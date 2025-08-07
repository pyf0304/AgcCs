
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFtpResourceWApi
 表名:FtpResource(00050210)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:29:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件服务
 模块英文名:FileService
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsFtpResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetIdFtpResource(this clsFtpResourceEN objFtpResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conFtpResource.IdFtpResource);
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conFtpResource.IdFtpResource);
objFtpResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.IdFtpResource) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.IdFtpResource, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.IdFtpResource] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFtpResourceID(this clsFtpResourceEN objFtpResourceEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, conFtpResource.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, conFtpResource.FtpResourceID);
objFtpResourceEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FtpResourceID) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FtpResourceID, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FtpResourceID] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileOriginalName(this clsFtpResourceEN objFtpResourceEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, conFtpResource.FileOriginalName);
objFtpResourceEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileOriginalName) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileOriginalName, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileOriginalName] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetftpServerIP(this clsFtpResourceEN objFtpResourceEN, string strftpServerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strftpServerIP, conFtpResource.ftpServerIP);
clsCheckSql.CheckFieldLen(strftpServerIP, 30, conFtpResource.ftpServerIP);
objFtpResourceEN.ftpServerIP = strftpServerIP; //ftp服务器地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.ftpServerIP) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.ftpServerIP, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.ftpServerIP] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileDirName(this clsFtpResourceEN objFtpResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, conFtpResource.FileDirName);
objFtpResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileDirName) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileDirName, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileDirName] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileRename(this clsFtpResourceEN objFtpResourceEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, conFtpResource.FileRename);
objFtpResourceEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileRename) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileRename, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileRename] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileType(this clsFtpResourceEN objFtpResourceEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, conFtpResource.FileType);
objFtpResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileType) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileType, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileType] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileUpDate(this clsFtpResourceEN objFtpResourceEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, conFtpResource.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, conFtpResource.FileUpDate);
objFtpResourceEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileUpDate) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileUpDate, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileUpDate] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileUpTime(this clsFtpResourceEN objFtpResourceEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, conFtpResource.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, conFtpResource.FileUpTime);
objFtpResourceEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileUpTime) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileUpTime, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileUpTime] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetFileSize(this clsFtpResourceEN objFtpResourceEN, long lngFileSize, string strComparisonOp="")
	{
objFtpResourceEN.FileSize = lngFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.FileSize) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.FileSize, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.FileSize] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetResourceOwner(this clsFtpResourceEN objFtpResourceEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, conFtpResource.ResourceOwner);
objFtpResourceEN.ResourceOwner = strResourceOwner; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.ResourceOwner) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.ResourceOwner, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.ResourceOwner] = strComparisonOp;
}
}
return objFtpResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFtpResourceEN SetMemo(this clsFtpResourceEN objFtpResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFtpResource.Memo);
objFtpResourceEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFtpResourceEN.dicFldComparisonOp.ContainsKey(conFtpResource.Memo) == false)
{
objFtpResourceEN.dicFldComparisonOp.Add(conFtpResource.Memo, strComparisonOp);
}
else
{
objFtpResourceEN.dicFldComparisonOp[conFtpResource.Memo] = strComparisonOp;
}
}
return objFtpResourceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFtpResourceEN objFtpResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFtpResource_Cond.IsUpdated(conFtpResource.IdFtpResource) == true)
{
string strComparisonOp_IdFtpResource = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.IdFtpResource, objFtpResource_Cond.IdFtpResource, strComparisonOp_IdFtpResource);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FtpResourceID, objFtpResource_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileOriginalName, objFtpResource_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.ftpServerIP) == true)
{
string strComparisonOp_ftpServerIP = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.ftpServerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.ftpServerIP, objFtpResource_Cond.ftpServerIP, strComparisonOp_ftpServerIP);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileDirName) == true)
{
string strComparisonOp_FileDirName = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileDirName, objFtpResource_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileRename) == true)
{
string strComparisonOp_FileRename = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileRename, objFtpResource_Cond.FileRename, strComparisonOp_FileRename);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileType) == true)
{
string strComparisonOp_FileType = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileType, objFtpResource_Cond.FileType, strComparisonOp_FileType);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileUpDate, objFtpResource_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.FileUpTime, objFtpResource_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.FileSize) == true)
{
string strComparisonOp_FileSize = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conFtpResource.FileSize, objFtpResource_Cond.FileSize, strComparisonOp_FileSize);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.ResourceOwner, objFtpResource_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objFtpResource_Cond.IsUpdated(conFtpResource.Memo) == true)
{
string strComparisonOp_Memo = objFtpResource_Cond.dicFldComparisonOp[conFtpResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFtpResource.Memo, objFtpResource_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFtpResourceEN objFtpResourceEN)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFtpResourceEN.sfUpdFldSetStr = objFtpResourceEN.getsfUpdFldSetStr();
clsFtpResourceWApi.CheckPropertyNew(objFtpResourceEN); 
bool bolResult = clsFtpResourceWApi.UpdateRecord(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFtpResourceEN objFtpResourceEN)
{
 if (string.IsNullOrEmpty(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFtpResourceWApi.IsExist(objFtpResourceEN.IdFtpResource) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objFtpResourceEN.IdFtpResource, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFtpResourceWApi.CheckPropertyNew(objFtpResourceEN); 
bool bolResult = clsFtpResourceWApi.AddNewRecord(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
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
 /// <param name = "objFtpResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFtpResourceEN objFtpResourceEN)
{
try
{
clsFtpResourceWApi.CheckPropertyNew(objFtpResourceEN); 
string strIdFtpResource = clsFtpResourceWApi.AddNewRecordWithMaxId(objFtpResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
return strIdFtpResource;
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFtpResourceEN objFtpResourceEN, string strWhereCond)
{
try
{
clsFtpResourceWApi.CheckPropertyNew(objFtpResourceEN); 
bool bolResult = clsFtpResourceWApi.UpdateWithCondition(objFtpResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
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
 /// FTP资源(FtpResource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFtpResourceWApi
{
private static readonly string mstrApiControllerName = "FtpResourceApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFtpResourceWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFtpResourceEN objFtpResourceEN)
{
if (!Object.Equals(null, objFtpResourceEN.IdFtpResource) && GetStrLen(objFtpResourceEN.IdFtpResource) > 8)
{
 throw new Exception("字段[FTP资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objFtpResourceEN.FtpResourceID) && GetStrLen(objFtpResourceEN.FtpResourceID) > 8)
{
 throw new Exception("字段[FTP资源ID]的长度不能超过8!");
}
if (!Object.Equals(null, objFtpResourceEN.FileOriginalName) && GetStrLen(objFtpResourceEN.FileOriginalName) > 200)
{
 throw new Exception("字段[文件原名]的长度不能超过200!");
}
if (!Object.Equals(null, objFtpResourceEN.ftpServerIP) && GetStrLen(objFtpResourceEN.ftpServerIP) > 30)
{
 throw new Exception("字段[ftp服务器地址]的长度不能超过30!");
}
if (!Object.Equals(null, objFtpResourceEN.FileDirName) && GetStrLen(objFtpResourceEN.FileDirName) > 200)
{
 throw new Exception("字段[文件目录名]的长度不能超过200!");
}
if (!Object.Equals(null, objFtpResourceEN.FileRename) && GetStrLen(objFtpResourceEN.FileRename) > 200)
{
 throw new Exception("字段[文件新名]的长度不能超过200!");
}
if (!Object.Equals(null, objFtpResourceEN.FileType) && GetStrLen(objFtpResourceEN.FileType) > 30)
{
 throw new Exception("字段[文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objFtpResourceEN.FileUpDate) && GetStrLen(objFtpResourceEN.FileUpDate) > 8)
{
 throw new Exception("字段[创建日期]的长度不能超过8!");
}
if (!Object.Equals(null, objFtpResourceEN.FileUpTime) && GetStrLen(objFtpResourceEN.FileUpTime) > 6)
{
 throw new Exception("字段[创建时间]的长度不能超过6!");
}
if (!Object.Equals(null, objFtpResourceEN.ResourceOwner) && GetStrLen(objFtpResourceEN.ResourceOwner) > 50)
{
 throw new Exception("字段[创建者]的长度不能超过50!");
}
if (!Object.Equals(null, objFtpResourceEN.Memo) && GetStrLen(objFtpResourceEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFtpResourceEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResource(string strIdFtpResource)
{
string strAction = "GetObjByIdFtpResource";
string strErrMsg = string.Empty;
string strResult = "";
clsFtpResourceEN objFtpResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["IdFtpResource"] = strIdFtpResource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFtpResourceEN = JsonConvert.DeserializeObject<clsFtpResourceEN>((string)jobjReturn["returnObj"]);
return objFtpResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strIdFtpResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResource_WA_Cache(string strIdFtpResource)
{
string strAction = "GetObjByIdFtpResource_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFtpResourceEN objFtpResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["IdFtpResource"] = strIdFtpResource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFtpResourceEN = JsonConvert.DeserializeObject<clsFtpResourceEN>((string)jobjReturn["returnObj"]);
return objFtpResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsFtpResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFtpResourceEN objFtpResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFtpResourceEN = JsonConvert.DeserializeObject<clsFtpResourceEN>((string)jobjReturn["returnObj"]);
return objFtpResourceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFtpResourceEN GetObjByIdFtpResource_Cache(string strIdFtpResource)
{
if (string.IsNullOrEmpty(strIdFtpResource) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFtpResourceEN> arrFtpResourceObjLst_Sel =
from objFtpResourceEN in arrFtpResourceObjLst_Cache
where objFtpResourceEN.IdFtpResource == strIdFtpResource
select objFtpResourceEN;
if (arrFtpResourceObjLst_Sel.Count() == 0)
{
   clsFtpResourceEN obj = clsFtpResourceWApi.GetObjByIdFtpResource(strIdFtpResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFtpResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetObjLst(string strWhereCond)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstById_FtpResourceLst(List<string> arrId_FtpResource)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_FtpResourceLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FtpResource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strIdFtpResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFtpResourceEN> GetObjLstById_FtpResourceLst_Cache(List<string> arrId_FtpResource)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFtpResourceEN> arrFtpResourceObjLst_Sel =
from objFtpResourceEN in arrFtpResourceObjLst_Cache
where arrId_FtpResource.Contains(objFtpResourceEN.IdFtpResource)
select objFtpResourceEN;
return arrFtpResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstById_FtpResourceLst_WA_Cache(List<string> arrId_FtpResource)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_FtpResourceLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FtpResource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFtpResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFtpResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFtpResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsFtpResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFtpResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFtpResourceEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelRecord(string strIdFtpResource)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFtpResourceEN objFtpResourceEN = clsFtpResourceWApi.GetObjByIdFtpResource(strIdFtpResource);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strIdFtpResource.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFtpResourceWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelFtpResources(List<string> arrIdFtpResource)
{
string strAction = "DelFtpResources";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdFtpResource);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFtpResourceWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelFtpResourcesByCond(string strWhereCond)
{
string strAction = "DelFtpResourcesByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool AddNewRecord(clsFtpResourceEN objFtpResourceEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFtpResourceEN>(objFtpResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsFtpResourceEN objFtpResourceEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFtpResourceEN>(objFtpResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFtpResourceWApi.ReFreshCache();
var strIdFtpResource = (string)jobjReturn["returnStr"];
return strIdFtpResource;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool UpdateRecord(clsFtpResourceEN objFtpResourceEN)
{
if (string.IsNullOrEmpty(objFtpResourceEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFtpResourceEN.IdFtpResource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFtpResourceEN>(objFtpResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objFtpResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFtpResourceEN objFtpResourceEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFtpResourceEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFtpResourceEN.IdFtpResource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFtpResourceEN.IdFtpResource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFtpResourceEN>(objFtpResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool IsExist(string strIdFtpResource)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["IdFtpResource"] = strIdFtpResource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objFtpResourceENS">源对象</param>
 /// <param name = "objFtpResourceENT">目标对象</param>
 public static void CopyTo(clsFtpResourceEN objFtpResourceENS, clsFtpResourceEN objFtpResourceENT)
{
try
{
objFtpResourceENT.IdFtpResource = objFtpResourceENS.IdFtpResource; //FTP资源流水号
objFtpResourceENT.FtpResourceID = objFtpResourceENS.FtpResourceID; //FTP资源ID
objFtpResourceENT.FileOriginalName = objFtpResourceENS.FileOriginalName; //文件原名
objFtpResourceENT.ftpServerIP = objFtpResourceENS.ftpServerIP; //ftp服务器地址
objFtpResourceENT.FileDirName = objFtpResourceENS.FileDirName; //文件目录名
objFtpResourceENT.FileRename = objFtpResourceENS.FileRename; //文件新名
objFtpResourceENT.FileType = objFtpResourceENS.FileType; //文件类型
objFtpResourceENT.FileUpDate = objFtpResourceENS.FileUpDate; //创建日期
objFtpResourceENT.FileUpTime = objFtpResourceENS.FileUpTime; //创建时间
objFtpResourceENT.FileSize = objFtpResourceENS.FileSize; //文件大小
objFtpResourceENT.ResourceOwner = objFtpResourceENS.ResourceOwner; //创建者
objFtpResourceENT.Memo = objFtpResourceENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFtpResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFtpResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFtpResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFtpResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFtpResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFtpResourceEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsFtpResourceWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdFtpResource");
//if (arrFtpResourceObjLst_Cache == null)
//{
//arrFtpResourceObjLst_Cache = await clsFtpResourceWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
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
if (clsFtpResourceWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFtpResourceWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFtpResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFtpResourceEN._CurrTabName);
List<clsFtpResourceEN> arrFtpResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFtpResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFtpResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFtpResource.IdFtpResource, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.ftpServerIP, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileType, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.FileSize, Type.GetType("System.Int64"));
objDT.Columns.Add(conFtpResource.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(conFtpResource.Memo, Type.GetType("System.String"));
foreach (clsFtpResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFtpResource.IdFtpResource] = objInFor[conFtpResource.IdFtpResource];
objDR[conFtpResource.FtpResourceID] = objInFor[conFtpResource.FtpResourceID];
objDR[conFtpResource.FileOriginalName] = objInFor[conFtpResource.FileOriginalName];
objDR[conFtpResource.ftpServerIP] = objInFor[conFtpResource.ftpServerIP];
objDR[conFtpResource.FileDirName] = objInFor[conFtpResource.FileDirName];
objDR[conFtpResource.FileRename] = objInFor[conFtpResource.FileRename];
objDR[conFtpResource.FileType] = objInFor[conFtpResource.FileType];
objDR[conFtpResource.FileUpDate] = objInFor[conFtpResource.FileUpDate];
objDR[conFtpResource.FileUpTime] = objInFor[conFtpResource.FileUpTime];
objDR[conFtpResource.FileSize] = objInFor[conFtpResource.FileSize];
objDR[conFtpResource.ResourceOwner] = objInFor[conFtpResource.ResourceOwner];
objDR[conFtpResource.Memo] = objInFor[conFtpResource.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// FTP资源(FtpResource)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FtpResource : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsFtpResourceWApi.ReFreshThisCache();
}
}

}