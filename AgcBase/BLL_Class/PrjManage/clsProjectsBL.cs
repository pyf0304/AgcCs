
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsBL
 表名:Projects(00050002)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsProjectsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProjectsEN GetObj(this K_PrjId_Projects myKey)
{
clsProjectsEN objProjectsEN = clsProjectsBL.ProjectsDA.GetObjByPrjId(myKey.Value);
return objProjectsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objProjectsEN) == false)
{
var strMsg = string.Format("记录已经存在!工程名称 = [{0}]的数据已经存在!(in clsProjectsBL.AddNewRecord)", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
bool bolResult = clsProjectsBL.ProjectsDA.AddNewRecordBySQL2(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
public static bool AddRecordEx(this clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsProjectsBL.IsExist(objProjectsEN.PrjId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objProjectsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objProjectsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程名称(PrjName)=[{0}])已经存在,不能重复!", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objProjectsEN.AddNewRecord();
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objProjectsEN) == false)
{
var strMsg = string.Format("记录已经存在!工程名称 = [{0}]的数据已经存在!(in clsProjectsBL.AddNewRecordWithMaxId)", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
string strPrjId = clsProjectsBL.ProjectsDA.AddNewRecordBySQL2WithReturnKey(objProjectsEN);
     objProjectsEN.PrjId = strPrjId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
}
return strPrjId;
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objProjectsEN) == false)
{
var strMsg = string.Format("记录已经存在!工程名称 = [{0}]的数据已经存在!(in clsProjectsBL.AddNewRecordWithReturnKey)", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
string strKey = clsProjectsBL.ProjectsDA.AddNewRecordBySQL2WithReturnKey(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjId(this clsProjectsEN objProjectsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conProjects.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conProjects.PrjId);
}
objProjectsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjName(this clsProjectsEN objProjectsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, conProjects.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, conProjects.PrjName);
}
objProjectsEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjName] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjDomain(this clsProjectsEN objProjectsEN, string strPrjDomain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, conProjects.PrjDomain);
}
objProjectsEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjDomain) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjDomain, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjDomain] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetTableSpace(this clsProjectsEN objProjectsEN, string strTableSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableSpace, 50, conProjects.TableSpace);
}
objProjectsEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.TableSpace) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.TableSpace, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.TableSpace] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetGetWebApiFunc(this clsProjectsEN objProjectsEN, string strGetWebApiFunc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetWebApiFunc, 100, conProjects.GetWebApiFunc);
}
objProjectsEN.GetWebApiFunc = strGetWebApiFunc; //获取WebApiUrl函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.GetWebApiFunc) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.GetWebApiFunc, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.GetWebApiFunc] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsRelaDataBase(this clsProjectsEN objProjectsEN, bool bolIsRelaDataBase, string strComparisonOp="")
	{
objProjectsEN.IsRelaDataBase = bolIsRelaDataBase; //是否关联数据库
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsRelaDataBase) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsRelaDataBase, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsRelaDataBase] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUseStateId(this clsProjectsEN objProjectsEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conProjects.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conProjects.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conProjects.UseStateId);
}
objProjectsEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UseStateId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UseStateId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UseStateId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUserId(this clsProjectsEN objProjectsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conProjects.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conProjects.UserId);
}
objProjectsEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UserId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UserId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UserId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUpdDate(this clsProjectsEN objProjectsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conProjects.UpdDate);
}
objProjectsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UpdDate) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UpdDate, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UpdDate] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetMemo(this clsProjectsEN objProjectsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conProjects.Memo);
}
objProjectsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.Memo) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.Memo, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.Memo] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetJavaPackageName(this clsProjectsEN objProjectsEN, string strJavaPackageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaPackageName, 200, conProjects.JavaPackageName);
}
objProjectsEN.JavaPackageName = strJavaPackageName; //Java包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.JavaPackageName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.JavaPackageName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.JavaPackageName] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsSupportMvc(this clsProjectsEN objProjectsEN, bool bolIsSupportMvc, string strComparisonOp="")
	{
objProjectsEN.IsSupportMvc = bolIsSupportMvc; //是否支持Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsSupportMvc) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsSupportMvc, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsSupportMvc] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsoPrjName(this clsProjectsEN objProjectsEN, string strIsoPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsoPrjName, 50, conProjects.IsoPrjName);
}
objProjectsEN.IsoPrjName = strIsoPrjName; //ISO工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsoPrjName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsoPrjName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsoPrjName] = strComparisonOp;
}
}
return objProjectsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objProjectsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsProjectsEN objProjectsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objProjectsEN.CheckPropertyNew();
clsProjectsEN objProjectsCond = new clsProjectsEN();
string strCondition = objProjectsCond
.SetPrjId(objProjectsEN.PrjId, "<>")
.SetPrjName(objProjectsEN.PrjName, "=")
.GetCombineCondition();
objProjectsEN._IsCheckProperty = true;
bool bolIsExist = clsProjectsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objProjectsEN.Update();
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
 /// <param name = "objProjects">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsProjectsEN objProjects)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsProjectsEN objProjectsCond = new clsProjectsEN();
