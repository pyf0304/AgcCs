
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLabelStyleBL
 表名:LabelStyle(00050066)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsLabelStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strLabelStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLabelStyleEN GetObj(this K_LabelStyleId_LabelStyle myKey)
{
clsLabelStyleEN objLabelStyleEN = clsLabelStyleBL.LabelStyleDA.GetObjByLabelStyleId(myKey.Value);
return objLabelStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLabelStyleEN objLabelStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsLabelStyleBL.IsExist(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objLabelStyleEN.LabelStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsLabelStyleBL.LabelStyleDA.AddNewRecordBySQL2(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsLabelStyleEN objLabelStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsLabelStyleBL.IsExist(objLabelStyleEN.LabelStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objLabelStyleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objLabelStyleEN.AddNewRecord();
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsLabelStyleEN objLabelStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsLabelStyleBL.IsExist(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objLabelStyleEN.LabelStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsLabelStyleBL.LabelStyleDA.AddNewRecordBySQL2WithReturnKey(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetLabelStyleId(this clsLabelStyleEN objLabelStyleEN, string strLabelStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelStyleId, 4, conLabelStyle.LabelStyleId);
}
objLabelStyleEN.LabelStyleId = strLabelStyleId; //LabelStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.LabelStyleId) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.LabelStyleId, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.LabelStyleId] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetLabelStyleName(this clsLabelStyleEN objLabelStyleEN, string strLabelStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLabelStyleName, conLabelStyle.LabelStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelStyleName, 30, conLabelStyle.LabelStyleName);
}
objLabelStyleEN.LabelStyleName = strLabelStyleName; //LabelStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.LabelStyleName) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.LabelStyleName, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.LabelStyleName] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetStyle(this clsLabelStyleEN objLabelStyleEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conLabelStyle.Style);
}
objLabelStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.Style) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.Style, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.Style] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetRunat(this clsLabelStyleEN objLabelStyleEN, string strRunat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conLabelStyle.Runat);
}
objLabelStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.Runat) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.Runat, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.Runat] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetFontSize(this clsLabelStyleEN objLabelStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conLabelStyle.FontSize);
}
objLabelStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.FontSize) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.FontSize, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.FontSize] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetFontName(this clsLabelStyleEN objLabelStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conLabelStyle.FontName);
}
objLabelStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.FontName) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.FontName, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.FontName] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetWidth(this clsLabelStyleEN objLabelStyleEN, int? intWidth, string strComparisonOp="")
	{
objLabelStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.Width) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.Width, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.Width] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetHeight(this clsLabelStyleEN objLabelStyleEN, int? intHeight, string strComparisonOp="")
	{
objLabelStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.Height) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.Height, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.Height] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetStyleZindex(this clsLabelStyleEN objLabelStyleEN, int? intStyleZindex, string strComparisonOp="")
	{
objLabelStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.StyleZindex) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.StyleZindex, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.StyleZindex] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetStyleLeft(this clsLabelStyleEN objLabelStyleEN, int? intStyleLeft, string strComparisonOp="")
	{
objLabelStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.StyleLeft) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.StyleLeft, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.StyleLeft] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetStylePosition(this clsLabelStyleEN objLabelStyleEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conLabelStyle.StylePosition);
}
objLabelStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.StylePosition) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.StylePosition, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.StylePosition] = strComparisonOp;
}
}
return objLabelStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLabelStyleEN SetStyleTop(this clsLabelStyleEN objLabelStyleEN, int? intStyleTop, string strComparisonOp="")
	{
objLabelStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLabelStyleEN.dicFldComparisonOp.ContainsKey(conLabelStyle.StyleTop) == false)
{
objLabelStyleEN.dicFldComparisonOp.Add(conLabelStyle.StyleTop, strComparisonOp);
}
else
{
objLabelStyleEN.dicFldComparisonOp[conLabelStyle.StyleTop] = strComparisonOp;
}
}
return objLabelStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objLabelStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsLabelStyleEN objLabelStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objLabelStyleEN.CheckPropertyNew();
clsLabelStyleEN objLabelStyleCond = new clsLabelStyleEN();
string strCondition = objLabelStyleCond
.SetLabelStyleId(objLabelStyleEN.LabelStyleId, "=")
.GetCombineCondition();
objLabelStyleEN._IsCheckProperty = true;
bool bolIsExist = clsLabelStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objLabelStyleEN.Update();
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLabelStyleEN objLabelStyleEN)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLabelStyleBL.LabelStyleDA.UpdateBySql2(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLabelStyleEN objLabelStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsLabelStyleBL.LabelStyleDA.UpdateBySql2(objLabelStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLabelStyleEN objLabelStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsLabelStyleBL.LabelStyleDA.UpdateBySqlWithCondition(objLabelStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLabelStyleEN objLabelStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsLabelStyleBL.LabelStyleDA.UpdateBySqlWithConditionTransaction(objLabelStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsLabelStyleEN objLabelStyleEN)
{
try
{
int intRecNum = clsLabelStyleBL.LabelStyleDA.DelRecord(objLabelStyleEN.LabelStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleENS">源对象</param>
 /// <param name = "objLabelStyleENT">目标对象</param>
 public static void CopyTo(this clsLabelStyleEN objLabelStyleENS, clsLabelStyleEN objLabelStyleENT)
{
try
{
objLabelStyleENT.LabelStyleId = objLabelStyleENS.LabelStyleId; //LabelStyleId
objLabelStyleENT.LabelStyleName = objLabelStyleENS.LabelStyleName; //LabelStyleName
objLabelStyleENT.Style = objLabelStyleENS.Style; //类型
objLabelStyleENT.Runat = objLabelStyleENS.Runat; //运行在
objLabelStyleENT.FontSize = objLabelStyleENS.FontSize; //字号
objLabelStyleENT.FontName = objLabelStyleENS.FontName; //字体
objLabelStyleENT.Width = objLabelStyleENS.Width; //宽
objLabelStyleENT.Height = objLabelStyleENS.Height; //高度
objLabelStyleENT.StyleZindex = objLabelStyleENS.StyleZindex; //Style_Zindex
objLabelStyleENT.StyleLeft = objLabelStyleENS.StyleLeft; //Style_Left
objLabelStyleENT.StylePosition = objLabelStyleENS.StylePosition; //Style_Position
objLabelStyleENT.StyleTop = objLabelStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objLabelStyleENS">源对象</param>
 /// <returns>目标对象=>clsLabelStyleEN:objLabelStyleENT</returns>
 public static clsLabelStyleEN CopyTo(this clsLabelStyleEN objLabelStyleENS)
{
try
{
 clsLabelStyleEN objLabelStyleENT = new clsLabelStyleEN()
{
LabelStyleId = objLabelStyleENS.LabelStyleId, //LabelStyleId
LabelStyleName = objLabelStyleENS.LabelStyleName, //LabelStyleName
Style = objLabelStyleENS.Style, //类型
Runat = objLabelStyleENS.Runat, //运行在
FontSize = objLabelStyleENS.FontSize, //字号
FontName = objLabelStyleENS.FontName, //字体
Width = objLabelStyleENS.Width, //宽
Height = objLabelStyleENS.Height, //高度
StyleZindex = objLabelStyleENS.StyleZindex, //Style_Zindex
StyleLeft = objLabelStyleENS.StyleLeft, //Style_Left
StylePosition = objLabelStyleENS.StylePosition, //Style_Position
StyleTop = objLabelStyleENS.StyleTop, //Style_Top
};
 return objLabelStyleENT;
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
public static void CheckPropertyNew(this clsLabelStyleEN objLabelStyleEN)
{
 clsLabelStyleBL.LabelStyleDA.CheckPropertyNew(objLabelStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsLabelStyleEN objLabelStyleEN)
{
 clsLabelStyleBL.LabelStyleDA.CheckProperty4Condition(objLabelStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLabelStyleEN objLabelStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLabelStyleCond.IsUpdated(conLabelStyle.LabelStyleId) == true)
{
string strComparisonOpLabelStyleId = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.LabelStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.LabelStyleId, objLabelStyleCond.LabelStyleId, strComparisonOpLabelStyleId);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.LabelStyleName) == true)
{
string strComparisonOpLabelStyleName = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.LabelStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.LabelStyleName, objLabelStyleCond.LabelStyleName, strComparisonOpLabelStyleName);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.Style) == true)
{
string strComparisonOpStyle = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.Style, objLabelStyleCond.Style, strComparisonOpStyle);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.Runat) == true)
{
string strComparisonOpRunat = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.Runat, objLabelStyleCond.Runat, strComparisonOpRunat);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.FontSize) == true)
{
string strComparisonOpFontSize = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.FontSize, objLabelStyleCond.FontSize, strComparisonOpFontSize);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.FontName) == true)
{
string strComparisonOpFontName = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.FontName, objLabelStyleCond.FontName, strComparisonOpFontName);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.Width) == true)
{
string strComparisonOpWidth = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conLabelStyle.Width, objLabelStyleCond.Width, strComparisonOpWidth);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.Height) == true)
{
string strComparisonOpHeight = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conLabelStyle.Height, objLabelStyleCond.Height, strComparisonOpHeight);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conLabelStyle.StyleZindex, objLabelStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conLabelStyle.StyleLeft, objLabelStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLabelStyle.StylePosition, objLabelStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objLabelStyleCond.IsUpdated(conLabelStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objLabelStyleCond.dicFldComparisonOp[conLabelStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conLabelStyle.StyleTop, objLabelStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_LabelStyle
{
public virtual bool UpdRelaTabDate(string strLabelStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 标签样式(LabelStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsLabelStyleBL
{
public static RelatedActions_LabelStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsLabelStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsLabelStyleDA LabelStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsLabelStyleDA();
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
 public clsLabelStyleBL()
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
if (string.IsNullOrEmpty(clsLabelStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLabelStyleEN._ConnectString);
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
public static DataTable GetDataTable_LabelStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = LabelStyleDA.GetDataTable_LabelStyle(strWhereCond);
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
objDT = LabelStyleDA.GetDataTable(strWhereCond);
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
objDT = LabelStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = LabelStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = LabelStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = LabelStyleDA.GetDataTable_Top(objTopPara);
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
objDT = LabelStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = LabelStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = LabelStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrLabelStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsLabelStyleEN> GetObjLstByLabelStyleIdLst(List<string> arrLabelStyleIdLst)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrLabelStyleIdLst, true);
 string strWhereCond = string.Format("LabelStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrLabelStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsLabelStyleEN> GetObjLstByLabelStyleIdLstCache(List<string> arrLabelStyleIdLst)
{
string strKey = string.Format("{0}", clsLabelStyleEN._CurrTabName);
List<clsLabelStyleEN> arrLabelStyleObjLstCache = GetObjLstCache();
IEnumerable <clsLabelStyleEN> arrLabelStyleObjLst_Sel =
arrLabelStyleObjLstCache
.Where(x => arrLabelStyleIdLst.Contains(x.LabelStyleId));
return arrLabelStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsLabelStyleEN> GetObjLst(string strWhereCond)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
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
public static List<clsLabelStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objLabelStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsLabelStyleEN> GetSubObjLstCache(clsLabelStyleEN objLabelStyleCond)
{
List<clsLabelStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLabelStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLabelStyle._AttributeName)
{
if (objLabelStyleCond.IsUpdated(strFldName) == false) continue;
if (objLabelStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLabelStyleCond[strFldName].ToString());
}
else
{
if (objLabelStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLabelStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLabelStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLabelStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLabelStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLabelStyleCond[strFldName]));
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
public static List<clsLabelStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
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
public static List<clsLabelStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
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
List<clsLabelStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsLabelStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsLabelStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsLabelStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
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
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
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
public static List<clsLabelStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsLabelStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsLabelStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
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
public static List<clsLabelStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsLabelStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsLabelStyleEN> arrObjLst = new List<clsLabelStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLabelStyleEN objLabelStyleEN = new clsLabelStyleEN();
try
{
objLabelStyleEN.LabelStyleId = objRow[conLabelStyle.LabelStyleId].ToString().Trim(); //LabelStyleId
objLabelStyleEN.LabelStyleName = objRow[conLabelStyle.LabelStyleName].ToString().Trim(); //LabelStyleName
objLabelStyleEN.Style = objRow[conLabelStyle.Style] == DBNull.Value ? null : objRow[conLabelStyle.Style].ToString().Trim(); //类型
objLabelStyleEN.Runat = objRow[conLabelStyle.Runat] == DBNull.Value ? null : objRow[conLabelStyle.Runat].ToString().Trim(); //运行在
objLabelStyleEN.FontSize = objRow[conLabelStyle.FontSize] == DBNull.Value ? null : objRow[conLabelStyle.FontSize].ToString().Trim(); //字号
objLabelStyleEN.FontName = objRow[conLabelStyle.FontName] == DBNull.Value ? null : objRow[conLabelStyle.FontName].ToString().Trim(); //字体
objLabelStyleEN.Width = objRow[conLabelStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Width].ToString().Trim()); //宽
objLabelStyleEN.Height = objRow[conLabelStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.Height].ToString().Trim()); //高度
objLabelStyleEN.StyleZindex = objRow[conLabelStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objLabelStyleEN.StyleLeft = objRow[conLabelStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleLeft].ToString().Trim()); //Style_Left
objLabelStyleEN.StylePosition = objRow[conLabelStyle.StylePosition] == DBNull.Value ? null : objRow[conLabelStyle.StylePosition].ToString().Trim(); //Style_Position
objLabelStyleEN.StyleTop = objRow[conLabelStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLabelStyle.StyleTop].ToString().Trim()); //Style_Top
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objLabelStyleEN.LabelStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objLabelStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objLabelStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetLabelStyle(ref clsLabelStyleEN objLabelStyleEN)
{
bool bolResult = LabelStyleDA.GetLabelStyle(ref objLabelStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strLabelStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLabelStyleEN GetObjByLabelStyleId(string strLabelStyleId)
{
if (strLabelStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strLabelStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strLabelStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strLabelStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsLabelStyleEN objLabelStyleEN = LabelStyleDA.GetObjByLabelStyleId(strLabelStyleId);
return objLabelStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsLabelStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsLabelStyleEN objLabelStyleEN = LabelStyleDA.GetFirstObj(strWhereCond);
 return objLabelStyleEN;
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
public static clsLabelStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsLabelStyleEN objLabelStyleEN = LabelStyleDA.GetObjByDataRow(objRow);
 return objLabelStyleEN;
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
public static clsLabelStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsLabelStyleEN objLabelStyleEN = LabelStyleDA.GetObjByDataRow(objRow);
 return objLabelStyleEN;
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
 /// <param name = "strLabelStyleId">所给的关键字</param>
 /// <param name = "lstLabelStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLabelStyleEN GetObjByLabelStyleIdFromList(string strLabelStyleId, List<clsLabelStyleEN> lstLabelStyleObjLst)
{
foreach (clsLabelStyleEN objLabelStyleEN in lstLabelStyleObjLst)
{
if (objLabelStyleEN.LabelStyleId == strLabelStyleId)
{
return objLabelStyleEN;
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
 string strLabelStyleId;
 try
 {
 strLabelStyleId = new clsLabelStyleDA().GetFirstID(strWhereCond);
 return strLabelStyleId;
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
 arrList = LabelStyleDA.GetID(strWhereCond);
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
bool bolIsExist = LabelStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strLabelStyleId)
{
if (string.IsNullOrEmpty(strLabelStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strLabelStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = LabelStyleDA.IsExist(strLabelStyleId);
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
 bolIsExist = clsLabelStyleDA.IsExistTable();
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
 bolIsExist = LabelStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsLabelStyleEN objLabelStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsLabelStyleBL.IsExist(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objLabelStyleEN.LabelStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = LabelStyleDA.AddNewRecordBySQL2(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsLabelStyleEN objLabelStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsLabelStyleBL.IsExist(objLabelStyleEN.LabelStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objLabelStyleEN.LabelStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = LabelStyleDA.AddNewRecordBySQL2WithReturnKey(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsLabelStyleEN objLabelStyleEN)
{
try
{
bool bolResult = LabelStyleDA.Update(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "objLabelStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsLabelStyleEN objLabelStyleEN)
{
 if (string.IsNullOrEmpty(objLabelStyleEN.LabelStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = LabelStyleDA.UpdateBySql2(objLabelStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsLabelStyleBL.ReFreshCache();

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
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
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strLabelStyleId)
{
try
{
 clsLabelStyleEN objLabelStyleEN = clsLabelStyleBL.GetObjByLabelStyleId(strLabelStyleId);

if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(objLabelStyleEN.LabelStyleId, "SetUpdDate");
}
if (objLabelStyleEN != null)
{
int intRecNum = LabelStyleDA.DelRecord(strLabelStyleId);
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
/// <param name="strLabelStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strLabelStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
//删除与表:[LabelStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conLabelStyle.LabelStyleId,
//strLabelStyleId);
//        clsLabelStyleBL.DelLabelStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLabelStyleBL.DelRecord(strLabelStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLabelStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLabelStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strLabelStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strLabelStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsLabelStyleBL.relatedActions != null)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(strLabelStyleId, "UpdRelaTabDate");
}
bool bolResult = LabelStyleDA.DelRecord(strLabelStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrLabelStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelLabelStyles(List<string> arrLabelStyleIdLst)
{
if (arrLabelStyleIdLst.Count == 0) return 0;
try
{
if (clsLabelStyleBL.relatedActions != null)
{
foreach (var strLabelStyleId in arrLabelStyleIdLst)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(strLabelStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = LabelStyleDA.DelLabelStyle(arrLabelStyleIdLst);
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
public static int DelLabelStylesByCond(string strWhereCond)
{
try
{
if (clsLabelStyleBL.relatedActions != null)
{
List<string> arrLabelStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strLabelStyleId in arrLabelStyleId)
{
clsLabelStyleBL.relatedActions.UpdRelaTabDate(strLabelStyleId, "UpdRelaTabDate");
}
}
int intRecNum = LabelStyleDA.DelLabelStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[LabelStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strLabelStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strLabelStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsLabelStyleDA.GetSpecSQLObj();
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
//删除与表:[LabelStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsLabelStyleBL.DelRecord(strLabelStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsLabelStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLabelStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objLabelStyleENS">源对象</param>
 /// <param name = "objLabelStyleENT">目标对象</param>
 public static void CopyTo(clsLabelStyleEN objLabelStyleENS, clsLabelStyleEN objLabelStyleENT)
{
try
{
objLabelStyleENT.LabelStyleId = objLabelStyleENS.LabelStyleId; //LabelStyleId
objLabelStyleENT.LabelStyleName = objLabelStyleENS.LabelStyleName; //LabelStyleName
objLabelStyleENT.Style = objLabelStyleENS.Style; //类型
objLabelStyleENT.Runat = objLabelStyleENS.Runat; //运行在
objLabelStyleENT.FontSize = objLabelStyleENS.FontSize; //字号
objLabelStyleENT.FontName = objLabelStyleENS.FontName; //字体
objLabelStyleENT.Width = objLabelStyleENS.Width; //宽
objLabelStyleENT.Height = objLabelStyleENS.Height; //高度
objLabelStyleENT.StyleZindex = objLabelStyleENS.StyleZindex; //Style_Zindex
objLabelStyleENT.StyleLeft = objLabelStyleENS.StyleLeft; //Style_Left
objLabelStyleENT.StylePosition = objLabelStyleENS.StylePosition; //Style_Position
objLabelStyleENT.StyleTop = objLabelStyleENS.StyleTop; //Style_Top
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
 /// <param name = "objLabelStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsLabelStyleEN objLabelStyleEN)
{
try
{
objLabelStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objLabelStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conLabelStyle.LabelStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.LabelStyleId = objLabelStyleEN.LabelStyleId; //LabelStyleId
}
if (arrFldSet.Contains(conLabelStyle.LabelStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.LabelStyleName = objLabelStyleEN.LabelStyleName; //LabelStyleName
}
if (arrFldSet.Contains(conLabelStyle.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.Style = objLabelStyleEN.Style == "[null]" ? null :  objLabelStyleEN.Style; //类型
}
if (arrFldSet.Contains(conLabelStyle.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.Runat = objLabelStyleEN.Runat == "[null]" ? null :  objLabelStyleEN.Runat; //运行在
}
if (arrFldSet.Contains(conLabelStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.FontSize = objLabelStyleEN.FontSize == "[null]" ? null :  objLabelStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conLabelStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.FontName = objLabelStyleEN.FontName == "[null]" ? null :  objLabelStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conLabelStyle.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.Width = objLabelStyleEN.Width; //宽
}
if (arrFldSet.Contains(conLabelStyle.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.Height = objLabelStyleEN.Height; //高度
}
if (arrFldSet.Contains(conLabelStyle.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.StyleZindex = objLabelStyleEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conLabelStyle.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.StyleLeft = objLabelStyleEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conLabelStyle.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.StylePosition = objLabelStyleEN.StylePosition == "[null]" ? null :  objLabelStyleEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conLabelStyle.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objLabelStyleEN.StyleTop = objLabelStyleEN.StyleTop; //Style_Top
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
 /// <param name = "objLabelStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsLabelStyleEN objLabelStyleEN)
{
try
{
if (objLabelStyleEN.Style == "[null]") objLabelStyleEN.Style = null; //类型
if (objLabelStyleEN.Runat == "[null]") objLabelStyleEN.Runat = null; //运行在
if (objLabelStyleEN.FontSize == "[null]") objLabelStyleEN.FontSize = null; //字号
if (objLabelStyleEN.FontName == "[null]") objLabelStyleEN.FontName = null; //字体
if (objLabelStyleEN.StylePosition == "[null]") objLabelStyleEN.StylePosition = null; //Style_Position
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
public static void CheckPropertyNew(clsLabelStyleEN objLabelStyleEN)
{
 LabelStyleDA.CheckPropertyNew(objLabelStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsLabelStyleEN objLabelStyleEN)
{
 LabelStyleDA.CheckProperty4Condition(objLabelStyleEN);
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
if (clsLabelStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLabelStyleBL没有刷新缓存机制(clsLabelStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LabelStyleId");
//if (arrLabelStyleObjLstCache == null)
//{
//arrLabelStyleObjLstCache = LabelStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strLabelStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsLabelStyleEN GetObjByLabelStyleIdCache(string strLabelStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsLabelStyleEN._CurrTabName);
List<clsLabelStyleEN> arrLabelStyleObjLstCache = GetObjLstCache();
IEnumerable <clsLabelStyleEN> arrLabelStyleObjLst_Sel =
arrLabelStyleObjLstCache
.Where(x=> x.LabelStyleId == strLabelStyleId 
);
if (arrLabelStyleObjLst_Sel.Count() == 0)
{
   clsLabelStyleEN obj = clsLabelStyleBL.GetObjByLabelStyleId(strLabelStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrLabelStyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLabelStyleEN> GetAllLabelStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsLabelStyleEN> arrLabelStyleObjLstCache = GetObjLstCache(); 
return arrLabelStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsLabelStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsLabelStyleEN._CurrTabName);
List<clsLabelStyleEN> arrLabelStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrLabelStyleObjLstCache;
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
string strKey = string.Format("{0}", clsLabelStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLabelStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsLabelStyleEN._RefreshTimeLst.Count == 0) return "";
return clsLabelStyleEN._RefreshTimeLst[clsLabelStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsLabelStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLabelStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLabelStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsLabelStyleBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strLabelStyleId)
{
if (strInFldName != conLabelStyle.LabelStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conLabelStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conLabelStyle._AttributeName));
throw new Exception(strMsg);
}
var objLabelStyle = clsLabelStyleBL.GetObjByLabelStyleIdCache(strLabelStyleId);
if (objLabelStyle == null) return "";
return objLabelStyle[strOutFldName].ToString();
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
int intRecCount = clsLabelStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsLabelStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsLabelStyleDA.GetRecCount();
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
int intRecCount = clsLabelStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objLabelStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsLabelStyleEN objLabelStyleCond)
{
List<clsLabelStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsLabelStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conLabelStyle._AttributeName)
{
if (objLabelStyleCond.IsUpdated(strFldName) == false) continue;
if (objLabelStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLabelStyleCond[strFldName].ToString());
}
else
{
if (objLabelStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objLabelStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objLabelStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objLabelStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objLabelStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objLabelStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objLabelStyleCond[strFldName]));
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
 List<string> arrList = clsLabelStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = LabelStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = LabelStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = LabelStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsLabelStyleDA.SetFldValue(clsLabelStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = LabelStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsLabelStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsLabelStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsLabelStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[LabelStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**LabelStyleId*/ 
 strCreateTabCode.Append(" LabelStyleId varchar(4) primary key, "); 
 // /**LabelStyleName*/ 
 strCreateTabCode.Append(" LabelStyleName varchar(30) not Null, "); 
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
 /// 标签样式(LabelStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4LabelStyle : clsCommFun4BL
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
clsLabelStyleBL.ReFreshThisCache();
}
}

}