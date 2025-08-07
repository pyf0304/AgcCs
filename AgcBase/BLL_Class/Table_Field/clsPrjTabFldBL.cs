
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabFldBL
 表名:PrjTabFld(00050019)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:50
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
public static class  clsPrjTabFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabFldEN GetObj(this K_mId_PrjTabFld myKey)
{
clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.PrjTabFldDA.GetObjBymId(myKey.Value);
return objPrjTabFldEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabFldEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsPrjTabFldBL.AddNewRecord)", objPrjTabFldEN.TabId,objPrjTabFldEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPrjTabFldBL.PrjTabFldDA.AddNewRecordBySQL2(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
public static bool AddRecordEx(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsNeedCheckUniqueness = true)
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
objPrjTabFldEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjTabFldEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表ID(TabId)=[{0}],字段Id(FldId)=[{1}])已经存在,不能重复!", objPrjTabFldEN.TabId, objPrjTabFldEN.FldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPrjTabFldEN.AddNewRecord();
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabFldEN) == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsPrjTabFldBL.AddNewRecordWithReturnKey)", objPrjTabFldEN.TabId,objPrjTabFldEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPrjTabFldBL.PrjTabFldDA.AddNewRecordBySQL2WithReturnKey(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetmId(this clsPrjTabFldEN objPrjTabFldEN, long lngmId, string strComparisonOp="")
	{
objPrjTabFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.mId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.mId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.mId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetTabId(this clsPrjTabFldEN objPrjTabFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjTabFld.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTabFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTabFld.TabId);
}
objPrjTabFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.TabId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.TabId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.TabId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldId(this clsPrjTabFldEN objPrjTabFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conPrjTabFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conPrjTabFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conPrjTabFld.FldId);
}
objPrjTabFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetPrjId(this clsPrjTabFldEN objPrjTabFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjTabFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTabFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTabFld.PrjId);
}
objPrjTabFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.PrjId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.PrjId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.PrjId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFieldTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, conPrjTabFld.FieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conPrjTabFld.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conPrjTabFld.FieldTypeId);
}
objPrjTabFldEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FieldTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FieldTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FieldTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabNullable(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTabNullable, conPrjTabFld.IsTabNullable);
objPrjTabFldEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabNullable) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabNullable, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabNullable] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabUnique(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objPrjTabFldEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabUnique) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabUnique, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabUnique] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabForeignKey(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
objPrjTabFldEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabForeignKey) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabForeignKey, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabForeignKey] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsSortFld(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsSortFld, string strComparisonOp="")
	{
objPrjTabFldEN.IsSortFld = bolIsSortFld; //是否排序字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsSortFld) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsSortFld, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsSortFld] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsGeneProp(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsGeneProp, string strComparisonOp="")
	{
objPrjTabFldEN.IsGeneProp = bolIsGeneProp; //是否生成属性
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsGeneProp) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsGeneProp, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsGeneProp] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsForExtendClass(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsForExtendClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsForExtendClass, conPrjTabFld.IsForExtendClass);
objPrjTabFldEN.IsForExtendClass = bolIsForExtendClass; //用于扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsForExtendClass) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsForExtendClass, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsForExtendClass] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetCtlTypeIdDu(this clsPrjTabFldEN objPrjTabFldEN, string strCtlTypeIdDu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
}
objPrjTabFldEN.CtlTypeIdDu = strCtlTypeIdDu; //控件类型Id_du
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.CtlTypeIdDu) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.CtlTypeIdDu, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.CtlTypeIdDu] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldDispUnitStyleId(this clsPrjTabFldEN objPrjTabFldEN, string strFldDispUnitStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
}
objPrjTabFldEN.FldDispUnitStyleId = strFldDispUnitStyleId; //字段显示单元样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldDispUnitStyleId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldDispUnitStyleId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldDispUnitStyleId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetInFldId(this clsPrjTabFldEN objPrjTabFldEN, string strInFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInFldId, 8, conPrjTabFld.InFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInFldId, 8, conPrjTabFld.InFldId);
}
objPrjTabFldEN.InFldId = strInFldId; //In字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.InFldId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.InFldId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.InFldId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetDnPathId(this clsPrjTabFldEN objPrjTabFldEN, string strDnPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conPrjTabFld.DnPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conPrjTabFld.DnPathId);
}
objPrjTabFldEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.DnPathId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.DnPathId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.DnPathId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetKeyId4Test(this clsPrjTabFldEN objPrjTabFldEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conPrjTabFld.KeyId4Test);
}
objPrjTabFldEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.KeyId4Test) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.KeyId4Test, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.KeyId4Test] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetDisplayFormat(this clsPrjTabFldEN objPrjTabFldEN, string strDisplayFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisplayFormat, 50, conPrjTabFld.DisplayFormat);
}
objPrjTabFldEN.DisplayFormat = strDisplayFormat; //显示格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.DisplayFormat) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.DisplayFormat, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.DisplayFormat] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsParentObj(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsParentObj, string strComparisonOp="")
	{
objPrjTabFldEN.IsParentObj = bolIsParentObj; //是否父对象
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsParentObj) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsParentObj, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsParentObj] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetPrimaryTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, conPrjTabFld.PrimaryTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
}
objPrjTabFldEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.PrimaryTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.PrimaryTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.PrimaryTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetForeignKeyTabId(this clsPrjTabFldEN objPrjTabFldEN, string strForeignKeyTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
}
objPrjTabFldEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.ForeignKeyTabId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.ForeignKeyTabId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.ForeignKeyTabId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldOpTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strFldOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeId, conPrjTabFld.FldOpTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
}
objPrjTabFldEN.FldOpTypeId = strFldOpTypeId; //字段操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldOpTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldOpTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldOpTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetSequenceNumber(this clsPrjTabFldEN objPrjTabFldEN, int? intSequenceNumber, string strComparisonOp="")
	{
objPrjTabFldEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.SequenceNumber) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.SequenceNumber, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.SequenceNumber] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetMemoInTab(this clsPrjTabFldEN objPrjTabFldEN, string strMemoInTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemoInTab, 1000, conPrjTabFld.MemoInTab);
}
objPrjTabFldEN.MemoInTab = strMemoInTab; //表中说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.MemoInTab) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.MemoInTab, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.MemoInTab] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetErrMsg(this clsPrjTabFldEN objPrjTabFldEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjTabFld.ErrMsg);
}
objPrjTabFldEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.ErrMsg) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.ErrMsg, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.ErrMsg] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetUpdDate(this clsPrjTabFldEN objPrjTabFldEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjTabFld.UpdDate);
}
objPrjTabFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.UpdDate) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.UpdDate, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.UpdDate] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetUpdUser(this clsPrjTabFldEN objPrjTabFldEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjTabFld.UpdUser);
}
objPrjTabFldEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.UpdUser) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.UpdUser, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.UpdUser] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetMemo(this clsPrjTabFldEN objPrjTabFldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTabFld.Memo);
}
objPrjTabFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.Memo) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.Memo, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.Memo] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjTabFldEN objPrjTabFldEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjTabFldEN.CheckPropertyNew();
clsPrjTabFldEN objPrjTabFldCond = new clsPrjTabFldEN();
string strCondition = objPrjTabFldCond
.SetmId(objPrjTabFldEN.mId, "<>")
.SetTabId(objPrjTabFldEN.TabId, "=")
.SetFldId(objPrjTabFldEN.FldId, "=")
.GetCombineCondition();
objPrjTabFldEN._IsCheckProperty = true;
bool bolIsExist = clsPrjTabFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabId_FldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjTabFldEN.Update();
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
 /// <param name = "objPrjTabFld">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjTabFldEN objPrjTabFld)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjTabFldEN objPrjTabFldCond = new clsPrjTabFldEN();
