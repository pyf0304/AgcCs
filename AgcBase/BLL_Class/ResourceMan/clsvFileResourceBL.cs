
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceBL
 表名:vFileResource(00050540)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsvFileResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFileResourceEN GetObj(this K_FileResourceID_vFileResource myKey)
{
clsvFileResourceEN objvFileResourceEN = clsvFileResourceBL.vFileResourceDA.GetObjByFileResourceID(myKey.Value);
return objvFileResourceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileResourceID(this clsvFileResourceEN objvFileResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
objvFileResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileResourceID) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileResourceID, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileResourceID] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileDirName(this clsvFileResourceEN objvFileResourceEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFileResource.FileDirName);
}
objvFileResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileDirName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileDirName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileDirName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileName(this clsvFileResourceEN objvFileResourceEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, convFileResource.FileName);
}
objvFileResourceEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetExtension(this clsvFileResourceEN objvFileResourceEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 20, convFileResource.Extension);
}
objvFileResourceEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.Extension) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.Extension, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.Extension] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetTabId(this clsvFileResourceEN objvFileResourceEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convFileResource.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convFileResource.TabId);
}
objvFileResourceEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.TabId) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.TabId, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.TabId] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetTabName(this clsvFileResourceEN objvFileResourceEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convFileResource.TabName);
}
objvFileResourceEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.TabName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.TabName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.TabName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetTabCnName(this clsvFileResourceEN objvFileResourceEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convFileResource.TabCnName);
}
objvFileResourceEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.TabCnName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.TabCnName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.TabCnName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetTabStateId(this clsvFileResourceEN objvFileResourceEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convFileResource.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convFileResource.TabStateId);
}
objvFileResourceEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.TabStateId) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.TabStateId, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.TabStateId] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFuncModuleAgcId(this clsvFileResourceEN objvFileResourceEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convFileResource.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convFileResource.FuncModuleAgcId);
}
objvFileResourceEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FuncModuleAgcId) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FuncModuleAgcId, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FuncModuleAgcId] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFuncModuleName(this clsvFileResourceEN objvFileResourceEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFileResource.FuncModuleName);
}
objvFileResourceEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FuncModuleName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FuncModuleName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FuncModuleName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIsBelongsCurrCMPrj(this clsvFileResourceEN objvFileResourceEN, bool bolIsBelongsCurrCMPrj, string strComparisonOp="")
	{
objvFileResourceEN.IsBelongsCurrCMPrj = bolIsBelongsCurrCMPrj; //是否属于当前项目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IsBelongsCurrCMPrj) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IsBelongsCurrCMPrj, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IsBelongsCurrCMPrj] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIsGeneCode(this clsvFileResourceEN objvFileResourceEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvFileResourceEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IsGeneCode) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IsGeneCode, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IsGeneCode] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIsCanDel(this clsvFileResourceEN objvFileResourceEN, bool bolIsCanDel, string strComparisonOp="")
	{
objvFileResourceEN.IsCanDel = bolIsCanDel; //是否可删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IsCanDel) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IsCanDel, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IsCanDel] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileLength(this clsvFileResourceEN objvFileResourceEN, long lngFileLength, string strComparisonOp="")
	{
objvFileResourceEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileLength) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileLength, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileLength] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileType(this clsvFileResourceEN objvFileResourceEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convFileResource.FileType);
}
objvFileResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileType) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileType, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileType] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCreationTime(this clsvFileResourceEN objvFileResourceEN, string strCreationTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreationTime, 20, convFileResource.CreationTime);
}
objvFileResourceEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CreationTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CreationTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CreationTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetLastWriteTime(this clsvFileResourceEN objvFileResourceEN, string strLastWriteTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastWriteTime, 30, convFileResource.LastWriteTime);
}
objvFileResourceEN.LastWriteTime = strLastWriteTime; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.LastWriteTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.LastWriteTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.LastWriteTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCheckDateTime(this clsvFileResourceEN objvFileResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFileResource.CheckDateTime);
}
objvFileResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CheckDateTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CheckDateTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CheckDateTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetInUse(this clsvFileResourceEN objvFileResourceEN, bool bolInUse, string strComparisonOp="")
	{
objvFileResourceEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.InUse) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.InUse, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.InUse] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIsExistFile(this clsvFileResourceEN objvFileResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFileResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IsExistFile) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IsExistFile, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IsExistFile] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetPrjId(this clsvFileResourceEN objvFileResourceEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFileResource.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFileResource.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFileResource.PrjId);
}
objvFileResourceEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.PrjId) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.PrjId, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.PrjId] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetPrjName(this clsvFileResourceEN objvFileResourceEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convFileResource.PrjName);
}
objvFileResourceEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.PrjName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.PrjName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.PrjName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCmPrjId(this clsvFileResourceEN objvFileResourceEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convFileResource.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convFileResource.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convFileResource.CmPrjId);
}
objvFileResourceEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CmPrjId) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CmPrjId, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CmPrjId] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCmPrjName(this clsvFileResourceEN objvFileResourceEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convFileResource.CmPrjName);
}
objvFileResourceEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CmPrjName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CmPrjName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CmPrjName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIpAddress(this clsvFileResourceEN objvFileResourceEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convFileResource.IpAddress);
}
objvFileResourceEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IpAddress) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IpAddress, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IpAddress] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetUpdDate(this clsvFileResourceEN objvFileResourceEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFileResource.UpdDate);
}
objvFileResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.UpdDate) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.UpdDate, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.UpdDate] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetUpdUser(this clsvFileResourceEN objvFileResourceEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFileResource.UpdUser);
}
objvFileResourceEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.UpdUser) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.UpdUser, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.UpdUser] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetMemo(this clsvFileResourceEN objvFileResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFileResource.Memo);
}
objvFileResourceEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.Memo) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.Memo, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.Memo] = strComparisonOp;
}
}
return objvFileResourceEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <param name = "objvFileResourceENT">目标对象</param>
 public static void CopyTo(this clsvFileResourceEN objvFileResourceENS, clsvFileResourceEN objvFileResourceENT)
{
try
{
objvFileResourceENT.FileResourceID = objvFileResourceENS.FileResourceID; //FileResourceID
objvFileResourceENT.FileDirName = objvFileResourceENS.FileDirName; //文件目录名
objvFileResourceENT.FileName = objvFileResourceENS.FileName; //文件名
objvFileResourceENT.Extension = objvFileResourceENS.Extension; //扩展名
objvFileResourceENT.TabId = objvFileResourceENS.TabId; //表ID
objvFileResourceENT.TabName = objvFileResourceENS.TabName; //表名
objvFileResourceENT.TabCnName = objvFileResourceENS.TabCnName; //表中文名
objvFileResourceENT.TabStateId = objvFileResourceENS.TabStateId; //表状态ID
objvFileResourceENT.FuncModuleAgcId = objvFileResourceENS.FuncModuleAgcId; //功能模块Id
objvFileResourceENT.FuncModuleName = objvFileResourceENS.FuncModuleName; //功能模块名称
objvFileResourceENT.IsBelongsCurrCMPrj = objvFileResourceENS.IsBelongsCurrCMPrj; //是否属于当前项目
objvFileResourceENT.IsGeneCode = objvFileResourceENS.IsGeneCode; //是否生成代码
objvFileResourceENT.IsCanDel = objvFileResourceENS.IsCanDel; //是否可删除
objvFileResourceENT.FileLength = objvFileResourceENS.FileLength; //文件长度
objvFileResourceENT.FileType = objvFileResourceENS.FileType; //文件类型
objvFileResourceENT.CreationTime = objvFileResourceENS.CreationTime; //建立时间
objvFileResourceENT.LastWriteTime = objvFileResourceENS.LastWriteTime; //修改日期
objvFileResourceENT.CheckDateTime = objvFileResourceENS.CheckDateTime; //CheckDateTime
objvFileResourceENT.InUse = objvFileResourceENS.InUse; //是否在用
objvFileResourceENT.IsExistFile = objvFileResourceENS.IsExistFile; //是否存在文件
objvFileResourceENT.PrjId = objvFileResourceENS.PrjId; //工程ID
objvFileResourceENT.PrjName = objvFileResourceENS.PrjName; //工程名称
objvFileResourceENT.CmPrjId = objvFileResourceENS.CmPrjId; //CM工程Id
objvFileResourceENT.CmPrjName = objvFileResourceENS.CmPrjName; //CM工程名
objvFileResourceENT.IpAddress = objvFileResourceENS.IpAddress; //服务器
objvFileResourceENT.UpdDate = objvFileResourceENS.UpdDate; //修改日期
objvFileResourceENT.UpdUser = objvFileResourceENS.UpdUser; //修改者
objvFileResourceENT.Memo = objvFileResourceENS.Memo; //说明
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
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <returns>目标对象=>clsvFileResourceEN:objvFileResourceENT</returns>
 public static clsvFileResourceEN CopyTo(this clsvFileResourceEN objvFileResourceENS)
{
try
{
 clsvFileResourceEN objvFileResourceENT = new clsvFileResourceEN()
{
FileResourceID = objvFileResourceENS.FileResourceID, //FileResourceID
FileDirName = objvFileResourceENS.FileDirName, //文件目录名
FileName = objvFileResourceENS.FileName, //文件名
Extension = objvFileResourceENS.Extension, //扩展名
TabId = objvFileResourceENS.TabId, //表ID
TabName = objvFileResourceENS.TabName, //表名
TabCnName = objvFileResourceENS.TabCnName, //表中文名
TabStateId = objvFileResourceENS.TabStateId, //表状态ID
FuncModuleAgcId = objvFileResourceENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvFileResourceENS.FuncModuleName, //功能模块名称
IsBelongsCurrCMPrj = objvFileResourceENS.IsBelongsCurrCMPrj, //是否属于当前项目
IsGeneCode = objvFileResourceENS.IsGeneCode, //是否生成代码
IsCanDel = objvFileResourceENS.IsCanDel, //是否可删除
FileLength = objvFileResourceENS.FileLength, //文件长度
FileType = objvFileResourceENS.FileType, //文件类型
CreationTime = objvFileResourceENS.CreationTime, //建立时间
LastWriteTime = objvFileResourceENS.LastWriteTime, //修改日期
CheckDateTime = objvFileResourceENS.CheckDateTime, //CheckDateTime
InUse = objvFileResourceENS.InUse, //是否在用
IsExistFile = objvFileResourceENS.IsExistFile, //是否存在文件
PrjId = objvFileResourceENS.PrjId, //工程ID
PrjName = objvFileResourceENS.PrjName, //工程名称
CmPrjId = objvFileResourceENS.CmPrjId, //CM工程Id
CmPrjName = objvFileResourceENS.CmPrjName, //CM工程名
IpAddress = objvFileResourceENS.IpAddress, //服务器
UpdDate = objvFileResourceENS.UpdDate, //修改日期
UpdUser = objvFileResourceENS.UpdUser, //修改者
Memo = objvFileResourceENS.Memo, //说明
};
 return objvFileResourceENT;
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
public static void CheckProperty4Condition(this clsvFileResourceEN objvFileResourceEN)
{
 clsvFileResourceBL.vFileResourceDA.CheckProperty4Condition(objvFileResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFileResourceEN objvFileResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFileResourceCond.IsUpdated(convFileResource.FileResourceID) == true)
{
string strComparisonOpFileResourceID = objvFileResourceCond.dicFldComparisonOp[convFileResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFileResource.FileResourceID, objvFileResourceCond.FileResourceID, strComparisonOpFileResourceID);
}
if (objvFileResourceCond.IsUpdated(convFileResource.FileDirName) == true)
{
string strComparisonOpFileDirName = objvFileResourceCond.dicFldComparisonOp[convFileResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileDirName, objvFileResourceCond.FileDirName, strComparisonOpFileDirName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.FileName) == true)
{
string strComparisonOpFileName = objvFileResourceCond.dicFldComparisonOp[convFileResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileName, objvFileResourceCond.FileName, strComparisonOpFileName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.Extension) == true)
{
string strComparisonOpExtension = objvFileResourceCond.dicFldComparisonOp[convFileResource.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.Extension, objvFileResourceCond.Extension, strComparisonOpExtension);
}
if (objvFileResourceCond.IsUpdated(convFileResource.TabId) == true)
{
string strComparisonOpTabId = objvFileResourceCond.dicFldComparisonOp[convFileResource.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.TabId, objvFileResourceCond.TabId, strComparisonOpTabId);
}
if (objvFileResourceCond.IsUpdated(convFileResource.TabName) == true)
{
string strComparisonOpTabName = objvFileResourceCond.dicFldComparisonOp[convFileResource.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.TabName, objvFileResourceCond.TabName, strComparisonOpTabName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.TabCnName) == true)
{
string strComparisonOpTabCnName = objvFileResourceCond.dicFldComparisonOp[convFileResource.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.TabCnName, objvFileResourceCond.TabCnName, strComparisonOpTabCnName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.TabStateId) == true)
{
string strComparisonOpTabStateId = objvFileResourceCond.dicFldComparisonOp[convFileResource.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.TabStateId, objvFileResourceCond.TabStateId, strComparisonOpTabStateId);
}
if (objvFileResourceCond.IsUpdated(convFileResource.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvFileResourceCond.dicFldComparisonOp[convFileResource.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FuncModuleAgcId, objvFileResourceCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvFileResourceCond.IsUpdated(convFileResource.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFileResourceCond.dicFldComparisonOp[convFileResource.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FuncModuleName, objvFileResourceCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.IsBelongsCurrCMPrj) == true)
{
if (objvFileResourceCond.IsBelongsCurrCMPrj == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsBelongsCurrCMPrj);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsBelongsCurrCMPrj);
}
}
if (objvFileResourceCond.IsUpdated(convFileResource.IsGeneCode) == true)
{
if (objvFileResourceCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsGeneCode);
}
}
if (objvFileResourceCond.IsUpdated(convFileResource.IsCanDel) == true)
{
if (objvFileResourceCond.IsCanDel == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsCanDel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsCanDel);
}
}
if (objvFileResourceCond.IsUpdated(convFileResource.FileLength) == true)
{
string strComparisonOpFileLength = objvFileResourceCond.dicFldComparisonOp[convFileResource.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFileResource.FileLength, objvFileResourceCond.FileLength, strComparisonOpFileLength);
}
if (objvFileResourceCond.IsUpdated(convFileResource.FileType) == true)
{
string strComparisonOpFileType = objvFileResourceCond.dicFldComparisonOp[convFileResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileType, objvFileResourceCond.FileType, strComparisonOpFileType);
}
if (objvFileResourceCond.IsUpdated(convFileResource.CreationTime) == true)
{
string strComparisonOpCreationTime = objvFileResourceCond.dicFldComparisonOp[convFileResource.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CreationTime, objvFileResourceCond.CreationTime, strComparisonOpCreationTime);
}
if (objvFileResourceCond.IsUpdated(convFileResource.LastWriteTime) == true)
{
string strComparisonOpLastWriteTime = objvFileResourceCond.dicFldComparisonOp[convFileResource.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.LastWriteTime, objvFileResourceCond.LastWriteTime, strComparisonOpLastWriteTime);
}
if (objvFileResourceCond.IsUpdated(convFileResource.CheckDateTime) == true)
{
string strComparisonOpCheckDateTime = objvFileResourceCond.dicFldComparisonOp[convFileResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CheckDateTime, objvFileResourceCond.CheckDateTime, strComparisonOpCheckDateTime);
}
if (objvFileResourceCond.IsUpdated(convFileResource.InUse) == true)
{
if (objvFileResourceCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.InUse);
}
}
if (objvFileResourceCond.IsUpdated(convFileResource.IsExistFile) == true)
{
if (objvFileResourceCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsExistFile);
}
}
if (objvFileResourceCond.IsUpdated(convFileResource.PrjId) == true)
{
string strComparisonOpPrjId = objvFileResourceCond.dicFldComparisonOp[convFileResource.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.PrjId, objvFileResourceCond.PrjId, strComparisonOpPrjId);
}
if (objvFileResourceCond.IsUpdated(convFileResource.PrjName) == true)
{
string strComparisonOpPrjName = objvFileResourceCond.dicFldComparisonOp[convFileResource.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.PrjName, objvFileResourceCond.PrjName, strComparisonOpPrjName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvFileResourceCond.dicFldComparisonOp[convFileResource.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CmPrjId, objvFileResourceCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvFileResourceCond.IsUpdated(convFileResource.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvFileResourceCond.dicFldComparisonOp[convFileResource.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CmPrjName, objvFileResourceCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvFileResourceCond.IsUpdated(convFileResource.IpAddress) == true)
{
string strComparisonOpIpAddress = objvFileResourceCond.dicFldComparisonOp[convFileResource.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.IpAddress, objvFileResourceCond.IpAddress, strComparisonOpIpAddress);
}
if (objvFileResourceCond.IsUpdated(convFileResource.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFileResourceCond.dicFldComparisonOp[convFileResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.UpdDate, objvFileResourceCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFileResourceCond.IsUpdated(convFileResource.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFileResourceCond.dicFldComparisonOp[convFileResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.UpdUser, objvFileResourceCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFileResourceCond.IsUpdated(convFileResource.Memo) == true)
{
string strComparisonOpMemo = objvFileResourceCond.dicFldComparisonOp[convFileResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.Memo, objvFileResourceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFileResource
{
public virtual bool UpdRelaTabDate(long lngFileResourceID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v文件资源(vFileResource)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFileResourceBL
{
public static RelatedActions_vFileResource relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vFileResourceListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vFileResourceList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvFileResourceEN> arrvFileResourceObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFileResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFileResourceDA vFileResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFileResourceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFileResourceBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvFileResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFileResourceEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vFileResourceDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vFileResourceDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vFileResourceDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vFileResource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTable_vFileResource(strWhereCond);
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
objDT = vFileResourceDA.GetDataTable(strWhereCond);
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
objDT = vFileResourceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFileResourceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFileResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFileResourceDA.GetDataTable_Top(objTopPara);
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
objDT = vFileResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vFileResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFileResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vFileResourceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrFileResourceIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByFileResourceIDLst(List<long> arrFileResourceIDLst)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFileResourceIDLst);
 string strWhereCond = string.Format("FileResourceID in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFileResourceIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFileResourceEN> GetObjLstByFileResourceIDLstCache(List<long> arrFileResourceIDLst)
{
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName);
List<clsvFileResourceEN> arrvFileResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvFileResourceEN> arrvFileResourceObjLst_Sel =
arrvFileResourceObjLstCache
.Where(x => arrFileResourceIDLst.Contains(x.FileResourceID));
return arrvFileResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLst(string strWhereCond)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
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
public static List<clsvFileResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFileResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFileResourceEN> GetSubObjLstCache(clsvFileResourceEN objvFileResourceCond)
{
List<clsvFileResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFileResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFileResource.AttributeName)
{
if (objvFileResourceCond.IsUpdated(strFldName) == false) continue;
if (objvFileResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else
{
if (objvFileResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFileResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFileResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
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
public static List<clsvFileResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
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
public static List<clsvFileResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
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
List<clsvFileResourceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFileResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFileResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
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
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
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
public static List<clsvFileResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFileResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
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
public static List<clsvFileResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvFileResourceEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvFileResourceEN objvFileResourceCond, string strOrderBy)
{
List<clsvFileResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFileResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFileResource.AttributeName)
{
if (objvFileResourceCond.IsUpdated(strFldName) == false) continue;
if (objvFileResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else
{
if (objvFileResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFileResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFileResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvFileResourceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvFileResourceEN objvFileResourceCond = JsonConvert.DeserializeObject<clsvFileResourceEN>(objPagerPara.whereCond);
if (objvFileResourceCond.sfFldComparisonOp == null)
{
objvFileResourceCond.dicFldComparisonOp = null;
}
else
{
objvFileResourceCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvFileResourceCond.sfFldComparisonOp);
}
clsvFileResourceBL.SetUpdFlag(objvFileResourceCond);
 try
{
CheckProperty4Condition(objvFileResourceCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvFileResourceBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvFileResourceCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFileResourceEN> arrObjLst = new List<clsvFileResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
try
{
objvFileResourceEN.FileResourceID = Int32.Parse(objRow[convFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objvFileResourceEN.FileDirName = objRow[convFileResource.FileDirName] == DBNull.Value ? null : objRow[convFileResource.FileDirName].ToString().Trim(); //文件目录名
objvFileResourceEN.FileName = objRow[convFileResource.FileName] == DBNull.Value ? null : objRow[convFileResource.FileName].ToString().Trim(); //文件名
objvFileResourceEN.Extension = objRow[convFileResource.Extension] == DBNull.Value ? null : objRow[convFileResource.Extension].ToString().Trim(); //扩展名
objvFileResourceEN.TabId = objRow[convFileResource.TabId] == DBNull.Value ? null : objRow[convFileResource.TabId].ToString().Trim(); //表ID
objvFileResourceEN.TabName = objRow[convFileResource.TabName] == DBNull.Value ? null : objRow[convFileResource.TabName].ToString().Trim(); //表名
objvFileResourceEN.TabCnName = objRow[convFileResource.TabCnName] == DBNull.Value ? null : objRow[convFileResource.TabCnName].ToString().Trim(); //表中文名
objvFileResourceEN.TabStateId = objRow[convFileResource.TabStateId] == DBNull.Value ? null : objRow[convFileResource.TabStateId].ToString().Trim(); //表状态ID
objvFileResourceEN.FuncModuleAgcId = objRow[convFileResource.FuncModuleAgcId] == DBNull.Value ? null : objRow[convFileResource.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFileResourceEN.FuncModuleName = objRow[convFileResource.FuncModuleName] == DBNull.Value ? null : objRow[convFileResource.FuncModuleName].ToString().Trim(); //功能模块名称
objvFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objvFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objvFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsCanDel].ToString().Trim()); //是否可删除
objvFileResourceEN.FileLength = objRow[convFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFileResource.FileLength].ToString().Trim()); //文件长度
objvFileResourceEN.FileType = objRow[convFileResource.FileType] == DBNull.Value ? null : objRow[convFileResource.FileType].ToString().Trim(); //文件类型
objvFileResourceEN.CreationTime = objRow[convFileResource.CreationTime] == DBNull.Value ? null : objRow[convFileResource.CreationTime].ToString().Trim(); //建立时间
objvFileResourceEN.LastWriteTime = objRow[convFileResource.LastWriteTime] == DBNull.Value ? null : objRow[convFileResource.LastWriteTime].ToString().Trim(); //修改日期
objvFileResourceEN.CheckDateTime = objRow[convFileResource.CheckDateTime] == DBNull.Value ? null : objRow[convFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.InUse].ToString().Trim()); //是否在用
objvFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objvFileResourceEN.PrjId = objRow[convFileResource.PrjId].ToString().Trim(); //工程ID
objvFileResourceEN.PrjName = objRow[convFileResource.PrjName] == DBNull.Value ? null : objRow[convFileResource.PrjName].ToString().Trim(); //工程名称
objvFileResourceEN.CmPrjId = objRow[convFileResource.CmPrjId].ToString().Trim(); //CM工程Id
objvFileResourceEN.CmPrjName = objRow[convFileResource.CmPrjName] == DBNull.Value ? null : objRow[convFileResource.CmPrjName].ToString().Trim(); //CM工程名
objvFileResourceEN.IpAddress = objRow[convFileResource.IpAddress] == DBNull.Value ? null : objRow[convFileResource.IpAddress].ToString().Trim(); //服务器
objvFileResourceEN.UpdDate = objRow[convFileResource.UpdDate] == DBNull.Value ? null : objRow[convFileResource.UpdDate].ToString().Trim(); //修改日期
objvFileResourceEN.UpdUser = objRow[convFileResource.UpdUser] == DBNull.Value ? null : objRow[convFileResource.UpdUser].ToString().Trim(); //修改者
objvFileResourceEN.Memo = objRow[convFileResource.Memo] == DBNull.Value ? null : objRow[convFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFileResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFileResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFileResource(ref clsvFileResourceEN objvFileResourceEN)
{
bool bolResult = vFileResourceDA.GetvFileResource(ref objvFileResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
clsvFileResourceEN objvFileResourceEN = vFileResourceDA.GetObjByFileResourceID(lngFileResourceID);
return objvFileResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFileResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFileResourceEN objvFileResourceEN = vFileResourceDA.GetFirstObj(strWhereCond);
 return objvFileResourceEN;
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
public static clsvFileResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFileResourceEN objvFileResourceEN = vFileResourceDA.GetObjByDataRow(objRow);
 return objvFileResourceEN;
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
public static clsvFileResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFileResourceEN objvFileResourceEN = vFileResourceDA.GetObjByDataRow(objRow);
 return objvFileResourceEN;
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
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <param name = "lstvFileResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFileResourceEN GetObjByFileResourceIDFromList(long lngFileResourceID, List<clsvFileResourceEN> lstvFileResourceObjLst)
{
foreach (clsvFileResourceEN objvFileResourceEN in lstvFileResourceObjLst)
{
if (objvFileResourceEN.FileResourceID == lngFileResourceID)
{
return objvFileResourceEN;
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
 long lngFileResourceID;
 try
 {
 lngFileResourceID = new clsvFileResourceDA().GetFirstID(strWhereCond);
 return lngFileResourceID;
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
 arrList = vFileResourceDA.GetID(strWhereCond);
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
bool bolIsExist = vFileResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngFileResourceID)
{
//检测记录是否存在
bool bolIsExist = vFileResourceDA.IsExist(lngFileResourceID);
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
 bolIsExist = clsvFileResourceDA.IsExistTable();
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
 bolIsExist = vFileResourceDA.IsExistTable(strTabName);
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
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <param name = "objvFileResourceENT">目标对象</param>
 public static void CopyTo(clsvFileResourceEN objvFileResourceENS, clsvFileResourceEN objvFileResourceENT)
{
try
{
objvFileResourceENT.FileResourceID = objvFileResourceENS.FileResourceID; //FileResourceID
objvFileResourceENT.FileDirName = objvFileResourceENS.FileDirName; //文件目录名
objvFileResourceENT.FileName = objvFileResourceENS.FileName; //文件名
objvFileResourceENT.Extension = objvFileResourceENS.Extension; //扩展名
objvFileResourceENT.TabId = objvFileResourceENS.TabId; //表ID
objvFileResourceENT.TabName = objvFileResourceENS.TabName; //表名
objvFileResourceENT.TabCnName = objvFileResourceENS.TabCnName; //表中文名
objvFileResourceENT.TabStateId = objvFileResourceENS.TabStateId; //表状态ID
objvFileResourceENT.FuncModuleAgcId = objvFileResourceENS.FuncModuleAgcId; //功能模块Id
objvFileResourceENT.FuncModuleName = objvFileResourceENS.FuncModuleName; //功能模块名称
objvFileResourceENT.IsBelongsCurrCMPrj = objvFileResourceENS.IsBelongsCurrCMPrj; //是否属于当前项目
objvFileResourceENT.IsGeneCode = objvFileResourceENS.IsGeneCode; //是否生成代码
objvFileResourceENT.IsCanDel = objvFileResourceENS.IsCanDel; //是否可删除
objvFileResourceENT.FileLength = objvFileResourceENS.FileLength; //文件长度
objvFileResourceENT.FileType = objvFileResourceENS.FileType; //文件类型
objvFileResourceENT.CreationTime = objvFileResourceENS.CreationTime; //建立时间
objvFileResourceENT.LastWriteTime = objvFileResourceENS.LastWriteTime; //修改日期
objvFileResourceENT.CheckDateTime = objvFileResourceENS.CheckDateTime; //CheckDateTime
objvFileResourceENT.InUse = objvFileResourceENS.InUse; //是否在用
objvFileResourceENT.IsExistFile = objvFileResourceENS.IsExistFile; //是否存在文件
objvFileResourceENT.PrjId = objvFileResourceENS.PrjId; //工程ID
objvFileResourceENT.PrjName = objvFileResourceENS.PrjName; //工程名称
objvFileResourceENT.CmPrjId = objvFileResourceENS.CmPrjId; //CM工程Id
objvFileResourceENT.CmPrjName = objvFileResourceENS.CmPrjName; //CM工程名
objvFileResourceENT.IpAddress = objvFileResourceENS.IpAddress; //服务器
objvFileResourceENT.UpdDate = objvFileResourceENS.UpdDate; //修改日期
objvFileResourceENT.UpdUser = objvFileResourceENS.UpdUser; //修改者
objvFileResourceENT.Memo = objvFileResourceENS.Memo; //说明
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
 /// <param name = "objvFileResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsvFileResourceEN objvFileResourceEN)
{
try
{
objvFileResourceEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvFileResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFileResource.FileResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FileResourceID = objvFileResourceEN.FileResourceID; //FileResourceID
}
if (arrFldSet.Contains(convFileResource.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FileDirName = objvFileResourceEN.FileDirName == "[null]" ? null :  objvFileResourceEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convFileResource.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FileName = objvFileResourceEN.FileName == "[null]" ? null :  objvFileResourceEN.FileName; //文件名
}
if (arrFldSet.Contains(convFileResource.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.Extension = objvFileResourceEN.Extension == "[null]" ? null :  objvFileResourceEN.Extension; //扩展名
}
if (arrFldSet.Contains(convFileResource.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.TabId = objvFileResourceEN.TabId == "[null]" ? null :  objvFileResourceEN.TabId; //表ID
}
if (arrFldSet.Contains(convFileResource.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.TabName = objvFileResourceEN.TabName == "[null]" ? null :  objvFileResourceEN.TabName; //表名
}
if (arrFldSet.Contains(convFileResource.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.TabCnName = objvFileResourceEN.TabCnName == "[null]" ? null :  objvFileResourceEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convFileResource.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.TabStateId = objvFileResourceEN.TabStateId == "[null]" ? null :  objvFileResourceEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convFileResource.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FuncModuleAgcId = objvFileResourceEN.FuncModuleAgcId == "[null]" ? null :  objvFileResourceEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convFileResource.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FuncModuleName = objvFileResourceEN.FuncModuleName == "[null]" ? null :  objvFileResourceEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convFileResource.IsBelongsCurrCMPrj, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.IsBelongsCurrCMPrj = objvFileResourceEN.IsBelongsCurrCMPrj; //是否属于当前项目
}
if (arrFldSet.Contains(convFileResource.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.IsGeneCode = objvFileResourceEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(convFileResource.IsCanDel, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.IsCanDel = objvFileResourceEN.IsCanDel; //是否可删除
}
if (arrFldSet.Contains(convFileResource.FileLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FileLength = objvFileResourceEN.FileLength; //文件长度
}
if (arrFldSet.Contains(convFileResource.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.FileType = objvFileResourceEN.FileType == "[null]" ? null :  objvFileResourceEN.FileType; //文件类型
}
if (arrFldSet.Contains(convFileResource.CreationTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.CreationTime = objvFileResourceEN.CreationTime == "[null]" ? null :  objvFileResourceEN.CreationTime; //建立时间
}
if (arrFldSet.Contains(convFileResource.LastWriteTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.LastWriteTime = objvFileResourceEN.LastWriteTime == "[null]" ? null :  objvFileResourceEN.LastWriteTime; //修改日期
}
if (arrFldSet.Contains(convFileResource.CheckDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.CheckDateTime = objvFileResourceEN.CheckDateTime == "[null]" ? null :  objvFileResourceEN.CheckDateTime; //CheckDateTime
}
if (arrFldSet.Contains(convFileResource.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.InUse = objvFileResourceEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFileResource.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.IsExistFile = objvFileResourceEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convFileResource.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.PrjId = objvFileResourceEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convFileResource.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.PrjName = objvFileResourceEN.PrjName == "[null]" ? null :  objvFileResourceEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convFileResource.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.CmPrjId = objvFileResourceEN.CmPrjId; //CM工程Id
}
if (arrFldSet.Contains(convFileResource.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.CmPrjName = objvFileResourceEN.CmPrjName == "[null]" ? null :  objvFileResourceEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convFileResource.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.IpAddress = objvFileResourceEN.IpAddress == "[null]" ? null :  objvFileResourceEN.IpAddress; //服务器
}
if (arrFldSet.Contains(convFileResource.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.UpdDate = objvFileResourceEN.UpdDate == "[null]" ? null :  objvFileResourceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFileResource.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.UpdUser = objvFileResourceEN.UpdUser == "[null]" ? null :  objvFileResourceEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFileResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFileResourceEN.Memo = objvFileResourceEN.Memo == "[null]" ? null :  objvFileResourceEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvFileResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFileResourceEN objvFileResourceEN)
{
try
{
if (objvFileResourceEN.FileDirName == "[null]") objvFileResourceEN.FileDirName = null; //文件目录名
if (objvFileResourceEN.FileName == "[null]") objvFileResourceEN.FileName = null; //文件名
if (objvFileResourceEN.Extension == "[null]") objvFileResourceEN.Extension = null; //扩展名
if (objvFileResourceEN.TabId == "[null]") objvFileResourceEN.TabId = null; //表ID
if (objvFileResourceEN.TabName == "[null]") objvFileResourceEN.TabName = null; //表名
if (objvFileResourceEN.TabCnName == "[null]") objvFileResourceEN.TabCnName = null; //表中文名
if (objvFileResourceEN.TabStateId == "[null]") objvFileResourceEN.TabStateId = null; //表状态ID
if (objvFileResourceEN.FuncModuleAgcId == "[null]") objvFileResourceEN.FuncModuleAgcId = null; //功能模块Id
if (objvFileResourceEN.FuncModuleName == "[null]") objvFileResourceEN.FuncModuleName = null; //功能模块名称
if (objvFileResourceEN.FileType == "[null]") objvFileResourceEN.FileType = null; //文件类型
if (objvFileResourceEN.CreationTime == "[null]") objvFileResourceEN.CreationTime = null; //建立时间
if (objvFileResourceEN.LastWriteTime == "[null]") objvFileResourceEN.LastWriteTime = null; //修改日期
if (objvFileResourceEN.CheckDateTime == "[null]") objvFileResourceEN.CheckDateTime = null; //CheckDateTime
if (objvFileResourceEN.PrjName == "[null]") objvFileResourceEN.PrjName = null; //工程名称
if (objvFileResourceEN.CmPrjName == "[null]") objvFileResourceEN.CmPrjName = null; //CM工程名
if (objvFileResourceEN.IpAddress == "[null]") objvFileResourceEN.IpAddress = null; //服务器
if (objvFileResourceEN.UpdDate == "[null]") objvFileResourceEN.UpdDate = null; //修改日期
if (objvFileResourceEN.UpdUser == "[null]") objvFileResourceEN.UpdUser = null; //修改者
if (objvFileResourceEN.Memo == "[null]") objvFileResourceEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvFileResourceEN objvFileResourceEN)
{
 vFileResourceDA.CheckProperty4Condition(objvFileResourceEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileResourceBL没有刷新缓存机制(clsFileResourceBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FileResourceID");
//if (arrvFileResourceObjLstCache == null)
//{
//arrvFileResourceObjLstCache = vFileResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFileResourceEN GetObjByFileResourceIDCache(long lngFileResourceID)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName);
List<clsvFileResourceEN> arrvFileResourceObjLstCache = GetObjLstCache();
IEnumerable <clsvFileResourceEN> arrvFileResourceObjLst_Sel =
arrvFileResourceObjLstCache
.Where(x=> x.FileResourceID == lngFileResourceID 
);
if (arrvFileResourceObjLst_Sel.Count() == 0)
{
   clsvFileResourceEN obj = clsvFileResourceBL.GetObjByFileResourceID(lngFileResourceID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFileResourceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFileResourceEN> GetAllvFileResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsvFileResourceEN> arrvFileResourceObjLstCache = GetObjLstCache(); 
return arrvFileResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName);
List<clsvFileResourceEN> arrvFileResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFileResourceObjLstCache;
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
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvFileResourceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvFileResourceEN> lstvFileResourceObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvFileResourceObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvFileResourceObjLst">[clsvFileResourceEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvFileResourceEN> lstvFileResourceObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvFileResourceBL.listXmlNode);
writer.WriteStartElement(clsvFileResourceBL.itemsXmlNode);
foreach (clsvFileResourceEN objvFileResourceEN in lstvFileResourceObjLst)
{
clsvFileResourceBL.SerializeXML(writer, objvFileResourceEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvFileResourceEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvFileResourceEN objvFileResourceEN)
{
writer.WriteStartElement(clsvFileResourceBL.itemXmlNode);
 
writer.WriteElementString(convFileResource.FileResourceID, objvFileResourceEN.FileResourceID.ToString(CultureInfo.InvariantCulture));
 
if (objvFileResourceEN.FileDirName != null)
{
writer.WriteElementString(convFileResource.FileDirName, objvFileResourceEN.FileDirName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.FileName != null)
{
writer.WriteElementString(convFileResource.FileName, objvFileResourceEN.FileName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.Extension != null)
{
writer.WriteElementString(convFileResource.Extension, objvFileResourceEN.Extension.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.TabId != null)
{
writer.WriteElementString(convFileResource.TabId, objvFileResourceEN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.TabName != null)
{
writer.WriteElementString(convFileResource.TabName, objvFileResourceEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.TabCnName != null)
{
writer.WriteElementString(convFileResource.TabCnName, objvFileResourceEN.TabCnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.TabStateId != null)
{
writer.WriteElementString(convFileResource.TabStateId, objvFileResourceEN.TabStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.FuncModuleAgcId != null)
{
writer.WriteElementString(convFileResource.FuncModuleAgcId, objvFileResourceEN.FuncModuleAgcId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.FuncModuleName != null)
{
writer.WriteElementString(convFileResource.FuncModuleName, objvFileResourceEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convFileResource.IsBelongsCurrCMPrj, objvFileResourceEN.IsBelongsCurrCMPrj.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convFileResource.IsGeneCode, objvFileResourceEN.IsGeneCode.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convFileResource.IsCanDel, objvFileResourceEN.IsCanDel.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convFileResource.FileLength, objvFileResourceEN.FileLength.ToString());
 
if (objvFileResourceEN.FileType != null)
{
writer.WriteElementString(convFileResource.FileType, objvFileResourceEN.FileType.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.CreationTime != null)
{
writer.WriteElementString(convFileResource.CreationTime, objvFileResourceEN.CreationTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.LastWriteTime != null)
{
writer.WriteElementString(convFileResource.LastWriteTime, objvFileResourceEN.LastWriteTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.CheckDateTime != null)
{
writer.WriteElementString(convFileResource.CheckDateTime, objvFileResourceEN.CheckDateTime.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convFileResource.InUse, objvFileResourceEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convFileResource.IsExistFile, objvFileResourceEN.IsExistFile.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvFileResourceEN.PrjId != null)
{
writer.WriteElementString(convFileResource.PrjId, objvFileResourceEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.PrjName != null)
{
writer.WriteElementString(convFileResource.PrjName, objvFileResourceEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.CmPrjId != null)
{
writer.WriteElementString(convFileResource.CmPrjId, objvFileResourceEN.CmPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.CmPrjName != null)
{
writer.WriteElementString(convFileResource.CmPrjName, objvFileResourceEN.CmPrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.IpAddress != null)
{
writer.WriteElementString(convFileResource.IpAddress, objvFileResourceEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.UpdDate != null)
{
writer.WriteElementString(convFileResource.UpdDate, objvFileResourceEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.UpdUser != null)
{
writer.WriteElementString(convFileResource.UpdUser, objvFileResourceEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvFileResourceEN.Memo != null)
{
writer.WriteElementString(convFileResource.Memo, objvFileResourceEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvFileResourceEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
reader.Read();
while (!(reader.Name == clsvFileResourceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convFileResource.FileResourceID))
{
objvFileResourceEN.FileResourceID = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convFileResource.FileDirName))
{
objvFileResourceEN.FileDirName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.FileName))
{
objvFileResourceEN.FileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.Extension))
{
objvFileResourceEN.Extension = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.TabId))
{
objvFileResourceEN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.TabName))
{
objvFileResourceEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.TabCnName))
{
objvFileResourceEN.TabCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.TabStateId))
{
objvFileResourceEN.TabStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.FuncModuleAgcId))
{
objvFileResourceEN.FuncModuleAgcId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.FuncModuleName))
{
objvFileResourceEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.IsBelongsCurrCMPrj))
{
objvFileResourceEN.IsBelongsCurrCMPrj = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convFileResource.IsGeneCode))
{
objvFileResourceEN.IsGeneCode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convFileResource.IsCanDel))
{
objvFileResourceEN.IsCanDel = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convFileResource.FileLength))
{
objvFileResourceEN.FileLength = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convFileResource.FileType))
{
objvFileResourceEN.FileType = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.CreationTime))
{
objvFileResourceEN.CreationTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.LastWriteTime))
{
objvFileResourceEN.LastWriteTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.CheckDateTime))
{
objvFileResourceEN.CheckDateTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.InUse))
{
objvFileResourceEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convFileResource.IsExistFile))
{
objvFileResourceEN.IsExistFile = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convFileResource.PrjId))
{
objvFileResourceEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.PrjName))
{
objvFileResourceEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.CmPrjId))
{
objvFileResourceEN.CmPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.CmPrjName))
{
objvFileResourceEN.CmPrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.IpAddress))
{
objvFileResourceEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.UpdDate))
{
objvFileResourceEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.UpdUser))
{
objvFileResourceEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convFileResource.Memo))
{
objvFileResourceEN.Memo = reader.ReadElementContentAsString();
}
}
return objvFileResourceEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvFileResourceObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvFileResourceEN GetObjFromXmlStr(string strvFileResourceObjXmlStr)
{
clsvFileResourceEN objvFileResourceEN = new clsvFileResourceEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvFileResourceObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvFileResourceBL.itemXmlNode))
{
objvFileResourceEN = GetObjFromXml(reader);
return objvFileResourceEN;
}
}
return objvFileResourceEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvFileResourceEN objvFileResourceEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvFileResourceEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngFileResourceID)
{
if (strInFldName != convFileResource.FileResourceID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFileResource.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFileResource.AttributeName));
throw new Exception(strMsg);
}
var objvFileResource = clsvFileResourceBL.GetObjByFileResourceIDCache(lngFileResourceID);
if (objvFileResource == null) return "";
return objvFileResource[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvFileResourceEN objvFileResourceEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvFileResourceEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvFileResourceEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvFileResourceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvFileResourceEN> lstvFileResourceObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvFileResourceObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvFileResourceEN objvFileResourceEN in lstvFileResourceObjLst)
{
string strJSON_One = SerializeObjToJSON(objvFileResourceEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvFileResourceDA.GetRecCount(strTabName);
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
int intRecCount = clsvFileResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFileResourceDA.GetRecCount();
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
int intRecCount = clsvFileResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFileResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFileResourceEN objvFileResourceCond)
{
List<clsvFileResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFileResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFileResource.AttributeName)
{
if (objvFileResourceCond.IsUpdated(strFldName) == false) continue;
if (objvFileResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else
{
if (objvFileResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFileResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFileResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFileResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFileResourceCond[strFldName]));
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
 List<string> arrList = clsvFileResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFileResourceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFileResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}