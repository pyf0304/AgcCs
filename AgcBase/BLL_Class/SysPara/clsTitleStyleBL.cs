
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTitleStyleBL
 表名:TitleStyle(00050004)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:02
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
public static class  clsTitleStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTitleStyleEN GetObj(this K_TitleStyleId_TitleStyle myKey)
{
clsTitleStyleEN objTitleStyleEN = clsTitleStyleBL.TitleStyleDA.GetObjByTitleStyleId(myKey.Value);
return objTitleStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTitleStyleEN.TitleStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTitleStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!标题类型名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsTitleStyleBL.AddNewRecord)", objTitleStyleEN.TitleStyleName,objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTitleStyleBL.TitleStyleDA.AddNewRecordBySQL2(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
public static bool AddRecordEx(this clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTitleStyleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTitleStyleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(标题类型名(TitleStyleName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objTitleStyleEN.TitleStyleName, objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTitleStyleEN.AddNewRecord();
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTitleStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!标题类型名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsTitleStyleBL.AddNewRecordWithMaxId)", objTitleStyleEN.TitleStyleName,objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true || clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
     objTitleStyleEN.TitleStyleId = clsTitleStyleBL.GetMaxStrIdByPrefix_S(objTitleStyleEN.PrjId);
 }
string strTitleStyleId = clsTitleStyleBL.TitleStyleDA.AddNewRecordBySQL2WithReturnKey(objTitleStyleEN);
     objTitleStyleEN.TitleStyleId = strTitleStyleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
}
return strTitleStyleId;
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTitleStyleEN.TitleStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTitleStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!标题类型名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsTitleStyleBL.AddNewRecordWithReturnKey)", objTitleStyleEN.TitleStyleName,objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTitleStyleBL.TitleStyleDA.AddNewRecordBySQL2WithReturnKey(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleStyleId(this clsTitleStyleEN objTitleStyleEN, string strTitleStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, conTitleStyle.TitleStyleId);
}
objTitleStyleEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleStyleId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleStyleId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleStyleId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleStyleName(this clsTitleStyleEN objTitleStyleEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, conTitleStyle.TitleStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, conTitleStyle.TitleStyleName);
}
objTitleStyleEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleStyleName) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleStyleName, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleStyleName] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetPrjId(this clsTitleStyleEN objTitleStyleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTitleStyle.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTitleStyle.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTitleStyle.PrjId);
}
objTitleStyleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.PrjId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.PrjId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.PrjId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTabHeight(this clsTitleStyleEN objTitleStyleEN, int intTabHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabHeight, conTitleStyle.TabHeight);
objTitleStyleEN.TabHeight = intTabHeight; //表格高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TabHeight) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TabHeight, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TabHeight] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetImgFile(this clsTitleStyleEN objTitleStyleEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strImgFile, conTitleStyle.ImgFile);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 200, conTitleStyle.ImgFile);
}
objTitleStyleEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.ImgFile) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.ImgFile, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.ImgFile] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetBackColor(this clsTitleStyleEN objTitleStyleEN, string strBackColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBackColor, conTitleStyle.BackColor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBackColor, 30, conTitleStyle.BackColor);
}
objTitleStyleEN.BackColor = strBackColor; //背景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.BackColor) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.BackColor, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.BackColor] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTabWidth(this clsTitleStyleEN objTitleStyleEN, int intTabWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabWidth, conTitleStyle.TabWidth);
objTitleStyleEN.TabWidth = intTabWidth; //表格宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TabWidth) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TabWidth, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TabWidth] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetForeColor(this clsTitleStyleEN objTitleStyleEN, string strForeColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeColor, conTitleStyle.ForeColor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeColor, 30, conTitleStyle.ForeColor);
}
objTitleStyleEN.ForeColor = strForeColor; //前景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.ForeColor) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.ForeColor, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.ForeColor] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetFontSize(this clsTitleStyleEN objTitleStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conTitleStyle.FontSize);
}
objTitleStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.FontSize) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.FontSize, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.FontSize] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetFontName(this clsTitleStyleEN objTitleStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conTitleStyle.FontName);
}
objTitleStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.FontName) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.FontName, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.FontName] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetIsDefault(this clsTitleStyleEN objTitleStyleEN, bool bolIsDefault, string strComparisonOp="")
	{
objTitleStyleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.IsDefault) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.IsDefault, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.IsDefault] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleTypeId(this clsTitleStyleEN objTitleStyleEN, string strTitleTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeId, conTitleStyle.TitleTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleTypeId, 2, conTitleStyle.TitleTypeId);
}
objTitleStyleEN.TitleTypeId = strTitleTypeId; //标题类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleTypeId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleTypeId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleTypeId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetUpdDate(this clsTitleStyleEN objTitleStyleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTitleStyle.UpdDate);
}
objTitleStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.UpdDate) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.UpdDate, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.UpdDate] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetUpdUserId(this clsTitleStyleEN objTitleStyleEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTitleStyle.UpdUserId);
}
objTitleStyleEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.UpdUserId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.UpdUserId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.UpdUserId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetMemo(this clsTitleStyleEN objTitleStyleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTitleStyle.Memo);
}
objTitleStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.Memo) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.Memo, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.Memo] = strComparisonOp;
}
}
return objTitleStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTitleStyleEN objTitleStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTitleStyleEN.CheckPropertyNew();
clsTitleStyleEN objTitleStyleCond = new clsTitleStyleEN();
string strCondition = objTitleStyleCond
.SetTitleStyleId(objTitleStyleEN.TitleStyleId, "<>")
.SetTitleStyleName(objTitleStyleEN.TitleStyleName, "=")
.SetPrjId(objTitleStyleEN.PrjId, "=")
.GetCombineCondition();
objTitleStyleEN._IsCheckProperty = true;
bool bolIsExist = clsTitleStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TitleStyleName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTitleStyleEN.Update();
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
 /// <param name = "objTitleStyle">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTitleStyleEN objTitleStyle)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTitleStyleEN objTitleStyleCond = new clsTitleStyleEN();
