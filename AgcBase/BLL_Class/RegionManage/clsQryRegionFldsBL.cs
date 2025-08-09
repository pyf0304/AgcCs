
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQryRegionFldsBL
 表名:QryRegionFlds(00050115)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:58
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
public static class  clsQryRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQryRegionFldsEN GetObj(this K_mId_QryRegionFlds myKey)
{
clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.QryRegionFldsDA.GetObjBymId(myKey.Value);
return objQryRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQryRegionFldsEN objQryRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQryRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsQryRegionFldsBL.AddNewRecord)", objQryRegionFldsEN.RegionId,objQryRegionFldsEN.FldId,objQryRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQryRegionFldsBL.QryRegionFldsDA.AddNewRecordBySQL2(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsQryRegionFldsEN objQryRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objQryRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQryRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],字段Id(FldId)=[{1}],OutFldId(OutFldId)=[{2}])已经存在,不能重复!", objQryRegionFldsEN.RegionId, objQryRegionFldsEN.FldId, objQryRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQryRegionFldsEN.AddNewRecord();
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQryRegionFldsEN objQryRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQryRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsQryRegionFldsBL.AddNewRecordWithReturnKey)", objQryRegionFldsEN.RegionId,objQryRegionFldsEN.FldId,objQryRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQryRegionFldsBL.QryRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetmId(this clsQryRegionFldsEN objQryRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objQryRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.mId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.mId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.mId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetRegionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conQryRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conQryRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conQryRegionFlds.RegionId);
}
objQryRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.RegionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.RegionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.RegionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldId(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conQryRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conQryRegionFlds.FldId);
}
objQryRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetOutFldId(this clsQryRegionFldsEN objQryRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conQryRegionFlds.OutFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conQryRegionFlds.OutFldId);
}
objQryRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.OutFldId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.OutFldId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.OutFldId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetLabelCaption(this clsQryRegionFldsEN objQryRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conQryRegionFlds.LabelCaption);
}
objQryRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.LabelCaption) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetCtlTypeId(this clsQryRegionFldsEN objQryRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conQryRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conQryRegionFlds.CtlTypeId);
}
objQryRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.CtlTypeId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarId(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conQryRegionFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conQryRegionFlds.VarId);
}
objQryRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsTabId(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsTabId, 8, conQryRegionFlds.DsTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDsTabId, 8, conQryRegionFlds.DsTabId);
}
objQryRegionFldsEN.DsTabId = strDsTabId; //数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsTabId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsTabId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsTabId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetTabFeatureId4Ddl(this clsQryRegionFldsEN objQryRegionFldsEN, string strTabFeatureId4Ddl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId4Ddl, 8, conQryRegionFlds.TabFeatureId4Ddl);
}
objQryRegionFldsEN.TabFeatureId4Ddl = strTabFeatureId4Ddl; //下拉框表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.TabFeatureId4Ddl) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.TabFeatureId4Ddl, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.TabFeatureId4Ddl] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldIdCond1(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond1, 8, conQryRegionFlds.FldIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond1, 8, conQryRegionFlds.FldIdCond1);
}
objQryRegionFldsEN.FldIdCond1 = strFldIdCond1; //字段Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldIdCond1) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldIdCond1, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldIdCond1] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarIdCond1(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarIdCond1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond1, 8, conQryRegionFlds.VarIdCond1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond1, 8, conQryRegionFlds.VarIdCond1);
}
objQryRegionFldsEN.VarIdCond1 = strVarIdCond1; //变量Id_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarIdCond1) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarIdCond1, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarIdCond1] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetFldIdCond2(this clsQryRegionFldsEN objQryRegionFldsEN, string strFldIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldIdCond2, 8, conQryRegionFlds.FldIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldIdCond2, 8, conQryRegionFlds.FldIdCond2);
}
objQryRegionFldsEN.FldIdCond2 = strFldIdCond2; //字段Id_条件2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.FldIdCond2) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.FldIdCond2, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.FldIdCond2] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetVarIdCond2(this clsQryRegionFldsEN objQryRegionFldsEN, string strVarIdCond2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarIdCond2, 8, conQryRegionFlds.VarIdCond2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarIdCond2, 8, conQryRegionFlds.VarIdCond2);
}
objQryRegionFldsEN.VarIdCond2 = strVarIdCond2; //数据源字段_条件1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.VarIdCond2) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.VarIdCond2, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.VarIdCond2] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetQueryOptionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strQueryOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQueryOptionId, 2, conQryRegionFlds.QueryOptionId);
}
objQryRegionFldsEN.QueryOptionId = strQueryOptionId; //查询方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.QueryOptionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.QueryOptionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.QueryOptionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDdlItemsOptionId(this clsQryRegionFldsEN objQryRegionFldsEN, string strDdlItemsOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDdlItemsOptionId, 2, conQryRegionFlds.DdlItemsOptionId);
}
objQryRegionFldsEN.DdlItemsOptionId = strDdlItemsOptionId; //下拉框列表选项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DdlItemsOptionId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DdlItemsOptionId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DdlItemsOptionId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsSqlStr(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsSqlStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsSqlStr, 200, conQryRegionFlds.DsSqlStr);
}
objQryRegionFldsEN.DsSqlStr = strDsSqlStr; //数据源SQL串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsSqlStr) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsSqlStr, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsSqlStr] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetItemsString(this clsQryRegionFldsEN objQryRegionFldsEN, string strItemsString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strItemsString, 200, conQryRegionFlds.ItemsString);
}
objQryRegionFldsEN.ItemsString = strItemsString; //列表项串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ItemsString) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ItemsString, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ItemsString] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetDsCondStr(this clsQryRegionFldsEN objQryRegionFldsEN, string strDsCondStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDsCondStr, 50, conQryRegionFlds.DsCondStr);
}
objQryRegionFldsEN.DsCondStr = strDsCondStr; //数据源条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.DsCondStr) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.DsCondStr, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.DsCondStr] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetColSpan(this clsQryRegionFldsEN objQryRegionFldsEN, int? intColSpan, string strComparisonOp="")
	{
objQryRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ColSpan) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ColSpan, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ColSpan] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetWidth(this clsQryRegionFldsEN objQryRegionFldsEN, int? intWidth, string strComparisonOp="")
	{
objQryRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.Width) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.Width, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.Width] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetSeqNum(this clsQryRegionFldsEN objQryRegionFldsEN, int? intSeqNum, string strComparisonOp="")
	{
objQryRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.SeqNum) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.SeqNum, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.SeqNum] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetChangeEvent(this clsQryRegionFldsEN objQryRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conQryRegionFlds.ChangeEvent);
}
objQryRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ChangeEvent) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetClickEvent(this clsQryRegionFldsEN objQryRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conQryRegionFlds.ClickEvent);
}
objQryRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ClickEvent) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetInUse(this clsQryRegionFldsEN objQryRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objQryRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.InUse) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.InUse, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.InUse] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetErrMsg(this clsQryRegionFldsEN objQryRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conQryRegionFlds.ErrMsg);
}
objQryRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.ErrMsg) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetPrjId(this clsQryRegionFldsEN objQryRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conQryRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conQryRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conQryRegionFlds.PrjId);
}
objQryRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.PrjId) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.PrjId, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.PrjId] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetUpdUser(this clsQryRegionFldsEN objQryRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQryRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQryRegionFlds.UpdUser);
}
objQryRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.UpdUser) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.UpdUser, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.UpdUser] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetUpdDate(this clsQryRegionFldsEN objQryRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQryRegionFlds.UpdDate);
}
objQryRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.UpdDate) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.UpdDate, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.UpdDate] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQryRegionFldsEN SetMemo(this clsQryRegionFldsEN objQryRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQryRegionFlds.Memo);
}
objQryRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQryRegionFldsEN.dicFldComparisonOp.ContainsKey(conQryRegionFlds.Memo) == false)
{
objQryRegionFldsEN.dicFldComparisonOp.Add(conQryRegionFlds.Memo, strComparisonOp);
}
else
{
objQryRegionFldsEN.dicFldComparisonOp[conQryRegionFlds.Memo] = strComparisonOp;
}
}
return objQryRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQryRegionFldsEN objQryRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQryRegionFldsEN.CheckPropertyNew();
clsQryRegionFldsEN objQryRegionFldsCond = new clsQryRegionFldsEN();
string strCondition = objQryRegionFldsCond
.SetmId(objQryRegionFldsEN.mId, "<>")
.SetRegionId(objQryRegionFldsEN.RegionId, "=")
.SetFldId(objQryRegionFldsEN.FldId, "=")
.SetOutFldId(objQryRegionFldsEN.OutFldId, "=")
.GetCombineCondition();
objQryRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsQryRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RegionId_FldId_OutFldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQryRegionFldsEN.Update();
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
 /// <param name = "objQryRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQryRegionFldsEN objQryRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQryRegionFldsEN objQryRegionFldsCond = new clsQryRegionFldsEN();
