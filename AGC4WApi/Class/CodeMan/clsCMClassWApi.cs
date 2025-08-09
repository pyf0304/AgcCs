
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassWApi
 表名:CMClass(00050501)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMClassWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetCmClassId(this clsCMClassEN objCMClassEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmClassId, 8, conCMClass.CmClassId);
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, conCMClass.CmClassId);
objCMClassEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.CmClassId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.CmClassId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.CmClassId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetApplicationTypeId(this clsCMClassEN objCMClassEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMClass.ApplicationTypeId);
objCMClassEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ApplicationTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ApplicationTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ApplicationTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetProgLangTypeId(this clsCMClassEN objCMClassEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conCMClass.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conCMClass.ProgLangTypeId);
objCMClassEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ProgLangTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ProgLangTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ProgLangTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetTabName(this clsCMClassEN objCMClassEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, conCMClass.TabName);
objCMClassEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.TabName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.TabName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.TabName] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetNameSpace(this clsCMClassEN objCMClassEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, conCMClass.NameSpace);
objCMClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.NameSpace) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.NameSpace, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.NameSpace] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetProjectPath(this clsCMClassEN objCMClassEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, conCMClass.ProjectPath);
clsCheckSql.CheckFieldLen(strProjectPath, 500, conCMClass.ProjectPath);
objCMClassEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ProjectPath) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ProjectPath, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ProjectPath] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFilePath(this clsCMClassEN objCMClassEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conCMClass.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, conCMClass.FilePath);
objCMClassEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FilePath) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FilePath, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FilePath] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFileName(this clsCMClassEN objCMClassEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conCMClass.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, conCMClass.FileName);
objCMClassEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FileName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FileName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FileName] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileText">文件内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFileText(this clsCMClassEN objCMClassEN, string strFileText, string strComparisonOp="")
	{
objCMClassEN.FileText = strFileText; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FileText) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FileText, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FileText] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetFuncModuleAgcId(this clsCMClassEN objCMClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMClass.FuncModuleAgcId);
objCMClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.FuncModuleAgcId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetCodeTypeId(this clsCMClassEN objCMClassEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCMClass.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCMClass.CodeTypeId);
objCMClassEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.CodeTypeId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.CodeTypeId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.CodeTypeId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUserId(this clsCMClassEN objCMClassEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, conCMClass.UserId);
objCMClassEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UserId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UserId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UserId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetPrjId(this clsCMClassEN objCMClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMClass.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMClass.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMClass.PrjId);
objCMClassEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.PrjId) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.PrjId, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.PrjId] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOpen">是否开放</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetIsOpen(this clsCMClassEN objCMClassEN, bool bolIsOpen, string strComparisonOp="")
	{
objCMClassEN.IsOpen = bolIsOpen; //是否开放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.IsOpen) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.IsOpen, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.IsOpen] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUpdDate(this clsCMClassEN objCMClassEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMClass.UpdDate);
objCMClassEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UpdDate) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UpdDate, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UpdDate] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetUpdUser(this clsCMClassEN objCMClassEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMClass.UpdUser);
objCMClassEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.UpdUser) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.UpdUser, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.UpdUser] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetMemo(this clsCMClassEN objCMClassEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMClass.Memo);
objCMClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.Memo) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.Memo, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.Memo] = strComparisonOp;
}
}
return objCMClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassEN SetClsName(this clsCMClassEN objCMClassEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, conCMClass.ClsName);
clsCheckSql.CheckFieldLen(strClsName, 100, conCMClass.ClsName);
objCMClassEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassEN.dicFldComparisonOp.ContainsKey(conCMClass.ClsName) == false)
{
objCMClassEN.dicFldComparisonOp.Add(conCMClass.ClsName, strComparisonOp);
}
else
{
objCMClassEN.dicFldComparisonOp[conCMClass.ClsName] = strComparisonOp;
}
}
return objCMClassEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMClassEN objCMClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMClassCond.IsUpdated(conCMClass.CmClassId) == true)
{
string strComparisonOpCmClassId = objCMClassCond.dicFldComparisonOp[conCMClass.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.CmClassId, objCMClassCond.CmClassId, strComparisonOpCmClassId);
}
if (objCMClassCond.IsUpdated(conCMClass.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMClass.ApplicationTypeId, objCMClassCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ProgLangTypeId, objCMClassCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.TabName) == true)
{
string strComparisonOpTabName = objCMClassCond.dicFldComparisonOp[conCMClass.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.TabName, objCMClassCond.TabName, strComparisonOpTabName);
}
if (objCMClassCond.IsUpdated(conCMClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objCMClassCond.dicFldComparisonOp[conCMClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.NameSpace, objCMClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objCMClassCond.IsUpdated(conCMClass.ProjectPath) == true)
{
string strComparisonOpProjectPath = objCMClassCond.dicFldComparisonOp[conCMClass.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ProjectPath, objCMClassCond.ProjectPath, strComparisonOpProjectPath);
}
if (objCMClassCond.IsUpdated(conCMClass.FilePath) == true)
{
string strComparisonOpFilePath = objCMClassCond.dicFldComparisonOp[conCMClass.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FilePath, objCMClassCond.FilePath, strComparisonOpFilePath);
}
if (objCMClassCond.IsUpdated(conCMClass.FileName) == true)
{
string strComparisonOpFileName = objCMClassCond.dicFldComparisonOp[conCMClass.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FileName, objCMClassCond.FileName, strComparisonOpFileName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objCMClassCond.IsUpdated(conCMClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMClassCond.dicFldComparisonOp[conCMClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.FuncModuleAgcId, objCMClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMClassCond.IsUpdated(conCMClass.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objCMClassCond.dicFldComparisonOp[conCMClass.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.CodeTypeId, objCMClassCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objCMClassCond.IsUpdated(conCMClass.UserId) == true)
{
string strComparisonOpUserId = objCMClassCond.dicFldComparisonOp[conCMClass.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UserId, objCMClassCond.UserId, strComparisonOpUserId);
}
if (objCMClassCond.IsUpdated(conCMClass.PrjId) == true)
{
string strComparisonOpPrjId = objCMClassCond.dicFldComparisonOp[conCMClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.PrjId, objCMClassCond.PrjId, strComparisonOpPrjId);
}
if (objCMClassCond.IsUpdated(conCMClass.IsOpen) == true)
{
if (objCMClassCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMClass.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMClass.IsOpen);
}
}
if (objCMClassCond.IsUpdated(conCMClass.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMClassCond.dicFldComparisonOp[conCMClass.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UpdDate, objCMClassCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMClassCond.IsUpdated(conCMClass.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMClassCond.dicFldComparisonOp[conCMClass.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.UpdUser, objCMClassCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMClassCond.IsUpdated(conCMClass.Memo) == true)
{
string strComparisonOpMemo = objCMClassCond.dicFldComparisonOp[conCMClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.Memo, objCMClassCond.Memo, strComparisonOpMemo);
}
if (objCMClassCond.IsUpdated(conCMClass.ClsName) == true)
{
string strComparisonOpClsName = objCMClassCond.dicFldComparisonOp[conCMClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClass.ClsName, objCMClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMClassEN objCMClassEN)
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMClassEN.sfUpdFldSetStr = objCMClassEN.getsfUpdFldSetStr();
clsCMClassWApi.CheckPropertyNew(objCMClassEN); 
bool bolResult = clsCMClassWApi.UpdateRecord(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
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
 /// 获取唯一性条件串--CMClass(CM类), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_NameSpace_ClsName_FileName_UserId_PrjId_ProgLangTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMClassEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMClassEN objCMClassEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMClassEN == null) return "";
if (objCMClassEN.CmClassId == null || objCMClassEN.CmClassId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmClassId !=  '{0}'", objCMClassEN.CmClassId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objCMClassEN.TabName);
 sbCondition.AppendFormat(" and NameSpace = '{0}'", objCMClassEN.NameSpace);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objCMClassEN.ClsName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objCMClassEN.FileName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCMClassEN.UserId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMClassEN.PrjId);
 sbCondition.AppendFormat(" and ProgLangTypeId = '{0}'", objCMClassEN.ProgLangTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMClassEN objCMClassEN)
{
try
{
 if (string.IsNullOrEmpty(objCMClassEN.CmClassId) == true || clsCMClassWApi.IsExist(objCMClassEN.CmClassId) == true)
 {
     objCMClassEN.CmClassId = clsCMClassWApi.GetMaxStrId();
 }
clsCMClassWApi.CheckPropertyNew(objCMClassEN); 
bool bolResult = clsCMClassWApi.AddNewRecord(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objCMClassEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMClassEN objCMClassEN)
{
try
{
clsCMClassWApi.CheckPropertyNew(objCMClassEN); 
string strCmClassId = clsCMClassWApi.AddNewRecordWithMaxId(objCMClassEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
return strCmClassId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMClassEN objCMClassEN, string strWhereCond)
{
try
{
clsCMClassWApi.CheckPropertyNew(objCMClassEN); 
bool bolResult = clsCMClassWApi.UpdateWithCondition(objCMClassEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
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
 /// CM类(CMClass)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMClassWApi
{
private static readonly string mstrApiControllerName = "CMClassApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCMClassWApi()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_CmClassId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMClass.CmClassId); 
List<clsCMClassEN> arrObjLst = clsCMClassWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMClassEN objCMClassEN = new clsCMClassEN()
{
CmClassId = "0",
ClsName = "选[CM类]..."
};
arrObjLstSel.Insert(0, objCMClassEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMClass.CmClassId;
objComboBox.DisplayMember = conCMClass.ClsName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMClassEN objCMClassEN)
{
if (!Object.Equals(null, objCMClassEN.CmClassId) && GetStrLen(objCMClassEN.CmClassId) > 8)
{
 throw new Exception("字段[类Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMClassEN.ProgLangTypeId) && GetStrLen(objCMClassEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCMClassEN.TabName) && GetStrLen(objCMClassEN.TabName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objCMClassEN.NameSpace) && GetStrLen(objCMClassEN.NameSpace) > 50)
{
 throw new Exception("字段[域名]的长度不能超过50!");
}
if (!Object.Equals(null, objCMClassEN.ProjectPath) && GetStrLen(objCMClassEN.ProjectPath) > 500)
{
 throw new Exception("字段[工程路径]的长度不能超过500!");
}
if (!Object.Equals(null, objCMClassEN.FilePath) && GetStrLen(objCMClassEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objCMClassEN.FileName) && GetStrLen(objCMClassEN.FileName) > 150)
{
 throw new Exception("字段[文件名]的长度不能超过150!");
}
if (!Object.Equals(null, objCMClassEN.FuncModuleAgcId) && GetStrLen(objCMClassEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMClassEN.CodeTypeId) && GetStrLen(objCMClassEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMClassEN.UserId) && GetStrLen(objCMClassEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objCMClassEN.PrjId) && GetStrLen(objCMClassEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMClassEN.UpdDate) && GetStrLen(objCMClassEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMClassEN.UpdUser) && GetStrLen(objCMClassEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMClassEN.Memo) && GetStrLen(objCMClassEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objCMClassEN.ClsName) && GetStrLen(objCMClassEN.ClsName) > 100)
{
 throw new Exception("字段[类名]的长度不能超过100!");
}
 objCMClassEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMClassEN GetObjByCmClassId(string strCmClassId)
{
if (strCmClassId == "") return null;
string strAction = "GetObjByCmClassId";
clsCMClassEN objCMClassEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmClassId"] = strCmClassId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMClassEN = JsonConvert.DeserializeObject<clsCMClassEN>(strJson);
return objCMClassEN;
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
public static clsCMClassEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMClassEN objCMClassEN;
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
objCMClassEN = JsonConvert.DeserializeObject<clsCMClassEN>(strJson);
return objCMClassEN;
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
 /// <param name = "strCmClassId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMClassEN GetObjByCmClassIdCache(string strCmClassId,string strPrjId)
{
if (string.IsNullOrEmpty(strCmClassId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
List<clsCMClassEN> arrCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrCMClassObjLst_Sel =
from objCMClassEN in arrCMClassObjLstCache
where objCMClassEN.CmClassId == strCmClassId 
select objCMClassEN;
if (arrCMClassObjLst_Sel.Count() == 0)
{
   clsCMClassEN obj = clsCMClassWApi.GetObjByCmClassId(strCmClassId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMClassObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetObjLst(string strWhereCond)
{
 List<clsCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
 /// <param name = "arrCmClassId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetObjLstByCmClassIdLst(List<string> arrCmClassId)
{
 List<clsCMClassEN> arrObjLst; 
string strAction = "GetObjLstByCmClassIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmClassId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
 /// <param name = "arrCmClassId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCMClassEN> GetObjLstByCmClassIdLstCache(List<string> arrCmClassId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
List<clsCMClassEN> arrCMClassObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassEN> arrCMClassObjLst_Sel =
from objCMClassEN in arrCMClassObjLstCache
where arrCmClassId.Contains(objCMClassEN.CmClassId)
select objCMClassEN;
return arrCMClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
public static List<clsCMClassEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
public static List<clsCMClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
public static List<clsCMClassEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMClassEN>>(strJson);
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
public static int DelRecord(string strCmClassId)
{
string strAction = "DelRecord";
try
{
 clsCMClassEN objCMClassEN = clsCMClassWApi.GetObjByCmClassId(strCmClassId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCmClassId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMClassWApi.ReFreshCache();
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
public static int DelCMClasss(List<string> arrCmClassId)
{
string strAction = "DelCMClasss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmClassId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMClassWApi.ReFreshCache();
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
public static int DelCMClasssByCond(string strWhereCond)
{
string strAction = "DelCMClasssByCond";
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
public static bool AddNewRecord(clsCMClassEN objCMClassEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMClassEN>(objCMClassEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsCMClassEN objCMClassEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMClassEN>(objCMClassEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassWApi.ReFreshCache();
var strCmClassId = (string)jobjReturn0["returnStr"];
return strCmClassId;
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
public static bool UpdateRecord(clsCMClassEN objCMClassEN)
{
if (string.IsNullOrEmpty(objCMClassEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMClassEN.CmClassId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMClassEN>(objCMClassEN);
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
 /// <param name = "objCMClassEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMClassEN objCMClassEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMClassEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMClassEN.CmClassId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMClassEN.CmClassId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMClassEN>(objCMClassEN);
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
public static bool IsExist(string strCmClassId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmClassId"] = strCmClassId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMClassENS">源对象</param>
 /// <param name = "objCMClassENT">目标对象</param>
 public static void CopyTo(clsCMClassEN objCMClassENS, clsCMClassEN objCMClassENT)
{
try
{
objCMClassENT.CmClassId = objCMClassENS.CmClassId; //类Id
objCMClassENT.ApplicationTypeId = objCMClassENS.ApplicationTypeId; //应用程序类型ID
objCMClassENT.ProgLangTypeId = objCMClassENS.ProgLangTypeId; //编程语言类型Id
objCMClassENT.TabName = objCMClassENS.TabName; //表名
objCMClassENT.NameSpace = objCMClassENS.NameSpace; //域名
objCMClassENT.ProjectPath = objCMClassENS.ProjectPath; //工程路径
objCMClassENT.FilePath = objCMClassENS.FilePath; //文件路径
objCMClassENT.FileName = objCMClassENS.FileName; //文件名
objCMClassENT.FileText = objCMClassENS.FileText; //文件内容
objCMClassENT.FuncModuleAgcId = objCMClassENS.FuncModuleAgcId; //功能模块Id
objCMClassENT.CodeTypeId = objCMClassENS.CodeTypeId; //代码类型Id
objCMClassENT.UserId = objCMClassENS.UserId; //用户Id
objCMClassENT.PrjId = objCMClassENS.PrjId; //工程Id
objCMClassENT.IsOpen = objCMClassENS.IsOpen; //是否开放
objCMClassENT.UpdDate = objCMClassENS.UpdDate; //修改日期
objCMClassENT.UpdUser = objCMClassENS.UpdUser; //修改者
objCMClassENT.Memo = objCMClassENS.Memo; //说明
objCMClassENT.ClsName = objCMClassENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsCMClassEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMClassEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMClassEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMClassEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMClassEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMClassEN._AttributeName)
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
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
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
if (clsCMClassWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMClassEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMClassWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMClassEN> GetObjLstCache(string strPrjId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCMClassEN._CurrTabName;
List<clsCMClassEN> arrCMClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMClassObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMClassEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMClass.CmClassId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMClass.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.FileText, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMClass.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCMClass.ClsName, Type.GetType("System.String"));
foreach (clsCMClassEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMClass.CmClassId] = objInFor[conCMClass.CmClassId];
objDR[conCMClass.ApplicationTypeId] = objInFor[conCMClass.ApplicationTypeId];
objDR[conCMClass.ProgLangTypeId] = objInFor[conCMClass.ProgLangTypeId];
objDR[conCMClass.TabName] = objInFor[conCMClass.TabName];
objDR[conCMClass.NameSpace] = objInFor[conCMClass.NameSpace];
objDR[conCMClass.ProjectPath] = objInFor[conCMClass.ProjectPath];
objDR[conCMClass.FilePath] = objInFor[conCMClass.FilePath];
objDR[conCMClass.FileName] = objInFor[conCMClass.FileName];
objDR[conCMClass.FileText] = objInFor[conCMClass.FileText];
objDR[conCMClass.FuncModuleAgcId] = objInFor[conCMClass.FuncModuleAgcId];
objDR[conCMClass.CodeTypeId] = objInFor[conCMClass.CodeTypeId];
objDR[conCMClass.UserId] = objInFor[conCMClass.UserId];
objDR[conCMClass.PrjId] = objInFor[conCMClass.PrjId];
objDR[conCMClass.IsOpen] = objInFor[conCMClass.IsOpen];
objDR[conCMClass.UpdDate] = objInFor[conCMClass.UpdDate];
objDR[conCMClass.UpdUser] = objInFor[conCMClass.UpdUser];
objDR[conCMClass.Memo] = objInFor[conCMClass.Memo];
objDR[conCMClass.ClsName] = objInFor[conCMClass.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM类(CMClass)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMClass : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsCMClassWApi.ReFreshThisCache(strPrjId);
}
}

}