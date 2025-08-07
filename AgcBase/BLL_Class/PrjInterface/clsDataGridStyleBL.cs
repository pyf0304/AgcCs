
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataGridStyleBL
 表名:DataGridStyle(00050005)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:15
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
public static class  clsDataGridStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDgStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataGridStyleEN GetObj(this K_DgStyleId_DataGridStyle myKey)
{
clsDataGridStyleEN objDataGridStyleEN = clsDataGridStyleBL.DataGridStyleDA.GetObjByDgStyleId(myKey.Value);
return objDataGridStyleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataGridStyleBL.IsExist(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataGridStyleEN.DgStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDataGridStyleBL.DataGridStyleDA.AddNewRecordBySQL2(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
public static bool AddRecordEx(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDataGridStyleBL.IsExist(objDataGridStyleEN.DgStyleId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDataGridStyleEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDataGridStyleEN.AddNewRecord();
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataGridStyleBL.IsExist(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataGridStyleEN.DgStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDataGridStyleBL.DataGridStyleDA.AddNewRecordBySQL2WithReturnKey(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetDgStyleId(this clsDataGridStyleEN objDataGridStyleEN, string strDgStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, conDataGridStyle.DgStyleId);
}
objDataGridStyleEN.DgStyleId = strDgStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.DgStyleId) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.DgStyleId, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.DgStyleId] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetDgStyleName(this clsDataGridStyleEN objDataGridStyleEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleName, conDataGridStyle.DgStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgStyleName, 30, conDataGridStyle.DgStyleName);
}
objDataGridStyleEN.DgStyleName = strDgStyleName; //DG模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.DgStyleName) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.DgStyleName, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.DgStyleName] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetRunat(this clsDataGridStyleEN objDataGridStyleEN, string strRunat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRunat, 30, conDataGridStyle.Runat);
}
objDataGridStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.Runat) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.Runat, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.Runat] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetFontSize(this clsDataGridStyleEN objDataGridStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, conDataGridStyle.FontSize);
}
objDataGridStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.FontSize) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.FontSize, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.FontSize] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetFontName(this clsDataGridStyleEN objDataGridStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, conDataGridStyle.FontName);
}
objDataGridStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.FontName) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.FontName, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.FontName] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetAllowPaging(this clsDataGridStyleEN objDataGridStyleEN, bool bolAllowPaging, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowPaging, conDataGridStyle.AllowPaging);
objDataGridStyleEN.AllowPaging = bolAllowPaging; //允许分页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.AllowPaging) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.AllowPaging, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.AllowPaging] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetPageSize(this clsDataGridStyleEN objDataGridStyleEN, int? intPageSize, string strComparisonOp="")
	{
objDataGridStyleEN.PageSize = intPageSize; //页大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.PageSize) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.PageSize, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.PageSize] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetAutoGenerateColumns(this clsDataGridStyleEN objDataGridStyleEN, bool bolAutoGenerateColumns, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAutoGenerateColumns, conDataGridStyle.AutoGenerateColumns);
objDataGridStyleEN.AutoGenerateColumns = bolAutoGenerateColumns; //自动生成列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.AutoGenerateColumns) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.AutoGenerateColumns, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.AutoGenerateColumns] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetAllowSorting(this clsDataGridStyleEN objDataGridStyleEN, bool bolAllowSorting, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowSorting, conDataGridStyle.AllowSorting);
objDataGridStyleEN.AllowSorting = bolAllowSorting; //允许排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.AllowSorting) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.AllowSorting, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.AllowSorting] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsRadio(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsRadio, string strComparisonOp="")
	{
objDataGridStyleEN.IsRadio = bolIsRadio; //是否单选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsRadio) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsRadio, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsRadio] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsCheck(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsCheck, string strComparisonOp="")
	{
objDataGridStyleEN.IsCheck = bolIsCheck; //是否复选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsCheck) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsCheck, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsCheck] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsJumpPage(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsJumpPage, string strComparisonOp="")
	{
objDataGridStyleEN.IsJumpPage = bolIsJumpPage; //是否跳页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsJumpPage) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsJumpPage, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsJumpPage] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsHaveUpdBtn(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsHaveUpdBtn, string strComparisonOp="")
	{
objDataGridStyleEN.IsHaveUpdBtn = bolIsHaveUpdBtn; //是否有修改按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsHaveUpdBtn) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsHaveUpdBtn, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsHaveUpdBtn] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsHaveDelBtn(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsHaveDelBtn, string strComparisonOp="")
	{
objDataGridStyleEN.IsHaveDelBtn = bolIsHaveDelBtn; //是否有删除按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsHaveDelBtn) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsHaveDelBtn, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsHaveDelBtn] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsHaveDetailBtn(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsHaveDetailBtn, string strComparisonOp="")
	{
objDataGridStyleEN.IsHaveDetailBtn = bolIsHaveDetailBtn; //是否有详细按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsHaveDetailBtn) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsHaveDetailBtn, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsHaveDetailBtn] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsInTab(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsInTab, string strComparisonOp="")
	{
objDataGridStyleEN.IsInTab = bolIsInTab; //是否生成DG在表中
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsInTab) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsInTab, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsInTab] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleZindex(this clsDataGridStyleEN objDataGridStyleEN, int? intStyleZindex, string strComparisonOp="")
	{
objDataGridStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.StyleZindex) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.StyleZindex, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.StyleZindex] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleLeft(this clsDataGridStyleEN objDataGridStyleEN, int? intStyleLeft, string strComparisonOp="")
	{
objDataGridStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.StyleLeft) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.StyleLeft, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.StyleLeft] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStylePosition(this clsDataGridStyleEN objDataGridStyleEN, string strStylePosition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conDataGridStyle.StylePosition);
}
objDataGridStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.StylePosition) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.StylePosition, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.StylePosition] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetWidth(this clsDataGridStyleEN objDataGridStyleEN, int? intWidth, string strComparisonOp="")
	{
objDataGridStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.Width) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.Width, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.Width] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetHeight(this clsDataGridStyleEN objDataGridStyleEN, int? intHeight, string strComparisonOp="")
	{
objDataGridStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.Height) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.Height, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.Height] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleTop(this clsDataGridStyleEN objDataGridStyleEN, int? intStyleTop, string strComparisonOp="")
	{
objDataGridStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.StyleTop) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.StyleTop, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.StyleTop] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyle(this clsDataGridStyleEN objDataGridStyleEN, string strStyle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyle, 800, conDataGridStyle.Style);
}
objDataGridStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.Style) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.Style, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.Style] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetIsDefault(this clsDataGridStyleEN objDataGridStyleEN, bool bolIsDefault, string strComparisonOp="")
	{
objDataGridStyleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataGridStyleEN.dicFldComparisonOp.ContainsKey(conDataGridStyle.IsDefault) == false)
{
objDataGridStyleEN.dicFldComparisonOp.Add(conDataGridStyle.IsDefault, strComparisonOp);
}
else
{
objDataGridStyleEN.dicFldComparisonOp[conDataGridStyle.IsDefault] = strComparisonOp;
}
}
return objDataGridStyleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDataGridStyleEN objDataGridStyleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDataGridStyleEN.CheckPropertyNew();
clsDataGridStyleEN objDataGridStyleCond = new clsDataGridStyleEN();
string strCondition = objDataGridStyleCond
.SetDgStyleId(objDataGridStyleEN.DgStyleId, "=")
.GetCombineCondition();
objDataGridStyleEN._IsCheckProperty = true;
bool bolIsExist = clsDataGridStyleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDataGridStyleEN.Update();
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataGridStyleEN objDataGridStyleEN)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataGridStyleBL.DataGridStyleDA.UpdateBySql2(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataGridStyleEN objDataGridStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDataGridStyleBL.DataGridStyleDA.UpdateBySql2(objDataGridStyleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataGridStyleEN objDataGridStyleEN, string strWhereCond)
{
try
{
bool bolResult = clsDataGridStyleBL.DataGridStyleDA.UpdateBySqlWithCondition(objDataGridStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataGridStyleEN objDataGridStyleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDataGridStyleBL.DataGridStyleDA.UpdateBySqlWithConditionTransaction(objDataGridStyleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDataGridStyleEN objDataGridStyleEN)
{
try
{
int intRecNum = clsDataGridStyleBL.DataGridStyleDA.DelRecord(objDataGridStyleEN.DgStyleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleENS">源对象</param>
 /// <param name = "objDataGridStyleENT">目标对象</param>
 public static void CopyTo(this clsDataGridStyleEN objDataGridStyleENS, clsDataGridStyleEN objDataGridStyleENT)
{
try
{
objDataGridStyleENT.DgStyleId = objDataGridStyleENS.DgStyleId; //DG模式ID
objDataGridStyleENT.DgStyleName = objDataGridStyleENS.DgStyleName; //DG模式名
objDataGridStyleENT.Runat = objDataGridStyleENS.Runat; //运行在
objDataGridStyleENT.FontSize = objDataGridStyleENS.FontSize; //字号
objDataGridStyleENT.FontName = objDataGridStyleENS.FontName; //字体
objDataGridStyleENT.AllowPaging = objDataGridStyleENS.AllowPaging; //允许分页
objDataGridStyleENT.PageSize = objDataGridStyleENS.PageSize; //页大小
objDataGridStyleENT.AutoGenerateColumns = objDataGridStyleENS.AutoGenerateColumns; //自动生成列
objDataGridStyleENT.AllowSorting = objDataGridStyleENS.AllowSorting; //允许排序
objDataGridStyleENT.IsRadio = objDataGridStyleENS.IsRadio; //是否单选框
objDataGridStyleENT.IsCheck = objDataGridStyleENS.IsCheck; //是否复选框
objDataGridStyleENT.IsJumpPage = objDataGridStyleENS.IsJumpPage; //是否跳页
objDataGridStyleENT.IsHaveUpdBtn = objDataGridStyleENS.IsHaveUpdBtn; //是否有修改按钮
objDataGridStyleENT.IsHaveDelBtn = objDataGridStyleENS.IsHaveDelBtn; //是否有删除按钮
objDataGridStyleENT.IsHaveDetailBtn = objDataGridStyleENS.IsHaveDetailBtn; //是否有详细按钮
objDataGridStyleENT.IsInTab = objDataGridStyleENS.IsInTab; //是否生成DG在表中
objDataGridStyleENT.StyleZindex = objDataGridStyleENS.StyleZindex; //Style_Zindex
objDataGridStyleENT.StyleLeft = objDataGridStyleENS.StyleLeft; //Style_Left
objDataGridStyleENT.StylePosition = objDataGridStyleENS.StylePosition; //Style_Position
objDataGridStyleENT.Width = objDataGridStyleENS.Width; //宽
objDataGridStyleENT.Height = objDataGridStyleENS.Height; //高度
objDataGridStyleENT.StyleTop = objDataGridStyleENS.StyleTop; //Style_Top
objDataGridStyleENT.Style = objDataGridStyleENS.Style; //类型
objDataGridStyleENT.IsDefault = objDataGridStyleENS.IsDefault; //是否默认
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
 /// <param name = "objDataGridStyleENS">源对象</param>
 /// <returns>目标对象=>clsDataGridStyleEN:objDataGridStyleENT</returns>
 public static clsDataGridStyleEN CopyTo(this clsDataGridStyleEN objDataGridStyleENS)
{
try
{
 clsDataGridStyleEN objDataGridStyleENT = new clsDataGridStyleEN()
{
DgStyleId = objDataGridStyleENS.DgStyleId, //DG模式ID
DgStyleName = objDataGridStyleENS.DgStyleName, //DG模式名
Runat = objDataGridStyleENS.Runat, //运行在
FontSize = objDataGridStyleENS.FontSize, //字号
FontName = objDataGridStyleENS.FontName, //字体
AllowPaging = objDataGridStyleENS.AllowPaging, //允许分页
PageSize = objDataGridStyleENS.PageSize, //页大小
AutoGenerateColumns = objDataGridStyleENS.AutoGenerateColumns, //自动生成列
AllowSorting = objDataGridStyleENS.AllowSorting, //允许排序
IsRadio = objDataGridStyleENS.IsRadio, //是否单选框
IsCheck = objDataGridStyleENS.IsCheck, //是否复选框
IsJumpPage = objDataGridStyleENS.IsJumpPage, //是否跳页
IsHaveUpdBtn = objDataGridStyleENS.IsHaveUpdBtn, //是否有修改按钮
IsHaveDelBtn = objDataGridStyleENS.IsHaveDelBtn, //是否有删除按钮
IsHaveDetailBtn = objDataGridStyleENS.IsHaveDetailBtn, //是否有详细按钮
IsInTab = objDataGridStyleENS.IsInTab, //是否生成DG在表中
StyleZindex = objDataGridStyleENS.StyleZindex, //Style_Zindex
StyleLeft = objDataGridStyleENS.StyleLeft, //Style_Left
StylePosition = objDataGridStyleENS.StylePosition, //Style_Position
Width = objDataGridStyleENS.Width, //宽
Height = objDataGridStyleENS.Height, //高度
StyleTop = objDataGridStyleENS.StyleTop, //Style_Top
Style = objDataGridStyleENS.Style, //类型
IsDefault = objDataGridStyleENS.IsDefault, //是否默认
};
 return objDataGridStyleENT;
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
public static void CheckPropertyNew(this clsDataGridStyleEN objDataGridStyleEN)
{
 clsDataGridStyleBL.DataGridStyleDA.CheckPropertyNew(objDataGridStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDataGridStyleEN objDataGridStyleEN)
{
 clsDataGridStyleBL.DataGridStyleDA.CheckProperty4Condition(objDataGridStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataGridStyleEN objDataGridStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.DgStyleId) == true)
{
string strComparisonOpDgStyleId = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.DgStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.DgStyleId, objDataGridStyleCond.DgStyleId, strComparisonOpDgStyleId);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.DgStyleName) == true)
{
string strComparisonOpDgStyleName = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.DgStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.DgStyleName, objDataGridStyleCond.DgStyleName, strComparisonOpDgStyleName);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.Runat) == true)
{
string strComparisonOpRunat = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.Runat, objDataGridStyleCond.Runat, strComparisonOpRunat);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.FontSize) == true)
{
string strComparisonOpFontSize = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.FontSize, objDataGridStyleCond.FontSize, strComparisonOpFontSize);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.FontName) == true)
{
string strComparisonOpFontName = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.FontName, objDataGridStyleCond.FontName, strComparisonOpFontName);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.AllowPaging) == true)
{
if (objDataGridStyleCond.AllowPaging == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.AllowPaging);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.AllowPaging);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.PageSize) == true)
{
string strComparisonOpPageSize = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.PageSize];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.PageSize, objDataGridStyleCond.PageSize, strComparisonOpPageSize);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.AutoGenerateColumns) == true)
{
if (objDataGridStyleCond.AutoGenerateColumns == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.AutoGenerateColumns);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.AutoGenerateColumns);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.AllowSorting) == true)
{
if (objDataGridStyleCond.AllowSorting == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.AllowSorting);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.AllowSorting);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsRadio) == true)
{
if (objDataGridStyleCond.IsRadio == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsRadio);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsRadio);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsCheck) == true)
{
if (objDataGridStyleCond.IsCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsCheck);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsJumpPage) == true)
{
if (objDataGridStyleCond.IsJumpPage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsJumpPage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsJumpPage);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsHaveUpdBtn) == true)
{
if (objDataGridStyleCond.IsHaveUpdBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsHaveUpdBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsHaveUpdBtn);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsHaveDelBtn) == true)
{
if (objDataGridStyleCond.IsHaveDelBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsHaveDelBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsHaveDelBtn);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsHaveDetailBtn) == true)
{
if (objDataGridStyleCond.IsHaveDetailBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsHaveDetailBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsHaveDetailBtn);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsInTab) == true)
{
if (objDataGridStyleCond.IsInTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsInTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsInTab);
}
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.StyleZindex, objDataGridStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.StyleLeft, objDataGridStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.StylePosition, objDataGridStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.Width) == true)
{
string strComparisonOpWidth = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.Width, objDataGridStyleCond.Width, strComparisonOpWidth);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.Height) == true)
{
string strComparisonOpHeight = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.Height, objDataGridStyleCond.Height, strComparisonOpHeight);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conDataGridStyle.StyleTop, objDataGridStyleCond.StyleTop, strComparisonOpStyleTop);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.Style) == true)
{
string strComparisonOpStyle = objDataGridStyleCond.dicFldComparisonOp[conDataGridStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataGridStyle.Style, objDataGridStyleCond.Style, strComparisonOpStyle);
}
if (objDataGridStyleCond.IsUpdated(conDataGridStyle.IsDefault) == true)
{
if (objDataGridStyleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDataGridStyle.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDataGridStyle.IsDefault);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DataGridStyle
{
public virtual bool UpdRelaTabDate(string strDgStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDataGridStyleBL
{
public static RelatedActions_DataGridStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDataGridStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDataGridStyleDA DataGridStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDataGridStyleDA();
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
 public clsDataGridStyleBL()
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
if (string.IsNullOrEmpty(clsDataGridStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataGridStyleEN._ConnectString);
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
public static DataTable GetDataTable_DataGridStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DataGridStyleDA.GetDataTable_DataGridStyle(strWhereCond);
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
objDT = DataGridStyleDA.GetDataTable(strWhereCond);
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
objDT = DataGridStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DataGridStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DataGridStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DataGridStyleDA.GetDataTable_Top(objTopPara);
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
objDT = DataGridStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DataGridStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DataGridStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDgStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByDgStyleIdLst(List<string> arrDgStyleIdLst)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDgStyleIdLst, true);
 string strWhereCond = string.Format("DgStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDgStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDataGridStyleEN> GetObjLstByDgStyleIdLstCache(List<string> arrDgStyleIdLst)
{
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel =
arrDataGridStyleObjLstCache
.Where(x => arrDgStyleIdLst.Contains(x.DgStyleId));
return arrDataGridStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLst(string strWhereCond)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
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
public static List<clsDataGridStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDataGridStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDataGridStyleEN> GetSubObjLstCache(clsDataGridStyleEN objDataGridStyleCond)
{
List<clsDataGridStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataGridStyle._AttributeName)
{
if (objDataGridStyleCond.IsUpdated(strFldName) == false) continue;
if (objDataGridStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataGridStyleCond[strFldName].ToString());
}
else
{
if (objDataGridStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataGridStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataGridStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataGridStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataGridStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataGridStyleCond[strFldName]));
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
public static List<clsDataGridStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
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
public static List<clsDataGridStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
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
List<clsDataGridStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDataGridStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDataGridStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
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
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
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
public static List<clsDataGridStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDataGridStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
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
public static List<clsDataGridStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDataGridStyleEN.DgStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDataGridStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDataGridStyle(ref clsDataGridStyleEN objDataGridStyleEN)
{
bool bolResult = DataGridStyleDA.GetDataGridStyle(ref objDataGridStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDgStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataGridStyleEN GetObjByDgStyleId(string strDgStyleId)
{
if (strDgStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDgStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDgStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDgStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDataGridStyleEN objDataGridStyleEN = DataGridStyleDA.GetObjByDgStyleId(strDgStyleId);
return objDataGridStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDataGridStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDataGridStyleEN objDataGridStyleEN = DataGridStyleDA.GetFirstObj(strWhereCond);
 return objDataGridStyleEN;
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
public static clsDataGridStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDataGridStyleEN objDataGridStyleEN = DataGridStyleDA.GetObjByDataRow(objRow);
 return objDataGridStyleEN;
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
public static clsDataGridStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDataGridStyleEN objDataGridStyleEN = DataGridStyleDA.GetObjByDataRow(objRow);
 return objDataGridStyleEN;
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
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <param name = "lstDataGridStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataGridStyleEN GetObjByDgStyleIdFromList(string strDgStyleId, List<clsDataGridStyleEN> lstDataGridStyleObjLst)
{
foreach (clsDataGridStyleEN objDataGridStyleEN in lstDataGridStyleObjLst)
{
if (objDataGridStyleEN.DgStyleId == strDgStyleId)
{
return objDataGridStyleEN;
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
 string strDgStyleId;
 try
 {
 strDgStyleId = new clsDataGridStyleDA().GetFirstID(strWhereCond);
 return strDgStyleId;
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
 arrList = DataGridStyleDA.GetID(strWhereCond);
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
bool bolIsExist = DataGridStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDgStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DataGridStyleDA.IsExist(strDgStyleId);
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
 bolIsExist = clsDataGridStyleDA.IsExistTable();
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
 bolIsExist = DataGridStyleDA.IsExistTable(strTabName);
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDataGridStyleEN objDataGridStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataGridStyleBL.IsExist(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataGridStyleEN.DgStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DataGridStyleDA.AddNewRecordBySQL2(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDataGridStyleEN objDataGridStyleEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataGridStyleBL.IsExist(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataGridStyleEN.DgStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DataGridStyleDA.AddNewRecordBySQL2WithReturnKey(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDataGridStyleEN objDataGridStyleEN)
{
try
{
bool bolResult = DataGridStyleDA.Update(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDataGridStyleEN objDataGridStyleEN)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DataGridStyleDA.UpdateBySql2(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleBL.ReFreshCache();

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
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
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDgStyleId)
{
try
{
 clsDataGridStyleEN objDataGridStyleEN = clsDataGridStyleBL.GetObjByDgStyleId(strDgStyleId);

if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(objDataGridStyleEN.DgStyleId, "SetUpdDate");
}
if (objDataGridStyleEN != null)
{
int intRecNum = DataGridStyleDA.DelRecord(strDgStyleId);
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
/// <param name="strDgStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDgStyleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
//删除与表:[DataGridStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDataGridStyle.DgStyleId,
//strDgStyleId);
//        clsDataGridStyleBL.DelDataGridStylesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataGridStyleBL.DelRecord(strDgStyleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataGridStyleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDgStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDgStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDataGridStyleBL.relatedActions != null)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(strDgStyleId, "UpdRelaTabDate");
}
bool bolResult = DataGridStyleDA.DelRecord(strDgStyleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDgStyleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDataGridStyles(List<string> arrDgStyleIdLst)
{
if (arrDgStyleIdLst.Count == 0) return 0;
try
{
if (clsDataGridStyleBL.relatedActions != null)
{
foreach (var strDgStyleId in arrDgStyleIdLst)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(strDgStyleId, "UpdRelaTabDate");
}
}
int intDelRecNum = DataGridStyleDA.DelDataGridStyle(arrDgStyleIdLst);
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
public static int DelDataGridStylesByCond(string strWhereCond)
{
try
{
if (clsDataGridStyleBL.relatedActions != null)
{
List<string> arrDgStyleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDgStyleId in arrDgStyleId)
{
clsDataGridStyleBL.relatedActions.UpdRelaTabDate(strDgStyleId, "UpdRelaTabDate");
}
}
int intRecNum = DataGridStyleDA.DelDataGridStyle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DataGridStyle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDgStyleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDgStyleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
//删除与表:[DataGridStyle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDataGridStyleBL.DelRecord(strDgStyleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDataGridStyleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDgStyleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDataGridStyleENS">源对象</param>
 /// <param name = "objDataGridStyleENT">目标对象</param>
 public static void CopyTo(clsDataGridStyleEN objDataGridStyleENS, clsDataGridStyleEN objDataGridStyleENT)
{
try
{
objDataGridStyleENT.DgStyleId = objDataGridStyleENS.DgStyleId; //DG模式ID
objDataGridStyleENT.DgStyleName = objDataGridStyleENS.DgStyleName; //DG模式名
objDataGridStyleENT.Runat = objDataGridStyleENS.Runat; //运行在
objDataGridStyleENT.FontSize = objDataGridStyleENS.FontSize; //字号
objDataGridStyleENT.FontName = objDataGridStyleENS.FontName; //字体
objDataGridStyleENT.AllowPaging = objDataGridStyleENS.AllowPaging; //允许分页
objDataGridStyleENT.PageSize = objDataGridStyleENS.PageSize; //页大小
objDataGridStyleENT.AutoGenerateColumns = objDataGridStyleENS.AutoGenerateColumns; //自动生成列
objDataGridStyleENT.AllowSorting = objDataGridStyleENS.AllowSorting; //允许排序
objDataGridStyleENT.IsRadio = objDataGridStyleENS.IsRadio; //是否单选框
objDataGridStyleENT.IsCheck = objDataGridStyleENS.IsCheck; //是否复选框
objDataGridStyleENT.IsJumpPage = objDataGridStyleENS.IsJumpPage; //是否跳页
objDataGridStyleENT.IsHaveUpdBtn = objDataGridStyleENS.IsHaveUpdBtn; //是否有修改按钮
objDataGridStyleENT.IsHaveDelBtn = objDataGridStyleENS.IsHaveDelBtn; //是否有删除按钮
objDataGridStyleENT.IsHaveDetailBtn = objDataGridStyleENS.IsHaveDetailBtn; //是否有详细按钮
objDataGridStyleENT.IsInTab = objDataGridStyleENS.IsInTab; //是否生成DG在表中
objDataGridStyleENT.StyleZindex = objDataGridStyleENS.StyleZindex; //Style_Zindex
objDataGridStyleENT.StyleLeft = objDataGridStyleENS.StyleLeft; //Style_Left
objDataGridStyleENT.StylePosition = objDataGridStyleENS.StylePosition; //Style_Position
objDataGridStyleENT.Width = objDataGridStyleENS.Width; //宽
objDataGridStyleENT.Height = objDataGridStyleENS.Height; //高度
objDataGridStyleENT.StyleTop = objDataGridStyleENS.StyleTop; //Style_Top
objDataGridStyleENT.Style = objDataGridStyleENS.Style; //类型
objDataGridStyleENT.IsDefault = objDataGridStyleENS.IsDefault; //是否默认
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
 /// <param name = "objDataGridStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsDataGridStyleEN objDataGridStyleEN)
{
try
{
objDataGridStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDataGridStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDataGridStyle.DgStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.DgStyleId = objDataGridStyleEN.DgStyleId; //DG模式ID
}
if (arrFldSet.Contains(conDataGridStyle.DgStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.DgStyleName = objDataGridStyleEN.DgStyleName; //DG模式名
}
if (arrFldSet.Contains(conDataGridStyle.Runat, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.Runat = objDataGridStyleEN.Runat == "[null]" ? null :  objDataGridStyleEN.Runat; //运行在
}
if (arrFldSet.Contains(conDataGridStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.FontSize = objDataGridStyleEN.FontSize == "[null]" ? null :  objDataGridStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(conDataGridStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.FontName = objDataGridStyleEN.FontName == "[null]" ? null :  objDataGridStyleEN.FontName; //字体
}
if (arrFldSet.Contains(conDataGridStyle.AllowPaging, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.AllowPaging = objDataGridStyleEN.AllowPaging; //允许分页
}
if (arrFldSet.Contains(conDataGridStyle.PageSize, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.PageSize = objDataGridStyleEN.PageSize; //页大小
}
if (arrFldSet.Contains(conDataGridStyle.AutoGenerateColumns, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.AutoGenerateColumns = objDataGridStyleEN.AutoGenerateColumns; //自动生成列
}
if (arrFldSet.Contains(conDataGridStyle.AllowSorting, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.AllowSorting = objDataGridStyleEN.AllowSorting; //允许排序
}
if (arrFldSet.Contains(conDataGridStyle.IsRadio, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsRadio = objDataGridStyleEN.IsRadio; //是否单选框
}
if (arrFldSet.Contains(conDataGridStyle.IsCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsCheck = objDataGridStyleEN.IsCheck; //是否复选框
}
if (arrFldSet.Contains(conDataGridStyle.IsJumpPage, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsJumpPage = objDataGridStyleEN.IsJumpPage; //是否跳页
}
if (arrFldSet.Contains(conDataGridStyle.IsHaveUpdBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsHaveUpdBtn = objDataGridStyleEN.IsHaveUpdBtn; //是否有修改按钮
}
if (arrFldSet.Contains(conDataGridStyle.IsHaveDelBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsHaveDelBtn = objDataGridStyleEN.IsHaveDelBtn; //是否有删除按钮
}
if (arrFldSet.Contains(conDataGridStyle.IsHaveDetailBtn, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsHaveDetailBtn = objDataGridStyleEN.IsHaveDetailBtn; //是否有详细按钮
}
if (arrFldSet.Contains(conDataGridStyle.IsInTab, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsInTab = objDataGridStyleEN.IsInTab; //是否生成DG在表中
}
if (arrFldSet.Contains(conDataGridStyle.StyleZindex, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.StyleZindex = objDataGridStyleEN.StyleZindex; //Style_Zindex
}
if (arrFldSet.Contains(conDataGridStyle.StyleLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.StyleLeft = objDataGridStyleEN.StyleLeft; //Style_Left
}
if (arrFldSet.Contains(conDataGridStyle.StylePosition, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.StylePosition = objDataGridStyleEN.StylePosition == "[null]" ? null :  objDataGridStyleEN.StylePosition; //Style_Position
}
if (arrFldSet.Contains(conDataGridStyle.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.Width = objDataGridStyleEN.Width; //宽
}
if (arrFldSet.Contains(conDataGridStyle.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.Height = objDataGridStyleEN.Height; //高度
}
if (arrFldSet.Contains(conDataGridStyle.StyleTop, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.StyleTop = objDataGridStyleEN.StyleTop; //Style_Top
}
if (arrFldSet.Contains(conDataGridStyle.Style, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.Style = objDataGridStyleEN.Style == "[null]" ? null :  objDataGridStyleEN.Style; //类型
}
if (arrFldSet.Contains(conDataGridStyle.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objDataGridStyleEN.IsDefault = objDataGridStyleEN.IsDefault; //是否默认
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
 /// <param name = "objDataGridStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsDataGridStyleEN objDataGridStyleEN)
{
try
{
if (objDataGridStyleEN.Runat == "[null]") objDataGridStyleEN.Runat = null; //运行在
if (objDataGridStyleEN.FontSize == "[null]") objDataGridStyleEN.FontSize = null; //字号
if (objDataGridStyleEN.FontName == "[null]") objDataGridStyleEN.FontName = null; //字体
if (objDataGridStyleEN.StylePosition == "[null]") objDataGridStyleEN.StylePosition = null; //Style_Position
if (objDataGridStyleEN.Style == "[null]") objDataGridStyleEN.Style = null; //类型
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
public static void CheckPropertyNew(clsDataGridStyleEN objDataGridStyleEN)
{
 DataGridStyleDA.CheckPropertyNew(objDataGridStyleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDataGridStyleEN objDataGridStyleEN)
{
 DataGridStyleDA.CheckProperty4Condition(objDataGridStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DgStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataGridStyle.DgStyleId); 
List<clsDataGridStyleEN> arrObjLst = clsDataGridStyleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN()
{
DgStyleId = "0",
DgStyleName = "选[DataGrid类型]..."
};
arrObjLst.Insert(0, objDataGridStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataGridStyle.DgStyleId;
objComboBox.DisplayMember = conDataGridStyle.DgStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[DataGrid类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conDataGridStyle.DgStyleId); 
IEnumerable<clsDataGridStyleEN> arrObjLst = clsDataGridStyleBL.GetObjLst(strCondition);
objDDL.DataValueField = conDataGridStyle.DgStyleId;
objDDL.DataTextField = conDataGridStyle.DgStyleName;
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
public static void BindDdl_DgStyleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[DataGrid类型]...","0");
List<clsDataGridStyleEN> arrDataGridStyleObjLst = GetAllDataGridStyleObjLstCache(); 
objDDL.DataValueField = conDataGridStyle.DgStyleId;
objDDL.DataTextField = conDataGridStyle.DgStyleName;
objDDL.DataSource = arrDataGridStyleObjLst;
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
if (clsDataGridStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataGridStyleBL没有刷新缓存机制(clsDataGridStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DgStyleId");
//if (arrDataGridStyleObjLstCache == null)
//{
//arrDataGridStyleObjLstCache = DataGridStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataGridStyleEN GetObjByDgStyleIdCache(string strDgStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel =
arrDataGridStyleObjLstCache
.Where(x=> x.DgStyleId == strDgStyleId 
);
if (arrDataGridStyleObjLst_Sel.Count() == 0)
{
   clsDataGridStyleEN obj = clsDataGridStyleBL.GetObjByDgStyleId(strDgStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDataGridStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDgStyleNameByDgStyleIdCache(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return "";
//获取缓存中的对象列表
clsDataGridStyleEN objDataGridStyle = GetObjByDgStyleIdCache(strDgStyleId);
if (objDataGridStyle == null) return "";
return objDataGridStyle.DgStyleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDgStyleIdCache(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return "";
//获取缓存中的对象列表
clsDataGridStyleEN objDataGridStyle = GetObjByDgStyleIdCache(strDgStyleId);
if (objDataGridStyle == null) return "";
return objDataGridStyle.DgStyleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataGridStyleEN> GetAllDataGridStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache(); 
return arrDataGridStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDataGridStyleObjLstCache;
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
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataGridStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDataGridStyleEN._RefreshTimeLst.Count == 0) return "";
return clsDataGridStyleEN._RefreshTimeLst[clsDataGridStyleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDataGridStyleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataGridStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDataGridStyleBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strDgStyleId)
{
if (strInFldName != conDataGridStyle.DgStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDataGridStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDataGridStyle._AttributeName));
throw new Exception(strMsg);
}
var objDataGridStyle = clsDataGridStyleBL.GetObjByDgStyleIdCache(strDgStyleId);
if (objDataGridStyle == null) return "";
return objDataGridStyle[strOutFldName].ToString();
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
int intRecCount = clsDataGridStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsDataGridStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDataGridStyleDA.GetRecCount();
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
int intRecCount = clsDataGridStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDataGridStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDataGridStyleEN objDataGridStyleCond)
{
List<clsDataGridStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDataGridStyle._AttributeName)
{
if (objDataGridStyleCond.IsUpdated(strFldName) == false) continue;
if (objDataGridStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataGridStyleCond[strFldName].ToString());
}
else
{
if (objDataGridStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDataGridStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDataGridStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDataGridStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDataGridStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDataGridStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDataGridStyleCond[strFldName]));
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
 List<string> arrList = clsDataGridStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DataGridStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DataGridStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DataGridStyleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataGridStyleDA.SetFldValue(clsDataGridStyleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DataGridStyleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataGridStyleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDataGridStyleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDataGridStyleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DataGridStyle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**DG模式ID*/ 
 strCreateTabCode.Append(" DgStyleId varchar(4) primary key, "); 
 // /**DG模式名*/ 
 strCreateTabCode.Append(" DgStyleName varchar(30) not Null, "); 
 // /**运行在*/ 
 strCreateTabCode.Append(" Runat varchar(30) Null, "); 
 // /**字号*/ 
 strCreateTabCode.Append(" FontSize varchar(20) Null, "); 
 // /**字体*/ 
 strCreateTabCode.Append(" FontName varchar(20) Null, "); 
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
 // /**是否跳页*/ 
 strCreateTabCode.Append(" IsJumpPage bit Null, "); 
 // /**是否有修改按钮*/ 
 strCreateTabCode.Append(" IsHaveUpdBtn bit Null, "); 
 // /**是否有删除按钮*/ 
 strCreateTabCode.Append(" IsHaveDelBtn bit Null, "); 
 // /**是否有详细按钮*/ 
 strCreateTabCode.Append(" IsHaveDetailBtn bit Null, "); 
 // /**是否生成DG在表中*/ 
 strCreateTabCode.Append(" IsInTab bit Null, "); 
 // /**Style_Zindex*/ 
 strCreateTabCode.Append(" StyleZindex int Null, "); 
 // /**Style_Left*/ 
 strCreateTabCode.Append(" StyleLeft int Null, "); 
 // /**Style_Position*/ 
 strCreateTabCode.Append(" StylePosition varchar(20) Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**Style_Top*/ 
 strCreateTabCode.Append(" StyleTop int Null, "); 
 // /**类型*/ 
 strCreateTabCode.Append(" Style varchar(800) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DataGridStyle : clsCommFun4BL
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
clsDataGridStyleBL.ReFreshThisCache();
}
}

}