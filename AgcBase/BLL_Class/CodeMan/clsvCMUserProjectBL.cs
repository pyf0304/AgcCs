
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMUserProjectBL
 表名:vCMUserProject(00050514)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:40
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
public static class  clsvCMUserProjectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMUserProjectEN GetObj(this K_mId_vCMUserProject myKey)
{
clsvCMUserProjectEN objvCMUserProjectEN = clsvCMUserProjectBL.vCMUserProjectDA.GetObjBymId(myKey.Value);
return objvCMUserProjectEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetmId(this clsvCMUserProjectEN objvCMUserProjectEN, long lngmId, string strComparisonOp="")
	{
objvCMUserProjectEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.mId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.mId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.mId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUserId(this clsvCMUserProjectEN objvCMUserProjectEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMUserProject.UserId);
}
objvCMUserProjectEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UserId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UserId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UserId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUserName(this clsvCMUserProjectEN objvCMUserProjectEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCMUserProject.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convCMUserProject.UserName);
}
objvCMUserProjectEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UserName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UserName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UserName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetCmPrjId(this clsvCMUserProjectEN objvCMUserProjectEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMUserProject.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMUserProject.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMUserProject.CmPrjId);
}
objvCMUserProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.CmPrjId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.CmPrjId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.CmPrjId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetCmPrjName(this clsvCMUserProjectEN objvCMUserProjectEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMUserProject.CmPrjName);
}
objvCMUserProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.CmPrjName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.CmPrjName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.CmPrjName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetPrjId(this clsvCMUserProjectEN objvCMUserProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMUserProject.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMUserProject.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMUserProject.PrjId);
}
objvCMUserProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.PrjId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.PrjId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.PrjId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetPrjName(this clsvCMUserProjectEN objvCMUserProjectEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMUserProject.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMUserProject.PrjName);
}
objvCMUserProjectEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.PrjName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.PrjName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.PrjName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetApplicationTypeId(this clsvCMUserProjectEN objvCMUserProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMUserProject.ApplicationTypeId);
objvCMUserProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ApplicationTypeId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetApplicationTypeSimName(this clsvCMUserProjectEN objvCMUserProjectEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMUserProject.ApplicationTypeSimName);
}
objvCMUserProjectEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ApplicationTypeSimName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetProjectFileName(this clsvCMUserProjectEN objvCMUserProjectEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectFileName, convCMUserProject.ProjectFileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMUserProject.ProjectFileName);
}
objvCMUserProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ProjectFileName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ProjectFileName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ProjectFileName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetProjectPath(this clsvCMUserProjectEN objvCMUserProjectEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMUserProject.ProjectPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMUserProject.ProjectPath);
}
objvCMUserProjectEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ProjectPath) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ProjectPath, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ProjectPath] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUpdDate(this clsvCMUserProjectEN objvCMUserProjectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMUserProject.UpdDate);
}
objvCMUserProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UpdDate) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UpdDate, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UpdDate] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUpdUserId(this clsvCMUserProjectEN objvCMUserProjectEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCMUserProject.UpdUserId);
}
objvCMUserProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UpdUserId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UpdUserId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UpdUserId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetMemo(this clsvCMUserProjectEN objvCMUserProjectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMUserProject.Memo);
}
objvCMUserProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.Memo) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.Memo, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.Memo] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMUserProjectENS">源对象</param>
 /// <param name = "objvCMUserProjectENT">目标对象</param>
 public static void CopyTo(this clsvCMUserProjectEN objvCMUserProjectENS, clsvCMUserProjectEN objvCMUserProjectENT)
{
try
{
objvCMUserProjectENT.mId = objvCMUserProjectENS.mId; //mId
objvCMUserProjectENT.UserId = objvCMUserProjectENS.UserId; //用户Id
objvCMUserProjectENT.UserName = objvCMUserProjectENS.UserName; //用户名
objvCMUserProjectENT.CmPrjId = objvCMUserProjectENS.CmPrjId; //Cm工程Id
objvCMUserProjectENT.CmPrjName = objvCMUserProjectENS.CmPrjName; //CM工程名
objvCMUserProjectENT.PrjId = objvCMUserProjectENS.PrjId; //工程Id
objvCMUserProjectENT.PrjName = objvCMUserProjectENS.PrjName; //工程名称
objvCMUserProjectENT.ApplicationTypeId = objvCMUserProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMUserProjectENT.ApplicationTypeSimName = objvCMUserProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMUserProjectENT.ProjectFileName = objvCMUserProjectENS.ProjectFileName; //工程文件名
objvCMUserProjectENT.ProjectPath = objvCMUserProjectENS.ProjectPath; //工程路径
objvCMUserProjectENT.UpdDate = objvCMUserProjectENS.UpdDate; //修改日期
objvCMUserProjectENT.UpdUserId = objvCMUserProjectENS.UpdUserId; //修改用户Id
objvCMUserProjectENT.Memo = objvCMUserProjectENS.Memo; //说明
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
 /// <param name = "objvCMUserProjectENS">源对象</param>
 /// <returns>目标对象=>clsvCMUserProjectEN:objvCMUserProjectENT</returns>
 public static clsvCMUserProjectEN CopyTo(this clsvCMUserProjectEN objvCMUserProjectENS)
{
try
{
 clsvCMUserProjectEN objvCMUserProjectENT = new clsvCMUserProjectEN()
{
mId = objvCMUserProjectENS.mId, //mId
UserId = objvCMUserProjectENS.UserId, //用户Id
UserName = objvCMUserProjectENS.UserName, //用户名
CmPrjId = objvCMUserProjectENS.CmPrjId, //Cm工程Id
CmPrjName = objvCMUserProjectENS.CmPrjName, //CM工程名
PrjId = objvCMUserProjectENS.PrjId, //工程Id
PrjName = objvCMUserProjectENS.PrjName, //工程名称
ApplicationTypeId = objvCMUserProjectENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeSimName = objvCMUserProjectENS.ApplicationTypeSimName, //应用程序类型简称
ProjectFileName = objvCMUserProjectENS.ProjectFileName, //工程文件名
ProjectPath = objvCMUserProjectENS.ProjectPath, //工程路径
UpdDate = objvCMUserProjectENS.UpdDate, //修改日期
UpdUserId = objvCMUserProjectENS.UpdUserId, //修改用户Id
Memo = objvCMUserProjectENS.Memo, //说明
};
 return objvCMUserProjectENT;
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
public static void CheckProperty4Condition(this clsvCMUserProjectEN objvCMUserProjectEN)
{
 clsvCMUserProjectBL.vCMUserProjectDA.CheckProperty4Condition(objvCMUserProjectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMUserProjectEN objvCMUserProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.mId) == true)
{
string strComparisonOpmId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMUserProject.mId, objvCMUserProjectCond.mId, strComparisonOpmId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UserId) == true)
{
string strComparisonOpUserId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UserId, objvCMUserProjectCond.UserId, strComparisonOpUserId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UserName) == true)
{
string strComparisonOpUserName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UserName, objvCMUserProjectCond.UserName, strComparisonOpUserName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.CmPrjId, objvCMUserProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.CmPrjName, objvCMUserProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.PrjId) == true)
{
string strComparisonOpPrjId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.PrjId, objvCMUserProjectCond.PrjId, strComparisonOpPrjId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.PrjName) == true)
{
string strComparisonOpPrjName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.PrjName, objvCMUserProjectCond.PrjName, strComparisonOpPrjName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMUserProject.ApplicationTypeId, objvCMUserProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ApplicationTypeSimName, objvCMUserProjectCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ProjectFileName, objvCMUserProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ProjectPath, objvCMUserProjectCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UpdDate, objvCMUserProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UpdUserId, objvCMUserProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.Memo) == true)
{
string strComparisonOpMemo = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.Memo, objvCMUserProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMUserProject
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM用户工程(vCMUserProject)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMUserProjectBL
{
public static RelatedActions_vCMUserProject relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMUserProjectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMUserProjectDA vCMUserProjectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMUserProjectDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMUserProjectBL()
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
if (string.IsNullOrEmpty(clsvCMUserProjectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMUserProjectEN._ConnectString);
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
public static DataTable GetDataTable_vCMUserProject(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMUserProjectDA.GetDataTable_vCMUserProject(strWhereCond);
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
objDT = vCMUserProjectDA.GetDataTable(strWhereCond);
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
objDT = vCMUserProjectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMUserProjectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMUserProjectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMUserProjectDA.GetDataTable_Top(objTopPara);
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
objDT = vCMUserProjectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMUserProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMUserProjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCMUserProjectEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
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
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMUserProjectEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel =
arrvCMUserProjectObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMUserProjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMUserProjectEN> GetObjLst(string strWhereCond)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
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
public static List<clsvCMUserProjectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMUserProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMUserProjectEN> GetSubObjLstCache(clsvCMUserProjectEN objvCMUserProjectCond)
{
List<clsvCMUserProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMUserProject._AttributeName)
{
if (objvCMUserProjectCond.IsUpdated(strFldName) == false) continue;
if (objvCMUserProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMUserProjectCond[strFldName].ToString());
}
else
{
if (objvCMUserProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMUserProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMUserProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMUserProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMUserProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMUserProjectCond[strFldName]));
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
public static List<clsvCMUserProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
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
public static List<clsvCMUserProjectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
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
List<clsvCMUserProjectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMUserProjectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMUserProjectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMUserProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
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
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
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
public static List<clsvCMUserProjectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMUserProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMUserProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
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
public static List<clsvCMUserProjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMUserProjectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMUserProjectEN> arrObjLst = new List<clsvCMUserProjectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN();
try
{
objvCMUserProjectEN.mId = Int32.Parse(objRow[convCMUserProject.mId].ToString().Trim()); //mId
objvCMUserProjectEN.UserId = objRow[convCMUserProject.UserId] == DBNull.Value ? null : objRow[convCMUserProject.UserId].ToString().Trim(); //用户Id
objvCMUserProjectEN.UserName = objRow[convCMUserProject.UserName].ToString().Trim(); //用户名
objvCMUserProjectEN.CmPrjId = objRow[convCMUserProject.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMUserProjectEN.CmPrjName = objRow[convCMUserProject.CmPrjName] == DBNull.Value ? null : objRow[convCMUserProject.CmPrjName].ToString().Trim(); //CM工程名
objvCMUserProjectEN.PrjId = objRow[convCMUserProject.PrjId].ToString().Trim(); //工程Id
objvCMUserProjectEN.PrjName = objRow[convCMUserProject.PrjName].ToString().Trim(); //工程名称
objvCMUserProjectEN.ApplicationTypeId = Int32.Parse(objRow[convCMUserProject.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMUserProjectEN.ApplicationTypeSimName = objRow[convCMUserProject.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMUserProject.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMUserProjectEN.ProjectFileName = objRow[convCMUserProject.ProjectFileName].ToString().Trim(); //工程文件名
objvCMUserProjectEN.ProjectPath = objRow[convCMUserProject.ProjectPath].ToString().Trim(); //工程路径
objvCMUserProjectEN.UpdDate = objRow[convCMUserProject.UpdDate] == DBNull.Value ? null : objRow[convCMUserProject.UpdDate].ToString().Trim(); //修改日期
objvCMUserProjectEN.UpdUserId = objRow[convCMUserProject.UpdUserId] == DBNull.Value ? null : objRow[convCMUserProject.UpdUserId].ToString().Trim(); //修改用户Id
objvCMUserProjectEN.Memo = objRow[convCMUserProject.Memo] == DBNull.Value ? null : objRow[convCMUserProject.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMUserProjectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMUserProjectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMUserProject(ref clsvCMUserProjectEN objvCMUserProjectEN)
{
bool bolResult = vCMUserProjectDA.GetvCMUserProject(ref objvCMUserProjectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMUserProjectEN GetObjBymId(long lngmId)
{
clsvCMUserProjectEN objvCMUserProjectEN = vCMUserProjectDA.GetObjBymId(lngmId);
return objvCMUserProjectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMUserProjectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMUserProjectEN objvCMUserProjectEN = vCMUserProjectDA.GetFirstObj(strWhereCond);
 return objvCMUserProjectEN;
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
public static clsvCMUserProjectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMUserProjectEN objvCMUserProjectEN = vCMUserProjectDA.GetObjByDataRow(objRow);
 return objvCMUserProjectEN;
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
public static clsvCMUserProjectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMUserProjectEN objvCMUserProjectEN = vCMUserProjectDA.GetObjByDataRow(objRow);
 return objvCMUserProjectEN;
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
 /// <param name = "lstvCMUserProjectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMUserProjectEN GetObjBymIdFromList(long lngmId, List<clsvCMUserProjectEN> lstvCMUserProjectObjLst)
{
foreach (clsvCMUserProjectEN objvCMUserProjectEN in lstvCMUserProjectObjLst)
{
if (objvCMUserProjectEN.mId == lngmId)
{
return objvCMUserProjectEN;
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
 lngmId = new clsvCMUserProjectDA().GetFirstID(strWhereCond);
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
 arrList = vCMUserProjectDA.GetID(strWhereCond);
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
bool bolIsExist = vCMUserProjectDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCMUserProjectDA.IsExist(lngmId);
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
 bolIsExist = clsvCMUserProjectDA.IsExistTable();
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
 bolIsExist = vCMUserProjectDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMUserProjectENS">源对象</param>
 /// <param name = "objvCMUserProjectENT">目标对象</param>
 public static void CopyTo(clsvCMUserProjectEN objvCMUserProjectENS, clsvCMUserProjectEN objvCMUserProjectENT)
{
try
{
objvCMUserProjectENT.mId = objvCMUserProjectENS.mId; //mId
objvCMUserProjectENT.UserId = objvCMUserProjectENS.UserId; //用户Id
objvCMUserProjectENT.UserName = objvCMUserProjectENS.UserName; //用户名
objvCMUserProjectENT.CmPrjId = objvCMUserProjectENS.CmPrjId; //Cm工程Id
objvCMUserProjectENT.CmPrjName = objvCMUserProjectENS.CmPrjName; //CM工程名
objvCMUserProjectENT.PrjId = objvCMUserProjectENS.PrjId; //工程Id
objvCMUserProjectENT.PrjName = objvCMUserProjectENS.PrjName; //工程名称
objvCMUserProjectENT.ApplicationTypeId = objvCMUserProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMUserProjectENT.ApplicationTypeSimName = objvCMUserProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMUserProjectENT.ProjectFileName = objvCMUserProjectENS.ProjectFileName; //工程文件名
objvCMUserProjectENT.ProjectPath = objvCMUserProjectENS.ProjectPath; //工程路径
objvCMUserProjectENT.UpdDate = objvCMUserProjectENS.UpdDate; //修改日期
objvCMUserProjectENT.UpdUserId = objvCMUserProjectENS.UpdUserId; //修改用户Id
objvCMUserProjectENT.Memo = objvCMUserProjectENS.Memo; //说明
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
 /// <param name = "objvCMUserProjectEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMUserProjectEN objvCMUserProjectEN)
{
try
{
objvCMUserProjectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMUserProjectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMUserProject.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.mId = objvCMUserProjectEN.mId; //mId
}
if (arrFldSet.Contains(convCMUserProject.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.UserId = objvCMUserProjectEN.UserId == "[null]" ? null :  objvCMUserProjectEN.UserId; //用户Id
}
if (arrFldSet.Contains(convCMUserProject.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.UserName = objvCMUserProjectEN.UserName; //用户名
}
if (arrFldSet.Contains(convCMUserProject.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.CmPrjId = objvCMUserProjectEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMUserProject.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.CmPrjName = objvCMUserProjectEN.CmPrjName == "[null]" ? null :  objvCMUserProjectEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMUserProject.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.PrjId = objvCMUserProjectEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMUserProject.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.PrjName = objvCMUserProjectEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMUserProject.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.ApplicationTypeId = objvCMUserProjectEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMUserProject.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.ApplicationTypeSimName = objvCMUserProjectEN.ApplicationTypeSimName == "[null]" ? null :  objvCMUserProjectEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMUserProject.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.ProjectFileName = objvCMUserProjectEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(convCMUserProject.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.ProjectPath = objvCMUserProjectEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(convCMUserProject.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.UpdDate = objvCMUserProjectEN.UpdDate == "[null]" ? null :  objvCMUserProjectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMUserProject.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.UpdUserId = objvCMUserProjectEN.UpdUserId == "[null]" ? null :  objvCMUserProjectEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCMUserProject.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMUserProjectEN.Memo = objvCMUserProjectEN.Memo == "[null]" ? null :  objvCMUserProjectEN.Memo; //说明
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
 /// <param name = "objvCMUserProjectEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMUserProjectEN objvCMUserProjectEN)
{
try
{
if (objvCMUserProjectEN.UserId == "[null]") objvCMUserProjectEN.UserId = null; //用户Id
if (objvCMUserProjectEN.CmPrjName == "[null]") objvCMUserProjectEN.CmPrjName = null; //CM工程名
if (objvCMUserProjectEN.ApplicationTypeSimName == "[null]") objvCMUserProjectEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMUserProjectEN.UpdDate == "[null]") objvCMUserProjectEN.UpdDate = null; //修改日期
if (objvCMUserProjectEN.UpdUserId == "[null]") objvCMUserProjectEN.UpdUserId = null; //修改用户Id
if (objvCMUserProjectEN.Memo == "[null]") objvCMUserProjectEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMUserProjectEN objvCMUserProjectEN)
{
 vCMUserProjectDA.CheckProperty4Condition(objvCMUserProjectEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMUserProject.mId); 
List<clsvCMUserProjectEN> arrObjLst = clsvCMUserProjectBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN()
{
mId = 0,
UserId = "选[vCM用户工程]..."
};
arrObjLst.Insert(0, objvCMUserProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMUserProject.mId;
objComboBox.DisplayMember = convCMUserProject.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM用户工程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCMUserProject.mId); 
IEnumerable<clsvCMUserProjectEN> arrObjLst = clsvCMUserProjectBL.GetObjLst(strCondition);
objDDL.DataValueField = convCMUserProject.mId;
objDDL.DataTextField = convCMUserProject.UserId;
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
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM用户工程]...","0");
List<clsvCMUserProjectEN> arrvCMUserProjectObjLst = GetAllvCMUserProjectObjLstCache(); 
objDDL.DataValueField = convCMUserProject.mId;
objDDL.DataTextField = convCMUserProject.UserId;
objDDL.DataSource = arrvCMUserProjectObjLst;
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
if (clsCMUserProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMUserProjectBL没有刷新缓存机制(clsCMUserProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMUserProjectObjLstCache == null)
//{
//arrvCMUserProjectObjLstCache = vCMUserProjectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMUserProjectEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel =
arrvCMUserProjectObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMUserProjectObjLst_Sel.Count() == 0)
{
   clsvCMUserProjectEN obj = clsvCMUserProjectBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMUserProjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvCMUserProjectEN objvCMUserProject = GetObjBymIdCache(lngmId);
if (objvCMUserProject == null) return "";
return objvCMUserProject.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvCMUserProjectEN objvCMUserProject = GetObjBymIdCache(lngmId);
if (objvCMUserProject == null) return "";
return objvCMUserProject.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMUserProjectEN> GetAllvCMUserProjectObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache(); 
return arrvCMUserProjectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMUserProjectEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMUserProjectObjLstCache;
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
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCMUserProjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMUserProjectEN._RefreshTimeLst.Count == 0) return "";
return clsvCMUserProjectEN._RefreshTimeLst[clsvCMUserProjectEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convCMUserProject.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMUserProject._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMUserProject._AttributeName));
throw new Exception(strMsg);
}
var objvCMUserProject = clsvCMUserProjectBL.GetObjBymIdCache(lngmId);
if (objvCMUserProject == null) return "";
return objvCMUserProject[strOutFldName].ToString();
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
int intRecCount = clsvCMUserProjectDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMUserProjectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMUserProjectDA.GetRecCount();
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
int intRecCount = clsvCMUserProjectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMUserProjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMUserProjectEN objvCMUserProjectCond)
{
List<clsvCMUserProjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMUserProject._AttributeName)
{
if (objvCMUserProjectCond.IsUpdated(strFldName) == false) continue;
if (objvCMUserProjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMUserProjectCond[strFldName].ToString());
}
else
{
if (objvCMUserProjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMUserProjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMUserProjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMUserProjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMUserProjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMUserProjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMUserProjectCond[strFldName]));
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
 List<string> arrList = clsvCMUserProjectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMUserProjectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMUserProjectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}