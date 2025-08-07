
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTitleStyleWApi
 表名:vTitleStyle(00050304)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:26
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
public static class  clsvTitleStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleId">标题类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleStyleId(this clsvTitleStyleEN objvTitleStyleEN, string strTitleStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convTitleStyle.TitleStyleId);
objvTitleStyleEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TitleStyleId) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TitleStyleId, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TitleStyleId] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleTypeName">标题类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleTypeName(this clsvTitleStyleEN objvTitleStyleEN, string strTitleTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeName, convTitleStyle.TitleTypeName);
clsCheckSql.CheckFieldLen(strTitleTypeName, 20, convTitleStyle.TitleTypeName);
objvTitleStyleEN.TitleTypeName = strTitleTypeName; //标题类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TitleTypeName) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TitleTypeName, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TitleTypeName] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleName">标题类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleStyleName(this clsvTitleStyleEN objvTitleStyleEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, convTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convTitleStyle.TitleStyleName);
objvTitleStyleEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TitleStyleName) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TitleStyleName, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TitleStyleName] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetPrjId(this clsvTitleStyleEN objvTitleStyleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convTitleStyle.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTitleStyle.PrjId);
objvTitleStyleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.PrjId) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.PrjId, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.PrjId] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabHeight">表格高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTabHeight(this clsvTitleStyleEN objvTitleStyleEN, int intTabHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabHeight, convTitleStyle.TabHeight);
objvTitleStyleEN.TabHeight = intTabHeight; //表格高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TabHeight) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TabHeight, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TabHeight] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetPrjName(this clsvTitleStyleEN objvTitleStyleEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTitleStyle.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convTitleStyle.PrjName);
objvTitleStyleEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.PrjName) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.PrjName, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.PrjName] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetImgFile(this clsvTitleStyleEN objvTitleStyleEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgFile, 200, convTitleStyle.ImgFile);
objvTitleStyleEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.ImgFile) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.ImgFile, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.ImgFile] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strBackColor">背景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetBackColor(this clsvTitleStyleEN objvTitleStyleEN, string strBackColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBackColor, convTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(strBackColor, 30, convTitleStyle.BackColor);
objvTitleStyleEN.BackColor = strBackColor; //背景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.BackColor) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.BackColor, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.BackColor] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabWidth">表格宽度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTabWidth(this clsvTitleStyleEN objvTitleStyleEN, int intTabWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabWidth, convTitleStyle.TabWidth);
objvTitleStyleEN.TabWidth = intTabWidth; //表格宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TabWidth) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TabWidth, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TabWidth] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeColor">前景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetForeColor(this clsvTitleStyleEN objvTitleStyleEN, string strForeColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeColor, convTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(strForeColor, 30, convTitleStyle.ForeColor);
objvTitleStyleEN.ForeColor = strForeColor; //前景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.ForeColor) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.ForeColor, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.ForeColor] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetFontSize(this clsvTitleStyleEN objvTitleStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, convTitleStyle.FontSize);
objvTitleStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.FontSize) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.FontSize, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.FontSize] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetFontName(this clsvTitleStyleEN objvTitleStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, convTitleStyle.FontName);
objvTitleStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.FontName) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.FontName, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.FontName] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefault">是否默认</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetIsDefault(this clsvTitleStyleEN objvTitleStyleEN, bool bolIsDefault, string strComparisonOp="")
	{
objvTitleStyleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.IsDefault) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.IsDefault, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.IsDefault] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleTypeId">标题类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleTypeId(this clsvTitleStyleEN objvTitleStyleEN, string strTitleTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeId, convTitleStyle.TitleTypeId);
clsCheckSql.CheckFieldLen(strTitleTypeId, 2, convTitleStyle.TitleTypeId);
objvTitleStyleEN.TitleTypeId = strTitleTypeId; //标题类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTitleStyleEN.dicFldComparisonOp.ContainsKey(convTitleStyle.TitleTypeId) == false)
{
objvTitleStyleEN.dicFldComparisonOp.Add(convTitleStyle.TitleTypeId, strComparisonOp);
}
else
{
objvTitleStyleEN.dicFldComparisonOp[convTitleStyle.TitleTypeId] = strComparisonOp;
}
}
return objvTitleStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTitleStyleEN objvTitleStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.TitleStyleId, objvTitleStyleCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TitleTypeName) == true)
{
string strComparisonOpTitleTypeName = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TitleTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.TitleTypeName, objvTitleStyleCond.TitleTypeName, strComparisonOpTitleTypeName);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.TitleStyleName, objvTitleStyleCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.PrjId) == true)
{
string strComparisonOpPrjId = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.PrjId, objvTitleStyleCond.PrjId, strComparisonOpPrjId);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TabHeight) == true)
{
string strComparisonOpTabHeight = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TabHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convTitleStyle.TabHeight, objvTitleStyleCond.TabHeight, strComparisonOpTabHeight);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.PrjName) == true)
{
string strComparisonOpPrjName = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.PrjName, objvTitleStyleCond.PrjName, strComparisonOpPrjName);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.ImgFile) == true)
{
string strComparisonOpImgFile = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.ImgFile, objvTitleStyleCond.ImgFile, strComparisonOpImgFile);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.BackColor) == true)
{
string strComparisonOpBackColor = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.BackColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.BackColor, objvTitleStyleCond.BackColor, strComparisonOpBackColor);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TabWidth) == true)
{
string strComparisonOpTabWidth = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TabWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convTitleStyle.TabWidth, objvTitleStyleCond.TabWidth, strComparisonOpTabWidth);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.ForeColor) == true)
{
string strComparisonOpForeColor = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.ForeColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.ForeColor, objvTitleStyleCond.ForeColor, strComparisonOpForeColor);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.FontSize) == true)
{
string strComparisonOpFontSize = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.FontSize, objvTitleStyleCond.FontSize, strComparisonOpFontSize);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.FontName) == true)
{
string strComparisonOpFontName = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.FontName, objvTitleStyleCond.FontName, strComparisonOpFontName);
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.IsDefault) == true)
{
if (objvTitleStyleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTitleStyle.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTitleStyle.IsDefault);
}
}
if (objvTitleStyleCond.IsUpdated(convTitleStyle.TitleTypeId) == true)
{
string strComparisonOpTitleTypeId = objvTitleStyleCond.dicFldComparisonOp[convTitleStyle.TitleTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTitleStyle.TitleTypeId, objvTitleStyleCond.TitleTypeId, strComparisonOpTitleTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v标题模式(vTitleStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTitleStyleWApi
{
private static readonly string mstrApiControllerName = "vTitleStyleApi";

 public clsvTitleStyleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
if (strTitleStyleId == "") return null;
string strAction = "GetObjByTitleStyleId";
clsvTitleStyleEN objvTitleStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTitleStyleId"] = strTitleStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvTitleStyleEN = JsonConvert.DeserializeObject<clsvTitleStyleEN>(strJson);
return objvTitleStyleEN;
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
public static clsvTitleStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTitleStyleEN objvTitleStyleEN;
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
objvTitleStyleEN = JsonConvert.DeserializeObject<clsvTitleStyleEN>(strJson);
return objvTitleStyleEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLst(string strWhereCond)
{
 List<clsvTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
 /// <param name = "arrTitleStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLstByTitleStyleIdLst(List<string> arrTitleStyleId)
{
 List<clsvTitleStyleEN> arrObjLst; 
string strAction = "GetObjLstByTitleStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTitleStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
public static List<clsvTitleStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
public static List<clsvTitleStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
public static List<clsvTitleStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTitleStyleEN>>(strJson);
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
public static bool IsExist(string strTitleStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTitleStyleId"] = strTitleStyleId
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvTitleStyleENS">源对象</param>
 /// <param name = "objvTitleStyleENT">目标对象</param>
 public static void CopyTo(clsvTitleStyleEN objvTitleStyleENS, clsvTitleStyleEN objvTitleStyleENT)
{
try
{
objvTitleStyleENT.TitleStyleId = objvTitleStyleENS.TitleStyleId; //标题类型Id
objvTitleStyleENT.TitleTypeName = objvTitleStyleENS.TitleTypeName; //标题类型
objvTitleStyleENT.TitleStyleName = objvTitleStyleENS.TitleStyleName; //标题类型名
objvTitleStyleENT.PrjId = objvTitleStyleENS.PrjId; //工程Id
objvTitleStyleENT.TabHeight = objvTitleStyleENS.TabHeight; //表格高度
objvTitleStyleENT.PrjName = objvTitleStyleENS.PrjName; //工程名称
objvTitleStyleENT.ImgFile = objvTitleStyleENS.ImgFile; //图像文件
objvTitleStyleENT.BackColor = objvTitleStyleENS.BackColor; //背景颜色
objvTitleStyleENT.TabWidth = objvTitleStyleENS.TabWidth; //表格宽度
objvTitleStyleENT.ForeColor = objvTitleStyleENS.ForeColor; //前景颜色
objvTitleStyleENT.FontSize = objvTitleStyleENS.FontSize; //字号
objvTitleStyleENT.FontName = objvTitleStyleENS.FontName; //字体
objvTitleStyleENT.IsDefault = objvTitleStyleENS.IsDefault; //是否默认
objvTitleStyleENT.TitleTypeId = objvTitleStyleENS.TitleTypeId; //标题类型ID
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
public static DataTable ToDataTable(List<clsvTitleStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTitleStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTitleStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTitleStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTitleStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTitleStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsvTitleStyleEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTitleStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTitleStyle.TitleStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.TitleTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.TitleStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.TabHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convTitleStyle.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.BackColor, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.TabWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convTitleStyle.ForeColor, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(convTitleStyle.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTitleStyle.TitleTypeId, Type.GetType("System.String"));
foreach (clsvTitleStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTitleStyle.TitleStyleId] = objInFor[convTitleStyle.TitleStyleId];
objDR[convTitleStyle.TitleTypeName] = objInFor[convTitleStyle.TitleTypeName];
objDR[convTitleStyle.TitleStyleName] = objInFor[convTitleStyle.TitleStyleName];
objDR[convTitleStyle.PrjId] = objInFor[convTitleStyle.PrjId];
objDR[convTitleStyle.TabHeight] = objInFor[convTitleStyle.TabHeight];
objDR[convTitleStyle.PrjName] = objInFor[convTitleStyle.PrjName];
objDR[convTitleStyle.ImgFile] = objInFor[convTitleStyle.ImgFile];
objDR[convTitleStyle.BackColor] = objInFor[convTitleStyle.BackColor];
objDR[convTitleStyle.TabWidth] = objInFor[convTitleStyle.TabWidth];
objDR[convTitleStyle.ForeColor] = objInFor[convTitleStyle.ForeColor];
objDR[convTitleStyle.FontSize] = objInFor[convTitleStyle.FontSize];
objDR[convTitleStyle.FontName] = objInFor[convTitleStyle.FontName];
objDR[convTitleStyle.IsDefault] = objInFor[convTitleStyle.IsDefault];
objDR[convTitleStyle.TitleTypeId] = objInFor[convTitleStyle.TitleTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}