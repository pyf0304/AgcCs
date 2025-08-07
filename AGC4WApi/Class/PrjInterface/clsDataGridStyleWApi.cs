
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataGridStyleWApi
 表名:DataGridStyle(00050005)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsDataGridStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleId">DG模式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetDgStyleId(this clsDataGridStyleEN objDataGridStyleEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgStyleId, 4, conDataGridStyle.DgStyleId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleName">DG模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetDgStyleName(this clsDataGridStyleEN objDataGridStyleEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleName, conDataGridStyle.DgStyleName);
clsCheckSql.CheckFieldLen(strDgStyleName, 30, conDataGridStyle.DgStyleName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRunat">运行在</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetRunat(this clsDataGridStyleEN objDataGridStyleEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRunat, 30, conDataGridStyle.Runat);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetFontSize(this clsDataGridStyleEN objDataGridStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, conDataGridStyle.FontSize);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetFontName(this clsDataGridStyleEN objDataGridStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, conDataGridStyle.FontName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAllowPaging">允许分页</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intPageSize">页大小</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetPageSize(this clsDataGridStyleEN objDataGridStyleEN, int intPageSize, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAutoGenerateColumns">自动生成列</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAllowSorting">允许排序</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRadio">是否单选框</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCheck">是否复选框</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJumpPage">是否跳页</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveUpdBtn">是否有修改按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDelBtn">是否有删除按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDetailBtn">是否有详细按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInTab">是否生成DG在表中</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleZindex">Style_Zindex</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleZindex(this clsDataGridStyleEN objDataGridStyleEN, int intStyleZindex, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleLeft">Style_Left</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleLeft(this clsDataGridStyleEN objDataGridStyleEN, int intStyleLeft, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStylePosition">Style_Position</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStylePosition(this clsDataGridStyleEN objDataGridStyleEN, string strStylePosition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conDataGridStyle.StylePosition);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetWidth(this clsDataGridStyleEN objDataGridStyleEN, int intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetHeight(this clsDataGridStyleEN objDataGridStyleEN, int intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleTop">Style_Top</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyleTop(this clsDataGridStyleEN objDataGridStyleEN, int intStyleTop, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyle">类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataGridStyleEN SetStyle(this clsDataGridStyleEN objDataGridStyleEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle, 800, conDataGridStyle.Style);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefault">是否默认</param>
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataGridStyleEN objDataGridStyleEN)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataGridStyleEN.sfUpdFldSetStr = objDataGridStyleEN.getsfUpdFldSetStr();
clsDataGridStyleWApi.CheckPropertyNew(objDataGridStyleEN); 
bool bolResult = clsDataGridStyleWApi.UpdateRecord(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataGridStyleEN objDataGridStyleEN)
{
 if (string.IsNullOrEmpty(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDataGridStyleWApi.IsExist(objDataGridStyleEN.DgStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDataGridStyleEN.DgStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsDataGridStyleWApi.CheckPropertyNew(objDataGridStyleEN); 
bool bolResult = clsDataGridStyleWApi.AddNewRecord(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDataGridStyleEN objDataGridStyleEN)
{
try
{
clsDataGridStyleWApi.CheckPropertyNew(objDataGridStyleEN); 
string strDgStyleId = clsDataGridStyleWApi.AddNewRecordWithMaxId(objDataGridStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
return strDgStyleId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataGridStyleEN objDataGridStyleEN, string strWhereCond)
{
try
{
clsDataGridStyleWApi.CheckPropertyNew(objDataGridStyleEN); 
bool bolResult = clsDataGridStyleWApi.UpdateWithCondition(objDataGridStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataGridStyleWApi
{
private static readonly string mstrApiControllerName = "DataGridStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDataGridStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DgStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[DataGrid类型]...","0");
List<clsDataGridStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DgStyleId";
objDDL.DataTextField="DgStyleName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DgStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataGridStyle.DgStyleId); 
List<clsDataGridStyleEN> arrObjLst = clsDataGridStyleWApi.GetObjLst(strCondition);
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataGridStyleEN objDataGridStyleEN)
{
if (!Object.Equals(null, objDataGridStyleEN.DgStyleId) && GetStrLen(objDataGridStyleEN.DgStyleId) > 4)
{
 throw new Exception("字段[DG模式ID]的长度不能超过4!");
}
if (!Object.Equals(null, objDataGridStyleEN.DgStyleName) && GetStrLen(objDataGridStyleEN.DgStyleName) > 30)
{
 throw new Exception("字段[DG模式名]的长度不能超过30!");
}
if (!Object.Equals(null, objDataGridStyleEN.Runat) && GetStrLen(objDataGridStyleEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objDataGridStyleEN.FontSize) && GetStrLen(objDataGridStyleEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objDataGridStyleEN.FontName) && GetStrLen(objDataGridStyleEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objDataGridStyleEN.StylePosition) && GetStrLen(objDataGridStyleEN.StylePosition) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
if (!Object.Equals(null, objDataGridStyleEN.Style) && GetStrLen(objDataGridStyleEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
 objDataGridStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDgStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataGridStyleEN GetObjByDgStyleId(string strDgStyleId)
{
if (strDgStyleId == "") return null;
string strAction = "GetObjByDgStyleId";
clsDataGridStyleEN objDataGridStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDgStyleId"] = strDgStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDataGridStyleEN = JsonConvert.DeserializeObject<clsDataGridStyleEN>(strJson);
return objDataGridStyleEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsDataGridStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDataGridStyleEN objDataGridStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDataGridStyleEN = JsonConvert.DeserializeObject<clsDataGridStyleEN>(strJson);
return objDataGridStyleEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataGridStyleEN GetObjByDgStyleIdCache(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel =
from objDataGridStyleEN in arrDataGridStyleObjLstCache
where objDataGridStyleEN.DgStyleId == strDgStyleId 
select objDataGridStyleEN;
if (arrDataGridStyleObjLst_Sel.Count() == 0)
{
   clsDataGridStyleEN obj = clsDataGridStyleWApi.GetObjByDgStyleId(strDgStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataGridStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDgStyleNameByDgStyleIdCache(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return "";
//初始化列表缓存
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel1 =
from objDataGridStyleEN in arrDataGridStyleObjLstCache
where objDataGridStyleEN.DgStyleId == strDgStyleId 
select objDataGridStyleEN;
List <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel = new List<clsDataGridStyleEN>();
foreach (clsDataGridStyleEN obj in arrDataGridStyleObjLst_Sel1)
{
arrDataGridStyleObjLst_Sel.Add(obj);
}
if (arrDataGridStyleObjLst_Sel.Count > 0)
{
return arrDataGridStyleObjLst_Sel[0].DgStyleName;
}
string strErrMsgForGetObjById = string.Format("在DataGridStyle对象缓存列表中,找不到记录[DgStyleId = {0}](函数:{1})", strDgStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataGridStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDgStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDgStyleIdCache(string strDgStyleId)
{
if (string.IsNullOrEmpty(strDgStyleId) == true) return "";
//初始化列表缓存
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel1 =
from objDataGridStyleEN in arrDataGridStyleObjLstCache
where objDataGridStyleEN.DgStyleId == strDgStyleId 
select objDataGridStyleEN;
List <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel = new List<clsDataGridStyleEN>();
foreach (clsDataGridStyleEN obj in arrDataGridStyleObjLst_Sel1)
{
arrDataGridStyleObjLst_Sel.Add(obj);
}
if (arrDataGridStyleObjLst_Sel.Count > 0)
{
return arrDataGridStyleObjLst_Sel[0].DgStyleName;
}
string strErrMsgForGetObjById = string.Format("在DataGridStyle对象缓存列表中,找不到记录的相关名称[DgStyleId = {0}](函数:{1})", strDgStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataGridStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLst(string strWhereCond)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrDgStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByDgStyleIdLst(List<string> arrDgStyleId)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetObjLstByDgStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDgStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDgStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDataGridStyleEN> GetObjLstByDgStyleIdLstCache(List<string> arrDgStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDataGridStyleEN> arrDataGridStyleObjLst_Sel =
from objDataGridStyleEN in arrDataGridStyleObjLstCache
where arrDgStyleId.Contains(objDataGridStyleEN.DgStyleId)
select objDataGridStyleEN;
return arrDataGridStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDataGridStyleEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataGridStyleEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strDgStyleId)
{
string strAction = "DelRecord";
try
{
 clsDataGridStyleEN objDataGridStyleEN = clsDataGridStyleWApi.GetObjByDgStyleId(strDgStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDgStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataGridStyleWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelDataGridStyles(List<string> arrDgStyleId)
{
string strAction = "DelDataGridStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDgStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataGridStyleWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelDataGridStylesByCond(string strWhereCond)
{
string strAction = "DelDataGridStylesByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsDataGridStyleEN objDataGridStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataGridStyleEN>(objDataGridStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsDataGridStyleEN objDataGridStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataGridStyleEN>(objDataGridStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataGridStyleWApi.ReFreshCache();
var strDgStyleId = (string)jobjReturn0["returnStr"];
return strDgStyleId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsDataGridStyleEN objDataGridStyleEN)
{
if (string.IsNullOrEmpty(objDataGridStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataGridStyleEN.DgStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataGridStyleEN>(objDataGridStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataGridStyleEN objDataGridStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataGridStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataGridStyleEN.DgStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataGridStyleEN.DgStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataGridStyleEN>(objDataGridStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strDgStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDgStyleId"] = strDgStyleId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsDataGridStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataGridStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataGridStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataGridStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataGridStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataGridStyleEN._AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDataGridStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataGridStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataGridStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataGridStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDataGridStyleEN._CurrTabName;
List<clsDataGridStyleEN> arrDataGridStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDataGridStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataGridStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataGridStyle.DgStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.DgStyleName, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.AllowPaging, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.PageSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.AutoGenerateColumns, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.AllowSorting, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsRadio, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsCheck, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsJumpPage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsHaveUpdBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsHaveDelBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsHaveDetailBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.IsInTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDataGridStyle.StyleZindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.StyleLeft, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.StylePosition, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.StyleTop, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataGridStyle.Style, Type.GetType("System.String"));
objDT.Columns.Add(conDataGridStyle.IsDefault, Type.GetType("System.Boolean"));
foreach (clsDataGridStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataGridStyle.DgStyleId] = objInFor[conDataGridStyle.DgStyleId];
objDR[conDataGridStyle.DgStyleName] = objInFor[conDataGridStyle.DgStyleName];
objDR[conDataGridStyle.Runat] = objInFor[conDataGridStyle.Runat];
objDR[conDataGridStyle.FontSize] = objInFor[conDataGridStyle.FontSize];
objDR[conDataGridStyle.FontName] = objInFor[conDataGridStyle.FontName];
objDR[conDataGridStyle.AllowPaging] = objInFor[conDataGridStyle.AllowPaging];
objDR[conDataGridStyle.PageSize] = objInFor[conDataGridStyle.PageSize];
objDR[conDataGridStyle.AutoGenerateColumns] = objInFor[conDataGridStyle.AutoGenerateColumns];
objDR[conDataGridStyle.AllowSorting] = objInFor[conDataGridStyle.AllowSorting];
objDR[conDataGridStyle.IsRadio] = objInFor[conDataGridStyle.IsRadio];
objDR[conDataGridStyle.IsCheck] = objInFor[conDataGridStyle.IsCheck];
objDR[conDataGridStyle.IsJumpPage] = objInFor[conDataGridStyle.IsJumpPage];
objDR[conDataGridStyle.IsHaveUpdBtn] = objInFor[conDataGridStyle.IsHaveUpdBtn];
objDR[conDataGridStyle.IsHaveDelBtn] = objInFor[conDataGridStyle.IsHaveDelBtn];
objDR[conDataGridStyle.IsHaveDetailBtn] = objInFor[conDataGridStyle.IsHaveDetailBtn];
objDR[conDataGridStyle.IsInTab] = objInFor[conDataGridStyle.IsInTab];
objDR[conDataGridStyle.StyleZindex] = objInFor[conDataGridStyle.StyleZindex];
objDR[conDataGridStyle.StyleLeft] = objInFor[conDataGridStyle.StyleLeft];
objDR[conDataGridStyle.StylePosition] = objInFor[conDataGridStyle.StylePosition];
objDR[conDataGridStyle.Width] = objInFor[conDataGridStyle.Width];
objDR[conDataGridStyle.Height] = objInFor[conDataGridStyle.Height];
objDR[conDataGridStyle.StyleTop] = objInFor[conDataGridStyle.StyleTop];
objDR[conDataGridStyle.Style] = objInFor[conDataGridStyle.Style];
objDR[conDataGridStyle.IsDefault] = objInFor[conDataGridStyle.IsDefault];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// DataGrid类型(DataGridStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DataGridStyle : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
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
clsDataGridStyleWApi.ReFreshThisCache();
}
}

}