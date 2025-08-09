
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTitleStyleBL
 表名:vTitleStyle(00050304)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsvTitleStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTitleStyleEN GetObj(this K_TitleStyleId_vTitleStyle myKey)
{
clsvTitleStyleEN objvTitleStyleEN = clsvTitleStyleBL.vTitleStyleDA.GetObjByTitleStyleId(myKey.Value);
return objvTitleStyleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleStyleId(this clsvTitleStyleEN objvTitleStyleEN, string strTitleStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convTitleStyle.TitleStyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleTypeName(this clsvTitleStyleEN objvTitleStyleEN, string strTitleTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeName, convTitleStyle.TitleTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleTypeName, 20, convTitleStyle.TitleTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleStyleName(this clsvTitleStyleEN objvTitleStyleEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleName, convTitleStyle.TitleStyleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convTitleStyle.TitleStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetPrjId(this clsvTitleStyleEN objvTitleStyleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTitleStyle.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTitleStyle.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTitleStyle.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetPrjName(this clsvTitleStyleEN objvTitleStyleEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convTitleStyle.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convTitleStyle.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetImgFile(this clsvTitleStyleEN objvTitleStyleEN, string strImgFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgFile, 200, convTitleStyle.ImgFile);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetBackColor(this clsvTitleStyleEN objvTitleStyleEN, string strBackColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBackColor, convTitleStyle.BackColor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBackColor, 30, convTitleStyle.BackColor);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetForeColor(this clsvTitleStyleEN objvTitleStyleEN, string strForeColor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeColor, convTitleStyle.ForeColor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strForeColor, 30, convTitleStyle.ForeColor);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetFontSize(this clsvTitleStyleEN objvTitleStyleEN, string strFontSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontSize, 20, convTitleStyle.FontSize);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetFontName(this clsvTitleStyleEN objvTitleStyleEN, string strFontName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFontName, 20, convTitleStyle.FontName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTitleStyleEN SetTitleTypeId(this clsvTitleStyleEN objvTitleStyleEN, string strTitleTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleTypeId, convTitleStyle.TitleTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleTypeId, 2, convTitleStyle.TitleTypeId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTitleStyleENS">源对象</param>
 /// <param name = "objvTitleStyleENT">目标对象</param>
 public static void CopyTo(this clsvTitleStyleEN objvTitleStyleENS, clsvTitleStyleEN objvTitleStyleENT)
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
 /// <param name = "objvTitleStyleENS">源对象</param>
 /// <returns>目标对象=>clsvTitleStyleEN:objvTitleStyleENT</returns>
 public static clsvTitleStyleEN CopyTo(this clsvTitleStyleEN objvTitleStyleENS)
{
try
{
 clsvTitleStyleEN objvTitleStyleENT = new clsvTitleStyleEN()
{
TitleStyleId = objvTitleStyleENS.TitleStyleId, //标题类型Id
TitleTypeName = objvTitleStyleENS.TitleTypeName, //标题类型
TitleStyleName = objvTitleStyleENS.TitleStyleName, //标题类型名
PrjId = objvTitleStyleENS.PrjId, //工程Id
TabHeight = objvTitleStyleENS.TabHeight, //表格高度
PrjName = objvTitleStyleENS.PrjName, //工程名称
ImgFile = objvTitleStyleENS.ImgFile, //图像文件
BackColor = objvTitleStyleENS.BackColor, //背景颜色
TabWidth = objvTitleStyleENS.TabWidth, //表格宽度
ForeColor = objvTitleStyleENS.ForeColor, //前景颜色
FontSize = objvTitleStyleENS.FontSize, //字号
FontName = objvTitleStyleENS.FontName, //字体
IsDefault = objvTitleStyleENS.IsDefault, //是否默认
TitleTypeId = objvTitleStyleENS.TitleTypeId, //标题类型ID
};
 return objvTitleStyleENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvTitleStyleEN objvTitleStyleEN)
{
 clsvTitleStyleBL.vTitleStyleDA.CheckProperty4Condition(objvTitleStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTitleStyle
{
public virtual bool UpdRelaTabDate(string strTitleStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v标题模式(vTitleStyle)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTitleStyleBL
{
public static RelatedActions_vTitleStyle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTitleStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTitleStyleDA vTitleStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTitleStyleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTitleStyleBL()
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
if (string.IsNullOrEmpty(clsvTitleStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTitleStyleEN._ConnectString);
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
public static DataTable GetDataTable_vTitleStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTitleStyleDA.GetDataTable_vTitleStyle(strWhereCond);
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
objDT = vTitleStyleDA.GetDataTable(strWhereCond);
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
objDT = vTitleStyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTitleStyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTitleStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTitleStyleDA.GetDataTable_Top(objTopPara);
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
objDT = vTitleStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTitleStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTitleStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTitleStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLstByTitleStyleIdLst(List<string> arrTitleStyleIdLst)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTitleStyleIdLst, true);
 string strWhereCond = string.Format("TitleStyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTitleStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTitleStyleEN> GetObjLstByTitleStyleIdLstCache(List<string> arrTitleStyleIdLst)
{
string strKey = string.Format("{0}", clsvTitleStyleEN._CurrTabName);
List<clsvTitleStyleEN> arrvTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvTitleStyleEN> arrvTitleStyleObjLst_Sel =
arrvTitleStyleObjLstCache
.Where(x => arrTitleStyleIdLst.Contains(x.TitleStyleId));
return arrvTitleStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLst(string strWhereCond)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
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
public static List<clsvTitleStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTitleStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTitleStyleEN> GetSubObjLstCache(clsvTitleStyleEN objvTitleStyleCond)
{
List<clsvTitleStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTitleStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTitleStyle._AttributeName)
{
if (objvTitleStyleCond.IsUpdated(strFldName) == false) continue;
if (objvTitleStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTitleStyleCond[strFldName].ToString());
}
else
{
if (objvTitleStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTitleStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTitleStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTitleStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTitleStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTitleStyleCond[strFldName]));
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
public static List<clsvTitleStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
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
public static List<clsvTitleStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
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
List<clsvTitleStyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTitleStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTitleStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
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
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
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
public static List<clsvTitleStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTitleStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
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
public static List<clsvTitleStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程Id
objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTitleStyleEN.TitleStyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTitleStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTitleStyle(ref clsvTitleStyleEN objvTitleStyleEN)
{
bool bolResult = vTitleStyleDA.GetvTitleStyle(ref objvTitleStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
if (strTitleStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTitleStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTitleStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTitleStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTitleStyleEN objvTitleStyleEN = vTitleStyleDA.GetObjByTitleStyleId(strTitleStyleId);
return objvTitleStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTitleStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTitleStyleEN objvTitleStyleEN = vTitleStyleDA.GetFirstObj(strWhereCond);
 return objvTitleStyleEN;
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
public static clsvTitleStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTitleStyleEN objvTitleStyleEN = vTitleStyleDA.GetObjByDataRow(objRow);
 return objvTitleStyleEN;
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
public static clsvTitleStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTitleStyleEN objvTitleStyleEN = vTitleStyleDA.GetObjByDataRow(objRow);
 return objvTitleStyleEN;
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
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <param name = "lstvTitleStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTitleStyleEN GetObjByTitleStyleIdFromList(string strTitleStyleId, List<clsvTitleStyleEN> lstvTitleStyleObjLst)
{
foreach (clsvTitleStyleEN objvTitleStyleEN in lstvTitleStyleObjLst)
{
if (objvTitleStyleEN.TitleStyleId == strTitleStyleId)
{
return objvTitleStyleEN;
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
 string strTitleStyleId;
 try
 {
 strTitleStyleId = new clsvTitleStyleDA().GetFirstID(strWhereCond);
 return strTitleStyleId;
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
 arrList = vTitleStyleDA.GetID(strWhereCond);
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
bool bolIsExist = vTitleStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTitleStyleId)
{
if (string.IsNullOrEmpty(strTitleStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTitleStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTitleStyleDA.IsExist(strTitleStyleId);
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
 bolIsExist = clsvTitleStyleDA.IsExistTable();
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
 bolIsExist = vTitleStyleDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
 /// <param name = "objvTitleStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsvTitleStyleEN objvTitleStyleEN)
{
try
{
objvTitleStyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTitleStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTitleStyle.TitleStyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TitleStyleId = objvTitleStyleEN.TitleStyleId; //标题类型Id
}
if (arrFldSet.Contains(convTitleStyle.TitleTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TitleTypeName = objvTitleStyleEN.TitleTypeName; //标题类型
}
if (arrFldSet.Contains(convTitleStyle.TitleStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TitleStyleName = objvTitleStyleEN.TitleStyleName; //标题类型名
}
if (arrFldSet.Contains(convTitleStyle.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.PrjId = objvTitleStyleEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convTitleStyle.TabHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TabHeight = objvTitleStyleEN.TabHeight; //表格高度
}
if (arrFldSet.Contains(convTitleStyle.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.PrjName = objvTitleStyleEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convTitleStyle.ImgFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.ImgFile = objvTitleStyleEN.ImgFile == "[null]" ? null :  objvTitleStyleEN.ImgFile; //图像文件
}
if (arrFldSet.Contains(convTitleStyle.BackColor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.BackColor = objvTitleStyleEN.BackColor; //背景颜色
}
if (arrFldSet.Contains(convTitleStyle.TabWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TabWidth = objvTitleStyleEN.TabWidth; //表格宽度
}
if (arrFldSet.Contains(convTitleStyle.ForeColor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.ForeColor = objvTitleStyleEN.ForeColor; //前景颜色
}
if (arrFldSet.Contains(convTitleStyle.FontSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.FontSize = objvTitleStyleEN.FontSize == "[null]" ? null :  objvTitleStyleEN.FontSize; //字号
}
if (arrFldSet.Contains(convTitleStyle.FontName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.FontName = objvTitleStyleEN.FontName == "[null]" ? null :  objvTitleStyleEN.FontName; //字体
}
if (arrFldSet.Contains(convTitleStyle.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.IsDefault = objvTitleStyleEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(convTitleStyle.TitleTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTitleStyleEN.TitleTypeId = objvTitleStyleEN.TitleTypeId; //标题类型ID
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
 /// <param name = "objvTitleStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTitleStyleEN objvTitleStyleEN)
{
try
{
if (objvTitleStyleEN.ImgFile == "[null]") objvTitleStyleEN.ImgFile = null; //图像文件
if (objvTitleStyleEN.FontSize == "[null]") objvTitleStyleEN.FontSize = null; //字号
if (objvTitleStyleEN.FontName == "[null]") objvTitleStyleEN.FontName = null; //字体
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvTitleStyleEN objvTitleStyleEN)
{
 vTitleStyleDA.CheckProperty4Condition(objvTitleStyleEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTitleStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTitleStyleBL没有刷新缓存机制(clsTitleStyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTitleTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTitleTypeBL没有刷新缓存机制(clsTitleTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TitleStyleId");
//if (arrvTitleStyleObjLstCache == null)
//{
//arrvTitleStyleObjLstCache = vTitleStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTitleStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTitleStyleEN GetObjByTitleStyleIdCache(string strTitleStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTitleStyleEN._CurrTabName);
List<clsvTitleStyleEN> arrvTitleStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvTitleStyleEN> arrvTitleStyleObjLst_Sel =
arrvTitleStyleObjLstCache
.Where(x=> x.TitleStyleId == strTitleStyleId 
);
if (arrvTitleStyleObjLst_Sel.Count() == 0)
{
   clsvTitleStyleEN obj = clsvTitleStyleBL.GetObjByTitleStyleId(strTitleStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTitleStyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTitleStyleEN> GetAllvTitleStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsvTitleStyleEN> arrvTitleStyleObjLstCache = GetObjLstCache(); 
return arrvTitleStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTitleStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTitleStyleEN._CurrTabName);
List<clsvTitleStyleEN> arrvTitleStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTitleStyleObjLstCache;
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
string strKey = string.Format("{0}", clsvTitleStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvTitleStyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTitleStyleEN._RefreshTimeLst.Count == 0) return "";
return clsvTitleStyleEN._RefreshTimeLst[clsvTitleStyleEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strTitleStyleId)
{
if (strInFldName != convTitleStyle.TitleStyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTitleStyle._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTitleStyle._AttributeName));
throw new Exception(strMsg);
}
var objvTitleStyle = clsvTitleStyleBL.GetObjByTitleStyleIdCache(strTitleStyleId);
if (objvTitleStyle == null) return "";
return objvTitleStyle[strOutFldName].ToString();
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
int intRecCount = clsvTitleStyleDA.GetRecCount(strTabName);
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
int intRecCount = clsvTitleStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTitleStyleDA.GetRecCount();
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
int intRecCount = clsvTitleStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTitleStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTitleStyleEN objvTitleStyleCond)
{
List<clsvTitleStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTitleStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTitleStyle._AttributeName)
{
if (objvTitleStyleCond.IsUpdated(strFldName) == false) continue;
if (objvTitleStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTitleStyleCond[strFldName].ToString());
}
else
{
if (objvTitleStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTitleStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTitleStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTitleStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTitleStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTitleStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTitleStyleCond[strFldName]));
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
 List<string> arrList = clsvTitleStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTitleStyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTitleStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}