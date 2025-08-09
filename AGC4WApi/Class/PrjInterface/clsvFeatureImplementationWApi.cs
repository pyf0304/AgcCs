
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureImplementationWApi
 表名:vFeatureImplementation(00050394)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsvFeatureImplementationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetmId(this clsvFeatureImplementationEN objvFeatureImplementationEN, long lngmId, string strComparisonOp="")
	{
objvFeatureImplementationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.mId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.mId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.mId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureImplementation.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureImplementation.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureImplementation.FeatureId);
objvFeatureImplementationEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureImplementation.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureImplementation.FeatureName);
objvFeatureImplementationEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetKeyWords(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureImplementation.KeyWords);
objvFeatureImplementationEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.KeyWords) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.KeyWords, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.KeyWords] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureDescription">功能说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureDescription(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureImplementation.FeatureDescription);
objvFeatureImplementationEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureDescription) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureDescription, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureDescription] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureTypeId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFeatureImplementation.FeatureTypeId);
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFeatureImplementation.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFeatureImplementation.FeatureTypeId);
objvFeatureImplementationEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureTypeId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureTypeId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureTypeId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureTypeName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureImplementation.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureImplementation.FeatureTypeName);
objvFeatureImplementationEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureTypeName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplId">界面实现Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetViewImplId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureImplementation.ViewImplId);
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureImplementation.ViewImplId);
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureImplementation.ViewImplId);
objvFeatureImplementationEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.ViewImplId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.ViewImplId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.ViewImplId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewImplName">界面实现名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetViewImplName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strViewImplName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureImplementation.ViewImplName);
objvFeatureImplementationEN.ViewImplName = strViewImplName; //界面实现名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.ViewImplName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.ViewImplName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.ViewImplName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetUpdDate(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureImplementation.UpdDate);
objvFeatureImplementationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.UpdDate) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.UpdDate, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.UpdDate] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetUpdUser(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureImplementation.UpdUser);
objvFeatureImplementationEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.UpdUser) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.UpdUser, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.UpdUser] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetMemo(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureImplementation.Memo);
objvFeatureImplementationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.Memo) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.Memo, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.Memo] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureImplementationEN objvFeatureImplementationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.mId) == true)
{
string strComparisonOpmId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureImplementation.mId, objvFeatureImplementationCond.mId, strComparisonOpmId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureId, objvFeatureImplementationCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureName, objvFeatureImplementationCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.KeyWords, objvFeatureImplementationCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureDescription, objvFeatureImplementationCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureTypeId, objvFeatureImplementationCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureTypeName, objvFeatureImplementationCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.ViewImplId) == true)
{
string strComparisonOpViewImplId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.ViewImplId, objvFeatureImplementationCond.ViewImplId, strComparisonOpViewImplId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.ViewImplName) == true)
{
string strComparisonOpViewImplName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.ViewImplName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.ViewImplName, objvFeatureImplementationCond.ViewImplName, strComparisonOpViewImplName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.UpdDate, objvFeatureImplementationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.UpdUser, objvFeatureImplementationCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.Memo) == true)
{
string strComparisonOpMemo = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.Memo, objvFeatureImplementationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能实现方式(vFeatureImplementation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureImplementationWApi
{
private static readonly string mstrApiControllerName = "vFeatureImplementationApi";

 public clsvFeatureImplementationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureImplementationEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFeatureImplementationEN objvFeatureImplementationEN;
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
objvFeatureImplementationEN = JsonConvert.DeserializeObject<clsvFeatureImplementationEN>(strJson);
return objvFeatureImplementationEN;
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
public static clsvFeatureImplementationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureImplementationEN objvFeatureImplementationEN;
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
objvFeatureImplementationEN = JsonConvert.DeserializeObject<clsvFeatureImplementationEN>(strJson);
return objvFeatureImplementationEN;
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
public static clsvFeatureImplementationEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrvFeatureImplementationObjLst_Sel =
from objvFeatureImplementationEN in arrvFeatureImplementationObjLstCache
where objvFeatureImplementationEN.mId == lngmId 
select objvFeatureImplementationEN;
if (arrvFeatureImplementationObjLst_Sel.Count() == 0)
{
   clsvFeatureImplementationEN obj = clsvFeatureImplementationWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFeatureImplementationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureImplementationEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
public static List<clsvFeatureImplementationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
public static IEnumerable<clsvFeatureImplementationEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrvFeatureImplementationObjLst_Sel =
from objvFeatureImplementationEN in arrvFeatureImplementationObjLstCache
where arrMId.Contains(objvFeatureImplementationEN.mId)
select objvFeatureImplementationEN;
return arrvFeatureImplementationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureImplementationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
public static List<clsvFeatureImplementationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
public static List<clsvFeatureImplementationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
public static List<clsvFeatureImplementationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureImplementationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureImplementationEN>>(strJson);
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
 /// <param name = "objvFeatureImplementationENS">源对象</param>
 /// <param name = "objvFeatureImplementationENT">目标对象</param>
 public static void CopyTo(clsvFeatureImplementationEN objvFeatureImplementationENS, clsvFeatureImplementationEN objvFeatureImplementationENT)
{
try
{
objvFeatureImplementationENT.mId = objvFeatureImplementationENS.mId; //mId
objvFeatureImplementationENT.FeatureId = objvFeatureImplementationENS.FeatureId; //功能Id
objvFeatureImplementationENT.FeatureName = objvFeatureImplementationENS.FeatureName; //功能名称
objvFeatureImplementationENT.KeyWords = objvFeatureImplementationENS.KeyWords; //关键字
objvFeatureImplementationENT.FeatureDescription = objvFeatureImplementationENS.FeatureDescription; //功能说明
objvFeatureImplementationENT.FeatureTypeId = objvFeatureImplementationENS.FeatureTypeId; //功能类型Id
objvFeatureImplementationENT.FeatureTypeName = objvFeatureImplementationENS.FeatureTypeName; //功能类型名称
objvFeatureImplementationENT.ViewImplId = objvFeatureImplementationENS.ViewImplId; //界面实现Id
objvFeatureImplementationENT.ViewImplName = objvFeatureImplementationENS.ViewImplName; //界面实现名
objvFeatureImplementationENT.UpdDate = objvFeatureImplementationENS.UpdDate; //修改日期
objvFeatureImplementationENT.UpdUser = objvFeatureImplementationENS.UpdUser; //修改者
objvFeatureImplementationENT.Memo = objvFeatureImplementationENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFeatureImplementationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureImplementationEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureImplementationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureImplementationEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureImplementationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureImplementationEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
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
public static List<clsvFeatureImplementationEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFeatureImplementationEN._CurrTabName;
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFeatureImplementationObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureImplementationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureImplementation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFeatureImplementation.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.FeatureDescription, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.ViewImplId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.ViewImplName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureImplementation.Memo, Type.GetType("System.String"));
foreach (clsvFeatureImplementationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureImplementation.mId] = objInFor[convFeatureImplementation.mId];
objDR[convFeatureImplementation.FeatureId] = objInFor[convFeatureImplementation.FeatureId];
objDR[convFeatureImplementation.FeatureName] = objInFor[convFeatureImplementation.FeatureName];
objDR[convFeatureImplementation.KeyWords] = objInFor[convFeatureImplementation.KeyWords];
objDR[convFeatureImplementation.FeatureDescription] = objInFor[convFeatureImplementation.FeatureDescription];
objDR[convFeatureImplementation.FeatureTypeId] = objInFor[convFeatureImplementation.FeatureTypeId];
objDR[convFeatureImplementation.FeatureTypeName] = objInFor[convFeatureImplementation.FeatureTypeName];
objDR[convFeatureImplementation.ViewImplId] = objInFor[convFeatureImplementation.ViewImplId];
objDR[convFeatureImplementation.ViewImplName] = objInFor[convFeatureImplementation.ViewImplName];
objDR[convFeatureImplementation.UpdDate] = objInFor[convFeatureImplementation.UpdDate];
objDR[convFeatureImplementation.UpdUser] = objInFor[convFeatureImplementation.UpdUser];
objDR[convFeatureImplementation.Memo] = objInFor[convFeatureImplementation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}