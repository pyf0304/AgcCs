
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_TemplateStyleBL
 表名:vcss_TemplateStyle(00050472)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:41:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class clsvcss_TemplateStyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_TemplateStyleEN GetObj(this K_mId_vcss_TemplateStyle myKey)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = clsvcss_TemplateStyleBL.vcss_TemplateStyleDA.GetObjBymId(myKey.Value);
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleId, 8, convcss_TemplateStyle.StyleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, convcss_TemplateStyle.StyleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetControlId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strControlId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlId, 8, convcss_TemplateStyle.ControlId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strControlId, 8, convcss_TemplateStyle.ControlId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetControlName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strControlName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strControlName, 50, convcss_TemplateStyle.ControlName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleName, 50, convcss_TemplateStyle.StyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleDesc(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleDesc, 1000, convcss_TemplateStyle.StyleDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetStyleContent(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strStyleContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, convcss_TemplateStyle.StyleContent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateId, 8, convcss_TemplateStyle.TemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTemplateId, 8, convcss_TemplateStyle.TemplateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateName, 50, convcss_TemplateStyle.TemplateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateDesc(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateDesc, 100, convcss_TemplateStyle.TemplateDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplatePic(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplatePic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplatePic, 100, convcss_TemplateStyle.TemplatePic);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateStyleName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateStyleName, 50, convcss_TemplateStyle.TemplateStyleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetUpdDate(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcss_TemplateStyle.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetUpdUser(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcss_TemplateStyle.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetMemo(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcss_TemplateStyle.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetTemplateStyleNameEn(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strTemplateStyleNameEn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateStyleNameEn, 200, convcss_TemplateStyle.TemplateStyleNameEn);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetcssModuleAreaId(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strcssModuleAreaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strcssModuleAreaId, convcss_TemplateStyle.cssModuleAreaId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strcssModuleAreaId, 8, convcss_TemplateStyle.cssModuleAreaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strcssModuleAreaId, 8, convcss_TemplateStyle.cssModuleAreaId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcss_TemplateStyleEN SetModuleAreaName(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN, string strModuleAreaName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModuleAreaName, 100, convcss_TemplateStyle.ModuleAreaName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <param name = "objvcss_TemplateStyleENT">目标对象</param>
 public static void CopyTo(this clsvcss_TemplateStyleEN objvcss_TemplateStyleENS, clsvcss_TemplateStyleEN objvcss_TemplateStyleENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <returns>目标对象=>clsvcss_TemplateStyleEN:objvcss_TemplateStyleENT</returns>
 public static clsvcss_TemplateStyleEN CopyTo(this clsvcss_TemplateStyleEN objvcss_TemplateStyleENS)
{
try
{
 clsvcss_TemplateStyleEN objvcss_TemplateStyleENT = new clsvcss_TemplateStyleEN()
{
mId = objvcss_TemplateStyleENS.mId, //mId
StyleId = objvcss_TemplateStyleENS.StyleId, //样式ID
ControlId = objvcss_TemplateStyleENS.ControlId, //控件ID
ControlName = objvcss_TemplateStyleENS.ControlName, //控件名称
StyleName = objvcss_TemplateStyleENS.StyleName, //样式名称
StyleDesc = objvcss_TemplateStyleENS.StyleDesc, //样式描述
StyleContent = objvcss_TemplateStyleENS.StyleContent, //样式内容
TemplateId = objvcss_TemplateStyleENS.TemplateId, //模板ID
TemplateName = objvcss_TemplateStyleENS.TemplateName, //模板名称
TemplateDesc = objvcss_TemplateStyleENS.TemplateDesc, //模板描述
TemplatePic = objvcss_TemplateStyleENS.TemplatePic, //模板图片
IsPublic = objvcss_TemplateStyleENS.IsPublic, //是否公开
TemplateStyleName = objvcss_TemplateStyleENS.TemplateStyleName, //模板样式名称
UpdDate = objvcss_TemplateStyleENS.UpdDate, //修改日期
UpdUser = objvcss_TemplateStyleENS.UpdUser, //修改者
Memo = objvcss_TemplateStyleENS.Memo, //说明
TemplateStyleNameEn = objvcss_TemplateStyleENS.TemplateStyleNameEn, //模板样式英文
cssModuleAreaId = objvcss_TemplateStyleENS.cssModuleAreaId, //区域主键
ModuleAreaName = objvcss_TemplateStyleENS.ModuleAreaName, //区域名称
IsDelete = objvcss_TemplateStyleENS.IsDelete, //IsDelete
};
 return objvcss_TemplateStyleENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
 clsvcss_TemplateStyleBL.vcss_TemplateStyleDA.CheckProperty4Condition(objvcss_TemplateStyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcss_TemplateStyleEN objvcss_TemplateStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.mId) == true)
{
string strComparisonOpmId = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convcss_TemplateStyle.mId, objvcss_TemplateStyleCond.mId, strComparisonOpmId);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.StyleId) == true)
{
string strComparisonOpStyleId = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleId, objvcss_TemplateStyleCond.StyleId, strComparisonOpStyleId);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.ControlId) == true)
{
string strComparisonOpControlId = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.ControlId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ControlId, objvcss_TemplateStyleCond.ControlId, strComparisonOpControlId);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.ControlName) == true)
{
string strComparisonOpControlName = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.ControlName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ControlName, objvcss_TemplateStyleCond.ControlName, strComparisonOpControlName);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.StyleName) == true)
{
string strComparisonOpStyleName = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleName, objvcss_TemplateStyleCond.StyleName, strComparisonOpStyleName);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.StyleDesc) == true)
{
string strComparisonOpStyleDesc = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleDesc, objvcss_TemplateStyleCond.StyleDesc, strComparisonOpStyleDesc);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.StyleContent) == true)
{
string strComparisonOpStyleContent = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.StyleContent, objvcss_TemplateStyleCond.StyleContent, strComparisonOpStyleContent);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplateId) == true)
{
string strComparisonOpTemplateId = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateId, objvcss_TemplateStyleCond.TemplateId, strComparisonOpTemplateId);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplateName) == true)
{
string strComparisonOpTemplateName = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateName, objvcss_TemplateStyleCond.TemplateName, strComparisonOpTemplateName);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplateDesc) == true)
{
string strComparisonOpTemplateDesc = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplateDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateDesc, objvcss_TemplateStyleCond.TemplateDesc, strComparisonOpTemplateDesc);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplatePic) == true)
{
string strComparisonOpTemplatePic = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplatePic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplatePic, objvcss_TemplateStyleCond.TemplatePic, strComparisonOpTemplatePic);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.IsPublic) == true)
{
if (objvcss_TemplateStyleCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcss_TemplateStyle.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcss_TemplateStyle.IsPublic);
}
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplateStyleName) == true)
{
string strComparisonOpTemplateStyleName = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateStyleName, objvcss_TemplateStyleCond.TemplateStyleName, strComparisonOpTemplateStyleName);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.UpdDate, objvcss_TemplateStyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.UpdUser, objvcss_TemplateStyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.Memo) == true)
{
string strComparisonOpMemo = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.Memo, objvcss_TemplateStyleCond.Memo, strComparisonOpMemo);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.TemplateStyleNameEn) == true)
{
string strComparisonOpTemplateStyleNameEn = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.TemplateStyleNameEn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.TemplateStyleNameEn, objvcss_TemplateStyleCond.TemplateStyleNameEn, strComparisonOpTemplateStyleNameEn);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.cssModuleAreaId) == true)
{
string strComparisonOpcssModuleAreaId = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.cssModuleAreaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.cssModuleAreaId, objvcss_TemplateStyleCond.cssModuleAreaId, strComparisonOpcssModuleAreaId);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.ModuleAreaName) == true)
{
string strComparisonOpModuleAreaName = objvcss_TemplateStyleCond.dicFldComparisonOp[convcss_TemplateStyle.ModuleAreaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_TemplateStyle.ModuleAreaName, objvcss_TemplateStyleCond.ModuleAreaName, strComparisonOpModuleAreaName);
}
if (objvcss_TemplateStyleCond.IsUpdated(convcss_TemplateStyle.IsDelete) == true)
{
if (objvcss_TemplateStyleCond.IsDelete == true)
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
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcss_TemplateStyle
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcss_TemplateStyleBL
{
public static RelatedActions_vcss_TemplateStyle relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vcss_TemplateStyleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vcss_TemplateStyleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcss_TemplateStyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcss_TemplateStyleDA vcss_TemplateStyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcss_TemplateStyleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcss_TemplateStyleBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvcss_TemplateStyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcss_TemplateStyleEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vcss_TemplateStyleDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vcss_TemplateStyleDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vcss_TemplateStyleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vcss_TemplateStyle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable_vcss_TemplateStyle(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vcss_TemplateStyleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcss_TemplateStyleEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Sel =
arrvcss_TemplateStyleObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvcss_TemplateStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLst(string strWhereCond)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcss_TemplateStyleEN> GetSubObjLstCache(clsvcss_TemplateStyleEN objvcss_TemplateStyleCond)
{
List<clsvcss_TemplateStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_TemplateStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcss_TemplateStyle.AttributeName)
{
if (objvcss_TemplateStyleCond.IsUpdated(strFldName) == false) continue;
if (objvcss_TemplateStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else
{
if (objvcss_TemplateStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcss_TemplateStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcss_TemplateStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvcss_TemplateStyleEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcss_TemplateStyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvcss_TemplateStyleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvcss_TemplateStyleEN objvcss_TemplateStyleCond, string strOrderBy)
{
List<clsvcss_TemplateStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_TemplateStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcss_TemplateStyle.AttributeName)
{
if (objvcss_TemplateStyleCond.IsUpdated(strFldName) == false) continue;
if (objvcss_TemplateStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else
{
if (objvcss_TemplateStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcss_TemplateStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcss_TemplateStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvcss_TemplateStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleCond = JsonConvert.DeserializeObject<clsvcss_TemplateStyleEN>(objPagerPara.whereCond);
if (objvcss_TemplateStyleCond.sfFldComparisonOp == null)
{
objvcss_TemplateStyleCond.dicFldComparisonOp = null;
}
else
{
objvcss_TemplateStyleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvcss_TemplateStyleCond.sfFldComparisonOp);
}
clsvcss_TemplateStyleBL.SetUpdFlag(objvcss_TemplateStyleCond);
 try
{
CheckProperty4Condition(objvcss_TemplateStyleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvcss_TemplateStyleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvcss_TemplateStyleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcss_TemplateStyleEN> arrObjLst = new List<clsvcss_TemplateStyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
try
{
objvcss_TemplateStyleEN.mId = Int32.Parse(objRow[convcss_TemplateStyle.mId].ToString().Trim()); //mId
objvcss_TemplateStyleEN.StyleId = objRow[convcss_TemplateStyle.StyleId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleId].ToString().Trim(); //样式ID
objvcss_TemplateStyleEN.ControlId = objRow[convcss_TemplateStyle.ControlId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlId].ToString().Trim(); //控件ID
objvcss_TemplateStyleEN.ControlName = objRow[convcss_TemplateStyle.ControlName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ControlName].ToString().Trim(); //控件名称
objvcss_TemplateStyleEN.StyleName = objRow[convcss_TemplateStyle.StyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleName].ToString().Trim(); //样式名称
objvcss_TemplateStyleEN.StyleDesc = objRow[convcss_TemplateStyle.StyleDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleDesc].ToString().Trim(); //样式描述
objvcss_TemplateStyleEN.StyleContent = objRow[convcss_TemplateStyle.StyleContent] == DBNull.Value ? null : objRow[convcss_TemplateStyle.StyleContent].ToString().Trim(); //样式内容
objvcss_TemplateStyleEN.TemplateId = objRow[convcss_TemplateStyle.TemplateId] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateId].ToString().Trim(); //模板ID
objvcss_TemplateStyleEN.TemplateName = objRow[convcss_TemplateStyle.TemplateName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateName].ToString().Trim(); //模板名称
objvcss_TemplateStyleEN.TemplateDesc = objRow[convcss_TemplateStyle.TemplateDesc] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateDesc].ToString().Trim(); //模板描述
objvcss_TemplateStyleEN.TemplatePic = objRow[convcss_TemplateStyle.TemplatePic] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplatePic].ToString().Trim(); //模板图片
objvcss_TemplateStyleEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsPublic].ToString().Trim()); //是否公开
objvcss_TemplateStyleEN.TemplateStyleName = objRow[convcss_TemplateStyle.TemplateStyleName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleName].ToString().Trim(); //模板样式名称
objvcss_TemplateStyleEN.UpdDate = objRow[convcss_TemplateStyle.UpdDate] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdDate].ToString().Trim(); //修改日期
objvcss_TemplateStyleEN.UpdUser = objRow[convcss_TemplateStyle.UpdUser] == DBNull.Value ? null : objRow[convcss_TemplateStyle.UpdUser].ToString().Trim(); //修改者
objvcss_TemplateStyleEN.Memo = objRow[convcss_TemplateStyle.Memo] == DBNull.Value ? null : objRow[convcss_TemplateStyle.Memo].ToString().Trim(); //说明
objvcss_TemplateStyleEN.TemplateStyleNameEn = objRow[convcss_TemplateStyle.TemplateStyleNameEn] == DBNull.Value ? null : objRow[convcss_TemplateStyle.TemplateStyleNameEn].ToString().Trim(); //模板样式英文
objvcss_TemplateStyleEN.cssModuleAreaId = objRow[convcss_TemplateStyle.cssModuleAreaId].ToString().Trim(); //区域主键
objvcss_TemplateStyleEN.ModuleAreaName = objRow[convcss_TemplateStyle.ModuleAreaName] == DBNull.Value ? null : objRow[convcss_TemplateStyle.ModuleAreaName].ToString().Trim(); //区域名称
objvcss_TemplateStyleEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convcss_TemplateStyle.IsDelete].ToString().Trim()); //IsDelete
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_TemplateStyleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_TemplateStyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcss_TemplateStyle(ref clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
bool bolResult = vcss_TemplateStyleDA.Getvcss_TemplateStyle(ref objvcss_TemplateStyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymId(long lngmId)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = vcss_TemplateStyleDA.GetObjBymId(lngmId);
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcss_TemplateStyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = vcss_TemplateStyleDA.GetFirstObj(strWhereCond);
 return objvcss_TemplateStyleEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvcss_TemplateStyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = vcss_TemplateStyleDA.GetObjByDataRow(objRow);
 return objvcss_TemplateStyleEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvcss_TemplateStyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = vcss_TemplateStyleDA.GetObjByDataRow(objRow);
 return objvcss_TemplateStyleEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvcss_TemplateStyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymIdFromList(long lngmId, List<clsvcss_TemplateStyleEN> lstvcss_TemplateStyleObjLst)
{
foreach (clsvcss_TemplateStyleEN objvcss_TemplateStyleEN in lstvcss_TemplateStyleObjLst)
{
if (objvcss_TemplateStyleEN.mId == lngmId)
{
return objvcss_TemplateStyleEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvcss_TemplateStyleDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vcss_TemplateStyleDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vcss_TemplateStyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vcss_TemplateStyleDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvcss_TemplateStyleDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vcss_TemplateStyleDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">源简化对象</param>
 public static void SetUpdFlag(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
try
{
objvcss_TemplateStyleEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvcss_TemplateStyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcss_TemplateStyle.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.mId = objvcss_TemplateStyleEN.mId; //mId
}
if (arrFldSet.Contains(convcss_TemplateStyle.StyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.StyleId = objvcss_TemplateStyleEN.StyleId == "[null]" ? null :  objvcss_TemplateStyleEN.StyleId; //样式ID
}
if (arrFldSet.Contains(convcss_TemplateStyle.ControlId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.ControlId = objvcss_TemplateStyleEN.ControlId == "[null]" ? null :  objvcss_TemplateStyleEN.ControlId; //控件ID
}
if (arrFldSet.Contains(convcss_TemplateStyle.ControlName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.ControlName = objvcss_TemplateStyleEN.ControlName == "[null]" ? null :  objvcss_TemplateStyleEN.ControlName; //控件名称
}
if (arrFldSet.Contains(convcss_TemplateStyle.StyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.StyleName = objvcss_TemplateStyleEN.StyleName == "[null]" ? null :  objvcss_TemplateStyleEN.StyleName; //样式名称
}
if (arrFldSet.Contains(convcss_TemplateStyle.StyleDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.StyleDesc = objvcss_TemplateStyleEN.StyleDesc == "[null]" ? null :  objvcss_TemplateStyleEN.StyleDesc; //样式描述
}
if (arrFldSet.Contains(convcss_TemplateStyle.StyleContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.StyleContent = objvcss_TemplateStyleEN.StyleContent == "[null]" ? null :  objvcss_TemplateStyleEN.StyleContent; //样式内容
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplateId = objvcss_TemplateStyleEN.TemplateId == "[null]" ? null :  objvcss_TemplateStyleEN.TemplateId; //模板ID
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplateName = objvcss_TemplateStyleEN.TemplateName == "[null]" ? null :  objvcss_TemplateStyleEN.TemplateName; //模板名称
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplateDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplateDesc = objvcss_TemplateStyleEN.TemplateDesc == "[null]" ? null :  objvcss_TemplateStyleEN.TemplateDesc; //模板描述
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplatePic, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplatePic = objvcss_TemplateStyleEN.TemplatePic == "[null]" ? null :  objvcss_TemplateStyleEN.TemplatePic; //模板图片
}
if (arrFldSet.Contains(convcss_TemplateStyle.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.IsPublic = objvcss_TemplateStyleEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplateStyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplateStyleName = objvcss_TemplateStyleEN.TemplateStyleName == "[null]" ? null :  objvcss_TemplateStyleEN.TemplateStyleName; //模板样式名称
}
if (arrFldSet.Contains(convcss_TemplateStyle.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.UpdDate = objvcss_TemplateStyleEN.UpdDate == "[null]" ? null :  objvcss_TemplateStyleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcss_TemplateStyle.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.UpdUser = objvcss_TemplateStyleEN.UpdUser == "[null]" ? null :  objvcss_TemplateStyleEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convcss_TemplateStyle.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.Memo = objvcss_TemplateStyleEN.Memo == "[null]" ? null :  objvcss_TemplateStyleEN.Memo; //说明
}
if (arrFldSet.Contains(convcss_TemplateStyle.TemplateStyleNameEn, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.TemplateStyleNameEn = objvcss_TemplateStyleEN.TemplateStyleNameEn == "[null]" ? null :  objvcss_TemplateStyleEN.TemplateStyleNameEn; //模板样式英文
}
if (arrFldSet.Contains(convcss_TemplateStyle.cssModuleAreaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.cssModuleAreaId = objvcss_TemplateStyleEN.cssModuleAreaId; //区域主键
}
if (arrFldSet.Contains(convcss_TemplateStyle.ModuleAreaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.ModuleAreaName = objvcss_TemplateStyleEN.ModuleAreaName == "[null]" ? null :  objvcss_TemplateStyleEN.ModuleAreaName; //区域名称
}
if (arrFldSet.Contains(convcss_TemplateStyle.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_TemplateStyleEN.IsDelete = objvcss_TemplateStyleEN.IsDelete; //IsDelete
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
try
{
if (objvcss_TemplateStyleEN.StyleId == "[null]") objvcss_TemplateStyleEN.StyleId = null; //样式ID
if (objvcss_TemplateStyleEN.ControlId == "[null]") objvcss_TemplateStyleEN.ControlId = null; //控件ID
if (objvcss_TemplateStyleEN.ControlName == "[null]") objvcss_TemplateStyleEN.ControlName = null; //控件名称
if (objvcss_TemplateStyleEN.StyleName == "[null]") objvcss_TemplateStyleEN.StyleName = null; //样式名称
if (objvcss_TemplateStyleEN.StyleDesc == "[null]") objvcss_TemplateStyleEN.StyleDesc = null; //样式描述
if (objvcss_TemplateStyleEN.StyleContent == "[null]") objvcss_TemplateStyleEN.StyleContent = null; //样式内容
if (objvcss_TemplateStyleEN.TemplateId == "[null]") objvcss_TemplateStyleEN.TemplateId = null; //模板ID
if (objvcss_TemplateStyleEN.TemplateName == "[null]") objvcss_TemplateStyleEN.TemplateName = null; //模板名称
if (objvcss_TemplateStyleEN.TemplateDesc == "[null]") objvcss_TemplateStyleEN.TemplateDesc = null; //模板描述
if (objvcss_TemplateStyleEN.TemplatePic == "[null]") objvcss_TemplateStyleEN.TemplatePic = null; //模板图片
if (objvcss_TemplateStyleEN.TemplateStyleName == "[null]") objvcss_TemplateStyleEN.TemplateStyleName = null; //模板样式名称
if (objvcss_TemplateStyleEN.UpdDate == "[null]") objvcss_TemplateStyleEN.UpdDate = null; //修改日期
if (objvcss_TemplateStyleEN.UpdUser == "[null]") objvcss_TemplateStyleEN.UpdUser = null; //修改者
if (objvcss_TemplateStyleEN.Memo == "[null]") objvcss_TemplateStyleEN.Memo = null; //说明
if (objvcss_TemplateStyleEN.TemplateStyleNameEn == "[null]") objvcss_TemplateStyleEN.TemplateStyleNameEn = null; //模板样式英文
if (objvcss_TemplateStyleEN.ModuleAreaName == "[null]") objvcss_TemplateStyleEN.ModuleAreaName = null; //区域名称
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
 vcss_TemplateStyleDA.CheckProperty4Condition(objvcss_TemplateStyleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clscss_TemplateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_TemplateBL没有刷新缓存机制(clscss_TemplateBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscss_TemplateStyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_TemplateStyleBL没有刷新缓存机制(clscss_TemplateStyleBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscss_ModuleAreaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_ModuleAreaBL没有刷新缓存机制(clscss_ModuleAreaBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//if (clscss_ControlBL.objCommFun4BL == null)
//{
//strMsg = string.Format("类clscss_ControlBL没有刷新缓存机制(clscss_ControlBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
//throw new Exception(strMsg);
//}
if (clscss_StyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_StyleBL没有刷新缓存机制(clscss_StyleBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvcss_TemplateStyleObjLstCache == null)
//{
//arrvcss_TemplateStyleObjLstCache = vcss_TemplateStyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcss_TemplateStyleEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLst_Sel =
arrvcss_TemplateStyleObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvcss_TemplateStyleObjLst_Sel.Count() == 0)
{
   clsvcss_TemplateStyleEN obj = clsvcss_TemplateStyleBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcss_TemplateStyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetAllvcss_TemplateStyleObjLstCache()
{
//获取缓存中的对象列表
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLstCache = GetObjLstCache(); 
return arrvcss_TemplateStyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcss_TemplateStyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcss_TemplateStyleEN._CurrTabName);
List<clsvcss_TemplateStyleEN> arrvcss_TemplateStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcss_TemplateStyleObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvcss_TemplateStyleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvcss_TemplateStyleEN> lstvcss_TemplateStyleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvcss_TemplateStyleObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvcss_TemplateStyleObjLst">[clsvcss_TemplateStyleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvcss_TemplateStyleEN> lstvcss_TemplateStyleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvcss_TemplateStyleBL.listXmlNode);
writer.WriteStartElement(clsvcss_TemplateStyleBL.itemsXmlNode);
foreach (clsvcss_TemplateStyleEN objvcss_TemplateStyleEN in lstvcss_TemplateStyleObjLst)
{
clsvcss_TemplateStyleBL.SerializeXML(writer, objvcss_TemplateStyleEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvcss_TemplateStyleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
writer.WriteStartElement(clsvcss_TemplateStyleBL.itemXmlNode);
 
writer.WriteElementString(convcss_TemplateStyle.mId, objvcss_TemplateStyleEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvcss_TemplateStyleEN.StyleId != null)
{
writer.WriteElementString(convcss_TemplateStyle.StyleId, objvcss_TemplateStyleEN.StyleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.ControlId != null)
{
writer.WriteElementString(convcss_TemplateStyle.ControlId, objvcss_TemplateStyleEN.ControlId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.ControlName != null)
{
writer.WriteElementString(convcss_TemplateStyle.ControlName, objvcss_TemplateStyleEN.ControlName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.StyleName != null)
{
writer.WriteElementString(convcss_TemplateStyle.StyleName, objvcss_TemplateStyleEN.StyleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.StyleDesc != null)
{
writer.WriteElementString(convcss_TemplateStyle.StyleDesc, objvcss_TemplateStyleEN.StyleDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.StyleContent != null)
{
writer.WriteElementString(convcss_TemplateStyle.StyleContent, objvcss_TemplateStyleEN.StyleContent.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.TemplateId != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplateId, objvcss_TemplateStyleEN.TemplateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.TemplateName != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplateName, objvcss_TemplateStyleEN.TemplateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.TemplateDesc != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplateDesc, objvcss_TemplateStyleEN.TemplateDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.TemplatePic != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplatePic, objvcss_TemplateStyleEN.TemplatePic.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convcss_TemplateStyle.IsPublic, objvcss_TemplateStyleEN.IsPublic.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvcss_TemplateStyleEN.TemplateStyleName != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplateStyleName, objvcss_TemplateStyleEN.TemplateStyleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.UpdDate != null)
{
writer.WriteElementString(convcss_TemplateStyle.UpdDate, objvcss_TemplateStyleEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.UpdUser != null)
{
writer.WriteElementString(convcss_TemplateStyle.UpdUser, objvcss_TemplateStyleEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.Memo != null)
{
writer.WriteElementString(convcss_TemplateStyle.Memo, objvcss_TemplateStyleEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.TemplateStyleNameEn != null)
{
writer.WriteElementString(convcss_TemplateStyle.TemplateStyleNameEn, objvcss_TemplateStyleEN.TemplateStyleNameEn.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.cssModuleAreaId != null)
{
writer.WriteElementString(convcss_TemplateStyle.cssModuleAreaId, objvcss_TemplateStyleEN.cssModuleAreaId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvcss_TemplateStyleEN.ModuleAreaName != null)
{
writer.WriteElementString(convcss_TemplateStyle.ModuleAreaName, objvcss_TemplateStyleEN.ModuleAreaName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convcss_TemplateStyle.IsDelete, objvcss_TemplateStyleEN.IsDelete.ToString().ToLower(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvcss_TemplateStyleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
reader.Read();
while (!(reader.Name == clsvcss_TemplateStyleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convcss_TemplateStyle.mId))
{
objvcss_TemplateStyleEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convcss_TemplateStyle.StyleId))
{
objvcss_TemplateStyleEN.StyleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.ControlId))
{
objvcss_TemplateStyleEN.ControlId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.ControlName))
{
objvcss_TemplateStyleEN.ControlName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.StyleName))
{
objvcss_TemplateStyleEN.StyleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.StyleDesc))
{
objvcss_TemplateStyleEN.StyleDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.StyleContent))
{
objvcss_TemplateStyleEN.StyleContent = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplateId))
{
objvcss_TemplateStyleEN.TemplateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplateName))
{
objvcss_TemplateStyleEN.TemplateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplateDesc))
{
objvcss_TemplateStyleEN.TemplateDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplatePic))
{
objvcss_TemplateStyleEN.TemplatePic = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.IsPublic))
{
objvcss_TemplateStyleEN.IsPublic = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplateStyleName))
{
objvcss_TemplateStyleEN.TemplateStyleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.UpdDate))
{
objvcss_TemplateStyleEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.UpdUser))
{
objvcss_TemplateStyleEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.Memo))
{
objvcss_TemplateStyleEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.TemplateStyleNameEn))
{
objvcss_TemplateStyleEN.TemplateStyleNameEn = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.cssModuleAreaId))
{
objvcss_TemplateStyleEN.cssModuleAreaId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.ModuleAreaName))
{
objvcss_TemplateStyleEN.ModuleAreaName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convcss_TemplateStyle.IsDelete))
{
objvcss_TemplateStyleEN.IsDelete = reader.ReadElementContentAsBoolean();
}
}
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvcss_TemplateStyleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvcss_TemplateStyleEN GetObjFromXmlStr(string strvcss_TemplateStyleObjXmlStr)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = new clsvcss_TemplateStyleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvcss_TemplateStyleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvcss_TemplateStyleBL.itemXmlNode))
{
objvcss_TemplateStyleEN = GetObjFromXml(reader);
return objvcss_TemplateStyleEN;
}
}
return objvcss_TemplateStyleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvcss_TemplateStyleEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convcss_TemplateStyle.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcss_TemplateStyle.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcss_TemplateStyle.AttributeName));
throw new Exception(strMsg);
}
var objvcss_TemplateStyle = clsvcss_TemplateStyleBL.GetObjBymIdCache(lngmId);
if (objvcss_TemplateStyle == null) return "";
return objvcss_TemplateStyle[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvcss_TemplateStyleEN objvcss_TemplateStyleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvcss_TemplateStyleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvcss_TemplateStyleEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvcss_TemplateStyleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvcss_TemplateStyleEN> lstvcss_TemplateStyleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvcss_TemplateStyleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvcss_TemplateStyleEN objvcss_TemplateStyleEN in lstvcss_TemplateStyleObjLst)
{
string strJSON_One = SerializeObjToJSON(objvcss_TemplateStyleEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvcss_TemplateStyleDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvcss_TemplateStyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcss_TemplateStyleDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvcss_TemplateStyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcss_TemplateStyleEN objvcss_TemplateStyleCond)
{
List<clsvcss_TemplateStyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_TemplateStyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcss_TemplateStyle.AttributeName)
{
if (objvcss_TemplateStyleCond.IsUpdated(strFldName) == false) continue;
if (objvcss_TemplateStyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else
{
if (objvcss_TemplateStyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcss_TemplateStyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_TemplateStyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcss_TemplateStyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcss_TemplateStyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcss_TemplateStyleCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvcss_TemplateStyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vcss_TemplateStyleDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vcss_TemplateStyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}