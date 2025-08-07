
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewReferFilesBL
 表名:vViewReferFiles(00050466)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:42:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvViewReferFilesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewReferFilesEN GetObj(this K_mId_vViewReferFiles myKey)
{
clsvViewReferFilesEN objvViewReferFilesEN = clsvViewReferFilesBL.vViewReferFilesDA.GetObjBymId(myKey.Value);
return objvViewReferFilesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetViewId(this clsvViewReferFilesEN objvViewReferFilesEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewReferFiles.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewReferFiles.ViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetViewName(this clsvViewReferFilesEN objvViewReferFilesEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convViewReferFiles.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convViewReferFiles.ViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetPrjId(this clsvViewReferFilesEN objvViewReferFilesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convViewReferFiles.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convViewReferFiles.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convViewReferFiles.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetCodeTypeId(this clsvViewReferFilesEN objvViewReferFilesEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convViewReferFiles.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convViewReferFiles.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetCodeTypeName(this clsvViewReferFilesEN objvViewReferFilesEN, string strCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convViewReferFiles.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileId(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileId, 8, convViewReferFiles.ReferFileId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, convViewReferFiles.ReferFileId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetFileName(this clsvViewReferFilesEN objvViewReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convViewReferFiles.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convViewReferFiles.FileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileTypeId(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, convViewReferFiles.ReferFileTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, convViewReferFiles.ReferFileTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetReferFileTypeName(this clsvViewReferFilesEN objvViewReferFilesEN, string strReferFileTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileTypeName, 50, convViewReferFiles.ReferFileTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetFilePath(this clsvViewReferFilesEN objvViewReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convViewReferFiles.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convViewReferFiles.FilePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetUpdDate(this clsvViewReferFilesEN objvViewReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewReferFiles.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetUpdUserId(this clsvViewReferFilesEN objvViewReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewReferFiles.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewReferFilesEN SetMemo(this clsvViewReferFilesEN objvViewReferFilesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewReferFiles.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewReferFilesENS">源对象</param>
 /// <param name = "objvViewReferFilesENT">目标对象</param>
 public static void CopyTo(this clsvViewReferFilesEN objvViewReferFilesENS, clsvViewReferFilesEN objvViewReferFilesENT)
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
 /// <param name = "objvViewReferFilesENS">源对象</param>
 /// <returns>目标对象=>clsvViewReferFilesEN:objvViewReferFilesENT</returns>
 public static clsvViewReferFilesEN CopyTo(this clsvViewReferFilesEN objvViewReferFilesENS)
{
try
{
 clsvViewReferFilesEN objvViewReferFilesENT = new clsvViewReferFilesEN()
{
mId = objvViewReferFilesENS.mId, //mId
ViewId = objvViewReferFilesENS.ViewId, //界面Id
ViewName = objvViewReferFilesENS.ViewName, //界面名称
PrjId = objvViewReferFilesENS.PrjId, //工程Id
CodeTypeId = objvViewReferFilesENS.CodeTypeId, //代码类型Id
CodeTypeName = objvViewReferFilesENS.CodeTypeName, //代码类型名
ReferFileId = objvViewReferFilesENS.ReferFileId, //引用文件Id
FileName = objvViewReferFilesENS.FileName, //文件名
ReferFileTypeId = objvViewReferFilesENS.ReferFileTypeId, //引用文件类型Id
ReferFileTypeName = objvViewReferFilesENS.ReferFileTypeName, //引用文件类型名
FilePath = objvViewReferFilesENS.FilePath, //文件路径
InUse = objvViewReferFilesENS.InUse, //是否在用
OrderNum = objvViewReferFilesENS.OrderNum, //序号
IsTemplate = objvViewReferFilesENS.IsTemplate, //是否模板
UpdDate = objvViewReferFilesENS.UpdDate, //修改日期
UpdUserId = objvViewReferFilesENS.UpdUserId, //修改用户Id
Memo = objvViewReferFilesENS.Memo, //说明
};
 return objvViewReferFilesENT;
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
public static void CheckProperty4Condition(this clsvViewReferFilesEN objvViewReferFilesEN)
{
 clsvViewReferFilesBL.vViewReferFilesDA.CheckProperty4Condition(objvViewReferFilesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewReferFiles
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面引用文件(vViewReferFiles)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewReferFilesBL
{
public static RelatedActions_vViewReferFiles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewReferFilesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewReferFilesDA vViewReferFilesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewReferFilesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewReferFilesBL()
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
if (string.IsNullOrEmpty(clsvViewReferFilesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewReferFilesEN._ConnectString);
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
public static DataTable GetDataTable_vViewReferFiles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewReferFilesDA.GetDataTable_vViewReferFiles(strWhereCond);
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
objDT = vViewReferFilesDA.GetDataTable(strWhereCond);
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
objDT = vViewReferFilesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewReferFilesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewReferFilesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewReferFilesDA.GetDataTable_Top(objTopPara);
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
objDT = vViewReferFilesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvViewReferFilesEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
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
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewReferFilesEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrvViewReferFilesObjLst_Sel =
arrvViewReferFilesObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvViewReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLst(string strWhereCond)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
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
public static List<clsvViewReferFilesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewReferFilesEN> GetSubObjLstCache(clsvViewReferFilesEN objvViewReferFilesCond)
{
 string strPrjId = objvViewReferFilesCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewReferFilesBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewReferFilesEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewReferFiles._AttributeName)
{
if (objvViewReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objvViewReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewReferFilesCond[strFldName].ToString());
}
else
{
if (objvViewReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewReferFilesCond[strFldName]));
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
public static List<clsvViewReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
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
public static List<clsvViewReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
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
List<clsvViewReferFilesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewReferFilesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
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
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
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
public static List<clsvViewReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
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
public static List<clsvViewReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewReferFilesEN> arrObjLst = new List<clsvViewReferFilesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewReferFilesEN objvViewReferFilesEN = new clsvViewReferFilesEN();
try
{
objvViewReferFilesEN.mId = Int32.Parse(objRow[convViewReferFiles.mId].ToString().Trim()); //mId
objvViewReferFilesEN.ViewId = objRow[convViewReferFiles.ViewId] == DBNull.Value ? null : objRow[convViewReferFiles.ViewId].ToString().Trim(); //界面Id
objvViewReferFilesEN.ViewName = objRow[convViewReferFiles.ViewName].ToString().Trim(); //界面名称
objvViewReferFilesEN.PrjId = objRow[convViewReferFiles.PrjId].ToString().Trim(); //工程Id
objvViewReferFilesEN.CodeTypeId = objRow[convViewReferFiles.CodeTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeId].ToString().Trim(); //代码类型Id
objvViewReferFilesEN.CodeTypeName = objRow[convViewReferFiles.CodeTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.CodeTypeName].ToString().Trim(); //代码类型名
objvViewReferFilesEN.ReferFileId = objRow[convViewReferFiles.ReferFileId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objvViewReferFilesEN.FileName = objRow[convViewReferFiles.FileName].ToString().Trim(); //文件名
objvViewReferFilesEN.ReferFileTypeId = objRow[convViewReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objvViewReferFilesEN.ReferFileTypeName = objRow[convViewReferFiles.ReferFileTypeName] == DBNull.Value ? null : objRow[convViewReferFiles.ReferFileTypeName].ToString().Trim(); //引用文件类型名
objvViewReferFilesEN.FilePath = objRow[convViewReferFiles.FilePath].ToString().Trim(); //文件路径
objvViewReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.InUse].ToString().Trim()); //是否在用
objvViewReferFilesEN.OrderNum = Int32.Parse(objRow[convViewReferFiles.OrderNum].ToString().Trim()); //序号
objvViewReferFilesEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convViewReferFiles.IsTemplate].ToString().Trim()); //是否模板
objvViewReferFilesEN.UpdDate = objRow[convViewReferFiles.UpdDate] == DBNull.Value ? null : objRow[convViewReferFiles.UpdDate].ToString().Trim(); //修改日期
objvViewReferFilesEN.UpdUserId = objRow[convViewReferFiles.UpdUserId] == DBNull.Value ? null : objRow[convViewReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objvViewReferFilesEN.Memo = objRow[convViewReferFiles.Memo] == DBNull.Value ? null : objRow[convViewReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewReferFilesEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewReferFilesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewReferFilesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewReferFiles(ref clsvViewReferFilesEN objvViewReferFilesEN)
{
bool bolResult = vViewReferFilesDA.GetvViewReferFiles(ref objvViewReferFilesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewReferFilesEN GetObjBymId(long lngmId)
{
clsvViewReferFilesEN objvViewReferFilesEN = vViewReferFilesDA.GetObjBymId(lngmId);
return objvViewReferFilesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewReferFilesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewReferFilesEN objvViewReferFilesEN = vViewReferFilesDA.GetFirstObj(strWhereCond);
 return objvViewReferFilesEN;
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
public static clsvViewReferFilesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewReferFilesEN objvViewReferFilesEN = vViewReferFilesDA.GetObjByDataRow(objRow);
 return objvViewReferFilesEN;
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
public static clsvViewReferFilesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewReferFilesEN objvViewReferFilesEN = vViewReferFilesDA.GetObjByDataRow(objRow);
 return objvViewReferFilesEN;
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
 /// <param name = "lstvViewReferFilesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewReferFilesEN GetObjBymIdFromList(long lngmId, List<clsvViewReferFilesEN> lstvViewReferFilesObjLst)
{
foreach (clsvViewReferFilesEN objvViewReferFilesEN in lstvViewReferFilesObjLst)
{
if (objvViewReferFilesEN.mId == lngmId)
{
return objvViewReferFilesEN;
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
 lngmId = new clsvViewReferFilesDA().GetFirstID(strWhereCond);
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
 arrList = vViewReferFilesDA.GetID(strWhereCond);
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
bool bolIsExist = vViewReferFilesDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vViewReferFilesDA.IsExist(lngmId);
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
 bolIsExist = clsvViewReferFilesDA.IsExistTable();
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
 bolIsExist = vViewReferFilesDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewReferFilesEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewReferFilesEN objvViewReferFilesEN)
{
try
{
objvViewReferFilesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewReferFilesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewReferFiles.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.mId = objvViewReferFilesEN.mId; //mId
}
if (arrFldSet.Contains(convViewReferFiles.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.ViewId = objvViewReferFilesEN.ViewId == "[null]" ? null :  objvViewReferFilesEN.ViewId; //界面Id
}
if (arrFldSet.Contains(convViewReferFiles.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.ViewName = objvViewReferFilesEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convViewReferFiles.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.PrjId = objvViewReferFilesEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convViewReferFiles.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.CodeTypeId = objvViewReferFilesEN.CodeTypeId == "[null]" ? null :  objvViewReferFilesEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convViewReferFiles.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.CodeTypeName = objvViewReferFilesEN.CodeTypeName == "[null]" ? null :  objvViewReferFilesEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convViewReferFiles.ReferFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.ReferFileId = objvViewReferFilesEN.ReferFileId == "[null]" ? null :  objvViewReferFilesEN.ReferFileId; //引用文件Id
}
if (arrFldSet.Contains(convViewReferFiles.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.FileName = objvViewReferFilesEN.FileName; //文件名
}
if (arrFldSet.Contains(convViewReferFiles.ReferFileTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.ReferFileTypeId = objvViewReferFilesEN.ReferFileTypeId == "[null]" ? null :  objvViewReferFilesEN.ReferFileTypeId; //引用文件类型Id
}
if (arrFldSet.Contains(convViewReferFiles.ReferFileTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.ReferFileTypeName = objvViewReferFilesEN.ReferFileTypeName == "[null]" ? null :  objvViewReferFilesEN.ReferFileTypeName; //引用文件类型名
}
if (arrFldSet.Contains(convViewReferFiles.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.FilePath = objvViewReferFilesEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convViewReferFiles.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.InUse = objvViewReferFilesEN.InUse; //是否在用
}
if (arrFldSet.Contains(convViewReferFiles.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.OrderNum = objvViewReferFilesEN.OrderNum; //序号
}
if (arrFldSet.Contains(convViewReferFiles.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.IsTemplate = objvViewReferFilesEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convViewReferFiles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.UpdDate = objvViewReferFilesEN.UpdDate == "[null]" ? null :  objvViewReferFilesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewReferFiles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.UpdUserId = objvViewReferFilesEN.UpdUserId == "[null]" ? null :  objvViewReferFilesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convViewReferFiles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewReferFilesEN.Memo = objvViewReferFilesEN.Memo == "[null]" ? null :  objvViewReferFilesEN.Memo; //说明
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
 /// <param name = "objvViewReferFilesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewReferFilesEN objvViewReferFilesEN)
{
try
{
if (objvViewReferFilesEN.ViewId == "[null]") objvViewReferFilesEN.ViewId = null; //界面Id
if (objvViewReferFilesEN.CodeTypeId == "[null]") objvViewReferFilesEN.CodeTypeId = null; //代码类型Id
if (objvViewReferFilesEN.CodeTypeName == "[null]") objvViewReferFilesEN.CodeTypeName = null; //代码类型名
if (objvViewReferFilesEN.ReferFileId == "[null]") objvViewReferFilesEN.ReferFileId = null; //引用文件Id
if (objvViewReferFilesEN.ReferFileTypeId == "[null]") objvViewReferFilesEN.ReferFileTypeId = null; //引用文件类型Id
if (objvViewReferFilesEN.ReferFileTypeName == "[null]") objvViewReferFilesEN.ReferFileTypeName = null; //引用文件类型名
if (objvViewReferFilesEN.UpdDate == "[null]") objvViewReferFilesEN.UpdDate = null; //修改日期
if (objvViewReferFilesEN.UpdUserId == "[null]") objvViewReferFilesEN.UpdUserId = null; //修改用户Id
if (objvViewReferFilesEN.Memo == "[null]") objvViewReferFilesEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvViewReferFilesEN objvViewReferFilesEN)
{
 vViewReferFilesDA.CheckProperty4Condition(objvViewReferFilesEN);
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
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewReferFilesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewReferFilesBL没有刷新缓存机制(clsViewReferFilesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsReferFilesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsReferFilesBL没有刷新缓存机制(clsReferFilesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsReferFileTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsReferFileTypeBL没有刷新缓存机制(clsReferFileTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvViewReferFilesObjLstCache == null)
//{
//arrvViewReferFilesObjLstCache = vViewReferFilesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewReferFilesEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrvViewReferFilesObjLst_Sel =
arrvViewReferFilesObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvViewReferFilesObjLst_Sel.Count() == 0)
{
   clsvViewReferFilesEN obj = clsvViewReferFilesBL.GetObjBymId(lngmId);
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
return arrvViewReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewReferFilesEN> GetAllvViewReferFilesObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = GetObjLstCache(strPrjId); 
return arrvViewReferFilesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewReferFilesEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvViewReferFilesEN> arrvViewReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewReferFilesObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewReferFilesEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvViewReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewReferFilesEN._RefreshTimeLst.Count == 0) return "";
return clsvViewReferFilesEN._RefreshTimeLst[clsvViewReferFilesEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convViewReferFiles.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewReferFiles._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewReferFiles._AttributeName));
throw new Exception(strMsg);
}
var objvViewReferFiles = clsvViewReferFilesBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvViewReferFiles == null) return "";
return objvViewReferFiles[strOutFldName].ToString();
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
int intRecCount = clsvViewReferFilesDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewReferFilesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewReferFilesDA.GetRecCount();
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
int intRecCount = clsvViewReferFilesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewReferFilesEN objvViewReferFilesCond)
{
 string strPrjId = objvViewReferFilesCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewReferFilesBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewReferFilesEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvViewReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewReferFiles._AttributeName)
{
if (objvViewReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objvViewReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewReferFilesCond[strFldName].ToString());
}
else
{
if (objvViewReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewReferFilesCond[strFldName]));
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
 List<string> arrList = clsvViewReferFilesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewReferFilesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewReferFilesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}