
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureRegionFldsBL
 表名:FeatureRegionFlds(00050452)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理(RegionManage)
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
public static class  clsFeatureRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureRegionFldsEN GetObj(this K_ViewFeatureId_FeatureRegionFlds myKey)
{
clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.FeatureRegionFldsDA.GetObjByViewFeatureId(myKey.Value);
return objFeatureRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],按钮名称 = [{1}],功能Id = [{2}]的数据已经存在!(in clsFeatureRegionFldsBL.AddNewRecord)", objFeatureRegionFldsEN.RegionId,objFeatureRegionFldsEN.ButtonName,objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
bool bolResult = clsFeatureRegionFldsBL.FeatureRegionFldsDA.AddNewRecordBySQL2(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFeatureRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFeatureRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],按钮名称(ButtonName)=[{1}],功能Id(FeatureId)=[{2}])已经存在,不能重复!", objFeatureRegionFldsEN.RegionId, objFeatureRegionFldsEN.ButtonName, objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFeatureRegionFldsEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],按钮名称 = [{1}],功能Id = [{2}]的数据已经存在!(in clsFeatureRegionFldsBL.AddNewRecordWithMaxId)", objFeatureRegionFldsEN.RegionId,objFeatureRegionFldsEN.ButtonName,objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
string strViewFeatureId = clsFeatureRegionFldsBL.FeatureRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objFeatureRegionFldsEN);
     objFeatureRegionFldsEN.ViewFeatureId = strViewFeatureId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
}
return strViewFeatureId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFeatureRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],按钮名称 = [{1}],功能Id = [{2}]的数据已经存在!(in clsFeatureRegionFldsBL.AddNewRecordWithReturnKey)", objFeatureRegionFldsEN.RegionId,objFeatureRegionFldsEN.ButtonName,objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
string strKey = clsFeatureRegionFldsBL.FeatureRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetViewFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strViewFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewFeatureId, 8, conFeatureRegionFlds.ViewFeatureId);
}
objFeatureRegionFldsEN.ViewFeatureId = strViewFeatureId; //界面功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ViewFeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ViewFeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ViewFeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetRegionId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conFeatureRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conFeatureRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conFeatureRegionFlds.RegionId);
}
objFeatureRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.RegionId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.RegionId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.RegionId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFeatureRegionFlds.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFeatureRegionFlds.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFeatureRegionFlds.FeatureId);
}
objFeatureRegionFldsEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetTabFeatureId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, conFeatureRegionFlds.TabFeatureId);
}
objFeatureRegionFldsEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.TabFeatureId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.TabFeatureId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.TabFeatureId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCheckTabFeature(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCheckTabFeature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckTabFeature, 50, conFeatureRegionFlds.CheckTabFeature);
}
objFeatureRegionFldsEN.CheckTabFeature = strCheckTabFeature; //检查表功能
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CheckTabFeature) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CheckTabFeature, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CheckTabFeature] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFeatureDescription(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, conFeatureRegionFlds.FeatureDescription);
}
objFeatureRegionFldsEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FeatureDescription) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FeatureDescription, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FeatureDescription] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetButtonName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, conFeatureRegionFlds.ButtonName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, conFeatureRegionFlds.ButtonName);
}
objFeatureRegionFldsEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ButtonName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ButtonName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ButtonName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetButtonName4Mvc(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strButtonName4Mvc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName4Mvc, conFeatureRegionFlds.ButtonName4Mvc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName4Mvc, 30, conFeatureRegionFlds.ButtonName4Mvc);
}
objFeatureRegionFldsEN.ButtonName4Mvc = strButtonName4Mvc; //按钮名称4Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ButtonName4Mvc) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ButtonName4Mvc, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ButtonName4Mvc] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCommandName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCommandName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommandName, 30, conFeatureRegionFlds.CommandName);
}
objFeatureRegionFldsEN.CommandName = strCommandName; //命令名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CommandName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CommandName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CommandName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetValueGivingModeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, conFeatureRegionFlds.ValueGivingModeId);
}
objFeatureRegionFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ValueGivingModeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFuncName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, conFeatureRegionFlds.FuncName);
}
objFeatureRegionFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FuncName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FuncName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FuncName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetDefaultValue(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conFeatureRegionFlds.DefaultValue);
}
objFeatureRegionFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.DefaultValue) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.DefaultValue, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.DefaultValue] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetKeyIdGetModeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, conFeatureRegionFlds.KeyIdGetModeId);
}
objFeatureRegionFldsEN.KeyIdGetModeId = strKeyIdGetModeId; //GC关键字获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.KeyIdGetModeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.KeyIdGetModeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.KeyIdGetModeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetText(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, conFeatureRegionFlds.Text);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, conFeatureRegionFlds.Text);
}
objFeatureRegionFldsEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Text) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Text, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Text] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetGroupName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, conFeatureRegionFlds.GroupName);
}
objFeatureRegionFldsEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.GroupName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.GroupName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.GroupName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetReleTabId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strReleTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReleTabId, conFeatureRegionFlds.ReleTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleTabId, 8, conFeatureRegionFlds.ReleTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleTabId, 8, conFeatureRegionFlds.ReleTabId);
}
objFeatureRegionFldsEN.ReleTabId = strReleTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ReleTabId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ReleTabId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ReleTabId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetReleFldId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strReleFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReleFldId, 8, conFeatureRegionFlds.ReleFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReleFldId, 8, conFeatureRegionFlds.ReleFldId);
}
objFeatureRegionFldsEN.ReleFldId = strReleFldId; //相关字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ReleFldId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ReleFldId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ReleFldId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetEventFuncName(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strEventFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, conFeatureRegionFlds.EventFuncName);
}
objFeatureRegionFldsEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.EventFuncName) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.EventFuncName, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.EventFuncName] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetFieldTypeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conFeatureRegionFlds.FieldTypeId);
}
objFeatureRegionFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.FieldTypeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.FieldTypeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.FieldTypeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetViewImplId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, conFeatureRegionFlds.ViewImplId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, conFeatureRegionFlds.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, conFeatureRegionFlds.ViewImplId);
}
objFeatureRegionFldsEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ViewImplId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ViewImplId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ViewImplId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCtlTypeId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conFeatureRegionFlds.CtlTypeId);
}
objFeatureRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CtlTypeId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetHeight(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int? intHeight, string strComparisonOp="")
	{
objFeatureRegionFldsEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Height) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Height, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Height] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetWidth(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int? intWidth, string strComparisonOp="")
	{
objFeatureRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Width) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Width, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Width] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetSeqNum(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, int? intSeqNum, string strComparisonOp="")
	{
objFeatureRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.SeqNum) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.SeqNum, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.SeqNum] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetCssClass(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strCssClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCssClass, 50, conFeatureRegionFlds.CssClass);
}
objFeatureRegionFldsEN.CssClass = strCssClass; //样式表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.CssClass) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.CssClass, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.CssClass] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetImageUrl(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conFeatureRegionFlds.ImageUrl);
}
objFeatureRegionFldsEN.ImageUrl = strImageUrl; //图片资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ImageUrl) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ImageUrl, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ImageUrl] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetInUse(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objFeatureRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.InUse) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.InUse, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.InUse] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetErrMsg(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conFeatureRegionFlds.ErrMsg);
}
objFeatureRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.ErrMsg) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetPrjId(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFeatureRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFeatureRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFeatureRegionFlds.PrjId);
}
objFeatureRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.PrjId) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.PrjId, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.PrjId] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetUpdUser(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conFeatureRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFeatureRegionFlds.UpdUser);
}
objFeatureRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.UpdUser) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.UpdUser, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.UpdUser] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetUpdDate(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFeatureRegionFlds.UpdDate);
}
objFeatureRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.UpdDate) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.UpdDate, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.UpdDate] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureRegionFldsEN SetMemo(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFeatureRegionFlds.Memo);
}
objFeatureRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureRegionFldsEN.dicFldComparisonOp.ContainsKey(conFeatureRegionFlds.Memo) == false)
{
objFeatureRegionFldsEN.dicFldComparisonOp.Add(conFeatureRegionFlds.Memo, strComparisonOp);
}
else
{
objFeatureRegionFldsEN.dicFldComparisonOp[conFeatureRegionFlds.Memo] = strComparisonOp;
}
}
return objFeatureRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFeatureRegionFldsEN.CheckPropertyNew();
clsFeatureRegionFldsEN objFeatureRegionFldsCond = new clsFeatureRegionFldsEN();
string strCondition = objFeatureRegionFldsCond
.SetViewFeatureId(objFeatureRegionFldsEN.ViewFeatureId, "<>")
.SetRegionId(objFeatureRegionFldsEN.RegionId, "=")
.SetButtonName(objFeatureRegionFldsEN.ButtonName, "=")
.SetFeatureId(objFeatureRegionFldsEN.FeatureId, "=")
.GetCombineCondition();
objFeatureRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsFeatureRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(在功能区域，的同一个功能，只能有一个唯一的按钮名)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFeatureRegionFldsEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objFeatureRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFeatureRegionFldsEN objFeatureRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFeatureRegionFldsEN objFeatureRegionFldsCond = new clsFeatureRegionFldsEN();
string strCondition = objFeatureRegionFldsCond
.SetRegionId(objFeatureRegionFlds.RegionId, "=")
.SetButtonName(objFeatureRegionFlds.ButtonName, "=")
.SetFeatureId(objFeatureRegionFlds.FeatureId, "=")
.GetCombineCondition();
objFeatureRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsFeatureRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFeatureRegionFlds.ViewFeatureId = clsFeatureRegionFldsBL.GetFirstID_S(strCondition);
objFeatureRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objFeatureRegionFlds.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
objFeatureRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureRegionFldsBL.FeatureRegionFldsDA.UpdateBySql2(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFeatureRegionFldsBL.FeatureRegionFldsDA.UpdateBySql2(objFeatureRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsFeatureRegionFldsBL.FeatureRegionFldsDA.UpdateBySqlWithCondition(objFeatureRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureRegionFldsEN objFeatureRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFeatureRegionFldsBL.FeatureRegionFldsDA.UpdateBySqlWithConditionTransaction(objFeatureRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
int intRecNum = clsFeatureRegionFldsBL.FeatureRegionFldsDA.DelRecord(objFeatureRegionFldsEN.ViewFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsENS">源对象</param>
 /// <param name = "objFeatureRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsFeatureRegionFldsEN objFeatureRegionFldsENS, clsFeatureRegionFldsEN objFeatureRegionFldsENT)
{
try
{
objFeatureRegionFldsENT.ViewFeatureId = objFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objFeatureRegionFldsENT.RegionId = objFeatureRegionFldsENS.RegionId; //区域Id
objFeatureRegionFldsENT.FeatureId = objFeatureRegionFldsENS.FeatureId; //功能Id
objFeatureRegionFldsENT.TabFeatureId = objFeatureRegionFldsENS.TabFeatureId; //表功能Id
objFeatureRegionFldsENT.CheckTabFeature = objFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objFeatureRegionFldsENT.FeatureDescription = objFeatureRegionFldsENS.FeatureDescription; //功能说明
objFeatureRegionFldsENT.ButtonName = objFeatureRegionFldsENS.ButtonName; //按钮名称
objFeatureRegionFldsENT.ButtonName4Mvc = objFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objFeatureRegionFldsENT.CommandName = objFeatureRegionFldsENS.CommandName; //命令名
objFeatureRegionFldsENT.ValueGivingModeId = objFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objFeatureRegionFldsENT.FuncName = objFeatureRegionFldsENS.FuncName; //函数名
objFeatureRegionFldsENT.DefaultValue = objFeatureRegionFldsENS.DefaultValue; //缺省值
objFeatureRegionFldsENT.KeyIdGetModeId = objFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objFeatureRegionFldsENT.Text = objFeatureRegionFldsENS.Text; //文本
objFeatureRegionFldsENT.GroupName = objFeatureRegionFldsENS.GroupName; //组名
objFeatureRegionFldsENT.ReleTabId = objFeatureRegionFldsENS.ReleTabId; //相关表Id
objFeatureRegionFldsENT.ReleFldId = objFeatureRegionFldsENS.ReleFldId; //相关字段Id
objFeatureRegionFldsENT.EventFuncName = objFeatureRegionFldsENS.EventFuncName; //事件函数名
objFeatureRegionFldsENT.FieldTypeId = objFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objFeatureRegionFldsENT.ViewImplId = objFeatureRegionFldsENS.ViewImplId; //界面实现Id
objFeatureRegionFldsENT.CtlTypeId = objFeatureRegionFldsENS.CtlTypeId; //控件类型号
objFeatureRegionFldsENT.Height = objFeatureRegionFldsENS.Height; //高度
objFeatureRegionFldsENT.Width = objFeatureRegionFldsENS.Width; //宽
objFeatureRegionFldsENT.SeqNum = objFeatureRegionFldsENS.SeqNum; //字段序号
objFeatureRegionFldsENT.CssClass = objFeatureRegionFldsENS.CssClass; //样式表
objFeatureRegionFldsENT.ImageUrl = objFeatureRegionFldsENS.ImageUrl; //图片资源
objFeatureRegionFldsENT.InUse = objFeatureRegionFldsENS.InUse; //是否在用
objFeatureRegionFldsENT.ErrMsg = objFeatureRegionFldsENS.ErrMsg; //错误信息
objFeatureRegionFldsENT.PrjId = objFeatureRegionFldsENS.PrjId; //工程Id
objFeatureRegionFldsENT.UpdUser = objFeatureRegionFldsENS.UpdUser; //修改者
objFeatureRegionFldsENT.UpdDate = objFeatureRegionFldsENS.UpdDate; //修改日期
objFeatureRegionFldsENT.Memo = objFeatureRegionFldsENS.Memo; //说明
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
 /// <param name = "objFeatureRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsFeatureRegionFldsEN:objFeatureRegionFldsENT</returns>
 public static clsFeatureRegionFldsEN CopyTo(this clsFeatureRegionFldsEN objFeatureRegionFldsENS)
{
try
{
 clsFeatureRegionFldsEN objFeatureRegionFldsENT = new clsFeatureRegionFldsEN()
{
ViewFeatureId = objFeatureRegionFldsENS.ViewFeatureId, //界面功能Id
RegionId = objFeatureRegionFldsENS.RegionId, //区域Id
FeatureId = objFeatureRegionFldsENS.FeatureId, //功能Id
TabFeatureId = objFeatureRegionFldsENS.TabFeatureId, //表功能Id
CheckTabFeature = objFeatureRegionFldsENS.CheckTabFeature, //检查表功能
FeatureDescription = objFeatureRegionFldsENS.FeatureDescription, //功能说明
ButtonName = objFeatureRegionFldsENS.ButtonName, //按钮名称
ButtonName4Mvc = objFeatureRegionFldsENS.ButtonName4Mvc, //按钮名称4Mvc
CommandName = objFeatureRegionFldsENS.CommandName, //命令名
ValueGivingModeId = objFeatureRegionFldsENS.ValueGivingModeId, //给值方式Id
FuncName = objFeatureRegionFldsENS.FuncName, //函数名
DefaultValue = objFeatureRegionFldsENS.DefaultValue, //缺省值
KeyIdGetModeId = objFeatureRegionFldsENS.KeyIdGetModeId, //GC关键字获取方式Id
Text = objFeatureRegionFldsENS.Text, //文本
GroupName = objFeatureRegionFldsENS.GroupName, //组名
ReleTabId = objFeatureRegionFldsENS.ReleTabId, //相关表Id
ReleFldId = objFeatureRegionFldsENS.ReleFldId, //相关字段Id
EventFuncName = objFeatureRegionFldsENS.EventFuncName, //事件函数名
FieldTypeId = objFeatureRegionFldsENS.FieldTypeId, //字段类型Id
ViewImplId = objFeatureRegionFldsENS.ViewImplId, //界面实现Id
CtlTypeId = objFeatureRegionFldsENS.CtlTypeId, //控件类型号
Height = objFeatureRegionFldsENS.Height, //高度
Width = objFeatureRegionFldsENS.Width, //宽
SeqNum = objFeatureRegionFldsENS.SeqNum, //字段序号
CssClass = objFeatureRegionFldsENS.CssClass, //样式表
ImageUrl = objFeatureRegionFldsENS.ImageUrl, //图片资源
InUse = objFeatureRegionFldsENS.InUse, //是否在用
ErrMsg = objFeatureRegionFldsENS.ErrMsg, //错误信息
PrjId = objFeatureRegionFldsENS.PrjId, //工程Id
UpdUser = objFeatureRegionFldsENS.UpdUser, //修改者
UpdDate = objFeatureRegionFldsENS.UpdDate, //修改日期
Memo = objFeatureRegionFldsENS.Memo, //说明
};
 return objFeatureRegionFldsENT;
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
public static void CheckPropertyNew(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 clsFeatureRegionFldsBL.FeatureRegionFldsDA.CheckPropertyNew(objFeatureRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 clsFeatureRegionFldsBL.FeatureRegionFldsDA.CheckProperty4Condition(objFeatureRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFeatureRegionFldsEN objFeatureRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ViewFeatureId) == true)
{
string strComparisonOpViewFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ViewFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ViewFeatureId, objFeatureRegionFldsCond.ViewFeatureId, strComparisonOpViewFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.RegionId, objFeatureRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FeatureId) == true)
{
string strComparisonOpFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FeatureId, objFeatureRegionFldsCond.FeatureId, strComparisonOpFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.TabFeatureId, objFeatureRegionFldsCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CheckTabFeature) == true)
{
string strComparisonOpCheckTabFeature = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CheckTabFeature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CheckTabFeature, objFeatureRegionFldsCond.CheckTabFeature, strComparisonOpCheckTabFeature);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FeatureDescription, objFeatureRegionFldsCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ButtonName) == true)
{
string strComparisonOpButtonName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ButtonName, objFeatureRegionFldsCond.ButtonName, strComparisonOpButtonName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ButtonName4Mvc) == true)
{
string strComparisonOpButtonName4Mvc = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ButtonName4Mvc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ButtonName4Mvc, objFeatureRegionFldsCond.ButtonName4Mvc, strComparisonOpButtonName4Mvc);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CommandName) == true)
{
string strComparisonOpCommandName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CommandName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CommandName, objFeatureRegionFldsCond.CommandName, strComparisonOpCommandName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ValueGivingModeId, objFeatureRegionFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FuncName) == true)
{
string strComparisonOpFuncName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FuncName, objFeatureRegionFldsCond.FuncName, strComparisonOpFuncName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.DefaultValue, objFeatureRegionFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.KeyIdGetModeId) == true)
{
string strComparisonOpKeyIdGetModeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.KeyIdGetModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.KeyIdGetModeId, objFeatureRegionFldsCond.KeyIdGetModeId, strComparisonOpKeyIdGetModeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Text) == true)
{
string strComparisonOpText = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.Text, objFeatureRegionFldsCond.Text, strComparisonOpText);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.GroupName) == true)
{
string strComparisonOpGroupName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.GroupName, objFeatureRegionFldsCond.GroupName, strComparisonOpGroupName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ReleTabId) == true)
{
string strComparisonOpReleTabId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ReleTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ReleTabId, objFeatureRegionFldsCond.ReleTabId, strComparisonOpReleTabId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ReleFldId) == true)
{
string strComparisonOpReleFldId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ReleFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ReleFldId, objFeatureRegionFldsCond.ReleFldId, strComparisonOpReleFldId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.EventFuncName, objFeatureRegionFldsCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.FieldTypeId, objFeatureRegionFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ViewImplId) == true)
{
string strComparisonOpViewImplId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ViewImplId, objFeatureRegionFldsCond.ViewImplId, strComparisonOpViewImplId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CtlTypeId, objFeatureRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Height) == true)
{
string strComparisonOpHeight = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.Height, objFeatureRegionFldsCond.Height, strComparisonOpHeight);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Width) == true)
{
string strComparisonOpWidth = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.Width, objFeatureRegionFldsCond.Width, strComparisonOpWidth);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureRegionFlds.SeqNum, objFeatureRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.CssClass) == true)
{
string strComparisonOpCssClass = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.CssClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.CssClass, objFeatureRegionFldsCond.CssClass, strComparisonOpCssClass);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ImageUrl) == true)
{
string strComparisonOpImageUrl = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ImageUrl, objFeatureRegionFldsCond.ImageUrl, strComparisonOpImageUrl);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.InUse) == true)
{
if (objFeatureRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFeatureRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFeatureRegionFlds.InUse);
}
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.ErrMsg, objFeatureRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.PrjId, objFeatureRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.UpdUser, objFeatureRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.UpdDate, objFeatureRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objFeatureRegionFldsCond.IsUpdated(conFeatureRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objFeatureRegionFldsCond.dicFldComparisonOp[conFeatureRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureRegionFlds.Memo, objFeatureRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FeatureRegionFlds(功能区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:Uni_RegionId_FeatureId_ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFeatureRegionFldsEN == null) return true;
if (objFeatureRegionFldsEN.ViewFeatureId == null || objFeatureRegionFldsEN.ViewFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
if (clsFeatureRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewFeatureId !=  '{0}'", objFeatureRegionFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
if (clsFeatureRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FeatureRegionFlds(功能区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Uni_RegionId_FeatureId_ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFeatureRegionFldsEN == null) return "";
if (objFeatureRegionFldsEN.ViewFeatureId == null || objFeatureRegionFldsEN.ViewFeatureId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewFeatureId !=  '{0}'", objFeatureRegionFldsEN.ViewFeatureId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objFeatureRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and ButtonName = '{0}'", objFeatureRegionFldsEN.ButtonName);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureRegionFldsEN.FeatureId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FeatureRegionFlds
{
public virtual bool UpdRelaTabDate(string strViewFeatureId, string strOpUser)
{
var objFeatureRegionFlds = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
if (objFeatureRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objFeatureRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objFeatureRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// 功能区域字段(FeatureRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFeatureRegionFldsBL
{
public static RelatedActions_FeatureRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFeatureRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFeatureRegionFldsDA FeatureRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFeatureRegionFldsDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsFeatureRegionFldsBL()
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
if (string.IsNullOrEmpty(clsFeatureRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFeatureRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_FeatureRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FeatureRegionFldsDA.GetDataTable_FeatureRegionFlds(strWhereCond);
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
objDT = FeatureRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = FeatureRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FeatureRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FeatureRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FeatureRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = FeatureRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FeatureRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FeatureRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstByViewFeatureIdLst(List<string> arrViewFeatureIdLst)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewFeatureIdLst, true);
 string strWhereCond = string.Format("ViewFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFeatureRegionFldsEN> GetObjLstByViewFeatureIdLstCache(List<string> arrViewFeatureIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
arrFeatureRegionFldsObjLstCache
.Where(x => arrViewFeatureIdLst.Contains(x.ViewFeatureId));
return arrFeatureRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
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
public static List<clsFeatureRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFeatureRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFeatureRegionFldsEN> GetSubObjLstCache(clsFeatureRegionFldsEN objFeatureRegionFldsCond)
{
 string strPrjId = objFeatureRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsFeatureRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsFeatureRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFeatureRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureRegionFlds._AttributeName)
{
if (objFeatureRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objFeatureRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureRegionFldsCond[strFldName].ToString());
}
else
{
if (objFeatureRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureRegionFldsCond[strFldName]));
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
public static List<clsFeatureRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
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
List<clsFeatureRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFeatureRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFeatureRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
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
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
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
public static List<clsFeatureRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFeatureRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
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
public static List<clsFeatureRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFeatureRegionFldsEN> arrObjLst = new List<clsFeatureRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureRegionFldsEN objFeatureRegionFldsEN = new clsFeatureRegionFldsEN();
try
{
objFeatureRegionFldsEN.ViewFeatureId = objRow[conFeatureRegionFlds.ViewFeatureId].ToString().Trim(); //界面功能Id
objFeatureRegionFldsEN.RegionId = objRow[conFeatureRegionFlds.RegionId].ToString().Trim(); //区域Id
objFeatureRegionFldsEN.FeatureId = objRow[conFeatureRegionFlds.FeatureId].ToString().Trim(); //功能Id
objFeatureRegionFldsEN.TabFeatureId = objRow[conFeatureRegionFlds.TabFeatureId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.TabFeatureId].ToString().Trim(); //表功能Id
objFeatureRegionFldsEN.CheckTabFeature = objRow[conFeatureRegionFlds.CheckTabFeature] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CheckTabFeature].ToString().Trim(); //检查表功能
objFeatureRegionFldsEN.FeatureDescription = objRow[conFeatureRegionFlds.FeatureDescription] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FeatureDescription].ToString().Trim(); //功能说明
objFeatureRegionFldsEN.ButtonName = objRow[conFeatureRegionFlds.ButtonName].ToString().Trim(); //按钮名称
objFeatureRegionFldsEN.ButtonName4Mvc = objRow[conFeatureRegionFlds.ButtonName4Mvc].ToString().Trim(); //按钮名称4Mvc
objFeatureRegionFldsEN.CommandName = objRow[conFeatureRegionFlds.CommandName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CommandName].ToString().Trim(); //命令名
objFeatureRegionFldsEN.ValueGivingModeId = objRow[conFeatureRegionFlds.ValueGivingModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ValueGivingModeId].ToString().Trim(); //给值方式Id
objFeatureRegionFldsEN.FuncName = objRow[conFeatureRegionFlds.FuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FuncName].ToString().Trim(); //函数名
objFeatureRegionFldsEN.DefaultValue = objRow[conFeatureRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conFeatureRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objFeatureRegionFldsEN.KeyIdGetModeId = objRow[conFeatureRegionFlds.KeyIdGetModeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objFeatureRegionFldsEN.Text = objRow[conFeatureRegionFlds.Text].ToString().Trim(); //文本
objFeatureRegionFldsEN.GroupName = objRow[conFeatureRegionFlds.GroupName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.GroupName].ToString().Trim(); //组名
objFeatureRegionFldsEN.ReleTabId = objRow[conFeatureRegionFlds.ReleTabId].ToString().Trim(); //相关表Id
objFeatureRegionFldsEN.ReleFldId = objRow[conFeatureRegionFlds.ReleFldId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ReleFldId].ToString().Trim(); //相关字段Id
objFeatureRegionFldsEN.EventFuncName = objRow[conFeatureRegionFlds.EventFuncName] == DBNull.Value ? null : objRow[conFeatureRegionFlds.EventFuncName].ToString().Trim(); //事件函数名
objFeatureRegionFldsEN.FieldTypeId = objRow[conFeatureRegionFlds.FieldTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureRegionFldsEN.ViewImplId = objRow[conFeatureRegionFlds.ViewImplId].ToString().Trim(); //界面实现Id
objFeatureRegionFldsEN.CtlTypeId = objRow[conFeatureRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objFeatureRegionFldsEN.Height = objRow[conFeatureRegionFlds.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Height].ToString().Trim()); //高度
objFeatureRegionFldsEN.Width = objRow[conFeatureRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.Width].ToString().Trim()); //宽
objFeatureRegionFldsEN.SeqNum = objRow[conFeatureRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureRegionFlds.SeqNum].ToString().Trim()); //字段序号
objFeatureRegionFldsEN.CssClass = objRow[conFeatureRegionFlds.CssClass] == DBNull.Value ? null : objRow[conFeatureRegionFlds.CssClass].ToString().Trim(); //样式表
objFeatureRegionFldsEN.ImageUrl = objRow[conFeatureRegionFlds.ImageUrl] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ImageUrl].ToString().Trim(); //图片资源
objFeatureRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFeatureRegionFlds.InUse].ToString().Trim()); //是否在用
objFeatureRegionFldsEN.ErrMsg = objRow[conFeatureRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conFeatureRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objFeatureRegionFldsEN.PrjId = objRow[conFeatureRegionFlds.PrjId].ToString().Trim(); //工程Id
objFeatureRegionFldsEN.UpdUser = objRow[conFeatureRegionFlds.UpdUser].ToString().Trim(); //修改者
objFeatureRegionFldsEN.UpdDate = objRow[conFeatureRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conFeatureRegionFlds.UpdDate].ToString().Trim(); //修改日期
objFeatureRegionFldsEN.Memo = objRow[conFeatureRegionFlds.Memo] == DBNull.Value ? null : objRow[conFeatureRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFeatureRegionFldsEN.ViewFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFeatureRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFeatureRegionFlds(ref clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
bool bolResult = FeatureRegionFldsDA.GetFeatureRegionFlds(ref objFeatureRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureRegionFldsEN GetObjByViewFeatureId(string strViewFeatureId)
{
if (strViewFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFeatureRegionFldsEN objFeatureRegionFldsEN = FeatureRegionFldsDA.GetObjByViewFeatureId(strViewFeatureId);
return objFeatureRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFeatureRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = FeatureRegionFldsDA.GetFirstObj(strWhereCond);
 return objFeatureRegionFldsEN;
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
public static clsFeatureRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = FeatureRegionFldsDA.GetObjByDataRow(objRow);
 return objFeatureRegionFldsEN;
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
public static clsFeatureRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = FeatureRegionFldsDA.GetObjByDataRow(objRow);
 return objFeatureRegionFldsEN;
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
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <param name = "lstFeatureRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureRegionFldsEN GetObjByViewFeatureIdFromList(string strViewFeatureId, List<clsFeatureRegionFldsEN> lstFeatureRegionFldsObjLst)
{
foreach (clsFeatureRegionFldsEN objFeatureRegionFldsEN in lstFeatureRegionFldsObjLst)
{
if (objFeatureRegionFldsEN.ViewFeatureId == strViewFeatureId)
{
return objFeatureRegionFldsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxViewFeatureId;
 try
 {
 strMaxViewFeatureId = clsFeatureRegionFldsDA.GetMaxStrId();
 return strMaxViewFeatureId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strViewFeatureId;
 try
 {
 strViewFeatureId = new clsFeatureRegionFldsDA().GetFirstID(strWhereCond);
 return strViewFeatureId;
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
 arrList = FeatureRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = FeatureRegionFldsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewFeatureId)
{
if (string.IsNullOrEmpty(strViewFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FeatureRegionFldsDA.IsExist(strViewFeatureId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strViewFeatureId">界面功能Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strViewFeatureId, string strOpUser)
{
clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
objFeatureRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFeatureRegionFldsEN.UpdUser = strOpUser;
return clsFeatureRegionFldsBL.UpdateBySql2(objFeatureRegionFldsEN);
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
 bolIsExist = clsFeatureRegionFldsDA.IsExistTable();
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
 bolIsExist = FeatureRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],按钮名称 = [{1}],功能Id = [{2}]的数据已经存在!(in clsFeatureRegionFldsBL.AddNewRecordBySql2)", objFeatureRegionFldsEN.RegionId,objFeatureRegionFldsEN.ButtonName,objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
bool bolResult = FeatureRegionFldsDA.AddNewRecordBySQL2(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFeatureRegionFldsEN objFeatureRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFeatureRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],按钮名称 = [{1}],功能Id = [{2}]的数据已经存在!(in clsFeatureRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objFeatureRegionFldsEN.RegionId,objFeatureRegionFldsEN.ButtonName,objFeatureRegionFldsEN.FeatureId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true || clsFeatureRegionFldsBL.IsExist(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
     objFeatureRegionFldsEN.ViewFeatureId = clsFeatureRegionFldsBL.GetMaxStrId_S();
 }
string strKey = FeatureRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
bool bolResult = FeatureRegionFldsDA.Update(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "objFeatureRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 if (string.IsNullOrEmpty(objFeatureRegionFldsEN.ViewFeatureId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FeatureRegionFldsDA.UpdateBySql2(objFeatureRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureRegionFldsBL.ReFreshCache(objFeatureRegionFldsEN.PrjId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strViewFeatureId)
{
try
{
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);

if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(objFeatureRegionFldsEN.ViewFeatureId, objFeatureRegionFldsEN.UpdUser);
}
if (objFeatureRegionFldsEN != null)
{
int intRecNum = FeatureRegionFldsDA.DelRecord(strViewFeatureId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
/// <param name="strViewFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strViewFeatureId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[FeatureRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFeatureRegionFlds.ViewFeatureId,
//strViewFeatureId);
//        clsFeatureRegionFldsBL.DelFeatureRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureRegionFldsBL.DelRecord(strViewFeatureId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strViewFeatureId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strViewFeatureId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFeatureRegionFldsBL.relatedActions != null)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(strViewFeatureId, "UpdRelaTabDate");
}
bool bolResult = FeatureRegionFldsDA.DelRecord(strViewFeatureId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrViewFeatureIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFeatureRegionFldss(List<string> arrViewFeatureIdLst)
{
if (arrViewFeatureIdLst.Count == 0) return 0;
try
{
if (clsFeatureRegionFldsBL.relatedActions != null)
{
foreach (var strViewFeatureId in arrViewFeatureIdLst)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(strViewFeatureId, "UpdRelaTabDate");
}
}
 clsFeatureRegionFldsEN objFeatureRegionFldsEN = clsFeatureRegionFldsBL.GetObjByViewFeatureId(arrViewFeatureIdLst[0]);
int intDelRecNum = FeatureRegionFldsDA.DelFeatureRegionFlds(arrViewFeatureIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objFeatureRegionFldsEN.PrjId);
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
public static int DelFeatureRegionFldssByCond(string strWhereCond)
{
try
{
if (clsFeatureRegionFldsBL.relatedActions != null)
{
List<string> arrViewFeatureId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewFeatureId in arrViewFeatureId)
{
clsFeatureRegionFldsBL.relatedActions.UpdRelaTabDate(strViewFeatureId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conFeatureRegionFlds.PrjId, strWhereCond);
int intRecNum = FeatureRegionFldsDA.DelFeatureRegionFlds(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FeatureRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strViewFeatureId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strViewFeatureId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFeatureRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[FeatureRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFeatureRegionFldsBL.DelRecord(strViewFeatureId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFeatureRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strViewFeatureId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFeatureRegionFldsENS">源对象</param>
 /// <param name = "objFeatureRegionFldsENT">目标对象</param>
 public static void CopyTo(clsFeatureRegionFldsEN objFeatureRegionFldsENS, clsFeatureRegionFldsEN objFeatureRegionFldsENT)
{
try
{
objFeatureRegionFldsENT.ViewFeatureId = objFeatureRegionFldsENS.ViewFeatureId; //界面功能Id
objFeatureRegionFldsENT.RegionId = objFeatureRegionFldsENS.RegionId; //区域Id
objFeatureRegionFldsENT.FeatureId = objFeatureRegionFldsENS.FeatureId; //功能Id
objFeatureRegionFldsENT.TabFeatureId = objFeatureRegionFldsENS.TabFeatureId; //表功能Id
objFeatureRegionFldsENT.CheckTabFeature = objFeatureRegionFldsENS.CheckTabFeature; //检查表功能
objFeatureRegionFldsENT.FeatureDescription = objFeatureRegionFldsENS.FeatureDescription; //功能说明
objFeatureRegionFldsENT.ButtonName = objFeatureRegionFldsENS.ButtonName; //按钮名称
objFeatureRegionFldsENT.ButtonName4Mvc = objFeatureRegionFldsENS.ButtonName4Mvc; //按钮名称4Mvc
objFeatureRegionFldsENT.CommandName = objFeatureRegionFldsENS.CommandName; //命令名
objFeatureRegionFldsENT.ValueGivingModeId = objFeatureRegionFldsENS.ValueGivingModeId; //给值方式Id
objFeatureRegionFldsENT.FuncName = objFeatureRegionFldsENS.FuncName; //函数名
objFeatureRegionFldsENT.DefaultValue = objFeatureRegionFldsENS.DefaultValue; //缺省值
objFeatureRegionFldsENT.KeyIdGetModeId = objFeatureRegionFldsENS.KeyIdGetModeId; //GC关键字获取方式Id
objFeatureRegionFldsENT.Text = objFeatureRegionFldsENS.Text; //文本
objFeatureRegionFldsENT.GroupName = objFeatureRegionFldsENS.GroupName; //组名
objFeatureRegionFldsENT.ReleTabId = objFeatureRegionFldsENS.ReleTabId; //相关表Id
objFeatureRegionFldsENT.ReleFldId = objFeatureRegionFldsENS.ReleFldId; //相关字段Id
objFeatureRegionFldsENT.EventFuncName = objFeatureRegionFldsENS.EventFuncName; //事件函数名
objFeatureRegionFldsENT.FieldTypeId = objFeatureRegionFldsENS.FieldTypeId; //字段类型Id
objFeatureRegionFldsENT.ViewImplId = objFeatureRegionFldsENS.ViewImplId; //界面实现Id
objFeatureRegionFldsENT.CtlTypeId = objFeatureRegionFldsENS.CtlTypeId; //控件类型号
objFeatureRegionFldsENT.Height = objFeatureRegionFldsENS.Height; //高度
objFeatureRegionFldsENT.Width = objFeatureRegionFldsENS.Width; //宽
objFeatureRegionFldsENT.SeqNum = objFeatureRegionFldsENS.SeqNum; //字段序号
objFeatureRegionFldsENT.CssClass = objFeatureRegionFldsENS.CssClass; //样式表
objFeatureRegionFldsENT.ImageUrl = objFeatureRegionFldsENS.ImageUrl; //图片资源
objFeatureRegionFldsENT.InUse = objFeatureRegionFldsENS.InUse; //是否在用
objFeatureRegionFldsENT.ErrMsg = objFeatureRegionFldsENS.ErrMsg; //错误信息
objFeatureRegionFldsENT.PrjId = objFeatureRegionFldsENS.PrjId; //工程Id
objFeatureRegionFldsENT.UpdUser = objFeatureRegionFldsENS.UpdUser; //修改者
objFeatureRegionFldsENT.UpdDate = objFeatureRegionFldsENS.UpdDate; //修改日期
objFeatureRegionFldsENT.Memo = objFeatureRegionFldsENS.Memo; //说明
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
 /// <param name = "objFeatureRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
objFeatureRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFeatureRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFeatureRegionFlds.ViewFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ViewFeatureId = objFeatureRegionFldsEN.ViewFeatureId; //界面功能Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.RegionId = objFeatureRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.FeatureId = objFeatureRegionFldsEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.TabFeatureId = objFeatureRegionFldsEN.TabFeatureId == "[null]" ? null :  objFeatureRegionFldsEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.CheckTabFeature, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.CheckTabFeature = objFeatureRegionFldsEN.CheckTabFeature == "[null]" ? null :  objFeatureRegionFldsEN.CheckTabFeature; //检查表功能
}
if (arrFldSet.Contains(conFeatureRegionFlds.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.FeatureDescription = objFeatureRegionFldsEN.FeatureDescription == "[null]" ? null :  objFeatureRegionFldsEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(conFeatureRegionFlds.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ButtonName = objFeatureRegionFldsEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(conFeatureRegionFlds.ButtonName4Mvc, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ButtonName4Mvc = objFeatureRegionFldsEN.ButtonName4Mvc; //按钮名称4Mvc
}
if (arrFldSet.Contains(conFeatureRegionFlds.CommandName, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.CommandName = objFeatureRegionFldsEN.CommandName == "[null]" ? null :  objFeatureRegionFldsEN.CommandName; //命令名
}
if (arrFldSet.Contains(conFeatureRegionFlds.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ValueGivingModeId = objFeatureRegionFldsEN.ValueGivingModeId == "[null]" ? null :  objFeatureRegionFldsEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.FuncName = objFeatureRegionFldsEN.FuncName == "[null]" ? null :  objFeatureRegionFldsEN.FuncName; //函数名
}
if (arrFldSet.Contains(conFeatureRegionFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.DefaultValue = objFeatureRegionFldsEN.DefaultValue == "[null]" ? null :  objFeatureRegionFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conFeatureRegionFlds.KeyIdGetModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.KeyIdGetModeId = objFeatureRegionFldsEN.KeyIdGetModeId == "[null]" ? null :  objFeatureRegionFldsEN.KeyIdGetModeId; //GC关键字获取方式Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.Text = objFeatureRegionFldsEN.Text; //文本
}
if (arrFldSet.Contains(conFeatureRegionFlds.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.GroupName = objFeatureRegionFldsEN.GroupName == "[null]" ? null :  objFeatureRegionFldsEN.GroupName; //组名
}
if (arrFldSet.Contains(conFeatureRegionFlds.ReleTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ReleTabId = objFeatureRegionFldsEN.ReleTabId; //相关表Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.ReleFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ReleFldId = objFeatureRegionFldsEN.ReleFldId == "[null]" ? null :  objFeatureRegionFldsEN.ReleFldId; //相关字段Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.EventFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.EventFuncName = objFeatureRegionFldsEN.EventFuncName == "[null]" ? null :  objFeatureRegionFldsEN.EventFuncName; //事件函数名
}
if (arrFldSet.Contains(conFeatureRegionFlds.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.FieldTypeId = objFeatureRegionFldsEN.FieldTypeId == "[null]" ? null :  objFeatureRegionFldsEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ViewImplId = objFeatureRegionFldsEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.CtlTypeId = objFeatureRegionFldsEN.CtlTypeId == "[null]" ? null :  objFeatureRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conFeatureRegionFlds.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.Height = objFeatureRegionFldsEN.Height; //高度
}
if (arrFldSet.Contains(conFeatureRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.Width = objFeatureRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(conFeatureRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.SeqNum = objFeatureRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conFeatureRegionFlds.CssClass, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.CssClass = objFeatureRegionFldsEN.CssClass == "[null]" ? null :  objFeatureRegionFldsEN.CssClass; //样式表
}
if (arrFldSet.Contains(conFeatureRegionFlds.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ImageUrl = objFeatureRegionFldsEN.ImageUrl == "[null]" ? null :  objFeatureRegionFldsEN.ImageUrl; //图片资源
}
if (arrFldSet.Contains(conFeatureRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.InUse = objFeatureRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conFeatureRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.ErrMsg = objFeatureRegionFldsEN.ErrMsg == "[null]" ? null :  objFeatureRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conFeatureRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.PrjId = objFeatureRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFeatureRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.UpdUser = objFeatureRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFeatureRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.UpdDate = objFeatureRegionFldsEN.UpdDate == "[null]" ? null :  objFeatureRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFeatureRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFeatureRegionFldsEN.Memo = objFeatureRegionFldsEN.Memo == "[null]" ? null :  objFeatureRegionFldsEN.Memo; //说明
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
 /// <param name = "objFeatureRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
try
{
if (objFeatureRegionFldsEN.TabFeatureId == "[null]") objFeatureRegionFldsEN.TabFeatureId = null; //表功能Id
if (objFeatureRegionFldsEN.CheckTabFeature == "[null]") objFeatureRegionFldsEN.CheckTabFeature = null; //检查表功能
if (objFeatureRegionFldsEN.FeatureDescription == "[null]") objFeatureRegionFldsEN.FeatureDescription = null; //功能说明
if (objFeatureRegionFldsEN.CommandName == "[null]") objFeatureRegionFldsEN.CommandName = null; //命令名
if (objFeatureRegionFldsEN.ValueGivingModeId == "[null]") objFeatureRegionFldsEN.ValueGivingModeId = null; //给值方式Id
if (objFeatureRegionFldsEN.FuncName == "[null]") objFeatureRegionFldsEN.FuncName = null; //函数名
if (objFeatureRegionFldsEN.DefaultValue == "[null]") objFeatureRegionFldsEN.DefaultValue = null; //缺省值
if (objFeatureRegionFldsEN.KeyIdGetModeId == "[null]") objFeatureRegionFldsEN.KeyIdGetModeId = null; //GC关键字获取方式Id
if (objFeatureRegionFldsEN.GroupName == "[null]") objFeatureRegionFldsEN.GroupName = null; //组名
if (objFeatureRegionFldsEN.ReleFldId == "[null]") objFeatureRegionFldsEN.ReleFldId = null; //相关字段Id
if (objFeatureRegionFldsEN.EventFuncName == "[null]") objFeatureRegionFldsEN.EventFuncName = null; //事件函数名
if (objFeatureRegionFldsEN.FieldTypeId == "[null]") objFeatureRegionFldsEN.FieldTypeId = null; //字段类型Id
if (objFeatureRegionFldsEN.CtlTypeId == "[null]") objFeatureRegionFldsEN.CtlTypeId = null; //控件类型号
if (objFeatureRegionFldsEN.CssClass == "[null]") objFeatureRegionFldsEN.CssClass = null; //样式表
if (objFeatureRegionFldsEN.ImageUrl == "[null]") objFeatureRegionFldsEN.ImageUrl = null; //图片资源
if (objFeatureRegionFldsEN.ErrMsg == "[null]") objFeatureRegionFldsEN.ErrMsg = null; //错误信息
if (objFeatureRegionFldsEN.UpdDate == "[null]") objFeatureRegionFldsEN.UpdDate = null; //修改日期
if (objFeatureRegionFldsEN.Memo == "[null]") objFeatureRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 FeatureRegionFldsDA.CheckPropertyNew(objFeatureRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
 FeatureRegionFldsDA.CheckProperty4Condition(objFeatureRegionFldsEN);
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
if (clsFeatureRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureRegionFldsBL没有刷新缓存机制(clsFeatureRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewFeatureId");
//if (arrFeatureRegionFldsObjLstCache == null)
//{
//arrFeatureRegionFldsObjLstCache = FeatureRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewFeatureId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureRegionFldsEN GetObjByViewFeatureIdCache(string strViewFeatureId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLst_Sel =
arrFeatureRegionFldsObjLstCache
.Where(x=> x.ViewFeatureId == strViewFeatureId 
);
if (arrFeatureRegionFldsObjLst_Sel.Count() == 0)
{
   clsFeatureRegionFldsEN obj = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewFeatureId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrFeatureRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetAllFeatureRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrFeatureRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureRegionFldsEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrFeatureRegionFldsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFeatureRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFeatureRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsFeatureRegionFldsEN._RefreshTimeLst[clsFeatureRegionFldsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFeatureRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFeatureRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFeatureRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFeatureRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FeatureRegionFlds(功能区域字段)
 /// 唯一性条件:Uni_RegionId_FeatureId_ButtonName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFeatureRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
{
//检测记录是否存在
string strResult = FeatureRegionFldsDA.GetUniCondStr(objFeatureRegionFldsEN);
return strResult;
}


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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strViewFeatureId, string strPrjId)
{
if (strInFldName != conFeatureRegionFlds.ViewFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFeatureRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFeatureRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objFeatureRegionFlds = clsFeatureRegionFldsBL.GetObjByViewFeatureIdCache(strViewFeatureId, strPrjId);
if (objFeatureRegionFlds == null) return "";
return objFeatureRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsFeatureRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsFeatureRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFeatureRegionFldsDA.GetRecCount();
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
int intRecCount = clsFeatureRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFeatureRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFeatureRegionFldsEN objFeatureRegionFldsCond)
{
 string strPrjId = objFeatureRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsFeatureRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsFeatureRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFeatureRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFeatureRegionFlds._AttributeName)
{
if (objFeatureRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objFeatureRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureRegionFldsCond[strFldName].ToString());
}
else
{
if (objFeatureRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFeatureRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFeatureRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFeatureRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFeatureRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFeatureRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFeatureRegionFldsCond[strFldName]));
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
 List<string> arrList = clsFeatureRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FeatureRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FeatureRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FeatureRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureRegionFldsDA.SetFldValue(clsFeatureRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FeatureRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFeatureRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFeatureRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FeatureRegionFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**界面功能Id*/ 
 strCreateTabCode.Append(" ViewFeatureId char(8) primary key, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) not Null, "); 
 // /**表功能Id*/ 
 strCreateTabCode.Append(" TabFeatureId char(8) Null, "); 
 // /**检查表功能*/ 
 strCreateTabCode.Append(" CheckTabFeature varchar(50) Null, "); 
 // /**功能说明*/ 
 strCreateTabCode.Append(" FeatureDescription varchar(4000) Null, "); 
 // /**按钮名称*/ 
 strCreateTabCode.Append(" ButtonName varchar(30) not Null, "); 
 // /**按钮名称4Mvc*/ 
 strCreateTabCode.Append(" ButtonName4Mvc varchar(30) not Null, "); 
 // /**命令名*/ 
 strCreateTabCode.Append(" CommandName varchar(30) Null, "); 
 // /**给值方式Id*/ 
 strCreateTabCode.Append(" ValueGivingModeId char(2) Null, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**GC关键字获取方式Id*/ 
 strCreateTabCode.Append(" KeyIdGetModeId char(4) Null, "); 
 // /**文本*/ 
 strCreateTabCode.Append(" Text varchar(30) not Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**相关表Id*/ 
 strCreateTabCode.Append(" ReleTabId char(8) not Null, "); 
 // /**相关字段Id*/ 
 strCreateTabCode.Append(" ReleFldId char(8) Null, "); 
 // /**事件函数名*/ 
 strCreateTabCode.Append(" EventFuncName varchar(50) Null, "); 
 // /**字段类型Id*/ 
 strCreateTabCode.Append(" FieldTypeId char(2) Null, "); 
 // /**界面实现Id*/ 
 strCreateTabCode.Append(" ViewImplId char(4) not Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**样式表*/ 
 strCreateTabCode.Append(" CssClass varchar(50) Null, "); 
 // /**图片资源*/ 
 strCreateTabCode.Append(" ImageUrl varchar(100) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FeatureName varchar(100) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**区域类型名称*/ 
 strCreateTabCode.Append(" RegionTypeName varchar(30) Null, "); 
 // /**控件类型中文名*/ 
 strCreateTabCode.Append(" CtlCnName varchar(50) Null, "); 
 // /**控件类型缩写*/ 
 strCreateTabCode.Append(" CtlTypeAbbr varchar(5) Null, "); 
 // /**界面实现名*/ 
 strCreateTabCode.Append(" ViewImplName varchar(50) Null, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) Null, "); 
 // /**给值方式名*/ 
 strCreateTabCode.Append(" ValueGivingModeName varchar(50) Null, "); 
 // /**表功能名*/ 
 strCreateTabCode.Append(" TabFeatureName varchar(100) Null, "); 
 // /**关系字段名*/ 
 strCreateTabCode.Append(" RelaFldName varchar(50) Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" CtrlId varchar(50) not Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**区域名称*/ 
 strCreateTabCode.Append(" RegionName varchar(50) not Null, "); 
 // /**Cm工程名s*/ 
 strCreateTabCode.Append(" TabNameEx varchar(50) Null, "); 
 // /**命令名Ex*/ 
 strCreateTabCode.Append(" CommandNameEx varchar(30) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：RegionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strRegionId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strRegionId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = new clsFeatureRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjList)
{
objFeatureRegionFlds.SeqNum = intIndex;
UpdateBySql2(objFeatureRegionFlds);
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
/// 调整所给关键字记录的序号。根据分类字段：RegionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strViewFeatureId">所给的关键字</param>
/// <param name="strRegionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strViewFeatureId ,string strRegionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[ViewFeatureId],获取相应的序号[SeqNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字ViewFeatureId
//5、把当前关键字ViewFeatureId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字ViewFeatureId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevViewFeatureId = "";    //上一条序号的关键字ViewFeatureId
string strNextViewFeatureId = "";    //下一条序号的关键字ViewFeatureId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[ViewFeatureId],获取相应的序号[SeqNum]。

clsFeatureRegionFldsEN objFeatureRegionFlds = clsFeatureRegionFldsBL.GetObjByViewFeatureId(strViewFeatureId);

intOrderNum = objFeatureRegionFlds.SeqNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);
intTabRecNum = clsFeatureRegionFldsBL.GetRecCountByCond(clsFeatureRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conFeatureRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字ViewFeatureId
strPrevViewFeatureId = clsFeatureRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevViewFeatureId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字ViewFeatureId所对应记录的序号减1
//6、把下(上)一个序号关键字ViewFeatureId所对应的记录序号加1
clsFeatureRegionFldsBL.SetFldValue(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conFeatureRegionFlds.ViewFeatureId, strViewFeatureId));
clsFeatureRegionFldsBL.SetFldValue(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFeatureRegionFlds.ViewFeatureId, strPrevViewFeatureId));
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

//4、获取下一个序号字段的关键字ViewFeatureId
sbCondition.AppendFormat(" {0} = {1} ", conFeatureRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);

strNextViewFeatureId = clsFeatureRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextViewFeatureId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字ViewFeatureId所对应记录的序号加1
//6、把下(上)一个序号关键字ViewFeatureId所对应的记录序号减1
clsFeatureRegionFldsBL.SetFldValue(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conFeatureRegionFlds.ViewFeatureId, strViewFeatureId));
clsFeatureRegionFldsBL.SetFldValue(clsFeatureRegionFldsEN._CurrTabName, conFeatureRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conFeatureRegionFlds.ViewFeatureId, strNextViewFeatureId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：RegionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strRegionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conFeatureRegionFlds.ViewFeatureId, strKeyList);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsLst = GetObjLst(strCondition);
foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsLst)
{
objFeatureRegionFlds.SeqNum = objFeatureRegionFlds.SeqNum + 10000;
UpdateBySql2(objFeatureRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = new clsFeatureRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjList)
{
objFeatureRegionFlds.SeqNum = intIndex;
UpdateBySql2(objFeatureRegionFlds);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：RegionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strRegionId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strRegionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conFeatureRegionFlds.ViewFeatureId, strKeyList);
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsLst = GetObjLst(strCondition);
foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsLst)
{
objFeatureRegionFlds.SeqNum = objFeatureRegionFlds.SeqNum - 10000;
UpdateBySql2(objFeatureRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conFeatureRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsFeatureRegionFldsEN> arrFeatureRegionFldsObjList = new clsFeatureRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFeatureRegionFldsEN objFeatureRegionFlds in arrFeatureRegionFldsObjList)
{
objFeatureRegionFlds.SeqNum = intIndex;
UpdateBySql2(objFeatureRegionFlds);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 功能区域字段(FeatureRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FeatureRegionFlds : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsFeatureRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}