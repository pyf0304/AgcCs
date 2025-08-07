
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupFldsBL
 表名:ViewGroupFlds(00050136)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class clsViewGroupFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewGroupFldsEN GetObj(this K_mId_ViewGroupFlds myKey)
{
clsViewGroupFldsEN objViewGroupFldsEN = clsViewGroupFldsBL.ViewGroupFldsDA.GetObjBymId(myKey.Value);
return objViewGroupFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewGroupFldsEN objViewGroupFldsEN)
{
if (CheckUniqueness_TabFldId_ViewGroupId(objViewGroupFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!表字段ID = [{0}],界面组ID = [{1}]的数据已经存在!(in clsViewGroupFldsBL.AddNewRecord)", objViewGroupFldsEN.TabFldId,objViewGroupFldsEN.ViewGroupId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewGroupFldsBL.ViewGroupFldsDA.AddNewRecordBySQL2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewGroupFldsEN objViewGroupFldsEN)
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
objViewGroupFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objViewGroupFldsEN. CheckUniqueness_TabFldId_ViewGroupId() == false)
{
strMsg = string.Format("(表字段ID(TabFldId)=[{0}],界面组ID(ViewGroupId)=[{1}])已经存在，不能重复!", objViewGroupFldsEN.TabFldId, objViewGroupFldsEN.ViewGroupId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewGroupFldsEN.AddNewRecord();
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewGroupFldsEN objViewGroupFldsEN)
{
if (CheckUniqueness_TabFldId_ViewGroupId(objViewGroupFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!表字段ID = [{0}],界面组ID = [{1}]的数据已经存在!(in clsViewGroupFldsBL.AddNewRecordWithReturnKey)", objViewGroupFldsEN.TabFldId,objViewGroupFldsEN.ViewGroupId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewGroupFldsBL.ViewGroupFldsDA.AddNewRecordBySQL2WithReturnKey(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetmId(this clsViewGroupFldsEN objViewGroupFldsEN, long lngmId, string strComparisonOp="")
	{
objViewGroupFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.mId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.mId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.mId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetCtlTypeId(this clsViewGroupFldsEN objViewGroupFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conViewGroupFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conViewGroupFlds.CtlTypeId);
}
objViewGroupFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.CtlTypeId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.CtlTypeId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.CtlTypeId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDdlItemsOptionId(this clsViewGroupFldsEN objViewGroupFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDdlItemsOptionId, conViewGroupFlds.DdlItemsOptionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conViewGroupFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conViewGroupFlds.DdlItemsOptionId);
}
objViewGroupFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.DdlItemsOptionId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDsCondStr(this clsViewGroupFldsEN objViewGroupFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conViewGroupFlds.DsCondStr);
}
objViewGroupFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.DsCondStr) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.DsCondStr, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.DsCondStr] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDs_DataTextFieldId(this clsViewGroupFldsEN objViewGroupFldsEN, string strDs_DataTextFieldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDs_DataTextFieldId, 8, conViewGroupFlds.Ds_DataTextFieldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDs_DataTextFieldId, 8, conViewGroupFlds.Ds_DataTextFieldId);
}
objViewGroupFldsEN.Ds_DataTextFieldId = strDs_DataTextFieldId; //数据源文本字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.Ds_DataTextFieldId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.Ds_DataTextFieldId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.Ds_DataTextFieldId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDsDataValueFieldId(this clsViewGroupFldsEN objViewGroupFldsEN, string strDsDataValueFieldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsDataValueFieldId, 8, conViewGroupFlds.DsDataValueFieldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsDataValueFieldId, 8, conViewGroupFlds.DsDataValueFieldId);
}
objViewGroupFldsEN.DsDataValueFieldId = strDsDataValueFieldId; //数据源值字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.DsDataValueFieldId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.DsDataValueFieldId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.DsDataValueFieldId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDsSqlStr(this clsViewGroupFldsEN objViewGroupFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conViewGroupFlds.DsSqlStr);
}
objViewGroupFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.DsSqlStr) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.DsSqlStr, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.DsSqlStr] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetDsTabId(this clsViewGroupFldsEN objViewGroupFldsEN, string strDsTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDsTabId, conViewGroupFlds.DsTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conViewGroupFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conViewGroupFlds.DsTabId);
}
objViewGroupFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.DsTabId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.DsTabId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.DsTabId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetItemsString(this clsViewGroupFldsEN objViewGroupFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, conViewGroupFlds.ItemsString);
}
objViewGroupFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.ItemsString) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.ItemsString, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.ItemsString] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetSeqNum(this clsViewGroupFldsEN objViewGroupFldsEN, int intSeqNum, string strComparisonOp="")
	{
objViewGroupFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.SeqNum) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.SeqNum, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.SeqNum] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetTabFldId(this clsViewGroupFldsEN objViewGroupFldsEN, long lngTabFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTabFldId, conViewGroupFlds.TabFldId);
objViewGroupFldsEN.TabFldId = lngTabFldId; //表字段ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.TabFldId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.TabFldId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.TabFldId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetUpdDate(this clsViewGroupFldsEN objViewGroupFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewGroupFlds.UpdDate);
}
objViewGroupFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.UpdDate) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.UpdDate, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.UpdDate] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetUserId(this clsViewGroupFldsEN objViewGroupFldsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conViewGroupFlds.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conViewGroupFlds.UserId);
}
objViewGroupFldsEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.UserId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.UserId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.UserId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetViewGroupId(this clsViewGroupFldsEN objViewGroupFldsEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupId, conViewGroupFlds.ViewGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, conViewGroupFlds.ViewGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, conViewGroupFlds.ViewGroupId);
}
objViewGroupFldsEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.ViewGroupId) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.ViewGroupId, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.ViewGroupId] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsViewGroupFldsEN SetMemo(this clsViewGroupFldsEN objViewGroupFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewGroupFlds.Memo);
}
objViewGroupFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupFldsEN.dicFldComparisonOp.ContainsKey(conViewGroupFlds.Memo) == false)
{
objViewGroupFldsEN.dicFldComparisonOp.Add(conViewGroupFlds.Memo, strComparisonOp);
}
else
{
objViewGroupFldsEN.dicFldComparisonOp[conViewGroupFlds.Memo] = strComparisonOp;
}
}
return objViewGroupFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewGroupFldsEN objViewGroupFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewGroupFldsEN.CheckPropertyNew();
clsViewGroupFldsEN objViewGroupFldsCond = new clsViewGroupFldsEN();
string strCondition = objViewGroupFldsCond
.SetmId(objViewGroupFldsEN.mId, "<>")
.SetTabFldId(objViewGroupFldsEN.TabFldId, "=")
.SetViewGroupId(objViewGroupFldsEN.ViewGroupId, "=")
.GetCombineCondition();
objViewGroupFldsEN._IsCheckProperty = true;
bool bolIsExist = clsViewGroupFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TabFldId_ViewGroupId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewGroupFldsEN.Update();
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
 /// <param name = "objViewGroupFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewGroupFldsEN objViewGroupFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewGroupFldsEN objViewGroupFldsCond = new clsViewGroupFldsEN();
