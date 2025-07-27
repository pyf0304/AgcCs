
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_TemplateStyleWApi
 表名:vcss_TemplateStyle(00050472)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理
 模块英文名:CssManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvcss_TemplateStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetmId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, long lngmId, string strComparisonOp="")
	{
objvcss_TemplateStyleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.mId) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.mId, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.mId] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleId, 8, convcss_TemplateStyle.StyleId);
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, convcss_TemplateStyle.StyleId);
objvcss_TemplateStyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.StyleId) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.StyleId, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.StyleId] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetControlId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strControlId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strControlId, 8, convcss_TemplateStyle.ControlId);
clsCheckSql.CheckFieldForeignKey(strControlId, 8, convcss_TemplateStyle.ControlId);
objvcss_TemplateStyleEN.ControlId = strControlId; //控件ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.ControlId) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.ControlId, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.ControlId] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetControlName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strControlName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strControlName, 50, convcss_TemplateStyle.ControlName);
objvcss_TemplateStyleEN.ControlName = strControlName; //控件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.ControlName) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.ControlName, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.ControlName] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleName, 50, convcss_TemplateStyle.StyleName);
objvcss_TemplateStyleEN.StyleName = strStyleName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.StyleName) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.StyleName, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.StyleName] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleDesc(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleDesc, 200, convcss_TemplateStyle.StyleDesc);
objvcss_TemplateStyleEN.StyleDesc = strStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.StyleDesc) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.StyleDesc, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.StyleDesc] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleContent(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, convcss_TemplateStyle.StyleContent);
objvcss_TemplateStyleEN.StyleContent = strStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.StyleContent) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.StyleContent, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.StyleContent] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateId, 8, convcss_TemplateStyle.TemplateId);
clsCheckSql.CheckFieldForeignKey(strTemplateId, 8, convcss_TemplateStyle.TemplateId);
objvcss_TemplateStyleEN.TemplateId = strTemplateId; //模板ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplateId) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplateId, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplateId] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateName, 50, convcss_TemplateStyle.TemplateName);
objvcss_TemplateStyleEN.TemplateName = strTemplateName; //模板名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplateName) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplateName, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplateName] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateDesc(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateDesc, 100, convcss_TemplateStyle.TemplateDesc);
objvcss_TemplateStyleEN.TemplateDesc = strTemplateDesc; //模板描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplateDesc) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplateDesc, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplateDesc] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplatePic(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplatePic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplatePic, 100, convcss_TemplateStyle.TemplatePic);
objvcss_TemplateStyleEN.TemplatePic = strTemplatePic; //模板图片
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplatePic) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplatePic, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplatePic] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetIsPublic(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, bool bolIsPublic, string strComparisonOp="")
	{
objvcss_TemplateStyleEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.IsPublic) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.IsPublic, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.IsPublic] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateStyleName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateStyleName, 50, convcss_TemplateStyle.TemplateStyleName);
objvcss_TemplateStyleEN.TemplateStyleName = strTemplateStyleName; //模板样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplateStyleName) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplateStyleName, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleName] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetUpdDate(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcss_TemplateStyle.UpdDate);
objvcss_TemplateStyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.UpdDate) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.UpdDate, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.UpdDate] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetUpdUser(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcss_TemplateStyle.UpdUser);
objvcss_TemplateStyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.UpdUser) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.UpdUser, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.UpdUser] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetMemo(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcss_TemplateStyle.Memo);
objvcss_TemplateStyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.Memo) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.Memo, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.Memo] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateStyleNameEn(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateStyleNameEn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTemplateStyleNameEn, 200, convcss_TemplateStyle.TemplateStyleNameEn);
objvcss_TemplateStyleEN.TemplateStyleNameEn = strTemplateStyleNameEn; //模板样式英文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.TemplateStyleNameEn) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.TemplateStyleNameEn, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleNameEn] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetcssModuleAreaId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strcssModuleAreaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcssModuleAreaId, convcss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldLen(strcssModuleAreaId, 8, convcss_TemplateStyle.cssModuleAreaId);
clsCheckSql.CheckFieldForeignKey(strcssModuleAreaId, 8, convcss_TemplateStyle.cssModuleAreaId);
objvcss_TemplateStyleEN.cssModuleAreaId = strcssModuleAreaId; //区域主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.cssModuleAreaId) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.cssModuleAreaId, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.cssModuleAreaId] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetModuleAreaName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strModuleAreaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModuleAreaName, 100, convcss_TemplateStyle.ModuleAreaName);
objvcss_TemplateStyleEN.ModuleAreaName = strModuleAreaName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.ModuleAreaName) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.ModuleAreaName, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.ModuleAreaName] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetIsDelete(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, bool bolIsDelete, string strComparisonOp="")
	{
objvcss_TemplateStyleEN.IsDelete = bolIsDelete; //IsDelete
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_TemplateStyleEN.dicFldComparisonOp.ContainsKey(convcss_TemplateStyle.IsDelete) == false)
{
objvcss_TemplateStyleEN.dicFldComparisonOp.Add(convcss_TemplateStyle.IsDelete, strComparisonOp);
}
else
{
objvcss_TemplateStyleEN.dicFldComparisonOp[convcss_TemplateStyle.IsDelete] = strComparisonOp;
}
}
return objvcss_TemplateStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcss_TemplateStyleEN objvcss_TemplateStyle_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.mId) == true)
{
string strComparisonOp_mId = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcss_TemplateStyle.mId, objvcss_TemplateStyle_Cond.mId, strComparisonOp_mId);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.StyleId) == true)
{
string strComparisonOp_StyleId = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleId, objvcss_TemplateStyle_Cond.StyleId, strComparisonOp_StyleId);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.ControlId) == true)
{
string strComparisonOp_ControlId = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.ControlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ControlId, objvcss_TemplateStyle_Cond.ControlId, strComparisonOp_ControlId);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.ControlName) == true)
{
string strComparisonOp_ControlName = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.ControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ControlName, objvcss_TemplateStyle_Cond.ControlName, strComparisonOp_ControlName);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.StyleName) == true)
{
string strComparisonOp_StyleName = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleName, objvcss_TemplateStyle_Cond.StyleName, strComparisonOp_StyleName);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.StyleDesc) == true)
{
string strComparisonOp_StyleDesc = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleDesc, objvcss_TemplateStyle_Cond.StyleDesc, strComparisonOp_StyleDesc);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.StyleContent) == true)
{
string strComparisonOp_StyleContent = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleContent, objvcss_TemplateStyle_Cond.StyleContent, strComparisonOp_StyleContent);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplateId) == true)
{
string strComparisonOp_TemplateId = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateId, objvcss_TemplateStyle_Cond.TemplateId, strComparisonOp_TemplateId);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplateName) == true)
{
string strComparisonOp_TemplateName = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateName, objvcss_TemplateStyle_Cond.TemplateName, strComparisonOp_TemplateName);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplateDesc) == true)
{
string strComparisonOp_TemplateDesc = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplateDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateDesc, objvcss_TemplateStyle_Cond.TemplateDesc, strComparisonOp_TemplateDesc);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplatePic) == true)
{
string strComparisonOp_TemplatePic = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplatePic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplatePic, objvcss_TemplateStyle_Cond.TemplatePic, strComparisonOp_TemplatePic);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.IsPublic) == true)
{
if (objvcss_TemplateStyle_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcss_TemplateStyle.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcss_TemplateStyle.IsPublic);
}
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplateStyleName) == true)
{
string strComparisonOp_TemplateStyleName = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateStyleName, objvcss_TemplateStyle_Cond.TemplateStyleName, strComparisonOp_TemplateStyleName);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.UpdDate, objvcss_TemplateStyle_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.UpdUser, objvcss_TemplateStyle_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.Memo) == true)
{
string strComparisonOp_Memo = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.Memo, objvcss_TemplateStyle_Cond.Memo, strComparisonOp_Memo);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.TemplateStyleNameEn) == true)
{
string strComparisonOp_TemplateStyleNameEn = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleNameEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateStyleNameEn, objvcss_TemplateStyle_Cond.TemplateStyleNameEn, strComparisonOp_TemplateStyleNameEn);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.cssModuleAreaId) == true)
{
string strComparisonOp_cssModuleAreaId = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.cssModuleAreaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.cssModuleAreaId, objvcss_TemplateStyle_Cond.cssModuleAreaId, strComparisonOp_cssModuleAreaId);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.ModuleAreaName) == true)
{
string strComparisonOp_ModuleAreaName = objvcss_TemplateStyle_Cond.dicFldComparisonOp[convcss_TemplateStyle.ModuleAreaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ModuleAreaName, objvcss_TemplateStyle_Cond.ModuleAreaName, strComparisonOp_ModuleAreaName);
}
if (objvcss_TemplateStyle_Cond.IsUpdated(convcss_TemplateStyle.IsDelete) == true)
{
if (objvcss_TemplateStyle_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcss_TemplateStyle.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcss_TemplateStyle.IsDelete);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcss_TemplateStyleWApi
{
private static readonly string mstrApiControllerName = "vcss_TemplateStyleApi";

 public clsvcss_TemplateStyleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvcss_TemplateStyleEN = JsonConvert.DeserializeObject<clsvcss_TemplateStyleEN>((string)jobjReturn["returnObj"]);
return objvcss_TemplateStyleEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvcss_TemplateStyleEN = JsonConvert.DeserializeObject<clsvcss_TemplateStyleEN>((string)jobjReturn["returnObj"]);
return objvcss_TemplateStyleEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsvcss_TemplateStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvcss_TemplateStyleEN = JsonConvert.DeserializeObject<clsvcss_TemplateStyleEN>((string)jobjReturn["returnObj"]);
return objvcss_TemplateStyleEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Sel =
from objvcss_TemplateStyleEN in arrvcss_TemplateStyleObjLst_Cache
where objvcss_TemplateStyleEN.mId == lngmId
select objvcss_TemplateStyleEN;
if (arrvcss_TemplateStyleObjLst_Sel.Count() == 0)
{
   clsvcss_TemplateStyleEN obj = clsvcss_TemplateStyleWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcss_TemplateStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLst(string strWhereCond)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcss_TemplateStyleEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Sel =
from objvcss_TemplateStyleEN in arrvcss_TemplateStyleObjLst_Cache
where arrMId.Contains(objvcss_TemplateStyleEN.mId)
select objvcss_TemplateStyleEN;
return arrvcss_TemplateStyleObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvcss_TemplateStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvcss_TemplateStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcss_TemplateStyleEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_TemplateStyleEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <param name = "objvcss_TemplateStyleENT">目标对象</param>
 public static void CopyTo(clsvcss_TemplateStyleEN objvcss_TemplateStyleENS, clsvcss_TemplateStyleEN objvcss_TemplateStyleENT)
{
try
{
objvcss_TemplateStyleENT.mId = objvcss_TemplateStyleENS.mId; //mId
objvcss_TemplateStyleENT.StyleId = objvcss_TemplateStyleENS.StyleId; //样式ID
objvcss_TemplateStyleENT.ControlId = objvcss_TemplateStyleENS.ControlId; //控件ID
objvcss_TemplateStyleENT.ControlName = objvcss_TemplateStyleENS.ControlName; //控件名称
objvcss_TemplateStyleENT.StyleName = objvcss_TemplateStyleENS.StyleName; //样式名称
objvcss_TemplateStyleENT.StyleDesc = objvcss_TemplateStyleENS.StyleDesc; //样式描述
objvcss_TemplateStyleENT.StyleContent = objvcss_TemplateStyleENS.StyleContent; //样式内容
objvcss_TemplateStyleENT.TemplateId = objvcss_TemplateStyleENS.TemplateId; //模板ID
objvcss_TemplateStyleENT.TemplateName = objvcss_TemplateStyleENS.TemplateName; //模板名称
objvcss_TemplateStyleENT.TemplateDesc = objvcss_TemplateStyleENS.TemplateDesc; //模板描述
objvcss_TemplateStyleENT.TemplatePic = objvcss_TemplateStyleENS.TemplatePic; //模板图片
objvcss_TemplateStyleENT.IsPublic = objvcss_TemplateStyleENS.IsPublic; //是否公开
objvcss_TemplateStyleENT.TemplateStyleName = objvcss_TemplateStyleENS.TemplateStyleName; //模板样式名称
objvcss_TemplateStyleENT.UpdDate = objvcss_TemplateStyleENS.UpdDate; //修改日期
objvcss_TemplateStyleENT.UpdUser = objvcss_TemplateStyleENS.UpdUser; //修改者
objvcss_TemplateStyleENT.Memo = objvcss_TemplateStyleENS.Memo; //说明
objvcss_TemplateStyleENT.TemplateStyleNameEn = objvcss_TemplateStyleENS.TemplateStyleNameEn; //模板样式英文
objvcss_TemplateStyleENT.cssModuleAreaId = objvcss_TemplateStyleENS.cssModuleAreaId; //区域主键
objvcss_TemplateStyleENT.ModuleAreaName = objvcss_TemplateStyleENS.ModuleAreaName; //区域名称
objvcss_TemplateStyleENT.IsDelete = objvcss_TemplateStyleENS.IsDelete; //IsDelete
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
public static DataTable ToDataTable(List<clsvcss_TemplateStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcss_TemplateStyleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcss_TemplateStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcss_TemplateStyleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcss_TemplateStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcss_TemplateStyleEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clscss_TemplateWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clscss_TemplateWApi没有刷新缓存机制(clscss_TemplateWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscss_TemplateStyleWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clscss_TemplateStyleWApi没有刷新缓存机制(clscss_TemplateStyleWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscss_ModuleAreaWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clscss_ModuleAreaWApi没有刷新缓存机制(clscss_ModuleAreaWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}

if (clscss_StyleWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clscss_StyleWApi没有刷新缓存机制(clscss_StyleWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcss_TemplateStyleObjLst_Cache == null)
//{
//arrvcss_TemplateStyleObjLst_Cache = await clsvcss_TemplateStyleWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcss_TemplateStyleObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcss_TemplateStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcss_TemplateStyle.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcss_TemplateStyle.StyleId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.ControlId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.ControlName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.StyleName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.StyleDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.StyleContent, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.TemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.TemplateName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.TemplateDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.TemplatePic, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcss_TemplateStyle.TemplateStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.TemplateStyleNameEn, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.cssModuleAreaId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.ModuleAreaName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_TemplateStyle.IsDelete, Type.GetType("System.Boolean"));
foreach (clsvcss_TemplateStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcss_TemplateStyle.mId] = objInFor[convcss_TemplateStyle.mId];
objDR[convcss_TemplateStyle.StyleId] = objInFor[convcss_TemplateStyle.StyleId];
objDR[convcss_TemplateStyle.ControlId] = objInFor[convcss_TemplateStyle.ControlId];
objDR[convcss_TemplateStyle.ControlName] = objInFor[convcss_TemplateStyle.ControlName];
objDR[convcss_TemplateStyle.StyleName] = objInFor[convcss_TemplateStyle.StyleName];
objDR[convcss_TemplateStyle.StyleDesc] = objInFor[convcss_TemplateStyle.StyleDesc];
objDR[convcss_TemplateStyle.StyleContent] = objInFor[convcss_TemplateStyle.StyleContent];
objDR[convcss_TemplateStyle.TemplateId] = objInFor[convcss_TemplateStyle.TemplateId];
objDR[convcss_TemplateStyle.TemplateName] = objInFor[convcss_TemplateStyle.TemplateName];
objDR[convcss_TemplateStyle.TemplateDesc] = objInFor[convcss_TemplateStyle.TemplateDesc];
objDR[convcss_TemplateStyle.TemplatePic] = objInFor[convcss_TemplateStyle.TemplatePic];
objDR[convcss_TemplateStyle.IsPublic] = objInFor[convcss_TemplateStyle.IsPublic];
objDR[convcss_TemplateStyle.TemplateStyleName] = objInFor[convcss_TemplateStyle.TemplateStyleName];
objDR[convcss_TemplateStyle.UpdDate] = objInFor[convcss_TemplateStyle.UpdDate];
objDR[convcss_TemplateStyle.UpdUser] = objInFor[convcss_TemplateStyle.UpdUser];
objDR[convcss_TemplateStyle.Memo] = objInFor[convcss_TemplateStyle.Memo];
objDR[convcss_TemplateStyle.TemplateStyleNameEn] = objInFor[convcss_TemplateStyle.TemplateStyleNameEn];
objDR[convcss_TemplateStyle.cssModuleAreaId] = objInFor[convcss_TemplateStyle.cssModuleAreaId];
objDR[convcss_TemplateStyle.ModuleAreaName] = objInFor[convcss_TemplateStyle.ModuleAreaName];
objDR[convcss_TemplateStyle.IsDelete] = objInFor[convcss_TemplateStyle.IsDelete];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}