string strCondition = objTitleStyleCond
.SetTitleStyleName(objTitleStyle.TitleStyleName, "=")
.SetPrjId(objTitleStyle.PrjId, "=")
.GetCombineCondition();
objTitleStyle._IsCheckProperty = true;
bool bolIsExist = clsTitleStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTitleStyle.TitleStyleId = clsTitleStyleBL.GetFirstID_S(strCondition);
objTitleStyle.UpdateWithCondition(strCondition);
}
else
{
objTitleStyle.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTitleStyleEN objTitleStyleEN)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTitleStyleBL.TitleStyleDA.UpdateBySql2(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTitleStyleEN objTitleStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTitleStyleBL.TitleStyleDA.UpdateBySql2(objTitleStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTitleStyleEN objTitleStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsTitleStyleBL.TitleStyleDA.UpdateBySqlWithCondition(objTitleStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTitleStyleEN objTitleStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTitleStyleBL.TitleStyleDA.UpdateBySqlWithConditionTransaction(objTitleStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTitleStyleEN objTitleStyleEN)
{
try
{
int intRecNum = clsTitleStyleBL.TitleStyleDA.DelRecord(objTitleStyleEN.TitleStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleENS">源对象</param>
 /// <param name = "objTitleStyleENT">目标对象</param>
 public static void CopyTo(this clsTitleStyleEN objTitleStyleENS, clsTitleStyleEN objTitleStyleENT)
{
try
{
objTitleStyleENT.TitleStyleId = objTitleStyleENS.TitleStyleId; //标题类型Id
objTitleStyleENT.TitleStyleName = objTitleStyleENS.TitleStyleName; //标题类型名
objTitleStyleENT.PrjId = objTitleStyleENS.PrjId; //工程Id
objTitleStyleENT.TabHeight = objTitleStyleENS.TabHeight; //表格高度
objTitleStyleENT.ImgFile = objTitleStyleENS.ImgFile; //图像文件
objTitleStyleENT.BackColor = objTitleStyleENS.BackColor; //背景颜色
objTitleStyleENT.TabWidth = objTitleStyleENS.TabWidth; //表格宽度
objTitleStyleENT.ForeColor = objTitleStyleENS.ForeColor; //前景颜色
objTitleStyleENT.FontSize = objTitleStyleENS.FontSize; //字号
objTitleStyleENT.FontName = objTitleStyleENS.FontName; //字体
objTitleStyleENT.IsDefault = objTitleStyleENS.IsDefault; //是否默认
objTitleStyleENT.TitleTypeId = objTitleStyleENS.TitleTypeId; //标题类型ID
objTitleStyleENT.UpdDate = objTitleStyleENS.UpdDate; //修改日期
objTitleStyleENT.UpdUserId = objTitleStyleENS.UpdUserId; //修改用户Id
objTitleStyleENT.Memo = objTitleStyleENS.Memo; //说明
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
 /// <param name = "objTitleStyleENS">源对象</param>
 /// <returns>目标对象=>clsTitleStyleEN:objTitleStyleENT</returns>
 public static clsTitleStyleEN CopyTo(this clsTitleStyleEN objTitleStyleENS)
{
try
{
 clsTitleStyleEN objTitleStyleENT = new clsTitleStyleEN()
{
TitleStyleId = objTitleStyleENS.TitleStyleId, //标题类型Id
TitleStyleName = objTitleStyleENS.TitleStyleName, //标题类型名
PrjId = objTitleStyleENS.PrjId, //工程Id
TabHeight = objTitleStyleENS.TabHeight, //表格高度
ImgFile = objTitleStyleENS.ImgFile, //图像文件
BackColor = objTitleStyleENS.BackColor, //背景颜色
TabWidth = objTitleStyleENS.TabWidth, //表格宽度
ForeColor = objTitleStyleENS.ForeColor, //前景颜色
FontSize = objTitleStyleENS.FontSize, //字号
FontName = objTitleStyleENS.FontName, //字体
IsDefault = objTitleStyleENS.IsDefault, //是否默认
TitleTypeId = objTitleStyleENS.TitleTypeId, //标题类型ID
UpdDate = objTitleStyleENS.UpdDate, //修改日期
UpdUserId = objTitleStyleENS.UpdUserId, //修改用户Id
Memo = objTitleStyleENS.Memo, //说明
};
 return objTitleStyleENT;
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
public static void CheckPropertyNew(this clsTitleStyleEN objTitleStyleEN)
{
 clsTitleStyleBL.TitleStyleDA.CheckPropertyNew(objTitleStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTitleStyleEN objTitleStyleEN)
{
 clsTitleStyleBL.TitleStyleDA.CheckProperty4Condition(objTitleStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTitleStyleEN objTitleStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleStyleId, objTitleStyleCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleStyleName, objTitleStyleCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.PrjId) == true)
{
string strComparisonOpPrjId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.PrjId, objTitleStyleCond.PrjId, strComparisonOpPrjId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TabHeight) == true)
{
string strComparisonOpTabHeight = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TabHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conTitleStyle.TabHeight, objTitleStyleCond.TabHeight, strComparisonOpTabHeight);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.ImgFile) == true)
{
string strComparisonOpImgFile = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.ImgFile, objTitleStyleCond.ImgFile, strComparisonOpImgFile);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.BackColor) == true)
{
string strComparisonOpBackColor = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.BackColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.BackColor, objTitleStyleCond.BackColor, strComparisonOpBackColor);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TabWidth) == true)
{
string strComparisonOpTabWidth = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TabWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conTitleStyle.TabWidth, objTitleStyleCond.TabWidth, strComparisonOpTabWidth);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.ForeColor) == true)
{
string strComparisonOpForeColor = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.ForeColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.ForeColor, objTitleStyleCond.ForeColor, strComparisonOpForeColor);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.FontSize) == true)
{
string strComparisonOpFontSize = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.FontSize, objTitleStyleCond.FontSize, strComparisonOpFontSize);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.FontName) == true)
{
string strComparisonOpFontName = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.FontName, objTitleStyleCond.FontName, strComparisonOpFontName);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.IsDefault) == true)
{
if (objTitleStyleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTitleStyle.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTitleStyle.IsDefault);
}
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleTypeId) == true)
{
string strComparisonOpTitleTypeId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleTypeId, objTitleStyleCond.TitleTypeId, strComparisonOpTitleTypeId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.UpdDate, objTitleStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.UpdUserId, objTitleStyleCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.Memo) == true)
{
string strComparisonOpMemo = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.Memo, objTitleStyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TitleStyle(标题模式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TitleStyleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTitleStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTitleStyleEN objTitleStyleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTitleStyleEN == null) return true;
if (objTitleStyleEN.TitleStyleId == null || objTitleStyleEN.TitleStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
if (clsTitleStyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TitleStyleId !=  '{0}'", objTitleStyleEN.TitleStyleId);
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
if (clsTitleStyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TitleStyle(标题模式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TitleStyleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTitleStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTitleStyleEN objTitleStyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTitleStyleEN == null) return "";
if (objTitleStyleEN.TitleStyleId == null || objTitleStyleEN.TitleStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TitleStyleId !=  '{0}'", objTitleStyleEN.TitleStyleId);
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TitleStyle
{
public virtual bool UpdRelaTabDate(string strTitleStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 标题模式(TitleStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTitleStyleBL
{
public static RelatedActions_TitleStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTitleStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTitleStyleDA TitleStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTitleStyleDA();
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
 public clsTitleStyleBL()
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
if (string.IsNullOrEmpty(clsTitleStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTitleStyleEN._ConnectString);
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
public static DataTable GetDataTable_TitleStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TitleStyleDA.GetDataTable_TitleStyle(strWhereCond);
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
objDT = TitleStyleDA.GetDataTable(strWhereCond);
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
objDT = TitleStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TitleStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TitleStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TitleStyleDA.GetDataTable_Top(objTopPara);
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
objDT = TitleStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TitleStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TitleStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTitleStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTitleStyleEN> GetObjLstByTitleStyleIdLst(List<string> arrTitleStyleIdLst)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTitleStyleIdLst, true);
 string strWhereCond = string.Format("TitleStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTitleStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTitleStyleEN> GetObjLstByTitleStyleIdLstCache(List<string> arrTitleStyleIdLst)
{
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel =
arrTitleStyleObjLstCache
.Where(x => arrTitleStyleIdLst.Contains(x.TitleStyleId));
return arrTitleStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTitleStyleEN> GetObjLst(string strWhereCond)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
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
public static List<clsTitleStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTitleStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTitleStyleEN> GetSubObjLstCache(clsTitleStyleEN objTitleStyleCond)
{
List<clsTitleStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTitleStyle._AttributeName)
{
if (objTitleStyleCond.IsUpdated(strFldName) == false) continue;
if (objTitleStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTitleStyleCond[strFldName].ToString());
}
else
{
if (objTitleStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTitleStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTitleStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTitleStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTitleStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTitleStyleCond[strFldName]));
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
public static List<clsTitleStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
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
public static List<clsTitleStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
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
List<clsTitleStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTitleStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTitleStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTitleStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
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
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
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
public static List<clsTitleStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTitleStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTitleStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
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
public static List<clsTitleStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTitleStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTitleStyleEN> arrObjLst = new List<clsTitleStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN();
try
{
objTitleStyleEN.TitleStyleId = objRow[conTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objTitleStyleEN.TitleStyleName = objRow[conTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objTitleStyleEN.PrjId = objRow[conTitleStyle.PrjId].ToString().Trim(); //工程Id
objTitleStyleEN.TabHeight = Int32.Parse(objRow[conTitleStyle.TabHeight].ToString().Trim()); //表格高度
objTitleStyleEN.ImgFile = objRow[conTitleStyle.ImgFile].ToString().Trim(); //图像文件
objTitleStyleEN.BackColor = objRow[conTitleStyle.BackColor].ToString().Trim(); //背景颜色
objTitleStyleEN.TabWidth = Int32.Parse(objRow[conTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objTitleStyleEN.ForeColor = objRow[conTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objTitleStyleEN.FontSize = objRow[conTitleStyle.FontSize] == DBNull.Value ? null : objRow[conTitleStyle.FontSize].ToString().Trim(); //字号
objTitleStyleEN.FontName = objRow[conTitleStyle.FontName] == DBNull.Value ? null : objRow[conTitleStyle.FontName].ToString().Trim(); //字体
objTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conTitleStyle.IsDefault].ToString().Trim()); //是否默认
objTitleStyleEN.TitleTypeId = objRow[conTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
objTitleStyleEN.UpdDate = objRow[conTitleStyle.UpdDate] == DBNull.Value ? null : objRow[conTitleStyle.UpdDate].ToString().Trim(); //修改日期
objTitleStyleEN.UpdUserId = objRow[conTitleStyle.UpdUserId] == DBNull.Value ? null : objRow[conTitleStyle.UpdUserId].ToString().Trim(); //修改用户Id
objTitleStyleEN.Memo = objRow[conTitleStyle.Memo] == DBNull.Value ? null : objRow[conTitleStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTitleStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTitleStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTitleStyle(ref clsTitleStyleEN objTitleStyleEN)
{
bool bolResult = TitleStyleDA.GetTitleStyle(ref objTitleStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
if (strTitleStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTitleStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTitleStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTitleStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTitleStyleEN objTitleStyleEN = TitleStyleDA.GetObjByTitleStyleId(strTitleStyleId);
return objTitleStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTitleStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTitleStyleEN objTitleStyleEN = TitleStyleDA.GetFirstObj(strWhereCond);
 return objTitleStyleEN;
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
public static clsTitleStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTitleStyleEN objTitleStyleEN = TitleStyleDA.GetObjByDataRow(objRow);
 return objTitleStyleEN;
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
public static clsTitleStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTitleStyleEN objTitleStyleEN = TitleStyleDA.GetObjByDataRow(objRow);
 return objTitleStyleEN;
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
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <param name = "lstTitleStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTitleStyleEN GetObjByTitleStyleIdFromList(string strTitleStyleId, List<clsTitleStyleEN> lstTitleStyleObjLst)
{
foreach (clsTitleStyleEN objTitleStyleEN in lstTitleStyleObjLst)
{
if (objTitleStyleEN.TitleStyleId == strTitleStyleId)
{
return objTitleStyleEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxTitleStyleId;
 try
 {
 strMaxTitleStyleId = new clsTitleStyleDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxTitleStyleId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strTitleStyleId;
 try
 {
 strTitleStyleId = new clsTitleStyleDA().GetFirstID(strWhereCond);
 return strTitleStyleId;
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
 arrList = TitleStyleDA.GetID(strWhereCond);
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
bool bolIsExist = TitleStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTitleStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TitleStyleDA.IsExist(strTitleStyleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTitleStyleId">标题类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTitleStyleId, string strOpUser)
{
clsTitleStyleEN objTitleStyleEN = clsTitleStyleBL.GetObjByTitleStyleId(strTitleStyleId);
objTitleStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTitleStyleEN.UpdUserId = strOpUser;
return clsTitleStyleBL.UpdateBySql2(objTitleStyleEN);
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
 bolIsExist = clsTitleStyleDA.IsExistTable();
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
 bolIsExist = TitleStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTitleStyleEN.TitleStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objTitleStyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标题类型名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsTitleStyleBL.AddNewRecordBySql2)", objTitleStyleEN.TitleStyleName,objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TitleStyleDA.AddNewRecordBySQL2(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTitleStyleEN objTitleStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTitleStyleBL.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTitleStyleEN.TitleStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objTitleStyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!标题类型名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsTitleStyleBL.AddNewRecordBySql2WithReturnKey)", objTitleStyleEN.TitleStyleName,objTitleStyleEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = TitleStyleDA.AddNewRecordBySQL2WithReturnKey(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTitleStyleEN objTitleStyleEN)
{
try
{
bool bolResult = TitleStyleDA.Update(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTitleStyleEN objTitleStyleEN)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TitleStyleDA.UpdateBySql2(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleBL.ReFreshCache();

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTitleStyleId)
{
try
{
 clsTitleStyleEN objTitleStyleEN = clsTitleStyleBL.GetObjByTitleStyleId(strTitleStyleId);

if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(objTitleStyleEN.TitleStyleId, objTitleStyleEN.UpdUserId);
}
if (objTitleStyleEN != null)
{
int intRecNum = TitleStyleDA.DelRecord(strTitleStyleId);
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
/// <param name="strTitleStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTitleStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
//删除与表:[TitleStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTitleStyle.TitleStyleId,
//strTitleStyleId);
//        clsTitleStyleBL.DelTitleStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTitleStyleBL.DelRecord(strTitleStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTitleStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTitleStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTitleStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTitleStyleBL.relatedActions != null)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(strTitleStyleId, "UpdRelaTabDate");
}
bool bolResult = TitleStyleDA.DelRecord(strTitleStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTitleStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTitleStyles(List<string> arrTitleStyleIdLst)
{
if (arrTitleStyleIdLst.Count == 0) return 0;
try
{
if (clsTitleStyleBL.relatedActions != null)
{
foreach (var strTitleStyleId in arrTitleStyleIdLst)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(strTitleStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = TitleStyleDA.DelTitleStyle(arrTitleStyleIdLst);
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
public static int DelTitleStylesByCond(string strWhereCond)
{
try
{
if (clsTitleStyleBL.relatedActions != null)
{
List<string> arrTitleStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTitleStyleId in arrTitleStyleId)
{
clsTitleStyleBL.relatedActions.UpdRelaTabDate(strTitleStyleId, "UpdRelaTabDate");
}
}
int intRecNum = TitleStyleDA.DelTitleStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TitleStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTitleStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTitleStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTitleStyleDA.GetSpecSQLObj();
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
//删除与表:[TitleStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTitleStyleBL.DelRecord(strTitleStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTitleStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTitleStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTitleStyleENS">源对象</param>
 /// <param name = "objTitleStyleENT">目标对象</param>
 public static void CopyTo(clsTitleStyleEN objTitleStyleENS, clsTitleStyleEN objTitleStyleENT)
{
try
{
objTitleStyleENT.TitleStyleId = objTitleStyleENS.TitleStyleId; //标题类型Id
objTitleStyleENT.TitleStyleName = objTitleStyleENS.TitleStyleName; //标题类型名
objTitleStyleENT.PrjId = objTitleStyleENS.PrjId; //工程Id
objTitleStyleENT.TabHeight = objTitleStyleENS.TabHeight; //表格高度
objTitleStyleENT.ImgFile = objTitleStyleENS.ImgFile; //图像文件
objTitleStyleENT.BackColor = objTitleStyleENS.BackColor; //背景颜色
objTitleStyleENT.TabWidth = objTitleStyleENS.TabWidth; //表格宽度
objTitleStyleENT.ForeColor = objTitleStyleENS.ForeColor; //前景颜色
objTitleStyleENT.FontSize = objTitleStyleENS.FontSize; //字号
objTitleStyleENT.FontName = objTitleStyleENS.FontName; //字体
objTitleStyleENT.IsDefault = objTitleStyleENS.IsDefault; //是否默认
objTitleStyleENT.TitleTypeId = objTitleStyleENS.TitleTypeId; //标题类型ID
objTitleStyleENT.UpdDate = objTitleStyleENS.UpdDate; //修改日期
objTitleStyleENT.UpdUserId = objTitleStyleENS.UpdUserId; //修改用户Id
objTitleStyleENT.Memo = objTitleStyleENS.Memo; //说明
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
 /// <param name = "objTitleStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsTitleStyleEN objTitleStyleEN)
{
try
{
objTitleStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTitleStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTitleStyle.TitleStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.TitleStyleId = objTitleStyleEN.TitleStyleId; //标题类型Id
}
if (arrFldSet.Contains(conTitleStyle.TitleStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.TitleStyleName = objTitleStyleEN.TitleStyleName; //标题类型名
}
if (arrFldSet.Contains(conTitleStyle.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.PrjId = objTitleStyleEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTitleStyle.TabHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.TabHeight = objTitleStyleEN.TabHeight; //表格高度
}
if (arrFldSet.Contains(conTitleStyle.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.ImgFile = objTitleStyleEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(conTitleStyle.BackColor, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.BackColor = objTitleStyleEN.BackColor; //背景颜色
}
if (arrFldSet.Contains(conTitleStyle.TabWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.TabWidth = objTitleStyleEN.TabWidth; //表格宽度
}
if (arrFldSet.Contains(conTitleStyle.ForeColor, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.ForeColor = objTitleStyleEN.ForeColor; //前景颜色
}
if (arrFldSet.Contains(conTitleStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.FontSize = objTitleStyleEN.FontSize == "[null]" ? null :  objTitleStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conTitleStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.FontName = objTitleStyleEN.FontName == "[null]" ? null :  objTitleStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conTitleStyle.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.IsDefault = objTitleStyleEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(conTitleStyle.TitleTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.TitleTypeId = objTitleStyleEN.TitleTypeId; //标题类型ID
}
if (arrFldSet.Contains(conTitleStyle.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.UpdDate = objTitleStyleEN.UpdDate == "[null]" ? null :  objTitleStyleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTitleStyle.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.UpdUserId = objTitleStyleEN.UpdUserId == "[null]" ? null :  objTitleStyleEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conTitleStyle.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTitleStyleEN.Memo = objTitleStyleEN.Memo == "[null]" ? null :  objTitleStyleEN.Memo; //说明
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
 /// <param name = "objTitleStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsTitleStyleEN objTitleStyleEN)
{
try
{
if (objTitleStyleEN.FontSize == "[null]") objTitleStyleEN.FontSize = null; //字号
if (objTitleStyleEN.FontName == "[null]") objTitleStyleEN.FontName = null; //字体
if (objTitleStyleEN.UpdDate == "[null]") objTitleStyleEN.UpdDate = null; //修改日期
if (objTitleStyleEN.UpdUserId == "[null]") objTitleStyleEN.UpdUserId = null; //修改用户Id
if (objTitleStyleEN.Memo == "[null]") objTitleStyleEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsTitleStyleEN objTitleStyleEN)
{
 TitleStyleDA.CheckPropertyNew(objTitleStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTitleStyleEN objTitleStyleEN)
{
 TitleStyleDA.CheckProperty4Condition(objTitleStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_TitleStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTitleStyle.TitleStyleId); 
List<clsTitleStyleEN> arrObjLst = clsTitleStyleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN()
{
TitleStyleId = "0",
TitleStyleName = "选[标题模式]..."
};
arrObjLst.Insert(0, objTitleStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTitleStyle.TitleStyleId;
objComboBox.DisplayMember = conTitleStyle.TitleStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_TitleStyleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[标题模式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conTitleStyle.TitleStyleId); 
IEnumerable<clsTitleStyleEN> arrObjLst = clsTitleStyleBL.GetObjLst(strCondition);
objDDL.DataValueField = conTitleStyle.TitleStyleId;
objDDL.DataTextField = conTitleStyle.TitleStyleName;
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
public static void BindDdl_TitleStyleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[标题模式]...","0");
List<clsTitleStyleEN> arrTitleStyleObjLst = GetAllTitleStyleObjLstCache(); 
objDDL.DataValueField = conTitleStyle.TitleStyleId;
objDDL.DataTextField = conTitleStyle.TitleStyleName;
objDDL.DataSource = arrTitleStyleObjLst;
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
if (clsTitleStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTitleStyleBL没有刷新缓存机制(clsTitleStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TitleStyleId");
//if (arrTitleStyleObjLstCache == null)
//{
//arrTitleStyleObjLstCache = TitleStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTitleStyleEN GetObjByTitleStyleIdCache(string strTitleStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel =
arrTitleStyleObjLstCache
.Where(x=> x.TitleStyleId == strTitleStyleId 
);
if (arrTitleStyleObjLst_Sel.Count() == 0)
{
   clsTitleStyleEN obj = clsTitleStyleBL.GetObjByTitleStyleId(strTitleStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTitleStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTitleStyleNameByTitleStyleIdCache(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return "";
//获取缓存中的对象列表
clsTitleStyleEN objTitleStyle = GetObjByTitleStyleIdCache(strTitleStyleId);
if (objTitleStyle == null) return "";
return objTitleStyle.TitleStyleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTitleStyleIdCache(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return "";
//获取缓存中的对象列表
clsTitleStyleEN objTitleStyle = GetObjByTitleStyleIdCache(strTitleStyleId);
if (objTitleStyle == null) return "";
return objTitleStyle.TitleStyleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTitleStyleEN> GetAllTitleStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache(); 
return arrTitleStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTitleStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
List<clsTitleStyleEN> arrTitleStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTitleStyleObjLstCache;
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
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTitleStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTitleStyleEN._RefreshTimeLst.Count == 0) return "";
return clsTitleStyleEN._RefreshTimeLst[clsTitleStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsTitleStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTitleStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTitleStyleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TitleStyle(标题模式)
 /// 唯一性条件:TitleStyleName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTitleStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTitleStyleEN objTitleStyleEN)
{
//检测记录是否存在
string strResult = TitleStyleDA.GetUniCondStr(objTitleStyleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTitleStyleId)
{
if (strInFldName != conTitleStyle.TitleStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTitleStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTitleStyle._AttributeName));
throw new Exception(strMsg);
}
var objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(strTitleStyleId);
if (objTitleStyle == null) return "";
return objTitleStyle[strOutFldName].ToString();
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
int intRecCount = clsTitleStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsTitleStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTitleStyleDA.GetRecCount();
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
int intRecCount = clsTitleStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTitleStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTitleStyleEN objTitleStyleCond)
{
List<clsTitleStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTitleStyle._AttributeName)
{
if (objTitleStyleCond.IsUpdated(strFldName) == false) continue;
if (objTitleStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTitleStyleCond[strFldName].ToString());
}
else
{
if (objTitleStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTitleStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTitleStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTitleStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTitleStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTitleStyleCond[strFldName]));
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
 List<string> arrList = clsTitleStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TitleStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TitleStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TitleStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTitleStyleDA.SetFldValue(clsTitleStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TitleStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTitleStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTitleStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTitleStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TitleStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**标题类型Id*/ 
 strCreateTabCode.Append(" TitleStyleId varchar(8) primary key, "); 
 // /**标题类型名*/ 
 strCreateTabCode.Append(" TitleStyleName varchar(20) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**表格高度*/ 
 strCreateTabCode.Append(" TabHeight int not Null, "); 
 // /**图像文件*/ 
 strCreateTabCode.Append(" ImgFile varchar(200) not Null, "); 
 // /**背景颜色*/ 
 strCreateTabCode.Append(" BackColor varchar(30) not Null, "); 
 // /**表格宽度*/ 
 strCreateTabCode.Append(" TabWidth int not Null, "); 
 // /**前景颜色*/ 
 strCreateTabCode.Append(" ForeColor varchar(30) not Null, "); 
 // /**字号*/ 
 strCreateTabCode.Append(" FontSize varchar(20) Null, "); 
 // /**字体*/ 
 strCreateTabCode.Append(" FontName varchar(20) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null, "); 
 // /**标题类型ID*/ 
 strCreateTabCode.Append(" TitleTypeId varchar(2) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 标题模式(TitleStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TitleStyle : clsCommFun4BL
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
clsTitleStyleBL.ReFreshThisCache();
}
}

}