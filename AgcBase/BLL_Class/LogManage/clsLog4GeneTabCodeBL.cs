
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GeneTabCodeBL
 表名:Log4GeneTabCode(00050279)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsLog4GeneTabCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4GeneTabCodeEN GetObj(this K_mId_Log4GeneTabCode myKey)
{
clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.GetObjBymId(myKey.Value);
return objLog4GeneTabCodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLog4GeneTabCodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],GC路径Id = [{1}],应用程序类型ID = [{2}],用户Id = [{3}]的数据已经存在!(in clsLog4GeneTabCodeBL.AddNewRecord)", objLog4GeneTabCodeEN.TabId,objLog4GeneTabCodeEN.GcPathId,objLog4GeneTabCodeEN.ApplicationTypeId,objLog4GeneTabCodeEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.AddNewRecordBySQL2(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedCheckUniqueness = true)
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
objLog4GeneTabCodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objLog4GeneTabCodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],GC路径Id(GcPathId)=[{1}],应用程序类型ID(ApplicationTypeId)=[{2}],用户Id(UserId)=[{3}])已经存在,不能重复!", objLog4GeneTabCodeEN.TabId, objLog4GeneTabCodeEN.GcPathId, objLog4GeneTabCodeEN.ApplicationTypeId, objLog4GeneTabCodeEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objLog4GeneTabCodeEN.AddNewRecord();
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objLog4GeneTabCodeEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],GC路径Id = [{1}],应用程序类型ID = [{2}],用户Id = [{3}]的数据已经存在!(in clsLog4GeneTabCodeBL.AddNewRecordWithReturnKey)", objLog4GeneTabCodeEN.TabId,objLog4GeneTabCodeEN.GcPathId,objLog4GeneTabCodeEN.ApplicationTypeId,objLog4GeneTabCodeEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.AddNewRecordBySQL2WithReturnKey(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetmId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, long lngmId, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.mId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.mId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.mId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetUserId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conLog4GeneTabCode.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conLog4GeneTabCode.UserId);
}
objLog4GeneTabCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.UserId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.UserId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.UserId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetTabId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conLog4GeneTabCode.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conLog4GeneTabCode.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conLog4GeneTabCode.TabId);
}
objLog4GeneTabCodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.TabId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.TabId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.TabId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetPrjId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conLog4GeneTabCode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conLog4GeneTabCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conLog4GeneTabCode.PrjId);
}
objLog4GeneTabCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.PrjId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.PrjId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.PrjId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetGcPathId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strGcPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conLog4GeneTabCode.GcPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conLog4GeneTabCode.GcPathId);
}
objLog4GeneTabCodeEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.GcPathId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.GcPathId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.GcPathId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetGeneCodeDate(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conLog4GeneTabCode.GeneCodeDate);
}
objLog4GeneTabCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.GeneCodeDate) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.GeneCodeDate, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.GeneCodeDate] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetIsNeedGene(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.IsNeedGene) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.IsNeedGene, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.IsNeedGene] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetVersionGeneCode(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, conLog4GeneTabCode.VersionGeneCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, conLog4GeneTabCode.VersionGeneCode);
}
objLog4GeneTabCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.VersionGeneCode) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.VersionGeneCode, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.VersionGeneCode] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetApplicationTypeId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, int? intApplicationTypeId, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.ApplicationTypeId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.ApplicationTypeId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.ApplicationTypeId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetMemo(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLog4GeneTabCode.Memo);
}
objLog4GeneTabCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.Memo) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.Memo, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.Memo] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objLog4GeneTabCodeEN.CheckPropertyNew();
clsLog4GeneTabCodeEN objLog4GeneTabCodeCond = new clsLog4GeneTabCodeEN();
string strCondition = objLog4GeneTabCodeCond
.SetmId(objLog4GeneTabCodeEN.mId, "<>")
.SetTabId(objLog4GeneTabCodeEN.TabId, "=")
.SetGcPathId(objLog4GeneTabCodeEN.GcPathId, "=")
.SetApplicationTypeId(objLog4GeneTabCodeEN.ApplicationTypeId, "=")
.SetUserId(objLog4GeneTabCodeEN.UserId, "=")
.GetCombineCondition();
objLog4GeneTabCodeEN._IsCheckProperty = true;
bool bolIsExist = clsLog4GeneTabCodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_GCPathId_ApplicationTypeId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objLog4GeneTabCodeEN.Update();
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
 /// <param name = "objLog4GeneTabCode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsLog4GeneTabCodeEN objLog4GeneTabCode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsLog4GeneTabCodeEN objLog4GeneTabCodeCond = new clsLog4GeneTabCodeEN();
