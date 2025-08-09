
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4ErrMsgBL
 表名:vPrjTab4ErrMsg(00050206)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjTab4ErrMsgBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4ErrMsgEN GetObj(this K_TabId_vPrjTab4ErrMsg myKey)
{
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = clsvPrjTab4ErrMsgBL.vPrjTab4ErrMsgDA.GetObjByTabId(myKey.Value);
return objvPrjTab4ErrMsgEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab4ErrMsg.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab4ErrMsg.TabId);
}
objvPrjTab4ErrMsgEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFldNum(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, int? intFldNum, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FldNum) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FldNum, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FldNum] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab4ErrMsg.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab4ErrMsg.TabName);
}
objvPrjTab4ErrMsgEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabCnName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convPrjTab4ErrMsg.TabCnName);
}
objvPrjTab4ErrMsgEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabCnName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabCnName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabCnName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetPrjId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTab4ErrMsg.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTab4ErrMsg.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTab4ErrMsg.PrjId);
}
objvPrjTab4ErrMsgEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.PrjId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.PrjId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.PrjId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetPrjName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjTab4ErrMsg.PrjName);
}
objvPrjTab4ErrMsgEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.PrjName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.PrjName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.PrjName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNeedTransCode(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convPrjTab4ErrMsg.IsNeedTransCode);
objvPrjTab4ErrMsgEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNeedTransCode) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNeedTransCode, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNeedTransCode] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetSqlDsTypeId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab4ErrMsg.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab4ErrMsg.SqlDsTypeId);
}
objvPrjTab4ErrMsgEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.SqlDsTypeId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetSqlDsTypeName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convPrjTab4ErrMsg.SqlDsTypeName);
}
objvPrjTab4ErrMsgEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.SqlDsTypeName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.SqlDsTypeName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabStateId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab4ErrMsg.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab4ErrMsg.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab4ErrMsg.TabStateId);
}
objvPrjTab4ErrMsgEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabStateId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabStateId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabStateName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convPrjTab4ErrMsg.TabStateName);
}
objvPrjTab4ErrMsgEN.TabStateName = strTabStateName; //表状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabStateName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabStateName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabNameB(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabNameB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabNameB, 50, convPrjTab4ErrMsg.TabNameB);
}
objvPrjTab4ErrMsgEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabNameB) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabNameB, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabNameB] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsParaTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsParaTab, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsParaTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsParaTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsParaTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNationStandard(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNationStandard) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNationStandard, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNationStandard] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsArchive(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsArchive, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsArchive) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsArchive, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsArchive] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsChecked(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsChecked) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsChecked, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsChecked] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetErrMsg(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convPrjTab4ErrMsg.ErrMsg);
}
objvPrjTab4ErrMsgEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.ErrMsg) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.ErrMsg, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleAgcId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab4ErrMsg.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab4ErrMsg.FuncModuleAgcId);
}
objvPrjTab4ErrMsgEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleAgcId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convPrjTab4ErrMsg.FuncModuleName);
}
objvPrjTab4ErrMsgEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetFuncModuleEnName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convPrjTab4ErrMsg.FuncModuleEnName);
}
objvPrjTab4ErrMsgEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.FuncModuleEnName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.FuncModuleEnName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleEnName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetOwner(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, convPrjTab4ErrMsg.Owner);
}
objvPrjTab4ErrMsgEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Owner) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Owner, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Owner] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsReleToSqlTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsReleToSqlTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsReleToSqlTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsReleToSqlTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetKeyword(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convPrjTab4ErrMsg.Keyword);
}
objvPrjTab4ErrMsgEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Keyword) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Keyword, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Keyword] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabTypeId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab4ErrMsg.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab4ErrMsg.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab4ErrMsg.TabTypeId);
}
objvPrjTab4ErrMsgEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabTypeId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetTabTypeName(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convPrjTab4ErrMsg.TabTypeName);
}
objvPrjTab4ErrMsgEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.TabTypeName) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.TabTypeName, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeName] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetRelaTabId4View(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strRelaTabId4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, convPrjTab4ErrMsg.RelaTabId4View);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, convPrjTab4ErrMsg.RelaTabId4View);
}
objvPrjTab4ErrMsgEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.RelaTabId4View) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.RelaTabId4View, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabId4View] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetOrderNum4Refer(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, int? intOrderNum4Refer, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.OrderNum4Refer) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.OrderNum4Refer, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.OrderNum4Refer] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetIsNeedGeneIndexer(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.IsNeedGeneIndexer) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetUpdUserId(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjTab4ErrMsg.UpdUserId);
}
objvPrjTab4ErrMsgEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.UpdUserId) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.UpdUserId, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.UpdUserId] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetUpdDate(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjTab4ErrMsg.UpdDate);
}
objvPrjTab4ErrMsgEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.UpdDate) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.UpdDate, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.UpdDate] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetMemo(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjTab4ErrMsg.Memo);
}
objvPrjTab4ErrMsgEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.Memo) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.Memo, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.Memo] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetErrMsg2(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strErrMsg2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg2, 8000, convPrjTab4ErrMsg.ErrMsg2);
}
objvPrjTab4ErrMsgEN.ErrMsg2 = strErrMsg2; //ErrMsg2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.ErrMsg2) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.ErrMsg2, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg2] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetRelaTabName4View(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strRelaTabName4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabName4View, 100, convPrjTab4ErrMsg.RelaTabName4View);
}
objvPrjTab4ErrMsgEN.RelaTabName4View = strRelaTabName4View; //RelaTabName4View
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.RelaTabName4View) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.RelaTabName4View, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabName4View] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab4ErrMsgEN SetDataBaseNameTab(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN, string strDataBaseNameTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseNameTab, 50, convPrjTab4ErrMsg.DataBaseNameTab);
}
objvPrjTab4ErrMsgEN.DataBaseNameTab = strDataBaseNameTab; //DataBaseName_Tab
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab4ErrMsgEN.dicFldComparisonOp.ContainsKey(convPrjTab4ErrMsg.DataBaseNameTab) == false)
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp.Add(convPrjTab4ErrMsg.DataBaseNameTab, strComparisonOp);
}
else
{
objvPrjTab4ErrMsgEN.dicFldComparisonOp[convPrjTab4ErrMsg.DataBaseNameTab] = strComparisonOp;
}
}
return objvPrjTab4ErrMsgEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
 public static void CopyTo(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENS, clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENT)
{
try
{
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程Id
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SqlDsTypeId = objvPrjTab4ErrMsgENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabNameB = objvPrjTab4ErrMsgENS.TabNameB; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.Keyword = objvPrjTab4ErrMsgENS.Keyword; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseNameTab = objvPrjTab4ErrMsgENS.DataBaseNameTab; //DataBaseName_Tab
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
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTab4ErrMsgEN:objvPrjTab4ErrMsgENT</returns>
 public static clsvPrjTab4ErrMsgEN CopyTo(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENS)
{
try
{
 clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENT = new clsvPrjTab4ErrMsgEN()
{
TabId = objvPrjTab4ErrMsgENS.TabId, //表ID
FldNum = objvPrjTab4ErrMsgENS.FldNum, //字段数
TabName = objvPrjTab4ErrMsgENS.TabName, //表名
TabCnName = objvPrjTab4ErrMsgENS.TabCnName, //表中文名
PrjId = objvPrjTab4ErrMsgENS.PrjId, //工程Id
PrjName = objvPrjTab4ErrMsgENS.PrjName, //工程名称
IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode, //是否需要转换代码
SqlDsTypeId = objvPrjTab4ErrMsgENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName, //Sql数据源名
TabStateId = objvPrjTab4ErrMsgENS.TabStateId, //表状态ID
TabStateName = objvPrjTab4ErrMsgENS.TabStateName, //表状态名称
TabNameB = objvPrjTab4ErrMsgENS.TabNameB, //表名_后备
IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab, //是否参数表
IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard, //是否国标
IsArchive = objvPrjTab4ErrMsgENS.IsArchive, //是否存档
IsChecked = objvPrjTab4ErrMsgENS.IsChecked, //是否核实
ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg, //错误信息
FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName, //功能模块英文名称
Owner = objvPrjTab4ErrMsgENS.Owner, //拥有者
IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab, //是否与SQL表相关
Keyword = objvPrjTab4ErrMsgENS.Keyword, //关键字
TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId, //表类型Id
TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName, //表类型名
RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View, //视图的相关表ID
OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer, //引用序号
IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer, //是否需要生成索引器
UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId, //修改用户Id
UpdDate = objvPrjTab4ErrMsgENS.UpdDate, //修改日期
Memo = objvPrjTab4ErrMsgENS.Memo, //说明
ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2, //ErrMsg2
RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View, //RelaTabName4View
DataBaseNameTab = objvPrjTab4ErrMsgENS.DataBaseNameTab, //DataBaseName_Tab
};
 return objvPrjTab4ErrMsgENT;
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
public static void CheckProperty4Condition(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
 clsvPrjTab4ErrMsgBL.vPrjTab4ErrMsgDA.CheckProperty4Condition(objvPrjTab4ErrMsgEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabId, objvPrjTab4ErrMsgCond.TabId, strComparisonOpTabId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FldNum) == true)
{
string strComparisonOpFldNum = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4ErrMsg.FldNum, objvPrjTab4ErrMsgCond.FldNum, strComparisonOpFldNum);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabName, objvPrjTab4ErrMsgCond.TabName, strComparisonOpTabName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabCnName) == true)
{
string strComparisonOpTabCnName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabCnName, objvPrjTab4ErrMsgCond.TabCnName, strComparisonOpTabCnName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.PrjId, objvPrjTab4ErrMsgCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.PrjName, objvPrjTab4ErrMsgCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNeedTransCode) == true)
{
if (objvPrjTab4ErrMsgCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNeedTransCode);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.SqlDsTypeId, objvPrjTab4ErrMsgCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.SqlDsTypeName, objvPrjTab4ErrMsgCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabStateId, objvPrjTab4ErrMsgCond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabStateName) == true)
{
string strComparisonOpTabStateName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabStateName, objvPrjTab4ErrMsgCond.TabStateName, strComparisonOpTabStateName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabNameB) == true)
{
string strComparisonOpTabNameB = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabNameB, objvPrjTab4ErrMsgCond.TabNameB, strComparisonOpTabNameB);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsParaTab) == true)
{
if (objvPrjTab4ErrMsgCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsParaTab);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNationStandard) == true)
{
if (objvPrjTab4ErrMsgCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNationStandard);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsArchive) == true)
{
if (objvPrjTab4ErrMsgCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsArchive);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsChecked) == true)
{
if (objvPrjTab4ErrMsgCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsChecked);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.ErrMsg, objvPrjTab4ErrMsgCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleAgcId, objvPrjTab4ErrMsgCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleName, objvPrjTab4ErrMsgCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.FuncModuleEnName, objvPrjTab4ErrMsgCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Owner) == true)
{
string strComparisonOpOwner = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Owner, objvPrjTab4ErrMsgCond.Owner, strComparisonOpOwner);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsReleToSqlTab) == true)
{
if (objvPrjTab4ErrMsgCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsReleToSqlTab);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Keyword) == true)
{
string strComparisonOpKeyword = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Keyword, objvPrjTab4ErrMsgCond.Keyword, strComparisonOpKeyword);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabTypeId, objvPrjTab4ErrMsgCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.TabTypeName, objvPrjTab4ErrMsgCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.RelaTabId4View, objvPrjTab4ErrMsgCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTab4ErrMsg.OrderNum4Refer, objvPrjTab4ErrMsgCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.IsNeedGeneIndexer) == true)
{
if (objvPrjTab4ErrMsgCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTab4ErrMsg.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTab4ErrMsg.IsNeedGeneIndexer);
}
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.UpdUserId, objvPrjTab4ErrMsgCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.UpdDate, objvPrjTab4ErrMsgCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.Memo) == true)
{
string strComparisonOpMemo = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.Memo, objvPrjTab4ErrMsgCond.Memo, strComparisonOpMemo);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.ErrMsg2) == true)
{
string strComparisonOpErrMsg2 = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.ErrMsg2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.ErrMsg2, objvPrjTab4ErrMsgCond.ErrMsg2, strComparisonOpErrMsg2);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.RelaTabName4View) == true)
{
string strComparisonOpRelaTabName4View = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.RelaTabName4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.RelaTabName4View, objvPrjTab4ErrMsgCond.RelaTabName4View, strComparisonOpRelaTabName4View);
}
if (objvPrjTab4ErrMsgCond.IsUpdated(convPrjTab4ErrMsg.DataBaseNameTab) == true)
{
string strComparisonOpDataBaseNameTab = objvPrjTab4ErrMsgCond.dicFldComparisonOp[convPrjTab4ErrMsg.DataBaseNameTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab4ErrMsg.DataBaseNameTab, objvPrjTab4ErrMsgCond.DataBaseNameTab, strComparisonOpDataBaseNameTab);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTab4ErrMsg
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjTab4ErrMsg(vPrjTab4ErrMsg)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab4ErrMsgBL
{
public static RelatedActions_vPrjTab4ErrMsg relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTab4ErrMsgDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTab4ErrMsgDA vPrjTab4ErrMsgDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTab4ErrMsgDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTab4ErrMsgBL()
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
if (string.IsNullOrEmpty(clsvPrjTab4ErrMsgEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab4ErrMsgEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTab4ErrMsg(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTab4ErrMsgDA.GetDataTable_vPrjTab4ErrMsg(strWhereCond);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable(strWhereCond);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTab4ErrMsgDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTab4ErrMsgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTab4ErrMsgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTab4ErrMsgEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel =
arrvPrjTab4ErrMsgObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTab4ErrMsgObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTab4ErrMsgEN> GetSubObjLstCache(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgCond)
{
 string strPrjId = objvPrjTab4ErrMsgCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTab4ErrMsgBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab4ErrMsgEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab4ErrMsg._AttributeName)
{
if (objvPrjTab4ErrMsgCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab4ErrMsgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4ErrMsgCond[strFldName].ToString());
}
else
{
if (objvPrjTab4ErrMsgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab4ErrMsgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4ErrMsgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab4ErrMsgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab4ErrMsgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab4ErrMsgCond[strFldName]));
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
List<clsvPrjTab4ErrMsgEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTab4ErrMsgEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTab4ErrMsgEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
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
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
public static List<clsvPrjTab4ErrMsgEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
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
public static List<clsvPrjTab4ErrMsgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTab4ErrMsgEN> arrObjLst = new List<clsvPrjTab4ErrMsgEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN();
try
{
objvPrjTab4ErrMsgEN.TabId = objRow[convPrjTab4ErrMsg.TabId].ToString().Trim(); //表ID
objvPrjTab4ErrMsgEN.FldNum = objRow[convPrjTab4ErrMsg.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.FldNum].ToString().Trim()); //字段数
objvPrjTab4ErrMsgEN.TabName = objRow[convPrjTab4ErrMsg.TabName].ToString().Trim(); //表名
objvPrjTab4ErrMsgEN.TabCnName = objRow[convPrjTab4ErrMsg.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4ErrMsgEN.PrjId = objRow[convPrjTab4ErrMsg.PrjId].ToString().Trim(); //工程Id
objvPrjTab4ErrMsgEN.PrjName = objRow[convPrjTab4ErrMsg.PrjName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.PrjName].ToString().Trim(); //工程名称
objvPrjTab4ErrMsgEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4ErrMsgEN.SqlDsTypeId = objRow[convPrjTab4ErrMsg.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4ErrMsgEN.SqlDsTypeName = objRow[convPrjTab4ErrMsg.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4ErrMsgEN.TabStateId = objRow[convPrjTab4ErrMsg.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4ErrMsgEN.TabStateName = objRow[convPrjTab4ErrMsg.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4ErrMsgEN.TabNameB = objRow[convPrjTab4ErrMsg.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4ErrMsgEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4ErrMsgEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4ErrMsgEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4ErrMsgEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4ErrMsgEN.ErrMsg = objRow[convPrjTab4ErrMsg.ErrMsg] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg].ToString().Trim(); //错误信息
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objRow[convPrjTab4ErrMsg.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4ErrMsgEN.FuncModuleName = objRow[convPrjTab4ErrMsg.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4ErrMsgEN.FuncModuleEnName = objRow[convPrjTab4ErrMsg.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4ErrMsgEN.Owner = objRow[convPrjTab4ErrMsg.Owner] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Owner].ToString().Trim(); //拥有者
objvPrjTab4ErrMsgEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4ErrMsgEN.Keyword = objRow[convPrjTab4ErrMsg.Keyword] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Keyword].ToString().Trim(); //关键字
objvPrjTab4ErrMsgEN.TabTypeId = objRow[convPrjTab4ErrMsg.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4ErrMsgEN.TabTypeName = objRow[convPrjTab4ErrMsg.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4ErrMsgEN.RelaTabId4View = objRow[convPrjTab4ErrMsg.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4ErrMsgEN.OrderNum4Refer = objRow[convPrjTab4ErrMsg.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4ErrMsg.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4ErrMsg.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4ErrMsgEN.UpdUserId = objRow[convPrjTab4ErrMsg.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4ErrMsgEN.UpdDate = objRow[convPrjTab4ErrMsg.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4ErrMsgEN.Memo = objRow[convPrjTab4ErrMsg.Memo] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.Memo].ToString().Trim(); //说明
objvPrjTab4ErrMsgEN.ErrMsg2 = objRow[convPrjTab4ErrMsg.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4ErrMsgEN.RelaTabName4View = objRow[convPrjTab4ErrMsg.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTab4ErrMsgEN.DataBaseNameTab = objRow[convPrjTab4ErrMsg.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4ErrMsg.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTab4ErrMsgEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTab4ErrMsgEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTab4ErrMsg(ref clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
bool bolResult = vPrjTab4ErrMsgDA.GetvPrjTab4ErrMsg(ref objvPrjTab4ErrMsgEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab4ErrMsgEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = vPrjTab4ErrMsgDA.GetObjByTabId(strTabId);
return objvPrjTab4ErrMsgEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTab4ErrMsgEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = vPrjTab4ErrMsgDA.GetFirstObj(strWhereCond);
 return objvPrjTab4ErrMsgEN;
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
public static clsvPrjTab4ErrMsgEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = vPrjTab4ErrMsgDA.GetObjByDataRow(objRow);
 return objvPrjTab4ErrMsgEN;
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
public static clsvPrjTab4ErrMsgEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = vPrjTab4ErrMsgDA.GetObjByDataRow(objRow);
 return objvPrjTab4ErrMsgEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvPrjTab4ErrMsgObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab4ErrMsgEN GetObjByTabIdFromList(string strTabId, List<clsvPrjTab4ErrMsgEN> lstvPrjTab4ErrMsgObjLst)
{
foreach (clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN in lstvPrjTab4ErrMsgObjLst)
{
if (objvPrjTab4ErrMsgEN.TabId == strTabId)
{
return objvPrjTab4ErrMsgEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsvPrjTab4ErrMsgDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = vPrjTab4ErrMsgDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTab4ErrMsgDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjTab4ErrMsgDA.IsExist(strTabId);
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
 bolIsExist = clsvPrjTab4ErrMsgDA.IsExistTable();
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
 bolIsExist = vPrjTab4ErrMsgDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTab4ErrMsgENS">源对象</param>
 /// <param name = "objvPrjTab4ErrMsgENT">目标对象</param>
 public static void CopyTo(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENS, clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgENT)
{
try
{
objvPrjTab4ErrMsgENT.TabId = objvPrjTab4ErrMsgENS.TabId; //表ID
objvPrjTab4ErrMsgENT.FldNum = objvPrjTab4ErrMsgENS.FldNum; //字段数
objvPrjTab4ErrMsgENT.TabName = objvPrjTab4ErrMsgENS.TabName; //表名
objvPrjTab4ErrMsgENT.TabCnName = objvPrjTab4ErrMsgENS.TabCnName; //表中文名
objvPrjTab4ErrMsgENT.PrjId = objvPrjTab4ErrMsgENS.PrjId; //工程Id
objvPrjTab4ErrMsgENT.PrjName = objvPrjTab4ErrMsgENS.PrjName; //工程名称
objvPrjTab4ErrMsgENT.IsNeedTransCode = objvPrjTab4ErrMsgENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4ErrMsgENT.SqlDsTypeId = objvPrjTab4ErrMsgENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4ErrMsgENT.SqlDsTypeName = objvPrjTab4ErrMsgENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4ErrMsgENT.TabStateId = objvPrjTab4ErrMsgENS.TabStateId; //表状态ID
objvPrjTab4ErrMsgENT.TabStateName = objvPrjTab4ErrMsgENS.TabStateName; //表状态名称
objvPrjTab4ErrMsgENT.TabNameB = objvPrjTab4ErrMsgENS.TabNameB; //表名_后备
objvPrjTab4ErrMsgENT.IsParaTab = objvPrjTab4ErrMsgENS.IsParaTab; //是否参数表
objvPrjTab4ErrMsgENT.IsNationStandard = objvPrjTab4ErrMsgENS.IsNationStandard; //是否国标
objvPrjTab4ErrMsgENT.IsArchive = objvPrjTab4ErrMsgENS.IsArchive; //是否存档
objvPrjTab4ErrMsgENT.IsChecked = objvPrjTab4ErrMsgENS.IsChecked; //是否核实
objvPrjTab4ErrMsgENT.ErrMsg = objvPrjTab4ErrMsgENS.ErrMsg; //错误信息
objvPrjTab4ErrMsgENT.FuncModuleAgcId = objvPrjTab4ErrMsgENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4ErrMsgENT.FuncModuleName = objvPrjTab4ErrMsgENS.FuncModuleName; //功能模块名称
objvPrjTab4ErrMsgENT.FuncModuleEnName = objvPrjTab4ErrMsgENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4ErrMsgENT.Owner = objvPrjTab4ErrMsgENS.Owner; //拥有者
objvPrjTab4ErrMsgENT.IsReleToSqlTab = objvPrjTab4ErrMsgENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4ErrMsgENT.Keyword = objvPrjTab4ErrMsgENS.Keyword; //关键字
objvPrjTab4ErrMsgENT.TabTypeId = objvPrjTab4ErrMsgENS.TabTypeId; //表类型Id
objvPrjTab4ErrMsgENT.TabTypeName = objvPrjTab4ErrMsgENS.TabTypeName; //表类型名
objvPrjTab4ErrMsgENT.RelaTabId4View = objvPrjTab4ErrMsgENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4ErrMsgENT.OrderNum4Refer = objvPrjTab4ErrMsgENS.OrderNum4Refer; //引用序号
objvPrjTab4ErrMsgENT.IsNeedGeneIndexer = objvPrjTab4ErrMsgENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4ErrMsgENT.UpdUserId = objvPrjTab4ErrMsgENS.UpdUserId; //修改用户Id
objvPrjTab4ErrMsgENT.UpdDate = objvPrjTab4ErrMsgENS.UpdDate; //修改日期
objvPrjTab4ErrMsgENT.Memo = objvPrjTab4ErrMsgENS.Memo; //说明
objvPrjTab4ErrMsgENT.ErrMsg2 = objvPrjTab4ErrMsgENS.ErrMsg2; //ErrMsg2
objvPrjTab4ErrMsgENT.RelaTabName4View = objvPrjTab4ErrMsgENS.RelaTabName4View; //RelaTabName4View
objvPrjTab4ErrMsgENT.DataBaseNameTab = objvPrjTab4ErrMsgENS.DataBaseNameTab; //DataBaseName_Tab
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
 /// <param name = "objvPrjTab4ErrMsgEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
try
{
objvPrjTab4ErrMsgEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTab4ErrMsgEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabId = objvPrjTab4ErrMsgEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.FldNum = objvPrjTab4ErrMsgEN.FldNum; //字段数
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabName = objvPrjTab4ErrMsgEN.TabName; //表名
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabCnName = objvPrjTab4ErrMsgEN.TabCnName == "[null]" ? null :  objvPrjTab4ErrMsgEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.PrjId = objvPrjTab4ErrMsgEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.PrjName = objvPrjTab4ErrMsgEN.PrjName == "[null]" ? null :  objvPrjTab4ErrMsgEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsNeedTransCode = objvPrjTab4ErrMsgEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.SqlDsTypeId = objvPrjTab4ErrMsgEN.SqlDsTypeId == "[null]" ? null :  objvPrjTab4ErrMsgEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.SqlDsTypeName = objvPrjTab4ErrMsgEN.SqlDsTypeName == "[null]" ? null :  objvPrjTab4ErrMsgEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabStateId = objvPrjTab4ErrMsgEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabStateName = objvPrjTab4ErrMsgEN.TabStateName == "[null]" ? null :  objvPrjTab4ErrMsgEN.TabStateName; //表状态名称
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabNameB, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabNameB = objvPrjTab4ErrMsgEN.TabNameB == "[null]" ? null :  objvPrjTab4ErrMsgEN.TabNameB; //表名_后备
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsParaTab = objvPrjTab4ErrMsgEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsNationStandard, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsNationStandard = objvPrjTab4ErrMsgEN.IsNationStandard; //是否国标
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsArchive = objvPrjTab4ErrMsgEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsChecked = objvPrjTab4ErrMsgEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.ErrMsg = objvPrjTab4ErrMsgEN.ErrMsg == "[null]" ? null :  objvPrjTab4ErrMsgEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.FuncModuleAgcId = objvPrjTab4ErrMsgEN.FuncModuleAgcId == "[null]" ? null :  objvPrjTab4ErrMsgEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.FuncModuleName = objvPrjTab4ErrMsgEN.FuncModuleName == "[null]" ? null :  objvPrjTab4ErrMsgEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.FuncModuleEnName = objvPrjTab4ErrMsgEN.FuncModuleEnName == "[null]" ? null :  objvPrjTab4ErrMsgEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.Owner = objvPrjTab4ErrMsgEN.Owner == "[null]" ? null :  objvPrjTab4ErrMsgEN.Owner; //拥有者
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsReleToSqlTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsReleToSqlTab = objvPrjTab4ErrMsgEN.IsReleToSqlTab; //是否与SQL表相关
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.Keyword = objvPrjTab4ErrMsgEN.Keyword == "[null]" ? null :  objvPrjTab4ErrMsgEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabTypeId = objvPrjTab4ErrMsgEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.TabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.TabTypeName = objvPrjTab4ErrMsgEN.TabTypeName == "[null]" ? null :  objvPrjTab4ErrMsgEN.TabTypeName; //表类型名
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.RelaTabId4View, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.RelaTabId4View = objvPrjTab4ErrMsgEN.RelaTabId4View == "[null]" ? null :  objvPrjTab4ErrMsgEN.RelaTabId4View; //视图的相关表ID
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.OrderNum4Refer = objvPrjTab4ErrMsgEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.IsNeedGeneIndexer, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.IsNeedGeneIndexer = objvPrjTab4ErrMsgEN.IsNeedGeneIndexer; //是否需要生成索引器
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.UpdUserId = objvPrjTab4ErrMsgEN.UpdUserId == "[null]" ? null :  objvPrjTab4ErrMsgEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.UpdDate = objvPrjTab4ErrMsgEN.UpdDate == "[null]" ? null :  objvPrjTab4ErrMsgEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.Memo = objvPrjTab4ErrMsgEN.Memo == "[null]" ? null :  objvPrjTab4ErrMsgEN.Memo; //说明
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.ErrMsg2, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.ErrMsg2 = objvPrjTab4ErrMsgEN.ErrMsg2 == "[null]" ? null :  objvPrjTab4ErrMsgEN.ErrMsg2; //ErrMsg2
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.RelaTabName4View, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.RelaTabName4View = objvPrjTab4ErrMsgEN.RelaTabName4View == "[null]" ? null :  objvPrjTab4ErrMsgEN.RelaTabName4View; //RelaTabName4View
}
if (arrFldSet.Contains(convPrjTab4ErrMsg.DataBaseNameTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTab4ErrMsgEN.DataBaseNameTab = objvPrjTab4ErrMsgEN.DataBaseNameTab == "[null]" ? null :  objvPrjTab4ErrMsgEN.DataBaseNameTab; //DataBaseName_Tab
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
 /// <param name = "objvPrjTab4ErrMsgEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
try
{
if (objvPrjTab4ErrMsgEN.TabCnName == "[null]") objvPrjTab4ErrMsgEN.TabCnName = null; //表中文名
if (objvPrjTab4ErrMsgEN.PrjName == "[null]") objvPrjTab4ErrMsgEN.PrjName = null; //工程名称
if (objvPrjTab4ErrMsgEN.SqlDsTypeId == "[null]") objvPrjTab4ErrMsgEN.SqlDsTypeId = null; //数据源类型Id
if (objvPrjTab4ErrMsgEN.SqlDsTypeName == "[null]") objvPrjTab4ErrMsgEN.SqlDsTypeName = null; //Sql数据源名
if (objvPrjTab4ErrMsgEN.TabStateName == "[null]") objvPrjTab4ErrMsgEN.TabStateName = null; //表状态名称
if (objvPrjTab4ErrMsgEN.TabNameB == "[null]") objvPrjTab4ErrMsgEN.TabNameB = null; //表名_后备
if (objvPrjTab4ErrMsgEN.ErrMsg == "[null]") objvPrjTab4ErrMsgEN.ErrMsg = null; //错误信息
if (objvPrjTab4ErrMsgEN.FuncModuleAgcId == "[null]") objvPrjTab4ErrMsgEN.FuncModuleAgcId = null; //功能模块Id
if (objvPrjTab4ErrMsgEN.FuncModuleName == "[null]") objvPrjTab4ErrMsgEN.FuncModuleName = null; //功能模块名称
if (objvPrjTab4ErrMsgEN.FuncModuleEnName == "[null]") objvPrjTab4ErrMsgEN.FuncModuleEnName = null; //功能模块英文名称
if (objvPrjTab4ErrMsgEN.Owner == "[null]") objvPrjTab4ErrMsgEN.Owner = null; //拥有者
if (objvPrjTab4ErrMsgEN.Keyword == "[null]") objvPrjTab4ErrMsgEN.Keyword = null; //关键字
if (objvPrjTab4ErrMsgEN.TabTypeName == "[null]") objvPrjTab4ErrMsgEN.TabTypeName = null; //表类型名
if (objvPrjTab4ErrMsgEN.RelaTabId4View == "[null]") objvPrjTab4ErrMsgEN.RelaTabId4View = null; //视图的相关表ID
if (objvPrjTab4ErrMsgEN.UpdUserId == "[null]") objvPrjTab4ErrMsgEN.UpdUserId = null; //修改用户Id
if (objvPrjTab4ErrMsgEN.UpdDate == "[null]") objvPrjTab4ErrMsgEN.UpdDate = null; //修改日期
if (objvPrjTab4ErrMsgEN.Memo == "[null]") objvPrjTab4ErrMsgEN.Memo = null; //说明
if (objvPrjTab4ErrMsgEN.ErrMsg2 == "[null]") objvPrjTab4ErrMsgEN.ErrMsg2 = null; //ErrMsg2
if (objvPrjTab4ErrMsgEN.RelaTabName4View == "[null]") objvPrjTab4ErrMsgEN.RelaTabName4View = null; //RelaTabName4View
if (objvPrjTab4ErrMsgEN.DataBaseNameTab == "[null]") objvPrjTab4ErrMsgEN.DataBaseNameTab = null; //DataBaseName_Tab
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
public static void CheckProperty4Condition(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN)
{
 vPrjTab4ErrMsgDA.CheckProperty4Condition(objvPrjTab4ErrMsgEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4ErrMsg.TabId); 
List<clsvPrjTab4ErrMsgEN> arrObjLst = clsvPrjTab4ErrMsgBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgEN = new clsvPrjTab4ErrMsgEN()
{
TabId = "0",
TabName = "选[vPrjTab4ErrMsg]..."
};
arrObjLstSel.Insert(0, objvPrjTab4ErrMsgEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjTab4ErrMsg.TabId;
objComboBox.DisplayMember = convPrjTab4ErrMsg.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4ErrMsg]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjTab4ErrMsg.TabId); 
IEnumerable<clsvPrjTab4ErrMsgEN> arrObjLst = clsvPrjTab4ErrMsgBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convPrjTab4ErrMsg.TabId;
objDDL.DataTextField = convPrjTab4ErrMsg.TabName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjTab4ErrMsg]...","0");
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst = GetAllvPrjTab4ErrMsgObjLstCache(strPrjId); 
objDDL.DataValueField = convPrjTab4ErrMsg.TabId;
objDDL.DataTextField = convPrjTab4ErrMsg.TabName;
objDDL.DataSource = arrvPrjTab4ErrMsgObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabCheckResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckResultBL没有刷新缓存机制(clsTabCheckResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTab4ErrMsgObjLstCache == null)
//{
//arrvPrjTab4ErrMsgObjLstCache = vPrjTab4ErrMsgDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab4ErrMsgEN GetObjByTabIdCache(string strTabId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLst_Sel =
arrvPrjTab4ErrMsgObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTab4ErrMsgObjLst_Sel.Count() == 0)
{
   clsvPrjTab4ErrMsgEN obj = clsvPrjTab4ErrMsgBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTab4ErrMsgObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsg = GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4ErrMsg == null) return "";
return objvPrjTab4ErrMsg.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsg = GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4ErrMsg == null) return "";
return objvPrjTab4ErrMsg.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetAllvPrjTab4ErrMsgObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTab4ErrMsgObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab4ErrMsgEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTab4ErrMsgEN> arrvPrjTab4ErrMsgObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTab4ErrMsgObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab4ErrMsgEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTab4ErrMsgEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTab4ErrMsgEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTab4ErrMsgEN._RefreshTimeLst[clsvPrjTab4ErrMsgEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != convPrjTab4ErrMsg.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTab4ErrMsg._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTab4ErrMsg._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTab4ErrMsg = clsvPrjTab4ErrMsgBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objvPrjTab4ErrMsg == null) return "";
return objvPrjTab4ErrMsg[strOutFldName].ToString();
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
int intRecCount = clsvPrjTab4ErrMsgDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTab4ErrMsgDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTab4ErrMsgDA.GetRecCount();
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
int intRecCount = clsvPrjTab4ErrMsgDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTab4ErrMsgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTab4ErrMsgEN objvPrjTab4ErrMsgCond)
{
 string strPrjId = objvPrjTab4ErrMsgCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTab4ErrMsgBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTab4ErrMsgEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTab4ErrMsgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTab4ErrMsg._AttributeName)
{
if (objvPrjTab4ErrMsgCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTab4ErrMsgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4ErrMsgCond[strFldName].ToString());
}
else
{
if (objvPrjTab4ErrMsgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTab4ErrMsgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTab4ErrMsgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTab4ErrMsgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTab4ErrMsgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTab4ErrMsgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTab4ErrMsgCond[strFldName]));
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
 List<string> arrList = clsvPrjTab4ErrMsgDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab4ErrMsgDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTab4ErrMsgDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}