
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionBL
 表名:ViewRegion(00050099)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:15
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
public static class  clsViewRegionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionEN GetObj(this K_RegionId_ViewRegion myKey)
{
clsViewRegionEN objViewRegionEN = clsViewRegionBL.ViewRegionDA.GetObjByRegionId(myKey.Value);
return objViewRegionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRegionEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],类名 = [{1}]的数据已经存在!(in clsViewRegionBL.AddNewRecord)", objViewRegionEN.PrjId,objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
bool bolResult = clsViewRegionBL.ViewRegionDA.AddNewRecordBySQL2(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
public static bool AddRecordEx(this clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsViewRegionBL.IsExist(objViewRegionEN.RegionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objViewRegionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewRegionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],类名(ClsName)=[{1}])已经存在,不能重复!", objViewRegionEN.PrjId, objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objViewRegionEN.AddNewRecord();
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRegionEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],类名 = [{1}]的数据已经存在!(in clsViewRegionBL.AddNewRecordWithMaxId)", objViewRegionEN.PrjId,objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
string strRegionId = clsViewRegionBL.ViewRegionDA.AddNewRecordBySQL2WithReturnKey(objViewRegionEN);
     objViewRegionEN.RegionId = strRegionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
}
return strRegionId;
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRegionEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],类名 = [{1}]的数据已经存在!(in clsViewRegionBL.AddNewRecordWithReturnKey)", objViewRegionEN.PrjId,objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
string strKey = clsViewRegionBL.ViewRegionDA.AddNewRecordBySQL2WithReturnKey(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionId(this clsViewRegionEN objViewRegionEN, string strRegionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conViewRegion.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conViewRegion.RegionId);
}
objViewRegionEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionName(this clsViewRegionEN objViewRegionEN, string strRegionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionName, conViewRegion.RegionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionName, 50, conViewRegion.RegionName);
}
objViewRegionEN.RegionName = strRegionName; //区域名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionName] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetRegionTypeId(this clsViewRegionEN objViewRegionEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, conViewRegion.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conViewRegion.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conViewRegion.RegionTypeId);
}
objViewRegionEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.RegionTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.RegionTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.RegionTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetFileName(this clsViewRegionEN objViewRegionEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conViewRegion.FileName);
}
objViewRegionEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.FileName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.FileName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.FileName] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetHeight(this clsViewRegionEN objViewRegionEN, int? intHeight, string strComparisonOp="")
	{
objViewRegionEN.Height = intHeight; //高度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Height) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Height, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Height] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetWidth(this clsViewRegionEN objViewRegionEN, int? intWidth, string strComparisonOp="")
	{
objViewRegionEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Width) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Width, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Width] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetColNum(this clsViewRegionEN objViewRegionEN, int? intColNum, string strComparisonOp="")
	{
objViewRegionEN.ColNum = intColNum; //列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ColNum) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ColNum, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ColNum] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetContainerTypeId(this clsViewRegionEN objViewRegionEN, string strContainerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, conViewRegion.ContainerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, conViewRegion.ContainerTypeId);
}
objViewRegionEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ContainerTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ContainerTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ContainerTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetPageDispModeId(this clsViewRegionEN objViewRegionEN, string strPageDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageDispModeId, 2, conViewRegion.PageDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPageDispModeId, 2, conViewRegion.PageDispModeId);
}
objViewRegionEN.PageDispModeId = strPageDispModeId; //页面显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.PageDispModeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.PageDispModeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.PageDispModeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetInOutTypeId(this clsViewRegionEN objViewRegionEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, conViewRegion.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conViewRegion.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conViewRegion.InOutTypeId);
}
objViewRegionEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.InOutTypeId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.InOutTypeId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.InOutTypeId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetTabId(this clsViewRegionEN objViewRegionEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conViewRegion.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conViewRegion.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conViewRegion.TabId);
}
objViewRegionEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.TabId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.TabId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.TabId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetKeyId4Test(this clsViewRegionEN objViewRegionEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conViewRegion.KeyId4Test);
}
objViewRegionEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.KeyId4Test) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.KeyId4Test, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.KeyId4Test] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetErrMsg(this clsViewRegionEN objViewRegionEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewRegion.ErrMsg);
}
objViewRegionEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ErrMsg) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ErrMsg, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ErrMsg] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetPrjId(this clsViewRegionEN objViewRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewRegion.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewRegion.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewRegion.PrjId);
}
objViewRegionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.PrjId) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.PrjId, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.PrjId] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetUpdUser(this clsViewRegionEN objViewRegionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewRegion.UpdUser);
}
objViewRegionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.UpdUser) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.UpdUser, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.UpdUser] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetUpdDate(this clsViewRegionEN objViewRegionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewRegion.UpdDate);
}
objViewRegionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.UpdDate) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.UpdDate, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.UpdDate] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetMemo(this clsViewRegionEN objViewRegionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewRegion.Memo);
}
objViewRegionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.Memo) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.Memo, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.Memo] = strComparisonOp;
}
}
return objViewRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionEN SetClsName(this clsViewRegionEN objViewRegionEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, conViewRegion.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conViewRegion.ClsName);
}
objViewRegionEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionEN.dicFldComparisonOp.ContainsKey(conViewRegion.ClsName) == false)
{
objViewRegionEN.dicFldComparisonOp.Add(conViewRegion.ClsName, strComparisonOp);
}
else
{
objViewRegionEN.dicFldComparisonOp[conViewRegion.ClsName] = strComparisonOp;
}
}
return objViewRegionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewRegionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewRegionEN objViewRegionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewRegionEN.CheckPropertyNew();
clsViewRegionEN objViewRegionCond = new clsViewRegionEN();
string strCondition = objViewRegionCond
.SetRegionId(objViewRegionEN.RegionId, "<>")
.SetPrjId(objViewRegionEN.PrjId, "=")
.SetClsName(objViewRegionEN.ClsName, "=")
.GetCombineCondition();
objViewRegionEN._IsCheckProperty = true;
bool bolIsExist = clsViewRegionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_ClsName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewRegionEN.Update();
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
 /// <param name = "objViewRegion">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewRegionEN objViewRegion)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewRegionEN objViewRegionCond = new clsViewRegionEN();