string strCondition = objPrjTabFldCond
.SetTabId(objPrjTabFld.TabId, "=")
.SetFldId(objPrjTabFld.FldId, "=")
.GetCombineCondition();
objPrjTabFld._IsCheckProperty = true;
bool bolIsExist = clsPrjTabFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjTabFld.mId = clsPrjTabFldBL.GetFirstID_S(strCondition);
objPrjTabFld.UpdateWithCondition(strCondition);
}
else
{
objPrjTabFld.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabFldEN objPrjTabFldEN)
{
 if (objPrjTabFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabFldBL.PrjTabFldDA.UpdateBySql2(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabFldEN objPrjTabFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrjTabFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabFldBL.PrjTabFldDA.UpdateBySql2(objPrjTabFldEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabFldEN objPrjTabFldEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjTabFldBL.PrjTabFldDA.UpdateBySqlWithCondition(objPrjTabFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabFldEN objPrjTabFldEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjTabFldBL.PrjTabFldDA.UpdateBySqlWithConditionTransaction(objPrjTabFldEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
public static int Delete(this clsPrjTabFldEN objPrjTabFldEN)
{
try
{
int intRecNum = clsPrjTabFldBL.PrjTabFldDA.DelRecord(objPrjTabFldEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldENS">源对象</param>
 /// <param name = "objPrjTabFldENT">目标对象</param>
 public static void CopyTo(this clsPrjTabFldEN objPrjTabFldENS, clsPrjTabFldEN objPrjTabFldENT)
{
try
{
objPrjTabFldENT.mId = objPrjTabFldENS.mId; //mId
objPrjTabFldENT.TabId = objPrjTabFldENS.TabId; //表ID
objPrjTabFldENT.FldId = objPrjTabFldENS.FldId; //字段Id
objPrjTabFldENT.PrjId = objPrjTabFldENS.PrjId; //工程Id
objPrjTabFldENT.FieldTypeId = objPrjTabFldENS.FieldTypeId; //字段类型Id
objPrjTabFldENT.IsTabNullable = objPrjTabFldENS.IsTabNullable; //是否表中可空
objPrjTabFldENT.IsTabUnique = objPrjTabFldENS.IsTabUnique; //是否表中唯一
objPrjTabFldENT.IsTabForeignKey = objPrjTabFldENS.IsTabForeignKey; //是否表外键
objPrjTabFldENT.IsSortFld = objPrjTabFldENS.IsSortFld; //是否排序字段
objPrjTabFldENT.IsGeneProp = objPrjTabFldENS.IsGeneProp; //是否生成属性
objPrjTabFldENT.IsForExtendClass = objPrjTabFldENS.IsForExtendClass; //用于扩展类
objPrjTabFldENT.CtlTypeIdDu = objPrjTabFldENS.CtlTypeIdDu; //控件类型Id_du
objPrjTabFldENT.FldDispUnitStyleId = objPrjTabFldENS.FldDispUnitStyleId; //字段显示单元样式Id
objPrjTabFldENT.InFldId = objPrjTabFldENS.InFldId; //In字段Id
objPrjTabFldENT.DnPathId = objPrjTabFldENS.DnPathId; //DN路径Id
objPrjTabFldENT.KeyId4Test = objPrjTabFldENS.KeyId4Test; //测试关键字Id
objPrjTabFldENT.DisplayFormat = objPrjTabFldENS.DisplayFormat; //显示格式
objPrjTabFldENT.IsParentObj = objPrjTabFldENS.IsParentObj; //是否父对象
objPrjTabFldENT.PrimaryTypeId = objPrjTabFldENS.PrimaryTypeId; //主键类型ID
objPrjTabFldENT.ForeignKeyTabId = objPrjTabFldENS.ForeignKeyTabId; //外键表ID
objPrjTabFldENT.FldOpTypeId = objPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objPrjTabFldENT.SequenceNumber = objPrjTabFldENS.SequenceNumber; //顺序号
objPrjTabFldENT.MemoInTab = objPrjTabFldENS.MemoInTab; //表中说明
objPrjTabFldENT.ErrMsg = objPrjTabFldENS.ErrMsg; //错误信息
objPrjTabFldENT.UpdDate = objPrjTabFldENS.UpdDate; //修改日期
objPrjTabFldENT.UpdUser = objPrjTabFldENS.UpdUser; //修改者
objPrjTabFldENT.Memo = objPrjTabFldENS.Memo; //说明
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
 /// <param name = "objPrjTabFldENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabFldEN:objPrjTabFldENT</returns>
 public static clsPrjTabFldEN CopyTo(this clsPrjTabFldEN objPrjTabFldENS)
{
try
{
 clsPrjTabFldEN objPrjTabFldENT = new clsPrjTabFldEN()
{
mId = objPrjTabFldENS.mId, //mId
TabId = objPrjTabFldENS.TabId, //表ID
FldId = objPrjTabFldENS.FldId, //字段Id
PrjId = objPrjTabFldENS.PrjId, //工程Id
FieldTypeId = objPrjTabFldENS.FieldTypeId, //字段类型Id
IsTabNullable = objPrjTabFldENS.IsTabNullable, //是否表中可空
IsTabUnique = objPrjTabFldENS.IsTabUnique, //是否表中唯一
IsTabForeignKey = objPrjTabFldENS.IsTabForeignKey, //是否表外键
IsSortFld = objPrjTabFldENS.IsSortFld, //是否排序字段
IsGeneProp = objPrjTabFldENS.IsGeneProp, //是否生成属性
IsForExtendClass = objPrjTabFldENS.IsForExtendClass, //用于扩展类
CtlTypeIdDu = objPrjTabFldENS.CtlTypeIdDu, //控件类型Id_du
FldDispUnitStyleId = objPrjTabFldENS.FldDispUnitStyleId, //字段显示单元样式Id
InFldId = objPrjTabFldENS.InFldId, //In字段Id
DnPathId = objPrjTabFldENS.DnPathId, //DN路径Id
KeyId4Test = objPrjTabFldENS.KeyId4Test, //测试关键字Id
DisplayFormat = objPrjTabFldENS.DisplayFormat, //显示格式
IsParentObj = objPrjTabFldENS.IsParentObj, //是否父对象
PrimaryTypeId = objPrjTabFldENS.PrimaryTypeId, //主键类型ID
ForeignKeyTabId = objPrjTabFldENS.ForeignKeyTabId, //外键表ID
FldOpTypeId = objPrjTabFldENS.FldOpTypeId, //字段操作类型Id
SequenceNumber = objPrjTabFldENS.SequenceNumber, //顺序号
MemoInTab = objPrjTabFldENS.MemoInTab, //表中说明
ErrMsg = objPrjTabFldENS.ErrMsg, //错误信息
UpdDate = objPrjTabFldENS.UpdDate, //修改日期
UpdUser = objPrjTabFldENS.UpdUser, //修改者
Memo = objPrjTabFldENS.Memo, //说明
};
 return objPrjTabFldENT;
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
public static void CheckPropertyNew(this clsPrjTabFldEN objPrjTabFldEN)
{
 clsPrjTabFldBL.PrjTabFldDA.CheckPropertyNew(objPrjTabFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjTabFldEN objPrjTabFldEN)
{
 clsPrjTabFldBL.PrjTabFldDA.CheckProperty4Condition(objPrjTabFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabFldEN objPrjTabFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.mId) == true)
{
string strComparisonOpmId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTabFld.mId, objPrjTabFldCond.mId, strComparisonOpmId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.TabId) == true)
{
string strComparisonOpTabId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.TabId, objPrjTabFldCond.TabId, strComparisonOpTabId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldId) == true)
{
string strComparisonOpFldId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldId, objPrjTabFldCond.FldId, strComparisonOpFldId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.PrjId, objPrjTabFldCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FieldTypeId, objPrjTabFldCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabNullable) == true)
{
if (objPrjTabFldCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabNullable);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabUnique) == true)
{
if (objPrjTabFldCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabUnique);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabForeignKey) == true)
{
if (objPrjTabFldCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabForeignKey);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsSortFld) == true)
{
if (objPrjTabFldCond.IsSortFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsSortFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsSortFld);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsGeneProp) == true)
{
if (objPrjTabFldCond.IsGeneProp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsGeneProp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsGeneProp);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsForExtendClass) == true)
{
if (objPrjTabFldCond.IsForExtendClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsForExtendClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsForExtendClass);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.CtlTypeIdDu) == true)
{
string strComparisonOpCtlTypeIdDu = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.CtlTypeIdDu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.CtlTypeIdDu, objPrjTabFldCond.CtlTypeIdDu, strComparisonOpCtlTypeIdDu);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldDispUnitStyleId) == true)
{
string strComparisonOpFldDispUnitStyleId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldDispUnitStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldDispUnitStyleId, objPrjTabFldCond.FldDispUnitStyleId, strComparisonOpFldDispUnitStyleId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.InFldId) == true)
{
string strComparisonOpInFldId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.InFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.InFldId, objPrjTabFldCond.InFldId, strComparisonOpInFldId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.DnPathId) == true)
{
string strComparisonOpDnPathId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.DnPathId, objPrjTabFldCond.DnPathId, strComparisonOpDnPathId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.KeyId4Test, objPrjTabFldCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.DisplayFormat) == true)
{
string strComparisonOpDisplayFormat = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.DisplayFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.DisplayFormat, objPrjTabFldCond.DisplayFormat, strComparisonOpDisplayFormat);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsParentObj) == true)
{
if (objPrjTabFldCond.IsParentObj == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsParentObj);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsParentObj);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.PrimaryTypeId, objPrjTabFldCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.ForeignKeyTabId, objPrjTabFldCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldOpTypeId) == true)
{
string strComparisonOpFldOpTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldOpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldOpTypeId, objPrjTabFldCond.FldOpTypeId, strComparisonOpFldOpTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTabFld.SequenceNumber, objPrjTabFldCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.MemoInTab) == true)
{
string strComparisonOpMemoInTab = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.MemoInTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.MemoInTab, objPrjTabFldCond.MemoInTab, strComparisonOpMemoInTab);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.ErrMsg, objPrjTabFldCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.UpdDate, objPrjTabFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.UpdUser, objPrjTabFldCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.Memo) == true)
{
string strComparisonOpMemo = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.Memo, objPrjTabFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjTabFld(工程表字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjTabFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjTabFldEN objPrjTabFldEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabFldEN == null) return true;
if (objPrjTabFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
if (clsPrjTabFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objPrjTabFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
if (clsPrjTabFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjTabFld(工程表字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjTabFldEN objPrjTabFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabFldEN == null) return "";
if (objPrjTabFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objPrjTabFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjTabFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
if (objPrjTabFld == null) return false;
 var objPrjTab = clsPrjTabBL.GetObjByTabId(objPrjTabFld.TabId);
if (objPrjTab == null) return false;
clsPrjTabBL.SetUpdDate(objPrjTabFld.TabId, strOpUser);
return true;
}
}
 /// <summary>
 /// 工程表字段(PrjTabFld)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabFldBL
{
public static RelatedActions_PrjTabFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjTabFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjTabFldDA PrjTabFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjTabFldDA();
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
 public clsPrjTabFldBL()
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
if (string.IsNullOrEmpty(clsPrjTabFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabFldEN._ConnectString);
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
public static DataTable GetDataTable_PrjTabFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjTabFldDA.GetDataTable_PrjTabFld(strWhereCond);
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
objDT = PrjTabFldDA.GetDataTable(strWhereCond);
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
objDT = PrjTabFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjTabFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjTabFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjTabFldDA.GetDataTable_Top(objTopPara);
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
objDT = PrjTabFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjTabFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjTabFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsPrjTabFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
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
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjTabFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
arrPrjTabFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrPrjTabFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLst(string strWhereCond)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
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
public static List<clsPrjTabFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjTabFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjTabFldEN> GetSubObjLstCache(clsPrjTabFldEN objPrjTabFldCond)
{
 string strPrjId = objPrjTabFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPrjTabFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPrjTabFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTabFld._AttributeName)
{
if (objPrjTabFldCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabFldCond[strFldName].ToString());
}
else
{
if (objPrjTabFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabFldCond[strFldName]));
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
public static List<clsPrjTabFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
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
public static List<clsPrjTabFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
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
List<clsPrjTabFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjTabFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjTabFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
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
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
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
public static List<clsPrjTabFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjTabFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
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
public static List<clsPrjTabFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjTabFldEN> arrObjLst = new List<clsPrjTabFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN();
try
{
objPrjTabFldEN.mId = Int32.Parse(objRow[conPrjTabFld.mId].ToString().Trim()); //mId
objPrjTabFldEN.TabId = objRow[conPrjTabFld.TabId].ToString().Trim(); //表ID
objPrjTabFldEN.FldId = objRow[conPrjTabFld.FldId].ToString().Trim(); //字段Id
objPrjTabFldEN.PrjId = objRow[conPrjTabFld.PrjId].ToString().Trim(); //工程Id
objPrjTabFldEN.FieldTypeId = objRow[conPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objPrjTabFldEN.IsGeneProp = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsGeneProp].ToString().Trim()); //是否生成属性
objPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objPrjTabFldEN.CtlTypeIdDu = objRow[conPrjTabFld.CtlTypeIdDu] == DBNull.Value ? null : objRow[conPrjTabFld.CtlTypeIdDu].ToString().Trim(); //控件类型Id_du
objPrjTabFldEN.FldDispUnitStyleId = objRow[conPrjTabFld.FldDispUnitStyleId] == DBNull.Value ? null : objRow[conPrjTabFld.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objPrjTabFldEN.InFldId = objRow[conPrjTabFld.InFldId] == DBNull.Value ? null : objRow[conPrjTabFld.InFldId].ToString().Trim(); //In字段Id
objPrjTabFldEN.DnPathId = objRow[conPrjTabFld.DnPathId] == DBNull.Value ? null : objRow[conPrjTabFld.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabFldEN.KeyId4Test = objRow[conPrjTabFld.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTabFld.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabFldEN.DisplayFormat = objRow[conPrjTabFld.DisplayFormat] == DBNull.Value ? null : objRow[conPrjTabFld.DisplayFormat].ToString().Trim(); //显示格式
objPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objPrjTabFldEN.PrimaryTypeId = objRow[conPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objPrjTabFldEN.ForeignKeyTabId = objRow[conPrjTabFld.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabFldEN.FldOpTypeId = objRow[conPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objPrjTabFldEN.SequenceNumber = objRow[conPrjTabFld.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objPrjTabFldEN.MemoInTab = objRow[conPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[conPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objPrjTabFldEN.ErrMsg = objRow[conPrjTabFld.ErrMsg] == DBNull.Value ? null : objRow[conPrjTabFld.ErrMsg].ToString().Trim(); //错误信息
objPrjTabFldEN.UpdDate = objRow[conPrjTabFld.UpdDate] == DBNull.Value ? null : objRow[conPrjTabFld.UpdDate].ToString().Trim(); //修改日期
objPrjTabFldEN.UpdUser = objRow[conPrjTabFld.UpdUser] == DBNull.Value ? null : objRow[conPrjTabFld.UpdUser].ToString().Trim(); //修改者
objPrjTabFldEN.Memo = objRow[conPrjTabFld.Memo] == DBNull.Value ? null : objRow[conPrjTabFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjTabFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjTabFld(ref clsPrjTabFldEN objPrjTabFldEN)
{
bool bolResult = PrjTabFldDA.GetPrjTabFld(ref objPrjTabFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabFldEN GetObjBymId(long lngmId)
{
clsPrjTabFldEN objPrjTabFldEN = PrjTabFldDA.GetObjBymId(lngmId);
return objPrjTabFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjTabFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjTabFldEN objPrjTabFldEN = PrjTabFldDA.GetFirstObj(strWhereCond);
 return objPrjTabFldEN;
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
public static clsPrjTabFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjTabFldEN objPrjTabFldEN = PrjTabFldDA.GetObjByDataRow(objRow);
 return objPrjTabFldEN;
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
public static clsPrjTabFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjTabFldEN objPrjTabFldEN = PrjTabFldDA.GetObjByDataRow(objRow);
 return objPrjTabFldEN;
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
 /// <param name = "lstPrjTabFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabFldEN GetObjBymIdFromList(long lngmId, List<clsPrjTabFldEN> lstPrjTabFldObjLst)
{
foreach (clsPrjTabFldEN objPrjTabFldEN in lstPrjTabFldObjLst)
{
if (objPrjTabFldEN.mId == lngmId)
{
return objPrjTabFldEN;
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
 lngmId = new clsPrjTabFldDA().GetFirstID(strWhereCond);
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
 arrList = PrjTabFldDA.GetID(strWhereCond);
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
bool bolIsExist = PrjTabFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = PrjTabFldDA.IsExist(lngmId);
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
clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);
objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjTabFldEN.UpdUser = strOpUser;
return clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
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
 bolIsExist = clsPrjTabFldDA.IsExistTable();
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
 bolIsExist = PrjTabFldDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjTabFldEN objPrjTabFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjTabFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsPrjTabFldBL.AddNewRecordBySql2)", objPrjTabFldEN.TabId,objPrjTabFldEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PrjTabFldDA.AddNewRecordBySQL2(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjTabFldEN objPrjTabFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objPrjTabFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表ID = [{0}],字段Id = [{1}]的数据已经存在!(in clsPrjTabFldBL.AddNewRecordBySql2WithReturnKey)", objPrjTabFldEN.TabId,objPrjTabFldEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = PrjTabFldDA.AddNewRecordBySQL2WithReturnKey(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjTabFldEN objPrjTabFldEN)
{
try
{
bool bolResult = PrjTabFldDA.Update(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjTabFldEN objPrjTabFldEN)
{
 if (objPrjTabFldEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjTabFldDA.UpdateBySql2(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldBL.ReFreshCache(objPrjTabFldEN.PrjId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
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
 clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);

if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(objPrjTabFldEN.mId, objPrjTabFldEN.UpdUser);
}
if (objPrjTabFldEN != null)
{
int intRecNum = PrjTabFldDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabFldEN.PrjId);
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
objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
//删除与表:[PrjTabFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjTabFld.mId,
//lngmId);
//        clsPrjTabFldBL.DelPrjTabFldsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabFldBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsPrjTabFldBL.relatedActions != null)
{
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = PrjTabFldDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelPrjTabFlds(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsPrjTabFldBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = PrjTabFldDA.DelPrjTabFld(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabFldEN.PrjId);
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
public static int DelPrjTabFldsByCond(string strWhereCond)
{
try
{
if (clsPrjTabFldBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsPrjTabFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conPrjTabFld.PrjId, strWhereCond);
int intRecNum = PrjTabFldDA.DelPrjTabFld(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjTabFld]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTabFldDA.GetSpecSQLObj();
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
//删除与表:[PrjTabFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabFldBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objPrjTabFldENS">源对象</param>
 /// <param name = "objPrjTabFldENT">目标对象</param>
 public static void CopyTo(clsPrjTabFldEN objPrjTabFldENS, clsPrjTabFldEN objPrjTabFldENT)
{
try
{
objPrjTabFldENT.mId = objPrjTabFldENS.mId; //mId
objPrjTabFldENT.TabId = objPrjTabFldENS.TabId; //表ID
objPrjTabFldENT.FldId = objPrjTabFldENS.FldId; //字段Id
objPrjTabFldENT.PrjId = objPrjTabFldENS.PrjId; //工程Id
objPrjTabFldENT.FieldTypeId = objPrjTabFldENS.FieldTypeId; //字段类型Id
objPrjTabFldENT.IsTabNullable = objPrjTabFldENS.IsTabNullable; //是否表中可空
objPrjTabFldENT.IsTabUnique = objPrjTabFldENS.IsTabUnique; //是否表中唯一
objPrjTabFldENT.IsTabForeignKey = objPrjTabFldENS.IsTabForeignKey; //是否表外键
objPrjTabFldENT.IsSortFld = objPrjTabFldENS.IsSortFld; //是否排序字段
objPrjTabFldENT.IsGeneProp = objPrjTabFldENS.IsGeneProp; //是否生成属性
objPrjTabFldENT.IsForExtendClass = objPrjTabFldENS.IsForExtendClass; //用于扩展类
objPrjTabFldENT.CtlTypeIdDu = objPrjTabFldENS.CtlTypeIdDu; //控件类型Id_du
objPrjTabFldENT.FldDispUnitStyleId = objPrjTabFldENS.FldDispUnitStyleId; //字段显示单元样式Id
objPrjTabFldENT.InFldId = objPrjTabFldENS.InFldId; //In字段Id
objPrjTabFldENT.DnPathId = objPrjTabFldENS.DnPathId; //DN路径Id
objPrjTabFldENT.KeyId4Test = objPrjTabFldENS.KeyId4Test; //测试关键字Id
objPrjTabFldENT.DisplayFormat = objPrjTabFldENS.DisplayFormat; //显示格式
objPrjTabFldENT.IsParentObj = objPrjTabFldENS.IsParentObj; //是否父对象
objPrjTabFldENT.PrimaryTypeId = objPrjTabFldENS.PrimaryTypeId; //主键类型ID
objPrjTabFldENT.ForeignKeyTabId = objPrjTabFldENS.ForeignKeyTabId; //外键表ID
objPrjTabFldENT.FldOpTypeId = objPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objPrjTabFldENT.SequenceNumber = objPrjTabFldENS.SequenceNumber; //顺序号
objPrjTabFldENT.MemoInTab = objPrjTabFldENS.MemoInTab; //表中说明
objPrjTabFldENT.ErrMsg = objPrjTabFldENS.ErrMsg; //错误信息
objPrjTabFldENT.UpdDate = objPrjTabFldENS.UpdDate; //修改日期
objPrjTabFldENT.UpdUser = objPrjTabFldENS.UpdUser; //修改者
objPrjTabFldENT.Memo = objPrjTabFldENS.Memo; //说明
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
 /// <param name = "objPrjTabFldEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjTabFldEN objPrjTabFldEN)
{
try
{
objPrjTabFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjTabFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjTabFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.mId = objPrjTabFldEN.mId; //mId
}
if (arrFldSet.Contains(conPrjTabFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.TabId = objPrjTabFldEN.TabId; //表ID
}
if (arrFldSet.Contains(conPrjTabFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.FldId = objPrjTabFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(conPrjTabFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.PrjId = objPrjTabFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjTabFld.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.FieldTypeId = objPrjTabFldEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conPrjTabFld.IsTabNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsTabNullable = objPrjTabFldEN.IsTabNullable; //是否表中可空
}
if (arrFldSet.Contains(conPrjTabFld.IsTabUnique, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsTabUnique = objPrjTabFldEN.IsTabUnique; //是否表中唯一
}
if (arrFldSet.Contains(conPrjTabFld.IsTabForeignKey, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsTabForeignKey = objPrjTabFldEN.IsTabForeignKey; //是否表外键
}
if (arrFldSet.Contains(conPrjTabFld.IsSortFld, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsSortFld = objPrjTabFldEN.IsSortFld; //是否排序字段
}
if (arrFldSet.Contains(conPrjTabFld.IsGeneProp, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsGeneProp = objPrjTabFldEN.IsGeneProp; //是否生成属性
}
if (arrFldSet.Contains(conPrjTabFld.IsForExtendClass, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsForExtendClass = objPrjTabFldEN.IsForExtendClass; //用于扩展类
}
if (arrFldSet.Contains(conPrjTabFld.CtlTypeIdDu, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.CtlTypeIdDu = objPrjTabFldEN.CtlTypeIdDu == "[null]" ? null :  objPrjTabFldEN.CtlTypeIdDu; //控件类型Id_du
}
if (arrFldSet.Contains(conPrjTabFld.FldDispUnitStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.FldDispUnitStyleId = objPrjTabFldEN.FldDispUnitStyleId == "[null]" ? null :  objPrjTabFldEN.FldDispUnitStyleId; //字段显示单元样式Id
}
if (arrFldSet.Contains(conPrjTabFld.InFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.InFldId = objPrjTabFldEN.InFldId == "[null]" ? null :  objPrjTabFldEN.InFldId; //In字段Id
}
if (arrFldSet.Contains(conPrjTabFld.DnPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.DnPathId = objPrjTabFldEN.DnPathId == "[null]" ? null :  objPrjTabFldEN.DnPathId; //DN路径Id
}
if (arrFldSet.Contains(conPrjTabFld.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.KeyId4Test = objPrjTabFldEN.KeyId4Test == "[null]" ? null :  objPrjTabFldEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(conPrjTabFld.DisplayFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.DisplayFormat = objPrjTabFldEN.DisplayFormat == "[null]" ? null :  objPrjTabFldEN.DisplayFormat; //显示格式
}
if (arrFldSet.Contains(conPrjTabFld.IsParentObj, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.IsParentObj = objPrjTabFldEN.IsParentObj; //是否父对象
}
if (arrFldSet.Contains(conPrjTabFld.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.PrimaryTypeId = objPrjTabFldEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(conPrjTabFld.ForeignKeyTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.ForeignKeyTabId = objPrjTabFldEN.ForeignKeyTabId == "[null]" ? null :  objPrjTabFldEN.ForeignKeyTabId; //外键表ID
}
if (arrFldSet.Contains(conPrjTabFld.FldOpTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.FldOpTypeId = objPrjTabFldEN.FldOpTypeId; //字段操作类型Id
}
if (arrFldSet.Contains(conPrjTabFld.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.SequenceNumber = objPrjTabFldEN.SequenceNumber; //顺序号
}
if (arrFldSet.Contains(conPrjTabFld.MemoInTab, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.MemoInTab = objPrjTabFldEN.MemoInTab == "[null]" ? null :  objPrjTabFldEN.MemoInTab; //表中说明
}
if (arrFldSet.Contains(conPrjTabFld.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.ErrMsg = objPrjTabFldEN.ErrMsg == "[null]" ? null :  objPrjTabFldEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conPrjTabFld.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.UpdDate = objPrjTabFldEN.UpdDate == "[null]" ? null :  objPrjTabFldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjTabFld.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.UpdUser = objPrjTabFldEN.UpdUser == "[null]" ? null :  objPrjTabFldEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conPrjTabFld.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabFldEN.Memo = objPrjTabFldEN.Memo == "[null]" ? null :  objPrjTabFldEN.Memo; //说明
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
 /// <param name = "objPrjTabFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjTabFldEN objPrjTabFldEN)
{
try
{
if (objPrjTabFldEN.CtlTypeIdDu == "[null]") objPrjTabFldEN.CtlTypeIdDu = null; //控件类型Id_du
if (objPrjTabFldEN.FldDispUnitStyleId == "[null]") objPrjTabFldEN.FldDispUnitStyleId = null; //字段显示单元样式Id
if (objPrjTabFldEN.InFldId == "[null]") objPrjTabFldEN.InFldId = null; //In字段Id
if (objPrjTabFldEN.DnPathId == "[null]") objPrjTabFldEN.DnPathId = null; //DN路径Id
if (objPrjTabFldEN.KeyId4Test == "[null]") objPrjTabFldEN.KeyId4Test = null; //测试关键字Id
if (objPrjTabFldEN.DisplayFormat == "[null]") objPrjTabFldEN.DisplayFormat = null; //显示格式
if (objPrjTabFldEN.ForeignKeyTabId == "[null]") objPrjTabFldEN.ForeignKeyTabId = null; //外键表ID
if (objPrjTabFldEN.MemoInTab == "[null]") objPrjTabFldEN.MemoInTab = null; //表中说明
if (objPrjTabFldEN.ErrMsg == "[null]") objPrjTabFldEN.ErrMsg = null; //错误信息
if (objPrjTabFldEN.UpdDate == "[null]") objPrjTabFldEN.UpdDate = null; //修改日期
if (objPrjTabFldEN.UpdUser == "[null]") objPrjTabFldEN.UpdUser = null; //修改者
if (objPrjTabFldEN.Memo == "[null]") objPrjTabFldEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjTabFldEN objPrjTabFldEN)
{
 PrjTabFldDA.CheckPropertyNew(objPrjTabFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjTabFldEN objPrjTabFldEN)
{
 PrjTabFldDA.CheckProperty4Condition(objPrjTabFldEN);
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
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrPrjTabFldObjLstCache == null)
//{
//arrPrjTabFldObjLstCache = PrjTabFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabFldEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
arrPrjTabFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrPrjTabFldObjLst_Sel.Count() == 0)
{
   clsPrjTabFldEN obj = clsPrjTabFldBL.GetObjBymId(lngmId);
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
return arrPrjTabFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabFldEN> GetAllPrjTabFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strPrjId); 
return arrPrjTabFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPrjTabFldObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:TabId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrPrjTabFldObjLst">需要排序的对象列表</param>
public static List <clsPrjTabFldEN> GetSubSet4PrjTabFldObjLstByTabIdCache(string strTabId, string strPrjId)
{
   if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
from objPrjTabFldEN in arrPrjTabFldObjLstCache
where objPrjTabFldEN.TabId == strTabId
select objPrjTabFldEN;
List <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
{
arrPrjTabFldObjLst_Sel.Add(obj);
}
return arrPrjTabFldObjLst_Sel;
}
 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrPrjTabFldObjLst">需要排序的对象列表</param>
public static List <clsPrjTabFldEN> GetSubSet4PrjTabFldObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
from objPrjTabFldEN in arrPrjTabFldObjLstCache
where objPrjTabFldEN.PrjId == strPrjId
select objPrjTabFldEN;
List <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
{
arrPrjTabFldObjLst_Sel.Add(obj);
}
return arrPrjTabFldObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjTabFldEN._RefreshTimeLst.Count == 0) return "";
return clsPrjTabFldEN._RefreshTimeLst[clsPrjTabFldEN._RefreshTimeLst.Count - 1];
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
if (clsPrjTabFldBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjTabFldBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjTabFld(工程表字段)
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjTabFldEN objPrjTabFldEN)
{
//检测记录是否存在
string strResult = PrjTabFldDA.GetUniCondStr(objPrjTabFldEN);
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
if (strInFldName != conPrjTabFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjTabFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjTabFld._AttributeName));
throw new Exception(strMsg);
}
var objPrjTabFld = clsPrjTabFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objPrjTabFld == null) return "";
return objPrjTabFld[strOutFldName].ToString();
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
int intRecCount = clsPrjTabFldDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjTabFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjTabFldDA.GetRecCount();
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
int intRecCount = clsPrjTabFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjTabFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjTabFldEN objPrjTabFldCond)
{
 string strPrjId = objPrjTabFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPrjTabFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPrjTabFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTabFld._AttributeName)
{
if (objPrjTabFldCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabFldCond[strFldName].ToString());
}
else
{
if (objPrjTabFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabFldCond[strFldName]));
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
 List<string> arrList = clsPrjTabFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjTabFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjTabFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjTabFldDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabFldDA.SetFldValue(clsPrjTabFldEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjTabFldDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabFldDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabFldDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabFldDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjTabFld] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) not Null, "); 
 // /**是否表中可空*/ 
 strCreateTabCode.Append(" IsTabNullable bit not Null, "); 
 // /**是否表中唯一*/ 
 strCreateTabCode.Append(" IsTabUnique bit Null, "); 
 // /**是否表外键*/ 
 strCreateTabCode.Append(" IsTabForeignKey bit Null, "); 
 // /**是否排序字段*/ 
 strCreateTabCode.Append(" IsSortFld bit Null, "); 
 // /**是否生成属性*/ 
 strCreateTabCode.Append(" IsGeneProp bit Null, "); 
 // /**用于扩展类*/ 
 strCreateTabCode.Append(" IsForExtendClass bit not Null, "); 
 // /**控件类型Id_du*/ 
 strCreateTabCode.Append(" CtlTypeIdDu char(2) Null, "); 
 // /**字段显示单元样式Id*/ 
 strCreateTabCode.Append(" FldDispUnitStyleId char(8) Null, "); 
 // /**In字段Id*/ 
 strCreateTabCode.Append(" InFldId char(8) Null, "); 
 // /**DN路径Id*/ 
 strCreateTabCode.Append(" DnPathId char(8) Null, "); 
 // /**测试关键字Id*/ 
 strCreateTabCode.Append(" KeyId4Test varchar(50) Null, "); 
 // /**显示格式*/ 
 strCreateTabCode.Append(" DisplayFormat varchar(50) Null, "); 
 // /**是否父对象*/ 
 strCreateTabCode.Append(" IsParentObj bit Null, "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) not Null, "); 
 // /**外键表ID*/ 
 strCreateTabCode.Append(" ForeignKeyTabId char(8) Null, "); 
 // /**字段操作类型Id*/ 
 strCreateTabCode.Append(" FldOpTypeId char(4) not Null, "); 
 // /**顺序号*/ 
 strCreateTabCode.Append(" SequenceNumber int Null, "); 
 // /**表中说明*/ 
 strCreateTabCode.Append(" MemoInTab varchar(1000) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**字段名Ex*/ 
 strCreateTabCode.Append(" FldNameEx varchar(50) Null, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" Caption varchar(200) Null, "); 
 // /**主键类型名*/ 
 strCreateTabCode.Append(" PrimaryTypeName varchar(30) Null, "); 
 // /**字段类型名*/ 
 strCreateTabCode.Append(" FieldTypeName varchar(30) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) Null, "); 
 // /**字段长度*/ 
 strCreateTabCode.Append(" FldLength int Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" ForeignKeyTabName varchar(100) not Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**精确度*/ 
 strCreateTabCode.Append(" FldPrecision int Null, "); 
 // /**错误等级Id*/ 
 strCreateTabCode.Append(" ErrorLevelId int not Null, "); 
 // /**表检查错误类型Id*/ 
 strCreateTabCode.Append(" TabCheckErrorTypeId char(2) not Null, "); 
 // /**TypeName_Sql*/ 
 strCreateTabCode.Append(" TypeNameSql varchar(50) Null, "); 
 // /**Length_Sql*/ 
 strCreateTabCode.Append(" LengthSql int Null, "); 
 // /**Precision_Sql*/ 
 strCreateTabCode.Append(" PrecisionSql int Null, "); 
 // /**Is_Nullable_SQL*/ 
 strCreateTabCode.Append(" IsNullableSql bit Null, "); 
 // /**SourceTabName*/ 
 strCreateTabCode.Append(" SourceTabName varchar(50) Null, "); 
 // /**转换字段名*/ 
 strCreateTabCode.Append(" ConvFldName varchar(50) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**是否需要添加转换字段*/ 
 strCreateTabCode.Append(" IsNeedAddConvFldName bit Null, "); 
 // /**路径DivStr*/ 
 strCreateTabCode.Append(" DnPathDivStr varchar(50) Null, "); 
 // /**是否选择*/ 
 strCreateTabCode.Append(" Checked bit Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：TabId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strTabId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strTabId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);
 strCondition += string.Format(" order by SequenceNumber ");
List<clsPrjTabFldEN> arrPrjTabFldObjList = new clsPrjTabFldDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFldObjList)
{
objPrjTabFld.SequenceNumber = intIndex;
UpdateBySql2(objPrjTabFld);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：TabId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strTabId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strTabId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[SequenceNumber]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[SequenceNumber]。

clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);

intOrderNum = objPrjTabFld.SequenceNumber ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);
intTabRecNum = clsPrjTabFldBL.GetRecCountByCond(clsPrjTabFldEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conPrjTabFld.SequenceNumber, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsPrjTabFldBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, conPrjTabFld.SequenceNumber,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conPrjTabFld.mId, lngmId));
clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, conPrjTabFld.SequenceNumber,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjTabFld.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conPrjTabFld.SequenceNumber, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);

lngNextmId = clsPrjTabFldBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, conPrjTabFld.SequenceNumber,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conPrjTabFld.mId, lngmId));
clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, conPrjTabFld.SequenceNumber,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conPrjTabFld.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TabId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strTabId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conPrjTabFld.mId, strKeyList);
List<clsPrjTabFldEN> arrPrjTabFldLst = GetObjLst(strCondition);
foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFldLst)
{
objPrjTabFld.SequenceNumber = objPrjTabFld.SequenceNumber + 10000;
UpdateBySql2(objPrjTabFld);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);
 strCondition += string.Format(" order by SequenceNumber ");
List<clsPrjTabFldEN> arrPrjTabFldObjList = new clsPrjTabFldDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFldObjList)
{
objPrjTabFld.SequenceNumber = intIndex;
UpdateBySql2(objPrjTabFld);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TabId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strTabId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strTabId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conPrjTabFld.mId, strKeyList);
List<clsPrjTabFldEN> arrPrjTabFldLst = GetObjLst(strCondition);
foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFldLst)
{
objPrjTabFld.SequenceNumber = objPrjTabFld.SequenceNumber - 10000;
UpdateBySql2(objPrjTabFld);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conPrjTabFld.TabId, strTabId);
 strCondition += string.Format(" order by SequenceNumber ");
List<clsPrjTabFldEN> arrPrjTabFldObjList = new clsPrjTabFldDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFldObjList)
{
objPrjTabFld.SequenceNumber = intIndex;
UpdateBySql2(objPrjTabFld);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 工程表字段(PrjTabFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjTabFld : clsCommFun4BLV2
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
clsPrjTabFldBL.ReFreshThisCache(strPrjId);
}
}

}