
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGenCtlStyleWApi
 表名:GenCtlStyle(00050064)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
public static class  clsGenCtlStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strGenCtlStyleId">GenCtlStyleId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetGenCtlStyleId(this clsGenCtlStyleEN objGenCtlStyleEN, string strGenCtlStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGenCtlStyleId, 4, conGenCtlStyle.GenCtlStyleId);
objGenCtlStyleEN.GenCtlStyleId = strGenCtlStyleId; //GenCtlStyleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.GenCtlStyleId) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.GenCtlStyleId, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleId] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strGenCtlStyleName">GenCtlStyleName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetGenCtlStyleName(this clsGenCtlStyleEN objGenCtlStyleEN, string strGenCtlStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGenCtlStyleName, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckFieldLen(strGenCtlStyleName, 30, conGenCtlStyle.GenCtlStyleName);
objGenCtlStyleEN.GenCtlStyleName = strGenCtlStyleName; //GenCtlStyleName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.GenCtlStyleName) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.GenCtlStyleName, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleName] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyle">类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyle(this clsGenCtlStyleEN objGenCtlStyleEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle, 800, conGenCtlStyle.Style);
objGenCtlStyleEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Style) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Style, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Style] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRunat">运行在</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetRunat(this clsGenCtlStyleEN objGenCtlStyleEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRunat, 30, conGenCtlStyle.Runat);
objGenCtlStyleEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Runat) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Runat, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Runat] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetFontSize(this clsGenCtlStyleEN objGenCtlStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, conGenCtlStyle.FontSize);
objGenCtlStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.FontSize) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.FontSize, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.FontSize] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetFontName(this clsGenCtlStyleEN objGenCtlStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, conGenCtlStyle.FontName);
objGenCtlStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.FontName) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.FontName, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.FontName] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetWidth(this clsGenCtlStyleEN objGenCtlStyleEN, int intWidth, string strComparisonOp="")
	{
objGenCtlStyleEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Width) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Width, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Width] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetHeight(this clsGenCtlStyleEN objGenCtlStyleEN, int intHeight, string strComparisonOp="")
	{
objGenCtlStyleEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.Height) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.Height, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.Height] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextMode">TextMode</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetTextMode(this clsGenCtlStyleEN objGenCtlStyleEN, string strTextMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextMode, conGenCtlStyle.TextMode);
clsCheckSql.CheckFieldLen(strTextMode, 20, conGenCtlStyle.TextMode);
objGenCtlStyleEN.TextMode = strTextMode; //TextMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.TextMode) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.TextMode, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.TextMode] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleZindex">Style_Zindex</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleZindex(this clsGenCtlStyleEN objGenCtlStyleEN, int intStyleZindex, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleZindex = intStyleZindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleZindex) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleZindex, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleZindex] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleLeft">Style_Left</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleLeft(this clsGenCtlStyleEN objGenCtlStyleEN, int intStyleLeft, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleLeft = intStyleLeft; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleLeft) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleLeft, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleLeft] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStylePosition">Style_Position</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStylePosition(this clsGenCtlStyleEN objGenCtlStyleEN, string strStylePosition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conGenCtlStyle.StylePosition);
objGenCtlStyleEN.StylePosition = strStylePosition; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StylePosition) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StylePosition, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StylePosition] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleTop">Style_Top</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGenCtlStyleEN SetStyleTop(this clsGenCtlStyleEN objGenCtlStyleEN, int intStyleTop, string strComparisonOp="")
	{
objGenCtlStyleEN.StyleTop = intStyleTop; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGenCtlStyleEN.dicFldComparisonOp.ContainsKey(conGenCtlStyle.StyleTop) == false)
{
objGenCtlStyleEN.dicFldComparisonOp.Add(conGenCtlStyle.StyleTop, strComparisonOp);
}
else
{
objGenCtlStyleEN.dicFldComparisonOp[conGenCtlStyle.StyleTop] = strComparisonOp;
}
}
return objGenCtlStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGenCtlStyleEN objGenCtlStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.GenCtlStyleId) == true)
{
string strComparisonOpGenCtlStyleId = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.GenCtlStyleId, objGenCtlStyleCond.GenCtlStyleId, strComparisonOpGenCtlStyleId);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.GenCtlStyleName) == true)
{
string strComparisonOpGenCtlStyleName = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.GenCtlStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.GenCtlStyleName, objGenCtlStyleCond.GenCtlStyleName, strComparisonOpGenCtlStyleName);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Style) == true)
{
string strComparisonOpStyle = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.Style, objGenCtlStyleCond.Style, strComparisonOpStyle);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Runat) == true)
{
string strComparisonOpRunat = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.Runat, objGenCtlStyleCond.Runat, strComparisonOpRunat);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.FontSize) == true)
{
string strComparisonOpFontSize = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.FontSize, objGenCtlStyleCond.FontSize, strComparisonOpFontSize);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.FontName) == true)
{
string strComparisonOpFontName = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.FontName, objGenCtlStyleCond.FontName, strComparisonOpFontName);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Width) == true)
{
string strComparisonOpWidth = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.Width, objGenCtlStyleCond.Width, strComparisonOpWidth);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.Height) == true)
{
string strComparisonOpHeight = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.Height, objGenCtlStyleCond.Height, strComparisonOpHeight);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.TextMode) == true)
{
string strComparisonOpTextMode = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.TextMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.TextMode, objGenCtlStyleCond.TextMode, strComparisonOpTextMode);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleZindex) == true)
{
string strComparisonOpStyleZindex = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleZindex];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleZindex, objGenCtlStyleCond.StyleZindex, strComparisonOpStyleZindex);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleLeft) == true)
{
string strComparisonOpStyleLeft = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleLeft, objGenCtlStyleCond.StyleLeft, strComparisonOpStyleLeft);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StylePosition) == true)
{
string strComparisonOpStylePosition = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StylePosition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGenCtlStyle.StylePosition, objGenCtlStyleCond.StylePosition, strComparisonOpStylePosition);
}
if (objGenCtlStyleCond.IsUpdated(conGenCtlStyle.StyleTop) == true)
{
string strComparisonOpStyleTop = objGenCtlStyleCond.dicFldComparisonOp[conGenCtlStyle.StyleTop];
strWhereCond += string.Format(" And {0} {2} {1}", conGenCtlStyle.StyleTop, objGenCtlStyleCond.StyleTop, strComparisonOpStyleTop);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objGenCtlStyleEN.sfUpdFldSetStr = objGenCtlStyleEN.getsfUpdFldSetStr();
clsGenCtlStyleWApi.CheckPropertyNew(objGenCtlStyleEN); 
bool bolResult = clsGenCtlStyleWApi.UpdateRecord(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (string.IsNullOrEmpty(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsGenCtlStyleWApi.IsExist(objGenCtlStyleEN.GenCtlStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objGenCtlStyleEN.GenCtlStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsGenCtlStyleWApi.CheckPropertyNew(objGenCtlStyleEN); 
bool bolResult = clsGenCtlStyleWApi.AddNewRecord(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGenCtlStyleEN objGenCtlStyleEN)
{
try
{
clsGenCtlStyleWApi.CheckPropertyNew(objGenCtlStyleEN); 
string strGenCtlStyleId = clsGenCtlStyleWApi.AddNewRecordWithMaxId(objGenCtlStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
return strGenCtlStyleId;
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGenCtlStyleEN objGenCtlStyleEN, string strWhereCond)
{
try
{
clsGenCtlStyleWApi.CheckPropertyNew(objGenCtlStyleEN); 
bool bolResult = clsGenCtlStyleWApi.UpdateWithCondition(objGenCtlStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
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
 /// 一般控件样式(GenCtlStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsGenCtlStyleWApi
{
private static readonly string mstrApiControllerName = "GenCtlStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsGenCtlStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_GenCtlStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[一般控件样式]...","0");
List<clsGenCtlStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="GenCtlStyleId";
objDDL.DataTextField="GenCtlStyleName";
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

public static void BindCbo_GenCtlStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGenCtlStyle.GenCtlStyleId); 
List<clsGenCtlStyleEN> arrObjLst = clsGenCtlStyleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN()
{
GenCtlStyleId = "0",
GenCtlStyleName = "选[一般控件样式]..."
};
arrObjLst.Insert(0, objGenCtlStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGenCtlStyle.GenCtlStyleId;
objComboBox.DisplayMember = conGenCtlStyle.GenCtlStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsGenCtlStyleEN objGenCtlStyleEN)
{
if (!Object.Equals(null, objGenCtlStyleEN.GenCtlStyleId) && GetStrLen(objGenCtlStyleEN.GenCtlStyleId) > 4)
{
 throw new Exception("字段[GenCtlStyleId]的长度不能超过4!");
}
if (!Object.Equals(null, objGenCtlStyleEN.GenCtlStyleName) && GetStrLen(objGenCtlStyleEN.GenCtlStyleName) > 30)
{
 throw new Exception("字段[GenCtlStyleName]的长度不能超过30!");
}
if (!Object.Equals(null, objGenCtlStyleEN.Style) && GetStrLen(objGenCtlStyleEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
if (!Object.Equals(null, objGenCtlStyleEN.Runat) && GetStrLen(objGenCtlStyleEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objGenCtlStyleEN.FontSize) && GetStrLen(objGenCtlStyleEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objGenCtlStyleEN.FontName) && GetStrLen(objGenCtlStyleEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objGenCtlStyleEN.TextMode) && GetStrLen(objGenCtlStyleEN.TextMode) > 20)
{
 throw new Exception("字段[TextMode]的长度不能超过20!");
}
if (!Object.Equals(null, objGenCtlStyleEN.StylePosition) && GetStrLen(objGenCtlStyleEN.StylePosition) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
 objGenCtlStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGenCtlStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGenCtlStyleEN GetObjByGenCtlStyleId(string strGenCtlStyleId)
{
if (strGenCtlStyleId == "") return null;
string strAction = "GetObjByGenCtlStyleId";
clsGenCtlStyleEN objGenCtlStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strGenCtlStyleId"] = strGenCtlStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objGenCtlStyleEN = JsonConvert.DeserializeObject<clsGenCtlStyleEN>(strJson);
return objGenCtlStyleEN;
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
public static clsGenCtlStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsGenCtlStyleEN objGenCtlStyleEN;
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
objGenCtlStyleEN = JsonConvert.DeserializeObject<clsGenCtlStyleEN>(strJson);
return objGenCtlStyleEN;
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
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGenCtlStyleEN GetObjByGenCtlStyleIdCache(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel =
from objGenCtlStyleEN in arrGenCtlStyleObjLstCache
where objGenCtlStyleEN.GenCtlStyleId == strGenCtlStyleId 
select objGenCtlStyleEN;
if (arrGenCtlStyleObjLst_Sel.Count() == 0)
{
   clsGenCtlStyleEN obj = clsGenCtlStyleWApi.GetObjByGenCtlStyleId(strGenCtlStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrGenCtlStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGenCtlStyleNameByGenCtlStyleIdCache(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return "";
//初始化列表缓存
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel1 =
from objGenCtlStyleEN in arrGenCtlStyleObjLstCache
where objGenCtlStyleEN.GenCtlStyleId == strGenCtlStyleId 
select objGenCtlStyleEN;
List <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel = new List<clsGenCtlStyleEN>();
foreach (clsGenCtlStyleEN obj in arrGenCtlStyleObjLst_Sel1)
{
arrGenCtlStyleObjLst_Sel.Add(obj);
}
if (arrGenCtlStyleObjLst_Sel.Count > 0)
{
return arrGenCtlStyleObjLst_Sel[0].GenCtlStyleName;
}
string strErrMsgForGetObjById = string.Format("在GenCtlStyle对象缓存列表中,找不到记录[GenCtlStyleId = {0}](函数:{1})", strGenCtlStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGenCtlStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strGenCtlStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByGenCtlStyleIdCache(string strGenCtlStyleId)
{
if (string.IsNullOrEmpty(strGenCtlStyleId) == true) return "";
//初始化列表缓存
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel1 =
from objGenCtlStyleEN in arrGenCtlStyleObjLstCache
where objGenCtlStyleEN.GenCtlStyleId == strGenCtlStyleId 
select objGenCtlStyleEN;
List <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel = new List<clsGenCtlStyleEN>();
foreach (clsGenCtlStyleEN obj in arrGenCtlStyleObjLst_Sel1)
{
arrGenCtlStyleObjLst_Sel.Add(obj);
}
if (arrGenCtlStyleObjLst_Sel.Count > 0)
{
return arrGenCtlStyleObjLst_Sel[0].GenCtlStyleName;
}
string strErrMsgForGetObjById = string.Format("在GenCtlStyle对象缓存列表中,找不到记录的相关名称[GenCtlStyleId = {0}](函数:{1})", strGenCtlStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGenCtlStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLst(string strWhereCond)
{
 List<clsGenCtlStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
 /// <param name = "arrGenCtlStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstByGenCtlStyleIdLst(List<string> arrGenCtlStyleId)
{
 List<clsGenCtlStyleEN> arrObjLst; 
string strAction = "GetObjLstByGenCtlStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrGenCtlStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
 /// <param name = "arrGenCtlStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsGenCtlStyleEN> GetObjLstByGenCtlStyleIdLstCache(List<string> arrGenCtlStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = GetObjLstCache();
IEnumerable <clsGenCtlStyleEN> arrGenCtlStyleObjLst_Sel =
from objGenCtlStyleEN in arrGenCtlStyleObjLstCache
where arrGenCtlStyleId.Contains(objGenCtlStyleEN.GenCtlStyleId)
select objGenCtlStyleEN;
return arrGenCtlStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGenCtlStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsGenCtlStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
public static List<clsGenCtlStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsGenCtlStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
public static List<clsGenCtlStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsGenCtlStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
public static List<clsGenCtlStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsGenCtlStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGenCtlStyleEN>>(strJson);
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
public static int DelRecord(string strGenCtlStyleId)
{
string strAction = "DelRecord";
try
{
 clsGenCtlStyleEN objGenCtlStyleEN = clsGenCtlStyleWApi.GetObjByGenCtlStyleId(strGenCtlStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strGenCtlStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGenCtlStyleWApi.ReFreshCache();
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
public static int DelGenCtlStyles(List<string> arrGenCtlStyleId)
{
string strAction = "DelGenCtlStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrGenCtlStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGenCtlStyleWApi.ReFreshCache();
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
public static int DelGenCtlStylesByCond(string strWhereCond)
{
string strAction = "DelGenCtlStylesByCond";
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
public static bool AddNewRecord(clsGenCtlStyleEN objGenCtlStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGenCtlStyleEN>(objGenCtlStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsGenCtlStyleEN objGenCtlStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGenCtlStyleEN>(objGenCtlStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGenCtlStyleWApi.ReFreshCache();
var strGenCtlStyleId = (string)jobjReturn0["returnStr"];
return strGenCtlStyleId;
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
public static bool UpdateRecord(clsGenCtlStyleEN objGenCtlStyleEN)
{
if (string.IsNullOrEmpty(objGenCtlStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGenCtlStyleEN.GenCtlStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGenCtlStyleEN>(objGenCtlStyleEN);
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsGenCtlStyleEN objGenCtlStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objGenCtlStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGenCtlStyleEN.GenCtlStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGenCtlStyleEN.GenCtlStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGenCtlStyleEN>(objGenCtlStyleEN);
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
public static bool IsExist(string strGenCtlStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strGenCtlStyleId"] = strGenCtlStyleId
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
 /// <param name = "objGenCtlStyleENS">源对象</param>
 /// <param name = "objGenCtlStyleENT">目标对象</param>
 public static void CopyTo(clsGenCtlStyleEN objGenCtlStyleENS, clsGenCtlStyleEN objGenCtlStyleENT)
{
try
{
objGenCtlStyleENT.GenCtlStyleId = objGenCtlStyleENS.GenCtlStyleId; //GenCtlStyleId
objGenCtlStyleENT.GenCtlStyleName = objGenCtlStyleENS.GenCtlStyleName; //GenCtlStyleName
objGenCtlStyleENT.Style = objGenCtlStyleENS.Style; //类型
objGenCtlStyleENT.Runat = objGenCtlStyleENS.Runat; //运行在
objGenCtlStyleENT.FontSize = objGenCtlStyleENS.FontSize; //字号
objGenCtlStyleENT.FontName = objGenCtlStyleENS.FontName; //字体
objGenCtlStyleENT.Width = objGenCtlStyleENS.Width; //宽
objGenCtlStyleENT.Height = objGenCtlStyleENS.Height; //高度
objGenCtlStyleENT.TextMode = objGenCtlStyleENS.TextMode; //TextMode
objGenCtlStyleENT.StyleZindex = objGenCtlStyleENS.StyleZindex; //Style_Zindex
objGenCtlStyleENT.StyleLeft = objGenCtlStyleENS.StyleLeft; //Style_Left
objGenCtlStyleENT.StylePosition = objGenCtlStyleENS.StylePosition; //Style_Position
objGenCtlStyleENT.StyleTop = objGenCtlStyleENS.StyleTop; //Style_Top
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
public static DataTable ToDataTable(List<clsGenCtlStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsGenCtlStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsGenCtlStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsGenCtlStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsGenCtlStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsGenCtlStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
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
if (clsGenCtlStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGenCtlStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGenCtlStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGenCtlStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsGenCtlStyleEN._CurrTabName;
List<clsGenCtlStyleEN> arrGenCtlStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrGenCtlStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsGenCtlStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conGenCtlStyle.GenCtlStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.GenCtlStyleName, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.Style, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conGenCtlStyle.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conGenCtlStyle.TextMode, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.StyleZindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conGenCtlStyle.StyleLeft, Type.GetType("System.Int32"));
objDT.Columns.Add(conGenCtlStyle.StylePosition, Type.GetType("System.String"));
objDT.Columns.Add(conGenCtlStyle.StyleTop, Type.GetType("System.Int32"));
foreach (clsGenCtlStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conGenCtlStyle.GenCtlStyleId] = objInFor[conGenCtlStyle.GenCtlStyleId];
objDR[conGenCtlStyle.GenCtlStyleName] = objInFor[conGenCtlStyle.GenCtlStyleName];
objDR[conGenCtlStyle.Style] = objInFor[conGenCtlStyle.Style];
objDR[conGenCtlStyle.Runat] = objInFor[conGenCtlStyle.Runat];
objDR[conGenCtlStyle.FontSize] = objInFor[conGenCtlStyle.FontSize];
objDR[conGenCtlStyle.FontName] = objInFor[conGenCtlStyle.FontName];
objDR[conGenCtlStyle.Width] = objInFor[conGenCtlStyle.Width];
objDR[conGenCtlStyle.Height] = objInFor[conGenCtlStyle.Height];
objDR[conGenCtlStyle.TextMode] = objInFor[conGenCtlStyle.TextMode];
objDR[conGenCtlStyle.StyleZindex] = objInFor[conGenCtlStyle.StyleZindex];
objDR[conGenCtlStyle.StyleLeft] = objInFor[conGenCtlStyle.StyleLeft];
objDR[conGenCtlStyle.StylePosition] = objInFor[conGenCtlStyle.StylePosition];
objDR[conGenCtlStyle.StyleTop] = objInFor[conGenCtlStyle.StyleTop];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 一般控件样式(GenCtlStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4GenCtlStyle : clsCommFun4BL
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
clsGenCtlStyleWApi.ReFreshThisCache();
}
}

}