string strCondition = objLog4GeneTabCodeCond
.SetTabId(objLog4GeneTabCode.TabId, "=")
.SetGcPathId(objLog4GeneTabCode.GcPathId, "=")
.SetApplicationTypeId(objLog4GeneTabCode.ApplicationTypeId, "=")
.SetUserId(objLog4GeneTabCode.UserId, "=")
.GetCombineCondition();
objLog4GeneTabCode._IsCheckProperty = true;
bool bolIsExist = clsLog4GeneTabCodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objLog4GeneTabCode.mId = clsLog4GeneTabCodeBL.GetFirstID_S(strCondition);
objLog4GeneTabCode.UpdateWithCondition(strCondition);
}
else
{
objLog4GeneTabCode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.UpdateBySql2(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GeneTabCodeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.UpdateBySql2(objLog4GeneTabCodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strWhereCond)
{
try
{
bool bolResult = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.UpdateBySqlWithCondition(objLog4GeneTabCodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.UpdateBySqlWithConditionTransaction(objLog4GeneTabCodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
public static int Delete(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
try
{
int intRecNum = clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.DelRecord(objLog4GeneTabCodeEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeENS">源对象</param>
 /// <param name = "objLog4GeneTabCodeENT">目标对象</param>
 public static void CopyTo(this clsLog4GeneTabCodeEN objLog4GeneTabCodeENS, clsLog4GeneTabCodeEN objLog4GeneTabCodeENT)
{
try
{
objLog4GeneTabCodeENT.mId = objLog4GeneTabCodeENS.mId; //mId
objLog4GeneTabCodeENT.UserId = objLog4GeneTabCodeENS.UserId; //用户Id
objLog4GeneTabCodeENT.TabId = objLog4GeneTabCodeENS.TabId; //表ID
objLog4GeneTabCodeENT.PrjId = objLog4GeneTabCodeENS.PrjId; //工程Id
objLog4GeneTabCodeENT.GcPathId = objLog4GeneTabCodeENS.GcPathId; //GC路径Id
objLog4GeneTabCodeENT.GeneCodeDate = objLog4GeneTabCodeENS.GeneCodeDate; //生成代码日期
objLog4GeneTabCodeENT.IsNeedGene = objLog4GeneTabCodeENS.IsNeedGene; //是否需要生成
objLog4GeneTabCodeENT.VersionGeneCode = objLog4GeneTabCodeENS.VersionGeneCode; //生成代码版本
objLog4GeneTabCodeENT.ApplicationTypeId = objLog4GeneTabCodeENS.ApplicationTypeId; //应用程序类型ID
objLog4GeneTabCodeENT.Memo = objLog4GeneTabCodeENS.Memo; //说明
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
 /// <param name = "objLog4GeneTabCodeENS">源对象</param>
 /// <returns>目标对象=>clsLog4GeneTabCodeEN:objLog4GeneTabCodeENT</returns>
 public static clsLog4GeneTabCodeEN CopyTo(this clsLog4GeneTabCodeEN objLog4GeneTabCodeENS)
{
try
{
 clsLog4GeneTabCodeEN objLog4GeneTabCodeENT = new clsLog4GeneTabCodeEN()
{
mId = objLog4GeneTabCodeENS.mId, //mId
UserId = objLog4GeneTabCodeENS.UserId, //用户Id
TabId = objLog4GeneTabCodeENS.TabId, //表ID
PrjId = objLog4GeneTabCodeENS.PrjId, //工程Id
GcPathId = objLog4GeneTabCodeENS.GcPathId, //GC路径Id
GeneCodeDate = objLog4GeneTabCodeENS.GeneCodeDate, //生成代码日期
IsNeedGene = objLog4GeneTabCodeENS.IsNeedGene, //是否需要生成
VersionGeneCode = objLog4GeneTabCodeENS.VersionGeneCode, //生成代码版本
ApplicationTypeId = objLog4GeneTabCodeENS.ApplicationTypeId, //应用程序类型ID
Memo = objLog4GeneTabCodeENS.Memo, //说明
};
 return objLog4GeneTabCodeENT;
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
public static void CheckPropertyNew(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.CheckPropertyNew(objLog4GeneTabCodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 clsLog4GeneTabCodeBL.Log4GeneTabCodeDA.CheckProperty4Condition(objLog4GeneTabCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.mId) == true)
{
string strComparisonOpmId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4GeneTabCode.mId, objLog4GeneTabCodeCond.mId, strComparisonOpmId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.UserId) == true)
{
string strComparisonOpUserId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.UserId, objLog4GeneTabCodeCond.UserId, strComparisonOpUserId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.TabId) == true)
{
string strComparisonOpTabId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.TabId, objLog4GeneTabCodeCond.TabId, strComparisonOpTabId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.PrjId) == true)
{
string strComparisonOpPrjId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.PrjId, objLog4GeneTabCodeCond.PrjId, strComparisonOpPrjId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.GcPathId) == true)
{
string strComparisonOpGcPathId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.GcPathId, objLog4GeneTabCodeCond.GcPathId, strComparisonOpGcPathId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.GeneCodeDate, objLog4GeneTabCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.IsNeedGene) == true)
{
if (objLog4GeneTabCodeCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", conLog4GeneTabCode.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conLog4GeneTabCode.IsNeedGene);
}
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.VersionGeneCode, objLog4GeneTabCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4GeneTabCode.ApplicationTypeId, objLog4GeneTabCodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.Memo) == true)
{
string strComparisonOpMemo = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.Memo, objLog4GeneTabCodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Log4GeneTabCode(生成表代码日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_GCPathId_ApplicationTypeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objLog4GeneTabCodeEN == null) return true;
if (objLog4GeneTabCodeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 if (objLog4GeneTabCodeEN.GcPathId == null)
{
 sbCondition.AppendFormat(" and GcPathId is null", objLog4GeneTabCodeEN.GcPathId);
}
else
{
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
}
 if (objLog4GeneTabCodeEN.ApplicationTypeId == null)
{
 sbCondition.AppendFormat(" and ApplicationTypeId is null", objLog4GeneTabCodeEN.ApplicationTypeId);
}
else
{
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
if (clsLog4GeneTabCodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4GeneTabCodeEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
if (clsLog4GeneTabCodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Log4GeneTabCode(生成表代码日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_GCPathId_ApplicationTypeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLog4GeneTabCodeEN == null) return "";
if (objLog4GeneTabCodeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 if (objLog4GeneTabCodeEN.GcPathId == null)
{
 sbCondition.AppendFormat(" and GcPathId is null", objLog4GeneTabCodeEN.GcPathId);
}
else
{
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
}
 if (objLog4GeneTabCodeEN.ApplicationTypeId == null)
{
 sbCondition.AppendFormat(" and ApplicationTypeId is null", objLog4GeneTabCodeEN.ApplicationTypeId);
}
else
{
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4GeneTabCodeEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Log4GeneTabCode
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 生成表代码日志(Log4GeneTabCode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsLog4GeneTabCodeBL
{
public static RelatedActions_Log4GeneTabCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsLog4GeneTabCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsLog4GeneTabCodeDA Log4GeneTabCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsLog4GeneTabCodeDA();
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
 public clsLog4GeneTabCodeBL()
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
if (string.IsNullOrEmpty(clsLog4GeneTabCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLog4GeneTabCodeEN._ConnectString);
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
public static DataTable GetDataTable_Log4GeneTabCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Log4GeneTabCodeDA.GetDataTable_Log4GeneTabCode(strWhereCond);
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
objDT = Log4GeneTabCodeDA.GetDataTable(strWhereCond);
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
objDT = Log4GeneTabCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Log4GeneTabCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Log4GeneTabCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Log4GeneTabCodeDA.GetDataTable_Top(objTopPara);
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
objDT = Log4GeneTabCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Log4GeneTabCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Log4GeneTabCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
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
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsLog4GeneTabCodeEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLst_Sel =
arrLog4GeneTabCodeObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrLog4GeneTabCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetObjLst(string strWhereCond)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
public static List<clsLog4GeneTabCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsLog4GeneTabCodeEN> GetSubObjLstCache(clsLog4GeneTabCodeEN objLog4GeneTabCodeCond)
{
List<clsLog4GeneTabCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GeneTabCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLog4GeneTabCode._AttributeName)
{
if (objLog4GeneTabCodeCond.IsUpdated(strFldName) == false) continue;
if (objLog4GeneTabCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GeneTabCodeCond[strFldName].ToString());
}
else
{
if (objLog4GeneTabCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLog4GeneTabCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GeneTabCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLog4GeneTabCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLog4GeneTabCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLog4GeneTabCodeCond[strFldName]));
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
List<clsLog4GeneTabCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsLog4GeneTabCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsLog4GeneTabCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
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
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
public static List<clsLog4GeneTabCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLog4GeneTabCodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetLog4GeneTabCode(ref clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
bool bolResult = Log4GeneTabCodeDA.GetLog4GeneTabCode(ref objLog4GeneTabCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4GeneTabCodeEN GetObjBymId(long lngmId)
{
clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = Log4GeneTabCodeDA.GetObjBymId(lngmId);
return objLog4GeneTabCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsLog4GeneTabCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = Log4GeneTabCodeDA.GetFirstObj(strWhereCond);
 return objLog4GeneTabCodeEN;
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
public static clsLog4GeneTabCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = Log4GeneTabCodeDA.GetObjByDataRow(objRow);
 return objLog4GeneTabCodeEN;
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
public static clsLog4GeneTabCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = Log4GeneTabCodeDA.GetObjByDataRow(objRow);
 return objLog4GeneTabCodeEN;
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
 /// <param name = "lstLog4GeneTabCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLog4GeneTabCodeEN GetObjBymIdFromList(long lngmId, List<clsLog4GeneTabCodeEN> lstLog4GeneTabCodeObjLst)
{
foreach (clsLog4GeneTabCodeEN objLog4GeneTabCodeEN in lstLog4GeneTabCodeObjLst)
{
if (objLog4GeneTabCodeEN.mId == lngmId)
{
return objLog4GeneTabCodeEN;
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
 lngmId = new clsLog4GeneTabCodeDA().GetFirstID(strWhereCond);
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
 arrList = Log4GeneTabCodeDA.GetID(strWhereCond);
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
bool bolIsExist = Log4GeneTabCodeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = Log4GeneTabCodeDA.IsExist(lngmId);
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
 bolIsExist = clsLog4GeneTabCodeDA.IsExistTable();
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
 bolIsExist = Log4GeneTabCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLog4GeneTabCodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],GC路径Id = [{1}],应用程序类型ID = [{2}],用户Id = [{3}]的数据已经存在!(in clsLog4GeneTabCodeBL.AddNewRecordBySql2)", objLog4GeneTabCodeEN.TabId,objLog4GeneTabCodeEN.GcPathId,objLog4GeneTabCodeEN.ApplicationTypeId,objLog4GeneTabCodeEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = Log4GeneTabCodeDA.AddNewRecordBySQL2(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objLog4GeneTabCodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],GC路径Id = [{1}],应用程序类型ID = [{2}],用户Id = [{3}]的数据已经存在!(in clsLog4GeneTabCodeBL.AddNewRecordBySql2WithReturnKey)", objLog4GeneTabCodeEN.TabId,objLog4GeneTabCodeEN.GcPathId,objLog4GeneTabCodeEN.ApplicationTypeId,objLog4GeneTabCodeEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = Log4GeneTabCodeDA.AddNewRecordBySQL2WithReturnKey(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
try
{
bool bolResult = Log4GeneTabCodeDA.Update(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Log4GeneTabCodeDA.UpdateBySql2(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLog4GeneTabCodeBL.ReFreshCache();

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
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
 clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = clsLog4GeneTabCodeBL.GetObjBymId(lngmId);

if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(objLog4GeneTabCodeEN.mId, "SetUpdDate");
}
if (objLog4GeneTabCodeEN != null)
{
int intRecNum = Log4GeneTabCodeDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
//删除与表:[Log4GeneTabCode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conLog4GeneTabCode.mId,
//lngmId);
//        clsLog4GeneTabCodeBL.DelLog4GeneTabCodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLog4GeneTabCodeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLog4GeneTabCodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsLog4GeneTabCodeBL.relatedActions != null)
{
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = Log4GeneTabCodeDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelLog4GeneTabCodes(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsLog4GeneTabCodeBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = Log4GeneTabCodeDA.DelLog4GeneTabCode(arrmIdLst);
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
public static int DelLog4GeneTabCodesByCond(string strWhereCond)
{
try
{
if (clsLog4GeneTabCodeBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsLog4GeneTabCodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = Log4GeneTabCodeDA.DelLog4GeneTabCode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Log4GeneTabCode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
//删除与表:[Log4GeneTabCode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLog4GeneTabCodeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLog4GeneTabCodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objLog4GeneTabCodeENS">源对象</param>
 /// <param name = "objLog4GeneTabCodeENT">目标对象</param>
 public static void CopyTo(clsLog4GeneTabCodeEN objLog4GeneTabCodeENS, clsLog4GeneTabCodeEN objLog4GeneTabCodeENT)
{
try
{
objLog4GeneTabCodeENT.mId = objLog4GeneTabCodeENS.mId; //mId
objLog4GeneTabCodeENT.UserId = objLog4GeneTabCodeENS.UserId; //用户Id
objLog4GeneTabCodeENT.TabId = objLog4GeneTabCodeENS.TabId; //表ID
objLog4GeneTabCodeENT.PrjId = objLog4GeneTabCodeENS.PrjId; //工程Id
objLog4GeneTabCodeENT.GcPathId = objLog4GeneTabCodeENS.GcPathId; //GC路径Id
objLog4GeneTabCodeENT.GeneCodeDate = objLog4GeneTabCodeENS.GeneCodeDate; //生成代码日期
objLog4GeneTabCodeENT.IsNeedGene = objLog4GeneTabCodeENS.IsNeedGene; //是否需要生成
objLog4GeneTabCodeENT.VersionGeneCode = objLog4GeneTabCodeENS.VersionGeneCode; //生成代码版本
objLog4GeneTabCodeENT.ApplicationTypeId = objLog4GeneTabCodeENS.ApplicationTypeId; //应用程序类型ID
objLog4GeneTabCodeENT.Memo = objLog4GeneTabCodeENS.Memo; //说明
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
 /// <param name = "objLog4GeneTabCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
try
{
objLog4GeneTabCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objLog4GeneTabCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conLog4GeneTabCode.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.mId = objLog4GeneTabCodeEN.mId; //mId
}
if (arrFldSet.Contains(conLog4GeneTabCode.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.UserId = objLog4GeneTabCodeEN.UserId; //用户Id
}
if (arrFldSet.Contains(conLog4GeneTabCode.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.TabId = objLog4GeneTabCodeEN.TabId; //表ID
}
if (arrFldSet.Contains(conLog4GeneTabCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.PrjId = objLog4GeneTabCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conLog4GeneTabCode.GcPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.GcPathId = objLog4GeneTabCodeEN.GcPathId == "[null]" ? null :  objLog4GeneTabCodeEN.GcPathId; //GC路径Id
}
if (arrFldSet.Contains(conLog4GeneTabCode.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.GeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate == "[null]" ? null :  objLog4GeneTabCodeEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(conLog4GeneTabCode.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.IsNeedGene = objLog4GeneTabCodeEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(conLog4GeneTabCode.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.VersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(conLog4GeneTabCode.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.ApplicationTypeId = objLog4GeneTabCodeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conLog4GeneTabCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objLog4GeneTabCodeEN.Memo = objLog4GeneTabCodeEN.Memo == "[null]" ? null :  objLog4GeneTabCodeEN.Memo; //说明
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
 /// <param name = "objLog4GeneTabCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
try
{
if (objLog4GeneTabCodeEN.GcPathId == "[null]") objLog4GeneTabCodeEN.GcPathId = null; //GC路径Id
if (objLog4GeneTabCodeEN.GeneCodeDate == "[null]") objLog4GeneTabCodeEN.GeneCodeDate = null; //生成代码日期
if (objLog4GeneTabCodeEN.Memo == "[null]") objLog4GeneTabCodeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 Log4GeneTabCodeDA.CheckPropertyNew(objLog4GeneTabCodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 Log4GeneTabCodeDA.CheckProperty4Condition(objLog4GeneTabCodeEN);
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
if (clsLog4GeneTabCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GeneTabCodeBL没有刷新缓存机制(clsLog4GeneTabCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrLog4GeneTabCodeObjLstCache == null)
//{
//arrLog4GeneTabCodeObjLstCache = Log4GeneTabCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLog4GeneTabCodeEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLst_Sel =
arrLog4GeneTabCodeObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrLog4GeneTabCodeObjLst_Sel.Count() == 0)
{
   clsLog4GeneTabCodeEN obj = clsLog4GeneTabCodeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrLog4GeneTabCodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetAllLog4GeneTabCodeObjLstCache()
{
//获取缓存中的对象列表
List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLstCache = GetObjLstCache(); 
return arrLog4GeneTabCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLog4GeneTabCodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
List<clsLog4GeneTabCodeEN> arrLog4GeneTabCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLog4GeneTabCodeObjLstCache;
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
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4GeneTabCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsLog4GeneTabCodeEN._RefreshTimeLst.Count == 0) return "";
return clsLog4GeneTabCodeEN._RefreshTimeLst[clsLog4GeneTabCodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsLog4GeneTabCodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4GeneTabCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsLog4GeneTabCodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Log4GeneTabCode(生成表代码日志)
 /// 唯一性条件:TabId_GCPathId_ApplicationTypeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检测记录是否存在
string strResult = Log4GeneTabCodeDA.GetUniCondStr(objLog4GeneTabCodeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conLog4GeneTabCode.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conLog4GeneTabCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conLog4GeneTabCode._AttributeName));
throw new Exception(strMsg);
}
var objLog4GeneTabCode = clsLog4GeneTabCodeBL.GetObjBymIdCache(lngmId);
if (objLog4GeneTabCode == null) return "";
return objLog4GeneTabCode[strOutFldName].ToString();
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
int intRecCount = clsLog4GeneTabCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsLog4GeneTabCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsLog4GeneTabCodeDA.GetRecCount();
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
int intRecCount = clsLog4GeneTabCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsLog4GeneTabCodeEN objLog4GeneTabCodeCond)
{
List<clsLog4GeneTabCodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLog4GeneTabCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLog4GeneTabCode._AttributeName)
{
if (objLog4GeneTabCodeCond.IsUpdated(strFldName) == false) continue;
if (objLog4GeneTabCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GeneTabCodeCond[strFldName].ToString());
}
else
{
if (objLog4GeneTabCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLog4GeneTabCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLog4GeneTabCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLog4GeneTabCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLog4GeneTabCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLog4GeneTabCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLog4GeneTabCodeCond[strFldName]));
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
 List<string> arrList = clsLog4GeneTabCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Log4GeneTabCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Log4GeneTabCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Log4GeneTabCodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsLog4GeneTabCodeDA.SetFldValue(clsLog4GeneTabCodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Log4GeneTabCodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsLog4GeneTabCodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsLog4GeneTabCodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsLog4GeneTabCodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Log4GeneTabCode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**GC路径Id*/ 
 strCreateTabCode.Append(" GcPathId char(8) Null, "); 
 // /**生成代码日期*/ 
 strCreateTabCode.Append(" GeneCodeDate varchar(20) Null, "); 
 // /**是否需要生成*/ 
 strCreateTabCode.Append(" IsNeedGene bit Null, "); 
 // /**生成代码版本*/ 
 strCreateTabCode.Append(" VersionGeneCode varchar(30) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 生成表代码日志(Log4GeneTabCode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Log4GeneTabCode : clsCommFun4BL
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
clsLog4GeneTabCodeBL.ReFreshThisCache();
}
}

}