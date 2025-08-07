
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectsBL
 表名:vProjects(00050167)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvProjectsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectsEN GetObj(this K_PrjId_vProjects myKey)
{
clsvProjectsEN objvProjectsEN = clsvProjectsBL.vProjectsDA.GetObjByPrjId(myKey.Value);
return objvProjectsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjId(this clsvProjectsEN objvProjectsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convProjects.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convProjects.PrjId);
}
objvProjectsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjName(this clsvProjectsEN objvProjectsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convProjects.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convProjects.PrjName);
}
objvProjectsEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetPrjDomain(this clsvProjectsEN objvProjectsEN, string strPrjDomain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, convProjects.PrjDomain);
}
objvProjectsEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.PrjDomain) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.PrjDomain, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.PrjDomain] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsoPrjName(this clsvProjectsEN objvProjectsEN, string strIsoPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIsoPrjName, 50, convProjects.IsoPrjName);
}
objvProjectsEN.IsoPrjName = strIsoPrjName; //ISO工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsoPrjName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsoPrjName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsoPrjName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetJavaPackageName(this clsvProjectsEN objvProjectsEN, string strJavaPackageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaPackageName, 200, convProjects.JavaPackageName);
}
objvProjectsEN.JavaPackageName = strJavaPackageName; //Java包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.JavaPackageName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.JavaPackageName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.JavaPackageName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsRelaDataBase(this clsvProjectsEN objvProjectsEN, bool bolIsRelaDataBase, string strComparisonOp="")
	{
objvProjectsEN.IsRelaDataBase = bolIsRelaDataBase; //是否关联数据库
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsRelaDataBase) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsRelaDataBase, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsRelaDataBase] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetSoftStructureId(this clsvProjectsEN objvProjectsEN, string strSoftStructureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSoftStructureId, convProjects.SoftStructureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSoftStructureId, 4, convProjects.SoftStructureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSoftStructureId, 4, convProjects.SoftStructureId);
}
objvProjectsEN.SoftStructureId = strSoftStructureId; //架构ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.SoftStructureId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.SoftStructureId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.SoftStructureId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetSoftStructureName(this clsvProjectsEN objvProjectsEN, string strSoftStructureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSoftStructureName, 50, convProjects.SoftStructureName);
}
objvProjectsEN.SoftStructureName = strSoftStructureName; //架构名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.SoftStructureName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.SoftStructureName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.SoftStructureName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetApplicationTypeId(this clsvProjectsEN objvProjectsEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convProjects.ApplicationTypeId);
objvProjectsEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.ApplicationTypeId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.ApplicationTypeId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.ApplicationTypeId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetApplicationTypeName(this clsvProjectsEN objvProjectsEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convProjects.ApplicationTypeName);
}
objvProjectsEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.ApplicationTypeName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.ApplicationTypeName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.ApplicationTypeName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUseStateId(this clsvProjectsEN objvProjectsEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convProjects.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convProjects.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convProjects.UseStateId);
}
objvProjectsEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UseStateId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UseStateId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UseStateId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUseStateName(this clsvProjectsEN objvProjectsEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convProjects.UseStateName);
}
objvProjectsEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UseStateName) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UseStateName, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UseStateName] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetIsSupportMvc(this clsvProjectsEN objvProjectsEN, bool bolIsSupportMvc, string strComparisonOp="")
	{
objvProjectsEN.IsSupportMvc = bolIsSupportMvc; //是否支持Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.IsSupportMvc) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.IsSupportMvc, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.IsSupportMvc] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUserId(this clsvProjectsEN objvProjectsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convProjects.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convProjects.UserId);
}
objvProjectsEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UserId) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UserId, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UserId] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetUpdDate(this clsvProjectsEN objvProjectsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convProjects.UpdDate);
}
objvProjectsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.UpdDate) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.UpdDate, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.UpdDate] = strComparisonOp;
}
}
return objvProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectsEN SetMemo(this clsvProjectsEN objvProjectsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convProjects.Memo);
}
objvProjectsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectsEN.dicFldComparisonOp.ContainsKey(convProjects.Memo) == false)
{
objvProjectsEN.dicFldComparisonOp.Add(convProjects.Memo, strComparisonOp);
}
else
{
objvProjectsEN.dicFldComparisonOp[convProjects.Memo] = strComparisonOp;
}
}
return objvProjectsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
 public static void CopyTo(this clsvProjectsEN objvProjectsENS, clsvProjectsEN objvProjectsENT)
{
try
{
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程Id
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.IsoPrjName = objvProjectsENS.IsoPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
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
 /// <param name = "objvProjectsENS">源对象</param>
 /// <returns>目标对象=>clsvProjectsEN:objvProjectsENT</returns>
 public static clsvProjectsEN CopyTo(this clsvProjectsEN objvProjectsENS)
{
try
{
 clsvProjectsEN objvProjectsENT = new clsvProjectsEN()
{
PrjId = objvProjectsENS.PrjId, //工程Id
PrjName = objvProjectsENS.PrjName, //工程名称
PrjDomain = objvProjectsENS.PrjDomain, //域/包名
IsoPrjName = objvProjectsENS.IsoPrjName, //ISO工程名
JavaPackageName = objvProjectsENS.JavaPackageName, //Java包名
IsRelaDataBase = objvProjectsENS.IsRelaDataBase, //是否关联数据库
SoftStructureId = objvProjectsENS.SoftStructureId, //架构ID
SoftStructureName = objvProjectsENS.SoftStructureName, //架构名称
ApplicationTypeId = objvProjectsENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvProjectsENS.ApplicationTypeName, //应用程序类型名称
UseStateId = objvProjectsENS.UseStateId, //使用状态Id
UseStateName = objvProjectsENS.UseStateName, //使用状态名称
IsSupportMvc = objvProjectsENS.IsSupportMvc, //是否支持Mvc
UserId = objvProjectsENS.UserId, //用户Id
UpdDate = objvProjectsENS.UpdDate, //修改日期
Memo = objvProjectsENS.Memo, //说明
};
 return objvProjectsENT;
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
public static void CheckProperty4Condition(this clsvProjectsEN objvProjectsEN)
{
 clsvProjectsBL.vProjectsDA.CheckProperty4Condition(objvProjectsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProjectsEN objvProjectsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProjectsCond.IsUpdated(convProjects.PrjId) == true)
{
string strComparisonOpPrjId = objvProjectsCond.dicFldComparisonOp[convProjects.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjId, objvProjectsCond.PrjId, strComparisonOpPrjId);
}
if (objvProjectsCond.IsUpdated(convProjects.PrjName) == true)
{
string strComparisonOpPrjName = objvProjectsCond.dicFldComparisonOp[convProjects.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjName, objvProjectsCond.PrjName, strComparisonOpPrjName);
}
if (objvProjectsCond.IsUpdated(convProjects.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objvProjectsCond.dicFldComparisonOp[convProjects.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.PrjDomain, objvProjectsCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objvProjectsCond.IsUpdated(convProjects.IsoPrjName) == true)
{
string strComparisonOpIsoPrjName = objvProjectsCond.dicFldComparisonOp[convProjects.IsoPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.IsoPrjName, objvProjectsCond.IsoPrjName, strComparisonOpIsoPrjName);
}
if (objvProjectsCond.IsUpdated(convProjects.JavaPackageName) == true)
{
string strComparisonOpJavaPackageName = objvProjectsCond.dicFldComparisonOp[convProjects.JavaPackageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.JavaPackageName, objvProjectsCond.JavaPackageName, strComparisonOpJavaPackageName);
}
if (objvProjectsCond.IsUpdated(convProjects.IsRelaDataBase) == true)
{
if (objvProjectsCond.IsRelaDataBase == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProjects.IsRelaDataBase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProjects.IsRelaDataBase);
}
}
if (objvProjectsCond.IsUpdated(convProjects.SoftStructureId) == true)
{
string strComparisonOpSoftStructureId = objvProjectsCond.dicFldComparisonOp[convProjects.SoftStructureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.SoftStructureId, objvProjectsCond.SoftStructureId, strComparisonOpSoftStructureId);
}
if (objvProjectsCond.IsUpdated(convProjects.SoftStructureName) == true)
{
string strComparisonOpSoftStructureName = objvProjectsCond.dicFldComparisonOp[convProjects.SoftStructureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.SoftStructureName, objvProjectsCond.SoftStructureName, strComparisonOpSoftStructureName);
}
if (objvProjectsCond.IsUpdated(convProjects.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvProjectsCond.dicFldComparisonOp[convProjects.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convProjects.ApplicationTypeId, objvProjectsCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvProjectsCond.IsUpdated(convProjects.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvProjectsCond.dicFldComparisonOp[convProjects.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.ApplicationTypeName, objvProjectsCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvProjectsCond.IsUpdated(convProjects.UseStateId) == true)
{
string strComparisonOpUseStateId = objvProjectsCond.dicFldComparisonOp[convProjects.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UseStateId, objvProjectsCond.UseStateId, strComparisonOpUseStateId);
}
if (objvProjectsCond.IsUpdated(convProjects.UseStateName) == true)
{
string strComparisonOpUseStateName = objvProjectsCond.dicFldComparisonOp[convProjects.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UseStateName, objvProjectsCond.UseStateName, strComparisonOpUseStateName);
}
if (objvProjectsCond.IsUpdated(convProjects.IsSupportMvc) == true)
{
if (objvProjectsCond.IsSupportMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProjects.IsSupportMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProjects.IsSupportMvc);
}
}
if (objvProjectsCond.IsUpdated(convProjects.UserId) == true)
{
string strComparisonOpUserId = objvProjectsCond.dicFldComparisonOp[convProjects.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UserId, objvProjectsCond.UserId, strComparisonOpUserId);
}
if (objvProjectsCond.IsUpdated(convProjects.UpdDate) == true)
{
string strComparisonOpUpdDate = objvProjectsCond.dicFldComparisonOp[convProjects.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.UpdDate, objvProjectsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvProjectsCond.IsUpdated(convProjects.Memo) == true)
{
string strComparisonOpMemo = objvProjectsCond.dicFldComparisonOp[convProjects.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjects.Memo, objvProjectsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vProjects
{
public virtual bool UpdRelaTabDate(string strPrjId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程(vProjects)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvProjectsBL
{
public static RelatedActions_vProjects relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvProjectsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvProjectsDA vProjectsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvProjectsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvProjectsBL()
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
if (string.IsNullOrEmpty(clsvProjectsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProjectsEN._ConnectString);
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
public static DataTable GetDataTable_vProjects(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vProjectsDA.GetDataTable_vProjects(strWhereCond);
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
objDT = vProjectsDA.GetDataTable(strWhereCond);
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
objDT = vProjectsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vProjectsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vProjectsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vProjectsDA.GetDataTable_Top(objTopPara);
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
objDT = vProjectsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vProjectsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vProjectsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvProjectsEN> GetObjLstByPrjIdLst(List<string> arrPrjIdLst)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPrjIdLst, true);
 string strWhereCond = string.Format("PrjId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvProjectsEN> GetObjLstByPrjIdLstCache(List<string> arrPrjIdLst)
{
string strKey = string.Format("{0}", clsvProjectsEN._CurrTabName);
List<clsvProjectsEN> arrvProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectsEN> arrvProjectsObjLst_Sel =
arrvProjectsObjLstCache
.Where(x => arrPrjIdLst.Contains(x.PrjId));
return arrvProjectsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectsEN> GetObjLst(string strWhereCond)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
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
public static List<clsvProjectsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvProjectsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvProjectsEN> GetSubObjLstCache(clsvProjectsEN objvProjectsCond)
{
List<clsvProjectsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProjects._AttributeName)
{
if (objvProjectsCond.IsUpdated(strFldName) == false) continue;
if (objvProjectsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectsCond[strFldName].ToString());
}
else
{
if (objvProjectsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProjectsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProjectsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProjectsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProjectsCond[strFldName]));
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
public static List<clsvProjectsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
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
public static List<clsvProjectsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
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
List<clsvProjectsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvProjectsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvProjectsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
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
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
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
public static List<clsvProjectsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvProjectsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvProjectsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
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
public static List<clsvProjectsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectsEN.PrjId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvProjectsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvProjects(ref clsvProjectsEN objvProjectsEN)
{
bool bolResult = vProjectsDA.GetvProjects(ref objvProjectsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectsEN GetObjByPrjId(string strPrjId)
{
if (strPrjId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPrjId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPrjId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvProjectsEN objvProjectsEN = vProjectsDA.GetObjByPrjId(strPrjId);
return objvProjectsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvProjectsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvProjectsEN objvProjectsEN = vProjectsDA.GetFirstObj(strWhereCond);
 return objvProjectsEN;
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
public static clsvProjectsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvProjectsEN objvProjectsEN = vProjectsDA.GetObjByDataRow(objRow);
 return objvProjectsEN;
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
public static clsvProjectsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvProjectsEN objvProjectsEN = vProjectsDA.GetObjByDataRow(objRow);
 return objvProjectsEN;
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
 /// <param name = "strPrjId">所给的关键字</param>
 /// <param name = "lstvProjectsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProjectsEN GetObjByPrjIdFromList(string strPrjId, List<clsvProjectsEN> lstvProjectsObjLst)
{
foreach (clsvProjectsEN objvProjectsEN in lstvProjectsObjLst)
{
if (objvProjectsEN.PrjId == strPrjId)
{
return objvProjectsEN;
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
 string strPrjId;
 try
 {
 strPrjId = new clsvProjectsDA().GetFirstID(strWhereCond);
 return strPrjId;
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
 arrList = vProjectsDA.GetID(strWhereCond);
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
bool bolIsExist = vProjectsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPrjId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vProjectsDA.IsExist(strPrjId);
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
 bolIsExist = clsvProjectsDA.IsExistTable();
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
 bolIsExist = vProjectsDA.IsExistTable(strTabName);
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
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
 public static void CopyTo(clsvProjectsEN objvProjectsENS, clsvProjectsEN objvProjectsENT)
{
try
{
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程Id
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.IsoPrjName = objvProjectsENS.IsoPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
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
 /// <param name = "objvProjectsEN">源简化对象</param>
 public static void SetUpdFlag(clsvProjectsEN objvProjectsEN)
{
try
{
objvProjectsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvProjectsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convProjects.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.PrjId = objvProjectsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convProjects.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.PrjName = objvProjectsEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convProjects.PrjDomain, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.PrjDomain = objvProjectsEN.PrjDomain == "[null]" ? null :  objvProjectsEN.PrjDomain; //域/包名
}
if (arrFldSet.Contains(convProjects.IsoPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.IsoPrjName = objvProjectsEN.IsoPrjName == "[null]" ? null :  objvProjectsEN.IsoPrjName; //ISO工程名
}
if (arrFldSet.Contains(convProjects.JavaPackageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.JavaPackageName = objvProjectsEN.JavaPackageName == "[null]" ? null :  objvProjectsEN.JavaPackageName; //Java包名
}
if (arrFldSet.Contains(convProjects.IsRelaDataBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.IsRelaDataBase = objvProjectsEN.IsRelaDataBase; //是否关联数据库
}
if (arrFldSet.Contains(convProjects.SoftStructureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.SoftStructureId = objvProjectsEN.SoftStructureId; //架构ID
}
if (arrFldSet.Contains(convProjects.SoftStructureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.SoftStructureName = objvProjectsEN.SoftStructureName == "[null]" ? null :  objvProjectsEN.SoftStructureName; //架构名称
}
if (arrFldSet.Contains(convProjects.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.ApplicationTypeId = objvProjectsEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convProjects.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.ApplicationTypeName = objvProjectsEN.ApplicationTypeName == "[null]" ? null :  objvProjectsEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convProjects.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.UseStateId = objvProjectsEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(convProjects.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.UseStateName = objvProjectsEN.UseStateName == "[null]" ? null :  objvProjectsEN.UseStateName; //使用状态名称
}
if (arrFldSet.Contains(convProjects.IsSupportMvc, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.IsSupportMvc = objvProjectsEN.IsSupportMvc; //是否支持Mvc
}
if (arrFldSet.Contains(convProjects.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.UserId = objvProjectsEN.UserId; //用户Id
}
if (arrFldSet.Contains(convProjects.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.UpdDate = objvProjectsEN.UpdDate == "[null]" ? null :  objvProjectsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convProjects.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectsEN.Memo = objvProjectsEN.Memo == "[null]" ? null :  objvProjectsEN.Memo; //说明
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
 /// <param name = "objvProjectsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvProjectsEN objvProjectsEN)
{
try
{
if (objvProjectsEN.PrjDomain == "[null]") objvProjectsEN.PrjDomain = null; //域/包名
if (objvProjectsEN.IsoPrjName == "[null]") objvProjectsEN.IsoPrjName = null; //ISO工程名
if (objvProjectsEN.JavaPackageName == "[null]") objvProjectsEN.JavaPackageName = null; //Java包名
if (objvProjectsEN.SoftStructureName == "[null]") objvProjectsEN.SoftStructureName = null; //架构名称
if (objvProjectsEN.ApplicationTypeName == "[null]") objvProjectsEN.ApplicationTypeName = null; //应用程序类型名称
if (objvProjectsEN.UseStateName == "[null]") objvProjectsEN.UseStateName = null; //使用状态名称
if (objvProjectsEN.UpdDate == "[null]") objvProjectsEN.UpdDate = null; //修改日期
if (objvProjectsEN.Memo == "[null]") objvProjectsEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvProjectsEN objvProjectsEN)
{
 vProjectsDA.CheckProperty4Condition(objvProjectsEN);
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
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PrjId");
//if (arrvProjectsObjLstCache == null)
//{
//arrvProjectsObjLstCache = vProjectsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProjectsEN GetObjByPrjIdCache(string strPrjId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvProjectsEN._CurrTabName);
List<clsvProjectsEN> arrvProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectsEN> arrvProjectsObjLst_Sel =
arrvProjectsObjLstCache
.Where(x=> x.PrjId == strPrjId 
);
if (arrvProjectsObjLst_Sel.Count() == 0)
{
   clsvProjectsEN obj = clsvProjectsBL.GetObjByPrjId(strPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvProjectsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProjectsEN> GetAllvProjectsObjLstCache()
{
//获取缓存中的对象列表
List<clsvProjectsEN> arrvProjectsObjLstCache = GetObjLstCache(); 
return arrvProjectsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProjectsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvProjectsEN._CurrTabName);
List<clsvProjectsEN> arrvProjectsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvProjectsObjLstCache;
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
string strKey = string.Format("{0}", clsvProjectsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvProjectsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvProjectsEN._RefreshTimeLst.Count == 0) return "";
return clsvProjectsEN._RefreshTimeLst[clsvProjectsEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strPrjId)
{
if (strInFldName != convProjects.PrjId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convProjects._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convProjects._AttributeName));
throw new Exception(strMsg);
}
var objvProjects = clsvProjectsBL.GetObjByPrjIdCache(strPrjId);
if (objvProjects == null) return "";
return objvProjects[strOutFldName].ToString();
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
int intRecCount = clsvProjectsDA.GetRecCount(strTabName);
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
int intRecCount = clsvProjectsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvProjectsDA.GetRecCount();
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
int intRecCount = clsvProjectsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvProjectsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvProjectsEN objvProjectsCond)
{
List<clsvProjectsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProjects._AttributeName)
{
if (objvProjectsCond.IsUpdated(strFldName) == false) continue;
if (objvProjectsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectsCond[strFldName].ToString());
}
else
{
if (objvProjectsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProjectsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProjectsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProjectsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProjectsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProjectsCond[strFldName]));
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
 List<string> arrList = clsvProjectsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vProjectsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vProjectsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}