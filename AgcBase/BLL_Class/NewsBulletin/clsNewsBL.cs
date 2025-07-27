
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsBL
 表名:News(00050478)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
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
public static class clsNewsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsNewsEN GetObj(this K_Id_News_News myKey)
{
clsNewsEN objNewsEN = clsNewsBL.NewsDA.GetObjById_News(myKey.Value);
return objNewsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsNewsEN objNewsEN)
{
if (CheckUniqueness_NewsTitle_EditPeople(objNewsEN) == false)
{
var strMsg = string.Format("记录已经存在!信息标题 = [{0}],编辑人 = [{1}]的数据已经存在!(in clsNewsBL.AddNewRecord)", objNewsEN.NewsTitle,objNewsEN.EditPeople);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsNewsBL.NewsDA.AddNewRecordBySQL2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
public static bool AddRecordEx(this clsNewsEN objNewsEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objNewsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objNewsEN. CheckUniqueness_NewsTitle_EditPeople() == false)
{
strMsg = string.Format("(信息标题(NewsTitle)=[{0}],编辑人(EditPeople)=[{1}])已经存在，不能重复!", objNewsEN.NewsTitle, objNewsEN.EditPeople);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objNewsEN.AddNewRecord();
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsNewsEN objNewsEN)
{
if (CheckUniqueness_NewsTitle_EditPeople(objNewsEN) == false)
{
var strMsg = string.Format("记录已经存在!信息标题 = [{0}],编辑人 = [{1}]的数据已经存在!(in clsNewsBL.AddNewRecordWithReturnKey)", objNewsEN.NewsTitle,objNewsEN.EditPeople);
throw new Exception(strMsg);
}
try
{
string strKey = clsNewsBL.NewsDA.AddNewRecordBySQL2WithReturnKey(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetId_News(this clsNewsEN objNewsEN, long lngId_News, string strComparisonOp="")
	{
objNewsEN.Id_News = lngId_News; //Id_News
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Id_News) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Id_News, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Id_News] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsTypeId(this clsNewsEN objNewsEN, string strNewsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewsTypeId, conNews.NewsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewsTypeId, 1, conNews.NewsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strNewsTypeId, 1, conNews.NewsTypeId);
}
objNewsEN.NewsTypeId = strNewsTypeId; //信息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsTypeId) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsTypeId, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsTypeId] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsTitle(this clsNewsEN objNewsEN, string strNewsTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewsTitle, 50, conNews.NewsTitle);
}
objNewsEN.NewsTitle = strNewsTitle; //信息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsTitle) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsTitle, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsTitle] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsContent(this clsNewsEN objNewsEN, string strNewsContent, string strComparisonOp="")
	{
objNewsEN.NewsContent = strNewsContent; //信息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsContent) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsContent, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsContent] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetImgPath(this clsNewsEN objNewsEN, string strImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgPath, 500, conNews.ImgPath);
}
objNewsEN.ImgPath = strImgPath; //图片路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.ImgPath) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.ImgPath, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.ImgPath] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetEditPeople(this clsNewsEN objNewsEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, conNews.EditPeople);
}
objNewsEN.EditPeople = strEditPeople; //编辑人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.EditPeople) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.EditPeople, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.EditPeople] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetEditTime(this clsNewsEN objNewsEN, string strEditTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditTime, 20, conNews.EditTime);
}
objNewsEN.EditTime = strEditTime; //编辑时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.EditTime) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.EditTime, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.EditTime] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetSource(this clsNewsEN objNewsEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 50, conNews.Source);
}
objNewsEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Source) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Source, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Source] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetIsTop(this clsNewsEN objNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.IsTop) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.IsTop, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.IsTop] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetViews(this clsNewsEN objNewsEN, int intViews, string strComparisonOp="")
	{
objNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Views) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Views, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Views] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetAudit(this clsNewsEN objNewsEN, string strAudit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAudit, 1, conNews.Audit);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAudit, 1, conNews.Audit);
}
objNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Audit) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Audit, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Audit] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetIsDeleted(this clsNewsEN objNewsEN, bool bolIsDeleted, string strComparisonOp="")
	{
objNewsEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.IsDeleted) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.IsDeleted, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.IsDeleted] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetDeletedDate(this clsNewsEN objNewsEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, conNews.DeletedDate);
}
objNewsEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.DeletedDate) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.DeletedDate, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.DeletedDate] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetMemo(this clsNewsEN objNewsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conNews.Memo);
}
objNewsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Memo) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Memo, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Memo] = strComparisonOp;
}
}
return objNewsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objNewsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsNewsEN objNewsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objNewsEN.CheckPropertyNew();
clsNewsEN objNewsCond = new clsNewsEN();
string strCondition = objNewsCond
.SetId_News(objNewsEN.Id_News, "<>")
.SetNewsTitle(objNewsEN.NewsTitle, "=")
.SetEditPeople(objNewsEN.EditPeople, "=")
.GetCombineCondition();
objNewsEN._IsCheckProperty = true;
bool bolIsExist = clsNewsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(NewsTitle_EditPeople)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objNewsEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objNews">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsNewsEN objNews)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsNewsEN objNewsCond = new clsNewsEN();
string strCondition = objNewsCond
.SetNewsTitle(objNews.NewsTitle, "=")
.SetEditPeople(objNews.EditPeople, "=")
.GetCombineCondition();
objNews._IsCheckProperty = true;
bool bolIsExist = clsNewsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objNews.Id_News = clsNewsBL.GetFirstID_S(strCondition);
objNews.UpdateWithCondition(strCondition);
}
else
{
objNews.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsNewsEN objNewsEN)
{
 if (objNewsEN.Id_News == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsNewsBL.NewsDA.UpdateBySql2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsNewsEN objNewsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objNewsEN.Id_News == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsNewsBL.NewsDA.UpdateBySql2(objNewsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsNewsEN objNewsEN, string strWhereCond)
{
try
{
bool bolResult = clsNewsBL.NewsDA.UpdateBySqlWithCondition(objNewsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsNewsEN objNewsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsNewsBL.NewsDA.UpdateBySqlWithConditionTransaction(objNewsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsNewsEN objNewsEN)
{
try
{
int intRecNum = clsNewsBL.NewsDA.DelRecord(objNewsEN.Id_News);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsENS">源对象</param>
 /// <param name = "objNewsENT">目标对象</param>
 public static void CopyTo(this clsNewsEN objNewsENS, clsNewsEN objNewsENT)
{
try
{
objNewsENT.Id_News = objNewsENS.Id_News; //Id_News
objNewsENT.NewsTypeId = objNewsENS.NewsTypeId; //信息类型Id
objNewsENT.NewsTitle = objNewsENS.NewsTitle; //信息标题
objNewsENT.NewsContent = objNewsENS.NewsContent; //信息内容
objNewsENT.ImgPath = objNewsENS.ImgPath; //图片路径
objNewsENT.EditPeople = objNewsENS.EditPeople; //编辑人
objNewsENT.EditTime = objNewsENS.EditTime; //编辑时间
objNewsENT.Source = objNewsENS.Source; //来源
objNewsENT.IsTop = objNewsENS.IsTop; //是否置顶
objNewsENT.Views = objNewsENS.Views; //浏览量
objNewsENT.Audit = objNewsENS.Audit; //审核
objNewsENT.IsDeleted = objNewsENS.IsDeleted; //是否删除
objNewsENT.DeletedDate = objNewsENS.DeletedDate; //删除日期
objNewsENT.Memo = objNewsENS.Memo; //说明
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
 /// <param name = "objNewsENS">源对象</param>
 /// <returns>目标对象=>clsNewsEN:objNewsENT</returns>
 public static clsNewsEN CopyTo(this clsNewsEN objNewsENS)
{
try
{
 clsNewsEN objNewsENT = new clsNewsEN()
{
Id_News = objNewsENS.Id_News, //Id_News
NewsTypeId = objNewsENS.NewsTypeId, //信息类型Id
NewsTitle = objNewsENS.NewsTitle, //信息标题
NewsContent = objNewsENS.NewsContent, //信息内容
ImgPath = objNewsENS.ImgPath, //图片路径
EditPeople = objNewsENS.EditPeople, //编辑人
EditTime = objNewsENS.EditTime, //编辑时间
Source = objNewsENS.Source, //来源
IsTop = objNewsENS.IsTop, //是否置顶
Views = objNewsENS.Views, //浏览量
Audit = objNewsENS.Audit, //审核
IsDeleted = objNewsENS.IsDeleted, //是否删除
DeletedDate = objNewsENS.DeletedDate, //删除日期
Memo = objNewsENS.Memo, //说明
};
 return objNewsENT;
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
public static void CheckPropertyNew(this clsNewsEN objNewsEN)
{
 clsNewsBL.NewsDA.CheckPropertyNew(objNewsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsNewsEN objNewsEN)
{
 clsNewsBL.NewsDA.CheckProperty4Condition(objNewsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsNewsEN objNewsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objNewsCond.IsUpdated(conNews.Id_News) == true)
{
string strComparisonOpId_News = objNewsCond.dicFldComparisonOp[conNews.Id_News];
strWhereCond += string.Format(" And {0} {2} {1}", conNews.Id_News, objNewsCond.Id_News, strComparisonOpId_News);
}
if (objNewsCond.IsUpdated(conNews.NewsTypeId) == true)
{
string strComparisonOpNewsTypeId = objNewsCond.dicFldComparisonOp[conNews.NewsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.NewsTypeId, objNewsCond.NewsTypeId, strComparisonOpNewsTypeId);
}
if (objNewsCond.IsUpdated(conNews.NewsTitle) == true)
{
string strComparisonOpNewsTitle = objNewsCond.dicFldComparisonOp[conNews.NewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.NewsTitle, objNewsCond.NewsTitle, strComparisonOpNewsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理！
if (objNewsCond.IsUpdated(conNews.ImgPath) == true)
{
string strComparisonOpImgPath = objNewsCond.dicFldComparisonOp[conNews.ImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.ImgPath, objNewsCond.ImgPath, strComparisonOpImgPath);
}
if (objNewsCond.IsUpdated(conNews.EditPeople) == true)
{
string strComparisonOpEditPeople = objNewsCond.dicFldComparisonOp[conNews.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.EditPeople, objNewsCond.EditPeople, strComparisonOpEditPeople);
}
if (objNewsCond.IsUpdated(conNews.EditTime) == true)
{
string strComparisonOpEditTime = objNewsCond.dicFldComparisonOp[conNews.EditTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.EditTime, objNewsCond.EditTime, strComparisonOpEditTime);
}
if (objNewsCond.IsUpdated(conNews.Source) == true)
{
string strComparisonOpSource = objNewsCond.dicFldComparisonOp[conNews.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Source, objNewsCond.Source, strComparisonOpSource);
}
if (objNewsCond.IsUpdated(conNews.IsTop) == true)
{
if (objNewsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conNews.IsTop);
}
}
if (objNewsCond.IsUpdated(conNews.Views) == true)
{
string strComparisonOpViews = objNewsCond.dicFldComparisonOp[conNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", conNews.Views, objNewsCond.Views, strComparisonOpViews);
}
if (objNewsCond.IsUpdated(conNews.Audit) == true)
{
string strComparisonOpAudit = objNewsCond.dicFldComparisonOp[conNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Audit, objNewsCond.Audit, strComparisonOpAudit);
}
if (objNewsCond.IsUpdated(conNews.IsDeleted) == true)
{
if (objNewsCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", conNews.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conNews.IsDeleted);
}
}
if (objNewsCond.IsUpdated(conNews.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objNewsCond.dicFldComparisonOp[conNews.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.DeletedDate, objNewsCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objNewsCond.IsUpdated(conNews.Memo) == true)
{
string strComparisonOpMemo = objNewsCond.dicFldComparisonOp[conNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Memo, objNewsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--News(新闻), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_NewsTitle_EditPeople(this clsNewsEN objNewsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objNewsEN == null) return true;
if (objNewsEN.Id_News == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objNewsEN.NewsTitle == null)
{
 sbCondition.AppendFormat(" and NewsTitle is null", objNewsEN.NewsTitle);
}
else
{
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
}
 if (objNewsEN.EditPeople == null)
{
 sbCondition.AppendFormat(" and EditPeople is null", objNewsEN.EditPeople);
}
else
{
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
}
if (clsNewsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("Id_News !=  {0}", objNewsEN.Id_News);
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
if (clsNewsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--News(新闻), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrNewsTitle_EditPeople(this clsNewsEN objNewsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objNewsEN == null) return "";
if (objNewsEN.Id_News == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objNewsEN.NewsTitle == null)
{
 sbCondition.AppendFormat(" and NewsTitle is null", objNewsEN.NewsTitle);
}
else
{
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
}
 if (objNewsEN.EditPeople == null)
{
 sbCondition.AppendFormat(" and EditPeople is null", objNewsEN.EditPeople);
}
else
{
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_News !=  {0}", objNewsEN.Id_News);
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_News
{
public virtual bool UpdRelaTabDate(long lngId_News, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 新闻(News)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsNewsBL
{
public static RelatedActions_News relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "NewsListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "NewsList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsNewsEN> arrNewsObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsNewsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsNewsDA NewsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsNewsDA();
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
 public clsNewsBL()
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
if (string.IsNullOrEmpty(clsNewsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsNewsEN._ConnectString);
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
objDS = NewsDA.GetDataSet(strWhereCond);
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
objDS = NewsDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = NewsDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_News(string strWhereCond)
{
DataTable objDT;
try
{
objDT = NewsDA.GetDataTable_News(strWhereCond);
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
objDT = NewsDA.GetDataTable(strWhereCond);
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
objDT = NewsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = NewsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = NewsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = NewsDA.GetDataTable_Top(objTopPara);
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
objDT = NewsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = NewsDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = NewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = NewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = NewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = NewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = NewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = NewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrId_NewsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsNewsEN> GetObjLstById_NewsLst(List<long> arrId_NewsLst)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_NewsLst);
 string strWhereCond = string.Format("Id_News in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrId_NewsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsNewsEN> GetObjLstById_NewsLstCache(List<long> arrId_NewsLst)
{
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLstCache = GetObjLstCache();
IEnumerable <clsNewsEN> arrNewsObjLst_Sel =
arrNewsObjLstCache
.Where(x => arrId_NewsLst.Contains(x.Id_News));
return arrNewsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetObjLst(string strWhereCond)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static List<clsNewsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsNewsEN> GetSubObjLstCache(clsNewsEN objNewsCond)
{
List<clsNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conNews.AttributeName)
{
if (objNewsCond.IsUpdated(strFldName) == false) continue;
if (objNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else
{
if (objNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
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
public static List<clsNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static List<clsNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
List<clsNewsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsNewsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
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
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static List<clsNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static List<clsNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static IEnumerable<clsNewsEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsNewsEN objNewsCond, string strOrderBy)
{
List<clsNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conNews.AttributeName)
{
if (objNewsCond.IsUpdated(strFldName) == false) continue;
if (objNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else
{
if (objNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
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
public static IEnumerable<clsNewsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsNewsEN objNewsCond = JsonConvert.DeserializeObject<clsNewsEN>(objPagerPara.whereCond);
if (objNewsCond.sfFldComparisonOp == null)
{
objNewsCond.dicFldComparisonOp = null;
}
else
{
objNewsCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objNewsCond.sfFldComparisonOp);
}
clsNewsBL.SetUpdFlag(objNewsCond);
 try
{
CheckProperty4Condition(objNewsCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsNewsBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objNewsCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsNewsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
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
public static List<clsNewsEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsNewsEN> arrObjLst = new List<clsNewsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsNewsEN objNewsEN = new clsNewsEN();
try
{
objNewsEN.Id_News = Int32.Parse(objRow[conNews.Id_News].ToString().Trim()); //Id_News
objNewsEN.NewsTypeId = objRow[conNews.NewsTypeId].ToString().Trim(); //信息类型Id
objNewsEN.NewsTitle = objRow[conNews.NewsTitle] == DBNull.Value ? null : objRow[conNews.NewsTitle].ToString().Trim(); //信息标题
objNewsEN.NewsContent = objRow[conNews.NewsContent] == DBNull.Value ? null : objRow[conNews.NewsContent].ToString().Trim(); //信息内容
objNewsEN.ImgPath = objRow[conNews.ImgPath] == DBNull.Value ? null : objRow[conNews.ImgPath].ToString().Trim(); //图片路径
objNewsEN.EditPeople = objRow[conNews.EditPeople] == DBNull.Value ? null : objRow[conNews.EditPeople].ToString().Trim(); //编辑人
objNewsEN.EditTime = objRow[conNews.EditTime] == DBNull.Value ? null : objRow[conNews.EditTime].ToString().Trim(); //编辑时间
objNewsEN.Source = objRow[conNews.Source] == DBNull.Value ? null : objRow[conNews.Source].ToString().Trim(); //来源
objNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsTop].ToString().Trim()); //是否置顶
objNewsEN.Views = objRow[conNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conNews.Views].ToString().Trim()); //浏览量
objNewsEN.Audit = objRow[conNews.Audit] == DBNull.Value ? null : objRow[conNews.Audit].ToString().Trim(); //审核
objNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conNews.IsDeleted].ToString().Trim()); //是否删除
objNewsEN.DeletedDate = objRow[conNews.DeletedDate] == DBNull.Value ? null : objRow[conNews.DeletedDate].ToString().Trim(); //删除日期
objNewsEN.Memo = objRow[conNews.Memo] == DBNull.Value ? null : objRow[conNews.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objNewsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objNewsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetNews(ref clsNewsEN objNewsEN)
{
bool bolResult = NewsDA.GetNews(ref objNewsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsNewsEN GetObjById_News(long lngId_News)
{
clsNewsEN objNewsEN = NewsDA.GetObjById_News(lngId_News);
return objNewsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsNewsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsNewsEN objNewsEN = NewsDA.GetFirstObj(strWhereCond);
 return objNewsEN;
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
public static clsNewsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsNewsEN objNewsEN = NewsDA.GetObjByDataRow(objRow);
 return objNewsEN;
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
public static clsNewsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsNewsEN objNewsEN = NewsDA.GetObjByDataRow(objRow);
 return objNewsEN;
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
 /// <param name = "lngId_News">所给的关键字</param>
 /// <param name = "lstNewsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsNewsEN GetObjById_NewsFromList(long lngId_News, List<clsNewsEN> lstNewsObjLst)
{
foreach (clsNewsEN objNewsEN in lstNewsObjLst)
{
if (objNewsEN.Id_News == lngId_News)
{
return objNewsEN;
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
 long lngId_News;
 try
 {
 lngId_News = new clsNewsDA().GetFirstID(strWhereCond);
 return lngId_News;
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
 arrList = NewsDA.GetID(strWhereCond);
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
bool bolIsExist = NewsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngId_News)
{
//检测记录是否存在
bool bolIsExist = NewsDA.IsExist(lngId_News);
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
 bolIsExist = clsNewsDA.IsExistTable();
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
 bolIsExist = NewsDA.IsExistTable(strTabName);
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsNewsEN objNewsEN)
{
if (objNewsEN.CheckUniqueness_NewsTitle_EditPeople() == false)
{
var strMsg = string.Format("记录已经存在!信息标题 = [{0}],编辑人 = [{1}]的数据已经存在!(in clsNewsBL.AddNewRecordBySql2)", objNewsEN.NewsTitle,objNewsEN.EditPeople);
throw new Exception(strMsg);
}
try
{
bool bolResult = NewsDA.AddNewRecordBySQL2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsNewsEN objNewsEN)
{
if (objNewsEN.CheckUniqueness_NewsTitle_EditPeople() == false)
{
var strMsg = string.Format("记录已经存在!信息标题 = [{0}],编辑人 = [{1}]的数据已经存在!(in clsNewsBL.AddNewRecordBySql2WithReturnKey)", objNewsEN.NewsTitle,objNewsEN.EditPeople);
throw new Exception(strMsg);
}
try
{
string strKey = NewsDA.AddNewRecordBySQL2WithReturnKey(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strNewsObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strNewsObjXml)
{
clsNewsEN objNewsEN = GetObjFromXmlStr(strNewsObjXml);
try
{
bool bolResult = NewsDA.AddNewRecordBySQL2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsNewsEN objNewsEN)
{
try
{
bool bolResult = NewsDA.Update(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsNewsEN objNewsEN)
{
 if (objNewsEN.Id_News == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = NewsDA.UpdateBySql2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strNewsObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strNewsObjXml)
{
clsNewsEN objNewsEN = GetObjFromXmlStr(strNewsObjXml);
try
{
bool bolResult = NewsDA.UpdateBySql2(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsBL.ReFreshCache();

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngId_News)
{
try
{
 clsNewsEN objNewsEN = clsNewsBL.GetObjById_News(lngId_News);

if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(objNewsEN.Id_News, "SetUpdDate");
}
if (objNewsEN != null)
{
int intRecNum = NewsDA.DelRecord(lngId_News);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngId_News">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngId_News )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsNewsDA.GetSpecSQLObj();
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
//删除与表:[News]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conNews.Id_News,
//lngId_News);
//        clsNewsBL.DelNewssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsNewsBL.DelRecord(lngId_News, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsNewsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngId_News, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngId_News, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(lngId_News, "UpdRelaTabDate");
}
bool bolResult = NewsDA.DelRecord(lngId_News,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngId_News) 
{
try
{
if (clsNewsBL.relatedActions != null)
{
clsNewsBL.relatedActions.UpdRelaTabDate(lngId_News, "UpdRelaTabDate");
}
bool bolResult = NewsDA.DelRecordBySP(lngId_News);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrId_NewsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelNewss(List<string> arrId_NewsLst)
{
if (arrId_NewsLst.Count == 0) return 0;
try
{
if (clsNewsBL.relatedActions != null)
{
foreach (var strId_News in arrId_NewsLst)
{
long lngId_News = long.Parse(strId_News);
clsNewsBL.relatedActions.UpdRelaTabDate(lngId_News, "UpdRelaTabDate");
}
}
int intDelRecNum = NewsDA.DelNews(arrId_NewsLst);
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
public static int DelNewssByCond(string strWhereCond)
{
try
{
if (clsNewsBL.relatedActions != null)
{
List<string> arrId_News = GetPrimaryKeyID_S(strWhereCond);
foreach (var strId_News in arrId_News)
{
long lngId_News = long.Parse(strId_News);
clsNewsBL.relatedActions.UpdRelaTabDate(lngId_News, "UpdRelaTabDate");
}
}
int intRecNum = NewsDA.DelNews(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[News]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngId_News">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngId_News)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsNewsDA.GetSpecSQLObj();
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
//删除与表:[News]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsNewsBL.DelRecord(lngId_News, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsNewsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngId_News, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objNewsENS">源对象</param>
 /// <param name = "objNewsENT">目标对象</param>
 public static void CopyTo(clsNewsEN objNewsENS, clsNewsEN objNewsENT)
{
try
{
objNewsENT.Id_News = objNewsENS.Id_News; //Id_News
objNewsENT.NewsTypeId = objNewsENS.NewsTypeId; //信息类型Id
objNewsENT.NewsTitle = objNewsENS.NewsTitle; //信息标题
objNewsENT.NewsContent = objNewsENS.NewsContent; //信息内容
objNewsENT.ImgPath = objNewsENS.ImgPath; //图片路径
objNewsENT.EditPeople = objNewsENS.EditPeople; //编辑人
objNewsENT.EditTime = objNewsENS.EditTime; //编辑时间
objNewsENT.Source = objNewsENS.Source; //来源
objNewsENT.IsTop = objNewsENS.IsTop; //是否置顶
objNewsENT.Views = objNewsENS.Views; //浏览量
objNewsENT.Audit = objNewsENS.Audit; //审核
objNewsENT.IsDeleted = objNewsENS.IsDeleted; //是否删除
objNewsENT.DeletedDate = objNewsENS.DeletedDate; //删除日期
objNewsENT.Memo = objNewsENS.Memo; //说明
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
 /// <param name = "objNewsEN">源简化对象</param>
 public static void SetUpdFlag(clsNewsEN objNewsEN)
{
try
{
objNewsEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objNewsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conNews.Id_News, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.Id_News = objNewsEN.Id_News; //Id_News
}
if (arrFldSet.Contains(conNews.NewsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.NewsTypeId = objNewsEN.NewsTypeId; //信息类型Id
}
if (arrFldSet.Contains(conNews.NewsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.NewsTitle = objNewsEN.NewsTitle == "[null]" ? null :  objNewsEN.NewsTitle; //信息标题
}
if (arrFldSet.Contains(conNews.NewsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.NewsContent = objNewsEN.NewsContent == "[null]" ? null :  objNewsEN.NewsContent; //信息内容
}
if (arrFldSet.Contains(conNews.ImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.ImgPath = objNewsEN.ImgPath == "[null]" ? null :  objNewsEN.ImgPath; //图片路径
}
if (arrFldSet.Contains(conNews.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.EditPeople = objNewsEN.EditPeople == "[null]" ? null :  objNewsEN.EditPeople; //编辑人
}
if (arrFldSet.Contains(conNews.EditTime, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.EditTime = objNewsEN.EditTime == "[null]" ? null :  objNewsEN.EditTime; //编辑时间
}
if (arrFldSet.Contains(conNews.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.Source = objNewsEN.Source == "[null]" ? null :  objNewsEN.Source; //来源
}
if (arrFldSet.Contains(conNews.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.IsTop = objNewsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(conNews.Views, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.Views = objNewsEN.Views; //浏览量
}
if (arrFldSet.Contains(conNews.Audit, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.Audit = objNewsEN.Audit == "[null]" ? null :  objNewsEN.Audit; //审核
}
if (arrFldSet.Contains(conNews.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.IsDeleted = objNewsEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(conNews.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.DeletedDate = objNewsEN.DeletedDate == "[null]" ? null :  objNewsEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(conNews.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objNewsEN.Memo = objNewsEN.Memo == "[null]" ? null :  objNewsEN.Memo; //说明
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
 /// <param name = "objNewsEN">源简化对象</param>
 public static void AccessFldValueNull(clsNewsEN objNewsEN)
{
try
{
if (objNewsEN.NewsTitle == "[null]") objNewsEN.NewsTitle = null; //信息标题
if (objNewsEN.NewsContent == "[null]") objNewsEN.NewsContent = null; //信息内容
if (objNewsEN.ImgPath == "[null]") objNewsEN.ImgPath = null; //图片路径
if (objNewsEN.EditPeople == "[null]") objNewsEN.EditPeople = null; //编辑人
if (objNewsEN.EditTime == "[null]") objNewsEN.EditTime = null; //编辑时间
if (objNewsEN.Source == "[null]") objNewsEN.Source = null; //来源
if (objNewsEN.Audit == "[null]") objNewsEN.Audit = null; //审核
if (objNewsEN.DeletedDate == "[null]") objNewsEN.DeletedDate = null; //删除日期
if (objNewsEN.Memo == "[null]") objNewsEN.Memo = null; //说明
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsNewsEN objNewsEN)
{
 NewsDA.CheckPropertyNew(objNewsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsNewsEN objNewsEN)
{
 NewsDA.CheckProperty4Condition(objNewsEN);
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
if (clsNewsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsNewsBL没有刷新缓存机制(clsNewsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_News");
//if (arrNewsObjLstCache == null)
//{
//arrNewsObjLstCache = NewsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngId_News">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsNewsEN GetObjById_NewsCache(long lngId_News)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLstCache = GetObjLstCache();
IEnumerable <clsNewsEN> arrNewsObjLst_Sel =
arrNewsObjLstCache
.Where(x=> x.Id_News == lngId_News 
);
if (arrNewsObjLst_Sel.Count() == 0)
{
   clsNewsEN obj = clsNewsBL.GetObjById_News(lngId_News);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrNewsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsNewsEN> GetAllNewsObjLstCache()
{
//获取缓存中的对象列表
List<clsNewsEN> arrNewsObjLstCache = GetObjLstCache(); 
return arrNewsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsNewsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrNewsObjLstCache;
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
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsNewsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsNewsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--News(新闻)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrNewsTitle_EditPeople(clsNewsEN objNewsEN)
{
//检测记录是否存在
string strResult = NewsDA.GetUniCondStrNewsTitle_EditPeople(objNewsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstNewsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsNewsEN> lstNewsObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstNewsObjLst, writer);
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
 /// <param name = "lstNewsObjLst">[clsNewsEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsNewsEN> lstNewsObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsNewsBL.listXmlNode);
writer.WriteStartElement(clsNewsBL.itemsXmlNode);
foreach (clsNewsEN objNewsEN in lstNewsObjLst)
{
clsNewsBL.SerializeXML(writer, objNewsEN);
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
 /// <param name = "objNewsEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsNewsEN objNewsEN)
{
writer.WriteStartElement(clsNewsBL.itemXmlNode);
 
writer.WriteElementString(conNews.Id_News, objNewsEN.Id_News.ToString(CultureInfo.InvariantCulture));
 
if (objNewsEN.NewsTypeId != null)
{
writer.WriteElementString(conNews.NewsTypeId, objNewsEN.NewsTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.NewsTitle != null)
{
writer.WriteElementString(conNews.NewsTitle, objNewsEN.NewsTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.NewsContent != null)
{
writer.WriteElementString(conNews.NewsContent, objNewsEN.NewsContent.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.ImgPath != null)
{
writer.WriteElementString(conNews.ImgPath, objNewsEN.ImgPath.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.EditPeople != null)
{
writer.WriteElementString(conNews.EditPeople, objNewsEN.EditPeople.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.EditTime != null)
{
writer.WriteElementString(conNews.EditTime, objNewsEN.EditTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.Source != null)
{
writer.WriteElementString(conNews.Source, objNewsEN.Source.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conNews.IsTop, objNewsEN.IsTop.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conNews.Views, objNewsEN.Views.ToString());
 
if (objNewsEN.Audit != null)
{
writer.WriteElementString(conNews.Audit, objNewsEN.Audit.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conNews.IsDeleted, objNewsEN.IsDeleted.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objNewsEN.DeletedDate != null)
{
writer.WriteElementString(conNews.DeletedDate, objNewsEN.DeletedDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objNewsEN.Memo != null)
{
writer.WriteElementString(conNews.Memo, objNewsEN.Memo.ToString(CultureInfo.InvariantCulture));
}
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
public static clsNewsEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsNewsEN objNewsEN = new clsNewsEN();
reader.Read();
while (!(reader.Name == clsNewsBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conNews.Id_News))
{
objNewsEN.Id_News = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conNews.NewsTypeId))
{
objNewsEN.NewsTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.NewsTitle))
{
objNewsEN.NewsTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.NewsContent))
{
objNewsEN.NewsContent = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.ImgPath))
{
objNewsEN.ImgPath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.EditPeople))
{
objNewsEN.EditPeople = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.EditTime))
{
objNewsEN.EditTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.Source))
{
objNewsEN.Source = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.IsTop))
{
objNewsEN.IsTop = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conNews.Views))
{
objNewsEN.Views = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conNews.Audit))
{
objNewsEN.Audit = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.IsDeleted))
{
objNewsEN.IsDeleted = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conNews.DeletedDate))
{
objNewsEN.DeletedDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conNews.Memo))
{
objNewsEN.Memo = reader.ReadElementContentAsString();
}
}
return objNewsEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strNewsObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsNewsEN GetObjFromXmlStr(string strNewsObjXmlStr)
{
clsNewsEN objNewsEN = new clsNewsEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strNewsObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsNewsBL.itemXmlNode))
{
objNewsEN = GetObjFromXml(reader);
return objNewsEN;
}
}
return objNewsEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objNewsEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsNewsEN objNewsEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objNewsEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngId_News)
{
if (strInFldName != conNews.Id_News)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conNews.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conNews.AttributeName));
throw new Exception(strMsg);
}
var objNews = clsNewsBL.GetObjById_NewsCache(lngId_News);
if (objNews == null) return "";
return objNews[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objNewsEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsNewsEN objNewsEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsNewsEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objNewsEN[strField]);
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
 /// <param name = "lstNewsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsNewsEN> lstNewsObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstNewsObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsNewsEN objNewsEN in lstNewsObjLst)
{
string strJSON_One = SerializeObjToJSON(objNewsEN);
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
int intRecCount = clsNewsDA.GetRecCount(strTabName);
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
int intRecCount = clsNewsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsNewsDA.GetRecCount();
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
int intRecCount = clsNewsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsNewsEN objNewsCond)
{
List<clsNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conNews.AttributeName)
{
if (objNewsCond.IsUpdated(strFldName) == false) continue;
if (objNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else
{
if (objNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objNewsCond[strFldName]));
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
 List<string> arrList = clsNewsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = NewsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = NewsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = NewsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsNewsDA.SetFldValue(clsNewsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = NewsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsNewsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsNewsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsNewsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[News] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Id_News*/ 
 strCreateTabCode.Append(" Id_News bigint primary key identity, "); 
 // /**信息类型Id*/ 
 strCreateTabCode.Append(" NewsTypeId char(1) not Null, "); 
 // /**信息标题*/ 
 strCreateTabCode.Append(" NewsTitle varchar(50) Null, "); 
 // /**信息内容*/ 
 strCreateTabCode.Append(" NewsContent text Null, "); 
 // /**图片路径*/ 
 strCreateTabCode.Append(" ImgPath varchar(500) Null, "); 
 // /**编辑人*/ 
 strCreateTabCode.Append(" EditPeople varchar(50) Null, "); 
 // /**编辑时间*/ 
 strCreateTabCode.Append(" EditTime varchar(20) Null, "); 
 // /**来源*/ 
 strCreateTabCode.Append(" Source varchar(50) Null, "); 
 // /**是否置顶*/ 
 strCreateTabCode.Append(" IsTop bit Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" Views int Null, "); 
 // /**审核*/ 
 strCreateTabCode.Append(" Audit char(1) Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDeleted bit Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" DeletedDate varchar(50) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 新闻(News)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4News : clsCommFun4BL
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
clsNewsBL.ReFreshThisCache();
}
}

}