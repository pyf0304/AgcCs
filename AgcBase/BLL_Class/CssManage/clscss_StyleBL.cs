
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_StyleBL
 表名:css_Style(00050468)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clscss_StyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_StyleEN GetObj(this K_StyleId_css_Style myKey)
{
clscss_StyleEN objcss_StyleEN = clscss_StyleBL.css_StyleDA.GetObjByStyleId(myKey.Value);
return objcss_StyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_StyleEN) == false)
{
var strMsg = string.Format("记录已经存在!控件类型号 = [{0}],样式名称 = [{1}]的数据已经存在!(in clscss_StyleBL.AddNewRecord)", objcss_StyleEN.CtlTypeId,objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
bool bolResult = clscss_StyleBL.css_StyleDA.AddNewRecordBySQL2(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
public static bool AddRecordEx(this clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscss_StyleBL.IsExist(objcss_StyleEN.StyleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcss_StyleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcss_StyleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(控件类型号(CtlTypeId)=[{0}],样式名称(StyleName)=[{1}])已经存在,不能重复!", objcss_StyleEN.CtlTypeId, objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcss_StyleEN.AddNewRecord();
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_StyleEN) == false)
{
var strMsg = string.Format("记录已经存在!控件类型号 = [{0}],样式名称 = [{1}]的数据已经存在!(in clscss_StyleBL.AddNewRecordWithMaxId)", objcss_StyleEN.CtlTypeId,objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
string strStyleId = clscss_StyleBL.css_StyleDA.AddNewRecordBySQL2WithReturnKey(objcss_StyleEN);
     objcss_StyleEN.StyleId = strStyleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
}
return strStyleId;
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcss_StyleEN) == false)
{
var strMsg = string.Format("记录已经存在!控件类型号 = [{0}],样式名称 = [{1}]的数据已经存在!(in clscss_StyleBL.AddNewRecordWithReturnKey)", objcss_StyleEN.CtlTypeId,objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
string strKey = clscss_StyleBL.css_StyleDA.AddNewRecordBySQL2WithReturnKey(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleId(this clscss_StyleEN objcss_StyleEN, string strStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleId, 8, concss_Style.StyleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, concss_Style.StyleId);
}
objcss_StyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleId) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleId, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleId] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetCtlTypeId(this clscss_StyleEN objcss_StyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, concss_Style.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, concss_Style.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, concss_Style.CtlTypeId);
}
objcss_StyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.CtlTypeId) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.CtlTypeId, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.CtlTypeId] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleName(this clscss_StyleEN objcss_StyleEN, string strStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleName, 50, concss_Style.StyleName);
}
objcss_StyleEN.StyleName = strStyleName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleName) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleName, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleName] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleDesc(this clscss_StyleEN objcss_StyleEN, string strStyleDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleDesc, 1000, concss_Style.StyleDesc);
}
objcss_StyleEN.StyleDesc = strStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleDesc) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleDesc, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleDesc] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleContent(this clscss_StyleEN objcss_StyleEN, string strStyleContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, concss_Style.StyleContent);
}
objcss_StyleEN.StyleContent = strStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleContent) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleContent, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleContent] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetIsDeleted(this clscss_StyleEN objcss_StyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objcss_StyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.IsDeleted) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.IsDeleted, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.IsDeleted] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetDeletedDate(this clscss_StyleEN objcss_StyleEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_Style.DeletedDate);
}
objcss_StyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.DeletedDate) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.DeletedDate, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.DeletedDate] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetUpdDate(this clscss_StyleEN objcss_StyleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_Style.UpdDate);
}
objcss_StyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.UpdDate) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.UpdDate, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.UpdDate] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetUpdUser(this clscss_StyleEN objcss_StyleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_Style.UpdUser);
}
objcss_StyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.UpdUser) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.UpdUser, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.UpdUser] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetMemo(this clscss_StyleEN objcss_StyleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_Style.Memo);
}
objcss_StyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.Memo) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.Memo, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.Memo] = strComparisonOp;
}
}
return objcss_StyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscss_StyleEN objcss_StyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcss_StyleEN.CheckPropertyNew();
clscss_StyleEN objcss_StyleCond = new clscss_StyleEN();
string strCondition = objcss_StyleCond
.SetStyleId(objcss_StyleEN.StyleId, "<>")
.SetCtlTypeId(objcss_StyleEN.CtlTypeId, "=")
.SetStyleName(objcss_StyleEN.StyleName, "=")
.GetCombineCondition();
objcss_StyleEN._IsCheckProperty = true;
bool bolIsExist = clscss_StyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CtlTypeId_StyleName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcss_StyleEN.Update();
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
 /// <param name = "objcss_Style">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscss_StyleEN objcss_Style)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscss_StyleEN objcss_StyleCond = new clscss_StyleEN();
