
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityWApi
 表名:SetFieldVisibility(00050242)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsSetFieldVisibilityWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetmId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, long lngmId, string strComparisonOp="")
	{
objSetFieldVisibilityEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.mId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.mId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.mId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdSchool">学校流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetIdSchool(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strIdSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conSetFieldVisibility.IdSchool);
objSetFieldVisibilityEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.IdSchool) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.IdSchool, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.IdSchool] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conSetFieldVisibility.UserId);
objSetFieldVisibilityEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetViewName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 100, conSetFieldVisibility.ViewName);
objSetFieldVisibilityEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.ViewName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.ViewName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.ViewName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFieldName(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldName, conSetFieldVisibility.FieldName);
clsCheckSql.CheckFieldLen(strFieldName, 50, conSetFieldVisibility.FieldName);
objSetFieldVisibilityEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FieldName) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FieldName, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FieldName] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCaption(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, conSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, conSetFieldVisibility.Caption);
objSetFieldVisibilityEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Caption) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Caption, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Caption] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtrlType">控件类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetCtrlType(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, conSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(strCtrlType, 50, conSetFieldVisibility.CtrlType);
objSetFieldVisibilityEN.CtrlType = strCtrlType; //控件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.CtrlType) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.CtrlType, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.CtrlType] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetIsVisible(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, bool bolIsVisible, string strComparisonOp="")
	{
objSetFieldVisibilityEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.IsVisible) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.IsVisible, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.IsVisible] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdDate(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSetFieldVisibility.UpdDate);
objSetFieldVisibilityEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdDate) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdDate, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdDate] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetUpdUserId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSetFieldVisibility.UpdUserId);
objSetFieldVisibilityEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.UpdUserId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.UpdUserId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.UpdUserId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetMemo(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSetFieldVisibility.Memo);
objSetFieldVisibilityEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.Memo) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.Memo, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.Memo] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">FuncModuleId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSetFieldVisibilityEN SetFuncModuleId(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 8, conSetFieldVisibility.FuncModuleId);
objSetFieldVisibilityEN.FuncModuleId = strFuncModuleId; //FuncModuleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(conSetFieldVisibility.FuncModuleId) == false)
{
objSetFieldVisibilityEN.dicFldComparisonOp.Add(conSetFieldVisibility.FuncModuleId, strComparisonOp);
}
else
{
objSetFieldVisibilityEN.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId] = strComparisonOp;
}
}
return objSetFieldVisibilityEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.mId) == true)
{
string strComparisonOpmId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSetFieldVisibility.mId, objSetFieldVisibilityCond.mId, strComparisonOpmId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.IdSchool) == true)
{
string strComparisonOpIdSchool = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.IdSchool, objSetFieldVisibilityCond.IdSchool, strComparisonOpIdSchool);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UserId) == true)
{
string strComparisonOpUserId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UserId, objSetFieldVisibilityCond.UserId, strComparisonOpUserId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.ViewName) == true)
{
string strComparisonOpViewName = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.ViewName, objSetFieldVisibilityCond.ViewName, strComparisonOpViewName);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.FieldName) == true)
{
string strComparisonOpFieldName = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FieldName, objSetFieldVisibilityCond.FieldName, strComparisonOpFieldName);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.Caption) == true)
{
string strComparisonOpCaption = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Caption, objSetFieldVisibilityCond.Caption, strComparisonOpCaption);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.CtrlType) == true)
{
string strComparisonOpCtrlType = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.CtrlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.CtrlType, objSetFieldVisibilityCond.CtrlType, strComparisonOpCtrlType);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.IsVisible) == true)
{
if (objSetFieldVisibilityCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSetFieldVisibility.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSetFieldVisibility.IsVisible);
}
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UpdDate) == true)
{
string strComparisonOpUpdDate = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdDate, objSetFieldVisibilityCond.UpdDate, strComparisonOpUpdDate);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.UpdUserId, objSetFieldVisibilityCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.Memo) == true)
{
string strComparisonOpMemo = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.Memo, objSetFieldVisibilityCond.Memo, strComparisonOpMemo);
}
if (objSetFieldVisibilityCond.IsUpdated(conSetFieldVisibility.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objSetFieldVisibilityCond.dicFldComparisonOp[conSetFieldVisibility.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSetFieldVisibility.FuncModuleId, objSetFieldVisibilityCond.FuncModuleId, strComparisonOpFuncModuleId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
 if (objSetFieldVisibilityEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSetFieldVisibilityEN.sfUpdFldSetStr = objSetFieldVisibilityEN.getsfUpdFldSetStr();
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.UpdateRecord(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--SetFieldVisibility(设置字段可视性), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_School_UserId_ViewName_FieldName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSetFieldVisibilityEN == null) return "";
if (objSetFieldVisibilityEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSetFieldVisibilityEN.mId);
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objSetFieldVisibilityEN.IdSchool);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSetFieldVisibilityEN.UserId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
try
{
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.AddNewRecord(objSetFieldVisibilityEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
try
{
clsSetFieldVisibilityWApi.CheckPropertyNew(objSetFieldVisibilityEN); 
bool bolResult = clsSetFieldVisibilityWApi.UpdateWithCondition(objSetFieldVisibilityEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSetFieldVisibilityWApi
{
private static readonly string mstrApiControllerName = "SetFieldVisibilityApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsSetFieldVisibilityWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
if (!Object.Equals(null, objSetFieldVisibilityEN.IdSchool) && GetStrLen(objSetFieldVisibilityEN.IdSchool) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UserId) && GetStrLen(objSetFieldVisibilityEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.ViewName) && GetStrLen(objSetFieldVisibilityEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FieldName) && GetStrLen(objSetFieldVisibilityEN.FieldName) > 50)
{
 throw new Exception("字段[字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Caption) && GetStrLen(objSetFieldVisibilityEN.Caption) > 200)
{
 throw new Exception("字段[标题]的长度不能超过200!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.CtrlType) && GetStrLen(objSetFieldVisibilityEN.CtrlType) > 50)
{
 throw new Exception("字段[控件类型]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdDate) && GetStrLen(objSetFieldVisibilityEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdUserId) && GetStrLen(objSetFieldVisibilityEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Memo) && GetStrLen(objSetFieldVisibilityEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FuncModuleId) && GetStrLen(objSetFieldVisibilityEN.FuncModuleId) > 8)
{
 throw new Exception("字段[FuncModuleId]的长度不能超过8!");
}
 objSetFieldVisibilityEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSetFieldVisibilityEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsSetFieldVisibilityEN objSetFieldVisibilityEN;
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
objSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsSetFieldVisibilityEN>(strJson);
return objSetFieldVisibilityEN;
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
public static clsSetFieldVisibilityEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSetFieldVisibilityEN objSetFieldVisibilityEN;
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
objSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsSetFieldVisibilityEN>(strJson);
return objSetFieldVisibilityEN;
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
public static List<clsSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static List<clsSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSetFieldVisibilityEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsSetFieldVisibilityEN objSetFieldVisibilityEN = clsSetFieldVisibilityWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelSetFieldVisibilitys(List<string> arrmId)
{
string strAction = "DelSetFieldVisibilitys";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSetFieldVisibilitysByCond(string strWhereCond)
{
string strAction = "DelSetFieldVisibilitysByCond";
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
public static bool AddNewRecord(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
if (string.IsNullOrEmpty(objSetFieldVisibilityEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
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
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSetFieldVisibilityEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSetFieldVisibilityEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSetFieldVisibilityEN>(objSetFieldVisibilityEN);
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
 /// <param name = "objSetFieldVisibilityENS">源对象</param>
 /// <param name = "objSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(clsSetFieldVisibilityEN objSetFieldVisibilityENS, clsSetFieldVisibilityEN objSetFieldVisibilityENT)
{
try
{
objSetFieldVisibilityENT.mId = objSetFieldVisibilityENS.mId; //mId
objSetFieldVisibilityENT.IdSchool = objSetFieldVisibilityENS.IdSchool; //学校流水号
objSetFieldVisibilityENT.UserId = objSetFieldVisibilityENS.UserId; //用户Id
objSetFieldVisibilityENT.ViewName = objSetFieldVisibilityENS.ViewName; //界面名称
objSetFieldVisibilityENT.FieldName = objSetFieldVisibilityENS.FieldName; //字段名
objSetFieldVisibilityENT.Caption = objSetFieldVisibilityENS.Caption; //标题
objSetFieldVisibilityENT.CtrlType = objSetFieldVisibilityENS.CtrlType; //控件类型
objSetFieldVisibilityENT.IsVisible = objSetFieldVisibilityENS.IsVisible; //是否显示
objSetFieldVisibilityENT.UpdDate = objSetFieldVisibilityENS.UpdDate; //修改日期
objSetFieldVisibilityENT.UpdUserId = objSetFieldVisibilityENS.UpdUserId; //修改用户Id
objSetFieldVisibilityENT.Memo = objSetFieldVisibilityENS.Memo; //说明
objSetFieldVisibilityENT.FuncModuleId = objSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
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
public static DataTable ToDataTable(List<clsSetFieldVisibilityEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSetFieldVisibilityEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSetFieldVisibilityEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSetFieldVisibilityEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSetFieldVisibilityEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSetFieldVisibilityEN._AttributeName)
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
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
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
if (clsSetFieldVisibilityWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSetFieldVisibilityEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSetFieldVisibilityWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsSetFieldVisibilityEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSetFieldVisibility.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conSetFieldVisibility.IdSchool, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.Caption, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.CtrlType, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSetFieldVisibility.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conSetFieldVisibility.FuncModuleId, Type.GetType("System.String"));
foreach (clsSetFieldVisibilityEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSetFieldVisibility.mId] = objInFor[conSetFieldVisibility.mId];
objDR[conSetFieldVisibility.IdSchool] = objInFor[conSetFieldVisibility.IdSchool];
objDR[conSetFieldVisibility.UserId] = objInFor[conSetFieldVisibility.UserId];
objDR[conSetFieldVisibility.ViewName] = objInFor[conSetFieldVisibility.ViewName];
objDR[conSetFieldVisibility.FieldName] = objInFor[conSetFieldVisibility.FieldName];
objDR[conSetFieldVisibility.Caption] = objInFor[conSetFieldVisibility.Caption];
objDR[conSetFieldVisibility.CtrlType] = objInFor[conSetFieldVisibility.CtrlType];
objDR[conSetFieldVisibility.IsVisible] = objInFor[conSetFieldVisibility.IsVisible];
objDR[conSetFieldVisibility.UpdDate] = objInFor[conSetFieldVisibility.UpdDate];
objDR[conSetFieldVisibility.UpdUserId] = objInFor[conSetFieldVisibility.UpdUserId];
objDR[conSetFieldVisibility.Memo] = objInFor[conSetFieldVisibility.Memo];
objDR[conSetFieldVisibility.FuncModuleId] = objInFor[conSetFieldVisibility.FuncModuleId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SetFieldVisibility : clsCommFun4BL
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
clsSetFieldVisibilityWApi.ReFreshThisCache();
}
}

}