
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabRelationWApi
 表名:TabRelation(00050086)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:40
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
public static class  clsTabRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelationId">RelationId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetRelationId(this clsTabRelationEN objTabRelationEN, string strRelationId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelationId, 8, conTabRelation.RelationId);
objTabRelationEN.RelationId = strRelationId; //RelationId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.RelationId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.RelationId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.RelationId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelationName">关系名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetRelationName(this clsTabRelationEN objTabRelationEN, string strRelationName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationName, conTabRelation.RelationName);
clsCheckSql.CheckFieldLen(strRelationName, 40, conTabRelation.RelationName);
objTabRelationEN.RelationName = strRelationName; //关系名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.RelationName) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.RelationName, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.RelationName] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabRelationTypeId">表关系类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetTabRelationTypeId(this clsTabRelationEN objTabRelationEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
objTabRelationEN.TabRelationTypeId = strTabRelationTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.TabRelationTypeId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.TabRelationTypeId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.TabRelationTypeId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyTabId">PrimaryKeyTabId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetPrimaryKeyTabId(this clsTabRelationEN objTabRelationEN, string strPrimaryKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryKeyTabId, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(strPrimaryKeyTabId, 8, conTabRelation.PrimaryKeyTabId);
objTabRelationEN.PrimaryKeyTabId = strPrimaryKeyTabId; //PrimaryKeyTabId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.PrimaryKeyTabId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.PrimaryKeyTabId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.PrimaryKeyTabId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyFldId">PrimaryKeyFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetPrimaryKeyFldId(this clsTabRelationEN objTabRelationEN, string strPrimaryKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryKeyFldId, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckFieldLen(strPrimaryKeyFldId, 8, conTabRelation.PrimaryKeyFldId);
objTabRelationEN.PrimaryKeyFldId = strPrimaryKeyFldId; //PrimaryKeyFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.PrimaryKeyFldId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.PrimaryKeyFldId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.PrimaryKeyFldId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyTabId">外键表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetForeignKeyTabId(this clsTabRelationEN objTabRelationEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
objTabRelationEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.ForeignKeyTabId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.ForeignKeyTabId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.ForeignKeyTabId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyFldId">外键字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetForeignKeyFldId(this clsTabRelationEN objTabRelationEN, string strForeignKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strForeignKeyFldId, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(strForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
objTabRelationEN.ForeignKeyFldId = strForeignKeyFldId; //外键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.ForeignKeyFldId) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.ForeignKeyFldId, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.ForeignKeyFldId] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCheckCurrData">是否检查当前数据</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsCheckCurrData(this clsTabRelationEN objTabRelationEN, bool bolIsCheckCurrData, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCheckCurrData, conTabRelation.IsCheckCurrData);
objTabRelationEN.IsCheckCurrData = bolIsCheckCurrData; //是否检查当前数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsCheckCurrData) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsCheckCurrData, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsCheckCurrData] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCopyForceRela">IsCopyForceRela</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsCopyForceRela(this clsTabRelationEN objTabRelationEN, bool bolIsCopyForceRela, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCopyForceRela, conTabRelation.IsCopyForceRela);
objTabRelationEN.IsCopyForceRela = bolIsCopyForceRela; //IsCopyForceRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsCopyForceRela) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsCopyForceRela, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsCopyForceRela] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUpdRelateFld">是否修改关系字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsUpdRelateFld(this clsTabRelationEN objTabRelationEN, bool bolIsUpdRelateFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdRelateFld, conTabRelation.IsUpdRelateFld);
objTabRelationEN.IsUpdRelateFld = bolIsUpdRelateFld; //是否修改关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsUpdRelateFld) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsUpdRelateFld, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsUpdRelateFld] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDelRelateRec">是否删除相关记录</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetIsDelRelateRec(this clsTabRelationEN objTabRelationEN, bool bolIsDelRelateRec, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDelRelateRec, conTabRelation.IsDelRelateRec);
objTabRelationEN.IsDelRelateRec = bolIsDelRelateRec; //是否删除相关记录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.IsDelRelateRec) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.IsDelRelateRec, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.IsDelRelateRec] = strComparisonOp;
}
}
return objTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabRelationEN SetMemo(this clsTabRelationEN objTabRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabRelation.Memo);
objTabRelationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabRelationEN.dicFldComparisonOp.ContainsKey(conTabRelation.Memo) == false)
{
objTabRelationEN.dicFldComparisonOp.Add(conTabRelation.Memo, strComparisonOp);
}
else
{
objTabRelationEN.dicFldComparisonOp[conTabRelation.Memo] = strComparisonOp;
}
}
return objTabRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabRelationEN objTabRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabRelationCond.IsUpdated(conTabRelation.RelationId) == true)
{
string strComparisonOpRelationId = objTabRelationCond.dicFldComparisonOp[conTabRelation.RelationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.RelationId, objTabRelationCond.RelationId, strComparisonOpRelationId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.RelationName) == true)
{
string strComparisonOpRelationName = objTabRelationCond.dicFldComparisonOp[conTabRelation.RelationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.RelationName, objTabRelationCond.RelationName, strComparisonOpRelationName);
}
if (objTabRelationCond.IsUpdated(conTabRelation.TabRelationTypeId) == true)
{
string strComparisonOpTabRelationTypeId = objTabRelationCond.dicFldComparisonOp[conTabRelation.TabRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.TabRelationTypeId, objTabRelationCond.TabRelationTypeId, strComparisonOpTabRelationTypeId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.PrimaryKeyTabId) == true)
{
string strComparisonOpPrimaryKeyTabId = objTabRelationCond.dicFldComparisonOp[conTabRelation.PrimaryKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.PrimaryKeyTabId, objTabRelationCond.PrimaryKeyTabId, strComparisonOpPrimaryKeyTabId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.PrimaryKeyFldId) == true)
{
string strComparisonOpPrimaryKeyFldId = objTabRelationCond.dicFldComparisonOp[conTabRelation.PrimaryKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.PrimaryKeyFldId, objTabRelationCond.PrimaryKeyFldId, strComparisonOpPrimaryKeyFldId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objTabRelationCond.dicFldComparisonOp[conTabRelation.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.ForeignKeyTabId, objTabRelationCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.ForeignKeyFldId) == true)
{
string strComparisonOpForeignKeyFldId = objTabRelationCond.dicFldComparisonOp[conTabRelation.ForeignKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.ForeignKeyFldId, objTabRelationCond.ForeignKeyFldId, strComparisonOpForeignKeyFldId);
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsCheckCurrData) == true)
{
if (objTabRelationCond.IsCheckCurrData == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsCheckCurrData);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsCheckCurrData);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsCopyForceRela) == true)
{
if (objTabRelationCond.IsCopyForceRela == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsCopyForceRela);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsCopyForceRela);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsUpdRelateFld) == true)
{
if (objTabRelationCond.IsUpdRelateFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsUpdRelateFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsUpdRelateFld);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.IsDelRelateRec) == true)
{
if (objTabRelationCond.IsDelRelateRec == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabRelation.IsDelRelateRec);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabRelation.IsDelRelateRec);
}
}
if (objTabRelationCond.IsUpdated(conTabRelation.Memo) == true)
{
string strComparisonOpMemo = objTabRelationCond.dicFldComparisonOp[conTabRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabRelation.Memo, objTabRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabRelationEN objTabRelationEN)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabRelationEN.sfUpdFldSetStr = objTabRelationEN.getsfUpdFldSetStr();
clsTabRelationWApi.CheckPropertyNew(objTabRelationEN); 
bool bolResult = clsTabRelationWApi.UpdateRecord(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabRelationEN objTabRelationEN)
{
 if (string.IsNullOrEmpty(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTabRelationWApi.IsExist(objTabRelationEN.RelationId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTabRelationEN.RelationId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTabRelationWApi.CheckPropertyNew(objTabRelationEN); 
bool bolResult = clsTabRelationWApi.AddNewRecord(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTabRelationEN objTabRelationEN)
{
try
{
clsTabRelationWApi.CheckPropertyNew(objTabRelationEN); 
string strRelationId = clsTabRelationWApi.AddNewRecordWithMaxId(objTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
return strRelationId;
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabRelationEN objTabRelationEN, string strWhereCond)
{
try
{
clsTabRelationWApi.CheckPropertyNew(objTabRelationEN); 
bool bolResult = clsTabRelationWApi.UpdateWithCondition(objTabRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
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
 /// TabRelation(TabRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabRelationWApi
{
private static readonly string mstrApiControllerName = "TabRelationApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsTabRelationWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabRelationEN objTabRelationEN)
{
if (!Object.Equals(null, objTabRelationEN.RelationId) && GetStrLen(objTabRelationEN.RelationId) > 8)
{
 throw new Exception("字段[RelationId]的长度不能超过8!");
}
if (!Object.Equals(null, objTabRelationEN.RelationName) && GetStrLen(objTabRelationEN.RelationName) > 40)
{
 throw new Exception("字段[关系名]的长度不能超过40!");
}
if (!Object.Equals(null, objTabRelationEN.TabRelationTypeId) && GetStrLen(objTabRelationEN.TabRelationTypeId) > 2)
{
 throw new Exception("字段[表关系类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabRelationEN.PrimaryKeyTabId) && GetStrLen(objTabRelationEN.PrimaryKeyTabId) > 8)
{
 throw new Exception("字段[PrimaryKeyTabId]的长度不能超过8!");
}
if (!Object.Equals(null, objTabRelationEN.PrimaryKeyFldId) && GetStrLen(objTabRelationEN.PrimaryKeyFldId) > 8)
{
 throw new Exception("字段[PrimaryKeyFldId]的长度不能超过8!");
}
if (!Object.Equals(null, objTabRelationEN.ForeignKeyTabId) && GetStrLen(objTabRelationEN.ForeignKeyTabId) > 8)
{
 throw new Exception("字段[外键表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objTabRelationEN.ForeignKeyFldId) && GetStrLen(objTabRelationEN.ForeignKeyFldId) > 8)
{
 throw new Exception("字段[外键字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabRelationEN.Memo) && GetStrLen(objTabRelationEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTabRelationEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabRelationEN GetObjByRelationId(string strRelationId)
{
if (strRelationId == "") return null;
string strAction = "GetObjByRelationId";
clsTabRelationEN objTabRelationEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelationId"] = strRelationId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objTabRelationEN = JsonConvert.DeserializeObject<clsTabRelationEN>(strJson);
return objTabRelationEN;
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
public static clsTabRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabRelationEN objTabRelationEN;
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
objTabRelationEN = JsonConvert.DeserializeObject<clsTabRelationEN>(strJson);
return objTabRelationEN;
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
 /// <param name = "strRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabRelationEN GetObjByRelationIdCache(string strRelationId)
{
if (string.IsNullOrEmpty(strRelationId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
List<clsTabRelationEN> arrTabRelationObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrTabRelationObjLst_Sel =
from objTabRelationEN in arrTabRelationObjLstCache
where objTabRelationEN.RelationId == strRelationId 
select objTabRelationEN;
if (arrTabRelationObjLst_Sel.Count() == 0)
{
   clsTabRelationEN obj = clsTabRelationWApi.GetObjByRelationId(strRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetObjLst(string strWhereCond)
{
 List<clsTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
 /// <param name = "arrRelationId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetObjLstByRelationIdLst(List<string> arrRelationId)
{
 List<clsTabRelationEN> arrObjLst; 
string strAction = "GetObjLstByRelationIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
 /// <param name = "arrRelationId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsTabRelationEN> GetObjLstByRelationIdLstCache(List<string> arrRelationId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
List<clsTabRelationEN> arrTabRelationObjLstCache = GetObjLstCache();
IEnumerable <clsTabRelationEN> arrTabRelationObjLst_Sel =
from objTabRelationEN in arrTabRelationObjLstCache
where arrRelationId.Contains(objTabRelationEN.RelationId)
select objTabRelationEN;
return arrTabRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
public static List<clsTabRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
public static List<clsTabRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
public static List<clsTabRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabRelationEN>>(strJson);
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
public static int DelRecord(string strRelationId)
{
string strAction = "DelRecord";
try
{
 clsTabRelationEN objTabRelationEN = clsTabRelationWApi.GetObjByRelationId(strRelationId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRelationId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabRelationWApi.ReFreshCache();
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
public static int DelTabRelations(List<string> arrRelationId)
{
string strAction = "DelTabRelations";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabRelationWApi.ReFreshCache();
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
public static int DelTabRelationsByCond(string strWhereCond)
{
string strAction = "DelTabRelationsByCond";
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
public static bool AddNewRecord(clsTabRelationEN objTabRelationEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabRelationEN>(objTabRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsTabRelationEN objTabRelationEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabRelationEN>(objTabRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabRelationWApi.ReFreshCache();
var strRelationId = (string)jobjReturn0["returnStr"];
return strRelationId;
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
public static bool UpdateRecord(clsTabRelationEN objTabRelationEN)
{
if (string.IsNullOrEmpty(objTabRelationEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabRelationEN.RelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabRelationEN>(objTabRelationEN);
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabRelationEN objTabRelationEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabRelationEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabRelationEN.RelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabRelationEN.RelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabRelationEN>(objTabRelationEN);
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
public static bool IsExist(string strRelationId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRelationId"] = strRelationId
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
 /// <param name = "objTabRelationENS">源对象</param>
 /// <param name = "objTabRelationENT">目标对象</param>
 public static void CopyTo(clsTabRelationEN objTabRelationENS, clsTabRelationEN objTabRelationENT)
{
try
{
objTabRelationENT.RelationId = objTabRelationENS.RelationId; //RelationId
objTabRelationENT.RelationName = objTabRelationENS.RelationName; //关系名
objTabRelationENT.TabRelationTypeId = objTabRelationENS.TabRelationTypeId; //表关系类型Id
objTabRelationENT.PrimaryKeyTabId = objTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objTabRelationENT.PrimaryKeyFldId = objTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
objTabRelationENT.ForeignKeyTabId = objTabRelationENS.ForeignKeyTabId; //外键表ID
objTabRelationENT.ForeignKeyFldId = objTabRelationENS.ForeignKeyFldId; //外键字段Id
objTabRelationENT.IsCheckCurrData = objTabRelationENS.IsCheckCurrData; //是否检查当前数据
objTabRelationENT.IsCopyForceRela = objTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objTabRelationENT.IsUpdRelateFld = objTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objTabRelationENT.IsDelRelateRec = objTabRelationENS.IsDelRelateRec; //是否删除相关记录
objTabRelationENT.Memo = objTabRelationENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTabRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabRelationEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabRelationEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabRelationEN._AttributeName)
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
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
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
if (clsTabRelationWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabRelationWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabRelationEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsTabRelationEN._CurrTabName;
List<clsTabRelationEN> arrTabRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabRelationObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabRelation.RelationId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.RelationName, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.TabRelationTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.PrimaryKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.PrimaryKeyFldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.ForeignKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.ForeignKeyFldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabRelation.IsCheckCurrData, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabRelation.IsCopyForceRela, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabRelation.IsUpdRelateFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabRelation.IsDelRelateRec, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabRelation.Memo, Type.GetType("System.String"));
foreach (clsTabRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabRelation.RelationId] = objInFor[conTabRelation.RelationId];
objDR[conTabRelation.RelationName] = objInFor[conTabRelation.RelationName];
objDR[conTabRelation.TabRelationTypeId] = objInFor[conTabRelation.TabRelationTypeId];
objDR[conTabRelation.PrimaryKeyTabId] = objInFor[conTabRelation.PrimaryKeyTabId];
objDR[conTabRelation.PrimaryKeyFldId] = objInFor[conTabRelation.PrimaryKeyFldId];
objDR[conTabRelation.ForeignKeyTabId] = objInFor[conTabRelation.ForeignKeyTabId];
objDR[conTabRelation.ForeignKeyFldId] = objInFor[conTabRelation.ForeignKeyFldId];
objDR[conTabRelation.IsCheckCurrData] = objInFor[conTabRelation.IsCheckCurrData];
objDR[conTabRelation.IsCopyForceRela] = objInFor[conTabRelation.IsCopyForceRela];
objDR[conTabRelation.IsUpdRelateFld] = objInFor[conTabRelation.IsUpdRelateFld];
objDR[conTabRelation.IsDelRelateRec] = objInFor[conTabRelation.IsDelRelateRec];
objDR[conTabRelation.Memo] = objInFor[conTabRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// TabRelation(TabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabRelation : clsCommFun4BL
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
clsTabRelationWApi.ReFreshThisCache();
}
}

}