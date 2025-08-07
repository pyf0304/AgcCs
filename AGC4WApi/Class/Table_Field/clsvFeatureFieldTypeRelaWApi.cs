
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFieldTypeRelaWApi
 表名:vFeatureFieldTypeRela(00050458)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:51:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvFeatureFieldTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetmId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureFieldTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.mId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.mId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.mId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureFieldTypeRela.FeatureId);
objvFeatureFieldTypeRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureFieldTypeRela.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureFieldTypeRela.FeatureName);
objvFeatureFieldTypeRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetKeyWords(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureFieldTypeRela.KeyWords);
objvFeatureFieldTypeRelaEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.KeyWords) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.KeyWords, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.KeyWords] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureTypeName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureFieldTypeRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureFieldTypeRela.FeatureTypeName);
objvFeatureFieldTypeRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureTypeName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureFieldTypeRela.FieldTypeId);
objvFeatureFieldTypeRelaEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureFieldTypeRela.FieldTypeName);
objvFeatureFieldTypeRelaEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeENName">字段类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeENName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeENName, 30, convFeatureFieldTypeRela.FieldTypeENName);
objvFeatureFieldTypeRelaEN.FieldTypeENName = strFieldTypeENName; //字段类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeENName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeENName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeENName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetOrderNum(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvFeatureFieldTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.OrderNum) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetUpdDate(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureFieldTypeRela.UpdDate);
objvFeatureFieldTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.UpdDate) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetUpdUser(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureFieldTypeRela.UpdUser);
objvFeatureFieldTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.UpdUser) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetMemo(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureFieldTypeRela.Memo);
objvFeatureFieldTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.Memo) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.Memo, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.Memo] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.mId) == true)
{
string strComparisonOpmId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFieldTypeRela.mId, objvFeatureFieldTypeRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureId, objvFeatureFieldTypeRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureName, objvFeatureFieldTypeRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.KeyWords, objvFeatureFieldTypeRelaCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureTypeName, objvFeatureFieldTypeRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeId, objvFeatureFieldTypeRelaCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeName, objvFeatureFieldTypeRelaCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeENName) == true)
{
string strComparisonOpFieldTypeENName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeENName, objvFeatureFieldTypeRelaCond.FieldTypeENName, strComparisonOpFieldTypeENName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFieldTypeRela.OrderNum, objvFeatureFieldTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.UpdDate, objvFeatureFieldTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.UpdUser, objvFeatureFieldTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.Memo, objvFeatureFieldTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能字段类型关系(vFeatureFieldTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFieldTypeRelaWApi
{
private static readonly string mstrApiControllerName = "vFeatureFieldTypeRelaApi";

 public clsvFeatureFieldTypeRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFieldTypeRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN;
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
objvFeatureFieldTypeRelaEN = JsonConvert.DeserializeObject<clsvFeatureFieldTypeRelaEN>(strJson);
return objvFeatureFieldTypeRelaEN;
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
public static clsvFeatureFieldTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN;
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
objvFeatureFieldTypeRelaEN = JsonConvert.DeserializeObject<clsvFeatureFieldTypeRelaEN>(strJson);
return objvFeatureFieldTypeRelaEN;
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
public static clsvFeatureFieldTypeRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLst_Sel =
from objvFeatureFieldTypeRelaEN in arrvFeatureFieldTypeRelaObjLstCache
where objvFeatureFieldTypeRelaEN.mId == lngmId 
select objvFeatureFieldTypeRelaEN;
if (arrvFeatureFieldTypeRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureFieldTypeRelaEN obj = clsvFeatureFieldTypeRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFeatureFieldTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
public static IEnumerable<clsvFeatureFieldTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLst_Sel =
from objvFeatureFieldTypeRelaEN in arrvFeatureFieldTypeRelaObjLstCache
where arrMId.Contains(objvFeatureFieldTypeRelaEN.mId)
select objvFeatureFieldTypeRelaEN;
return arrvFeatureFieldTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureFieldTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFieldTypeRelaEN>>(strJson);
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
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureFieldTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENS, clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENT)
{
try
{
objvFeatureFieldTypeRelaENT.mId = objvFeatureFieldTypeRelaENS.mId; //mId
objvFeatureFieldTypeRelaENT.FeatureId = objvFeatureFieldTypeRelaENS.FeatureId; //功能Id
objvFeatureFieldTypeRelaENT.FeatureName = objvFeatureFieldTypeRelaENS.FeatureName; //功能名称
objvFeatureFieldTypeRelaENT.KeyWords = objvFeatureFieldTypeRelaENS.KeyWords; //关键字
objvFeatureFieldTypeRelaENT.FeatureTypeName = objvFeatureFieldTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureFieldTypeRelaENT.FieldTypeId = objvFeatureFieldTypeRelaENS.FieldTypeId; //字段类型Id
objvFeatureFieldTypeRelaENT.FieldTypeName = objvFeatureFieldTypeRelaENS.FieldTypeName; //字段类型名
objvFeatureFieldTypeRelaENT.FieldTypeENName = objvFeatureFieldTypeRelaENS.FieldTypeENName; //字段类型英文名
objvFeatureFieldTypeRelaENT.OrderNum = objvFeatureFieldTypeRelaENS.OrderNum; //序号
objvFeatureFieldTypeRelaENT.UpdDate = objvFeatureFieldTypeRelaENS.UpdDate; //修改日期
objvFeatureFieldTypeRelaENT.UpdUser = objvFeatureFieldTypeRelaENS.UpdUser; //修改者
objvFeatureFieldTypeRelaENT.Memo = objvFeatureFieldTypeRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFeatureFieldTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureFieldTypeRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureFieldTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureFieldTypeRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureFieldTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureFieldTypeRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFeatureFieldTypeRelaEN._CurrTabName;
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFeatureFieldTypeRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFeatureFieldTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureFieldTypeRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFeatureFieldTypeRela.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.FieldTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureFieldTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFieldTypeRela.Memo, Type.GetType("System.String"));
foreach (clsvFeatureFieldTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureFieldTypeRela.mId] = objInFor[convFeatureFieldTypeRela.mId];
objDR[convFeatureFieldTypeRela.FeatureId] = objInFor[convFeatureFieldTypeRela.FeatureId];
objDR[convFeatureFieldTypeRela.FeatureName] = objInFor[convFeatureFieldTypeRela.FeatureName];
objDR[convFeatureFieldTypeRela.KeyWords] = objInFor[convFeatureFieldTypeRela.KeyWords];
objDR[convFeatureFieldTypeRela.FeatureTypeName] = objInFor[convFeatureFieldTypeRela.FeatureTypeName];
objDR[convFeatureFieldTypeRela.FieldTypeId] = objInFor[convFeatureFieldTypeRela.FieldTypeId];
objDR[convFeatureFieldTypeRela.FieldTypeName] = objInFor[convFeatureFieldTypeRela.FieldTypeName];
objDR[convFeatureFieldTypeRela.FieldTypeENName] = objInFor[convFeatureFieldTypeRela.FieldTypeENName];
objDR[convFeatureFieldTypeRela.OrderNum] = objInFor[convFeatureFieldTypeRela.OrderNum];
objDR[convFeatureFieldTypeRela.UpdDate] = objInFor[convFeatureFieldTypeRela.UpdDate];
objDR[convFeatureFieldTypeRela.UpdUser] = objInFor[convFeatureFieldTypeRela.UpdUser];
objDR[convFeatureFieldTypeRela.Memo] = objInFor[convFeatureFieldTypeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}