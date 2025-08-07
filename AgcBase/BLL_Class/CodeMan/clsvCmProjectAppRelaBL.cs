
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCmProjectAppRelaBL
 表名:vCmProjectAppRela(00050634)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:39
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
public static class  clsvCmProjectAppRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectAppRelaEN GetObj(this K_CMProjectAppRelaId_vCmProjectAppRela myKey)
{
clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = clsvCmProjectAppRelaBL.vCmProjectAppRelaDA.GetObjByCMProjectAppRelaId(myKey.Value);
return objvCmProjectAppRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetPrjId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCmProjectAppRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCmProjectAppRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCmProjectAppRela.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetPrjName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCmProjectAppRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCmProjectAppRela.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetMemo(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCmProjectAppRela.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetUpdDate(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCmProjectAppRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convCmProjectAppRela.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCmProjectAppRela.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeENName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convCmProjectAppRela.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convCmProjectAppRela.ApplicationTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetApplicationTypeSimName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCmProjectAppRela.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetCmPrjName(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCmProjectAppRela.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetCmPrjId(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCmProjectAppRela.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCmProjectAppRela.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCmProjectAppRela.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetUpdUser(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCmProjectAppRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCmProjectAppRelaEN SetAppOrderNum(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN, int? intAppOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaENS">源对象</param>
 /// <param name = "objvCmProjectAppRelaENT">目标对象</param>
 public static void CopyTo(this clsvCmProjectAppRelaEN objvCmProjectAppRelaENS, clsvCmProjectAppRelaEN objvCmProjectAppRelaENT)
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
 /// <param name = "objvCmProjectAppRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCmProjectAppRelaEN:objvCmProjectAppRelaENT</returns>
 public static clsvCmProjectAppRelaEN CopyTo(this clsvCmProjectAppRelaEN objvCmProjectAppRelaENS)
{
try
{
 clsvCmProjectAppRelaEN objvCmProjectAppRelaENT = new clsvCmProjectAppRelaEN()
{
CMProjectAppRelaId = objvCmProjectAppRelaENS.CMProjectAppRelaId, //Cm工程应用关系Id
PrjId = objvCmProjectAppRelaENS.PrjId, //工程Id
PrjName = objvCmProjectAppRelaENS.PrjName, //工程名称
Memo = objvCmProjectAppRelaENS.Memo, //说明
UpdDate = objvCmProjectAppRelaENS.UpdDate, //修改日期
ApplicationTypeName = objvCmProjectAppRelaENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvCmProjectAppRelaENS.ApplicationTypeENName, //应用类型英文名
ApplicationTypeSimName = objvCmProjectAppRelaENS.ApplicationTypeSimName, //应用程序类型简称
CmPrjName = objvCmProjectAppRelaENS.CmPrjName, //CM工程名
ApplicationTypeId = objvCmProjectAppRelaENS.ApplicationTypeId, //应用程序类型ID
CmPrjId = objvCmProjectAppRelaENS.CmPrjId, //Cm工程Id
UpdUser = objvCmProjectAppRelaENS.UpdUser, //修改者
OrderNum = objvCmProjectAppRelaENS.OrderNum, //序号
AppOrderNum = objvCmProjectAppRelaENS.AppOrderNum, //AppOrderNum
AppIsVisible = objvCmProjectAppRelaENS.AppIsVisible, //AppIsVisible
};
 return objvCmProjectAppRelaENT;
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
public static void CheckProperty4Condition(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
 clsvCmProjectAppRelaBL.vCmProjectAppRelaDA.CheckProperty4Condition(objvCmProjectAppRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--vCmProjectAppRela(vCmProjectAppRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvCmProjectAppRelaEN == null) return true;
if (objvCmProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCmProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCmProjectAppRelaEN.CmPrjId);
if (clsvCmProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objvCmProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCmProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCmProjectAppRelaEN.CmPrjId);
if (clsvCmProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vCmProjectAppRela(vCmProjectAppRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCmProjectAppRela
{
public virtual bool UpdRelaTabDate(long lngCMProjectAppRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCmProjectAppRela(vCmProjectAppRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCmProjectAppRelaBL
{
public static RelatedActions_vCmProjectAppRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCmProjectAppRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCmProjectAppRelaDA vCmProjectAppRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCmProjectAppRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCmProjectAppRelaBL()
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
if (string.IsNullOrEmpty(clsvCmProjectAppRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCmProjectAppRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCmProjectAppRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCmProjectAppRelaDA.GetDataTable_vCmProjectAppRela(strWhereCond);
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
objDT = vCmProjectAppRelaDA.GetDataTable(strWhereCond);
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
objDT = vCmProjectAppRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCmProjectAppRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCmProjectAppRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCmProjectAppRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCmProjectAppRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCmProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCmProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaIdLst)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCMProjectAppRelaIdLst);
 string strWhereCond = string.Format("CMProjectAppRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCmProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Sel =
arrvCmProjectAppRelaObjLstCache
.Where(x => arrCMProjectAppRelaIdLst.Contains(x.CMProjectAppRelaId));
return arrvCmProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
public static List<clsvCmProjectAppRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCmProjectAppRelaEN> GetSubObjLstCache(clsvCmProjectAppRelaEN objvCmProjectAppRelaCond)
{
 string strPrjId = objvCmProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCmProjectAppRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCmProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCmProjectAppRela._AttributeName)
{
if (objvCmProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCmProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objvCmProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCmProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCmProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCmProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCmProjectAppRelaCond[strFldName]));
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
List<clsvCmProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCmProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCmProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
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
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
public static List<clsvCmProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
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
public static List<clsvCmProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCmProjectAppRelaEN> arrObjLst = new List<clsvCmProjectAppRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = new clsvCmProjectAppRelaEN();
try
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCmProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCmProjectAppRelaEN.PrjId = objRow[convCmProjectAppRela.PrjId].ToString().Trim(); //工程Id
objvCmProjectAppRelaEN.PrjName = objRow[convCmProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCmProjectAppRelaEN.Memo = objRow[convCmProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCmProjectAppRela.Memo].ToString().Trim(); //说明
objvCmProjectAppRelaEN.UpdDate = objRow[convCmProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCmProjectAppRelaEN.ApplicationTypeName = objRow[convCmProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCmProjectAppRelaEN.ApplicationTypeENName = objRow[convCmProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCmProjectAppRelaEN.ApplicationTypeSimName = objRow[convCmProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCmProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCmProjectAppRelaEN.CmPrjName = objRow[convCmProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCmProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCmProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCmProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCmProjectAppRelaEN.CmPrjId = objRow[convCmProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objvCmProjectAppRelaEN.UpdUser = objRow[convCmProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCmProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCmProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCmProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCmProjectAppRelaEN.AppOrderNum = objRow[convCmProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCmProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCmProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCmProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCmProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCmProjectAppRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCmProjectAppRela(ref clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
bool bolResult = vCmProjectAppRelaDA.GetvCmProjectAppRela(ref objvCmProjectAppRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = vCmProjectAppRelaDA.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
return objvCmProjectAppRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCmProjectAppRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = vCmProjectAppRelaDA.GetFirstObj(strWhereCond);
 return objvCmProjectAppRelaEN;
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
public static clsvCmProjectAppRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = vCmProjectAppRelaDA.GetObjByDataRow(objRow);
 return objvCmProjectAppRelaEN;
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
public static clsvCmProjectAppRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCmProjectAppRelaEN objvCmProjectAppRelaEN = vCmProjectAppRelaDA.GetObjByDataRow(objRow);
 return objvCmProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "lstvCmProjectAppRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaIdFromList(long lngCMProjectAppRelaId, List<clsvCmProjectAppRelaEN> lstvCmProjectAppRelaObjLst)
{
foreach (clsvCmProjectAppRelaEN objvCmProjectAppRelaEN in lstvCmProjectAppRelaObjLst)
{
if (objvCmProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId)
{
return objvCmProjectAppRelaEN;
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
 long lngCMProjectAppRelaId;
 try
 {
 lngCMProjectAppRelaId = new clsvCmProjectAppRelaDA().GetFirstID(strWhereCond);
 return lngCMProjectAppRelaId;
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
 arrList = vCmProjectAppRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCmProjectAppRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
bool bolIsExist = vCmProjectAppRelaDA.IsExist(lngCMProjectAppRelaId);
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
 bolIsExist = clsvCmProjectAppRelaDA.IsExistTable();
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
 bolIsExist = vCmProjectAppRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCmProjectAppRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
try
{
objvCmProjectAppRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCmProjectAppRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCmProjectAppRela.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.CMProjectAppRelaId = objvCmProjectAppRelaEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(convCmProjectAppRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.PrjId = objvCmProjectAppRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCmProjectAppRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.PrjName = objvCmProjectAppRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCmProjectAppRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.Memo = objvCmProjectAppRelaEN.Memo == "[null]" ? null :  objvCmProjectAppRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convCmProjectAppRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.UpdDate = objvCmProjectAppRelaEN.UpdDate == "[null]" ? null :  objvCmProjectAppRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCmProjectAppRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.ApplicationTypeName = objvCmProjectAppRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convCmProjectAppRela.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.ApplicationTypeENName = objvCmProjectAppRelaEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convCmProjectAppRela.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.ApplicationTypeSimName = objvCmProjectAppRelaEN.ApplicationTypeSimName == "[null]" ? null :  objvCmProjectAppRelaEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCmProjectAppRela.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.CmPrjName = objvCmProjectAppRelaEN.CmPrjName == "[null]" ? null :  objvCmProjectAppRelaEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCmProjectAppRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.ApplicationTypeId = objvCmProjectAppRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCmProjectAppRela.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.CmPrjId = objvCmProjectAppRelaEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCmProjectAppRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.UpdUser = objvCmProjectAppRelaEN.UpdUser == "[null]" ? null :  objvCmProjectAppRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCmProjectAppRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.OrderNum = objvCmProjectAppRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCmProjectAppRela.AppOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.AppOrderNum = objvCmProjectAppRelaEN.AppOrderNum; //AppOrderNum
}
if (arrFldSet.Contains(convCmProjectAppRela.AppIsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCmProjectAppRelaEN.AppIsVisible = objvCmProjectAppRelaEN.AppIsVisible; //AppIsVisible
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
 /// <param name = "objvCmProjectAppRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
try
{
if (objvCmProjectAppRelaEN.Memo == "[null]") objvCmProjectAppRelaEN.Memo = null; //说明
if (objvCmProjectAppRelaEN.UpdDate == "[null]") objvCmProjectAppRelaEN.UpdDate = null; //修改日期
if (objvCmProjectAppRelaEN.ApplicationTypeSimName == "[null]") objvCmProjectAppRelaEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCmProjectAppRelaEN.CmPrjName == "[null]") objvCmProjectAppRelaEN.CmPrjName = null; //CM工程名
if (objvCmProjectAppRelaEN.UpdUser == "[null]") objvCmProjectAppRelaEN.UpdUser = null; //修改者
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
public static void CheckProperty4Condition(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
 vCmProjectAppRelaDA.CheckProperty4Condition(objvCmProjectAppRelaEN);
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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectAppRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectAppRelaBL没有刷新缓存机制(clsCMProjectAppRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CMProjectAppRelaId");
//if (arrvCmProjectAppRelaObjLstCache == null)
//{
//arrvCmProjectAppRelaObjLstCache = vCmProjectAppRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCmProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLst_Sel =
arrvCmProjectAppRelaObjLstCache
.Where(x=> x.CMProjectAppRelaId == lngCMProjectAppRelaId 
);
if (arrvCmProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsvCmProjectAppRelaEN obj = clsvCmProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngCMProjectAppRelaId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCmProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetAllvCmProjectAppRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrvCmProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCmProjectAppRelaEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCmProjectAppRelaEN> arrvCmProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCmProjectAppRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCmProjectAppRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCmProjectAppRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCmProjectAppRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvCmProjectAppRelaEN._RefreshTimeLst[clsvCmProjectAppRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vCmProjectAppRela(vCmProjectAppRela)
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvCmProjectAppRelaEN objvCmProjectAppRelaEN)
{
//检测记录是否存在
string strResult = vCmProjectAppRelaDA.GetUniCondStr(objvCmProjectAppRelaEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngCMProjectAppRelaId, string strPrjId)
{
if (strInFldName != convCmProjectAppRela.CMProjectAppRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCmProjectAppRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCmProjectAppRela._AttributeName));
throw new Exception(strMsg);
}
var objvCmProjectAppRela = clsvCmProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, strPrjId);
if (objvCmProjectAppRela == null) return "";
return objvCmProjectAppRela[strOutFldName].ToString();
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
int intRecCount = clsvCmProjectAppRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCmProjectAppRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCmProjectAppRelaDA.GetRecCount();
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
int intRecCount = clsvCmProjectAppRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCmProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCmProjectAppRelaEN objvCmProjectAppRelaCond)
{
 string strPrjId = objvCmProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCmProjectAppRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCmProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCmProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCmProjectAppRela._AttributeName)
{
if (objvCmProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCmProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objvCmProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCmProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCmProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCmProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCmProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCmProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCmProjectAppRelaCond[strFldName]));
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
 List<string> arrList = clsvCmProjectAppRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCmProjectAppRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCmProjectAppRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}