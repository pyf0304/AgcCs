
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectBL
 表名:CMProject(00050512)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsCMProjectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectEN GetObj(this K_CmPrjId_CMProject myKey)
{
clsCMProjectEN objCMProjectEN = clsCMProjectBL.CMProjectDA.GetObjByCmPrjId(myKey.Value);
return objCMProjectEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectEN) == false)
{
var strMsg = string.Format("记录已经存在!CM工程名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsCMProjectBL.AddNewRecord)", objCMProjectEN.CmPrjName,objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
bool bolResult = clsCMProjectBL.CMProjectDA.AddNewRecordBySQL2(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
public static bool AddRecordEx(this clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCMProjectEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMProjectEN.CheckUniqueness() == false)
{
strMsg = string.Format("(CM工程名(CmPrjName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objCMProjectEN.CmPrjName, objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCMProjectEN.AddNewRecord();
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectEN) == false)
{
var strMsg = string.Format("记录已经存在!CM工程名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsCMProjectBL.AddNewRecordWithMaxId)", objCMProjectEN.CmPrjName,objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
string strCmPrjId = clsCMProjectBL.CMProjectDA.AddNewRecordBySQL2WithReturnKey(objCMProjectEN);
     objCMProjectEN.CmPrjId = strCmPrjId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
}
return strCmPrjId;
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectEN) == false)
{
var strMsg = string.Format("记录已经存在!CM工程名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsCMProjectBL.AddNewRecordWithReturnKey)", objCMProjectEN.CmPrjName,objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
string strKey = clsCMProjectBL.CMProjectDA.AddNewRecordBySQL2WithReturnKey(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetCmPrjId(this clsCMProjectEN objCMProjectEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProject.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProject.CmPrjId);
}
objCMProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.CmPrjId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.CmPrjId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.CmPrjId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetCmPrjName(this clsCMProjectEN objCMProjectEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjName, conCMProject.CmPrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, conCMProject.CmPrjName);
}
objCMProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.CmPrjName) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.CmPrjName, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.CmPrjName] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetPrjId(this clsCMProjectEN objCMProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMProject.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMProject.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMProject.PrjId);
}
objCMProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.PrjId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.PrjId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.PrjId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetApplicationTypeId(this clsCMProjectEN objCMProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMProject.ApplicationTypeId);
objCMProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.ApplicationTypeId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.ApplicationTypeId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.ApplicationTypeId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetFunctionTemplateId(this clsCMProjectEN objCMProjectEN, string strFunctionTemplateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, conCMProject.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, conCMProject.FunctionTemplateId);
}
objCMProjectEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.FunctionTemplateId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.FunctionTemplateId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.FunctionTemplateId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetVueDesignSysId(this clsCMProjectEN objCMProjectEN, string strVueDesignSysId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVueDesignSysId, 2, conCMProject.VueDesignSysId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVueDesignSysId, 2, conCMProject.VueDesignSysId);
}
objCMProjectEN.VueDesignSysId = strVueDesignSysId; //Vue控件设计体系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.VueDesignSysId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.VueDesignSysId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.VueDesignSysId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsFstLcase(this clsCMProjectEN objCMProjectEN, bool bolIsFstLcase, string strComparisonOp="")
	{
objCMProjectEN.IsFstLcase = bolIsFstLcase; //是否首字母小写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsFstLcase) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsFstLcase, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsFstLcase] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsCamelCase(this clsCMProjectEN objCMProjectEN, bool bolIsCamelCase, string strComparisonOp="")
	{
objCMProjectEN.IsCamelCase = bolIsCamelCase; //是否使用CamelCase
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsCamelCase) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsCamelCase, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsCamelCase] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetProjectFileName(this clsCMProjectEN objCMProjectEN, string strProjectFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, conCMProject.ProjectFileName);
}
objCMProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.ProjectFileName) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.ProjectFileName, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.ProjectFileName] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUseStateId(this clsCMProjectEN objCMProjectEN, string strUseStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conCMProject.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conCMProject.UseStateId);
}
objCMProjectEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UseStateId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UseStateId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UseStateId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsRefresh4RelaView(this clsCMProjectEN objCMProjectEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objCMProjectEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsRefresh4RelaView) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsRefresh4RelaView, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsRefresh4RelaView] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUpdDate(this clsCMProjectEN objCMProjectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProject.UpdDate);
}
objCMProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UpdDate) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UpdDate, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UpdDate] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUpdUserId(this clsCMProjectEN objCMProjectEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCMProject.UpdUserId);
}
objCMProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UpdUserId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UpdUserId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UpdUserId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetMemo(this clsCMProjectEN objCMProjectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProject.Memo);
}
objCMProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.Memo) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.Memo, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.Memo] = strComparisonOp;
}
}
return objCMProjectEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMProjectEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMProjectEN objCMProjectEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMProjectEN.CheckPropertyNew();
clsCMProjectEN objCMProjectCond = new clsCMProjectEN();
string strCondition = objCMProjectCond
.SetCmPrjId(objCMProjectEN.CmPrjId, "<>")
.SetCmPrjName(objCMProjectEN.CmPrjName, "=")
.SetPrjId(objCMProjectEN.PrjId, "=")
.GetCombineCondition();
objCMProjectEN._IsCheckProperty = true;
bool bolIsExist = clsCMProjectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CMPrjName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMProjectEN.Update();
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
 /// <param name = "objCMProject">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMProjectEN objCMProject)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMProjectEN objCMProjectCond = new clsCMProjectEN();
