
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4RootFldBL
 表名:FieldTab4RootFld(00050422)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsFieldTab4RootFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTab4RootFldEN GetObj(this K_mId_FieldTab4RootFld myKey)
{
clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldBL.FieldTab4RootFldDA.GetObjBymId(myKey.Value);
return objFieldTab4RootFldEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFieldTab4RootFldEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsFieldTab4RootFldBL.AddNewRecord)", objFieldTab4RootFldEN.TabId,objFieldTab4RootFldEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFieldTab4RootFldBL.FieldTab4RootFldDA.AddNewRecordBySQL2(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
public static bool AddRecordEx(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsNeedCheckUniqueness = true)
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
objFieldTab4RootFldEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFieldTab4RootFldEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],字段Id(FldId)=[{1}])已经存在,不能重复!", objFieldTab4RootFldEN.TabId, objFieldTab4RootFldEN.FldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFieldTab4RootFldEN.AddNewRecord();
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFieldTab4RootFldEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsFieldTab4RootFldBL.AddNewRecordWithReturnKey)", objFieldTab4RootFldEN.TabId,objFieldTab4RootFldEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFieldTab4RootFldBL.FieldTab4RootFldDA.AddNewRecordBySQL2WithReturnKey(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetmId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, long lngmId, string strComparisonOp="")
	{
objFieldTab4RootFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.mId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.mId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.mId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetTabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conFieldTab4RootFld.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conFieldTab4RootFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conFieldTab4RootFld.TabId);
}
objFieldTab4RootFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.TabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.TabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.TabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetFldId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conFieldTab4RootFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conFieldTab4RootFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conFieldTab4RootFld.FldId);
}
objFieldTab4RootFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.FldId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.FldId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.FldId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetIsPrimaryKey(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, conFieldTab4RootFld.IsPrimaryKey);
objFieldTab4RootFldEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.IsPrimaryKey) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.IsPrimaryKey, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.IsPrimaryKey] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetIsRootFld(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsRootFld, string strComparisonOp="")
	{
objFieldTab4RootFldEN.IsRootFld = bolIsRootFld; //是否根字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.IsRootFld) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.IsRootFld, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.IsRootFld] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRoot4TabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRoot4TabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoot4TabId, 8, conFieldTab4RootFld.Root4TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoot4TabId, 8, conFieldTab4RootFld.Root4TabId);
}
objFieldTab4RootFldEN.Root4TabId = strRoot4TabId; //主根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.Root4TabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.Root4TabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.Root4TabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRootFldId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRootFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootFldId, 8, conFieldTab4RootFld.RootFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootFldId, 8, conFieldTab4RootFld.RootFldId);
}
objFieldTab4RootFldEN.RootFldId = strRootFldId; //根字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.RootFldId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.RootFldId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.RootFldId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRootTabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRootTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootTabId, 8, conFieldTab4RootFld.RootTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootTabId, 8, conFieldTab4RootFld.RootTabId);
}
objFieldTab4RootFldEN.RootTabId = strRootTabId; //根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.RootTabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.RootTabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.RootTabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetPrjId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFieldTab4RootFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFieldTab4RootFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFieldTab4RootFld.PrjId);
}
objFieldTab4RootFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.PrjId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.PrjId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.PrjId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetUpdUser(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFieldTab4RootFld.UpdUser);
}
objFieldTab4RootFldEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.UpdUser) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.UpdUser, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.UpdUser] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetUpdDate(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFieldTab4RootFld.UpdDate);
}
objFieldTab4RootFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.UpdDate) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.UpdDate, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.UpdDate] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetMemo(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldTab4RootFld.Memo);
}
objFieldTab4RootFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.Memo) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.Memo, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.Memo] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFieldTab4RootFldEN.CheckPropertyNew();
clsFieldTab4RootFldEN objFieldTab4RootFldCond = new clsFieldTab4RootFldEN();
string strCondition = objFieldTab4RootFldCond
.SetmId(objFieldTab4RootFldEN.mId, "<>")
.SetTabId(objFieldTab4RootFldEN.TabId, "=")
.SetFldId(objFieldTab4RootFldEN.FldId, "=")
.GetCombineCondition();
objFieldTab4RootFldEN._IsCheckProperty = true;
bool bolIsExist = clsFieldTab4RootFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_FldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFieldTab4RootFldEN.Update();
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
 /// <param name = "objFieldTab4RootFld">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFieldTab4RootFldEN objFieldTab4RootFld)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFieldTab4RootFldEN objFieldTab4RootFldCond = new clsFieldTab4RootFldEN();
