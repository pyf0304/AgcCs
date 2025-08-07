
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureAppTypeRelaWApi
 表名:vFeatureAppTypeRela(00050431)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFeatureAppTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetmId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureAppTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.mId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.mId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.mId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureAppTypeRela.ApplicationTypeId);
objvFeatureAppTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convFeatureAppTypeRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureAppTypeRela.ApplicationTypeName);
objvFeatureAppTypeRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeENName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convFeatureAppTypeRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convFeatureAppTypeRela.ApplicationTypeENName);
objvFeatureAppTypeRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeENName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureAppTypeRela.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureAppTypeRela.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureAppTypeRela.FeatureId);
objvFeatureAppTypeRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureAppTypeRela.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureAppTypeRela.FeatureName);
objvFeatureAppTypeRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureTypeName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureAppTypeRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureAppTypeRela.FeatureTypeName);
objvFeatureAppTypeRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureTypeName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetOrderNum(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFeatureAppTypeRela.OrderNum);
objvFeatureAppTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.OrderNum) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetInUse(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, bool bolInUse, string strComparisonOp="")
	{
objvFeatureAppTypeRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.InUse) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.InUse, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.InUse] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetUpdDate(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureAppTypeRela.UpdDate);
objvFeatureAppTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.UpdDate) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetUpdUser(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureAppTypeRela.UpdUser);
objvFeatureAppTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.UpdUser) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetMemo(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureAppTypeRela.Memo);
objvFeatureAppTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.Memo) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.Memo, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.Memo] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.mId) == true)
{
string strComparisonOpmId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.mId, objvFeatureAppTypeRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.ApplicationTypeId, objvFeatureAppTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.ApplicationTypeName, objvFeatureAppTypeRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.ApplicationTypeENName, objvFeatureAppTypeRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureId, objvFeatureAppTypeRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureName, objvFeatureAppTypeRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureTypeName, objvFeatureAppTypeRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.OrderNum, objvFeatureAppTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.InUse) == true)
{
if (objvFeatureAppTypeRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFeatureAppTypeRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFeatureAppTypeRela.InUse);
}
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.UpdDate, objvFeatureAppTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.UpdUser, objvFeatureAppTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.Memo, objvFeatureAppTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能应用关系(vFeatureAppTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureAppTypeRelaWApi
{
private static readonly string mstrApiControllerName = "vFeatureAppTypeRelaApi";

 public clsvFeatureAppTypeRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureAppTypeRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN;
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
objvFeatureAppTypeRelaEN = JsonConvert.DeserializeObject<clsvFeatureAppTypeRelaEN>(strJson);
return objvFeatureAppTypeRelaEN;
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
public static clsvFeatureAppTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN;
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
objvFeatureAppTypeRelaEN = JsonConvert.DeserializeObject<clsvFeatureAppTypeRelaEN>(strJson);
return objvFeatureAppTypeRelaEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureAppTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureAppTypeRelaEN>>(strJson);
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
 /// <param name = "objvFeatureAppTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureAppTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENS, clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENT)
{
try
{
objvFeatureAppTypeRelaENT.mId = objvFeatureAppTypeRelaENS.mId; //mId
objvFeatureAppTypeRelaENT.ApplicationTypeId = objvFeatureAppTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureAppTypeRelaENT.ApplicationTypeName = objvFeatureAppTypeRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureAppTypeRelaENT.ApplicationTypeENName = objvFeatureAppTypeRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureAppTypeRelaENT.FeatureId = objvFeatureAppTypeRelaENS.FeatureId; //功能Id
objvFeatureAppTypeRelaENT.FeatureName = objvFeatureAppTypeRelaENS.FeatureName; //功能名称
objvFeatureAppTypeRelaENT.FeatureTypeName = objvFeatureAppTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureAppTypeRelaENT.OrderNum = objvFeatureAppTypeRelaENS.OrderNum; //序号
objvFeatureAppTypeRelaENT.InUse = objvFeatureAppTypeRelaENS.InUse; //是否在用
objvFeatureAppTypeRelaENT.UpdDate = objvFeatureAppTypeRelaENS.UpdDate; //修改日期
objvFeatureAppTypeRelaENT.UpdUser = objvFeatureAppTypeRelaENS.UpdUser; //修改者
objvFeatureAppTypeRelaENT.Memo = objvFeatureAppTypeRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFeatureAppTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureAppTypeRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureAppTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureAppTypeRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureAppTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureAppTypeRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureAppTypeRelaEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureAppTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureAppTypeRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFeatureAppTypeRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureAppTypeRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureAppTypeRela.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFeatureAppTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureAppTypeRela.Memo, Type.GetType("System.String"));
foreach (clsvFeatureAppTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureAppTypeRela.mId] = objInFor[convFeatureAppTypeRela.mId];
objDR[convFeatureAppTypeRela.ApplicationTypeId] = objInFor[convFeatureAppTypeRela.ApplicationTypeId];
objDR[convFeatureAppTypeRela.ApplicationTypeName] = objInFor[convFeatureAppTypeRela.ApplicationTypeName];
objDR[convFeatureAppTypeRela.ApplicationTypeENName] = objInFor[convFeatureAppTypeRela.ApplicationTypeENName];
objDR[convFeatureAppTypeRela.FeatureId] = objInFor[convFeatureAppTypeRela.FeatureId];
objDR[convFeatureAppTypeRela.FeatureName] = objInFor[convFeatureAppTypeRela.FeatureName];
objDR[convFeatureAppTypeRela.FeatureTypeName] = objInFor[convFeatureAppTypeRela.FeatureTypeName];
objDR[convFeatureAppTypeRela.OrderNum] = objInFor[convFeatureAppTypeRela.OrderNum];
objDR[convFeatureAppTypeRela.InUse] = objInFor[convFeatureAppTypeRela.InUse];
objDR[convFeatureAppTypeRela.UpdDate] = objInFor[convFeatureAppTypeRela.UpdDate];
objDR[convFeatureAppTypeRela.UpdUser] = objInFor[convFeatureAppTypeRela.UpdUser];
objDR[convFeatureAppTypeRela.Memo] = objInFor[convFeatureAppTypeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}