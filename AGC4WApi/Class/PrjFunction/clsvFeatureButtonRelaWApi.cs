
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureButtonRelaWApi
 表名:vFeatureButtonRela(00050428)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:52
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
public static class  clsvFeatureButtonRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetmId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureButtonRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.mId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.mId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.mId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureButtonRela.ApplicationTypeId);
objvFeatureButtonRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convFeatureButtonRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureButtonRela.ApplicationTypeName);
objvFeatureButtonRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeENName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convFeatureButtonRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convFeatureButtonRela.ApplicationTypeENName);
objvFeatureButtonRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeENName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureButtonRela.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureButtonRela.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureButtonRela.FeatureId);
objvFeatureButtonRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureButtonRela.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureButtonRela.FeatureName);
objvFeatureButtonRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureTypeName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureButtonRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureButtonRela.FeatureTypeName);
objvFeatureButtonRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureTypeName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonId">按钮Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetButtonId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strButtonId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonId, convFeatureButtonRela.ButtonId);
clsCheckSql.CheckFieldLen(strButtonId, 2, convFeatureButtonRela.ButtonId);
clsCheckSql.CheckFieldForeignKey(strButtonId, 2, convFeatureButtonRela.ButtonId);
objvFeatureButtonRelaEN.ButtonId = strButtonId; //按钮Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ButtonId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ButtonId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ButtonId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strButtonName">按钮名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetButtonName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureButtonRela.ButtonName);
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureButtonRela.ButtonName);
objvFeatureButtonRelaEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ButtonName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ButtonName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ButtonName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strText">文本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetText(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureButtonRela.Text);
clsCheckSql.CheckFieldLen(strText, 30, convFeatureButtonRela.Text);
objvFeatureButtonRelaEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.Text) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.Text, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.Text] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetOrderNum(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFeatureButtonRela.OrderNum);
objvFeatureButtonRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.OrderNum) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strEventFuncName">事件函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetEventFuncName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strEventFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureButtonRela.EventFuncName);
objvFeatureButtonRelaEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.EventFuncName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.EventFuncName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.EventFuncName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetUpdDate(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureButtonRela.UpdDate);
objvFeatureButtonRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.UpdDate) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetUpdUser(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureButtonRela.UpdUser);
objvFeatureButtonRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.UpdUser) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetMemo(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureButtonRela.Memo);
objvFeatureButtonRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.Memo) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.Memo, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.Memo] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureButtonRelaEN objvFeatureButtonRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.mId) == true)
{
string strComparisonOpmId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.mId, objvFeatureButtonRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.ApplicationTypeId, objvFeatureButtonRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ApplicationTypeName, objvFeatureButtonRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ApplicationTypeENName, objvFeatureButtonRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureId, objvFeatureButtonRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureName, objvFeatureButtonRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureTypeName, objvFeatureButtonRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ButtonId) == true)
{
string strComparisonOpButtonId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ButtonId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ButtonId, objvFeatureButtonRelaCond.ButtonId, strComparisonOpButtonId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ButtonName) == true)
{
string strComparisonOpButtonName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ButtonName, objvFeatureButtonRelaCond.ButtonName, strComparisonOpButtonName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.Text) == true)
{
string strComparisonOpText = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.Text, objvFeatureButtonRelaCond.Text, strComparisonOpText);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.OrderNum, objvFeatureButtonRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.EventFuncName, objvFeatureButtonRelaCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.UpdDate, objvFeatureButtonRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.UpdUser, objvFeatureButtonRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.Memo, objvFeatureButtonRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能按钮关系(vFeatureButtonRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureButtonRelaWApi
{
private static readonly string mstrApiControllerName = "vFeatureButtonRelaApi";

 public clsvFeatureButtonRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureButtonRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFeatureButtonRelaEN objvFeatureButtonRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFeatureButtonRelaEN = JsonConvert.DeserializeObject<clsvFeatureButtonRelaEN>(strJson);
return objvFeatureButtonRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvFeatureButtonRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureButtonRelaEN objvFeatureButtonRelaEN;
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
objvFeatureButtonRelaEN = JsonConvert.DeserializeObject<clsvFeatureButtonRelaEN>(strJson);
return objvFeatureButtonRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureButtonRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel =
from objvFeatureButtonRelaEN in arrvFeatureButtonRelaObjLstCache
where objvFeatureButtonRelaEN.mId == lngmId 
select objvFeatureButtonRelaEN;
if (arrvFeatureButtonRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureButtonRelaEN obj = clsvFeatureButtonRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFeatureButtonRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFeatureButtonRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel =
from objvFeatureButtonRelaEN in arrvFeatureButtonRelaObjLstCache
where arrMId.Contains(objvFeatureButtonRelaEN.mId)
select objvFeatureButtonRelaEN;
return arrvFeatureButtonRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureButtonRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureButtonRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvFeatureButtonRelaENS">源对象</param>
 /// <param name = "objvFeatureButtonRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureButtonRelaEN objvFeatureButtonRelaENS, clsvFeatureButtonRelaEN objvFeatureButtonRelaENT)
{
try
{
objvFeatureButtonRelaENT.mId = objvFeatureButtonRelaENS.mId; //mId
objvFeatureButtonRelaENT.ApplicationTypeId = objvFeatureButtonRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureButtonRelaENT.ApplicationTypeName = objvFeatureButtonRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureButtonRelaENT.ApplicationTypeENName = objvFeatureButtonRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureButtonRelaENT.FeatureId = objvFeatureButtonRelaENS.FeatureId; //功能Id
objvFeatureButtonRelaENT.FeatureName = objvFeatureButtonRelaENS.FeatureName; //功能名称
objvFeatureButtonRelaENT.FeatureTypeName = objvFeatureButtonRelaENS.FeatureTypeName; //功能类型名称
objvFeatureButtonRelaENT.ButtonId = objvFeatureButtonRelaENS.ButtonId; //按钮Id
objvFeatureButtonRelaENT.ButtonName = objvFeatureButtonRelaENS.ButtonName; //按钮名称
objvFeatureButtonRelaENT.Text = objvFeatureButtonRelaENS.Text; //文本
objvFeatureButtonRelaENT.OrderNum = objvFeatureButtonRelaENS.OrderNum; //序号
objvFeatureButtonRelaENT.EventFuncName = objvFeatureButtonRelaENS.EventFuncName; //事件函数名
objvFeatureButtonRelaENT.UpdDate = objvFeatureButtonRelaENS.UpdDate; //修改日期
objvFeatureButtonRelaENT.UpdUser = objvFeatureButtonRelaENS.UpdUser; //修改者
objvFeatureButtonRelaENT.Memo = objvFeatureButtonRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFeatureButtonRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureButtonRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureButtonRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureButtonRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureButtonRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureButtonRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFeatureButtonRelaEN._CurrTabName;
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFeatureButtonRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureButtonRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureButtonRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFeatureButtonRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureButtonRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.ButtonId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.ButtonName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.Text, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureButtonRela.EventFuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureButtonRela.Memo, Type.GetType("System.String"));
foreach (clsvFeatureButtonRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureButtonRela.mId] = objInFor[convFeatureButtonRela.mId];
objDR[convFeatureButtonRela.ApplicationTypeId] = objInFor[convFeatureButtonRela.ApplicationTypeId];
objDR[convFeatureButtonRela.ApplicationTypeName] = objInFor[convFeatureButtonRela.ApplicationTypeName];
objDR[convFeatureButtonRela.ApplicationTypeENName] = objInFor[convFeatureButtonRela.ApplicationTypeENName];
objDR[convFeatureButtonRela.FeatureId] = objInFor[convFeatureButtonRela.FeatureId];
objDR[convFeatureButtonRela.FeatureName] = objInFor[convFeatureButtonRela.FeatureName];
objDR[convFeatureButtonRela.FeatureTypeName] = objInFor[convFeatureButtonRela.FeatureTypeName];
objDR[convFeatureButtonRela.ButtonId] = objInFor[convFeatureButtonRela.ButtonId];
objDR[convFeatureButtonRela.ButtonName] = objInFor[convFeatureButtonRela.ButtonName];
objDR[convFeatureButtonRela.Text] = objInFor[convFeatureButtonRela.Text];
objDR[convFeatureButtonRela.OrderNum] = objInFor[convFeatureButtonRela.OrderNum];
objDR[convFeatureButtonRela.EventFuncName] = objInFor[convFeatureButtonRela.EventFuncName];
objDR[convFeatureButtonRela.UpdDate] = objInFor[convFeatureButtonRela.UpdDate];
objDR[convFeatureButtonRela.UpdUser] = objInFor[convFeatureButtonRela.UpdUser];
objDR[convFeatureButtonRela.Memo] = objInFor[convFeatureButtonRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}