string strCondition = objCMProjectCond
.SetCmPrjName(objCMProject.CmPrjName, "=")
.SetPrjId(objCMProject.PrjId, "=")
.GetCombineCondition();
objCMProject._IsCheckProperty = true;
bool bolIsExist = clsCMProjectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMProject.CmPrjId = clsCMProjectBL.GetFirstID_S(strCondition);
objCMProject.UpdateWithCondition(strCondition);
}
else
{
objCMProject.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
objCMProject.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectEN objCMProjectEN)
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectBL.CMProjectDA.UpdateBySql2(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectEN objCMProjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectBL.CMProjectDA.UpdateBySql2(objCMProjectEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectEN objCMProjectEN, string strWhereCond)
{
try
{
bool bolResult = clsCMProjectBL.CMProjectDA.UpdateBySqlWithCondition(objCMProjectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectEN objCMProjectEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMProjectBL.CMProjectDA.UpdateBySqlWithConditionTransaction(objCMProjectEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMProjectEN objCMProjectEN)
{
try
{
int intRecNum = clsCMProjectBL.CMProjectDA.DelRecord(objCMProjectEN.CmPrjId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectENS">源对象</param>
 /// <param name = "objCMProjectENT">目标对象</param>
 public static void CopyTo(this clsCMProjectEN objCMProjectENS, clsCMProjectEN objCMProjectENT)
{
try
{
objCMProjectENT.CmPrjId = objCMProjectENS.CmPrjId; //Cm工程Id
objCMProjectENT.CmPrjName = objCMProjectENS.CmPrjName; //CM工程名
objCMProjectENT.PrjId = objCMProjectENS.PrjId; //工程Id
objCMProjectENT.ApplicationTypeId = objCMProjectENS.ApplicationTypeId; //应用程序类型ID
objCMProjectENT.FunctionTemplateId = objCMProjectENS.FunctionTemplateId; //函数模板Id
objCMProjectENT.VueDesignSysId = objCMProjectENS.VueDesignSysId; //Vue控件设计体系Id
objCMProjectENT.IsFstLcase = objCMProjectENS.IsFstLcase; //是否首字母小写
objCMProjectENT.IsCamelCase = objCMProjectENS.IsCamelCase; //是否使用CamelCase
objCMProjectENT.ProjectFileName = objCMProjectENS.ProjectFileName; //工程文件名
objCMProjectENT.UseStateId = objCMProjectENS.UseStateId; //使用状态Id
objCMProjectENT.IsRefresh4RelaView = objCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objCMProjectENT.UpdDate = objCMProjectENS.UpdDate; //修改日期
objCMProjectENT.UpdUserId = objCMProjectENS.UpdUserId; //修改用户Id
objCMProjectENT.Memo = objCMProjectENS.Memo; //说明
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
 /// <param name = "objCMProjectENS">源对象</param>
 /// <returns>目标对象=>clsCMProjectEN:objCMProjectENT</returns>
 public static clsCMProjectEN CopyTo(this clsCMProjectEN objCMProjectENS)
{
try
{
 clsCMProjectEN objCMProjectENT = new clsCMProjectEN()
{
CmPrjId = objCMProjectENS.CmPrjId, //Cm工程Id
CmPrjName = objCMProjectENS.CmPrjName, //CM工程名
PrjId = objCMProjectENS.PrjId, //工程Id
ApplicationTypeId = objCMProjectENS.ApplicationTypeId, //应用程序类型ID
FunctionTemplateId = objCMProjectENS.FunctionTemplateId, //函数模板Id
VueDesignSysId = objCMProjectENS.VueDesignSysId, //Vue控件设计体系Id
IsFstLcase = objCMProjectENS.IsFstLcase, //是否首字母小写
IsCamelCase = objCMProjectENS.IsCamelCase, //是否使用CamelCase
ProjectFileName = objCMProjectENS.ProjectFileName, //工程文件名
UseStateId = objCMProjectENS.UseStateId, //使用状态Id
IsRefresh4RelaView = objCMProjectENS.IsRefresh4RelaView, //是否刷新相关视图
UpdDate = objCMProjectENS.UpdDate, //修改日期
UpdUserId = objCMProjectENS.UpdUserId, //修改用户Id
Memo = objCMProjectENS.Memo, //说明
};
 return objCMProjectENT;
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
public static void CheckPropertyNew(this clsCMProjectEN objCMProjectEN)
{
 clsCMProjectBL.CMProjectDA.CheckPropertyNew(objCMProjectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMProjectEN objCMProjectEN)
{
 clsCMProjectBL.CMProjectDA.CheckProperty4Condition(objCMProjectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectEN objCMProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectCond.IsUpdated(conCMProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectCond.dicFldComparisonOp[conCMProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.CmPrjId, objCMProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectCond.IsUpdated(conCMProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objCMProjectCond.dicFldComparisonOp[conCMProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.CmPrjName, objCMProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objCMProjectCond.IsUpdated(conCMProject.PrjId) == true)
{
string strComparisonOpPrjId = objCMProjectCond.dicFldComparisonOp[conCMProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.PrjId, objCMProjectCond.PrjId, strComparisonOpPrjId);
}
if (objCMProjectCond.IsUpdated(conCMProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMProjectCond.dicFldComparisonOp[conCMProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProject.ApplicationTypeId, objCMProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMProjectCond.IsUpdated(conCMProject.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objCMProjectCond.dicFldComparisonOp[conCMProject.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.FunctionTemplateId, objCMProjectCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objCMProjectCond.IsUpdated(conCMProject.VueDesignSysId) == true)
{
string strComparisonOpVueDesignSysId = objCMProjectCond.dicFldComparisonOp[conCMProject.VueDesignSysId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.VueDesignSysId, objCMProjectCond.VueDesignSysId, strComparisonOpVueDesignSysId);
}
if (objCMProjectCond.IsUpdated(conCMProject.IsFstLcase) == true)
{
if (objCMProjectCond.IsFstLcase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsFstLcase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsFstLcase);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.IsCamelCase) == true)
{
if (objCMProjectCond.IsCamelCase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsCamelCase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsCamelCase);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objCMProjectCond.dicFldComparisonOp[conCMProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.ProjectFileName, objCMProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objCMProjectCond.IsUpdated(conCMProject.UseStateId) == true)
{
string strComparisonOpUseStateId = objCMProjectCond.dicFldComparisonOp[conCMProject.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UseStateId, objCMProjectCond.UseStateId, strComparisonOpUseStateId);
}
if (objCMProjectCond.IsUpdated(conCMProject.IsRefresh4RelaView) == true)
{
if (objCMProjectCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsRefresh4RelaView);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectCond.dicFldComparisonOp[conCMProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UpdDate, objCMProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectCond.IsUpdated(conCMProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCMProjectCond.dicFldComparisonOp[conCMProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UpdUserId, objCMProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCMProjectCond.IsUpdated(conCMProject.Memo) == true)
{
string strComparisonOpMemo = objCMProjectCond.dicFldComparisonOp[conCMProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.Memo, objCMProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMProject(CM项目), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMPrjName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMProjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMProjectEN objCMProjectEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectEN == null) return true;
if (objCMProjectEN.CmPrjId == null || objCMProjectEN.CmPrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
if (clsCMProjectBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmPrjId !=  '{0}'", objCMProjectEN.CmPrjId);
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
if (clsCMProjectBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMProject(CM项目), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMPrjName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMProjectEN objCMProjectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectEN == null) return "";
if (objCMProjectEN.CmPrjId == null || objCMProjectEN.CmPrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmPrjId !=  '{0}'", objCMProjectEN.CmPrjId);
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMProject
{
public virtual bool UpdRelaTabDate(string strCmPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM项目(CMProject)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectBL
{
public static RelatedActions_CMProject relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMProjectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMProjectDA CMProjectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMProjectDA();
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
 public clsCMProjectBL()
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
if (string.IsNullOrEmpty(clsCMProjectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMProjectEN._ConnectString);
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
public static DataTable GetDataTable_CMProject(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMProjectDA.GetDataTable_CMProject(strWhereCond);
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
objDT = CMProjectDA.GetDataTable(strWhereCond);
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
objDT = CMProjectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMProjectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMProjectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMProjectDA.GetDataTable_Top(objTopPara);
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
objDT = CMProjectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMProjectEN> GetObjLstByCmPrjIdLst(List<string> arrCmPrjIdLst)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmPrjIdLst, true);
 string strWhereCond = string.Format("CmPrjId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMProjectEN> GetObjLstByCmPrjIdLstCache(List<string> arrCmPrjIdLst)
{
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel =
arrCMProjectObjLstCache
.Where(x => arrCmPrjIdLst.Contains(x.CmPrjId));
return arrCMProjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectEN> GetObjLst(string strWhereCond)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
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
public static List<clsCMProjectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMProjectEN> GetSubObjLstCache(clsCMProjectEN objCMProjectCond)
{
List<clsCMProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProject._AttributeName)
{
if (objCMProjectCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectCond[strFldName].ToString());
}
else
{
if (objCMProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectCond[strFldName]));
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
public static List<clsCMProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
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
public static List<clsCMProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
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
List<clsCMProjectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMProjectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
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
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
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
public static List<clsCMProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
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
public static List<clsCMProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMProjectEN> arrObjLst = new List<clsCMProjectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectEN objCMProjectEN = new clsCMProjectEN();
try
{
objCMProjectEN.CmPrjId = objRow[conCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectEN.CmPrjName = objRow[conCMProject.CmPrjName].ToString().Trim(); //CM工程名
objCMProjectEN.PrjId = objRow[conCMProject.PrjId].ToString().Trim(); //工程Id
objCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[conCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectEN.FunctionTemplateId = objRow[conCMProject.FunctionTemplateId] == DBNull.Value ? null : objRow[conCMProject.FunctionTemplateId].ToString().Trim(); //函数模板Id
objCMProjectEN.VueDesignSysId = objRow[conCMProject.VueDesignSysId] == DBNull.Value ? null : objRow[conCMProject.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objCMProjectEN.IsFstLcase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsFstLcase].ToString().Trim()); //是否首字母小写
objCMProjectEN.IsCamelCase = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsCamelCase].ToString().Trim()); //是否使用CamelCase
objCMProjectEN.ProjectFileName = objRow[conCMProject.ProjectFileName] == DBNull.Value ? null : objRow[conCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objCMProjectEN.UseStateId = objRow[conCMProject.UseStateId] == DBNull.Value ? null : objRow[conCMProject.UseStateId].ToString().Trim(); //使用状态Id
objCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objCMProjectEN.UpdDate = objRow[conCMProject.UpdDate] == DBNull.Value ? null : objRow[conCMProject.UpdDate].ToString().Trim(); //修改日期
objCMProjectEN.UpdUserId = objRow[conCMProject.UpdUserId] == DBNull.Value ? null : objRow[conCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objCMProjectEN.Memo = objRow[conCMProject.Memo] == DBNull.Value ? null : objRow[conCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMProjectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMProject(ref clsCMProjectEN objCMProjectEN)
{
bool bolResult = CMProjectDA.GetCMProject(ref objCMProjectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
if (strCmPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMProjectEN objCMProjectEN = CMProjectDA.GetObjByCmPrjId(strCmPrjId);
return objCMProjectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMProjectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMProjectEN objCMProjectEN = CMProjectDA.GetFirstObj(strWhereCond);
 return objCMProjectEN;
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
public static clsCMProjectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMProjectEN objCMProjectEN = CMProjectDA.GetObjByDataRow(objRow);
 return objCMProjectEN;
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
public static clsCMProjectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMProjectEN objCMProjectEN = CMProjectDA.GetObjByDataRow(objRow);
 return objCMProjectEN;
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
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <param name = "lstCMProjectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectEN GetObjByCmPrjIdFromList(string strCmPrjId, List<clsCMProjectEN> lstCMProjectObjLst)
{
foreach (clsCMProjectEN objCMProjectEN in lstCMProjectObjLst)
{
if (objCMProjectEN.CmPrjId == strCmPrjId)
{
return objCMProjectEN;
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
 string strMaxCmPrjId;
 try
 {
 strMaxCmPrjId = clsCMProjectDA.GetMaxStrId();
 return strMaxCmPrjId;
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
 string strCmPrjId;
 try
 {
 strCmPrjId = new clsCMProjectDA().GetFirstID(strWhereCond);
 return strCmPrjId;
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
 arrList = CMProjectDA.GetID(strWhereCond);
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
bool bolIsExist = CMProjectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmPrjId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMProjectDA.IsExist(strCmPrjId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmPrjId">Cm工程Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmPrjId, string strOpUser)
{
clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjId(strCmPrjId);
objCMProjectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMProjectEN.UpdUserId = strOpUser;
return clsCMProjectBL.UpdateBySql2(objCMProjectEN);
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
 bolIsExist = clsCMProjectDA.IsExistTable();
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
 bolIsExist = CMProjectDA.IsExistTable(strTabName);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CM工程名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsCMProjectBL.AddNewRecordBySql2)", objCMProjectEN.CmPrjName,objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
bool bolResult = CMProjectDA.AddNewRecordBySQL2(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMProjectEN objCMProjectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CM工程名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsCMProjectBL.AddNewRecordBySql2WithReturnKey)", objCMProjectEN.CmPrjName,objCMProjectEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectBL.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectBL.GetMaxStrId_S();
 }
string strKey = CMProjectDA.AddNewRecordBySQL2WithReturnKey(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMProjectEN objCMProjectEN)
{
try
{
bool bolResult = CMProjectDA.Update(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMProjectEN objCMProjectEN)
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMProjectDA.UpdateBySql2(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectBL.ReFreshCache();

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
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
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmPrjId)
{
try
{
 clsCMProjectEN objCMProjectEN = clsCMProjectBL.GetObjByCmPrjId(strCmPrjId);

if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(objCMProjectEN.CmPrjId, objCMProjectEN.UpdUserId);
}
if (objCMProjectEN != null)
{
int intRecNum = CMProjectDA.DelRecord(strCmPrjId);
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
/// <param name="strCmPrjId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmPrjId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectDA.GetSpecSQLObj();
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
//删除与表:[CMProject]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMProject.CmPrjId,
//strCmPrjId);
//        clsCMProjectBL.DelCMProjectsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectBL.DelRecord(strCmPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmPrjId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMProjectBL.relatedActions != null)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(strCmPrjId, "UpdRelaTabDate");
}
bool bolResult = CMProjectDA.DelRecord(strCmPrjId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmPrjIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMProjects(List<string> arrCmPrjIdLst)
{
if (arrCmPrjIdLst.Count == 0) return 0;
try
{
if (clsCMProjectBL.relatedActions != null)
{
foreach (var strCmPrjId in arrCmPrjIdLst)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(strCmPrjId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMProjectDA.DelCMProject(arrCmPrjIdLst);
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
public static int DelCMProjectsByCond(string strWhereCond)
{
try
{
if (clsCMProjectBL.relatedActions != null)
{
List<string> arrCmPrjId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmPrjId in arrCmPrjId)
{
clsCMProjectBL.relatedActions.UpdRelaTabDate(strCmPrjId, "UpdRelaTabDate");
}
}
int intRecNum = CMProjectDA.DelCMProject(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMProject]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmPrjId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectDA.GetSpecSQLObj();
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
//删除与表:[CMProject]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectBL.DelRecord(strCmPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmPrjId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMProjectENS">源对象</param>
 /// <param name = "objCMProjectENT">目标对象</param>
 public static void CopyTo(clsCMProjectEN objCMProjectENS, clsCMProjectEN objCMProjectENT)
{
try
{
objCMProjectENT.CmPrjId = objCMProjectENS.CmPrjId; //Cm工程Id
objCMProjectENT.CmPrjName = objCMProjectENS.CmPrjName; //CM工程名
objCMProjectENT.PrjId = objCMProjectENS.PrjId; //工程Id
objCMProjectENT.ApplicationTypeId = objCMProjectENS.ApplicationTypeId; //应用程序类型ID
objCMProjectENT.FunctionTemplateId = objCMProjectENS.FunctionTemplateId; //函数模板Id
objCMProjectENT.VueDesignSysId = objCMProjectENS.VueDesignSysId; //Vue控件设计体系Id
objCMProjectENT.IsFstLcase = objCMProjectENS.IsFstLcase; //是否首字母小写
objCMProjectENT.IsCamelCase = objCMProjectENS.IsCamelCase; //是否使用CamelCase
objCMProjectENT.ProjectFileName = objCMProjectENS.ProjectFileName; //工程文件名
objCMProjectENT.UseStateId = objCMProjectENS.UseStateId; //使用状态Id
objCMProjectENT.IsRefresh4RelaView = objCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objCMProjectENT.UpdDate = objCMProjectENS.UpdDate; //修改日期
objCMProjectENT.UpdUserId = objCMProjectENS.UpdUserId; //修改用户Id
objCMProjectENT.Memo = objCMProjectENS.Memo; //说明
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
 /// <param name = "objCMProjectEN">源简化对象</param>
 public static void SetUpdFlag(clsCMProjectEN objCMProjectEN)
{
try
{
objCMProjectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMProjectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMProject.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.CmPrjId = objCMProjectEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conCMProject.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.CmPrjName = objCMProjectEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(conCMProject.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.PrjId = objCMProjectEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMProject.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.ApplicationTypeId = objCMProjectEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conCMProject.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.FunctionTemplateId = objCMProjectEN.FunctionTemplateId == "[null]" ? null :  objCMProjectEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(conCMProject.VueDesignSysId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.VueDesignSysId = objCMProjectEN.VueDesignSysId == "[null]" ? null :  objCMProjectEN.VueDesignSysId; //Vue控件设计体系Id
}
if (arrFldSet.Contains(conCMProject.IsFstLcase, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.IsFstLcase = objCMProjectEN.IsFstLcase; //是否首字母小写
}
if (arrFldSet.Contains(conCMProject.IsCamelCase, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.IsCamelCase = objCMProjectEN.IsCamelCase; //是否使用CamelCase
}
if (arrFldSet.Contains(conCMProject.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.ProjectFileName = objCMProjectEN.ProjectFileName == "[null]" ? null :  objCMProjectEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(conCMProject.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.UseStateId = objCMProjectEN.UseStateId == "[null]" ? null :  objCMProjectEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(conCMProject.IsRefresh4RelaView, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.IsRefresh4RelaView = objCMProjectEN.IsRefresh4RelaView; //是否刷新相关视图
}
if (arrFldSet.Contains(conCMProject.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.UpdDate = objCMProjectEN.UpdDate == "[null]" ? null :  objCMProjectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMProject.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.UpdUserId = objCMProjectEN.UpdUserId == "[null]" ? null :  objCMProjectEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCMProject.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectEN.Memo = objCMProjectEN.Memo == "[null]" ? null :  objCMProjectEN.Memo; //说明
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
 /// <param name = "objCMProjectEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMProjectEN objCMProjectEN)
{
try
{
if (objCMProjectEN.FunctionTemplateId == "[null]") objCMProjectEN.FunctionTemplateId = null; //函数模板Id
if (objCMProjectEN.VueDesignSysId == "[null]") objCMProjectEN.VueDesignSysId = null; //Vue控件设计体系Id
if (objCMProjectEN.ProjectFileName == "[null]") objCMProjectEN.ProjectFileName = null; //工程文件名
if (objCMProjectEN.UseStateId == "[null]") objCMProjectEN.UseStateId = null; //使用状态Id
if (objCMProjectEN.UpdDate == "[null]") objCMProjectEN.UpdDate = null; //修改日期
if (objCMProjectEN.UpdUserId == "[null]") objCMProjectEN.UpdUserId = null; //修改用户Id
if (objCMProjectEN.Memo == "[null]") objCMProjectEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMProjectEN objCMProjectEN)
{
 CMProjectDA.CheckPropertyNew(objCMProjectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMProjectEN objCMProjectEN)
{
 CMProjectDA.CheckProperty4Condition(objCMProjectEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_CmPrjId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId); 
List<clsCMProjectEN> arrObjLst = clsCMProjectBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMProjectEN objCMProjectEN = new clsCMProjectEN()
{
CmPrjId = "0",
CmPrjName = "选[CM项目]..."
};
arrObjLstSel.Insert(0, objCMProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMProject.CmPrjId;
objComboBox.DisplayMember = conCMProject.CmPrjName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_CmPrjId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM项目]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId); 
IEnumerable<clsCMProjectEN> arrObjLst = clsCMProjectBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conCMProject.CmPrjId;
objDDL.DataTextField = conCMProject.CmPrjName;
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
public static void BindDdl_CmPrjIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM项目]...","0");
List<clsCMProjectEN> arrCMProjectObjLst = GetAllCMProjectObjLstCache(); 
objDDL.DataValueField = conCMProject.CmPrjId;
objDDL.DataTextField = conCMProject.CmPrjName;
objDDL.DataSource = arrCMProjectObjLst;
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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmPrjId");
//if (arrCMProjectObjLstCache == null)
//{
//arrCMProjectObjLstCache = CMProjectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectEN GetObjByCmPrjIdCache(string strCmPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel =
arrCMProjectObjLstCache
.Where(x=> x.CmPrjId == strCmPrjId 
);
if (arrCMProjectObjLst_Sel.Count() == 0)
{
   clsCMProjectEN obj = clsCMProjectBL.GetObjByCmPrjId(strCmPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMProjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCmPrjNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//获取缓存中的对象列表
clsCMProjectEN objCMProject = GetObjByCmPrjIdCache(strCmPrjId);
if (objCMProject == null) return "";
return objCMProject.CmPrjName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//获取缓存中的对象列表
clsCMProjectEN objCMProject = GetObjByCmPrjIdCache(strCmPrjId);
if (objCMProject == null) return "";
return objCMProject.CmPrjName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectEN> GetAllCMProjectObjLstCache()
{
//获取缓存中的对象列表
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache(); 
return arrCMProjectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
List<clsCMProjectEN> arrCMProjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMProjectObjLstCache;
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
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMProjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMProjectEN._RefreshTimeLst.Count == 0) return "";
return clsCMProjectEN._RefreshTimeLst[clsCMProjectEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCMProjectBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMProjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMProjectBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMProject(CM项目)
 /// 唯一性条件:CMPrjName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMProjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMProjectEN objCMProjectEN)
{
//检测记录是否存在
string strResult = CMProjectDA.GetUniCondStr(objCMProjectEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCmPrjId)
{
if (strInFldName != conCMProject.CmPrjId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMProject._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMProject._AttributeName));
throw new Exception(strMsg);
}
var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
if (objCMProject == null) return "";
return objCMProject[strOutFldName].ToString();
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
int intRecCount = clsCMProjectDA.GetRecCount(strTabName);
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
int intRecCount = clsCMProjectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMProjectDA.GetRecCount();
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
int intRecCount = clsCMProjectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMProjectEN objCMProjectCond)
{
List<clsCMProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProject._AttributeName)
{
if (objCMProjectCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectCond[strFldName].ToString());
}
else
{
if (objCMProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectCond[strFldName]));
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
 List<string> arrList = clsCMProjectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMProjectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMProjectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMProjectDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectDA.SetFldValue(clsCMProjectEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMProjectDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMProject] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) primary key, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**函数模板Id*/ 
 strCreateTabCode.Append(" FunctionTemplateId char(4) Null, "); 
 // /**Vue控件设计体系Id*/ 
 strCreateTabCode.Append(" VueDesignSysId char(2) Null, "); 
 // /**是否首字母小写*/ 
 strCreateTabCode.Append(" IsFstLcase bit Null, "); 
 // /**是否使用CamelCase*/ 
 strCreateTabCode.Append(" IsCamelCase bit Null, "); 
 // /**工程文件名*/ 
 strCreateTabCode.Append(" ProjectFileName varchar(200) Null, "); 
 // /**使用状态Id*/ 
 strCreateTabCode.Append(" UseStateId char(4) Null, "); 
 // /**是否刷新相关视图*/ 
 strCreateTabCode.Append(" IsRefresh4RelaView bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**使用状态名称*/ 
 strCreateTabCode.Append(" UseStateName varchar(30) Null, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) Null, "); 
 // /**应用类型名列表*/ 
 strCreateTabCode.Append(" ApplicationTypeNameLst varchar(50) Null, "); 
 // /**函数模板名*/ 
 strCreateTabCode.Append(" FunctionTemplateName varchar(50) not Null, "); 
 // /**Vue控件设计体系名称*/ 
 strCreateTabCode.Append(" VueDesignSysName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CM项目(CMProject)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMProject : clsCommFun4BL
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
clsCMProjectBL.ReFreshThisCache();
}
}

}