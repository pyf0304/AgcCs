
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateWApi
 表名:css_Template(00050469)
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
public static class  clscss_TemplateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateId">模板ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateId(this clscss_TemplateEN objcss_TemplateEN, string strTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateId, 8, concss_Template.TemplateId);
clsCheckSql.CheckFieldForeignKey(strTemplateId, 8, concss_Template.TemplateId);
objcss_TemplateEN.TemplateId = strTemplateId; //模板ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.TemplateId) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.TemplateId, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.TemplateId] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateName">模板名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateName(this clscss_TemplateEN objcss_TemplateEN, string strTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateName, 50, concss_Template.TemplateName);
objcss_TemplateEN.TemplateName = strTemplateName; //模板名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.TemplateName) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.TemplateName, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.TemplateName] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplateDesc">模板描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateDesc(this clscss_TemplateEN objcss_TemplateEN, string strTemplateDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateDesc, 100, concss_Template.TemplateDesc);
objcss_TemplateEN.TemplateDesc = strTemplateDesc; //模板描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.TemplateDesc) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.TemplateDesc, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.TemplateDesc] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetOrderNum(this clscss_TemplateEN objcss_TemplateEN, int intOrderNum, string strComparisonOp="")
	{
objcss_TemplateEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.OrderNum) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.OrderNum, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.OrderNum] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strTemplatePic">模板图片</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplatePic(this clscss_TemplateEN objcss_TemplateEN, string strTemplatePic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplatePic, 100, concss_Template.TemplatePic);
objcss_TemplateEN.TemplatePic = strTemplatePic; //模板图片
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.TemplatePic) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.TemplatePic, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.TemplatePic] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPublic">是否公开</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetIsPublic(this clscss_TemplateEN objcss_TemplateEN, bool bolIsPublic, string strComparisonOp="")
	{
objcss_TemplateEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.IsPublic) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.IsPublic, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.IsPublic] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDeleted">是否删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetIsDeleted(this clscss_TemplateEN objcss_TemplateEN, bool bolIsDeleted, string strComparisonOp="")
	{
objcss_TemplateEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.IsDeleted) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.IsDeleted, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.IsDeleted] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strDeletedDate">删除日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetDeletedDate(this clscss_TemplateEN objcss_TemplateEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_Template.DeletedDate);
objcss_TemplateEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.DeletedDate) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.DeletedDate, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.DeletedDate] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetUpdDate(this clscss_TemplateEN objcss_TemplateEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_Template.UpdDate);
objcss_TemplateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.UpdDate) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.UpdDate, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.UpdDate] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetUpdUser(this clscss_TemplateEN objcss_TemplateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_Template.UpdUser);
objcss_TemplateEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.UpdUser) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.UpdUser, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.UpdUser] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetMemo(this clscss_TemplateEN objcss_TemplateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_Template.Memo);
objcss_TemplateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcss_TemplateEN.dicFldComparisonOp.ContainsKey(concss_Template.Memo) == false)
{
objcss_TemplateEN.dicFldComparisonOp.Add(concss_Template.Memo, strComparisonOp);
}
else
{
objcss_TemplateEN.dicFldComparisonOp[concss_Template.Memo] = strComparisonOp;
}
}
return objcss_TemplateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscss_TemplateEN objcss_TemplateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcss_TemplateCond.IsUpdated(concss_Template.TemplateId) == true)
{
string strComparisonOpTemplateId = objcss_TemplateCond.dicFldComparisonOp[concss_Template.TemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.TemplateId, objcss_TemplateCond.TemplateId, strComparisonOpTemplateId);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.TemplateName) == true)
{
string strComparisonOpTemplateName = objcss_TemplateCond.dicFldComparisonOp[concss_Template.TemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.TemplateName, objcss_TemplateCond.TemplateName, strComparisonOpTemplateName);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.TemplateDesc) == true)
{
string strComparisonOpTemplateDesc = objcss_TemplateCond.dicFldComparisonOp[concss_Template.TemplateDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.TemplateDesc, objcss_TemplateCond.TemplateDesc, strComparisonOpTemplateDesc);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.OrderNum) == true)
{
string strComparisonOpOrderNum = objcss_TemplateCond.dicFldComparisonOp[concss_Template.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concss_Template.OrderNum, objcss_TemplateCond.OrderNum, strComparisonOpOrderNum);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.TemplatePic) == true)
{
string strComparisonOpTemplatePic = objcss_TemplateCond.dicFldComparisonOp[concss_Template.TemplatePic];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.TemplatePic, objcss_TemplateCond.TemplatePic, strComparisonOpTemplatePic);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.IsPublic) == true)
{
if (objcss_TemplateCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_Template.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_Template.IsPublic);
}
}
if (objcss_TemplateCond.IsUpdated(concss_Template.IsDeleted) == true)
{
if (objcss_TemplateCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", concss_Template.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concss_Template.IsDeleted);
}
}
if (objcss_TemplateCond.IsUpdated(concss_Template.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objcss_TemplateCond.dicFldComparisonOp[concss_Template.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.DeletedDate, objcss_TemplateCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.UpdDate) == true)
{
string strComparisonOpUpdDate = objcss_TemplateCond.dicFldComparisonOp[concss_Template.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.UpdDate, objcss_TemplateCond.UpdDate, strComparisonOpUpdDate);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.UpdUser) == true)
{
string strComparisonOpUpdUser = objcss_TemplateCond.dicFldComparisonOp[concss_Template.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.UpdUser, objcss_TemplateCond.UpdUser, strComparisonOpUpdUser);
}
if (objcss_TemplateCond.IsUpdated(concss_Template.Memo) == true)
{
string strComparisonOpMemo = objcss_TemplateCond.dicFldComparisonOp[concss_Template.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concss_Template.Memo, objcss_TemplateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_TemplateEN objcss_TemplateEN)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcss_TemplateEN.sfUpdFldSetStr = objcss_TemplateEN.getsfUpdFldSetStr();
clscss_TemplateWApi.CheckPropertyNew(objcss_TemplateEN); 
bool bolResult = clscss_TemplateWApi.UpdateRecord(objcss_TemplateEN);
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_TemplateEN objcss_TemplateEN)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscss_TemplateWApi.IsExist(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcss_TemplateEN.TemplateId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscss_TemplateWApi.CheckPropertyNew(objcss_TemplateEN); 
bool bolResult = clscss_TemplateWApi.AddNewRecord(objcss_TemplateEN);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscss_TemplateEN objcss_TemplateEN)
{
try
{
clscss_TemplateWApi.CheckPropertyNew(objcss_TemplateEN); 
string strTemplateId = clscss_TemplateWApi.AddNewRecordWithMaxId(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strTemplateId;
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
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_TemplateEN objcss_TemplateEN, string strWhereCond)
{
try
{
clscss_TemplateWApi.CheckPropertyNew(objcss_TemplateEN); 
bool bolResult = clscss_TemplateWApi.UpdateWithCondition(objcss_TemplateEN, strWhereCond);
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
 /// css_Template(css_Template)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscss_TemplateWApi
{
private static readonly string mstrApiControllerName = "css_TemplateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clscss_TemplateWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscss_TemplateEN objcss_TemplateEN)
{
if (!Object.Equals(null, objcss_TemplateEN.TemplateId) && GetStrLen(objcss_TemplateEN.TemplateId) > 8)
{
 throw new Exception("字段[模板ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcss_TemplateEN.TemplateName) && GetStrLen(objcss_TemplateEN.TemplateName) > 50)
{
 throw new Exception("字段[模板名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_TemplateEN.TemplateDesc) && GetStrLen(objcss_TemplateEN.TemplateDesc) > 100)
{
 throw new Exception("字段[模板描述]的长度不能超过100!");
}
if (!Object.Equals(null, objcss_TemplateEN.TemplatePic) && GetStrLen(objcss_TemplateEN.TemplatePic) > 100)
{
 throw new Exception("字段[模板图片]的长度不能超过100!");
}
if (!Object.Equals(null, objcss_TemplateEN.DeletedDate) && GetStrLen(objcss_TemplateEN.DeletedDate) > 50)
{
 throw new Exception("字段[删除日期]的长度不能超过50!");
}
if (!Object.Equals(null, objcss_TemplateEN.UpdDate) && GetStrLen(objcss_TemplateEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_TemplateEN.UpdUser) && GetStrLen(objcss_TemplateEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objcss_TemplateEN.Memo) && GetStrLen(objcss_TemplateEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objcss_TemplateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_TemplateEN GetObjByTemplateId(string strTemplateId)
{
if (strTemplateId == "") return null;
string strAction = "GetObjByTemplateId";
clscss_TemplateEN objcss_TemplateEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTemplateId"] = strTemplateId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objcss_TemplateEN = JsonConvert.DeserializeObject<clscss_TemplateEN>(strJson);
return objcss_TemplateEN;
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
public static clscss_TemplateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clscss_TemplateEN objcss_TemplateEN;
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
objcss_TemplateEN = JsonConvert.DeserializeObject<clscss_TemplateEN>(strJson);
return objcss_TemplateEN;
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
public static List<clscss_TemplateEN> GetObjLst(string strWhereCond)
{
 List<clscss_TemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
 /// <param name = "arrTemplateId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_TemplateEN> GetObjLstByTemplateIdLst(List<string> arrTemplateId)
{
 List<clscss_TemplateEN> arrObjLst; 
string strAction = "GetObjLstByTemplateIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTemplateId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
public static List<clscss_TemplateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscss_TemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
public static List<clscss_TemplateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscss_TemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
public static List<clscss_TemplateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscss_TemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
public static List<clscss_TemplateEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clscss_TemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscss_TemplateEN>>(strJson);
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
public static int DelRecord(string strTemplateId)
{
string strAction = "DelRecord";
try
{
 clscss_TemplateEN objcss_TemplateEN = clscss_TemplateWApi.GetObjByTemplateId(strTemplateId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTemplateId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int Delcss_Templates(List<string> arrTemplateId)
{
string strAction = "Delcss_Templates";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTemplateId);
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
public static int Delcss_TemplatesByCond(string strWhereCond)
{
string strAction = "Delcss_TemplatesByCond";
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
public static bool AddNewRecord(clscss_TemplateEN objcss_TemplateEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateEN>(objcss_TemplateEN);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clscss_TemplateEN objcss_TemplateEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateEN>(objcss_TemplateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strTemplateId = (string)jobjReturn0["returnStr"];
return strTemplateId;
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
public static bool UpdateRecord(clscss_TemplateEN objcss_TemplateEN)
{
if (string.IsNullOrEmpty(objcss_TemplateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateEN.TemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateEN>(objcss_TemplateEN);
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
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscss_TemplateEN objcss_TemplateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcss_TemplateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateEN.TemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objcss_TemplateEN.TemplateId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscss_TemplateEN>(objcss_TemplateEN);
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
public static bool IsExist(string strTemplateId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTemplateId"] = strTemplateId
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
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <param name = "objcss_TemplateENT">目标对象</param>
 public static void CopyTo(clscss_TemplateEN objcss_TemplateENS, clscss_TemplateEN objcss_TemplateENT)
{
try
{
objcss_TemplateENT.TemplateId = objcss_TemplateENS.TemplateId; //模板ID
objcss_TemplateENT.TemplateName = objcss_TemplateENS.TemplateName; //模板名称
objcss_TemplateENT.TemplateDesc = objcss_TemplateENS.TemplateDesc; //模板描述
objcss_TemplateENT.OrderNum = objcss_TemplateENS.OrderNum; //序号
objcss_TemplateENT.TemplatePic = objcss_TemplateENS.TemplatePic; //模板图片
objcss_TemplateENT.IsPublic = objcss_TemplateENS.IsPublic; //是否公开
objcss_TemplateENT.IsDeleted = objcss_TemplateENS.IsDeleted; //是否删除
objcss_TemplateENT.DeletedDate = objcss_TemplateENS.DeletedDate; //删除日期
objcss_TemplateENT.UpdDate = objcss_TemplateENS.UpdDate; //修改日期
objcss_TemplateENT.UpdUser = objcss_TemplateENS.UpdUser; //修改者
objcss_TemplateENT.Memo = objcss_TemplateENS.Memo; //说明
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
public static DataTable ToDataTable(List<clscss_TemplateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscss_TemplateEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscss_TemplateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscss_TemplateEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscss_TemplateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscss_TemplateEN._AttributeName)
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
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
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
if (clscss_TemplateWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_TemplateWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clscss_TemplateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concss_Template.TemplateId, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.TemplateName, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.TemplateDesc, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concss_Template.TemplatePic, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(concss_Template.IsDeleted, Type.GetType("System.Boolean"));
objDT.Columns.Add(concss_Template.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concss_Template.Memo, Type.GetType("System.String"));
foreach (clscss_TemplateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concss_Template.TemplateId] = objInFor[concss_Template.TemplateId];
objDR[concss_Template.TemplateName] = objInFor[concss_Template.TemplateName];
objDR[concss_Template.TemplateDesc] = objInFor[concss_Template.TemplateDesc];
objDR[concss_Template.OrderNum] = objInFor[concss_Template.OrderNum];
objDR[concss_Template.TemplatePic] = objInFor[concss_Template.TemplatePic];
objDR[concss_Template.IsPublic] = objInFor[concss_Template.IsPublic];
objDR[concss_Template.IsDeleted] = objInFor[concss_Template.IsDeleted];
objDR[concss_Template.DeletedDate] = objInFor[concss_Template.DeletedDate];
objDR[concss_Template.UpdDate] = objInFor[concss_Template.UpdDate];
objDR[concss_Template.UpdUser] = objInFor[concss_Template.UpdUser];
objDR[concss_Template.Memo] = objInFor[concss_Template.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// css_Template(css_Template)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4css_Template : clsCommFun4BL
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
clscss_TemplateWApi.ReFreshThisCache();
}
}

}