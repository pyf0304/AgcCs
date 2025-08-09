
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityBL
 表名:vSetFieldVisibility(00050243)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvSetFieldVisibilityBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSetFieldVisibilityEN GetObj(this K_mId_vSetFieldVisibility myKey)
{
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = clsvSetFieldVisibilityBL.vSetFieldVisibilityDA.GetObjBymId(myKey.Value);
return objvSetFieldVisibilityEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleEnName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convSetFieldVisibility.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleNameSim(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convSetFieldVisibility.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetIdSchool(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convSetFieldVisibility.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convSetFieldVisibility.IdSchool);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convSetFieldVisibility.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 20, convSetFieldVisibility.SchoolId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetSchoolName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convSetFieldVisibility.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convSetFieldVisibility.SchoolName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetViewName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convSetFieldVisibility.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFieldName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFieldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldName, 50, convSetFieldVisibility.FieldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCaption(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convSetFieldVisibility.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convSetFieldVisibility.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetCtrlType(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strCtrlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtrlType, convSetFieldVisibility.CtrlType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtrlType, 50, convSetFieldVisibility.CtrlType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdDate(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSetFieldVisibility.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetUpdUserId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSetFieldVisibility.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetMemo(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSetFieldVisibility.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleId(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 8, convSetFieldVisibility.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 8, convSetFieldVisibility.FuncModuleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSetFieldVisibilityEN SetFuncModuleName(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convSetFieldVisibility.FuncModuleName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityENS">源对象</param>
 /// <param name = "objvSetFieldVisibilityENT">目标对象</param>
 public static void CopyTo(this clsvSetFieldVisibilityEN objvSetFieldVisibilityENS, clsvSetFieldVisibilityEN objvSetFieldVisibilityENT)
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
 /// <param name = "objvSetFieldVisibilityENS">源对象</param>
 /// <returns>目标对象=>clsvSetFieldVisibilityEN:objvSetFieldVisibilityENT</returns>
 public static clsvSetFieldVisibilityEN CopyTo(this clsvSetFieldVisibilityEN objvSetFieldVisibilityENS)
{
try
{
 clsvSetFieldVisibilityEN objvSetFieldVisibilityENT = new clsvSetFieldVisibilityEN()
{
FuncModuleEnName = objvSetFieldVisibilityENS.FuncModuleEnName, //功能模块英文名称
FuncModuleNameSim = objvSetFieldVisibilityENS.FuncModuleNameSim, //功能模块简称
mId = objvSetFieldVisibilityENS.mId, //mId
IdSchool = objvSetFieldVisibilityENS.IdSchool, //学校流水号
SchoolId = objvSetFieldVisibilityENS.SchoolId, //学校Id
SchoolName = objvSetFieldVisibilityENS.SchoolName, //学校名称
ViewName = objvSetFieldVisibilityENS.ViewName, //界面名称
FieldName = objvSetFieldVisibilityENS.FieldName, //字段名
Caption = objvSetFieldVisibilityENS.Caption, //标题
CtrlType = objvSetFieldVisibilityENS.CtrlType, //控件类型
IsVisible = objvSetFieldVisibilityENS.IsVisible, //是否显示
UpdDate = objvSetFieldVisibilityENS.UpdDate, //修改日期
UpdUserId = objvSetFieldVisibilityENS.UpdUserId, //修改用户Id
Memo = objvSetFieldVisibilityENS.Memo, //说明
FuncModuleId = objvSetFieldVisibilityENS.FuncModuleId, //FuncModuleId
FuncModuleName = objvSetFieldVisibilityENS.FuncModuleName, //功能模块名称
};
 return objvSetFieldVisibilityENT;
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
public static void CheckProperty4Condition(this clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
 clsvSetFieldVisibilityBL.vSetFieldVisibilityDA.CheckProperty4Condition(objvSetFieldVisibilityEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSetFieldVisibility
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSetFieldVisibilityBL
{
public static RelatedActions_vSetFieldVisibility relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSetFieldVisibilityDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSetFieldVisibilityDA vSetFieldVisibilityDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSetFieldVisibilityDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSetFieldVisibilityBL()
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
if (string.IsNullOrEmpty(clsvSetFieldVisibilityEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSetFieldVisibilityEN._ConnectString);
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
public static DataTable GetDataTable_vSetFieldVisibility(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSetFieldVisibilityDA.GetDataTable_vSetFieldVisibility(strWhereCond);
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
objDT = vSetFieldVisibilityDA.GetDataTable(strWhereCond);
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
objDT = vSetFieldVisibilityDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSetFieldVisibilityDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSetFieldVisibilityDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSetFieldVisibilityDA.GetDataTable_Top(objTopPara);
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
objDT = vSetFieldVisibilityDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSetFieldVisibilityDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSetFieldVisibilityDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSetFieldVisibilityEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLstCache = GetObjLstCache();
IEnumerable <clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Sel =
arrvSetFieldVisibilityObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvSetFieldVisibilityObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public static List<clsvSetFieldVisibilityEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSetFieldVisibilityEN> GetSubObjLstCache(clsvSetFieldVisibilityEN objvSetFieldVisibilityCond)
{
List<clsvSetFieldVisibilityEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSetFieldVisibilityEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSetFieldVisibility._AttributeName)
{
if (objvSetFieldVisibilityCond.IsUpdated(strFldName) == false) continue;
if (objvSetFieldVisibilityCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSetFieldVisibilityCond[strFldName].ToString());
}
else
{
if (objvSetFieldVisibilityCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSetFieldVisibilityCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSetFieldVisibilityCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSetFieldVisibilityCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSetFieldVisibilityCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSetFieldVisibilityCond[strFldName]));
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
List<clsvSetFieldVisibilityEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSetFieldVisibilityEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSetFieldVisibilityEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
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
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public static List<clsvSetFieldVisibilityEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
try
{
objvSetFieldVisibilityEN.FuncModuleEnName = objRow[convSetFieldVisibility.FuncModuleEnName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvSetFieldVisibilityEN.FuncModuleNameSim = objRow[convSetFieldVisibility.FuncModuleNameSim] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvSetFieldVisibilityEN.mId = Int32.Parse(objRow[convSetFieldVisibility.mId].ToString().Trim()); //mId
objvSetFieldVisibilityEN.IdSchool = objRow[convSetFieldVisibility.IdSchool] == DBNull.Value ? null : objRow[convSetFieldVisibility.IdSchool].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow[convSetFieldVisibility.SchoolId].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow[convSetFieldVisibility.SchoolName].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow[convSetFieldVisibility.ViewName] == DBNull.Value ? null : objRow[convSetFieldVisibility.ViewName].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.FieldName = objRow[convSetFieldVisibility.FieldName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FieldName].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.Caption = objRow[convSetFieldVisibility.Caption].ToString().Trim(); //标题
objvSetFieldVisibilityEN.CtrlType = objRow[convSetFieldVisibility.CtrlType].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convSetFieldVisibility.IsVisible].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.UpdDate = objRow[convSetFieldVisibility.UpdDate] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdDate].ToString().Trim(); //修改日期
objvSetFieldVisibilityEN.UpdUserId = objRow[convSetFieldVisibility.UpdUserId] == DBNull.Value ? null : objRow[convSetFieldVisibility.UpdUserId].ToString().Trim(); //修改用户Id
objvSetFieldVisibilityEN.Memo = objRow[convSetFieldVisibility.Memo] == DBNull.Value ? null : objRow[convSetFieldVisibility.Memo].ToString().Trim(); //说明
objvSetFieldVisibilityEN.FuncModuleId = objRow[convSetFieldVisibility.FuncModuleId] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleId].ToString().Trim(); //FuncModuleId
objvSetFieldVisibilityEN.FuncModuleName = objRow[convSetFieldVisibility.FuncModuleName] == DBNull.Value ? null : objRow[convSetFieldVisibility.FuncModuleName].ToString().Trim(); //功能模块名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSetFieldVisibilityEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSetFieldVisibilityEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSetFieldVisibility(ref clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
bool bolResult = vSetFieldVisibilityDA.GetvSetFieldVisibility(ref objvSetFieldVisibilityEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymId(long lngmId)
{
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = vSetFieldVisibilityDA.GetObjBymId(lngmId);
return objvSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSetFieldVisibilityEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = vSetFieldVisibilityDA.GetFirstObj(strWhereCond);
 return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = vSetFieldVisibilityDA.GetObjByDataRow(objRow);
 return objvSetFieldVisibilityEN;
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
public static clsvSetFieldVisibilityEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = vSetFieldVisibilityDA.GetObjByDataRow(objRow);
 return objvSetFieldVisibilityEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvSetFieldVisibilityObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymIdFromList(long lngmId, List<clsvSetFieldVisibilityEN> lstvSetFieldVisibilityObjLst)
{
foreach (clsvSetFieldVisibilityEN objvSetFieldVisibilityEN in lstvSetFieldVisibilityObjLst)
{
if (objvSetFieldVisibilityEN.mId == lngmId)
{
return objvSetFieldVisibilityEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvSetFieldVisibilityDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vSetFieldVisibilityDA.GetID(strWhereCond);
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
bool bolIsExist = vSetFieldVisibilityDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vSetFieldVisibilityDA.IsExist(lngmId);
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
 bolIsExist = clsvSetFieldVisibilityDA.IsExistTable();
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
 bolIsExist = vSetFieldVisibilityDA.IsExistTable(strTabName);
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
 /// <param name = "objvSetFieldVisibilityEN">源简化对象</param>
 public static void SetUpdFlag(clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
try
{
objvSetFieldVisibilityEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSetFieldVisibilityEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSetFieldVisibility.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.FuncModuleEnName = objvSetFieldVisibilityEN.FuncModuleEnName == "[null]" ? null :  objvSetFieldVisibilityEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convSetFieldVisibility.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.FuncModuleNameSim = objvSetFieldVisibilityEN.FuncModuleNameSim == "[null]" ? null :  objvSetFieldVisibilityEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convSetFieldVisibility.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.mId = objvSetFieldVisibilityEN.mId; //mId
}
if (arrFldSet.Contains(convSetFieldVisibility.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.IdSchool = objvSetFieldVisibilityEN.IdSchool == "[null]" ? null :  objvSetFieldVisibilityEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convSetFieldVisibility.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.SchoolId = objvSetFieldVisibilityEN.SchoolId; //学校Id
}
if (arrFldSet.Contains(convSetFieldVisibility.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.SchoolName = objvSetFieldVisibilityEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convSetFieldVisibility.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.ViewName = objvSetFieldVisibilityEN.ViewName == "[null]" ? null :  objvSetFieldVisibilityEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convSetFieldVisibility.FieldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.FieldName = objvSetFieldVisibilityEN.FieldName == "[null]" ? null :  objvSetFieldVisibilityEN.FieldName; //字段名
}
if (arrFldSet.Contains(convSetFieldVisibility.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.Caption = objvSetFieldVisibilityEN.Caption; //标题
}
if (arrFldSet.Contains(convSetFieldVisibility.CtrlType, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.CtrlType = objvSetFieldVisibilityEN.CtrlType; //控件类型
}
if (arrFldSet.Contains(convSetFieldVisibility.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.IsVisible = objvSetFieldVisibilityEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convSetFieldVisibility.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.UpdDate = objvSetFieldVisibilityEN.UpdDate == "[null]" ? null :  objvSetFieldVisibilityEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSetFieldVisibility.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.UpdUserId = objvSetFieldVisibilityEN.UpdUserId == "[null]" ? null :  objvSetFieldVisibilityEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSetFieldVisibility.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.Memo = objvSetFieldVisibilityEN.Memo == "[null]" ? null :  objvSetFieldVisibilityEN.Memo; //说明
}
if (arrFldSet.Contains(convSetFieldVisibility.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.FuncModuleId = objvSetFieldVisibilityEN.FuncModuleId == "[null]" ? null :  objvSetFieldVisibilityEN.FuncModuleId; //FuncModuleId
}
if (arrFldSet.Contains(convSetFieldVisibility.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSetFieldVisibilityEN.FuncModuleName = objvSetFieldVisibilityEN.FuncModuleName == "[null]" ? null :  objvSetFieldVisibilityEN.FuncModuleName; //功能模块名称
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
 /// <param name = "objvSetFieldVisibilityEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
try
{
if (objvSetFieldVisibilityEN.FuncModuleEnName == "[null]") objvSetFieldVisibilityEN.FuncModuleEnName = null; //功能模块英文名称
if (objvSetFieldVisibilityEN.FuncModuleNameSim == "[null]") objvSetFieldVisibilityEN.FuncModuleNameSim = null; //功能模块简称
if (objvSetFieldVisibilityEN.IdSchool == "[null]") objvSetFieldVisibilityEN.IdSchool = null; //学校流水号
if (objvSetFieldVisibilityEN.ViewName == "[null]") objvSetFieldVisibilityEN.ViewName = null; //界面名称
if (objvSetFieldVisibilityEN.FieldName == "[null]") objvSetFieldVisibilityEN.FieldName = null; //字段名
if (objvSetFieldVisibilityEN.UpdDate == "[null]") objvSetFieldVisibilityEN.UpdDate = null; //修改日期
if (objvSetFieldVisibilityEN.UpdUserId == "[null]") objvSetFieldVisibilityEN.UpdUserId = null; //修改用户Id
if (objvSetFieldVisibilityEN.Memo == "[null]") objvSetFieldVisibilityEN.Memo = null; //说明
if (objvSetFieldVisibilityEN.FuncModuleId == "[null]") objvSetFieldVisibilityEN.FuncModuleId = null; //FuncModuleId
if (objvSetFieldVisibilityEN.FuncModuleName == "[null]") objvSetFieldVisibilityEN.FuncModuleName = null; //功能模块名称
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
public static void CheckProperty4Condition(clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
 vSetFieldVisibilityDA.CheckProperty4Condition(objvSetFieldVisibilityEN);
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
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSetFieldVisibilityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSetFieldVisibilityBL没有刷新缓存机制(clsSetFieldVisibilityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSetFieldVisibilityObjLstCache == null)
//{
//arrvSetFieldVisibilityObjLstCache = vSetFieldVisibilityDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLstCache = GetObjLstCache();
IEnumerable <clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Sel =
arrvSetFieldVisibilityObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvSetFieldVisibilityObjLst_Sel.Count() == 0)
{
   clsvSetFieldVisibilityEN obj = clsvSetFieldVisibilityBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSetFieldVisibilityObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetAllvSetFieldVisibilityObjLstCache()
{
//获取缓存中的对象列表
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLstCache = GetObjLstCache(); 
return arrvSetFieldVisibilityObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName);
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSetFieldVisibilityObjLstCache;
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
string strKey = string.Format("{0}", clsvSetFieldVisibilityEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvSetFieldVisibilityEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSetFieldVisibilityEN._RefreshTimeLst.Count == 0) return "";
return clsvSetFieldVisibilityEN._RefreshTimeLst[clsvSetFieldVisibilityEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convSetFieldVisibility.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSetFieldVisibility._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSetFieldVisibility._AttributeName));
throw new Exception(strMsg);
}
var objvSetFieldVisibility = clsvSetFieldVisibilityBL.GetObjBymIdCache(lngmId);
if (objvSetFieldVisibility == null) return "";
return objvSetFieldVisibility[strOutFldName].ToString();
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
int intRecCount = clsvSetFieldVisibilityDA.GetRecCount(strTabName);
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
int intRecCount = clsvSetFieldVisibilityDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSetFieldVisibilityDA.GetRecCount();
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
int intRecCount = clsvSetFieldVisibilityDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSetFieldVisibilityEN objvSetFieldVisibilityCond)
{
List<clsvSetFieldVisibilityEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSetFieldVisibilityEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSetFieldVisibility._AttributeName)
{
if (objvSetFieldVisibilityCond.IsUpdated(strFldName) == false) continue;
if (objvSetFieldVisibilityCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSetFieldVisibilityCond[strFldName].ToString());
}
else
{
if (objvSetFieldVisibilityCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSetFieldVisibilityCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSetFieldVisibilityCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSetFieldVisibilityCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSetFieldVisibilityCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSetFieldVisibilityCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSetFieldVisibilityCond[strFldName]));
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
 List<string> arrList = clsvSetFieldVisibilityDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSetFieldVisibilityDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSetFieldVisibilityDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}