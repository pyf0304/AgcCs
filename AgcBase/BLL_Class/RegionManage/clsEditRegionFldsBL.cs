
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionFldsBL
 表名:EditRegionFlds(00050116)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsEditRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEditRegionFldsEN GetObj(this K_mId_EditRegionFlds myKey)
{
clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.EditRegionFldsDA.GetObjBymId(myKey.Value);
return objEditRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objEditRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsEditRegionFldsBL.AddNewRecord)", objEditRegionFldsEN.RegionId,objEditRegionFldsEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsEditRegionFldsBL.EditRegionFldsDA.AddNewRecordBySQL2(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objEditRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objEditRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],字段Id(FldId)=[{1}])已经存在,不能重复!", objEditRegionFldsEN.RegionId, objEditRegionFldsEN.FldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objEditRegionFldsEN.AddNewRecord();
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objEditRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsEditRegionFldsBL.AddNewRecordWithReturnKey)", objEditRegionFldsEN.RegionId,objEditRegionFldsEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsEditRegionFldsBL.EditRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetmId(this clsEditRegionFldsEN objEditRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objEditRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.mId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.mId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.mId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetRegionId(this clsEditRegionFldsEN objEditRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conEditRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conEditRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conEditRegionFlds.RegionId);
}
objEditRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.RegionId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.RegionId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.RegionId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldId(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conEditRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conEditRegionFlds.FldId);
}
objEditRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetLabelCaption(this clsEditRegionFldsEN objEditRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conEditRegionFlds.LabelCaption);
}
objEditRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.LabelCaption) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetCtlTypeId(this clsEditRegionFldsEN objEditRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conEditRegionFlds.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conEditRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conEditRegionFlds.CtlTypeId);
}
objEditRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.CtlTypeId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetCallTabFeatureId(this clsEditRegionFldsEN objEditRegionFldsEN, string strCallTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCallTabFeatureId, 8, conEditRegionFlds.CallTabFeatureId);
}
objEditRegionFldsEN.CallTabFeatureId = strCallTabFeatureId; //调用表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.CallTabFeatureId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.CallTabFeatureId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.CallTabFeatureId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarId(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conEditRegionFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conEditRegionFlds.VarId);
}
objEditRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDefaultValue(this clsEditRegionFldsEN objEditRegionFldsEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conEditRegionFlds.DefaultValue);
}
objEditRegionFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DefaultValue) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DefaultValue, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DefaultValue] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDdlItemsOptionId(this clsEditRegionFldsEN objEditRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conEditRegionFlds.DdlItemsOptionId);
}
objEditRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DdlItemsOptionId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsTabId(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conEditRegionFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conEditRegionFlds.DsTabId);
}
objEditRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsTabId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsTabId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsTabId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetTabFeatureId4Ddl(this clsEditRegionFldsEN objEditRegionFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conEditRegionFlds.TabFeatureId4Ddl);
}
objEditRegionFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.TabFeatureId4Ddl) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldIdCond1(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conEditRegionFlds.FldIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conEditRegionFlds.FldIdCond1);
}
objEditRegionFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldIdCond1) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldIdCond1, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldIdCond1] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarIdCond1(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conEditRegionFlds.VarIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conEditRegionFlds.VarIdCond1);
}
objEditRegionFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarIdCond1) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarIdCond1, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarIdCond1] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetFldIdCond2(this clsEditRegionFldsEN objEditRegionFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conEditRegionFlds.FldIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conEditRegionFlds.FldIdCond2);
}
objEditRegionFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.FldIdCond2) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.FldIdCond2, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.FldIdCond2] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetVarIdCond2(this clsEditRegionFldsEN objEditRegionFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conEditRegionFlds.VarIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conEditRegionFlds.VarIdCond2);
}
objEditRegionFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.VarIdCond2) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.VarIdCond2, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.VarIdCond2] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsCondStr(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conEditRegionFlds.DsCondStr);
}
objEditRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsCondStr) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetDsSqlStr(this clsEditRegionFldsEN objEditRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conEditRegionFlds.DsSqlStr);
}
objEditRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.DsSqlStr) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetItemsString(this clsEditRegionFldsEN objEditRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, conEditRegionFlds.ItemsString);
}
objEditRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ItemsString) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ItemsString, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ItemsString] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetColSpan(this clsEditRegionFldsEN objEditRegionFldsEN, int? intColSpan, string strComparisonOp="")
	{
objEditRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ColSpan) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ColSpan, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ColSpan] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetColIndex(this clsEditRegionFldsEN objEditRegionFldsEN, int? intColIndex, string strComparisonOp="")
	{
objEditRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ColIndex) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ColIndex, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ColIndex] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetWidth(this clsEditRegionFldsEN objEditRegionFldsEN, int? intWidth, string strComparisonOp="")
	{
objEditRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.Width) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.Width, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.Width] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetIsMultiRow(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objEditRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.IsMultiRow) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetSeqNum(this clsEditRegionFldsEN objEditRegionFldsEN, int? intSeqNum, string strComparisonOp="")
	{
objEditRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.SeqNum) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.SeqNum, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.SeqNum] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetInOutTypeId(this clsEditRegionFldsEN objEditRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conEditRegionFlds.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conEditRegionFlds.InOutTypeId);
}
objEditRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.InOutTypeId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetClickEvent(this clsEditRegionFldsEN objEditRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conEditRegionFlds.ClickEvent);
}
objEditRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ClickEvent) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetChangeEvent(this clsEditRegionFldsEN objEditRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conEditRegionFlds.ChangeEvent);
}
objEditRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ChangeEvent) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetInUse(this clsEditRegionFldsEN objEditRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objEditRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.InUse) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.InUse, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.InUse] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetErrMsg(this clsEditRegionFldsEN objEditRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conEditRegionFlds.ErrMsg);
}
objEditRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.ErrMsg) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetPrjId(this clsEditRegionFldsEN objEditRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conEditRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conEditRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conEditRegionFlds.PrjId);
}
objEditRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.PrjId) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.PrjId, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.PrjId] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetUpdUser(this clsEditRegionFldsEN objEditRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conEditRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conEditRegionFlds.UpdUser);
}
objEditRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.UpdUser) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.UpdUser, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.UpdUser] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetUpdDate(this clsEditRegionFldsEN objEditRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conEditRegionFlds.UpdDate);
}
objEditRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.UpdDate) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.UpdDate, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.UpdDate] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsEditRegionFldsEN SetMemo(this clsEditRegionFldsEN objEditRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conEditRegionFlds.Memo);
}
objEditRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionFldsEN.dicFldComparisonOp.ContainsKey(conEditRegionFlds.Memo) == false)
{
objEditRegionFldsEN.dicFldComparisonOp.Add(conEditRegionFlds.Memo, strComparisonOp);
}
else
{
objEditRegionFldsEN.dicFldComparisonOp[conEditRegionFlds.Memo] = strComparisonOp;
}
}
return objEditRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsEditRegionFldsEN objEditRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objEditRegionFldsEN.CheckPropertyNew();
clsEditRegionFldsEN objEditRegionFldsCond = new clsEditRegionFldsEN();
string strCondition = objEditRegionFldsCond
.SetmId(objEditRegionFldsEN.mId, "<>")
.SetRegionId(objEditRegionFldsEN.RegionId, "=")
.SetFldId(objEditRegionFldsEN.FldId, "=")
.GetCombineCondition();
objEditRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsEditRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RegionId_FldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objEditRegionFldsEN.Update();
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
 /// <param name = "objEditRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsEditRegionFldsEN objEditRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsEditRegionFldsEN objEditRegionFldsCond = new clsEditRegionFldsEN();
