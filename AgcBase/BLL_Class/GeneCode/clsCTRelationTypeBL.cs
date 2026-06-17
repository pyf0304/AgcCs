
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTRelationTypeBL
 表名:CTRelationType(00050645)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/16 22:27:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsCTRelationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCtRelationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCTRelationTypeEN GetObj(this K_CtRelationTypeId_CTRelationType myKey)
{
clsCTRelationTypeEN objCTRelationTypeEN = clsCTRelationTypeBL.CTRelationTypeDA.GetObjByCtRelationTypeId(myKey.Value);
return objCTRelationTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCTRelationTypeEN objCTRelationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTRelationTypeBL.IsExist(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTRelationTypeEN.CtRelationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCTRelationTypeBL.CTRelationTypeDA.AddNewRecordBySQL2(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCTRelationTypeEN objCTRelationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCTRelationTypeBL.IsExist(objCTRelationTypeEN.CtRelationTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCTRelationTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCTRelationTypeEN.AddNewRecord();
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCTRelationTypeEN objCTRelationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTRelationTypeBL.IsExist(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTRelationTypeEN.CtRelationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCTRelationTypeBL.CTRelationTypeDA.AddNewRecordBySQL2WithReturnKey(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetCtRelationTypeId(this clsCTRelationTypeEN objCTRelationTypeEN, string strCtRelationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtRelationTypeId, 2, conCTRelationType.CtRelationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtRelationTypeId, 2, conCTRelationType.CtRelationTypeId);
}
objCTRelationTypeEN.CtRelationTypeId = strCtRelationTypeId; //Ct关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.CtRelationTypeId) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.CtRelationTypeId, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.CtRelationTypeId] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetRelationTypeName(this clsCTRelationTypeEN objCTRelationTypeEN, string strRelationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationTypeName, conCTRelationType.RelationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationTypeName, 50, conCTRelationType.RelationTypeName);
}
objCTRelationTypeEN.RelationTypeName = strRelationTypeName; //关系类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.RelationTypeName) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.RelationTypeName, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.RelationTypeName] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetRelationTypeEN(this clsCTRelationTypeEN objCTRelationTypeEN, string strRelationTypeEN, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationTypeEN, 50, conCTRelationType.RelationTypeEN);
}
objCTRelationTypeEN.RelationTypeEN = strRelationTypeEN; //关系类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.RelationTypeEN) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.RelationTypeEN, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.RelationTypeEN] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetDescription(this clsCTRelationTypeEN objCTRelationTypeEN, string strDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDescription, 300, conCTRelationType.Description);
}
objCTRelationTypeEN.Description = strDescription; //描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.Description) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.Description, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.Description] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetOrderNum(this clsCTRelationTypeEN objCTRelationTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objCTRelationTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.OrderNum) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.OrderNum, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.OrderNum] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetInUse(this clsCTRelationTypeEN objCTRelationTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCTRelationTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.InUse) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.InUse, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.InUse] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetLineColor(this clsCTRelationTypeEN objCTRelationTypeEN, string strLineColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLineColor, 20, conCTRelationType.LineColor);
}
objCTRelationTypeEN.LineColor = strLineColor; //LineColor
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.LineColor) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.LineColor, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.LineColor] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetLineStyle(this clsCTRelationTypeEN objCTRelationTypeEN, string strLineStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLineStyle, 20, conCTRelationType.LineStyle);
}
objCTRelationTypeEN.LineStyle = strLineStyle; //LineStyle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.LineStyle) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.LineStyle, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.LineStyle] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetLineWidth(this clsCTRelationTypeEN objCTRelationTypeEN, int? intLineWidth, string strComparisonOp="")
	{
objCTRelationTypeEN.LineWidth = intLineWidth; //LineWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.LineWidth) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.LineWidth, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.LineWidth] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetArrowType(this clsCTRelationTypeEN objCTRelationTypeEN, string strArrowType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strArrowType, 20, conCTRelationType.ArrowType);
}
objCTRelationTypeEN.ArrowType = strArrowType; //箭头类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.ArrowType) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.ArrowType, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.ArrowType] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetDisplayColor(this clsCTRelationTypeEN objCTRelationTypeEN, string strDisplayColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisplayColor, 20, conCTRelationType.DisplayColor);
}
objCTRelationTypeEN.DisplayColor = strDisplayColor; //DisplayColor
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.DisplayColor) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.DisplayColor, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.DisplayColor] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetUpdDate(this clsCTRelationTypeEN objCTRelationTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCTRelationType.UpdDate);
}
objCTRelationTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.UpdDate) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.UpdDate, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.UpdDate] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetUpdUser(this clsCTRelationTypeEN objCTRelationTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCTRelationType.UpdUser);
}
objCTRelationTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.UpdUser) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.UpdUser, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.UpdUser] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTRelationTypeEN SetMemo(this clsCTRelationTypeEN objCTRelationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCTRelationType.Memo);
}
objCTRelationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTRelationTypeEN.dicFldComparisonOp.ContainsKey(conCTRelationType.Memo) == false)
{
objCTRelationTypeEN.dicFldComparisonOp.Add(conCTRelationType.Memo, strComparisonOp);
}
else
{
objCTRelationTypeEN.dicFldComparisonOp[conCTRelationType.Memo] = strComparisonOp;
}
}
return objCTRelationTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCTRelationTypeEN objCTRelationTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCTRelationTypeEN.CheckPropertyNew();
clsCTRelationTypeEN objCTRelationTypeCond = new clsCTRelationTypeEN();
string strCondition = objCTRelationTypeCond
.SetCtRelationTypeId(objCTRelationTypeEN.CtRelationTypeId, "=")
.GetCombineCondition();
objCTRelationTypeEN._IsCheckProperty = true;
bool bolIsExist = clsCTRelationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCTRelationTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTRelationTypeBL.CTRelationTypeDA.UpdateBySql2(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTRelationTypeEN objCTRelationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTRelationTypeBL.CTRelationTypeDA.UpdateBySql2(objCTRelationTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTRelationTypeEN objCTRelationTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsCTRelationTypeBL.CTRelationTypeDA.UpdateBySqlWithCondition(objCTRelationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTRelationTypeEN objCTRelationTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCTRelationTypeBL.CTRelationTypeDA.UpdateBySqlWithConditionTransaction(objCTRelationTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCTRelationTypeEN objCTRelationTypeEN)
{
try
{
int intRecNum = clsCTRelationTypeBL.CTRelationTypeDA.DelRecord(objCTRelationTypeEN.CtRelationTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeENS">源对象</param>
 /// <param name = "objCTRelationTypeENT">目标对象</param>
 public static void CopyTo(this clsCTRelationTypeEN objCTRelationTypeENS, clsCTRelationTypeEN objCTRelationTypeENT)
{
try
{
objCTRelationTypeENT.CtRelationTypeId = objCTRelationTypeENS.CtRelationTypeId; //Ct关系类型Id
objCTRelationTypeENT.RelationTypeName = objCTRelationTypeENS.RelationTypeName; //关系类型名
objCTRelationTypeENT.RelationTypeEN = objCTRelationTypeENS.RelationTypeEN; //关系类型英文名
objCTRelationTypeENT.Description = objCTRelationTypeENS.Description; //描述
objCTRelationTypeENT.OrderNum = objCTRelationTypeENS.OrderNum; //序号
objCTRelationTypeENT.InUse = objCTRelationTypeENS.InUse; //是否在用
objCTRelationTypeENT.LineColor = objCTRelationTypeENS.LineColor; //LineColor
objCTRelationTypeENT.LineStyle = objCTRelationTypeENS.LineStyle; //LineStyle
objCTRelationTypeENT.LineWidth = objCTRelationTypeENS.LineWidth; //LineWidth
objCTRelationTypeENT.ArrowType = objCTRelationTypeENS.ArrowType; //箭头类型
objCTRelationTypeENT.DisplayColor = objCTRelationTypeENS.DisplayColor; //DisplayColor
objCTRelationTypeENT.UpdDate = objCTRelationTypeENS.UpdDate; //修改日期
objCTRelationTypeENT.UpdUser = objCTRelationTypeENS.UpdUser; //修改者
objCTRelationTypeENT.Memo = objCTRelationTypeENS.Memo; //说明
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
 /// <param name = "objCTRelationTypeENS">源对象</param>
 /// <returns>目标对象=>clsCTRelationTypeEN:objCTRelationTypeENT</returns>
 public static clsCTRelationTypeEN CopyTo(this clsCTRelationTypeEN objCTRelationTypeENS)
{
try
{
 clsCTRelationTypeEN objCTRelationTypeENT = new clsCTRelationTypeEN()
{
CtRelationTypeId = objCTRelationTypeENS.CtRelationTypeId, //Ct关系类型Id
RelationTypeName = objCTRelationTypeENS.RelationTypeName, //关系类型名
RelationTypeEN = objCTRelationTypeENS.RelationTypeEN, //关系类型英文名
Description = objCTRelationTypeENS.Description, //描述
OrderNum = objCTRelationTypeENS.OrderNum, //序号
InUse = objCTRelationTypeENS.InUse, //是否在用
LineColor = objCTRelationTypeENS.LineColor, //LineColor
LineStyle = objCTRelationTypeENS.LineStyle, //LineStyle
LineWidth = objCTRelationTypeENS.LineWidth, //LineWidth
ArrowType = objCTRelationTypeENS.ArrowType, //箭头类型
DisplayColor = objCTRelationTypeENS.DisplayColor, //DisplayColor
UpdDate = objCTRelationTypeENS.UpdDate, //修改日期
UpdUser = objCTRelationTypeENS.UpdUser, //修改者
Memo = objCTRelationTypeENS.Memo, //说明
};
 return objCTRelationTypeENT;
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
public static void CheckPropertyNew(this clsCTRelationTypeEN objCTRelationTypeEN)
{
 clsCTRelationTypeBL.CTRelationTypeDA.CheckPropertyNew(objCTRelationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCTRelationTypeEN objCTRelationTypeEN)
{
 clsCTRelationTypeBL.CTRelationTypeDA.CheckProperty4Condition(objCTRelationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCTRelationTypeEN objCTRelationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.CtRelationTypeId) == true)
{
string strComparisonOpCtRelationTypeId = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.CtRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.CtRelationTypeId, objCTRelationTypeCond.CtRelationTypeId, strComparisonOpCtRelationTypeId);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.RelationTypeName) == true)
{
string strComparisonOpRelationTypeName = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.RelationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.RelationTypeName, objCTRelationTypeCond.RelationTypeName, strComparisonOpRelationTypeName);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.RelationTypeEN) == true)
{
string strComparisonOpRelationTypeEN = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.RelationTypeEN];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.RelationTypeEN, objCTRelationTypeCond.RelationTypeEN, strComparisonOpRelationTypeEN);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.Description) == true)
{
string strComparisonOpDescription = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.Description];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.Description, objCTRelationTypeCond.Description, strComparisonOpDescription);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCTRelationType.OrderNum, objCTRelationTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.InUse) == true)
{
if (objCTRelationTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCTRelationType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCTRelationType.InUse);
}
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.LineColor) == true)
{
string strComparisonOpLineColor = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.LineColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.LineColor, objCTRelationTypeCond.LineColor, strComparisonOpLineColor);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.LineStyle) == true)
{
string strComparisonOpLineStyle = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.LineStyle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.LineStyle, objCTRelationTypeCond.LineStyle, strComparisonOpLineStyle);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.LineWidth) == true)
{
string strComparisonOpLineWidth = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.LineWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conCTRelationType.LineWidth, objCTRelationTypeCond.LineWidth, strComparisonOpLineWidth);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.ArrowType) == true)
{
string strComparisonOpArrowType = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.ArrowType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.ArrowType, objCTRelationTypeCond.ArrowType, strComparisonOpArrowType);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.DisplayColor) == true)
{
string strComparisonOpDisplayColor = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.DisplayColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.DisplayColor, objCTRelationTypeCond.DisplayColor, strComparisonOpDisplayColor);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.UpdDate, objCTRelationTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.UpdUser, objCTRelationTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCTRelationTypeCond.IsUpdated(conCTRelationType.Memo) == true)
{
string strComparisonOpMemo = objCTRelationTypeCond.dicFldComparisonOp[conCTRelationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTRelationType.Memo, objCTRelationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CTRelationType
{
public virtual bool UpdRelaTabDate(string strCtRelationTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCTRelationType
{
 /// <summary>
 /// 必须依赖
 /// </summary>
public const string Require_01 = "01";
 /// <summary>
 /// 可选依赖
 /// </summary>
public const string Optional_02 = "02";
 /// <summary>
 /// 生成顺序
 /// </summary>
public const string GenerateAfter_03 = "03";
 /// <summary>
 /// 引用关系
 /// </summary>
public const string Reference_04 = "04";
}
 /// <summary>
 /// CT关系类型(CTRelationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCTRelationTypeBL
{
public static RelatedActions_CTRelationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCTRelationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCTRelationTypeDA CTRelationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCTRelationTypeDA();
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
 public clsCTRelationTypeBL()
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
if (string.IsNullOrEmpty(clsCTRelationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTRelationTypeEN._ConnectString);
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
public static DataTable GetDataTable_CTRelationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CTRelationTypeDA.GetDataTable_CTRelationType(strWhereCond);
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
objDT = CTRelationTypeDA.GetDataTable(strWhereCond);
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
objDT = CTRelationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CTRelationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CTRelationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CTRelationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = CTRelationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CTRelationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CTRelationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCtRelationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCTRelationTypeEN> GetObjLstByCtRelationTypeIdLst(List<string> arrCtRelationTypeIdLst)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCtRelationTypeIdLst, true);
 string strWhereCond = string.Format("CtRelationTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCtRelationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCTRelationTypeEN> GetObjLstByCtRelationTypeIdLstCache(List<string> arrCtRelationTypeIdLst)
{
string strKey = string.Format("{0}", clsCTRelationTypeEN._CurrTabName);
List<clsCTRelationTypeEN> arrCTRelationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCTRelationTypeEN> arrCTRelationTypeObjLst_Sel =
arrCTRelationTypeObjLstCache
.Where(x => arrCtRelationTypeIdLst.Contains(x.CtRelationTypeId));
return arrCTRelationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTRelationTypeEN> GetObjLst(string strWhereCond)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
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
public static List<clsCTRelationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCTRelationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCTRelationTypeEN> GetSubObjLstCache(clsCTRelationTypeEN objCTRelationTypeCond)
{
List<clsCTRelationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTRelationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTRelationType._AttributeName)
{
if (objCTRelationTypeCond.IsUpdated(strFldName) == false) continue;
if (objCTRelationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTRelationTypeCond[strFldName].ToString());
}
else
{
if (objCTRelationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTRelationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTRelationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTRelationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTRelationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTRelationTypeCond[strFldName]));
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
public static List<clsCTRelationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
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
public static List<clsCTRelationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
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
List<clsCTRelationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCTRelationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTRelationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCTRelationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
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
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
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
public static List<clsCTRelationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCTRelationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCTRelationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
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
public static List<clsCTRelationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTRelationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCTRelationTypeEN> arrObjLst = new List<clsCTRelationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTRelationTypeEN objCTRelationTypeEN = new clsCTRelationTypeEN();
try
{
objCTRelationTypeEN.CtRelationTypeId = objRow[conCTRelationType.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objCTRelationTypeEN.RelationTypeName = objRow[conCTRelationType.RelationTypeName].ToString().Trim(); //关系类型名
objCTRelationTypeEN.RelationTypeEN = objRow[conCTRelationType.RelationTypeEN] == DBNull.Value ? null : objRow[conCTRelationType.RelationTypeEN].ToString().Trim(); //关系类型英文名
objCTRelationTypeEN.Description = objRow[conCTRelationType.Description] == DBNull.Value ? null : objRow[conCTRelationType.Description].ToString().Trim(); //描述
objCTRelationTypeEN.OrderNum = objRow[conCTRelationType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.OrderNum].ToString().Trim()); //序号
objCTRelationTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTRelationType.InUse].ToString().Trim()); //是否在用
objCTRelationTypeEN.LineColor = objRow[conCTRelationType.LineColor] == DBNull.Value ? null : objRow[conCTRelationType.LineColor].ToString().Trim(); //LineColor
objCTRelationTypeEN.LineStyle = objRow[conCTRelationType.LineStyle] == DBNull.Value ? null : objRow[conCTRelationType.LineStyle].ToString().Trim(); //LineStyle
objCTRelationTypeEN.LineWidth = objRow[conCTRelationType.LineWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTRelationType.LineWidth].ToString().Trim()); //LineWidth
objCTRelationTypeEN.ArrowType = objRow[conCTRelationType.ArrowType] == DBNull.Value ? null : objRow[conCTRelationType.ArrowType].ToString().Trim(); //箭头类型
objCTRelationTypeEN.DisplayColor = objRow[conCTRelationType.DisplayColor] == DBNull.Value ? null : objRow[conCTRelationType.DisplayColor].ToString().Trim(); //DisplayColor
objCTRelationTypeEN.UpdDate = objRow[conCTRelationType.UpdDate] == DBNull.Value ? null : objRow[conCTRelationType.UpdDate].ToString().Trim(); //修改日期
objCTRelationTypeEN.UpdUser = objRow[conCTRelationType.UpdUser] == DBNull.Value ? null : objRow[conCTRelationType.UpdUser].ToString().Trim(); //修改者
objCTRelationTypeEN.Memo = objRow[conCTRelationType.Memo] == DBNull.Value ? null : objRow[conCTRelationType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTRelationTypeEN.CtRelationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTRelationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCTRelationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCTRelationType(ref clsCTRelationTypeEN objCTRelationTypeEN)
{
bool bolResult = CTRelationTypeDA.GetCTRelationType(ref objCTRelationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCtRelationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCTRelationTypeEN GetObjByCtRelationTypeId(string strCtRelationTypeId)
{
if (strCtRelationTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCtRelationTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCtRelationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCtRelationTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCTRelationTypeEN objCTRelationTypeEN = CTRelationTypeDA.GetObjByCtRelationTypeId(strCtRelationTypeId);
return objCTRelationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCTRelationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCTRelationTypeEN objCTRelationTypeEN = CTRelationTypeDA.GetFirstObj(strWhereCond);
 return objCTRelationTypeEN;
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
public static clsCTRelationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCTRelationTypeEN objCTRelationTypeEN = CTRelationTypeDA.GetObjByDataRow(objRow);
 return objCTRelationTypeEN;
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
public static clsCTRelationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCTRelationTypeEN objCTRelationTypeEN = CTRelationTypeDA.GetObjByDataRow(objRow);
 return objCTRelationTypeEN;
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
 /// <param name = "strCtRelationTypeId">所给的关键字</param>
 /// <param name = "lstCTRelationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTRelationTypeEN GetObjByCtRelationTypeIdFromList(string strCtRelationTypeId, List<clsCTRelationTypeEN> lstCTRelationTypeObjLst)
{
foreach (clsCTRelationTypeEN objCTRelationTypeEN in lstCTRelationTypeObjLst)
{
if (objCTRelationTypeEN.CtRelationTypeId == strCtRelationTypeId)
{
return objCTRelationTypeEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strCtRelationTypeId;
 try
 {
 strCtRelationTypeId = new clsCTRelationTypeDA().GetFirstID(strWhereCond);
 return strCtRelationTypeId;
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
 arrList = CTRelationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = CTRelationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCtRelationTypeId)
{
if (string.IsNullOrEmpty(strCtRelationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCtRelationTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CTRelationTypeDA.IsExist(strCtRelationTypeId);
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
 bolIsExist = clsCTRelationTypeDA.IsExistTable();
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
 bolIsExist = CTRelationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCTRelationTypeEN objCTRelationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTRelationTypeBL.IsExist(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTRelationTypeEN.CtRelationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CTRelationTypeDA.AddNewRecordBySQL2(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCTRelationTypeEN objCTRelationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTRelationTypeBL.IsExist(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTRelationTypeEN.CtRelationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CTRelationTypeDA.AddNewRecordBySQL2WithReturnKey(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCTRelationTypeEN objCTRelationTypeEN)
{
try
{
bool bolResult = CTRelationTypeDA.Update(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "objCTRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCTRelationTypeEN objCTRelationTypeEN)
{
 if (string.IsNullOrEmpty(objCTRelationTypeEN.CtRelationTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CTRelationTypeDA.UpdateBySql2(objCTRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTRelationTypeBL.ReFreshCache();

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
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
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCtRelationTypeId)
{
try
{
 clsCTRelationTypeEN objCTRelationTypeEN = clsCTRelationTypeBL.GetObjByCtRelationTypeId(strCtRelationTypeId);

if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(objCTRelationTypeEN.CtRelationTypeId, "SetUpdDate");
}
if (objCTRelationTypeEN != null)
{
int intRecNum = CTRelationTypeDA.DelRecord(strCtRelationTypeId);
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
/// <param name="strCtRelationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCtRelationTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
//删除与表:[CTRelationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCTRelationType.CtRelationTypeId,
//strCtRelationTypeId);
//        clsCTRelationTypeBL.DelCTRelationTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTRelationTypeBL.DelRecord(strCtRelationTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTRelationTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtRelationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCtRelationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCtRelationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCTRelationTypeBL.relatedActions != null)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(strCtRelationTypeId, "UpdRelaTabDate");
}
bool bolResult = CTRelationTypeDA.DelRecord(strCtRelationTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCtRelationTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCTRelationTypes(List<string> arrCtRelationTypeIdLst)
{
if (arrCtRelationTypeIdLst.Count == 0) return 0;
try
{
if (clsCTRelationTypeBL.relatedActions != null)
{
foreach (var strCtRelationTypeId in arrCtRelationTypeIdLst)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(strCtRelationTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = CTRelationTypeDA.DelCTRelationType(arrCtRelationTypeIdLst);
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
public static int DelCTRelationTypesByCond(string strWhereCond)
{
try
{
if (clsCTRelationTypeBL.relatedActions != null)
{
List<string> arrCtRelationTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCtRelationTypeId in arrCtRelationTypeId)
{
clsCTRelationTypeBL.relatedActions.UpdRelaTabDate(strCtRelationTypeId, "UpdRelaTabDate");
}
}
int intRecNum = CTRelationTypeDA.DelCTRelationType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CTRelationType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCtRelationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCtRelationTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTRelationTypeDA.GetSpecSQLObj();
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
//删除与表:[CTRelationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTRelationTypeBL.DelRecord(strCtRelationTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTRelationTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtRelationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCTRelationTypeENS">源对象</param>
 /// <param name = "objCTRelationTypeENT">目标对象</param>
 public static void CopyTo(clsCTRelationTypeEN objCTRelationTypeENS, clsCTRelationTypeEN objCTRelationTypeENT)
{
try
{
objCTRelationTypeENT.CtRelationTypeId = objCTRelationTypeENS.CtRelationTypeId; //Ct关系类型Id
objCTRelationTypeENT.RelationTypeName = objCTRelationTypeENS.RelationTypeName; //关系类型名
objCTRelationTypeENT.RelationTypeEN = objCTRelationTypeENS.RelationTypeEN; //关系类型英文名
objCTRelationTypeENT.Description = objCTRelationTypeENS.Description; //描述
objCTRelationTypeENT.OrderNum = objCTRelationTypeENS.OrderNum; //序号
objCTRelationTypeENT.InUse = objCTRelationTypeENS.InUse; //是否在用
objCTRelationTypeENT.LineColor = objCTRelationTypeENS.LineColor; //LineColor
objCTRelationTypeENT.LineStyle = objCTRelationTypeENS.LineStyle; //LineStyle
objCTRelationTypeENT.LineWidth = objCTRelationTypeENS.LineWidth; //LineWidth
objCTRelationTypeENT.ArrowType = objCTRelationTypeENS.ArrowType; //箭头类型
objCTRelationTypeENT.DisplayColor = objCTRelationTypeENS.DisplayColor; //DisplayColor
objCTRelationTypeENT.UpdDate = objCTRelationTypeENS.UpdDate; //修改日期
objCTRelationTypeENT.UpdUser = objCTRelationTypeENS.UpdUser; //修改者
objCTRelationTypeENT.Memo = objCTRelationTypeENS.Memo; //说明
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
 /// <param name = "objCTRelationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsCTRelationTypeEN objCTRelationTypeEN)
{
try
{
objCTRelationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCTRelationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCTRelationType.CtRelationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.CtRelationTypeId = objCTRelationTypeEN.CtRelationTypeId; //Ct关系类型Id
}
if (arrFldSet.Contains(conCTRelationType.RelationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.RelationTypeName = objCTRelationTypeEN.RelationTypeName; //关系类型名
}
if (arrFldSet.Contains(conCTRelationType.RelationTypeEN, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.RelationTypeEN = objCTRelationTypeEN.RelationTypeEN == "[null]" ? null :  objCTRelationTypeEN.RelationTypeEN; //关系类型英文名
}
if (arrFldSet.Contains(conCTRelationType.Description, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.Description = objCTRelationTypeEN.Description == "[null]" ? null :  objCTRelationTypeEN.Description; //描述
}
if (arrFldSet.Contains(conCTRelationType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.OrderNum = objCTRelationTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCTRelationType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.InUse = objCTRelationTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCTRelationType.LineColor, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.LineColor = objCTRelationTypeEN.LineColor == "[null]" ? null :  objCTRelationTypeEN.LineColor; //LineColor
}
if (arrFldSet.Contains(conCTRelationType.LineStyle, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.LineStyle = objCTRelationTypeEN.LineStyle == "[null]" ? null :  objCTRelationTypeEN.LineStyle; //LineStyle
}
if (arrFldSet.Contains(conCTRelationType.LineWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.LineWidth = objCTRelationTypeEN.LineWidth; //LineWidth
}
if (arrFldSet.Contains(conCTRelationType.ArrowType, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.ArrowType = objCTRelationTypeEN.ArrowType == "[null]" ? null :  objCTRelationTypeEN.ArrowType; //箭头类型
}
if (arrFldSet.Contains(conCTRelationType.DisplayColor, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.DisplayColor = objCTRelationTypeEN.DisplayColor == "[null]" ? null :  objCTRelationTypeEN.DisplayColor; //DisplayColor
}
if (arrFldSet.Contains(conCTRelationType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.UpdDate = objCTRelationTypeEN.UpdDate == "[null]" ? null :  objCTRelationTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCTRelationType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.UpdUser = objCTRelationTypeEN.UpdUser == "[null]" ? null :  objCTRelationTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCTRelationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCTRelationTypeEN.Memo = objCTRelationTypeEN.Memo == "[null]" ? null :  objCTRelationTypeEN.Memo; //说明
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
 /// <param name = "objCTRelationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsCTRelationTypeEN objCTRelationTypeEN)
{
try
{
if (objCTRelationTypeEN.RelationTypeEN == "[null]") objCTRelationTypeEN.RelationTypeEN = null; //关系类型英文名
if (objCTRelationTypeEN.Description == "[null]") objCTRelationTypeEN.Description = null; //描述
if (objCTRelationTypeEN.LineColor == "[null]") objCTRelationTypeEN.LineColor = null; //LineColor
if (objCTRelationTypeEN.LineStyle == "[null]") objCTRelationTypeEN.LineStyle = null; //LineStyle
if (objCTRelationTypeEN.ArrowType == "[null]") objCTRelationTypeEN.ArrowType = null; //箭头类型
if (objCTRelationTypeEN.DisplayColor == "[null]") objCTRelationTypeEN.DisplayColor = null; //DisplayColor
if (objCTRelationTypeEN.UpdDate == "[null]") objCTRelationTypeEN.UpdDate = null; //修改日期
if (objCTRelationTypeEN.UpdUser == "[null]") objCTRelationTypeEN.UpdUser = null; //修改者
if (objCTRelationTypeEN.Memo == "[null]") objCTRelationTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCTRelationTypeEN objCTRelationTypeEN)
{
 CTRelationTypeDA.CheckPropertyNew(objCTRelationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCTRelationTypeEN objCTRelationTypeEN)
{
 CTRelationTypeDA.CheckProperty4Condition(objCTRelationTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CtRelationTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CT关系类型]...","0");
List<clsCTRelationTypeEN> arrCTRelationTypeObjLst = GetAllCTRelationTypeObjLstCache(); 
arrCTRelationTypeObjLst = arrCTRelationTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conCTRelationType.CtRelationTypeId;
objDDL.DataTextField = conCTRelationType.RelationTypeName;
objDDL.DataSource = arrCTRelationTypeObjLst;
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
if (clsCTRelationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCTRelationTypeBL没有刷新缓存机制(clsCTRelationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CtRelationTypeId");
//if (arrCTRelationTypeObjLstCache == null)
//{
//arrCTRelationTypeObjLstCache = CTRelationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCtRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTRelationTypeEN GetObjByCtRelationTypeIdCache(string strCtRelationTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCTRelationTypeEN._CurrTabName);
List<clsCTRelationTypeEN> arrCTRelationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCTRelationTypeEN> arrCTRelationTypeObjLst_Sel =
arrCTRelationTypeObjLstCache
.Where(x=> x.CtRelationTypeId == strCtRelationTypeId 
);
if (arrCTRelationTypeObjLst_Sel.Count() == 0)
{
   clsCTRelationTypeEN obj = clsCTRelationTypeBL.GetObjByCtRelationTypeId(strCtRelationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCTRelationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRelationTypeNameByCtRelationTypeIdCache(string strCtRelationTypeId)
{
if (string.IsNullOrEmpty(strCtRelationTypeId) == true) return "";
//获取缓存中的对象列表
clsCTRelationTypeEN objCTRelationType = GetObjByCtRelationTypeIdCache(strCtRelationTypeId);
if (objCTRelationType == null) return "";
return objCTRelationType.RelationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCtRelationTypeIdCache(string strCtRelationTypeId)
{
if (string.IsNullOrEmpty(strCtRelationTypeId) == true) return "";
//获取缓存中的对象列表
clsCTRelationTypeEN objCTRelationType = GetObjByCtRelationTypeIdCache(strCtRelationTypeId);
if (objCTRelationType == null) return "";
return objCTRelationType.RelationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTRelationTypeEN> GetAllCTRelationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsCTRelationTypeEN> arrCTRelationTypeObjLstCache = GetObjLstCache(); 
return arrCTRelationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTRelationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCTRelationTypeEN._CurrTabName);
List<clsCTRelationTypeEN> arrCTRelationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCTRelationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsCTRelationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTRelationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCTRelationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsCTRelationTypeEN._RefreshTimeLst[clsCTRelationTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCTRelationTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCTRelationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTRelationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCTRelationTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-06-16
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCtRelationTypeId)
{
if (strInFldName != conCTRelationType.CtRelationTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCTRelationType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCTRelationType._AttributeName));
throw new Exception(strMsg);
}
var objCTRelationType = clsCTRelationTypeBL.GetObjByCtRelationTypeIdCache(strCtRelationTypeId);
if (objCTRelationType == null) return "";
return objCTRelationType[strOutFldName].ToString();
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
int intRecCount = clsCTRelationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsCTRelationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCTRelationTypeDA.GetRecCount();
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
int intRecCount = clsCTRelationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCTRelationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCTRelationTypeEN objCTRelationTypeCond)
{
List<clsCTRelationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTRelationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTRelationType._AttributeName)
{
if (objCTRelationTypeCond.IsUpdated(strFldName) == false) continue;
if (objCTRelationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTRelationTypeCond[strFldName].ToString());
}
else
{
if (objCTRelationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTRelationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTRelationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTRelationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTRelationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTRelationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTRelationTypeCond[strFldName]));
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
 List<string> arrList = clsCTRelationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CTRelationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CTRelationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CTRelationTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTRelationTypeDA.SetFldValue(clsCTRelationTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CTRelationTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTRelationTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTRelationTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTRelationTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CTRelationType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Ct关系类型Id*/ 
 strCreateTabCode.Append(" CtRelationTypeId char(2) primary key, "); 
 // /**关系类型名*/ 
 strCreateTabCode.Append(" RelationTypeName varchar(50) not Null, "); 
 // /**关系类型英文名*/ 
 strCreateTabCode.Append(" RelationTypeEN varchar(50) Null, "); 
 // /**描述*/ 
 strCreateTabCode.Append(" Description varchar(300) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**LineColor*/ 
 strCreateTabCode.Append(" LineColor varchar(20) Null, "); 
 // /**LineStyle*/ 
 strCreateTabCode.Append(" LineStyle varchar(20) Null, "); 
 // /**LineWidth*/ 
 strCreateTabCode.Append(" LineWidth int Null, "); 
 // /**箭头类型*/ 
 strCreateTabCode.Append(" ArrowType varchar(20) Null, "); 
 // /**DisplayColor*/ 
 strCreateTabCode.Append(" DisplayColor varchar(20) Null, "); 
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


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder( )
{
try
{
string strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsCTRelationTypeEN> arrCTRelationTypeObjList = new clsCTRelationTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCTRelationTypeEN objCTRelationType in arrCTRelationTypeObjList)
{
objCTRelationType.OrderNum = intIndex;
UpdateBySql2(objCTRelationType);
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
/// 调整所给关键字记录的序号。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCtRelationTypeId">所给的关键字</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strCtRelationTypeId  )
{
try
{
//操作步骤：
//1、根据所给定的关键字[CtRelationTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CtRelationTypeId
//5、把当前关键字CtRelationTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CtRelationTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCtRelationTypeId = "";    //上一条序号的关键字CtRelationTypeId
string strNextCtRelationTypeId = "";    //下一条序号的关键字CtRelationTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[CtRelationTypeId],获取相应的序号[OrderNum]。

 clsCTRelationTypeEN objCTRelationType = clsCTRelationTypeBL.GetObjByCtRelationTypeId(strCtRelationTypeId);

intOrderNum = objCTRelationType.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
intTabRecNum = clsCTRelationTypeBL.GetRecCountByCond(clsCTRelationTypeEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conCTRelationType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字CtRelationTypeId
strPrevCtRelationTypeId = clsCTRelationTypeBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevCtRelationTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CtRelationTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字CtRelationTypeId所对应的记录序号加1
clsCTRelationTypeBL.SetFldValue(clsCTRelationTypeEN._CurrTabName, conCTRelationType.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conCTRelationType.CtRelationTypeId, strCtRelationTypeId));
clsCTRelationTypeBL.SetFldValue(clsCTRelationTypeEN._CurrTabName, conCTRelationType.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCTRelationType.CtRelationTypeId, strPrevCtRelationTypeId));
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

//4、获取下一个序号字段的关键字CtRelationTypeId
sbCondition.AppendFormat(" {0} = {1} ", conCTRelationType.OrderNum, intOrderNum + 1);

strNextCtRelationTypeId = clsCTRelationTypeBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextCtRelationTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CtRelationTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字CtRelationTypeId所对应的记录序号减1
clsCTRelationTypeBL.SetFldValue(clsCTRelationTypeEN._CurrTabName, conCTRelationType.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conCTRelationType.CtRelationTypeId, strCtRelationTypeId));
clsCTRelationTypeBL.SetFldValue(clsCTRelationTypeEN._CurrTabName, conCTRelationType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCTRelationType.CtRelationTypeId, strNextCtRelationTypeId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCTRelationType.CtRelationTypeId, strKeyList);
List<clsCTRelationTypeEN> arrCTRelationTypeLst = GetObjLst(strCondition);
foreach (clsCTRelationTypeEN objCTRelationType in arrCTRelationTypeLst)
{
objCTRelationType.OrderNum = objCTRelationType.OrderNum + 10000;
UpdateBySql2(objCTRelationType);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsCTRelationTypeEN> arrCTRelationTypeObjList = new clsCTRelationTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCTRelationTypeEN objCTRelationType in arrCTRelationTypeObjList)
{
objCTRelationType.OrderNum = intIndex;
UpdateBySql2(objCTRelationType);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId  )
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCTRelationType.CtRelationTypeId, strKeyList);
List<clsCTRelationTypeEN> arrCTRelationTypeLst = GetObjLst(strCondition);
foreach (clsCTRelationTypeEN objCTRelationType in arrCTRelationTypeLst)
{
objCTRelationType.OrderNum = objCTRelationType.OrderNum - 10000;
UpdateBySql2(objCTRelationType);
}
strCondition = " 1=1 ";
 strCondition += string.Format(" order by OrderNum ");
List<clsCTRelationTypeEN> arrCTRelationTypeObjList = new clsCTRelationTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCTRelationTypeEN objCTRelationType in arrCTRelationTypeObjList)
{
objCTRelationType.OrderNum = intIndex;
UpdateBySql2(objCTRelationType);
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
 /// CT关系类型(CTRelationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CTRelationType : clsCommFun4BL
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
clsCTRelationTypeBL.ReFreshThisCache();
}
}

}