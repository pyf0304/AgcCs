
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassBL
 表名:CMClass(00050501)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:47
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
public static class  clsCMClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMClassEN GetObj(this K_CmClassId_CMClass myKey)
{
clsCMClassEN objCMClassEN = clsCMClassBL.CMClassDA.GetObjByCmClassId(myKey.Value);
return objCMClassEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMClassEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],域名 = [{1}],类名 = [{2}],文件名 = [{3}],用户Id = [{4}],工程Id = [{5}],编程语言类型Id = [{6}]的数据已经存在!(in clsCMClassBL.AddNewRecord)", objCMClassEN.TabName,objCMClassEN.NameSpace,objCMClassEN.ClsName,objCMClassEN.FileName,objCMClassEN.UserId,objCMClassEN.PrjId,objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
bool bolResult = clsCMClassBL.CMClassDA.AddNewRecordBySQL2(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
public static bool AddRecordEx(this clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCMClassBL.IsExist(objCMClassEN.CmClassId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCMClassEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMClassEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表名(TabName)=[{0}],域名(NameSpace)=[{1}],类名(ClsName)=[{2}],文件名(FileName)=[{3}],用户Id(UserId)=[{4}],工程Id(PrjId)=[{5}],编程语言类型Id(ProgLangTypeId)=[{6}])已经存在,不能重复!", objCMClassEN.TabName, objCMClassEN.NameSpace, objCMClassEN.ClsName, objCMClassEN.FileName, objCMClassEN.UserId, objCMClassEN.PrjId, objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCMClassEN.AddNewRecord();
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMClassEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],域名 = [{1}],类名 = [{2}],文件名 = [{3}],用户Id = [{4}],工程Id = [{5}],编程语言类型Id = [{6}]的数据已经存在!(in clsCMClassBL.AddNewRecordWithMaxId)", objCMClassEN.TabName,objCMClassEN.NameSpace,objCMClassEN.ClsName,objCMClassEN.FileName,objCMClassEN.UserId,objCMClassEN.PrjId,objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
string strCmClassId = clsCMClassBL.CMClassDA.AddNewRecordBySQL2WithReturnKey(objCMClassEN);
     objCMClassEN.CmClassId = strCmClassId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
}
return strCmClassId;
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMClassEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],域名 = [{1}],类名 = [{2}],文件名 = [{3}],用户Id = [{4}],工程Id = [{5}],编程语言类型Id = [{6}]的数据已经存在!(in clsCMClassBL.AddNewRecordWithReturnKey)", objCMClassEN.TabName,objCMClassEN.NameSpace,objCMClassEN.ClsName,objCMClassEN.FileName,objCMClassEN.UserId,objCMClassEN.PrjId,objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
string strKey = clsCMClassBL.CMClassDA.AddNewRecordBySQL2WithReturnKey(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetCmClassId(this clsCMClassEN objCMClassEN, string strCmClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, conCMClass.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, conCMClass.CmClassId);
}
objCMClassEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.CmClassId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.CmClassId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.CmClassId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetApplicationTypeId(this clsCMClassEN objCMClassEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMClass.ApplicationTypeId);
objCMClassEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ApplicationTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ApplicationTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ApplicationTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetProgLangTypeId(this clsCMClassEN objCMClassEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conCMClass.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conCMClass.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conCMClass.ProgLangTypeId);
}
objCMClassEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ProgLangTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ProgLangTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ProgLangTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetTabName(this clsCMClassEN objCMClassEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conCMClass.TabName);
}
objCMClassEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.TabName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.TabName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.TabName] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetNameSpace(this clsCMClassEN objCMClassEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, conCMClass.NameSpace);
}
objCMClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.NameSpace) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.NameSpace, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.NameSpace] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetProjectPath(this clsCMClassEN objCMClassEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, conCMClass.ProjectPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, conCMClass.ProjectPath);
}
objCMClassEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ProjectPath) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ProjectPath, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ProjectPath] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFilePath(this clsCMClassEN objCMClassEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conCMClass.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conCMClass.FilePath);
}
objCMClassEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FilePath) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FilePath, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FilePath] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFileName(this clsCMClassEN objCMClassEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conCMClass.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conCMClass.FileName);
}
objCMClassEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FileName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FileName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FileName] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFileText(this clsCMClassEN objCMClassEN, string strFileText, string strComparisonOp="")
	{
objCMClassEN.FileText = strFileText; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FileText) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FileText, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FileText] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFuncModuleAgcId(this clsCMClassEN objCMClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
}
objCMClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FuncModuleAgcId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetCodeTypeId(this clsCMClassEN objCMClassEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conCMClass.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCMClass.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCMClass.CodeTypeId);
}
objCMClassEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.CodeTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.CodeTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.CodeTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUserId(this clsCMClassEN objCMClassEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conCMClass.UserId);
}
objCMClassEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UserId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UserId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UserId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetPrjId(this clsCMClassEN objCMClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMClass.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMClass.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMClass.PrjId);
}
objCMClassEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.PrjId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.PrjId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.PrjId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetIsOpen(this clsCMClassEN objCMClassEN, bool bolIsOpen, string strComparisonOp="")
	{
objCMClassEN.IsOpen = bolIsOpen; //是否开放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.IsOpen) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.IsOpen, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.IsOpen] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUpdDate(this clsCMClassEN objCMClassEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMClass.UpdDate);
}
objCMClassEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UpdDate) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UpdDate, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UpdDate] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUpdUser(this clsCMClassEN objCMClassEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMClass.UpdUser);
}
objCMClassEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UpdUser) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UpdUser, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UpdUser] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetMemo(this clsCMClassEN objCMClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMClass.Memo);
}
objCMClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.Memo) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.Memo, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.Memo] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetClsName(this clsCMClassEN objCMClassEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, conCMClass.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conCMClass.ClsName);
}
objCMClassEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ClsName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ClsName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ClsName] = strComparisonOp;
}
}
return objCMClassEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMClassEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMClassEN objCMClassEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMClassEN.CheckPropertyNew();
clsCMClassEN objCMClassCond = new clsCMClassEN();
string strCondition = objCMClassCond
.SetCmClassId(objCMClassEN.CmClassId, "<>")
.SetTabName(objCMClassEN.TabName, "=")
.SetNameSpace(objCMClassEN.NameSpace, "=")
.SetClsName(objCMClassEN.ClsName, "=")
.SetFileName(objCMClassEN.FileName, "=")
.SetUserId(objCMClassEN.UserId, "=")
.SetPrjId(objCMClassEN.PrjId, "=")
.SetProgLangTypeId(objCMClassEN.ProgLangTypeId, "=")
.GetCombineCondition();
objCMClassEN._IsCheckProperty = true;
bool bolIsExist = clsCMClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabName_NameSpace_ClsName_FileName_UserId_PrjId_ProgLangTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMClassEN.Update();
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
 /// <param name = "objCMClass">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMClassEN objCMClass)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMClassEN objCMClassCond = new clsCMClassEN();