string strCondition = objProjectsCond
.SetPrjName(objProjects.PrjName, "=")
.GetCombineCondition();
objProjects._IsCheckProperty = true;
bool bolIsExist = clsProjectsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objProjects.PrjId = clsProjectsBL.GetFirstID_S(strCondition);
objProjects.UpdateWithCondition(strCondition);
}
else
{
objProjects.PrjId = clsProjectsBL.GetMaxStrId_S();
objProjects.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProjectsEN objProjectsEN)
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsProjectsBL.ProjectsDA.UpdateBySql2(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProjectsEN objProjectsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsProjectsBL.ProjectsDA.UpdateBySql2(objProjectsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProjectsEN objProjectsEN, string strWhereCond)
{
try
{
bool bolResult = clsProjectsBL.ProjectsDA.UpdateBySqlWithCondition(objProjectsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProjectsEN objProjectsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsProjectsBL.ProjectsDA.UpdateBySqlWithConditionTransaction(objProjectsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsProjectsEN objProjectsEN)
{
try
{
int intRecNum = clsProjectsBL.ProjectsDA.DelRecord(objProjectsEN.PrjId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
 public static void CopyTo(this clsProjectsEN objProjectsENS, clsProjectsEN objProjectsENT)
{
try
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程Id
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.GetWebApiFunc = objProjectsENS.GetWebApiFunc; //获取WebApiUrl函数
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.IsoPrjName = objProjectsENS.IsoPrjName; //ISO工程名
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
 /// <param name = "objProjectsENS">源对象</param>
 /// <returns>目标对象=>clsProjectsEN:objProjectsENT</returns>
 public static clsProjectsEN CopyTo(this clsProjectsEN objProjectsENS)
{
try
{
 clsProjectsEN objProjectsENT = new clsProjectsEN()
{
PrjId = objProjectsENS.PrjId, //工程Id
PrjName = objProjectsENS.PrjName, //工程名称
PrjDomain = objProjectsENS.PrjDomain, //域/包名
TableSpace = objProjectsENS.TableSpace, //表空间
GetWebApiFunc = objProjectsENS.GetWebApiFunc, //获取WebApiUrl函数
IsRelaDataBase = objProjectsENS.IsRelaDataBase, //是否关联数据库
UseStateId = objProjectsENS.UseStateId, //使用状态Id
UserId = objProjectsENS.UserId, //用户Id
UpdDate = objProjectsENS.UpdDate, //修改日期
Memo = objProjectsENS.Memo, //说明
JavaPackageName = objProjectsENS.JavaPackageName, //Java包名
IsSupportMvc = objProjectsENS.IsSupportMvc, //是否支持Mvc
IsoPrjName = objProjectsENS.IsoPrjName, //ISO工程名
};
 return objProjectsENT;
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
public static void CheckPropertyNew(this clsProjectsEN objProjectsEN)
{
 clsProjectsBL.ProjectsDA.CheckPropertyNew(objProjectsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsProjectsEN objProjectsEN)
{
 clsProjectsBL.ProjectsDA.CheckProperty4Condition(objProjectsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsProjectsEN objProjectsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objProjectsCond.IsUpdated(conProjects.PrjId) == true)
{
string strComparisonOpPrjId = objProjectsCond.dicFldComparisonOp[conProjects.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjId, objProjectsCond.PrjId, strComparisonOpPrjId);
}
if (objProjectsCond.IsUpdated(conProjects.PrjName) == true)
{
string strComparisonOpPrjName = objProjectsCond.dicFldComparisonOp[conProjects.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjName, objProjectsCond.PrjName, strComparisonOpPrjName);
}
if (objProjectsCond.IsUpdated(conProjects.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objProjectsCond.dicFldComparisonOp[conProjects.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjDomain, objProjectsCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objProjectsCond.IsUpdated(conProjects.TableSpace) == true)
{
string strComparisonOpTableSpace = objProjectsCond.dicFldComparisonOp[conProjects.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.TableSpace, objProjectsCond.TableSpace, strComparisonOpTableSpace);
}
if (objProjectsCond.IsUpdated(conProjects.GetWebApiFunc) == true)
{
string strComparisonOpGetWebApiFunc = objProjectsCond.dicFldComparisonOp[conProjects.GetWebApiFunc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.GetWebApiFunc, objProjectsCond.GetWebApiFunc, strComparisonOpGetWebApiFunc);
}
if (objProjectsCond.IsUpdated(conProjects.IsRelaDataBase) == true)
{
if (objProjectsCond.IsRelaDataBase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProjects.IsRelaDataBase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProjects.IsRelaDataBase);
}
}
if (objProjectsCond.IsUpdated(conProjects.UseStateId) == true)
{
string strComparisonOpUseStateId = objProjectsCond.dicFldComparisonOp[conProjects.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UseStateId, objProjectsCond.UseStateId, strComparisonOpUseStateId);
}
if (objProjectsCond.IsUpdated(conProjects.UserId) == true)
{
string strComparisonOpUserId = objProjectsCond.dicFldComparisonOp[conProjects.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UserId, objProjectsCond.UserId, strComparisonOpUserId);
}
if (objProjectsCond.IsUpdated(conProjects.UpdDate) == true)
{
string strComparisonOpUpdDate = objProjectsCond.dicFldComparisonOp[conProjects.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UpdDate, objProjectsCond.UpdDate, strComparisonOpUpdDate);
}
if (objProjectsCond.IsUpdated(conProjects.Memo) == true)
{
string strComparisonOpMemo = objProjectsCond.dicFldComparisonOp[conProjects.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.Memo, objProjectsCond.Memo, strComparisonOpMemo);
}
if (objProjectsCond.IsUpdated(conProjects.JavaPackageName) == true)
{
string strComparisonOpJavaPackageName = objProjectsCond.dicFldComparisonOp[conProjects.JavaPackageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.JavaPackageName, objProjectsCond.JavaPackageName, strComparisonOpJavaPackageName);
}
if (objProjectsCond.IsUpdated(conProjects.IsSupportMvc) == true)
{
if (objProjectsCond.IsSupportMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProjects.IsSupportMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProjects.IsSupportMvc);
}
}
if (objProjectsCond.IsUpdated(conProjects.IsoPrjName) == true)
{
string strComparisonOpIsoPrjName = objProjectsCond.dicFldComparisonOp[conProjects.IsoPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.IsoPrjName, objProjectsCond.IsoPrjName, strComparisonOpIsoPrjName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Projects(工程), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objProjectsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsProjectsEN objProjectsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objProjectsEN == null) return true;
if (objProjectsEN.PrjId == null || objProjectsEN.PrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
if (clsProjectsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PrjId !=  '{0}'", objProjectsEN.PrjId);
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
if (clsProjectsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Projects(工程), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objProjectsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsProjectsEN objProjectsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objProjectsEN == null) return "";
if (objProjectsEN.PrjId == null || objProjectsEN.PrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjId !=  '{0}'", objProjectsEN.PrjId);
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Projects
{
public virtual bool UpdRelaTabDate(string strPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程(Projects)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsProjectsBL
{
public static RelatedActions_Projects relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsProjectsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsProjectsDA ProjectsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsProjectsDA();
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
 public clsProjectsBL()
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
if (string.IsNullOrEmpty(clsProjectsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsProjectsEN._ConnectString);
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
public static DataTable GetDataTable_Projects(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ProjectsDA.GetDataTable_Projects(strWhereCond);
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
objDT = ProjectsDA.GetDataTable(strWhereCond);
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
objDT = ProjectsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ProjectsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ProjectsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ProjectsDA.GetDataTable_Top(objTopPara);
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
objDT = ProjectsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ProjectsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ProjectsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsProjectsEN> GetObjLstByPrjIdLst(List<string> arrPrjIdLst)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjIdLst, true);
 string strWhereCond = string.Format("PrjId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsProjectsEN> GetObjLstByPrjIdLstCache(List<string> arrPrjIdLst)
{
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel =
arrProjectsObjLstCache
.Where(x => arrPrjIdLst.Contains(x.PrjId));
return arrProjectsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetObjLst(string strWhereCond)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
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
public static List<clsProjectsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objProjectsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsProjectsEN> GetSubObjLstCache(clsProjectsEN objProjectsCond)
{
List<clsProjectsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conProjects._AttributeName)
{
if (objProjectsCond.IsUpdated(strFldName) == false) continue;
if (objProjectsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProjectsCond[strFldName].ToString());
}
else
{
if (objProjectsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objProjectsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProjectsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objProjectsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objProjectsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objProjectsCond[strFldName]));
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
public static List<clsProjectsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
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
public static List<clsProjectsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
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
List<clsProjectsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsProjectsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsProjectsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
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
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
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
public static List<clsProjectsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsProjectsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsProjectsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
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
public static List<clsProjectsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objProjectsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetProjects(ref clsProjectsEN objProjectsEN)
{
bool bolResult = ProjectsDA.GetProjects(ref objProjectsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProjectsEN GetObjByPrjId(string strPrjId)
{
if (strPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsProjectsEN objProjectsEN = ProjectsDA.GetObjByPrjId(strPrjId);
return objProjectsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsProjectsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsProjectsEN objProjectsEN = ProjectsDA.GetFirstObj(strWhereCond);
 return objProjectsEN;
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
public static clsProjectsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsProjectsEN objProjectsEN = ProjectsDA.GetObjByDataRow(objRow);
 return objProjectsEN;
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
public static clsProjectsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsProjectsEN objProjectsEN = ProjectsDA.GetObjByDataRow(objRow);
 return objProjectsEN;
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
 /// <param name = "strPrjId">所给的关键字</param>
 /// <param name = "lstProjectsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProjectsEN GetObjByPrjIdFromList(string strPrjId, List<clsProjectsEN> lstProjectsObjLst)
{
foreach (clsProjectsEN objProjectsEN in lstProjectsObjLst)
{
if (objProjectsEN.PrjId == strPrjId)
{
return objProjectsEN;
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
 string strMaxPrjId;
 try
 {
 strMaxPrjId = clsProjectsDA.GetMaxStrId();
 return strMaxPrjId;
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
 string strPrjId;
 try
 {
 strPrjId = new clsProjectsDA().GetFirstID(strWhereCond);
 return strPrjId;
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
 arrList = ProjectsDA.GetID(strWhereCond);
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
bool bolIsExist = ProjectsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ProjectsDA.IsExist(strPrjId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPrjId">工程Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPrjId, string strOpUser)
{
clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId(strPrjId);
objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsProjectsBL.UpdateBySql2(objProjectsEN);
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
 bolIsExist = clsProjectsDA.IsExistTable();
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
 bolIsExist = ProjectsDA.IsExistTable(strTabName);
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objProjectsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程名称 = [{0}]的数据已经存在!(in clsProjectsBL.AddNewRecordBySql2)", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
bool bolResult = ProjectsDA.AddNewRecordBySQL2(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsProjectsEN objProjectsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objProjectsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程名称 = [{0}]的数据已经存在!(in clsProjectsBL.AddNewRecordBySql2WithReturnKey)", objProjectsEN.PrjName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsBL.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsBL.GetMaxStrId_S();
 }
string strKey = ProjectsDA.AddNewRecordBySQL2WithReturnKey(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsProjectsEN objProjectsEN)
{
try
{
bool bolResult = ProjectsDA.Update(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsProjectsEN objProjectsEN)
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ProjectsDA.UpdateBySql2(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsBL.ReFreshCache();

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
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
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPrjId)
{
try
{
 clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId(strPrjId);

if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(objProjectsEN.PrjId, "SetUpdDate");
}
if (objProjectsEN != null)
{
int intRecNum = ProjectsDA.DelRecord(strPrjId);
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
/// <param name="strPrjId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPrjId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsProjectsDA.GetSpecSQLObj();
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
//删除与表:[Projects]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conProjects.PrjId,
//strPrjId);
//        clsProjectsBL.DelProjectssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsProjectsBL.DelRecord(strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsProjectsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsProjectsBL.relatedActions != null)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(strPrjId, "UpdRelaTabDate");
}
bool bolResult = ProjectsDA.DelRecord(strPrjId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPrjIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelProjectss(List<string> arrPrjIdLst)
{
if (arrPrjIdLst.Count == 0) return 0;
try
{
if (clsProjectsBL.relatedActions != null)
{
foreach (var strPrjId in arrPrjIdLst)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(strPrjId, "UpdRelaTabDate");
}
}
int intDelRecNum = ProjectsDA.DelProjects(arrPrjIdLst);
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
public static int DelProjectssByCond(string strWhereCond)
{
try
{
if (clsProjectsBL.relatedActions != null)
{
List<string> arrPrjId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPrjId in arrPrjId)
{
clsProjectsBL.relatedActions.UpdRelaTabDate(strPrjId, "UpdRelaTabDate");
}
}
int intRecNum = ProjectsDA.DelProjects(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Projects]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPrjId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsProjectsDA.GetSpecSQLObj();
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
//删除与表:[Projects]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsProjectsBL.DelRecord(strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsProjectsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPrjId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
 public static void CopyTo(clsProjectsEN objProjectsENS, clsProjectsEN objProjectsENT)
{
try
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程Id
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.GetWebApiFunc = objProjectsENS.GetWebApiFunc; //获取WebApiUrl函数
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.IsoPrjName = objProjectsENS.IsoPrjName; //ISO工程名
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
 /// <param name = "objProjectsEN">源简化对象</param>
 public static void SetUpdFlag(clsProjectsEN objProjectsEN)
{
try
{
objProjectsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objProjectsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conProjects.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.PrjId = objProjectsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conProjects.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.PrjName = objProjectsEN.PrjName; //工程名称
}
if (arrFldSet.Contains(conProjects.PrjDomain, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.PrjDomain = objProjectsEN.PrjDomain == "[null]" ? null :  objProjectsEN.PrjDomain; //域/包名
}
if (arrFldSet.Contains(conProjects.TableSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.TableSpace = objProjectsEN.TableSpace == "[null]" ? null :  objProjectsEN.TableSpace; //表空间
}
if (arrFldSet.Contains(conProjects.GetWebApiFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.GetWebApiFunc = objProjectsEN.GetWebApiFunc == "[null]" ? null :  objProjectsEN.GetWebApiFunc; //获取WebApiUrl函数
}
if (arrFldSet.Contains(conProjects.IsRelaDataBase, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.IsRelaDataBase = objProjectsEN.IsRelaDataBase; //是否关联数据库
}
if (arrFldSet.Contains(conProjects.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.UseStateId = objProjectsEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(conProjects.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.UserId = objProjectsEN.UserId; //用户Id
}
if (arrFldSet.Contains(conProjects.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.UpdDate = objProjectsEN.UpdDate == "[null]" ? null :  objProjectsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conProjects.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.Memo = objProjectsEN.Memo == "[null]" ? null :  objProjectsEN.Memo; //说明
}
if (arrFldSet.Contains(conProjects.JavaPackageName, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.JavaPackageName = objProjectsEN.JavaPackageName == "[null]" ? null :  objProjectsEN.JavaPackageName; //Java包名
}
if (arrFldSet.Contains(conProjects.IsSupportMvc, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.IsSupportMvc = objProjectsEN.IsSupportMvc; //是否支持Mvc
}
if (arrFldSet.Contains(conProjects.IsoPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objProjectsEN.IsoPrjName = objProjectsEN.IsoPrjName == "[null]" ? null :  objProjectsEN.IsoPrjName; //ISO工程名
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
 /// <param name = "objProjectsEN">源简化对象</param>
 public static void AccessFldValueNull(clsProjectsEN objProjectsEN)
{
try
{
if (objProjectsEN.PrjDomain == "[null]") objProjectsEN.PrjDomain = null; //域/包名
if (objProjectsEN.TableSpace == "[null]") objProjectsEN.TableSpace = null; //表空间
if (objProjectsEN.GetWebApiFunc == "[null]") objProjectsEN.GetWebApiFunc = null; //获取WebApiUrl函数
if (objProjectsEN.UpdDate == "[null]") objProjectsEN.UpdDate = null; //修改日期
if (objProjectsEN.Memo == "[null]") objProjectsEN.Memo = null; //说明
if (objProjectsEN.JavaPackageName == "[null]") objProjectsEN.JavaPackageName = null; //Java包名
if (objProjectsEN.IsoPrjName == "[null]") objProjectsEN.IsoPrjName = null; //ISO工程名
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
public static void CheckPropertyNew(clsProjectsEN objProjectsEN)
{
 ProjectsDA.CheckPropertyNew(objProjectsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsProjectsEN objProjectsEN)
{
 ProjectsDA.CheckProperty4Condition(objProjectsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PrjId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conProjects.PrjId); 
List<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsProjectsEN objProjectsEN = new clsProjectsEN()
{
PrjId = "0",
PrjName = "选[工程]..."
};
arrObjLst.Insert(0, objProjectsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conProjects.PrjId;
objComboBox.DisplayMember = conProjects.PrjName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conProjects.PrjId); 
IEnumerable<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition);
objDDL.DataValueField = conProjects.PrjId;
objDDL.DataTextField = conProjects.PrjName;
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
public static void BindDdl_PrjIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程]...","0");
List<clsProjectsEN> arrProjectsObjLst = GetAllProjectsObjLstCache(); 
objDDL.DataValueField = conProjects.PrjId;
objDDL.DataTextField = conProjects.PrjName;
objDDL.DataSource = arrProjectsObjLst;
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjId");
//if (arrProjectsObjLstCache == null)
//{
//arrProjectsObjLstCache = ProjectsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProjectsEN GetObjByPrjIdCache(string strPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel =
arrProjectsObjLstCache
.Where(x=> x.PrjId == strPrjId 
);
if (arrProjectsObjLst_Sel.Count() == 0)
{
   clsProjectsEN obj = clsProjectsBL.GetObjByPrjId(strPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrProjectsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjNameByPrjIdCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return "";
//获取缓存中的对象列表
clsProjectsEN objProjects = GetObjByPrjIdCache(strPrjId);
if (objProjects == null) return "";
return objProjects.PrjName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjIdCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return "";
//获取缓存中的对象列表
clsProjectsEN objProjects = GetObjByPrjIdCache(strPrjId);
if (objProjects == null) return "";
return objProjects.PrjName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProjectsEN> GetAllProjectsObjLstCache()
{
//获取缓存中的对象列表
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache(); 
return arrProjectsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProjectsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
List<clsProjectsEN> arrProjectsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrProjectsObjLstCache;
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
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProjectsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsProjectsEN._RefreshTimeLst.Count == 0) return "";
return clsProjectsEN._RefreshTimeLst[clsProjectsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsProjectsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProjectsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsProjectsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Projects(工程)
 /// 唯一性条件:PrjName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objProjectsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsProjectsEN objProjectsEN)
{
//检测记录是否存在
string strResult = ProjectsDA.GetUniCondStr(objProjectsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strPrjId)
{
if (strInFldName != conProjects.PrjId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conProjects._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conProjects._AttributeName));
throw new Exception(strMsg);
}
var objProjects = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
if (objProjects == null) return "";
return objProjects[strOutFldName].ToString();
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
int intRecCount = clsProjectsDA.GetRecCount(strTabName);
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
int intRecCount = clsProjectsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsProjectsDA.GetRecCount();
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
int intRecCount = clsProjectsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objProjectsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsProjectsEN objProjectsCond)
{
List<clsProjectsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conProjects._AttributeName)
{
if (objProjectsCond.IsUpdated(strFldName) == false) continue;
if (objProjectsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProjectsCond[strFldName].ToString());
}
else
{
if (objProjectsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objProjectsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objProjectsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objProjectsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objProjectsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objProjectsCond[strFldName]));
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
 List<string> arrList = clsProjectsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ProjectsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ProjectsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ProjectsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsProjectsDA.SetFldValue(clsProjectsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ProjectsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsProjectsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsProjectsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsProjectsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Projects] "); 
 strCreateTabCode.Append(" ( "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) primary key, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) not Null, "); 
 // /**域/包名*/ 
 strCreateTabCode.Append(" PrjDomain varchar(128) Null, "); 
 // /**表空间*/ 
 strCreateTabCode.Append(" TableSpace varchar(50) Null, "); 
 // /**获取WebApiUrl函数*/ 
 strCreateTabCode.Append(" GetWebApiFunc varchar(100) Null, "); 
 // /**是否关联数据库*/ 
 strCreateTabCode.Append(" IsRelaDataBase bit Null, "); 
 // /**使用状态Id*/ 
 strCreateTabCode.Append(" UseStateId char(4) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**Java包名*/ 
 strCreateTabCode.Append(" JavaPackageName varchar(200) Null, "); 
 // /**是否支持Mvc*/ 
 strCreateTabCode.Append(" IsSupportMvc bit Null, "); 
 // /**ISO工程名*/ 
 strCreateTabCode.Append(" IsoPrjName varchar(50) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**使用状态名称*/ 
 strCreateTabCode.Append(" UseStateName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程(Projects)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Projects : clsCommFun4BL
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
clsProjectsBL.ReFreshThisCache();
}
}

}