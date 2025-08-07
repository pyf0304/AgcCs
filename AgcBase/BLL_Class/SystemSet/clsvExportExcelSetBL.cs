
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcelSetBL
 表名:vExportExcelSet(00050238)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvExportExcelSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcelSetEN GetObj(this K_IdExportExcel4Users_vExportExcelSet myKey)
{
clsvExportExcelSetEN objvExportExcelSetEN = clsvExportExcelSetBL.vExportExcelSetDA.GetObjByIdExportExcel4Users(myKey.Value);
return objvExportExcelSetEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetIdExportExcel4Users(this clsvExportExcelSetEN objvExportExcelSetEN, string strIdExportExcel4Users, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExportExcel4Users, 8, convExportExcelSet.IdExportExcel4Users);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExportExcel4Users, 8, convExportExcelSet.IdExportExcel4Users);
}
objvExportExcelSetEN.IdExportExcel4Users = strIdExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.IdExportExcel4Users) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.IdExportExcel4Users, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.IdExportExcel4Users] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetViewName(this clsvExportExcelSetEN objvExportExcelSetEN, string strViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convExportExcelSet.ViewName);
}
objvExportExcelSetEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ViewName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ViewName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ViewName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetTabName(this clsvExportExcelSetEN objvExportExcelSetEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convExportExcelSet.TabName);
}
objvExportExcelSetEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.TabName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.TabName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.TabName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetIsDefaultUser(this clsvExportExcelSetEN objvExportExcelSetEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, convExportExcelSet.IsDefaultUser);
objvExportExcelSetEN.IsDefaultUser = bolIsDefaultUser; //是否缺省用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.IsDefaultUser) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.IsDefaultUser, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.IsDefaultUser] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetUserName(this clsvExportExcelSetEN objvExportExcelSetEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convExportExcelSet.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convExportExcelSet.UserName);
}
objvExportExcelSetEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UserName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UserName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UserName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetExportFileName(this clsvExportExcelSetEN objvExportExcelSetEN, string strExportFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExportFileName, convExportExcelSet.ExportFileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExportFileName, 100, convExportExcelSet.ExportFileName);
}
objvExportExcelSetEN.ExportFileName = strExportFileName; //导出文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ExportFileName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ExportFileName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ExportFileName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetUpdUserId(this clsvExportExcelSetEN objvExportExcelSetEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convExportExcelSet.UpdUserId);
}
objvExportExcelSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UpdUserId) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UpdUserId, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UpdUserId] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetUpdDate(this clsvExportExcelSetEN objvExportExcelSetEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExportExcelSet.UpdDate);
}
objvExportExcelSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UpdDate) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UpdDate, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UpdDate] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetMemo(this clsvExportExcelSetEN objvExportExcelSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExportExcelSet.Memo);
}
objvExportExcelSetEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.Memo) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.Memo, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.Memo] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetUserId(this clsvExportExcelSetEN objvExportExcelSetEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convExportExcelSet.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convExportExcelSet.UserId);
}
objvExportExcelSetEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.UserId) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.UserId, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.UserId] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvExportExcelSetEN SetViewTabName(this clsvExportExcelSetEN objvExportExcelSetEN, string strViewTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTabName, convExportExcelSet.ViewTabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTabName, 101, convExportExcelSet.ViewTabName);
}
objvExportExcelSetEN.ViewTabName = strViewTabName; //ViewTabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcelSetEN.dicFldComparisonOp.ContainsKey(convExportExcelSet.ViewTabName) == false)
{
objvExportExcelSetEN.dicFldComparisonOp.Add(convExportExcelSet.ViewTabName, strComparisonOp);
}
else
{
objvExportExcelSetEN.dicFldComparisonOp[convExportExcelSet.ViewTabName] = strComparisonOp;
}
}
return objvExportExcelSetEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvExportExcelSetENS">源对象</param>
 /// <param name = "objvExportExcelSetENT">目标对象</param>
 public static void CopyTo(this clsvExportExcelSetEN objvExportExcelSetENS, clsvExportExcelSetEN objvExportExcelSetENT)
{
try
{
objvExportExcelSetENT.IdExportExcel4Users = objvExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcelSetENT.ViewName = objvExportExcelSetENS.ViewName; //界面名称
objvExportExcelSetENT.TabName = objvExportExcelSetENS.TabName; //表名
objvExportExcelSetENT.IsDefaultUser = objvExportExcelSetENS.IsDefaultUser; //是否缺省用户
objvExportExcelSetENT.UserName = objvExportExcelSetENS.UserName; //用户名
objvExportExcelSetENT.ExportFileName = objvExportExcelSetENS.ExportFileName; //导出文件名
objvExportExcelSetENT.UpdUserId = objvExportExcelSetENS.UpdUserId; //修改用户Id
objvExportExcelSetENT.UpdDate = objvExportExcelSetENS.UpdDate; //修改日期
objvExportExcelSetENT.Memo = objvExportExcelSetENS.Memo; //说明
objvExportExcelSetENT.UserId = objvExportExcelSetENS.UserId; //用户Id
objvExportExcelSetENT.ViewTabName = objvExportExcelSetENS.ViewTabName; //ViewTabName
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
 /// <param name = "objvExportExcelSetENS">源对象</param>
 /// <returns>目标对象=>clsvExportExcelSetEN:objvExportExcelSetENT</returns>
 public static clsvExportExcelSetEN CopyTo(this clsvExportExcelSetEN objvExportExcelSetENS)
{
try
{
 clsvExportExcelSetEN objvExportExcelSetENT = new clsvExportExcelSetEN()
{
IdExportExcel4Users = objvExportExcelSetENS.IdExportExcel4Users, //导出Excel用户字段流水号
ViewName = objvExportExcelSetENS.ViewName, //界面名称
TabName = objvExportExcelSetENS.TabName, //表名
IsDefaultUser = objvExportExcelSetENS.IsDefaultUser, //是否缺省用户
UserName = objvExportExcelSetENS.UserName, //用户名
ExportFileName = objvExportExcelSetENS.ExportFileName, //导出文件名
UpdUserId = objvExportExcelSetENS.UpdUserId, //修改用户Id
UpdDate = objvExportExcelSetENS.UpdDate, //修改日期
Memo = objvExportExcelSetENS.Memo, //说明
UserId = objvExportExcelSetENS.UserId, //用户Id
ViewTabName = objvExportExcelSetENS.ViewTabName, //ViewTabName
};
 return objvExportExcelSetENT;
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
public static void CheckProperty4Condition(this clsvExportExcelSetEN objvExportExcelSetEN)
{
 clsvExportExcelSetBL.vExportExcelSetDA.CheckProperty4Condition(objvExportExcelSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvExportExcelSetEN objvExportExcelSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.IdExportExcel4Users) == true)
{
string strComparisonOpIdExportExcel4Users = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.IdExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.IdExportExcel4Users, objvExportExcelSetCond.IdExportExcel4Users, strComparisonOpIdExportExcel4Users);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.ViewName) == true)
{
string strComparisonOpViewName = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ViewName, objvExportExcelSetCond.ViewName, strComparisonOpViewName);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.TabName) == true)
{
string strComparisonOpTabName = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.TabName, objvExportExcelSetCond.TabName, strComparisonOpTabName);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.IsDefaultUser) == true)
{
if (objvExportExcelSetCond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcelSet.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcelSet.IsDefaultUser);
}
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.UserName) == true)
{
string strComparisonOpUserName = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UserName, objvExportExcelSetCond.UserName, strComparisonOpUserName);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.ExportFileName) == true)
{
string strComparisonOpExportFileName = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.ExportFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ExportFileName, objvExportExcelSetCond.ExportFileName, strComparisonOpExportFileName);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UpdUserId, objvExportExcelSetCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UpdDate, objvExportExcelSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.Memo) == true)
{
string strComparisonOpMemo = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.Memo, objvExportExcelSetCond.Memo, strComparisonOpMemo);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.UserId) == true)
{
string strComparisonOpUserId = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.UserId, objvExportExcelSetCond.UserId, strComparisonOpUserId);
}
if (objvExportExcelSetCond.IsUpdated(convExportExcelSet.ViewTabName) == true)
{
string strComparisonOpViewTabName = objvExportExcelSetCond.dicFldComparisonOp[convExportExcelSet.ViewTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcelSet.ViewTabName, objvExportExcelSetCond.ViewTabName, strComparisonOpViewTabName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vExportExcelSet
{
public virtual bool UpdRelaTabDate(string strIdExportExcel4Users, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v导出Excel设置(vExportExcelSet)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcelSetBL
{
public static RelatedActions_vExportExcelSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvExportExcelSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvExportExcelSetDA vExportExcelSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvExportExcelSetDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvExportExcelSetBL()
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
if (string.IsNullOrEmpty(clsvExportExcelSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExportExcelSetEN._ConnectString);
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
public static DataTable GetDataTable_vExportExcelSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vExportExcelSetDA.GetDataTable_vExportExcelSet(strWhereCond);
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
objDT = vExportExcelSetDA.GetDataTable(strWhereCond);
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
objDT = vExportExcelSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vExportExcelSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vExportExcelSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vExportExcelSetDA.GetDataTable_Top(objTopPara);
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
objDT = vExportExcelSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vExportExcelSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vExportExcelSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdExportExcel4UsersLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLstByIdExportExcel4UsersLst(List<string> arrIdExportExcel4UsersLst)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdExportExcel4UsersLst, true);
 string strWhereCond = string.Format("IdExportExcel4Users in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdExportExcel4UsersLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvExportExcelSetEN> GetObjLstByIdExportExcel4UsersLstCache(List<string> arrIdExportExcel4UsersLst)
{
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel =
arrvExportExcelSetObjLstCache
.Where(x => arrIdExportExcel4UsersLst.Contains(x.IdExportExcel4Users));
return arrvExportExcelSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLst(string strWhereCond)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
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
public static List<clsvExportExcelSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvExportExcelSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvExportExcelSetEN> GetSubObjLstCache(clsvExportExcelSetEN objvExportExcelSetCond)
{
List<clsvExportExcelSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcelSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExportExcelSet._AttributeName)
{
if (objvExportExcelSetCond.IsUpdated(strFldName) == false) continue;
if (objvExportExcelSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcelSetCond[strFldName].ToString());
}
else
{
if (objvExportExcelSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExportExcelSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcelSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExportExcelSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExportExcelSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExportExcelSetCond[strFldName]));
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
public static List<clsvExportExcelSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
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
public static List<clsvExportExcelSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
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
List<clsvExportExcelSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvExportExcelSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvExportExcelSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
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
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
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
public static List<clsvExportExcelSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvExportExcelSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
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
public static List<clsvExportExcelSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvExportExcelSetEN.IdExportExcel4Users, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvExportExcelSet(ref clsvExportExcelSetEN objvExportExcelSetEN)
{
bool bolResult = vExportExcelSetDA.GetvExportExcelSet(ref objvExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcelSetEN GetObjByIdExportExcel4Users(string strIdExportExcel4Users)
{
if (strIdExportExcel4Users.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdExportExcel4Users]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdExportExcel4Users]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvExportExcelSetEN objvExportExcelSetEN = vExportExcelSetDA.GetObjByIdExportExcel4Users(strIdExportExcel4Users);
return objvExportExcelSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvExportExcelSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvExportExcelSetEN objvExportExcelSetEN = vExportExcelSetDA.GetFirstObj(strWhereCond);
 return objvExportExcelSetEN;
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
public static clsvExportExcelSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvExportExcelSetEN objvExportExcelSetEN = vExportExcelSetDA.GetObjByDataRow(objRow);
 return objvExportExcelSetEN;
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
public static clsvExportExcelSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvExportExcelSetEN objvExportExcelSetEN = vExportExcelSetDA.GetObjByDataRow(objRow);
 return objvExportExcelSetEN;
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
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <param name = "lstvExportExcelSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcelSetEN GetObjByIdExportExcel4UsersFromList(string strIdExportExcel4Users, List<clsvExportExcelSetEN> lstvExportExcelSetObjLst)
{
foreach (clsvExportExcelSetEN objvExportExcelSetEN in lstvExportExcelSetObjLst)
{
if (objvExportExcelSetEN.IdExportExcel4Users == strIdExportExcel4Users)
{
return objvExportExcelSetEN;
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
 string strIdExportExcel4Users;
 try
 {
 strIdExportExcel4Users = new clsvExportExcelSetDA().GetFirstID(strWhereCond);
 return strIdExportExcel4Users;
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
 arrList = vExportExcelSetDA.GetID(strWhereCond);
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
bool bolIsExist = vExportExcelSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdExportExcel4Users)
{
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdExportExcel4Users]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vExportExcelSetDA.IsExist(strIdExportExcel4Users);
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
 bolIsExist = clsvExportExcelSetDA.IsExistTable();
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
 bolIsExist = vExportExcelSetDA.IsExistTable(strTabName);
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
 /// <param name = "objvExportExcelSetENS">源对象</param>
 /// <param name = "objvExportExcelSetENT">目标对象</param>
 public static void CopyTo(clsvExportExcelSetEN objvExportExcelSetENS, clsvExportExcelSetEN objvExportExcelSetENT)
{
try
{
objvExportExcelSetENT.IdExportExcel4Users = objvExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcelSetENT.ViewName = objvExportExcelSetENS.ViewName; //界面名称
objvExportExcelSetENT.TabName = objvExportExcelSetENS.TabName; //表名
objvExportExcelSetENT.IsDefaultUser = objvExportExcelSetENS.IsDefaultUser; //是否缺省用户
objvExportExcelSetENT.UserName = objvExportExcelSetENS.UserName; //用户名
objvExportExcelSetENT.ExportFileName = objvExportExcelSetENS.ExportFileName; //导出文件名
objvExportExcelSetENT.UpdUserId = objvExportExcelSetENS.UpdUserId; //修改用户Id
objvExportExcelSetENT.UpdDate = objvExportExcelSetENS.UpdDate; //修改日期
objvExportExcelSetENT.Memo = objvExportExcelSetENS.Memo; //说明
objvExportExcelSetENT.UserId = objvExportExcelSetENS.UserId; //用户Id
objvExportExcelSetENT.ViewTabName = objvExportExcelSetENS.ViewTabName; //ViewTabName
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
 /// <param name = "objvExportExcelSetEN">源简化对象</param>
 public static void SetUpdFlag(clsvExportExcelSetEN objvExportExcelSetEN)
{
try
{
objvExportExcelSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvExportExcelSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convExportExcelSet.IdExportExcel4Users, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.IdExportExcel4Users = objvExportExcelSetEN.IdExportExcel4Users; //导出Excel用户字段流水号
}
if (arrFldSet.Contains(convExportExcelSet.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.ViewName = objvExportExcelSetEN.ViewName == "[null]" ? null :  objvExportExcelSetEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convExportExcelSet.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.TabName = objvExportExcelSetEN.TabName == "[null]" ? null :  objvExportExcelSetEN.TabName; //表名
}
if (arrFldSet.Contains(convExportExcelSet.IsDefaultUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.IsDefaultUser = objvExportExcelSetEN.IsDefaultUser; //是否缺省用户
}
if (arrFldSet.Contains(convExportExcelSet.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.UserName = objvExportExcelSetEN.UserName; //用户名
}
if (arrFldSet.Contains(convExportExcelSet.ExportFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.ExportFileName = objvExportExcelSetEN.ExportFileName; //导出文件名
}
if (arrFldSet.Contains(convExportExcelSet.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.UpdUserId = objvExportExcelSetEN.UpdUserId == "[null]" ? null :  objvExportExcelSetEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convExportExcelSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.UpdDate = objvExportExcelSetEN.UpdDate == "[null]" ? null :  objvExportExcelSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convExportExcelSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.Memo = objvExportExcelSetEN.Memo == "[null]" ? null :  objvExportExcelSetEN.Memo; //说明
}
if (arrFldSet.Contains(convExportExcelSet.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.UserId = objvExportExcelSetEN.UserId; //用户Id
}
if (arrFldSet.Contains(convExportExcelSet.ViewTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvExportExcelSetEN.ViewTabName = objvExportExcelSetEN.ViewTabName; //ViewTabName
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
 /// <param name = "objvExportExcelSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsvExportExcelSetEN objvExportExcelSetEN)
{
try
{
if (objvExportExcelSetEN.ViewName == "[null]") objvExportExcelSetEN.ViewName = null; //界面名称
if (objvExportExcelSetEN.TabName == "[null]") objvExportExcelSetEN.TabName = null; //表名
if (objvExportExcelSetEN.UpdUserId == "[null]") objvExportExcelSetEN.UpdUserId = null; //修改用户Id
if (objvExportExcelSetEN.UpdDate == "[null]") objvExportExcelSetEN.UpdDate = null; //修改日期
if (objvExportExcelSetEN.Memo == "[null]") objvExportExcelSetEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvExportExcelSetEN objvExportExcelSetEN)
{
 vExportExcelSetDA.CheckProperty4Condition(objvExportExcelSetEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdExportExcel4Users(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convExportExcelSet.IdExportExcel4Users); 
List<clsvExportExcelSetEN> arrObjLst = clsvExportExcelSetBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN()
{
IdExportExcel4Users = "0",
ViewTabName = "选[v导出Excel设置]..."
};
arrObjLst.Insert(0, objvExportExcelSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convExportExcelSet.IdExportExcel4Users;
objComboBox.DisplayMember = convExportExcelSet.ViewTabName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v导出Excel设置]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convExportExcelSet.IdExportExcel4Users); 
IEnumerable<clsvExportExcelSetEN> arrObjLst = clsvExportExcelSetBL.GetObjLst(strCondition);
objDDL.DataValueField = convExportExcelSet.IdExportExcel4Users;
objDDL.DataTextField = convExportExcelSet.ViewTabName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdExportExcel4UsersCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v导出Excel设置]...","0");
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst = GetAllvExportExcelSetObjLstCache(); 
objDDL.DataValueField = convExportExcelSet.IdExportExcel4Users;
objDDL.DataTextField = convExportExcelSet.ViewTabName;
objDDL.DataSource = arrvExportExcelSetObjLst;
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExportExcelSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcelSetBL没有刷新缓存机制(clsExportExcelSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdExportExcel4Users");
//if (arrvExportExcelSetObjLstCache == null)
//{
//arrvExportExcelSetObjLstCache = vExportExcelSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcelSetEN GetObjByIdExportExcel4UsersCache(string strIdExportExcel4Users)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcelSetEN> arrvExportExcelSetObjLst_Sel =
arrvExportExcelSetObjLstCache
.Where(x=> x.IdExportExcel4Users == strIdExportExcel4Users 
);
if (arrvExportExcelSetObjLst_Sel.Count() == 0)
{
   clsvExportExcelSetEN obj = clsvExportExcelSetBL.GetObjByIdExportExcel4Users(strIdExportExcel4Users);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvExportExcelSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewTabNameByIdExportExcel4UsersCache(string strIdExportExcel4Users)
{
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true) return "";
//获取缓存中的对象列表
clsvExportExcelSetEN objvExportExcelSet = GetObjByIdExportExcel4UsersCache(strIdExportExcel4Users);
if (objvExportExcelSet == null) return "";
return objvExportExcelSet.ViewTabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdExportExcel4UsersCache(string strIdExportExcel4Users)
{
if (string.IsNullOrEmpty(strIdExportExcel4Users) == true) return "";
//获取缓存中的对象列表
clsvExportExcelSetEN objvExportExcelSet = GetObjByIdExportExcel4UsersCache(strIdExportExcel4Users);
if (objvExportExcelSet == null) return "";
return objvExportExcelSet.ViewTabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExportExcelSetEN> GetAllvExportExcelSetObjLstCache()
{
//获取缓存中的对象列表
List<clsvExportExcelSetEN> arrvExportExcelSetObjLstCache = GetObjLstCache(); 
return arrvExportExcelSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName);
List<clsvExportExcelSetEN> arrvExportExcelSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvExportExcelSetObjLstCache;
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
string strKey = string.Format("{0}", clsvExportExcelSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvExportExcelSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvExportExcelSetEN._RefreshTimeLst.Count == 0) return "";
return clsvExportExcelSetEN._RefreshTimeLst[clsvExportExcelSetEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdExportExcel4Users)
{
if (strInFldName != convExportExcelSet.IdExportExcel4Users)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convExportExcelSet._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convExportExcelSet._AttributeName));
throw new Exception(strMsg);
}
var objvExportExcelSet = clsvExportExcelSetBL.GetObjByIdExportExcel4UsersCache(strIdExportExcel4Users);
if (objvExportExcelSet == null) return "";
return objvExportExcelSet[strOutFldName].ToString();
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
int intRecCount = clsvExportExcelSetDA.GetRecCount(strTabName);
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
int intRecCount = clsvExportExcelSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvExportExcelSetDA.GetRecCount();
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
int intRecCount = clsvExportExcelSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvExportExcelSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvExportExcelSetEN objvExportExcelSetCond)
{
List<clsvExportExcelSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvExportExcelSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convExportExcelSet._AttributeName)
{
if (objvExportExcelSetCond.IsUpdated(strFldName) == false) continue;
if (objvExportExcelSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcelSetCond[strFldName].ToString());
}
else
{
if (objvExportExcelSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvExportExcelSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvExportExcelSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvExportExcelSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvExportExcelSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvExportExcelSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvExportExcelSetCond[strFldName]));
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
 List<string> arrList = clsvExportExcelSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vExportExcelSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vExportExcelSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}