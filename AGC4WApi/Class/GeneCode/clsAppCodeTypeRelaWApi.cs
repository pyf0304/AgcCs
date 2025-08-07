
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppCodeTypeRelaWApi
 表名:AppCodeTypeRela(00050418)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsAppCodeTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetmId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.mId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.mId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.mId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetApplicationTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conAppCodeTypeRela.ApplicationTypeId);
objAppCodeTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.ApplicationTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetCodeTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
objAppCodeTypeRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.CodeTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.CodeTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.CodeTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewTypeCode">界面类型码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetViewTypeCode(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int intViewTypeCode, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.ViewTypeCode) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.ViewTypeCode, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.ViewTypeCode] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetTabMainTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
objAppCodeTypeRelaEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.TabMainTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.TabMainTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.TabMainTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetIsVisible(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.IsVisible) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.IsVisible, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.IsVisible] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInGroupGeneCode">是否参与组生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetIsInGroupGeneCode(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsInGroupGeneCode, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.IsInGroupGeneCode = bolIsInGroupGeneCode; //是否参与组生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.IsInGroupGeneCode) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.IsInGroupGeneCode, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.IsInGroupGeneCode] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetOrderNum(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conAppCodeTypeRela.OrderNum);
objAppCodeTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.OrderNum) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.OrderNum, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.OrderNum] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetUpdDate(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAppCodeTypeRela.UpdDate);
objAppCodeTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.UpdDate) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.UpdDate, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.UpdDate] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetUpdUser(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAppCodeTypeRela.UpdUser);
objAppCodeTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.UpdUser) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.UpdUser, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.UpdUser] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetMemo(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppCodeTypeRela.Memo);
objAppCodeTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.Memo) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.Memo, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.Memo] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.mId) == true)
{
string strComparisonOpmId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.mId, objAppCodeTypeRelaCond.mId, strComparisonOpmId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.ApplicationTypeId, objAppCodeTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.CodeTypeId, objAppCodeTypeRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.ViewTypeCode, objAppCodeTypeRelaCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.TabMainTypeId, objAppCodeTypeRelaCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.IsVisible) == true)
{
if (objAppCodeTypeRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppCodeTypeRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppCodeTypeRela.IsVisible);
}
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode) == true)
{
if (objAppCodeTypeRelaCond.IsInGroupGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppCodeTypeRela.IsInGroupGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppCodeTypeRela.IsInGroupGeneCode);
}
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.OrderNum, objAppCodeTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.UpdDate, objAppCodeTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.UpdUser, objAppCodeTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.Memo) == true)
{
string strComparisonOpMemo = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.Memo, objAppCodeTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 if (objAppCodeTypeRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objAppCodeTypeRelaEN.sfUpdFldSetStr = objAppCodeTypeRelaEN.getsfUpdFldSetStr();
clsAppCodeTypeRelaWApi.CheckPropertyNew(objAppCodeTypeRelaEN); 
bool bolResult = clsAppCodeTypeRelaWApi.UpdateRecord(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaWApi.ReFreshCache();
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
 /// 获取唯一性条件串--AppCodeTypeRela(应用程序代码类型关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CodeTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAppCodeTypeRelaEN == null) return "";
if (objAppCodeTypeRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppCodeTypeRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
try
{
clsAppCodeTypeRelaWApi.CheckPropertyNew(objAppCodeTypeRelaEN); 
bool bolResult = clsAppCodeTypeRelaWApi.AddNewRecord(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaWApi.ReFreshCache();
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strWhereCond)
{
try
{
clsAppCodeTypeRelaWApi.CheckPropertyNew(objAppCodeTypeRelaEN); 
bool bolResult = clsAppCodeTypeRelaWApi.UpdateWithCondition(objAppCodeTypeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaWApi.ReFreshCache();
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
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsAppCodeTypeRelaWApi
{
private static readonly string mstrApiControllerName = "AppCodeTypeRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsAppCodeTypeRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
if (!Object.Equals(null, objAppCodeTypeRelaEN.CodeTypeId) && GetStrLen(objAppCodeTypeRelaEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objAppCodeTypeRelaEN.TabMainTypeId) && GetStrLen(objAppCodeTypeRelaEN.TabMainTypeId) > 4)
{
 throw new Exception("字段[表主类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objAppCodeTypeRelaEN.UpdDate) && GetStrLen(objAppCodeTypeRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objAppCodeTypeRelaEN.UpdUser) && GetStrLen(objAppCodeTypeRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objAppCodeTypeRelaEN.Memo) && GetStrLen(objAppCodeTypeRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objAppCodeTypeRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN;
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
objAppCodeTypeRelaEN = JsonConvert.DeserializeObject<clsAppCodeTypeRelaEN>(strJson);
return objAppCodeTypeRelaEN;
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
public static clsAppCodeTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN;
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
objAppCodeTypeRelaEN = JsonConvert.DeserializeObject<clsAppCodeTypeRelaEN>(strJson);
return objAppCodeTypeRelaEN;
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
public static clsAppCodeTypeRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel =
from objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjLstCache
where objAppCodeTypeRelaEN.mId == lngmId 
select objAppCodeTypeRelaEN;
if (arrAppCodeTypeRelaObjLst_Sel.Count() == 0)
{
   clsAppCodeTypeRelaEN obj = clsAppCodeTypeRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrAppCodeTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static IEnumerable<clsAppCodeTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel =
from objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjLstCache
where arrMId.Contains(objAppCodeTypeRelaEN.mId)
select objAppCodeTypeRelaEN;
return arrAppCodeTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsAppCodeTypeRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAppCodeTypeRelaEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsAppCodeTypeRelaWApi.ReFreshCache();
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
public static int DelAppCodeTypeRelas(List<string> arrmId)
{
string strAction = "DelAppCodeTypeRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsAppCodeTypeRelaWApi.ReFreshCache();
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
public static int DelAppCodeTypeRelasByCond(string strWhereCond)
{
string strAction = "DelAppCodeTypeRelasByCond";
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
public static bool AddNewRecord(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppCodeTypeRelaEN>(objAppCodeTypeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaWApi.ReFreshCache();
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppCodeTypeRelaEN>(objAppCodeTypeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
if (string.IsNullOrEmpty(objAppCodeTypeRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objAppCodeTypeRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppCodeTypeRelaEN>(objAppCodeTypeRelaEN);
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objAppCodeTypeRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objAppCodeTypeRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objAppCodeTypeRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAppCodeTypeRelaEN>(objAppCodeTypeRelaEN);
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
 /// <param name = "objAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objAppCodeTypeRelaENT">目标对象</param>
 public static void CopyTo(clsAppCodeTypeRelaEN objAppCodeTypeRelaENS, clsAppCodeTypeRelaEN objAppCodeTypeRelaENT)
{
try
{
objAppCodeTypeRelaENT.mId = objAppCodeTypeRelaENS.mId; //mId
objAppCodeTypeRelaENT.ApplicationTypeId = objAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objAppCodeTypeRelaENT.CodeTypeId = objAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objAppCodeTypeRelaENT.ViewTypeCode = objAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objAppCodeTypeRelaENT.TabMainTypeId = objAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objAppCodeTypeRelaENT.IsVisible = objAppCodeTypeRelaENS.IsVisible; //是否显示
objAppCodeTypeRelaENT.IsInGroupGeneCode = objAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objAppCodeTypeRelaENT.OrderNum = objAppCodeTypeRelaENS.OrderNum; //序号
objAppCodeTypeRelaENT.UpdDate = objAppCodeTypeRelaENS.UpdDate; //修改日期
objAppCodeTypeRelaENT.UpdUser = objAppCodeTypeRelaENS.UpdUser; //修改者
objAppCodeTypeRelaENT.Memo = objAppCodeTypeRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsAppCodeTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsAppCodeTypeRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsAppCodeTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsAppCodeTypeRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsAppCodeTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsAppCodeTypeRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
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
if (clsAppCodeTypeRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppCodeTypeRelaWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsAppCodeTypeRelaEN._CurrTabName;
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrAppCodeTypeRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsAppCodeTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conAppCodeTypeRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conAppCodeTypeRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conAppCodeTypeRela.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conAppCodeTypeRela.ViewTypeCode, Type.GetType("System.Int32"));
objDT.Columns.Add(conAppCodeTypeRela.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conAppCodeTypeRela.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAppCodeTypeRela.IsInGroupGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAppCodeTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conAppCodeTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conAppCodeTypeRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conAppCodeTypeRela.Memo, Type.GetType("System.String"));
foreach (clsAppCodeTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conAppCodeTypeRela.mId] = objInFor[conAppCodeTypeRela.mId];
objDR[conAppCodeTypeRela.ApplicationTypeId] = objInFor[conAppCodeTypeRela.ApplicationTypeId];
objDR[conAppCodeTypeRela.CodeTypeId] = objInFor[conAppCodeTypeRela.CodeTypeId];
objDR[conAppCodeTypeRela.ViewTypeCode] = objInFor[conAppCodeTypeRela.ViewTypeCode];
objDR[conAppCodeTypeRela.TabMainTypeId] = objInFor[conAppCodeTypeRela.TabMainTypeId];
objDR[conAppCodeTypeRela.IsVisible] = objInFor[conAppCodeTypeRela.IsVisible];
objDR[conAppCodeTypeRela.IsInGroupGeneCode] = objInFor[conAppCodeTypeRela.IsInGroupGeneCode];
objDR[conAppCodeTypeRela.OrderNum] = objInFor[conAppCodeTypeRela.OrderNum];
objDR[conAppCodeTypeRela.UpdDate] = objInFor[conAppCodeTypeRela.UpdDate];
objDR[conAppCodeTypeRela.UpdUser] = objInFor[conAppCodeTypeRela.UpdUser];
objDR[conAppCodeTypeRela.Memo] = objInFor[conAppCodeTypeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4AppCodeTypeRela : clsCommFun4BL
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
clsAppCodeTypeRelaWApi.ReFreshThisCache();
}
}

}