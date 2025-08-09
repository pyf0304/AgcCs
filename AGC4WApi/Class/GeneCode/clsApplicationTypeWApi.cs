
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsApplicationTypeWApi
 表名:ApplicationType(00050127)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:47
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
public static class  clsApplicationTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeId(this clsApplicationTypeEN objApplicationTypeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objApplicationTypeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeId) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeId, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeId] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, conApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, conApplicationType.ApplicationTypeName);
objApplicationTypeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeSimName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, conApplicationType.ApplicationTypeSimName);
objApplicationTypeEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeSimName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeSimName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeSimName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetApplicationTypeENName(this clsApplicationTypeEN objApplicationTypeEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, conApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, conApplicationType.ApplicationTypeENName);
objApplicationTypeEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ApplicationTypeENName) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ApplicationTypeENName, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ApplicationTypeENName] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conApplicationType.ProgLangTypeId);
objApplicationTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId2">编程语言类型Id2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId2(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId2, 2, conApplicationType.ProgLangTypeId2);
objApplicationTypeEN.ProgLangTypeId2 = strProgLangTypeId2; //编程语言类型Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId2) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId2, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId2] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId3">编程语言类型Id3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId3(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId3, 2, conApplicationType.ProgLangTypeId3);
objApplicationTypeEN.ProgLangTypeId3 = strProgLangTypeId3; //编程语言类型Id3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId3) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId3, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId3] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId4">编程语言类型Id4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId4(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4, 2, conApplicationType.ProgLangTypeId4);
objApplicationTypeEN.ProgLangTypeId4 = strProgLangTypeId4; //编程语言类型Id4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId4) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId4, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId4] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId5">编程语言类型Id5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetProgLangTypeId5(this clsApplicationTypeEN objApplicationTypeEN, string strProgLangTypeId5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId5, 2, conApplicationType.ProgLangTypeId5);
objApplicationTypeEN.ProgLangTypeId5 = strProgLangTypeId5; //编程语言类型Id5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.ProgLangTypeId5) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.ProgLangTypeId5, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.ProgLangTypeId5] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetIsVisible(this clsApplicationTypeEN objApplicationTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objApplicationTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.IsVisible) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.IsVisible, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.IsVisible] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intVisitedNum">访问数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetVisitedNum(this clsApplicationTypeEN objApplicationTypeEN, int intVisitedNum, string strComparisonOp="")
	{
objApplicationTypeEN.VisitedNum = intVisitedNum; //访问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.VisitedNum) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.VisitedNum, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.VisitedNum] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetOrderNum(this clsApplicationTypeEN objApplicationTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conApplicationType.OrderNum);
objApplicationTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.OrderNum) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.OrderNum, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.OrderNum] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsApplicationTypeEN SetMemo(this clsApplicationTypeEN objApplicationTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conApplicationType.Memo);
objApplicationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objApplicationTypeEN.dicFldComparisonOp.ContainsKey(conApplicationType.Memo) == false)
{
objApplicationTypeEN.dicFldComparisonOp.Add(conApplicationType.Memo, strComparisonOp);
}
else
{
objApplicationTypeEN.dicFldComparisonOp[conApplicationType.Memo] = strComparisonOp;
}
}
return objApplicationTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsApplicationTypeEN objApplicationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.ApplicationTypeId, objApplicationTypeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeName, objApplicationTypeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeSimName, objApplicationTypeCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ApplicationTypeENName, objApplicationTypeCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId, objApplicationTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId2) == true)
{
string strComparisonOpProgLangTypeId2 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId2, objApplicationTypeCond.ProgLangTypeId2, strComparisonOpProgLangTypeId2);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId3) == true)
{
string strComparisonOpProgLangTypeId3 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId3];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId3, objApplicationTypeCond.ProgLangTypeId3, strComparisonOpProgLangTypeId3);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId4) == true)
{
string strComparisonOpProgLangTypeId4 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId4];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId4, objApplicationTypeCond.ProgLangTypeId4, strComparisonOpProgLangTypeId4);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.ProgLangTypeId5) == true)
{
string strComparisonOpProgLangTypeId5 = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.ProgLangTypeId5];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.ProgLangTypeId5, objApplicationTypeCond.ProgLangTypeId5, strComparisonOpProgLangTypeId5);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.IsVisible) == true)
{
if (objApplicationTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conApplicationType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conApplicationType.IsVisible);
}
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.VisitedNum) == true)
{
string strComparisonOpVisitedNum = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.VisitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.VisitedNum, objApplicationTypeCond.VisitedNum, strComparisonOpVisitedNum);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.OrderNum) == true)
{
string strComparisonOpOrderNum = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conApplicationType.OrderNum, objApplicationTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objApplicationTypeCond.IsUpdated(conApplicationType.Memo) == true)
{
string strComparisonOpMemo = objApplicationTypeCond.dicFldComparisonOp[conApplicationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conApplicationType.Memo, objApplicationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsApplicationTypeEN objApplicationTypeEN)
{
 if (objApplicationTypeEN.ApplicationTypeId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objApplicationTypeEN.sfUpdFldSetStr = objApplicationTypeEN.getsfUpdFldSetStr();
clsApplicationTypeWApi.CheckPropertyNew(objApplicationTypeEN); 
bool bolResult = clsApplicationTypeWApi.UpdateRecord(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ApplicationType(应用程序类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objApplicationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsApplicationTypeEN objApplicationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objApplicationTypeEN == null) return "";
if (objApplicationTypeEN.ApplicationTypeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ApplicationTypeId !=  {0}", objApplicationTypeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ApplicationTypeName = '{0}'", objApplicationTypeEN.ApplicationTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsApplicationTypeEN objApplicationTypeEN)
{
try
{
clsApplicationTypeWApi.CheckPropertyNew(objApplicationTypeEN); 
bool bolResult = clsApplicationTypeWApi.AddNewRecord(objApplicationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsApplicationTypeEN objApplicationTypeEN, string strWhereCond)
{
try
{
clsApplicationTypeWApi.CheckPropertyNew(objApplicationTypeEN); 
bool bolResult = clsApplicationTypeWApi.UpdateWithCondition(objApplicationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public enum enumApplicationType : int
{
[Description("未知")]
Unknown_0 = 0,
[Description("Win应用")]
WinApp_1 = 1,
[Description("Web应用")]
WebApp_2 = 2,
[Description("JavaWeb应用")]
JavaWeb_3 = 3,
[Description("Web网站")]
WebSite_4 = 4,
[Description("AndroidApp")]
AndroidApp_5 = 5,
[Description("IOSApp")]
IOSApp_6 = 6,
[Description("公共应用后台")]
PubApp4WinWeb_7 = 7,
[Description("SilverLight应用")]
SilverLightApp_8 = 8,
[Description("未知")]
Unknown_9 = 9,
[Description("Web服务访问应用")]
WebSrvAccess_10 = 10,
[Description("表字段常量")]
TableFldConst_11 = 11,
[Description("WebApi访问应用")]
WebApiAccess_12 = 12,
[Description("AspMvc应用")]
AspMvcApp_13 = 13,
[Description("JavaWin应用程序")]
JavaWinApp_14 = 14,
[Description("SwiftWin应用程序")]
SwiftWinApp_15 = 15,
[Description("AspMvc应用-TS")]
AspMvcApp_TS_16 = 16,
[Description("Web应用-JS")]
WebApp_JS_17 = 17,
[Description("Spa应用InCore-TS")]
SpaAppInCore_TS_18 = 18,
[Description("WebApi应用")]
WebApi_19 = 19,
[Description("AspMvcAjax应用")]
AspMvcAjaxApp_20 = 20,
[Description("AndroidApp-WA")]
AndroidApp_WA_21 = 21,
[Description("IOSApp-WA")]
IOSApp_WA_22 = 22,
[Description("公共类")]
PubClass_23 = 23,
[Description("Neo4J应用")]
Neo4JApp_24 = 24,
[Description("Neo4J应用后台")]
Neo4JApp4WinWeb_25 = 25,
[Description("Neo4JWA访问应用")]
Neo4JWAAccess_26 = 26,
[Description("SpaInCoreUT")]
SpaInCoreUT_27 = 27,
[Description("Web应用-JS-RJ")]
WebApp_JS_RJ_28 = 28,
[Description("公共类-TS")]
PubClass_TS_29 = 29,
[Description("Vue应用InCore-TS")]
VueAppInCore_TS_30 = 30,
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsApplicationTypeWApi
{
private static readonly string mstrApiControllerName = "ApplicationTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsApplicationTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[应用程序类型]...","0");
List<clsApplicationTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ApplicationTypeId";
objDDL.DataTextField="ApplicationTypeName";
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

public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conApplicationType.ApplicationTypeId); 
List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsApplicationTypeEN objApplicationTypeEN = new clsApplicationTypeEN()
{
ApplicationTypeId = 0,
ApplicationTypeName = "选[应用程序类型]..."
};
arrObjLst.Insert(0, objApplicationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conApplicationType.ApplicationTypeId;
objComboBox.DisplayMember = conApplicationType.ApplicationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsApplicationTypeEN objApplicationTypeEN)
{
if (!Object.Equals(null, objApplicationTypeEN.ApplicationTypeName) && GetStrLen(objApplicationTypeEN.ApplicationTypeName) > 30)
{
 throw new Exception("字段[应用程序类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objApplicationTypeEN.ApplicationTypeSimName) && GetStrLen(objApplicationTypeEN.ApplicationTypeSimName) > 30)
{
 throw new Exception("字段[应用程序类型简称]的长度不能超过30!");
}
if (!Object.Equals(null, objApplicationTypeEN.ApplicationTypeENName) && GetStrLen(objApplicationTypeEN.ApplicationTypeENName) > 30)
{
 throw new Exception("字段[应用类型英文名]的长度不能超过30!");
}
if (!Object.Equals(null, objApplicationTypeEN.ProgLangTypeId) && GetStrLen(objApplicationTypeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objApplicationTypeEN.ProgLangTypeId2) && GetStrLen(objApplicationTypeEN.ProgLangTypeId2) > 2)
{
 throw new Exception("字段[编程语言类型Id2]的长度不能超过2!");
}
if (!Object.Equals(null, objApplicationTypeEN.ProgLangTypeId3) && GetStrLen(objApplicationTypeEN.ProgLangTypeId3) > 2)
{
 throw new Exception("字段[编程语言类型Id3]的长度不能超过2!");
}
if (!Object.Equals(null, objApplicationTypeEN.ProgLangTypeId4) && GetStrLen(objApplicationTypeEN.ProgLangTypeId4) > 2)
{
 throw new Exception("字段[编程语言类型Id4]的长度不能超过2!");
}
if (!Object.Equals(null, objApplicationTypeEN.ProgLangTypeId5) && GetStrLen(objApplicationTypeEN.ProgLangTypeId5) > 2)
{
 throw new Exception("字段[编程语言类型Id5]的长度不能超过2!");
}
if (!Object.Equals(null, objApplicationTypeEN.Memo) && GetStrLen(objApplicationTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objApplicationTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
if (intApplicationTypeId == 0) return null;
string strAction = "GetObjByApplicationTypeId";
clsApplicationTypeEN objApplicationTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objApplicationTypeEN = JsonConvert.DeserializeObject<clsApplicationTypeEN>(strJson);
return objApplicationTypeEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsApplicationTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsApplicationTypeEN objApplicationTypeEN;
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
objApplicationTypeEN = JsonConvert.DeserializeObject<clsApplicationTypeEN>(strJson);
return objApplicationTypeEN;
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
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsApplicationTypeEN GetObjByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel =
from objApplicationTypeEN in arrApplicationTypeObjLstCache
where objApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objApplicationTypeEN;
if (arrApplicationTypeObjLst_Sel.Count() == 0)
{
   clsApplicationTypeEN obj = clsApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrApplicationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetApplicationTypeNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel1 =
from objApplicationTypeEN in arrApplicationTypeObjLstCache
where objApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objApplicationTypeEN;
List <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel = new List<clsApplicationTypeEN>();
foreach (clsApplicationTypeEN obj in arrApplicationTypeObjLst_Sel1)
{
arrApplicationTypeObjLst_Sel.Add(obj);
}
if (arrApplicationTypeObjLst_Sel.Count > 0)
{
return arrApplicationTypeObjLst_Sel[0].ApplicationTypeName;
}
string strErrMsgForGetObjById = string.Format("在ApplicationType对象缓存列表中,找不到记录[ApplicationTypeId = {0}](函数:{1})", intApplicationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel1 =
from objApplicationTypeEN in arrApplicationTypeObjLstCache
where objApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objApplicationTypeEN;
List <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel = new List<clsApplicationTypeEN>();
foreach (clsApplicationTypeEN obj in arrApplicationTypeObjLst_Sel1)
{
arrApplicationTypeObjLst_Sel.Add(obj);
}
if (arrApplicationTypeObjLst_Sel.Count > 0)
{
return arrApplicationTypeObjLst_Sel[0].ApplicationTypeName;
}
string strErrMsgForGetObjById = string.Format("在ApplicationType对象缓存列表中,找不到记录的相关名称[ApplicationTypeId = {0}](函数:{1})", intApplicationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLst(string strWhereCond)
{
 List<clsApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstByApplicationTypeIdLst(List<int> arrApplicationTypeId)
{
 List<clsApplicationTypeEN> arrObjLst; 
string strAction = "GetObjLstByApplicationTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrApplicationTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsApplicationTypeEN> GetObjLstByApplicationTypeIdLstCache(List<int> arrApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsApplicationTypeEN> arrApplicationTypeObjLst_Sel =
from objApplicationTypeEN in arrApplicationTypeObjLstCache
where arrApplicationTypeId.Contains(objApplicationTypeEN.ApplicationTypeId)
select objApplicationTypeEN;
return arrApplicationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsApplicationTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
public static List<clsApplicationTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
public static List<clsApplicationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
public static List<clsApplicationTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsApplicationTypeEN>>(strJson);
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
public static int DelRecord(int intApplicationTypeId)
{
string strAction = "DelRecord";
try
{
 clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intApplicationTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsApplicationTypeWApi.ReFreshCache();
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
public static int DelApplicationTypes(List<string> arrApplicationTypeId)
{
string strAction = "DelApplicationTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrApplicationTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsApplicationTypeWApi.ReFreshCache();
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
public static int DelApplicationTypesByCond(string strWhereCond)
{
string strAction = "DelApplicationTypesByCond";
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
public static bool AddNewRecord(clsApplicationTypeEN objApplicationTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsApplicationTypeEN>(objApplicationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objApplicationTypeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsApplicationTypeEN objApplicationTypeEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsApplicationTypeEN>(objApplicationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsApplicationTypeWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsApplicationTypeEN objApplicationTypeEN)
{
if (string.IsNullOrEmpty(objApplicationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsApplicationTypeEN>(objApplicationTypeEN);
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
 /// <param name = "objApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsApplicationTypeEN objApplicationTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objApplicationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objApplicationTypeEN.ApplicationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsApplicationTypeEN>(objApplicationTypeEN);
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
public static bool IsExist(int intApplicationTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString()
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
 /// <param name = "objApplicationTypeENS">源对象</param>
 /// <param name = "objApplicationTypeENT">目标对象</param>
 public static void CopyTo(clsApplicationTypeEN objApplicationTypeENS, clsApplicationTypeEN objApplicationTypeENT)
{
try
{
objApplicationTypeENT.ApplicationTypeId = objApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objApplicationTypeENT.ApplicationTypeName = objApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objApplicationTypeENT.ApplicationTypeSimName = objApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objApplicationTypeENT.ApplicationTypeENName = objApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objApplicationTypeENT.ProgLangTypeId = objApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objApplicationTypeENT.ProgLangTypeId2 = objApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objApplicationTypeENT.ProgLangTypeId3 = objApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objApplicationTypeENT.ProgLangTypeId4 = objApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objApplicationTypeENT.ProgLangTypeId5 = objApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objApplicationTypeENT.IsVisible = objApplicationTypeENS.IsVisible; //是否显示
objApplicationTypeENT.VisitedNum = objApplicationTypeENS.VisitedNum; //访问数
objApplicationTypeENT.OrderNum = objApplicationTypeENS.OrderNum; //序号
objApplicationTypeENT.Memo = objApplicationTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsApplicationTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsApplicationTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsApplicationTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsApplicationTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsApplicationTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsApplicationTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
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
if (clsApplicationTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsApplicationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsApplicationTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsApplicationTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsApplicationTypeEN._CurrTabName;
List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrApplicationTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsApplicationTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conApplicationType.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conApplicationType.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ProgLangTypeId2, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ProgLangTypeId3, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ProgLangTypeId4, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.ProgLangTypeId5, Type.GetType("System.String"));
objDT.Columns.Add(conApplicationType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conApplicationType.VisitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conApplicationType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conApplicationType.Memo, Type.GetType("System.String"));
foreach (clsApplicationTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conApplicationType.ApplicationTypeId] = objInFor[conApplicationType.ApplicationTypeId];
objDR[conApplicationType.ApplicationTypeName] = objInFor[conApplicationType.ApplicationTypeName];
objDR[conApplicationType.ApplicationTypeSimName] = objInFor[conApplicationType.ApplicationTypeSimName];
objDR[conApplicationType.ApplicationTypeENName] = objInFor[conApplicationType.ApplicationTypeENName];
objDR[conApplicationType.ProgLangTypeId] = objInFor[conApplicationType.ProgLangTypeId];
objDR[conApplicationType.ProgLangTypeId2] = objInFor[conApplicationType.ProgLangTypeId2];
objDR[conApplicationType.ProgLangTypeId3] = objInFor[conApplicationType.ProgLangTypeId3];
objDR[conApplicationType.ProgLangTypeId4] = objInFor[conApplicationType.ProgLangTypeId4];
objDR[conApplicationType.ProgLangTypeId5] = objInFor[conApplicationType.ProgLangTypeId5];
objDR[conApplicationType.IsVisible] = objInFor[conApplicationType.IsVisible];
objDR[conApplicationType.VisitedNum] = objInFor[conApplicationType.VisitedNum];
objDR[conApplicationType.OrderNum] = objInFor[conApplicationType.OrderNum];
objDR[conApplicationType.Memo] = objInFor[conApplicationType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 应用程序类型(ApplicationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ApplicationType : clsCommFun4BL
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
clsApplicationTypeWApi.ReFreshThisCache();
}
}

}