
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonTabWApi
 表名:ButtonTab(00050427)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsButtonTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonId">按钮Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetButtonId(this clsButtonTabEN objButtonTabEN, string strButtonId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strButtonId, 2, conButtonTab.ButtonId);
clsCheckSql.CheckFieldForeignKey(strButtonId, 2, conButtonTab.ButtonId);
objButtonTabEN.ButtonId = strButtonId; //按钮Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ButtonId) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ButtonId, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ButtonId] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetButtonName(this clsButtonTabEN objButtonTabEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, conButtonTab.ButtonName);
clsCheckSql.CheckFieldLen(strButtonName, 30, conButtonTab.ButtonName);
objButtonTabEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ButtonName) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ButtonName, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ButtonName] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetText(this clsButtonTabEN objButtonTabEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, conButtonTab.Text);
clsCheckSql.CheckFieldLen(strText, 30, conButtonTab.Text);
objButtonTabEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Text) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Text, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Text] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCommandName">命令名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetCommandName(this clsButtonTabEN objButtonTabEN, string strCommandName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCommandName, 30, conButtonTab.CommandName);
objButtonTabEN.CommandName = strCommandName; //命令名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.CommandName) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.CommandName, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.CommandName] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intHeight">高度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetHeight(this clsButtonTabEN objButtonTabEN, int intHeight, string strComparisonOp="")
	{
objButtonTabEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Height) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Height, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Height] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intWidth">宽</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetWidth(this clsButtonTabEN objButtonTabEN, int intWidth, string strComparisonOp="")
	{
objButtonTabEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Width) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Width, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Width] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCssClass">样式表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetCssClass(this clsButtonTabEN objButtonTabEN, string strCssClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCssClass, 50, conButtonTab.CssClass);
objButtonTabEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.CssClass) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.CssClass, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.CssClass] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strImageUrl">图片资源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetImageUrl(this clsButtonTabEN objButtonTabEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conButtonTab.ImageUrl);
objButtonTabEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.ImageUrl) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.ImageUrl, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.ImageUrl] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetInUse(this clsButtonTabEN objButtonTabEN, bool bolInUse, string strComparisonOp="")
	{
objButtonTabEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.InUse) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.InUse, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.InUse] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetOrderNum(this clsButtonTabEN objButtonTabEN, int intOrderNum, string strComparisonOp="")
	{
objButtonTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.OrderNum) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.OrderNum, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.OrderNum] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetUpdUser(this clsButtonTabEN objButtonTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conButtonTab.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conButtonTab.UpdUser);
objButtonTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.UpdUser) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.UpdUser, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.UpdUser] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetUpdDate(this clsButtonTabEN objButtonTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conButtonTab.UpdDate);
objButtonTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.UpdDate) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.UpdDate, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.UpdDate] = strComparisonOp;
}
}
return objButtonTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objButtonTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsButtonTabEN SetMemo(this clsButtonTabEN objButtonTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conButtonTab.Memo);
objButtonTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objButtonTabEN.dicFldComparisonOp.ContainsKey(conButtonTab.Memo) == false)
{
objButtonTabEN.dicFldComparisonOp.Add(conButtonTab.Memo, strComparisonOp);
}
else
{
objButtonTabEN.dicFldComparisonOp[conButtonTab.Memo] = strComparisonOp;
}
}
return objButtonTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsButtonTabEN objButtonTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objButtonTabCond.IsUpdated(conButtonTab.ButtonId) == true)
{
string strComparisonOpButtonId = objButtonTabCond.dicFldComparisonOp[conButtonTab.ButtonId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ButtonId, objButtonTabCond.ButtonId, strComparisonOpButtonId);
}
if (objButtonTabCond.IsUpdated(conButtonTab.ButtonName) == true)
{
string strComparisonOpButtonName = objButtonTabCond.dicFldComparisonOp[conButtonTab.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ButtonName, objButtonTabCond.ButtonName, strComparisonOpButtonName);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Text) == true)
{
string strComparisonOpText = objButtonTabCond.dicFldComparisonOp[conButtonTab.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.Text, objButtonTabCond.Text, strComparisonOpText);
}
if (objButtonTabCond.IsUpdated(conButtonTab.CommandName) == true)
{
string strComparisonOpCommandName = objButtonTabCond.dicFldComparisonOp[conButtonTab.CommandName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.CommandName, objButtonTabCond.CommandName, strComparisonOpCommandName);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Height) == true)
{
string strComparisonOpHeight = objButtonTabCond.dicFldComparisonOp[conButtonTab.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.Height, objButtonTabCond.Height, strComparisonOpHeight);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Width) == true)
{
string strComparisonOpWidth = objButtonTabCond.dicFldComparisonOp[conButtonTab.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.Width, objButtonTabCond.Width, strComparisonOpWidth);
}
if (objButtonTabCond.IsUpdated(conButtonTab.CssClass) == true)
{
string strComparisonOpCssClass = objButtonTabCond.dicFldComparisonOp[conButtonTab.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.CssClass, objButtonTabCond.CssClass, strComparisonOpCssClass);
}
if (objButtonTabCond.IsUpdated(conButtonTab.ImageUrl) == true)
{
string strComparisonOpImageUrl = objButtonTabCond.dicFldComparisonOp[conButtonTab.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.ImageUrl, objButtonTabCond.ImageUrl, strComparisonOpImageUrl);
}
if (objButtonTabCond.IsUpdated(conButtonTab.InUse) == true)
{
if (objButtonTabCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conButtonTab.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conButtonTab.InUse);
}
}
if (objButtonTabCond.IsUpdated(conButtonTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objButtonTabCond.dicFldComparisonOp[conButtonTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conButtonTab.OrderNum, objButtonTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objButtonTabCond.IsUpdated(conButtonTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objButtonTabCond.dicFldComparisonOp[conButtonTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.UpdUser, objButtonTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objButtonTabCond.IsUpdated(conButtonTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objButtonTabCond.dicFldComparisonOp[conButtonTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.UpdDate, objButtonTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objButtonTabCond.IsUpdated(conButtonTab.Memo) == true)
{
string strComparisonOpMemo = objButtonTabCond.dicFldComparisonOp[conButtonTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conButtonTab.Memo, objButtonTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsButtonTabEN objButtonTabEN)
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objButtonTabEN.sfUpdFldSetStr = objButtonTabEN.getsfUpdFldSetStr();
clsButtonTabWApi.CheckPropertyNew(objButtonTabEN); 
bool bolResult = clsButtonTabWApi.UpdateRecord(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ButtonTab(按钮), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ButtonName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objButtonTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsButtonTabEN objButtonTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objButtonTabEN == null) return "";
if (objButtonTabEN.ButtonId == null || objButtonTabEN.ButtonId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ButtonId !=  '{0}'", objButtonTabEN.ButtonId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objButtonTabEN.ButtonName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsButtonTabEN objButtonTabEN)
{
try
{
 if (string.IsNullOrEmpty(objButtonTabEN.ButtonId) == true || clsButtonTabWApi.IsExist(objButtonTabEN.ButtonId) == true)
 {
     objButtonTabEN.ButtonId = clsButtonTabWApi.GetMaxStrId();
 }
clsButtonTabWApi.CheckPropertyNew(objButtonTabEN); 
bool bolResult = clsButtonTabWApi.AddNewRecord(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
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
 /// <param name = "objButtonTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsButtonTabEN objButtonTabEN)
{
try
{
clsButtonTabWApi.CheckPropertyNew(objButtonTabEN); 
string strButtonId = clsButtonTabWApi.AddNewRecordWithMaxId(objButtonTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
return strButtonId;
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsButtonTabEN objButtonTabEN, string strWhereCond)
{
try
{
clsButtonTabWApi.CheckPropertyNew(objButtonTabEN); 
bool bolResult = clsButtonTabWApi.UpdateWithCondition(objButtonTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
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
 /// 按钮(ButtonTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsButtonTabWApi
{
private static readonly string mstrApiControllerName = "ButtonTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsButtonTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ButtonId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[按钮]...","0");
List<clsButtonTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ButtonId";
objDDL.DataTextField="ButtonName";
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

public static void BindCbo_ButtonId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conButtonTab.ButtonId); 
List<clsButtonTabEN> arrObjLst = clsButtonTabWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsButtonTabEN objButtonTabEN = new clsButtonTabEN()
{
ButtonId = "0",
ButtonName = "选[按钮]..."
};
arrObjLst.Insert(0, objButtonTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conButtonTab.ButtonId;
objComboBox.DisplayMember = conButtonTab.ButtonName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsButtonTabEN objButtonTabEN)
{
if (!Object.Equals(null, objButtonTabEN.ButtonId) && GetStrLen(objButtonTabEN.ButtonId) > 2)
{
 throw new Exception("字段[按钮Id]的长度不能超过2!");
}
if (!Object.Equals(null, objButtonTabEN.ButtonName) && GetStrLen(objButtonTabEN.ButtonName) > 30)
{
 throw new Exception("字段[按钮名称]的长度不能超过30!");
}
if (!Object.Equals(null, objButtonTabEN.Text) && GetStrLen(objButtonTabEN.Text) > 30)
{
 throw new Exception("字段[文本]的长度不能超过30!");
}
if (!Object.Equals(null, objButtonTabEN.CommandName) && GetStrLen(objButtonTabEN.CommandName) > 30)
{
 throw new Exception("字段[命令名]的长度不能超过30!");
}
if (!Object.Equals(null, objButtonTabEN.CssClass) && GetStrLen(objButtonTabEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objButtonTabEN.ImageUrl) && GetStrLen(objButtonTabEN.ImageUrl) > 100)
{
 throw new Exception("字段[图片资源]的长度不能超过100!");
}
if (!Object.Equals(null, objButtonTabEN.UpdUser) && GetStrLen(objButtonTabEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objButtonTabEN.UpdDate) && GetStrLen(objButtonTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objButtonTabEN.Memo) && GetStrLen(objButtonTabEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objButtonTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strButtonId">表关键字</param>
 /// <returns>表对象</returns>
public static clsButtonTabEN GetObjByButtonId(string strButtonId)
{
if (strButtonId == "") return null;
string strAction = "GetObjByButtonId";
clsButtonTabEN objButtonTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strButtonId"] = strButtonId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objButtonTabEN = JsonConvert.DeserializeObject<clsButtonTabEN>(strJson);
return objButtonTabEN;
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
public static clsButtonTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsButtonTabEN objButtonTabEN;
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
objButtonTabEN = JsonConvert.DeserializeObject<clsButtonTabEN>(strJson);
return objButtonTabEN;
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
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsButtonTabEN GetObjByButtonIdCache(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel =
from objButtonTabEN in arrButtonTabObjLstCache
where objButtonTabEN.ButtonId == strButtonId 
select objButtonTabEN;
if (arrButtonTabObjLst_Sel.Count() == 0)
{
   clsButtonTabEN obj = clsButtonTabWApi.GetObjByButtonId(strButtonId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrButtonTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetButtonNameByButtonIdCache(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return "";
//初始化列表缓存
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel1 =
from objButtonTabEN in arrButtonTabObjLstCache
where objButtonTabEN.ButtonId == strButtonId 
select objButtonTabEN;
List <clsButtonTabEN> arrButtonTabObjLst_Sel = new List<clsButtonTabEN>();
foreach (clsButtonTabEN obj in arrButtonTabObjLst_Sel1)
{
arrButtonTabObjLst_Sel.Add(obj);
}
if (arrButtonTabObjLst_Sel.Count > 0)
{
return arrButtonTabObjLst_Sel[0].ButtonName;
}
string strErrMsgForGetObjById = string.Format("在ButtonTab对象缓存列表中,找不到记录[ButtonId = {0}](函数:{1})", strButtonId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsButtonTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strButtonId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByButtonIdCache(string strButtonId)
{
if (string.IsNullOrEmpty(strButtonId) == true) return "";
//初始化列表缓存
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel1 =
from objButtonTabEN in arrButtonTabObjLstCache
where objButtonTabEN.ButtonId == strButtonId 
select objButtonTabEN;
List <clsButtonTabEN> arrButtonTabObjLst_Sel = new List<clsButtonTabEN>();
foreach (clsButtonTabEN obj in arrButtonTabObjLst_Sel1)
{
arrButtonTabObjLst_Sel.Add(obj);
}
if (arrButtonTabObjLst_Sel.Count > 0)
{
return arrButtonTabObjLst_Sel[0].ButtonName;
}
string strErrMsgForGetObjById = string.Format("在ButtonTab对象缓存列表中,找不到记录的相关名称[ButtonId = {0}](函数:{1})", strButtonId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsButtonTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetObjLst(string strWhereCond)
{
 List<clsButtonTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
 /// <param name = "arrButtonId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetObjLstByButtonIdLst(List<string> arrButtonId)
{
 List<clsButtonTabEN> arrObjLst; 
string strAction = "GetObjLstByButtonIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrButtonId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
 /// <param name = "arrButtonId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsButtonTabEN> GetObjLstByButtonIdLstCache(List<string> arrButtonId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
List<clsButtonTabEN> arrButtonTabObjLstCache = GetObjLstCache();
IEnumerable <clsButtonTabEN> arrButtonTabObjLst_Sel =
from objButtonTabEN in arrButtonTabObjLstCache
where arrButtonId.Contains(objButtonTabEN.ButtonId)
select objButtonTabEN;
return arrButtonTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsButtonTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsButtonTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
public static List<clsButtonTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsButtonTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
public static List<clsButtonTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsButtonTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
public static List<clsButtonTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsButtonTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsButtonTabEN>>(strJson);
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
public static int DelRecord(string strButtonId)
{
string strAction = "DelRecord";
try
{
 clsButtonTabEN objButtonTabEN = clsButtonTabWApi.GetObjByButtonId(strButtonId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strButtonId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsButtonTabWApi.ReFreshCache();
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
public static int DelButtonTabs(List<string> arrButtonId)
{
string strAction = "DelButtonTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrButtonId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsButtonTabWApi.ReFreshCache();
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
public static int DelButtonTabsByCond(string strWhereCond)
{
string strAction = "DelButtonTabsByCond";
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
public static bool AddNewRecord(clsButtonTabEN objButtonTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonTabEN>(objButtonTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsButtonTabEN objButtonTabEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonTabEN>(objButtonTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsButtonTabWApi.ReFreshCache();
var strButtonId = (string)jobjReturn0["returnStr"];
return strButtonId;
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
public static bool UpdateRecord(clsButtonTabEN objButtonTabEN)
{
if (string.IsNullOrEmpty(objButtonTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonTabEN.ButtonId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonTabEN>(objButtonTabEN);
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
 /// <param name = "objButtonTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsButtonTabEN objButtonTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objButtonTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonTabEN.ButtonId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objButtonTabEN.ButtonId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsButtonTabEN>(objButtonTabEN);
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
public static bool IsExist(string strButtonId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strButtonId"] = strButtonId
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
 /// <param name = "objButtonTabENS">源对象</param>
 /// <param name = "objButtonTabENT">目标对象</param>
 public static void CopyTo(clsButtonTabEN objButtonTabENS, clsButtonTabEN objButtonTabENT)
{
try
{
objButtonTabENT.ButtonId = objButtonTabENS.ButtonId; //按钮Id
objButtonTabENT.ButtonName = objButtonTabENS.ButtonName; //按钮名称
objButtonTabENT.Text = objButtonTabENS.Text; //文本
objButtonTabENT.CommandName = objButtonTabENS.CommandName; //命令名
objButtonTabENT.Height = objButtonTabENS.Height; //高度
objButtonTabENT.Width = objButtonTabENS.Width; //宽
objButtonTabENT.CssClass = objButtonTabENS.CssClass; //样式表
objButtonTabENT.ImageUrl = objButtonTabENS.ImageUrl; //图片资源
objButtonTabENT.InUse = objButtonTabENS.InUse; //是否在用
objButtonTabENT.OrderNum = objButtonTabENS.OrderNum; //序号
objButtonTabENT.UpdUser = objButtonTabENS.UpdUser; //修改者
objButtonTabENT.UpdDate = objButtonTabENS.UpdDate; //修改日期
objButtonTabENT.Memo = objButtonTabENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsButtonTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsButtonTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsButtonTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsButtonTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsButtonTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsButtonTabEN._AttributeName)
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
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
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
if (clsButtonTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsButtonTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsButtonTabWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsButtonTabEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsButtonTabEN._CurrTabName;
List<clsButtonTabEN> arrButtonTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrButtonTabObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsButtonTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conButtonTab.ButtonId, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.Text, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.CommandName, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.Height, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonTab.Width, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonTab.CssClass, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conButtonTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conButtonTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conButtonTab.Memo, Type.GetType("System.String"));
foreach (clsButtonTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conButtonTab.ButtonId] = objInFor[conButtonTab.ButtonId];
objDR[conButtonTab.ButtonName] = objInFor[conButtonTab.ButtonName];
objDR[conButtonTab.Text] = objInFor[conButtonTab.Text];
objDR[conButtonTab.CommandName] = objInFor[conButtonTab.CommandName];
objDR[conButtonTab.Height] = objInFor[conButtonTab.Height];
objDR[conButtonTab.Width] = objInFor[conButtonTab.Width];
objDR[conButtonTab.CssClass] = objInFor[conButtonTab.CssClass];
objDR[conButtonTab.ImageUrl] = objInFor[conButtonTab.ImageUrl];
objDR[conButtonTab.InUse] = objInFor[conButtonTab.InUse];
objDR[conButtonTab.OrderNum] = objInFor[conButtonTab.OrderNum];
objDR[conButtonTab.UpdUser] = objInFor[conButtonTab.UpdUser];
objDR[conButtonTab.UpdDate] = objInFor[conButtonTab.UpdDate];
objDR[conButtonTab.Memo] = objInFor[conButtonTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 按钮(ButtonTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ButtonTab : clsCommFun4BL
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
clsButtonTabWApi.ReFreshThisCache();
}
}

}