string strCondition = objCMClassCond
.SetTabName(objCMClass.TabName, "=")
.SetNameSpace(objCMClass.NameSpace, "=")
.SetClsName(objCMClass.ClsName, "=")
.SetFileName(objCMClass.FileName, "=")
.SetUserId(objCMClass.UserId, "=")
.SetPrjId(objCMClass.PrjId, "=")
.SetProgLangTypeId(objCMClass.ProgLangTypeId, "=")
.GetCombineCondition();
objCMClass._IsCheckProperty = true;
bool bolIsExist = clsCMClassBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMClass.CmClassId = clsCMClassBL.GetFirstID_S(strCondition);
objCMClass.UpdateWithCondition(strCondition);
}
else
{
objCMClass.CmClassId = clsCMClassBL.GetMaxStrId_S();
objCMClass.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMClassEN objCMClassEN)
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMClassBL.CMClassDA.UpdateBySql2(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMClassEN objCMClassEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMClassBL.CMClassDA.UpdateBySql2(objCMClassEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMClassEN objCMClassEN, string strWhereCond)
{
try
{
bool bolResult = clsCMClassBL.CMClassDA.UpdateBySqlWithCondition(objCMClassEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMClassEN objCMClassEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMClassBL.CMClassDA.UpdateBySqlWithConditionTransaction(objCMClassEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMClassEN objCMClassEN)
{
try
{
int intRecNum = clsCMClassBL.CMClassDA.DelRecord(objCMClassEN.CmClassId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassENS">源对象</param>
 /// <param name = "objCMClassENT">目标对象</param>
 public static void CopyTo(this clsCMClassEN objCMClassENS, clsCMClassEN objCMClassENT)
{
try
{
objCMClassENT.CmClassId = objCMClassENS.CmClassId; //类Id
objCMClassENT.ApplicationTypeId = objCMClassENS.ApplicationTypeId; //应用程序类型ID
objCMClassENT.ProgLangTypeId = objCMClassENS.ProgLangTypeId; //编程语言类型Id
objCMClassENT.TabName = objCMClassENS.TabName; //表名
objCMClassENT.NameSpace = objCMClassENS.NameSpace; //域名
objCMClassENT.ProjectPath = objCMClassENS.ProjectPath; //工程路径
objCMClassENT.FilePath = objCMClassENS.FilePath; //文件路径
objCMClassENT.FileName = objCMClassENS.FileName; //文件名
objCMClassENT.FileText = objCMClassENS.FileText; //文件内容
objCMClassENT.FuncModuleAgcId = objCMClassENS.FuncModuleAgcId; //功能模块Id
objCMClassENT.CodeTypeId = objCMClassENS.CodeTypeId; //代码类型Id
objCMClassENT.UserId = objCMClassENS.UserId; //用户Id
objCMClassENT.PrjId = objCMClassENS.PrjId; //工程Id
objCMClassENT.IsOpen = objCMClassENS.IsOpen; //是否开放
objCMClassENT.UpdDate = objCMClassENS.UpdDate; //修改日期
objCMClassENT.UpdUser = objCMClassENS.UpdUser; //修改者
objCMClassENT.Memo = objCMClassENS.Memo; //说明
objCMClassENT.ClsName = objCMClassENS.ClsName; //类名
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
 /// <param name = "objCMClassENS">源对象</param>
 /// <returns>目标对象=>clsCMClassEN:objCMClassENT</returns>
 public static clsCMClassEN CopyTo(this clsCMClassEN objCMClassENS)
{
try
{
 clsCMClassEN objCMClassENT = new clsCMClassEN()
{
CmClassId = objCMClassENS.CmClassId, //类Id
ApplicationTypeId = objCMClassENS.ApplicationTypeId, //应用程序类型ID
ProgLangTypeId = objCMClassENS.ProgLangTypeId, //编程语言类型Id
TabName = objCMClassENS.TabName, //表名
NameSpace = objCMClassENS.NameSpace, //域名
ProjectPath = objCMClassENS.ProjectPath, //工程路径
FilePath = objCMClassENS.FilePath, //文件路径
FileName = objCMClassENS.FileName, //文件名
FileText = objCMClassENS.FileText, //文件内容
FuncModuleAgcId = objCMClassENS.FuncModuleAgcId, //功能模块Id
CodeTypeId = objCMClassENS.CodeTypeId, //代码类型Id
UserId = objCMClassENS.UserId, //用户Id
PrjId = objCMClassENS.PrjId, //工程Id
IsOpen = objCMClassENS.IsOpen, //是否开放
UpdDate = objCMClassENS.UpdDate, //修改日期
UpdUser = objCMClassENS.UpdUser, //修改者
Memo = objCMClassENS.Memo, //说明
ClsName = objCMClassENS.ClsName, //类名
};
 return objCMClassENT;
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
public static void CheckPropertyNew(this clsCMClassEN objCMClassEN)
{
 clsCMClassBL.CMClassDA.CheckPropertyNew(objCMClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMClassEN objCMClassEN)
{
 clsCMClassBL.CMClassDA.CheckProperty4Condition(objCMClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMClassEN objCMClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMClassCond.IsUpdated(conCMClass.CmClassId) == true)
{
string strComparisonOpCmClassId = objCMClassCond.dicFldComparisonOp[conCMClass.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.CmClassId, objCMClassCond.CmClassId, strComparisonOpCmClassId);
}
if (objCMClassCond.IsUpdated(conCMClass.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMClass.ApplicationTypeId, objCMClassCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ProgLangTypeId, objCMClassCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.TabName) == true)
{
string strComparisonOpTabName = objCMClassCond.dicFldComparisonOp[conCMClass.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.TabName, objCMClassCond.TabName, strComparisonOpTabName);
}
if (objCMClassCond.IsUpdated(conCMClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objCMClassCond.dicFldComparisonOp[conCMClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.NameSpace, objCMClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objCMClassCond.IsUpdated(conCMClass.ProjectPath) == true)
{
string strComparisonOpProjectPath = objCMClassCond.dicFldComparisonOp[conCMClass.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ProjectPath, objCMClassCond.ProjectPath, strComparisonOpProjectPath);
}
if (objCMClassCond.IsUpdated(conCMClass.FilePath) == true)
{
string strComparisonOpFilePath = objCMClassCond.dicFldComparisonOp[conCMClass.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FilePath, objCMClassCond.FilePath, strComparisonOpFilePath);
}
if (objCMClassCond.IsUpdated(conCMClass.FileName) == true)
{
string strComparisonOpFileName = objCMClassCond.dicFldComparisonOp[conCMClass.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FileName, objCMClassCond.FileName, strComparisonOpFileName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCMClassCond.IsUpdated(conCMClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMClassCond.dicFldComparisonOp[conCMClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FuncModuleAgcId, objCMClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMClassCond.IsUpdated(conCMClass.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.CodeTypeId, objCMClassCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.UserId) == true)
{
string strComparisonOpUserId = objCMClassCond.dicFldComparisonOp[conCMClass.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UserId, objCMClassCond.UserId, strComparisonOpUserId);
}
if (objCMClassCond.IsUpdated(conCMClass.PrjId) == true)
{
string strComparisonOpPrjId = objCMClassCond.dicFldComparisonOp[conCMClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.PrjId, objCMClassCond.PrjId, strComparisonOpPrjId);
}
if (objCMClassCond.IsUpdated(conCMClass.IsOpen) == true)
{
if (objCMClassCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMClass.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMClass.IsOpen);
}
}
if (objCMClassCond.IsUpdated(conCMClass.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMClassCond.dicFldComparisonOp[conCMClass.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UpdDate, objCMClassCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMClassCond.IsUpdated(conCMClass.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMClassCond.dicFldComparisonOp[conCMClass.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UpdUser, objCMClassCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMClassCond.IsUpdated(conCMClass.Memo) == true)
{
string strComparisonOpMemo = objCMClassCond.dicFldComparisonOp[conCMClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.Memo, objCMClassCond.Memo, strComparisonOpMemo);
}
if (objCMClassCond.IsUpdated(conCMClass.ClsName) == true)
{
string strComparisonOpClsName = objCMClassCond.dicFldComparisonOp[conCMClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ClsName, objCMClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMClass(CM类), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabName_NameSpace_ClsName_FileName_UserId_PrjId_ProgLangTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMClassEN objCMClassEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMClassEN == null) return true;
if (objCMClassEN.CmClassId == null || objCMClassEN.CmClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objCMClassEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null", objCMClassEN.TabName);
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
}
 if (objCMClassEN.NameSpace == null)
{
 sbCondition.AppendFormat(" and NameSpace is null", objCMClassEN.NameSpace);
}
else
{
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
}
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 if (objCMClassEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objCMClassEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
if (clsCMClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmClassId !=  '{0}'", objCMClassEN.CmClassId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
if (clsCMClassBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMClass(CM类), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_NameSpace_ClsName_FileName_UserId_PrjId_ProgLangTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMClassEN objCMClassEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMClassEN == null) return "";
if (objCMClassEN.CmClassId == null || objCMClassEN.CmClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objCMClassEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null", objCMClassEN.TabName);
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
}
 if (objCMClassEN.NameSpace == null)
{
 sbCondition.AppendFormat(" and NameSpace is null", objCMClassEN.NameSpace);
}
else
{
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
}
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 if (objCMClassEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objCMClassEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmClassId !=  '{0}'", objCMClassEN.CmClassId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMClass
{
public virtual bool UpdRelaTabDate(string strCmClassId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM类(CMClass)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMClassBL
{
public static RelatedActions_CMClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMClassDA CMClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMClassDA();
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
 public clsCMClassBL()
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
if (string.IsNullOrEmpty(clsCMClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMClassEN._ConnectString);
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
public static DataTable GetDataTable_CMClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMClassDA.GetDataTable_CMClass(strWhereCond);
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
objDT = CMClassDA.GetDataTable(strWhereCond);
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
objDT = CMClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMClassDA.GetDataTable_Top(objTopPara);
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
objDT = CMClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMClassEN> GetObjLstByCmClassIdLst(List<string> arrCmClassIdLst)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmClassIdLst, true);
 string strWhereCond = string.Format("CmClassId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMClassEN> GetObjLstByCmClassIdLstCache(List<string> arrCmClassIdLst)
{
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
List<clsCMClassEN> arrCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrCMClassObjLst_Sel =
arrCMClassObjLstCache
.Where(x => arrCmClassIdLst.Contains(x.CmClassId));
return arrCMClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetObjLst(string strWhereCond)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
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
public static List<clsCMClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMClassEN> GetSubObjLstCache(clsCMClassEN objCMClassCond)
{
List<clsCMClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMClass._AttributeName)
{
if (objCMClassCond.IsUpdated(strFldName) == false) continue;
if (objCMClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassCond[strFldName].ToString());
}
else
{
if (objCMClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMClassCond[strFldName]));
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
public static List<clsCMClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
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
public static List<clsCMClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
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
List<clsCMClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
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
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
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
public static List<clsCMClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
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
public static List<clsCMClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMClassEN> arrObjLst = new List<clsCMClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassEN objCMClassEN = new clsCMClassEN();
try
{
objCMClassEN.CmClassId = objRow[conCMClass.CmClassId].ToString().Trim(); //类Id
objCMClassEN.ApplicationTypeId = Int32.Parse(objRow[conCMClass.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMClassEN.ProgLangTypeId = objRow[conCMClass.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCMClassEN.TabName = objRow[conCMClass.TabName] == DBNull.Value ? null : objRow[conCMClass.TabName].ToString().Trim(); //表名
objCMClassEN.NameSpace = objRow[conCMClass.NameSpace] == DBNull.Value ? null : objRow[conCMClass.NameSpace].ToString().Trim(); //域名
objCMClassEN.ProjectPath = objRow[conCMClass.ProjectPath].ToString().Trim(); //工程路径
objCMClassEN.FilePath = objRow[conCMClass.FilePath].ToString().Trim(); //文件路径
objCMClassEN.FileName = objRow[conCMClass.FileName].ToString().Trim(); //文件名
objCMClassEN.FileText = objRow[conCMClass.FileText] == DBNull.Value ? null : objRow[conCMClass.FileText].ToString().Trim(); //文件内容
objCMClassEN.FuncModuleAgcId = objRow[conCMClass.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMClassEN.CodeTypeId = objRow[conCMClass.CodeTypeId].ToString().Trim(); //代码类型Id
objCMClassEN.UserId = objRow[conCMClass.UserId] == DBNull.Value ? null : objRow[conCMClass.UserId].ToString().Trim(); //用户Id
objCMClassEN.PrjId = objRow[conCMClass.PrjId].ToString().Trim(); //工程Id
objCMClassEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[conCMClass.IsOpen].ToString().Trim()); //是否开放
objCMClassEN.UpdDate = objRow[conCMClass.UpdDate] == DBNull.Value ? null : objRow[conCMClass.UpdDate].ToString().Trim(); //修改日期
objCMClassEN.UpdUser = objRow[conCMClass.UpdUser] == DBNull.Value ? null : objRow[conCMClass.UpdUser].ToString().Trim(); //修改者
objCMClassEN.Memo = objRow[conCMClass.Memo] == DBNull.Value ? null : objRow[conCMClass.Memo].ToString().Trim(); //说明
objCMClassEN.ClsName = objRow[conCMClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassEN.CmClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMClass(ref clsCMClassEN objCMClassEN)
{
bool bolResult = CMClassDA.GetCMClass(ref objCMClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMClassEN GetObjByCmClassId(string strCmClassId)
{
if (strCmClassId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmClassId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmClassId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmClassId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMClassEN objCMClassEN = CMClassDA.GetObjByCmClassId(strCmClassId);
return objCMClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMClassEN objCMClassEN = CMClassDA.GetFirstObj(strWhereCond);
 return objCMClassEN;
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
public static clsCMClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMClassEN objCMClassEN = CMClassDA.GetObjByDataRow(objRow);
 return objCMClassEN;
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
public static clsCMClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMClassEN objCMClassEN = CMClassDA.GetObjByDataRow(objRow);
 return objCMClassEN;
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
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <param name = "lstCMClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMClassEN GetObjByCmClassIdFromList(string strCmClassId, List<clsCMClassEN> lstCMClassObjLst)
{
foreach (clsCMClassEN objCMClassEN in lstCMClassObjLst)
{
if (objCMClassEN.CmClassId == strCmClassId)
{
return objCMClassEN;
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
 string strMaxCmClassId;
 try
 {
 strMaxCmClassId = clsCMClassDA.GetMaxStrId();
 return strMaxCmClassId;
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
 string strCmClassId;
 try
 {
 strCmClassId = new clsCMClassDA().GetFirstID(strWhereCond);
 return strCmClassId;
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
 arrList = CMClassDA.GetID(strWhereCond);
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
bool bolIsExist = CMClassDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmClassId)
{
if (string.IsNullOrEmpty(strCmClassId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmClassId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMClassDA.IsExist(strCmClassId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmClassId">类Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmClassId, string strOpUser)
{
clsCMClassEN objCMClassEN = clsCMClassBL.GetObjByCmClassId(strCmClassId);
objCMClassEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMClassEN.UpdUser = strOpUser;
return clsCMClassBL.UpdateBySql2(objCMClassEN);
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
 bolIsExist = clsCMClassDA.IsExistTable();
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
 bolIsExist = CMClassDA.IsExistTable(strTabName);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],域名 = [{1}],类名 = [{2}],文件名 = [{3}],用户Id = [{4}],工程Id = [{5}],编程语言类型Id = [{6}]的数据已经存在!(in clsCMClassBL.AddNewRecordBySql2)", objCMClassEN.TabName,objCMClassEN.NameSpace,objCMClassEN.ClsName,objCMClassEN.FileName,objCMClassEN.UserId,objCMClassEN.PrjId,objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
bool bolResult = CMClassDA.AddNewRecordBySQL2(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMClassEN objCMClassEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMClassEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],域名 = [{1}],类名 = [{2}],文件名 = [{3}],用户Id = [{4}],工程Id = [{5}],编程语言类型Id = [{6}]的数据已经存在!(in clsCMClassBL.AddNewRecordBySql2WithReturnKey)", objCMClassEN.TabName,objCMClassEN.NameSpace,objCMClassEN.ClsName,objCMClassEN.FileName,objCMClassEN.UserId,objCMClassEN.PrjId,objCMClassEN.ProgLangTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassBL.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassBL.GetMaxStrId_S();
 }
string strKey = CMClassDA.AddNewRecordBySQL2WithReturnKey(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMClassEN objCMClassEN)
{
try
{
bool bolResult = CMClassDA.Update(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMClassEN objCMClassEN)
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMClassDA.UpdateBySql2(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassBL.ReFreshCache();

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmClassId)
{
try
{
 clsCMClassEN objCMClassEN = clsCMClassBL.GetObjByCmClassId(strCmClassId);

if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(objCMClassEN.CmClassId, objCMClassEN.UpdUser);
}
if (objCMClassEN != null)
{
int intRecNum = CMClassDA.DelRecord(strCmClassId);
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
/// <param name="strCmClassId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmClassId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMClassDA.GetSpecSQLObj();
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
//删除与表:[CMClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMClass.CmClassId,
//strCmClassId);
//        clsCMClassBL.DelCMClasssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMClassBL.DelRecord(strCmClassId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMClassBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmClassId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmClassId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmClassId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMClassBL.relatedActions != null)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(strCmClassId, "UpdRelaTabDate");
}
bool bolResult = CMClassDA.DelRecord(strCmClassId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmClassIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMClasss(List<string> arrCmClassIdLst)
{
if (arrCmClassIdLst.Count == 0) return 0;
try
{
if (clsCMClassBL.relatedActions != null)
{
foreach (var strCmClassId in arrCmClassIdLst)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(strCmClassId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMClassDA.DelCMClass(arrCmClassIdLst);
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
public static int DelCMClasssByCond(string strWhereCond)
{
try
{
if (clsCMClassBL.relatedActions != null)
{
List<string> arrCmClassId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmClassId in arrCmClassId)
{
clsCMClassBL.relatedActions.UpdRelaTabDate(strCmClassId, "UpdRelaTabDate");
}
}
int intRecNum = CMClassDA.DelCMClass(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMClass]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmClassId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmClassId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMClassDA.GetSpecSQLObj();
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
//删除与表:[CMClass]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMClassBL.DelRecord(strCmClassId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMClassBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmClassId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMClassENS">源对象</param>
 /// <param name = "objCMClassENT">目标对象</param>
 public static void CopyTo(clsCMClassEN objCMClassENS, clsCMClassEN objCMClassENT)
{
try
{
objCMClassENT.CmClassId = objCMClassENS.CmClassId; //类Id
objCMClassENT.ApplicationTypeId = objCMClassENS.ApplicationTypeId; //应用程序类型ID
objCMClassENT.ProgLangTypeId = objCMClassENS.ProgLangTypeId; //编程语言类型Id
objCMClassENT.TabName = objCMClassENS.TabName; //表名
objCMClassENT.NameSpace = objCMClassENS.NameSpace; //域名
objCMClassENT.ProjectPath = objCMClassENS.ProjectPath; //工程路径
objCMClassENT.FilePath = objCMClassENS.FilePath; //文件路径
objCMClassENT.FileName = objCMClassENS.FileName; //文件名
objCMClassENT.FileText = objCMClassENS.FileText; //文件内容
objCMClassENT.FuncModuleAgcId = objCMClassENS.FuncModuleAgcId; //功能模块Id
objCMClassENT.CodeTypeId = objCMClassENS.CodeTypeId; //代码类型Id
objCMClassENT.UserId = objCMClassENS.UserId; //用户Id
objCMClassENT.PrjId = objCMClassENS.PrjId; //工程Id
objCMClassENT.IsOpen = objCMClassENS.IsOpen; //是否开放
objCMClassENT.UpdDate = objCMClassENS.UpdDate; //修改日期
objCMClassENT.UpdUser = objCMClassENS.UpdUser; //修改者
objCMClassENT.Memo = objCMClassENS.Memo; //说明
objCMClassENT.ClsName = objCMClassENS.ClsName; //类名
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
 /// <param name = "objCMClassEN">源简化对象</param>
 public static void SetUpdFlag(clsCMClassEN objCMClassEN)
{
try
{
objCMClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMClass.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.CmClassId = objCMClassEN.CmClassId; //类Id
}
if (arrFldSet.Contains(conCMClass.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.ApplicationTypeId = objCMClassEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conCMClass.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.ProgLangTypeId = objCMClassEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conCMClass.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.TabName = objCMClassEN.TabName == "[null]" ? null :  objCMClassEN.TabName; //表名
}
if (arrFldSet.Contains(conCMClass.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.NameSpace = objCMClassEN.NameSpace == "[null]" ? null :  objCMClassEN.NameSpace; //域名
}
if (arrFldSet.Contains(conCMClass.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.ProjectPath = objCMClassEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(conCMClass.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.FilePath = objCMClassEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conCMClass.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.FileName = objCMClassEN.FileName; //文件名
}
if (arrFldSet.Contains(conCMClass.FileText, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.FileText = objCMClassEN.FileText == "[null]" ? null :  objCMClassEN.FileText; //文件内容
}
if (arrFldSet.Contains(conCMClass.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.FuncModuleAgcId = objCMClassEN.FuncModuleAgcId == "[null]" ? null :  objCMClassEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conCMClass.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.CodeTypeId = objCMClassEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conCMClass.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.UserId = objCMClassEN.UserId == "[null]" ? null :  objCMClassEN.UserId; //用户Id
}
if (arrFldSet.Contains(conCMClass.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.PrjId = objCMClassEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMClass.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.IsOpen = objCMClassEN.IsOpen; //是否开放
}
if (arrFldSet.Contains(conCMClass.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.UpdDate = objCMClassEN.UpdDate == "[null]" ? null :  objCMClassEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMClass.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.UpdUser = objCMClassEN.UpdUser == "[null]" ? null :  objCMClassEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.Memo = objCMClassEN.Memo == "[null]" ? null :  objCMClassEN.Memo; //说明
}
if (arrFldSet.Contains(conCMClass.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassEN.ClsName = objCMClassEN.ClsName; //类名
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
 /// <param name = "objCMClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMClassEN objCMClassEN)
{
try
{
if (objCMClassEN.TabName == "[null]") objCMClassEN.TabName = null; //表名
if (objCMClassEN.NameSpace == "[null]") objCMClassEN.NameSpace = null; //域名
if (objCMClassEN.FileText == "[null]") objCMClassEN.FileText = null; //文件内容
if (objCMClassEN.FuncModuleAgcId == "[null]") objCMClassEN.FuncModuleAgcId = null; //功能模块Id
if (objCMClassEN.UserId == "[null]") objCMClassEN.UserId = null; //用户Id
if (objCMClassEN.UpdDate == "[null]") objCMClassEN.UpdDate = null; //修改日期
if (objCMClassEN.UpdUser == "[null]") objCMClassEN.UpdUser = null; //修改者
if (objCMClassEN.Memo == "[null]") objCMClassEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMClassEN objCMClassEN)
{
 CMClassDA.CheckPropertyNew(objCMClassEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMClassEN objCMClassEN)
{
 CMClassDA.CheckProperty4Condition(objCMClassEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_CmClassId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMClass.CmClassId); 
List<clsCMClassEN> arrObjLst = clsCMClassBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMClassEN objCMClassEN = new clsCMClassEN()
{
CmClassId = "0",
ClsName = "选[CM类]..."
};
arrObjLstSel.Insert(0, objCMClassEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMClass.CmClassId;
objComboBox.DisplayMember = conCMClass.ClsName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_CmClassId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM类]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMClass.CmClassId); 
IEnumerable<clsCMClassEN> arrObjLst = clsCMClassBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conCMClass.CmClassId;
objDDL.DataTextField = conCMClass.ClsName;
objDDL.DataSource = arrObjLstSel;
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
if (clsCMClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassBL没有刷新缓存机制(clsCMClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmClassId");
//if (arrCMClassObjLstCache == null)
//{
//arrCMClassObjLstCache = CMClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMClassEN GetObjByCmClassIdCache(string strCmClassId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
List<clsCMClassEN> arrCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrCMClassObjLst_Sel =
arrCMClassObjLstCache
.Where(x=> x.CmClassId == strCmClassId 
);
if (arrCMClassObjLst_Sel.Count() == 0)
{
   clsCMClassEN obj = clsCMClassBL.GetObjByCmClassId(strCmClassId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMClassObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMClassEN> GetAllCMClassObjLstCache()
{
//获取缓存中的对象列表
List<clsCMClassEN> arrCMClassObjLstCache = GetObjLstCache(); 
return arrCMClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMClassEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
List<clsCMClassEN> arrCMClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMClassObjLstCache;
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
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMClassEN._RefreshTimeLst.Count == 0) return "";
return clsCMClassEN._RefreshTimeLst[clsCMClassEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCMClassBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMClassBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMClass(CM类)
 /// 唯一性条件:TabName_NameSpace_ClsName_FileName_UserId_PrjId_ProgLangTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMClassEN objCMClassEN)
{
//检测记录是否存在
string strResult = CMClassDA.GetUniCondStr(objCMClassEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCmClassId)
{
if (strInFldName != conCMClass.CmClassId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMClass._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMClass._AttributeName));
throw new Exception(strMsg);
}
var objCMClass = clsCMClassBL.GetObjByCmClassIdCache(strCmClassId);
if (objCMClass == null) return "";
return objCMClass[strOutFldName].ToString();
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
int intRecCount = clsCMClassDA.GetRecCount(strTabName);
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
int intRecCount = clsCMClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMClassDA.GetRecCount();
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
int intRecCount = clsCMClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMClassEN objCMClassCond)
{
List<clsCMClassEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMClass._AttributeName)
{
if (objCMClassCond.IsUpdated(strFldName) == false) continue;
if (objCMClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassCond[strFldName].ToString());
}
else
{
if (objCMClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMClassCond[strFldName]));
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
 List<string> arrList = clsCMClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMClassDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMClassDA.SetFldValue(clsCMClassEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMClassDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMClassDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMClassDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMClassDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMClass] "); 
 strCreateTabCode.Append(" ( "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" CmClassId char(8) primary key, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**域名*/ 
 strCreateTabCode.Append(" NameSpace varchar(50) Null, "); 
 // /**工程路径*/ 
 strCreateTabCode.Append(" ProjectPath varchar(500) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) not Null, "); 
 // /**文件内容*/ 
 strCreateTabCode.Append(" FileText text Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**是否开放*/ 
 strCreateTabCode.Append(" IsOpen bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CM类(CMClass)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMClass : clsCommFun4BL
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
clsCMClassBL.ReFreshThisCache();
}
}

}