string strCondition = objViewRegionCond
.SetPrjId(objViewRegion.PrjId, "=")
.SetClsName(objViewRegion.ClsName, "=")
.GetCombineCondition();
objViewRegion._IsCheckProperty = true;
bool bolIsExist = clsViewRegionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewRegion.RegionId = clsViewRegionBL.GetFirstID_S(strCondition);
objViewRegion.UpdateWithCondition(strCondition);
}
else
{
objViewRegion.RegionId = clsViewRegionBL.GetMaxStrId_S();
objViewRegion.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionEN objViewRegionEN)
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionBL.ViewRegionDA.UpdateBySql2(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionEN objViewRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionBL.ViewRegionDA.UpdateBySql2(objViewRegionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionEN objViewRegionEN, string strWhereCond)
{
try
{
bool bolResult = clsViewRegionBL.ViewRegionDA.UpdateBySqlWithCondition(objViewRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionEN objViewRegionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewRegionBL.ViewRegionDA.UpdateBySqlWithConditionTransaction(objViewRegionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewRegionEN objViewRegionEN)
{
try
{
int intRecNum = clsViewRegionBL.ViewRegionDA.DelRecord(objViewRegionEN.RegionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
 public static void CopyTo(this clsViewRegionEN objViewRegionENS, clsViewRegionEN objViewRegionENT)
{
try
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.FileName = objViewRegionENS.FileName; //文件名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.ColNum = objViewRegionENS.ColNum; //列数
objViewRegionENT.ContainerTypeId = objViewRegionENS.ContainerTypeId; //容器类型Id
objViewRegionENT.PageDispModeId = objViewRegionENS.PageDispModeId; //页面显示模式Id
objViewRegionENT.InOutTypeId = objViewRegionENS.InOutTypeId; //INOUT类型ID
objViewRegionENT.TabId = objViewRegionENS.TabId; //表ID
objViewRegionENT.KeyId4Test = objViewRegionENS.KeyId4Test; //测试关键字Id
objViewRegionENT.ErrMsg = objViewRegionENS.ErrMsg; //错误信息
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程Id
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.ClsName = objViewRegionENS.ClsName; //类名
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
 /// <param name = "objViewRegionENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionEN:objViewRegionENT</returns>
 public static clsViewRegionEN CopyTo(this clsViewRegionEN objViewRegionENS)
{
try
{
 clsViewRegionEN objViewRegionENT = new clsViewRegionEN()
{
RegionId = objViewRegionENS.RegionId, //区域Id
RegionName = objViewRegionENS.RegionName, //区域名称
RegionTypeId = objViewRegionENS.RegionTypeId, //区域类型Id
FileName = objViewRegionENS.FileName, //文件名
Height = objViewRegionENS.Height, //高度
Width = objViewRegionENS.Width, //宽
ColNum = objViewRegionENS.ColNum, //列数
ContainerTypeId = objViewRegionENS.ContainerTypeId, //容器类型Id
PageDispModeId = objViewRegionENS.PageDispModeId, //页面显示模式Id
InOutTypeId = objViewRegionENS.InOutTypeId, //INOUT类型ID
TabId = objViewRegionENS.TabId, //表ID
KeyId4Test = objViewRegionENS.KeyId4Test, //测试关键字Id
ErrMsg = objViewRegionENS.ErrMsg, //错误信息
PrjId = objViewRegionENS.PrjId, //工程Id
UpdUser = objViewRegionENS.UpdUser, //修改者
UpdDate = objViewRegionENS.UpdDate, //修改日期
Memo = objViewRegionENS.Memo, //说明
ClsName = objViewRegionENS.ClsName, //类名
};
 return objViewRegionENT;
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
public static void CheckPropertyNew(this clsViewRegionEN objViewRegionEN)
{
 clsViewRegionBL.ViewRegionDA.CheckPropertyNew(objViewRegionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewRegionEN objViewRegionEN)
{
 clsViewRegionBL.ViewRegionDA.CheckProperty4Condition(objViewRegionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewRegionEN objViewRegionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewRegionCond.IsUpdated(conViewRegion.RegionId) == true)
{
string strComparisonOpRegionId = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionId, objViewRegionCond.RegionId, strComparisonOpRegionId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.RegionName) == true)
{
string strComparisonOpRegionName = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionName, objViewRegionCond.RegionName, strComparisonOpRegionName);
}
if (objViewRegionCond.IsUpdated(conViewRegion.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.RegionTypeId, objViewRegionCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.FileName) == true)
{
string strComparisonOpFileName = objViewRegionCond.dicFldComparisonOp[conViewRegion.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.FileName, objViewRegionCond.FileName, strComparisonOpFileName);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Height) == true)
{
string strComparisonOpHeight = objViewRegionCond.dicFldComparisonOp[conViewRegion.Height];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.Height, objViewRegionCond.Height, strComparisonOpHeight);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Width) == true)
{
string strComparisonOpWidth = objViewRegionCond.dicFldComparisonOp[conViewRegion.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.Width, objViewRegionCond.Width, strComparisonOpWidth);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ColNum) == true)
{
string strComparisonOpColNum = objViewRegionCond.dicFldComparisonOp[conViewRegion.ColNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegion.ColNum, objViewRegionCond.ColNum, strComparisonOpColNum);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ContainerTypeId, objViewRegionCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.PageDispModeId) == true)
{
string strComparisonOpPageDispModeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.PageDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.PageDispModeId, objViewRegionCond.PageDispModeId, strComparisonOpPageDispModeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objViewRegionCond.dicFldComparisonOp[conViewRegion.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.InOutTypeId, objViewRegionCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.TabId) == true)
{
string strComparisonOpTabId = objViewRegionCond.dicFldComparisonOp[conViewRegion.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.TabId, objViewRegionCond.TabId, strComparisonOpTabId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objViewRegionCond.dicFldComparisonOp[conViewRegion.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.KeyId4Test, objViewRegionCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewRegionCond.dicFldComparisonOp[conViewRegion.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ErrMsg, objViewRegionCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewRegionCond.IsUpdated(conViewRegion.PrjId) == true)
{
string strComparisonOpPrjId = objViewRegionCond.dicFldComparisonOp[conViewRegion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.PrjId, objViewRegionCond.PrjId, strComparisonOpPrjId);
}
if (objViewRegionCond.IsUpdated(conViewRegion.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewRegionCond.dicFldComparisonOp[conViewRegion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.UpdUser, objViewRegionCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewRegionCond.IsUpdated(conViewRegion.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewRegionCond.dicFldComparisonOp[conViewRegion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.UpdDate, objViewRegionCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewRegionCond.IsUpdated(conViewRegion.Memo) == true)
{
string strComparisonOpMemo = objViewRegionCond.dicFldComparisonOp[conViewRegion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.Memo, objViewRegionCond.Memo, strComparisonOpMemo);
}
if (objViewRegionCond.IsUpdated(conViewRegion.ClsName) == true)
{
string strComparisonOpClsName = objViewRegionCond.dicFldComparisonOp[conViewRegion.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegion.ClsName, objViewRegionCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewRegion(界面区域), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_ClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewRegionEN objViewRegionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewRegionEN == null) return true;
if (objViewRegionEN.RegionId == null || objViewRegionEN.RegionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
if (clsViewRegionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RegionId !=  '{0}'", objViewRegionEN.RegionId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
if (clsViewRegionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewRegion(界面区域), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewRegionEN objViewRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewRegionEN == null) return "";
if (objViewRegionEN.RegionId == null || objViewRegionEN.RegionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RegionId !=  '{0}'", objViewRegionEN.RegionId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewRegionEN.PrjId);
 sbCondition.AppendFormat(" and ClsName = '{0}'", objViewRegionEN.ClsName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewRegion
{
public virtual bool UpdRelaTabDate(string strRegionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewRegionBL
{
public static RelatedActions_ViewRegion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewRegionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewRegionDA ViewRegionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewRegionDA();
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
 public clsViewRegionBL()
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
if (string.IsNullOrEmpty(clsViewRegionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionEN._ConnectString);
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
public static DataTable GetDataTable_ViewRegion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewRegionDA.GetDataTable_ViewRegion(strWhereCond);
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
objDT = ViewRegionDA.GetDataTable(strWhereCond);
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
objDT = ViewRegionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewRegionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewRegionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewRegionDA.GetDataTable_Top(objTopPara);
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
objDT = ViewRegionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRegionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewRegionEN> GetObjLstByRegionIdLst(List<string> arrRegionIdLst)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRegionIdLst, true);
 string strWhereCond = string.Format("RegionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRegionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewRegionEN> GetObjLstByRegionIdLstCache(List<string> arrRegionIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel =
arrViewRegionObjLstCache
.Where(x => arrRegionIdLst.Contains(x.RegionId));
return arrViewRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionEN> GetObjLst(string strWhereCond)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
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
public static List<clsViewRegionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewRegionEN> GetSubObjLstCache(clsViewRegionEN objViewRegionCond)
{
 string strPrjId = objViewRegionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewRegionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewRegionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegion._AttributeName)
{
if (objViewRegionCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCond[strFldName].ToString());
}
else
{
if (objViewRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionCond[strFldName]));
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
public static List<clsViewRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
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
public static List<clsViewRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
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
List<clsViewRegionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewRegionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
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
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
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
public static List<clsViewRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
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
public static List<clsViewRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewRegionEN> arrObjLst = new List<clsViewRegionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionEN objViewRegionEN = new clsViewRegionEN();
try
{
objViewRegionEN.RegionId = objRow[conViewRegion.RegionId].ToString().Trim(); //区域Id
objViewRegionEN.RegionName = objRow[conViewRegion.RegionName].ToString().Trim(); //区域名称
objViewRegionEN.RegionTypeId = objRow[conViewRegion.RegionTypeId].ToString().Trim(); //区域类型Id
objViewRegionEN.FileName = objRow[conViewRegion.FileName] == DBNull.Value ? null : objRow[conViewRegion.FileName].ToString().Trim(); //文件名
objViewRegionEN.Height = objRow[conViewRegion.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Height].ToString().Trim()); //高度
objViewRegionEN.Width = objRow[conViewRegion.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.Width].ToString().Trim()); //宽
objViewRegionEN.ColNum = objRow[conViewRegion.ColNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewRegion.ColNum].ToString().Trim()); //列数
objViewRegionEN.ContainerTypeId = objRow[conViewRegion.ContainerTypeId] == DBNull.Value ? null : objRow[conViewRegion.ContainerTypeId].ToString().Trim(); //容器类型Id
objViewRegionEN.PageDispModeId = objRow[conViewRegion.PageDispModeId] == DBNull.Value ? null : objRow[conViewRegion.PageDispModeId].ToString().Trim(); //页面显示模式Id
objViewRegionEN.InOutTypeId = objRow[conViewRegion.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRegionEN.TabId = objRow[conViewRegion.TabId].ToString().Trim(); //表ID
objViewRegionEN.KeyId4Test = objRow[conViewRegion.KeyId4Test] == DBNull.Value ? null : objRow[conViewRegion.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewRegionEN.ErrMsg = objRow[conViewRegion.ErrMsg] == DBNull.Value ? null : objRow[conViewRegion.ErrMsg].ToString().Trim(); //错误信息
objViewRegionEN.PrjId = objRow[conViewRegion.PrjId].ToString().Trim(); //工程Id
objViewRegionEN.UpdUser = objRow[conViewRegion.UpdUser] == DBNull.Value ? null : objRow[conViewRegion.UpdUser].ToString().Trim(); //修改者
objViewRegionEN.UpdDate = objRow[conViewRegion.UpdDate] == DBNull.Value ? null : objRow[conViewRegion.UpdDate].ToString().Trim(); //修改日期
objViewRegionEN.Memo = objRow[conViewRegion.Memo] == DBNull.Value ? null : objRow[conViewRegion.Memo].ToString().Trim(); //说明
objViewRegionEN.ClsName = objRow[conViewRegion.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionEN.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewRegionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewRegion(ref clsViewRegionEN objViewRegionEN)
{
bool bolResult = ViewRegionDA.GetViewRegion(ref objViewRegionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionEN GetObjByRegionId(string strRegionId)
{
if (strRegionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRegionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRegionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRegionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewRegionEN objViewRegionEN = ViewRegionDA.GetObjByRegionId(strRegionId);
return objViewRegionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewRegionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewRegionEN objViewRegionEN = ViewRegionDA.GetFirstObj(strWhereCond);
 return objViewRegionEN;
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
public static clsViewRegionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewRegionEN objViewRegionEN = ViewRegionDA.GetObjByDataRow(objRow);
 return objViewRegionEN;
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
public static clsViewRegionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewRegionEN objViewRegionEN = ViewRegionDA.GetObjByDataRow(objRow);
 return objViewRegionEN;
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
 /// <param name = "strRegionId">所给的关键字</param>
 /// <param name = "lstViewRegionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionEN GetObjByRegionIdFromList(string strRegionId, List<clsViewRegionEN> lstViewRegionObjLst)
{
foreach (clsViewRegionEN objViewRegionEN in lstViewRegionObjLst)
{
if (objViewRegionEN.RegionId == strRegionId)
{
return objViewRegionEN;
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
 string strMaxRegionId;
 try
 {
 strMaxRegionId = clsViewRegionDA.GetMaxStrId();
 return strMaxRegionId;
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
 string strRegionId;
 try
 {
 strRegionId = new clsViewRegionDA().GetFirstID(strWhereCond);
 return strRegionId;
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
 arrList = ViewRegionDA.GetID(strWhereCond);
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
bool bolIsExist = ViewRegionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRegionId)
{
if (string.IsNullOrEmpty(strRegionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRegionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ViewRegionDA.IsExist(strRegionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRegionId">区域Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRegionId, string strOpUser)
{
clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId(strRegionId);
objViewRegionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewRegionEN.UpdUser = strOpUser;
return clsViewRegionBL.UpdateBySql2(objViewRegionEN);
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
 bolIsExist = clsViewRegionDA.IsExistTable();
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
 bolIsExist = ViewRegionDA.IsExistTable(strTabName);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRegionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],类名 = [{1}]的数据已经存在!(in clsViewRegionBL.AddNewRecordBySql2)", objViewRegionEN.PrjId,objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
bool bolResult = ViewRegionDA.AddNewRecordBySQL2(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewRegionEN objViewRegionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRegionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],类名 = [{1}]的数据已经存在!(in clsViewRegionBL.AddNewRecordBySql2WithReturnKey)", objViewRegionEN.PrjId,objViewRegionEN.ClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true || clsViewRegionBL.IsExist(objViewRegionEN.RegionId) == true)
 {
     objViewRegionEN.RegionId = clsViewRegionBL.GetMaxStrId_S();
 }
string strKey = ViewRegionDA.AddNewRecordBySQL2WithReturnKey(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewRegionEN objViewRegionEN)
{
try
{
bool bolResult = ViewRegionDA.Update(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "objViewRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewRegionEN objViewRegionEN)
{
 if (string.IsNullOrEmpty(objViewRegionEN.RegionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewRegionDA.UpdateBySql2(objViewRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionBL.ReFreshCache(objViewRegionEN.PrjId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRegionId)
{
try
{
 clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId(strRegionId);

if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(objViewRegionEN.RegionId, objViewRegionEN.UpdUser);
}
if (objViewRegionEN != null)
{
int intRecNum = ViewRegionDA.DelRecord(strRegionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRegionEN.PrjId);
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
/// <param name="strRegionId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strRegionId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRegionDA.GetSpecSQLObj();
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
//删除与表:[ViewRegion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewRegion.RegionId,
//strRegionId);
//        clsViewRegionBL.DelViewRegionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionBL.DelRecord(strRegionId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRegionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRegionId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewRegionBL.relatedActions != null)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(strRegionId, "UpdRelaTabDate");
}
bool bolResult = ViewRegionDA.DelRecord(strRegionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRegionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewRegions(List<string> arrRegionIdLst)
{
if (arrRegionIdLst.Count == 0) return 0;
try
{
if (clsViewRegionBL.relatedActions != null)
{
foreach (var strRegionId in arrRegionIdLst)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(strRegionId, "UpdRelaTabDate");
}
}
 clsViewRegionEN objViewRegionEN = clsViewRegionBL.GetObjByRegionId(arrRegionIdLst[0]);
int intDelRecNum = ViewRegionDA.DelViewRegion(arrRegionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRegionEN.PrjId);
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
public static int DelViewRegionsByCond(string strWhereCond)
{
try
{
if (clsViewRegionBL.relatedActions != null)
{
List<string> arrRegionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRegionId in arrRegionId)
{
clsViewRegionBL.relatedActions.UpdRelaTabDate(strRegionId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewRegion.PrjId, strWhereCond);
int intRecNum = ViewRegionDA.DelViewRegion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewRegion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRegionId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRegionId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRegionDA.GetSpecSQLObj();
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
//删除与表:[ViewRegion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionBL.DelRecord(strRegionId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRegionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewRegionENS">源对象</param>
 /// <param name = "objViewRegionENT">目标对象</param>
 public static void CopyTo(clsViewRegionEN objViewRegionENS, clsViewRegionEN objViewRegionENT)
{
try
{
objViewRegionENT.RegionId = objViewRegionENS.RegionId; //区域Id
objViewRegionENT.RegionName = objViewRegionENS.RegionName; //区域名称
objViewRegionENT.RegionTypeId = objViewRegionENS.RegionTypeId; //区域类型Id
objViewRegionENT.FileName = objViewRegionENS.FileName; //文件名
objViewRegionENT.Height = objViewRegionENS.Height; //高度
objViewRegionENT.Width = objViewRegionENS.Width; //宽
objViewRegionENT.ColNum = objViewRegionENS.ColNum; //列数
objViewRegionENT.ContainerTypeId = objViewRegionENS.ContainerTypeId; //容器类型Id
objViewRegionENT.PageDispModeId = objViewRegionENS.PageDispModeId; //页面显示模式Id
objViewRegionENT.InOutTypeId = objViewRegionENS.InOutTypeId; //INOUT类型ID
objViewRegionENT.TabId = objViewRegionENS.TabId; //表ID
objViewRegionENT.KeyId4Test = objViewRegionENS.KeyId4Test; //测试关键字Id
objViewRegionENT.ErrMsg = objViewRegionENS.ErrMsg; //错误信息
objViewRegionENT.PrjId = objViewRegionENS.PrjId; //工程Id
objViewRegionENT.UpdUser = objViewRegionENS.UpdUser; //修改者
objViewRegionENT.UpdDate = objViewRegionENS.UpdDate; //修改日期
objViewRegionENT.Memo = objViewRegionENS.Memo; //说明
objViewRegionENT.ClsName = objViewRegionENS.ClsName; //类名
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
 /// <param name = "objViewRegionEN">源简化对象</param>
 public static void SetUpdFlag(clsViewRegionEN objViewRegionEN)
{
try
{
objViewRegionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewRegionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewRegion.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.RegionId = objViewRegionEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conViewRegion.RegionName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.RegionName = objViewRegionEN.RegionName; //区域名称
}
if (arrFldSet.Contains(conViewRegion.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.RegionTypeId = objViewRegionEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conViewRegion.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.FileName = objViewRegionEN.FileName == "[null]" ? null :  objViewRegionEN.FileName; //文件名
}
if (arrFldSet.Contains(conViewRegion.Height, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.Height = objViewRegionEN.Height; //高度
}
if (arrFldSet.Contains(conViewRegion.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.Width = objViewRegionEN.Width; //宽
}
if (arrFldSet.Contains(conViewRegion.ColNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.ColNum = objViewRegionEN.ColNum; //列数
}
if (arrFldSet.Contains(conViewRegion.ContainerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.ContainerTypeId = objViewRegionEN.ContainerTypeId == "[null]" ? null :  objViewRegionEN.ContainerTypeId; //容器类型Id
}
if (arrFldSet.Contains(conViewRegion.PageDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.PageDispModeId = objViewRegionEN.PageDispModeId == "[null]" ? null :  objViewRegionEN.PageDispModeId; //页面显示模式Id
}
if (arrFldSet.Contains(conViewRegion.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.InOutTypeId = objViewRegionEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(conViewRegion.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.TabId = objViewRegionEN.TabId; //表ID
}
if (arrFldSet.Contains(conViewRegion.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.KeyId4Test = objViewRegionEN.KeyId4Test == "[null]" ? null :  objViewRegionEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(conViewRegion.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.ErrMsg = objViewRegionEN.ErrMsg == "[null]" ? null :  objViewRegionEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conViewRegion.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.PrjId = objViewRegionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewRegion.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.UpdUser = objViewRegionEN.UpdUser == "[null]" ? null :  objViewRegionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewRegion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.UpdDate = objViewRegionEN.UpdDate == "[null]" ? null :  objViewRegionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewRegion.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.Memo = objViewRegionEN.Memo == "[null]" ? null :  objViewRegionEN.Memo; //说明
}
if (arrFldSet.Contains(conViewRegion.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionEN.ClsName = objViewRegionEN.ClsName; //类名
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
 /// <param name = "objViewRegionEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewRegionEN objViewRegionEN)
{
try
{
if (objViewRegionEN.FileName == "[null]") objViewRegionEN.FileName = null; //文件名
if (objViewRegionEN.ContainerTypeId == "[null]") objViewRegionEN.ContainerTypeId = null; //容器类型Id
if (objViewRegionEN.PageDispModeId == "[null]") objViewRegionEN.PageDispModeId = null; //页面显示模式Id
if (objViewRegionEN.KeyId4Test == "[null]") objViewRegionEN.KeyId4Test = null; //测试关键字Id
if (objViewRegionEN.ErrMsg == "[null]") objViewRegionEN.ErrMsg = null; //错误信息
if (objViewRegionEN.UpdUser == "[null]") objViewRegionEN.UpdUser = null; //修改者
if (objViewRegionEN.UpdDate == "[null]") objViewRegionEN.UpdDate = null; //修改日期
if (objViewRegionEN.Memo == "[null]") objViewRegionEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewRegionEN objViewRegionEN)
{
 ViewRegionDA.CheckPropertyNew(objViewRegionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewRegionEN objViewRegionEN)
{
 ViewRegionDA.CheckProperty4Condition(objViewRegionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RegionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面区域]...","0");
List<clsViewRegionEN> arrViewRegionObjLst = GetAllViewRegionObjLstCache(strPrjId); 
objDDL.DataValueField = conViewRegion.RegionId;
objDDL.DataTextField = conViewRegion.RegionName;
objDDL.DataSource = arrViewRegionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsViewRegionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionBL没有刷新缓存机制(clsViewRegionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RegionId");
//if (arrViewRegionObjLstCache == null)
//{
//arrViewRegionObjLstCache = ViewRegionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionEN GetObjByRegionIdCache(string strRegionId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrViewRegionObjLst_Sel =
arrViewRegionObjLstCache
.Where(x=> x.RegionId == strRegionId 
);
if (arrViewRegionObjLst_Sel.Count() == 0)
{
   clsViewRegionEN obj = clsViewRegionBL.GetObjByRegionId(strRegionId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strRegionId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRegionNameByRegionIdCache(string strRegionId, string strPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return "";
//获取缓存中的对象列表
clsViewRegionEN objViewRegion = GetObjByRegionIdCache(strRegionId, strPrjId);
if (objViewRegion == null) return "";
return objViewRegion.RegionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRegionIdCache(string strRegionId, string strPrjId)
{
if (string.IsNullOrEmpty(strRegionId) == true) return "";
//获取缓存中的对象列表
clsViewRegionEN objViewRegion = GetObjByRegionIdCache(strRegionId, strPrjId);
if (objViewRegion == null) return "";
return objViewRegion.RegionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionEN> GetAllViewRegionObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewRegionEN> arrViewRegionObjLstCache = GetObjLstCache(strPrjId); 
return arrViewRegionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewRegionEN> arrViewRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewRegionObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRegionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewRegionEN._RefreshTimeLst.Count == 0) return "";
return clsViewRegionEN._RefreshTimeLst[clsViewRegionEN._RefreshTimeLst.Count - 1];
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
if (clsViewRegionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewRegionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRegionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewRegionBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewRegion(界面区域)
 /// 唯一性条件:PrjId_ClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewRegionEN objViewRegionEN)
{
//检测记录是否存在
string strResult = ViewRegionDA.GetUniCondStr(objViewRegionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRegionId, string strPrjId)
{
if (strInFldName != conViewRegion.RegionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewRegion._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewRegion._AttributeName));
throw new Exception(strMsg);
}
var objViewRegion = clsViewRegionBL.GetObjByRegionIdCache(strRegionId, strPrjId);
if (objViewRegion == null) return "";
return objViewRegion[strOutFldName].ToString();
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
int intRecCount = clsViewRegionDA.GetRecCount(strTabName);
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
int intRecCount = clsViewRegionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewRegionDA.GetRecCount();
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
int intRecCount = clsViewRegionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewRegionEN objViewRegionCond)
{
 string strPrjId = objViewRegionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewRegionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewRegionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegion._AttributeName)
{
if (objViewRegionCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCond[strFldName].ToString());
}
else
{
if (objViewRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionCond[strFldName]));
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
 List<string> arrList = clsViewRegionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewRegionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionDA.SetFldValue(clsViewRegionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewRegionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewRegion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) primary key, "); 
 // /**区域名称*/ 
 strCreateTabCode.Append(" RegionName varchar(50) not Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) not Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) Null, "); 
 // /**高度*/ 
 strCreateTabCode.Append(" Height int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**列数*/ 
 strCreateTabCode.Append(" ColNum int Null, "); 
 // /**容器类型Id*/ 
 strCreateTabCode.Append(" ContainerTypeId char(4) Null, "); 
 // /**页面显示模式Id*/ 
 strCreateTabCode.Append(" PageDispModeId char(2) Null, "); 
 // /**INOUT类型ID*/ 
 strCreateTabCode.Append(" InOutTypeId char(2) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**测试关键字Id*/ 
 strCreateTabCode.Append(" KeyId4Test varchar(50) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**区域类型简名*/ 
 strCreateTabCode.Append(" RegionTypeSimName varchar(10) Null, "); 
 // /**容器类型名*/ 
 strCreateTabCode.Append(" ContainerTypeName varchar(50) Null, "); 
 // /**页面显示模式名称*/ 
 strCreateTabCode.Append(" PageDispModeName varchar(50) Null, "); 
 // /**INOUT类型名称*/ 
 strCreateTabCode.Append(" InOutTypeName varchar(30) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**区域类型序号*/ 
 strCreateTabCode.Append(" RegionTypeOrderNum int Null, "); 
 // /**区域类型名称*/ 
 strCreateTabCode.Append(" RegionTypeName varchar(30) not Null, "); 
 // /**可使用字段数*/ 
 strCreateTabCode.Append(" FldCountInUse int Null, "); 
 // /**引用数*/ 
 strCreateTabCode.Append(" ReferNum int not Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) not Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**PrjIdRefer*/ 
 strCreateTabCode.Append(" PrjIdRefer char(4) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面区域(ViewRegion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewRegion : clsCommFun4BLV2
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
clsViewRegionBL.ReFreshThisCache(strPrjId);
}
}

}