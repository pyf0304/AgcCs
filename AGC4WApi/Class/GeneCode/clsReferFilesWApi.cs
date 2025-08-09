
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFilesWApi
 表名:ReferFiles(00050460)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:07
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
public static class  clsReferFilesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileId">引用文件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetReferFileId(this clsReferFilesEN objReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileId, 8, conReferFiles.ReferFileId);
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, conReferFiles.ReferFileId);
objReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.ReferFileId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.ReferFileId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.ReferFileId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFileName">文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetFileName(this clsReferFilesEN objReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conReferFiles.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, conReferFiles.FileName);
objReferFilesEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.FileName) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.FileName, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.FileName] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileTypeId">引用文件类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetReferFileTypeId(this clsReferFilesEN objReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
objReferFilesEN.ReferFileTypeId = strReferFileTypeId; //引用文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.ReferFileTypeId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.ReferFileTypeId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.ReferFileTypeId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetFilePath(this clsReferFilesEN objReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conReferFiles.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, conReferFiles.FilePath);
objReferFilesEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.FilePath) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.FilePath, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.FilePath] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedDownLoad">是否需要下载</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetIsNeedDownLoad(this clsReferFilesEN objReferFilesEN, bool bolIsNeedDownLoad, string strComparisonOp="")
	{
objReferFilesEN.IsNeedDownLoad = bolIsNeedDownLoad; //是否需要下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.IsNeedDownLoad) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.IsNeedDownLoad, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.IsNeedDownLoad] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersion">版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetVersion(this clsReferFilesEN objReferFilesEN, string strVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersion, 30, conReferFiles.Version);
objReferFilesEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.Version) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.Version, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.Version] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetInUse(this clsReferFilesEN objReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.InUse) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.InUse, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.InUse] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetOrderNum(this clsReferFilesEN objReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conReferFiles.OrderNum);
objReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.OrderNum) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.OrderNum, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.OrderNum] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetUpdDate(this clsReferFilesEN objReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conReferFiles.UpdDate);
objReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.UpdDate) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.UpdDate, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.UpdDate] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetUpdUserId(this clsReferFilesEN objReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conReferFiles.UpdUserId);
objReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.UpdUserId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.UpdUserId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.UpdUserId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetMemo(this clsReferFilesEN objReferFilesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conReferFiles.Memo);
objReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.Memo) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.Memo, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.Memo] = strComparisonOp;
}
}
return objReferFilesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsReferFilesEN objReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objReferFilesCond.IsUpdated(conReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objReferFilesCond.dicFldComparisonOp[conReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.ReferFileId, objReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.FileName) == true)
{
string strComparisonOpFileName = objReferFilesCond.dicFldComparisonOp[conReferFiles.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.FileName, objReferFilesCond.FileName, strComparisonOpFileName);
}
if (objReferFilesCond.IsUpdated(conReferFiles.ReferFileTypeId) == true)
{
string strComparisonOpReferFileTypeId = objReferFilesCond.dicFldComparisonOp[conReferFiles.ReferFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.ReferFileTypeId, objReferFilesCond.ReferFileTypeId, strComparisonOpReferFileTypeId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.FilePath) == true)
{
string strComparisonOpFilePath = objReferFilesCond.dicFldComparisonOp[conReferFiles.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.FilePath, objReferFilesCond.FilePath, strComparisonOpFilePath);
}
if (objReferFilesCond.IsUpdated(conReferFiles.IsNeedDownLoad) == true)
{
if (objReferFilesCond.IsNeedDownLoad == true)
{
strWhereCond += string.Format(" And {0} = '1'", conReferFiles.IsNeedDownLoad);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conReferFiles.IsNeedDownLoad);
}
}
if (objReferFilesCond.IsUpdated(conReferFiles.Version) == true)
{
string strComparisonOpVersion = objReferFilesCond.dicFldComparisonOp[conReferFiles.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.Version, objReferFilesCond.Version, strComparisonOpVersion);
}
if (objReferFilesCond.IsUpdated(conReferFiles.InUse) == true)
{
if (objReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conReferFiles.InUse);
}
}
if (objReferFilesCond.IsUpdated(conReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objReferFilesCond.dicFldComparisonOp[conReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conReferFiles.OrderNum, objReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objReferFilesCond.IsUpdated(conReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objReferFilesCond.dicFldComparisonOp[conReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.UpdDate, objReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objReferFilesCond.IsUpdated(conReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objReferFilesCond.dicFldComparisonOp[conReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.UpdUserId, objReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.Memo) == true)
{
string strComparisonOpMemo = objReferFilesCond.dicFldComparisonOp[conReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.Memo, objReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsReferFilesEN objReferFilesEN)
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objReferFilesEN.sfUpdFldSetStr = objReferFilesEN.getsfUpdFldSetStr();
clsReferFilesWApi.CheckPropertyNew(objReferFilesEN); 
bool bolResult = clsReferFilesWApi.UpdateRecord(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ReferFiles(引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileName_ReferFileTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsReferFilesEN objReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objReferFilesEN == null) return "";
if (objReferFilesEN.ReferFileId == null || objReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsReferFilesEN objReferFilesEN)
{
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesWApi.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesWApi.GetMaxStrId();
 }
clsReferFilesWApi.CheckPropertyNew(objReferFilesEN); 
bool bolResult = clsReferFilesWApi.AddNewRecord(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsReferFilesEN objReferFilesEN)
{
try
{
clsReferFilesWApi.CheckPropertyNew(objReferFilesEN); 
string strReferFileId = clsReferFilesWApi.AddNewRecordWithMaxId(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
return strReferFileId;
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsReferFilesEN objReferFilesEN, string strWhereCond)
{
try
{
clsReferFilesWApi.CheckPropertyNew(objReferFilesEN); 
bool bolResult = clsReferFilesWApi.UpdateWithCondition(objReferFilesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
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
 /// 引用文件(ReferFiles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsReferFilesWApi
{
private static readonly string mstrApiControllerName = "ReferFilesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsReferFilesWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ReferFileId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[引用文件]...","0");
List<clsReferFilesEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ReferFileId";
objDDL.DataTextField="FileName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ReferFileId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conReferFiles.ReferFileId); 
List<clsReferFilesEN> arrObjLst = clsReferFilesWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsReferFilesEN objReferFilesEN = new clsReferFilesEN()
{
ReferFileId = "0",
FileName = "选[引用文件]..."
};
arrObjLst.Insert(0, objReferFilesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conReferFiles.ReferFileId;
objComboBox.DisplayMember = conReferFiles.FileName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsReferFilesEN objReferFilesEN)
{
if (!Object.Equals(null, objReferFilesEN.ReferFileId) && GetStrLen(objReferFilesEN.ReferFileId) > 8)
{
 throw new Exception("字段[引用文件Id]的长度不能超过8!");
}
if (!Object.Equals(null, objReferFilesEN.FileName) && GetStrLen(objReferFilesEN.FileName) > 150)
{
 throw new Exception("字段[文件名]的长度不能超过150!");
}
if (!Object.Equals(null, objReferFilesEN.ReferFileTypeId) && GetStrLen(objReferFilesEN.ReferFileTypeId) > 2)
{
 throw new Exception("字段[引用文件类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objReferFilesEN.FilePath) && GetStrLen(objReferFilesEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objReferFilesEN.Version) && GetStrLen(objReferFilesEN.Version) > 30)
{
 throw new Exception("字段[版本]的长度不能超过30!");
}
if (!Object.Equals(null, objReferFilesEN.UpdDate) && GetStrLen(objReferFilesEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objReferFilesEN.UpdUserId) && GetStrLen(objReferFilesEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objReferFilesEN.Memo) && GetStrLen(objReferFilesEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objReferFilesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsReferFilesEN GetObjByReferFileId(string strReferFileId)
{
if (strReferFileId == "") return null;
string strAction = "GetObjByReferFileId";
clsReferFilesEN objReferFilesEN;
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
objReferFilesEN = JsonConvert.DeserializeObject<clsReferFilesEN>(strJson);
return objReferFilesEN;
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
public static clsReferFilesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsReferFilesEN objReferFilesEN;
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
objReferFilesEN = JsonConvert.DeserializeObject<clsReferFilesEN>(strJson);
return objReferFilesEN;
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
public static clsReferFilesEN GetObjByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel =
from objReferFilesEN in arrReferFilesObjLstCache
where objReferFilesEN.ReferFileId == strReferFileId 
select objReferFilesEN;
if (arrReferFilesObjLst_Sel.Count() == 0)
{
   clsReferFilesEN obj = clsReferFilesWApi.GetObjByReferFileId(strReferFileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFileNameByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return "";
//初始化列表缓存
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel1 =
from objReferFilesEN in arrReferFilesObjLstCache
where objReferFilesEN.ReferFileId == strReferFileId 
select objReferFilesEN;
List <clsReferFilesEN> arrReferFilesObjLst_Sel = new List<clsReferFilesEN>();
foreach (clsReferFilesEN obj in arrReferFilesObjLst_Sel1)
{
arrReferFilesObjLst_Sel.Add(obj);
}
if (arrReferFilesObjLst_Sel.Count > 0)
{
return arrReferFilesObjLst_Sel[0].FileName;
}
string strErrMsgForGetObjById = string.Format("在ReferFiles对象缓存列表中,找不到记录[ReferFileId = {0}](函数:{1})", strReferFileId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsReferFilesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return "";
//初始化列表缓存
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel1 =
from objReferFilesEN in arrReferFilesObjLstCache
where objReferFilesEN.ReferFileId == strReferFileId 
select objReferFilesEN;
List <clsReferFilesEN> arrReferFilesObjLst_Sel = new List<clsReferFilesEN>();
foreach (clsReferFilesEN obj in arrReferFilesObjLst_Sel1)
{
arrReferFilesObjLst_Sel.Add(obj);
}
if (arrReferFilesObjLst_Sel.Count > 0)
{
return arrReferFilesObjLst_Sel[0].FileName;
}
string strErrMsgForGetObjById = string.Format("在ReferFiles对象缓存列表中,找不到记录的相关名称[ReferFileId = {0}](函数:{1})", strReferFileId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsReferFilesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsReferFilesEN> GetObjLst(string strWhereCond)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static List<clsReferFilesEN> GetObjLstByReferFileIdLst(List<string> arrReferFileId)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static IEnumerable<clsReferFilesEN> GetObjLstByReferFileIdLstCache(List<string> arrReferFileId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel =
from objReferFilesEN in arrReferFilesObjLstCache
where arrReferFileId.Contains(objReferFilesEN.ReferFileId)
select objReferFilesEN;
return arrReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static List<clsReferFilesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static List<clsReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static List<clsReferFilesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsReferFilesEN>>(strJson);
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
public static int DelRecord(string strReferFileId)
{
string strAction = "DelRecord";
try
{
 clsReferFilesEN objReferFilesEN = clsReferFilesWApi.GetObjByReferFileId(strReferFileId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strReferFileId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsReferFilesWApi.ReFreshCache();
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
public static int DelReferFiless(List<string> arrReferFileId)
{
string strAction = "DelReferFiless";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrReferFileId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsReferFilesWApi.ReFreshCache();
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
public static int DelReferFilessByCond(string strWhereCond)
{
string strAction = "DelReferFilessByCond";
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
public static bool AddNewRecord(clsReferFilesEN objReferFilesEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsReferFilesEN>(objReferFilesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsReferFilesEN objReferFilesEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsReferFilesEN>(objReferFilesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesWApi.ReFreshCache();
var strReferFileId = (string)jobjReturn0["returnStr"];
return strReferFileId;
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
public static bool UpdateRecord(clsReferFilesEN objReferFilesEN)
{
if (string.IsNullOrEmpty(objReferFilesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objReferFilesEN.ReferFileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsReferFilesEN>(objReferFilesEN);
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsReferFilesEN objReferFilesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objReferFilesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objReferFilesEN.ReferFileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objReferFilesEN.ReferFileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsReferFilesEN>(objReferFilesEN);
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
 /// <param name = "objReferFilesENS">源对象</param>
 /// <param name = "objReferFilesENT">目标对象</param>
 public static void CopyTo(clsReferFilesEN objReferFilesENS, clsReferFilesEN objReferFilesENT)
{
try
{
objReferFilesENT.ReferFileId = objReferFilesENS.ReferFileId; //引用文件Id
objReferFilesENT.FileName = objReferFilesENS.FileName; //文件名
objReferFilesENT.ReferFileTypeId = objReferFilesENS.ReferFileTypeId; //引用文件类型Id
objReferFilesENT.FilePath = objReferFilesENS.FilePath; //文件路径
objReferFilesENT.IsNeedDownLoad = objReferFilesENS.IsNeedDownLoad; //是否需要下载
objReferFilesENT.Version = objReferFilesENS.Version; //版本
objReferFilesENT.InUse = objReferFilesENS.InUse; //是否在用
objReferFilesENT.OrderNum = objReferFilesENS.OrderNum; //序号
objReferFilesENT.UpdDate = objReferFilesENS.UpdDate; //修改日期
objReferFilesENT.UpdUserId = objReferFilesENS.UpdUserId; //修改用户Id
objReferFilesENT.Memo = objReferFilesENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsReferFilesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsReferFilesEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsReferFilesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsReferFilesEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsReferFilesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsReferFilesEN._AttributeName)
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
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
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
if (clsReferFilesWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsReferFilesWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsReferFilesEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsReferFilesEN._CurrTabName;
List<clsReferFilesEN> arrReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrReferFilesObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsReferFilesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conReferFiles.ReferFileId, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.ReferFileTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.IsNeedDownLoad, Type.GetType("System.Boolean"));
objDT.Columns.Add(conReferFiles.Version, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conReferFiles.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conReferFiles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conReferFiles.Memo, Type.GetType("System.String"));
foreach (clsReferFilesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conReferFiles.ReferFileId] = objInFor[conReferFiles.ReferFileId];
objDR[conReferFiles.FileName] = objInFor[conReferFiles.FileName];
objDR[conReferFiles.ReferFileTypeId] = objInFor[conReferFiles.ReferFileTypeId];
objDR[conReferFiles.FilePath] = objInFor[conReferFiles.FilePath];
objDR[conReferFiles.IsNeedDownLoad] = objInFor[conReferFiles.IsNeedDownLoad];
objDR[conReferFiles.Version] = objInFor[conReferFiles.Version];
objDR[conReferFiles.InUse] = objInFor[conReferFiles.InUse];
objDR[conReferFiles.OrderNum] = objInFor[conReferFiles.OrderNum];
objDR[conReferFiles.UpdDate] = objInFor[conReferFiles.UpdDate];
objDR[conReferFiles.UpdUserId] = objInFor[conReferFiles.UpdUserId];
objDR[conReferFiles.Memo] = objInFor[conReferFiles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 引用文件(ReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ReferFiles : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsReferFilesWApi.ReFreshThisCache();
}
}

}