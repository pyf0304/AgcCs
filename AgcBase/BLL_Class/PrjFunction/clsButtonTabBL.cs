
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonTabBL
 表名:ButtonTab(00050427)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsButtonTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strButtonId">表关键字</param>
 /// <returns>表对象</returns>
public static clsButtonTabEN GetObj(this K_ButtonId_ButtonTab myKey)
{
clsButtonTabEN objButtonTabEN = clsButtonTabBL.ButtonTabDA.GetObjByButtonId(myKey.Value);
return objButtonTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objButtonTabEN) == false)
{
var strMsg = string.Format("记录已经存在!按钮名称 = [{0}]的数据已经存在!(in clsButtonTabBL.AddNewRecord)", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
bool bolResult = clsButtonTabBL.ButtonTabDA.AddNewRecordBySQL2(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
public static bool AddRecordEx(this clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsButtonTabBL.IsExist(objButtonTabEN.ButtonId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objButtonTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objButtonTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(按钮名称(ButtonName)=[{0}])已经存在,不能重复!", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objButtonTabEN.AddNewRecord();
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objButtonTabEN) == false)
{
var strMsg = string.Format("记录已经存在!按钮名称 = [{0}]的数据已经存在!(in clsButtonTabBL.AddNewRecordWithMaxId)", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
string strButtonId = clsButtonTabBL.ButtonTabDA.AddNewRecordBySQL2WithReturnKey(objButtonTabEN);
     objButtonTabEN.ButtonId = strButtonId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
}
return strButtonId;
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objButtonTabEN) == false)
{
var strMsg = string.Format("记录已经存在!按钮名称 = [{0}]的数据已经存在!(in clsButtonTabBL.AddNewRecordWithReturnKey)", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
string strKey = clsButtonTabBL.ButtonTabDA.AddNewRecordBySQL2WithReturnKey(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetButtonId(this clsButtonTabEN objButtonTabEN, string strButtonId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonId, 2, conButtonTab.ButtonId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strButtonId, 2, conButtonTab.ButtonId);
}
objButtonTabEN.ButtonId = strButtonId; //按钮Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ButtonId) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ButtonId, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ButtonId] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetButtonName(this clsButtonTabEN objButtonTabEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, conButtonTab.ButtonName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, conButtonTab.ButtonName);
}
objButtonTabEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ButtonName) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ButtonName, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ButtonName] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetText(this clsButtonTabEN objButtonTabEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, conButtonTab.Text);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, conButtonTab.Text);
}
objButtonTabEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Text) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Text, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Text] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetCommandName(this clsButtonTabEN objButtonTabEN, string strCommandName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommandName, 30, conButtonTab.CommandName);
}
objButtonTabEN.CommandName = strCommandName; //命令名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.CommandName) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.CommandName, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.CommandName] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetHeight(this clsButtonTabEN objButtonTabEN, int? intHeight, string strComparisonOp="")
	{
objButtonTabEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Height) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Height, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Height] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetWidth(this clsButtonTabEN objButtonTabEN, int? intWidth, string strComparisonOp="")
	{
objButtonTabEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Width) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Width, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Width] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetCssClass(this clsButtonTabEN objButtonTabEN, string strCssClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCssClass, 50, conButtonTab.CssClass);
}
objButtonTabEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.CssClass) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.CssClass, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.CssClass] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetImageUrl(this clsButtonTabEN objButtonTabEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conButtonTab.ImageUrl);
}
objButtonTabEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ImageUrl) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ImageUrl, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ImageUrl] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetInUse(this clsButtonTabEN objButtonTabEN, bool bolInUse, string strComparisonOp="")
	{
objButtonTabEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.InUse) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.InUse, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.InUse] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetOrderNum(this clsButtonTabEN objButtonTabEN, int? intOrderNum, string strComparisonOp="")
	{
objButtonTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.OrderNum) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.OrderNum, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.OrderNum] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetUpdUser(this clsButtonTabEN objButtonTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conButtonTab.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conButtonTab.UpdUser);
}
objButtonTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.UpdUser) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.UpdUser, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.UpdUser] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetUpdDate(this clsButtonTabEN objButtonTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conButtonTab.UpdDate);
}
objButtonTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.UpdDate) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.UpdDate, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.UpdDate] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetMemo(this clsButtonTabEN objButtonTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conButtonTab.Memo);
}
objButtonTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Memo) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Memo, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Memo] = strComparisonOp;
}
}
return objButtonTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objButtonTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsButtonTabEN objButtonTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objButtonTabEN.CheckPropertyNew();
clsButtonTabEN objButtonTabCond = new clsButtonTabEN();
string strCondition = objButtonTabCond
.SetButtonId(objButtonTabEN.ButtonId, "<>")
.SetButtonName(objButtonTabEN.ButtonName, "=")
.GetCombineCondition();
objButtonTabEN._IsCheckProperty = true;
bool bolIsExist = clsButtonTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ButtonName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objButtonTabEN.Update();
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
 /// <param name = "objButtonTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsButtonTabEN objButtonTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsButtonTabEN objButtonTabCond = new clsButtonTabEN();
