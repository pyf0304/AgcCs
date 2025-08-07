
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectPrjTabBL
 表名:vCmProjectPrjTab(00050531)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCmProjectPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectPrjTabEN GetObj(this K_mId_vCmProjectPrjTab myKey)
{
clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = clsvCmProjectPrjTabBL.vCmProjectPrjTabDA.GetObjBymId(myKey.Value);
return objvCmProjectPrjTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetmId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, long lngmId, string strComparisonOp="")
	{
objvCmProjectPrjTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.mId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.mId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.mId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetCmPrjId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCmProjectPrjTab.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCmProjectPrjTab.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCmProjectPrjTab.CmPrjId);
}
objvCmProjectPrjTabEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.CmPrjId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.CmPrjId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.CmPrjId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetCmPrjName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCmProjectPrjTab.CmPrjName);
}
objvCmProjectPrjTabEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.CmPrjName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.CmPrjName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.CmPrjName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetPrjId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCmProjectPrjTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCmProjectPrjTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCmProjectPrjTab.PrjId);
}
objvCmProjectPrjTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.PrjId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.PrjId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.PrjId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convCmProjectPrjTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convCmProjectPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convCmProjectPrjTab.TabId);
}
objvCmProjectPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convCmProjectPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convCmProjectPrjTab.TabName);
}
objvCmProjectPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetFuncModuleAgcId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCmProjectPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCmProjectPrjTab.FuncModuleAgcId);
}
objvCmProjectPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.FuncModuleAgcId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetFuncModuleName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCmProjectPrjTab.FuncModuleName);
}
objvCmProjectPrjTabEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.FuncModuleName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.FuncModuleName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetOrderNum(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCmProjectPrjTab.OrderNum);
objvCmProjectPrjTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.OrderNum) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.OrderNum, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.OrderNum] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetUpdDate(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCmProjectPrjTab.UpdDate);
}
objvCmProjectPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.UpdDate) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.UpdDate, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.UpdDate] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetUpdUser(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCmProjectPrjTab.UpdUser);
}
objvCmProjectPrjTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.UpdUser) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.UpdUser, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.UpdUser] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetMemo(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCmProjectPrjTab.Memo);
}
objvCmProjectPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.Memo) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.Memo, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.Memo] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetSqlDsTypeId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convCmProjectPrjTab.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convCmProjectPrjTab.SqlDsTypeId);
}
objvCmProjectPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.SqlDsTypeId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetSqlDsTypeName(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convCmProjectPrjTab.SqlDsTypeName);
}
objvCmProjectPrjTabEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.SqlDsTypeName) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.SqlDsTypeName, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeName] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabRecNum(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, int? intTabRecNum, string strComparisonOp="")
	{
objvCmProjectPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabRecNum) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabRecNum, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabRecNum] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabTypeId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convCmProjectPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convCmProjectPrjTab.TabTypeId);
}
objvCmProjectPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabTypeId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabTypeId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabTypeId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectPrjTabEN SetTabStateId(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convCmProjectPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convCmProjectPrjTab.TabStateId);
}
objvCmProjectPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectPrjTabEN.dicFldComparisonOp.ContainsKey(convCmProjectPrjTab.TabStateId) == false)
{
objvCmProjectPrjTabEN.dicFldComparisonOp.Add(convCmProjectPrjTab.TabStateId, strComparisonOp);
}
else
{
objvCmProjectPrjTabEN.dicFldComparisonOp[convCmProjectPrjTab.TabStateId] = strComparisonOp;
}
}
return objvCmProjectPrjTabEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabENS">源对象</param>
 /// <param name = "objvCmProjectPrjTabENT">目标对象</param>
 public static void CopyTo(this clsvCmProjectPrjTabEN objvCmProjectPrjTabENS, clsvCmProjectPrjTabEN objvCmProjectPrjTabENT)
{
try
{
objvCmProjectPrjTabENT.mId = objvCmProjectPrjTabENS.mId; //mId
objvCmProjectPrjTabENT.CmPrjId = objvCmProjectPrjTabENS.CmPrjId; //Cm工程Id
objvCmProjectPrjTabENT.CmPrjName = objvCmProjectPrjTabENS.CmPrjName; //CM工程名
objvCmProjectPrjTabENT.PrjId = objvCmProjectPrjTabENS.PrjId; //工程Id
objvCmProjectPrjTabENT.TabId = objvCmProjectPrjTabENS.TabId; //表ID
objvCmProjectPrjTabENT.TabName = objvCmProjectPrjTabENS.TabName; //表名
objvCmProjectPrjTabENT.FuncModuleAgcId = objvCmProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCmProjectPrjTabENT.FuncModuleName = objvCmProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCmProjectPrjTabENT.OrderNum = objvCmProjectPrjTabENS.OrderNum; //序号
objvCmProjectPrjTabENT.UpdDate = objvCmProjectPrjTabENS.UpdDate; //修改日期
objvCmProjectPrjTabENT.UpdUser = objvCmProjectPrjTabENS.UpdUser; //修改者
objvCmProjectPrjTabENT.Memo = objvCmProjectPrjTabENS.Memo; //说明
objvCmProjectPrjTabENT.SqlDsTypeId = objvCmProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCmProjectPrjTabENT.SqlDsTypeName = objvCmProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCmProjectPrjTabENT.TabRecNum = objvCmProjectPrjTabENS.TabRecNum; //记录数
objvCmProjectPrjTabENT.TabTypeId = objvCmProjectPrjTabENS.TabTypeId; //表类型Id
objvCmProjectPrjTabENT.TabStateId = objvCmProjectPrjTabENS.TabStateId; //表状态ID
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
 /// <param name = "objvCmProjectPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsvCmProjectPrjTabEN:objvCmProjectPrjTabENT</returns>
 public static clsvCmProjectPrjTabEN CopyTo(this clsvCmProjectPrjTabEN objvCmProjectPrjTabENS)
{
try
{
 clsvCmProjectPrjTabEN objvCmProjectPrjTabENT = new clsvCmProjectPrjTabEN()
{
mId = objvCmProjectPrjTabENS.mId, //mId
CmPrjId = objvCmProjectPrjTabENS.CmPrjId, //Cm工程Id
CmPrjName = objvCmProjectPrjTabENS.CmPrjName, //CM工程名
PrjId = objvCmProjectPrjTabENS.PrjId, //工程Id
TabId = objvCmProjectPrjTabENS.TabId, //表ID
TabName = objvCmProjectPrjTabENS.TabName, //表名
FuncModuleAgcId = objvCmProjectPrjTabENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCmProjectPrjTabENS.FuncModuleName, //功能模块名称
OrderNum = objvCmProjectPrjTabENS.OrderNum, //序号
UpdDate = objvCmProjectPrjTabENS.UpdDate, //修改日期
UpdUser = objvCmProjectPrjTabENS.UpdUser, //修改者
Memo = objvCmProjectPrjTabENS.Memo, //说明
SqlDsTypeId = objvCmProjectPrjTabENS.SqlDsTypeId, //数据源类型Id
SqlDsTypeName = objvCmProjectPrjTabENS.SqlDsTypeName, //Sql数据源名
TabRecNum = objvCmProjectPrjTabENS.TabRecNum, //记录数
TabTypeId = objvCmProjectPrjTabENS.TabTypeId, //表类型Id
TabStateId = objvCmProjectPrjTabENS.TabStateId, //表状态ID
};
 return objvCmProjectPrjTabENT;
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
public static void CheckProperty4Condition(this clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
 clsvCmProjectPrjTabBL.vCmProjectPrjTabDA.CheckProperty4Condition(objvCmProjectPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCmProjectPrjTabEN objvCmProjectPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.mId) == true)
{
string strComparisonOpmId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.mId, objvCmProjectPrjTabCond.mId, strComparisonOpmId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.CmPrjId, objvCmProjectPrjTabCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.CmPrjName, objvCmProjectPrjTabCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.PrjId, objvCmProjectPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabId) == true)
{
string strComparisonOpTabId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabId, objvCmProjectPrjTabCond.TabId, strComparisonOpTabId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabName) == true)
{
string strComparisonOpTabName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabName, objvCmProjectPrjTabCond.TabName, strComparisonOpTabName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.FuncModuleAgcId, objvCmProjectPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.FuncModuleName, objvCmProjectPrjTabCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.OrderNum, objvCmProjectPrjTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.UpdDate, objvCmProjectPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.UpdUser, objvCmProjectPrjTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.Memo) == true)
{
string strComparisonOpMemo = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.Memo, objvCmProjectPrjTabCond.Memo, strComparisonOpMemo);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.SqlDsTypeId, objvCmProjectPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.SqlDsTypeName, objvCmProjectPrjTabCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectPrjTab.TabRecNum, objvCmProjectPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabTypeId, objvCmProjectPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvCmProjectPrjTabCond.IsUpdated(convCmProjectPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objvCmProjectPrjTabCond.dicFldComparisonOp[convCmProjectPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectPrjTab.TabStateId, objvCmProjectPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCmProjectPrjTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCmProjectPrjTab(vCmProjectPrjTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCmProjectPrjTabBL
{
public static RelatedActions_vCmProjectPrjTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCmProjectPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCmProjectPrjTabDA vCmProjectPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCmProjectPrjTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCmProjectPrjTabBL()
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
if (string.IsNullOrEmpty(clsvCmProjectPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCmProjectPrjTabEN._ConnectString);
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
public static DataTable GetDataTable_vCmProjectPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCmProjectPrjTabDA.GetDataTable_vCmProjectPrjTab(strWhereCond);
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
objDT = vCmProjectPrjTabDA.GetDataTable(strWhereCond);
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
objDT = vCmProjectPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCmProjectPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCmProjectPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCmProjectPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = vCmProjectPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCmProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCmProjectPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
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
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCmProjectPrjTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLst_Sel =
arrvCmProjectPrjTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCmProjectPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
public static List<clsvCmProjectPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCmProjectPrjTabEN> GetSubObjLstCache(clsvCmProjectPrjTabEN objvCmProjectPrjTabCond)
{
 string strPrjId = objvCmProjectPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCmProjectPrjTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCmProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCmProjectPrjTab._AttributeName)
{
if (objvCmProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvCmProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objvCmProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCmProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCmProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCmProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCmProjectPrjTabCond[strFldName]));
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
List<clsvCmProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCmProjectPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCmProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
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
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
public static List<clsvCmProjectPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
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
public static List<clsvCmProjectPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCmProjectPrjTabEN> arrObjLst = new List<clsvCmProjectPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = new clsvCmProjectPrjTabEN();
try
{
objvCmProjectPrjTabEN.mId = Int32.Parse(objRow[convCmProjectPrjTab.mId].ToString().Trim()); //mId
objvCmProjectPrjTabEN.CmPrjId = objRow[convCmProjectPrjTab.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectPrjTabEN.CmPrjName = objRow[convCmProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectPrjTabEN.PrjId = objRow[convCmProjectPrjTab.PrjId].ToString().Trim(); //工程Id
objvCmProjectPrjTabEN.TabId = objRow[convCmProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCmProjectPrjTabEN.TabName = objRow[convCmProjectPrjTab.TabName].ToString().Trim(); //表名
objvCmProjectPrjTabEN.FuncModuleAgcId = objRow[convCmProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCmProjectPrjTabEN.FuncModuleName = objRow[convCmProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCmProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCmProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCmProjectPrjTabEN.UpdDate = objRow[convCmProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCmProjectPrjTabEN.UpdUser = objRow[convCmProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCmProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCmProjectPrjTabEN.Memo = objRow[convCmProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCmProjectPrjTab.Memo].ToString().Trim(); //说明
objvCmProjectPrjTabEN.SqlDsTypeId = objRow[convCmProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCmProjectPrjTabEN.SqlDsTypeName = objRow[convCmProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCmProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCmProjectPrjTabEN.TabRecNum = objRow[convCmProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCmProjectPrjTabEN.TabTypeId = objRow[convCmProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCmProjectPrjTabEN.TabStateId = objRow[convCmProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCmProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectPrjTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCmProjectPrjTab(ref clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
bool bolResult = vCmProjectPrjTabDA.GetvCmProjectPrjTab(ref objvCmProjectPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectPrjTabEN GetObjBymId(long lngmId)
{
clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = vCmProjectPrjTabDA.GetObjBymId(lngmId);
return objvCmProjectPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCmProjectPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = vCmProjectPrjTabDA.GetFirstObj(strWhereCond);
 return objvCmProjectPrjTabEN;
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
public static clsvCmProjectPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = vCmProjectPrjTabDA.GetObjByDataRow(objRow);
 return objvCmProjectPrjTabEN;
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
public static clsvCmProjectPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCmProjectPrjTabEN objvCmProjectPrjTabEN = vCmProjectPrjTabDA.GetObjByDataRow(objRow);
 return objvCmProjectPrjTabEN;
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
 /// <param name = "lstvCmProjectPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCmProjectPrjTabEN GetObjBymIdFromList(long lngmId, List<clsvCmProjectPrjTabEN> lstvCmProjectPrjTabObjLst)
{
foreach (clsvCmProjectPrjTabEN objvCmProjectPrjTabEN in lstvCmProjectPrjTabObjLst)
{
if (objvCmProjectPrjTabEN.mId == lngmId)
{
return objvCmProjectPrjTabEN;
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
 lngmId = new clsvCmProjectPrjTabDA().GetFirstID(strWhereCond);
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
 arrList = vCmProjectPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = vCmProjectPrjTabDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCmProjectPrjTabDA.IsExist(lngmId);
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
 bolIsExist = clsvCmProjectPrjTabDA.IsExistTable();
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
 bolIsExist = vCmProjectPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvCmProjectPrjTabENS">源对象</param>
 /// <param name = "objvCmProjectPrjTabENT">目标对象</param>
 public static void CopyTo(clsvCmProjectPrjTabEN objvCmProjectPrjTabENS, clsvCmProjectPrjTabEN objvCmProjectPrjTabENT)
{
try
{
objvCmProjectPrjTabENT.mId = objvCmProjectPrjTabENS.mId; //mId
objvCmProjectPrjTabENT.CmPrjId = objvCmProjectPrjTabENS.CmPrjId; //Cm工程Id
objvCmProjectPrjTabENT.CmPrjName = objvCmProjectPrjTabENS.CmPrjName; //CM工程名
objvCmProjectPrjTabENT.PrjId = objvCmProjectPrjTabENS.PrjId; //工程Id
objvCmProjectPrjTabENT.TabId = objvCmProjectPrjTabENS.TabId; //表ID
objvCmProjectPrjTabENT.TabName = objvCmProjectPrjTabENS.TabName; //表名
objvCmProjectPrjTabENT.FuncModuleAgcId = objvCmProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCmProjectPrjTabENT.FuncModuleName = objvCmProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCmProjectPrjTabENT.OrderNum = objvCmProjectPrjTabENS.OrderNum; //序号
objvCmProjectPrjTabENT.UpdDate = objvCmProjectPrjTabENS.UpdDate; //修改日期
objvCmProjectPrjTabENT.UpdUser = objvCmProjectPrjTabENS.UpdUser; //修改者
objvCmProjectPrjTabENT.Memo = objvCmProjectPrjTabENS.Memo; //说明
objvCmProjectPrjTabENT.SqlDsTypeId = objvCmProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCmProjectPrjTabENT.SqlDsTypeName = objvCmProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCmProjectPrjTabENT.TabRecNum = objvCmProjectPrjTabENS.TabRecNum; //记录数
objvCmProjectPrjTabENT.TabTypeId = objvCmProjectPrjTabENS.TabTypeId; //表类型Id
objvCmProjectPrjTabENT.TabStateId = objvCmProjectPrjTabENS.TabStateId; //表状态ID
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
 /// <param name = "objvCmProjectPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
try
{
objvCmProjectPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCmProjectPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCmProjectPrjTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.mId = objvCmProjectPrjTabEN.mId; //mId
}
if (arrFldSet.Contains(convCmProjectPrjTab.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.CmPrjId = objvCmProjectPrjTabEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCmProjectPrjTab.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.CmPrjName = objvCmProjectPrjTabEN.CmPrjName == "[null]" ? null :  objvCmProjectPrjTabEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCmProjectPrjTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.PrjId = objvCmProjectPrjTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCmProjectPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.TabId = objvCmProjectPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convCmProjectPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.TabName = objvCmProjectPrjTabEN.TabName; //表名
}
if (arrFldSet.Contains(convCmProjectPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.FuncModuleAgcId = objvCmProjectPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objvCmProjectPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCmProjectPrjTab.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.FuncModuleName = objvCmProjectPrjTabEN.FuncModuleName == "[null]" ? null :  objvCmProjectPrjTabEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCmProjectPrjTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.OrderNum = objvCmProjectPrjTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCmProjectPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.UpdDate = objvCmProjectPrjTabEN.UpdDate == "[null]" ? null :  objvCmProjectPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCmProjectPrjTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.UpdUser = objvCmProjectPrjTabEN.UpdUser == "[null]" ? null :  objvCmProjectPrjTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCmProjectPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.Memo = objvCmProjectPrjTabEN.Memo == "[null]" ? null :  objvCmProjectPrjTabEN.Memo; //说明
}
if (arrFldSet.Contains(convCmProjectPrjTab.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.SqlDsTypeId = objvCmProjectPrjTabEN.SqlDsTypeId == "[null]" ? null :  objvCmProjectPrjTabEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(convCmProjectPrjTab.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.SqlDsTypeName = objvCmProjectPrjTabEN.SqlDsTypeName == "[null]" ? null :  objvCmProjectPrjTabEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convCmProjectPrjTab.TabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.TabRecNum = objvCmProjectPrjTabEN.TabRecNum; //记录数
}
if (arrFldSet.Contains(convCmProjectPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.TabTypeId = objvCmProjectPrjTabEN.TabTypeId == "[null]" ? null :  objvCmProjectPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convCmProjectPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectPrjTabEN.TabStateId = objvCmProjectPrjTabEN.TabStateId == "[null]" ? null :  objvCmProjectPrjTabEN.TabStateId; //表状态ID
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
 /// <param name = "objvCmProjectPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
try
{
if (objvCmProjectPrjTabEN.CmPrjName == "[null]") objvCmProjectPrjTabEN.CmPrjName = null; //CM工程名
if (objvCmProjectPrjTabEN.FuncModuleAgcId == "[null]") objvCmProjectPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objvCmProjectPrjTabEN.FuncModuleName == "[null]") objvCmProjectPrjTabEN.FuncModuleName = null; //功能模块名称
if (objvCmProjectPrjTabEN.UpdDate == "[null]") objvCmProjectPrjTabEN.UpdDate = null; //修改日期
if (objvCmProjectPrjTabEN.UpdUser == "[null]") objvCmProjectPrjTabEN.UpdUser = null; //修改者
if (objvCmProjectPrjTabEN.Memo == "[null]") objvCmProjectPrjTabEN.Memo = null; //说明
if (objvCmProjectPrjTabEN.SqlDsTypeId == "[null]") objvCmProjectPrjTabEN.SqlDsTypeId = null; //数据源类型Id
if (objvCmProjectPrjTabEN.SqlDsTypeName == "[null]") objvCmProjectPrjTabEN.SqlDsTypeName = null; //Sql数据源名
if (objvCmProjectPrjTabEN.TabTypeId == "[null]") objvCmProjectPrjTabEN.TabTypeId = null; //表类型Id
if (objvCmProjectPrjTabEN.TabStateId == "[null]") objvCmProjectPrjTabEN.TabStateId = null; //表状态ID
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
public static void CheckProperty4Condition(clsvCmProjectPrjTabEN objvCmProjectPrjTabEN)
{
 vCmProjectPrjTabDA.CheckProperty4Condition(objvCmProjectPrjTabEN);
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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCmProjectPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCmProjectPrjTabBL没有刷新缓存机制(clsCmProjectPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCmProjectPrjTabObjLstCache == null)
//{
//arrvCmProjectPrjTabObjLstCache = vCmProjectPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCmProjectPrjTabEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLst_Sel =
arrvCmProjectPrjTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCmProjectPrjTabObjLst_Sel.Count() == 0)
{
   clsvCmProjectPrjTabEN obj = clsvCmProjectPrjTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCmProjectPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetAllvCmProjectPrjTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvCmProjectPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectPrjTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCmProjectPrjTabEN> arrvCmProjectPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCmProjectPrjTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCmProjectPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCmProjectPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCmProjectPrjTabEN._RefreshTimeLst.Count == 0) return "";
return clsvCmProjectPrjTabEN._RefreshTimeLst[clsvCmProjectPrjTabEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convCmProjectPrjTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCmProjectPrjTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCmProjectPrjTab._AttributeName));
throw new Exception(strMsg);
}
var objvCmProjectPrjTab = clsvCmProjectPrjTabBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvCmProjectPrjTab == null) return "";
return objvCmProjectPrjTab[strOutFldName].ToString();
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
int intRecCount = clsvCmProjectPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvCmProjectPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCmProjectPrjTabDA.GetRecCount();
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
int intRecCount = clsvCmProjectPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCmProjectPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCmProjectPrjTabEN objvCmProjectPrjTabCond)
{
 string strPrjId = objvCmProjectPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCmProjectPrjTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCmProjectPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCmProjectPrjTab._AttributeName)
{
if (objvCmProjectPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvCmProjectPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectPrjTabCond[strFldName].ToString());
}
else
{
if (objvCmProjectPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCmProjectPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCmProjectPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCmProjectPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCmProjectPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCmProjectPrjTabCond[strFldName]));
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
 List<string> arrList = clsvCmProjectPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCmProjectPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCmProjectPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}