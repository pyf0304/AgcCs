
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateBL
 表名:css_Template(00050469)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:12
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clscss_TemplateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_TemplateEN GetObj(this K_TemplateId_css_Template myKey)
{
clscss_TemplateEN objcss_TemplateEN = clscss_TemplateBL.css_TemplateDA.GetObjByTemplateId(myKey.Value);
return objcss_TemplateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscss_TemplateEN objcss_TemplateEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscss_TemplateBL.IsExist(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcss_TemplateEN.TemplateId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clscss_TemplateBL.css_TemplateDA.AddNewRecordBySQL2(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clscss_TemplateEN objcss_TemplateEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clscss_TemplateBL.IsExist(objcss_TemplateEN.TemplateId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objcss_TemplateEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objcss_TemplateEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscss_TemplateEN objcss_TemplateEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscss_TemplateBL.IsExist(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcss_TemplateEN.TemplateId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clscss_TemplateBL.css_TemplateDA.AddNewRecordBySQL2WithReturnKey(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateId(this clscss_TemplateEN objcss_TemplateEN, string strTemplateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateId, 8, concss_Template.TemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTemplateId, 8, concss_Template.TemplateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateName(this clscss_TemplateEN objcss_TemplateEN, string strTemplateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateName, 50, concss_Template.TemplateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplateDesc(this clscss_TemplateEN objcss_TemplateEN, string strTemplateDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplateDesc, 100, concss_Template.TemplateDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetOrderNum(this clscss_TemplateEN objcss_TemplateEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetTemplatePic(this clscss_TemplateEN objcss_TemplateEN, string strTemplatePic, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTemplatePic, 100, concss_Template.TemplatePic);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetDeletedDate(this clscss_TemplateEN objcss_TemplateEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, concss_Template.DeletedDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetUpdDate(this clscss_TemplateEN objcss_TemplateEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concss_Template.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetUpdUser(this clscss_TemplateEN objcss_TemplateEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concss_Template.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscss_TemplateEN SetMemo(this clscss_TemplateEN objcss_TemplateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concss_Template.Memo);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscss_TemplateEN objcss_TemplateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcss_TemplateEN.CheckPropertyNew();
clscss_TemplateEN objcss_TemplateCond = new clscss_TemplateEN();
string strCondition = objcss_TemplateCond
.SetTemplateId(objcss_TemplateEN.TemplateId, "=")
.GetCombineCondition();
objcss_TemplateEN._IsCheckProperty = true;
bool bolIsExist = clscss_TemplateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcss_TemplateEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_TemplateEN objcss_TemplateEN)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_TemplateBL.css_TemplateDA.UpdateBySql2(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscss_TemplateEN objcss_TemplateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscss_TemplateBL.css_TemplateDA.UpdateBySql2(objcss_TemplateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_TemplateEN objcss_TemplateEN, string strWhereCond)
{
try
{
bool bolResult = clscss_TemplateBL.css_TemplateDA.UpdateBySqlWithCondition(objcss_TemplateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscss_TemplateEN objcss_TemplateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscss_TemplateBL.css_TemplateDA.UpdateBySqlWithConditionTransaction(objcss_TemplateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscss_TemplateEN objcss_TemplateEN)
{
try
{
int intRecNum = clscss_TemplateBL.css_TemplateDA.DelRecord(objcss_TemplateEN.TemplateId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <param name = "objcss_TemplateENT">目标对象</param>
 public static void CopyTo(this clscss_TemplateEN objcss_TemplateENS, clscss_TemplateEN objcss_TemplateENT)
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
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <returns>目标对象=>clscss_TemplateEN:objcss_TemplateENT</returns>
 public static clscss_TemplateEN CopyTo(this clscss_TemplateEN objcss_TemplateENS)
{
try
{
 clscss_TemplateEN objcss_TemplateENT = new clscss_TemplateEN()
{
TemplateId = objcss_TemplateENS.TemplateId, //模板ID
TemplateName = objcss_TemplateENS.TemplateName, //模板名称
TemplateDesc = objcss_TemplateENS.TemplateDesc, //模板描述
OrderNum = objcss_TemplateENS.OrderNum, //序号
TemplatePic = objcss_TemplateENS.TemplatePic, //模板图片
IsPublic = objcss_TemplateENS.IsPublic, //是否公开
IsDeleted = objcss_TemplateENS.IsDeleted, //是否删除
DeletedDate = objcss_TemplateENS.DeletedDate, //删除日期
UpdDate = objcss_TemplateENS.UpdDate, //修改日期
UpdUser = objcss_TemplateENS.UpdUser, //修改者
Memo = objcss_TemplateENS.Memo, //说明
};
 return objcss_TemplateENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clscss_TemplateEN objcss_TemplateEN)
{
 clscss_TemplateBL.css_TemplateDA.CheckPropertyNew(objcss_TemplateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscss_TemplateEN objcss_TemplateEN)
{
 clscss_TemplateBL.css_TemplateDA.CheckProperty4Condition(objcss_TemplateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_css_Template
{
public virtual bool UpdRelaTabDate(string strTemplateId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// css_Template(css_Template)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscss_TemplateBL
{
public static RelatedActions_css_Template relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscss_TemplateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscss_TemplateDA css_TemplateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscss_TemplateDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clscss_TemplateBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
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
if (string.IsNullOrEmpty(clscss_TemplateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscss_TemplateEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_css_Template(string strWhereCond)
{
DataTable objDT;
try
{
objDT = css_TemplateDA.GetDataTable_css_Template(strWhereCond);
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
objDT = css_TemplateDA.GetDataTable(strWhereCond);
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
objDT = css_TemplateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = css_TemplateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = css_TemplateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = css_TemplateDA.GetDataTable_Top(objTopPara);
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
objDT = css_TemplateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = css_TemplateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = css_TemplateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrTemplateIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscss_TemplateEN> GetObjLstByTemplateIdLst(List<string> arrTemplateIdLst)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTemplateIdLst, true);
 string strWhereCond = string.Format("TemplateId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTemplateIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscss_TemplateEN> GetObjLstByTemplateIdLstCache(List<string> arrTemplateIdLst)
{
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
List<clscss_TemplateEN> arrcss_TemplateObjLstCache = GetObjLstCache();
IEnumerable <clscss_TemplateEN> arrcss_TemplateObjLst_Sel =
arrcss_TemplateObjLstCache
.Where(x => arrTemplateIdLst.Contains(x.TemplateId));
return arrcss_TemplateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_TemplateEN> GetObjLst(string strWhereCond)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
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
public static List<clscss_TemplateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcss_TemplateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscss_TemplateEN> GetSubObjLstCache(clscss_TemplateEN objcss_TemplateCond)
{
List<clscss_TemplateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_TemplateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_Template._AttributeName)
{
if (objcss_TemplateCond.IsUpdated(strFldName) == false) continue;
if (objcss_TemplateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_TemplateCond[strFldName].ToString());
}
else
{
if (objcss_TemplateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_TemplateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_TemplateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_TemplateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_TemplateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_TemplateCond[strFldName]));
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
public static List<clscss_TemplateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
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
public static List<clscss_TemplateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
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
List<clscss_TemplateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscss_TemplateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_TemplateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscss_TemplateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
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
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
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
public static List<clscss_TemplateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscss_TemplateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscss_TemplateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
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
public static List<clscss_TemplateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscss_TemplateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscss_TemplateEN> arrObjLst = new List<clscss_TemplateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscss_TemplateEN objcss_TemplateEN = new clscss_TemplateEN();
try
{
objcss_TemplateEN.TemplateId = objRow[concss_Template.TemplateId].ToString().Trim(); //模板ID
objcss_TemplateEN.TemplateName = objRow[concss_Template.TemplateName] == DBNull.Value ? null : objRow[concss_Template.TemplateName].ToString().Trim(); //模板名称
objcss_TemplateEN.TemplateDesc = objRow[concss_Template.TemplateDesc] == DBNull.Value ? null : objRow[concss_Template.TemplateDesc].ToString().Trim(); //模板描述
objcss_TemplateEN.OrderNum = objRow[concss_Template.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concss_Template.OrderNum].ToString().Trim()); //序号
objcss_TemplateEN.TemplatePic = objRow[concss_Template.TemplatePic] == DBNull.Value ? null : objRow[concss_Template.TemplatePic].ToString().Trim(); //模板图片
objcss_TemplateEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsPublic].ToString().Trim()); //是否公开
objcss_TemplateEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[concss_Template.IsDeleted].ToString().Trim()); //是否删除
objcss_TemplateEN.DeletedDate = objRow[concss_Template.DeletedDate] == DBNull.Value ? null : objRow[concss_Template.DeletedDate].ToString().Trim(); //删除日期
objcss_TemplateEN.UpdDate = objRow[concss_Template.UpdDate] == DBNull.Value ? null : objRow[concss_Template.UpdDate].ToString().Trim(); //修改日期
objcss_TemplateEN.UpdUser = objRow[concss_Template.UpdUser] == DBNull.Value ? null : objRow[concss_Template.UpdUser].ToString().Trim(); //修改者
objcss_TemplateEN.Memo = objRow[concss_Template.Memo] == DBNull.Value ? null : objRow[concss_Template.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcss_TemplateEN.TemplateId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcss_TemplateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcss_TemplateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcss_Template(ref clscss_TemplateEN objcss_TemplateEN)
{
bool bolResult = css_TemplateDA.Getcss_Template(ref objcss_TemplateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public static clscss_TemplateEN GetObjByTemplateId(string strTemplateId)
{
if (strTemplateId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTemplateId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTemplateId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTemplateId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscss_TemplateEN objcss_TemplateEN = css_TemplateDA.GetObjByTemplateId(strTemplateId);
return objcss_TemplateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscss_TemplateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscss_TemplateEN objcss_TemplateEN = css_TemplateDA.GetFirstObj(strWhereCond);
 return objcss_TemplateEN;
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
public static clscss_TemplateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscss_TemplateEN objcss_TemplateEN = css_TemplateDA.GetObjByDataRow(objRow);
 return objcss_TemplateEN;
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
public static clscss_TemplateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscss_TemplateEN objcss_TemplateEN = css_TemplateDA.GetObjByDataRow(objRow);
 return objcss_TemplateEN;
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
 /// <param name = "strTemplateId">所给的关键字</param>
 /// <param name = "lstcss_TemplateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_TemplateEN GetObjByTemplateIdFromList(string strTemplateId, List<clscss_TemplateEN> lstcss_TemplateObjLst)
{
foreach (clscss_TemplateEN objcss_TemplateEN in lstcss_TemplateObjLst)
{
if (objcss_TemplateEN.TemplateId == strTemplateId)
{
return objcss_TemplateEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTemplateId;
 try
 {
 strTemplateId = new clscss_TemplateDA().GetFirstID(strWhereCond);
 return strTemplateId;
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
 arrList = css_TemplateDA.GetID(strWhereCond);
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
bool bolIsExist = css_TemplateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTemplateId)
{
if (string.IsNullOrEmpty(strTemplateId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTemplateId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = css_TemplateDA.IsExist(strTemplateId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTemplateId">模板ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTemplateId, string strOpUser)
{
clscss_TemplateEN objcss_TemplateEN = clscss_TemplateBL.GetObjByTemplateId(strTemplateId);
objcss_TemplateEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcss_TemplateEN.UpdUser = strOpUser;
return clscss_TemplateBL.UpdateBySql2(objcss_TemplateEN);
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
 bolIsExist = clscss_TemplateDA.IsExistTable();
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
 bolIsExist = css_TemplateDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscss_TemplateEN objcss_TemplateEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscss_TemplateBL.IsExist(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcss_TemplateEN.TemplateId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = css_TemplateDA.AddNewRecordBySQL2(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscss_TemplateEN objcss_TemplateEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscss_TemplateBL.IsExist(objcss_TemplateEN.TemplateId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcss_TemplateEN.TemplateId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = css_TemplateDA.AddNewRecordBySQL2WithReturnKey(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscss_TemplateEN objcss_TemplateEN)
{
try
{
bool bolResult = css_TemplateDA.Update(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objcss_TemplateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscss_TemplateEN objcss_TemplateEN)
{
 if (string.IsNullOrEmpty(objcss_TemplateEN.TemplateId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = css_TemplateDA.UpdateBySql2(objcss_TemplateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscss_TemplateBL.ReFreshCache();

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTemplateId)
{
try
{
 clscss_TemplateEN objcss_TemplateEN = clscss_TemplateBL.GetObjByTemplateId(strTemplateId);

if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_TemplateEN.TemplateId, objcss_TemplateEN.UpdUser);
}
if (objcss_TemplateEN != null)
{
int intRecNum = css_TemplateDA.DelRecord(strTemplateId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strTemplateId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTemplateId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_TemplateDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[css_Template]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concss_Template.TemplateId,
//strTemplateId);
//        clscss_TemplateBL.Delcss_TemplatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_TemplateBL.DelRecord(strTemplateId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_TemplateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTemplateId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strTemplateId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTemplateId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(strTemplateId, "UpdRelaTabDate");
}
bool bolResult = css_TemplateDA.DelRecord(strTemplateId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrTemplateIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcss_Templates(List<string> arrTemplateIdLst)
{
if (arrTemplateIdLst.Count == 0) return 0;
try
{
if (clscss_TemplateBL.relatedActions != null)
{
foreach (var strTemplateId in arrTemplateIdLst)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(strTemplateId, "UpdRelaTabDate");
}
}
int intDelRecNum = css_TemplateDA.Delcss_Template(arrTemplateIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int Delcss_TemplatesByCond(string strWhereCond)
{
try
{
if (clscss_TemplateBL.relatedActions != null)
{
List<string> arrTemplateId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTemplateId in arrTemplateId)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(strTemplateId, "UpdRelaTabDate");
}
}
int intRecNum = css_TemplateDA.Delcss_Template(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[css_Template]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTemplateId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTemplateId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscss_TemplateDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[css_Template]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscss_TemplateBL.DelRecord(strTemplateId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscss_TemplateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTemplateId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
 /// <param name = "objcss_TemplateEN">源简化对象</param>
 public static void SetUpdFlag(clscss_TemplateEN objcss_TemplateEN)
{
try
{
objcss_TemplateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcss_TemplateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concss_Template.TemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.TemplateId = objcss_TemplateEN.TemplateId; //模板ID
}
if (arrFldSet.Contains(concss_Template.TemplateName, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.TemplateName = objcss_TemplateEN.TemplateName == "[null]" ? null :  objcss_TemplateEN.TemplateName; //模板名称
}
if (arrFldSet.Contains(concss_Template.TemplateDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.TemplateDesc = objcss_TemplateEN.TemplateDesc == "[null]" ? null :  objcss_TemplateEN.TemplateDesc; //模板描述
}
if (arrFldSet.Contains(concss_Template.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.OrderNum = objcss_TemplateEN.OrderNum; //序号
}
if (arrFldSet.Contains(concss_Template.TemplatePic, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.TemplatePic = objcss_TemplateEN.TemplatePic == "[null]" ? null :  objcss_TemplateEN.TemplatePic; //模板图片
}
if (arrFldSet.Contains(concss_Template.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.IsPublic = objcss_TemplateEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(concss_Template.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.IsDeleted = objcss_TemplateEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(concss_Template.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.DeletedDate = objcss_TemplateEN.DeletedDate == "[null]" ? null :  objcss_TemplateEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(concss_Template.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.UpdDate = objcss_TemplateEN.UpdDate == "[null]" ? null :  objcss_TemplateEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concss_Template.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.UpdUser = objcss_TemplateEN.UpdUser == "[null]" ? null :  objcss_TemplateEN.UpdUser; //修改者
}
if (arrFldSet.Contains(concss_Template.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcss_TemplateEN.Memo = objcss_TemplateEN.Memo == "[null]" ? null :  objcss_TemplateEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objcss_TemplateEN">源简化对象</param>
 public static void AccessFldValueNull(clscss_TemplateEN objcss_TemplateEN)
{
try
{
if (objcss_TemplateEN.TemplateName == "[null]") objcss_TemplateEN.TemplateName = null; //模板名称
if (objcss_TemplateEN.TemplateDesc == "[null]") objcss_TemplateEN.TemplateDesc = null; //模板描述
if (objcss_TemplateEN.TemplatePic == "[null]") objcss_TemplateEN.TemplatePic = null; //模板图片
if (objcss_TemplateEN.DeletedDate == "[null]") objcss_TemplateEN.DeletedDate = null; //删除日期
if (objcss_TemplateEN.UpdDate == "[null]") objcss_TemplateEN.UpdDate = null; //修改日期
if (objcss_TemplateEN.UpdUser == "[null]") objcss_TemplateEN.UpdUser = null; //修改者
if (objcss_TemplateEN.Memo == "[null]") objcss_TemplateEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscss_TemplateEN objcss_TemplateEN)
{
 css_TemplateDA.CheckPropertyNew(objcss_TemplateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscss_TemplateEN objcss_TemplateEN)
{
 css_TemplateDA.CheckProperty4Condition(objcss_TemplateEN);
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
strMsg = string.Format("类clscss_TemplateBL没有刷新缓存机制(clscss_TemplateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TemplateId");
//if (arrcss_TemplateObjLstCache == null)
//{
//arrcss_TemplateObjLstCache = css_TemplateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTemplateId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscss_TemplateEN GetObjByTemplateIdCache(string strTemplateId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
List<clscss_TemplateEN> arrcss_TemplateObjLstCache = GetObjLstCache();
IEnumerable <clscss_TemplateEN> arrcss_TemplateObjLst_Sel =
arrcss_TemplateObjLstCache
.Where(x=> x.TemplateId == strTemplateId 
);
if (arrcss_TemplateObjLst_Sel.Count() == 0)
{
   clscss_TemplateEN obj = clscss_TemplateBL.GetObjByTemplateId(strTemplateId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcss_TemplateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_TemplateEN> GetAllcss_TemplateObjLstCache()
{
//获取缓存中的对象列表
List<clscss_TemplateEN> arrcss_TemplateObjLstCache = GetObjLstCache(); 
return arrcss_TemplateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscss_TemplateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
List<clscss_TemplateEN> arrcss_TemplateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcss_TemplateObjLstCache;
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
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_TemplateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clscss_TemplateEN._RefreshTimeLst.Count == 0) return "";
return clscss_TemplateEN._RefreshTimeLst[clscss_TemplateEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscss_TemplateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscss_TemplateEN._CurrTabName);
CacheHelper.Remove(strKey);
clscss_TemplateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscss_TemplateBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTemplateId)
{
if (strInFldName != concss_Template.TemplateId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concss_Template._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concss_Template._AttributeName));
throw new Exception(strMsg);
}
var objcss_Template = clscss_TemplateBL.GetObjByTemplateIdCache(strTemplateId);
if (objcss_Template == null) return "";
return objcss_Template[strOutFldName].ToString();
}


 #region 有关JSON操作


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
int intRecCount = clscss_TemplateDA.GetRecCount(strTabName);
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
int intRecCount = clscss_TemplateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscss_TemplateDA.GetRecCount();
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
int intRecCount = clscss_TemplateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcss_TemplateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscss_TemplateEN objcss_TemplateCond)
{
List<clscss_TemplateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscss_TemplateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concss_Template._AttributeName)
{
if (objcss_TemplateCond.IsUpdated(strFldName) == false) continue;
if (objcss_TemplateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_TemplateCond[strFldName].ToString());
}
else
{
if (objcss_TemplateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcss_TemplateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcss_TemplateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcss_TemplateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcss_TemplateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcss_TemplateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcss_TemplateCond[strFldName]));
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
 List<string> arrList = clscss_TemplateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = css_TemplateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = css_TemplateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = css_TemplateDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clscss_TemplateDA.SetFldValue(clscss_TemplateEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = css_TemplateDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clscss_TemplateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clscss_TemplateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clscss_TemplateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[css_Template] "); 
 strCreateTabCode.Append(" ( "); 
 // /**模板ID*/ 
 strCreateTabCode.Append(" TemplateId char(8) primary key, "); 
 // /**模板名称*/ 
 strCreateTabCode.Append(" TemplateName varchar(50) Null, "); 
 // /**模板描述*/ 
 strCreateTabCode.Append(" TemplateDesc varchar(100) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**模板图片*/ 
 strCreateTabCode.Append(" TemplatePic varchar(100) Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDeleted bit Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" DeletedDate varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", concss_Template.OrderNum); 
List<clscss_TemplateEN> arrcss_TemplateObjList = new clscss_TemplateDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_TemplateEN objcss_Template in arrcss_TemplateObjList)
{
objcss_Template.OrderNum = intIndex;
UpdateBySql2(objcss_Template);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strTemplateId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strTemplateId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[TemplateId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字TemplateId
//5、把当前关键字TemplateId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字TemplateId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevTemplateId = "";    //上一条序号的关键字TemplateId
string strNextTemplateId = "";    //下一条序号的关键字TemplateId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[TemplateId],获取相应的序号[OrderNum]。

clscss_TemplateEN objcss_Template = clscss_TemplateBL.GetObjByTemplateId(strTemplateId);

intOrderNum = objcss_Template.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clscss_TemplateBL.GetRecCountByCond(clscss_TemplateEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", concss_Template.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字TemplateId
strPrevTemplateId = clscss_TemplateBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevTemplateId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字TemplateId所对应记录的序号减1
//6、把下(上)一个序号关键字TemplateId所对应的记录序号加1
clscss_TemplateBL.SetFldValue(clscss_TemplateEN._CurrTabName, concss_Template.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", concss_Template.TemplateId, strTemplateId));
clscss_TemplateBL.SetFldValue(clscss_TemplateEN._CurrTabName, concss_Template.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", concss_Template.TemplateId, strPrevTemplateId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字TemplateId
strCondition.AppendFormat(" {0} = {1}", concss_Template.OrderNum, intOrderNum + 1);

strNextTemplateId = clscss_TemplateBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextTemplateId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字TemplateId所对应记录的序号加1
//6、把下(上)一个序号关键字TemplateId所对应的记录序号减1
clscss_TemplateBL.SetFldValue(clscss_TemplateEN._CurrTabName, concss_Template.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", concss_Template.TemplateId, strTemplateId));
clscss_TemplateBL.SetFldValue(clscss_TemplateEN._CurrTabName, concss_Template.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", concss_Template.TemplateId, strNextTemplateId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clscss_TemplateBL.ReFreshCache();
if (clscss_TemplateBL.relatedActions != null)
{
clscss_TemplateBL.relatedActions.UpdRelaTabDate(objcss_Template.TemplateId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concss_Template.TemplateId, strKeyList);
List<clscss_TemplateEN> arrcss_TemplateLst = GetObjLst(strCondition);
foreach (clscss_TemplateEN objcss_Template in arrcss_TemplateLst)
{
objcss_Template.OrderNum = objcss_Template.OrderNum + 10000;
UpdateBySql2(objcss_Template);
}
strCondition = string.Format("1 = 1 order by {0} ", concss_Template.OrderNum); 
List<clscss_TemplateEN> arrcss_TemplateObjList = new clscss_TemplateDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_TemplateEN objcss_Template in arrcss_TemplateObjList)
{
objcss_Template.OrderNum = intIndex;
UpdateBySql2(objcss_Template);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concss_Template.TemplateId, strKeyList);
List<clscss_TemplateEN> arrcss_TemplateLst = GetObjLst(strCondition);
foreach (clscss_TemplateEN objcss_Template in arrcss_TemplateLst)
{
objcss_Template.OrderNum = objcss_Template.OrderNum - 10000;
UpdateBySql2(objcss_Template);
}
strCondition = string.Format("1 = 1 order by {0} ", concss_Template.OrderNum); 
List<clscss_TemplateEN> arrcss_TemplateObjList = new clscss_TemplateDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscss_TemplateEN objcss_Template in arrcss_TemplateObjList)
{
objcss_Template.OrderNum = intIndex;
UpdateBySql2(objcss_Template);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// css_Template(css_Template)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4css_Template : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clscss_TemplateBL.ReFreshThisCache();
}
}

}