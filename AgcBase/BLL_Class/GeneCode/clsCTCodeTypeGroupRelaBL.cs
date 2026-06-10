
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupRelaBL
 表名:CTCodeTypeGroupRela(00050647)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/07 13:58:58
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
public static class  clsCTCodeTypeGroupRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CodeTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTCodeTypeGroupRelaBL.IsExist(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTCodeTypeGroupRelaEN.CtGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.AddNewRecordBySQL2(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCTCodeTypeGroupRelaBL.IsExist(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCTCodeTypeGroupRelaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCTCodeTypeGroupRelaEN.AddNewRecord();
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTCodeTypeGroupRelaBL.IsExist(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTCodeTypeGroupRelaEN.CtGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.AddNewRecordBySQL2WithReturnKey(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetCtGroupId(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strCtGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtGroupId, 4, conCTCodeTypeGroupRela.CtGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtGroupId, 4, conCTCodeTypeGroupRela.CtGroupId);
}
objCTCodeTypeGroupRelaEN.CtGroupId = strCtGroupId; //Ct组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.CtGroupId) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.CtGroupId, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.CtGroupId] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetCodeTypeId(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCTCodeTypeGroupRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCTCodeTypeGroupRela.CodeTypeId);
}
objCTCodeTypeGroupRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.CodeTypeId) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.CodeTypeId, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.CodeTypeId] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetIsMainGroup(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsMainGroup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMainGroup, conCTCodeTypeGroupRela.IsMainGroup);
objCTCodeTypeGroupRelaEN.IsMainGroup = bolIsMainGroup; //IsMainGroup
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.IsMainGroup) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.IsMainGroup, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.IsMainGroup] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetOrderNum(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.OrderNum) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.OrderNum, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.OrderNum] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetLayerNo(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intLayerNo, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.LayerNo = intLayerNo; //LayerNo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.LayerNo) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.LayerNo, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.LayerNo] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosX(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosX, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosX = intPosX; //PosX
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosX) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosX, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosX] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosY(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosY, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosY = intPosY; //PosY
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosY) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosY, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosY] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosXSmall(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosXSmall, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosXSmall = intPosXSmall; //PosXSmall
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosXSmall) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosXSmall, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosXSmall] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosYSmall(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosYSmall, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosYSmall = intPosYSmall; //PosYSmall
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosYSmall) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosYSmall, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosYSmall] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosXLarge(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosXLarge, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosXLarge = intPosXLarge; //PosXLarge
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosXLarge) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosXLarge, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosXLarge] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetPosYLarge(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int? intPosYLarge, string strComparisonOp="")
	{
objCTCodeTypeGroupRelaEN.PosYLarge = intPosYLarge; //PosYLarge
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.PosYLarge) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.PosYLarge, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.PosYLarge] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetLayoutVersion(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, int intLayoutVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intLayoutVersion, conCTCodeTypeGroupRela.LayoutVersion);
objCTCodeTypeGroupRelaEN.LayoutVersion = intLayoutVersion; //LayoutVersion
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.LayoutVersion) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.LayoutVersion, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutVersion] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetIsPinned(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsPinned, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPinned, conCTCodeTypeGroupRela.IsPinned);
objCTCodeTypeGroupRelaEN.IsPinned = bolIsPinned; //IsPinned
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.IsPinned) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.IsPinned, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.IsPinned] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetLayoutUpdatedBy(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strLayoutUpdatedBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLayoutUpdatedBy, 100, conCTCodeTypeGroupRela.LayoutUpdatedBy);
}
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = strLayoutUpdatedBy; //LayoutUpdatedBy
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.LayoutUpdatedBy) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.LayoutUpdatedBy, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutUpdatedBy] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetLayoutUpdatedAt(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strLayoutUpdatedAt, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLayoutUpdatedAt, 20, conCTCodeTypeGroupRela.LayoutUpdatedAt);
}
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = strLayoutUpdatedAt; //LayoutUpdatedAt
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.LayoutUpdatedAt) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.LayoutUpdatedAt, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutUpdatedAt] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetUpdDate(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCTCodeTypeGroupRela.UpdDate);
}
objCTCodeTypeGroupRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.UpdDate) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.UpdDate, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.UpdDate] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupRelaEN SetUpdUser(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCTCodeTypeGroupRela.UpdUser);
}
objCTCodeTypeGroupRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupRelaEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroupRela.UpdUser) == false)
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp.Add(conCTCodeTypeGroupRela.UpdUser, strComparisonOp);
}
else
{
objCTCodeTypeGroupRelaEN.dicFldComparisonOp[conCTCodeTypeGroupRela.UpdUser] = strComparisonOp;
}
}
return objCTCodeTypeGroupRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCTCodeTypeGroupRelaEN.CheckPropertyNew();
clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaCond = new clsCTCodeTypeGroupRelaEN();
string strCondition = objCTCodeTypeGroupRelaCond
.SetCtGroupId(objCTCodeTypeGroupRelaEN.CtGroupId, "=")
.GetCombineCondition();
objCTCodeTypeGroupRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCTCodeTypeGroupRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCTCodeTypeGroupRelaEN.Update();
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.UpdateBySql2(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.UpdateBySql2(objCTCodeTypeGroupRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.UpdateBySqlWithCondition(objCTCodeTypeGroupRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.UpdateBySqlWithConditionTransaction(objCTCodeTypeGroupRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
try
{
int intRecNum = clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.DelRecord(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupRelaENT">目标对象</param>
 public static void CopyTo(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENS, clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENT)
{
try
{
objCTCodeTypeGroupRelaENT.CtGroupId = objCTCodeTypeGroupRelaENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupRelaENT.CodeTypeId = objCTCodeTypeGroupRelaENS.CodeTypeId; //代码类型Id
objCTCodeTypeGroupRelaENT.IsMainGroup = objCTCodeTypeGroupRelaENS.IsMainGroup; //IsMainGroup
objCTCodeTypeGroupRelaENT.OrderNum = objCTCodeTypeGroupRelaENS.OrderNum; //序号
objCTCodeTypeGroupRelaENT.LayerNo = objCTCodeTypeGroupRelaENS.LayerNo; //LayerNo
objCTCodeTypeGroupRelaENT.PosX = objCTCodeTypeGroupRelaENS.PosX; //PosX
objCTCodeTypeGroupRelaENT.PosY = objCTCodeTypeGroupRelaENS.PosY; //PosY
objCTCodeTypeGroupRelaENT.PosXSmall = objCTCodeTypeGroupRelaENS.PosXSmall; //PosXSmall
objCTCodeTypeGroupRelaENT.PosYSmall = objCTCodeTypeGroupRelaENS.PosYSmall; //PosYSmall
objCTCodeTypeGroupRelaENT.PosXLarge = objCTCodeTypeGroupRelaENS.PosXLarge; //PosXLarge
objCTCodeTypeGroupRelaENT.PosYLarge = objCTCodeTypeGroupRelaENS.PosYLarge; //PosYLarge
objCTCodeTypeGroupRelaENT.LayoutVersion = objCTCodeTypeGroupRelaENS.LayoutVersion; //LayoutVersion
objCTCodeTypeGroupRelaENT.IsPinned = objCTCodeTypeGroupRelaENS.IsPinned; //IsPinned
objCTCodeTypeGroupRelaENT.LayoutUpdatedBy = objCTCodeTypeGroupRelaENS.LayoutUpdatedBy; //LayoutUpdatedBy
objCTCodeTypeGroupRelaENT.LayoutUpdatedAt = objCTCodeTypeGroupRelaENS.LayoutUpdatedAt; //LayoutUpdatedAt
objCTCodeTypeGroupRelaENT.UpdDate = objCTCodeTypeGroupRelaENS.UpdDate; //修改日期
objCTCodeTypeGroupRelaENT.UpdUser = objCTCodeTypeGroupRelaENS.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupRelaENS">源对象</param>
 /// <returns>目标对象=>clsCTCodeTypeGroupRelaEN:objCTCodeTypeGroupRelaENT</returns>
 public static clsCTCodeTypeGroupRelaEN CopyTo(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENS)
{
try
{
 clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENT = new clsCTCodeTypeGroupRelaEN()
{
CtGroupId = objCTCodeTypeGroupRelaENS.CtGroupId, //Ct组Id
CodeTypeId = objCTCodeTypeGroupRelaENS.CodeTypeId, //代码类型Id
IsMainGroup = objCTCodeTypeGroupRelaENS.IsMainGroup, //IsMainGroup
OrderNum = objCTCodeTypeGroupRelaENS.OrderNum, //序号
LayerNo = objCTCodeTypeGroupRelaENS.LayerNo, //LayerNo
PosX = objCTCodeTypeGroupRelaENS.PosX, //PosX
PosY = objCTCodeTypeGroupRelaENS.PosY, //PosY
PosXSmall = objCTCodeTypeGroupRelaENS.PosXSmall, //PosXSmall
PosYSmall = objCTCodeTypeGroupRelaENS.PosYSmall, //PosYSmall
PosXLarge = objCTCodeTypeGroupRelaENS.PosXLarge, //PosXLarge
PosYLarge = objCTCodeTypeGroupRelaENS.PosYLarge, //PosYLarge
LayoutVersion = objCTCodeTypeGroupRelaENS.LayoutVersion, //LayoutVersion
IsPinned = objCTCodeTypeGroupRelaENS.IsPinned, //IsPinned
LayoutUpdatedBy = objCTCodeTypeGroupRelaENS.LayoutUpdatedBy, //LayoutUpdatedBy
LayoutUpdatedAt = objCTCodeTypeGroupRelaENS.LayoutUpdatedAt, //LayoutUpdatedAt
UpdDate = objCTCodeTypeGroupRelaENS.UpdDate, //修改日期
UpdUser = objCTCodeTypeGroupRelaENS.UpdUser, //修改者
};
 return objCTCodeTypeGroupRelaENT;
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
public static void CheckPropertyNew(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 clsCTCodeTypeGroupRelaBL.CTCodeTypeGroupRelaDA.CheckProperty4Condition(objCTCodeTypeGroupRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.CtGroupId) == true)
{
string strComparisonOpCtGroupId = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.CtGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.CtGroupId, objCTCodeTypeGroupRelaCond.CtGroupId, strComparisonOpCtGroupId);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.CodeTypeId, objCTCodeTypeGroupRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup) == true)
{
if (objCTCodeTypeGroupRelaCond.IsMainGroup == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCTCodeTypeGroupRela.IsMainGroup);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCTCodeTypeGroupRela.IsMainGroup);
}
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.OrderNum, objCTCodeTypeGroupRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.LayerNo) == true)
{
string strComparisonOpLayerNo = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.LayerNo];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.LayerNo, objCTCodeTypeGroupRelaCond.LayerNo, strComparisonOpLayerNo);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosX) == true)
{
string strComparisonOpPosX = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosX];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosX, objCTCodeTypeGroupRelaCond.PosX, strComparisonOpPosX);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosY) == true)
{
string strComparisonOpPosY = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosY];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosY, objCTCodeTypeGroupRelaCond.PosY, strComparisonOpPosY);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosXSmall) == true)
{
string strComparisonOpPosXSmall = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosXSmall];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosXSmall, objCTCodeTypeGroupRelaCond.PosXSmall, strComparisonOpPosXSmall);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosYSmall) == true)
{
string strComparisonOpPosYSmall = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosYSmall];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosYSmall, objCTCodeTypeGroupRelaCond.PosYSmall, strComparisonOpPosYSmall);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosXLarge) == true)
{
string strComparisonOpPosXLarge = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosXLarge];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosXLarge, objCTCodeTypeGroupRelaCond.PosXLarge, strComparisonOpPosXLarge);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.PosYLarge) == true)
{
string strComparisonOpPosYLarge = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.PosYLarge];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.PosYLarge, objCTCodeTypeGroupRelaCond.PosYLarge, strComparisonOpPosYLarge);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion) == true)
{
string strComparisonOpLayoutVersion = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutVersion];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroupRela.LayoutVersion, objCTCodeTypeGroupRelaCond.LayoutVersion, strComparisonOpLayoutVersion);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.IsPinned) == true)
{
if (objCTCodeTypeGroupRelaCond.IsPinned == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCTCodeTypeGroupRela.IsPinned);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCTCodeTypeGroupRela.IsPinned);
}
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy) == true)
{
string strComparisonOpLayoutUpdatedBy = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutUpdatedBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.LayoutUpdatedBy, objCTCodeTypeGroupRelaCond.LayoutUpdatedBy, strComparisonOpLayoutUpdatedBy);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt) == true)
{
string strComparisonOpLayoutUpdatedAt = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.LayoutUpdatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.LayoutUpdatedAt, objCTCodeTypeGroupRelaCond.LayoutUpdatedAt, strComparisonOpLayoutUpdatedAt);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.UpdDate, objCTCodeTypeGroupRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCTCodeTypeGroupRelaCond.IsUpdated(conCTCodeTypeGroupRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[conCTCodeTypeGroupRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroupRela.UpdUser, objCTCodeTypeGroupRelaCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CTCodeTypeGroupRela
{
public virtual bool UpdRelaTabDate(string strCtGroupId,string strCodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCTCodeTypeGroupRelaBL
{
public static RelatedActions_CTCodeTypeGroupRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCTCodeTypeGroupRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCTCodeTypeGroupRelaDA CTCodeTypeGroupRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCTCodeTypeGroupRelaDA();
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
 public clsCTCodeTypeGroupRelaBL()
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
if (string.IsNullOrEmpty(clsCTCodeTypeGroupRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupRelaEN._ConnectString);
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
public static DataTable GetDataTable_CTCodeTypeGroupRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CTCodeTypeGroupRelaDA.GetDataTable_CTCodeTypeGroupRela(strWhereCond);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable(strWhereCond);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CTCodeTypeGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objCTCodeTypeGroupRelaEN.CtGroupId;
strResult += "|" + objCTCodeTypeGroupRelaEN.CodeTypeId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCTCodeTypeGroupRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsCTCodeTypeGroupRelaEN._CurrTabName);
List<clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLst_Sel =
arrCTCodeTypeGroupRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrCTCodeTypeGroupRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetObjLst(string strWhereCond)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
public static List<clsCTCodeTypeGroupRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCTCodeTypeGroupRelaEN> GetSubObjLstCache(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaCond)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTCodeTypeGroupRela._AttributeName)
{
if (objCTCodeTypeGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objCTCodeTypeGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupRelaCond[strFldName].ToString());
}
else
{
if (objCTCodeTypeGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTCodeTypeGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupRelaCond[strFldName]));
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
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
List<clsCTCodeTypeGroupRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCTCodeTypeGroupRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCTCodeTypeGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
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
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
public static List<clsCTCodeTypeGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupRelaEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCTCodeTypeGroupRela(ref clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
bool bolResult = CTCodeTypeGroupRelaDA.GetCTCodeTypeGroupRela(ref objCTCodeTypeGroupRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCTCodeTypeGroupRelaEN GetObjByKeyLst(string strCtGroupId,string strCodeTypeId)
{
if (strCtGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strCtGroupId,strCodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strCodeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strCtGroupId,strCodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCtGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strCtGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strCodeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = CTCodeTypeGroupRelaDA.GetObjByKeyLst(strCtGroupId,strCodeTypeId);
return objCTCodeTypeGroupRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCTCodeTypeGroupRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = CTCodeTypeGroupRelaDA.GetFirstObj(strWhereCond);
 return objCTCodeTypeGroupRelaEN;
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
public static clsCTCodeTypeGroupRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = CTCodeTypeGroupRelaDA.GetObjByDataRow(objRow);
 return objCTCodeTypeGroupRelaEN;
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
public static clsCTCodeTypeGroupRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = CTCodeTypeGroupRelaDA.GetObjByDataRow(objRow);
 return objCTCodeTypeGroupRelaEN;
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
 /// <param name = "strCtGroupId">表关键字</param>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <param name = "lstCTCodeTypeGroupRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTCodeTypeGroupRelaEN GetObjByKeyLstFromList(string strCtGroupId,string strCodeTypeId, List<clsCTCodeTypeGroupRelaEN> lstCTCodeTypeGroupRelaObjLst)
{
foreach (clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN in lstCTCodeTypeGroupRelaObjLst)
{
if (objCTCodeTypeGroupRelaEN.CtGroupId == strCtGroupId 
 && objCTCodeTypeGroupRelaEN.CodeTypeId == strCodeTypeId 
)
{
return objCTCodeTypeGroupRelaEN;
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
 string strCtGroupId;
 try
 {
 strCtGroupId = new clsCTCodeTypeGroupRelaDA().GetFirstID(strWhereCond);
 return strCtGroupId;
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
 arrList = CTCodeTypeGroupRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CTCodeTypeGroupRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCtGroupId,string strCodeTypeId)
{
//检测记录是否存在
bool bolIsExist = CTCodeTypeGroupRelaDA.IsExist(strCtGroupId,strCodeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCtGroupId">Ct组Id</param>
/// <param name = "strCodeTypeId">代码类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCtGroupId , string strCodeTypeId, string strOpUser)
{
clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = clsCTCodeTypeGroupRelaBL.GetObjByKeyLst(strCtGroupId,strCodeTypeId);
objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCTCodeTypeGroupRelaEN.UpdUser = strOpUser;
return clsCTCodeTypeGroupRelaBL.UpdateBySql2(objCTCodeTypeGroupRelaEN);
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
 bolIsExist = clsCTCodeTypeGroupRelaDA.IsExistTable();
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
 bolIsExist = CTCodeTypeGroupRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTCodeTypeGroupRelaBL.IsExist(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTCodeTypeGroupRelaEN.CtGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CTCodeTypeGroupRelaDA.AddNewRecordBySQL2(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCTCodeTypeGroupRelaBL.IsExist(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCTCodeTypeGroupRelaEN.CtGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CTCodeTypeGroupRelaDA.AddNewRecordBySQL2WithReturnKey(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
try
{
bool bolResult = CTCodeTypeGroupRelaDA.Update(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupRelaEN.CtGroupId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CTCodeTypeGroupRelaDA.UpdateBySql2(objCTCodeTypeGroupRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupRelaBL.ReFreshCache();

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCtGroupId,string strCodeTypeId)
{
try
{
 clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = clsCTCodeTypeGroupRelaBL.GetObjByKeyLst(strCtGroupId,strCodeTypeId);

if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId, objCTCodeTypeGroupRelaEN.UpdUser);
}
if (objCTCodeTypeGroupRelaEN != null)
{
int intRecNum = CTCodeTypeGroupRelaDA.DelRecord(strCtGroupId,strCodeTypeId);
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
/// <param name="strCtGroupId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCtGroupId,string strCodeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
//删除与表:[CTCodeTypeGroupRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCTCodeTypeGroupRela.CtGroupId,
//strCtGroupId);
//        clsCTCodeTypeGroupRelaBL.DelCTCodeTypeGroupRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTCodeTypeGroupRelaBL.DelRecord(strCtGroupId,strCodeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTCodeTypeGroupRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCtGroupId,string strCodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(strCtGroupId,strCodeTypeId, "UpdRelaTabDate");
}
bool bolResult = CTCodeTypeGroupRelaDA.DelRecord(strCtGroupId,strCodeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCtGroupIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strCtGroupId;
string strCodeTypeId;
if (clsCTCodeTypeGroupRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strCtGroupId = sstrKey[0];
strCodeTypeId = sstrKey[1];
clsCTCodeTypeGroupRelaBL.relatedActions.UpdRelaTabDate(strCtGroupId,strCodeTypeId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strCtGroupId = sstrKey[0];
strCodeTypeId = sstrKey[1];
int intDelRecNum = CTCodeTypeGroupRelaDA.DelRecKeyLsts(arrKeyLsts);
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
public static int DelCTCodeTypeGroupRelasByCond(string strWhereCond)
{
try
{
int intRecNum = CTCodeTypeGroupRelaDA.DelCTCodeTypeGroupRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CTCodeTypeGroupRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCtGroupId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCtGroupId,string strCodeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
//删除与表:[CTCodeTypeGroupRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTCodeTypeGroupRelaBL.DelRecord(strCtGroupId,strCodeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTCodeTypeGroupRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCTCodeTypeGroupRelaENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupRelaENT">目标对象</param>
 public static void CopyTo(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENS, clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENT)
{
try
{
objCTCodeTypeGroupRelaENT.CtGroupId = objCTCodeTypeGroupRelaENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupRelaENT.CodeTypeId = objCTCodeTypeGroupRelaENS.CodeTypeId; //代码类型Id
objCTCodeTypeGroupRelaENT.IsMainGroup = objCTCodeTypeGroupRelaENS.IsMainGroup; //IsMainGroup
objCTCodeTypeGroupRelaENT.OrderNum = objCTCodeTypeGroupRelaENS.OrderNum; //序号
objCTCodeTypeGroupRelaENT.LayerNo = objCTCodeTypeGroupRelaENS.LayerNo; //LayerNo
objCTCodeTypeGroupRelaENT.PosX = objCTCodeTypeGroupRelaENS.PosX; //PosX
objCTCodeTypeGroupRelaENT.PosY = objCTCodeTypeGroupRelaENS.PosY; //PosY
objCTCodeTypeGroupRelaENT.PosXSmall = objCTCodeTypeGroupRelaENS.PosXSmall; //PosXSmall
objCTCodeTypeGroupRelaENT.PosYSmall = objCTCodeTypeGroupRelaENS.PosYSmall; //PosYSmall
objCTCodeTypeGroupRelaENT.PosXLarge = objCTCodeTypeGroupRelaENS.PosXLarge; //PosXLarge
objCTCodeTypeGroupRelaENT.PosYLarge = objCTCodeTypeGroupRelaENS.PosYLarge; //PosYLarge
objCTCodeTypeGroupRelaENT.LayoutVersion = objCTCodeTypeGroupRelaENS.LayoutVersion; //LayoutVersion
objCTCodeTypeGroupRelaENT.IsPinned = objCTCodeTypeGroupRelaENS.IsPinned; //IsPinned
objCTCodeTypeGroupRelaENT.LayoutUpdatedBy = objCTCodeTypeGroupRelaENS.LayoutUpdatedBy; //LayoutUpdatedBy
objCTCodeTypeGroupRelaENT.LayoutUpdatedAt = objCTCodeTypeGroupRelaENS.LayoutUpdatedAt; //LayoutUpdatedAt
objCTCodeTypeGroupRelaENT.UpdDate = objCTCodeTypeGroupRelaENS.UpdDate; //修改日期
objCTCodeTypeGroupRelaENT.UpdUser = objCTCodeTypeGroupRelaENS.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
try
{
objCTCodeTypeGroupRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCTCodeTypeGroupRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCTCodeTypeGroupRela.CtGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.CtGroupId = objCTCodeTypeGroupRelaEN.CtGroupId; //Ct组Id
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.CodeTypeId = objCTCodeTypeGroupRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.IsMainGroup, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.IsMainGroup = objCTCodeTypeGroupRelaEN.IsMainGroup; //IsMainGroup
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.OrderNum = objCTCodeTypeGroupRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.LayerNo, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.LayerNo = objCTCodeTypeGroupRelaEN.LayerNo; //LayerNo
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosX, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosX = objCTCodeTypeGroupRelaEN.PosX; //PosX
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosY, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosY = objCTCodeTypeGroupRelaEN.PosY; //PosY
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosXSmall, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosXSmall = objCTCodeTypeGroupRelaEN.PosXSmall; //PosXSmall
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosYSmall, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosYSmall = objCTCodeTypeGroupRelaEN.PosYSmall; //PosYSmall
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosXLarge, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosXLarge = objCTCodeTypeGroupRelaEN.PosXLarge; //PosXLarge
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.PosYLarge, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.PosYLarge = objCTCodeTypeGroupRelaEN.PosYLarge; //PosYLarge
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.LayoutVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.LayoutVersion = objCTCodeTypeGroupRelaEN.LayoutVersion; //LayoutVersion
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.IsPinned, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.IsPinned = objCTCodeTypeGroupRelaEN.IsPinned; //IsPinned
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.LayoutUpdatedBy, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy == "[null]" ? null :  objCTCodeTypeGroupRelaEN.LayoutUpdatedBy; //LayoutUpdatedBy
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.LayoutUpdatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt == "[null]" ? null :  objCTCodeTypeGroupRelaEN.LayoutUpdatedAt; //LayoutUpdatedAt
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.UpdDate = objCTCodeTypeGroupRelaEN.UpdDate == "[null]" ? null :  objCTCodeTypeGroupRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCTCodeTypeGroupRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupRelaEN.UpdUser = objCTCodeTypeGroupRelaEN.UpdUser == "[null]" ? null :  objCTCodeTypeGroupRelaEN.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
try
{
if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy == "[null]") objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = null; //LayoutUpdatedBy
if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt == "[null]") objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = null; //LayoutUpdatedAt
if (objCTCodeTypeGroupRelaEN.UpdDate == "[null]") objCTCodeTypeGroupRelaEN.UpdDate = null; //修改日期
if (objCTCodeTypeGroupRelaEN.UpdUser == "[null]") objCTCodeTypeGroupRelaEN.UpdUser = null; //修改者
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
public static void CheckPropertyNew(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 CTCodeTypeGroupRelaDA.CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 CTCodeTypeGroupRelaDA.CheckProperty4Condition(objCTCodeTypeGroupRelaEN);
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
if (clsCTCodeTypeGroupRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCTCodeTypeGroupRelaBL没有刷新缓存机制(clsCTCodeTypeGroupRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CtGroupId");
//if (arrCTCodeTypeGroupRelaObjLstCache == null)
//{
//arrCTCodeTypeGroupRelaObjLstCache = CTCodeTypeGroupRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTCodeTypeGroupRelaEN GetObjByKeyLstCache(string strCtGroupId,string strCodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCTCodeTypeGroupRelaEN._CurrTabName);
List<clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLst_Sel =
arrCTCodeTypeGroupRelaObjLstCache
.Where(x=> x.CtGroupId == strCtGroupId 
 && x.CodeTypeId == strCodeTypeId 
);
if (arrCTCodeTypeGroupRelaObjLst_Sel.Count() == 0)
{
   clsCTCodeTypeGroupRelaEN obj = clsCTCodeTypeGroupRelaBL.GetObjByKeyLst(strCtGroupId,strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCTCodeTypeGroupRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetAllCTCodeTypeGroupRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLstCache = GetObjLstCache(); 
return arrCTCodeTypeGroupRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTCodeTypeGroupRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCTCodeTypeGroupRelaEN._CurrTabName);
List<clsCTCodeTypeGroupRelaEN> arrCTCodeTypeGroupRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCTCodeTypeGroupRelaObjLstCache;
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
string strKey = string.Format("{0}", clsCTCodeTypeGroupRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTCodeTypeGroupRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCTCodeTypeGroupRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCTCodeTypeGroupRelaEN._RefreshTimeLst[clsCTCodeTypeGroupRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCTCodeTypeGroupRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCTCodeTypeGroupRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTCodeTypeGroupRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCTCodeTypeGroupRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-06-07
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCtGroupId,string strCodeTypeId)
{
if (strInFldName != conCTCodeTypeGroupRela.CtGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCTCodeTypeGroupRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCTCodeTypeGroupRela._AttributeName));
throw new Exception(strMsg);
}
var objCTCodeTypeGroupRela = clsCTCodeTypeGroupRelaBL.GetObjByKeyLstCache(strCtGroupId,strCodeTypeId);
if (objCTCodeTypeGroupRela == null) return "";
return objCTCodeTypeGroupRela[strOutFldName].ToString();
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
int intRecCount = clsCTCodeTypeGroupRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCTCodeTypeGroupRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCTCodeTypeGroupRelaDA.GetRecCount();
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
int intRecCount = clsCTCodeTypeGroupRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaCond)
{
List<clsCTCodeTypeGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTCodeTypeGroupRela._AttributeName)
{
if (objCTCodeTypeGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objCTCodeTypeGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupRelaCond[strFldName].ToString());
}
else
{
if (objCTCodeTypeGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTCodeTypeGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTCodeTypeGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTCodeTypeGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupRelaCond[strFldName]));
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
 List<string> arrList = clsCTCodeTypeGroupRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CTCodeTypeGroupRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CTCodeTypeGroupRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CTCodeTypeGroupRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupRelaDA.SetFldValue(clsCTCodeTypeGroupRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CTCodeTypeGroupRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CTCodeTypeGroupRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Ct组Id*/ 
 strCreateTabCode.Append(" CtGroupId char(4) primary key, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) primary key, "); 
 // /**IsMainGroup*/ 
 strCreateTabCode.Append(" IsMainGroup bit not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**LayerNo*/ 
 strCreateTabCode.Append(" LayerNo int Null, "); 
 // /**PosX*/ 
 strCreateTabCode.Append(" PosX int Null, "); 
 // /**PosY*/ 
 strCreateTabCode.Append(" PosY int Null, "); 
 // /**PosXSmall*/ 
 strCreateTabCode.Append(" PosXSmall int Null, "); 
 // /**PosYSmall*/ 
 strCreateTabCode.Append(" PosYSmall int Null, "); 
 // /**PosXLarge*/ 
 strCreateTabCode.Append(" PosXLarge int Null, "); 
 // /**PosYLarge*/ 
 strCreateTabCode.Append(" PosYLarge int Null, "); 
 // /**LayoutVersion*/ 
 strCreateTabCode.Append(" LayoutVersion int not Null, "); 
 // /**IsPinned*/ 
 strCreateTabCode.Append(" IsPinned bit not Null, "); 
 // /**LayoutUpdatedBy*/ 
 strCreateTabCode.Append(" LayoutUpdatedBy nvarchar(100) Null, "); 
 // /**LayoutUpdatedAt*/ 
 strCreateTabCode.Append(" LayoutUpdatedAt varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CTCodeTypeGroupRela : clsCommFun4BL
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
clsCTCodeTypeGroupRelaBL.ReFreshThisCache();
}
}

}