
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewDgInfoBL
 表名:ViewDgInfo(00050012)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsViewDgInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewDgID">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewDgInfoEN GetObj(this K_ViewDgID_ViewDgInfo myKey)
{
clsViewDgInfoEN objViewDgInfoEN = clsViewDgInfoBL.ViewDgInfoDA.GetObjByViewDgID(myKey.Value);
return objViewDgInfoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewDgInfoEN.ViewDgID, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewDgInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Dg名称 = [{0}],界面Id = [{1}]的数据已经存在!(in clsViewDgInfoBL.AddNewRecord)", objViewDgInfoEN.ViewDgName,objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewDgInfoBL.ViewDgInfoDA.AddNewRecordBySQL2(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewDgInfoEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewDgInfoEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面Dg名称(ViewDgName)=[{0}],界面Id(ViewId)=[{1}])已经存在,不能重复!", objViewDgInfoEN.ViewDgName, objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewDgInfoEN.AddNewRecord();
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewDgInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Dg名称 = [{0}],界面Id = [{1}]的数据已经存在!(in clsViewDgInfoBL.AddNewRecordWithMaxId)", objViewDgInfoEN.ViewDgName,objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true || clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
     objViewDgInfoEN.ViewDgID = clsViewDgInfoBL.GetMaxStrIdByPrefix_S(objViewDgInfoEN.ViewId);
 }
string strViewDgID = clsViewDgInfoBL.ViewDgInfoDA.AddNewRecordBySQL2WithReturnKey(objViewDgInfoEN);
     objViewDgInfoEN.ViewDgID = strViewDgID;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
}
return strViewDgID;
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewDgInfoEN.ViewDgID, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewDgInfoEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Dg名称 = [{0}],界面Id = [{1}]的数据已经存在!(in clsViewDgInfoBL.AddNewRecordWithReturnKey)", objViewDgInfoEN.ViewDgName,objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewDgInfoBL.ViewDgInfoDA.AddNewRecordBySQL2WithReturnKey(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewDgID(this clsViewDgInfoEN objViewDgInfoEN, string strViewDgID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDgID, 10, conViewDgInfo.ViewDgID);
}
objViewDgInfoEN.ViewDgID = strViewDgID; //界面DgId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.ViewDgID) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.ViewDgID, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.ViewDgID] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewDgName(this clsViewDgInfoEN objViewDgInfoEN, string strViewDgName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewDgName, conViewDgInfo.ViewDgName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewDgName, 100, conViewDgInfo.ViewDgName);
}
objViewDgInfoEN.ViewDgName = strViewDgName; //界面Dg名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.ViewDgName) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.ViewDgName, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.ViewDgName] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewId(this clsViewDgInfoEN objViewDgInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, conViewDgInfo.ViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewDgInfo.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewDgInfo.ViewId);
}
objViewDgInfoEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.ViewId) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.ViewId, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.ViewId] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetSqlDsId(this clsViewDgInfoEN objViewDgInfoEN, string strSqlDsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsId, 8, conViewDgInfo.SqlDsId);
}
objViewDgInfoEN.SqlDsId = strSqlDsId; //数据源表/视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.SqlDsId) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.SqlDsId, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.SqlDsId] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetDgStyleId(this clsViewDgInfoEN objViewDgInfoEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleId, conViewDgInfo.DgStyleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, conViewDgInfo.DgStyleId);
}
objViewDgInfoEN.DgStyleId = strDgStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.DgStyleId) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.DgStyleId, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.DgStyleId] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyle(this clsViewDgInfoEN objViewDgInfoEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conViewDgInfo.Style);
}
objViewDgInfoEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.Style) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.Style, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.Style] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetRunat(this clsViewDgInfoEN objViewDgInfoEN, string strRunat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conViewDgInfo.Runat);
}
objViewDgInfoEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.Runat) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.Runat, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.Runat] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetFontSize(this clsViewDgInfoEN objViewDgInfoEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conViewDgInfo.FontSize);
}
objViewDgInfoEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.FontSize) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.FontSize, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.FontSize] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetFontName(this clsViewDgInfoEN objViewDgInfoEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conViewDgInfo.FontName);
}
objViewDgInfoEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.FontName) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.FontName, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.FontName] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetWidth(this clsViewDgInfoEN objViewDgInfoEN, int? intWidth, string strComparisonOp="")
	{
objViewDgInfoEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.Width) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.Width, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.Width] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetHeight(this clsViewDgInfoEN objViewDgInfoEN, int? intHeight, string strComparisonOp="")
	{
objViewDgInfoEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.Height) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.Height, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.Height] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetAllowPaging(this clsViewDgInfoEN objViewDgInfoEN, bool bolAllowPaging, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowPaging, conViewDgInfo.AllowPaging);
objViewDgInfoEN.AllowPaging = bolAllowPaging; //允许分页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.AllowPaging) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.AllowPaging, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.AllowPaging] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetPageSize(this clsViewDgInfoEN objViewDgInfoEN, int? intPageSize, string strComparisonOp="")
	{
objViewDgInfoEN.PageSize = intPageSize; //页大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.PageSize) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.PageSize, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.PageSize] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetAutoGenerateColumns(this clsViewDgInfoEN objViewDgInfoEN, bool bolAutoGenerateColumns, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAutoGenerateColumns, conViewDgInfo.AutoGenerateColumns);
objViewDgInfoEN.AutoGenerateColumns = bolAutoGenerateColumns; //自动生成列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.AutoGenerateColumns) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.AutoGenerateColumns, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.AutoGenerateColumns] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetAllowSorting(this clsViewDgInfoEN objViewDgInfoEN, bool bolAllowSorting, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowSorting, conViewDgInfo.AllowSorting);
objViewDgInfoEN.AllowSorting = bolAllowSorting; //允许排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.AllowSorting) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.AllowSorting, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.AllowSorting] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsRadio(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsRadio, string strComparisonOp="")
	{
objViewDgInfoEN.IsRadio = bolIsRadio; //是否单选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsRadio) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsRadio, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsRadio] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsCheck(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsCheck, string strComparisonOp="")
	{
objViewDgInfoEN.IsCheck = bolIsCheck; //是否复选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsCheck) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsCheck, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsCheck] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsHaveUpdBtn(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsHaveUpdBtn, string strComparisonOp="")
	{
objViewDgInfoEN.IsHaveUpdBtn = bolIsHaveUpdBtn; //是否有修改按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsHaveUpdBtn) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsHaveUpdBtn, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsHaveUpdBtn] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsHaveDelBtn(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsHaveDelBtn, string strComparisonOp="")
	{
objViewDgInfoEN.IsHaveDelBtn = bolIsHaveDelBtn; //是否有删除按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsHaveDelBtn) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsHaveDelBtn, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsHaveDelBtn] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsHaveDetailBtn(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsHaveDetailBtn, string strComparisonOp="")
	{
objViewDgInfoEN.IsHaveDetailBtn = bolIsHaveDetailBtn; //是否有详细按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsHaveDetailBtn) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsHaveDetailBtn, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsHaveDetailBtn] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsJumpPage(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsJumpPage, string strComparisonOp="")
	{
objViewDgInfoEN.IsJumpPage = bolIsJumpPage; //是否跳页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsJumpPage) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsJumpPage, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsJumpPage] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetIsInTab(this clsViewDgInfoEN objViewDgInfoEN, bool bolIsInTab, string strComparisonOp="")
	{
objViewDgInfoEN.IsInTab = bolIsInTab; //是否生成DG在表中
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.IsInTab) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.IsInTab, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.IsInTab] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleZindex(this clsViewDgInfoEN objViewDgInfoEN, int? intStyleZindex, string strComparisonOp="")
	{
objViewDgInfoEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.StyleZindex) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.StyleZindex, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.StyleZindex] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleLeft(this clsViewDgInfoEN objViewDgInfoEN, int? intStyleLeft, string strComparisonOp="")
	{
objViewDgInfoEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.StyleLeft) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.StyleLeft, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.StyleLeft] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStylePosition(this clsViewDgInfoEN objViewDgInfoEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conViewDgInfo.StylePosition);
}
objViewDgInfoEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.StylePosition) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.StylePosition, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.StylePosition] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleTop(this clsViewDgInfoEN objViewDgInfoEN, int? intStyleTop, string strComparisonOp="")
	{
objViewDgInfoEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.StyleTop) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.StyleTop, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.StyleTop] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetSqlDsTypeId(this clsViewDgInfoEN objViewDgInfoEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conViewDgInfo.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
}
objViewDgInfoEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewDgInfoEN.dicFldComparisonOp.ContainsKey(conViewDgInfo.SqlDsTypeId) == false)
{
objViewDgInfoEN.dicFldComparisonOp.Add(conViewDgInfo.SqlDsTypeId, strComparisonOp);
}
else
{
objViewDgInfoEN.dicFldComparisonOp[conViewDgInfo.SqlDsTypeId] = strComparisonOp;
}
}
return objViewDgInfoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewDgInfoEN objViewDgInfoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewDgInfoEN.CheckPropertyNew();
clsViewDgInfoEN objViewDgInfoCond = new clsViewDgInfoEN();
string strCondition = objViewDgInfoCond
.SetViewDgID(objViewDgInfoEN.ViewDgID, "<>")
.SetViewDgName(objViewDgInfoEN.ViewDgName, "=")
.SetViewId(objViewDgInfoEN.ViewId, "=")
.GetCombineCondition();
objViewDgInfoEN._IsCheckProperty = true;
bool bolIsExist = clsViewDgInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewDgName_ViewId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewDgInfoEN.Update();
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
 /// <param name = "objViewDgInfo">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewDgInfoEN objViewDgInfo)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewDgInfoEN objViewDgInfoCond = new clsViewDgInfoEN();