string strCondition = objViewGroupFldsCond
.SetTabFldId(objViewGroupFlds.TabFldId, "=")
.SetViewGroupId(objViewGroupFlds.ViewGroupId, "=")
.GetCombineCondition();
objViewGroupFlds._IsCheckProperty = true;
bool bolIsExist = clsViewGroupFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewGroupFlds.mId = clsViewGroupFldsBL.GetFirstID_S(strCondition);
objViewGroupFlds.UpdateWithCondition(strCondition);
}
else
{
objViewGroupFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewGroupFldsEN objViewGroupFldsEN)
{
 if (objViewGroupFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewGroupFldsBL.ViewGroupFldsDA.UpdateBySql2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewGroupFldsEN objViewGroupFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewGroupFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewGroupFldsBL.ViewGroupFldsDA.UpdateBySql2(objViewGroupFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewGroupFldsEN objViewGroupFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsViewGroupFldsBL.ViewGroupFldsDA.UpdateBySqlWithCondition(objViewGroupFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewGroupFldsEN objViewGroupFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewGroupFldsBL.ViewGroupFldsDA.UpdateBySqlWithConditionTransaction(objViewGroupFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewGroupFldsEN objViewGroupFldsEN)
{
try
{
int intRecNum = clsViewGroupFldsBL.ViewGroupFldsDA.DelRecord(objViewGroupFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsENS">源对象</param>
 /// <param name = "objViewGroupFldsENT">目标对象</param>
 public static void CopyTo(this clsViewGroupFldsEN objViewGroupFldsENS, clsViewGroupFldsEN objViewGroupFldsENT)
{
try
{
objViewGroupFldsENT.mId = objViewGroupFldsENS.mId; //mId
objViewGroupFldsENT.CtlTypeId = objViewGroupFldsENS.CtlTypeId; //控件类型号
objViewGroupFldsENT.DdlItemsOptionId = objViewGroupFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewGroupFldsENT.DsCondStr = objViewGroupFldsENS.DsCondStr; //数据源条件串
objViewGroupFldsENT.Ds_DataTextFieldId = objViewGroupFldsENS.Ds_DataTextFieldId; //数据源文本字段Id
objViewGroupFldsENT.DsDataValueFieldId = objViewGroupFldsENS.DsDataValueFieldId; //数据源值字段Id
objViewGroupFldsENT.DsSqlStr = objViewGroupFldsENS.DsSqlStr; //数据源SQL串
objViewGroupFldsENT.DsTabId = objViewGroupFldsENS.DsTabId; //数据源表ID
objViewGroupFldsENT.ItemsString = objViewGroupFldsENS.ItemsString; //列表项串
objViewGroupFldsENT.SeqNum = objViewGroupFldsENS.SeqNum; //字段序号
objViewGroupFldsENT.TabFldId = objViewGroupFldsENS.TabFldId; //表字段ID
objViewGroupFldsENT.UpdDate = objViewGroupFldsENS.UpdDate; //修改日期
objViewGroupFldsENT.UserId = objViewGroupFldsENS.UserId; //用户Id
objViewGroupFldsENT.ViewGroupId = objViewGroupFldsENS.ViewGroupId; //界面组ID
objViewGroupFldsENT.Memo = objViewGroupFldsENS.Memo; //说明
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
 /// <param name = "objViewGroupFldsENS">源对象</param>
 /// <returns>目标对象=>clsViewGroupFldsEN:objViewGroupFldsENT</returns>
 public static clsViewGroupFldsEN CopyTo(this clsViewGroupFldsEN objViewGroupFldsENS)
{
try
{
 clsViewGroupFldsEN objViewGroupFldsENT = new clsViewGroupFldsEN()
{
mId = objViewGroupFldsENS.mId, //mId
CtlTypeId = objViewGroupFldsENS.CtlTypeId, //控件类型号
DdlItemsOptionId = objViewGroupFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DsCondStr = objViewGroupFldsENS.DsCondStr, //数据源条件串
Ds_DataTextFieldId = objViewGroupFldsENS.Ds_DataTextFieldId, //数据源文本字段Id
DsDataValueFieldId = objViewGroupFldsENS.DsDataValueFieldId, //数据源值字段Id
DsSqlStr = objViewGroupFldsENS.DsSqlStr, //数据源SQL串
DsTabId = objViewGroupFldsENS.DsTabId, //数据源表ID
ItemsString = objViewGroupFldsENS.ItemsString, //列表项串
SeqNum = objViewGroupFldsENS.SeqNum, //字段序号
TabFldId = objViewGroupFldsENS.TabFldId, //表字段ID
UpdDate = objViewGroupFldsENS.UpdDate, //修改日期
UserId = objViewGroupFldsENS.UserId, //用户Id
ViewGroupId = objViewGroupFldsENS.ViewGroupId, //界面组ID
Memo = objViewGroupFldsENS.Memo, //说明
};
 return objViewGroupFldsENT;
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
public static void CheckPropertyNew(this clsViewGroupFldsEN objViewGroupFldsEN)
{
 clsViewGroupFldsBL.ViewGroupFldsDA.CheckPropertyNew(objViewGroupFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewGroupFldsEN objViewGroupFldsEN)
{
 clsViewGroupFldsBL.ViewGroupFldsDA.CheckProperty4Condition(objViewGroupFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewGroupFldsEN objViewGroupFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.mId) == true)
{
string strComparisonOpmId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewGroupFlds.mId, objViewGroupFldsCond.mId, strComparisonOpmId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.CtlTypeId, objViewGroupFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.DdlItemsOptionId, objViewGroupFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.DsCondStr, objViewGroupFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.Ds_DataTextFieldId) == true)
{
string strComparisonOpDs_DataTextFieldId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.Ds_DataTextFieldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.Ds_DataTextFieldId, objViewGroupFldsCond.Ds_DataTextFieldId, strComparisonOpDs_DataTextFieldId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.DsDataValueFieldId) == true)
{
string strComparisonOpDsDataValueFieldId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.DsDataValueFieldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.DsDataValueFieldId, objViewGroupFldsCond.DsDataValueFieldId, strComparisonOpDsDataValueFieldId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.DsSqlStr, objViewGroupFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.DsTabId, objViewGroupFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.ItemsString, objViewGroupFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewGroupFlds.SeqNum, objViewGroupFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.TabFldId) == true)
{
string strComparisonOpTabFldId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.TabFldId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewGroupFlds.TabFldId, objViewGroupFldsCond.TabFldId, strComparisonOpTabFldId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.UpdDate, objViewGroupFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.UserId) == true)
{
string strComparisonOpUserId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.UserId, objViewGroupFldsCond.UserId, strComparisonOpUserId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.ViewGroupId, objViewGroupFldsCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objViewGroupFldsCond.IsUpdated(conViewGroupFlds.Memo) == true)
{
string strComparisonOpMemo = objViewGroupFldsCond.dicFldComparisonOp[conViewGroupFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroupFlds.Memo, objViewGroupFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewGroupFlds(界面组字段集合), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_TabFldId_ViewGroupId(this clsViewGroupFldsEN objViewGroupFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewGroupFldsEN == null) return true;
if (objViewGroupFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFldId = '{0}'", objViewGroupFldsEN.TabFldId);
 sbCondition.AppendFormat(" and ViewGroupId = '{0}'", objViewGroupFldsEN.ViewGroupId);
if (clsViewGroupFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewGroupFldsEN.mId);
 sbCondition.AppendFormat(" and TabFldId = '{0}'", objViewGroupFldsEN.TabFldId);
 sbCondition.AppendFormat(" and ViewGroupId = '{0}'", objViewGroupFldsEN.ViewGroupId);
if (clsViewGroupFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--ViewGroupFlds(界面组字段集合), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrTabFldId_ViewGroupId(this clsViewGroupFldsEN objViewGroupFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewGroupFldsEN == null) return "";
if (objViewGroupFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFldId = '{0}'", objViewGroupFldsEN.TabFldId);
 sbCondition.AppendFormat(" and ViewGroupId = '{0}'", objViewGroupFldsEN.ViewGroupId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewGroupFldsEN.mId);
 sbCondition.AppendFormat(" and TabFldId = '{0}'", objViewGroupFldsEN.TabFldId);
 sbCondition.AppendFormat(" and ViewGroupId = '{0}'", objViewGroupFldsEN.ViewGroupId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewGroupFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面组字段集合(ViewGroupFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewGroupFldsBL
{
public static RelatedActions_ViewGroupFlds relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "ViewGroupFldsListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "ViewGroupFldsList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsViewGroupFldsEN> arrViewGroupFldsObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewGroupFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewGroupFldsDA ViewGroupFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewGroupFldsDA();
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
 public clsViewGroupFldsBL()
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
if (string.IsNullOrEmpty(clsViewGroupFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewGroupFldsEN._ConnectString);
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
objDS = ViewGroupFldsDA.GetDataSet(strWhereCond);
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
objDS = ViewGroupFldsDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = ViewGroupFldsDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_ViewGroupFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewGroupFldsDA.GetDataTable_ViewGroupFlds(strWhereCond);
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
objDT = ViewGroupFldsDA.GetDataTable(strWhereCond);
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
objDT = ViewGroupFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewGroupFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewGroupFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewGroupFldsDA.GetDataTable_Top(objTopPara);
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
objDT = ViewGroupFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewGroupFldsDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = ViewGroupFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewGroupFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = ViewGroupFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = ViewGroupFldsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = ViewGroupFldsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = ViewGroupFldsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsViewGroupFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
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
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewGroupFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsViewGroupFldsEN._CurrTabName);
List<clsViewGroupFldsEN> arrViewGroupFldsObjLstCache = GetObjLstCache();
IEnumerable <clsViewGroupFldsEN> arrViewGroupFldsObjLst_Sel =
arrViewGroupFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrViewGroupFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupFldsEN> GetObjLst(string strWhereCond)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static List<clsViewGroupFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewGroupFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewGroupFldsEN> GetSubObjLstCache(clsViewGroupFldsEN objViewGroupFldsCond)
{
List<clsViewGroupFldsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewGroupFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewGroupFlds.AttributeName)
{
if (objViewGroupFldsCond.IsUpdated(strFldName) == false) continue;
if (objViewGroupFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else
{
if (objViewGroupFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewGroupFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewGroupFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
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
public static List<clsViewGroupFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static List<clsViewGroupFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
List<clsViewGroupFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewGroupFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewGroupFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
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
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static List<clsViewGroupFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewGroupFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewGroupFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static List<clsViewGroupFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static IEnumerable<clsViewGroupFldsEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsViewGroupFldsEN objViewGroupFldsCond, string strOrderBy)
{
List<clsViewGroupFldsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewGroupFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewGroupFlds.AttributeName)
{
if (objViewGroupFldsCond.IsUpdated(strFldName) == false) continue;
if (objViewGroupFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else
{
if (objViewGroupFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewGroupFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewGroupFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
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
public static IEnumerable<clsViewGroupFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsViewGroupFldsEN objViewGroupFldsCond = JsonConvert.DeserializeObject<clsViewGroupFldsEN>(objPagerPara.whereCond);
if (objViewGroupFldsCond.sfFldComparisonOp == null)
{
objViewGroupFldsCond.dicFldComparisonOp = null;
}
else
{
objViewGroupFldsCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objViewGroupFldsCond.sfFldComparisonOp);
}
clsViewGroupFldsBL.SetUpdFlag(objViewGroupFldsCond);
 try
{
CheckProperty4Condition(objViewGroupFldsCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsViewGroupFldsBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objViewGroupFldsCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupFldsEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsViewGroupFldsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
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
public static List<clsViewGroupFldsEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewGroupFldsEN> arrObjLst = new List<clsViewGroupFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
try
{
objViewGroupFldsEN.mId = Int32.Parse(objRow[conViewGroupFlds.mId].ToString().Trim()); //mId
objViewGroupFldsEN.CtlTypeId = objRow[conViewGroupFlds.CtlTypeId] == DBNull.Value ? null : objRow[conViewGroupFlds.CtlTypeId].ToString().Trim(); //控件类型号
objViewGroupFldsEN.DdlItemsOptionId = objRow[conViewGroupFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objViewGroupFldsEN.DsCondStr = objRow[conViewGroupFlds.DsCondStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsCondStr].ToString().Trim(); //数据源条件串
objViewGroupFldsEN.Ds_DataTextFieldId = objRow[conViewGroupFlds.Ds_DataTextFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.Ds_DataTextFieldId].ToString().Trim(); //数据源文本字段Id
objViewGroupFldsEN.DsDataValueFieldId = objRow[conViewGroupFlds.DsDataValueFieldId] == DBNull.Value ? null : objRow[conViewGroupFlds.DsDataValueFieldId].ToString().Trim(); //数据源值字段Id
objViewGroupFldsEN.DsSqlStr = objRow[conViewGroupFlds.DsSqlStr] == DBNull.Value ? null : objRow[conViewGroupFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objViewGroupFldsEN.DsTabId = objRow[conViewGroupFlds.DsTabId].ToString().Trim(); //数据源表ID
objViewGroupFldsEN.ItemsString = objRow[conViewGroupFlds.ItemsString] == DBNull.Value ? null : objRow[conViewGroupFlds.ItemsString].ToString().Trim(); //列表项串
objViewGroupFldsEN.SeqNum = objRow[conViewGroupFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewGroupFlds.SeqNum].ToString().Trim()); //字段序号
objViewGroupFldsEN.TabFldId = Int32.Parse(objRow[conViewGroupFlds.TabFldId].ToString().Trim()); //表字段ID
objViewGroupFldsEN.UpdDate = objRow[conViewGroupFlds.UpdDate] == DBNull.Value ? null : objRow[conViewGroupFlds.UpdDate].ToString().Trim(); //修改日期
objViewGroupFldsEN.UserId = objRow[conViewGroupFlds.UserId].ToString().Trim(); //用户Id
objViewGroupFldsEN.ViewGroupId = objRow[conViewGroupFlds.ViewGroupId].ToString().Trim(); //界面组ID
objViewGroupFldsEN.Memo = objRow[conViewGroupFlds.Memo] == DBNull.Value ? null : objRow[conViewGroupFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewGroupFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewGroupFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewGroupFlds(ref clsViewGroupFldsEN objViewGroupFldsEN)
{
bool bolResult = ViewGroupFldsDA.GetViewGroupFlds(ref objViewGroupFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewGroupFldsEN GetObjBymId(long lngmId)
{
clsViewGroupFldsEN objViewGroupFldsEN = ViewGroupFldsDA.GetObjBymId(lngmId);
return objViewGroupFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewGroupFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewGroupFldsEN objViewGroupFldsEN = ViewGroupFldsDA.GetFirstObj(strWhereCond);
 return objViewGroupFldsEN;
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
public static clsViewGroupFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewGroupFldsEN objViewGroupFldsEN = ViewGroupFldsDA.GetObjByDataRow(objRow);
 return objViewGroupFldsEN;
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
public static clsViewGroupFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewGroupFldsEN objViewGroupFldsEN = ViewGroupFldsDA.GetObjByDataRow(objRow);
 return objViewGroupFldsEN;
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
 /// <param name = "lstViewGroupFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewGroupFldsEN GetObjBymIdFromList(long lngmId, List<clsViewGroupFldsEN> lstViewGroupFldsObjLst)
{
foreach (clsViewGroupFldsEN objViewGroupFldsEN in lstViewGroupFldsObjLst)
{
if (objViewGroupFldsEN.mId == lngmId)
{
return objViewGroupFldsEN;
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
 lngmId = new clsViewGroupFldsDA().GetFirstID(strWhereCond);
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
 arrList = ViewGroupFldsDA.GetID(strWhereCond);
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
bool bolIsExist = ViewGroupFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ViewGroupFldsDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsViewGroupFldsEN objViewGroupFldsEN = clsViewGroupFldsBL.GetObjBymId(lngmId);
objViewGroupFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsViewGroupFldsBL.UpdateBySql2(objViewGroupFldsEN);
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
 bolIsExist = clsViewGroupFldsDA.IsExistTable();
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
 bolIsExist = ViewGroupFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewGroupFldsEN objViewGroupFldsEN)
{
if (objViewGroupFldsEN.CheckUniqueness_TabFldId_ViewGroupId() == false)
{
var strMsg = string.Format("记录已经存在!表字段ID = [{0}],界面组ID = [{1}]的数据已经存在!(in clsViewGroupFldsBL.AddNewRecordBySql2)", objViewGroupFldsEN.TabFldId,objViewGroupFldsEN.ViewGroupId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewGroupFldsDA.AddNewRecordBySQL2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewGroupFldsEN objViewGroupFldsEN)
{
if (objViewGroupFldsEN.CheckUniqueness_TabFldId_ViewGroupId() == false)
{
var strMsg = string.Format("记录已经存在!表字段ID = [{0}],界面组ID = [{1}]的数据已经存在!(in clsViewGroupFldsBL.AddNewRecordBySql2WithReturnKey)", objViewGroupFldsEN.TabFldId,objViewGroupFldsEN.ViewGroupId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewGroupFldsDA.AddNewRecordBySQL2WithReturnKey(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "strViewGroupFldsObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strViewGroupFldsObjXml)
{
clsViewGroupFldsEN objViewGroupFldsEN = GetObjFromXmlStr(strViewGroupFldsObjXml);
try
{
bool bolResult = ViewGroupFldsDA.AddNewRecordBySQL2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewGroupFldsEN objViewGroupFldsEN)
{
try
{
bool bolResult = ViewGroupFldsDA.Update(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "objViewGroupFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewGroupFldsEN objViewGroupFldsEN)
{
 if (objViewGroupFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewGroupFldsDA.UpdateBySql2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "strViewGroupFldsObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strViewGroupFldsObjXml)
{
clsViewGroupFldsEN objViewGroupFldsEN = GetObjFromXmlStr(strViewGroupFldsObjXml);
try
{
bool bolResult = ViewGroupFldsDA.UpdateBySql2(objViewGroupFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupFldsBL.ReFreshCache();

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsViewGroupFldsEN objViewGroupFldsEN = clsViewGroupFldsBL.GetObjBymId(lngmId);

if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(objViewGroupFldsEN.mId, "SetUpdDate");
}
if (objViewGroupFldsEN != null)
{
int intRecNum = ViewGroupFldsDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
//删除与表:[ViewGroupFlds]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewGroupFlds.mId,
//lngmId);
//        clsViewGroupFldsBL.DelViewGroupFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewGroupFldsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewGroupFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewGroupFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
try
{
if (clsViewGroupFldsBL.relatedActions != null)
{
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewGroupFldsDA.DelRecordBySP(lngmId);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewGroupFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsViewGroupFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = ViewGroupFldsDA.DelViewGroupFlds(arrmIdLst);
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
public static int DelViewGroupFldssByCond(string strWhereCond)
{
try
{
if (clsViewGroupFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewGroupFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = ViewGroupFldsDA.DelViewGroupFlds(strWhereCond);
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
/// 这里仅仅是演示函数，使用时请复制到扩展类:[ViewGroupFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewGroupFldsDA.GetSpecSQLObj();
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
//删除与表:[ViewGroupFlds]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewGroupFldsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewGroupFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewGroupFldsENS">源对象</param>
 /// <param name = "objViewGroupFldsENT">目标对象</param>
 public static void CopyTo(clsViewGroupFldsEN objViewGroupFldsENS, clsViewGroupFldsEN objViewGroupFldsENT)
{
try
{
objViewGroupFldsENT.mId = objViewGroupFldsENS.mId; //mId
objViewGroupFldsENT.CtlTypeId = objViewGroupFldsENS.CtlTypeId; //控件类型号
objViewGroupFldsENT.DdlItemsOptionId = objViewGroupFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objViewGroupFldsENT.DsCondStr = objViewGroupFldsENS.DsCondStr; //数据源条件串
objViewGroupFldsENT.Ds_DataTextFieldId = objViewGroupFldsENS.Ds_DataTextFieldId; //数据源文本字段Id
objViewGroupFldsENT.DsDataValueFieldId = objViewGroupFldsENS.DsDataValueFieldId; //数据源值字段Id
objViewGroupFldsENT.DsSqlStr = objViewGroupFldsENS.DsSqlStr; //数据源SQL串
objViewGroupFldsENT.DsTabId = objViewGroupFldsENS.DsTabId; //数据源表ID
objViewGroupFldsENT.ItemsString = objViewGroupFldsENS.ItemsString; //列表项串
objViewGroupFldsENT.SeqNum = objViewGroupFldsENS.SeqNum; //字段序号
objViewGroupFldsENT.TabFldId = objViewGroupFldsENS.TabFldId; //表字段ID
objViewGroupFldsENT.UpdDate = objViewGroupFldsENS.UpdDate; //修改日期
objViewGroupFldsENT.UserId = objViewGroupFldsENS.UserId; //用户Id
objViewGroupFldsENT.ViewGroupId = objViewGroupFldsENS.ViewGroupId; //界面组ID
objViewGroupFldsENT.Memo = objViewGroupFldsENS.Memo; //说明
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
 /// <param name = "objViewGroupFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsViewGroupFldsEN objViewGroupFldsEN)
{
try
{
objViewGroupFldsEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objViewGroupFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewGroupFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.mId = objViewGroupFldsEN.mId; //mId
}
if (arrFldSet.Contains(conViewGroupFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.CtlTypeId = objViewGroupFldsEN.CtlTypeId == "[null]" ? null :  objViewGroupFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conViewGroupFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.DdlItemsOptionId = objViewGroupFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(conViewGroupFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.DsCondStr = objViewGroupFldsEN.DsCondStr == "[null]" ? null :  objViewGroupFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(conViewGroupFlds.Ds_DataTextFieldId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.Ds_DataTextFieldId = objViewGroupFldsEN.Ds_DataTextFieldId == "[null]" ? null :  objViewGroupFldsEN.Ds_DataTextFieldId; //数据源文本字段Id
}
if (arrFldSet.Contains(conViewGroupFlds.DsDataValueFieldId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.DsDataValueFieldId = objViewGroupFldsEN.DsDataValueFieldId == "[null]" ? null :  objViewGroupFldsEN.DsDataValueFieldId; //数据源值字段Id
}
if (arrFldSet.Contains(conViewGroupFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.DsSqlStr = objViewGroupFldsEN.DsSqlStr == "[null]" ? null :  objViewGroupFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(conViewGroupFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.DsTabId = objViewGroupFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(conViewGroupFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.ItemsString = objViewGroupFldsEN.ItemsString == "[null]" ? null :  objViewGroupFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(conViewGroupFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.SeqNum = objViewGroupFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conViewGroupFlds.TabFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.TabFldId = objViewGroupFldsEN.TabFldId; //表字段ID
}
if (arrFldSet.Contains(conViewGroupFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.UpdDate = objViewGroupFldsEN.UpdDate == "[null]" ? null :  objViewGroupFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewGroupFlds.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.UserId = objViewGroupFldsEN.UserId; //用户Id
}
if (arrFldSet.Contains(conViewGroupFlds.ViewGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.ViewGroupId = objViewGroupFldsEN.ViewGroupId; //界面组ID
}
if (arrFldSet.Contains(conViewGroupFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewGroupFldsEN.Memo = objViewGroupFldsEN.Memo == "[null]" ? null :  objViewGroupFldsEN.Memo; //说明
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
 /// <param name = "objViewGroupFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewGroupFldsEN objViewGroupFldsEN)
{
try
{
if (objViewGroupFldsEN.CtlTypeId == "[null]") objViewGroupFldsEN.CtlTypeId = null; //控件类型号
if (objViewGroupFldsEN.DsCondStr == "[null]") objViewGroupFldsEN.DsCondStr = null; //数据源条件串
if (objViewGroupFldsEN.Ds_DataTextFieldId == "[null]") objViewGroupFldsEN.Ds_DataTextFieldId = null; //数据源文本字段Id
if (objViewGroupFldsEN.DsDataValueFieldId == "[null]") objViewGroupFldsEN.DsDataValueFieldId = null; //数据源值字段Id
if (objViewGroupFldsEN.DsSqlStr == "[null]") objViewGroupFldsEN.DsSqlStr = null; //数据源SQL串
if (objViewGroupFldsEN.ItemsString == "[null]") objViewGroupFldsEN.ItemsString = null; //列表项串
if (objViewGroupFldsEN.UpdDate == "[null]") objViewGroupFldsEN.UpdDate = null; //修改日期
if (objViewGroupFldsEN.Memo == "[null]") objViewGroupFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewGroupFldsEN objViewGroupFldsEN)
{
 ViewGroupFldsDA.CheckPropertyNew(objViewGroupFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewGroupFldsEN objViewGroupFldsEN)
{
 ViewGroupFldsDA.CheckProperty4Condition(objViewGroupFldsEN);
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
if (clsViewGroupFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewGroupFldsBL没有刷新缓存机制(clsViewGroupFldsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrViewGroupFldsObjLstCache == null)
//{
//arrViewGroupFldsObjLstCache = ViewGroupFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewGroupFldsEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewGroupFldsEN._CurrTabName);
List<clsViewGroupFldsEN> arrViewGroupFldsObjLstCache = GetObjLstCache();
IEnumerable <clsViewGroupFldsEN> arrViewGroupFldsObjLst_Sel =
arrViewGroupFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrViewGroupFldsObjLst_Sel.Count() == 0)
{
   clsViewGroupFldsEN obj = clsViewGroupFldsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewGroupFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupFldsEN> GetAllViewGroupFldsObjLstCache()
{
//获取缓存中的对象列表
List<clsViewGroupFldsEN> arrViewGroupFldsObjLstCache = GetObjLstCache(); 
return arrViewGroupFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupFldsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewGroupFldsEN._CurrTabName);
List<clsViewGroupFldsEN> arrViewGroupFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewGroupFldsObjLstCache;
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
string strKey = string.Format("{0}", clsViewGroupFldsEN._CurrTabName);
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
if (clsViewGroupFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewGroupFldsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewGroupFldsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewGroupFlds(界面组字段集合)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrTabFldId_ViewGroupId(clsViewGroupFldsEN objViewGroupFldsEN)
{
//检测记录是否存在
string strResult = ViewGroupFldsDA.GetUniCondStrTabFldId_ViewGroupId(objViewGroupFldsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstViewGroupFldsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsViewGroupFldsEN> lstViewGroupFldsObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstViewGroupFldsObjLst, writer);
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
 /// <param name = "lstViewGroupFldsObjLst">[clsViewGroupFldsEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsViewGroupFldsEN> lstViewGroupFldsObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsViewGroupFldsBL.listXmlNode);
writer.WriteStartElement(clsViewGroupFldsBL.itemsXmlNode);
foreach (clsViewGroupFldsEN objViewGroupFldsEN in lstViewGroupFldsObjLst)
{
clsViewGroupFldsBL.SerializeXML(writer, objViewGroupFldsEN);
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
 /// <param name = "objViewGroupFldsEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsViewGroupFldsEN objViewGroupFldsEN)
{
writer.WriteStartElement(clsViewGroupFldsBL.itemXmlNode);
 
writer.WriteElementString(conViewGroupFlds.mId, objViewGroupFldsEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objViewGroupFldsEN.CtlTypeId != null)
{
writer.WriteElementString(conViewGroupFlds.CtlTypeId, objViewGroupFldsEN.CtlTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.DdlItemsOptionId != null)
{
writer.WriteElementString(conViewGroupFlds.DdlItemsOptionId, objViewGroupFldsEN.DdlItemsOptionId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.DsCondStr != null)
{
writer.WriteElementString(conViewGroupFlds.DsCondStr, objViewGroupFldsEN.DsCondStr.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.Ds_DataTextFieldId != null)
{
writer.WriteElementString(conViewGroupFlds.Ds_DataTextFieldId, objViewGroupFldsEN.Ds_DataTextFieldId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.DsDataValueFieldId != null)
{
writer.WriteElementString(conViewGroupFlds.DsDataValueFieldId, objViewGroupFldsEN.DsDataValueFieldId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.DsSqlStr != null)
{
writer.WriteElementString(conViewGroupFlds.DsSqlStr, objViewGroupFldsEN.DsSqlStr.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.DsTabId != null)
{
writer.WriteElementString(conViewGroupFlds.DsTabId, objViewGroupFldsEN.DsTabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.ItemsString != null)
{
writer.WriteElementString(conViewGroupFlds.ItemsString, objViewGroupFldsEN.ItemsString.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conViewGroupFlds.SeqNum, objViewGroupFldsEN.SeqNum.ToString());
 
writer.WriteElementString(conViewGroupFlds.TabFldId, objViewGroupFldsEN.TabFldId.ToString(CultureInfo.InvariantCulture));
 
if (objViewGroupFldsEN.UpdDate != null)
{
writer.WriteElementString(conViewGroupFlds.UpdDate, objViewGroupFldsEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.UserId != null)
{
writer.WriteElementString(conViewGroupFlds.UserId, objViewGroupFldsEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.ViewGroupId != null)
{
writer.WriteElementString(conViewGroupFlds.ViewGroupId, objViewGroupFldsEN.ViewGroupId.ToString(CultureInfo.InvariantCulture));
}
 
if (objViewGroupFldsEN.Memo != null)
{
writer.WriteElementString(conViewGroupFlds.Memo, objViewGroupFldsEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsViewGroupFldsEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
reader.Read();
while (!(reader.Name == clsViewGroupFldsBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conViewGroupFlds.mId))
{
objViewGroupFldsEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conViewGroupFlds.CtlTypeId))
{
objViewGroupFldsEN.CtlTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.DdlItemsOptionId))
{
objViewGroupFldsEN.DdlItemsOptionId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.DsCondStr))
{
objViewGroupFldsEN.DsCondStr = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.Ds_DataTextFieldId))
{
objViewGroupFldsEN.Ds_DataTextFieldId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.DsDataValueFieldId))
{
objViewGroupFldsEN.DsDataValueFieldId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.DsSqlStr))
{
objViewGroupFldsEN.DsSqlStr = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.DsTabId))
{
objViewGroupFldsEN.DsTabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.ItemsString))
{
objViewGroupFldsEN.ItemsString = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.SeqNum))
{
objViewGroupFldsEN.SeqNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conViewGroupFlds.TabFldId))
{
objViewGroupFldsEN.TabFldId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conViewGroupFlds.UpdDate))
{
objViewGroupFldsEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.UserId))
{
objViewGroupFldsEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.ViewGroupId))
{
objViewGroupFldsEN.ViewGroupId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conViewGroupFlds.Memo))
{
objViewGroupFldsEN.Memo = reader.ReadElementContentAsString();
}
}
return objViewGroupFldsEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strViewGroupFldsObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsViewGroupFldsEN GetObjFromXmlStr(string strViewGroupFldsObjXmlStr)
{
clsViewGroupFldsEN objViewGroupFldsEN = new clsViewGroupFldsEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strViewGroupFldsObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsViewGroupFldsBL.itemXmlNode))
{
objViewGroupFldsEN = GetObjFromXml(reader);
return objViewGroupFldsEN;
}
}
return objViewGroupFldsEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsViewGroupFldsEN objViewGroupFldsEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objViewGroupFldsEN);
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
if (strInFldName != conViewGroupFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewGroupFlds.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewGroupFlds.AttributeName));
throw new Exception(strMsg);
}
var objViewGroupFlds = clsViewGroupFldsBL.GetObjBymIdCache(lngmId);
if (objViewGroupFlds == null) return "";
return objViewGroupFlds[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objViewGroupFldsEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsViewGroupFldsEN objViewGroupFldsEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsViewGroupFldsEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objViewGroupFldsEN[strField]);
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
 /// <param name = "lstViewGroupFldsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsViewGroupFldsEN> lstViewGroupFldsObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstViewGroupFldsObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsViewGroupFldsEN objViewGroupFldsEN in lstViewGroupFldsObjLst)
{
string strJSON_One = SerializeObjToJSON(objViewGroupFldsEN);
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
int intRecCount = clsViewGroupFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsViewGroupFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewGroupFldsDA.GetRecCount();
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
int intRecCount = clsViewGroupFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewGroupFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewGroupFldsEN objViewGroupFldsCond)
{
List<clsViewGroupFldsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewGroupFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewGroupFlds.AttributeName)
{
if (objViewGroupFldsCond.IsUpdated(strFldName) == false) continue;
if (objViewGroupFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else
{
if (objViewGroupFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewGroupFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewGroupFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewGroupFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewGroupFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewGroupFldsCond[strFldName]));
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
 List<string> arrList = clsViewGroupFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewGroupFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewGroupFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewGroupFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewGroupFldsDA.SetFldValue(clsViewGroupFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewGroupFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewGroupFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewGroupFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewGroupFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewGroupFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) Null, "); 
 // /**下拉框列表选项ID*/ 
 strCreateTabCode.Append(" DdlItemsOptionId char(2) not Null, "); 
 // /**数据源条件串*/ 
 strCreateTabCode.Append(" DsCondStr varchar(50) Null, "); 
 // /**数据源文本字段Id*/ 
 strCreateTabCode.Append(" Ds_DataTextFieldId char(8) Null, "); 
 // /**数据源值字段Id*/ 
 strCreateTabCode.Append(" DsDataValueFieldId char(8) Null, "); 
 // /**数据源SQL串*/ 
 strCreateTabCode.Append(" DsSqlStr varchar(200) Null, "); 
 // /**数据源表ID*/ 
 strCreateTabCode.Append(" DsTabId char(8) not Null, "); 
 // /**列表项串*/ 
 strCreateTabCode.Append(" ItemsString varchar(200) Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**表字段ID*/ 
 strCreateTabCode.Append(" TabFldId bigint not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**界面组ID*/ 
 strCreateTabCode.Append(" ViewGroupId char(8) not Null, "); 
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
 /// 界面组字段集合(ViewGroupFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4ViewGroupFlds : clsCommFun4BL
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
clsViewGroupFldsBL.ReFreshThisCache();
}
}

}