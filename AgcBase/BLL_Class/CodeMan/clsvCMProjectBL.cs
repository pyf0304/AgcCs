
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectBL
 表名:vCMProject(00050513)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvCMProjectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectEN GetObj(this K_CmPrjId_vCMProject myKey)
{
clsvCMProjectEN objvCMProjectEN = clsvCMProjectBL.vCMProjectDA.GetObjByCmPrjId(myKey.Value);
return objvCMProjectEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetCmPrjId(this clsvCMProjectEN objvCMProjectEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProject.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProject.CmPrjId);
}
objvCMProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.CmPrjId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetCmPrjName(this clsvCMProjectEN objvCMProjectEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProject.CmPrjName);
}
objvCMProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.CmPrjName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetPrjId(this clsvCMProjectEN objvCMProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProject.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProject.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProject.PrjId);
}
objvCMProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.PrjId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.PrjId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.PrjId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetPrjName(this clsvCMProjectEN objvCMProjectEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMProject.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMProject.PrjName);
}
objvCMProjectEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.PrjName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.PrjName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.PrjName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetApplicationTypeId(this clsvCMProjectEN objvCMProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMProject.ApplicationTypeId);
objvCMProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ApplicationTypeId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetApplicationTypeSimName(this clsvCMProjectEN objvCMProjectEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMProject.ApplicationTypeSimName);
}
objvCMProjectEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ApplicationTypeSimName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetProjectFileName(this clsvCMProjectEN objvCMProjectEN, string strProjectFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMProject.ProjectFileName);
}
objvCMProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ProjectFileName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ProjectFileName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ProjectFileName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUseStateId(this clsvCMProjectEN objvCMProjectEN, string strUseStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convCMProject.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convCMProject.UseStateId);
}
objvCMProjectEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UseStateId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UseStateId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UseStateId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUseStateName(this clsvCMProjectEN objvCMProjectEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convCMProject.UseStateName);
}
objvCMProjectEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UseStateName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UseStateName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UseStateName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetIsRefresh4RelaView(this clsvCMProjectEN objvCMProjectEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objvCMProjectEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.IsRefresh4RelaView) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.IsRefresh4RelaView, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.IsRefresh4RelaView] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUpdDate(this clsvCMProjectEN objvCMProjectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProject.UpdDate);
}
objvCMProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UpdDate) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UpdDate, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UpdDate] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUpdUserId(this clsvCMProjectEN objvCMProjectEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCMProject.UpdUserId);
}
objvCMProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UpdUserId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UpdUserId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UpdUserId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetMemo(this clsvCMProjectEN objvCMProjectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProject.Memo);
}
objvCMProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.Memo) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.Memo, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.Memo] = strComparisonOp;
}
}
return objvCMProjectEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMProjectENS">源对象</param>
 /// <param name = "objvCMProjectENT">目标对象</param>
 public static void CopyTo(this clsvCMProjectEN objvCMProjectENS, clsvCMProjectEN objvCMProjectENT)
{
try
{
objvCMProjectENT.CmPrjId = objvCMProjectENS.CmPrjId; //Cm工程Id
objvCMProjectENT.CmPrjName = objvCMProjectENS.CmPrjName; //CM工程名
objvCMProjectENT.PrjId = objvCMProjectENS.PrjId; //工程Id
objvCMProjectENT.PrjName = objvCMProjectENS.PrjName; //工程名称
objvCMProjectENT.ApplicationTypeId = objvCMProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectENT.ApplicationTypeSimName = objvCMProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectENT.ProjectFileName = objvCMProjectENS.ProjectFileName; //工程文件名
objvCMProjectENT.UseStateId = objvCMProjectENS.UseStateId; //使用状态Id
objvCMProjectENT.UseStateName = objvCMProjectENS.UseStateName; //使用状态名称
objvCMProjectENT.IsRefresh4RelaView = objvCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objvCMProjectENT.UpdDate = objvCMProjectENS.UpdDate; //修改日期
objvCMProjectENT.UpdUserId = objvCMProjectENS.UpdUserId; //修改用户Id
objvCMProjectENT.Memo = objvCMProjectENS.Memo; //说明
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
 /// <param name = "objvCMProjectENS">源对象</param>
 /// <returns>目标对象=>clsvCMProjectEN:objvCMProjectENT</returns>
 public static clsvCMProjectEN CopyTo(this clsvCMProjectEN objvCMProjectENS)
{
try
{
 clsvCMProjectEN objvCMProjectENT = new clsvCMProjectEN()
{
CmPrjId = objvCMProjectENS.CmPrjId, //Cm工程Id
CmPrjName = objvCMProjectENS.CmPrjName, //CM工程名
PrjId = objvCMProjectENS.PrjId, //工程Id
PrjName = objvCMProjectENS.PrjName, //工程名称
ApplicationTypeId = objvCMProjectENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeSimName = objvCMProjectENS.ApplicationTypeSimName, //应用程序类型简称
ProjectFileName = objvCMProjectENS.ProjectFileName, //工程文件名
UseStateId = objvCMProjectENS.UseStateId, //使用状态Id
UseStateName = objvCMProjectENS.UseStateName, //使用状态名称
IsRefresh4RelaView = objvCMProjectENS.IsRefresh4RelaView, //是否刷新相关视图
UpdDate = objvCMProjectENS.UpdDate, //修改日期
UpdUserId = objvCMProjectENS.UpdUserId, //修改用户Id
Memo = objvCMProjectENS.Memo, //说明
};
 return objvCMProjectENT;
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
public static void CheckProperty4Condition(this clsvCMProjectEN objvCMProjectEN)
{
 clsvCMProjectBL.vCMProjectDA.CheckProperty4Condition(objvCMProjectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectEN objvCMProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectCond.IsUpdated(convCMProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectCond.dicFldComparisonOp[convCMProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.CmPrjId, objvCMProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectCond.dicFldComparisonOp[convCMProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.CmPrjName, objvCMProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectCond.dicFldComparisonOp[convCMProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.PrjId, objvCMProjectCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.PrjName) == true)
{
string strComparisonOpPrjName = objvCMProjectCond.dicFldComparisonOp[convCMProject.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.PrjName, objvCMProjectCond.PrjName, strComparisonOpPrjName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMProjectCond.dicFldComparisonOp[convCMProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProject.ApplicationTypeId, objvCMProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMProjectCond.dicFldComparisonOp[convCMProject.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.ApplicationTypeSimName, objvCMProjectCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvCMProjectCond.dicFldComparisonOp[convCMProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.ProjectFileName, objvCMProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UseStateId) == true)
{
string strComparisonOpUseStateId = objvCMProjectCond.dicFldComparisonOp[convCMProject.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UseStateId, objvCMProjectCond.UseStateId, strComparisonOpUseStateId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UseStateName) == true)
{
string strComparisonOpUseStateName = objvCMProjectCond.dicFldComparisonOp[convCMProject.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UseStateName, objvCMProjectCond.UseStateName, strComparisonOpUseStateName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.IsRefresh4RelaView) == true)
{
if (objvCMProjectCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMProject.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMProject.IsRefresh4RelaView);
}
}
if (objvCMProjectCond.IsUpdated(convCMProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectCond.dicFldComparisonOp[convCMProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UpdDate, objvCMProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCMProjectCond.dicFldComparisonOp[convCMProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UpdUserId, objvCMProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectCond.dicFldComparisonOp[convCMProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.Memo, objvCMProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMProject
{
public virtual bool UpdRelaTabDate(string strCmPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM项目(vCMProject)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectBL
{
public static RelatedActions_vCMProject relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMProjectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMProjectDA vCMProjectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMProjectDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMProjectBL()
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
if (string.IsNullOrEmpty(clsvCMProjectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectEN._ConnectString);
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
public static DataTable GetDataTable_vCMProject(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMProjectDA.GetDataTable_vCMProject(strWhereCond);
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
objDT = vCMProjectDA.GetDataTable(strWhereCond);
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
objDT = vCMProjectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMProjectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMProjectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMProjectDA.GetDataTable_Top(objTopPara);
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
objDT = vCMProjectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMProjectEN> GetObjLstByCmPrjIdLst(List<string> arrCmPrjIdLst)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmPrjIdLst, true);
 string strWhereCond = string.Format("CmPrjId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMProjectEN> GetObjLstByCmPrjIdLstCache(List<string> arrCmPrjIdLst)
{
string strKey = string.Format("{0}", clsvCMProjectEN._CurrTabName);
List<clsvCMProjectEN> arrvCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMProjectEN> arrvCMProjectObjLst_Sel =
arrvCMProjectObjLstCache
.Where(x => arrCmPrjIdLst.Contains(x.CmPrjId));
return arrvCMProjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectEN> GetObjLst(string strWhereCond)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
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
public static List<clsvCMProjectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMProjectEN> GetSubObjLstCache(clsvCMProjectEN objvCMProjectCond)
{
List<clsvCMProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProject._AttributeName)
{
if (objvCMProjectCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectCond[strFldName].ToString());
}
else
{
if (objvCMProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectCond[strFldName]));
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
public static List<clsvCMProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
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
public static List<clsvCMProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
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
List<clsvCMProjectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMProjectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
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
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
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
public static List<clsvCMProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
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
public static List<clsvCMProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMProjectEN> arrObjLst = new List<clsvCMProjectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN();
try
{
objvCMProjectEN.CmPrjId = objRow[convCMProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectEN.CmPrjName = objRow[convCMProject.CmPrjName] == DBNull.Value ? null : objRow[convCMProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectEN.PrjId = objRow[convCMProject.PrjId].ToString().Trim(); //工程Id
objvCMProjectEN.PrjName = objRow[convCMProject.PrjName].ToString().Trim(); //工程名称
objvCMProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectEN.ApplicationTypeSimName = objRow[convCMProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectEN.ProjectFileName = objRow[convCMProject.ProjectFileName] == DBNull.Value ? null : objRow[convCMProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMProjectEN.UseStateId = objRow[convCMProject.UseStateId] == DBNull.Value ? null : objRow[convCMProject.UseStateId].ToString().Trim(); //使用状态Id
objvCMProjectEN.UseStateName = objRow[convCMProject.UseStateName] == DBNull.Value ? null : objRow[convCMProject.UseStateName].ToString().Trim(); //使用状态名称
objvCMProjectEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convCMProject.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvCMProjectEN.UpdDate = objRow[convCMProject.UpdDate] == DBNull.Value ? null : objRow[convCMProject.UpdDate].ToString().Trim(); //修改日期
objvCMProjectEN.UpdUserId = objRow[convCMProject.UpdUserId] == DBNull.Value ? null : objRow[convCMProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMProjectEN.Memo = objRow[convCMProject.Memo] == DBNull.Value ? null : objRow[convCMProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectEN.CmPrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMProjectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMProject(ref clsvCMProjectEN objvCMProjectEN)
{
bool bolResult = vCMProjectDA.GetvCMProject(ref objvCMProjectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
if (strCmPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMProjectEN objvCMProjectEN = vCMProjectDA.GetObjByCmPrjId(strCmPrjId);
return objvCMProjectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMProjectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMProjectEN objvCMProjectEN = vCMProjectDA.GetFirstObj(strWhereCond);
 return objvCMProjectEN;
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
public static clsvCMProjectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMProjectEN objvCMProjectEN = vCMProjectDA.GetObjByDataRow(objRow);
 return objvCMProjectEN;
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
public static clsvCMProjectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMProjectEN objvCMProjectEN = vCMProjectDA.GetObjByDataRow(objRow);
 return objvCMProjectEN;
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
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <param name = "lstvCMProjectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectEN GetObjByCmPrjIdFromList(string strCmPrjId, List<clsvCMProjectEN> lstvCMProjectObjLst)
{
foreach (clsvCMProjectEN objvCMProjectEN in lstvCMProjectObjLst)
{
if (objvCMProjectEN.CmPrjId == strCmPrjId)
{
return objvCMProjectEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxCmPrjId;
 try
 {
 strMaxCmPrjId = clsvCMProjectDA.GetMaxStrId();
 return strMaxCmPrjId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strCmPrjId;
 try
 {
 strCmPrjId = new clsvCMProjectDA().GetFirstID(strWhereCond);
 return strCmPrjId;
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
 arrList = vCMProjectDA.GetID(strWhereCond);
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
bool bolIsExist = vCMProjectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmPrjId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMProjectDA.IsExist(strCmPrjId);
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
 bolIsExist = clsvCMProjectDA.IsExistTable();
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
 bolIsExist = vCMProjectDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMProjectENS">源对象</param>
 /// <param name = "objvCMProjectENT">目标对象</param>
 public static void CopyTo(clsvCMProjectEN objvCMProjectENS, clsvCMProjectEN objvCMProjectENT)
{
try
{
objvCMProjectENT.CmPrjId = objvCMProjectENS.CmPrjId; //Cm工程Id
objvCMProjectENT.CmPrjName = objvCMProjectENS.CmPrjName; //CM工程名
objvCMProjectENT.PrjId = objvCMProjectENS.PrjId; //工程Id
objvCMProjectENT.PrjName = objvCMProjectENS.PrjName; //工程名称
objvCMProjectENT.ApplicationTypeId = objvCMProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectENT.ApplicationTypeSimName = objvCMProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectENT.ProjectFileName = objvCMProjectENS.ProjectFileName; //工程文件名
objvCMProjectENT.UseStateId = objvCMProjectENS.UseStateId; //使用状态Id
objvCMProjectENT.UseStateName = objvCMProjectENS.UseStateName; //使用状态名称
objvCMProjectENT.IsRefresh4RelaView = objvCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objvCMProjectENT.UpdDate = objvCMProjectENS.UpdDate; //修改日期
objvCMProjectENT.UpdUserId = objvCMProjectENS.UpdUserId; //修改用户Id
objvCMProjectENT.Memo = objvCMProjectENS.Memo; //说明
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
 /// <param name = "objvCMProjectEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMProjectEN objvCMProjectEN)
{
try
{
objvCMProjectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMProjectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMProject.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.CmPrjId = objvCMProjectEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMProject.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.CmPrjName = objvCMProjectEN.CmPrjName == "[null]" ? null :  objvCMProjectEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMProject.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.PrjId = objvCMProjectEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMProject.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.PrjName = objvCMProjectEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMProject.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.ApplicationTypeId = objvCMProjectEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMProject.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.ApplicationTypeSimName = objvCMProjectEN.ApplicationTypeSimName == "[null]" ? null :  objvCMProjectEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMProject.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.ProjectFileName = objvCMProjectEN.ProjectFileName == "[null]" ? null :  objvCMProjectEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(convCMProject.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.UseStateId = objvCMProjectEN.UseStateId == "[null]" ? null :  objvCMProjectEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(convCMProject.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.UseStateName = objvCMProjectEN.UseStateName == "[null]" ? null :  objvCMProjectEN.UseStateName; //使用状态名称
}
if (arrFldSet.Contains(convCMProject.IsRefresh4RelaView, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.IsRefresh4RelaView = objvCMProjectEN.IsRefresh4RelaView; //是否刷新相关视图
}
if (arrFldSet.Contains(convCMProject.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.UpdDate = objvCMProjectEN.UpdDate == "[null]" ? null :  objvCMProjectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMProject.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.UpdUserId = objvCMProjectEN.UpdUserId == "[null]" ? null :  objvCMProjectEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCMProject.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectEN.Memo = objvCMProjectEN.Memo == "[null]" ? null :  objvCMProjectEN.Memo; //说明
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
 /// <param name = "objvCMProjectEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMProjectEN objvCMProjectEN)
{
try
{
if (objvCMProjectEN.CmPrjName == "[null]") objvCMProjectEN.CmPrjName = null; //CM工程名
if (objvCMProjectEN.ApplicationTypeSimName == "[null]") objvCMProjectEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMProjectEN.ProjectFileName == "[null]") objvCMProjectEN.ProjectFileName = null; //工程文件名
if (objvCMProjectEN.UseStateId == "[null]") objvCMProjectEN.UseStateId = null; //使用状态Id
if (objvCMProjectEN.UseStateName == "[null]") objvCMProjectEN.UseStateName = null; //使用状态名称
if (objvCMProjectEN.UpdDate == "[null]") objvCMProjectEN.UpdDate = null; //修改日期
if (objvCMProjectEN.UpdUserId == "[null]") objvCMProjectEN.UpdUserId = null; //修改用户Id
if (objvCMProjectEN.Memo == "[null]") objvCMProjectEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMProjectEN objvCMProjectEN)
{
 vCMProjectDA.CheckProperty4Condition(objvCMProjectEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CmPrjId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMProject.CmPrjId); 
List<clsvCMProjectEN> arrObjLst = clsvCMProjectBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN()
{
CmPrjId = "0",
CmPrjName = "选[vCM项目]..."
};
arrObjLst.Insert(0, objvCMProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMProject.CmPrjId;
objComboBox.DisplayMember = convCMProject.CmPrjName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CmPrjId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM项目]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCMProject.CmPrjId); 
IEnumerable<clsvCMProjectEN> arrObjLst = clsvCMProjectBL.GetObjLst(strCondition);
objDDL.DataValueField = convCMProject.CmPrjId;
objDDL.DataTextField = convCMProject.CmPrjName;
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
public static void BindDdl_CmPrjIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM项目]...","0");
List<clsvCMProjectEN> arrvCMProjectObjLst = GetAllvCMProjectObjLstCache(); 
objDDL.DataValueField = convCMProject.CmPrjId;
objDDL.DataTextField = convCMProject.CmPrjName;
objDDL.DataSource = arrvCMProjectObjLst;
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
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmPrjId");
//if (arrvCMProjectObjLstCache == null)
//{
//arrvCMProjectObjLstCache = vCMProjectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectEN GetObjByCmPrjIdCache(string strCmPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMProjectEN._CurrTabName);
List<clsvCMProjectEN> arrvCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMProjectEN> arrvCMProjectObjLst_Sel =
arrvCMProjectObjLstCache
.Where(x=> x.CmPrjId == strCmPrjId 
);
if (arrvCMProjectObjLst_Sel.Count() == 0)
{
   clsvCMProjectEN obj = clsvCMProjectBL.GetObjByCmPrjId(strCmPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMProjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCmPrjNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//获取缓存中的对象列表
clsvCMProjectEN objvCMProject = GetObjByCmPrjIdCache(strCmPrjId);
if (objvCMProject == null) return "";
return objvCMProject.CmPrjName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//获取缓存中的对象列表
clsvCMProjectEN objvCMProject = GetObjByCmPrjIdCache(strCmPrjId);
if (objvCMProject == null) return "";
return objvCMProject.CmPrjName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectEN> GetAllvCMProjectObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMProjectEN> arrvCMProjectObjLstCache = GetObjLstCache(); 
return arrvCMProjectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMProjectEN._CurrTabName);
List<clsvCMProjectEN> arrvCMProjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMProjectObjLstCache;
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
string strKey = string.Format("{0}", clsvCMProjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCMProjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMProjectEN._RefreshTimeLst.Count == 0) return "";
return clsvCMProjectEN._RefreshTimeLst[clsvCMProjectEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCmPrjId)
{
if (strInFldName != convCMProject.CmPrjId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMProject._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMProject._AttributeName));
throw new Exception(strMsg);
}
var objvCMProject = clsvCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
if (objvCMProject == null) return "";
return objvCMProject[strOutFldName].ToString();
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
int intRecCount = clsvCMProjectDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMProjectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMProjectDA.GetRecCount();
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
int intRecCount = clsvCMProjectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMProjectEN objvCMProjectCond)
{
List<clsvCMProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProject._AttributeName)
{
if (objvCMProjectCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectCond[strFldName].ToString());
}
else
{
if (objvCMProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectCond[strFldName]));
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
 List<string> arrList = clsvCMProjectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}