string strCondition = objButtonTabCond
.SetButtonName(objButtonTab.ButtonName, "=")
.GetCombineCondition();
objButtonTab._IsCheckProperty = true;
bool bolIsExist = clsButtonTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objButtonTab.ButtonId = clsButtonTabBL.GetFirstID_S(strCondition);
objButtonTab.UpdateWithCondition(strCondition);
}
else
{
objButtonTab.ButtonId = clsButtonTabBL.GetMaxStrId_S();
objButtonTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsButtonTabEN objButtonTabEN)
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsButtonTabBL.ButtonTabDA.UpdateBySql2(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsButtonTabEN objButtonTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsButtonTabBL.ButtonTabDA.UpdateBySql2(objButtonTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsButtonTabEN objButtonTabEN, string strWhereCond)
{
try
{
bool bolResult = clsButtonTabBL.ButtonTabDA.UpdateBySqlWithCondition(objButtonTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsButtonTabEN objButtonTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsButtonTabBL.ButtonTabDA.UpdateBySqlWithConditionTransaction(objButtonTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsButtonTabEN objButtonTabEN)
{
try
{
int intRecNum = clsButtonTabBL.ButtonTabDA.DelRecord(objButtonTabEN.ButtonId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabENS">源对象</param>
 /// <param name = "objButtonTabENT">目标对象</param>
 public static void CopyTo(this clsButtonTabEN objButtonTabENS, clsButtonTabEN objButtonTabENT)
{
try
{
objButtonTabENT.ButtonId = objButtonTabENS.ButtonId; //按钮Id
objButtonTabENT.ButtonName = objButtonTabENS.ButtonName; //按钮名称
objButtonTabENT.Text = objButtonTabENS.Text; //文本
objButtonTabENT.CommandName = objButtonTabENS.CommandName; //命令名
objButtonTabENT.Height = objButtonTabENS.Height; //高度
objButtonTabENT.Width = objButtonTabENS.Width; //宽
objButtonTabENT.CssClass = objButtonTabENS.CssClass; //样式表
objButtonTabENT.ImageUrl = objButtonTabENS.ImageUrl; //图片资源
objButtonTabENT.InUse = objButtonTabENS.InUse; //是否在用
objButtonTabENT.OrderNum = objButtonTabENS.OrderNum; //序号
objButtonTabENT.UpdUser = objButtonTabENS.UpdUser; //修改者
objButtonTabENT.UpdDate = objButtonTabENS.UpdDate; //修改日期
objButtonTabENT.Memo = objButtonTabENS.Memo; //说明
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
 /// <param name = "objButtonTabENS">源对象</param>
 /// <returns>目标对象=>clsButtonTabEN:objButtonTabENT</returns>
 public static clsButtonTabEN CopyTo(this clsButtonTabEN objButtonTabENS)
{
try
{
 clsButtonTabEN objButtonTabENT = new clsButtonTabEN()
{
ButtonId = objButtonTabENS.ButtonId, //按钮Id
ButtonName = objButtonTabENS.ButtonName, //按钮名称
Text = objButtonTabENS.Text, //文本
CommandName = objButtonTabENS.CommandName, //命令名
Height = objButtonTabENS.Height, //高度
Width = objButtonTabENS.Width, //宽
CssClass = objButtonTabENS.CssClass, //样式表
ImageUrl = objButtonTabENS.ImageUrl, //图片资源
InUse = objButtonTabENS.InUse, //是否在用
OrderNum = objButtonTabENS.OrderNum, //序号
UpdUser = objButtonTabENS.UpdUser, //修改者
UpdDate = objButtonTabENS.UpdDate, //修改日期
Memo = objButtonTabENS.Memo, //说明
};
 return objButtonTabENT;
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
public static void CheckPropertyNew(this clsButtonTabEN objButtonTabEN)
{
 clsButtonTabBL.ButtonTabDA.CheckPropertyNew(objButtonTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsButtonTabEN objButtonTabEN)
{
 clsButtonTabBL.ButtonTabDA.CheckProperty4Condition(objButtonTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsButtonTabEN objButtonTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objButtonTabCond.IsUpdated(conButtonTab.ButtonId) == true)
{
string strComparisonOpButtonId = objButtonTabCond.dicFldComparisonOp[conButtonTab.ButtonId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ButtonId, objButtonTabCond.ButtonId, strComparisonOpButtonId);
}
if (objButtonTabCond.IsUpdated(conButtonTab.ButtonName) == true)
{
string strComparisonOpButtonName = objButtonTabCond.dicFldComparisonOp[conButtonTab.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ButtonName, objButtonTabCond.ButtonName, strComparisonOpButtonName);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Text) == true)
{
string strComparisonOpText = objButtonTabCond.dicFldComparisonOp[conButtonTab.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.Text, objButtonTabCond.Text, strComparisonOpText);
}
if (objButtonTabCond.IsUpdated(conButtonTab.CommandName) == true)
{
string strComparisonOpCommandName = objButtonTabCond.dicFldComparisonOp[conButtonTab.CommandName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.CommandName, objButtonTabCond.CommandName, strComparisonOpCommandName);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Height) == true)
{
string strComparisonOpHeight = objButtonTabCond.dicFldComparisonOp[conButtonTab.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.Height, objButtonTabCond.Height, strComparisonOpHeight);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Width) == true)
{
string strComparisonOpWidth = objButtonTabCond.dicFldComparisonOp[conButtonTab.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.Width, objButtonTabCond.Width, strComparisonOpWidth);
}
if (objButtonTabCond.IsUpdated(conButtonTab.CssClass) == true)
{
string strComparisonOpCssClass = objButtonTabCond.dicFldComparisonOp[conButtonTab.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.CssClass, objButtonTabCond.CssClass, strComparisonOpCssClass);
}
if (objButtonTabCond.IsUpdated(conButtonTab.ImageUrl) == true)
{
string strComparisonOpImageUrl = objButtonTabCond.dicFldComparisonOp[conButtonTab.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ImageUrl, objButtonTabCond.ImageUrl, strComparisonOpImageUrl);
}
if (objButtonTabCond.IsUpdated(conButtonTab.InUse) == true)
{
if (objButtonTabCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conButtonTab.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conButtonTab.InUse);
}
}
if (objButtonTabCond.IsUpdated(conButtonTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objButtonTabCond.dicFldComparisonOp[conButtonTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.OrderNum, objButtonTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objButtonTabCond.IsUpdated(conButtonTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objButtonTabCond.dicFldComparisonOp[conButtonTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.UpdUser, objButtonTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objButtonTabCond.IsUpdated(conButtonTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objButtonTabCond.dicFldComparisonOp[conButtonTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.UpdDate, objButtonTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Memo) == true)
{
string strComparisonOpMemo = objButtonTabCond.dicFldComparisonOp[conButtonTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.Memo, objButtonTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ButtonTab(按钮), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objButtonTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsButtonTabEN objButtonTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objButtonTabEN == null) return true;
if (objButtonTabEN.ButtonId == null || objButtonTabEN.ButtonId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
if (clsButtonTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ButtonId !=  '{0}'", objButtonTabEN.ButtonId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
if (clsButtonTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ButtonTab(按钮), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objButtonTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsButtonTabEN objButtonTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objButtonTabEN == null) return "";
if (objButtonTabEN.ButtonId == null || objButtonTabEN.ButtonId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ButtonId !=  '{0}'", objButtonTabEN.ButtonId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ButtonTab
{
public virtual bool UpdRelaTabDate(string strButtonId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 按钮(ButtonTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsButtonTabBL
{
public static RelatedActions_ButtonTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsButtonTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsButtonTabDA ButtonTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsButtonTabDA();
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
 public clsButtonTabBL()
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
if (string.IsNullOrEmpty(clsButtonTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsButtonTabEN._ConnectString);
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
public static DataTable GetDataTable_ButtonTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ButtonTabDA.GetDataTable_ButtonTab(strWhereCond);
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
objDT = ButtonTabDA.GetDataTable(strWhereCond);
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
objDT = ButtonTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ButtonTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ButtonTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ButtonTabDA.GetDataTable_Top(objTopPara);
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
objDT = ButtonTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ButtonTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ButtonTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrButtonIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsButtonTabEN> GetObjLstByButtonIdLst(List<string> arrButtonIdLst)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrButtonIdLst, true);
 string strWhereCond = string.Format("ButtonId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrButtonIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsButtonTabEN> GetObjLstByButtonIdLstCache(List<string> arrButtonIdLst)
{
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel =
arrButtonTabObjLstCache
.Where(x => arrButtonIdLst.Contains(x.ButtonId));
return arrButtonTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetObjLst(string strWhereCond)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
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
public static List<clsButtonTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objButtonTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsButtonTabEN> GetSubObjLstCache(clsButtonTabEN objButtonTabCond)
{
List<clsButtonTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conButtonTab._AttributeName)
{
if (objButtonTabCond.IsUpdated(strFldName) == false) continue;
if (objButtonTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objButtonTabCond[strFldName].ToString());
}
else
{
if (objButtonTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objButtonTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objButtonTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objButtonTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objButtonTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objButtonTabCond[strFldName]));
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
public static List<clsButtonTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
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
public static List<clsButtonTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
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
List<clsButtonTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsButtonTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsButtonTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
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
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
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
public static List<clsButtonTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsButtonTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsButtonTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
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
public static List<clsButtonTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsButtonTabEN> arrObjLst = new List<clsButtonTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonTabEN objButtonTabEN = new clsButtonTabEN();
try
{
objButtonTabEN.ButtonId = objRow[conButtonTab.ButtonId].ToString().Trim(); //按钮Id
objButtonTabEN.ButtonName = objRow[conButtonTab.ButtonName].ToString().Trim(); //按钮名称
objButtonTabEN.Text = objRow[conButtonTab.Text].ToString().Trim(); //文本
objButtonTabEN.CommandName = objRow[conButtonTab.CommandName] == DBNull.Value ? null : objRow[conButtonTab.CommandName].ToString().Trim(); //命令名
objButtonTabEN.Height = objRow[conButtonTab.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Height].ToString().Trim()); //高度
objButtonTabEN.Width = objRow[conButtonTab.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.Width].ToString().Trim()); //宽
objButtonTabEN.CssClass = objRow[conButtonTab.CssClass] == DBNull.Value ? null : objRow[conButtonTab.CssClass].ToString().Trim(); //样式表
objButtonTabEN.ImageUrl = objRow[conButtonTab.ImageUrl] == DBNull.Value ? null : objRow[conButtonTab.ImageUrl].ToString().Trim(); //图片资源
objButtonTabEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conButtonTab.InUse].ToString().Trim()); //是否在用
objButtonTabEN.OrderNum = objRow[conButtonTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conButtonTab.OrderNum].ToString().Trim()); //序号
objButtonTabEN.UpdUser = objRow[conButtonTab.UpdUser].ToString().Trim(); //修改者
objButtonTabEN.UpdDate = objRow[conButtonTab.UpdDate] == DBNull.Value ? null : objRow[conButtonTab.UpdDate].ToString().Trim(); //修改日期
objButtonTabEN.Memo = objRow[conButtonTab.Memo] == DBNull.Value ? null : objRow[conButtonTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objButtonTabEN.ButtonId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objButtonTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objButtonTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetButtonTab(ref clsButtonTabEN objButtonTabEN)
{
bool bolResult = ButtonTabDA.GetButtonTab(ref objButtonTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strButtonId">表关键字</param>
 /// <returns>表对象</returns>
public static clsButtonTabEN GetObjByButtonId(string strButtonId)
{
if (strButtonId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strButtonId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strButtonId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strButtonId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsButtonTabEN objButtonTabEN = ButtonTabDA.GetObjByButtonId(strButtonId);
return objButtonTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsButtonTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsButtonTabEN objButtonTabEN = ButtonTabDA.GetFirstObj(strWhereCond);
 return objButtonTabEN;
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
public static clsButtonTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsButtonTabEN objButtonTabEN = ButtonTabDA.GetObjByDataRow(objRow);
 return objButtonTabEN;
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
public static clsButtonTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsButtonTabEN objButtonTabEN = ButtonTabDA.GetObjByDataRow(objRow);
 return objButtonTabEN;
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
 /// <param name = "strButtonId">所给的关键字</param>
 /// <param name = "lstButtonTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsButtonTabEN GetObjByButtonIdFromList(string strButtonId, List<clsButtonTabEN> lstButtonTabObjLst)
{
foreach (clsButtonTabEN objButtonTabEN in lstButtonTabObjLst)
{
if (objButtonTabEN.ButtonId == strButtonId)
{
return objButtonTabEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxButtonId;
 try
 {
 strMaxButtonId = clsButtonTabDA.GetMaxStrId();
 return strMaxButtonId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
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
 string strButtonId;
 try
 {
 strButtonId = new clsButtonTabDA().GetFirstID(strWhereCond);
 return strButtonId;
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
 arrList = ButtonTabDA.GetID(strWhereCond);
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
bool bolIsExist = ButtonTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strButtonId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ButtonTabDA.IsExist(strButtonId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strButtonId">按钮Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strButtonId, string strOpUser)
{
clsButtonTabEN objButtonTabEN = clsButtonTabBL.GetObjByButtonId(strButtonId);
objButtonTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objButtonTabEN.UpdUser = strOpUser;
return clsButtonTabBL.UpdateBySql2(objButtonTabEN);
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
 bolIsExist = clsButtonTabDA.IsExistTable();
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
 bolIsExist = ButtonTabDA.IsExistTable(strTabName);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objButtonTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!按钮名称 = [{0}]的数据已经存在!(in clsButtonTabBL.AddNewRecordBySql2)", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
bool bolResult = ButtonTabDA.AddNewRecordBySQL2(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsButtonTabEN objButtonTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objButtonTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!按钮名称 = [{0}]的数据已经存在!(in clsButtonTabBL.AddNewRecordBySql2WithReturnKey)", objButtonTabEN.ButtonName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabBL.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabBL.GetMaxStrId_S();
 }
string strKey = ButtonTabDA.AddNewRecordBySQL2WithReturnKey(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsButtonTabEN objButtonTabEN)
{
try
{
bool bolResult = ButtonTabDA.Update(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsButtonTabEN objButtonTabEN)
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ButtonTabDA.UpdateBySql2(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabBL.ReFreshCache();

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
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
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strButtonId)
{
try
{
 clsButtonTabEN objButtonTabEN = clsButtonTabBL.GetObjByButtonId(strButtonId);

if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTabEN.ButtonId, objButtonTabEN.UpdUser);
}
if (objButtonTabEN != null)
{
int intRecNum = ButtonTabDA.DelRecord(strButtonId);
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
/// <param name="strButtonId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strButtonId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsButtonTabDA.GetSpecSQLObj();
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
//删除与表:[ButtonTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conButtonTab.ButtonId,
//strButtonId);
//        clsButtonTabBL.DelButtonTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsButtonTabBL.DelRecord(strButtonId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsButtonTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strButtonId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strButtonId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strButtonId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(strButtonId, "UpdRelaTabDate");
}
bool bolResult = ButtonTabDA.DelRecord(strButtonId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrButtonIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelButtonTabs(List<string> arrButtonIdLst)
{
if (arrButtonIdLst.Count == 0) return 0;
try
{
if (clsButtonTabBL.relatedActions != null)
{
foreach (var strButtonId in arrButtonIdLst)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(strButtonId, "UpdRelaTabDate");
}
}
int intDelRecNum = ButtonTabDA.DelButtonTab(arrButtonIdLst);
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
public static int DelButtonTabsByCond(string strWhereCond)
{
try
{
if (clsButtonTabBL.relatedActions != null)
{
List<string> arrButtonId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strButtonId in arrButtonId)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(strButtonId, "UpdRelaTabDate");
}
}
int intRecNum = ButtonTabDA.DelButtonTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ButtonTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strButtonId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strButtonId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsButtonTabDA.GetSpecSQLObj();
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
//删除与表:[ButtonTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsButtonTabBL.DelRecord(strButtonId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsButtonTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strButtonId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objButtonTabENS">源对象</param>
 /// <param name = "objButtonTabENT">目标对象</param>
 public static void CopyTo(clsButtonTabEN objButtonTabENS, clsButtonTabEN objButtonTabENT)
{
try
{
objButtonTabENT.ButtonId = objButtonTabENS.ButtonId; //按钮Id
objButtonTabENT.ButtonName = objButtonTabENS.ButtonName; //按钮名称
objButtonTabENT.Text = objButtonTabENS.Text; //文本
objButtonTabENT.CommandName = objButtonTabENS.CommandName; //命令名
objButtonTabENT.Height = objButtonTabENS.Height; //高度
objButtonTabENT.Width = objButtonTabENS.Width; //宽
objButtonTabENT.CssClass = objButtonTabENS.CssClass; //样式表
objButtonTabENT.ImageUrl = objButtonTabENS.ImageUrl; //图片资源
objButtonTabENT.InUse = objButtonTabENS.InUse; //是否在用
objButtonTabENT.OrderNum = objButtonTabENS.OrderNum; //序号
objButtonTabENT.UpdUser = objButtonTabENS.UpdUser; //修改者
objButtonTabENT.UpdDate = objButtonTabENS.UpdDate; //修改日期
objButtonTabENT.Memo = objButtonTabENS.Memo; //说明
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
 /// <param name = "objButtonTabEN">源简化对象</param>
 public static void SetUpdFlag(clsButtonTabEN objButtonTabEN)
{
try
{
objButtonTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objButtonTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conButtonTab.ButtonId, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.ButtonId = objButtonTabEN.ButtonId; //按钮Id
}
if (arrFldSet.Contains(conButtonTab.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.ButtonName = objButtonTabEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(conButtonTab.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.Text = objButtonTabEN.Text; //文本
}
if (arrFldSet.Contains(conButtonTab.CommandName, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.CommandName = objButtonTabEN.CommandName == "[null]" ? null :  objButtonTabEN.CommandName; //命令名
}
if (arrFldSet.Contains(conButtonTab.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.Height = objButtonTabEN.Height; //高度
}
if (arrFldSet.Contains(conButtonTab.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.Width = objButtonTabEN.Width; //宽
}
if (arrFldSet.Contains(conButtonTab.CssClass, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.CssClass = objButtonTabEN.CssClass == "[null]" ? null :  objButtonTabEN.CssClass; //样式表
}
if (arrFldSet.Contains(conButtonTab.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.ImageUrl = objButtonTabEN.ImageUrl == "[null]" ? null :  objButtonTabEN.ImageUrl; //图片资源
}
if (arrFldSet.Contains(conButtonTab.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.InUse = objButtonTabEN.InUse; //是否在用
}
if (arrFldSet.Contains(conButtonTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.OrderNum = objButtonTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conButtonTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.UpdUser = objButtonTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conButtonTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.UpdDate = objButtonTabEN.UpdDate == "[null]" ? null :  objButtonTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conButtonTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objButtonTabEN.Memo = objButtonTabEN.Memo == "[null]" ? null :  objButtonTabEN.Memo; //说明
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
 /// <param name = "objButtonTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsButtonTabEN objButtonTabEN)
{
try
{
if (objButtonTabEN.CommandName == "[null]") objButtonTabEN.CommandName = null; //命令名
if (objButtonTabEN.CssClass == "[null]") objButtonTabEN.CssClass = null; //样式表
if (objButtonTabEN.ImageUrl == "[null]") objButtonTabEN.ImageUrl = null; //图片资源
if (objButtonTabEN.UpdDate == "[null]") objButtonTabEN.UpdDate = null; //修改日期
if (objButtonTabEN.Memo == "[null]") objButtonTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsButtonTabEN objButtonTabEN)
{
 ButtonTabDA.CheckPropertyNew(objButtonTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsButtonTabEN objButtonTabEN)
{
 ButtonTabDA.CheckProperty4Condition(objButtonTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ButtonId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conButtonTab.ButtonId); 
List<clsButtonTabEN> arrObjLst = clsButtonTabBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsButtonTabEN objButtonTabEN = new clsButtonTabEN()
{
ButtonId = "0",
ButtonName = "选[按钮]..."
};
arrObjLst.Insert(0, objButtonTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conButtonTab.ButtonId;
objComboBox.DisplayMember = conButtonTab.ButtonName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ButtonId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[按钮]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conButtonTab.ButtonId); 
IEnumerable<clsButtonTabEN> arrObjLst = clsButtonTabBL.GetObjLst(strCondition);
objDDL.DataValueField = conButtonTab.ButtonId;
objDDL.DataTextField = conButtonTab.ButtonName;
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
public static void BindDdl_ButtonIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[按钮]...","0");
List<clsButtonTabEN> arrButtonTabObjLst = GetAllButtonTabObjLstCache(); 
arrButtonTabObjLst = arrButtonTabObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conButtonTab.ButtonId;
objDDL.DataTextField = conButtonTab.ButtonName;
objDDL.DataSource = arrButtonTabObjLst;
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
if (clsButtonTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsButtonTabBL没有刷新缓存机制(clsButtonTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ButtonId");
//if (arrButtonTabObjLstCache == null)
//{
//arrButtonTabObjLstCache = ButtonTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsButtonTabEN GetObjByButtonIdCache(string strButtonId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel =
arrButtonTabObjLstCache
.Where(x=> x.ButtonId == strButtonId 
);
if (arrButtonTabObjLst_Sel.Count() == 0)
{
   clsButtonTabEN obj = clsButtonTabBL.GetObjByButtonId(strButtonId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrButtonTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetButtonNameByButtonIdCache(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return "";
//获取缓存中的对象列表
clsButtonTabEN objButtonTab = GetObjByButtonIdCache(strButtonId);
if (objButtonTab == null) return "";
return objButtonTab.ButtonName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByButtonIdCache(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return "";
//获取缓存中的对象列表
clsButtonTabEN objButtonTab = GetObjByButtonIdCache(strButtonId);
if (objButtonTab == null) return "";
return objButtonTab.ButtonName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsButtonTabEN> GetAllButtonTabObjLstCache()
{
//获取缓存中的对象列表
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache(); 
return arrButtonTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsButtonTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
List<clsButtonTabEN> arrButtonTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrButtonTabObjLstCache;
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
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsButtonTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsButtonTabEN._RefreshTimeLst.Count == 0) return "";
return clsButtonTabEN._RefreshTimeLst[clsButtonTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsButtonTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsButtonTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsButtonTabBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ButtonTab(按钮)
 /// 唯一性条件:ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objButtonTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsButtonTabEN objButtonTabEN)
{
//检测记录是否存在
string strResult = ButtonTabDA.GetUniCondStr(objButtonTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strButtonId)
{
if (strInFldName != conButtonTab.ButtonId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conButtonTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conButtonTab._AttributeName));
throw new Exception(strMsg);
}
var objButtonTab = clsButtonTabBL.GetObjByButtonIdCache(strButtonId);
if (objButtonTab == null) return "";
return objButtonTab[strOutFldName].ToString();
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
int intRecCount = clsButtonTabDA.GetRecCount(strTabName);
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
int intRecCount = clsButtonTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsButtonTabDA.GetRecCount();
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
int intRecCount = clsButtonTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objButtonTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsButtonTabEN objButtonTabCond)
{
List<clsButtonTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conButtonTab._AttributeName)
{
if (objButtonTabCond.IsUpdated(strFldName) == false) continue;
if (objButtonTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objButtonTabCond[strFldName].ToString());
}
else
{
if (objButtonTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objButtonTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objButtonTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objButtonTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objButtonTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objButtonTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objButtonTabCond[strFldName]));
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
 List<string> arrList = clsButtonTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ButtonTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ButtonTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ButtonTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsButtonTabDA.SetFldValue(clsButtonTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ButtonTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsButtonTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsButtonTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsButtonTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ButtonTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**按钮Id*/ 
 strCreateTabCode.Append(" ButtonId char(2) primary key, "); 
 // /**按钮名称*/ 
 strCreateTabCode.Append(" ButtonName varchar(30) not Null, "); 
 // /**文本*/ 
 strCreateTabCode.Append(" Text varchar(30) not Null, "); 
 // /**命令名*/ 
 strCreateTabCode.Append(" CommandName varchar(30) Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**样式表*/ 
 strCreateTabCode.Append(" CssClass varchar(50) Null, "); 
 // /**图片资源*/ 
 strCreateTabCode.Append(" ImageUrl varchar(100) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**关键字Id*/ 
 strCreateTabCode.Append(" KeyId varchar(8) not Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) not Null, "); 
 // /**功能的次序*/ 
 strCreateTabCode.Append(" OrderNum4Feature int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conButtonTab.OrderNum); 
List<clsButtonTabEN> arrButtonTabObjList = new clsButtonTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsButtonTabEN objButtonTab in arrButtonTabObjList)
{
objButtonTab.OrderNum = intIndex;
UpdateBySql2(objButtonTab);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strButtonId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strButtonId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[ButtonId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字ButtonId
//5、把当前关键字ButtonId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字ButtonId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevButtonId = "";    //上一条序号的关键字ButtonId
string strNextButtonId = "";    //下一条序号的关键字ButtonId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[ButtonId],获取相应的序号[OrderNum]。

clsButtonTabEN objButtonTab = clsButtonTabBL.GetObjByButtonId(strButtonId);

intOrderNum = objButtonTab.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsButtonTabBL.GetRecCountByCond(clsButtonTabEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conButtonTab.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字ButtonId
strPrevButtonId = clsButtonTabBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevButtonId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字ButtonId所对应记录的序号减1
//6、把下(上)一个序号关键字ButtonId所对应的记录序号加1
clsButtonTabBL.SetFldValue(clsButtonTabEN._CurrTabName, conButtonTab.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conButtonTab.ButtonId, strButtonId));
clsButtonTabBL.SetFldValue(clsButtonTabEN._CurrTabName, conButtonTab.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conButtonTab.ButtonId, strPrevButtonId));
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

//4、获取下一个序号字段的关键字ButtonId
strCondition.AppendFormat(" {0} = {1}", conButtonTab.OrderNum, intOrderNum + 1);

strNextButtonId = clsButtonTabBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextButtonId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字ButtonId所对应记录的序号加1
//6、把下(上)一个序号关键字ButtonId所对应的记录序号减1
clsButtonTabBL.SetFldValue(clsButtonTabEN._CurrTabName, conButtonTab.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conButtonTab.ButtonId, strButtonId));
clsButtonTabBL.SetFldValue(clsButtonTabEN._CurrTabName, conButtonTab.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conButtonTab.ButtonId, strNextButtonId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsButtonTabBL.ReFreshCache();
if (clsButtonTabBL.relatedActions != null)
{
clsButtonTabBL.relatedActions.UpdRelaTabDate(objButtonTab.ButtonId, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conButtonTab.ButtonId, strKeyList);
List<clsButtonTabEN> arrButtonTabLst = GetObjLst(strCondition);
foreach (clsButtonTabEN objButtonTab in arrButtonTabLst)
{
objButtonTab.OrderNum = objButtonTab.OrderNum + 10000;
UpdateBySql2(objButtonTab);
}
strCondition = string.Format("1 = 1 order by {0} ", conButtonTab.OrderNum); 
List<clsButtonTabEN> arrButtonTabObjList = new clsButtonTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsButtonTabEN objButtonTab in arrButtonTabObjList)
{
objButtonTab.OrderNum = intIndex;
UpdateBySql2(objButtonTab);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conButtonTab.ButtonId, strKeyList);
List<clsButtonTabEN> arrButtonTabLst = GetObjLst(strCondition);
foreach (clsButtonTabEN objButtonTab in arrButtonTabLst)
{
objButtonTab.OrderNum = objButtonTab.OrderNum - 10000;
UpdateBySql2(objButtonTab);
}
strCondition = string.Format("1 = 1 order by {0} ", conButtonTab.OrderNum); 
List<clsButtonTabEN> arrButtonTabObjList = new clsButtonTabDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsButtonTabEN objButtonTab in arrButtonTabObjList)
{
objButtonTab.OrderNum = intIndex;
UpdateBySql2(objButtonTab);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 按钮(ButtonTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ButtonTab : clsCommFun4BL
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
clsButtonTabBL.ReFreshThisCache();
}
}

}