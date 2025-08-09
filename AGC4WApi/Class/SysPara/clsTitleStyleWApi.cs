
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTitleStyleWApi
 表名:TitleStyle(00050004)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsTitleStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleId">标题类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleStyleId(this clsTitleStyleEN objTitleStyleEN, string strTitleStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, conTitleStyle.TitleStyleId);
objTitleStyleEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleStyleId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleStyleId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleStyleId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleName">标题类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleStyleName(this clsTitleStyleEN objTitleStyleEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, conTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, conTitleStyle.TitleStyleName);
objTitleStyleEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleStyleName) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleStyleName, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleStyleName] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetPrjId(this clsTitleStyleEN objTitleStyleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTitleStyle.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTitleStyle.PrjId);
objTitleStyleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.PrjId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.PrjId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.PrjId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabHeight">表格高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTabHeight(this clsTitleStyleEN objTitleStyleEN, int intTabHeight, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabHeight, conTitleStyle.TabHeight);
objTitleStyleEN.TabHeight = intTabHeight; //表格高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TabHeight) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TabHeight, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TabHeight] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strImgFile">图像文件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetImgFile(this clsTitleStyleEN objTitleStyleEN, string strImgFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strImgFile, conTitleStyle.ImgFile);
clsCheckSql.CheckFieldLen(strImgFile, 200, conTitleStyle.ImgFile);
objTitleStyleEN.ImgFile = strImgFile; //图像文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.ImgFile) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.ImgFile, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.ImgFile] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strBackColor">背景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetBackColor(this clsTitleStyleEN objTitleStyleEN, string strBackColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBackColor, conTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(strBackColor, 30, conTitleStyle.BackColor);
objTitleStyleEN.BackColor = strBackColor; //背景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.BackColor) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.BackColor, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.BackColor] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabWidth">表格宽度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTabWidth(this clsTitleStyleEN objTitleStyleEN, int intTabWidth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTabWidth, conTitleStyle.TabWidth);
objTitleStyleEN.TabWidth = intTabWidth; //表格宽度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TabWidth) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TabWidth, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TabWidth] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeColor">前景颜色</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetForeColor(this clsTitleStyleEN objTitleStyleEN, string strForeColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeColor, conTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(strForeColor, 30, conTitleStyle.ForeColor);
objTitleStyleEN.ForeColor = strForeColor; //前景颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.ForeColor) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.ForeColor, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.ForeColor] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetFontSize(this clsTitleStyleEN objTitleStyleEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, conTitleStyle.FontSize);
objTitleStyleEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.FontSize) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.FontSize, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.FontSize] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetFontName(this clsTitleStyleEN objTitleStyleEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, conTitleStyle.FontName);
objTitleStyleEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.FontName) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.FontName, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.FontName] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefault">是否默认</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetIsDefault(this clsTitleStyleEN objTitleStyleEN, bool bolIsDefault, string strComparisonOp="")
	{
objTitleStyleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.IsDefault) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.IsDefault, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.IsDefault] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleTypeId">标题类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetTitleTypeId(this clsTitleStyleEN objTitleStyleEN, string strTitleTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeId, conTitleStyle.TitleTypeId);
clsCheckSql.CheckFieldLen(strTitleTypeId, 2, conTitleStyle.TitleTypeId);
objTitleStyleEN.TitleTypeId = strTitleTypeId; //标题类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.TitleTypeId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.TitleTypeId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.TitleTypeId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetUpdDate(this clsTitleStyleEN objTitleStyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTitleStyle.UpdDate);
objTitleStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.UpdDate) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.UpdDate, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.UpdDate] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetUpdUserId(this clsTitleStyleEN objTitleStyleEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTitleStyle.UpdUserId);
objTitleStyleEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.UpdUserId) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.UpdUserId, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.UpdUserId] = strComparisonOp;
}
}
return objTitleStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTitleStyleEN SetMemo(this clsTitleStyleEN objTitleStyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTitleStyle.Memo);
objTitleStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTitleStyleEN.dicFldComparisonOp.ContainsKey(conTitleStyle.Memo) == false)
{
objTitleStyleEN.dicFldComparisonOp.Add(conTitleStyle.Memo, strComparisonOp);
}
else
{
objTitleStyleEN.dicFldComparisonOp[conTitleStyle.Memo] = strComparisonOp;
}
}
return objTitleStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTitleStyleEN objTitleStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleStyleId, objTitleStyleCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleStyleName, objTitleStyleCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.PrjId) == true)
{
string strComparisonOpPrjId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.PrjId, objTitleStyleCond.PrjId, strComparisonOpPrjId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TabHeight) == true)
{
string strComparisonOpTabHeight = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TabHeight];
strWhereCond += string.Format(" And {0} {2} {1}", conTitleStyle.TabHeight, objTitleStyleCond.TabHeight, strComparisonOpTabHeight);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.ImgFile) == true)
{
string strComparisonOpImgFile = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.ImgFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.ImgFile, objTitleStyleCond.ImgFile, strComparisonOpImgFile);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.BackColor) == true)
{
string strComparisonOpBackColor = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.BackColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.BackColor, objTitleStyleCond.BackColor, strComparisonOpBackColor);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TabWidth) == true)
{
string strComparisonOpTabWidth = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TabWidth];
strWhereCond += string.Format(" And {0} {2} {1}", conTitleStyle.TabWidth, objTitleStyleCond.TabWidth, strComparisonOpTabWidth);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.ForeColor) == true)
{
string strComparisonOpForeColor = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.ForeColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.ForeColor, objTitleStyleCond.ForeColor, strComparisonOpForeColor);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.FontSize) == true)
{
string strComparisonOpFontSize = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.FontSize, objTitleStyleCond.FontSize, strComparisonOpFontSize);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.FontName) == true)
{
string strComparisonOpFontName = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.FontName, objTitleStyleCond.FontName, strComparisonOpFontName);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.IsDefault) == true)
{
if (objTitleStyleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTitleStyle.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTitleStyle.IsDefault);
}
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.TitleTypeId) == true)
{
string strComparisonOpTitleTypeId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.TitleTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.TitleTypeId, objTitleStyleCond.TitleTypeId, strComparisonOpTitleTypeId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.UpdDate, objTitleStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.UpdUserId, objTitleStyleCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objTitleStyleCond.IsUpdated(conTitleStyle.Memo) == true)
{
string strComparisonOpMemo = objTitleStyleCond.dicFldComparisonOp[conTitleStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTitleStyle.Memo, objTitleStyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTitleStyleEN objTitleStyleEN)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTitleStyleEN.sfUpdFldSetStr = objTitleStyleEN.getsfUpdFldSetStr();
clsTitleStyleWApi.CheckPropertyNew(objTitleStyleEN); 
bool bolResult = clsTitleStyleWApi.UpdateRecord(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
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
 /// 获取唯一性条件串--TitleStyle(标题模式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TitleStyleName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTitleStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTitleStyleEN objTitleStyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTitleStyleEN == null) return "";
if (objTitleStyleEN.TitleStyleId == null || objTitleStyleEN.TitleStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TitleStyleId !=  '{0}'", objTitleStyleEN.TitleStyleId);
 sbCondition.AppendFormat(" and TitleStyleName = '{0}'", objTitleStyleEN.TitleStyleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTitleStyleEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTitleStyleEN objTitleStyleEN)
{
 if (string.IsNullOrEmpty(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTitleStyleWApi.IsExist(objTitleStyleEN.TitleStyleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTitleStyleEN.TitleStyleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTitleStyleWApi.CheckPropertyNew(objTitleStyleEN); 
bool bolResult = clsTitleStyleWApi.AddNewRecord(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
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
 /// <param name = "objTitleStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTitleStyleEN objTitleStyleEN)
{
try
{
clsTitleStyleWApi.CheckPropertyNew(objTitleStyleEN); 
string strTitleStyleId = clsTitleStyleWApi.AddNewRecordWithMaxId(objTitleStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
return strTitleStyleId;
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTitleStyleEN objTitleStyleEN, string strWhereCond)
{
try
{
clsTitleStyleWApi.CheckPropertyNew(objTitleStyleEN); 
bool bolResult = clsTitleStyleWApi.UpdateWithCondition(objTitleStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
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
 /// 标题模式(TitleStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTitleStyleWApi
{
private static readonly string mstrApiControllerName = "TitleStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsTitleStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TitleStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[标题模式]...","0");
List<clsTitleStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TitleStyleId";
objDDL.DataTextField="TitleStyleName";
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

public static void BindCbo_TitleStyleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTitleStyle.TitleStyleId); 
List<clsTitleStyleEN> arrObjLst = clsTitleStyleWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTitleStyleEN objTitleStyleEN = new clsTitleStyleEN()
{
TitleStyleId = "0",
TitleStyleName = "选[标题模式]..."
};
arrObjLst.Insert(0, objTitleStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTitleStyle.TitleStyleId;
objComboBox.DisplayMember = conTitleStyle.TitleStyleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTitleStyleEN objTitleStyleEN)
{
if (!Object.Equals(null, objTitleStyleEN.TitleStyleId) && GetStrLen(objTitleStyleEN.TitleStyleId) > 8)
{
 throw new Exception("字段[标题类型Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTitleStyleEN.TitleStyleName) && GetStrLen(objTitleStyleEN.TitleStyleName) > 20)
{
 throw new Exception("字段[标题类型名]的长度不能超过20!");
}
if (!Object.Equals(null, objTitleStyleEN.PrjId) && GetStrLen(objTitleStyleEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTitleStyleEN.ImgFile) && GetStrLen(objTitleStyleEN.ImgFile) > 200)
{
 throw new Exception("字段[图像文件]的长度不能超过200!");
}
if (!Object.Equals(null, objTitleStyleEN.BackColor) && GetStrLen(objTitleStyleEN.BackColor) > 30)
{
 throw new Exception("字段[背景颜色]的长度不能超过30!");
}
if (!Object.Equals(null, objTitleStyleEN.ForeColor) && GetStrLen(objTitleStyleEN.ForeColor) > 30)
{
 throw new Exception("字段[前景颜色]的长度不能超过30!");
}
if (!Object.Equals(null, objTitleStyleEN.FontSize) && GetStrLen(objTitleStyleEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objTitleStyleEN.FontName) && GetStrLen(objTitleStyleEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objTitleStyleEN.TitleTypeId) && GetStrLen(objTitleStyleEN.TitleTypeId) > 2)
{
 throw new Exception("字段[标题类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objTitleStyleEN.UpdDate) && GetStrLen(objTitleStyleEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTitleStyleEN.UpdUserId) && GetStrLen(objTitleStyleEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTitleStyleEN.Memo) && GetStrLen(objTitleStyleEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTitleStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
if (strTitleStyleId == "") return null;
string strAction = "GetObjByTitleStyleId";
clsTitleStyleEN objTitleStyleEN;
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
objTitleStyleEN = JsonConvert.DeserializeObject<clsTitleStyleEN>(strJson);
return objTitleStyleEN;
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
public static clsTitleStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTitleStyleEN objTitleStyleEN;
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
objTitleStyleEN = JsonConvert.DeserializeObject<clsTitleStyleEN>(strJson);
return objTitleStyleEN;
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
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTitleStyleEN GetObjByTitleStyleIdCache(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel =
from objTitleStyleEN in arrTitleStyleObjLstCache
where objTitleStyleEN.TitleStyleId == strTitleStyleId 
select objTitleStyleEN;
if (arrTitleStyleObjLst_Sel.Count() == 0)
{
   clsTitleStyleEN obj = clsTitleStyleWApi.GetObjByTitleStyleId(strTitleStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTitleStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTitleStyleNameByTitleStyleIdCache(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return "";
//初始化列表缓存
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel1 =
from objTitleStyleEN in arrTitleStyleObjLstCache
where objTitleStyleEN.TitleStyleId == strTitleStyleId 
select objTitleStyleEN;
List <clsTitleStyleEN> arrTitleStyleObjLst_Sel = new List<clsTitleStyleEN>();
foreach (clsTitleStyleEN obj in arrTitleStyleObjLst_Sel1)
{
arrTitleStyleObjLst_Sel.Add(obj);
}
if (arrTitleStyleObjLst_Sel.Count > 0)
{
return arrTitleStyleObjLst_Sel[0].TitleStyleName;
}
string strErrMsgForGetObjById = string.Format("在TitleStyle对象缓存列表中,找不到记录[TitleStyleId = {0}](函数:{1})", strTitleStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTitleStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTitleStyleIdCache(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true) return "";
//初始化列表缓存
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel1 =
from objTitleStyleEN in arrTitleStyleObjLstCache
where objTitleStyleEN.TitleStyleId == strTitleStyleId 
select objTitleStyleEN;
List <clsTitleStyleEN> arrTitleStyleObjLst_Sel = new List<clsTitleStyleEN>();
foreach (clsTitleStyleEN obj in arrTitleStyleObjLst_Sel1)
{
arrTitleStyleObjLst_Sel.Add(obj);
}
if (arrTitleStyleObjLst_Sel.Count > 0)
{
return arrTitleStyleObjLst_Sel[0].TitleStyleName;
}
string strErrMsgForGetObjById = string.Format("在TitleStyle对象缓存列表中,找不到记录的相关名称[TitleStyleId = {0}](函数:{1})", strTitleStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTitleStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTitleStyleEN> GetObjLst(string strWhereCond)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
public static List<clsTitleStyleEN> GetObjLstByTitleStyleIdLst(List<string> arrTitleStyleId)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
 /// <param name = "arrTitleStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsTitleStyleEN> GetObjLstByTitleStyleIdLstCache(List<string> arrTitleStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
List<clsTitleStyleEN> arrTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsTitleStyleEN> arrTitleStyleObjLst_Sel =
from objTitleStyleEN in arrTitleStyleObjLstCache
where arrTitleStyleId.Contains(objTitleStyleEN.TitleStyleId)
select objTitleStyleEN;
return arrTitleStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTitleStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
public static List<clsTitleStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
public static List<clsTitleStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
public static List<clsTitleStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTitleStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTitleStyleEN>>(strJson);
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
public static int DelRecord(string strTitleStyleId)
{
string strAction = "DelRecord";
try
{
 clsTitleStyleEN objTitleStyleEN = clsTitleStyleWApi.GetObjByTitleStyleId(strTitleStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTitleStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTitleStyleWApi.ReFreshCache();
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
public static int DelTitleStyles(List<string> arrTitleStyleId)
{
string strAction = "DelTitleStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTitleStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTitleStyleWApi.ReFreshCache();
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
public static int DelTitleStylesByCond(string strWhereCond)
{
string strAction = "DelTitleStylesByCond";
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
public static bool AddNewRecord(clsTitleStyleEN objTitleStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTitleStyleEN>(objTitleStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsTitleStyleEN objTitleStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTitleStyleEN>(objTitleStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTitleStyleWApi.ReFreshCache();
var strTitleStyleId = (string)jobjReturn0["returnStr"];
return strTitleStyleId;
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
public static bool UpdateRecord(clsTitleStyleEN objTitleStyleEN)
{
if (string.IsNullOrEmpty(objTitleStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTitleStyleEN.TitleStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTitleStyleEN>(objTitleStyleEN);
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
 /// <param name = "objTitleStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTitleStyleEN objTitleStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTitleStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTitleStyleEN.TitleStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTitleStyleEN.TitleStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTitleStyleEN>(objTitleStyleEN);
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
 /// <param name = "objTitleStyleENS">源对象</param>
 /// <param name = "objTitleStyleENT">目标对象</param>
 public static void CopyTo(clsTitleStyleEN objTitleStyleENS, clsTitleStyleEN objTitleStyleENT)
{
try
{
objTitleStyleENT.TitleStyleId = objTitleStyleENS.TitleStyleId; //标题类型Id
objTitleStyleENT.TitleStyleName = objTitleStyleENS.TitleStyleName; //标题类型名
objTitleStyleENT.PrjId = objTitleStyleENS.PrjId; //工程Id
objTitleStyleENT.TabHeight = objTitleStyleENS.TabHeight; //表格高度
objTitleStyleENT.ImgFile = objTitleStyleENS.ImgFile; //图像文件
objTitleStyleENT.BackColor = objTitleStyleENS.BackColor; //背景颜色
objTitleStyleENT.TabWidth = objTitleStyleENS.TabWidth; //表格宽度
objTitleStyleENT.ForeColor = objTitleStyleENS.ForeColor; //前景颜色
objTitleStyleENT.FontSize = objTitleStyleENS.FontSize; //字号
objTitleStyleENT.FontName = objTitleStyleENS.FontName; //字体
objTitleStyleENT.IsDefault = objTitleStyleENS.IsDefault; //是否默认
objTitleStyleENT.TitleTypeId = objTitleStyleENS.TitleTypeId; //标题类型ID
objTitleStyleENT.UpdDate = objTitleStyleENS.UpdDate; //修改日期
objTitleStyleENT.UpdUserId = objTitleStyleENS.UpdUserId; //修改用户Id
objTitleStyleENT.Memo = objTitleStyleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTitleStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTitleStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTitleStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTitleStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTitleStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTitleStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
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
if (clsTitleStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTitleStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTitleStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTitleStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsTitleStyleEN._CurrTabName;
List<clsTitleStyleEN> arrTitleStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTitleStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTitleStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTitleStyle.TitleStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.TitleStyleName, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.TabHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(conTitleStyle.ImgFile, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.BackColor, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.TabWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(conTitleStyle.ForeColor, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTitleStyle.TitleTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTitleStyle.Memo, Type.GetType("System.String"));
foreach (clsTitleStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTitleStyle.TitleStyleId] = objInFor[conTitleStyle.TitleStyleId];
objDR[conTitleStyle.TitleStyleName] = objInFor[conTitleStyle.TitleStyleName];
objDR[conTitleStyle.PrjId] = objInFor[conTitleStyle.PrjId];
objDR[conTitleStyle.TabHeight] = objInFor[conTitleStyle.TabHeight];
objDR[conTitleStyle.ImgFile] = objInFor[conTitleStyle.ImgFile];
objDR[conTitleStyle.BackColor] = objInFor[conTitleStyle.BackColor];
objDR[conTitleStyle.TabWidth] = objInFor[conTitleStyle.TabWidth];
objDR[conTitleStyle.ForeColor] = objInFor[conTitleStyle.ForeColor];
objDR[conTitleStyle.FontSize] = objInFor[conTitleStyle.FontSize];
objDR[conTitleStyle.FontName] = objInFor[conTitleStyle.FontName];
objDR[conTitleStyle.IsDefault] = objInFor[conTitleStyle.IsDefault];
objDR[conTitleStyle.TitleTypeId] = objInFor[conTitleStyle.TitleTypeId];
objDR[conTitleStyle.UpdDate] = objInFor[conTitleStyle.UpdDate];
objDR[conTitleStyle.UpdUserId] = objInFor[conTitleStyle.UpdUserId];
objDR[conTitleStyle.Memo] = objInFor[conTitleStyle.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 标题模式(TitleStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TitleStyle : clsCommFun4BL
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
clsTitleStyleWApi.ReFreshThisCache();
}
}

}