string strCondition = objQryRegionFldsCond
.SetRegionId(objQryRegionFlds.RegionId, "=")
.SetFldId(objQryRegionFlds.FldId, "=")
.SetOutFldId(objQryRegionFlds.OutFldId, "=")
.GetCombineCondition();
objQryRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsQryRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQryRegionFlds.mId = clsQryRegionFldsBL.GetFirstID_S(strCondition);
objQryRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objQryRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQryRegionFldsEN objQryRegionFldsEN)
{
 if (objQryRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQryRegionFldsBL.QryRegionFldsDA.UpdateBySql2(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQryRegionFldsEN objQryRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQryRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQryRegionFldsBL.QryRegionFldsDA.UpdateBySql2(objQryRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQryRegionFldsEN objQryRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsQryRegionFldsBL.QryRegionFldsDA.UpdateBySqlWithCondition(objQryRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQryRegionFldsEN objQryRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQryRegionFldsBL.QryRegionFldsDA.UpdateBySqlWithConditionTransaction(objQryRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
public static int Delete(this clsQryRegionFldsEN objQryRegionFldsEN)
{
try
{
int intRecNum = clsQryRegionFldsBL.QryRegionFldsDA.DelRecord(objQryRegionFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsQryRegionFldsEN objQryRegionFldsENS, clsQryRegionFldsEN objQryRegionFldsENT)
{
try
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.FldId = objQryRegionFldsENS.FldId; //字段Id
objQryRegionFldsENT.OutFldId = objQryRegionFldsENS.OutFldId; //OutFldId
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.VarId = objQryRegionFldsENS.VarId; //变量Id
objQryRegionFldsENT.DsTabId = objQryRegionFldsENS.DsTabId; //数据源表ID
objQryRegionFldsENT.TabFeatureId4Ddl = objQryRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objQryRegionFldsENT.FldIdCond1 = objQryRegionFldsENS.FldIdCond1; //字段Id_条件1
objQryRegionFldsENT.VarIdCond1 = objQryRegionFldsENS.VarIdCond1; //变量Id_条件1
objQryRegionFldsENT.FldIdCond2 = objQryRegionFldsENS.FldIdCond2; //字段Id_条件2
objQryRegionFldsENT.VarIdCond2 = objQryRegionFldsENS.VarIdCond2; //数据源字段_条件1
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DdlItemsOptionId = objQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DsSqlStr = objQryRegionFldsENS.DsSqlStr; //数据源SQL串
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DsCondStr = objQryRegionFldsENS.DsCondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.ChangeEvent = objQryRegionFldsENS.ChangeEvent; //Change事件
objQryRegionFldsENT.ClickEvent = objQryRegionFldsENS.ClickEvent; //Click事件
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.ErrMsg = objQryRegionFldsENS.ErrMsg; //错误信息
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程Id
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
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
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsQryRegionFldsEN:objQryRegionFldsENT</returns>
 public static clsQryRegionFldsEN CopyTo(this clsQryRegionFldsEN objQryRegionFldsENS)
{
try
{
 clsQryRegionFldsEN objQryRegionFldsENT = new clsQryRegionFldsEN()
{
mId = objQryRegionFldsENS.mId, //mId
RegionId = objQryRegionFldsENS.RegionId, //区域Id
FldId = objQryRegionFldsENS.FldId, //字段Id
OutFldId = objQryRegionFldsENS.OutFldId, //OutFldId
LabelCaption = objQryRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objQryRegionFldsENS.CtlTypeId, //控件类型号
VarId = objQryRegionFldsENS.VarId, //变量Id
DsTabId = objQryRegionFldsENS.DsTabId, //数据源表ID
TabFeatureId4Ddl = objQryRegionFldsENS.TabFeatureId4Ddl, //下拉框表功能Id
FldIdCond1 = objQryRegionFldsENS.FldIdCond1, //字段Id_条件1
VarIdCond1 = objQryRegionFldsENS.VarIdCond1, //变量Id_条件1
FldIdCond2 = objQryRegionFldsENS.FldIdCond2, //字段Id_条件2
VarIdCond2 = objQryRegionFldsENS.VarIdCond2, //数据源字段_条件1
QueryOptionId = objQryRegionFldsENS.QueryOptionId, //查询方式Id
DdlItemsOptionId = objQryRegionFldsENS.DdlItemsOptionId, //下拉框列表选项ID
DsSqlStr = objQryRegionFldsENS.DsSqlStr, //数据源SQL串
ItemsString = objQryRegionFldsENS.ItemsString, //列表项串
DsCondStr = objQryRegionFldsENS.DsCondStr, //数据源条件串
ColSpan = objQryRegionFldsENS.ColSpan, //跨列数
Width = objQryRegionFldsENS.Width, //宽
SeqNum = objQryRegionFldsENS.SeqNum, //字段序号
ChangeEvent = objQryRegionFldsENS.ChangeEvent, //Change事件
ClickEvent = objQryRegionFldsENS.ClickEvent, //Click事件
InUse = objQryRegionFldsENS.InUse, //是否在用
ErrMsg = objQryRegionFldsENS.ErrMsg, //错误信息
PrjId = objQryRegionFldsENS.PrjId, //工程Id
UpdUser = objQryRegionFldsENS.UpdUser, //修改者
UpdDate = objQryRegionFldsENS.UpdDate, //修改日期
Memo = objQryRegionFldsENS.Memo, //说明
};
 return objQryRegionFldsENT;
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
public static void CheckPropertyNew(this clsQryRegionFldsEN objQryRegionFldsEN)
{
 clsQryRegionFldsBL.QryRegionFldsDA.CheckPropertyNew(objQryRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQryRegionFldsEN objQryRegionFldsEN)
{
 clsQryRegionFldsBL.QryRegionFldsDA.CheckProperty4Condition(objQryRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQryRegionFldsEN objQryRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.mId) == true)
{
string strComparisonOpmId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.mId, objQryRegionFldsCond.mId, strComparisonOpmId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.RegionId, objQryRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldId, objQryRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.OutFldId, objQryRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.LabelCaption, objQryRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.CtlTypeId, objQryRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarId, objQryRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsTabId) == true)
{
string strComparisonOpDsTabId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsTabId, objQryRegionFldsCond.DsTabId, strComparisonOpDsTabId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.TabFeatureId4Ddl) == true)
{
string strComparisonOpTabFeatureId4Ddl = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.TabFeatureId4Ddl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.TabFeatureId4Ddl, objQryRegionFldsCond.TabFeatureId4Ddl, strComparisonOpTabFeatureId4Ddl);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldIdCond1) == true)
{
string strComparisonOpFldIdCond1 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldIdCond1, objQryRegionFldsCond.FldIdCond1, strComparisonOpFldIdCond1);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarIdCond1) == true)
{
string strComparisonOpVarIdCond1 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarIdCond1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarIdCond1, objQryRegionFldsCond.VarIdCond1, strComparisonOpVarIdCond1);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.FldIdCond2) == true)
{
string strComparisonOpFldIdCond2 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.FldIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.FldIdCond2, objQryRegionFldsCond.FldIdCond2, strComparisonOpFldIdCond2);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.VarIdCond2) == true)
{
string strComparisonOpVarIdCond2 = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.VarIdCond2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.VarIdCond2, objQryRegionFldsCond.VarIdCond2, strComparisonOpVarIdCond2);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.QueryOptionId) == true)
{
string strComparisonOpQueryOptionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.QueryOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.QueryOptionId, objQryRegionFldsCond.QueryOptionId, strComparisonOpQueryOptionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DdlItemsOptionId) == true)
{
string strComparisonOpDdlItemsOptionId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DdlItemsOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DdlItemsOptionId, objQryRegionFldsCond.DdlItemsOptionId, strComparisonOpDdlItemsOptionId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsSqlStr) == true)
{
string strComparisonOpDsSqlStr = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsSqlStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsSqlStr, objQryRegionFldsCond.DsSqlStr, strComparisonOpDsSqlStr);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ItemsString) == true)
{
string strComparisonOpItemsString = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ItemsString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ItemsString, objQryRegionFldsCond.ItemsString, strComparisonOpItemsString);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.DsCondStr) == true)
{
string strComparisonOpDsCondStr = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.DsCondStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.DsCondStr, objQryRegionFldsCond.DsCondStr, strComparisonOpDsCondStr);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.ColSpan, objQryRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.Width) == true)
{
string strComparisonOpWidth = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.Width, objQryRegionFldsCond.Width, strComparisonOpWidth);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQryRegionFlds.SeqNum, objQryRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ChangeEvent, objQryRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ClickEvent, objQryRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.InUse) == true)
{
if (objQryRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQryRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQryRegionFlds.InUse);
}
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.ErrMsg, objQryRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.PrjId, objQryRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.UpdUser, objQryRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.UpdDate, objQryRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objQryRegionFldsCond.IsUpdated(conQryRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objQryRegionFldsCond.dicFldComparisonOp[conQryRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQryRegionFlds.Memo, objQryRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QryRegionFlds(查询区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQryRegionFldsEN objQryRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQryRegionFldsEN == null) return true;
if (objQryRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 if (objQryRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objQryRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
}
 if (objQryRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objQryRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
}
if (clsQryRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQryRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
if (clsQryRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QryRegionFlds(查询区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQryRegionFldsEN objQryRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQryRegionFldsEN == null) return "";
if (objQryRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 if (objQryRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objQryRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
}
 if (objQryRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objQryRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQryRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objQryRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objQryRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objQryRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QryRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objQryRegionFlds = clsQryRegionFldsBL.GetObjBymId(lngmId);
if (objQryRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objQryRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objQryRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// 查询区域字段(QryRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQryRegionFldsBL
{
public static RelatedActions_QryRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQryRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQryRegionFldsDA QryRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQryRegionFldsDA();
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
 public clsQryRegionFldsBL()
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
if (string.IsNullOrEmpty(clsQryRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQryRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_QryRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QryRegionFldsDA.GetDataTable_QryRegionFlds(strWhereCond);
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
objDT = QryRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = QryRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QryRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QryRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QryRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = QryRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QryRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QryRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsQryRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
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
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQryRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strPrjId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
arrQryRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQryRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
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
public static List<clsQryRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQryRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQryRegionFldsEN> GetSubObjLstCache(clsQryRegionFldsEN objQryRegionFldsCond)
{
 string strPrjId = objQryRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsQryRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsQryRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsQryRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQryRegionFlds._AttributeName)
{
if (objQryRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objQryRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQryRegionFldsCond[strFldName].ToString());
}
else
{
if (objQryRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQryRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQryRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQryRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQryRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQryRegionFldsCond[strFldName]));
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
public static List<clsQryRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
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
public static List<clsQryRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
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
List<clsQryRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQryRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQryRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQryRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
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
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
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
public static List<clsQryRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQryRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
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
public static List<clsQryRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQryRegionFldsEN> arrObjLst = new List<clsQryRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();
try
{
objQryRegionFldsEN.mId = Int32.Parse(objRow[conQryRegionFlds.mId].ToString().Trim()); //mId
objQryRegionFldsEN.RegionId = objRow[conQryRegionFlds.RegionId].ToString().Trim(); //区域Id
objQryRegionFldsEN.FldId = objRow[conQryRegionFlds.FldId] == DBNull.Value ? null : objRow[conQryRegionFlds.FldId].ToString().Trim(); //字段Id
objQryRegionFldsEN.OutFldId = objRow[conQryRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conQryRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objQryRegionFldsEN.LabelCaption = objRow[conQryRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conQryRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objQryRegionFldsEN.CtlTypeId = objRow[conQryRegionFlds.CtlTypeId] == DBNull.Value ? null : objRow[conQryRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objQryRegionFldsEN.VarId = objRow[conQryRegionFlds.VarId] == DBNull.Value ? null : objRow[conQryRegionFlds.VarId].ToString().Trim(); //变量Id
objQryRegionFldsEN.DsTabId = objRow[conQryRegionFlds.DsTabId] == DBNull.Value ? null : objRow[conQryRegionFlds.DsTabId].ToString().Trim(); //数据源表ID
objQryRegionFldsEN.TabFeatureId4Ddl = objRow[conQryRegionFlds.TabFeatureId4Ddl] == DBNull.Value ? null : objRow[conQryRegionFlds.TabFeatureId4Ddl].ToString().Trim(); //下拉框表功能Id
objQryRegionFldsEN.FldIdCond1 = objRow[conQryRegionFlds.FldIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond1].ToString().Trim(); //字段Id_条件1
objQryRegionFldsEN.VarIdCond1 = objRow[conQryRegionFlds.VarIdCond1] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond1].ToString().Trim(); //变量Id_条件1
objQryRegionFldsEN.FldIdCond2 = objRow[conQryRegionFlds.FldIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.FldIdCond2].ToString().Trim(); //字段Id_条件2
objQryRegionFldsEN.VarIdCond2 = objRow[conQryRegionFlds.VarIdCond2] == DBNull.Value ? null : objRow[conQryRegionFlds.VarIdCond2].ToString().Trim(); //数据源字段_条件1
objQryRegionFldsEN.QueryOptionId = objRow[conQryRegionFlds.QueryOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.QueryOptionId].ToString().Trim(); //查询方式Id
objQryRegionFldsEN.DdlItemsOptionId = objRow[conQryRegionFlds.DdlItemsOptionId] == DBNull.Value ? null : objRow[conQryRegionFlds.DdlItemsOptionId].ToString().Trim(); //下拉框列表选项ID
objQryRegionFldsEN.DsSqlStr = objRow[conQryRegionFlds.DsSqlStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsSqlStr].ToString().Trim(); //数据源SQL串
objQryRegionFldsEN.ItemsString = objRow[conQryRegionFlds.ItemsString] == DBNull.Value ? null : objRow[conQryRegionFlds.ItemsString].ToString().Trim(); //列表项串
objQryRegionFldsEN.DsCondStr = objRow[conQryRegionFlds.DsCondStr] == DBNull.Value ? null : objRow[conQryRegionFlds.DsCondStr].ToString().Trim(); //数据源条件串
objQryRegionFldsEN.ColSpan = objRow[conQryRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.ColSpan].ToString().Trim()); //跨列数
objQryRegionFldsEN.Width = objRow[conQryRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.Width].ToString().Trim()); //宽
objQryRegionFldsEN.SeqNum = objRow[conQryRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQryRegionFlds.SeqNum].ToString().Trim()); //字段序号
objQryRegionFldsEN.ChangeEvent = objRow[conQryRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objQryRegionFldsEN.ClickEvent = objRow[conQryRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conQryRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objQryRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conQryRegionFlds.InUse].ToString().Trim()); //是否在用
objQryRegionFldsEN.ErrMsg = objRow[conQryRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conQryRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objQryRegionFldsEN.PrjId = objRow[conQryRegionFlds.PrjId].ToString().Trim(); //工程Id
objQryRegionFldsEN.UpdUser = objRow[conQryRegionFlds.UpdUser].ToString().Trim(); //修改者
objQryRegionFldsEN.UpdDate = objRow[conQryRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conQryRegionFlds.UpdDate].ToString().Trim(); //修改日期
objQryRegionFldsEN.Memo = objRow[conQryRegionFlds.Memo] == DBNull.Value ? null : objRow[conQryRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQryRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQryRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQryRegionFlds(ref clsQryRegionFldsEN objQryRegionFldsEN)
{
bool bolResult = QryRegionFldsDA.GetQryRegionFlds(ref objQryRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQryRegionFldsEN GetObjBymId(long lngmId)
{
clsQryRegionFldsEN objQryRegionFldsEN = QryRegionFldsDA.GetObjBymId(lngmId);
return objQryRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQryRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQryRegionFldsEN objQryRegionFldsEN = QryRegionFldsDA.GetFirstObj(strWhereCond);
 return objQryRegionFldsEN;
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
public static clsQryRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQryRegionFldsEN objQryRegionFldsEN = QryRegionFldsDA.GetObjByDataRow(objRow);
 return objQryRegionFldsEN;
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
public static clsQryRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQryRegionFldsEN objQryRegionFldsEN = QryRegionFldsDA.GetObjByDataRow(objRow);
 return objQryRegionFldsEN;
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
 /// <param name = "lstQryRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQryRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsQryRegionFldsEN> lstQryRegionFldsObjLst)
{
foreach (clsQryRegionFldsEN objQryRegionFldsEN in lstQryRegionFldsObjLst)
{
if (objQryRegionFldsEN.mId == lngmId)
{
return objQryRegionFldsEN;
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
 lngmId = new clsQryRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = QryRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = QryRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QryRegionFldsDA.IsExist(lngmId);
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
clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(lngmId);
objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQryRegionFldsEN.UpdUser = strOpUser;
return clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
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
 bolIsExist = clsQryRegionFldsDA.IsExistTable();
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
 bolIsExist = QryRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQryRegionFldsEN objQryRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQryRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsQryRegionFldsBL.AddNewRecordBySql2)", objQryRegionFldsEN.RegionId,objQryRegionFldsEN.FldId,objQryRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QryRegionFldsDA.AddNewRecordBySQL2(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQryRegionFldsEN objQryRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQryRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsQryRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objQryRegionFldsEN.RegionId,objQryRegionFldsEN.FldId,objQryRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = QryRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQryRegionFldsEN objQryRegionFldsEN)
{
try
{
bool bolResult = QryRegionFldsDA.Update(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 /// <param name = "objQryRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQryRegionFldsEN objQryRegionFldsEN)
{
 if (objQryRegionFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QryRegionFldsDA.UpdateBySql2(objQryRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQryRegionFldsBL.ReFreshCache(objQryRegionFldsEN.PrjId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
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
 clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(lngmId);

if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(objQryRegionFldsEN.mId, objQryRegionFldsEN.UpdUser);
}
if (objQryRegionFldsEN != null)
{
int intRecNum = QryRegionFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQryRegionFldsEN.PrjId);
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
objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[QryRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQryRegionFlds.mId,
//lngmId);
//        clsQryRegionFldsBL.DelQryRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQryRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQryRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQryRegionFldsBL.relatedActions != null)
{
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QryRegionFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelQryRegionFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQryRegionFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = QryRegionFldsDA.DelQryRegionFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objQryRegionFldsEN.PrjId);
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
public static int DelQryRegionFldssByCond(string strWhereCond)
{
try
{
if (clsQryRegionFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQryRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conQryRegionFlds.PrjId, strWhereCond);
int intRecNum = QryRegionFldsDA.DelQryRegionFlds(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QryRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQryRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[QryRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQryRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQryRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQryRegionFldsENS">源对象</param>
 /// <param name = "objQryRegionFldsENT">目标对象</param>
 public static void CopyTo(clsQryRegionFldsEN objQryRegionFldsENS, clsQryRegionFldsEN objQryRegionFldsENT)
{
try
{
objQryRegionFldsENT.mId = objQryRegionFldsENS.mId; //mId
objQryRegionFldsENT.RegionId = objQryRegionFldsENS.RegionId; //区域Id
objQryRegionFldsENT.FldId = objQryRegionFldsENS.FldId; //字段Id
objQryRegionFldsENT.OutFldId = objQryRegionFldsENS.OutFldId; //OutFldId
objQryRegionFldsENT.LabelCaption = objQryRegionFldsENS.LabelCaption; //标签标题
objQryRegionFldsENT.CtlTypeId = objQryRegionFldsENS.CtlTypeId; //控件类型号
objQryRegionFldsENT.VarId = objQryRegionFldsENS.VarId; //变量Id
objQryRegionFldsENT.DsTabId = objQryRegionFldsENS.DsTabId; //数据源表ID
objQryRegionFldsENT.TabFeatureId4Ddl = objQryRegionFldsENS.TabFeatureId4Ddl; //下拉框表功能Id
objQryRegionFldsENT.FldIdCond1 = objQryRegionFldsENS.FldIdCond1; //字段Id_条件1
objQryRegionFldsENT.VarIdCond1 = objQryRegionFldsENS.VarIdCond1; //变量Id_条件1
objQryRegionFldsENT.FldIdCond2 = objQryRegionFldsENS.FldIdCond2; //字段Id_条件2
objQryRegionFldsENT.VarIdCond2 = objQryRegionFldsENS.VarIdCond2; //数据源字段_条件1
objQryRegionFldsENT.QueryOptionId = objQryRegionFldsENS.QueryOptionId; //查询方式Id
objQryRegionFldsENT.DdlItemsOptionId = objQryRegionFldsENS.DdlItemsOptionId; //下拉框列表选项ID
objQryRegionFldsENT.DsSqlStr = objQryRegionFldsENS.DsSqlStr; //数据源SQL串
objQryRegionFldsENT.ItemsString = objQryRegionFldsENS.ItemsString; //列表项串
objQryRegionFldsENT.DsCondStr = objQryRegionFldsENS.DsCondStr; //数据源条件串
objQryRegionFldsENT.ColSpan = objQryRegionFldsENS.ColSpan; //跨列数
objQryRegionFldsENT.Width = objQryRegionFldsENS.Width; //宽
objQryRegionFldsENT.SeqNum = objQryRegionFldsENS.SeqNum; //字段序号
objQryRegionFldsENT.ChangeEvent = objQryRegionFldsENS.ChangeEvent; //Change事件
objQryRegionFldsENT.ClickEvent = objQryRegionFldsENS.ClickEvent; //Click事件
objQryRegionFldsENT.InUse = objQryRegionFldsENS.InUse; //是否在用
objQryRegionFldsENT.ErrMsg = objQryRegionFldsENS.ErrMsg; //错误信息
objQryRegionFldsENT.PrjId = objQryRegionFldsENS.PrjId; //工程Id
objQryRegionFldsENT.UpdUser = objQryRegionFldsENS.UpdUser; //修改者
objQryRegionFldsENT.UpdDate = objQryRegionFldsENS.UpdDate; //修改日期
objQryRegionFldsENT.Memo = objQryRegionFldsENS.Memo; //说明
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
 /// <param name = "objQryRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsQryRegionFldsEN objQryRegionFldsEN)
{
try
{
objQryRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQryRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQryRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.mId = objQryRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(conQryRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.RegionId = objQryRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conQryRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.FldId = objQryRegionFldsEN.FldId == "[null]" ? null :  objQryRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conQryRegionFlds.OutFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.OutFldId = objQryRegionFldsEN.OutFldId == "[null]" ? null :  objQryRegionFldsEN.OutFldId; //OutFldId
}
if (arrFldSet.Contains(conQryRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.LabelCaption = objQryRegionFldsEN.LabelCaption == "[null]" ? null :  objQryRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(conQryRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.CtlTypeId = objQryRegionFldsEN.CtlTypeId == "[null]" ? null :  objQryRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conQryRegionFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.VarId = objQryRegionFldsEN.VarId == "[null]" ? null :  objQryRegionFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(conQryRegionFlds.DsTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.DsTabId = objQryRegionFldsEN.DsTabId == "[null]" ? null :  objQryRegionFldsEN.DsTabId; //数据源表ID
}
if (arrFldSet.Contains(conQryRegionFlds.TabFeatureId4Ddl, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.TabFeatureId4Ddl = objQryRegionFldsEN.TabFeatureId4Ddl == "[null]" ? null :  objQryRegionFldsEN.TabFeatureId4Ddl; //下拉框表功能Id
}
if (arrFldSet.Contains(conQryRegionFlds.FldIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.FldIdCond1 = objQryRegionFldsEN.FldIdCond1 == "[null]" ? null :  objQryRegionFldsEN.FldIdCond1; //字段Id_条件1
}
if (arrFldSet.Contains(conQryRegionFlds.VarIdCond1, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.VarIdCond1 = objQryRegionFldsEN.VarIdCond1 == "[null]" ? null :  objQryRegionFldsEN.VarIdCond1; //变量Id_条件1
}
if (arrFldSet.Contains(conQryRegionFlds.FldIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.FldIdCond2 = objQryRegionFldsEN.FldIdCond2 == "[null]" ? null :  objQryRegionFldsEN.FldIdCond2; //字段Id_条件2
}
if (arrFldSet.Contains(conQryRegionFlds.VarIdCond2, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.VarIdCond2 = objQryRegionFldsEN.VarIdCond2 == "[null]" ? null :  objQryRegionFldsEN.VarIdCond2; //数据源字段_条件1
}
if (arrFldSet.Contains(conQryRegionFlds.QueryOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.QueryOptionId = objQryRegionFldsEN.QueryOptionId == "[null]" ? null :  objQryRegionFldsEN.QueryOptionId; //查询方式Id
}
if (arrFldSet.Contains(conQryRegionFlds.DdlItemsOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.DdlItemsOptionId = objQryRegionFldsEN.DdlItemsOptionId == "[null]" ? null :  objQryRegionFldsEN.DdlItemsOptionId; //下拉框列表选项ID
}
if (arrFldSet.Contains(conQryRegionFlds.DsSqlStr, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.DsSqlStr = objQryRegionFldsEN.DsSqlStr == "[null]" ? null :  objQryRegionFldsEN.DsSqlStr; //数据源SQL串
}
if (arrFldSet.Contains(conQryRegionFlds.ItemsString, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.ItemsString = objQryRegionFldsEN.ItemsString == "[null]" ? null :  objQryRegionFldsEN.ItemsString; //列表项串
}
if (arrFldSet.Contains(conQryRegionFlds.DsCondStr, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.DsCondStr = objQryRegionFldsEN.DsCondStr == "[null]" ? null :  objQryRegionFldsEN.DsCondStr; //数据源条件串
}
if (arrFldSet.Contains(conQryRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.ColSpan = objQryRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(conQryRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.Width = objQryRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(conQryRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.SeqNum = objQryRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conQryRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.ChangeEvent = objQryRegionFldsEN.ChangeEvent == "[null]" ? null :  objQryRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(conQryRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.ClickEvent = objQryRegionFldsEN.ClickEvent == "[null]" ? null :  objQryRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(conQryRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.InUse = objQryRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conQryRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.ErrMsg = objQryRegionFldsEN.ErrMsg == "[null]" ? null :  objQryRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conQryRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.PrjId = objQryRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conQryRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.UpdUser = objQryRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conQryRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.UpdDate = objQryRegionFldsEN.UpdDate == "[null]" ? null :  objQryRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQryRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQryRegionFldsEN.Memo = objQryRegionFldsEN.Memo == "[null]" ? null :  objQryRegionFldsEN.Memo; //说明
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
 /// <param name = "objQryRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsQryRegionFldsEN objQryRegionFldsEN)
{
try
{
if (objQryRegionFldsEN.FldId == "[null]") objQryRegionFldsEN.FldId = null; //字段Id
if (objQryRegionFldsEN.OutFldId == "[null]") objQryRegionFldsEN.OutFldId = null; //OutFldId
if (objQryRegionFldsEN.LabelCaption == "[null]") objQryRegionFldsEN.LabelCaption = null; //标签标题
if (objQryRegionFldsEN.CtlTypeId == "[null]") objQryRegionFldsEN.CtlTypeId = null; //控件类型号
if (objQryRegionFldsEN.VarId == "[null]") objQryRegionFldsEN.VarId = null; //变量Id
if (objQryRegionFldsEN.DsTabId == "[null]") objQryRegionFldsEN.DsTabId = null; //数据源表ID
if (objQryRegionFldsEN.TabFeatureId4Ddl == "[null]") objQryRegionFldsEN.TabFeatureId4Ddl = null; //下拉框表功能Id
if (objQryRegionFldsEN.FldIdCond1 == "[null]") objQryRegionFldsEN.FldIdCond1 = null; //字段Id_条件1
if (objQryRegionFldsEN.VarIdCond1 == "[null]") objQryRegionFldsEN.VarIdCond1 = null; //变量Id_条件1
if (objQryRegionFldsEN.FldIdCond2 == "[null]") objQryRegionFldsEN.FldIdCond2 = null; //字段Id_条件2
if (objQryRegionFldsEN.VarIdCond2 == "[null]") objQryRegionFldsEN.VarIdCond2 = null; //数据源字段_条件1
if (objQryRegionFldsEN.QueryOptionId == "[null]") objQryRegionFldsEN.QueryOptionId = null; //查询方式Id
if (objQryRegionFldsEN.DdlItemsOptionId == "[null]") objQryRegionFldsEN.DdlItemsOptionId = null; //下拉框列表选项ID
if (objQryRegionFldsEN.DsSqlStr == "[null]") objQryRegionFldsEN.DsSqlStr = null; //数据源SQL串
if (objQryRegionFldsEN.ItemsString == "[null]") objQryRegionFldsEN.ItemsString = null; //列表项串
if (objQryRegionFldsEN.DsCondStr == "[null]") objQryRegionFldsEN.DsCondStr = null; //数据源条件串
if (objQryRegionFldsEN.ChangeEvent == "[null]") objQryRegionFldsEN.ChangeEvent = null; //Change事件
if (objQryRegionFldsEN.ClickEvent == "[null]") objQryRegionFldsEN.ClickEvent = null; //Click事件
if (objQryRegionFldsEN.ErrMsg == "[null]") objQryRegionFldsEN.ErrMsg = null; //错误信息
if (objQryRegionFldsEN.UpdDate == "[null]") objQryRegionFldsEN.UpdDate = null; //修改日期
if (objQryRegionFldsEN.Memo == "[null]") objQryRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsQryRegionFldsEN objQryRegionFldsEN)
{
 QryRegionFldsDA.CheckPropertyNew(objQryRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQryRegionFldsEN objQryRegionFldsEN)
{
 QryRegionFldsDA.CheckProperty4Condition(objQryRegionFldsEN);
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
if (clsQryRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQryRegionFldsBL没有刷新缓存机制(clsQryRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQryRegionFldsObjLstCache == null)
//{
//arrQryRegionFldsObjLstCache = QryRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQryRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strPrjId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
arrQryRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQryRegionFldsObjLst_Sel.Count() == 0)
{
   clsQryRegionFldsEN obj = clsQryRegionFldsBL.GetObjBymId(lngmId);
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
return arrQryRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQryRegionFldsEN> GetAllQryRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrQryRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQryRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsQryRegionFldsEN> arrQryRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrQryRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsQryRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQryRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsQryRegionFldsEN._RefreshTimeLst[clsQryRegionFldsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsQryRegionFldsBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsQryRegionFldsBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsQryRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQryRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsQryRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQryRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QryRegionFlds(查询区域字段)
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQryRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQryRegionFldsEN objQryRegionFldsEN)
{
//检测记录是否存在
string strResult = QryRegionFldsDA.GetUniCondStr(objQryRegionFldsEN);
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
if (strInFldName != conQryRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQryRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQryRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objQryRegionFlds = clsQryRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objQryRegionFlds == null) return "";
return objQryRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsQryRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsQryRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQryRegionFldsDA.GetRecCount();
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
int intRecCount = clsQryRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQryRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQryRegionFldsEN objQryRegionFldsCond)
{
 string strPrjId = objQryRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsQryRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsQryRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsQryRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQryRegionFlds._AttributeName)
{
if (objQryRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objQryRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQryRegionFldsCond[strFldName].ToString());
}
else
{
if (objQryRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQryRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQryRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQryRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQryRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQryRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQryRegionFldsCond[strFldName]));
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
 List<string> arrList = clsQryRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QryRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QryRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QryRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQryRegionFldsDA.SetFldValue(clsQryRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QryRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQryRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQryRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQryRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QryRegionFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**OutFldId*/ 
 strCreateTabCode.Append(" OutFldId char(8) Null, "); 
 // /**标签标题*/ 
 strCreateTabCode.Append(" LabelCaption varchar(150) Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) Null, "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) Null, "); 
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
 // /**查询方式Id*/ 
 strCreateTabCode.Append(" QueryOptionId varchar(2) Null, "); 
 // /**下拉框列表选项ID*/ 
 strCreateTabCode.Append(" DdlItemsOptionId char(2) Null, "); 
 // /**数据源SQL串*/ 
 strCreateTabCode.Append(" DsSqlStr varchar(200) Null, "); 
 // /**列表项串*/ 
 strCreateTabCode.Append(" ItemsString varchar(200) Null, "); 
 // /**数据源条件串*/ 
 strCreateTabCode.Append(" DsCondStr varchar(50) Null, "); 
 // /**跨列数*/ 
 strCreateTabCode.Append(" ColSpan int Null, "); 
 // /**宽*/ 
 strCreateTabCode.Append(" Width int Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int Null, "); 
 // /**Change事件*/ 
 strCreateTabCode.Append(" ChangeEvent varchar(50) Null, "); 
 // /**Click事件*/ 
 strCreateTabCode.Append(" ClickEvent varchar(50) Null, "); 
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
 // /**事件*/ 
 strCreateTabCode.Append(" Event varchar(50) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNameV2 varchar(50) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**Out字段名*/ 
 strCreateTabCode.Append(" OutFldName varchar(50) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**DN路径IdEx*/ 
 strCreateTabCode.Append(" DnPathIdEx char(8) Null, "); 
 // /**DN路径Id*/ 
 strCreateTabCode.Append(" DnPathId char(8) Null, "); 
 // /**使用函数映射*/ 
 strCreateTabCode.Append(" IsUseFunc bit Null, "); 
 // /**数据属性名*/ 
 strCreateTabCode.Append(" DataPropertyName varchar(50) Null, "); 
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
strCondition += string.Format(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsQryRegionFldsEN> arrQryRegionFldsObjList = new clsQryRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQryRegionFldsEN objQryRegionFlds in arrQryRegionFldsObjList)
{
objQryRegionFlds.SeqNum = intIndex;
UpdateBySql2(objQryRegionFlds);
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

clsQryRegionFldsEN objQryRegionFlds = clsQryRegionFldsBL.GetObjBymId(lngmId);

intOrderNum = objQryRegionFlds.SeqNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);
intTabRecNum = clsQryRegionFldsBL.GetRecCountByCond(clsQryRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conQryRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsQryRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conQryRegionFlds.mId, lngmId));
clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQryRegionFlds.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conQryRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);

lngNextmId = clsQryRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conQryRegionFlds.mId, lngmId));
clsQryRegionFldsBL.SetFldValue(clsQryRegionFldsEN._CurrTabName, conQryRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conQryRegionFlds.mId, lngNextmId));
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
string strCondition = string.Format("{0} in ({1})", conQryRegionFlds.mId, strKeyList);
List<clsQryRegionFldsEN> arrQryRegionFldsLst = GetObjLst(strCondition);
foreach (clsQryRegionFldsEN objQryRegionFlds in arrQryRegionFldsLst)
{
objQryRegionFlds.SeqNum = objQryRegionFlds.SeqNum + 10000;
UpdateBySql2(objQryRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsQryRegionFldsEN> arrQryRegionFldsObjList = new clsQryRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQryRegionFldsEN objQryRegionFlds in arrQryRegionFldsObjList)
{
objQryRegionFlds.SeqNum = intIndex;
UpdateBySql2(objQryRegionFlds);
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
string strCondition = string.Format("{0} in ({1})", conQryRegionFlds.mId, strKeyList);
List<clsQryRegionFldsEN> arrQryRegionFldsLst = GetObjLst(strCondition);
foreach (clsQryRegionFldsEN objQryRegionFlds in arrQryRegionFldsLst)
{
objQryRegionFlds.SeqNum = objQryRegionFlds.SeqNum - 10000;
UpdateBySql2(objQryRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conQryRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsQryRegionFldsEN> arrQryRegionFldsObjList = new clsQryRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsQryRegionFldsEN objQryRegionFlds in arrQryRegionFldsObjList)
{
objQryRegionFlds.SeqNum = intIndex;
UpdateBySql2(objQryRegionFlds);
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
 /// 查询区域字段(QryRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QryRegionFlds : clsCommFun4BLV2
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
clsQryRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}