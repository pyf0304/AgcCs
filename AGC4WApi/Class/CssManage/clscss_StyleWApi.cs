
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_StyleWApi
 表名:css_Style(00050468)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:21
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
public static class  clscss_StyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleId">样式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleId(this clscss_StyleEN objcss_StyleEN, string strStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleId, 8, concss_Style.StyleId);
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, concss_Style.StyleId);
objcss_StyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleId) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleId, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleId] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetCtlTypeId(this clscss_StyleEN objcss_StyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, concss_Style.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, concss_Style.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, concss_Style.CtlTypeId);
objcss_StyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.CtlTypeId) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.CtlTypeId, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.CtlTypeId] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleName">样式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleName(this clscss_StyleEN objcss_StyleEN, string strStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleName, 50, concss_Style.StyleName);
objcss_StyleEN.StyleName = strStyleName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleName) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleName, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleName] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleDesc">样式描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleDesc(this clscss_StyleEN objcss_StyleEN, string strStyleDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleDesc, 1000, concss_Style.StyleDesc);
objcss_StyleEN.StyleDesc = strStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleDesc) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleDesc, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleDesc] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleContent">样式内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetStyleContent(this clscss_StyleEN objcss_StyleEN, string strStyleContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, concss_Style.StyleContent);
objcss_StyleEN.StyleContent = strStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.StyleContent) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.StyleContent, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.StyleContent] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDeleted">是否删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetIsDeleted(this clscss_StyleEN objcss_StyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objcss_StyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.IsDeleted) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.IsDeleted, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.IsDeleted] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDeletedDate">删除日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetDeletedDate(this clscss_StyleEN objcss_StyleEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_Style.DeletedDate);
objcss_StyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.DeletedDate) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.DeletedDate, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.DeletedDate] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetUpdDate(this clscss_StyleEN objcss_StyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_Style.UpdDate);
objcss_StyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.UpdDate) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.UpdDate, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.UpdDate] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetUpdUser(this clscss_StyleEN objcss_StyleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_Style.UpdUser);
objcss_StyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.UpdUser) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.UpdUser, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.UpdUser] = strComparisonOp;
}
}
return objcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_StyleEN SetMemo(this clscss_StyleEN objcss_StyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_Style.Memo);
objcss_StyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_StyleEN.dicFldComparisonOp.ContainsKey(concss_Style.Memo) == false)
{
objcss_StyleEN.dicFldComparisonOp.Add(concss_Style.Memo, strComparisonOp);
}
else
{
objcss_StyleEN.dicFldComparisonOp[concss_Style.Memo] = strComparisonOp;
}
}
return objcss_StyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_StyleEN objcss_StyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_StyleCond.IsUpdated(concss_Style.StyleId) == true)
{
string strComparisonOpStyleId = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleId, objcss_StyleCond.StyleId, strComparisonOpStyleId);
}
if (objcss_StyleCond.IsUpdated(concss_Style.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objcss_StyleCond.dicFldComparisonOp[concss_Style.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.CtlTypeId, objcss_StyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleName) == true)
{
string strComparisonOpStyleName = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleName, objcss_StyleCond.StyleName, strComparisonOpStyleName);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleDesc) == true)
{
string strComparisonOpStyleDesc = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleDesc, objcss_StyleCond.StyleDesc, strComparisonOpStyleDesc);
}
if (objcss_StyleCond.IsUpdated(concss_Style.StyleContent) == true)
{
string strComparisonOpStyleContent = objcss_StyleCond.dicFldComparisonOp[concss_Style.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.StyleContent, objcss_StyleCond.StyleContent, strComparisonOpStyleContent);
}
if (objcss_StyleCond.IsUpdated(concss_Style.IsDeleted) == true)
{
if (objcss_StyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_Style.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_Style.IsDeleted);
}
}
if (objcss_StyleCond.IsUpdated(concss_Style.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objcss_StyleCond.dicFldComparisonOp[concss_Style.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.DeletedDate, objcss_StyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objcss_StyleCond.IsUpdated(concss_Style.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_StyleCond.dicFldComparisonOp[concss_Style.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.UpdDate, objcss_StyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_StyleCond.IsUpdated(concss_Style.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_StyleCond.dicFldComparisonOp[concss_Style.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.UpdUser, objcss_StyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_StyleCond.IsUpdated(concss_Style.Memo) == true)
{
string strComparisonOpMemo = objcss_StyleCond.dicFldComparisonOp[concss_Style.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Style.Memo, objcss_StyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_StyleEN objcss_StyleEN)
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcss_StyleEN.sfUpdFldSetStr = objcss_StyleEN.getsfUpdFldSetStr();
clscss_StyleWApi.CheckPropertyNew(objcss_StyleEN); 
bool bolResult = clscss_StyleWApi.UpdateRecord(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
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
 /// 获取唯一性条件串--css_Style(css_Style), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CtlTypeId_StyleName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcss_StyleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clscss_StyleEN objcss_StyleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcss_StyleEN == null) return "";
if (objcss_StyleEN.StyleId == null || objcss_StyleEN.StyleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StyleId !=  '{0}'", objcss_StyleEN.StyleId);
 sbCondition.AppendFormat(" and CtlTypeId = '{0}'", objcss_StyleEN.CtlTypeId);
 sbCondition.AppendFormat(" and StyleName = '{0}'", objcss_StyleEN.StyleName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_StyleEN objcss_StyleEN)
{
try
{
 if (string.IsNullOrEmpty(objcss_StyleEN.StyleId) == true || clscss_StyleWApi.IsExist(objcss_StyleEN.StyleId) == true)
 {
     objcss_StyleEN.StyleId = clscss_StyleWApi.GetMaxStrId();
 }
clscss_StyleWApi.CheckPropertyNew(objcss_StyleEN); 
bool bolResult = clscss_StyleWApi.AddNewRecord(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
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
 /// <param name = "objcss_StyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscss_StyleEN objcss_StyleEN)
{
try
{
clscss_StyleWApi.CheckPropertyNew(objcss_StyleEN); 
string strStyleId = clscss_StyleWApi.AddNewRecordWithMaxId(objcss_StyleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
return strStyleId;
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
 /// <param name = "objcss_StyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_StyleEN objcss_StyleEN, string strWhereCond)
{
try
{
clscss_StyleWApi.CheckPropertyNew(objcss_StyleEN); 
bool bolResult = clscss_StyleWApi.UpdateWithCondition(objcss_StyleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
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
 /// css_Style(css_Style)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscss_StyleWApi
{
private static readonly string mstrApiControllerName = "css_StyleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clscss_StyleWApi()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCtlTypeId"></param>
public static void BindCbo_StyleId(System.Windows.Forms.ComboBox objComboBox , string strCtlTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concss_Style.StyleId); 
List<clscss_StyleEN> arrObjLst = clscss_StyleWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CtlTypeId == strCtlTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscss_StyleEN objcss_StyleEN = new clscss_StyleEN()
{
StyleId = "0",
StyleName = "选[css_Style]..."
};
arrObjLstSel.Insert(0, objcss_StyleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concss_Style.StyleId;
objComboBox.DisplayMember = concss_Style.StyleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscss_StyleEN objcss_StyleEN)
{
if (!Object.Equals(null, objcss_StyleEN.StyleId) && GetStrLen(objcss_StyleEN.StyleId) > 8)
{
 throw new Exception("字段[样式ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_StyleEN.CtlTypeId) && GetStrLen(objcss_StyleEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objcss_StyleEN.StyleName) && GetStrLen(objcss_StyleEN.StyleName) > 50)
{
 throw new Exception("字段[样式名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_StyleEN.StyleDesc) && GetStrLen(objcss_StyleEN.StyleDesc) > 1000)
{
 throw new Exception("字段[样式描述]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_StyleEN.StyleContent) && GetStrLen(objcss_StyleEN.StyleContent) > 1000)
{
 throw new Exception("字段[样式内容]的长度不能超过1000!");
}
if (!Object.Equals(null, objcss_StyleEN.DeletedDate) && GetStrLen(objcss_StyleEN.DeletedDate) > 50)
{
 throw new Exception("字段[删除日期]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_StyleEN.UpdDate) && GetStrLen(objcss_StyleEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_StyleEN.UpdUser) && GetStrLen(objcss_StyleEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_StyleEN.Memo) && GetStrLen(objcss_StyleEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objcss_StyleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_StyleEN GetObjByStyleId(string strStyleId)
{
if (strStyleId == "") return null;
string strAction = "GetObjByStyleId";
clscss_StyleEN objcss_StyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strStyleId"] = strStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objcss_StyleEN = JsonConvert.DeserializeObject<clscss_StyleEN>(strJson);
return objcss_StyleEN;
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
public static clscss_StyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clscss_StyleEN objcss_StyleEN;
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
objcss_StyleEN = JsonConvert.DeserializeObject<clscss_StyleEN>(strJson);
return objcss_StyleEN;
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
 /// <param name = "strStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_StyleEN GetObjByStyleIdCache(string strStyleId)
{
if (string.IsNullOrEmpty(strStyleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
List<clscss_StyleEN> arrcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrcss_StyleObjLst_Sel =
from objcss_StyleEN in arrcss_StyleObjLstCache
where objcss_StyleEN.StyleId == strStyleId 
select objcss_StyleEN;
if (arrcss_StyleObjLst_Sel.Count() == 0)
{
   clscss_StyleEN obj = clscss_StyleWApi.GetObjByStyleId(strStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcss_StyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetObjLst(string strWhereCond)
{
 List<clscss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
 /// <param name = "arrStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetObjLstByStyleIdLst(List<string> arrStyleId)
{
 List<clscss_StyleEN> arrObjLst; 
string strAction = "GetObjLstByStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
 /// <param name = "arrStyleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clscss_StyleEN> GetObjLstByStyleIdLstCache(List<string> arrStyleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
List<clscss_StyleEN> arrcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clscss_StyleEN> arrcss_StyleObjLst_Sel =
from objcss_StyleEN in arrcss_StyleObjLstCache
where arrStyleId.Contains(objcss_StyleEN.StyleId)
select objcss_StyleEN;
return arrcss_StyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_StyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
public static List<clscss_StyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
public static List<clscss_StyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
public static List<clscss_StyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clscss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_StyleEN>>(strJson);
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
public static int DelRecord(string strStyleId)
{
string strAction = "DelRecord";
try
{
 clscss_StyleEN objcss_StyleEN = clscss_StyleWApi.GetObjByStyleId(strStyleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strStyleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clscss_StyleWApi.ReFreshCache();
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
public static int Delcss_Styles(List<string> arrStyleId)
{
string strAction = "Delcss_Styles";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrStyleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clscss_StyleWApi.ReFreshCache();
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
public static int Delcss_StylesByCond(string strWhereCond)
{
string strAction = "Delcss_StylesByCond";
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
public static bool AddNewRecord(clscss_StyleEN objcss_StyleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_StyleEN>(objcss_StyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clscss_StyleEN objcss_StyleEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_StyleEN>(objcss_StyleEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_StyleWApi.ReFreshCache();
var strStyleId = (string)jobjReturn0["returnStr"];
return strStyleId;
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
public static bool UpdateRecord(clscss_StyleEN objcss_StyleEN)
{
if (string.IsNullOrEmpty(objcss_StyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_StyleEN.StyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_StyleEN>(objcss_StyleEN);
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
 /// <param name = "objcss_StyleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscss_StyleEN objcss_StyleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcss_StyleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_StyleEN.StyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_StyleEN.StyleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_StyleEN>(objcss_StyleEN);
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
public static bool IsExist(string strStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strStyleId"] = strStyleId
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
 /// <param name = "objcss_StyleENS">源对象</param>
 /// <param name = "objcss_StyleENT">目标对象</param>
 public static void CopyTo(clscss_StyleEN objcss_StyleENS, clscss_StyleEN objcss_StyleENT)
{
try
{
objcss_StyleENT.StyleId = objcss_StyleENS.StyleId; //样式ID
objcss_StyleENT.CtlTypeId = objcss_StyleENS.CtlTypeId; //控件类型号
objcss_StyleENT.StyleName = objcss_StyleENS.StyleName; //样式名称
objcss_StyleENT.StyleDesc = objcss_StyleENS.StyleDesc; //样式描述
objcss_StyleENT.StyleContent = objcss_StyleENS.StyleContent; //样式内容
objcss_StyleENT.IsDeleted = objcss_StyleENS.IsDeleted; //是否删除
objcss_StyleENT.DeletedDate = objcss_StyleENS.DeletedDate; //删除日期
objcss_StyleENT.UpdDate = objcss_StyleENS.UpdDate; //修改日期
objcss_StyleENT.UpdUser = objcss_StyleENS.UpdUser; //修改者
objcss_StyleENT.Memo = objcss_StyleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clscss_StyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscss_StyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscss_StyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscss_StyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscss_StyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscss_StyleEN._AttributeName)
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
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
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
if (clscss_StyleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_StyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_StyleWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_StyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clscss_StyleEN._CurrTabName;
List<clscss_StyleEN> arrcss_StyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrcss_StyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscss_StyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concss_Style.StyleId, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.StyleName, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.StyleDesc, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.StyleContent, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.IsDeleted, Type.GetType("System.Boolean"));
objDT.Columns.Add(concss_Style.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concss_Style.Memo, Type.GetType("System.String"));
foreach (clscss_StyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concss_Style.StyleId] = objInFor[concss_Style.StyleId];
objDR[concss_Style.CtlTypeId] = objInFor[concss_Style.CtlTypeId];
objDR[concss_Style.StyleName] = objInFor[concss_Style.StyleName];
objDR[concss_Style.StyleDesc] = objInFor[concss_Style.StyleDesc];
objDR[concss_Style.StyleContent] = objInFor[concss_Style.StyleContent];
objDR[concss_Style.IsDeleted] = objInFor[concss_Style.IsDeleted];
objDR[concss_Style.DeletedDate] = objInFor[concss_Style.DeletedDate];
objDR[concss_Style.UpdDate] = objInFor[concss_Style.UpdDate];
objDR[concss_Style.UpdUser] = objInFor[concss_Style.UpdUser];
objDR[concss_Style.Memo] = objInFor[concss_Style.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// css_Style(css_Style)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4css_Style : clsCommFun4BL
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
clscss_StyleWApi.ReFreshThisCache();
}
}

}