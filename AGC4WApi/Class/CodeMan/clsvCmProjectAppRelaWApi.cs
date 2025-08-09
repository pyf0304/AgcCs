
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectAppRelaWApi
 表名:vCmProjectAppRela(00050634)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:44
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
public static class  clsvCmProjectAppRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetCMProjectAppRelaId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
objvCmProjectAppRelaEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.CMProjectAppRelaId) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.CMProjectAppRelaId, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.CMProjectAppRelaId] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetPrjId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCmProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCmProjectAppRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCmProjectAppRela.PrjId);
objvCmProjectAppRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.PrjId) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.PrjId, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.PrjId] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetPrjName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCmProjectAppRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCmProjectAppRela.PrjName);
objvCmProjectAppRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.PrjName) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.PrjName, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.PrjName] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetMemo(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCmProjectAppRela.Memo);
objvCmProjectAppRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.Memo) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.Memo, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.Memo] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetUpdDate(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCmProjectAppRela.UpdDate);
objvCmProjectAppRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.UpdDate) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.UpdDate, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.UpdDate] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convCmProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCmProjectAppRela.ApplicationTypeName);
objvCmProjectAppRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.ApplicationTypeName) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeENName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convCmProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convCmProjectAppRela.ApplicationTypeENName);
objvCmProjectAppRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.ApplicationTypeENName) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeSimName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCmProjectAppRela.ApplicationTypeSimName);
objvCmProjectAppRelaEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.ApplicationTypeSimName) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetCmPrjName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCmProjectAppRela.CmPrjName);
objvCmProjectAppRelaEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.CmPrjName) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.CmPrjName, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.CmPrjName] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCmProjectAppRela.ApplicationTypeId);
objvCmProjectAppRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.ApplicationTypeId) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetCmPrjId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCmProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCmProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCmProjectAppRela.CmPrjId);
objvCmProjectAppRelaEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.CmPrjId) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.CmPrjId, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.CmPrjId] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetUpdUser(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCmProjectAppRela.UpdUser);
objvCmProjectAppRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.UpdUser) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.UpdUser, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.UpdUser] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetOrderNum(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCmProjectAppRela.OrderNum);
objvCmProjectAppRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.OrderNum) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.OrderNum, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.OrderNum] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppOrderNum">AppOrderNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetAppOrderNum(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, int intAppOrderNum, string strComparisonOp="")
	{
objvCmProjectAppRelaEN.AppOrderNum = intAppOrderNum; //AppOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.AppOrderNum) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.AppOrderNum, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.AppOrderNum] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAppIsVisible">AppIsVisible</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetAppIsVisible(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, bool bolAppIsVisible, string strComparisonOp="")
	{
objvCmProjectAppRelaEN.AppIsVisible = bolAppIsVisible; //AppIsVisible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCmProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCmProjectAppRela.AppIsVisible) == false)
{
objvCmProjectAppRelaEN.dicFldComparisonOp.Add(convCmProjectAppRela.AppIsVisible, strComparisonOp);
}
else
{
objvCmProjectAppRelaEN.dicFldComparisonOp[convCmProjectAppRela.AppIsVisible] = strComparisonOp;
}
}
return objvCmProjectAppRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCmProjectAppRelaEN objvCmProjectAppRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectAppRela.CMProjectAppRelaId, objvCmProjectAppRelaCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.PrjId) == true)
{
string strComparisonOpPrjId = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.PrjId, objvCmProjectAppRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.PrjName) == true)
{
string strComparisonOpPrjName = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.PrjName, objvCmProjectAppRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.Memo) == true)
{
string strComparisonOpMemo = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.Memo, objvCmProjectAppRelaCond.Memo, strComparisonOpMemo);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.UpdDate, objvCmProjectAppRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.ApplicationTypeName, objvCmProjectAppRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.ApplicationTypeENName, objvCmProjectAppRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.ApplicationTypeSimName, objvCmProjectAppRelaCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.CmPrjName, objvCmProjectAppRelaCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectAppRela.ApplicationTypeId, objvCmProjectAppRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.CmPrjId, objvCmProjectAppRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCmProjectAppRela.UpdUser, objvCmProjectAppRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectAppRela.OrderNum, objvCmProjectAppRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.AppOrderNum) == true)
{
string strComparisonOpAppOrderNum = objvCmProjectAppRelaCond.dicFldComparisonOp[convCmProjectAppRela.AppOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCmProjectAppRela.AppOrderNum, objvCmProjectAppRelaCond.AppOrderNum, strComparisonOpAppOrderNum);
}
if (objvCmProjectAppRelaCond.IsUpdated(convCmProjectAppRela.AppIsVisible) == true)
{
if (objvCmProjectAppRelaCond.AppIsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCmProjectAppRela.AppIsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCmProjectAppRela.AppIsVisible);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vCmProjectAppRela(vCmProjectAppRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvCmProjectAppRelaEN == null) return "";
if (objvCmProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCmProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCmProjectAppRelaEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objvCmProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCmProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCmProjectAppRelaEN.CmPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vCmProjectAppRela(vCmProjectAppRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCmProjectAppRelaWApi
{
private static readonly string mstrApiControllerName = "vCmProjectAppRelaApi";

 public clsvCmProjectAppRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
if (lngCMProjectAppRelaId == 0) return null;
string strAction = "GetObjByCMProjectAppRelaId";
clsvCmProjectAppRelaEN objvCmProjectAppRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCmProjectAppRelaEN = JsonConvert.DeserializeObject<clsvCmProjectAppRelaEN>(strJson);
return objvCmProjectAppRelaEN;
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
public static clsvCmProjectAppRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCmProjectAppRelaEN objvCmProjectAppRelaEN;
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
objvCmProjectAppRelaEN = JsonConvert.DeserializeObject<clsvCmProjectAppRelaEN>(strJson);
return objvCmProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Sel =
from objvCmProjectAppRelaEN in arrvCmProjectAppRelaObjLstCache
where objvCmProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId 
select objvCmProjectAppRelaEN;
if (arrvCmProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsvCmProjectAppRelaEN obj = clsvCmProjectAppRelaWApi.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCmProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaId)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
string strAction = "GetObjLstByCMProjectAppRelaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCMProjectAppRelaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCmProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Sel =
from objvCmProjectAppRelaEN in arrvCmProjectAppRelaObjLstCache
where arrCMProjectAppRelaId.Contains(objvCmProjectAppRelaEN.CMProjectAppRelaId)
select objvCmProjectAppRelaEN;
return arrvCmProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCmProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCmProjectAppRelaEN>>(strJson);
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
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString()
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
 /// <param name = "objvCmProjectAppRelaENS">源对象</param>
 /// <param name = "objvCmProjectAppRelaENT">目标对象</param>
 public static void CopyTo(clsvCmProjectAppRelaEN objvCmProjectAppRelaENS, clsvCmProjectAppRelaEN objvCmProjectAppRelaENT)
{
try
{
objvCmProjectAppRelaENT.CMProjectAppRelaId = objvCmProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvCmProjectAppRelaENT.PrjId = objvCmProjectAppRelaENS.PrjId; //工程Id
objvCmProjectAppRelaENT.PrjName = objvCmProjectAppRelaENS.PrjName; //工程名称
objvCmProjectAppRelaENT.Memo = objvCmProjectAppRelaENS.Memo; //说明
objvCmProjectAppRelaENT.UpdDate = objvCmProjectAppRelaENS.UpdDate; //修改日期
objvCmProjectAppRelaENT.ApplicationTypeName = objvCmProjectAppRelaENS.ApplicationTypeName; //应用程序类型名称
objvCmProjectAppRelaENT.ApplicationTypeENName = objvCmProjectAppRelaENS.ApplicationTypeENName; //应用类型英文名
objvCmProjectAppRelaENT.ApplicationTypeSimName = objvCmProjectAppRelaENS.ApplicationTypeSimName; //应用程序类型简称
objvCmProjectAppRelaENT.CmPrjName = objvCmProjectAppRelaENS.CmPrjName; //CM工程名
objvCmProjectAppRelaENT.ApplicationTypeId = objvCmProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objvCmProjectAppRelaENT.CmPrjId = objvCmProjectAppRelaENS.CmPrjId; //Cm工程Id
objvCmProjectAppRelaENT.UpdUser = objvCmProjectAppRelaENS.UpdUser; //修改者
objvCmProjectAppRelaENT.OrderNum = objvCmProjectAppRelaENS.OrderNum; //序号
objvCmProjectAppRelaENT.AppOrderNum = objvCmProjectAppRelaENS.AppOrderNum; //AppOrderNum
objvCmProjectAppRelaENT.AppIsVisible = objvCmProjectAppRelaENS.AppIsVisible; //AppIsVisible
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
public static DataTable ToDataTable(List<clsvCmProjectAppRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCmProjectAppRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCmProjectAppRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCmProjectAppRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCmProjectAppRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCmProjectAppRelaEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectAppRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectAppRelaWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectAppRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectAppRelaWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCmProjectAppRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCmProjectAppRelaEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCmProjectAppRela.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCmProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCmProjectAppRelaEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCmProjectAppRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCmProjectAppRelaWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCmProjectAppRelaObjLstCache = CacheHelper.Get<List<clsvCmProjectAppRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCmProjectAppRelaObjLstCache = CacheHelper.Get<List<clsvCmProjectAppRelaEN>>(strKey);
}
return arrvCmProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCmProjectAppRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCmProjectAppRela.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCmProjectAppRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCmProjectAppRela.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCmProjectAppRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCmProjectAppRela.AppOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCmProjectAppRela.AppIsVisible, Type.GetType("System.Boolean"));
foreach (clsvCmProjectAppRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCmProjectAppRela.CMProjectAppRelaId] = objInFor[convCmProjectAppRela.CMProjectAppRelaId];
objDR[convCmProjectAppRela.PrjId] = objInFor[convCmProjectAppRela.PrjId];
objDR[convCmProjectAppRela.PrjName] = objInFor[convCmProjectAppRela.PrjName];
objDR[convCmProjectAppRela.Memo] = objInFor[convCmProjectAppRela.Memo];
objDR[convCmProjectAppRela.UpdDate] = objInFor[convCmProjectAppRela.UpdDate];
objDR[convCmProjectAppRela.ApplicationTypeName] = objInFor[convCmProjectAppRela.ApplicationTypeName];
objDR[convCmProjectAppRela.ApplicationTypeENName] = objInFor[convCmProjectAppRela.ApplicationTypeENName];
objDR[convCmProjectAppRela.ApplicationTypeSimName] = objInFor[convCmProjectAppRela.ApplicationTypeSimName];
objDR[convCmProjectAppRela.CmPrjName] = objInFor[convCmProjectAppRela.CmPrjName];
objDR[convCmProjectAppRela.ApplicationTypeId] = objInFor[convCmProjectAppRela.ApplicationTypeId];
objDR[convCmProjectAppRela.CmPrjId] = objInFor[convCmProjectAppRela.CmPrjId];
objDR[convCmProjectAppRela.UpdUser] = objInFor[convCmProjectAppRela.UpdUser];
objDR[convCmProjectAppRela.OrderNum] = objInFor[convCmProjectAppRela.OrderNum];
objDR[convCmProjectAppRela.AppOrderNum] = objInFor[convCmProjectAppRela.AppOrderNum];
objDR[convCmProjectAppRela.AppIsVisible] = objInFor[convCmProjectAppRela.AppIsVisible];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}