
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewReferFilesWApi
 表名:vViewReferFiles(00050466)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvViewReferFilesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetmId(this clsvViewReferFilesEN objvViewReferFilesEN, long lngmId, string strComparisonOp="")
	{
objvViewReferFilesEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.mId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.mId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.mId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetViewId(this clsvViewReferFilesEN objvViewReferFilesEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewReferFiles.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewReferFiles.ViewId);
objvViewReferFilesEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.ViewId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.ViewId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.ViewId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetViewName(this clsvViewReferFilesEN objvViewReferFilesEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewReferFiles.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convViewReferFiles.ViewName);
objvViewReferFilesEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.ViewName) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.ViewName, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.ViewName] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetPrjId(this clsvViewReferFilesEN objvViewReferFilesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewReferFiles.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewReferFiles.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewReferFiles.PrjId);
objvViewReferFilesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.PrjId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.PrjId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.PrjId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetCodeTypeId(this clsvViewReferFilesEN objvViewReferFilesEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convViewReferFiles.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convViewReferFiles.CodeTypeId);
objvViewReferFilesEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.CodeTypeId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.CodeTypeId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.CodeTypeId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetCodeTypeName(this clsvViewReferFilesEN objvViewReferFilesEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convViewReferFiles.CodeTypeName);
objvViewReferFilesEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.CodeTypeName) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.CodeTypeName, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.CodeTypeName] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileId">引用文件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileId(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileId, 8, convViewReferFiles.ReferFileId);
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, convViewReferFiles.ReferFileId);
objvViewReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.ReferFileId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.ReferFileId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.ReferFileId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetFileName(this clsvViewReferFilesEN objvViewReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewReferFiles.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convViewReferFiles.FileName);
objvViewReferFilesEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.FileName) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.FileName, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.FileName] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileTypeId">引用文件类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileTypeId(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, convViewReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, convViewReferFiles.ReferFileTypeId);
objvViewReferFilesEN.ReferFileTypeId = strReferFileTypeId; //引用文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.ReferFileTypeId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.ReferFileTypeId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.ReferFileTypeId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileTypeName">引用文件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileTypeName(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileTypeName, 50, convViewReferFiles.ReferFileTypeName);
objvViewReferFilesEN.ReferFileTypeName = strReferFileTypeName; //引用文件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.ReferFileTypeName) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.ReferFileTypeName, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.ReferFileTypeName] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetFilePath(this clsvViewReferFilesEN objvViewReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewReferFiles.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewReferFiles.FilePath);
objvViewReferFilesEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.FilePath) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.FilePath, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.FilePath] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetInUse(this clsvViewReferFilesEN objvViewReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objvViewReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.InUse) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.InUse, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.InUse] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetOrderNum(this clsvViewReferFilesEN objvViewReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convViewReferFiles.OrderNum);
objvViewReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.OrderNum) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.OrderNum, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.OrderNum] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetIsTemplate(this clsvViewReferFilesEN objvViewReferFilesEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convViewReferFiles.IsTemplate);
objvViewReferFilesEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.IsTemplate) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.IsTemplate, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.IsTemplate] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetUpdDate(this clsvViewReferFilesEN objvViewReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewReferFiles.UpdDate);
objvViewReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.UpdDate) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.UpdDate, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.UpdDate] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetUpdUserId(this clsvViewReferFilesEN objvViewReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewReferFiles.UpdUserId);
objvViewReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.UpdUserId) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.UpdUserId, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.UpdUserId] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetMemo(this clsvViewReferFilesEN objvViewReferFilesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewReferFiles.Memo);
objvViewReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewReferFilesEN.dicFldComparisonOp.ContainsKey(convViewReferFiles.Memo) == false)
{
objvViewReferFilesEN.dicFldComparisonOp.Add(convViewReferFiles.Memo, strComparisonOp);
}
else
{
objvViewReferFilesEN.dicFldComparisonOp[convViewReferFiles.Memo] = strComparisonOp;
}
}
return objvViewReferFilesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewReferFilesEN objvViewReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.mId) == true)
{
string strComparisonOpmId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewReferFiles.mId, objvViewReferFilesCond.mId, strComparisonOpmId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.ViewId) == true)
{
string strComparisonOpViewId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.ViewId, objvViewReferFilesCond.ViewId, strComparisonOpViewId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.ViewName) == true)
{
string strComparisonOpViewName = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.ViewName, objvViewReferFilesCond.ViewName, strComparisonOpViewName);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.PrjId) == true)
{
string strComparisonOpPrjId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.PrjId, objvViewReferFilesCond.PrjId, strComparisonOpPrjId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.CodeTypeId, objvViewReferFilesCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.CodeTypeName, objvViewReferFilesCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.ReferFileId, objvViewReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.FileName) == true)
{
string strComparisonOpFileName = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.FileName, objvViewReferFilesCond.FileName, strComparisonOpFileName);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.ReferFileTypeId) == true)
{
string strComparisonOpReferFileTypeId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.ReferFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.ReferFileTypeId, objvViewReferFilesCond.ReferFileTypeId, strComparisonOpReferFileTypeId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.ReferFileTypeName) == true)
{
string strComparisonOpReferFileTypeName = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.ReferFileTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.ReferFileTypeName, objvViewReferFilesCond.ReferFileTypeName, strComparisonOpReferFileTypeName);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.FilePath) == true)
{
string strComparisonOpFilePath = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.FilePath, objvViewReferFilesCond.FilePath, strComparisonOpFilePath);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.InUse) == true)
{
if (objvViewReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewReferFiles.InUse);
}
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewReferFiles.OrderNum, objvViewReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.IsTemplate) == true)
{
if (objvViewReferFilesCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewReferFiles.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewReferFiles.IsTemplate);
}
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.UpdDate, objvViewReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.UpdUserId, objvViewReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvViewReferFilesCond.IsUpdated(convViewReferFiles.Memo) == true)
{
string strComparisonOpMemo = objvViewReferFilesCond.dicFldComparisonOp[convViewReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewReferFiles.Memo, objvViewReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面引用文件(vViewReferFiles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewReferFilesWApi
{
private static readonly string mstrApiControllerName = "vViewReferFilesApi";

 public clsvViewReferFilesWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewReferFilesEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvViewReferFilesEN objvViewReferFilesEN;
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
objvViewReferFilesEN = JsonConvert.DeserializeObject<clsvViewReferFilesEN>(strJson);
return objvViewReferFilesEN;
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
public static clsvViewReferFilesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewReferFilesEN objvViewReferFilesEN;
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
objvViewReferFilesEN = JsonConvert.DeserializeObject<clsvViewReferFilesEN>(strJson);
return objvViewReferFilesEN;
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
public static clsvViewReferFilesEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrvViewReferFilesObjLst_Sel =
from objvViewReferFilesEN in arrvViewReferFilesObjLstCache
where objvViewReferFilesEN.mId == lngmId 
select objvViewReferFilesEN;
if (arrvViewReferFilesObjLst_Sel.Count() == 0)
{
   clsvViewReferFilesEN obj = clsvViewReferFilesWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLst(string strWhereCond)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
public static List<clsvViewReferFilesEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
public static IEnumerable<clsvViewReferFilesEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrvViewReferFilesObjLst_Sel =
from objvViewReferFilesEN in arrvViewReferFilesObjLstCache
where arrMId.Contains(objvViewReferFilesEN.mId)
select objvViewReferFilesEN;
return arrvViewReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
public static List<clsvViewReferFilesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
public static List<clsvViewReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
public static List<clsvViewReferFilesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewReferFilesEN>>(strJson);
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
 /// <param name = "objvViewReferFilesENS">源对象</param>
 /// <param name = "objvViewReferFilesENT">目标对象</param>
 public static void CopyTo(clsvViewReferFilesEN objvViewReferFilesENS, clsvViewReferFilesEN objvViewReferFilesENT)
{
try
{
objvViewReferFilesENT.mId = objvViewReferFilesENS.mId; //mId
objvViewReferFilesENT.ViewId = objvViewReferFilesENS.ViewId; //界面Id
objvViewReferFilesENT.ViewName = objvViewReferFilesENS.ViewName; //界面名称
objvViewReferFilesENT.PrjId = objvViewReferFilesENS.PrjId; //工程Id
objvViewReferFilesENT.CodeTypeId = objvViewReferFilesENS.CodeTypeId; //代码类型Id
objvViewReferFilesENT.CodeTypeName = objvViewReferFilesENS.CodeTypeName; //代码类型名
objvViewReferFilesENT.ReferFileId = objvViewReferFilesENS.ReferFileId; //引用文件Id
objvViewReferFilesENT.FileName = objvViewReferFilesENS.FileName; //文件名
objvViewReferFilesENT.ReferFileTypeId = objvViewReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvViewReferFilesENT.ReferFileTypeName = objvViewReferFilesENS.ReferFileTypeName; //引用文件类型名
objvViewReferFilesENT.FilePath = objvViewReferFilesENS.FilePath; //文件路径
objvViewReferFilesENT.InUse = objvViewReferFilesENS.InUse; //是否在用
objvViewReferFilesENT.OrderNum = objvViewReferFilesENS.OrderNum; //序号
objvViewReferFilesENT.IsTemplate = objvViewReferFilesENS.IsTemplate; //是否模板
objvViewReferFilesENT.UpdDate = objvViewReferFilesENS.UpdDate; //修改日期
objvViewReferFilesENT.UpdUserId = objvViewReferFilesENS.UpdUserId; //修改用户Id
objvViewReferFilesENT.Memo = objvViewReferFilesENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvViewReferFilesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewReferFilesEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewReferFilesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewReferFilesEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewReferFilesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewReferFilesEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewReferFilesWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewReferFilesWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
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
public static List<clsvViewReferFilesEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewReferFilesWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewReferFilesWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvViewReferFilesEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvViewReferFilesEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convViewReferFiles.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewReferFilesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvViewReferFilesEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvViewReferFilesWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvViewReferFilesWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvViewReferFilesObjLstCache = CacheHelper.Get<List<clsvViewReferFilesEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvViewReferFilesObjLstCache = CacheHelper.Get<List<clsvViewReferFilesEN>>(strKey);
}
return arrvViewReferFilesObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewReferFilesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewReferFiles.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewReferFiles.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.ReferFileId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.ReferFileTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.ReferFileTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewReferFiles.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convViewReferFiles.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convViewReferFiles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewReferFiles.Memo, Type.GetType("System.String"));
foreach (clsvViewReferFilesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewReferFiles.mId] = objInFor[convViewReferFiles.mId];
objDR[convViewReferFiles.ViewId] = objInFor[convViewReferFiles.ViewId];
objDR[convViewReferFiles.ViewName] = objInFor[convViewReferFiles.ViewName];
objDR[convViewReferFiles.PrjId] = objInFor[convViewReferFiles.PrjId];
objDR[convViewReferFiles.CodeTypeId] = objInFor[convViewReferFiles.CodeTypeId];
objDR[convViewReferFiles.CodeTypeName] = objInFor[convViewReferFiles.CodeTypeName];
objDR[convViewReferFiles.ReferFileId] = objInFor[convViewReferFiles.ReferFileId];
objDR[convViewReferFiles.FileName] = objInFor[convViewReferFiles.FileName];
objDR[convViewReferFiles.ReferFileTypeId] = objInFor[convViewReferFiles.ReferFileTypeId];
objDR[convViewReferFiles.ReferFileTypeName] = objInFor[convViewReferFiles.ReferFileTypeName];
objDR[convViewReferFiles.FilePath] = objInFor[convViewReferFiles.FilePath];
objDR[convViewReferFiles.InUse] = objInFor[convViewReferFiles.InUse];
objDR[convViewReferFiles.OrderNum] = objInFor[convViewReferFiles.OrderNum];
objDR[convViewReferFiles.IsTemplate] = objInFor[convViewReferFiles.IsTemplate];
objDR[convViewReferFiles.UpdDate] = objInFor[convViewReferFiles.UpdDate];
objDR[convViewReferFiles.UpdUserId] = objInFor[convViewReferFiles.UpdUserId];
objDR[convViewReferFiles.Memo] = objInFor[convViewReferFiles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}