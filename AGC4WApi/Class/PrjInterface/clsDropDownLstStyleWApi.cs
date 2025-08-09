
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDropDownLstStyleWApi
 表名:DropDownLstStyle(00050060)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsDropDownLstStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDropDownLstStyleId">DropDownLstStyleId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDropDownLstStyleId(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDropDownLstStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDropDownLstStyleId, 4, conDropDownLstStyle.DropDownLstStyleId);
objDropDownLstStyleEN.DropDownLstStyleId = strDropDownLstStyleId; //DropDownLstStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DropDownLstStyleId) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DropDownLstStyleId, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleId] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDropDownLstStyleName">DropDownLstStyleName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDropDownLstStyleName(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDropDownLstStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckFieldLen(strDropDownLstStyleName, 30, conDropDownLstStyle.DropDownLstStyleName);
objDropDownLstStyleEN.DropDownLstStyleName = strDropDownLstStyleName; //DropDownLstStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DropDownLstStyleName) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DropDownLstStyleName, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleName] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyle">类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyle(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle, 800, conDropDownLstStyle.Style);
objDropDownLstStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Style) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Style, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Style] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRunat">运行在</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetRunat(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRunat, conDropDownLstStyle.Runat);
clsCheckSql.CheckFieldLen(strRunat, 30, conDropDownLstStyle.Runat);
objDropDownLstStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Runat) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Runat, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Runat] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetFontSize(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontSize, conDropDownLstStyle.FontSize);
clsCheckSql.CheckFieldLen(strFontSize, 20, conDropDownLstStyle.FontSize);
objDropDownLstStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.FontSize) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.FontSize, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.FontSize] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetFontName(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontName, conDropDownLstStyle.FontName);
clsCheckSql.CheckFieldLen(strFontName, 20, conDropDownLstStyle.FontName);
objDropDownLstStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.FontName) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.FontName, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.FontName] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetWidth(this clsDropDownLstStyleEN objDropDownLstStyleEN, int intWidth, string strComparisonOp="")
	{
objDropDownLstStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Width) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Width, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Width] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetHeight(this clsDropDownLstStyleEN objDropDownLstStyleEN, int intHeight, string strComparisonOp="")
	{
objDropDownLstStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Height) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Height, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Height] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextMode">TextMode</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetTextMode(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strTextMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextMode, conDropDownLstStyle.TextMode);
clsCheckSql.CheckFieldLen(strTextMode, 20, conDropDownLstStyle.TextMode);
objDropDownLstStyleEN.TextMode = strTextMode; //TextMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.TextMode) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.TextMode, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.TextMode] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolReadOnly">ReadOnly</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetReadOnly(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolReadOnly, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolReadOnly, conDropDownLstStyle.ReadOnly);
objDropDownLstStyleEN.ReadOnly = bolReadOnly; //ReadOnly
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.ReadOnly) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.ReadOnly, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.ReadOnly] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strBackColor">背景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetBackColor(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strBackColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBackColor, 30, conDropDownLstStyle.BackColor);
objDropDownLstStyleEN.BackColor = strBackColor; //背景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.BackColor) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.BackColor, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.BackColor] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeColor">前景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetForeColor(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strForeColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeColor, 30, conDropDownLstStyle.ForeColor);
objDropDownLstStyleEN.ForeColor = strForeColor; //前景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.ForeColor) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.ForeColor, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.ForeColor] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTextField">DataTextField</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataTextField(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataTextField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTextField, 30, conDropDownLstStyle.DataTextField);
objDropDownLstStyleEN.DataTextField = strDataTextField; //DataTextField
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataTextField) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataTextField, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataTextField] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataValueField">DataValueField</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataValueField(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataValueField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataValueField, 30, conDropDownLstStyle.DataValueField);
objDropDownLstStyleEN.DataValueField = strDataValueField; //DataValueField
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataValueField) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataValueField, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataValueField] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTextFormatString">DataTextFormatString</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetDataTextFormatString(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strDataTextFormatString, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTextFormatString, 30, conDropDownLstStyle.DataTextFormatString);
objDropDownLstStyleEN.DataTextFormatString = strDataTextFormatString; //DataTextFormatString
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.DataTextFormatString) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.DataTextFormatString, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.DataTextFormatString] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strAccessKey">AccessKey</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetAccessKey(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strAccessKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessKey, 30, conDropDownLstStyle.AccessKey);
objDropDownLstStyleEN.AccessKey = strAccessKey; //AccessKey
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.AccessKey) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.AccessKey, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.AccessKey] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAutoPostBack">AutoPostBack</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetAutoPostBack(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolAutoPostBack, string strComparisonOp="")
	{
objDropDownLstStyleEN.AutoPostBack = bolAutoPostBack; //AutoPostBack
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.AutoPostBack) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.AutoPostBack, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.AutoPostBack] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolVisible">Visible</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetVisible(this clsDropDownLstStyleEN objDropDownLstStyleEN, bool bolVisible, string strComparisonOp="")
	{
objDropDownLstStyleEN.Visible = bolVisible; //Visible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.Visible) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.Visible, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.Visible] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleZindex">Style_Zindex</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleZindex(this clsDropDownLstStyleEN objDropDownLstStyleEN, int intStyleZindex, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleZindex) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleZindex, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleZindex] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleLeft">Style_Left</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleLeft(this clsDropDownLstStyleEN objDropDownLstStyleEN, int intStyleLeft, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleLeft) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleLeft, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleLeft] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStylePosition">Style_Position</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStylePosition(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strStylePosition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conDropDownLstStyle.StylePosition);
objDropDownLstStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StylePosition) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StylePosition, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StylePosition] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleTop">Style_Top</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDropDownLstStyleEN SetStyleTop(this clsDropDownLstStyleEN objDropDownLstStyleEN, int intStyleTop, string strComparisonOp="")
	{
objDropDownLstStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDropDownLstStyleEN.dicFldComparisonOp.ContainsKey(conDropDownLstStyle.StyleTop) == false)
{
objDropDownLstStyleEN.dicFldComparisonOp.Add(conDropDownLstStyle.StyleTop, strComparisonOp);
}
else
{
objDropDownLstStyleEN.dicFldComparisonOp[conDropDownLstStyle.StyleTop] = strComparisonOp;
}
}
return objDropDownLstStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDropDownLstStyleEN objDropDownLstStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DropDownLstStyleId) == true)
{
string strComparisonOpDropDownLstStyleId = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DropDownLstStyleId, objDropDownLstStyleCond.DropDownLstStyleId, strComparisonOpDropDownLstStyleId);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DropDownLstStyleName) == true)
{
string strComparisonOpDropDownLstStyleName = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DropDownLstStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DropDownLstStyleName, objDropDownLstStyleCond.DropDownLstStyleName, strComparisonOpDropDownLstStyleName);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Style) == true)
{
string strComparisonOpStyle = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.Style, objDropDownLstStyleCond.Style, strComparisonOpStyle);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Runat) == true)
{
string strComparisonOpRunat = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.Runat, objDropDownLstStyleCond.Runat, strComparisonOpRunat);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.FontSize) == true)
{
string strComparisonOpFontSize = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.FontSize, objDropDownLstStyleCond.FontSize, strComparisonOpFontSize);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.FontName) == true)
{
string strComparisonOpFontName = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.FontName, objDropDownLstStyleCond.FontName, strComparisonOpFontName);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Width) == true)
{
string strComparisonOpWidth = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.Width, objDropDownLstStyleCond.Width, strComparisonOpWidth);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Height) == true)
{
string strComparisonOpHeight = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.Height, objDropDownLstStyleCond.Height, strComparisonOpHeight);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.TextMode) == true)
{
string strComparisonOpTextMode = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.TextMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.TextMode, objDropDownLstStyleCond.TextMode, strComparisonOpTextMode);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.ReadOnly) == true)
{
if (objDropDownLstStyleCond.ReadOnly == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.ReadOnly);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.ReadOnly);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.BackColor) == true)
{
string strComparisonOpBackColor = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.BackColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.BackColor, objDropDownLstStyleCond.BackColor, strComparisonOpBackColor);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.ForeColor) == true)
{
string strComparisonOpForeColor = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.ForeColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.ForeColor, objDropDownLstStyleCond.ForeColor, strComparisonOpForeColor);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataTextField) == true)
{
string strComparisonOpDataTextField = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataTextField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataTextField, objDropDownLstStyleCond.DataTextField, strComparisonOpDataTextField);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataValueField) == true)
{
string strComparisonOpDataValueField = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataValueField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataValueField, objDropDownLstStyleCond.DataValueField, strComparisonOpDataValueField);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.DataTextFormatString) == true)
{
string strComparisonOpDataTextFormatString = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.DataTextFormatString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.DataTextFormatString, objDropDownLstStyleCond.DataTextFormatString, strComparisonOpDataTextFormatString);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.AccessKey) == true)
{
string strComparisonOpAccessKey = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.AccessKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.AccessKey, objDropDownLstStyleCond.AccessKey, strComparisonOpAccessKey);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.AutoPostBack) == true)
{
if (objDropDownLstStyleCond.AutoPostBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.AutoPostBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.AutoPostBack);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.Visible) == true)
{
if (objDropDownLstStyleCond.Visible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDropDownLstStyle.Visible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDropDownLstStyle.Visible);
}
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleZindex, objDropDownLstStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleLeft, objDropDownLstStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDropDownLstStyle.StylePosition, objDropDownLstStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objDropDownLstStyleCond.IsUpdated(conDropDownLstStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objDropDownLstStyleCond.dicFldComparisonOp[conDropDownLstStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conDropDownLstStyle.StyleTop, objDropDownLstStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDropDownLstStyleEN.sfUpdFldSetStr = objDropDownLstStyleEN.getsfUpdFldSetStr();
clsDropDownLstStyleWApi.CheckPropertyNew(objDropDownLstStyleEN); 
bool bolResult = clsDropDownLstStyleWApi.UpdateRecord(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (string.IsNullOrEmpty(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDropDownLstStyleWApi.IsExist(objDropDownLstStyleEN.DropDownLstStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDropDownLstStyleEN.DropDownLstStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsDropDownLstStyleWApi.CheckPropertyNew(objDropDownLstStyleEN); 
bool bolResult = clsDropDownLstStyleWApi.AddNewRecord(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDropDownLstStyleEN objDropDownLstStyleEN)
{
try
{
clsDropDownLstStyleWApi.CheckPropertyNew(objDropDownLstStyleEN); 
string strDropDownLstStyleId = clsDropDownLstStyleWApi.AddNewRecordWithMaxId(objDropDownLstStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
return strDropDownLstStyleId;
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDropDownLstStyleEN objDropDownLstStyleEN, string strWhereCond)
{
try
{
clsDropDownLstStyleWApi.CheckPropertyNew(objDropDownLstStyleEN); 
bool bolResult = clsDropDownLstStyleWApi.UpdateWithCondition(objDropDownLstStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
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
 /// 下拉框样式(DropDownLstStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDropDownLstStyleWApi
{
private static readonly string mstrApiControllerName = "DropDownLstStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDropDownLstStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DropDownLstStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[下拉框样式]...","0");
List<clsDropDownLstStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DropDownLstStyleId";
objDDL.DataTextField="DropDownLstStyleName";
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

public static void BindCbo_DropDownLstStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDropDownLstStyle.DropDownLstStyleId); 
List<clsDropDownLstStyleEN> arrObjLst = clsDropDownLstStyleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN()
{
DropDownLstStyleId = "0",
DropDownLstStyleName = "选[下拉框样式]..."
};
arrObjLst.Insert(0, objDropDownLstStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDropDownLstStyle.DropDownLstStyleId;
objComboBox.DisplayMember = conDropDownLstStyle.DropDownLstStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
if (!Object.Equals(null, objDropDownLstStyleEN.DropDownLstStyleId) && GetStrLen(objDropDownLstStyleEN.DropDownLstStyleId) > 4)
{
 throw new Exception("字段[DropDownLstStyleId]的长度不能超过4!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.DropDownLstStyleName) && GetStrLen(objDropDownLstStyleEN.DropDownLstStyleName) > 30)
{
 throw new Exception("字段[DropDownLstStyleName]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.Style) && GetStrLen(objDropDownLstStyleEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.Runat) && GetStrLen(objDropDownLstStyleEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.FontSize) && GetStrLen(objDropDownLstStyleEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.FontName) && GetStrLen(objDropDownLstStyleEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.TextMode) && GetStrLen(objDropDownLstStyleEN.TextMode) > 20)
{
 throw new Exception("字段[TextMode]的长度不能超过20!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.BackColor) && GetStrLen(objDropDownLstStyleEN.BackColor) > 30)
{
 throw new Exception("字段[背景颜色]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.ForeColor) && GetStrLen(objDropDownLstStyleEN.ForeColor) > 30)
{
 throw new Exception("字段[前景颜色]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.DataTextField) && GetStrLen(objDropDownLstStyleEN.DataTextField) > 30)
{
 throw new Exception("字段[DataTextField]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.DataValueField) && GetStrLen(objDropDownLstStyleEN.DataValueField) > 30)
{
 throw new Exception("字段[DataValueField]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.DataTextFormatString) && GetStrLen(objDropDownLstStyleEN.DataTextFormatString) > 30)
{
 throw new Exception("字段[DataTextFormatString]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.AccessKey) && GetStrLen(objDropDownLstStyleEN.AccessKey) > 30)
{
 throw new Exception("字段[AccessKey]的长度不能超过30!");
}
if (!Object.Equals(null, objDropDownLstStyleEN.StylePosition) && GetStrLen(objDropDownLstStyleEN.StylePosition) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
 objDropDownLstStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDropDownLstStyleEN GetObjByDropDownLstStyleId(string strDropDownLstStyleId)
{
if (strDropDownLstStyleId == "") return null;
string strAction = "GetObjByDropDownLstStyleId";
clsDropDownLstStyleEN objDropDownLstStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDropDownLstStyleId"] = strDropDownLstStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDropDownLstStyleEN = JsonConvert.DeserializeObject<clsDropDownLstStyleEN>(strJson);
return objDropDownLstStyleEN;
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
public static clsDropDownLstStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDropDownLstStyleEN objDropDownLstStyleEN;
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
objDropDownLstStyleEN = JsonConvert.DeserializeObject<clsDropDownLstStyleEN>(strJson);
return objDropDownLstStyleEN;
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
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDropDownLstStyleEN GetObjByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel =
from objDropDownLstStyleEN in arrDropDownLstStyleObjLstCache
where objDropDownLstStyleEN.DropDownLstStyleId == strDropDownLstStyleId 
select objDropDownLstStyleEN;
if (arrDropDownLstStyleObjLst_Sel.Count() == 0)
{
   clsDropDownLstStyleEN obj = clsDropDownLstStyleWApi.GetObjByDropDownLstStyleId(strDropDownLstStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDropDownLstStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDropDownLstStyleNameByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return "";
//初始化列表缓存
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel1 =
from objDropDownLstStyleEN in arrDropDownLstStyleObjLstCache
where objDropDownLstStyleEN.DropDownLstStyleId == strDropDownLstStyleId 
select objDropDownLstStyleEN;
List <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel = new List<clsDropDownLstStyleEN>();
foreach (clsDropDownLstStyleEN obj in arrDropDownLstStyleObjLst_Sel1)
{
arrDropDownLstStyleObjLst_Sel.Add(obj);
}
if (arrDropDownLstStyleObjLst_Sel.Count > 0)
{
return arrDropDownLstStyleObjLst_Sel[0].DropDownLstStyleName;
}
string strErrMsgForGetObjById = string.Format("在DropDownLstStyle对象缓存列表中,找不到记录[DropDownLstStyleId = {0}](函数:{1})", strDropDownLstStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDropDownLstStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDropDownLstStyleIdCache(string strDropDownLstStyleId)
{
if (string.IsNullOrEmpty(strDropDownLstStyleId) == true) return "";
//初始化列表缓存
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel1 =
from objDropDownLstStyleEN in arrDropDownLstStyleObjLstCache
where objDropDownLstStyleEN.DropDownLstStyleId == strDropDownLstStyleId 
select objDropDownLstStyleEN;
List <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel = new List<clsDropDownLstStyleEN>();
foreach (clsDropDownLstStyleEN obj in arrDropDownLstStyleObjLst_Sel1)
{
arrDropDownLstStyleObjLst_Sel.Add(obj);
}
if (arrDropDownLstStyleObjLst_Sel.Count > 0)
{
return arrDropDownLstStyleObjLst_Sel[0].DropDownLstStyleName;
}
string strErrMsgForGetObjById = string.Format("在DropDownLstStyle对象缓存列表中,找不到记录的相关名称[DropDownLstStyleId = {0}](函数:{1})", strDropDownLstStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDropDownLstStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLst(string strWhereCond)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
 /// <param name = "arrDropDownLstStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstByDropDownLstStyleIdLst(List<string> arrDropDownLstStyleId)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
string strAction = "GetObjLstByDropDownLstStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDropDownLstStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
 /// <param name = "arrDropDownLstStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDropDownLstStyleEN> GetObjLstByDropDownLstStyleIdLstCache(List<string> arrDropDownLstStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = GetObjLstCache();
IEnumerable <clsDropDownLstStyleEN> arrDropDownLstStyleObjLst_Sel =
from objDropDownLstStyleEN in arrDropDownLstStyleObjLstCache
where arrDropDownLstStyleId.Contains(objDropDownLstStyleEN.DropDownLstStyleId)
select objDropDownLstStyleEN;
return arrDropDownLstStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDropDownLstStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
public static List<clsDropDownLstStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
public static List<clsDropDownLstStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
public static List<clsDropDownLstStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDropDownLstStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDropDownLstStyleEN>>(strJson);
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
public static int DelRecord(string strDropDownLstStyleId)
{
string strAction = "DelRecord";
try
{
 clsDropDownLstStyleEN objDropDownLstStyleEN = clsDropDownLstStyleWApi.GetObjByDropDownLstStyleId(strDropDownLstStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDropDownLstStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDropDownLstStyleWApi.ReFreshCache();
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
public static int DelDropDownLstStyles(List<string> arrDropDownLstStyleId)
{
string strAction = "DelDropDownLstStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDropDownLstStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDropDownLstStyleWApi.ReFreshCache();
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
public static int DelDropDownLstStylesByCond(string strWhereCond)
{
string strAction = "DelDropDownLstStylesByCond";
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
public static bool AddNewRecord(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDropDownLstStyleEN>(objDropDownLstStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDropDownLstStyleEN>(objDropDownLstStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDropDownLstStyleWApi.ReFreshCache();
var strDropDownLstStyleId = (string)jobjReturn0["returnStr"];
return strDropDownLstStyleId;
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
public static bool UpdateRecord(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
if (string.IsNullOrEmpty(objDropDownLstStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDropDownLstStyleEN.DropDownLstStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDropDownLstStyleEN>(objDropDownLstStyleEN);
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDropDownLstStyleEN objDropDownLstStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDropDownLstStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDropDownLstStyleEN.DropDownLstStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDropDownLstStyleEN.DropDownLstStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDropDownLstStyleEN>(objDropDownLstStyleEN);
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
public static bool IsExist(string strDropDownLstStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDropDownLstStyleId"] = strDropDownLstStyleId
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
 /// <param name = "objDropDownLstStyleENS">源对象</param>
 /// <param name = "objDropDownLstStyleENT">目标对象</param>
 public static void CopyTo(clsDropDownLstStyleEN objDropDownLstStyleENS, clsDropDownLstStyleEN objDropDownLstStyleENT)
{
try
{
objDropDownLstStyleENT.DropDownLstStyleId = objDropDownLstStyleENS.DropDownLstStyleId; //DropDownLstStyleId
objDropDownLstStyleENT.DropDownLstStyleName = objDropDownLstStyleENS.DropDownLstStyleName; //DropDownLstStyleName
objDropDownLstStyleENT.Style = objDropDownLstStyleENS.Style; //类型
objDropDownLstStyleENT.Runat = objDropDownLstStyleENS.Runat; //运行在
objDropDownLstStyleENT.FontSize = objDropDownLstStyleENS.FontSize; //字号
objDropDownLstStyleENT.FontName = objDropDownLstStyleENS.FontName; //字体
objDropDownLstStyleENT.Width = objDropDownLstStyleENS.Width; //宽
objDropDownLstStyleENT.Height = objDropDownLstStyleENS.Height; //高度
objDropDownLstStyleENT.TextMode = objDropDownLstStyleENS.TextMode; //TextMode
objDropDownLstStyleENT.ReadOnly = objDropDownLstStyleENS.ReadOnly; //ReadOnly
objDropDownLstStyleENT.BackColor = objDropDownLstStyleENS.BackColor; //背景颜色
objDropDownLstStyleENT.ForeColor = objDropDownLstStyleENS.ForeColor; //前景颜色
objDropDownLstStyleENT.DataTextField = objDropDownLstStyleENS.DataTextField; //DataTextField
objDropDownLstStyleENT.DataValueField = objDropDownLstStyleENS.DataValueField; //DataValueField
objDropDownLstStyleENT.DataTextFormatString = objDropDownLstStyleENS.DataTextFormatString; //DataTextFormatString
objDropDownLstStyleENT.AccessKey = objDropDownLstStyleENS.AccessKey; //AccessKey
objDropDownLstStyleENT.AutoPostBack = objDropDownLstStyleENS.AutoPostBack; //AutoPostBack
objDropDownLstStyleENT.Visible = objDropDownLstStyleENS.Visible; //Visible
objDropDownLstStyleENT.StyleZindex = objDropDownLstStyleENS.StyleZindex; //Style_Zindex
objDropDownLstStyleENT.StyleLeft = objDropDownLstStyleENS.StyleLeft; //Style_Left
objDropDownLstStyleENT.StylePosition = objDropDownLstStyleENS.StylePosition; //Style_Position
objDropDownLstStyleENT.StyleTop = objDropDownLstStyleENS.StyleTop; //Style_Top
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
public static DataTable ToDataTable(List<clsDropDownLstStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDropDownLstStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDropDownLstStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDropDownLstStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDropDownLstStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDropDownLstStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
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
if (clsDropDownLstStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDropDownLstStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDropDownLstStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDropDownLstStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDropDownLstStyleEN._CurrTabName;
List<clsDropDownLstStyleEN> arrDropDownLstStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDropDownLstStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDropDownLstStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDropDownLstStyle.DropDownLstStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.DropDownLstStyleName, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.Style, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conDropDownLstStyle.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conDropDownLstStyle.TextMode, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.ReadOnly, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDropDownLstStyle.BackColor, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.ForeColor, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.DataTextField, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.DataValueField, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.DataTextFormatString, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.AccessKey, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.AutoPostBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDropDownLstStyle.Visible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDropDownLstStyle.StyleZindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conDropDownLstStyle.StyleLeft, Type.GetType("System.Int32"));
objDT.Columns.Add(conDropDownLstStyle.StylePosition, Type.GetType("System.String"));
objDT.Columns.Add(conDropDownLstStyle.StyleTop, Type.GetType("System.Int32"));
foreach (clsDropDownLstStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDropDownLstStyle.DropDownLstStyleId] = objInFor[conDropDownLstStyle.DropDownLstStyleId];
objDR[conDropDownLstStyle.DropDownLstStyleName] = objInFor[conDropDownLstStyle.DropDownLstStyleName];
objDR[conDropDownLstStyle.Style] = objInFor[conDropDownLstStyle.Style];
objDR[conDropDownLstStyle.Runat] = objInFor[conDropDownLstStyle.Runat];
objDR[conDropDownLstStyle.FontSize] = objInFor[conDropDownLstStyle.FontSize];
objDR[conDropDownLstStyle.FontName] = objInFor[conDropDownLstStyle.FontName];
objDR[conDropDownLstStyle.Width] = objInFor[conDropDownLstStyle.Width];
objDR[conDropDownLstStyle.Height] = objInFor[conDropDownLstStyle.Height];
objDR[conDropDownLstStyle.TextMode] = objInFor[conDropDownLstStyle.TextMode];
objDR[conDropDownLstStyle.ReadOnly] = objInFor[conDropDownLstStyle.ReadOnly];
objDR[conDropDownLstStyle.BackColor] = objInFor[conDropDownLstStyle.BackColor];
objDR[conDropDownLstStyle.ForeColor] = objInFor[conDropDownLstStyle.ForeColor];
objDR[conDropDownLstStyle.DataTextField] = objInFor[conDropDownLstStyle.DataTextField];
objDR[conDropDownLstStyle.DataValueField] = objInFor[conDropDownLstStyle.DataValueField];
objDR[conDropDownLstStyle.DataTextFormatString] = objInFor[conDropDownLstStyle.DataTextFormatString];
objDR[conDropDownLstStyle.AccessKey] = objInFor[conDropDownLstStyle.AccessKey];
objDR[conDropDownLstStyle.AutoPostBack] = objInFor[conDropDownLstStyle.AutoPostBack];
objDR[conDropDownLstStyle.Visible] = objInFor[conDropDownLstStyle.Visible];
objDR[conDropDownLstStyle.StyleZindex] = objInFor[conDropDownLstStyle.StyleZindex];
objDR[conDropDownLstStyle.StyleLeft] = objInFor[conDropDownLstStyle.StyleLeft];
objDR[conDropDownLstStyle.StylePosition] = objInFor[conDropDownLstStyle.StylePosition];
objDR[conDropDownLstStyle.StyleTop] = objInFor[conDropDownLstStyle.StyleTop];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 下拉框样式(DropDownLstStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DropDownLstStyle : clsCommFun4BL
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
clsDropDownLstStyleWApi.ReFreshThisCache();
}
}

}