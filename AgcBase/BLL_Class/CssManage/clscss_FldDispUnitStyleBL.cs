
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_FldDispUnitStyleBL
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
public static class  clscss_FldDispUnitStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_FldDispUnitStyleEN GetObj(this K_FldDispUnitStyleId_css_FldDispUnitStyle myKey)
{
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.GetObjByFldDispUnitStyleId(myKey.Value);
return objcss_FldDispUnitStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_FldDispUnitStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!字段显示单元样式名称 = [{0}],控件类型号 = [{1}]的数据已经存在!(in clscss_FldDispUnitStyleBL.AddNewRecord)", objcss_FldDispUnitStyleEN.FldDispUnitStyleName,objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
bool bolResult = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.AddNewRecordBySQL2(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
public static bool AddRecordEx(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcss_FldDispUnitStyleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcss_FldDispUnitStyleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字段显示单元样式名称(FldDispUnitStyleName)=[{0}],控件类型号(CtlTypeId)=[{1}])已经存在,不能重复!", objcss_FldDispUnitStyleEN.FldDispUnitStyleName, objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcss_FldDispUnitStyleEN.AddNewRecord();
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_FldDispUnitStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!字段显示单元样式名称 = [{0}],控件类型号 = [{1}]的数据已经存在!(in clscss_FldDispUnitStyleBL.AddNewRecordWithMaxId)", objcss_FldDispUnitStyleEN.FldDispUnitStyleName,objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
string strFldDispUnitStyleId = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.AddNewRecordBySQL2WithReturnKey(objcss_FldDispUnitStyleEN);
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = strFldDispUnitStyleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
}
return strFldDispUnitStyleId;
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_FldDispUnitStyleEN) == false)
{
var strMsg = string.Format("记录已经存在!字段显示单元样式名称 = [{0}],控件类型号 = [{1}]的数据已经存在!(in clscss_FldDispUnitStyleBL.AddNewRecordWithReturnKey)", objcss_FldDispUnitStyleEN.FldDispUnitStyleName,objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
string strKey = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.AddNewRecordBySQL2WithReturnKey(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
}
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = strFldDispUnitStyleId; //字段显示单元样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleId) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleId, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleId] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleName(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleName, 50, concss_FldDispUnitStyle.FldDispUnitStyleName);
}
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = strFldDispUnitStyleName; //字段显示单元样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleName) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleName, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleName] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleDesc(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleDesc, 1000, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
}
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = strFldDispUnitStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleDesc) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetStyleIdContent(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strStyleIdContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
}
objcss_FldDispUnitStyleEN.StyleIdContent = strStyleIdContent; //内容样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.StyleIdContent) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.StyleIdContent, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdContent] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetStyleIdTitle(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strStyleIdTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
}
objcss_FldDispUnitStyleEN.StyleIdTitle = strStyleIdTitle; //标题样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.StyleIdTitle) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.StyleIdTitle, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdTitle] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleContent(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleContent, 1000, concss_FldDispUnitStyle.FldDispUnitStyleContent);
}
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = strFldDispUnitStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleContent) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleContent] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitFormat(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldDispUnitFormat, 1000, concss_FldDispUnitStyle.FldDispUnitFormat);
}
objcss_FldDispUnitStyleEN.FldDispUnitFormat = strFldDispUnitFormat; //字段显示单元格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitFormat) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitFormat, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitFormat] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetCtlTypeId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, concss_FldDispUnitStyle.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
}
objcss_FldDispUnitStyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.CtlTypeId) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.CtlTypeId, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.CtlTypeId] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetOrderNum(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, int? intOrderNum, string strComparisonOp="")
	{
objcss_FldDispUnitStyleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.OrderNum) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.OrderNum, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.OrderNum] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetDeletedDate(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_FldDispUnitStyle.DeletedDate);
}
objcss_FldDispUnitStyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.DeletedDate) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.DeletedDate, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.DeletedDate] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetIsDeleted(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objcss_FldDispUnitStyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.IsDeleted) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.IsDeleted, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.IsDeleted] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetUpdDate(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_FldDispUnitStyle.UpdDate);
}
objcss_FldDispUnitStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.UpdDate) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.UpdDate, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.UpdDate] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetUpdUser(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_FldDispUnitStyle.UpdUser);
}
objcss_FldDispUnitStyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.UpdUser) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.UpdUser, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.UpdUser] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetMemo(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_FldDispUnitStyle.Memo);
}
objcss_FldDispUnitStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.Memo) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.Memo, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.Memo] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcss_FldDispUnitStyleEN.CheckPropertyNew();
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond = new clscss_FldDispUnitStyleEN();
string strCondition = objcss_FldDispUnitStyleCond
.SetFldDispUnitStyleId(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, "<>")
.SetFldDispUnitStyleName(objcss_FldDispUnitStyleEN.FldDispUnitStyleName, "=")
.SetCtlTypeId(objcss_FldDispUnitStyleEN.CtlTypeId, "=")
.GetCombineCondition();
objcss_FldDispUnitStyleEN._IsCheckProperty = true;
bool bolIsExist = clscss_FldDispUnitStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FldDispUnitStyleName_CtlTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcss_FldDispUnitStyleEN.Update();
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
 /// <param name = "objcss_FldDispUnitStyle">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond = new clscss_FldDispUnitStyleEN();