string strCondition = objViewDgInfoCond
.SetViewDgName(objViewDgInfo.ViewDgName, "=")
.SetViewId(objViewDgInfo.ViewId, "=")
.GetCombineCondition();
objViewDgInfo._IsCheckProperty = true;
bool bolIsExist = clsViewDgInfoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewDgInfo.ViewDgID = clsViewDgInfoBL.GetFirstID_S(strCondition);
objViewDgInfo.UpdateWithCondition(strCondition);
}
else
{
objViewDgInfo.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewDgInfoEN objViewDgInfoEN)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewDgInfoBL.ViewDgInfoDA.UpdateBySql2(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewDgInfoEN objViewDgInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewDgInfoBL.ViewDgInfoDA.UpdateBySql2(objViewDgInfoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewDgInfoEN objViewDgInfoEN, string strWhereCond)
{
try
{
bool bolResult = clsViewDgInfoBL.ViewDgInfoDA.UpdateBySqlWithCondition(objViewDgInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewDgInfoEN objViewDgInfoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewDgInfoBL.ViewDgInfoDA.UpdateBySqlWithConditionTransaction(objViewDgInfoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewDgInfoEN objViewDgInfoEN)
{
try
{
int intRecNum = clsViewDgInfoBL.ViewDgInfoDA.DelRecord(objViewDgInfoEN.ViewDgID);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoENS">源对象</param>
 /// <param name = "objViewDgInfoENT">目标对象</param>
 public static void CopyTo(this clsViewDgInfoEN objViewDgInfoENS, clsViewDgInfoEN objViewDgInfoENT)
{
try
{
objViewDgInfoENT.ViewDgID = objViewDgInfoENS.ViewDgID; //界面DgId
objViewDgInfoENT.ViewDgName = objViewDgInfoENS.ViewDgName; //界面Dg名称
objViewDgInfoENT.ViewId = objViewDgInfoENS.ViewId; //界面Id
objViewDgInfoENT.SqlDsId = objViewDgInfoENS.SqlDsId; //数据源表/视图Id
objViewDgInfoENT.DgStyleId = objViewDgInfoENS.DgStyleId; //DG模式ID
objViewDgInfoENT.Style = objViewDgInfoENS.Style; //类型
objViewDgInfoENT.Runat = objViewDgInfoENS.Runat; //运行在
objViewDgInfoENT.FontSize = objViewDgInfoENS.FontSize; //字号
objViewDgInfoENT.FontName = objViewDgInfoENS.FontName; //字体
objViewDgInfoENT.Width = objViewDgInfoENS.Width; //宽
objViewDgInfoENT.Height = objViewDgInfoENS.Height; //高度
objViewDgInfoENT.AllowPaging = objViewDgInfoENS.AllowPaging; //允许分页
objViewDgInfoENT.PageSize = objViewDgInfoENS.PageSize; //页大小
objViewDgInfoENT.AutoGenerateColumns = objViewDgInfoENS.AutoGenerateColumns; //自动生成列
objViewDgInfoENT.AllowSorting = objViewDgInfoENS.AllowSorting; //允许排序
objViewDgInfoENT.IsRadio = objViewDgInfoENS.IsRadio; //是否单选框
objViewDgInfoENT.IsCheck = objViewDgInfoENS.IsCheck; //是否复选框
objViewDgInfoENT.IsHaveUpdBtn = objViewDgInfoENS.IsHaveUpdBtn; //是否有修改按钮
objViewDgInfoENT.IsHaveDelBtn = objViewDgInfoENS.IsHaveDelBtn; //是否有删除按钮
objViewDgInfoENT.IsHaveDetailBtn = objViewDgInfoENS.IsHaveDetailBtn; //是否有详细按钮
objViewDgInfoENT.IsJumpPage = objViewDgInfoENS.IsJumpPage; //是否跳页
objViewDgInfoENT.IsInTab = objViewDgInfoENS.IsInTab; //是否生成DG在表中
objViewDgInfoENT.StyleZindex = objViewDgInfoENS.StyleZindex; //Style_Zindex
objViewDgInfoENT.StyleLeft = objViewDgInfoENS.StyleLeft; //Style_Left
objViewDgInfoENT.StylePosition = objViewDgInfoENS.StylePosition; //Style_Position
objViewDgInfoENT.StyleTop = objViewDgInfoENS.StyleTop; //Style_Top
objViewDgInfoENT.SqlDsTypeId = objViewDgInfoENS.SqlDsTypeId; //数据源类型Id
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
 /// <param name = "objViewDgInfoENS">源对象</param>
 /// <returns>目标对象=>clsViewDgInfoEN:objViewDgInfoENT</returns>
 public static clsViewDgInfoEN CopyTo(this clsViewDgInfoEN objViewDgInfoENS)
{
try
{
 clsViewDgInfoEN objViewDgInfoENT = new clsViewDgInfoEN()
{
ViewDgID = objViewDgInfoENS.ViewDgID, //界面DgId
ViewDgName = objViewDgInfoENS.ViewDgName, //界面Dg名称
ViewId = objViewDgInfoENS.ViewId, //界面Id
SqlDsId = objViewDgInfoENS.SqlDsId, //数据源表/视图Id
DgStyleId = objViewDgInfoENS.DgStyleId, //DG模式ID
Style = objViewDgInfoENS.Style, //类型
Runat = objViewDgInfoENS.Runat, //运行在
FontSize = objViewDgInfoENS.FontSize, //字号
FontName = objViewDgInfoENS.FontName, //字体
Width = objViewDgInfoENS.Width, //宽
Height = objViewDgInfoENS.Height, //高度
AllowPaging = objViewDgInfoENS.AllowPaging, //允许分页
PageSize = objViewDgInfoENS.PageSize, //页大小
AutoGenerateColumns = objViewDgInfoENS.AutoGenerateColumns, //自动生成列
AllowSorting = objViewDgInfoENS.AllowSorting, //允许排序
IsRadio = objViewDgInfoENS.IsRadio, //是否单选框
IsCheck = objViewDgInfoENS.IsCheck, //是否复选框
IsHaveUpdBtn = objViewDgInfoENS.IsHaveUpdBtn, //是否有修改按钮
IsHaveDelBtn = objViewDgInfoENS.IsHaveDelBtn, //是否有删除按钮
IsHaveDetailBtn = objViewDgInfoENS.IsHaveDetailBtn, //是否有详细按钮
IsJumpPage = objViewDgInfoENS.IsJumpPage, //是否跳页
IsInTab = objViewDgInfoENS.IsInTab, //是否生成DG在表中
StyleZindex = objViewDgInfoENS.StyleZindex, //Style_Zindex
StyleLeft = objViewDgInfoENS.StyleLeft, //Style_Left
StylePosition = objViewDgInfoENS.StylePosition, //Style_Position
StyleTop = objViewDgInfoENS.StyleTop, //Style_Top
SqlDsTypeId = objViewDgInfoENS.SqlDsTypeId, //数据源类型Id
};
 return objViewDgInfoENT;
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
public static void CheckPropertyNew(this clsViewDgInfoEN objViewDgInfoEN)
{
 clsViewDgInfoBL.ViewDgInfoDA.CheckPropertyNew(objViewDgInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewDgInfoEN objViewDgInfoEN)
{
 clsViewDgInfoBL.ViewDgInfoDA.CheckProperty4Condition(objViewDgInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewDgInfoEN objViewDgInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.ViewDgID) == true)
{
string strComparisonOpViewDgID = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.ViewDgID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.ViewDgID, objViewDgInfoCond.ViewDgID, strComparisonOpViewDgID);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.ViewDgName) == true)
{
string strComparisonOpViewDgName = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.ViewDgName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.ViewDgName, objViewDgInfoCond.ViewDgName, strComparisonOpViewDgName);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.ViewId) == true)
{
string strComparisonOpViewId = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.ViewId, objViewDgInfoCond.ViewId, strComparisonOpViewId);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.SqlDsId) == true)
{
string strComparisonOpSqlDsId = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.SqlDsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.SqlDsId, objViewDgInfoCond.SqlDsId, strComparisonOpSqlDsId);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.DgStyleId) == true)
{
string strComparisonOpDgStyleId = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.DgStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.DgStyleId, objViewDgInfoCond.DgStyleId, strComparisonOpDgStyleId);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.Style) == true)
{
string strComparisonOpStyle = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.Style, objViewDgInfoCond.Style, strComparisonOpStyle);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.Runat) == true)
{
string strComparisonOpRunat = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.Runat, objViewDgInfoCond.Runat, strComparisonOpRunat);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.FontSize) == true)
{
string strComparisonOpFontSize = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.FontSize, objViewDgInfoCond.FontSize, strComparisonOpFontSize);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.FontName) == true)
{
string strComparisonOpFontName = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.FontName, objViewDgInfoCond.FontName, strComparisonOpFontName);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.Width) == true)
{
string strComparisonOpWidth = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.Width, objViewDgInfoCond.Width, strComparisonOpWidth);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.Height) == true)
{
string strComparisonOpHeight = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.Height, objViewDgInfoCond.Height, strComparisonOpHeight);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.AllowPaging) == true)
{
if (objViewDgInfoCond.AllowPaging == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.AllowPaging);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.AllowPaging);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.PageSize) == true)
{
string strComparisonOpPageSize = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.PageSize];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.PageSize, objViewDgInfoCond.PageSize, strComparisonOpPageSize);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.AutoGenerateColumns) == true)
{
if (objViewDgInfoCond.AutoGenerateColumns == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.AutoGenerateColumns);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.AutoGenerateColumns);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.AllowSorting) == true)
{
if (objViewDgInfoCond.AllowSorting == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.AllowSorting);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.AllowSorting);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsRadio) == true)
{
if (objViewDgInfoCond.IsRadio == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsRadio);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsRadio);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsCheck) == true)
{
if (objViewDgInfoCond.IsCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsCheck);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsHaveUpdBtn) == true)
{
if (objViewDgInfoCond.IsHaveUpdBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsHaveUpdBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsHaveUpdBtn);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsHaveDelBtn) == true)
{
if (objViewDgInfoCond.IsHaveDelBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsHaveDelBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsHaveDelBtn);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsHaveDetailBtn) == true)
{
if (objViewDgInfoCond.IsHaveDetailBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsHaveDetailBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsHaveDetailBtn);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsJumpPage) == true)
{
if (objViewDgInfoCond.IsJumpPage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsJumpPage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsJumpPage);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.IsInTab) == true)
{
if (objViewDgInfoCond.IsInTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewDgInfo.IsInTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewDgInfo.IsInTab);
}
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.StyleZindex, objViewDgInfoCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.StyleLeft, objViewDgInfoCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.StylePosition) == true)
{
string strComparisonOpStylePosition = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.StylePosition, objViewDgInfoCond.StylePosition, strComparisonOpStylePosition);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.StyleTop) == true)
{
string strComparisonOpStyleTop = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conViewDgInfo.StyleTop, objViewDgInfoCond.StyleTop, strComparisonOpStyleTop);
}
if (objViewDgInfoCond.IsUpdated(conViewDgInfo.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objViewDgInfoCond.dicFldComparisonOp[conViewDgInfo.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewDgInfo.SqlDsTypeId, objViewDgInfoCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewDgInfo(视图Dg), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewDgName_ViewId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewDgInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewDgInfoEN objViewDgInfoEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewDgInfoEN == null) return true;
if (objViewDgInfoEN.ViewDgID == null || objViewDgInfoEN.ViewDgID == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewDgName = '{0}'", objViewDgInfoEN.ViewDgName);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewDgInfoEN.ViewId);
if (clsViewDgInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewDgID !=  '{0}'", objViewDgInfoEN.ViewDgID);
 sbCondition.AppendFormat(" and ViewDgName = '{0}'", objViewDgInfoEN.ViewDgName);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewDgInfoEN.ViewId);
if (clsViewDgInfoBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewDgInfo(视图Dg), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewDgName_ViewId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewDgInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewDgInfoEN objViewDgInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewDgInfoEN == null) return "";
if (objViewDgInfoEN.ViewDgID == null || objViewDgInfoEN.ViewDgID == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewDgName = '{0}'", objViewDgInfoEN.ViewDgName);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewDgInfoEN.ViewId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewDgID !=  '{0}'", objViewDgInfoEN.ViewDgID);
 sbCondition.AppendFormat(" and ViewDgName = '{0}'", objViewDgInfoEN.ViewDgName);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewDgInfoEN.ViewId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewDgInfo
{
public virtual bool UpdRelaTabDate(string strViewDgID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 视图Dg(ViewDgInfo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewDgInfoBL
{
public static RelatedActions_ViewDgInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewDgInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewDgInfoDA ViewDgInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewDgInfoDA();
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
 public clsViewDgInfoBL()
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
if (string.IsNullOrEmpty(clsViewDgInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewDgInfoEN._ConnectString);
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
public static DataTable GetDataTable_ViewDgInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewDgInfoDA.GetDataTable_ViewDgInfo(strWhereCond);
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
objDT = ViewDgInfoDA.GetDataTable(strWhereCond);
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
objDT = ViewDgInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewDgInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewDgInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewDgInfoDA.GetDataTable_Top(objTopPara);
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
objDT = ViewDgInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewDgInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewDgInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewDgIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstByViewDgIDLst(List<string> arrViewDgIDLst)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewDgIDLst, true);
 string strWhereCond = string.Format("ViewDgID in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewDgIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewDgInfoEN> GetObjLstByViewDgIDLstCache(List<string> arrViewDgIDLst)
{
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrViewDgInfoObjLst_Sel =
arrViewDgInfoObjLstCache
.Where(x => arrViewDgIDLst.Contains(x.ViewDgID));
return arrViewDgInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLst(string strWhereCond)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
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
public static List<clsViewDgInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewDgInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewDgInfoEN> GetSubObjLstCache(clsViewDgInfoEN objViewDgInfoCond)
{
List<clsViewDgInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewDgInfo._AttributeName)
{
if (objViewDgInfoCond.IsUpdated(strFldName) == false) continue;
if (objViewDgInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewDgInfoCond[strFldName].ToString());
}
else
{
if (objViewDgInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewDgInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewDgInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewDgInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewDgInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewDgInfoCond[strFldName]));
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
public static List<clsViewDgInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
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
public static List<clsViewDgInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
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
List<clsViewDgInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewDgInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewDgInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
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
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
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
public static List<clsViewDgInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewDgInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
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
public static List<clsViewDgInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewDgInfoEN> arrObjLst = new List<clsViewDgInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewDgInfoEN objViewDgInfoEN = new clsViewDgInfoEN();
try
{
objViewDgInfoEN.ViewDgID = objRow[conViewDgInfo.ViewDgID].ToString().Trim(); //界面DgId
objViewDgInfoEN.ViewDgName = objRow[conViewDgInfo.ViewDgName].ToString().Trim(); //界面Dg名称
objViewDgInfoEN.ViewId = objRow[conViewDgInfo.ViewId].ToString().Trim(); //界面Id
objViewDgInfoEN.SqlDsId = objRow[conViewDgInfo.SqlDsId] == DBNull.Value ? null : objRow[conViewDgInfo.SqlDsId].ToString().Trim(); //数据源表/视图Id
objViewDgInfoEN.DgStyleId = objRow[conViewDgInfo.DgStyleId].ToString().Trim(); //DG模式ID
objViewDgInfoEN.Style = objRow[conViewDgInfo.Style] == DBNull.Value ? null : objRow[conViewDgInfo.Style].ToString().Trim(); //类型
objViewDgInfoEN.Runat = objRow[conViewDgInfo.Runat] == DBNull.Value ? null : objRow[conViewDgInfo.Runat].ToString().Trim(); //运行在
objViewDgInfoEN.FontSize = objRow[conViewDgInfo.FontSize] == DBNull.Value ? null : objRow[conViewDgInfo.FontSize].ToString().Trim(); //字号
objViewDgInfoEN.FontName = objRow[conViewDgInfo.FontName] == DBNull.Value ? null : objRow[conViewDgInfo.FontName].ToString().Trim(); //字体
objViewDgInfoEN.Width = objRow[conViewDgInfo.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Width].ToString().Trim()); //宽
objViewDgInfoEN.Height = objRow[conViewDgInfo.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.Height].ToString().Trim()); //高度
objViewDgInfoEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowPaging].ToString().Trim()); //允许分页
objViewDgInfoEN.PageSize = objRow[conViewDgInfo.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.PageSize].ToString().Trim()); //页大小
objViewDgInfoEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AutoGenerateColumns].ToString().Trim()); //自动生成列
objViewDgInfoEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.AllowSorting].ToString().Trim()); //允许排序
objViewDgInfoEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsRadio].ToString().Trim()); //是否单选框
objViewDgInfoEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsCheck].ToString().Trim()); //是否复选框
objViewDgInfoEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objViewDgInfoEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objViewDgInfoEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objViewDgInfoEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsJumpPage].ToString().Trim()); //是否跳页
objViewDgInfoEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conViewDgInfo.IsInTab].ToString().Trim()); //是否生成DG在表中
objViewDgInfoEN.StyleZindex = objRow[conViewDgInfo.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleZindex].ToString().Trim()); //Style_Zindex
objViewDgInfoEN.StyleLeft = objRow[conViewDgInfo.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleLeft].ToString().Trim()); //Style_Left
objViewDgInfoEN.StylePosition = objRow[conViewDgInfo.StylePosition] == DBNull.Value ? null : objRow[conViewDgInfo.StylePosition].ToString().Trim(); //Style_Position
objViewDgInfoEN.StyleTop = objRow[conViewDgInfo.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewDgInfo.StyleTop].ToString().Trim()); //Style_Top
objViewDgInfoEN.SqlDsTypeId = objRow[conViewDgInfo.SqlDsTypeId].ToString().Trim(); //数据源类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewDgInfoEN.ViewDgID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewDgInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewDgInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewDgInfo(ref clsViewDgInfoEN objViewDgInfoEN)
{
bool bolResult = ViewDgInfoDA.GetViewDgInfo(ref objViewDgInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewDgID">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewDgInfoEN GetObjByViewDgID(string strViewDgID)
{
if (strViewDgID.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewDgID]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewDgID) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewDgID]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewDgInfoEN objViewDgInfoEN = ViewDgInfoDA.GetObjByViewDgID(strViewDgID);
return objViewDgInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewDgInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewDgInfoEN objViewDgInfoEN = ViewDgInfoDA.GetFirstObj(strWhereCond);
 return objViewDgInfoEN;
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
public static clsViewDgInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewDgInfoEN objViewDgInfoEN = ViewDgInfoDA.GetObjByDataRow(objRow);
 return objViewDgInfoEN;
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
public static clsViewDgInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewDgInfoEN objViewDgInfoEN = ViewDgInfoDA.GetObjByDataRow(objRow);
 return objViewDgInfoEN;
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
 /// <param name = "strViewDgID">所给的关键字</param>
 /// <param name = "lstViewDgInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewDgInfoEN GetObjByViewDgIDFromList(string strViewDgID, List<clsViewDgInfoEN> lstViewDgInfoObjLst)
{
foreach (clsViewDgInfoEN objViewDgInfoEN in lstViewDgInfoObjLst)
{
if (objViewDgInfoEN.ViewDgID == strViewDgID)
{
return objViewDgInfoEN;
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
 string strMaxViewDgID;
 try
 {
 strMaxViewDgID = new clsViewDgInfoDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxViewDgID;
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
 string strViewDgID;
 try
 {
 strViewDgID = new clsViewDgInfoDA().GetFirstID(strWhereCond);
 return strViewDgID;
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
 arrList = ViewDgInfoDA.GetID(strWhereCond);
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
bool bolIsExist = ViewDgInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewDgID)
{
if (string.IsNullOrEmpty(strViewDgID) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewDgID]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ViewDgInfoDA.IsExist(strViewDgID);
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
 bolIsExist = clsViewDgInfoDA.IsExistTable();
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
 bolIsExist = ViewDgInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewDgInfoEN.ViewDgID, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewDgInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Dg名称 = [{0}],界面Id = [{1}]的数据已经存在!(in clsViewDgInfoBL.AddNewRecordBySql2)", objViewDgInfoEN.ViewDgName,objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewDgInfoDA.AddNewRecordBySQL2(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewDgInfoEN objViewDgInfoEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewDgInfoBL.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewDgInfoEN.ViewDgID, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objViewDgInfoEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Dg名称 = [{0}],界面Id = [{1}]的数据已经存在!(in clsViewDgInfoBL.AddNewRecordBySql2WithReturnKey)", objViewDgInfoEN.ViewDgName,objViewDgInfoEN.ViewId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewDgInfoDA.AddNewRecordBySQL2WithReturnKey(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewDgInfoEN objViewDgInfoEN)
{
try
{
bool bolResult = ViewDgInfoDA.Update(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewDgInfoEN objViewDgInfoEN)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewDgInfoDA.UpdateBySql2(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoBL.ReFreshCache();

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
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
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewDgID)
{
try
{
 clsViewDgInfoEN objViewDgInfoEN = clsViewDgInfoBL.GetObjByViewDgID(strViewDgID);

if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(objViewDgInfoEN.ViewDgID, "SetUpdDate");
}
if (objViewDgInfoEN != null)
{
int intRecNum = ViewDgInfoDA.DelRecord(strViewDgID);
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
/// <param name="strViewDgID">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewDgID )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
//删除与表:[ViewDgInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewDgInfo.ViewDgID,
//strViewDgID);
//        clsViewDgInfoBL.DelViewDgInfosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewDgInfoBL.DelRecord(strViewDgID, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewDgInfoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewDgID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewDgID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewDgID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewDgInfoBL.relatedActions != null)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(strViewDgID, "UpdRelaTabDate");
}
bool bolResult = ViewDgInfoDA.DelRecord(strViewDgID,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewDgIDLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewDgInfos(List<string> arrViewDgIDLst)
{
if (arrViewDgIDLst.Count == 0) return 0;
try
{
if (clsViewDgInfoBL.relatedActions != null)
{
foreach (var strViewDgID in arrViewDgIDLst)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(strViewDgID, "UpdRelaTabDate");
}
}
int intDelRecNum = ViewDgInfoDA.DelViewDgInfo(arrViewDgIDLst);
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
public static int DelViewDgInfosByCond(string strWhereCond)
{
try
{
if (clsViewDgInfoBL.relatedActions != null)
{
List<string> arrViewDgID = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewDgID in arrViewDgID)
{
clsViewDgInfoBL.relatedActions.UpdRelaTabDate(strViewDgID, "UpdRelaTabDate");
}
}
int intRecNum = ViewDgInfoDA.DelViewDgInfo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewDgInfo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewDgID">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewDgID)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewDgInfoDA.GetSpecSQLObj();
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
//删除与表:[ViewDgInfo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewDgInfoBL.DelRecord(strViewDgID, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewDgInfoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewDgID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewDgInfoENS">源对象</param>
 /// <param name = "objViewDgInfoENT">目标对象</param>
 public static void CopyTo(clsViewDgInfoEN objViewDgInfoENS, clsViewDgInfoEN objViewDgInfoENT)
{
try
{
objViewDgInfoENT.ViewDgID = objViewDgInfoENS.ViewDgID; //界面DgId
objViewDgInfoENT.ViewDgName = objViewDgInfoENS.ViewDgName; //界面Dg名称
objViewDgInfoENT.ViewId = objViewDgInfoENS.ViewId; //界面Id
objViewDgInfoENT.SqlDsId = objViewDgInfoENS.SqlDsId; //数据源表/视图Id
objViewDgInfoENT.DgStyleId = objViewDgInfoENS.DgStyleId; //DG模式ID
objViewDgInfoENT.Style = objViewDgInfoENS.Style; //类型
objViewDgInfoENT.Runat = objViewDgInfoENS.Runat; //运行在
objViewDgInfoENT.FontSize = objViewDgInfoENS.FontSize; //字号
objViewDgInfoENT.FontName = objViewDgInfoENS.FontName; //字体
objViewDgInfoENT.Width = objViewDgInfoENS.Width; //宽
objViewDgInfoENT.Height = objViewDgInfoENS.Height; //高度
objViewDgInfoENT.AllowPaging = objViewDgInfoENS.AllowPaging; //允许分页
objViewDgInfoENT.PageSize = objViewDgInfoENS.PageSize; //页大小
objViewDgInfoENT.AutoGenerateColumns = objViewDgInfoENS.AutoGenerateColumns; //自动生成列
objViewDgInfoENT.AllowSorting = objViewDgInfoENS.AllowSorting; //允许排序
objViewDgInfoENT.IsRadio = objViewDgInfoENS.IsRadio; //是否单选框
objViewDgInfoENT.IsCheck = objViewDgInfoENS.IsCheck; //是否复选框
objViewDgInfoENT.IsHaveUpdBtn = objViewDgInfoENS.IsHaveUpdBtn; //是否有修改按钮
objViewDgInfoENT.IsHaveDelBtn = objViewDgInfoENS.IsHaveDelBtn; //是否有删除按钮
objViewDgInfoENT.IsHaveDetailBtn = objViewDgInfoENS.IsHaveDetailBtn; //是否有详细按钮
objViewDgInfoENT.IsJumpPage = objViewDgInfoENS.IsJumpPage; //是否跳页
objViewDgInfoENT.IsInTab = objViewDgInfoENS.IsInTab; //是否生成DG在表中
objViewDgInfoENT.StyleZindex = objViewDgInfoENS.StyleZindex; //Style_Zindex
objViewDgInfoENT.StyleLeft = objViewDgInfoENS.StyleLeft; //Style_Left
objViewDgInfoENT.StylePosition = objViewDgInfoENS.StylePosition; //Style_Position
objViewDgInfoENT.StyleTop = objViewDgInfoENS.StyleTop; //Style_Top
objViewDgInfoENT.SqlDsTypeId = objViewDgInfoENS.SqlDsTypeId; //数据源类型Id
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
 /// <param name = "objViewDgInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsViewDgInfoEN objViewDgInfoEN)
{
try
{
objViewDgInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewDgInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewDgInfo.ViewDgID, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.ViewDgID = objViewDgInfoEN.ViewDgID; //界面DgId
}
if (arrFldSet.Contains(conViewDgInfo.ViewDgName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.ViewDgName = objViewDgInfoEN.ViewDgName; //界面Dg名称
}
if (arrFldSet.Contains(conViewDgInfo.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.ViewId = objViewDgInfoEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewDgInfo.SqlDsId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.SqlDsId = objViewDgInfoEN.SqlDsId == "[null]" ? null :  objViewDgInfoEN.SqlDsId; //数据源表/视图Id
}
if (arrFldSet.Contains(conViewDgInfo.DgStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.DgStyleId = objViewDgInfoEN.DgStyleId; //DG模式ID
}
if (arrFldSet.Contains(conViewDgInfo.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.Style = objViewDgInfoEN.Style == "[null]" ? null :  objViewDgInfoEN.Style; //类型
}
if (arrFldSet.Contains(conViewDgInfo.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.Runat = objViewDgInfoEN.Runat == "[null]" ? null :  objViewDgInfoEN.Runat; //运行在
}
if (arrFldSet.Contains(conViewDgInfo.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.FontSize = objViewDgInfoEN.FontSize == "[null]" ? null :  objViewDgInfoEN.FontSize; //字号
}
if (arrFldSet.Contains(conViewDgInfo.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.FontName = objViewDgInfoEN.FontName == "[null]" ? null :  objViewDgInfoEN.FontName; //字体
}
if (arrFldSet.Contains(conViewDgInfo.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.Width = objViewDgInfoEN.Width; //宽
}
if (arrFldSet.Contains(conViewDgInfo.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.Height = objViewDgInfoEN.Height; //高度
}
if (arrFldSet.Contains(conViewDgInfo.AllowPaging, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.AllowPaging = objViewDgInfoEN.AllowPaging; //允许分页
}
if (arrFldSet.Contains(conViewDgInfo.PageSize, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.PageSize = objViewDgInfoEN.PageSize; //页大小
}
if (arrFldSet.Contains(conViewDgInfo.AutoGenerateColumns, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.AutoGenerateColumns = objViewDgInfoEN.AutoGenerateColumns; //自动生成列
}
if (arrFldSet.Contains(conViewDgInfo.AllowSorting, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.AllowSorting = objViewDgInfoEN.AllowSorting; //允许排序
}
if (arrFldSet.Contains(conViewDgInfo.IsRadio, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsRadio = objViewDgInfoEN.IsRadio; //是否单选框
}
if (arrFldSet.Contains(conViewDgInfo.IsCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsCheck = objViewDgInfoEN.IsCheck; //是否复选框
}
if (arrFldSet.Contains(conViewDgInfo.IsHaveUpdBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsHaveUpdBtn = objViewDgInfoEN.IsHaveUpdBtn; //是否有修改按钮
}
if (arrFldSet.Contains(conViewDgInfo.IsHaveDelBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsHaveDelBtn = objViewDgInfoEN.IsHaveDelBtn; //是否有删除按钮
}
if (arrFldSet.Contains(conViewDgInfo.IsHaveDetailBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsHaveDetailBtn = objViewDgInfoEN.IsHaveDetailBtn; //是否有详细按钮
}
if (arrFldSet.Contains(conViewDgInfo.IsJumpPage, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsJumpPage = objViewDgInfoEN.IsJumpPage; //是否跳页
}
if (arrFldSet.Contains(conViewDgInfo.IsInTab, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.IsInTab = objViewDgInfoEN.IsInTab; //是否生成DG在表中
}
if (arrFldSet.Contains(conViewDgInfo.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.StyleZindex = objViewDgInfoEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conViewDgInfo.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.StyleLeft = objViewDgInfoEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conViewDgInfo.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.StylePosition = objViewDgInfoEN.StylePosition == "[null]" ? null :  objViewDgInfoEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conViewDgInfo.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.StyleTop = objViewDgInfoEN.StyleTop; //Style_Top
}
if (arrFldSet.Contains(conViewDgInfo.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewDgInfoEN.SqlDsTypeId = objViewDgInfoEN.SqlDsTypeId; //数据源类型Id
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
 /// <param name = "objViewDgInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewDgInfoEN objViewDgInfoEN)
{
try
{
if (objViewDgInfoEN.SqlDsId == "[null]") objViewDgInfoEN.SqlDsId = null; //数据源表/视图Id
if (objViewDgInfoEN.Style == "[null]") objViewDgInfoEN.Style = null; //类型
if (objViewDgInfoEN.Runat == "[null]") objViewDgInfoEN.Runat = null; //运行在
if (objViewDgInfoEN.FontSize == "[null]") objViewDgInfoEN.FontSize = null; //字号
if (objViewDgInfoEN.FontName == "[null]") objViewDgInfoEN.FontName = null; //字体
if (objViewDgInfoEN.StylePosition == "[null]") objViewDgInfoEN.StylePosition = null; //Style_Position
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
public static void CheckPropertyNew(clsViewDgInfoEN objViewDgInfoEN)
{
 ViewDgInfoDA.CheckPropertyNew(objViewDgInfoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewDgInfoEN objViewDgInfoEN)
{
 ViewDgInfoDA.CheckProperty4Condition(objViewDgInfoEN);
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
if (clsViewDgInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewDgInfoBL没有刷新缓存机制(clsViewDgInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewDgID");
//if (arrViewDgInfoObjLstCache == null)
//{
//arrViewDgInfoObjLstCache = ViewDgInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewDgID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewDgInfoEN GetObjByViewDgIDCache(string strViewDgID)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrViewDgInfoObjLst_Sel =
arrViewDgInfoObjLstCache
.Where(x=> x.ViewDgID == strViewDgID 
);
if (arrViewDgInfoObjLst_Sel.Count() == 0)
{
   clsViewDgInfoEN obj = clsViewDgInfoBL.GetObjByViewDgID(strViewDgID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewDgInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewDgInfoEN> GetAllViewDgInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = GetObjLstCache(); 
return arrViewDgInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewDgInfoObjLstCache;
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
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewDgInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewDgInfoEN._RefreshTimeLst.Count == 0) return "";
return clsViewDgInfoEN._RefreshTimeLst[clsViewDgInfoEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsViewDgInfoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewDgInfoEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewDgInfoBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewDgInfo(视图Dg)
 /// 唯一性条件:ViewDgName_ViewId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewDgInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewDgInfoEN objViewDgInfoEN)
{
//检测记录是否存在
string strResult = ViewDgInfoDA.GetUniCondStr(objViewDgInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strViewDgID)
{
if (strInFldName != conViewDgInfo.ViewDgID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewDgInfo._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewDgInfo._AttributeName));
throw new Exception(strMsg);
}
var objViewDgInfo = clsViewDgInfoBL.GetObjByViewDgIDCache(strViewDgID);
if (objViewDgInfo == null) return "";
return objViewDgInfo[strOutFldName].ToString();
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
int intRecCount = clsViewDgInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsViewDgInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewDgInfoDA.GetRecCount();
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
int intRecCount = clsViewDgInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewDgInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewDgInfoEN objViewDgInfoCond)
{
List<clsViewDgInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewDgInfo._AttributeName)
{
if (objViewDgInfoCond.IsUpdated(strFldName) == false) continue;
if (objViewDgInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewDgInfoCond[strFldName].ToString());
}
else
{
if (objViewDgInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewDgInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewDgInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewDgInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewDgInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewDgInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewDgInfoCond[strFldName]));
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
 List<string> arrList = clsViewDgInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewDgInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewDgInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewDgInfoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewDgInfoDA.SetFldValue(clsViewDgInfoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewDgInfoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewDgInfoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewDgInfoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewDgInfoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewDgInfo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面DgId*/ 
 strCreateTabCode.Append(" ViewDgID varchar(10) primary key, "); 
 // /**界面Dg名称*/ 
 strCreateTabCode.Append(" ViewDgName varchar(100) not Null, "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) not Null, "); 
 // /**数据源表/视图Id*/ 
 strCreateTabCode.Append(" SqlDsId varchar(8) Null, "); 
 // /**DG模式ID*/ 
 strCreateTabCode.Append(" DgStyleId varchar(4) not Null, "); 
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
 // /**允许分页*/ 
 strCreateTabCode.Append(" AllowPaging bit not Null, "); 
 // /**页大小*/ 
 strCreateTabCode.Append(" PageSize int Null, "); 
 // /**自动生成列*/ 
 strCreateTabCode.Append(" AutoGenerateColumns bit not Null, "); 
 // /**允许排序*/ 
 strCreateTabCode.Append(" AllowSorting bit not Null, "); 
 // /**是否单选框*/ 
 strCreateTabCode.Append(" IsRadio bit Null, "); 
 // /**是否复选框*/ 
 strCreateTabCode.Append(" IsCheck bit Null, "); 
 // /**是否有修改按钮*/ 
 strCreateTabCode.Append(" IsHaveUpdBtn bit Null, "); 
 // /**是否有删除按钮*/ 
 strCreateTabCode.Append(" IsHaveDelBtn bit Null, "); 
 // /**是否有详细按钮*/ 
 strCreateTabCode.Append(" IsHaveDetailBtn bit Null, "); 
 // /**是否跳页*/ 
 strCreateTabCode.Append(" IsJumpPage bit Null, "); 
 // /**是否生成DG在表中*/ 
 strCreateTabCode.Append(" IsInTab bit Null, "); 
 // /**Style_Zindex*/ 
 strCreateTabCode.Append(" StyleZindex int Null, "); 
 // /**Style_Left*/ 
 strCreateTabCode.Append(" StyleLeft int Null, "); 
 // /**Style_Position*/ 
 strCreateTabCode.Append(" StylePosition varchar(20) Null, "); 
 // /**Style_Top*/ 
 strCreateTabCode.Append(" StyleTop int Null, "); 
 // /**数据源类型Id*/ 
 strCreateTabCode.Append(" SqlDsTypeId char(2) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 视图Dg(ViewDgInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewDgInfo : clsCommFun4BL
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
clsViewDgInfoBL.ReFreshThisCache();
}
}

}