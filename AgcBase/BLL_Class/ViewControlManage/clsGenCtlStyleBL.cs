
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGenCtlStyleBL
 表名:GenCtlStyle(00050064)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
public static class  clsGenCtlStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strGenCtlStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGenCtlStyleEN GetObj(this K_GenCtlStyleId_GenCtlStyle myKey)
{
clsGenCtlStyleEN objGenCtlStyleEN = clsGenCtlStyleBL.GenCtlStyleDA.GetObjByGenCtlStyleId(myKey.Value);
return objGenCtlStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGenCtlStyleEN objGenCtlStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGenCtlStyleBL.IsExist(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGenCtlStyleEN.GenCtlStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsGenCtlStyleBL.GenCtlStyleDA.AddNewRecordBySQL2(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsGenCtlStyleEN objGenCtlStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsGenCtlStyleBL.IsExist(objGenCtlStyleEN.GenCtlStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objGenCtlStyleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objGenCtlStyleEN.AddNewRecord();
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGenCtlStyleEN objGenCtlStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGenCtlStyleBL.IsExist(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGenCtlStyleEN.GenCtlStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsGenCtlStyleBL.GenCtlStyleDA.AddNewRecordBySQL2WithReturnKey(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetGenCtlStyleId(this clsGenCtlStyleEN objGenCtlStyleEN, string strGenCtlStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGenCtlStyleId, 4, conGenCtlStyle.GenCtlStyleId);
}
objGenCtlStyleEN.GenCtlStyleId = strGenCtlStyleId; //GenCtlStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.GenCtlStyleId) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.GenCtlStyleId, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleId] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetGenCtlStyleName(this clsGenCtlStyleEN objGenCtlStyleEN, string strGenCtlStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGenCtlStyleName, conGenCtlStyle.GenCtlStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGenCtlStyleName, 30, conGenCtlStyle.GenCtlStyleName);
}
objGenCtlStyleEN.GenCtlStyleName = strGenCtlStyleName; //GenCtlStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.GenCtlStyleName) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.GenCtlStyleName, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleName] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyle(this clsGenCtlStyleEN objGenCtlStyleEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conGenCtlStyle.Style);
}
objGenCtlStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Style) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Style, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Style] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetRunat(this clsGenCtlStyleEN objGenCtlStyleEN, string strRunat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conGenCtlStyle.Runat);
}
objGenCtlStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Runat) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Runat, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Runat] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetFontSize(this clsGenCtlStyleEN objGenCtlStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conGenCtlStyle.FontSize);
}
objGenCtlStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.FontSize) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.FontSize, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.FontSize] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetFontName(this clsGenCtlStyleEN objGenCtlStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conGenCtlStyle.FontName);
}
objGenCtlStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.FontName) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.FontName, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.FontName] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetWidth(this clsGenCtlStyleEN objGenCtlStyleEN, int? intWidth, string strComparisonOp="")
	{
objGenCtlStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Width) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Width, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Width] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetHeight(this clsGenCtlStyleEN objGenCtlStyleEN, int? intHeight, string strComparisonOp="")
	{
objGenCtlStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Height) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Height, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Height] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetTextMode(this clsGenCtlStyleEN objGenCtlStyleEN, string strTextMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextMode, conGenCtlStyle.TextMode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextMode, 20, conGenCtlStyle.TextMode);
}
objGenCtlStyleEN.TextMode = strTextMode; //TextMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.TextMode) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.TextMode, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.TextMode] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleZindex(this clsGenCtlStyleEN objGenCtlStyleEN, int? intStyleZindex, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleZindex) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleZindex, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleZindex] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleLeft(this clsGenCtlStyleEN objGenCtlStyleEN, int? intStyleLeft, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleLeft) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleLeft, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleLeft] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStylePosition(this clsGenCtlStyleEN objGenCtlStyleEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conGenCtlStyle.StylePosition);
}
objGenCtlStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StylePosition) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StylePosition, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StylePosition] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleTop(this clsGenCtlStyleEN objGenCtlStyleEN, int? intStyleTop, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleTop) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleTop, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleTop] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGenCtlStyleEN objGenCtlStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGenCtlStyleEN.CheckPropertyNew();
clsGenCtlStyleEN objGenCtlStyleCond = new clsGenCtlStyleEN();
string strCondition = objGenCtlStyleCond
.SetGenCtlStyleId(objGenCtlStyleEN.GenCtlStyleId, "=")
.GetCombineCondition();
objGenCtlStyleEN._IsCheckProperty = true;
bool bolIsExist = clsGenCtlStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGenCtlStyleEN.Update();
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGenCtlStyleBL.GenCtlStyleDA.UpdateBySql2(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGenCtlStyleEN objGenCtlStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGenCtlStyleBL.GenCtlStyleDA.UpdateBySql2(objGenCtlStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGenCtlStyleEN objGenCtlStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsGenCtlStyleBL.GenCtlStyleDA.UpdateBySqlWithCondition(objGenCtlStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGenCtlStyleEN objGenCtlStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGenCtlStyleBL.GenCtlStyleDA.UpdateBySqlWithConditionTransaction(objGenCtlStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGenCtlStyleEN objGenCtlStyleEN)
{
try
{
int intRecNum = clsGenCtlStyleBL.GenCtlStyleDA.DelRecord(objGenCtlStyleEN.GenCtlStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleENS">源对象</param>
 /// <param name = "objGenCtlStyleENT">目标对象</param>
 public static void CopyTo(this clsGenCtlStyleEN objGenCtlStyleENS, clsGenCtlStyleEN objGenCtlStyleENT)
{
try
{
objGenCtlStyleENT.GenCtlStyleId = objGenCtlStyleENS.GenCtlStyleId; //GenCtlStyleId
objGenCtlStyleENT.GenCtlStyleName = objGenCtlStyleENS.GenCtlStyleName; //GenCtlStyleName
objGenCtlStyleENT.Style = objGenCtlStyleENS.Style; //类型
objGenCtlStyleENT.Runat = objGenCtlStyleENS.Runat; //运行在
objGenCtlStyleENT.FontSize = objGenCtlStyleENS.FontSize; //字号
objGenCtlStyleENT.FontName = objGenCtlStyleENS.FontName; //字体
objGenCtlStyleENT.Width = objGenCtlStyleENS.Width; //宽
objGenCtlStyleENT.Height = objGenCtlStyleENS.Height; //高度
objGenCtlStyleENT.TextMode = objGenCtlStyleENS.TextMode; //TextMode
objGenCtlStyleENT.StyleZindex = objGenCtlStyleENS.StyleZindex; //Style_Zindex
objGenCtlStyleENT.StyleLeft = objGenCtlStyleENS.StyleLeft; //Style_Left
objGenCtlStyleENT.StylePosition = objGenCtlStyleENS.StylePosition; //Style_Position
objGenCtlStyleENT.StyleTop = objGenCtlStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objGenCtlStyleENS">源对象</param>
 /// <returns>目标对象=>clsGenCtlStyleEN:objGenCtlStyleENT</returns>
 public static clsGenCtlStyleEN CopyTo(this clsGenCtlStyleEN objGenCtlStyleENS)
{
try
{
 clsGenCtlStyleEN objGenCtlStyleENT = new clsGenCtlStyleEN()
{
GenCtlStyleId = objGenCtlStyleENS.GenCtlStyleId, //GenCtlStyleId
GenCtlStyleName = objGenCtlStyleENS.GenCtlStyleName, //GenCtlStyleName
Style = objGenCtlStyleENS.Style, //类型
Runat = objGenCtlStyleENS.Runat, //运行在
FontSize = objGenCtlStyleENS.FontSize, //字号
FontName = objGenCtlStyleENS.FontName, //字体
Width = objGenCtlStyleENS.Width, //宽
Height = objGenCtlStyleENS.Height, //高度
TextMode = objGenCtlStyleENS.TextMode, //TextMode
StyleZindex = objGenCtlStyleENS.StyleZindex, //Style_Zindex
StyleLeft = objGenCtlStyleENS.StyleLeft, //Style_Left
StylePosition = objGenCtlStyleENS.StylePosition, //Style_Position
StyleTop = objGenCtlStyleENS.StyleTop, //Style_Top
};
 return objGenCtlStyleENT;
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
public static void CheckPropertyNew(this clsGenCtlStyleEN objGenCtlStyleEN)
{
 clsGenCtlStyleBL.GenCtlStyleDA.CheckPropertyNew(objGenCtlStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGenCtlStyleEN objGenCtlStyleEN)
{
 clsGenCtlStyleBL.GenCtlStyleDA.CheckProperty4Condition(objGenCtlStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGenCtlStyleEN objGenCtlStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.GenCtlStyleId) == true)
{
string strComparisonOpGenCtlStyleId = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.GenCtlStyleId, objGenCtlStyleCond.GenCtlStyleId, strComparisonOpGenCtlStyleId);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.GenCtlStyleName) == true)
{
string strComparisonOpGenCtlStyleName = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.GenCtlStyleName, objGenCtlStyleCond.GenCtlStyleName, strComparisonOpGenCtlStyleName);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Style) == true)
{
string strComparisonOpStyle = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.Style, objGenCtlStyleCond.Style, strComparisonOpStyle);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Runat) == true)
{
string strComparisonOpRunat = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.Runat, objGenCtlStyleCond.Runat, strComparisonOpRunat);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.FontSize) == true)
{
string strComparisonOpFontSize = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.FontSize, objGenCtlStyleCond.FontSize, strComparisonOpFontSize);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.FontName) == true)
{
string strComparisonOpFontName = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.FontName, objGenCtlStyleCond.FontName, strComparisonOpFontName);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Width) == true)
{
string strComparisonOpWidth = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.Width, objGenCtlStyleCond.Width, strComparisonOpWidth);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Height) == true)
{
string strComparisonOpHeight = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.Height, objGenCtlStyleCond.Height, strComparisonOpHeight);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.TextMode) == true)
{
string strComparisonOpTextMode = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.TextMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.TextMode, objGenCtlStyleCond.TextMode, strComparisonOpTextMode);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleZindex, objGenCtlStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleLeft, objGenCtlStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.StylePosition, objGenCtlStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleTop, objGenCtlStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GenCtlStyle
{
public virtual bool UpdRelaTabDate(string strGenCtlStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 一般控件样式(GenCtlStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGenCtlStyleBL
{
public static RelatedActions_GenCtlStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGenCtlStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGenCtlStyleDA GenCtlStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGenCtlStyleDA();
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
 public clsGenCtlStyleBL()
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
if (string.IsNullOrEmpty(clsGenCtlStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGenCtlStyleEN._ConnectString);
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
public static DataTable GetDataTable_GenCtlStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GenCtlStyleDA.GetDataTable_GenCtlStyle(strWhereCond);
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
objDT = GenCtlStyleDA.GetDataTable(strWhereCond);
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
objDT = GenCtlStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GenCtlStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GenCtlStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GenCtlStyleDA.GetDataTable_Top(objTopPara);
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
objDT = GenCtlStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GenCtlStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GenCtlStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGenCtlStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstByGenCtlStyleIdLst(List<string> arrGenCtlStyleIdLst)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGenCtlStyleIdLst, true);
 string strWhereCond = string.Format("GenCtlStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGenCtlStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGenCtlStyleEN> GetObjLstByGenCtlStyleIdLstCache(List<string> arrGenCtlStyleIdLst)
{
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel =
arrGenCtlStyleObjLstCache
.Where(x => arrGenCtlStyleIdLst.Contains(x.GenCtlStyleId));
return arrGenCtlStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLst(string strWhereCond)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
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
public static List<clsGenCtlStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGenCtlStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGenCtlStyleEN> GetSubObjLstCache(clsGenCtlStyleEN objGenCtlStyleCond)
{
List<clsGenCtlStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGenCtlStyle._AttributeName)
{
if (objGenCtlStyleCond.IsUpdated(strFldName) == false) continue;
if (objGenCtlStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGenCtlStyleCond[strFldName].ToString());
}
else
{
if (objGenCtlStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGenCtlStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGenCtlStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGenCtlStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGenCtlStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGenCtlStyleCond[strFldName]));
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
public static List<clsGenCtlStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
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
public static List<clsGenCtlStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
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
List<clsGenCtlStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGenCtlStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGenCtlStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
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
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
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
public static List<clsGenCtlStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGenCtlStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
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
public static List<clsGenCtlStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGenCtlStyleEN.GenCtlStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGenCtlStyle(ref clsGenCtlStyleEN objGenCtlStyleEN)
{
bool bolResult = GenCtlStyleDA.GetGenCtlStyle(ref objGenCtlStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strGenCtlStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGenCtlStyleEN GetObjByGenCtlStyleId(string strGenCtlStyleId)
{
if (strGenCtlStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strGenCtlStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strGenCtlStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strGenCtlStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGenCtlStyleEN objGenCtlStyleEN = GenCtlStyleDA.GetObjByGenCtlStyleId(strGenCtlStyleId);
return objGenCtlStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGenCtlStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGenCtlStyleEN objGenCtlStyleEN = GenCtlStyleDA.GetFirstObj(strWhereCond);
 return objGenCtlStyleEN;
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
public static clsGenCtlStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGenCtlStyleEN objGenCtlStyleEN = GenCtlStyleDA.GetObjByDataRow(objRow);
 return objGenCtlStyleEN;
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
public static clsGenCtlStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGenCtlStyleEN objGenCtlStyleEN = GenCtlStyleDA.GetObjByDataRow(objRow);
 return objGenCtlStyleEN;
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
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <param name = "lstGenCtlStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGenCtlStyleEN GetObjByGenCtlStyleIdFromList(string strGenCtlStyleId, List<clsGenCtlStyleEN> lstGenCtlStyleObjLst)
{
foreach (clsGenCtlStyleEN objGenCtlStyleEN in lstGenCtlStyleObjLst)
{
if (objGenCtlStyleEN.GenCtlStyleId == strGenCtlStyleId)
{
return objGenCtlStyleEN;
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
 string strGenCtlStyleId;
 try
 {
 strGenCtlStyleId = new clsGenCtlStyleDA().GetFirstID(strWhereCond);
 return strGenCtlStyleId;
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
 arrList = GenCtlStyleDA.GetID(strWhereCond);
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
bool bolIsExist = GenCtlStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strGenCtlStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GenCtlStyleDA.IsExist(strGenCtlStyleId);
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
 bolIsExist = clsGenCtlStyleDA.IsExistTable();
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
 bolIsExist = GenCtlStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGenCtlStyleEN objGenCtlStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGenCtlStyleBL.IsExist(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGenCtlStyleEN.GenCtlStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = GenCtlStyleDA.AddNewRecordBySQL2(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGenCtlStyleEN objGenCtlStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGenCtlStyleBL.IsExist(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGenCtlStyleEN.GenCtlStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = GenCtlStyleDA.AddNewRecordBySQL2WithReturnKey(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGenCtlStyleEN objGenCtlStyleEN)
{
try
{
bool bolResult = GenCtlStyleDA.Update(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GenCtlStyleDA.UpdateBySql2(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleBL.ReFreshCache();

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
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
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strGenCtlStyleId)
{
try
{
 clsGenCtlStyleEN objGenCtlStyleEN = clsGenCtlStyleBL.GetObjByGenCtlStyleId(strGenCtlStyleId);

if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(objGenCtlStyleEN.GenCtlStyleId, "SetUpdDate");
}
if (objGenCtlStyleEN != null)
{
int intRecNum = GenCtlStyleDA.DelRecord(strGenCtlStyleId);
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
/// <param name="strGenCtlStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strGenCtlStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
//删除与表:[GenCtlStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGenCtlStyle.GenCtlStyleId,
//strGenCtlStyleId);
//        clsGenCtlStyleBL.DelGenCtlStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGenCtlStyleBL.DelRecord(strGenCtlStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGenCtlStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGenCtlStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strGenCtlStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGenCtlStyleBL.relatedActions != null)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(strGenCtlStyleId, "UpdRelaTabDate");
}
bool bolResult = GenCtlStyleDA.DelRecord(strGenCtlStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrGenCtlStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGenCtlStyles(List<string> arrGenCtlStyleIdLst)
{
if (arrGenCtlStyleIdLst.Count == 0) return 0;
try
{
if (clsGenCtlStyleBL.relatedActions != null)
{
foreach (var strGenCtlStyleId in arrGenCtlStyleIdLst)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(strGenCtlStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = GenCtlStyleDA.DelGenCtlStyle(arrGenCtlStyleIdLst);
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
public static int DelGenCtlStylesByCond(string strWhereCond)
{
try
{
if (clsGenCtlStyleBL.relatedActions != null)
{
List<string> arrGenCtlStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strGenCtlStyleId in arrGenCtlStyleId)
{
clsGenCtlStyleBL.relatedActions.UpdRelaTabDate(strGenCtlStyleId, "UpdRelaTabDate");
}
}
int intRecNum = GenCtlStyleDA.DelGenCtlStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GenCtlStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strGenCtlStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strGenCtlStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
//删除与表:[GenCtlStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGenCtlStyleBL.DelRecord(strGenCtlStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGenCtlStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strGenCtlStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGenCtlStyleENS">源对象</param>
 /// <param name = "objGenCtlStyleENT">目标对象</param>
 public static void CopyTo(clsGenCtlStyleEN objGenCtlStyleENS, clsGenCtlStyleEN objGenCtlStyleENT)
{
try
{
objGenCtlStyleENT.GenCtlStyleId = objGenCtlStyleENS.GenCtlStyleId; //GenCtlStyleId
objGenCtlStyleENT.GenCtlStyleName = objGenCtlStyleENS.GenCtlStyleName; //GenCtlStyleName
objGenCtlStyleENT.Style = objGenCtlStyleENS.Style; //类型
objGenCtlStyleENT.Runat = objGenCtlStyleENS.Runat; //运行在
objGenCtlStyleENT.FontSize = objGenCtlStyleENS.FontSize; //字号
objGenCtlStyleENT.FontName = objGenCtlStyleENS.FontName; //字体
objGenCtlStyleENT.Width = objGenCtlStyleENS.Width; //宽
objGenCtlStyleENT.Height = objGenCtlStyleENS.Height; //高度
objGenCtlStyleENT.TextMode = objGenCtlStyleENS.TextMode; //TextMode
objGenCtlStyleENT.StyleZindex = objGenCtlStyleENS.StyleZindex; //Style_Zindex
objGenCtlStyleENT.StyleLeft = objGenCtlStyleENS.StyleLeft; //Style_Left
objGenCtlStyleENT.StylePosition = objGenCtlStyleENS.StylePosition; //Style_Position
objGenCtlStyleENT.StyleTop = objGenCtlStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objGenCtlStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsGenCtlStyleEN objGenCtlStyleEN)
{
try
{
objGenCtlStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGenCtlStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGenCtlStyle.GenCtlStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.GenCtlStyleId = objGenCtlStyleEN.GenCtlStyleId; //GenCtlStyleId
}
if (arrFldSet.Contains(conGenCtlStyle.GenCtlStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.GenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName; //GenCtlStyleName
}
if (arrFldSet.Contains(conGenCtlStyle.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.Style = objGenCtlStyleEN.Style == "[null]" ? null :  objGenCtlStyleEN.Style; //类型
}
if (arrFldSet.Contains(conGenCtlStyle.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.Runat = objGenCtlStyleEN.Runat == "[null]" ? null :  objGenCtlStyleEN.Runat; //运行在
}
if (arrFldSet.Contains(conGenCtlStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.FontSize = objGenCtlStyleEN.FontSize == "[null]" ? null :  objGenCtlStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conGenCtlStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.FontName = objGenCtlStyleEN.FontName == "[null]" ? null :  objGenCtlStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conGenCtlStyle.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.Width = objGenCtlStyleEN.Width; //宽
}
if (arrFldSet.Contains(conGenCtlStyle.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.Height = objGenCtlStyleEN.Height; //高度
}
if (arrFldSet.Contains(conGenCtlStyle.TextMode, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.TextMode = objGenCtlStyleEN.TextMode; //TextMode
}
if (arrFldSet.Contains(conGenCtlStyle.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.StyleZindex = objGenCtlStyleEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conGenCtlStyle.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.StyleLeft = objGenCtlStyleEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conGenCtlStyle.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.StylePosition = objGenCtlStyleEN.StylePosition == "[null]" ? null :  objGenCtlStyleEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conGenCtlStyle.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objGenCtlStyleEN.StyleTop = objGenCtlStyleEN.StyleTop; //Style_Top
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
 /// <param name = "objGenCtlStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsGenCtlStyleEN objGenCtlStyleEN)
{
try
{
if (objGenCtlStyleEN.Style == "[null]") objGenCtlStyleEN.Style = null; //类型
if (objGenCtlStyleEN.Runat == "[null]") objGenCtlStyleEN.Runat = null; //运行在
if (objGenCtlStyleEN.FontSize == "[null]") objGenCtlStyleEN.FontSize = null; //字号
if (objGenCtlStyleEN.FontName == "[null]") objGenCtlStyleEN.FontName = null; //字体
if (objGenCtlStyleEN.StylePosition == "[null]") objGenCtlStyleEN.StylePosition = null; //Style_Position
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
public static void CheckPropertyNew(clsGenCtlStyleEN objGenCtlStyleEN)
{
 GenCtlStyleDA.CheckPropertyNew(objGenCtlStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGenCtlStyleEN objGenCtlStyleEN)
{
 GenCtlStyleDA.CheckProperty4Condition(objGenCtlStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_GenCtlStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGenCtlStyle.GenCtlStyleId); 
List<clsGenCtlStyleEN> arrObjLst = clsGenCtlStyleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN()
{
GenCtlStyleId = "0",
GenCtlStyleName = "选[一般控件样式]..."
};
arrObjLst.Insert(0, objGenCtlStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGenCtlStyle.GenCtlStyleId;
objComboBox.DisplayMember = conGenCtlStyle.GenCtlStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_GenCtlStyleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[一般控件样式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conGenCtlStyle.GenCtlStyleId); 
IEnumerable<clsGenCtlStyleEN> arrObjLst = clsGenCtlStyleBL.GetObjLst(strCondition);
objDDL.DataValueField = conGenCtlStyle.GenCtlStyleId;
objDDL.DataTextField = conGenCtlStyle.GenCtlStyleName;
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
public static void BindDdl_GenCtlStyleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[一般控件样式]...","0");
List<clsGenCtlStyleEN> arrGenCtlStyleObjLst = GetAllGenCtlStyleObjLstCache(); 
objDDL.DataValueField = conGenCtlStyle.GenCtlStyleId;
objDDL.DataTextField = conGenCtlStyle.GenCtlStyleName;
objDDL.DataSource = arrGenCtlStyleObjLst;
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
if (clsGenCtlStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGenCtlStyleBL没有刷新缓存机制(clsGenCtlStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by GenCtlStyleId");
//if (arrGenCtlStyleObjLstCache == null)
//{
//arrGenCtlStyleObjLstCache = GenCtlStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGenCtlStyleEN GetObjByGenCtlStyleIdCache(string strGenCtlStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel =
arrGenCtlStyleObjLstCache
.Where(x=> x.GenCtlStyleId == strGenCtlStyleId 
);
if (arrGenCtlStyleObjLst_Sel.Count() == 0)
{
   clsGenCtlStyleEN obj = clsGenCtlStyleBL.GetObjByGenCtlStyleId(strGenCtlStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGenCtlStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGenCtlStyleNameByGenCtlStyleIdCache(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return "";
//获取缓存中的对象列表
clsGenCtlStyleEN objGenCtlStyle = GetObjByGenCtlStyleIdCache(strGenCtlStyleId);
if (objGenCtlStyle == null) return "";
return objGenCtlStyle.GenCtlStyleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByGenCtlStyleIdCache(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return "";
//获取缓存中的对象列表
clsGenCtlStyleEN objGenCtlStyle = GetObjByGenCtlStyleIdCache(strGenCtlStyleId);
if (objGenCtlStyle == null) return "";
return objGenCtlStyle.GenCtlStyleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGenCtlStyleEN> GetAllGenCtlStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache(); 
return arrGenCtlStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGenCtlStyleObjLstCache;
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
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGenCtlStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGenCtlStyleEN._RefreshTimeLst.Count == 0) return "";
return clsGenCtlStyleEN._RefreshTimeLst[clsGenCtlStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsGenCtlStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGenCtlStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGenCtlStyleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strGenCtlStyleId)
{
if (strInFldName != conGenCtlStyle.GenCtlStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGenCtlStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGenCtlStyle._AttributeName));
throw new Exception(strMsg);
}
var objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache(strGenCtlStyleId);
if (objGenCtlStyle == null) return "";
return objGenCtlStyle[strOutFldName].ToString();
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
int intRecCount = clsGenCtlStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsGenCtlStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGenCtlStyleDA.GetRecCount();
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
int intRecCount = clsGenCtlStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGenCtlStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGenCtlStyleEN objGenCtlStyleCond)
{
List<clsGenCtlStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGenCtlStyle._AttributeName)
{
if (objGenCtlStyleCond.IsUpdated(strFldName) == false) continue;
if (objGenCtlStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGenCtlStyleCond[strFldName].ToString());
}
else
{
if (objGenCtlStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGenCtlStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGenCtlStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGenCtlStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGenCtlStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGenCtlStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGenCtlStyleCond[strFldName]));
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
 List<string> arrList = clsGenCtlStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GenCtlStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GenCtlStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GenCtlStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGenCtlStyleDA.SetFldValue(clsGenCtlStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GenCtlStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGenCtlStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGenCtlStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGenCtlStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GenCtlStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**GenCtlStyleId*/ 
 strCreateTabCode.Append(" GenCtlStyleId varchar(4) primary key, "); 
 // /**GenCtlStyleName*/ 
 strCreateTabCode.Append(" GenCtlStyleName varchar(30) not Null, "); 
 // /**类型*/ 
 strCreateTabCode.Append(" Style varchar(800) Null, "); 
 // /**运行在*/ 
 strCreateTabCode.Append(" Runat varchar(30) Null, "); 
 // /**字号*/ 
 strCreateTabCode.Append(" FontSize varchar(20) Null, "); 
 // /**字体*/ 
 strCreateTabCode.Append(" FontName varchar(20) Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**TextMode*/ 
 strCreateTabCode.Append(" TextMode varchar(20) not Null, "); 
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
 /// 一般控件样式(GenCtlStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GenCtlStyle : clsCommFun4BL
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
clsGenCtlStyleBL.ReFreshThisCache();
}
}

}