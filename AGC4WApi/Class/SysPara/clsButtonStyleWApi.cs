
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonStyleWApi
 表名:ButtonStyle(00050054)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsButtonStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonStyleId">按钮样式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetButtonStyleId(this clsButtonStyleEN objButtonStyleEN, string strButtonStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strButtonStyleId, 4, conButtonStyle.ButtonStyleId);
clsCheckSql.CheckFieldForeignKey(strButtonStyleId, 4, conButtonStyle.ButtonStyleId);
objButtonStyleEN.ButtonStyleId = strButtonStyleId; //按钮样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.ButtonStyleId) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.ButtonStyleId, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.ButtonStyleId] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonStyleName">按钮样式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetButtonStyleName(this clsButtonStyleEN objButtonStyleEN, string strButtonStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonStyleName, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckFieldLen(strButtonStyleName, 30, conButtonStyle.ButtonStyleName);
objButtonStyleEN.ButtonStyleName = strButtonStyleName; //按钮样式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.ButtonStyleName) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.ButtonStyleName, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.ButtonStyleName] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetCssClass(this clsButtonStyleEN objButtonStyleEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, conButtonStyle.CssClass);
objButtonStyleEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.CssClass) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.CssClass, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.CssClass] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyle">类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetStyle(this clsButtonStyleEN objButtonStyleEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStyle, conButtonStyle.Style);
clsCheckSql.CheckFieldLen(strStyle, 800, conButtonStyle.Style);
objButtonStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.Style) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.Style, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.Style] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRunat">运行在</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetRunat(this clsButtonStyleEN objButtonStyleEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRunat, conButtonStyle.Runat);
clsCheckSql.CheckFieldLen(strRunat, 30, conButtonStyle.Runat);
objButtonStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.Runat) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.Runat, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.Runat] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetFontSize(this clsButtonStyleEN objButtonStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontSize, conButtonStyle.FontSize);
clsCheckSql.CheckFieldLen(strFontSize, 20, conButtonStyle.FontSize);
objButtonStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.FontSize) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.FontSize, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.FontSize] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetFontName(this clsButtonStyleEN objButtonStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFontName, conButtonStyle.FontName);
clsCheckSql.CheckFieldLen(strFontName, 20, conButtonStyle.FontName);
objButtonStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.FontName) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.FontName, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.FontName] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetWidth(this clsButtonStyleEN objButtonStyleEN, int intWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWidth, conButtonStyle.Width);
objButtonStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.Width) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.Width, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.Width] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetHeight(this clsButtonStyleEN objButtonStyleEN, int intHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intHeight, conButtonStyle.Height);
objButtonStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.Height) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.Height, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.Height] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleZindex">Style_Zindex</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetStyleZindex(this clsButtonStyleEN objButtonStyleEN, int intStyleZindex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStyleZindex, conButtonStyle.StyleZindex);
objButtonStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.StyleZindex) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.StyleZindex, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.StyleZindex] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleLeft">Style_Left</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetStyleLeft(this clsButtonStyleEN objButtonStyleEN, int intStyleLeft, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStyleLeft, conButtonStyle.StyleLeft);
objButtonStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.StyleLeft) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.StyleLeft, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.StyleLeft] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStylePosition">Style_Position</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetStylePosition(this clsButtonStyleEN objButtonStyleEN, string strStylePosition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStylePosition, conButtonStyle.StylePosition);
clsCheckSql.CheckFieldLen(strStylePosition, 20, conButtonStyle.StylePosition);
objButtonStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.StylePosition) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.StylePosition, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.StylePosition] = strComparisonOp;
}
}
return objButtonStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleTop">Style_Top</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonStyleEN SetStyleTop(this clsButtonStyleEN objButtonStyleEN, int intStyleTop, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStyleTop, conButtonStyle.StyleTop);
objButtonStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonStyleEN.dicFldComparisonOp.ContainsKey(conButtonStyle.StyleTop) == false)
{
objButtonStyleEN.dicFldComparisonOp.Add(conButtonStyle.StyleTop, strComparisonOp);
}
else
{
objButtonStyleEN.dicFldComparisonOp[conButtonStyle.StyleTop] = strComparisonOp;
}
}
return objButtonStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsButtonStyleEN objButtonStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objButtonStyleCond.IsUpdated(conButtonStyle.ButtonStyleId) == true)
{
string strComparisonOpButtonStyleId = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.ButtonStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.ButtonStyleId, objButtonStyleCond.ButtonStyleId, strComparisonOpButtonStyleId);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.ButtonStyleName) == true)
{
string strComparisonOpButtonStyleName = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.ButtonStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.ButtonStyleName, objButtonStyleCond.ButtonStyleName, strComparisonOpButtonStyleName);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.CssClass) == true)
{
string strComparisonOpCssClass = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.CssClass, objButtonStyleCond.CssClass, strComparisonOpCssClass);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.Style) == true)
{
string strComparisonOpStyle = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.Style, objButtonStyleCond.Style, strComparisonOpStyle);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.Runat) == true)
{
string strComparisonOpRunat = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.Runat, objButtonStyleCond.Runat, strComparisonOpRunat);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.FontSize) == true)
{
string strComparisonOpFontSize = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.FontSize, objButtonStyleCond.FontSize, strComparisonOpFontSize);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.FontName) == true)
{
string strComparisonOpFontName = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.FontName, objButtonStyleCond.FontName, strComparisonOpFontName);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.Width) == true)
{
string strComparisonOpWidth = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonStyle.Width, objButtonStyleCond.Width, strComparisonOpWidth);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.Height) == true)
{
string strComparisonOpHeight = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonStyle.Height, objButtonStyleCond.Height, strComparisonOpHeight);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonStyle.StyleZindex, objButtonStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonStyle.StyleLeft, objButtonStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonStyle.StylePosition, objButtonStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objButtonStyleCond.IsUpdated(conButtonStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objButtonStyleCond.dicFldComparisonOp[conButtonStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonStyle.StyleTop, objButtonStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsButtonStyleEN objButtonStyleEN)
{
 if (string.IsNullOrEmpty(objButtonStyleEN.ButtonStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objButtonStyleEN.sfUpdFldSetStr = objButtonStyleEN.getsfUpdFldSetStr();
clsButtonStyleWApi.CheckPropertyNew(objButtonStyleEN); 
bool bolResult = clsButtonStyleWApi.UpdateRecord(objButtonStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
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
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsButtonStyleEN objButtonStyleEN)
{
 if (string.IsNullOrEmpty(objButtonStyleEN.ButtonStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsButtonStyleWApi.IsExist(objButtonStyleEN.ButtonStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objButtonStyleEN.ButtonStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsButtonStyleWApi.CheckPropertyNew(objButtonStyleEN); 
bool bolResult = clsButtonStyleWApi.AddNewRecord(objButtonStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
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
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsButtonStyleEN objButtonStyleEN)
{
try
{
clsButtonStyleWApi.CheckPropertyNew(objButtonStyleEN); 
string strButtonStyleId = clsButtonStyleWApi.AddNewRecordWithMaxId(objButtonStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
return strButtonStyleId;
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
 /// <param name = "objButtonStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsButtonStyleEN objButtonStyleEN, string strWhereCond)
{
try
{
clsButtonStyleWApi.CheckPropertyNew(objButtonStyleEN); 
bool bolResult = clsButtonStyleWApi.UpdateWithCondition(objButtonStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
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
 /// 按钮样式(ButtonStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsButtonStyleWApi
{
private static readonly string mstrApiControllerName = "ButtonStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsButtonStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ButtonStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[按钮样式]...","0");
List<clsButtonStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ButtonStyleId";
objDDL.DataTextField="ButtonStyleName";
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

public static void BindCbo_ButtonStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conButtonStyle.ButtonStyleId); 
List<clsButtonStyleEN> arrObjLst = clsButtonStyleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN()
{
ButtonStyleId = "0",
ButtonStyleName = "选[按钮样式]..."
};
arrObjLst.Insert(0, objButtonStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conButtonStyle.ButtonStyleId;
objComboBox.DisplayMember = conButtonStyle.ButtonStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsButtonStyleEN objButtonStyleEN)
{
if (!Object.Equals(null, objButtonStyleEN.ButtonStyleId) && GetStrLen(objButtonStyleEN.ButtonStyleId) > 4)
{
 throw new Exception("字段[按钮样式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objButtonStyleEN.ButtonStyleName) && GetStrLen(objButtonStyleEN.ButtonStyleName) > 30)
{
 throw new Exception("字段[按钮样式名]的长度不能超过30!");
}
if (!Object.Equals(null, objButtonStyleEN.CssClass) && GetStrLen(objButtonStyleEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objButtonStyleEN.Style) && GetStrLen(objButtonStyleEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
if (!Object.Equals(null, objButtonStyleEN.Runat) && GetStrLen(objButtonStyleEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objButtonStyleEN.FontSize) && GetStrLen(objButtonStyleEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objButtonStyleEN.FontName) && GetStrLen(objButtonStyleEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objButtonStyleEN.StylePosition) && GetStrLen(objButtonStyleEN.StylePosition) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
 objButtonStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strButtonStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsButtonStyleEN GetObjByButtonStyleId(string strButtonStyleId)
{
if (strButtonStyleId == "") return null;
string strAction = "GetObjByButtonStyleId";
clsButtonStyleEN objButtonStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strButtonStyleId"] = strButtonStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objButtonStyleEN = JsonConvert.DeserializeObject<clsButtonStyleEN>(strJson);
return objButtonStyleEN;
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
public static clsButtonStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsButtonStyleEN objButtonStyleEN;
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
objButtonStyleEN = JsonConvert.DeserializeObject<clsButtonStyleEN>(strJson);
return objButtonStyleEN;
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
 /// <param name = "strButtonStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsButtonStyleEN GetObjByButtonStyleIdCache(string strButtonStyleId)
{
if (string.IsNullOrEmpty(strButtonStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsButtonStyleEN._CurrTabName);
List<clsButtonStyleEN> arrButtonStyleObjLstCache = GetObjLstCache();
IEnumerable <clsButtonStyleEN> arrButtonStyleObjLst_Sel =
from objButtonStyleEN in arrButtonStyleObjLstCache
where objButtonStyleEN.ButtonStyleId == strButtonStyleId 
select objButtonStyleEN;
if (arrButtonStyleObjLst_Sel.Count() == 0)
{
   clsButtonStyleEN obj = clsButtonStyleWApi.GetObjByButtonStyleId(strButtonStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrButtonStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetButtonStyleNameByButtonStyleIdCache(string strButtonStyleId)
{
if (string.IsNullOrEmpty(strButtonStyleId) == true) return "";
//初始化列表缓存
List<clsButtonStyleEN> arrButtonStyleObjLstCache = GetObjLstCache();
IEnumerable <clsButtonStyleEN> arrButtonStyleObjLst_Sel1 =
from objButtonStyleEN in arrButtonStyleObjLstCache
where objButtonStyleEN.ButtonStyleId == strButtonStyleId 
select objButtonStyleEN;
List <clsButtonStyleEN> arrButtonStyleObjLst_Sel = new List<clsButtonStyleEN>();
foreach (clsButtonStyleEN obj in arrButtonStyleObjLst_Sel1)
{
arrButtonStyleObjLst_Sel.Add(obj);
}
if (arrButtonStyleObjLst_Sel.Count > 0)
{
return arrButtonStyleObjLst_Sel[0].ButtonStyleName;
}
string strErrMsgForGetObjById = string.Format("在ButtonStyle对象缓存列表中,找不到记录[ButtonStyleId = {0}](函数:{1})", strButtonStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsButtonStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByButtonStyleIdCache(string strButtonStyleId)
{
if (string.IsNullOrEmpty(strButtonStyleId) == true) return "";
//初始化列表缓存
List<clsButtonStyleEN> arrButtonStyleObjLstCache = GetObjLstCache();
IEnumerable <clsButtonStyleEN> arrButtonStyleObjLst_Sel1 =
from objButtonStyleEN in arrButtonStyleObjLstCache
where objButtonStyleEN.ButtonStyleId == strButtonStyleId 
select objButtonStyleEN;
List <clsButtonStyleEN> arrButtonStyleObjLst_Sel = new List<clsButtonStyleEN>();
foreach (clsButtonStyleEN obj in arrButtonStyleObjLst_Sel1)
{
arrButtonStyleObjLst_Sel.Add(obj);
}
if (arrButtonStyleObjLst_Sel.Count > 0)
{
return arrButtonStyleObjLst_Sel[0].ButtonStyleName;
}
string strErrMsgForGetObjById = string.Format("在ButtonStyle对象缓存列表中,找不到记录的相关名称[ButtonStyleId = {0}](函数:{1})", strButtonStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsButtonStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonStyleEN> GetObjLst(string strWhereCond)
{
 List<clsButtonStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
 /// <param name = "arrButtonStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonStyleEN> GetObjLstByButtonStyleIdLst(List<string> arrButtonStyleId)
{
 List<clsButtonStyleEN> arrObjLst; 
string strAction = "GetObjLstByButtonStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrButtonStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
 /// <param name = "arrButtonStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsButtonStyleEN> GetObjLstByButtonStyleIdLstCache(List<string> arrButtonStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsButtonStyleEN._CurrTabName);
List<clsButtonStyleEN> arrButtonStyleObjLstCache = GetObjLstCache();
IEnumerable <clsButtonStyleEN> arrButtonStyleObjLst_Sel =
from objButtonStyleEN in arrButtonStyleObjLstCache
where arrButtonStyleId.Contains(objButtonStyleEN.ButtonStyleId)
select objButtonStyleEN;
return arrButtonStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsButtonStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
public static List<clsButtonStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsButtonStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
public static List<clsButtonStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsButtonStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
public static List<clsButtonStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsButtonStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonStyleEN>>(strJson);
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
public static int DelRecord(string strButtonStyleId)
{
string strAction = "DelRecord";
try
{
 clsButtonStyleEN objButtonStyleEN = clsButtonStyleWApi.GetObjByButtonStyleId(strButtonStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strButtonStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsButtonStyleWApi.ReFreshCache();
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
public static int DelButtonStyles(List<string> arrButtonStyleId)
{
string strAction = "DelButtonStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrButtonStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsButtonStyleWApi.ReFreshCache();
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
public static int DelButtonStylesByCond(string strWhereCond)
{
string strAction = "DelButtonStylesByCond";
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
public static bool AddNewRecord(clsButtonStyleEN objButtonStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonStyleEN>(objButtonStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsButtonStyleEN objButtonStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonStyleEN>(objButtonStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonStyleWApi.ReFreshCache();
var strButtonStyleId = (string)jobjReturn0["returnStr"];
return strButtonStyleId;
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
public static bool UpdateRecord(clsButtonStyleEN objButtonStyleEN)
{
if (string.IsNullOrEmpty(objButtonStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonStyleEN.ButtonStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonStyleEN>(objButtonStyleEN);
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
 /// <param name = "objButtonStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsButtonStyleEN objButtonStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objButtonStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonStyleEN.ButtonStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonStyleEN.ButtonStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonStyleEN>(objButtonStyleEN);
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
public static bool IsExist(string strButtonStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strButtonStyleId"] = strButtonStyleId
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
 /// <param name = "objButtonStyleENS">源对象</param>
 /// <param name = "objButtonStyleENT">目标对象</param>
 public static void CopyTo(clsButtonStyleEN objButtonStyleENS, clsButtonStyleEN objButtonStyleENT)
{
try
{
objButtonStyleENT.ButtonStyleId = objButtonStyleENS.ButtonStyleId; //按钮样式Id
objButtonStyleENT.ButtonStyleName = objButtonStyleENS.ButtonStyleName; //按钮样式名
objButtonStyleENT.CssClass = objButtonStyleENS.CssClass; //样式表
objButtonStyleENT.Style = objButtonStyleENS.Style; //类型
objButtonStyleENT.Runat = objButtonStyleENS.Runat; //运行在
objButtonStyleENT.FontSize = objButtonStyleENS.FontSize; //字号
objButtonStyleENT.FontName = objButtonStyleENS.FontName; //字体
objButtonStyleENT.Width = objButtonStyleENS.Width; //宽
objButtonStyleENT.Height = objButtonStyleENS.Height; //高度
objButtonStyleENT.StyleZindex = objButtonStyleENS.StyleZindex; //Style_Zindex
objButtonStyleENT.StyleLeft = objButtonStyleENS.StyleLeft; //Style_Left
objButtonStyleENT.StylePosition = objButtonStyleENS.StylePosition; //Style_Position
objButtonStyleENT.StyleTop = objButtonStyleENS.StyleTop; //Style_Top
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
public static DataTable ToDataTable(List<clsButtonStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsButtonStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsButtonStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsButtonStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsButtonStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsButtonStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsButtonStyleEN._CurrTabName);
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
if (clsButtonStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsButtonStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsButtonStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsButtonStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsButtonStyleEN._CurrTabName;
List<clsButtonStyleEN> arrButtonStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrButtonStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsButtonStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conButtonStyle.ButtonStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.ButtonStyleName, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.Style, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonStyle.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonStyle.StyleZindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonStyle.StyleLeft, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonStyle.StylePosition, Type.GetType("System.String"));
objDT.Columns.Add(conButtonStyle.StyleTop, Type.GetType("System.Int32"));
foreach (clsButtonStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conButtonStyle.ButtonStyleId] = objInFor[conButtonStyle.ButtonStyleId];
objDR[conButtonStyle.ButtonStyleName] = objInFor[conButtonStyle.ButtonStyleName];
objDR[conButtonStyle.CssClass] = objInFor[conButtonStyle.CssClass];
objDR[conButtonStyle.Style] = objInFor[conButtonStyle.Style];
objDR[conButtonStyle.Runat] = objInFor[conButtonStyle.Runat];
objDR[conButtonStyle.FontSize] = objInFor[conButtonStyle.FontSize];
objDR[conButtonStyle.FontName] = objInFor[conButtonStyle.FontName];
objDR[conButtonStyle.Width] = objInFor[conButtonStyle.Width];
objDR[conButtonStyle.Height] = objInFor[conButtonStyle.Height];
objDR[conButtonStyle.StyleZindex] = objInFor[conButtonStyle.StyleZindex];
objDR[conButtonStyle.StyleLeft] = objInFor[conButtonStyle.StyleLeft];
objDR[conButtonStyle.StylePosition] = objInFor[conButtonStyle.StylePosition];
objDR[conButtonStyle.StyleTop] = objInFor[conButtonStyle.StyleTop];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 按钮样式(ButtonStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ButtonStyle : clsCommFun4BL
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
clsButtonStyleWApi.ReFreshThisCache();
}
}

}