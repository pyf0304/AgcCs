
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCheckStyleBL
 表名:CheckStyle(00050056)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:50
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
public static class  clsCheckStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCheckStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCheckStyleEN GetObj(this K_CheckStyleId_CheckStyle myKey)
{
clsCheckStyleEN objCheckStyleEN = clsCheckStyleBL.CheckStyleDA.GetObjByCheckStyleId(myKey.Value);
return objCheckStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCheckStyleEN objCheckStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCheckStyleBL.IsExist(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCheckStyleEN.CheckStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCheckStyleBL.CheckStyleDA.AddNewRecordBySQL2(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCheckStyleEN objCheckStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCheckStyleBL.IsExist(objCheckStyleEN.CheckStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCheckStyleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCheckStyleEN.AddNewRecord();
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCheckStyleEN objCheckStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCheckStyleBL.IsExist(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCheckStyleEN.CheckStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCheckStyleBL.CheckStyleDA.AddNewRecordBySQL2WithReturnKey(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetCheckStyleId(this clsCheckStyleEN objCheckStyleEN, string strCheckStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckStyleId, 4, conCheckStyle.CheckStyleId);
}
objCheckStyleEN.CheckStyleId = strCheckStyleId; //CheckStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.CheckStyleId) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.CheckStyleId, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.CheckStyleId] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetCheckStyleName(this clsCheckStyleEN objCheckStyleEN, string strCheckStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckStyleName, conCheckStyle.CheckStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckStyleName, 30, conCheckStyle.CheckStyleName);
}
objCheckStyleEN.CheckStyleName = strCheckStyleName; //CheckStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.CheckStyleName) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.CheckStyleName, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.CheckStyleName] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetStyle(this clsCheckStyleEN objCheckStyleEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conCheckStyle.Style);
}
objCheckStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.Style) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.Style, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.Style] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetRunat(this clsCheckStyleEN objCheckStyleEN, string strRunat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conCheckStyle.Runat);
}
objCheckStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.Runat) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.Runat, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.Runat] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetFontSize(this clsCheckStyleEN objCheckStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conCheckStyle.FontSize);
}
objCheckStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.FontSize) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.FontSize, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.FontSize] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetFontName(this clsCheckStyleEN objCheckStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conCheckStyle.FontName);
}
objCheckStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.FontName) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.FontName, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.FontName] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetWidth(this clsCheckStyleEN objCheckStyleEN, int? intWidth, string strComparisonOp="")
	{
objCheckStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.Width) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.Width, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.Width] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetHeight(this clsCheckStyleEN objCheckStyleEN, int? intHeight, string strComparisonOp="")
	{
objCheckStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.Height) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.Height, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.Height] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetStyleZindex(this clsCheckStyleEN objCheckStyleEN, int? intStyleZindex, string strComparisonOp="")
	{
objCheckStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.StyleZindex) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.StyleZindex, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.StyleZindex] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetStyleLeft(this clsCheckStyleEN objCheckStyleEN, int? intStyleLeft, string strComparisonOp="")
	{
objCheckStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.StyleLeft) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.StyleLeft, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.StyleLeft] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetStylePosition(this clsCheckStyleEN objCheckStyleEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conCheckStyle.StylePosition);
}
objCheckStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.StylePosition) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.StylePosition, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.StylePosition] = strComparisonOp;
}
}
return objCheckStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCheckStyleEN SetStyleTop(this clsCheckStyleEN objCheckStyleEN, int? intStyleTop, string strComparisonOp="")
	{
objCheckStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckStyleEN.dicFldComparisonOp.ContainsKey(conCheckStyle.StyleTop) == false)
{
objCheckStyleEN.dicFldComparisonOp.Add(conCheckStyle.StyleTop, strComparisonOp);
}
else
{
objCheckStyleEN.dicFldComparisonOp[conCheckStyle.StyleTop] = strComparisonOp;
}
}
return objCheckStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCheckStyleEN objCheckStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCheckStyleEN.CheckPropertyNew();
clsCheckStyleEN objCheckStyleCond = new clsCheckStyleEN();
string strCondition = objCheckStyleCond
.SetCheckStyleId(objCheckStyleEN.CheckStyleId, "=")
.GetCombineCondition();
objCheckStyleEN._IsCheckProperty = true;
bool bolIsExist = clsCheckStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCheckStyleEN.Update();
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCheckStyleEN objCheckStyleEN)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCheckStyleBL.CheckStyleDA.UpdateBySql2(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCheckStyleEN objCheckStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCheckStyleBL.CheckStyleDA.UpdateBySql2(objCheckStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCheckStyleEN objCheckStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsCheckStyleBL.CheckStyleDA.UpdateBySqlWithCondition(objCheckStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCheckStyleEN objCheckStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCheckStyleBL.CheckStyleDA.UpdateBySqlWithConditionTransaction(objCheckStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCheckStyleEN objCheckStyleEN)
{
try
{
int intRecNum = clsCheckStyleBL.CheckStyleDA.DelRecord(objCheckStyleEN.CheckStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleENS">源对象</param>
 /// <param name = "objCheckStyleENT">目标对象</param>
 public static void CopyTo(this clsCheckStyleEN objCheckStyleENS, clsCheckStyleEN objCheckStyleENT)
{
try
{
objCheckStyleENT.CheckStyleId = objCheckStyleENS.CheckStyleId; //CheckStyleId
objCheckStyleENT.CheckStyleName = objCheckStyleENS.CheckStyleName; //CheckStyleName
objCheckStyleENT.Style = objCheckStyleENS.Style; //类型
objCheckStyleENT.Runat = objCheckStyleENS.Runat; //运行在
objCheckStyleENT.FontSize = objCheckStyleENS.FontSize; //字号
objCheckStyleENT.FontName = objCheckStyleENS.FontName; //字体
objCheckStyleENT.Width = objCheckStyleENS.Width; //宽
objCheckStyleENT.Height = objCheckStyleENS.Height; //高度
objCheckStyleENT.StyleZindex = objCheckStyleENS.StyleZindex; //Style_Zindex
objCheckStyleENT.StyleLeft = objCheckStyleENS.StyleLeft; //Style_Left
objCheckStyleENT.StylePosition = objCheckStyleENS.StylePosition; //Style_Position
objCheckStyleENT.StyleTop = objCheckStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objCheckStyleENS">源对象</param>
 /// <returns>目标对象=>clsCheckStyleEN:objCheckStyleENT</returns>
 public static clsCheckStyleEN CopyTo(this clsCheckStyleEN objCheckStyleENS)
{
try
{
 clsCheckStyleEN objCheckStyleENT = new clsCheckStyleEN()
{
CheckStyleId = objCheckStyleENS.CheckStyleId, //CheckStyleId
CheckStyleName = objCheckStyleENS.CheckStyleName, //CheckStyleName
Style = objCheckStyleENS.Style, //类型
Runat = objCheckStyleENS.Runat, //运行在
FontSize = objCheckStyleENS.FontSize, //字号
FontName = objCheckStyleENS.FontName, //字体
Width = objCheckStyleENS.Width, //宽
Height = objCheckStyleENS.Height, //高度
StyleZindex = objCheckStyleENS.StyleZindex, //Style_Zindex
StyleLeft = objCheckStyleENS.StyleLeft, //Style_Left
StylePosition = objCheckStyleENS.StylePosition, //Style_Position
StyleTop = objCheckStyleENS.StyleTop, //Style_Top
};
 return objCheckStyleENT;
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
public static void CheckPropertyNew(this clsCheckStyleEN objCheckStyleEN)
{
 clsCheckStyleBL.CheckStyleDA.CheckPropertyNew(objCheckStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCheckStyleEN objCheckStyleEN)
{
 clsCheckStyleBL.CheckStyleDA.CheckProperty4Condition(objCheckStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCheckStyleEN objCheckStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCheckStyleCond.IsUpdated(conCheckStyle.CheckStyleId) == true)
{
string strComparisonOpCheckStyleId = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.CheckStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.CheckStyleId, objCheckStyleCond.CheckStyleId, strComparisonOpCheckStyleId);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.CheckStyleName) == true)
{
string strComparisonOpCheckStyleName = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.CheckStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.CheckStyleName, objCheckStyleCond.CheckStyleName, strComparisonOpCheckStyleName);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.Style) == true)
{
string strComparisonOpStyle = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.Style, objCheckStyleCond.Style, strComparisonOpStyle);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.Runat) == true)
{
string strComparisonOpRunat = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.Runat, objCheckStyleCond.Runat, strComparisonOpRunat);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.FontSize) == true)
{
string strComparisonOpFontSize = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.FontSize, objCheckStyleCond.FontSize, strComparisonOpFontSize);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.FontName) == true)
{
string strComparisonOpFontName = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.FontName, objCheckStyleCond.FontName, strComparisonOpFontName);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.Width) == true)
{
string strComparisonOpWidth = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckStyle.Width, objCheckStyleCond.Width, strComparisonOpWidth);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.Height) == true)
{
string strComparisonOpHeight = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckStyle.Height, objCheckStyleCond.Height, strComparisonOpHeight);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckStyle.StyleZindex, objCheckStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckStyle.StyleLeft, objCheckStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckStyle.StylePosition, objCheckStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objCheckStyleCond.IsUpdated(conCheckStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objCheckStyleCond.dicFldComparisonOp[conCheckStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckStyle.StyleTop, objCheckStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CheckStyle
{
public virtual bool UpdRelaTabDate(string strCheckStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 复选框样式(CheckStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCheckStyleBL
{
public static RelatedActions_CheckStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCheckStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCheckStyleDA CheckStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCheckStyleDA();
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
 public clsCheckStyleBL()
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
if (string.IsNullOrEmpty(clsCheckStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCheckStyleEN._ConnectString);
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
public static DataTable GetDataTable_CheckStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CheckStyleDA.GetDataTable_CheckStyle(strWhereCond);
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
objDT = CheckStyleDA.GetDataTable(strWhereCond);
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
objDT = CheckStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CheckStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CheckStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CheckStyleDA.GetDataTable_Top(objTopPara);
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
objDT = CheckStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CheckStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CheckStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCheckStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCheckStyleEN> GetObjLstByCheckStyleIdLst(List<string> arrCheckStyleIdLst)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCheckStyleIdLst, true);
 string strWhereCond = string.Format("CheckStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCheckStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCheckStyleEN> GetObjLstByCheckStyleIdLstCache(List<string> arrCheckStyleIdLst)
{
string strKey = string.Format("{0}", clsCheckStyleEN._CurrTabName);
List<clsCheckStyleEN> arrCheckStyleObjLstCache = GetObjLstCache();
IEnumerable <clsCheckStyleEN> arrCheckStyleObjLst_Sel =
arrCheckStyleObjLstCache
.Where(x => arrCheckStyleIdLst.Contains(x.CheckStyleId));
return arrCheckStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCheckStyleEN> GetObjLst(string strWhereCond)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
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
public static List<clsCheckStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCheckStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCheckStyleEN> GetSubObjLstCache(clsCheckStyleEN objCheckStyleCond)
{
List<clsCheckStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCheckStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCheckStyle._AttributeName)
{
if (objCheckStyleCond.IsUpdated(strFldName) == false) continue;
if (objCheckStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCheckStyleCond[strFldName].ToString());
}
else
{
if (objCheckStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCheckStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCheckStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCheckStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCheckStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCheckStyleCond[strFldName]));
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
public static List<clsCheckStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
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
public static List<clsCheckStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
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
List<clsCheckStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCheckStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCheckStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCheckStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
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
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
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
public static List<clsCheckStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCheckStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCheckStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
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
public static List<clsCheckStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCheckStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCheckStyleEN.CheckStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCheckStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCheckStyle(ref clsCheckStyleEN objCheckStyleEN)
{
bool bolResult = CheckStyleDA.GetCheckStyle(ref objCheckStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCheckStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCheckStyleEN GetObjByCheckStyleId(string strCheckStyleId)
{
if (strCheckStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCheckStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCheckStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCheckStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCheckStyleEN objCheckStyleEN = CheckStyleDA.GetObjByCheckStyleId(strCheckStyleId);
return objCheckStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCheckStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCheckStyleEN objCheckStyleEN = CheckStyleDA.GetFirstObj(strWhereCond);
 return objCheckStyleEN;
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
public static clsCheckStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCheckStyleEN objCheckStyleEN = CheckStyleDA.GetObjByDataRow(objRow);
 return objCheckStyleEN;
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
public static clsCheckStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCheckStyleEN objCheckStyleEN = CheckStyleDA.GetObjByDataRow(objRow);
 return objCheckStyleEN;
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
 /// <param name = "strCheckStyleId">所给的关键字</param>
 /// <param name = "lstCheckStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCheckStyleEN GetObjByCheckStyleIdFromList(string strCheckStyleId, List<clsCheckStyleEN> lstCheckStyleObjLst)
{
foreach (clsCheckStyleEN objCheckStyleEN in lstCheckStyleObjLst)
{
if (objCheckStyleEN.CheckStyleId == strCheckStyleId)
{
return objCheckStyleEN;
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
 string strCheckStyleId;
 try
 {
 strCheckStyleId = new clsCheckStyleDA().GetFirstID(strWhereCond);
 return strCheckStyleId;
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
 arrList = CheckStyleDA.GetID(strWhereCond);
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
bool bolIsExist = CheckStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCheckStyleId)
{
if (string.IsNullOrEmpty(strCheckStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCheckStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CheckStyleDA.IsExist(strCheckStyleId);
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
 bolIsExist = clsCheckStyleDA.IsExistTable();
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
 bolIsExist = CheckStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCheckStyleEN objCheckStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCheckStyleBL.IsExist(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCheckStyleEN.CheckStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CheckStyleDA.AddNewRecordBySQL2(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCheckStyleEN objCheckStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCheckStyleBL.IsExist(objCheckStyleEN.CheckStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCheckStyleEN.CheckStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CheckStyleDA.AddNewRecordBySQL2WithReturnKey(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCheckStyleEN objCheckStyleEN)
{
try
{
bool bolResult = CheckStyleDA.Update(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCheckStyleEN objCheckStyleEN)
{
 if (string.IsNullOrEmpty(objCheckStyleEN.CheckStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CheckStyleDA.UpdateBySql2(objCheckStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckStyleBL.ReFreshCache();

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
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
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCheckStyleId)
{
try
{
 clsCheckStyleEN objCheckStyleEN = clsCheckStyleBL.GetObjByCheckStyleId(strCheckStyleId);

if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(objCheckStyleEN.CheckStyleId, "SetUpdDate");
}
if (objCheckStyleEN != null)
{
int intRecNum = CheckStyleDA.DelRecord(strCheckStyleId);
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
/// <param name="strCheckStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCheckStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
//删除与表:[CheckStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCheckStyle.CheckStyleId,
//strCheckStyleId);
//        clsCheckStyleBL.DelCheckStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCheckStyleBL.DelRecord(strCheckStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCheckStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCheckStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCheckStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCheckStyleBL.relatedActions != null)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(strCheckStyleId, "UpdRelaTabDate");
}
bool bolResult = CheckStyleDA.DelRecord(strCheckStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCheckStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCheckStyles(List<string> arrCheckStyleIdLst)
{
if (arrCheckStyleIdLst.Count == 0) return 0;
try
{
if (clsCheckStyleBL.relatedActions != null)
{
foreach (var strCheckStyleId in arrCheckStyleIdLst)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(strCheckStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = CheckStyleDA.DelCheckStyle(arrCheckStyleIdLst);
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
public static int DelCheckStylesByCond(string strWhereCond)
{
try
{
if (clsCheckStyleBL.relatedActions != null)
{
List<string> arrCheckStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCheckStyleId in arrCheckStyleId)
{
clsCheckStyleBL.relatedActions.UpdRelaTabDate(strCheckStyleId, "UpdRelaTabDate");
}
}
int intRecNum = CheckStyleDA.DelCheckStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CheckStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCheckStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCheckStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
//删除与表:[CheckStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCheckStyleBL.DelRecord(strCheckStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCheckStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCheckStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCheckStyleENS">源对象</param>
 /// <param name = "objCheckStyleENT">目标对象</param>
 public static void CopyTo(clsCheckStyleEN objCheckStyleENS, clsCheckStyleEN objCheckStyleENT)
{
try
{
objCheckStyleENT.CheckStyleId = objCheckStyleENS.CheckStyleId; //CheckStyleId
objCheckStyleENT.CheckStyleName = objCheckStyleENS.CheckStyleName; //CheckStyleName
objCheckStyleENT.Style = objCheckStyleENS.Style; //类型
objCheckStyleENT.Runat = objCheckStyleENS.Runat; //运行在
objCheckStyleENT.FontSize = objCheckStyleENS.FontSize; //字号
objCheckStyleENT.FontName = objCheckStyleENS.FontName; //字体
objCheckStyleENT.Width = objCheckStyleENS.Width; //宽
objCheckStyleENT.Height = objCheckStyleENS.Height; //高度
objCheckStyleENT.StyleZindex = objCheckStyleENS.StyleZindex; //Style_Zindex
objCheckStyleENT.StyleLeft = objCheckStyleENS.StyleLeft; //Style_Left
objCheckStyleENT.StylePosition = objCheckStyleENS.StylePosition; //Style_Position
objCheckStyleENT.StyleTop = objCheckStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objCheckStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsCheckStyleEN objCheckStyleEN)
{
try
{
objCheckStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCheckStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCheckStyle.CheckStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.CheckStyleId = objCheckStyleEN.CheckStyleId; //CheckStyleId
}
if (arrFldSet.Contains(conCheckStyle.CheckStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.CheckStyleName = objCheckStyleEN.CheckStyleName; //CheckStyleName
}
if (arrFldSet.Contains(conCheckStyle.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.Style = objCheckStyleEN.Style == "[null]" ? null :  objCheckStyleEN.Style; //类型
}
if (arrFldSet.Contains(conCheckStyle.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.Runat = objCheckStyleEN.Runat == "[null]" ? null :  objCheckStyleEN.Runat; //运行在
}
if (arrFldSet.Contains(conCheckStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.FontSize = objCheckStyleEN.FontSize == "[null]" ? null :  objCheckStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conCheckStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.FontName = objCheckStyleEN.FontName == "[null]" ? null :  objCheckStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conCheckStyle.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.Width = objCheckStyleEN.Width; //宽
}
if (arrFldSet.Contains(conCheckStyle.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.Height = objCheckStyleEN.Height; //高度
}
if (arrFldSet.Contains(conCheckStyle.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.StyleZindex = objCheckStyleEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conCheckStyle.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.StyleLeft = objCheckStyleEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conCheckStyle.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.StylePosition = objCheckStyleEN.StylePosition == "[null]" ? null :  objCheckStyleEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conCheckStyle.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objCheckStyleEN.StyleTop = objCheckStyleEN.StyleTop; //Style_Top
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
 /// <param name = "objCheckStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsCheckStyleEN objCheckStyleEN)
{
try
{
if (objCheckStyleEN.Style == "[null]") objCheckStyleEN.Style = null; //类型
if (objCheckStyleEN.Runat == "[null]") objCheckStyleEN.Runat = null; //运行在
if (objCheckStyleEN.FontSize == "[null]") objCheckStyleEN.FontSize = null; //字号
if (objCheckStyleEN.FontName == "[null]") objCheckStyleEN.FontName = null; //字体
if (objCheckStyleEN.StylePosition == "[null]") objCheckStyleEN.StylePosition = null; //Style_Position
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
public static void CheckPropertyNew(clsCheckStyleEN objCheckStyleEN)
{
 CheckStyleDA.CheckPropertyNew(objCheckStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCheckStyleEN objCheckStyleEN)
{
 CheckStyleDA.CheckProperty4Condition(objCheckStyleEN);
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
if (clsCheckStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCheckStyleBL没有刷新缓存机制(clsCheckStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CheckStyleId");
//if (arrCheckStyleObjLstCache == null)
//{
//arrCheckStyleObjLstCache = CheckStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCheckStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCheckStyleEN GetObjByCheckStyleIdCache(string strCheckStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCheckStyleEN._CurrTabName);
List<clsCheckStyleEN> arrCheckStyleObjLstCache = GetObjLstCache();
IEnumerable <clsCheckStyleEN> arrCheckStyleObjLst_Sel =
arrCheckStyleObjLstCache
.Where(x=> x.CheckStyleId == strCheckStyleId 
);
if (arrCheckStyleObjLst_Sel.Count() == 0)
{
   clsCheckStyleEN obj = clsCheckStyleBL.GetObjByCheckStyleId(strCheckStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCheckStyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCheckStyleEN> GetAllCheckStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsCheckStyleEN> arrCheckStyleObjLstCache = GetObjLstCache(); 
return arrCheckStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCheckStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCheckStyleEN._CurrTabName);
List<clsCheckStyleEN> arrCheckStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCheckStyleObjLstCache;
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
string strKey = string.Format("{0}", clsCheckStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCheckStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCheckStyleEN._RefreshTimeLst.Count == 0) return "";
return clsCheckStyleEN._RefreshTimeLst[clsCheckStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCheckStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCheckStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCheckStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCheckStyleBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strCheckStyleId)
{
if (strInFldName != conCheckStyle.CheckStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCheckStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCheckStyle._AttributeName));
throw new Exception(strMsg);
}
var objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache(strCheckStyleId);
if (objCheckStyle == null) return "";
return objCheckStyle[strOutFldName].ToString();
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
int intRecCount = clsCheckStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsCheckStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCheckStyleDA.GetRecCount();
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
int intRecCount = clsCheckStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCheckStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCheckStyleEN objCheckStyleCond)
{
List<clsCheckStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCheckStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCheckStyle._AttributeName)
{
if (objCheckStyleCond.IsUpdated(strFldName) == false) continue;
if (objCheckStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCheckStyleCond[strFldName].ToString());
}
else
{
if (objCheckStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCheckStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCheckStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCheckStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCheckStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCheckStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCheckStyleCond[strFldName]));
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
 List<string> arrList = clsCheckStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CheckStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CheckStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CheckStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCheckStyleDA.SetFldValue(clsCheckStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CheckStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCheckStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCheckStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCheckStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CheckStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**CheckStyleId*/ 
 strCreateTabCode.Append(" CheckStyleId varchar(4) primary key, "); 
 // /**CheckStyleName*/ 
 strCreateTabCode.Append(" CheckStyleName varchar(30) not Null, "); 
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
 /// 复选框样式(CheckStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CheckStyle : clsCommFun4BL
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
clsCheckStyleBL.ReFreshThisCache();
}
}

}