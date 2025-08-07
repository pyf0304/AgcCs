
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionWApi
 表名:DGRegion(00050112)
 生成代码版本:2020.07.25.1
 生成日期:2020/07/25 23:30:05
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using AGC.Const;

namespace AGC4WApi
{
public static class clsDGRegionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetRegionId(this clsDGRegionEN objDGRegionEN, string lngRegionId, string strComparisonOp="")
	{
objDGRegionEN.RegionId = lngRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_RegionId) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_RegionId, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_RegionId] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetDGStyleId(this clsDGRegionEN objDGRegionEN, string strDGStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDGStyleId, clsDGRegionEN.con_DGStyleId);
clsCheckSql.CheckFieldLen(strDGStyleId, 4, clsDGRegionEN.con_DGStyleId);
objDGRegionEN.DGStyleId = strDGStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_DGStyleId) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_DGStyleId, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_DGStyleId] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetAllowPaging(this clsDGRegionEN objDGRegionEN, bool bolAllowPaging, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowPaging, clsDGRegionEN.con_AllowPaging);
objDGRegionEN.AllowPaging = bolAllowPaging; //允许分页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_AllowPaging) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_AllowPaging, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_AllowPaging] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetAutoGenerateColumns(this clsDGRegionEN objDGRegionEN, bool bolAutoGenerateColumns, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAutoGenerateColumns, clsDGRegionEN.con_AutoGenerateColumns);
objDGRegionEN.AutoGenerateColumns = bolAutoGenerateColumns; //自动生成列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_AutoGenerateColumns) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_AutoGenerateColumns, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_AutoGenerateColumns] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetAllowSorting(this clsDGRegionEN objDGRegionEN, bool bolAllowSorting, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolAllowSorting, clsDGRegionEN.con_AllowSorting);
objDGRegionEN.AllowSorting = bolAllowSorting; //允许排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_AllowSorting) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_AllowSorting, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_AllowSorting] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsRadio(this clsDGRegionEN objDGRegionEN, bool bolIsRadio, string strComparisonOp="")
	{
objDGRegionEN.IsRadio = bolIsRadio; //是否单选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsRadio) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsRadio, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsRadio] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsCheck(this clsDGRegionEN objDGRegionEN, bool bolIsCheck, string strComparisonOp="")
	{
objDGRegionEN.IsCheck = bolIsCheck; //是否复选框
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsCheck) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsCheck, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsCheck] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsJumpPage(this clsDGRegionEN objDGRegionEN, bool bolIsJumpPage, string strComparisonOp="")
	{
objDGRegionEN.IsJumpPage = bolIsJumpPage; //是否跳页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsJumpPage) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsJumpPage, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsJumpPage] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsHaveUpdBtn(this clsDGRegionEN objDGRegionEN, bool bolIsHaveUpdBtn, string strComparisonOp="")
	{
objDGRegionEN.IsHaveUpdBtn = bolIsHaveUpdBtn; //是否有修改按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsHaveUpdBtn) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsHaveUpdBtn, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsHaveUpdBtn] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsHaveDelBtn(this clsDGRegionEN objDGRegionEN, bool bolIsHaveDelBtn, string strComparisonOp="")
	{
objDGRegionEN.IsHaveDelBtn = bolIsHaveDelBtn; //是否有删除按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsHaveDelBtn) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsHaveDelBtn, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsHaveDelBtn] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsHaveDetailBtn(this clsDGRegionEN objDGRegionEN, bool bolIsHaveDetailBtn, string strComparisonOp="")
	{
objDGRegionEN.IsHaveDetailBtn = bolIsHaveDetailBtn; //是否有详细按钮
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsHaveDetailBtn) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsHaveDetailBtn, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsHaveDetailBtn] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetIsInTab(this clsDGRegionEN objDGRegionEN, bool bolIsInTab, string strComparisonOp="")
	{
objDGRegionEN.IsInTab = bolIsInTab; //是否生成DG在表中
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_IsInTab) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_IsInTab, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_IsInTab] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetWidth(this clsDGRegionEN objDGRegionEN, int intWidth, string strComparisonOp="")
	{
objDGRegionEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Width) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Width, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Width] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetHeight(this clsDGRegionEN objDGRegionEN, int intHeight, string strComparisonOp="")
	{
objDGRegionEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Height) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Height, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Height] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetViewDgName(this clsDGRegionEN objDGRegionEN, string strViewDgName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewDgName, 100, clsDGRegionEN.con_ViewDgName);
objDGRegionEN.ViewDgName = strViewDgName; //界面Dg名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_ViewDgName) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_ViewDgName, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_ViewDgName] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetFontSize(this clsDGRegionEN objDGRegionEN, string strFontSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontSize, 20, clsDGRegionEN.con_FontSize);
objDGRegionEN.FontSize = strFontSize; //字号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_FontSize) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_FontSize, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_FontSize] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetPageSize(this clsDGRegionEN objDGRegionEN, int intPageSize, string strComparisonOp="")
	{
objDGRegionEN.PageSize = intPageSize; //页大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_PageSize) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_PageSize, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_PageSize] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetRunat(this clsDGRegionEN objDGRegionEN, string strRunat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRunat, 30, clsDGRegionEN.con_Runat);
objDGRegionEN.Runat = strRunat; //运行在
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Runat) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Runat, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Runat] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetStyle_Top(this clsDGRegionEN objDGRegionEN, int intStyle_Top, string strComparisonOp="")
	{
objDGRegionEN.Style_Top = intStyle_Top; //Style_Top
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Style_Top) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Style_Top, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Style_Top] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetStyle_Position(this clsDGRegionEN objDGRegionEN, string strStyle_Position, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle_Position, 20, clsDGRegionEN.con_Style_Position);
objDGRegionEN.Style_Position = strStyle_Position; //Style_Position
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Style_Position) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Style_Position, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Style_Position] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetStyle_Left(this clsDGRegionEN objDGRegionEN, int intStyle_Left, string strComparisonOp="")
	{
objDGRegionEN.Style_Left = intStyle_Left; //Style_Left
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Style_Left) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Style_Left, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Style_Left] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetStyle_Zindex(this clsDGRegionEN objDGRegionEN, int intStyle_Zindex, string strComparisonOp="")
	{
objDGRegionEN.Style_Zindex = intStyle_Zindex; //Style_Zindex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Style_Zindex) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Style_Zindex, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Style_Zindex] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetStyle(this clsDGRegionEN objDGRegionEN, string strStyle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyle, 800, clsDGRegionEN.con_Style);
objDGRegionEN.Style = strStyle; //类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Style) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Style, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Style] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetColNum(this clsDGRegionEN objDGRegionEN, int intColNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intColNum, clsDGRegionEN.con_ColNum);
objDGRegionEN.ColNum = intColNum; //列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_ColNum) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_ColNum, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_ColNum] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetFontName(this clsDGRegionEN objDGRegionEN, string strFontName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFontName, 20, clsDGRegionEN.con_FontName);
objDGRegionEN.FontName = strFontName; //字体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_FontName) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_FontName, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_FontName] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetPrjId(this clsDGRegionEN objDGRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, clsDGRegionEN.con_PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, clsDGRegionEN.con_PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, clsDGRegionEN.con_PrjId);
objDGRegionEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_PrjId) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_PrjId, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_PrjId] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetUpdDate(this clsDGRegionEN objDGRegionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, clsDGRegionEN.con_UpdDate);
objDGRegionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_UpdDate) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_UpdDate, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_UpdDate] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetUpdUser(this clsDGRegionEN objDGRegionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, clsDGRegionEN.con_UpdUser);
objDGRegionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_UpdUser) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_UpdUser, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_UpdUser] = strComparisonOp;
}
}
return objDGRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDGRegionEN SetMemo(this clsDGRegionEN objDGRegionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, clsDGRegionEN.con_Memo);
objDGRegionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionEN.dicFldComparisonOp.ContainsKey(clsDGRegionEN.con_Memo) == false)
{
objDGRegionEN.dicFldComparisonOp.Add(clsDGRegionEN.con_Memo, strComparisonOp);
}
else
{
objDGRegionEN.dicFldComparisonOp[clsDGRegionEN.con_Memo] = strComparisonOp;
}
}
return objDGRegionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDGRegionEN objDGRegion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_RegionId) == true)
{
string strComparisonOp_RegionId = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_RegionId];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_RegionId, objDGRegion_Cond.RegionId, strComparisonOp_RegionId);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_DGStyleId) == true)
{
string strComparisonOp_DGStyleId = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_DGStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_DGStyleId, objDGRegion_Cond.DGStyleId, strComparisonOp_DGStyleId);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_AllowPaging) == true)
{
if (objDGRegion_Cond.AllowPaging == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_AllowPaging);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_AllowPaging);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_AutoGenerateColumns) == true)
{
if (objDGRegion_Cond.AutoGenerateColumns == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_AutoGenerateColumns);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_AutoGenerateColumns);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_AllowSorting) == true)
{
if (objDGRegion_Cond.AllowSorting == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_AllowSorting);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_AllowSorting);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsRadio) == true)
{
if (objDGRegion_Cond.IsRadio == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsRadio);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsRadio);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsCheck) == true)
{
if (objDGRegion_Cond.IsCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsCheck);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsJumpPage) == true)
{
if (objDGRegion_Cond.IsJumpPage == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsJumpPage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsJumpPage);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsHaveUpdBtn) == true)
{
if (objDGRegion_Cond.IsHaveUpdBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsHaveUpdBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsHaveUpdBtn);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsHaveDelBtn) == true)
{
if (objDGRegion_Cond.IsHaveDelBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsHaveDelBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsHaveDelBtn);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsHaveDetailBtn) == true)
{
if (objDGRegion_Cond.IsHaveDetailBtn == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsHaveDetailBtn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsHaveDetailBtn);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_IsInTab) == true)
{
if (objDGRegion_Cond.IsInTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsDGRegionEN.con_IsInTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsDGRegionEN.con_IsInTab);
}
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Width) == true)
{
string strComparisonOp_Width = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Width];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_Width, objDGRegion_Cond.Width, strComparisonOp_Width);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Height) == true)
{
string strComparisonOp_Height = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Height];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_Height, objDGRegion_Cond.Height, strComparisonOp_Height);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_ViewDgName) == true)
{
string strComparisonOp_ViewDgName = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_ViewDgName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_ViewDgName, objDGRegion_Cond.ViewDgName, strComparisonOp_ViewDgName);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_FontSize) == true)
{
string strComparisonOp_FontSize = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_FontSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_FontSize, objDGRegion_Cond.FontSize, strComparisonOp_FontSize);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_PageSize) == true)
{
string strComparisonOp_PageSize = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_PageSize];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_PageSize, objDGRegion_Cond.PageSize, strComparisonOp_PageSize);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Runat) == true)
{
string strComparisonOp_Runat = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Runat];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_Runat, objDGRegion_Cond.Runat, strComparisonOp_Runat);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Style_Top) == true)
{
string strComparisonOp_Style_Top = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Style_Top];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_Style_Top, objDGRegion_Cond.Style_Top, strComparisonOp_Style_Top);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Style_Position) == true)
{
string strComparisonOp_Style_Position = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Style_Position];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_Style_Position, objDGRegion_Cond.Style_Position, strComparisonOp_Style_Position);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Style_Left) == true)
{
string strComparisonOp_Style_Left = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Style_Left];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_Style_Left, objDGRegion_Cond.Style_Left, strComparisonOp_Style_Left);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Style_Zindex) == true)
{
string strComparisonOp_Style_Zindex = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Style_Zindex];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_Style_Zindex, objDGRegion_Cond.Style_Zindex, strComparisonOp_Style_Zindex);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Style) == true)
{
string strComparisonOp_Style = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Style];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_Style, objDGRegion_Cond.Style, strComparisonOp_Style);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_ColNum) == true)
{
string strComparisonOp_ColNum = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_ColNum];
strWhereCond += string.Format(" And {0} {2} {1}", clsDGRegionEN.con_ColNum, objDGRegion_Cond.ColNum, strComparisonOp_ColNum);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_FontName) == true)
{
string strComparisonOp_FontName = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_FontName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_FontName, objDGRegion_Cond.FontName, strComparisonOp_FontName);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_PrjId) == true)
{
string strComparisonOp_PrjId = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_PrjId, objDGRegion_Cond.PrjId, strComparisonOp_PrjId);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_UpdDate) == true)
{
string strComparisonOp_UpdDate = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_UpdDate, objDGRegion_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_UpdUser) == true)
{
string strComparisonOp_UpdUser = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_UpdUser, objDGRegion_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objDGRegion_Cond.IsUpdated(clsDGRegionEN.con_Memo) == true)
{
string strComparisonOp_Memo = objDGRegion_Cond.dicFldComparisonOp[clsDGRegionEN.con_Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsDGRegionEN.con_Memo, objDGRegion_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDGRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDGRegionEN objDGRegionEN)
{
 if (objDGRegionEN.RegionId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDGRegionEN.sf_UpdFldSetStr = objDGRegionEN.getsf_UpdFldSetStr();
clsDGRegionWApi.CheckPropertyNew(objDGRegionEN); 
bool bolResult = clsDGRegionWApi.UpdateRecord(objDGRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
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
 /// 检查唯一性(Uniqueness)--DGRegion(DG区域), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDGRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PrjId_RegionId(this clsDGRegionEN objDGRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDGRegionEN == null) return "";
if (objDGRegionEN.RegionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDGRegionEN.PrjId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionEN.RegionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RegionId !=  {0}", objDGRegionEN.RegionId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDGRegionEN.PrjId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionEN.RegionId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDGRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDGRegionEN objDGRegionEN)
{
try
{
clsDGRegionWApi.CheckPropertyNew(objDGRegionEN); 
bool bolResult = clsDGRegionWApi.AddNewRecord(objDGRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDGRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDGRegionEN objDGRegionEN, string strWhereCond)
{
try
{
clsDGRegionWApi.CheckPropertyNew(objDGRegionEN); 
bool bolResult = clsDGRegionWApi.UpdateWithCondition(objDGRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
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
 /// DG区域(DGRegion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDGRegionWApi
{
private static readonly string mstrApiControllerName = "DGRegionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsDGRegionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDGRegionEN objDGRegionEN)
{
if (!Object.Equals(null, objDGRegionEN.DGStyleId) && GetStrLen(objDGRegionEN.DGStyleId) > 4)
{
 throw new Exception("字段[DG模式ID]的长度不能超过4!");
}
if (!Object.Equals(null, objDGRegionEN.ViewDgName) && GetStrLen(objDGRegionEN.ViewDgName) > 100)
{
 throw new Exception("字段[界面Dg名称]的长度不能超过100!");
}
if (!Object.Equals(null, objDGRegionEN.FontSize) && GetStrLen(objDGRegionEN.FontSize) > 20)
{
 throw new Exception("字段[字号]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionEN.Runat) && GetStrLen(objDGRegionEN.Runat) > 30)
{
 throw new Exception("字段[运行在]的长度不能超过30!");
}
if (!Object.Equals(null, objDGRegionEN.Style_Position) && GetStrLen(objDGRegionEN.Style_Position) > 20)
{
 throw new Exception("字段[Style_Position]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionEN.Style) && GetStrLen(objDGRegionEN.Style) > 800)
{
 throw new Exception("字段[类型]的长度不能超过800!");
}
if (!Object.Equals(null, objDGRegionEN.FontName) && GetStrLen(objDGRegionEN.FontName) > 20)
{
 throw new Exception("字段[字体]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionEN.PrjId) && GetStrLen(objDGRegionEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objDGRegionEN.UpdDate) && GetStrLen(objDGRegionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionEN.UpdUser) && GetStrLen(objDGRegionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionEN.Memo) && GetStrLen(objDGRegionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDGRegionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDGRegionEN GetObjByRegionId(string lngRegionId)
{
string strAction = "GetObjByRegionId";
string strErrMsg = string.Empty;
string strResult = "";
clsDGRegionEN objDGRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDGRegionEN = JsonConvert.DeserializeObject<clsDGRegionEN>((string)jobjReturn["ReturnObj"]);
return objDGRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDGRegionEN GetObjByRegionId_WA_Cache(string lngRegionId, string strPrjId)
{
string strAction = "GetObjByRegionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsDGRegionEN objDGRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString(),
["PrjId"] = strPrjId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDGRegionEN = JsonConvert.DeserializeObject<clsDGRegionEN>((string)jobjReturn["ReturnObj"]);
return objDGRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsDGRegionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsDGRegionEN objDGRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDGRegionEN = JsonConvert.DeserializeObject<clsDGRegionEN>((string)jobjReturn["ReturnObj"]);
return objDGRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDGRegionEN GetObjByRegionId_Cache(string lngRegionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDGRegionEN._CurrTabName_S, strPrjId);
List<clsDGRegionEN> arrDGRegionObjLst_Cache = GetObjLst_Cache(strPrjId);
IEnumerable <clsDGRegionEN> arrDGRegionObjLst_Sel =
from objDGRegionEN in arrDGRegionObjLst_Cache
where objDGRegionEN.RegionId == lngRegionId
select objDGRegionEN;
if (arrDGRegionObjLst_Sel.Count() == 0)
{
   clsDGRegionEN obj = clsDGRegionWApi.GetObjByRegionId(lngRegionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDGRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionEN> GetObjLst(string strWhereCond)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionEN> GetObjLstByRegionIdLst(List<long> arrRegionId)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByRegionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsDGRegionEN> GetObjLstByRegionIdLst_Cache(List<long> arrRegionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDGRegionEN._CurrTabName_S, strPrjId);
List<clsDGRegionEN> arrDGRegionObjLst_Cache = GetObjLst_Cache(strPrjId);
IEnumerable <clsDGRegionEN> arrDGRegionObjLst_Sel =
from objDGRegionEN in arrDGRegionObjLst_Cache
where arrRegionId.Contains(objDGRegionEN.RegionId)
select objDGRegionEN;
return arrDGRegionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionEN> GetObjLstByRegionIdLst_WA_Cache(List<long> arrRegionId, string strPrjId)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByRegionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PrjId"] = strPrjId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsDGRegionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsDGRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsDGRegionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsDGRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelRecord(string lngRegionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsDGRegionEN objDGRegionEN = clsDGRegionWApi.GetObjByRegionId(lngRegionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngRegionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelDGRegions(List<string> arrRegionId)
{
string strAction = "DelDGRegions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsDGRegionEN objDGRegionEN = clsDGRegionWApi.GetObjByRegionId(long.Parse(arrRegionId[0]));
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelDGRegionsByCond(string strWhereCond)
{
string strAction = "DelDGRegionsByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool AddNewRecord(clsDGRegionEN objDGRegionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionEN>(objDGRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionWApi.ReFreshCache(objDGRegionEN.PrjId);
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsDGRegionEN objDGRegionEN)
{
if (string.IsNullOrEmpty(objDGRegionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionEN>(objDGRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objDGRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDGRegionEN objDGRegionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDGRegionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionEN>(objDGRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string lngRegionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objDGRegionENS">源对象</param>
 /// <param name = "objDGRegionENT">目标对象</param>
 public static void CopyTo(clsDGRegionEN objDGRegionENS, clsDGRegionEN objDGRegionENT)
{
try
{
objDGRegionENT.RegionId = objDGRegionENS.RegionId; //区域Id
objDGRegionENT.DGStyleId = objDGRegionENS.DGStyleId; //DG模式ID
objDGRegionENT.AllowPaging = objDGRegionENS.AllowPaging; //允许分页
objDGRegionENT.AutoGenerateColumns = objDGRegionENS.AutoGenerateColumns; //自动生成列
objDGRegionENT.AllowSorting = objDGRegionENS.AllowSorting; //允许排序
objDGRegionENT.IsRadio = objDGRegionENS.IsRadio; //是否单选框
objDGRegionENT.IsCheck = objDGRegionENS.IsCheck; //是否复选框
objDGRegionENT.IsJumpPage = objDGRegionENS.IsJumpPage; //是否跳页
objDGRegionENT.IsHaveUpdBtn = objDGRegionENS.IsHaveUpdBtn; //是否有修改按钮
objDGRegionENT.IsHaveDelBtn = objDGRegionENS.IsHaveDelBtn; //是否有删除按钮
objDGRegionENT.IsHaveDetailBtn = objDGRegionENS.IsHaveDetailBtn; //是否有详细按钮
objDGRegionENT.IsInTab = objDGRegionENS.IsInTab; //是否生成DG在表中
objDGRegionENT.Width = objDGRegionENS.Width; //宽
objDGRegionENT.Height = objDGRegionENS.Height; //高度
objDGRegionENT.ViewDgName = objDGRegionENS.ViewDgName; //界面Dg名称
objDGRegionENT.FontSize = objDGRegionENS.FontSize; //字号
objDGRegionENT.PageSize = objDGRegionENS.PageSize; //页大小
objDGRegionENT.Runat = objDGRegionENS.Runat; //运行在
objDGRegionENT.Style_Top = objDGRegionENS.Style_Top; //Style_Top
objDGRegionENT.Style_Position = objDGRegionENS.Style_Position; //Style_Position
objDGRegionENT.Style_Left = objDGRegionENS.Style_Left; //Style_Left
objDGRegionENT.Style_Zindex = objDGRegionENS.Style_Zindex; //Style_Zindex
objDGRegionENT.Style = objDGRegionENS.Style; //类型
objDGRegionENT.ColNum = objDGRegionENS.ColNum; //列数
objDGRegionENT.FontName = objDGRegionENS.FontName; //字体
objDGRegionENT.PrjId = objDGRegionENS.PrjId; //工程ID
objDGRegionENT.UpdDate = objDGRegionENS.UpdDate; //修改日期
objDGRegionENT.UpdUser = objDGRegionENS.UpdUser; //修改者
objDGRegionENT.Memo = objDGRegionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDGRegionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDGRegionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDGRegionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDGRegionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDGRegionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDGRegionEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsDGRegionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDGRegionWApi没有刷新缓存机制(clsDGRegionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RegionId");
//if (arrDGRegionObjLst_Cache == null)
//{
//arrDGRegionObjLst_Cache = await clsDGRegionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDGRegionEN._CurrTabName_S, strPrjId);
CacheHelper.Remove(strKey);
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDGRegionWApi.objCommFun4BL != null) 
{
 string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDGRegionEN._CurrTabName_S, strPrjId);
CacheHelper.Remove(strKey);
clsDGRegionWApi.objCommFun4BL.ReFreshCache(strPrjId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDGRegionEN> GetObjLst_Cache(string strPrjId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsDGRegionEN._CurrTabName_S, strPrjId);
List<clsDGRegionEN> arrDGRegionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("PrjId='{0}'", strPrjId)); });
return arrDGRegionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDGRegionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDGRegion.RegionId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDGRegion.DGStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.AllowPaging, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.AutoGenerateColumns, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.AllowSorting, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsRadio, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsCheck, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsJumpPage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsHaveUpdBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsHaveDelBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsHaveDetailBtn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.IsInTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegion.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.ViewDgName, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.FontSize, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.PageSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.Runat, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.Style_Top, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.Style_Position, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.Style_Left, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.Style_Zindex, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.Style, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.ColNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegion.FontName, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegion.Memo, Type.GetType("System.String"));
foreach (clsDGRegionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDGRegion.RegionId] = objInFor[conDGRegion.RegionId];
objDR[conDGRegion.DGStyleId] = objInFor[conDGRegion.DGStyleId];
objDR[conDGRegion.AllowPaging] = objInFor[conDGRegion.AllowPaging];
objDR[conDGRegion.AutoGenerateColumns] = objInFor[conDGRegion.AutoGenerateColumns];
objDR[conDGRegion.AllowSorting] = objInFor[conDGRegion.AllowSorting];
objDR[conDGRegion.IsRadio] = objInFor[conDGRegion.IsRadio];
objDR[conDGRegion.IsCheck] = objInFor[conDGRegion.IsCheck];
objDR[conDGRegion.IsJumpPage] = objInFor[conDGRegion.IsJumpPage];
objDR[conDGRegion.IsHaveUpdBtn] = objInFor[conDGRegion.IsHaveUpdBtn];
objDR[conDGRegion.IsHaveDelBtn] = objInFor[conDGRegion.IsHaveDelBtn];
objDR[conDGRegion.IsHaveDetailBtn] = objInFor[conDGRegion.IsHaveDetailBtn];
objDR[conDGRegion.IsInTab] = objInFor[conDGRegion.IsInTab];
objDR[conDGRegion.Width] = objInFor[conDGRegion.Width];
objDR[conDGRegion.Height] = objInFor[conDGRegion.Height];
objDR[conDGRegion.ViewDgName] = objInFor[conDGRegion.ViewDgName];
objDR[conDGRegion.FontSize] = objInFor[conDGRegion.FontSize];
objDR[conDGRegion.PageSize] = objInFor[conDGRegion.PageSize];
objDR[conDGRegion.Runat] = objInFor[conDGRegion.Runat];
objDR[conDGRegion.Style_Top] = objInFor[conDGRegion.Style_Top];
objDR[conDGRegion.Style_Position] = objInFor[conDGRegion.Style_Position];
objDR[conDGRegion.Style_Left] = objInFor[conDGRegion.Style_Left];
objDR[conDGRegion.Style_Zindex] = objInFor[conDGRegion.Style_Zindex];
objDR[conDGRegion.Style] = objInFor[conDGRegion.Style];
objDR[conDGRegion.ColNum] = objInFor[conDGRegion.ColNum];
objDR[conDGRegion.FontName] = objInFor[conDGRegion.FontName];
objDR[conDGRegion.PrjId] = objInFor[conDGRegion.PrjId];
objDR[conDGRegion.UpdDate] = objInFor[conDGRegion.UpdDate];
objDR[conDGRegion.UpdUser] = objInFor[conDGRegion.UpdUser];
objDR[conDGRegion.Memo] = objInFor[conDGRegion.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}