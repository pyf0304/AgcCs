
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateStyleWApi
 表名:css_TemplateStyle(00050470)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
public static class  clscss_TemplateStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetmId(this clscss_TemplateStyleEN objcss_TemplateStyleEN, long lngmId, string strComparisonOp="")
	{
objcss_TemplateStyleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.mId) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.mId, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.mId] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleId">样式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetStyleId(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleId, 8, concss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, concss_TemplateStyle.StyleId);
objcss_TemplateStyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.StyleId) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.StyleId, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.StyleId] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateId">模板ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetTemplateId(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateId, 8, concss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldForeignKey(strTemplateId, 8, concss_TemplateStyle.TemplateId);
objcss_TemplateStyleEN.TemplateId = strTemplateId; //模板ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.TemplateId) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.TemplateId, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.TemplateId] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strcssModuleAreaId">区域主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetcssModuleAreaId(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strcssModuleAreaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcssModuleAreaId, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(strcssModuleAreaId, 8, concss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldForeignKey(strcssModuleAreaId, 8, concss_TemplateStyle.cssModuleAreaId);
objcss_TemplateStyleEN.cssModuleAreaId = strcssModuleAreaId; //区域主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.cssModuleAreaId) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.cssModuleAreaId, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.cssModuleAreaId] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateStyleName">模板样式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetTemplateStyleName(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strTemplateStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateStyleName, 50, concss_TemplateStyle.TemplateStyleName);
objcss_TemplateStyleEN.TemplateStyleName = strTemplateStyleName; //模板样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.TemplateStyleName) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.TemplateStyleName, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.TemplateStyleName] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetUpdDate(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_TemplateStyle.UpdDate);
objcss_TemplateStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.UpdDate) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.UpdDate, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.UpdDate] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetUpdUser(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_TemplateStyle.UpdUser);
objcss_TemplateStyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.UpdUser) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.UpdUser, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.UpdUser] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetMemo(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_TemplateStyle.Memo);
objcss_TemplateStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.Memo) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.Memo, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.Memo] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateStyleNameEn">模板样式英文</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetTemplateStyleNameEn(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strTemplateStyleNameEn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateStyleNameEn, 200, concss_TemplateStyle.TemplateStyleNameEn);
objcss_TemplateStyleEN.TemplateStyleNameEn = strTemplateStyleNameEn; //模板样式英文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.TemplateStyleNameEn) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.TemplateStyleNameEn, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.TemplateStyleNameEn] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDelete">IsDelete</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateStyleEN SetIsDelete(this clscss_TemplateStyleEN objcss_TemplateStyleEN, bool bolIsDelete, string strComparisonOp="")
	{
objcss_TemplateStyleEN.IsDelete = bolIsDelete; //IsDelete
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(concss_TemplateStyle.IsDelete) == false)
{
objcss_TemplateStyleEN.dicFldComparisonOp.Add(concss_TemplateStyle.IsDelete, strComparisonOp);
}
else
{
objcss_TemplateStyleEN.dicFldComparisonOp[concss_TemplateStyle.IsDelete] = strComparisonOp;
}
}
return objcss_TemplateStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_TemplateStyleEN objcss_TemplateStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.mId) == true)
{
string strComparisonOpmId = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concss_TemplateStyle.mId, objcss_TemplateStyleCond.mId, strComparisonOpmId);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.StyleId) == true)
{
string strComparisonOpStyleId = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.StyleId, objcss_TemplateStyleCond.StyleId, strComparisonOpStyleId);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.TemplateId) == true)
{
string strComparisonOpTemplateId = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.TemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.TemplateId, objcss_TemplateStyleCond.TemplateId, strComparisonOpTemplateId);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.cssModuleAreaId) == true)
{
string strComparisonOpcssModuleAreaId = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.cssModuleAreaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.cssModuleAreaId, objcss_TemplateStyleCond.cssModuleAreaId, strComparisonOpcssModuleAreaId);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.TemplateStyleName) == true)
{
string strComparisonOpTemplateStyleName = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.TemplateStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.TemplateStyleName, objcss_TemplateStyleCond.TemplateStyleName, strComparisonOpTemplateStyleName);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.UpdDate, objcss_TemplateStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.UpdUser, objcss_TemplateStyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.Memo) == true)
{
string strComparisonOpMemo = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.Memo, objcss_TemplateStyleCond.Memo, strComparisonOpMemo);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.TemplateStyleNameEn) == true)
{
string strComparisonOpTemplateStyleNameEn = objcss_TemplateStyleCond.dicFldComparisonOp[concss_TemplateStyle.TemplateStyleNameEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_TemplateStyle.TemplateStyleNameEn, objcss_TemplateStyleCond.TemplateStyleNameEn, strComparisonOpTemplateStyleNameEn);
}
if (objcss_TemplateStyleCond.IsUpdated(concss_TemplateStyle.IsDelete) == true)
{
if (objcss_TemplateStyleCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_TemplateStyle.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_TemplateStyle.IsDelete);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
 if (objcss_TemplateStyleEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcss_TemplateStyleEN.sfUpdFldSetStr = objcss_TemplateStyleEN.getsfUpdFldSetStr();
clscss_TemplateStyleWApi.CheckPropertyNew(objcss_TemplateStyleEN); 
bool bolResult = clscss_TemplateStyleWApi.UpdateRecord(objcss_TemplateStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--css_TemplateStyle(css_TemplateStyle), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TemplateStyleName_TemplateId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcss_TemplateStyleEN == null) return "";
if (objcss_TemplateStyleEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TemplateStyleName = '{0}'", objcss_TemplateStyleEN.TemplateStyleName);
 sbCondition.AppendFormat(" and TemplateId = '{0}'", objcss_TemplateStyleEN.TemplateId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcss_TemplateStyleEN.mId);
 sbCondition.AppendFormat(" and TemplateStyleName = '{0}'", objcss_TemplateStyleEN.TemplateStyleName);
 sbCondition.AppendFormat(" and TemplateId = '{0}'", objcss_TemplateStyleEN.TemplateId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_TemplateStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
try
{
clscss_TemplateStyleWApi.CheckPropertyNew(objcss_TemplateStyleEN); 
bool bolResult = clscss_TemplateStyleWApi.AddNewRecord(objcss_TemplateStyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objcss_TemplateStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_TemplateStyleEN objcss_TemplateStyleEN, string strWhereCond)
{
try
{
clscss_TemplateStyleWApi.CheckPropertyNew(objcss_TemplateStyleEN); 
bool bolResult = clscss_TemplateStyleWApi.UpdateWithCondition(objcss_TemplateStyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// css_TemplateStyle(css_TemplateStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscss_TemplateStyleWApi
{
private static readonly string mstrApiControllerName = "css_TemplateStyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clscss_TemplateStyleWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
if (!Object.Equals(null, objcss_TemplateStyleEN.StyleId) && GetStrLen(objcss_TemplateStyleEN.StyleId) > 8)
{
 throw new Exception("字段[样式ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.TemplateId) && GetStrLen(objcss_TemplateStyleEN.TemplateId) > 8)
{
 throw new Exception("字段[模板ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.cssModuleAreaId) && GetStrLen(objcss_TemplateStyleEN.cssModuleAreaId) > 8)
{
 throw new Exception("字段[区域主键]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.TemplateStyleName) && GetStrLen(objcss_TemplateStyleEN.TemplateStyleName) > 50)
{
 throw new Exception("字段[模板样式名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.UpdDate) && GetStrLen(objcss_TemplateStyleEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.UpdUser) && GetStrLen(objcss_TemplateStyleEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.Memo) && GetStrLen(objcss_TemplateStyleEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_TemplateStyleEN.TemplateStyleNameEn) && GetStrLen(objcss_TemplateStyleEN.TemplateStyleNameEn) > 200)
{
 throw new Exception("字段[模板样式英文]的长度不能超过200!");
}
 objcss_TemplateStyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_TemplateStyleEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clscss_TemplateStyleEN objcss_TemplateStyleEN;
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
objcss_TemplateStyleEN = JsonConvert.DeserializeObject<clscss_TemplateStyleEN>(strJson);
return objcss_TemplateStyleEN;
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
public static clscss_TemplateStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clscss_TemplateStyleEN objcss_TemplateStyleEN;
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
objcss_TemplateStyleEN = JsonConvert.DeserializeObject<clscss_TemplateStyleEN>(strJson);
return objcss_TemplateStyleEN;
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
public static List<clscss_TemplateStyleEN> GetObjLst(string strWhereCond)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
public static List<clscss_TemplateStyleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
public static List<clscss_TemplateStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
public static List<clscss_TemplateStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
public static List<clscss_TemplateStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
public static List<clscss_TemplateStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clscss_TemplateStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateStyleEN>>(strJson);
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
 clscss_TemplateStyleEN objcss_TemplateStyleEN = clscss_TemplateStyleWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int Delcss_TemplateStyles(List<string> arrmId)
{
string strAction = "Delcss_TemplateStyles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcss_TemplateStylesByCond(string strWhereCond)
{
string strAction = "Delcss_TemplateStylesByCond";
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
public static bool AddNewRecord(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateStyleEN>(objcss_TemplateStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objcss_TemplateStyleEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateStyleEN>(objcss_TemplateStyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clscss_TemplateStyleEN objcss_TemplateStyleEN)
{
if (string.IsNullOrEmpty(objcss_TemplateStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateStyleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateStyleEN>(objcss_TemplateStyleEN);
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
 /// <param name = "objcss_TemplateStyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscss_TemplateStyleEN objcss_TemplateStyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcss_TemplateStyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateStyleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateStyleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateStyleEN>(objcss_TemplateStyleEN);
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
 /// <param name = "objcss_TemplateStyleENS">源对象</param>
 /// <param name = "objcss_TemplateStyleENT">目标对象</param>
 public static void CopyTo(clscss_TemplateStyleEN objcss_TemplateStyleENS, clscss_TemplateStyleEN objcss_TemplateStyleENT)
{
try
{
objcss_TemplateStyleENT.mId = objcss_TemplateStyleENS.mId; //mId
objcss_TemplateStyleENT.StyleId = objcss_TemplateStyleENS.StyleId; //样式ID
objcss_TemplateStyleENT.TemplateId = objcss_TemplateStyleENS.TemplateId; //模板ID
objcss_TemplateStyleENT.cssModuleAreaId = objcss_TemplateStyleENS.cssModuleAreaId; //区域主键
objcss_TemplateStyleENT.TemplateStyleName = objcss_TemplateStyleENS.TemplateStyleName; //模板样式名称
objcss_TemplateStyleENT.UpdDate = objcss_TemplateStyleENS.UpdDate; //修改日期
objcss_TemplateStyleENT.UpdUser = objcss_TemplateStyleENS.UpdUser; //修改者
objcss_TemplateStyleENT.Memo = objcss_TemplateStyleENS.Memo; //说明
objcss_TemplateStyleENT.TemplateStyleNameEn = objcss_TemplateStyleENS.TemplateStyleNameEn; //模板样式英文
objcss_TemplateStyleENT.IsDelete = objcss_TemplateStyleENS.IsDelete; //IsDelete
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
public static DataTable ToDataTable(List<clscss_TemplateStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscss_TemplateStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscss_TemplateStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscss_TemplateStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscss_TemplateStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscss_TemplateStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clscss_TemplateStyleEN._CurrTabName);
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
if (clscss_TemplateStyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_TemplateStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_TemplateStyleWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clscss_TemplateStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concss_TemplateStyle.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concss_TemplateStyle.StyleId, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.TemplateId, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.cssModuleAreaId, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.TemplateStyleName, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.Memo, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.TemplateStyleNameEn, Type.GetType("System.String"));
objDT.Columns.Add(concss_TemplateStyle.IsDelete, Type.GetType("System.Boolean"));
foreach (clscss_TemplateStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concss_TemplateStyle.mId] = objInFor[concss_TemplateStyle.mId];
objDR[concss_TemplateStyle.StyleId] = objInFor[concss_TemplateStyle.StyleId];
objDR[concss_TemplateStyle.TemplateId] = objInFor[concss_TemplateStyle.TemplateId];
objDR[concss_TemplateStyle.cssModuleAreaId] = objInFor[concss_TemplateStyle.cssModuleAreaId];
objDR[concss_TemplateStyle.TemplateStyleName] = objInFor[concss_TemplateStyle.TemplateStyleName];
objDR[concss_TemplateStyle.UpdDate] = objInFor[concss_TemplateStyle.UpdDate];
objDR[concss_TemplateStyle.UpdUser] = objInFor[concss_TemplateStyle.UpdUser];
objDR[concss_TemplateStyle.Memo] = objInFor[concss_TemplateStyle.Memo];
objDR[concss_TemplateStyle.TemplateStyleNameEn] = objInFor[concss_TemplateStyle.TemplateStyleNameEn];
objDR[concss_TemplateStyle.IsDelete] = objInFor[concss_TemplateStyle.IsDelete];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// css_TemplateStyle(css_TemplateStyle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4css_TemplateStyle : clsCommFun4BL
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
clscss_TemplateStyleWApi.ReFreshThisCache();
}
}

}