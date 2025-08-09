
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvReferFilesWApi
 表名:vReferFiles(00050461)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:58
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
public static class  clsvReferFilesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileId">引用文件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileId(this clsvReferFilesEN objvReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileId, 8, convReferFiles.ReferFileId);
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, convReferFiles.ReferFileId);
objvReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetFileName(this clsvReferFilesEN objvReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, convReferFiles.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, convReferFiles.FileName);
objvReferFilesEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.FileName) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.FileName, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.FileName] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileTypeId">引用文件类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileTypeId(this clsvReferFilesEN objvReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, convReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, convReferFiles.ReferFileTypeId);
objvReferFilesEN.ReferFileTypeId = strReferFileTypeId; //引用文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileTypeId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileTypeId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileTypeId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileTypeName">引用文件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetReferFileTypeName(this clsvReferFilesEN objvReferFilesEN, string strReferFileTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileTypeName, 50, convReferFiles.ReferFileTypeName);
objvReferFilesEN.ReferFileTypeName = strReferFileTypeName; //引用文件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.ReferFileTypeName) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.ReferFileTypeName, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.ReferFileTypeName] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetFilePath(this clsvReferFilesEN objvReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convReferFiles.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convReferFiles.FilePath);
objvReferFilesEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.FilePath) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.FilePath, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.FilePath] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedDownLoad">是否需要下载</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetIsNeedDownLoad(this clsvReferFilesEN objvReferFilesEN, bool bolIsNeedDownLoad, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedDownLoad, convReferFiles.IsNeedDownLoad);
objvReferFilesEN.IsNeedDownLoad = bolIsNeedDownLoad; //是否需要下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.IsNeedDownLoad) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.IsNeedDownLoad, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.IsNeedDownLoad] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersion">版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetVersion(this clsvReferFilesEN objvReferFilesEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersion, convReferFiles.Version);
clsCheckSql.CheckFieldLen(strVersion, 30, convReferFiles.Version);
objvReferFilesEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.Version) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.Version, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.Version] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetInUse(this clsvReferFilesEN objvReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objvReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.InUse) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.InUse, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.InUse] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetOrderNum(this clsvReferFilesEN objvReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convReferFiles.OrderNum);
objvReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.OrderNum) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.OrderNum, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.OrderNum] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetUpdDate(this clsvReferFilesEN objvReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convReferFiles.UpdDate);
objvReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.UpdDate) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.UpdDate, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.UpdDate] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetUpdUserId(this clsvReferFilesEN objvReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convReferFiles.UpdUserId);
objvReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.UpdUserId) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.UpdUserId, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.UpdUserId] = strComparisonOp;
}
}
return objvReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvReferFilesEN SetMemo(this clsvReferFilesEN objvReferFilesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convReferFiles.Memo);
objvReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvReferFilesEN.dicFldComparisonOp.ContainsKey(convReferFiles.Memo) == false)
{
objvReferFilesEN.dicFldComparisonOp.Add(convReferFiles.Memo, strComparisonOp);
}
else
{
objvReferFilesEN.dicFldComparisonOp[convReferFiles.Memo] = strComparisonOp;
}
}
return objvReferFilesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvReferFilesEN objvReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileId, objvReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.FileName) == true)
{
string strComparisonOpFileName = objvReferFilesCond.dicFldComparisonOp[convReferFiles.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.FileName, objvReferFilesCond.FileName, strComparisonOpFileName);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileTypeId) == true)
{
string strComparisonOpReferFileTypeId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileTypeId, objvReferFilesCond.ReferFileTypeId, strComparisonOpReferFileTypeId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.ReferFileTypeName) == true)
{
string strComparisonOpReferFileTypeName = objvReferFilesCond.dicFldComparisonOp[convReferFiles.ReferFileTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.ReferFileTypeName, objvReferFilesCond.ReferFileTypeName, strComparisonOpReferFileTypeName);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.FilePath) == true)
{
string strComparisonOpFilePath = objvReferFilesCond.dicFldComparisonOp[convReferFiles.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.FilePath, objvReferFilesCond.FilePath, strComparisonOpFilePath);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.IsNeedDownLoad) == true)
{
if (objvReferFilesCond.IsNeedDownLoad == true)
{
strWhereCond += string.Format(" And {0} = '1'", convReferFiles.IsNeedDownLoad);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convReferFiles.IsNeedDownLoad);
}
}
if (objvReferFilesCond.IsUpdated(convReferFiles.Version) == true)
{
string strComparisonOpVersion = objvReferFilesCond.dicFldComparisonOp[convReferFiles.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.Version, objvReferFilesCond.Version, strComparisonOpVersion);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.InUse) == true)
{
if (objvReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convReferFiles.InUse);
}
}
if (objvReferFilesCond.IsUpdated(convReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objvReferFilesCond.dicFldComparisonOp[convReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convReferFiles.OrderNum, objvReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objvReferFilesCond.dicFldComparisonOp[convReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.UpdDate, objvReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvReferFilesCond.dicFldComparisonOp[convReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.UpdUserId, objvReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvReferFilesCond.IsUpdated(convReferFiles.Memo) == true)
{
string strComparisonOpMemo = objvReferFilesCond.dicFldComparisonOp[convReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convReferFiles.Memo, objvReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vReferFiles(v引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvReferFilesEN objvReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvReferFilesEN == null) return "";
if (objvReferFilesEN.ReferFileId == null || objvReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objvReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objvReferFilesEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objvReferFilesEN.FilePath);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// v引用文件(vReferFiles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvReferFilesWApi
{
private static readonly string mstrApiControllerName = "vReferFilesApi";

 public clsvReferFilesWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvReferFilesEN GetObjByReferFileId(string strReferFileId)
{
if (strReferFileId == "") return null;
string strAction = "GetObjByReferFileId";
clsvReferFilesEN objvReferFilesEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strReferFileId"] = strReferFileId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvReferFilesEN = JsonConvert.DeserializeObject<clsvReferFilesEN>(strJson);
return objvReferFilesEN;
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
public static clsvReferFilesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvReferFilesEN objvReferFilesEN;
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
objvReferFilesEN = JsonConvert.DeserializeObject<clsvReferFilesEN>(strJson);
return objvReferFilesEN;
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
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvReferFilesEN GetObjByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
List<clsvReferFilesEN> arrvReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrvReferFilesObjLst_Sel =
from objvReferFilesEN in arrvReferFilesObjLstCache
where objvReferFilesEN.ReferFileId == strReferFileId 
select objvReferFilesEN;
if (arrvReferFilesObjLst_Sel.Count() == 0)
{
   clsvReferFilesEN obj = clsvReferFilesWApi.GetObjByReferFileId(strReferFileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetObjLst(string strWhereCond)
{
 List<clsvReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
 /// <param name = "arrReferFileId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetObjLstByReferFileIdLst(List<string> arrReferFileId)
{
 List<clsvReferFilesEN> arrObjLst; 
string strAction = "GetObjLstByReferFileIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrReferFileId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
 /// <param name = "arrReferFileId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvReferFilesEN> GetObjLstByReferFileIdLstCache(List<string> arrReferFileId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
List<clsvReferFilesEN> arrvReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsvReferFilesEN> arrvReferFilesObjLst_Sel =
from objvReferFilesEN in arrvReferFilesObjLstCache
where arrReferFileId.Contains(objvReferFilesEN.ReferFileId)
select objvReferFilesEN;
return arrvReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
public static List<clsvReferFilesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
public static List<clsvReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
public static List<clsvReferFilesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvReferFilesEN>>(strJson);
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
public static bool IsExist(string strReferFileId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strReferFileId"] = strReferFileId
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
 /// <param name = "objvReferFilesENS">源对象</param>
 /// <param name = "objvReferFilesENT">目标对象</param>
 public static void CopyTo(clsvReferFilesEN objvReferFilesENS, clsvReferFilesEN objvReferFilesENT)
{
try
{
objvReferFilesENT.ReferFileId = objvReferFilesENS.ReferFileId; //引用文件Id
objvReferFilesENT.FileName = objvReferFilesENS.FileName; //文件名
objvReferFilesENT.ReferFileTypeId = objvReferFilesENS.ReferFileTypeId; //引用文件类型Id
objvReferFilesENT.ReferFileTypeName = objvReferFilesENS.ReferFileTypeName; //引用文件类型名
objvReferFilesENT.FilePath = objvReferFilesENS.FilePath; //文件路径
objvReferFilesENT.IsNeedDownLoad = objvReferFilesENS.IsNeedDownLoad; //是否需要下载
objvReferFilesENT.Version = objvReferFilesENS.Version; //版本
objvReferFilesENT.InUse = objvReferFilesENS.InUse; //是否在用
objvReferFilesENT.OrderNum = objvReferFilesENS.OrderNum; //序号
objvReferFilesENT.UpdDate = objvReferFilesENS.UpdDate; //修改日期
objvReferFilesENT.UpdUserId = objvReferFilesENS.UpdUserId; //修改用户Id
objvReferFilesENT.Memo = objvReferFilesENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvReferFilesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvReferFilesEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvReferFilesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvReferFilesEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvReferFilesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvReferFilesEN._AttributeName)
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
string strKey = string.Format("{0}", clsvReferFilesEN._CurrTabName);
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
public static List<clsvReferFilesEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvReferFilesEN._CurrTabName;
List<clsvReferFilesEN> arrvReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvReferFilesObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvReferFilesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convReferFiles.ReferFileId, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.ReferFileTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.ReferFileTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.IsNeedDownLoad, Type.GetType("System.Boolean"));
objDT.Columns.Add(convReferFiles.Version, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convReferFiles.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convReferFiles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convReferFiles.Memo, Type.GetType("System.String"));
foreach (clsvReferFilesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convReferFiles.ReferFileId] = objInFor[convReferFiles.ReferFileId];
objDR[convReferFiles.FileName] = objInFor[convReferFiles.FileName];
objDR[convReferFiles.ReferFileTypeId] = objInFor[convReferFiles.ReferFileTypeId];
objDR[convReferFiles.ReferFileTypeName] = objInFor[convReferFiles.ReferFileTypeName];
objDR[convReferFiles.FilePath] = objInFor[convReferFiles.FilePath];
objDR[convReferFiles.IsNeedDownLoad] = objInFor[convReferFiles.IsNeedDownLoad];
objDR[convReferFiles.Version] = objInFor[convReferFiles.Version];
objDR[convReferFiles.InUse] = objInFor[convReferFiles.InUse];
objDR[convReferFiles.OrderNum] = objInFor[convReferFiles.OrderNum];
objDR[convReferFiles.UpdDate] = objInFor[convReferFiles.UpdDate];
objDR[convReferFiles.UpdUserId] = objInFor[convReferFiles.UpdUserId];
objDR[convReferFiles.Memo] = objInFor[convReferFiles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}