string strCondition = objFieldTab4RootFldCond
.SetTabId(objFieldTab4RootFld.TabId, "=")
.SetFldId(objFieldTab4RootFld.FldId, "=")
.GetCombineCondition();
objFieldTab4RootFld._IsCheckProperty = true;
bool bolIsExist = clsFieldTab4RootFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFieldTab4RootFld.mId = clsFieldTab4RootFldBL.GetFirstID_S(strCondition);
objFieldTab4RootFld.UpdateWithCondition(strCondition);
}
else
{
objFieldTab4RootFld.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 if (objFieldTab4RootFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTab4RootFldBL.FieldTab4RootFldDA.UpdateBySql2(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFieldTab4RootFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFieldTab4RootFldBL.FieldTab4RootFldDA.UpdateBySql2(objFieldTab4RootFldEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strWhereCond)
{
try
{
bool bolResult = clsFieldTab4RootFldBL.FieldTab4RootFldDA.UpdateBySqlWithCondition(objFieldTab4RootFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFieldTab4RootFldBL.FieldTab4RootFldDA.UpdateBySqlWithConditionTransaction(objFieldTab4RootFldEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
public static int Delete(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
try
{
int intRecNum = clsFieldTab4RootFldBL.FieldTab4RootFldDA.DelRecord(objFieldTab4RootFldEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldENS">源对象</param>
 /// <param name = "objFieldTab4RootFldENT">目标对象</param>
 public static void CopyTo(this clsFieldTab4RootFldEN objFieldTab4RootFldENS, clsFieldTab4RootFldEN objFieldTab4RootFldENT)
{
try
{
objFieldTab4RootFldENT.mId = objFieldTab4RootFldENS.mId; //mId
objFieldTab4RootFldENT.TabId = objFieldTab4RootFldENS.TabId; //表ID
objFieldTab4RootFldENT.FldId = objFieldTab4RootFldENS.FldId; //字段Id
objFieldTab4RootFldENT.IsPrimaryKey = objFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objFieldTab4RootFldENT.IsRootFld = objFieldTab4RootFldENS.IsRootFld; //是否根字段
objFieldTab4RootFldENT.Root4TabId = objFieldTab4RootFldENS.Root4TabId; //主根表Id
objFieldTab4RootFldENT.RootFldId = objFieldTab4RootFldENS.RootFldId; //根字段Id
objFieldTab4RootFldENT.RootTabId = objFieldTab4RootFldENS.RootTabId; //根表Id
objFieldTab4RootFldENT.PrjId = objFieldTab4RootFldENS.PrjId; //工程Id
objFieldTab4RootFldENT.UpdUser = objFieldTab4RootFldENS.UpdUser; //修改者
objFieldTab4RootFldENT.UpdDate = objFieldTab4RootFldENS.UpdDate; //修改日期
objFieldTab4RootFldENT.Memo = objFieldTab4RootFldENS.Memo; //说明
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
 /// <param name = "objFieldTab4RootFldENS">源对象</param>
 /// <returns>目标对象=>clsFieldTab4RootFldEN:objFieldTab4RootFldENT</returns>
 public static clsFieldTab4RootFldEN CopyTo(this clsFieldTab4RootFldEN objFieldTab4RootFldENS)
{
try
{
 clsFieldTab4RootFldEN objFieldTab4RootFldENT = new clsFieldTab4RootFldEN()
{
mId = objFieldTab4RootFldENS.mId, //mId
TabId = objFieldTab4RootFldENS.TabId, //表ID
FldId = objFieldTab4RootFldENS.FldId, //字段Id
IsPrimaryKey = objFieldTab4RootFldENS.IsPrimaryKey, //是否主键
IsRootFld = objFieldTab4RootFldENS.IsRootFld, //是否根字段
Root4TabId = objFieldTab4RootFldENS.Root4TabId, //主根表Id
RootFldId = objFieldTab4RootFldENS.RootFldId, //根字段Id
RootTabId = objFieldTab4RootFldENS.RootTabId, //根表Id
PrjId = objFieldTab4RootFldENS.PrjId, //工程Id
UpdUser = objFieldTab4RootFldENS.UpdUser, //修改者
UpdDate = objFieldTab4RootFldENS.UpdDate, //修改日期
Memo = objFieldTab4RootFldENS.Memo, //说明
};
 return objFieldTab4RootFldENT;
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
public static void CheckPropertyNew(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 clsFieldTab4RootFldBL.FieldTab4RootFldDA.CheckPropertyNew(objFieldTab4RootFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 clsFieldTab4RootFldBL.FieldTab4RootFldDA.CheckProperty4Condition(objFieldTab4RootFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTab4RootFldEN objFieldTab4RootFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.mId) == true)
{
string strComparisonOpmId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab4RootFld.mId, objFieldTab4RootFldCond.mId, strComparisonOpmId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.TabId) == true)
{
string strComparisonOpTabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.TabId, objFieldTab4RootFldCond.TabId, strComparisonOpTabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.FldId) == true)
{
string strComparisonOpFldId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.FldId, objFieldTab4RootFldCond.FldId, strComparisonOpFldId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.IsPrimaryKey) == true)
{
if (objFieldTab4RootFldCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab4RootFld.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab4RootFld.IsPrimaryKey);
}
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.IsRootFld) == true)
{
if (objFieldTab4RootFldCond.IsRootFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab4RootFld.IsRootFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab4RootFld.IsRootFld);
}
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.Root4TabId) == true)
{
string strComparisonOpRoot4TabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.Root4TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.Root4TabId, objFieldTab4RootFldCond.Root4TabId, strComparisonOpRoot4TabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.RootFldId) == true)
{
string strComparisonOpRootFldId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.RootFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.RootFldId, objFieldTab4RootFldCond.RootFldId, strComparisonOpRootFldId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.RootTabId) == true)
{
string strComparisonOpRootTabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.RootTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.RootTabId, objFieldTab4RootFldCond.RootTabId, strComparisonOpRootTabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.PrjId) == true)
{
string strComparisonOpPrjId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.PrjId, objFieldTab4RootFldCond.PrjId, strComparisonOpPrjId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.UpdUser) == true)
{
string strComparisonOpUpdUser = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.UpdUser, objFieldTab4RootFldCond.UpdUser, strComparisonOpUpdUser);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.UpdDate, objFieldTab4RootFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.Memo) == true)
{
string strComparisonOpMemo = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.Memo, objFieldTab4RootFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FieldTab4RootFld(工程字段4RootFld), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFieldTab4RootFldEN == null) return true;
if (objFieldTab4RootFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
if (clsFieldTab4RootFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFieldTab4RootFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
if (clsFieldTab4RootFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FieldTab4RootFld(工程字段4RootFld), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFieldTab4RootFldEN == null) return "";
if (objFieldTab4RootFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFieldTab4RootFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FieldTab4RootFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFieldTab4RootFldBL
{
public static RelatedActions_FieldTab4RootFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFieldTab4RootFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFieldTab4RootFldDA FieldTab4RootFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFieldTab4RootFldDA();
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
 public clsFieldTab4RootFldBL()
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
if (string.IsNullOrEmpty(clsFieldTab4RootFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTab4RootFldEN._ConnectString);
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
public static DataTable GetDataTable_FieldTab4RootFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FieldTab4RootFldDA.GetDataTable_FieldTab4RootFld(strWhereCond);
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
objDT = FieldTab4RootFldDA.GetDataTable(strWhereCond);
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
objDT = FieldTab4RootFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FieldTab4RootFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FieldTab4RootFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FieldTab4RootFldDA.GetDataTable_Top(objTopPara);
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
objDT = FieldTab4RootFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FieldTab4RootFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FieldTab4RootFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
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
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFieldTab4RootFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLst_Sel =
arrFieldTab4RootFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFieldTab4RootFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLst(string strWhereCond)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
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
public static List<clsFieldTab4RootFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFieldTab4RootFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFieldTab4RootFldEN> GetSubObjLstCache(clsFieldTab4RootFldEN objFieldTab4RootFldCond)
{
 string strPrjId = objFieldTab4RootFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsFieldTab4RootFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsFieldTab4RootFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldTab4RootFld._AttributeName)
{
if (objFieldTab4RootFldCond.IsUpdated(strFldName) == false) continue;
if (objFieldTab4RootFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTab4RootFldCond[strFldName].ToString());
}
else
{
if (objFieldTab4RootFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTab4RootFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTab4RootFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTab4RootFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTab4RootFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTab4RootFldCond[strFldName]));
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
public static List<clsFieldTab4RootFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
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
List<clsFieldTab4RootFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFieldTab4RootFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFieldTab4RootFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
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
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
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
public static List<clsFieldTab4RootFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFieldTab4RootFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFieldTab4RootFld(ref clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
bool bolResult = FieldTab4RootFldDA.GetFieldTab4RootFld(ref objFieldTab4RootFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTab4RootFldEN GetObjBymId(long lngmId)
{
clsFieldTab4RootFldEN objFieldTab4RootFldEN = FieldTab4RootFldDA.GetObjBymId(lngmId);
return objFieldTab4RootFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFieldTab4RootFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = FieldTab4RootFldDA.GetFirstObj(strWhereCond);
 return objFieldTab4RootFldEN;
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
public static clsFieldTab4RootFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = FieldTab4RootFldDA.GetObjByDataRow(objRow);
 return objFieldTab4RootFldEN;
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
public static clsFieldTab4RootFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = FieldTab4RootFldDA.GetObjByDataRow(objRow);
 return objFieldTab4RootFldEN;
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
 /// <param name = "lstFieldTab4RootFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTab4RootFldEN GetObjBymIdFromList(long lngmId, List<clsFieldTab4RootFldEN> lstFieldTab4RootFldObjLst)
{
foreach (clsFieldTab4RootFldEN objFieldTab4RootFldEN in lstFieldTab4RootFldObjLst)
{
if (objFieldTab4RootFldEN.mId == lngmId)
{
return objFieldTab4RootFldEN;
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
 lngmId = new clsFieldTab4RootFldDA().GetFirstID(strWhereCond);
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
 arrList = FieldTab4RootFldDA.GetID(strWhereCond);
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
bool bolIsExist = FieldTab4RootFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FieldTab4RootFldDA.IsExist(lngmId);
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
clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldBL.GetObjBymId(lngmId);
objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFieldTab4RootFldEN.UpdUser = strOpUser;
return clsFieldTab4RootFldBL.UpdateBySql2(objFieldTab4RootFldEN);
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
 bolIsExist = clsFieldTab4RootFldDA.IsExistTable();
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
 bolIsExist = FieldTab4RootFldDA.IsExistTable(strTabName);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFieldTab4RootFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsFieldTab4RootFldBL.AddNewRecordBySql2)", objFieldTab4RootFldEN.TabId,objFieldTab4RootFldEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FieldTab4RootFldDA.AddNewRecordBySQL2(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFieldTab4RootFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsFieldTab4RootFldBL.AddNewRecordBySql2WithReturnKey)", objFieldTab4RootFldEN.TabId,objFieldTab4RootFldEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = FieldTab4RootFldDA.AddNewRecordBySQL2WithReturnKey(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
try
{
bool bolResult = FieldTab4RootFldDA.Update(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 if (objFieldTab4RootFldEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FieldTab4RootFldDA.UpdateBySql2(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldBL.ReFreshCache(objFieldTab4RootFldEN.PrjId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
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
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldBL.GetObjBymId(lngmId);

if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(objFieldTab4RootFldEN.mId, objFieldTab4RootFldEN.UpdUser);
}
if (objFieldTab4RootFldEN != null)
{
int intRecNum = FieldTab4RootFldDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
//删除与表:[FieldTab4RootFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFieldTab4RootFld.mId,
//lngmId);
//        clsFieldTab4RootFldBL.DelFieldTab4RootFldsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTab4RootFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTab4RootFldBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFieldTab4RootFldBL.relatedActions != null)
{
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FieldTab4RootFldDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFieldTab4RootFlds(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFieldTab4RootFldBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = FieldTab4RootFldDA.DelFieldTab4RootFld(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
public static int DelFieldTab4RootFldsByCond(string strWhereCond)
{
try
{
if (clsFieldTab4RootFldBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFieldTab4RootFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conFieldTab4RootFld.PrjId, strWhereCond);
int intRecNum = FieldTab4RootFldDA.DelFieldTab4RootFld(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FieldTab4RootFld]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
//删除与表:[FieldTab4RootFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFieldTab4RootFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFieldTab4RootFldBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFieldTab4RootFldENS">源对象</param>
 /// <param name = "objFieldTab4RootFldENT">目标对象</param>
 public static void CopyTo(clsFieldTab4RootFldEN objFieldTab4RootFldENS, clsFieldTab4RootFldEN objFieldTab4RootFldENT)
{
try
{
objFieldTab4RootFldENT.mId = objFieldTab4RootFldENS.mId; //mId
objFieldTab4RootFldENT.TabId = objFieldTab4RootFldENS.TabId; //表ID
objFieldTab4RootFldENT.FldId = objFieldTab4RootFldENS.FldId; //字段Id
objFieldTab4RootFldENT.IsPrimaryKey = objFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objFieldTab4RootFldENT.IsRootFld = objFieldTab4RootFldENS.IsRootFld; //是否根字段
objFieldTab4RootFldENT.Root4TabId = objFieldTab4RootFldENS.Root4TabId; //主根表Id
objFieldTab4RootFldENT.RootFldId = objFieldTab4RootFldENS.RootFldId; //根字段Id
objFieldTab4RootFldENT.RootTabId = objFieldTab4RootFldENS.RootTabId; //根表Id
objFieldTab4RootFldENT.PrjId = objFieldTab4RootFldENS.PrjId; //工程Id
objFieldTab4RootFldENT.UpdUser = objFieldTab4RootFldENS.UpdUser; //修改者
objFieldTab4RootFldENT.UpdDate = objFieldTab4RootFldENS.UpdDate; //修改日期
objFieldTab4RootFldENT.Memo = objFieldTab4RootFldENS.Memo; //说明
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
 /// <param name = "objFieldTab4RootFldEN">源简化对象</param>
 public static void SetUpdFlag(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
try
{
objFieldTab4RootFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFieldTab4RootFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFieldTab4RootFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.mId = objFieldTab4RootFldEN.mId; //mId
}
if (arrFldSet.Contains(conFieldTab4RootFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.TabId = objFieldTab4RootFldEN.TabId; //表ID
}
if (arrFldSet.Contains(conFieldTab4RootFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.FldId = objFieldTab4RootFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(conFieldTab4RootFld.IsPrimaryKey, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.IsPrimaryKey = objFieldTab4RootFldEN.IsPrimaryKey; //是否主键
}
if (arrFldSet.Contains(conFieldTab4RootFld.IsRootFld, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.IsRootFld = objFieldTab4RootFldEN.IsRootFld; //是否根字段
}
if (arrFldSet.Contains(conFieldTab4RootFld.Root4TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.Root4TabId = objFieldTab4RootFldEN.Root4TabId == "[null]" ? null :  objFieldTab4RootFldEN.Root4TabId; //主根表Id
}
if (arrFldSet.Contains(conFieldTab4RootFld.RootFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.RootFldId = objFieldTab4RootFldEN.RootFldId == "[null]" ? null :  objFieldTab4RootFldEN.RootFldId; //根字段Id
}
if (arrFldSet.Contains(conFieldTab4RootFld.RootTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.RootTabId = objFieldTab4RootFldEN.RootTabId == "[null]" ? null :  objFieldTab4RootFldEN.RootTabId; //根表Id
}
if (arrFldSet.Contains(conFieldTab4RootFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.PrjId = objFieldTab4RootFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFieldTab4RootFld.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.UpdUser = objFieldTab4RootFldEN.UpdUser == "[null]" ? null :  objFieldTab4RootFldEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFieldTab4RootFld.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.UpdDate = objFieldTab4RootFldEN.UpdDate == "[null]" ? null :  objFieldTab4RootFldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFieldTab4RootFld.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFieldTab4RootFldEN.Memo = objFieldTab4RootFldEN.Memo == "[null]" ? null :  objFieldTab4RootFldEN.Memo; //说明
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
 /// <param name = "objFieldTab4RootFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
try
{
if (objFieldTab4RootFldEN.Root4TabId == "[null]") objFieldTab4RootFldEN.Root4TabId = null; //主根表Id
if (objFieldTab4RootFldEN.RootFldId == "[null]") objFieldTab4RootFldEN.RootFldId = null; //根字段Id
if (objFieldTab4RootFldEN.RootTabId == "[null]") objFieldTab4RootFldEN.RootTabId = null; //根表Id
if (objFieldTab4RootFldEN.UpdUser == "[null]") objFieldTab4RootFldEN.UpdUser = null; //修改者
if (objFieldTab4RootFldEN.UpdDate == "[null]") objFieldTab4RootFldEN.UpdDate = null; //修改日期
if (objFieldTab4RootFldEN.Memo == "[null]") objFieldTab4RootFldEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 FieldTab4RootFldDA.CheckPropertyNew(objFieldTab4RootFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 FieldTab4RootFldDA.CheckProperty4Condition(objFieldTab4RootFldEN);
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
if (clsFieldTab4RootFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTab4RootFldBL没有刷新缓存机制(clsFieldTab4RootFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFieldTab4RootFldObjLstCache == null)
//{
//arrFieldTab4RootFldObjLstCache = FieldTab4RootFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTab4RootFldEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLst_Sel =
arrFieldTab4RootFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFieldTab4RootFldObjLst_Sel.Count() == 0)
{
   clsFieldTab4RootFldEN obj = clsFieldTab4RootFldBL.GetObjBymId(lngmId);
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
return arrFieldTab4RootFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetAllFieldTab4RootFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId); 
return arrFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrFieldTab4RootFldObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTab4RootFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFieldTab4RootFldEN._RefreshTimeLst.Count == 0) return "";
return clsFieldTab4RootFldEN._RefreshTimeLst[clsFieldTab4RootFldEN._RefreshTimeLst.Count - 1];
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
if (clsFieldTab4RootFldBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTab4RootFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFieldTab4RootFldBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FieldTab4RootFld(工程字段4RootFld)
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检测记录是否存在
string strResult = FieldTab4RootFldDA.GetUniCondStr(objFieldTab4RootFldEN);
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
if (strInFldName != conFieldTab4RootFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFieldTab4RootFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFieldTab4RootFld._AttributeName));
throw new Exception(strMsg);
}
var objFieldTab4RootFld = clsFieldTab4RootFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objFieldTab4RootFld == null) return "";
return objFieldTab4RootFld[strOutFldName].ToString();
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
int intRecCount = clsFieldTab4RootFldDA.GetRecCount(strTabName);
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
int intRecCount = clsFieldTab4RootFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFieldTab4RootFldDA.GetRecCount();
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
int intRecCount = clsFieldTab4RootFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFieldTab4RootFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFieldTab4RootFldEN objFieldTab4RootFldCond)
{
 string strPrjId = objFieldTab4RootFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsFieldTab4RootFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsFieldTab4RootFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFieldTab4RootFld._AttributeName)
{
if (objFieldTab4RootFldCond.IsUpdated(strFldName) == false) continue;
if (objFieldTab4RootFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTab4RootFldCond[strFldName].ToString());
}
else
{
if (objFieldTab4RootFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFieldTab4RootFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFieldTab4RootFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFieldTab4RootFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFieldTab4RootFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFieldTab4RootFldCond[strFldName]));
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
 List<string> arrList = clsFieldTab4RootFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FieldTab4RootFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FieldTab4RootFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FieldTab4RootFldDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTab4RootFldDA.SetFldValue(clsFieldTab4RootFldEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FieldTab4RootFldDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTab4RootFldDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFieldTab4RootFldDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFieldTab4RootFldDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FieldTab4RootFld] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**是否主键*/ 
 strCreateTabCode.Append(" IsPrimaryKey bit not Null, "); 
 // /**是否根字段*/ 
 strCreateTabCode.Append(" IsRootFld bit Null, "); 
 // /**主根表Id*/ 
 strCreateTabCode.Append(" Root4TabId char(8) Null, "); 
 // /**根字段Id*/ 
 strCreateTabCode.Append(" RootFldId char(8) Null, "); 
 // /**根表Id*/ 
 strCreateTabCode.Append(" RootTabId char(8) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FieldTab4RootFld : clsCommFun4BLV2
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
clsFieldTab4RootFldBL.ReFreshThisCache(strPrjId);
}
}

}