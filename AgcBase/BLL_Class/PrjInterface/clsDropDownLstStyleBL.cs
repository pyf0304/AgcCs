
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDropDownLstStyleBL
 表名:DropDownLstStyle(00050060)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsDropDownLstStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDropDownLstStyleEN GetObj(this K_DropDownLstStyleId_DropDownLstStyle myKey)
{
clsDropDownLstStyleEN objDropDownLstStyleEN = clsDropDownLstStyleBL.DropDownLstStyleDA.GetObjByDropDownLstStyleId(myKey.Value);
return objDropDownLstStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDropDownLstStyleBL.IsExist(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDropDownLstStyleEN.DropDownLstStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDropDownLstStyleBL.DropDownLstStyleDA.AddNewRecordBySQL2(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDropDownLstStyleBL.IsExist(objDropDownLstStyleEN.DropDownLstStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDropDownLstStyleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDropDownLstStyleEN.AddNewRecord();
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDropDownLstStyleBL.IsExist(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDropDownLstStyleEN.DropDownLstStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDropDownLstStyleBL.DropDownLstStyleDA.AddNewRecordBySQL2WithReturnKey(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDropDownLstStyleId(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDropDownLstStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDropDownLstStyleId, 4, conDropDownLstStyle.DropDownLstStyleId);
}
objDropDownLstStyleEN.DropDownLstStyleId = strDropDownLstStyleId; //DropDownLstStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DropDownLstStyleId) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DropDownLstStyleId, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleId] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDropDownLstStyleName(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDropDownLstStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDropDownLstStyleName, 30, conDropDownLstStyle.DropDownLstStyleName);
}
objDropDownLstStyleEN.DropDownLstStyleName = strDropDownLstStyleName; //DropDownLstStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DropDownLstStyleName) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DropDownLstStyleName, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleName] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyle(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conDropDownLstStyle.Style);
}
objDropDownLstStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Style) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Style, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Style] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetRunat(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRunat, conDropDownLstStyle.Runat);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conDropDownLstStyle.Runat);
}
objDropDownLstStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Runat) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Runat, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Runat] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetFontSize(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontSize, conDropDownLstStyle.FontSize);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conDropDownLstStyle.FontSize);
}
objDropDownLstStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.FontSize) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.FontSize, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.FontSize] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetFontName(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontName, conDropDownLstStyle.FontName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conDropDownLstStyle.FontName);
}
objDropDownLstStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.FontName) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.FontName, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.FontName] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetWidth(this clsDropDownLstStyleEN objDropDownLstStyleEN, int? intWidth, string strComparisonOp="")
	{
objDropDownLstStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Width) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Width, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Width] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetHeight(this clsDropDownLstStyleEN objDropDownLstStyleEN, int? intHeight, string strComparisonOp="")
	{
objDropDownLstStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Height) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Height, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Height] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetTextMode(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strTextMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextMode, conDropDownLstStyle.TextMode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextMode, 20, conDropDownLstStyle.TextMode);
}
objDropDownLstStyleEN.TextMode = strTextMode; //TextMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.TextMode) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.TextMode, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.TextMode] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetReadOnly(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolReadOnly, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolReadOnly, conDropDownLstStyle.ReadOnly);
objDropDownLstStyleEN.ReadOnly = bolReadOnly; //ReadOnly
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.ReadOnly) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.ReadOnly, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.ReadOnly] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetBackColor(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strBackColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBackColor, 30, conDropDownLstStyle.BackColor);
}
objDropDownLstStyleEN.BackColor = strBackColor; //背景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.BackColor) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.BackColor, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.BackColor] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetForeColor(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strForeColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeColor, 30, conDropDownLstStyle.ForeColor);
}
objDropDownLstStyleEN.ForeColor = strForeColor; //前景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.ForeColor) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.ForeColor, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.ForeColor] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataTextField(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataTextField, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTextField, 30, conDropDownLstStyle.DataTextField);
}
objDropDownLstStyleEN.DataTextField = strDataTextField; //DataTextField
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataTextField) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataTextField, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataTextField] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataValueField(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataValueField, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataValueField, 30, conDropDownLstStyle.DataValueField);
}
objDropDownLstStyleEN.DataValueField = strDataValueField; //DataValueField
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataValueField) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataValueField, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataValueField] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataTextFormatString(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataTextFormatString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTextFormatString, 30, conDropDownLstStyle.DataTextFormatString);
}
objDropDownLstStyleEN.DataTextFormatString = strDataTextFormatString; //DataTextFormatString
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataTextFormatString) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataTextFormatString, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataTextFormatString] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetAccessKey(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strAccessKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAccessKey, 30, conDropDownLstStyle.AccessKey);
}
objDropDownLstStyleEN.AccessKey = strAccessKey; //AccessKey
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.AccessKey) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.AccessKey, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.AccessKey] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetAutoPostBack(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolAutoPostBack, string strComparisonOp="")
	{
objDropDownLstStyleEN.AutoPostBack = bolAutoPostBack; //AutoPostBack
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.AutoPostBack) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.AutoPostBack, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.AutoPostBack] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetVisible(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolVisible, string strComparisonOp="")
	{
objDropDownLstStyleEN.Visible = bolVisible; //Visible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Visible) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Visible, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Visible] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleZindex(this clsDropDownLstStyleEN objDropDownLstStyleEN, int? intStyleZindex, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleZindex) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleZindex, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleZindex] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleLeft(this clsDropDownLstStyleEN objDropDownLstStyleEN, int? intStyleLeft, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleLeft) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleLeft, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleLeft] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStylePosition(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conDropDownLstStyle.StylePosition);
}
objDropDownLstStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StylePosition) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StylePosition, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StylePosition] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleTop(this clsDropDownLstStyleEN objDropDownLstStyleEN, int? intStyleTop, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleTop) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleTop, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleTop] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDropDownLstStyleEN.CheckPropertyNew();
clsDropDownLstStyleEN objDropDownLstStyleCond = new clsDropDownLstStyleEN();
string strCondition = objDropDownLstStyleCond
.SetDropDownLstStyleId(objDropDownLstStyleEN.DropDownLstStyleId, "=")
.GetCombineCondition();
objDropDownLstStyleEN._IsCheckProperty = true;
bool bolIsExist = clsDropDownLstStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDropDownLstStyleEN.Update();
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDropDownLstStyleBL.DropDownLstStyleDA.UpdateBySql2(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDropDownLstStyleEN objDropDownLstStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDropDownLstStyleBL.DropDownLstStyleDA.UpdateBySql2(objDropDownLstStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsDropDownLstStyleBL.DropDownLstStyleDA.UpdateBySqlWithCondition(objDropDownLstStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDropDownLstStyleBL.DropDownLstStyleDA.UpdateBySqlWithConditionTransaction(objDropDownLstStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
try
{
int intRecNum = clsDropDownLstStyleBL.DropDownLstStyleDA.DelRecord(objDropDownLstStyleEN.DropDownLstStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleENS">源对象</param>
 /// <param name = "objDropDownLstStyleENT">目标对象</param>
 public static void CopyTo(this clsDropDownLstStyleEN objDropDownLstStyleENS, clsDropDownLstStyleEN objDropDownLstStyleENT)
{
try
{
objDropDownLstStyleENT.DropDownLstStyleId = objDropDownLstStyleENS.DropDownLstStyleId; //DropDownLstStyleId
objDropDownLstStyleENT.DropDownLstStyleName = objDropDownLstStyleENS.DropDownLstStyleName; //DropDownLstStyleName
objDropDownLstStyleENT.Style = objDropDownLstStyleENS.Style; //类型
objDropDownLstStyleENT.Runat = objDropDownLstStyleENS.Runat; //运行在
objDropDownLstStyleENT.FontSize = objDropDownLstStyleENS.FontSize; //字号
objDropDownLstStyleENT.FontName = objDropDownLstStyleENS.FontName; //字体
objDropDownLstStyleENT.Width = objDropDownLstStyleENS.Width; //宽
objDropDownLstStyleENT.Height = objDropDownLstStyleENS.Height; //高度
objDropDownLstStyleENT.TextMode = objDropDownLstStyleENS.TextMode; //TextMode
objDropDownLstStyleENT.ReadOnly = objDropDownLstStyleENS.ReadOnly; //ReadOnly
objDropDownLstStyleENT.BackColor = objDropDownLstStyleENS.BackColor; //背景颜色
objDropDownLstStyleENT.ForeColor = objDropDownLstStyleENS.ForeColor; //前景颜色
objDropDownLstStyleENT.DataTextField = objDropDownLstStyleENS.DataTextField; //DataTextField
objDropDownLstStyleENT.DataValueField = objDropDownLstStyleENS.DataValueField; //DataValueField
objDropDownLstStyleENT.DataTextFormatString = objDropDownLstStyleENS.DataTextFormatString; //DataTextFormatString
objDropDownLstStyleENT.AccessKey = objDropDownLstStyleENS.AccessKey; //AccessKey
objDropDownLstStyleENT.AutoPostBack = objDropDownLstStyleENS.AutoPostBack; //AutoPostBack
objDropDownLstStyleENT.Visible = objDropDownLstStyleENS.Visible; //Visible
objDropDownLstStyleENT.StyleZindex = objDropDownLstStyleENS.StyleZindex; //Style_Zindex
objDropDownLstStyleENT.StyleLeft = objDropDownLstStyleENS.StyleLeft; //Style_Left
objDropDownLstStyleENT.StylePosition = objDropDownLstStyleENS.StylePosition; //Style_Position
objDropDownLstStyleENT.StyleTop = objDropDownLstStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objDropDownLstStyleENS">源对象</param>
 /// <returns>目标对象=>clsDropDownLstStyleEN:objDropDownLstStyleENT</returns>
 public static clsDropDownLstStyleEN CopyTo(this clsDropDownLstStyleEN objDropDownLstStyleENS)
{
try
{
 clsDropDownLstStyleEN objDropDownLstStyleENT = new clsDropDownLstStyleEN()
{
DropDownLstStyleId = objDropDownLstStyleENS.DropDownLstStyleId, //DropDownLstStyleId
DropDownLstStyleName = objDropDownLstStyleENS.DropDownLstStyleName, //DropDownLstStyleName
Style = objDropDownLstStyleENS.Style, //类型
Runat = objDropDownLstStyleENS.Runat, //运行在
FontSize = objDropDownLstStyleENS.FontSize, //字号
FontName = objDropDownLstStyleENS.FontName, //字体
Width = objDropDownLstStyleENS.Width, //宽
Height = objDropDownLstStyleENS.Height, //高度
TextMode = objDropDownLstStyleENS.TextMode, //TextMode
ReadOnly = objDropDownLstStyleENS.ReadOnly, //ReadOnly
BackColor = objDropDownLstStyleENS.BackColor, //背景颜色
ForeColor = objDropDownLstStyleENS.ForeColor, //前景颜色
DataTextField = objDropDownLstStyleENS.DataTextField, //DataTextField
DataValueField = objDropDownLstStyleENS.DataValueField, //DataValueField
DataTextFormatString = objDropDownLstStyleENS.DataTextFormatString, //DataTextFormatString
AccessKey = objDropDownLstStyleENS.AccessKey, //AccessKey
AutoPostBack = objDropDownLstStyleENS.AutoPostBack, //AutoPostBack
Visible = objDropDownLstStyleENS.Visible, //Visible
StyleZindex = objDropDownLstStyleENS.StyleZindex, //Style_Zindex
StyleLeft = objDropDownLstStyleENS.StyleLeft, //Style_Left
StylePosition = objDropDownLstStyleENS.StylePosition, //Style_Position
StyleTop = objDropDownLstStyleENS.StyleTop, //Style_Top
};
 return objDropDownLstStyleENT;
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
public static void CheckPropertyNew(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 clsDropDownLstStyleBL.DropDownLstStyleDA.CheckPropertyNew(objDropDownLstStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 clsDropDownLstStyleBL.DropDownLstStyleDA.CheckProperty4Condition(objDropDownLstStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDropDownLstStyleEN objDropDownLstStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DropDownLstStyleId) == true)
{
string strComparisonOpDropDownLstStyleId = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DropDownLstStyleId, objDropDownLstStyleCond.DropDownLstStyleId, strComparisonOpDropDownLstStyleId);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DropDownLstStyleName) == true)
{
string strComparisonOpDropDownLstStyleName = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DropDownLstStyleName, objDropDownLstStyleCond.DropDownLstStyleName, strComparisonOpDropDownLstStyleName);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Style) == true)
{
string strComparisonOpStyle = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.Style, objDropDownLstStyleCond.Style, strComparisonOpStyle);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Runat) == true)
{
string strComparisonOpRunat = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.Runat, objDropDownLstStyleCond.Runat, strComparisonOpRunat);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.FontSize) == true)
{
string strComparisonOpFontSize = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.FontSize, objDropDownLstStyleCond.FontSize, strComparisonOpFontSize);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.FontName) == true)
{
string strComparisonOpFontName = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.FontName, objDropDownLstStyleCond.FontName, strComparisonOpFontName);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Width) == true)
{
string strComparisonOpWidth = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.Width, objDropDownLstStyleCond.Width, strComparisonOpWidth);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Height) == true)
{
string strComparisonOpHeight = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.Height, objDropDownLstStyleCond.Height, strComparisonOpHeight);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.TextMode) == true)
{
string strComparisonOpTextMode = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.TextMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.TextMode, objDropDownLstStyleCond.TextMode, strComparisonOpTextMode);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.ReadOnly) == true)
{
if (objDropDownLstStyleCond.ReadOnly == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.ReadOnly);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.ReadOnly);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.BackColor) == true)
{
string strComparisonOpBackColor = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.BackColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.BackColor, objDropDownLstStyleCond.BackColor, strComparisonOpBackColor);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.ForeColor) == true)
{
string strComparisonOpForeColor = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.ForeColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.ForeColor, objDropDownLstStyleCond.ForeColor, strComparisonOpForeColor);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataTextField) == true)
{
string strComparisonOpDataTextField = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataTextField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataTextField, objDropDownLstStyleCond.DataTextField, strComparisonOpDataTextField);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataValueField) == true)
{
string strComparisonOpDataValueField = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataValueField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataValueField, objDropDownLstStyleCond.DataValueField, strComparisonOpDataValueField);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataTextFormatString) == true)
{
string strComparisonOpDataTextFormatString = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataTextFormatString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataTextFormatString, objDropDownLstStyleCond.DataTextFormatString, strComparisonOpDataTextFormatString);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.AccessKey) == true)
{
string strComparisonOpAccessKey = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.AccessKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.AccessKey, objDropDownLstStyleCond.AccessKey, strComparisonOpAccessKey);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.AutoPostBack) == true)
{
if (objDropDownLstStyleCond.AutoPostBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.AutoPostBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.AutoPostBack);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Visible) == true)
{
if (objDropDownLstStyleCond.Visible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.Visible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.Visible);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleZindex, objDropDownLstStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleLeft, objDropDownLstStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.StylePosition, objDropDownLstStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleTop, objDropDownLstStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DropDownLstStyle
{
public virtual bool UpdRelaTabDate(string strDropDownLstStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 下拉框样式(DropDownLstStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDropDownLstStyleBL
{
public static RelatedActions_DropDownLstStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDropDownLstStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDropDownLstStyleDA DropDownLstStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDropDownLstStyleDA();
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
 public clsDropDownLstStyleBL()
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
if (string.IsNullOrEmpty(clsDropDownLstStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDropDownLstStyleEN._ConnectString);
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
public static DataTable GetDataTable_DropDownLstStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DropDownLstStyleDA.GetDataTable_DropDownLstStyle(strWhereCond);
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
objDT = DropDownLstStyleDA.GetDataTable(strWhereCond);
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
objDT = DropDownLstStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DropDownLstStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DropDownLstStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DropDownLstStyleDA.GetDataTable_Top(objTopPara);
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
objDT = DropDownLstStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DropDownLstStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DropDownLstStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDropDownLstStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstByDropDownLstStyleIdLst(List<string> arrDropDownLstStyleIdLst)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDropDownLstStyleIdLst, true);
 string strWhereCond = string.Format("DropDownLstStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDropDownLstStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDropDownLstStyleEN> GetObjLstByDropDownLstStyleIdLstCache(List<string> arrDropDownLstStyleIdLst)
{
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel =
arrDropDownLstStyleObjLstCache
.Where(x => arrDropDownLstStyleIdLst.Contains(x.DropDownLstStyleId));
return arrDropDownLstStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLst(string strWhereCond)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
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
public static List<clsDropDownLstStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDropDownLstStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDropDownLstStyleEN> GetSubObjLstCache(clsDropDownLstStyleEN objDropDownLstStyleCond)
{
List<clsDropDownLstStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDropDownLstStyle._AttributeName)
{
if (objDropDownLstStyleCond.IsUpdated(strFldName) == false) continue;
if (objDropDownLstStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDropDownLstStyleCond[strFldName].ToString());
}
else
{
if (objDropDownLstStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDropDownLstStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDropDownLstStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDropDownLstStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDropDownLstStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDropDownLstStyleCond[strFldName]));
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
public static List<clsDropDownLstStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
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
public static List<clsDropDownLstStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
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
List<clsDropDownLstStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDropDownLstStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDropDownLstStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
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
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
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
public static List<clsDropDownLstStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDropDownLstStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
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
public static List<clsDropDownLstStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDropDownLstStyleEN.DropDownLstStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDropDownLstStyle(ref clsDropDownLstStyleEN objDropDownLstStyleEN)
{
bool bolResult = DropDownLstStyleDA.GetDropDownLstStyle(ref objDropDownLstStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDropDownLstStyleEN GetObjByDropDownLstStyleId(string strDropDownLstStyleId)
{
if (strDropDownLstStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDropDownLstStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDropDownLstStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDropDownLstStyleEN objDropDownLstStyleEN = DropDownLstStyleDA.GetObjByDropDownLstStyleId(strDropDownLstStyleId);
return objDropDownLstStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDropDownLstStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDropDownLstStyleEN objDropDownLstStyleEN = DropDownLstStyleDA.GetFirstObj(strWhereCond);
 return objDropDownLstStyleEN;
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
public static clsDropDownLstStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDropDownLstStyleEN objDropDownLstStyleEN = DropDownLstStyleDA.GetObjByDataRow(objRow);
 return objDropDownLstStyleEN;
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
public static clsDropDownLstStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDropDownLstStyleEN objDropDownLstStyleEN = DropDownLstStyleDA.GetObjByDataRow(objRow);
 return objDropDownLstStyleEN;
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
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <param name = "lstDropDownLstStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDropDownLstStyleEN GetObjByDropDownLstStyleIdFromList(string strDropDownLstStyleId, List<clsDropDownLstStyleEN> lstDropDownLstStyleObjLst)
{
foreach (clsDropDownLstStyleEN objDropDownLstStyleEN in lstDropDownLstStyleObjLst)
{
if (objDropDownLstStyleEN.DropDownLstStyleId == strDropDownLstStyleId)
{
return objDropDownLstStyleEN;
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
 string strDropDownLstStyleId;
 try
 {
 strDropDownLstStyleId = new clsDropDownLstStyleDA().GetFirstID(strWhereCond);
 return strDropDownLstStyleId;
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
 arrList = DropDownLstStyleDA.GetID(strWhereCond);
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
bool bolIsExist = DropDownLstStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDropDownLstStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DropDownLstStyleDA.IsExist(strDropDownLstStyleId);
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
 bolIsExist = clsDropDownLstStyleDA.IsExistTable();
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
 bolIsExist = DropDownLstStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDropDownLstStyleBL.IsExist(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDropDownLstStyleEN.DropDownLstStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DropDownLstStyleDA.AddNewRecordBySQL2(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDropDownLstStyleBL.IsExist(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDropDownLstStyleEN.DropDownLstStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DropDownLstStyleDA.AddNewRecordBySQL2WithReturnKey(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
try
{
bool bolResult = DropDownLstStyleDA.Update(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DropDownLstStyleDA.UpdateBySql2(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleBL.ReFreshCache();

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
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
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDropDownLstStyleId)
{
try
{
 clsDropDownLstStyleEN objDropDownLstStyleEN = clsDropDownLstStyleBL.GetObjByDropDownLstStyleId(strDropDownLstStyleId);

if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(objDropDownLstStyleEN.DropDownLstStyleId, "SetUpdDate");
}
if (objDropDownLstStyleEN != null)
{
int intRecNum = DropDownLstStyleDA.DelRecord(strDropDownLstStyleId);
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
/// <param name="strDropDownLstStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDropDownLstStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
//删除与表:[DropDownLstStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDropDownLstStyle.DropDownLstStyleId,
//strDropDownLstStyleId);
//        clsDropDownLstStyleBL.DelDropDownLstStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDropDownLstStyleBL.DelRecord(strDropDownLstStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDropDownLstStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDropDownLstStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDropDownLstStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDropDownLstStyleBL.relatedActions != null)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(strDropDownLstStyleId, "UpdRelaTabDate");
}
bool bolResult = DropDownLstStyleDA.DelRecord(strDropDownLstStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDropDownLstStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDropDownLstStyles(List<string> arrDropDownLstStyleIdLst)
{
if (arrDropDownLstStyleIdLst.Count == 0) return 0;
try
{
if (clsDropDownLstStyleBL.relatedActions != null)
{
foreach (var strDropDownLstStyleId in arrDropDownLstStyleIdLst)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(strDropDownLstStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = DropDownLstStyleDA.DelDropDownLstStyle(arrDropDownLstStyleIdLst);
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
public static int DelDropDownLstStylesByCond(string strWhereCond)
{
try
{
if (clsDropDownLstStyleBL.relatedActions != null)
{
List<string> arrDropDownLstStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDropDownLstStyleId in arrDropDownLstStyleId)
{
clsDropDownLstStyleBL.relatedActions.UpdRelaTabDate(strDropDownLstStyleId, "UpdRelaTabDate");
}
}
int intRecNum = DropDownLstStyleDA.DelDropDownLstStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DropDownLstStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDropDownLstStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDropDownLstStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
//删除与表:[DropDownLstStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDropDownLstStyleBL.DelRecord(strDropDownLstStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDropDownLstStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDropDownLstStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDropDownLstStyleENS">源对象</param>
 /// <param name = "objDropDownLstStyleENT">目标对象</param>
 public static void CopyTo(clsDropDownLstStyleEN objDropDownLstStyleENS, clsDropDownLstStyleEN objDropDownLstStyleENT)
{
try
{
objDropDownLstStyleENT.DropDownLstStyleId = objDropDownLstStyleENS.DropDownLstStyleId; //DropDownLstStyleId
objDropDownLstStyleENT.DropDownLstStyleName = objDropDownLstStyleENS.DropDownLstStyleName; //DropDownLstStyleName
objDropDownLstStyleENT.Style = objDropDownLstStyleENS.Style; //类型
objDropDownLstStyleENT.Runat = objDropDownLstStyleENS.Runat; //运行在
objDropDownLstStyleENT.FontSize = objDropDownLstStyleENS.FontSize; //字号
objDropDownLstStyleENT.FontName = objDropDownLstStyleENS.FontName; //字体
objDropDownLstStyleENT.Width = objDropDownLstStyleENS.Width; //宽
objDropDownLstStyleENT.Height = objDropDownLstStyleENS.Height; //高度
objDropDownLstStyleENT.TextMode = objDropDownLstStyleENS.TextMode; //TextMode
objDropDownLstStyleENT.ReadOnly = objDropDownLstStyleENS.ReadOnly; //ReadOnly
objDropDownLstStyleENT.BackColor = objDropDownLstStyleENS.BackColor; //背景颜色
objDropDownLstStyleENT.ForeColor = objDropDownLstStyleENS.ForeColor; //前景颜色
objDropDownLstStyleENT.DataTextField = objDropDownLstStyleENS.DataTextField; //DataTextField
objDropDownLstStyleENT.DataValueField = objDropDownLstStyleENS.DataValueField; //DataValueField
objDropDownLstStyleENT.DataTextFormatString = objDropDownLstStyleENS.DataTextFormatString; //DataTextFormatString
objDropDownLstStyleENT.AccessKey = objDropDownLstStyleENS.AccessKey; //AccessKey
objDropDownLstStyleENT.AutoPostBack = objDropDownLstStyleENS.AutoPostBack; //AutoPostBack
objDropDownLstStyleENT.Visible = objDropDownLstStyleENS.Visible; //Visible
objDropDownLstStyleENT.StyleZindex = objDropDownLstStyleENS.StyleZindex; //Style_Zindex
objDropDownLstStyleENT.StyleLeft = objDropDownLstStyleENS.StyleLeft; //Style_Left
objDropDownLstStyleENT.StylePosition = objDropDownLstStyleENS.StylePosition; //Style_Position
objDropDownLstStyleENT.StyleTop = objDropDownLstStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objDropDownLstStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
try
{
objDropDownLstStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDropDownLstStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDropDownLstStyle.DropDownLstStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.DropDownLstStyleId = objDropDownLstStyleEN.DropDownLstStyleId; //DropDownLstStyleId
}
if (arrFldSet.Contains(conDropDownLstStyle.DropDownLstStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.DropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName; //DropDownLstStyleName
}
if (arrFldSet.Contains(conDropDownLstStyle.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.Style = objDropDownLstStyleEN.Style == "[null]" ? null :  objDropDownLstStyleEN.Style; //类型
}
if (arrFldSet.Contains(conDropDownLstStyle.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.Runat = objDropDownLstStyleEN.Runat; //运行在
}
if (arrFldSet.Contains(conDropDownLstStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.FontSize = objDropDownLstStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conDropDownLstStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.FontName = objDropDownLstStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conDropDownLstStyle.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.Width = objDropDownLstStyleEN.Width; //宽
}
if (arrFldSet.Contains(conDropDownLstStyle.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.Height = objDropDownLstStyleEN.Height; //高度
}
if (arrFldSet.Contains(conDropDownLstStyle.TextMode, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.TextMode = objDropDownLstStyleEN.TextMode; //TextMode
}
if (arrFldSet.Contains(conDropDownLstStyle.ReadOnly, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.ReadOnly = objDropDownLstStyleEN.ReadOnly; //ReadOnly
}
if (arrFldSet.Contains(conDropDownLstStyle.BackColor, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.BackColor = objDropDownLstStyleEN.BackColor == "[null]" ? null :  objDropDownLstStyleEN.BackColor; //背景颜色
}
if (arrFldSet.Contains(conDropDownLstStyle.ForeColor, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.ForeColor = objDropDownLstStyleEN.ForeColor == "[null]" ? null :  objDropDownLstStyleEN.ForeColor; //前景颜色
}
if (arrFldSet.Contains(conDropDownLstStyle.DataTextField, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.DataTextField = objDropDownLstStyleEN.DataTextField == "[null]" ? null :  objDropDownLstStyleEN.DataTextField; //DataTextField
}
if (arrFldSet.Contains(conDropDownLstStyle.DataValueField, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.DataValueField = objDropDownLstStyleEN.DataValueField == "[null]" ? null :  objDropDownLstStyleEN.DataValueField; //DataValueField
}
if (arrFldSet.Contains(conDropDownLstStyle.DataTextFormatString, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.DataTextFormatString = objDropDownLstStyleEN.DataTextFormatString == "[null]" ? null :  objDropDownLstStyleEN.DataTextFormatString; //DataTextFormatString
}
if (arrFldSet.Contains(conDropDownLstStyle.AccessKey, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.AccessKey = objDropDownLstStyleEN.AccessKey == "[null]" ? null :  objDropDownLstStyleEN.AccessKey; //AccessKey
}
if (arrFldSet.Contains(conDropDownLstStyle.AutoPostBack, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.AutoPostBack = objDropDownLstStyleEN.AutoPostBack; //AutoPostBack
}
if (arrFldSet.Contains(conDropDownLstStyle.Visible, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.Visible = objDropDownLstStyleEN.Visible; //Visible
}
if (arrFldSet.Contains(conDropDownLstStyle.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.StyleZindex = objDropDownLstStyleEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conDropDownLstStyle.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.StyleLeft = objDropDownLstStyleEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conDropDownLstStyle.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.StylePosition = objDropDownLstStyleEN.StylePosition == "[null]" ? null :  objDropDownLstStyleEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conDropDownLstStyle.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objDropDownLstStyleEN.StyleTop = objDropDownLstStyleEN.StyleTop; //Style_Top
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
 /// <param name = "objDropDownLstStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
try
{
if (objDropDownLstStyleEN.Style == "[null]") objDropDownLstStyleEN.Style = null; //类型
if (objDropDownLstStyleEN.BackColor == "[null]") objDropDownLstStyleEN.BackColor = null; //背景颜色
if (objDropDownLstStyleEN.ForeColor == "[null]") objDropDownLstStyleEN.ForeColor = null; //前景颜色
if (objDropDownLstStyleEN.DataTextField == "[null]") objDropDownLstStyleEN.DataTextField = null; //DataTextField
if (objDropDownLstStyleEN.DataValueField == "[null]") objDropDownLstStyleEN.DataValueField = null; //DataValueField
if (objDropDownLstStyleEN.DataTextFormatString == "[null]") objDropDownLstStyleEN.DataTextFormatString = null; //DataTextFormatString
if (objDropDownLstStyleEN.AccessKey == "[null]") objDropDownLstStyleEN.AccessKey = null; //AccessKey
if (objDropDownLstStyleEN.StylePosition == "[null]") objDropDownLstStyleEN.StylePosition = null; //Style_Position
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
public static void CheckPropertyNew(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 DropDownLstStyleDA.CheckPropertyNew(objDropDownLstStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 DropDownLstStyleDA.CheckProperty4Condition(objDropDownLstStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DropDownLstStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDropDownLstStyle.DropDownLstStyleId); 
List<clsDropDownLstStyleEN> arrObjLst = clsDropDownLstStyleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN()
{
DropDownLstStyleId = "0",
DropDownLstStyleName = "选[下拉框样式]..."
};
arrObjLst.Insert(0, objDropDownLstStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDropDownLstStyle.DropDownLstStyleId;
objComboBox.DisplayMember = conDropDownLstStyle.DropDownLstStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DropDownLstStyleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[下拉框样式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDropDownLstStyle.DropDownLstStyleId); 
IEnumerable<clsDropDownLstStyleEN> arrObjLst = clsDropDownLstStyleBL.GetObjLst(strCondition);
objDDL.DataValueField = conDropDownLstStyle.DropDownLstStyleId;
objDDL.DataTextField = conDropDownLstStyle.DropDownLstStyleName;
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
public static void BindDdl_DropDownLstStyleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[下拉框样式]...","0");
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLst = GetAllDropDownLstStyleObjLstCache(); 
objDDL.DataValueField = conDropDownLstStyle.DropDownLstStyleId;
objDDL.DataTextField = conDropDownLstStyle.DropDownLstStyleName;
objDDL.DataSource = arrDropDownLstStyleObjLst;
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
if (clsDropDownLstStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDropDownLstStyleBL没有刷新缓存机制(clsDropDownLstStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DropDownLstStyleId");
//if (arrDropDownLstStyleObjLstCache == null)
//{
//arrDropDownLstStyleObjLstCache = DropDownLstStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDropDownLstStyleEN GetObjByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel =
arrDropDownLstStyleObjLstCache
.Where(x=> x.DropDownLstStyleId == strDropDownLstStyleId 
);
if (arrDropDownLstStyleObjLst_Sel.Count() == 0)
{
   clsDropDownLstStyleEN obj = clsDropDownLstStyleBL.GetObjByDropDownLstStyleId(strDropDownLstStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDropDownLstStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDropDownLstStyleNameByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return "";
//获取缓存中的对象列表
clsDropDownLstStyleEN objDropDownLstStyle = GetObjByDropDownLstStyleIdCache(strDropDownLstStyleId);
if (objDropDownLstStyle == null) return "";
return objDropDownLstStyle.DropDownLstStyleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return "";
//获取缓存中的对象列表
clsDropDownLstStyleEN objDropDownLstStyle = GetObjByDropDownLstStyleIdCache(strDropDownLstStyleId);
if (objDropDownLstStyle == null) return "";
return objDropDownLstStyle.DropDownLstStyleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDropDownLstStyleEN> GetAllDropDownLstStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache(); 
return arrDropDownLstStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDropDownLstStyleObjLstCache;
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
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDropDownLstStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDropDownLstStyleEN._RefreshTimeLst.Count == 0) return "";
return clsDropDownLstStyleEN._RefreshTimeLst[clsDropDownLstStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDropDownLstStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDropDownLstStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDropDownLstStyleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strDropDownLstStyleId)
{
if (strInFldName != conDropDownLstStyle.DropDownLstStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDropDownLstStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDropDownLstStyle._AttributeName));
throw new Exception(strMsg);
}
var objDropDownLstStyle = clsDropDownLstStyleBL.GetObjByDropDownLstStyleIdCache(strDropDownLstStyleId);
if (objDropDownLstStyle == null) return "";
return objDropDownLstStyle[strOutFldName].ToString();
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
int intRecCount = clsDropDownLstStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsDropDownLstStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDropDownLstStyleDA.GetRecCount();
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
int intRecCount = clsDropDownLstStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDropDownLstStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDropDownLstStyleEN objDropDownLstStyleCond)
{
List<clsDropDownLstStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDropDownLstStyle._AttributeName)
{
if (objDropDownLstStyleCond.IsUpdated(strFldName) == false) continue;
if (objDropDownLstStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDropDownLstStyleCond[strFldName].ToString());
}
else
{
if (objDropDownLstStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDropDownLstStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDropDownLstStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDropDownLstStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDropDownLstStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDropDownLstStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDropDownLstStyleCond[strFldName]));
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
 List<string> arrList = clsDropDownLstStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DropDownLstStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DropDownLstStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DropDownLstStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDropDownLstStyleDA.SetFldValue(clsDropDownLstStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DropDownLstStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDropDownLstStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDropDownLstStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDropDownLstStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DropDownLstStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**DropDownLstStyleId*/ 
 strCreateTabCode.Append(" DropDownLstStyleId varchar(4) primary key, "); 
 // /**DropDownLstStyleName*/ 
 strCreateTabCode.Append(" DropDownLstStyleName varchar(30) not Null, "); 
 // /**类型*/ 
 strCreateTabCode.Append(" Style varchar(800) Null, "); 
 // /**运行在*/ 
 strCreateTabCode.Append(" Runat varchar(30) not Null, "); 
 // /**字号*/ 
 strCreateTabCode.Append(" FontSize varchar(20) not Null, "); 
 // /**字体*/ 
 strCreateTabCode.Append(" FontName varchar(20) not Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**TextMode*/ 
 strCreateTabCode.Append(" TextMode varchar(20) not Null, "); 
 // /**ReadOnly*/ 
 strCreateTabCode.Append(" ReadOnly bit not Null, "); 
 // /**背景颜色*/ 
 strCreateTabCode.Append(" BackColor varchar(30) Null, "); 
 // /**前景颜色*/ 
 strCreateTabCode.Append(" ForeColor varchar(30) Null, "); 
 // /**DataTextField*/ 
 strCreateTabCode.Append(" DataTextField varchar(30) Null, "); 
 // /**DataValueField*/ 
 strCreateTabCode.Append(" DataValueField varchar(30) Null, "); 
 // /**DataTextFormatString*/ 
 strCreateTabCode.Append(" DataTextFormatString varchar(30) Null, "); 
 // /**AccessKey*/ 
 strCreateTabCode.Append(" AccessKey varchar(30) Null, "); 
 // /**AutoPostBack*/ 
 strCreateTabCode.Append(" AutoPostBack bit Null, "); 
 // /**Visible*/ 
 strCreateTabCode.Append(" Visible bit Null, "); 
 // /**Style_Zindex*/ 
 strCreateTabCode.Append(" StyleZindex int Null, "); 
 // /**Style_Left*/ 
 strCreateTabCode.Append(" StyleLeft int Null, "); 
 // /**Style_Position*/ 
 strCreateTabCode.Append(" StylePosition varchar(20) Null, "); 
 // /**Style_Top*/ 
 strCreateTabCode.Append(" StyleTop int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 下拉框样式(DropDownLstStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DropDownLstStyle : clsCommFun4BL
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
clsDropDownLstStyleBL.ReFreshThisCache();
}
}

}