string strCondition = objEditRegionFldsCond
.SetRegionId(objEditRegionFlds.RegionId, "=")
.SetFldId(objEditRegionFlds.FldId, "=")
.GetCombineCondition();
objEditRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsEditRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objEditRegionFlds.mId = clsEditRegionFldsBL.GetFirstID_S(strCondition);
objEditRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objEditRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEditRegionFldsEN objEditRegionFldsEN)
{
 if (objEditRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsEditRegionFldsBL.EditRegionFldsDA.UpdateBySql2(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEditRegionFldsEN objEditRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objEditRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsEditRegionFldsBL.EditRegionFldsDA.UpdateBySql2(objEditRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEditRegionFldsEN objEditRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsEditRegionFldsBL.EditRegionFldsDA.UpdateBySqlWithCondition(objEditRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEditRegionFldsEN objEditRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsEditRegionFldsBL.EditRegionFldsDA.UpdateBySqlWithConditionTransaction(objEditRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
public static int Delete(this clsEditRegionFldsEN objEditRegionFldsEN)
{
try
{
int intRecNum = clsEditRegionFldsBL.EditRegionFldsDA.DelRecord(objEditRegionFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsEditRegionFldsEN objEditRegionFldsENS, clsEditRegionFldsEN objEditRegionFldsENT)
{
try
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.FldId = objEditRegionFldsENS.FldId; //字段Id
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.CallTabFeatureId = objEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objEditRegionFldsENT.VarId = objEditRegionFldsENS.VarId; //变量Id
objEditRegionFldsENT.DefaultValue = objEditRegionFldsENS.DefaultValue; //缺省值
objEditRegionFldsENT.DdlItemsOptionId = objEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DsTabId = objEditRegionFldsENS.DsTabId; //数据源表ID
objEditRegionFldsENT.TabFeatureId4Ddl = objEditRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objEditRegionFldsENT.FldIdCond1 = objEditRegionFldsENS.FldIdCond1; //字段Id_条件1
objEditRegionFldsENT.VarIdCond1 = objEditRegionFldsENS.VarIdCond1; //变量Id_条件1
objEditRegionFldsENT.FldIdCond2 = objEditRegionFldsENS.FldIdCond2; //字段Id_条件2
objEditRegionFldsENT.VarIdCond2 = objEditRegionFldsENS.VarIdCond2; //数据源字段_条件1
objEditRegionFldsENT.DsCondStr = objEditRegionFldsENS.DsCondStr; //数据源条件串
objEditRegionFldsENT.DsSqlStr = objEditRegionFldsENS.DsSqlStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.InOutTypeId = objEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objEditRegionFldsENT.ClickEvent = objEditRegionFldsENS.ClickEvent; //Click事件
objEditRegionFldsENT.ChangeEvent = objEditRegionFldsENS.ChangeEvent; //Change事件
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.ErrMsg = objEditRegionFldsENS.ErrMsg; //错误信息
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程Id
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
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
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsEditRegionFldsEN:objEditRegionFldsENT</returns>
 public static clsEditRegionFldsEN CopyTo(this clsEditRegionFldsEN objEditRegionFldsENS)
{
try
{
 clsEditRegionFldsEN objEditRegionFldsENT = new clsEditRegionFldsEN()
{
mId = objEditRegionFldsENS.mId, //mId
RegionId = objEditRegionFldsENS.RegionId, //区域Id
FldId = objEditRegionFldsENS.FldId, //字段Id
LabelCaption = objEditRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objEditRegionFldsENS.CtlTypeId, //控件类型号
CallTabFeatureId = objEditRegionFldsENS.CallTabFeatureId, //调用表功能Id
VarId = objEditRegionFldsENS.VarId, //变量Id
DefaultValue = objEditRegionFldsENS.DefaultValue, //缺省值
DdlItemsOptionId = objEditRegionFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DsTabId = objEditRegionFldsENS.DsTabId, //数据源表ID
TabFeatureId4Ddl = objEditRegionFldsENS.TabFeatureId4Ddl, //下拉框表功能Id
FldIdCond1 = objEditRegionFldsENS.FldIdCond1, //字段Id_条件1
VarIdCond1 = objEditRegionFldsENS.VarIdCond1, //变量Id_条件1
FldIdCond2 = objEditRegionFldsENS.FldIdCond2, //字段Id_条件2
VarIdCond2 = objEditRegionFldsENS.VarIdCond2, //数据源字段_条件1
DsCondStr = objEditRegionFldsENS.DsCondStr, //数据源条件串
DsSqlStr = objEditRegionFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objEditRegionFldsENS.ItemsString, //列表项串
ColSpan = objEditRegionFldsENS.ColSpan, //跨列数
ColIndex = objEditRegionFldsENS.ColIndex, //列序号
Width = objEditRegionFldsENS.Width, //宽
IsMultiRow = objEditRegionFldsENS.IsMultiRow, //是否多行
SeqNum = objEditRegionFldsENS.SeqNum, //字段序号
InOutTypeId = objEditRegionFldsENS.InOutTypeId, //INOUT类型ID
ClickEvent = objEditRegionFldsENS.ClickEvent, //Click事件
ChangeEvent = objEditRegionFldsENS.ChangeEvent, //Change事件
InUse = objEditRegionFldsENS.InUse, //是否在用
ErrMsg = objEditRegionFldsENS.ErrMsg, //错误信息
PrjId = objEditRegionFldsENS.PrjId, //工程Id
UpdUser = objEditRegionFldsENS.UpdUser, //修改者
UpdDate = objEditRegionFldsENS.UpdDate, //修改日期
Memo = objEditRegionFldsENS.Memo, //说明
};
 return objEditRegionFldsENT;
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
public static void CheckPropertyNew(this clsEditRegionFldsEN objEditRegionFldsEN)
{
 clsEditRegionFldsBL.EditRegionFldsDA.CheckPropertyNew(objEditRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsEditRegionFldsEN objEditRegionFldsEN)
{
 clsEditRegionFldsBL.EditRegionFldsDA.CheckProperty4Condition(objEditRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEditRegionFldsEN objEditRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.mId) == true)
{
string strComparisonOpmId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.mId, objEditRegionFldsCond.mId, strComparisonOpmId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.RegionId, objEditRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldId, objEditRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.LabelCaption, objEditRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.CtlTypeId, objEditRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.CallTabFeatureId) == true)
{
string strComparisonOpCallTabFeatureId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.CallTabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.CallTabFeatureId, objEditRegionFldsCond.CallTabFeatureId, strComparisonOpCallTabFeatureId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarId, objEditRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DefaultValue, objEditRegionFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DdlItemsOptionId, objEditRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsTabId, objEditRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.TabFeatureId4Ddl, objEditRegionFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldIdCond1, objEditRegionFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarIdCond1, objEditRegionFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.FldIdCond2, objEditRegionFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.VarIdCond2, objEditRegionFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsCondStr, objEditRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.DsSqlStr, objEditRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ItemsString, objEditRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.ColSpan, objEditRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.ColIndex, objEditRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.Width) == true)
{
string strComparisonOpWidth = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.Width, objEditRegionFldsCond.Width, strComparisonOpWidth);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.IsMultiRow) == true)
{
if (objEditRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEditRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEditRegionFlds.IsMultiRow);
}
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conEditRegionFlds.SeqNum, objEditRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.InOutTypeId, objEditRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ClickEvent, objEditRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ChangeEvent, objEditRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.InUse) == true)
{
if (objEditRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conEditRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conEditRegionFlds.InUse);
}
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.ErrMsg, objEditRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.PrjId, objEditRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.UpdUser, objEditRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.UpdDate, objEditRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objEditRegionFldsCond.IsUpdated(conEditRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objEditRegionFldsCond.dicFldComparisonOp[conEditRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conEditRegionFlds.Memo, objEditRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--EditRegionFlds(编辑区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RegionId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsEditRegionFldsEN objEditRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objEditRegionFldsEN == null) return true;
if (objEditRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 if (objEditRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objEditRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
}
if (clsEditRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objEditRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
if (clsEditRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--EditRegionFlds(编辑区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsEditRegionFldsEN objEditRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objEditRegionFldsEN == null) return "";
if (objEditRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 if (objEditRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objEditRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objEditRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objEditRegionFldsEN.FldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_EditRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objEditRegionFlds = clsEditRegionFldsBL.GetObjBymId(lngmId);
if (objEditRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objEditRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objEditRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// 编辑区域字段(EditRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsEditRegionFldsBL
{
public static RelatedActions_EditRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsEditRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsEditRegionFldsDA EditRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsEditRegionFldsDA();
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
 public clsEditRegionFldsBL()
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
if (string.IsNullOrEmpty(clsEditRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsEditRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_EditRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = EditRegionFldsDA.GetDataTable_EditRegionFlds(strWhereCond);
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
objDT = EditRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = EditRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = EditRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = EditRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = EditRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = EditRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = EditRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = EditRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
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
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsEditRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
arrEditRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrEditRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
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
public static List<clsEditRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objEditRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsEditRegionFldsEN> GetSubObjLstCache(clsEditRegionFldsEN objEditRegionFldsCond)
{
 string strPrjId = objEditRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsEditRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsEditRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsEditRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conEditRegionFlds._AttributeName)
{
if (objEditRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objEditRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEditRegionFldsCond[strFldName].ToString());
}
else
{
if (objEditRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objEditRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEditRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objEditRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objEditRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objEditRegionFldsCond[strFldName]));
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
public static List<clsEditRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
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
public static List<clsEditRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
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
List<clsEditRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsEditRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsEditRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
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
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
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
public static List<clsEditRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsEditRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
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
public static List<clsEditRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsEditRegionFldsEN> arrObjLst = new List<clsEditRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEditRegionFldsEN objEditRegionFldsEN = new clsEditRegionFldsEN();
try
{
objEditRegionFldsEN.mId = Int32.Parse(objRow[conEditRegionFlds.mId].ToString().Trim()); //mId
objEditRegionFldsEN.RegionId = objRow[conEditRegionFlds.RegionId].ToString().Trim(); //区域Id
objEditRegionFldsEN.FldId = objRow[conEditRegionFlds.FldId] == DBNull.Value ? null : objRow[conEditRegionFlds.FldId].ToString().Trim(); //字段Id
objEditRegionFldsEN.LabelCaption = objRow[conEditRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conEditRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objEditRegionFldsEN.CtlTypeId = objRow[conEditRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objEditRegionFldsEN.CallTabFeatureId = objRow[conEditRegionFlds.CallTabFeatureId] == DBNull.Value ? null : objRow[conEditRegionFlds.CallTabFeatureId].ToString().Trim(); //调用表功能Id
objEditRegionFldsEN.VarId = objRow[conEditRegionFlds.VarId] == DBNull.Value ? null : objRow[conEditRegionFlds.VarId].ToString().Trim(); //变量Id
objEditRegionFldsEN.DefaultValue = objRow[conEditRegionFlds.DefaultValue] == DBNull.Value ? null : objRow[conEditRegionFlds.DefaultValue].ToString().Trim(); //缺省值
objEditRegionFldsEN.DdlItemsOptionId = objRow[conEditRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conEditRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objEditRegionFldsEN.DsTabId = objRow[conEditRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conEditRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objEditRegionFldsEN.TabFeatureId4Ddl = objRow[conEditRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conEditRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objEditRegionFldsEN.FldIdCond1 = objRow[conEditRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objEditRegionFldsEN.VarIdCond1 = objRow[conEditRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objEditRegionFldsEN.FldIdCond2 = objRow[conEditRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objEditRegionFldsEN.VarIdCond2 = objRow[conEditRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conEditRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objEditRegionFldsEN.DsCondStr = objRow[conEditRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objEditRegionFldsEN.DsSqlStr = objRow[conEditRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conEditRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objEditRegionFldsEN.ItemsString = objRow[conEditRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conEditRegionFlds.ItemsString].ToString().Trim(); //列表项串
objEditRegionFldsEN.ColSpan = objRow[conEditRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColSpan].ToString().Trim()); //跨列数
objEditRegionFldsEN.ColIndex = objRow[conEditRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.ColIndex].ToString().Trim()); //列序号
objEditRegionFldsEN.Width = objRow[conEditRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.Width].ToString().Trim()); //宽
objEditRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objEditRegionFldsEN.SeqNum = objRow[conEditRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEditRegionFlds.SeqNum].ToString().Trim()); //字段序号
objEditRegionFldsEN.InOutTypeId = objRow[conEditRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conEditRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objEditRegionFldsEN.ClickEvent = objRow[conEditRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objEditRegionFldsEN.ChangeEvent = objRow[conEditRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conEditRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objEditRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conEditRegionFlds.InUse].ToString().Trim()); //是否在用
objEditRegionFldsEN.ErrMsg = objRow[conEditRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conEditRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objEditRegionFldsEN.PrjId = objRow[conEditRegionFlds.PrjId].ToString().Trim(); //工程Id
objEditRegionFldsEN.UpdUser = objRow[conEditRegionFlds.UpdUser].ToString().Trim(); //修改者
objEditRegionFldsEN.UpdDate = objRow[conEditRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conEditRegionFlds.UpdDate].ToString().Trim(); //修改日期
objEditRegionFldsEN.Memo = objRow[conEditRegionFlds.Memo] == DBNull.Value ? null : objRow[conEditRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objEditRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objEditRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetEditRegionFlds(ref clsEditRegionFldsEN objEditRegionFldsEN)
{
bool bolResult = EditRegionFldsDA.GetEditRegionFlds(ref objEditRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEditRegionFldsEN GetObjBymId(long lngmId)
{
clsEditRegionFldsEN objEditRegionFldsEN = EditRegionFldsDA.GetObjBymId(lngmId);
return objEditRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsEditRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsEditRegionFldsEN objEditRegionFldsEN = EditRegionFldsDA.GetFirstObj(strWhereCond);
 return objEditRegionFldsEN;
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
public static clsEditRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsEditRegionFldsEN objEditRegionFldsEN = EditRegionFldsDA.GetObjByDataRow(objRow);
 return objEditRegionFldsEN;
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
public static clsEditRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsEditRegionFldsEN objEditRegionFldsEN = EditRegionFldsDA.GetObjByDataRow(objRow);
 return objEditRegionFldsEN;
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
 /// <param name = "lstEditRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEditRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsEditRegionFldsEN> lstEditRegionFldsObjLst)
{
foreach (clsEditRegionFldsEN objEditRegionFldsEN in lstEditRegionFldsObjLst)
{
if (objEditRegionFldsEN.mId == lngmId)
{
return objEditRegionFldsEN;
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
 lngmId = new clsEditRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = EditRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = EditRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = EditRegionFldsDA.IsExist(lngmId);
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
clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(lngmId);
objEditRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objEditRegionFldsEN.UpdUser = strOpUser;
return clsEditRegionFldsBL.UpdateBySql2(objEditRegionFldsEN);
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
 bolIsExist = clsEditRegionFldsDA.IsExistTable();
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
 bolIsExist = EditRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objEditRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsEditRegionFldsBL.AddNewRecordBySql2)", objEditRegionFldsEN.RegionId,objEditRegionFldsEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = EditRegionFldsDA.AddNewRecordBySQL2(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsEditRegionFldsEN objEditRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objEditRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsEditRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objEditRegionFldsEN.RegionId,objEditRegionFldsEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = EditRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsEditRegionFldsEN objEditRegionFldsEN)
{
try
{
bool bolResult = EditRegionFldsDA.Update(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "objEditRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsEditRegionFldsEN objEditRegionFldsEN)
{
 if (objEditRegionFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = EditRegionFldsDA.UpdateBySql2(objEditRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionFldsBL.ReFreshCache(objEditRegionFldsEN.PrjId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(lngmId);

if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(objEditRegionFldsEN.mId, objEditRegionFldsEN.UpdUser);
}
if (objEditRegionFldsEN != null)
{
int intRecNum = EditRegionFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objEditRegionFldsEN.PrjId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[EditRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conEditRegionFlds.mId,
//lngmId);
//        clsEditRegionFldsBL.DelEditRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsEditRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsEditRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
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
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsEditRegionFldsBL.relatedActions != null)
{
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = EditRegionFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelEditRegionFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsEditRegionFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsEditRegionFldsEN objEditRegionFldsEN = clsEditRegionFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = EditRegionFldsDA.DelEditRegionFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objEditRegionFldsEN.PrjId);
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
public static int DelEditRegionFldssByCond(string strWhereCond)
{
try
{
if (clsEditRegionFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsEditRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conEditRegionFlds.PrjId, strWhereCond);
int intRecNum = EditRegionFldsDA.DelEditRegionFlds(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[EditRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsEditRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[EditRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsEditRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsEditRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
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
 /// <param name = "objEditRegionFldsENS">源对象</param>
 /// <param name = "objEditRegionFldsENT">目标对象</param>
 public static void CopyTo(clsEditRegionFldsEN objEditRegionFldsENS, clsEditRegionFldsEN objEditRegionFldsENT)
{
try
{
objEditRegionFldsENT.mId = objEditRegionFldsENS.mId; //mId
objEditRegionFldsENT.RegionId = objEditRegionFldsENS.RegionId; //区域Id
objEditRegionFldsENT.FldId = objEditRegionFldsENS.FldId; //字段Id
objEditRegionFldsENT.LabelCaption = objEditRegionFldsENS.LabelCaption; //标签标题
objEditRegionFldsENT.CtlTypeId = objEditRegionFldsENS.CtlTypeId; //控件类型号
objEditRegionFldsENT.CallTabFeatureId = objEditRegionFldsENS.CallTabFeatureId; //调用表功能Id
objEditRegionFldsENT.VarId = objEditRegionFldsENS.VarId; //变量Id
objEditRegionFldsENT.DefaultValue = objEditRegionFldsENS.DefaultValue; //缺省值
objEditRegionFldsENT.DdlItemsOptionId = objEditRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objEditRegionFldsENT.DsTabId = objEditRegionFldsENS.DsTabId; //数据源表ID
objEditRegionFldsENT.TabFeatureId4Ddl = objEditRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objEditRegionFldsENT.FldIdCond1 = objEditRegionFldsENS.FldIdCond1; //字段Id_条件1
objEditRegionFldsENT.VarIdCond1 = objEditRegionFldsENS.VarIdCond1; //变量Id_条件1
objEditRegionFldsENT.FldIdCond2 = objEditRegionFldsENS.FldIdCond2; //字段Id_条件2
objEditRegionFldsENT.VarIdCond2 = objEditRegionFldsENS.VarIdCond2; //数据源字段_条件1
objEditRegionFldsENT.DsCondStr = objEditRegionFldsENS.DsCondStr; //数据源条件串
objEditRegionFldsENT.DsSqlStr = objEditRegionFldsENS.DsSqlStr; //数据源SQL串
objEditRegionFldsENT.ItemsString = objEditRegionFldsENS.ItemsString; //列表项串
objEditRegionFldsENT.ColSpan = objEditRegionFldsENS.ColSpan; //跨列数
objEditRegionFldsENT.ColIndex = objEditRegionFldsENS.ColIndex; //列序号
objEditRegionFldsENT.Width = objEditRegionFldsENS.Width; //宽
objEditRegionFldsENT.IsMultiRow = objEditRegionFldsENS.IsMultiRow; //是否多行
objEditRegionFldsENT.SeqNum = objEditRegionFldsENS.SeqNum; //字段序号
objEditRegionFldsENT.InOutTypeId = objEditRegionFldsENS.InOutTypeId; //INOUT类型ID
objEditRegionFldsENT.ClickEvent = objEditRegionFldsENS.ClickEvent; //Click事件
objEditRegionFldsENT.ChangeEvent = objEditRegionFldsENS.ChangeEvent; //Change事件
objEditRegionFldsENT.InUse = objEditRegionFldsENS.InUse; //是否在用
objEditRegionFldsENT.ErrMsg = objEditRegionFldsENS.ErrMsg; //错误信息
objEditRegionFldsENT.PrjId = objEditRegionFldsENS.PrjId; //工程Id
objEditRegionFldsENT.UpdUser = objEditRegionFldsENS.UpdUser; //修改者
objEditRegionFldsENT.UpdDate = objEditRegionFldsENS.UpdDate; //修改日期
objEditRegionFldsENT.Memo = objEditRegionFldsENS.Memo; //说明
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
 /// <param name = "objEditRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsEditRegionFldsEN objEditRegionFldsEN)
{
try
{
objEditRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objEditRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conEditRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.mId = objEditRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(conEditRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.RegionId = objEditRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conEditRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.FldId = objEditRegionFldsEN.FldId == "[null]" ? null :  objEditRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conEditRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.LabelCaption = objEditRegionFldsEN.LabelCaption == "[null]" ? null :  objEditRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(conEditRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.CtlTypeId = objEditRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conEditRegionFlds.CallTabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.CallTabFeatureId = objEditRegionFldsEN.CallTabFeatureId == "[null]" ? null :  objEditRegionFldsEN.CallTabFeatureId; //调用表功能Id
}
if (arrFldSet.Contains(conEditRegionFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.VarId = objEditRegionFldsEN.VarId == "[null]" ? null :  objEditRegionFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(conEditRegionFlds.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.DefaultValue = objEditRegionFldsEN.DefaultValue == "[null]" ? null :  objEditRegionFldsEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(conEditRegionFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.DdlItemsOptionId = objEditRegionFldsEN.DdlItemsOptionId == "[null]" ? null :  objEditRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(conEditRegionFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.DsTabId = objEditRegionFldsEN.DsTabId == "[null]" ? null :  objEditRegionFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(conEditRegionFlds.TabFeatureId4Ddl, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.TabFeatureId4Ddl = objEditRegionFldsEN.TabFeatureId4Ddl == "[null]" ? null :  objEditRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
}
if (arrFldSet.Contains(conEditRegionFlds.FldIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.FldIdCond1 = objEditRegionFldsEN.FldIdCond1 == "[null]" ? null :  objEditRegionFldsEN.FldIdCond1; //字段Id_条件1
}
if (arrFldSet.Contains(conEditRegionFlds.VarIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.VarIdCond1 = objEditRegionFldsEN.VarIdCond1 == "[null]" ? null :  objEditRegionFldsEN.VarIdCond1; //变量Id_条件1
}
if (arrFldSet.Contains(conEditRegionFlds.FldIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.FldIdCond2 = objEditRegionFldsEN.FldIdCond2 == "[null]" ? null :  objEditRegionFldsEN.FldIdCond2; //字段Id_条件2
}
if (arrFldSet.Contains(conEditRegionFlds.VarIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.VarIdCond2 = objEditRegionFldsEN.VarIdCond2 == "[null]" ? null :  objEditRegionFldsEN.VarIdCond2; //数据源字段_条件1
}
if (arrFldSet.Contains(conEditRegionFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.DsCondStr = objEditRegionFldsEN.DsCondStr == "[null]" ? null :  objEditRegionFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(conEditRegionFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.DsSqlStr = objEditRegionFldsEN.DsSqlStr == "[null]" ? null :  objEditRegionFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(conEditRegionFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ItemsString = objEditRegionFldsEN.ItemsString == "[null]" ? null :  objEditRegionFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(conEditRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ColSpan = objEditRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(conEditRegionFlds.ColIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ColIndex = objEditRegionFldsEN.ColIndex; //列序号
}
if (arrFldSet.Contains(conEditRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.Width = objEditRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(conEditRegionFlds.IsMultiRow, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.IsMultiRow = objEditRegionFldsEN.IsMultiRow; //是否多行
}
if (arrFldSet.Contains(conEditRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.SeqNum = objEditRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conEditRegionFlds.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.InOutTypeId = objEditRegionFldsEN.InOutTypeId == "[null]" ? null :  objEditRegionFldsEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(conEditRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ClickEvent = objEditRegionFldsEN.ClickEvent == "[null]" ? null :  objEditRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(conEditRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ChangeEvent = objEditRegionFldsEN.ChangeEvent == "[null]" ? null :  objEditRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(conEditRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.InUse = objEditRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conEditRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.ErrMsg = objEditRegionFldsEN.ErrMsg == "[null]" ? null :  objEditRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conEditRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.PrjId = objEditRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conEditRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.UpdUser = objEditRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conEditRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.UpdDate = objEditRegionFldsEN.UpdDate == "[null]" ? null :  objEditRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conEditRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objEditRegionFldsEN.Memo = objEditRegionFldsEN.Memo == "[null]" ? null :  objEditRegionFldsEN.Memo; //说明
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
 /// <param name = "objEditRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsEditRegionFldsEN objEditRegionFldsEN)
{
try
{
if (objEditRegionFldsEN.FldId == "[null]") objEditRegionFldsEN.FldId = null; //字段Id
if (objEditRegionFldsEN.LabelCaption == "[null]") objEditRegionFldsEN.LabelCaption = null; //标签标题
if (objEditRegionFldsEN.CallTabFeatureId == "[null]") objEditRegionFldsEN.CallTabFeatureId = null; //调用表功能Id
if (objEditRegionFldsEN.VarId == "[null]") objEditRegionFldsEN.VarId = null; //变量Id
if (objEditRegionFldsEN.DefaultValue == "[null]") objEditRegionFldsEN.DefaultValue = null; //缺省值
if (objEditRegionFldsEN.DdlItemsOptionId == "[null]") objEditRegionFldsEN.DdlItemsOptionId = null; //下拉框列表选项ID
if (objEditRegionFldsEN.DsTabId == "[null]") objEditRegionFldsEN.DsTabId = null; //数据源表ID
if (objEditRegionFldsEN.TabFeatureId4Ddl == "[null]") objEditRegionFldsEN.TabFeatureId4Ddl = null; //下拉框表功能Id
if (objEditRegionFldsEN.FldIdCond1 == "[null]") objEditRegionFldsEN.FldIdCond1 = null; //字段Id_条件1
if (objEditRegionFldsEN.VarIdCond1 == "[null]") objEditRegionFldsEN.VarIdCond1 = null; //变量Id_条件1
if (objEditRegionFldsEN.FldIdCond2 == "[null]") objEditRegionFldsEN.FldIdCond2 = null; //字段Id_条件2
if (objEditRegionFldsEN.VarIdCond2 == "[null]") objEditRegionFldsEN.VarIdCond2 = null; //数据源字段_条件1
if (objEditRegionFldsEN.DsCondStr == "[null]") objEditRegionFldsEN.DsCondStr = null; //数据源条件串
if (objEditRegionFldsEN.DsSqlStr == "[null]") objEditRegionFldsEN.DsSqlStr = null; //数据源SQL串
if (objEditRegionFldsEN.ItemsString == "[null]") objEditRegionFldsEN.ItemsString = null; //列表项串
if (objEditRegionFldsEN.InOutTypeId == "[null]") objEditRegionFldsEN.InOutTypeId = null; //INOUT类型ID
if (objEditRegionFldsEN.ClickEvent == "[null]") objEditRegionFldsEN.ClickEvent = null; //Click事件
if (objEditRegionFldsEN.ChangeEvent == "[null]") objEditRegionFldsEN.ChangeEvent = null; //Change事件
if (objEditRegionFldsEN.ErrMsg == "[null]") objEditRegionFldsEN.ErrMsg = null; //错误信息
if (objEditRegionFldsEN.UpdDate == "[null]") objEditRegionFldsEN.UpdDate = null; //修改日期
if (objEditRegionFldsEN.Memo == "[null]") objEditRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsEditRegionFldsEN objEditRegionFldsEN)
{
 EditRegionFldsDA.CheckPropertyNew(objEditRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsEditRegionFldsEN objEditRegionFldsEN)
{
 EditRegionFldsDA.CheckProperty4Condition(objEditRegionFldsEN);
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
if (clsEditRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsEditRegionFldsBL没有刷新缓存机制(clsEditRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrEditRegionFldsObjLstCache == null)
//{
//arrEditRegionFldsObjLstCache = EditRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEditRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsEditRegionFldsEN> arrEditRegionFldsObjLst_Sel =
arrEditRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrEditRegionFldsObjLst_Sel.Count() == 0)
{
   clsEditRegionFldsEN obj = clsEditRegionFldsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrEditRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEditRegionFldsEN> GetAllEditRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrEditRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEditRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsEditRegionFldsEN> arrEditRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrEditRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsEditRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsEditRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsEditRegionFldsEN._RefreshTimeLst[clsEditRegionFldsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsEditRegionFldsBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsEditRegionFldsBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsEditRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsEditRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsEditRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsEditRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--EditRegionFlds(编辑区域字段)
 /// 唯一性条件:RegionId_FldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objEditRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsEditRegionFldsEN objEditRegionFldsEN)
{
//检测记录是否存在
string strResult = EditRegionFldsDA.GetUniCondStr(objEditRegionFldsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conEditRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conEditRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conEditRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objEditRegionFlds = clsEditRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objEditRegionFlds == null) return "";
return objEditRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsEditRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsEditRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsEditRegionFldsDA.GetRecCount();
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
int intRecCount = clsEditRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objEditRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsEditRegionFldsEN objEditRegionFldsCond)
{
 string strPrjId = objEditRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsEditRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsEditRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsEditRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conEditRegionFlds._AttributeName)
{
if (objEditRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objEditRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEditRegionFldsCond[strFldName].ToString());
}
else
{
if (objEditRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objEditRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objEditRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objEditRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objEditRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objEditRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objEditRegionFldsCond[strFldName]));
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
 List<string> arrList = clsEditRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = EditRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = EditRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = EditRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsEditRegionFldsDA.SetFldValue(clsEditRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = EditRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsEditRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsEditRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsEditRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[EditRegionFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**标签标题*/ 
 strCreateTabCode.Append(" LabelCaption varchar(150) Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) not Null, "); 
 // /**调用表功能Id*/ 
 strCreateTabCode.Append(" CallTabFeatureId char(8) Null, "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) Null, "); 
 // /**缺省值*/ 
 strCreateTabCode.Append(" DefaultValue varchar(50) Null, "); 
 // /**下拉框列表选项ID*/ 
 strCreateTabCode.Append(" DdlItemsOptionId char(2) Null, "); 
 // /**数据源表ID*/ 
 strCreateTabCode.Append(" DsTabId char(8) Null, "); 
 // /**下拉框表功能Id*/ 
 strCreateTabCode.Append(" TabFeatureId4Ddl char(8) Null, "); 
 // /**字段Id_条件1*/ 
 strCreateTabCode.Append(" FldIdCond1 char(8) Null, "); 
 // /**变量Id_条件1*/ 
 strCreateTabCode.Append(" VarIdCond1 char(8) Null, "); 
 // /**字段Id_条件2*/ 
 strCreateTabCode.Append(" FldIdCond2 char(8) Null, "); 
 // /**数据源字段_条件1*/ 
 strCreateTabCode.Append(" VarIdCond2 char(8) Null, "); 
 // /**数据源条件串*/ 
 strCreateTabCode.Append(" DsCondStr varchar(50) Null, "); 
 // /**数据源SQL串*/ 
 strCreateTabCode.Append(" DsSqlStr varchar(200) Null, "); 
 // /**列表项串*/ 
 strCreateTabCode.Append(" ItemsString varchar(200) Null, "); 
 // /**跨列数*/ 
 strCreateTabCode.Append(" ColSpan int Null, "); 
 // /**列序号*/ 
 strCreateTabCode.Append(" ColIndex int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**是否多行*/ 
 strCreateTabCode.Append(" IsMultiRow bit Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**INOUT类型ID*/ 
 strCreateTabCode.Append(" InOutTypeId char(2) Null, "); 
 // /**Click事件*/ 
 strCreateTabCode.Append(" ClickEvent varchar(50) Null, "); 
 // /**Change事件*/ 
 strCreateTabCode.Append(" ChangeEvent varchar(50) Null, "); 
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
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**控件Id*/ 
 strCreateTabCode.Append(" CtrlId varchar(50) not Null, "); 
 // /**事件*/ 
 strCreateTabCode.Append(" Event varchar(50) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNameV2 varchar(50) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
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
strCondition += string.Format(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsEditRegionFldsEN> arrEditRegionFldsObjList = new clsEditRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldsObjList)
{
objEditRegionFlds.SeqNum = intIndex;
UpdateBySql2(objEditRegionFlds);
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
/// <param name="lngmId">所给的关键字</param>
/// <param name="strRegionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strRegionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[SeqNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[SeqNum]。

clsEditRegionFldsEN objEditRegionFlds = clsEditRegionFldsBL.GetObjBymId(lngmId);

intOrderNum = objEditRegionFlds.SeqNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);
intTabRecNum = clsEditRegionFldsBL.GetRecCountByCond(clsEditRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conEditRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsEditRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conEditRegionFlds.mId, lngmId));
clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conEditRegionFlds.mId, lngPrevmId));
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

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conEditRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);

lngNextmId = clsEditRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conEditRegionFlds.mId, lngmId));
clsEditRegionFldsBL.SetFldValue(clsEditRegionFldsEN._CurrTabName, conEditRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conEditRegionFlds.mId, lngNextmId));
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
public static bool GoBottom(List<long> arrKeyId ,string strRegionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conEditRegionFlds.mId, strKeyList);
List<clsEditRegionFldsEN> arrEditRegionFldsLst = GetObjLst(strCondition);
foreach (clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldsLst)
{
objEditRegionFlds.SeqNum = objEditRegionFlds.SeqNum + 10000;
UpdateBySql2(objEditRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsEditRegionFldsEN> arrEditRegionFldsObjList = new clsEditRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldsObjList)
{
objEditRegionFlds.SeqNum = intIndex;
UpdateBySql2(objEditRegionFlds);
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
public static bool GoTop(List<long> arrKeyId ,string strRegionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conEditRegionFlds.mId, strKeyList);
List<clsEditRegionFldsEN> arrEditRegionFldsLst = GetObjLst(strCondition);
foreach (clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldsLst)
{
objEditRegionFlds.SeqNum = objEditRegionFlds.SeqNum - 10000;
UpdateBySql2(objEditRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conEditRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsEditRegionFldsEN> arrEditRegionFldsObjList = new clsEditRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsEditRegionFldsEN objEditRegionFlds in arrEditRegionFldsObjList)
{
objEditRegionFlds.SeqNum = intIndex;
UpdateBySql2(objEditRegionFlds);
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
 /// 编辑区域字段(EditRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4EditRegionFlds : clsCommFun4BLV2
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
clsEditRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}