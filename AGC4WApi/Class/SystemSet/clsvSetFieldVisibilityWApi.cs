
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityWApi
 表名:vSetFieldVisibility(00050243)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:41
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
public static class  clsvSetFieldVisibilityWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleEnName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convSetFieldVisibility.FuncModuleEnName);
objvSetFieldVisibilityEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleEnName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleEnName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleEnName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">功能模块简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleNameSim(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convSetFieldVisibility.FuncModuleNameSim);
objvSetFieldVisibilityEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleNameSim) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleNameSim, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleNameSim] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetmId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, long lngmId, string strComparisonOp="")
	{
objvSetFieldVisibilityEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.mId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.mId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.mId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdSchool">学校流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetIdSchool(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strIdSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convSetFieldVisibility.IdSchool);
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convSetFieldVisibility.IdSchool);
objvSetFieldVisibilityEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.IdSchool) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.IdSchool, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.IdSchool] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolId">学校Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convSetFieldVisibility.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 20, convSetFieldVisibility.SchoolId);
objvSetFieldVisibilityEN.SchoolId = strSchoolId; //学校Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.SchoolId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.SchoolId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.SchoolId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolName">学校名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convSetFieldVisibility.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convSetFieldVisibility.SchoolName);
objvSetFieldVisibilityEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.SchoolName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.SchoolName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.SchoolName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetViewName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 100, convSetFieldVisibility.ViewName);
objvSetFieldVisibilityEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.ViewName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.ViewName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.ViewName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFieldName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldName, 50, convSetFieldVisibility.FieldName);
objvSetFieldVisibilityEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FieldName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FieldName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FieldName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCaption(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convSetFieldVisibility.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convSetFieldVisibility.Caption);
objvSetFieldVisibilityEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.Caption) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.Caption, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.Caption] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtrlType">控件类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCtrlType(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, convSetFieldVisibility.CtrlType);
clsCheckSql.CheckFieldLen(strCtrlType, 50, convSetFieldVisibility.CtrlType);
objvSetFieldVisibilityEN.CtrlType = strCtrlType; //控件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.CtrlType) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.CtrlType, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.CtrlType] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetIsVisible(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, bool bolIsVisible, string strComparisonOp="")
	{
objvSetFieldVisibilityEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.IsVisible) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.IsVisible, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.IsVisible] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdDate(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSetFieldVisibility.UpdDate);
objvSetFieldVisibilityEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.UpdDate) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.UpdDate, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.UpdDate] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdUserId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSetFieldVisibility.UpdUserId);
objvSetFieldVisibilityEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.UpdUserId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.UpdUserId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.UpdUserId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetMemo(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSetFieldVisibility.Memo);
objvSetFieldVisibilityEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.Memo) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.Memo, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.Memo] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">FuncModuleId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 8, convSetFieldVisibility.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 8, convSetFieldVisibility.FuncModuleId);
objvSetFieldVisibilityEN.FuncModuleId = strFuncModuleId; //FuncModuleId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleId) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleId, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleId] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convSetFieldVisibility.FuncModuleName);
objvSetFieldVisibilityEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSetFieldVisibilityEN.dicFldComparisonOp.ContainsKey(convSetFieldVisibility.FuncModuleName) == false)
{
objvSetFieldVisibilityEN.dicFldComparisonOp.Add(convSetFieldVisibility.FuncModuleName, strComparisonOp);
}
else
{
objvSetFieldVisibilityEN.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName] = strComparisonOp;
}
}
return objvSetFieldVisibilityEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSetFieldVisibilityEN objvSetFieldVisibilityCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleEnName, objvSetFieldVisibilityCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleNameSim, objvSetFieldVisibilityCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.mId) == true)
{
string strComparisonOpmId = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSetFieldVisibility.mId, objvSetFieldVisibilityCond.mId, strComparisonOpmId);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.IdSchool) == true)
{
string strComparisonOpIdSchool = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.IdSchool, objvSetFieldVisibilityCond.IdSchool, strComparisonOpIdSchool);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.SchoolId) == true)
{
string strComparisonOpSchoolId = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.SchoolId, objvSetFieldVisibilityCond.SchoolId, strComparisonOpSchoolId);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.SchoolName) == true)
{
string strComparisonOpSchoolName = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.SchoolName, objvSetFieldVisibilityCond.SchoolName, strComparisonOpSchoolName);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.ViewName) == true)
{
string strComparisonOpViewName = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.ViewName, objvSetFieldVisibilityCond.ViewName, strComparisonOpViewName);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.FieldName) == true)
{
string strComparisonOpFieldName = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FieldName, objvSetFieldVisibilityCond.FieldName, strComparisonOpFieldName);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.Caption) == true)
{
string strComparisonOpCaption = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.Caption, objvSetFieldVisibilityCond.Caption, strComparisonOpCaption);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.CtrlType) == true)
{
string strComparisonOpCtrlType = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.CtrlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.CtrlType, objvSetFieldVisibilityCond.CtrlType, strComparisonOpCtrlType);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.IsVisible) == true)
{
if (objvSetFieldVisibilityCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSetFieldVisibility.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSetFieldVisibility.IsVisible);
}
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.UpdDate, objvSetFieldVisibilityCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.UpdUserId, objvSetFieldVisibilityCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.Memo) == true)
{
string strComparisonOpMemo = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.Memo, objvSetFieldVisibilityCond.Memo, strComparisonOpMemo);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleId, objvSetFieldVisibilityCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvSetFieldVisibilityCond.IsUpdated(convSetFieldVisibility.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvSetFieldVisibilityCond.dicFldComparisonOp[convSetFieldVisibility.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSetFieldVisibility.FuncModuleName, objvSetFieldVisibilityCond.FuncModuleName, strComparisonOpFuncModuleName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSetFieldVisibilityWApi
{
private static readonly string mstrApiControllerName = "vSetFieldVisibilityApi";

 public clsvSetFieldVisibilityWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN;
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
objvSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsvSetFieldVisibilityEN>(strJson);
return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN;
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
objvSetFieldVisibilityEN = JsonConvert.DeserializeObject<clsvSetFieldVisibilityEN>(strJson);
return objvSetFieldVisibilityEN;
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
public static List<clsvSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
public static List<clsvSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSetFieldVisibilityEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSetFieldVisibilityEN>>(strJson);
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
 /// <param name = "objvSetFieldVisibilityENS">源对象</param>
 /// <param name = "objvSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(clsvSetFieldVisibilityEN objvSetFieldVisibilityENS, clsvSetFieldVisibilityEN objvSetFieldVisibilityENT)
{
try
{
objvSetFieldVisibilityENT.FuncModuleEnName = objvSetFieldVisibilityENS.FuncModuleEnName; //功能模块英文名称
objvSetFieldVisibilityENT.FuncModuleNameSim = objvSetFieldVisibilityENS.FuncModuleNameSim; //功能模块简称
objvSetFieldVisibilityENT.mId = objvSetFieldVisibilityENS.mId; //mId
objvSetFieldVisibilityENT.IdSchool = objvSetFieldVisibilityENS.IdSchool; //学校流水号
objvSetFieldVisibilityENT.SchoolId = objvSetFieldVisibilityENS.SchoolId; //学校Id
objvSetFieldVisibilityENT.SchoolName = objvSetFieldVisibilityENS.SchoolName; //学校名称
objvSetFieldVisibilityENT.ViewName = objvSetFieldVisibilityENS.ViewName; //界面名称
objvSetFieldVisibilityENT.FieldName = objvSetFieldVisibilityENS.FieldName; //字段名
objvSetFieldVisibilityENT.Caption = objvSetFieldVisibilityENS.Caption; //标题
objvSetFieldVisibilityENT.CtrlType = objvSetFieldVisibilityENS.CtrlType; //控件类型
objvSetFieldVisibilityENT.IsVisible = objvSetFieldVisibilityENS.IsVisible; //是否显示
objvSetFieldVisibilityENT.UpdDate = objvSetFieldVisibilityENS.UpdDate; //修改日期
objvSetFieldVisibilityENT.UpdUserId = objvSetFieldVisibilityENS.UpdUserId; //修改用户Id
objvSetFieldVisibilityENT.Memo = objvSetFieldVisibilityENS.Memo; //说明
objvSetFieldVisibilityENT.FuncModuleId = objvSetFieldVisibilityENS.FuncModuleId; //FuncModuleId
objvSetFieldVisibilityENT.FuncModuleName = objvSetFieldVisibilityENS.FuncModuleName; //功能模块名称
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
public static DataTable ToDataTable(List<clsvSetFieldVisibilityEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSetFieldVisibilityEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSetFieldVisibilityEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSetFieldVisibilityEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSetFieldVisibilityEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSetFieldVisibilityEN._AttributeName)
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
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSetFieldVisibilityEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSetFieldVisibility.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSetFieldVisibility.IdSchool, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.CtrlType, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSetFieldVisibility.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convSetFieldVisibility.FuncModuleName, Type.GetType("System.String"));
foreach (clsvSetFieldVisibilityEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSetFieldVisibility.FuncModuleEnName] = objInFor[convSetFieldVisibility.FuncModuleEnName];
objDR[convSetFieldVisibility.FuncModuleNameSim] = objInFor[convSetFieldVisibility.FuncModuleNameSim];
objDR[convSetFieldVisibility.mId] = objInFor[convSetFieldVisibility.mId];
objDR[convSetFieldVisibility.IdSchool] = objInFor[convSetFieldVisibility.IdSchool];
objDR[convSetFieldVisibility.SchoolId] = objInFor[convSetFieldVisibility.SchoolId];
objDR[convSetFieldVisibility.SchoolName] = objInFor[convSetFieldVisibility.SchoolName];
objDR[convSetFieldVisibility.ViewName] = objInFor[convSetFieldVisibility.ViewName];
objDR[convSetFieldVisibility.FieldName] = objInFor[convSetFieldVisibility.FieldName];
objDR[convSetFieldVisibility.Caption] = objInFor[convSetFieldVisibility.Caption];
objDR[convSetFieldVisibility.CtrlType] = objInFor[convSetFieldVisibility.CtrlType];
objDR[convSetFieldVisibility.IsVisible] = objInFor[convSetFieldVisibility.IsVisible];
objDR[convSetFieldVisibility.UpdDate] = objInFor[convSetFieldVisibility.UpdDate];
objDR[convSetFieldVisibility.UpdUserId] = objInFor[convSetFieldVisibility.UpdUserId];
objDR[convSetFieldVisibility.Memo] = objInFor[convSetFieldVisibility.Memo];
objDR[convSetFieldVisibility.FuncModuleId] = objInFor[convSetFieldVisibility.FuncModuleId];
objDR[convSetFieldVisibility.FuncModuleName] = objInFor[convSetFieldVisibility.FuncModuleName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}