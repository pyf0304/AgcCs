
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCtlTypeWApi
 表名:CtlType(00050058)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:46
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
public static class  clsCtlTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeId(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conCtlType.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conCtlType.CtlTypeId);
objCtlTypeEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeId) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeId, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeId] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeName(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeName, conCtlType.CtlTypeName);
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, conCtlType.CtlTypeName);
objCtlTypeEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeENName">控件类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeENName(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeENName, 50, conCtlType.CtlTypeENName);
objCtlTypeEN.CtlTypeENName = strCtlTypeENName; //控件类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeENName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeENName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeENName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlCnName">控件类型中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlCnName(this clsCtlTypeEN objCtlTypeEN, string strCtlCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlCnName, conCtlType.CtlCnName);
clsCheckSql.CheckFieldLen(strCtlCnName, 50, conCtlType.CtlCnName);
objCtlTypeEN.CtlCnName = strCtlCnName; //控件类型中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlCnName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlCnName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlCnName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeAbbr">控件类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetCtlTypeAbbr(this clsCtlTypeEN objCtlTypeEN, string strCtlTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeAbbr, conCtlType.CtlTypeAbbr);
clsCheckSql.CheckFieldLen(strCtlTypeAbbr, 5, conCtlType.CtlTypeAbbr);
objCtlTypeEN.CtlTypeAbbr = strCtlTypeAbbr; //控件类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.CtlTypeAbbr) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.CtlTypeAbbr, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.CtlTypeAbbr] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strHtmlCtrlTypeName">HtmlCtrlTypeName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetHtmlCtrlTypeName(this clsCtlTypeEN objCtlTypeEN, string strHtmlCtrlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHtmlCtrlTypeName, 50, conCtlType.HtmlCtrlTypeName);
objCtlTypeEN.HtmlCtrlTypeName = strHtmlCtrlTypeName; //HtmlCtrlTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.HtmlCtrlTypeName) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.HtmlCtrlTypeName, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.HtmlCtrlTypeName] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForApple">IsForApple</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetIsForApple(this clsCtlTypeEN objCtlTypeEN, bool bolIsForApple, string strComparisonOp="")
	{
objCtlTypeEN.IsForApple = bolIsForApple; //IsForApple
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.IsForApple) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.IsForApple, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.IsForApple] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetInUse(this clsCtlTypeEN objCtlTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCtlTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.InUse) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.InUse, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.InUse] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetIsVisible(this clsCtlTypeEN objCtlTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objCtlTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.IsVisible) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.IsVisible, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.IsVisible] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetOrderNum(this clsCtlTypeEN objCtlTypeEN, int intOrderNum, string strComparisonOp="")
	{
objCtlTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.OrderNum) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.OrderNum, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.OrderNum] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetUpdDate(this clsCtlTypeEN objCtlTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCtlType.UpdDate);
objCtlTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.UpdDate) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.UpdDate, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.UpdDate] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetUpdUser(this clsCtlTypeEN objCtlTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCtlType.UpdUser);
objCtlTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.UpdUser) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.UpdUser, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.UpdUser] = strComparisonOp;
}
}
return objCtlTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCtlTypeEN SetMemo(this clsCtlTypeEN objCtlTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCtlType.Memo);
objCtlTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCtlTypeEN.dicFldComparisonOp.ContainsKey(conCtlType.Memo) == false)
{
objCtlTypeEN.dicFldComparisonOp.Add(conCtlType.Memo, strComparisonOp);
}
else
{
objCtlTypeEN.dicFldComparisonOp[conCtlType.Memo] = strComparisonOp;
}
}
return objCtlTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCtlTypeEN objCtlTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeId, objCtlTypeCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeName, objCtlTypeCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeENName) == true)
{
string strComparisonOpCtlTypeENName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeENName, objCtlTypeCond.CtlTypeENName, strComparisonOpCtlTypeENName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlCnName) == true)
{
string strComparisonOpCtlCnName = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlCnName, objCtlTypeCond.CtlCnName, strComparisonOpCtlCnName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.CtlTypeAbbr) == true)
{
string strComparisonOpCtlTypeAbbr = objCtlTypeCond.dicFldComparisonOp[conCtlType.CtlTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.CtlTypeAbbr, objCtlTypeCond.CtlTypeAbbr, strComparisonOpCtlTypeAbbr);
}
if (objCtlTypeCond.IsUpdated(conCtlType.HtmlCtrlTypeName) == true)
{
string strComparisonOpHtmlCtrlTypeName = objCtlTypeCond.dicFldComparisonOp[conCtlType.HtmlCtrlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.HtmlCtrlTypeName, objCtlTypeCond.HtmlCtrlTypeName, strComparisonOpHtmlCtrlTypeName);
}
if (objCtlTypeCond.IsUpdated(conCtlType.IsForApple) == true)
{
if (objCtlTypeCond.IsForApple == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.IsForApple);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.IsForApple);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.InUse) == true)
{
if (objCtlTypeCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.InUse);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.IsVisible) == true)
{
if (objCtlTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCtlType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCtlType.IsVisible);
}
}
if (objCtlTypeCond.IsUpdated(conCtlType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCtlTypeCond.dicFldComparisonOp[conCtlType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCtlType.OrderNum, objCtlTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCtlTypeCond.IsUpdated(conCtlType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCtlTypeCond.dicFldComparisonOp[conCtlType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.UpdDate, objCtlTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCtlTypeCond.IsUpdated(conCtlType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCtlTypeCond.dicFldComparisonOp[conCtlType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.UpdUser, objCtlTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCtlTypeCond.IsUpdated(conCtlType.Memo) == true)
{
string strComparisonOpMemo = objCtlTypeCond.dicFldComparisonOp[conCtlType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCtlType.Memo, objCtlTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCtlTypeEN objCtlTypeEN)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCtlTypeEN.sfUpdFldSetStr = objCtlTypeEN.getsfUpdFldSetStr();
clsCtlTypeWApi.CheckPropertyNew(objCtlTypeEN); 
bool bolResult = clsCtlTypeWApi.UpdateRecord(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCtlTypeEN objCtlTypeEN)
{
 if (string.IsNullOrEmpty(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCtlTypeWApi.IsExist(objCtlTypeEN.CtlTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCtlTypeEN.CtlTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCtlTypeWApi.CheckPropertyNew(objCtlTypeEN); 
bool bolResult = clsCtlTypeWApi.AddNewRecord(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
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
 /// <param name = "objCtlTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCtlTypeEN objCtlTypeEN)
{
try
{
clsCtlTypeWApi.CheckPropertyNew(objCtlTypeEN); 
string strCtlTypeId = clsCtlTypeWApi.AddNewRecordWithMaxId(objCtlTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
return strCtlTypeId;
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCtlTypeEN objCtlTypeEN, string strWhereCond)
{
try
{
clsCtlTypeWApi.CheckPropertyNew(objCtlTypeEN); 
bool bolResult = clsCtlTypeWApi.UpdateWithCondition(objCtlTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumCtlTypeWA
{
 /// <summary>
 /// None
 /// </summary>
public const string None_00 = "00";
 /// <summary>
 /// Button
 /// </summary>
public const string Button_01 = "01";
 /// <summary>
 /// CheckBox
 /// </summary>
public const string CheckBox_02 = "02";
 /// <summary>
 /// CheckBoxList
 /// </summary>
public const string CheckBoxList_03 = "03";
 /// <summary>
 /// DataGrid
 /// </summary>
public const string DataGrid_04 = "04";
 /// <summary>
 /// DataList
 /// </summary>
public const string DataList_05 = "05";
 /// <summary>
 /// DropDownList
 /// </summary>
public const string DropDownList_06 = "06";
 /// <summary>
 /// HyperLink
 /// </summary>
public const string HyperLink_07 = "07";
 /// <summary>
 /// Image
 /// </summary>
public const string Image_08 = "08";
 /// <summary>
 /// ImageButton
 /// </summary>
public const string ImageButton_09 = "09";
 /// <summary>
 /// Label
 /// </summary>
public const string Label_10 = "10";
 /// <summary>
 /// LinkButton
 /// </summary>
public const string LinkButton_11 = "11";
 /// <summary>
 /// ListBox
 /// </summary>
public const string ListBox_12 = "12";
 /// <summary>
 /// Panel
 /// </summary>
public const string Panel_13 = "13";
 /// <summary>
 /// RadioButton
 /// </summary>
public const string RadioButton_14 = "14";
 /// <summary>
 /// RadioButtonList
 /// </summary>
public const string RadioButtonList_15 = "15";
 /// <summary>
 /// TextBox
 /// </summary>
public const string TextBox_16 = "16";
 /// <summary>
 /// RadioButton_Bool
 /// </summary>
public const string RadioButton_Bool_17 = "17";
 /// <summary>
 /// DropDownList_Bool
 /// </summary>
public const string DropDownList_Bool_18 = "18";
 /// <summary>
 /// GridView
 /// </summary>
public const string GridView_19 = "19";
 /// <summary>
 /// ISOstoryBoard
 /// </summary>
public const string ISOstoryBoard_20 = "20";
 /// <summary>
 /// ISOscene
 /// </summary>
public const string ISOscene_21 = "21";
 /// <summary>
 /// ISOviewController
 /// </summary>
public const string ISOviewController_22 = "22";
 /// <summary>
 /// ISOviewControllerLayoutGuide
 /// </summary>
public const string ISOviewControllerLayoutGuide_23 = "23";
 /// <summary>
 /// ISOview
 /// </summary>
public const string ISOview_24 = "24";
 /// <summary>
 /// ISOStackView
 /// </summary>
public const string ISOStackView_25 = "25";
 /// <summary>
 /// ISOButton
 /// </summary>
public const string ISOButton_26 = "26";
 /// <summary>
 /// ISOtextField
 /// </summary>
public const string ISOtextField_27 = "27";
 /// <summary>
 /// ISOlabel
 /// </summary>
public const string ISOlabel_28 = "28";
 /// <summary>
 /// ISOnavigationBar
 /// </summary>
public const string ISOnavigationBar_29 = "29";
 /// <summary>
 /// ISONavigationItem
 /// </summary>
public const string ISONavigationItem_30 = "30";
 /// <summary>
 /// ISOBarButtonItem
 /// </summary>
public const string ISOBarButtonItem_31 = "31";
 /// <summary>
 /// ISOOutlet
 /// </summary>
public const string ISOOutlet_32 = "32";
 /// <summary>
 /// ISOAction
 /// </summary>
public const string ISOAction_33 = "33";
 /// <summary>
 /// ISOAutoresizingMask
 /// </summary>
public const string ISOAutoresizingMask_34 = "34";
 /// <summary>
 /// GivenValue
 /// </summary>
public const string GivenValue_35 = "35";
 /// <summary>
 /// DefaultValue
 /// </summary>
public const string DefaultValue_36 = "36";
 /// <summary>
 /// ViewVariable
 /// </summary>
public const string ViewVariable_38 = "38";
 /// <summary>
 /// DisplayName
 /// </summary>
public const string DisplayName_39 = "39";
 /// <summary>
 /// TextArea
 /// </summary>
public const string TextArea_41 = "41";
 /// <summary>
 /// Table
 /// </summary>
public const string Table_42 = "42";
 /// <summary>
 /// span
 /// </summary>
public const string span_43 = "43";
 /// <summary>
 /// TableHeader
 /// </summary>
public const string TableHeader_44 = "44";
 /// <summary>
 /// TablePager
 /// </summary>
public const string TablePager_45 = "45";
 /// <summary>
 /// Icon
 /// </summary>
public const string Icon_46 = "46";
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCtlTypeWApi
{
private static readonly string mstrApiControllerName = "CtlTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCtlTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CtlTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[控件类型缩写]...","0");
List<clsCtlTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CtlTypeId";
objDDL.DataTextField="CtlTypeName";
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

public static void BindCbo_CtlTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCtlType.CtlTypeId); 
List<clsCtlTypeEN> arrObjLst = clsCtlTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN()
{
CtlTypeId = "0",
CtlTypeName = "选[控件类型缩写]..."
};
arrObjLst.Insert(0, objCtlTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCtlType.CtlTypeId;
objComboBox.DisplayMember = conCtlType.CtlTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}
 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "bolIsForApple"></param>
public static void BindCbo_CtlTypeId(System.Windows.Forms.ComboBox objComboBox , bool bolIsForApple)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCtlType.CtlTypeId); 
List<clsCtlTypeEN> arrObjLst = clsCtlTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.IsForApple == false).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN()
{
CtlTypeId = "0",
CtlTypeName = "选[控件类型缩写]..."
};
arrObjLstSel.Insert(0, objCtlTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCtlType.CtlTypeId;
objComboBox.DisplayMember = conCtlType.CtlTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}
//该表下拉框功能不需要生成;
 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "bolIsVisible"></param>
public static void BindCbo_CtlTypeId(System.Windows.Forms.ComboBox objComboBox , bool bolIsVisible)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCtlType.CtlTypeId); 
List<clsCtlTypeEN> arrObjLst = clsCtlTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.IsVisible == false).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCtlTypeEN objCtlTypeEN = new clsCtlTypeEN()
{
CtlTypeId = "0",
CtlTypeName = "选[控件类型缩写]..."
};
arrObjLstSel.Insert(0, objCtlTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCtlType.CtlTypeId;
objComboBox.DisplayMember = conCtlType.CtlTypeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCtlTypeEN objCtlTypeEN)
{
if (!Object.Equals(null, objCtlTypeEN.CtlTypeId) && GetStrLen(objCtlTypeEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objCtlTypeEN.CtlTypeName) && GetStrLen(objCtlTypeEN.CtlTypeName) > 30)
{
 throw new Exception("字段[控件类型名]的长度不能超过30!");
}
if (!Object.Equals(null, objCtlTypeEN.CtlTypeENName) && GetStrLen(objCtlTypeEN.CtlTypeENName) > 50)
{
 throw new Exception("字段[控件类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objCtlTypeEN.CtlCnName) && GetStrLen(objCtlTypeEN.CtlCnName) > 50)
{
 throw new Exception("字段[控件类型中文名]的长度不能超过50!");
}
if (!Object.Equals(null, objCtlTypeEN.CtlTypeAbbr) && GetStrLen(objCtlTypeEN.CtlTypeAbbr) > 5)
{
 throw new Exception("字段[控件类型缩写]的长度不能超过5!");
}
if (!Object.Equals(null, objCtlTypeEN.HtmlCtrlTypeName) && GetStrLen(objCtlTypeEN.HtmlCtrlTypeName) > 50)
{
 throw new Exception("字段[HtmlCtrlTypeName]的长度不能超过50!");
}
if (!Object.Equals(null, objCtlTypeEN.UpdDate) && GetStrLen(objCtlTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCtlTypeEN.UpdUser) && GetStrLen(objCtlTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCtlTypeEN.Memo) && GetStrLen(objCtlTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCtlTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCtlTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCtlTypeEN GetObjByCtlTypeId(string strCtlTypeId)
{
if (strCtlTypeId == "") return null;
string strAction = "GetObjByCtlTypeId";
clsCtlTypeEN objCtlTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCtlTypeId"] = strCtlTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCtlTypeEN = JsonConvert.DeserializeObject<clsCtlTypeEN>(strJson);
return objCtlTypeEN;
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
public static clsCtlTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCtlTypeEN objCtlTypeEN;
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
objCtlTypeEN = JsonConvert.DeserializeObject<clsCtlTypeEN>(strJson);
return objCtlTypeEN;
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
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCtlTypeEN GetObjByCtlTypeIdCache(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel =
from objCtlTypeEN in arrCtlTypeObjLstCache
where objCtlTypeEN.CtlTypeId == strCtlTypeId 
select objCtlTypeEN;
if (arrCtlTypeObjLst_Sel.Count() == 0)
{
   clsCtlTypeEN obj = clsCtlTypeWApi.GetObjByCtlTypeId(strCtlTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCtlTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCtlTypeNameByCtlTypeIdCache(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return "";
//初始化列表缓存
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel1 =
from objCtlTypeEN in arrCtlTypeObjLstCache
where objCtlTypeEN.CtlTypeId == strCtlTypeId 
select objCtlTypeEN;
List <clsCtlTypeEN> arrCtlTypeObjLst_Sel = new List<clsCtlTypeEN>();
foreach (clsCtlTypeEN obj in arrCtlTypeObjLst_Sel1)
{
arrCtlTypeObjLst_Sel.Add(obj);
}
if (arrCtlTypeObjLst_Sel.Count > 0)
{
return arrCtlTypeObjLst_Sel[0].CtlTypeName;
}
string strErrMsgForGetObjById = string.Format("在CtlType对象缓存列表中,找不到记录[CtlTypeId = {0}](函数:{1})", strCtlTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCtlTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtlTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCtlTypeIdCache(string strCtlTypeId)
{
if (string.IsNullOrEmpty(strCtlTypeId) == true) return "";
//初始化列表缓存
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel1 =
from objCtlTypeEN in arrCtlTypeObjLstCache
where objCtlTypeEN.CtlTypeId == strCtlTypeId 
select objCtlTypeEN;
List <clsCtlTypeEN> arrCtlTypeObjLst_Sel = new List<clsCtlTypeEN>();
foreach (clsCtlTypeEN obj in arrCtlTypeObjLst_Sel1)
{
arrCtlTypeObjLst_Sel.Add(obj);
}
if (arrCtlTypeObjLst_Sel.Count > 0)
{
return arrCtlTypeObjLst_Sel[0].CtlTypeName;
}
string strErrMsgForGetObjById = string.Format("在CtlType对象缓存列表中,找不到记录的相关名称[CtlTypeId = {0}](函数:{1})", strCtlTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCtlTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetObjLst(string strWhereCond)
{
 List<clsCtlTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
 /// <param name = "arrCtlTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstByCtlTypeIdLst(List<string> arrCtlTypeId)
{
 List<clsCtlTypeEN> arrObjLst; 
string strAction = "GetObjLstByCtlTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCtlTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
 /// <param name = "arrCtlTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCtlTypeEN> GetObjLstByCtlTypeIdLstCache(List<string> arrCtlTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
List<clsCtlTypeEN> arrCtlTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCtlTypeEN> arrCtlTypeObjLst_Sel =
from objCtlTypeEN in arrCtlTypeObjLstCache
where arrCtlTypeId.Contains(objCtlTypeEN.CtlTypeId)
select objCtlTypeEN;
return arrCtlTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCtlTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCtlTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
public static List<clsCtlTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCtlTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
public static List<clsCtlTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCtlTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
public static List<clsCtlTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCtlTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCtlTypeEN>>(strJson);
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
public static int DelRecord(string strCtlTypeId)
{
string strAction = "DelRecord";
try
{
 clsCtlTypeEN objCtlTypeEN = clsCtlTypeWApi.GetObjByCtlTypeId(strCtlTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCtlTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCtlTypeWApi.ReFreshCache();
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
public static int DelCtlTypes(List<string> arrCtlTypeId)
{
string strAction = "DelCtlTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCtlTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCtlTypeWApi.ReFreshCache();
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
public static int DelCtlTypesByCond(string strWhereCond)
{
string strAction = "DelCtlTypesByCond";
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
public static bool AddNewRecord(clsCtlTypeEN objCtlTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCtlTypeEN>(objCtlTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCtlTypeEN objCtlTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCtlTypeEN>(objCtlTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCtlTypeWApi.ReFreshCache();
var strCtlTypeId = (string)jobjReturn0["returnStr"];
return strCtlTypeId;
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
public static bool UpdateRecord(clsCtlTypeEN objCtlTypeEN)
{
if (string.IsNullOrEmpty(objCtlTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCtlTypeEN.CtlTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCtlTypeEN>(objCtlTypeEN);
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
 /// <param name = "objCtlTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCtlTypeEN objCtlTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCtlTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCtlTypeEN.CtlTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCtlTypeEN.CtlTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCtlTypeEN>(objCtlTypeEN);
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
public static bool IsExist(string strCtlTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCtlTypeId"] = strCtlTypeId
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
 /// <param name = "objCtlTypeENS">源对象</param>
 /// <param name = "objCtlTypeENT">目标对象</param>
 public static void CopyTo(clsCtlTypeEN objCtlTypeENS, clsCtlTypeEN objCtlTypeENT)
{
try
{
objCtlTypeENT.CtlTypeId = objCtlTypeENS.CtlTypeId; //控件类型号
objCtlTypeENT.CtlTypeName = objCtlTypeENS.CtlTypeName; //控件类型名
objCtlTypeENT.CtlTypeENName = objCtlTypeENS.CtlTypeENName; //控件类型英文名
objCtlTypeENT.CtlCnName = objCtlTypeENS.CtlCnName; //控件类型中文名
objCtlTypeENT.CtlTypeAbbr = objCtlTypeENS.CtlTypeAbbr; //控件类型缩写
objCtlTypeENT.HtmlCtrlTypeName = objCtlTypeENS.HtmlCtrlTypeName; //HtmlCtrlTypeName
objCtlTypeENT.IsForApple = objCtlTypeENS.IsForApple; //IsForApple
objCtlTypeENT.InUse = objCtlTypeENS.InUse; //是否在用
objCtlTypeENT.IsVisible = objCtlTypeENS.IsVisible; //是否显示
objCtlTypeENT.OrderNum = objCtlTypeENS.OrderNum; //序号
objCtlTypeENT.UpdDate = objCtlTypeENS.UpdDate; //修改日期
objCtlTypeENT.UpdUser = objCtlTypeENS.UpdUser; //修改者
objCtlTypeENT.Memo = objCtlTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCtlTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCtlTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCtlTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCtlTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCtlTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCtlTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
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
if (clsCtlTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCtlTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCtlTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCtlTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCtlTypeEN._CurrTabName;
List<clsCtlTypeEN> arrCtlTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCtlTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCtlTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCtlType.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.CtlTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.CtlCnName, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.CtlTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.HtmlCtrlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.IsForApple, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCtlType.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCtlType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCtlType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCtlType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCtlType.Memo, Type.GetType("System.String"));
foreach (clsCtlTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCtlType.CtlTypeId] = objInFor[conCtlType.CtlTypeId];
objDR[conCtlType.CtlTypeName] = objInFor[conCtlType.CtlTypeName];
objDR[conCtlType.CtlTypeENName] = objInFor[conCtlType.CtlTypeENName];
objDR[conCtlType.CtlCnName] = objInFor[conCtlType.CtlCnName];
objDR[conCtlType.CtlTypeAbbr] = objInFor[conCtlType.CtlTypeAbbr];
objDR[conCtlType.HtmlCtrlTypeName] = objInFor[conCtlType.HtmlCtrlTypeName];
objDR[conCtlType.IsForApple] = objInFor[conCtlType.IsForApple];
objDR[conCtlType.InUse] = objInFor[conCtlType.InUse];
objDR[conCtlType.IsVisible] = objInFor[conCtlType.IsVisible];
objDR[conCtlType.OrderNum] = objInFor[conCtlType.OrderNum];
objDR[conCtlType.UpdDate] = objInFor[conCtlType.UpdDate];
objDR[conCtlType.UpdUser] = objInFor[conCtlType.UpdUser];
objDR[conCtlType.Memo] = objInFor[conCtlType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 控件类型缩写(CtlType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CtlType : clsCommFun4BL
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
clsCtlTypeWApi.ReFreshThisCache();
}
}

}