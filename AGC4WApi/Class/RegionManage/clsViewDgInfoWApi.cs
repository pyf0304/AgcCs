
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewDgInfoWApi
 表名:ViewDgInfo(00050012)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsViewDgInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDgID">界面DgId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewDgID(this clsViewDgInfoEN objViewDgInfoEN, string strViewDgID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDgID, 10, conViewDgInfo.ViewDgID);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewDgName">界面Dg名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewDgName(this clsViewDgInfoEN objViewDgInfoEN, string strViewDgName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewDgName, conViewDgInfo.ViewDgName);
clsCheckSql.CheckFieldLen(strViewDgName, 100, conViewDgInfo.ViewDgName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetViewId(this clsViewDgInfoEN objViewDgInfoEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldLen(strViewId, 8, conViewDgInfo.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewDgInfo.ViewId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsId">数据源表/视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetSqlDsId(this clsViewDgInfoEN objViewDgInfoEN, string strSqlDsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsId, 8, conViewDgInfo.SqlDsId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleId">DG模式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetDgStyleId(this clsViewDgInfoEN objViewDgInfoEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleId, conViewDgInfo.DgStyleId);
clsCheckSql.CheckFieldLen(strDgStyleId, 4, conViewDgInfo.DgStyleId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyle">类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyle(this clsViewDgInfoEN objViewDgInfoEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle, 800, conViewDgInfo.Style);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strRunat">运行在</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetRunat(this clsViewDgInfoEN objViewDgInfoEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRunat, 30, conViewDgInfo.Runat);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontSize">字号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetFontSize(this clsViewDgInfoEN objViewDgInfoEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, conViewDgInfo.FontSize);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strFontName">字体</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetFontName(this clsViewDgInfoEN objViewDgInfoEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, conViewDgInfo.FontName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetWidth(this clsViewDgInfoEN objViewDgInfoEN, int intWidth, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetHeight(this clsViewDgInfoEN objViewDgInfoEN, int intHeight, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAllowPaging">允许分页</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intPageSize">页大小</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetPageSize(this clsViewDgInfoEN objViewDgInfoEN, int intPageSize, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAutoGenerateColumns">自动生成列</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAllowSorting">允许排序</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRadio">是否单选框</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCheck">是否复选框</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveUpdBtn">是否有修改按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDelBtn">是否有删除按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHaveDetailBtn">是否有详细按钮</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsJumpPage">是否跳页</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInTab">是否生成DG在表中</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleZindex">Style_Zindex</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleZindex(this clsViewDgInfoEN objViewDgInfoEN, int intStyleZindex, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleLeft">Style_Left</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleLeft(this clsViewDgInfoEN objViewDgInfoEN, int intStyleLeft, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strStylePosition">Style_Position</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStylePosition(this clsViewDgInfoEN objViewDgInfoEN, string strStylePosition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStylePosition, 20, conViewDgInfo.StylePosition);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "intStyleTop">Style_Top</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetStyleTop(this clsViewDgInfoEN objViewDgInfoEN, int intStyleTop, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewDgInfoEN SetSqlDsTypeId(this clsViewDgInfoEN objViewDgInfoEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conViewDgInfo.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conViewDgInfo.SqlDsTypeId);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewDgInfoEN objViewDgInfoEN)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewDgInfoEN.sfUpdFldSetStr = objViewDgInfoEN.getsfUpdFldSetStr();
clsViewDgInfoWApi.CheckPropertyNew(objViewDgInfoEN); 
bool bolResult = clsViewDgInfoWApi.UpdateRecord(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ViewDgInfo(视图Dg), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewDgName_ViewId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewDgInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewDgInfoEN objViewDgInfoEN)
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewDgInfoEN objViewDgInfoEN)
{
 if (string.IsNullOrEmpty(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewDgInfoWApi.IsExist(objViewDgInfoEN.ViewDgID) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewDgInfoEN.ViewDgID, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsViewDgInfoWApi.CheckPropertyNew(objViewDgInfoEN); 
bool bolResult = clsViewDgInfoWApi.AddNewRecord(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
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
 /// <param name = "objViewDgInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewDgInfoEN objViewDgInfoEN)
{
try
{
clsViewDgInfoWApi.CheckPropertyNew(objViewDgInfoEN); 
string strViewDgID = clsViewDgInfoWApi.AddNewRecordWithMaxId(objViewDgInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
return strViewDgID;
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewDgInfoEN objViewDgInfoEN, string strWhereCond)
{
try
{
clsViewDgInfoWApi.CheckPropertyNew(objViewDgInfoEN); 
bool bolResult = clsViewDgInfoWApi.UpdateWithCondition(objViewDgInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
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
 /// 视图Dg(ViewDgInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewDgInfoWApi
{
private static readonly string mstrApiControllerName = "ViewDgInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsViewDgInfoWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewDgInfoEN objViewDgInfoEN)
{
if (!Object.Equals(null, objViewDgInfoEN.ViewDgID) && GetStrLen(objViewDgInfoEN.ViewDgID) > 10)
{
 throw new Exception("字段[界面DgId]的长度不能超过10!");
}
if (!Object.Equals(null, objViewDgInfoEN.ViewDgName) && GetStrLen(objViewDgInfoEN.ViewDgName) > 100)
{
 throw new Exception("字段[界面Dg名称]的长度不能超过100!");
}
if (!Object.Equals(null, objViewDgInfoEN.ViewId) && GetStrLen(objViewDgInfoEN.ViewId) > 8)
{
 throw new Exception("字段[界面Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewDgInfoEN.SqlDsId) && GetStrLen(objViewDgInfoEN.SqlDsId) > 8)
{
 throw new Exception("字段[数据源表/视图Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewDgInfoEN.DgStyleId) && GetStrLen(objViewDgInfoEN.DgStyleId) > 4)
{
 throw new Exception("字段[DG模式ID]的长度不能超过4!");
}
if (!Object.Equals(null, objViewDgInfoEN.Style) && GetStrLen(objViewDgInfoEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
if (!Object.Equals(null, objViewDgInfoEN.Runat) && GetStrLen(objViewDgInfoEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objViewDgInfoEN.FontSize) && GetStrLen(objViewDgInfoEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objViewDgInfoEN.FontName) && GetStrLen(objViewDgInfoEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objViewDgInfoEN.StylePosition) && GetStrLen(objViewDgInfoEN.StylePosition) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
if (!Object.Equals(null, objViewDgInfoEN.SqlDsTypeId) && GetStrLen(objViewDgInfoEN.SqlDsTypeId) > 2)
{
 throw new Exception("字段[数据源类型Id]的长度不能超过2!");
}
 objViewDgInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewDgID">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewDgInfoEN GetObjByViewDgID(string strViewDgID)
{
if (strViewDgID == "") return null;
string strAction = "GetObjByViewDgID";
clsViewDgInfoEN objViewDgInfoEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewDgID"] = strViewDgID,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objViewDgInfoEN = JsonConvert.DeserializeObject<clsViewDgInfoEN>(strJson);
return objViewDgInfoEN;
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
public static clsViewDgInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewDgInfoEN objViewDgInfoEN;
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
objViewDgInfoEN = JsonConvert.DeserializeObject<clsViewDgInfoEN>(strJson);
return objViewDgInfoEN;
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
 /// <param name = "strViewDgID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewDgInfoEN GetObjByViewDgIDCache(string strViewDgID)
{
if (string.IsNullOrEmpty(strViewDgID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrViewDgInfoObjLst_Sel =
from objViewDgInfoEN in arrViewDgInfoObjLstCache
where objViewDgInfoEN.ViewDgID == strViewDgID 
select objViewDgInfoEN;
if (arrViewDgInfoObjLst_Sel.Count() == 0)
{
   clsViewDgInfoEN obj = clsViewDgInfoWApi.GetObjByViewDgID(strViewDgID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewDgInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLst(string strWhereCond)
{
 List<clsViewDgInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
 /// <param name = "arrViewDgID">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstByViewDgIDLst(List<string> arrViewDgID)
{
 List<clsViewDgInfoEN> arrObjLst; 
string strAction = "GetObjLstByViewDgIDLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewDgID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
 /// <param name = "arrViewDgID">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsViewDgInfoEN> GetObjLstByViewDgIDLstCache(List<string> arrViewDgID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = GetObjLstCache();
IEnumerable <clsViewDgInfoEN> arrViewDgInfoObjLst_Sel =
from objViewDgInfoEN in arrViewDgInfoObjLstCache
where arrViewDgID.Contains(objViewDgInfoEN.ViewDgID)
select objViewDgInfoEN;
return arrViewDgInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewDgInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewDgInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
public static List<clsViewDgInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewDgInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
public static List<clsViewDgInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewDgInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
public static List<clsViewDgInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewDgInfoEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewDgInfoEN>>(strJson);
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
public static int DelRecord(string strViewDgID)
{
string strAction = "DelRecord";
try
{
 clsViewDgInfoEN objViewDgInfoEN = clsViewDgInfoWApi.GetObjByViewDgID(strViewDgID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewDgID.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewDgInfoWApi.ReFreshCache();
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
public static int DelViewDgInfos(List<string> arrViewDgID)
{
string strAction = "DelViewDgInfos";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewDgID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewDgInfoWApi.ReFreshCache();
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
public static int DelViewDgInfosByCond(string strWhereCond)
{
string strAction = "DelViewDgInfosByCond";
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
public static bool AddNewRecord(clsViewDgInfoEN objViewDgInfoEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewDgInfoEN>(objViewDgInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsViewDgInfoEN objViewDgInfoEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewDgInfoEN>(objViewDgInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewDgInfoWApi.ReFreshCache();
var strViewDgID = (string)jobjReturn0["returnStr"];
return strViewDgID;
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
public static bool UpdateRecord(clsViewDgInfoEN objViewDgInfoEN)
{
if (string.IsNullOrEmpty(objViewDgInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewDgInfoEN.ViewDgID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewDgInfoEN>(objViewDgInfoEN);
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
 /// <param name = "objViewDgInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewDgInfoEN objViewDgInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewDgInfoEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewDgInfoEN.ViewDgID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewDgInfoEN.ViewDgID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewDgInfoEN>(objViewDgInfoEN);
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
public static bool IsExist(string strViewDgID)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewDgID"] = strViewDgID
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
public static DataTable ToDataTable(List<clsViewDgInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewDgInfoEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewDgInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewDgInfoEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewDgInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewDgInfoEN._AttributeName)
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
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
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
if (clsViewDgInfoWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewDgInfoEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewDgInfoWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewDgInfoEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsViewDgInfoEN._CurrTabName;
List<clsViewDgInfoEN> arrViewDgInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewDgInfoObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewDgInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewDgInfo.ViewDgID, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.ViewDgName, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.SqlDsId, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.DgStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.Style, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.AllowPaging, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.PageSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.AutoGenerateColumns, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.AllowSorting, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsRadio, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsCheck, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsHaveUpdBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsHaveDelBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsHaveDetailBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsJumpPage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.IsInTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewDgInfo.StyleZindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.StyleLeft, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.StylePosition, Type.GetType("System.String"));
objDT.Columns.Add(conViewDgInfo.StyleTop, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewDgInfo.SqlDsTypeId, Type.GetType("System.String"));
foreach (clsViewDgInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewDgInfo.ViewDgID] = objInFor[conViewDgInfo.ViewDgID];
objDR[conViewDgInfo.ViewDgName] = objInFor[conViewDgInfo.ViewDgName];
objDR[conViewDgInfo.ViewId] = objInFor[conViewDgInfo.ViewId];
objDR[conViewDgInfo.SqlDsId] = objInFor[conViewDgInfo.SqlDsId];
objDR[conViewDgInfo.DgStyleId] = objInFor[conViewDgInfo.DgStyleId];
objDR[conViewDgInfo.Style] = objInFor[conViewDgInfo.Style];
objDR[conViewDgInfo.Runat] = objInFor[conViewDgInfo.Runat];
objDR[conViewDgInfo.FontSize] = objInFor[conViewDgInfo.FontSize];
objDR[conViewDgInfo.FontName] = objInFor[conViewDgInfo.FontName];
objDR[conViewDgInfo.Width] = objInFor[conViewDgInfo.Width];
objDR[conViewDgInfo.Height] = objInFor[conViewDgInfo.Height];
objDR[conViewDgInfo.AllowPaging] = objInFor[conViewDgInfo.AllowPaging];
objDR[conViewDgInfo.PageSize] = objInFor[conViewDgInfo.PageSize];
objDR[conViewDgInfo.AutoGenerateColumns] = objInFor[conViewDgInfo.AutoGenerateColumns];
objDR[conViewDgInfo.AllowSorting] = objInFor[conViewDgInfo.AllowSorting];
objDR[conViewDgInfo.IsRadio] = objInFor[conViewDgInfo.IsRadio];
objDR[conViewDgInfo.IsCheck] = objInFor[conViewDgInfo.IsCheck];
objDR[conViewDgInfo.IsHaveUpdBtn] = objInFor[conViewDgInfo.IsHaveUpdBtn];
objDR[conViewDgInfo.IsHaveDelBtn] = objInFor[conViewDgInfo.IsHaveDelBtn];
objDR[conViewDgInfo.IsHaveDetailBtn] = objInFor[conViewDgInfo.IsHaveDetailBtn];
objDR[conViewDgInfo.IsJumpPage] = objInFor[conViewDgInfo.IsJumpPage];
objDR[conViewDgInfo.IsInTab] = objInFor[conViewDgInfo.IsInTab];
objDR[conViewDgInfo.StyleZindex] = objInFor[conViewDgInfo.StyleZindex];
objDR[conViewDgInfo.StyleLeft] = objInFor[conViewDgInfo.StyleLeft];
objDR[conViewDgInfo.StylePosition] = objInFor[conViewDgInfo.StylePosition];
objDR[conViewDgInfo.StyleTop] = objInFor[conViewDgInfo.StyleTop];
objDR[conViewDgInfo.SqlDsTypeId] = objInFor[conViewDgInfo.SqlDsTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 视图Dg(ViewDgInfo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewDgInfo : clsCommFun4BL
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
clsViewDgInfoWApi.ReFreshThisCache();
}
}

}