string strCondition = objcss_StyleCond
.SetCtlTypeId(objcss_Style.CtlTypeId, "=")
.SetStyleName(objcss_Style.StyleName, "=")
.GetCombineCondition();
objcss_Style._IsCheckProperty = true;
bool bolIsExist = clscss_StyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcss_Style.StyleId = clscss_StyleBL.GetFirstID_S(strCondition);
objcss_Style.UpdateWithCondition(strCondition);
}
else
{
objcss_Style.StyleId = clscss_StyleBL.GetMaxStrId_S();
objcss_Style.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_StyleEN objcss_StyleEN)
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_StyleBL.css_StyleDA.UpdateBySql2(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_StyleEN objcss_StyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_StyleBL.css_StyleDA.UpdateBySql2(objcss_StyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_StyleEN objcss_StyleEN, string strWhereCond)
{
try
{
bool bolResult = clscss_StyleBL.css_StyleDA.UpdateBySqlWithCondition(objcss_StyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_StyleEN objcss_StyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscss_StyleBL.css_StyleDA.UpdateBySqlWithConditionTransaction(objcss_StyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscss_StyleEN objcss_StyleEN)
{
try
{
int intRecNum = clscss_StyleBL.css_StyleDA.DelRecord(objcss_StyleEN.StyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleENS">源对象</param>
 /// <param name = "objcss_StyleENT">目标对象</param>
 public static void CopyTo(this clscss_StyleEN objcss_StyleENS, clscss_StyleEN objcss_StyleENT)
{
try
{
objcss_StyleENT.StyleId = objcss_StyleENS.StyleId; //样式ID
objcss_StyleENT.CtlTypeId = objcss_StyleENS.CtlTypeId; //控件类型号
objcss_StyleENT.StyleName = objcss_StyleENS.StyleName; //样式名称
objcss_StyleENT.StyleDesc = objcss_StyleENS.StyleDesc; //样式描述
objcss_StyleENT.StyleContent = objcss_StyleENS.StyleContent; //样式内容
objcss_StyleENT.IsDeleted = objcss_StyleENS.IsDeleted; //是否删除
objcss_StyleENT.DeletedDate = objcss_StyleENS.DeletedDate; //删除日期
objcss_StyleENT.UpdDate = objcss_StyleENS.UpdDate; //修改日期
objcss_StyleENT.UpdUser = objcss_StyleENS.UpdUser; //修改者
objcss_StyleENT.Memo = objcss_StyleENS.Memo; //说明
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
 /// <param name = "objcss_StyleENS">源对象</param>
 /// <returns>目标对象=>clscss_StyleEN:objcss_StyleENT</returns>
 public static clscss_StyleEN CopyTo(this clscss_StyleEN objcss_StyleENS)
{
try
{
 clscss_StyleEN objcss_StyleENT = new clscss_StyleEN()
{
StyleId = objcss_StyleENS.StyleId, //样式ID
CtlTypeId = objcss_StyleENS.CtlTypeId, //控件类型号
StyleName = objcss_StyleENS.StyleName, //样式名称
StyleDesc = objcss_StyleENS.StyleDesc, //样式描述
StyleContent = objcss_StyleENS.StyleContent, //样式内容
IsDeleted = objcss_StyleENS.IsDeleted, //是否删除
DeletedDate = objcss_StyleENS.DeletedDate, //删除日期
UpdDate = objcss_StyleENS.UpdDate, //修改日期
UpdUser = objcss_StyleENS.UpdUser, //修改者
Memo = objcss_StyleENS.Memo, //说明
};
 return objcss_StyleENT;
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
public static void CheckPropertyNew(this clscss_StyleEN objcss_StyleEN)
{
 clscss_StyleBL.css_StyleDA.CheckPropertyNew(objcss_StyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscss_StyleEN objcss_StyleEN)
{
 clscss_StyleBL.css_StyleDA.CheckProperty4Condition(objcss_StyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_StyleEN objcss_StyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_StyleCond.IsUpdated(concss_Style.StyleId) == true)
{
string strComparisonOpStyleId = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleId, objcss_StyleCond.StyleId, strComparisonOpStyleId);
}
if (objcss_StyleCond.IsUpdated(concss_Style.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objcss_StyleCond.dicFldComparisonOp[concss_Style.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.CtlTypeId, objcss_StyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleName) == true)
{
string strComparisonOpStyleName = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleName, objcss_StyleCond.StyleName, strComparisonOpStyleName);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleDesc) == true)
{
string strComparisonOpStyleDesc = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleDesc, objcss_StyleCond.StyleDesc, strComparisonOpStyleDesc);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleContent) == true)
{
string strComparisonOpStyleContent = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleContent, objcss_StyleCond.StyleContent, strComparisonOpStyleContent);
}
if (objcss_StyleCond.IsUpdated(concss_Style.IsDeleted) == true)
{
if (objcss_StyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_Style.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_Style.IsDeleted);
}
}
if (objcss_StyleCond.IsUpdated(concss_Style.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objcss_StyleCond.dicFldComparisonOp[concss_Style.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.DeletedDate, objcss_StyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objcss_StyleCond.IsUpdated(concss_Style.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_StyleCond.dicFldComparisonOp[concss_Style.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.UpdDate, objcss_StyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_StyleCond.IsUpdated(concss_Style.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_StyleCond.dicFldComparisonOp[concss_Style.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.UpdUser, objcss_StyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_StyleCond.IsUpdated(concss_Style.Memo) == true)
{
string strComparisonOpMemo = objcss_StyleCond.dicFldComparisonOp[concss_Style.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.Memo, objcss_StyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--css_Style(css_Style), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CtlTypeId_StyleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcss_StyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscss_StyleEN objcss_StyleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcss_StyleEN == null) return true;
if (objcss_StyleEN.StyleId == null || objcss_StyleEN.StyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 if (objcss_StyleEN.StyleName == null)
{
 sbCondition.AppendFormat(" and StyleName is null", objcss_StyleEN.StyleName);
}
else
{
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
}
if (clscss_StyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("StyleId !=  '{0}'", objcss_StyleEN.StyleId);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
if (clscss_StyleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--css_Style(css_Style), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CtlTypeId_StyleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcss_StyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscss_StyleEN objcss_StyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcss_StyleEN == null) return "";
if (objcss_StyleEN.StyleId == null || objcss_StyleEN.StyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 if (objcss_StyleEN.StyleName == null)
{
 sbCondition.AppendFormat(" and StyleName is null", objcss_StyleEN.StyleName);
}
else
{
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StyleId !=  '{0}'", objcss_StyleEN.StyleId);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_css_Style
{
public virtual bool UpdRelaTabDate(string strStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// css_Style(css_Style)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscss_StyleBL
{
public static RelatedActions_css_Style relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscss_StyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscss_StyleDA css_StyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscss_StyleDA();
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
 public clscss_StyleBL()
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
if (string.IsNullOrEmpty(clscss_StyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_StyleEN._ConnectString);
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
public static DataTable GetDataTable_css_Style(string strWhereCond)
{
DataTable objDT;
try
{
objDT = css_StyleDA.GetDataTable_css_Style(strWhereCond);
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
objDT = css_StyleDA.GetDataTable(strWhereCond);
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
objDT = css_StyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = css_StyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = css_StyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = css_StyleDA.GetDataTable_Top(objTopPara);
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
objDT = css_StyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = css_StyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = css_StyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscss_StyleEN> GetObjLstByStyleIdLst(List<string> arrStyleIdLst)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStyleIdLst, true);
 string strWhereCond = string.Format("StyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscss_StyleEN> GetObjLstByStyleIdLstCache(List<string> arrStyleIdLst)
{
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
List<clscss_StyleEN> arrcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrcss_StyleObjLst_Sel =
arrcss_StyleObjLstCache
.Where(x => arrStyleIdLst.Contains(x.StyleId));
return arrcss_StyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetObjLst(string strWhereCond)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
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
public static List<clscss_StyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcss_StyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscss_StyleEN> GetSubObjLstCache(clscss_StyleEN objcss_StyleCond)
{
List<clscss_StyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_Style._AttributeName)
{
if (objcss_StyleCond.IsUpdated(strFldName) == false) continue;
if (objcss_StyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_StyleCond[strFldName].ToString());
}
else
{
if (objcss_StyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_StyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_StyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_StyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_StyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_StyleCond[strFldName]));
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
public static List<clscss_StyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
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
public static List<clscss_StyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
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
List<clscss_StyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscss_StyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscss_StyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
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
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
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
public static List<clscss_StyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscss_StyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscss_StyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
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
public static List<clscss_StyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscss_StyleEN> arrObjLst = new List<clscss_StyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_StyleEN objcss_StyleEN = new clscss_StyleEN();
try
{
objcss_StyleEN.StyleId = objRow[concss_Style.StyleId].ToString().Trim(); //样式ID
objcss_StyleEN.CtlTypeId = objRow[concss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objcss_StyleEN.StyleName = objRow[concss_Style.StyleName] == DBNull.Value ? null : objRow[concss_Style.StyleName].ToString().Trim(); //样式名称
objcss_StyleEN.StyleDesc = objRow[concss_Style.StyleDesc] == DBNull.Value ? null : objRow[concss_Style.StyleDesc].ToString().Trim(); //样式描述
objcss_StyleEN.StyleContent = objRow[concss_Style.StyleContent] == DBNull.Value ? null : objRow[concss_Style.StyleContent].ToString().Trim(); //样式内容
objcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Style.IsDeleted].ToString().Trim()); //是否删除
objcss_StyleEN.DeletedDate = objRow[concss_Style.DeletedDate] == DBNull.Value ? null : objRow[concss_Style.DeletedDate].ToString().Trim(); //删除日期
objcss_StyleEN.UpdDate = objRow[concss_Style.UpdDate] == DBNull.Value ? null : objRow[concss_Style.UpdDate].ToString().Trim(); //修改日期
objcss_StyleEN.UpdUser = objRow[concss_Style.UpdUser] == DBNull.Value ? null : objRow[concss_Style.UpdUser].ToString().Trim(); //修改者
objcss_StyleEN.Memo = objRow[concss_Style.Memo] == DBNull.Value ? null : objRow[concss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_StyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcss_StyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcss_Style(ref clscss_StyleEN objcss_StyleEN)
{
bool bolResult = css_StyleDA.Getcss_Style(ref objcss_StyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_StyleEN GetObjByStyleId(string strStyleId)
{
if (strStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscss_StyleEN objcss_StyleEN = css_StyleDA.GetObjByStyleId(strStyleId);
return objcss_StyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscss_StyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscss_StyleEN objcss_StyleEN = css_StyleDA.GetFirstObj(strWhereCond);
 return objcss_StyleEN;
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
public static clscss_StyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscss_StyleEN objcss_StyleEN = css_StyleDA.GetObjByDataRow(objRow);
 return objcss_StyleEN;
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
public static clscss_StyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscss_StyleEN objcss_StyleEN = css_StyleDA.GetObjByDataRow(objRow);
 return objcss_StyleEN;
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
 /// <param name = "strStyleId">所给的关键字</param>
 /// <param name = "lstcss_StyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_StyleEN GetObjByStyleIdFromList(string strStyleId, List<clscss_StyleEN> lstcss_StyleObjLst)
{
foreach (clscss_StyleEN objcss_StyleEN in lstcss_StyleObjLst)
{
if (objcss_StyleEN.StyleId == strStyleId)
{
return objcss_StyleEN;
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
 string strMaxStyleId;
 try
 {
 strMaxStyleId = clscss_StyleDA.GetMaxStrId();
 return strMaxStyleId;
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
 string strStyleId;
 try
 {
 strStyleId = new clscss_StyleDA().GetFirstID(strWhereCond);
 return strStyleId;
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
 arrList = css_StyleDA.GetID(strWhereCond);
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
bool bolIsExist = css_StyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStyleId)
{
if (string.IsNullOrEmpty(strStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = css_StyleDA.IsExist(strStyleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strStyleId">样式ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strStyleId, string strOpUser)
{
clscss_StyleEN objcss_StyleEN = clscss_StyleBL.GetObjByStyleId(strStyleId);
objcss_StyleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcss_StyleEN.UpdUser = strOpUser;
return clscss_StyleBL.UpdateBySql2(objcss_StyleEN);
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
 bolIsExist = clscss_StyleDA.IsExistTable();
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
 bolIsExist = css_StyleDA.IsExistTable(strTabName);
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcss_StyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!控件类型号 = [{0}],样式名称 = [{1}]的数据已经存在!(in clscss_StyleBL.AddNewRecordBySql2)", objcss_StyleEN.CtlTypeId,objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
bool bolResult = css_StyleDA.AddNewRecordBySQL2(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscss_StyleEN objcss_StyleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcss_StyleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!控件类型号 = [{0}],样式名称 = [{1}]的数据已经存在!(in clscss_StyleBL.AddNewRecordBySql2WithReturnKey)", objcss_StyleEN.CtlTypeId,objcss_StyleEN.StyleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleBL.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleBL.GetMaxStrId_S();
 }
string strKey = css_StyleDA.AddNewRecordBySQL2WithReturnKey(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscss_StyleEN objcss_StyleEN)
{
try
{
bool bolResult = css_StyleDA.Update(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscss_StyleEN objcss_StyleEN)
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = css_StyleDA.UpdateBySql2(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleBL.ReFreshCache();

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
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
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStyleId)
{
try
{
 clscss_StyleEN objcss_StyleEN = clscss_StyleBL.GetObjByStyleId(strStyleId);

if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(objcss_StyleEN.StyleId, objcss_StyleEN.UpdUser);
}
if (objcss_StyleEN != null)
{
int intRecNum = css_StyleDA.DelRecord(strStyleId);
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
/// <param name="strStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_StyleDA.GetSpecSQLObj();
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
//删除与表:[css_Style]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concss_Style.StyleId,
//strStyleId);
//        clscss_StyleBL.Delcss_StylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_StyleBL.DelRecord(strStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_StyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscss_StyleBL.relatedActions != null)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(strStyleId, "UpdRelaTabDate");
}
bool bolResult = css_StyleDA.DelRecord(strStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcss_Styles(List<string> arrStyleIdLst)
{
if (arrStyleIdLst.Count == 0) return 0;
try
{
if (clscss_StyleBL.relatedActions != null)
{
foreach (var strStyleId in arrStyleIdLst)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(strStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = css_StyleDA.Delcss_Style(arrStyleIdLst);
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
public static int Delcss_StylesByCond(string strWhereCond)
{
try
{
if (clscss_StyleBL.relatedActions != null)
{
List<string> arrStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strStyleId in arrStyleId)
{
clscss_StyleBL.relatedActions.UpdRelaTabDate(strStyleId, "UpdRelaTabDate");
}
}
int intRecNum = css_StyleDA.Delcss_Style(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[css_Style]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_StyleDA.GetSpecSQLObj();
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
//删除与表:[css_Style]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_StyleBL.DelRecord(strStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_StyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcss_StyleENS">源对象</param>
 /// <param name = "objcss_StyleENT">目标对象</param>
 public static void CopyTo(clscss_StyleEN objcss_StyleENS, clscss_StyleEN objcss_StyleENT)
{
try
{
objcss_StyleENT.StyleId = objcss_StyleENS.StyleId; //样式ID
objcss_StyleENT.CtlTypeId = objcss_StyleENS.CtlTypeId; //控件类型号
objcss_StyleENT.StyleName = objcss_StyleENS.StyleName; //样式名称
objcss_StyleENT.StyleDesc = objcss_StyleENS.StyleDesc; //样式描述
objcss_StyleENT.StyleContent = objcss_StyleENS.StyleContent; //样式内容
objcss_StyleENT.IsDeleted = objcss_StyleENS.IsDeleted; //是否删除
objcss_StyleENT.DeletedDate = objcss_StyleENS.DeletedDate; //删除日期
objcss_StyleENT.UpdDate = objcss_StyleENS.UpdDate; //修改日期
objcss_StyleENT.UpdUser = objcss_StyleENS.UpdUser; //修改者
objcss_StyleENT.Memo = objcss_StyleENS.Memo; //说明
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
 /// <param name = "objcss_StyleEN">源简化对象</param>
 public static void SetUpdFlag(clscss_StyleEN objcss_StyleEN)
{
try
{
objcss_StyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcss_StyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concss_Style.StyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.StyleId = objcss_StyleEN.StyleId; //样式ID
}
if (arrFldSet.Contains(concss_Style.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.CtlTypeId = objcss_StyleEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(concss_Style.StyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.StyleName = objcss_StyleEN.StyleName == "[null]" ? null :  objcss_StyleEN.StyleName; //样式名称
}
if (arrFldSet.Contains(concss_Style.StyleDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.StyleDesc = objcss_StyleEN.StyleDesc == "[null]" ? null :  objcss_StyleEN.StyleDesc; //样式描述
}
if (arrFldSet.Contains(concss_Style.StyleContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.StyleContent = objcss_StyleEN.StyleContent == "[null]" ? null :  objcss_StyleEN.StyleContent; //样式内容
}
if (arrFldSet.Contains(concss_Style.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.IsDeleted = objcss_StyleEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(concss_Style.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.DeletedDate = objcss_StyleEN.DeletedDate == "[null]" ? null :  objcss_StyleEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(concss_Style.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.UpdDate = objcss_StyleEN.UpdDate == "[null]" ? null :  objcss_StyleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concss_Style.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.UpdUser = objcss_StyleEN.UpdUser == "[null]" ? null :  objcss_StyleEN.UpdUser; //修改者
}
if (arrFldSet.Contains(concss_Style.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_StyleEN.Memo = objcss_StyleEN.Memo == "[null]" ? null :  objcss_StyleEN.Memo; //说明
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
 /// <param name = "objcss_StyleEN">源简化对象</param>
 public static void AccessFldValueNull(clscss_StyleEN objcss_StyleEN)
{
try
{
if (objcss_StyleEN.StyleName == "[null]") objcss_StyleEN.StyleName = null; //样式名称
if (objcss_StyleEN.StyleDesc == "[null]") objcss_StyleEN.StyleDesc = null; //样式描述
if (objcss_StyleEN.StyleContent == "[null]") objcss_StyleEN.StyleContent = null; //样式内容
if (objcss_StyleEN.DeletedDate == "[null]") objcss_StyleEN.DeletedDate = null; //删除日期
if (objcss_StyleEN.UpdDate == "[null]") objcss_StyleEN.UpdDate = null; //修改日期
if (objcss_StyleEN.UpdUser == "[null]") objcss_StyleEN.UpdUser = null; //修改者
if (objcss_StyleEN.Memo == "[null]") objcss_StyleEN.Memo = null; //说明
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
public static void CheckPropertyNew(clscss_StyleEN objcss_StyleEN)
{
 css_StyleDA.CheckPropertyNew(objcss_StyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscss_StyleEN objcss_StyleEN)
{
 css_StyleDA.CheckProperty4Condition(objcss_StyleEN);
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
if (clscss_StyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_StyleBL没有刷新缓存机制(clscss_StyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StyleId");
//if (arrcss_StyleObjLstCache == null)
//{
//arrcss_StyleObjLstCache = css_StyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_StyleEN GetObjByStyleIdCache(string strStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
List<clscss_StyleEN> arrcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrcss_StyleObjLst_Sel =
arrcss_StyleObjLstCache
.Where(x=> x.StyleId == strStyleId 
);
if (arrcss_StyleObjLst_Sel.Count() == 0)
{
   clscss_StyleEN obj = clscss_StyleBL.GetObjByStyleId(strStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcss_StyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_StyleEN> GetAllcss_StyleObjLstCache()
{
//获取缓存中的对象列表
List<clscss_StyleEN> arrcss_StyleObjLstCache = GetObjLstCache(); 
return arrcss_StyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_StyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
List<clscss_StyleEN> arrcss_StyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcss_StyleObjLstCache;
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
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_StyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscss_StyleEN._RefreshTimeLst.Count == 0) return "";
return clscss_StyleEN._RefreshTimeLst[clscss_StyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscss_StyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_StyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscss_StyleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--css_Style(css_Style)
 /// 唯一性条件:CtlTypeId_StyleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcss_StyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscss_StyleEN objcss_StyleEN)
{
//检测记录是否存在
string strResult = css_StyleDA.GetUniCondStr(objcss_StyleEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strStyleId)
{
if (strInFldName != concss_Style.StyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concss_Style._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concss_Style._AttributeName));
throw new Exception(strMsg);
}
var objcss_Style = clscss_StyleBL.GetObjByStyleIdCache(strStyleId);
if (objcss_Style == null) return "";
return objcss_Style[strOutFldName].ToString();
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
int intRecCount = clscss_StyleDA.GetRecCount(strTabName);
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
int intRecCount = clscss_StyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscss_StyleDA.GetRecCount();
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
int intRecCount = clscss_StyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcss_StyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscss_StyleEN objcss_StyleCond)
{
List<clscss_StyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_Style._AttributeName)
{
if (objcss_StyleCond.IsUpdated(strFldName) == false) continue;
if (objcss_StyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_StyleCond[strFldName].ToString());
}
else
{
if (objcss_StyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_StyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_StyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_StyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_StyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_StyleCond[strFldName]));
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
 List<string> arrList = clscss_StyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = css_StyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = css_StyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = css_StyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscss_StyleDA.SetFldValue(clscss_StyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = css_StyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscss_StyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscss_StyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscss_StyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[css_Style] "); 
 strCreateTabCode.Append(" ( "); 
 // /**样式ID*/ 
 strCreateTabCode.Append(" StyleId char(8) primary key, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) not Null, "); 
 // /**样式名称*/ 
 strCreateTabCode.Append(" StyleName varchar(50) Null, "); 
 // /**样式描述*/ 
 strCreateTabCode.Append(" StyleDesc varchar(1000) Null, "); 
 // /**样式内容*/ 
 strCreateTabCode.Append(" StyleContent varchar(1000) Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDeleted bit Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" DeletedDate varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// css_Style(css_Style)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4css_Style : clsCommFun4BL
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
clscss_StyleBL.ReFreshThisCache();
}
}

}