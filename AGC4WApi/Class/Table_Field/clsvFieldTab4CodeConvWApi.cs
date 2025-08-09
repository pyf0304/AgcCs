
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4CodeConvWApi
 表名:vFieldTab4CodeConv(00050594)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvFieldTab4CodeConvWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetFldName(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab4CodeConv.FldName);
objvFieldTab4CodeConvEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.FldName) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.FldName, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.FldName] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetFldId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab4CodeConv.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab4CodeConv.FldId);
objvFieldTab4CodeConvEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.FldId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.FldId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.FldId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetPrjId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab4CodeConv.PrjId);
objvFieldTab4CodeConvEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.PrjId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.PrjId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.PrjId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabId">代码表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convFieldTab4CodeConv.CodeTabId);
objvFieldTab4CodeConvEN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabNameId">代码_名Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabNameId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convFieldTab4CodeConv.CodeTabNameId);
objvFieldTab4CodeConvEN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabNameId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabNameId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabNameId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCodeId">代码Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabCodeId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabCodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convFieldTab4CodeConv.CodeTabCodeId);
objvFieldTab4CodeConvEN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabCodeId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabCodeId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCodeId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetUpdDate(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab4CodeConv.UpdDate);
objvFieldTab4CodeConvEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.UpdDate) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.UpdDate, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.UpdDate] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetUpdUser(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab4CodeConv.UpdUser);
objvFieldTab4CodeConvEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.UpdUser) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.UpdUser, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.UpdUser] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetMemo(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab4CodeConv.Memo);
objvFieldTab4CodeConvEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.Memo) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.Memo, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.Memo] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTab">代码表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTab(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convFieldTab4CodeConv.CodeTab);
objvFieldTab4CodeConvEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTab) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTab, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTab] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabName(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabName, 100, convFieldTab4CodeConv.CodeTabName);
objvFieldTab4CodeConvEN.CodeTabName = strCodeTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabName) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabName, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabName] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCode">代码表_代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabCode(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convFieldTab4CodeConv.CodeTabCode);
objvFieldTab4CodeConvEN.CodeTabCode = strCodeTabCode; //代码表_代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabCode) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabCode, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCode] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.FldName, objvFieldTab4CodeConvCond.FldName, strComparisonOpFldName);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.FldId, objvFieldTab4CodeConvCond.FldId, strComparisonOpFldId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.PrjId, objvFieldTab4CodeConvCond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabId, objvFieldTab4CodeConvCond.CodeTabId, strComparisonOpCodeTabId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabNameId, objvFieldTab4CodeConvCond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabCodeId, objvFieldTab4CodeConvCond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.UpdDate, objvFieldTab4CodeConvCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.UpdUser, objvFieldTab4CodeConvCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.Memo) == true)
{
string strComparisonOpMemo = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.Memo, objvFieldTab4CodeConvCond.Memo, strComparisonOpMemo);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTab) == true)
{
string strComparisonOpCodeTab = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTab, objvFieldTab4CodeConvCond.CodeTab, strComparisonOpCodeTab);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabName, objvFieldTab4CodeConvCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabCode, objvFieldTab4CodeConvCond.CodeTabCode, strComparisonOpCodeTabCode);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab4CodeConvWApi
{
private static readonly string mstrApiControllerName = "vFieldTab4CodeConvApi";

 public clsvFieldTab4CodeConvWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4CodeConvEN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFieldTab4CodeConvEN = JsonConvert.DeserializeObject<clsvFieldTab4CodeConvEN>(strJson);
return objvFieldTab4CodeConvEN;
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
public static clsvFieldTab4CodeConvEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN;
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
objvFieldTab4CodeConvEN = JsonConvert.DeserializeObject<clsvFieldTab4CodeConvEN>(strJson);
return objvFieldTab4CodeConvEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4CodeConvEN GetObjByFldIdCache(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = GetObjLstCache();
IEnumerable <clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLst_Sel =
from objvFieldTab4CodeConvEN in arrvFieldTab4CodeConvObjLstCache
where objvFieldTab4CodeConvEN.FldId == strFldId 
select objvFieldTab4CodeConvEN;
if (arrvFieldTab4CodeConvObjLst_Sel.Count() == 0)
{
   clsvFieldTab4CodeConvEN obj = clsvFieldTab4CodeConvWApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTab4CodeConvObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
 /// <param name = "arrFldId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
string strAction = "GetObjLstByFldIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
 /// <param name = "arrFldId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFieldTab4CodeConvEN> GetObjLstByFldIdLstCache(List<string> arrFldId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = GetObjLstCache();
IEnumerable <clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLst_Sel =
from objvFieldTab4CodeConvEN in arrvFieldTab4CodeConvObjLstCache
where arrFldId.Contains(objvFieldTab4CodeConvEN.FldId)
select objvFieldTab4CodeConvEN;
return arrvFieldTab4CodeConvObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4CodeConvEN>>(strJson);
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
public static bool IsExist(string strFldId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId
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
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objvFieldTab4CodeConvENT">目标对象</param>
 public static void CopyTo(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS, clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT)
{
try
{
objvFieldTab4CodeConvENT.FldName = objvFieldTab4CodeConvENS.FldName; //字段名
objvFieldTab4CodeConvENT.FldId = objvFieldTab4CodeConvENS.FldId; //字段Id
objvFieldTab4CodeConvENT.PrjId = objvFieldTab4CodeConvENS.PrjId; //工程Id
objvFieldTab4CodeConvENT.CodeTabId = objvFieldTab4CodeConvENS.CodeTabId; //代码表Id
objvFieldTab4CodeConvENT.CodeTabNameId = objvFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objvFieldTab4CodeConvENT.CodeTabCodeId = objvFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objvFieldTab4CodeConvENT.UpdDate = objvFieldTab4CodeConvENS.UpdDate; //修改日期
objvFieldTab4CodeConvENT.UpdUser = objvFieldTab4CodeConvENS.UpdUser; //修改者
objvFieldTab4CodeConvENT.Memo = objvFieldTab4CodeConvENS.Memo; //说明
objvFieldTab4CodeConvENT.CodeTab = objvFieldTab4CodeConvENS.CodeTab; //代码表
objvFieldTab4CodeConvENT.CodeTabName = objvFieldTab4CodeConvENS.CodeTabName; //表名
objvFieldTab4CodeConvENT.CodeTabCode = objvFieldTab4CodeConvENS.CodeTabCode; //代码表_代码
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
public static DataTable ToDataTable(List<clsvFieldTab4CodeConvEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTab4CodeConvEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTab4CodeConvEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTab4CodeConvEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTab4CodeConvEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTab4CodeConvEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4CodeConvWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4CodeConvWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4CodeConvWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4CodeConvWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTab4CodeConvEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTab4CodeConvEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFieldTab4CodeConv.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTab4CodeConvObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstCacheFromObjLst(List<clsvFieldTab4CodeConvEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4CodeConvWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4CodeConvWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFieldTab4CodeConvObjLstCache = CacheHelper.Get<List<clsvFieldTab4CodeConvEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFieldTab4CodeConvObjLstCache = CacheHelper.Get<List<clsvFieldTab4CodeConvEN>>(strKey);
}
return arrvFieldTab4CodeConvObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTab4CodeConvEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab4CodeConv.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTabNameId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTabCodeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTabName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4CodeConv.CodeTabCode, Type.GetType("System.String"));
foreach (clsvFieldTab4CodeConvEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab4CodeConv.FldName] = objInFor[convFieldTab4CodeConv.FldName];
objDR[convFieldTab4CodeConv.FldId] = objInFor[convFieldTab4CodeConv.FldId];
objDR[convFieldTab4CodeConv.PrjId] = objInFor[convFieldTab4CodeConv.PrjId];
objDR[convFieldTab4CodeConv.CodeTabId] = objInFor[convFieldTab4CodeConv.CodeTabId];
objDR[convFieldTab4CodeConv.CodeTabNameId] = objInFor[convFieldTab4CodeConv.CodeTabNameId];
objDR[convFieldTab4CodeConv.CodeTabCodeId] = objInFor[convFieldTab4CodeConv.CodeTabCodeId];
objDR[convFieldTab4CodeConv.UpdDate] = objInFor[convFieldTab4CodeConv.UpdDate];
objDR[convFieldTab4CodeConv.UpdUser] = objInFor[convFieldTab4CodeConv.UpdUser];
objDR[convFieldTab4CodeConv.Memo] = objInFor[convFieldTab4CodeConv.Memo];
objDR[convFieldTab4CodeConv.CodeTab] = objInFor[convFieldTab4CodeConv.CodeTab];
objDR[convFieldTab4CodeConv.CodeTabName] = objInFor[convFieldTab4CodeConv.CodeTabName];
objDR[convFieldTab4CodeConv.CodeTabCode] = objInFor[convFieldTab4CodeConv.CodeTabCode];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}