string strCondition = objcss_FldDispUnitStyleCond
.SetFldDispUnitStyleName(objcss_FldDispUnitStyle.FldDispUnitStyleName, "=")
.SetCtlTypeId(objcss_FldDispUnitStyle.CtlTypeId, "=")
.GetCombineCondition();
objcss_FldDispUnitStyle._IsCheckProperty = true;
bool bolIsExist = clscss_FldDispUnitStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcss_FldDispUnitStyle.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetFirstID_S(strCondition);
objcss_FldDispUnitStyle.UpdateWithCondition(strCondition);
}
else
{
objcss_FldDispUnitStyle.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
objcss_FldDispUnitStyle.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.UpdateBySql2(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.UpdateBySql2(objcss_FldDispUnitStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strWhereCond)
{
try
{
bool bolResult = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.UpdateBySqlWithCondition(objcss_FldDispUnitStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.UpdateBySqlWithConditionTransaction(objcss_FldDispUnitStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
int intRecNum = clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.DelRecord(objcss_FldDispUnitStyleEN.FldDispUnitStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <param name = "objcss_FldDispUnitStyleENT">目标对象</param>
 public static void CopyTo(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS, clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT)
{
try
{
objcss_FldDispUnitStyleENT.FldDispUnitStyleId = objcss_FldDispUnitStyleENS.FldDispUnitStyleId; //字段显示单元样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleName = objcss_FldDispUnitStyleENS.FldDispUnitStyleName; //字段显示单元样式名称
objcss_FldDispUnitStyleENT.FldDispUnitStyleDesc = objcss_FldDispUnitStyleENS.FldDispUnitStyleDesc; //样式描述
objcss_FldDispUnitStyleENT.StyleIdContent = objcss_FldDispUnitStyleENS.StyleIdContent; //内容样式Id
objcss_FldDispUnitStyleENT.StyleIdTitle = objcss_FldDispUnitStyleENS.StyleIdTitle; //标题样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleContent = objcss_FldDispUnitStyleENS.FldDispUnitStyleContent; //样式内容
objcss_FldDispUnitStyleENT.FldDispUnitFormat = objcss_FldDispUnitStyleENS.FldDispUnitFormat; //字段显示单元格式
objcss_FldDispUnitStyleENT.CtlTypeId = objcss_FldDispUnitStyleENS.CtlTypeId; //控件类型号
objcss_FldDispUnitStyleENT.OrderNum = objcss_FldDispUnitStyleENS.OrderNum; //序号
objcss_FldDispUnitStyleENT.DeletedDate = objcss_FldDispUnitStyleENS.DeletedDate; //删除日期
objcss_FldDispUnitStyleENT.IsDeleted = objcss_FldDispUnitStyleENS.IsDeleted; //是否删除
objcss_FldDispUnitStyleENT.UpdDate = objcss_FldDispUnitStyleENS.UpdDate; //修改日期
objcss_FldDispUnitStyleENT.UpdUser = objcss_FldDispUnitStyleENS.UpdUser; //修改者
objcss_FldDispUnitStyleENT.Memo = objcss_FldDispUnitStyleENS.Memo; //说明
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
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <returns>目标对象=>clscss_FldDispUnitStyleEN:objcss_FldDispUnitStyleENT</returns>
 public static clscss_FldDispUnitStyleEN CopyTo(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS)
{
try
{
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT = new clscss_FldDispUnitStyleEN()
{
FldDispUnitStyleId = objcss_FldDispUnitStyleENS.FldDispUnitStyleId, //字段显示单元样式Id
FldDispUnitStyleName = objcss_FldDispUnitStyleENS.FldDispUnitStyleName, //字段显示单元样式名称
FldDispUnitStyleDesc = objcss_FldDispUnitStyleENS.FldDispUnitStyleDesc, //样式描述
StyleIdContent = objcss_FldDispUnitStyleENS.StyleIdContent, //内容样式Id
StyleIdTitle = objcss_FldDispUnitStyleENS.StyleIdTitle, //标题样式Id
FldDispUnitStyleContent = objcss_FldDispUnitStyleENS.FldDispUnitStyleContent, //样式内容
FldDispUnitFormat = objcss_FldDispUnitStyleENS.FldDispUnitFormat, //字段显示单元格式
CtlTypeId = objcss_FldDispUnitStyleENS.CtlTypeId, //控件类型号
OrderNum = objcss_FldDispUnitStyleENS.OrderNum, //序号
DeletedDate = objcss_FldDispUnitStyleENS.DeletedDate, //删除日期
IsDeleted = objcss_FldDispUnitStyleENS.IsDeleted, //是否删除
UpdDate = objcss_FldDispUnitStyleENS.UpdDate, //修改日期
UpdUser = objcss_FldDispUnitStyleENS.UpdUser, //修改者
Memo = objcss_FldDispUnitStyleENS.Memo, //说明
};
 return objcss_FldDispUnitStyleENT;
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
public static void CheckPropertyNew(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.CheckProperty4Condition(objcss_FldDispUnitStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleId) == true)
{
string strComparisonOpFldDispUnitStyleId = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, objcss_FldDispUnitStyleCond.FldDispUnitStyleId, strComparisonOpFldDispUnitStyleId);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName) == true)
{
string strComparisonOpFldDispUnitStyleName = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleName, objcss_FldDispUnitStyleCond.FldDispUnitStyleName, strComparisonOpFldDispUnitStyleName);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc) == true)
{
string strComparisonOpFldDispUnitStyleDesc = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleDesc, objcss_FldDispUnitStyleCond.FldDispUnitStyleDesc, strComparisonOpFldDispUnitStyleDesc);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.StyleIdContent) == true)
{
string strComparisonOpStyleIdContent = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.StyleIdContent, objcss_FldDispUnitStyleCond.StyleIdContent, strComparisonOpStyleIdContent);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle) == true)
{
string strComparisonOpStyleIdTitle = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.StyleIdTitle, objcss_FldDispUnitStyleCond.StyleIdTitle, strComparisonOpStyleIdTitle);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent) == true)
{
string strComparisonOpFldDispUnitStyleContent = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleContent, objcss_FldDispUnitStyleCond.FldDispUnitStyleContent, strComparisonOpFldDispUnitStyleContent);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat) == true)
{
string strComparisonOpFldDispUnitFormat = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitFormat, objcss_FldDispUnitStyleCond.FldDispUnitFormat, strComparisonOpFldDispUnitFormat);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.CtlTypeId, objcss_FldDispUnitStyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.OrderNum) == true)
{
string strComparisonOpOrderNum = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concss_FldDispUnitStyle.OrderNum, objcss_FldDispUnitStyleCond.OrderNum, strComparisonOpOrderNum);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.DeletedDate, objcss_FldDispUnitStyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.IsDeleted) == true)
{
if (objcss_FldDispUnitStyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_FldDispUnitStyle.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_FldDispUnitStyle.IsDeleted);
}
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.UpdDate, objcss_FldDispUnitStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.UpdUser, objcss_FldDispUnitStyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.Memo) == true)
{
string strComparisonOpMemo = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.Memo, objcss_FldDispUnitStyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--css_FldDispUnitStyle(字段显示单元样式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FldDispUnitStyleName_CtlTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcss_FldDispUnitStyleEN == null) return true;
if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId == null || objcss_FldDispUnitStyleEN.FldDispUnitStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
if (clscss_FldDispUnitStyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FldDispUnitStyleId !=  '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleId);
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
if (clscss_FldDispUnitStyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--css_FldDispUnitStyle(字段显示单元样式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldDispUnitStyleName_CtlTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcss_FldDispUnitStyleEN == null) return "";
if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId == null || objcss_FldDispUnitStyleEN.FldDispUnitStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FldDispUnitStyleId !=  '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleId);
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_css_FldDispUnitStyle
{
public virtual bool UpdRelaTabDate(string strFldDispUnitStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscss_FldDispUnitStyleBL
{
public static RelatedActions_css_FldDispUnitStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscss_FldDispUnitStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscss_FldDispUnitStyleDA css_FldDispUnitStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscss_FldDispUnitStyleDA();
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
 public clscss_FldDispUnitStyleBL()
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
if (string.IsNullOrEmpty(clscss_FldDispUnitStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_FldDispUnitStyleEN._ConnectString);
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
public static DataTable GetDataTable_css_FldDispUnitStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = css_FldDispUnitStyleDA.GetDataTable_css_FldDispUnitStyle(strWhereCond);
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
objDT = css_FldDispUnitStyleDA.GetDataTable(strWhereCond);
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
objDT = css_FldDispUnitStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = css_FldDispUnitStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = css_FldDispUnitStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = css_FldDispUnitStyleDA.GetDataTable_Top(objTopPara);
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
objDT = css_FldDispUnitStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = css_FldDispUnitStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = css_FldDispUnitStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstByFldDispUnitStyleIdLst(List<string> arrFldDispUnitStyleIdLst)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldDispUnitStyleIdLst, true);
 string strWhereCond = string.Format("FldDispUnitStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscss_FldDispUnitStyleEN> GetObjLstByFldDispUnitStyleIdLstCache(List<string> arrFldDispUnitStyleIdLst)
{
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel =
arrcss_FldDispUnitStyleObjLstCache
.Where(x => arrFldDispUnitStyleIdLst.Contains(x.FldDispUnitStyleId));
return arrcss_FldDispUnitStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLst(string strWhereCond)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscss_FldDispUnitStyleEN> GetSubObjLstCache(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond)
{
List<clscss_FldDispUnitStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_FldDispUnitStyle._AttributeName)
{
if (objcss_FldDispUnitStyleCond.IsUpdated(strFldName) == false) continue;
if (objcss_FldDispUnitStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_FldDispUnitStyleCond[strFldName].ToString());
}
else
{
if (objcss_FldDispUnitStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_FldDispUnitStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_FldDispUnitStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_FldDispUnitStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_FldDispUnitStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_FldDispUnitStyleCond[strFldName]));
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
List<clscss_FldDispUnitStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscss_FldDispUnitStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscss_FldDispUnitStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
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
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
public static List<clscss_FldDispUnitStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscss_FldDispUnitStyleEN> arrObjLst = new List<clscss_FldDispUnitStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN();
try
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objRow[concss_FldDispUnitStyle.FldDispUnitStyleId].ToString().Trim(); //字段显示单元样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objRow[concss_FldDispUnitStyle.FldDispUnitStyleName].ToString().Trim(); //字段显示单元样式名称
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitStyleDesc].ToString().Trim(); //样式描述
objcss_FldDispUnitStyleEN.StyleIdContent = objRow[concss_FldDispUnitStyle.StyleIdContent] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdContent].ToString().Trim(); //内容样式Id
objcss_FldDispUnitStyleEN.StyleIdTitle = objRow[concss_FldDispUnitStyle.StyleIdTitle] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.StyleIdTitle].ToString().Trim(); //标题样式Id
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objRow[concss_FldDispUnitStyle.FldDispUnitStyleContent].ToString().Trim(); //样式内容
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objRow[concss_FldDispUnitStyle.FldDispUnitFormat] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.FldDispUnitFormat].ToString().Trim(); //字段显示单元格式
objcss_FldDispUnitStyleEN.CtlTypeId = objRow[concss_FldDispUnitStyle.CtlTypeId].ToString().Trim(); //控件类型号
objcss_FldDispUnitStyleEN.OrderNum = objRow[concss_FldDispUnitStyle.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_FldDispUnitStyle.OrderNum].ToString().Trim()); //序号
objcss_FldDispUnitStyleEN.DeletedDate = objRow[concss_FldDispUnitStyle.DeletedDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.DeletedDate].ToString().Trim(); //删除日期
objcss_FldDispUnitStyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_FldDispUnitStyle.IsDeleted].ToString().Trim()); //是否删除
objcss_FldDispUnitStyleEN.UpdDate = objRow[concss_FldDispUnitStyle.UpdDate] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdDate].ToString().Trim(); //修改日期
objcss_FldDispUnitStyleEN.UpdUser = objRow[concss_FldDispUnitStyle.UpdUser] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.UpdUser].ToString().Trim(); //修改者
objcss_FldDispUnitStyleEN.Memo = objRow[concss_FldDispUnitStyle.Memo] == DBNull.Value ? null : objRow[concss_FldDispUnitStyle.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_FldDispUnitStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcss_FldDispUnitStyle(ref clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
bool bolResult = css_FldDispUnitStyleDA.Getcss_FldDispUnitStyle(ref objcss_FldDispUnitStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleId(string strFldDispUnitStyleId)
{
if (strFldDispUnitStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldDispUnitStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldDispUnitStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = css_FldDispUnitStyleDA.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
return objcss_FldDispUnitStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscss_FldDispUnitStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = css_FldDispUnitStyleDA.GetFirstObj(strWhereCond);
 return objcss_FldDispUnitStyleEN;
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
public static clscss_FldDispUnitStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = css_FldDispUnitStyleDA.GetObjByDataRow(objRow);
 return objcss_FldDispUnitStyleEN;
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
public static clscss_FldDispUnitStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = css_FldDispUnitStyleDA.GetObjByDataRow(objRow);
 return objcss_FldDispUnitStyleEN;
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
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <param name = "lstcss_FldDispUnitStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleIdFromList(string strFldDispUnitStyleId, List<clscss_FldDispUnitStyleEN> lstcss_FldDispUnitStyleObjLst)
{
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN in lstcss_FldDispUnitStyleObjLst)
{
if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId == strFldDispUnitStyleId)
{
return objcss_FldDispUnitStyleEN;
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
 string strMaxFldDispUnitStyleId;
 try
 {
 strMaxFldDispUnitStyleId = clscss_FldDispUnitStyleDA.GetMaxStrId();
 return strMaxFldDispUnitStyleId;
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
 string strFldDispUnitStyleId;
 try
 {
 strFldDispUnitStyleId = new clscss_FldDispUnitStyleDA().GetFirstID(strWhereCond);
 return strFldDispUnitStyleId;
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
 arrList = css_FldDispUnitStyleDA.GetID(strWhereCond);
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
bool bolIsExist = css_FldDispUnitStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldDispUnitStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = css_FldDispUnitStyleDA.IsExist(strFldDispUnitStyleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFldDispUnitStyleId">字段显示单元样式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFldDispUnitStyleId, string strOpUser)
{
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
objcss_FldDispUnitStyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcss_FldDispUnitStyleEN.UpdUser = strOpUser;
return clscss_FldDispUnitStyleBL.UpdateBySql2(objcss_FldDispUnitStyleEN);
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
 bolIsExist = clscss_FldDispUnitStyleDA.IsExistTable();
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
 bolIsExist = css_FldDispUnitStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcss_FldDispUnitStyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段显示单元样式名称 = [{0}],控件类型号 = [{1}]的数据已经存在!(in clscss_FldDispUnitStyleBL.AddNewRecordBySql2)", objcss_FldDispUnitStyleEN.FldDispUnitStyleName,objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
bool bolResult = css_FldDispUnitStyleDA.AddNewRecordBySQL2(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcss_FldDispUnitStyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字段显示单元样式名称 = [{0}],控件类型号 = [{1}]的数据已经存在!(in clscss_FldDispUnitStyleBL.AddNewRecordBySql2WithReturnKey)", objcss_FldDispUnitStyleEN.FldDispUnitStyleName,objcss_FldDispUnitStyleEN.CtlTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleBL.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetMaxStrId_S();
 }
string strKey = css_FldDispUnitStyleDA.AddNewRecordBySQL2WithReturnKey(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
bool bolResult = css_FldDispUnitStyleDA.Update(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = css_FldDispUnitStyleDA.UpdateBySql2(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleBL.ReFreshCache();

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
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
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFldDispUnitStyleId)
{
try
{
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);

if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(objcss_FldDispUnitStyleEN.FldDispUnitStyleId, objcss_FldDispUnitStyleEN.UpdUser);
}
if (objcss_FldDispUnitStyleEN != null)
{
int intRecNum = css_FldDispUnitStyleDA.DelRecord(strFldDispUnitStyleId);
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
/// <param name="strFldDispUnitStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFldDispUnitStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
//删除与表:[css_FldDispUnitStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concss_FldDispUnitStyle.FldDispUnitStyleId,
//strFldDispUnitStyleId);
//        clscss_FldDispUnitStyleBL.Delcss_FldDispUnitStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_FldDispUnitStyleBL.DelRecord(strFldDispUnitStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_FldDispUnitStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldDispUnitStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DelRecordBySign)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleId">给定的关键字列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecordBySign(List<string> arrFldDispUnitStyleId)
{
try
{
if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
foreach (var strFldDispUnitStyleId in arrFldDispUnitStyleId)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(strFldDispUnitStyleId, "UpdRelaTabDate");
}
}
int intRecNum_Total = 0;
arrFldDispUnitStyleId.ForEach((x) =>
{
int intRecNum = css_FldDispUnitStyleDA.DelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000077)根据标志删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:恢复被删除的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrFldDispUnitStyleId">给定的关键字列表</param>
 /// <returns>返回恢复删除的记录数</returns>
public static int UnDelRecordBySign(List<string> arrFldDispUnitStyleId)
{
try
{
int intRecNum_Total = 0;
arrFldDispUnitStyleId.ForEach((x) =>
{
int intRecNum = css_FldDispUnitStyleDA.UnDelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
foreach (var strFldDispUnitStyleId in arrFldDispUnitStyleId)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(strFldDispUnitStyleId, "UpdRelaTabDate");
}
}
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000078)恢复被删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFldDispUnitStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(strFldDispUnitStyleId, "UpdRelaTabDate");
}
bool bolResult = css_FldDispUnitStyleDA.DelRecord(strFldDispUnitStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFldDispUnitStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcss_FldDispUnitStyles(List<string> arrFldDispUnitStyleIdLst)
{
if (arrFldDispUnitStyleIdLst.Count == 0) return 0;
try
{
if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
foreach (var strFldDispUnitStyleId in arrFldDispUnitStyleIdLst)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(strFldDispUnitStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = css_FldDispUnitStyleDA.Delcss_FldDispUnitStyle(arrFldDispUnitStyleIdLst);
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
public static int Delcss_FldDispUnitStylesByCond(string strWhereCond)
{
try
{
if (clscss_FldDispUnitStyleBL.relatedActions != null)
{
List<string> arrFldDispUnitStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFldDispUnitStyleId in arrFldDispUnitStyleId)
{
clscss_FldDispUnitStyleBL.relatedActions.UpdRelaTabDate(strFldDispUnitStyleId, "UpdRelaTabDate");
}
}
int intRecNum = css_FldDispUnitStyleDA.Delcss_FldDispUnitStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[css_FldDispUnitStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFldDispUnitStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFldDispUnitStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_FldDispUnitStyleDA.GetSpecSQLObj();
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
//删除与表:[css_FldDispUnitStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_FldDispUnitStyleBL.DelRecord(strFldDispUnitStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_FldDispUnitStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFldDispUnitStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <param name = "objcss_FldDispUnitStyleENT">目标对象</param>
 public static void CopyTo(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS, clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT)
{
try
{
objcss_FldDispUnitStyleENT.FldDispUnitStyleId = objcss_FldDispUnitStyleENS.FldDispUnitStyleId; //字段显示单元样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleName = objcss_FldDispUnitStyleENS.FldDispUnitStyleName; //字段显示单元样式名称
objcss_FldDispUnitStyleENT.FldDispUnitStyleDesc = objcss_FldDispUnitStyleENS.FldDispUnitStyleDesc; //样式描述
objcss_FldDispUnitStyleENT.StyleIdContent = objcss_FldDispUnitStyleENS.StyleIdContent; //内容样式Id
objcss_FldDispUnitStyleENT.StyleIdTitle = objcss_FldDispUnitStyleENS.StyleIdTitle; //标题样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleContent = objcss_FldDispUnitStyleENS.FldDispUnitStyleContent; //样式内容
objcss_FldDispUnitStyleENT.FldDispUnitFormat = objcss_FldDispUnitStyleENS.FldDispUnitFormat; //字段显示单元格式
objcss_FldDispUnitStyleENT.CtlTypeId = objcss_FldDispUnitStyleENS.CtlTypeId; //控件类型号
objcss_FldDispUnitStyleENT.OrderNum = objcss_FldDispUnitStyleENS.OrderNum; //序号
objcss_FldDispUnitStyleENT.DeletedDate = objcss_FldDispUnitStyleENS.DeletedDate; //删除日期
objcss_FldDispUnitStyleENT.IsDeleted = objcss_FldDispUnitStyleENS.IsDeleted; //是否删除
objcss_FldDispUnitStyleENT.UpdDate = objcss_FldDispUnitStyleENS.UpdDate; //修改日期
objcss_FldDispUnitStyleENT.UpdUser = objcss_FldDispUnitStyleENS.UpdUser; //修改者
objcss_FldDispUnitStyleENT.Memo = objcss_FldDispUnitStyleENS.Memo; //说明
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
 /// <param name = "objcss_FldDispUnitStyleEN">源简化对象</param>
 public static void SetUpdFlag(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
objcss_FldDispUnitStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcss_FldDispUnitStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concss_FldDispUnitStyle.FldDispUnitStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = objcss_FldDispUnitStyleEN.FldDispUnitStyleId; //字段显示单元样式Id
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.FldDispUnitStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = objcss_FldDispUnitStyleEN.FldDispUnitStyleName; //字段显示单元样式名称
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.FldDispUnitStyleDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc == "[null]" ? null :  objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc; //样式描述
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.StyleIdContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.StyleIdContent = objcss_FldDispUnitStyleEN.StyleIdContent == "[null]" ? null :  objcss_FldDispUnitStyleEN.StyleIdContent; //内容样式Id
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.StyleIdTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.StyleIdTitle = objcss_FldDispUnitStyleEN.StyleIdTitle == "[null]" ? null :  objcss_FldDispUnitStyleEN.StyleIdTitle; //标题样式Id
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.FldDispUnitStyleContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = objcss_FldDispUnitStyleEN.FldDispUnitStyleContent; //样式内容
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.FldDispUnitFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.FldDispUnitFormat = objcss_FldDispUnitStyleEN.FldDispUnitFormat == "[null]" ? null :  objcss_FldDispUnitStyleEN.FldDispUnitFormat; //字段显示单元格式
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.CtlTypeId = objcss_FldDispUnitStyleEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.OrderNum = objcss_FldDispUnitStyleEN.OrderNum; //序号
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.DeletedDate = objcss_FldDispUnitStyleEN.DeletedDate == "[null]" ? null :  objcss_FldDispUnitStyleEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.IsDeleted = objcss_FldDispUnitStyleEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.UpdDate = objcss_FldDispUnitStyleEN.UpdDate == "[null]" ? null :  objcss_FldDispUnitStyleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.UpdUser = objcss_FldDispUnitStyleEN.UpdUser == "[null]" ? null :  objcss_FldDispUnitStyleEN.UpdUser; //修改者
}
if (arrFldSet.Contains(concss_FldDispUnitStyle.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_FldDispUnitStyleEN.Memo = objcss_FldDispUnitStyleEN.Memo == "[null]" ? null :  objcss_FldDispUnitStyleEN.Memo; //说明
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
 /// <param name = "objcss_FldDispUnitStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
if (objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc == "[null]") objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = null; //样式描述
if (objcss_FldDispUnitStyleEN.StyleIdContent == "[null]") objcss_FldDispUnitStyleEN.StyleIdContent = null; //内容样式Id
if (objcss_FldDispUnitStyleEN.StyleIdTitle == "[null]") objcss_FldDispUnitStyleEN.StyleIdTitle = null; //标题样式Id
if (objcss_FldDispUnitStyleEN.FldDispUnitFormat == "[null]") objcss_FldDispUnitStyleEN.FldDispUnitFormat = null; //字段显示单元格式
if (objcss_FldDispUnitStyleEN.DeletedDate == "[null]") objcss_FldDispUnitStyleEN.DeletedDate = null; //删除日期
if (objcss_FldDispUnitStyleEN.UpdDate == "[null]") objcss_FldDispUnitStyleEN.UpdDate = null; //修改日期
if (objcss_FldDispUnitStyleEN.UpdUser == "[null]") objcss_FldDispUnitStyleEN.UpdUser = null; //修改者
if (objcss_FldDispUnitStyleEN.Memo == "[null]") objcss_FldDispUnitStyleEN.Memo = null; //说明
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
public static void CheckPropertyNew(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 css_FldDispUnitStyleDA.CheckPropertyNew(objcss_FldDispUnitStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 css_FldDispUnitStyleDA.CheckProperty4Condition(objcss_FldDispUnitStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldDispUnitStyleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段显示单元样式]...","0");
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst = GetAllcss_FldDispUnitStyleObjLstCache(); 
arrcss_FldDispUnitStyleObjLst = arrcss_FldDispUnitStyleObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = concss_FldDispUnitStyle.FldDispUnitStyleId;
objDDL.DataTextField = concss_FldDispUnitStyle.FldDispUnitStyleName;
objDDL.DataSource = arrcss_FldDispUnitStyleObjLst;
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
if (clscss_FldDispUnitStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_FldDispUnitStyleBL没有刷新缓存机制(clscss_FldDispUnitStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldDispUnitStyleId");
//if (arrcss_FldDispUnitStyleObjLstCache == null)
//{
//arrcss_FldDispUnitStyleObjLstCache = css_FldDispUnitStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel =
arrcss_FldDispUnitStyleObjLstCache
.Where(x=> x.FldDispUnitStyleId == strFldDispUnitStyleId 
);
if (arrcss_FldDispUnitStyleObjLst_Sel.Count() == 0)
{
   clscss_FldDispUnitStyleEN obj = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcss_FldDispUnitStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldDispUnitStyleNameByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return "";
//获取缓存中的对象列表
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle = GetObjByFldDispUnitStyleIdCache(strFldDispUnitStyleId);
if (objcss_FldDispUnitStyle == null) return "";
return objcss_FldDispUnitStyle.FldDispUnitStyleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return "";
//获取缓存中的对象列表
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle = GetObjByFldDispUnitStyleIdCache(strFldDispUnitStyleId);
if (objcss_FldDispUnitStyle == null) return "";
return objcss_FldDispUnitStyle.FldDispUnitStyleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetAllcss_FldDispUnitStyleObjLstCache()
{
//获取缓存中的对象列表
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache(); 
return arrcss_FldDispUnitStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcss_FldDispUnitStyleObjLstCache;
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
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_FldDispUnitStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscss_FldDispUnitStyleEN._RefreshTimeLst.Count == 0) return "";
return clscss_FldDispUnitStyleEN._RefreshTimeLst[clscss_FldDispUnitStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clscss_FldDispUnitStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_FldDispUnitStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscss_FldDispUnitStyleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--css_FldDispUnitStyle(字段显示单元样式)
 /// 唯一性条件:FldDispUnitStyleName_CtlTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检测记录是否存在
string strResult = css_FldDispUnitStyleDA.GetUniCondStr(objcss_FldDispUnitStyleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFldDispUnitStyleId)
{
if (strInFldName != concss_FldDispUnitStyle.FldDispUnitStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concss_FldDispUnitStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concss_FldDispUnitStyle._AttributeName));
throw new Exception(strMsg);
}
var objcss_FldDispUnitStyle = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleIdCache(strFldDispUnitStyleId);
if (objcss_FldDispUnitStyle == null) return "";
return objcss_FldDispUnitStyle[strOutFldName].ToString();
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
int intRecCount = clscss_FldDispUnitStyleDA.GetRecCount(strTabName);
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
int intRecCount = clscss_FldDispUnitStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscss_FldDispUnitStyleDA.GetRecCount();
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
int intRecCount = clscss_FldDispUnitStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond)
{
List<clscss_FldDispUnitStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_FldDispUnitStyle._AttributeName)
{
if (objcss_FldDispUnitStyleCond.IsUpdated(strFldName) == false) continue;
if (objcss_FldDispUnitStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_FldDispUnitStyleCond[strFldName].ToString());
}
else
{
if (objcss_FldDispUnitStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_FldDispUnitStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_FldDispUnitStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_FldDispUnitStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_FldDispUnitStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_FldDispUnitStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_FldDispUnitStyleCond[strFldName]));
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
 List<string> arrList = clscss_FldDispUnitStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = css_FldDispUnitStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = css_FldDispUnitStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = css_FldDispUnitStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscss_FldDispUnitStyleDA.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = css_FldDispUnitStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscss_FldDispUnitStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscss_FldDispUnitStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscss_FldDispUnitStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[css_FldDispUnitStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字段显示单元样式Id*/ 
 strCreateTabCode.Append(" FldDispUnitStyleId char(8) primary key, "); 
 // /**字段显示单元样式名称*/ 
 strCreateTabCode.Append(" FldDispUnitStyleName varchar(50) not Null, "); 
 // /**样式描述*/ 
 strCreateTabCode.Append(" FldDispUnitStyleDesc varchar(1000) Null, "); 
 // /**内容样式Id*/ 
 strCreateTabCode.Append(" StyleIdContent char(8) Null, "); 
 // /**标题样式Id*/ 
 strCreateTabCode.Append(" StyleIdTitle char(8) Null, "); 
 // /**样式内容*/ 
 strCreateTabCode.Append(" FldDispUnitStyleContent varchar(1000) not Null, "); 
 // /**字段显示单元格式*/ 
 strCreateTabCode.Append(" FldDispUnitFormat varchar(1000) Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" DeletedDate varchar(50) Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDeleted bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) Null, "); 
 // /**内容样式名*/ 
 strCreateTabCode.Append(" StyleNameContent varchar(200) Null, "); 
 // /**标题样式名*/ 
 strCreateTabCode.Append(" StyleNameTitle varchar(200) Null, "); 
 // /**字段显示单元格式-显示*/ 
 strCreateTabCode.Append(" FldDispUnitFormatDisp varchar(1000) Null, "); 
 // /**字段显示单元样式名称*/ 
 strCreateTabCode.Append(" DuFldDispUnitStyleName varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CtlTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCtlTypeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCtlTypeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjList = new clscss_FldDispUnitStyleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle in arrcss_FldDispUnitStyleObjList)
{
objcss_FldDispUnitStyle.OrderNum = intIndex;
UpdateBySql2(objcss_FldDispUnitStyle);
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
/// 调整所给关键字记录的序号。根据分类字段：CtlTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strFldDispUnitStyleId">所给的关键字</param>
/// <param name="strCtlTypeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strFldDispUnitStyleId ,string strCtlTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[FldDispUnitStyleId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字FldDispUnitStyleId
//5、把当前关键字FldDispUnitStyleId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字FldDispUnitStyleId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevFldDispUnitStyleId = "";    //上一条序号的关键字FldDispUnitStyleId
string strNextFldDispUnitStyleId = "";    //下一条序号的关键字FldDispUnitStyleId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[FldDispUnitStyleId],获取相应的序号[OrderNum]。

clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);

intOrderNum = objcss_FldDispUnitStyle.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);
intTabRecNum = clscss_FldDispUnitStyleBL.GetRecCountByCond(clscss_FldDispUnitStyleEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", concss_FldDispUnitStyle.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);
//4、获取上一个序号字段的关键字FldDispUnitStyleId
strPrevFldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevFldDispUnitStyleId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字FldDispUnitStyleId所对应记录的序号减1
//6、把下(上)一个序号关键字FldDispUnitStyleId所对应的记录序号加1
clscss_FldDispUnitStyleBL.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, strFldDispUnitStyleId));
clscss_FldDispUnitStyleBL.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, strPrevFldDispUnitStyleId));
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

//4、获取下一个序号字段的关键字FldDispUnitStyleId
sbCondition.AppendFormat(" {0} = {1} ", concss_FldDispUnitStyle.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);

strNextFldDispUnitStyleId = clscss_FldDispUnitStyleBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextFldDispUnitStyleId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字FldDispUnitStyleId所对应记录的序号加1
//6、把下(上)一个序号关键字FldDispUnitStyleId所对应的记录序号减1
clscss_FldDispUnitStyleBL.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, strFldDispUnitStyleId));
clscss_FldDispUnitStyleBL.SetFldValue(clscss_FldDispUnitStyleEN._CurrTabName, concss_FldDispUnitStyle.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, strNextFldDispUnitStyleId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CtlTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strCtlTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concss_FldDispUnitStyle.FldDispUnitStyleId, strKeyList);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleLst = GetObjLst(strCondition);
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle in arrcss_FldDispUnitStyleLst)
{
objcss_FldDispUnitStyle.OrderNum = objcss_FldDispUnitStyle.OrderNum + 10000;
UpdateBySql2(objcss_FldDispUnitStyle);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjList = new clscss_FldDispUnitStyleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle in arrcss_FldDispUnitStyleObjList)
{
objcss_FldDispUnitStyle.OrderNum = intIndex;
UpdateBySql2(objcss_FldDispUnitStyle);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CtlTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCtlTypeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strCtlTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concss_FldDispUnitStyle.FldDispUnitStyleId, strKeyList);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleLst = GetObjLst(strCondition);
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle in arrcss_FldDispUnitStyleLst)
{
objcss_FldDispUnitStyle.OrderNum = objcss_FldDispUnitStyle.OrderNum - 10000;
UpdateBySql2(objcss_FldDispUnitStyle);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concss_FldDispUnitStyle.CtlTypeId, strCtlTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjList = new clscss_FldDispUnitStyleDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_FldDispUnitStyleEN objcss_FldDispUnitStyle in arrcss_FldDispUnitStyleObjList)
{
objcss_FldDispUnitStyle.OrderNum = intIndex;
UpdateBySql2(objcss_FldDispUnitStyle);
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
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4css_FldDispUnitStyle : clsCommFun4BL
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
clscss_FldDispUnitStyleBL.ReFreshThisCache();
}
}

}