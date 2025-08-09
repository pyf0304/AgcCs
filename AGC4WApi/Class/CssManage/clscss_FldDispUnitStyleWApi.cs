
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_FldDispUnitStyleWApi
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
public static class  clscss_FldDispUnitStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitStyleId">字段显示单元样式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
clsCheckSql.CheckFieldForeignKey(strFldDispUnitStyleId, 8, concss_FldDispUnitStyle.FldDispUnitStyleId);
objcss_FldDispUnitStyleEN.FldDispUnitStyleId = strFldDispUnitStyleId; //字段显示单元样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleId) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleId, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleId] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitStyleName">字段显示单元样式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleName(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldDispUnitStyleName, concss_FldDispUnitStyle.FldDispUnitStyleName);
clsCheckSql.CheckFieldLen(strFldDispUnitStyleName, 50, concss_FldDispUnitStyle.FldDispUnitStyleName);
objcss_FldDispUnitStyleEN.FldDispUnitStyleName = strFldDispUnitStyleName; //字段显示单元样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleName) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleName, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleName] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitStyleDesc">样式描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleDesc(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleDesc, 1000, concss_FldDispUnitStyle.FldDispUnitStyleDesc);
objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc = strFldDispUnitStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleDesc) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleIdContent">内容样式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetStyleIdContent(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strStyleIdContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
clsCheckSql.CheckFieldForeignKey(strStyleIdContent, 8, concss_FldDispUnitStyle.StyleIdContent);
objcss_FldDispUnitStyleEN.StyleIdContent = strStyleIdContent; //内容样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.StyleIdContent) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.StyleIdContent, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdContent] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleIdTitle">标题样式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetStyleIdTitle(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strStyleIdTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
clsCheckSql.CheckFieldForeignKey(strStyleIdTitle, 8, concss_FldDispUnitStyle.StyleIdTitle);
objcss_FldDispUnitStyleEN.StyleIdTitle = strStyleIdTitle; //标题样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.StyleIdTitle) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.StyleIdTitle, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdTitle] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitStyleContent">样式内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitStyleContent(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitStyleContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldDispUnitStyleContent, concss_FldDispUnitStyle.FldDispUnitStyleContent);
clsCheckSql.CheckFieldLen(strFldDispUnitStyleContent, 1000, concss_FldDispUnitStyle.FldDispUnitStyleContent);
objcss_FldDispUnitStyleEN.FldDispUnitStyleContent = strFldDispUnitStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitStyleContent) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleContent] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitFormat">字段显示单元格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetFldDispUnitFormat(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strFldDispUnitFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldDispUnitFormat, 1000, concss_FldDispUnitStyle.FldDispUnitFormat);
objcss_FldDispUnitStyleEN.FldDispUnitFormat = strFldDispUnitFormat; //字段显示单元格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.FldDispUnitFormat) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.FldDispUnitFormat, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitFormat] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetCtlTypeId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, concss_FldDispUnitStyle.CtlTypeId);
objcss_FldDispUnitStyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.CtlTypeId) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.CtlTypeId, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.CtlTypeId] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetOrderNum(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, int intOrderNum, string strComparisonOp="")
	{
objcss_FldDispUnitStyleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.OrderNum) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.OrderNum, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.OrderNum] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDeletedDate">删除日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetDeletedDate(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_FldDispUnitStyle.DeletedDate);
objcss_FldDispUnitStyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.DeletedDate) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.DeletedDate, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.DeletedDate] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDeleted">是否删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetIsDeleted(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objcss_FldDispUnitStyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.IsDeleted) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.IsDeleted, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.IsDeleted] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetUpdDate(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_FldDispUnitStyle.UpdDate);
objcss_FldDispUnitStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.UpdDate) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.UpdDate, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.UpdDate] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetUpdUser(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_FldDispUnitStyle.UpdUser);
objcss_FldDispUnitStyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.UpdUser) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.UpdUser, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.UpdUser] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_FldDispUnitStyleEN SetMemo(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_FldDispUnitStyle.Memo);
objcss_FldDispUnitStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_FldDispUnitStyleEN.dicFldComparisonOp.ContainsKey(concss_FldDispUnitStyle.Memo) == false)
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp.Add(concss_FldDispUnitStyle.Memo, strComparisonOp);
}
else
{
objcss_FldDispUnitStyleEN.dicFldComparisonOp[concss_FldDispUnitStyle.Memo] = strComparisonOp;
}
}
return objcss_FldDispUnitStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleId) == true)
{
string strComparisonOpFldDispUnitStyleId = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleId, objcss_FldDispUnitStyleCond.FldDispUnitStyleId, strComparisonOpFldDispUnitStyleId);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleName) == true)
{
string strComparisonOpFldDispUnitStyleName = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleName, objcss_FldDispUnitStyleCond.FldDispUnitStyleName, strComparisonOpFldDispUnitStyleName);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleDesc) == true)
{
string strComparisonOpFldDispUnitStyleDesc = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleDesc, objcss_FldDispUnitStyleCond.FldDispUnitStyleDesc, strComparisonOpFldDispUnitStyleDesc);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.StyleIdContent) == true)
{
string strComparisonOpStyleIdContent = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.StyleIdContent, objcss_FldDispUnitStyleCond.StyleIdContent, strComparisonOpStyleIdContent);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.StyleIdTitle) == true)
{
string strComparisonOpStyleIdTitle = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.StyleIdTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.StyleIdTitle, objcss_FldDispUnitStyleCond.StyleIdTitle, strComparisonOpStyleIdTitle);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitStyleContent) == true)
{
string strComparisonOpFldDispUnitStyleContent = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitStyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitStyleContent, objcss_FldDispUnitStyleCond.FldDispUnitStyleContent, strComparisonOpFldDispUnitStyleContent);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.FldDispUnitFormat) == true)
{
string strComparisonOpFldDispUnitFormat = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.FldDispUnitFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.FldDispUnitFormat, objcss_FldDispUnitStyleCond.FldDispUnitFormat, strComparisonOpFldDispUnitFormat);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.CtlTypeId, objcss_FldDispUnitStyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.OrderNum) == true)
{
string strComparisonOpOrderNum = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concss_FldDispUnitStyle.OrderNum, objcss_FldDispUnitStyleCond.OrderNum, strComparisonOpOrderNum);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.DeletedDate, objcss_FldDispUnitStyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.IsDeleted) == true)
{
if (objcss_FldDispUnitStyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_FldDispUnitStyle.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_FldDispUnitStyle.IsDeleted);
}
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.UpdDate, objcss_FldDispUnitStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.UpdUser, objcss_FldDispUnitStyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_FldDispUnitStyleCond.IsUpdated(concss_FldDispUnitStyle.Memo) == true)
{
string strComparisonOpMemo = objcss_FldDispUnitStyleCond.dicFldComparisonOp[concss_FldDispUnitStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_FldDispUnitStyle.Memo, objcss_FldDispUnitStyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcss_FldDispUnitStyleEN.sfUpdFldSetStr = objcss_FldDispUnitStyleEN.getsfUpdFldSetStr();
clscss_FldDispUnitStyleWApi.CheckPropertyNew(objcss_FldDispUnitStyleEN); 
bool bolResult = clscss_FldDispUnitStyleWApi.UpdateRecord(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
 /// 获取唯一性条件串--css_FldDispUnitStyle(字段显示单元样式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldDispUnitStyleName_CtlTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcss_FldDispUnitStyleEN == null) return "";
if (objcss_FldDispUnitStyleEN.FldDispUnitStyleId == null || objcss_FldDispUnitStyleEN.FldDispUnitStyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FldDispUnitStyleId !=  '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleId);
 sbCondition.AppendFormat(" and FldDispUnitStyleName = '{0}'", objcss_FldDispUnitStyleEN.FldDispUnitStyleName);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_FldDispUnitStyleEN.CtlTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
 if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true || clscss_FldDispUnitStyleWApi.IsExist(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) == true)
 {
     objcss_FldDispUnitStyleEN.FldDispUnitStyleId = clscss_FldDispUnitStyleWApi.GetMaxStrId();
 }
clscss_FldDispUnitStyleWApi.CheckPropertyNew(objcss_FldDispUnitStyleEN); 
bool bolResult = clscss_FldDispUnitStyleWApi.AddNewRecord(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
try
{
clscss_FldDispUnitStyleWApi.CheckPropertyNew(objcss_FldDispUnitStyleEN); 
string strFldDispUnitStyleId = clscss_FldDispUnitStyleWApi.AddNewRecordWithMaxId(objcss_FldDispUnitStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
return strFldDispUnitStyleId;
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strWhereCond)
{
try
{
clscss_FldDispUnitStyleWApi.CheckPropertyNew(objcss_FldDispUnitStyleEN); 
bool bolResult = clscss_FldDispUnitStyleWApi.UpdateWithCondition(objcss_FldDispUnitStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscss_FldDispUnitStyleWApi
{
private static readonly string mstrApiControllerName = "css_FldDispUnitStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clscss_FldDispUnitStyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldDispUnitStyleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[字段显示单元样式]...","0");
List<clscss_FldDispUnitStyleEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FldDispUnitStyleId";
objDDL.DataTextField="FldDispUnitStyleName";
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

 /// <param name = "strCtlTypeId"></param>
public static void BindCbo_FldDispUnitStyleId(System.Windows.Forms.ComboBox objComboBox , string strCtlTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concss_FldDispUnitStyle.FldDispUnitStyleId); 
List<clscss_FldDispUnitStyleEN> arrObjLst = clscss_FldDispUnitStyleWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CtlTypeId == strCtlTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = new clscss_FldDispUnitStyleEN()
{
FldDispUnitStyleId = "0",
FldDispUnitStyleName = "选[字段显示单元样式]..."
};
arrObjLstSel.Insert(0, objcss_FldDispUnitStyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concss_FldDispUnitStyle.FldDispUnitStyleId;
objComboBox.DisplayMember = concss_FldDispUnitStyle.FldDispUnitStyleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.FldDispUnitStyleId) && GetStrLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleId) > 8)
{
 throw new Exception("字段[字段显示单元样式Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.FldDispUnitStyleName) && GetStrLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleName) > 50)
{
 throw new Exception("字段[字段显示单元样式名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc) && GetStrLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleDesc) > 1000)
{
 throw new Exception("字段[样式描述]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.StyleIdContent) && GetStrLen(objcss_FldDispUnitStyleEN.StyleIdContent) > 8)
{
 throw new Exception("字段[内容样式Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.StyleIdTitle) && GetStrLen(objcss_FldDispUnitStyleEN.StyleIdTitle) > 8)
{
 throw new Exception("字段[标题样式Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.FldDispUnitStyleContent) && GetStrLen(objcss_FldDispUnitStyleEN.FldDispUnitStyleContent) > 1000)
{
 throw new Exception("字段[样式内容]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.FldDispUnitFormat) && GetStrLen(objcss_FldDispUnitStyleEN.FldDispUnitFormat) > 1000)
{
 throw new Exception("字段[字段显示单元格式]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.CtlTypeId) && GetStrLen(objcss_FldDispUnitStyleEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.DeletedDate) && GetStrLen(objcss_FldDispUnitStyleEN.DeletedDate) > 50)
{
 throw new Exception("字段[删除日期]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.UpdDate) && GetStrLen(objcss_FldDispUnitStyleEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.UpdUser) && GetStrLen(objcss_FldDispUnitStyleEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_FldDispUnitStyleEN.Memo) && GetStrLen(objcss_FldDispUnitStyleEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objcss_FldDispUnitStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleId(string strFldDispUnitStyleId)
{
if (strFldDispUnitStyleId == "") return null;
string strAction = "GetObjByFldDispUnitStyleId";
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldDispUnitStyleId"] = strFldDispUnitStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objcss_FldDispUnitStyleEN = JsonConvert.DeserializeObject<clscss_FldDispUnitStyleEN>(strJson);
return objcss_FldDispUnitStyleEN;
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
public static clscss_FldDispUnitStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN;
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
objcss_FldDispUnitStyleEN = JsonConvert.DeserializeObject<clscss_FldDispUnitStyleEN>(strJson);
return objcss_FldDispUnitStyleEN;
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
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_FldDispUnitStyleEN GetObjByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel =
from objcss_FldDispUnitStyleEN in arrcss_FldDispUnitStyleObjLstCache
where objcss_FldDispUnitStyleEN.FldDispUnitStyleId == strFldDispUnitStyleId 
select objcss_FldDispUnitStyleEN;
if (arrcss_FldDispUnitStyleObjLst_Sel.Count() == 0)
{
   clscss_FldDispUnitStyleEN obj = clscss_FldDispUnitStyleWApi.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcss_FldDispUnitStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldDispUnitStyleNameByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return "";
//初始化列表缓存
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel1 =
from objcss_FldDispUnitStyleEN in arrcss_FldDispUnitStyleObjLstCache
where objcss_FldDispUnitStyleEN.FldDispUnitStyleId == strFldDispUnitStyleId 
select objcss_FldDispUnitStyleEN;
List <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel = new List<clscss_FldDispUnitStyleEN>();
foreach (clscss_FldDispUnitStyleEN obj in arrcss_FldDispUnitStyleObjLst_Sel1)
{
arrcss_FldDispUnitStyleObjLst_Sel.Add(obj);
}
if (arrcss_FldDispUnitStyleObjLst_Sel.Count > 0)
{
return arrcss_FldDispUnitStyleObjLst_Sel[0].FldDispUnitStyleName;
}
string strErrMsgForGetObjById = string.Format("在css_FldDispUnitStyle对象缓存列表中,找不到记录[FldDispUnitStyleId = {0}](函数:{1})", strFldDispUnitStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscss_FldDispUnitStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldDispUnitStyleIdCache(string strFldDispUnitStyleId)
{
if (string.IsNullOrEmpty(strFldDispUnitStyleId) == true) return "";
//初始化列表缓存
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel1 =
from objcss_FldDispUnitStyleEN in arrcss_FldDispUnitStyleObjLstCache
where objcss_FldDispUnitStyleEN.FldDispUnitStyleId == strFldDispUnitStyleId 
select objcss_FldDispUnitStyleEN;
List <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel = new List<clscss_FldDispUnitStyleEN>();
foreach (clscss_FldDispUnitStyleEN obj in arrcss_FldDispUnitStyleObjLst_Sel1)
{
arrcss_FldDispUnitStyleObjLst_Sel.Add(obj);
}
if (arrcss_FldDispUnitStyleObjLst_Sel.Count > 0)
{
return arrcss_FldDispUnitStyleObjLst_Sel[0].FldDispUnitStyleName;
}
string strErrMsgForGetObjById = string.Format("在css_FldDispUnitStyle对象缓存列表中,找不到记录的相关名称[FldDispUnitStyleId = {0}](函数:{1})", strFldDispUnitStyleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscss_FldDispUnitStyleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLst(string strWhereCond)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
 /// <param name = "arrFldDispUnitStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstByFldDispUnitStyleIdLst(List<string> arrFldDispUnitStyleId)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
string strAction = "GetObjLstByFldDispUnitStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldDispUnitStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
 /// <param name = "arrFldDispUnitStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clscss_FldDispUnitStyleEN> GetObjLstByFldDispUnitStyleIdLstCache(List<string> arrFldDispUnitStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLst_Sel =
from objcss_FldDispUnitStyleEN in arrcss_FldDispUnitStyleObjLstCache
where arrFldDispUnitStyleId.Contains(objcss_FldDispUnitStyleEN.FldDispUnitStyleId)
select objcss_FldDispUnitStyleEN;
return arrcss_FldDispUnitStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
public static List<clscss_FldDispUnitStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clscss_FldDispUnitStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_FldDispUnitStyleEN>>(strJson);
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
public static int DelRecord(string strFldDispUnitStyleId)
{
string strAction = "DelRecord";
try
{
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleWApi.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFldDispUnitStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
public static int Delcss_FldDispUnitStyles(List<string> arrFldDispUnitStyleId)
{
string strAction = "Delcss_FldDispUnitStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldDispUnitStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
public static int Delcss_FldDispUnitStylesByCond(string strWhereCond)
{
string strAction = "Delcss_FldDispUnitStylesByCond";
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
public static bool AddNewRecord(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_FldDispUnitStyleEN>(objcss_FldDispUnitStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_FldDispUnitStyleEN>(objcss_FldDispUnitStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_FldDispUnitStyleWApi.ReFreshCache();
var strFldDispUnitStyleId = (string)jobjReturn0["returnStr"];
return strFldDispUnitStyleId;
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
public static bool UpdateRecord(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN)
{
if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_FldDispUnitStyleEN>(objcss_FldDispUnitStyleEN);
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
 /// <param name = "objcss_FldDispUnitStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcss_FldDispUnitStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_FldDispUnitStyleEN.FldDispUnitStyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_FldDispUnitStyleEN>(objcss_FldDispUnitStyleEN);
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
public static bool IsExist(string strFldDispUnitStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldDispUnitStyleId"] = strFldDispUnitStyleId
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
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <param name = "objcss_FldDispUnitStyleENT">目标对象</param>
 public static void CopyTo(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS, clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT)
{
try
{
objcss_FldDispUnitStyleENT.FldDispUnitStyleId = objcss_FldDispUnitStyleENS.FldDispUnitStyleId; //字段显示单元样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleName = objcss_FldDispUnitStyleENS.FldDispUnitStyleName; //字段显示单元样式名称
objcss_FldDispUnitStyleENT.FldDispUnitStyleDesc = objcss_FldDispUnitStyleENS.FldDispUnitStyleDesc; //样式描述
objcss_FldDispUnitStyleENT.StyleIdContent = objcss_FldDispUnitStyleENS.StyleIdContent; //内容样式Id
objcss_FldDispUnitStyleENT.StyleIdTitle = objcss_FldDispUnitStyleENS.StyleIdTitle; //标题样式Id
objcss_FldDispUnitStyleENT.FldDispUnitStyleContent = objcss_FldDispUnitStyleENS.FldDispUnitStyleContent; //样式内容
objcss_FldDispUnitStyleENT.FldDispUnitFormat = objcss_FldDispUnitStyleENS.FldDispUnitFormat; //字段显示单元格式
objcss_FldDispUnitStyleENT.CtlTypeId = objcss_FldDispUnitStyleENS.CtlTypeId; //控件类型号
objcss_FldDispUnitStyleENT.OrderNum = objcss_FldDispUnitStyleENS.OrderNum; //序号
objcss_FldDispUnitStyleENT.DeletedDate = objcss_FldDispUnitStyleENS.DeletedDate; //删除日期
objcss_FldDispUnitStyleENT.IsDeleted = objcss_FldDispUnitStyleENS.IsDeleted; //是否删除
objcss_FldDispUnitStyleENT.UpdDate = objcss_FldDispUnitStyleENS.UpdDate; //修改日期
objcss_FldDispUnitStyleENT.UpdUser = objcss_FldDispUnitStyleENS.UpdUser; //修改者
objcss_FldDispUnitStyleENT.Memo = objcss_FldDispUnitStyleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clscss_FldDispUnitStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscss_FldDispUnitStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscss_FldDispUnitStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscss_FldDispUnitStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscss_FldDispUnitStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscss_FldDispUnitStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
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
if (clscss_FldDispUnitStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_FldDispUnitStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_FldDispUnitStyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_FldDispUnitStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clscss_FldDispUnitStyleEN._CurrTabName;
List<clscss_FldDispUnitStyleEN> arrcss_FldDispUnitStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrcss_FldDispUnitStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscss_FldDispUnitStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concss_FldDispUnitStyle.FldDispUnitStyleId, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.FldDispUnitStyleName, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.FldDispUnitStyleDesc, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.StyleIdContent, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.StyleIdTitle, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.FldDispUnitStyleContent, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.FldDispUnitFormat, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concss_FldDispUnitStyle.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.IsDeleted, Type.GetType("System.Boolean"));
objDT.Columns.Add(concss_FldDispUnitStyle.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concss_FldDispUnitStyle.Memo, Type.GetType("System.String"));
foreach (clscss_FldDispUnitStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concss_FldDispUnitStyle.FldDispUnitStyleId] = objInFor[concss_FldDispUnitStyle.FldDispUnitStyleId];
objDR[concss_FldDispUnitStyle.FldDispUnitStyleName] = objInFor[concss_FldDispUnitStyle.FldDispUnitStyleName];
objDR[concss_FldDispUnitStyle.FldDispUnitStyleDesc] = objInFor[concss_FldDispUnitStyle.FldDispUnitStyleDesc];
objDR[concss_FldDispUnitStyle.StyleIdContent] = objInFor[concss_FldDispUnitStyle.StyleIdContent];
objDR[concss_FldDispUnitStyle.StyleIdTitle] = objInFor[concss_FldDispUnitStyle.StyleIdTitle];
objDR[concss_FldDispUnitStyle.FldDispUnitStyleContent] = objInFor[concss_FldDispUnitStyle.FldDispUnitStyleContent];
objDR[concss_FldDispUnitStyle.FldDispUnitFormat] = objInFor[concss_FldDispUnitStyle.FldDispUnitFormat];
objDR[concss_FldDispUnitStyle.CtlTypeId] = objInFor[concss_FldDispUnitStyle.CtlTypeId];
objDR[concss_FldDispUnitStyle.OrderNum] = objInFor[concss_FldDispUnitStyle.OrderNum];
objDR[concss_FldDispUnitStyle.DeletedDate] = objInFor[concss_FldDispUnitStyle.DeletedDate];
objDR[concss_FldDispUnitStyle.IsDeleted] = objInFor[concss_FldDispUnitStyle.IsDeleted];
objDR[concss_FldDispUnitStyle.UpdDate] = objInFor[concss_FldDispUnitStyle.UpdDate];
objDR[concss_FldDispUnitStyle.UpdUser] = objInFor[concss_FldDispUnitStyle.UpdUser];
objDR[concss_FldDispUnitStyle.Memo] = objInFor[concss_FldDispUnitStyle.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 字段显示单元样式(css_FldDispUnitStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4css_FldDispUnitStyle : clsCommFun4BL
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
clscss_FldDispUnitStyleWApi.ReFreshThisCache();
}
}

}