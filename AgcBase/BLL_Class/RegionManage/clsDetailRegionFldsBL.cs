
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDetailRegionFldsBL
 表名:DetailRegionFlds(00050544)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:05
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
public static class  clsDetailRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDetailRegionFldsEN GetObj(this K_mId_DetailRegionFlds myKey)
{
clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.DetailRegionFldsDA.GetObjBymId(myKey.Value);
return objDetailRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDetailRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDetailRegionFldsBL.AddNewRecord)", objDetailRegionFldsEN.RegionId,objDetailRegionFldsEN.FldId,objDetailRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDetailRegionFldsBL.DetailRegionFldsDA.AddNewRecordBySQL2(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objDetailRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDetailRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],字段Id(FldId)=[{1}],OutFldId(OutFldId)=[{2}])已经存在,不能重复!", objDetailRegionFldsEN.RegionId, objDetailRegionFldsEN.FldId, objDetailRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDetailRegionFldsEN.AddNewRecord();
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDetailRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDetailRegionFldsBL.AddNewRecordWithReturnKey)", objDetailRegionFldsEN.RegionId,objDetailRegionFldsEN.FldId,objDetailRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsDetailRegionFldsBL.DetailRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetmId(this clsDetailRegionFldsEN objDetailRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objDetailRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.mId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.mId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.mId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetRegionId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conDetailRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conDetailRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conDetailRegionFlds.RegionId);
}
objDetailRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.RegionId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.RegionId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.RegionId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetFldId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conDetailRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDetailRegionFlds.FldId);
}
objDetailRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.FldId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.FldId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.FldId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetOutFldId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conDetailRegionFlds.OutFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conDetailRegionFlds.OutFldId);
}
objDetailRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.OutFldId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.OutFldId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.OutFldId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetLabelCaption(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strLabelCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLabelCaption, 150, conDetailRegionFlds.LabelCaption);
}
objDetailRegionFldsEN.LabelCaption = strLabelCaption; //标签标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.LabelCaption) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.LabelCaption, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.LabelCaption] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetCtlTypeId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conDetailRegionFlds.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conDetailRegionFlds.CtlTypeId);
}
objDetailRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.CtlTypeId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetColSpan(this clsDetailRegionFldsEN objDetailRegionFldsEN, int? intColSpan, string strComparisonOp="")
	{
objDetailRegionFldsEN.ColSpan = intColSpan; //跨列数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ColSpan) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ColSpan, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ColSpan] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetColIndex(this clsDetailRegionFldsEN objDetailRegionFldsEN, int? intColIndex, string strComparisonOp="")
	{
objDetailRegionFldsEN.ColIndex = intColIndex; //列序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ColIndex) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ColIndex, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ColIndex] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetWidth(this clsDetailRegionFldsEN objDetailRegionFldsEN, int? intWidth, string strComparisonOp="")
	{
objDetailRegionFldsEN.Width = intWidth; //宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.Width) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.Width, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.Width] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetIsMultiRow(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsMultiRow, string strComparisonOp="")
	{
objDetailRegionFldsEN.IsMultiRow = bolIsMultiRow; //是否多行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.IsMultiRow) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.IsMultiRow, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.IsMultiRow] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetSeqNum(this clsDetailRegionFldsEN objDetailRegionFldsEN, int? intSeqNum, string strComparisonOp="")
	{
objDetailRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.SeqNum) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.SeqNum, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.SeqNum] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetInOutTypeId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strInOutTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conDetailRegionFlds.InOutTypeId);
}
objDetailRegionFldsEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.InOutTypeId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.InOutTypeId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.InOutTypeId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetInUse(this clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objDetailRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.InUse) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.InUse, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.InUse] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetChangeEvent(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strChangeEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChangeEvent, 50, conDetailRegionFlds.ChangeEvent);
}
objDetailRegionFldsEN.ChangeEvent = strChangeEvent; //Change事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ChangeEvent) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ChangeEvent, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ChangeEvent] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetClickEvent(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strClickEvent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClickEvent, 50, conDetailRegionFlds.ClickEvent);
}
objDetailRegionFldsEN.ClickEvent = strClickEvent; //Click事件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ClickEvent) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ClickEvent, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ClickEvent] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetVarId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conDetailRegionFlds.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conDetailRegionFlds.VarId);
}
objDetailRegionFldsEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.VarId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.VarId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.VarId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetErrMsg(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDetailRegionFlds.ErrMsg);
}
objDetailRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.ErrMsg) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetPrjId(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDetailRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDetailRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDetailRegionFlds.PrjId);
}
objDetailRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.PrjId) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.PrjId, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.PrjId] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetUpdUser(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDetailRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDetailRegionFlds.UpdUser);
}
objDetailRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.UpdUser) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.UpdUser, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.UpdUser] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetUpdDate(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDetailRegionFlds.UpdDate);
}
objDetailRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.UpdDate) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.UpdDate, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.UpdDate] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDetailRegionFldsEN SetMemo(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDetailRegionFlds.Memo);
}
objDetailRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDetailRegionFldsEN.dicFldComparisonOp.ContainsKey(conDetailRegionFlds.Memo) == false)
{
objDetailRegionFldsEN.dicFldComparisonOp.Add(conDetailRegionFlds.Memo, strComparisonOp);
}
else
{
objDetailRegionFldsEN.dicFldComparisonOp[conDetailRegionFlds.Memo] = strComparisonOp;
}
}
return objDetailRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDetailRegionFldsEN.CheckPropertyNew();
clsDetailRegionFldsEN objDetailRegionFldsCond = new clsDetailRegionFldsEN();
string strCondition = objDetailRegionFldsCond
.SetmId(objDetailRegionFldsEN.mId, "<>")
.SetRegionId(objDetailRegionFldsEN.RegionId, "=")
.SetFldId(objDetailRegionFldsEN.FldId, "=")
.SetOutFldId(objDetailRegionFldsEN.OutFldId, "=")
.GetCombineCondition();
objDetailRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsDetailRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RegionId_FldId_OutFldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDetailRegionFldsEN.Update();
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
 /// <param name = "objDetailRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDetailRegionFldsEN objDetailRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDetailRegionFldsEN objDetailRegionFldsCond = new clsDetailRegionFldsEN();
string strCondition = objDetailRegionFldsCond
.SetRegionId(objDetailRegionFlds.RegionId, "=")
.SetFldId(objDetailRegionFlds.FldId, "=")
.SetOutFldId(objDetailRegionFlds.OutFldId, "=")
.GetCombineCondition();
objDetailRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsDetailRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDetailRegionFlds.mId = clsDetailRegionFldsBL.GetFirstID_S(strCondition);
objDetailRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objDetailRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 if (objDetailRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDetailRegionFldsBL.DetailRegionFldsDA.UpdateBySql2(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDetailRegionFldsEN objDetailRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDetailRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDetailRegionFldsBL.DetailRegionFldsDA.UpdateBySql2(objDetailRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsDetailRegionFldsBL.DetailRegionFldsDA.UpdateBySqlWithCondition(objDetailRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDetailRegionFldsEN objDetailRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDetailRegionFldsBL.DetailRegionFldsDA.UpdateBySqlWithConditionTransaction(objDetailRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
public static int Delete(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
try
{
int intRecNum = clsDetailRegionFldsBL.DetailRegionFldsDA.DelRecord(objDetailRegionFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsENS">源对象</param>
 /// <param name = "objDetailRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsDetailRegionFldsEN objDetailRegionFldsENS, clsDetailRegionFldsEN objDetailRegionFldsENT)
{
try
{
objDetailRegionFldsENT.mId = objDetailRegionFldsENS.mId; //mId
objDetailRegionFldsENT.RegionId = objDetailRegionFldsENS.RegionId; //区域Id
objDetailRegionFldsENT.FldId = objDetailRegionFldsENS.FldId; //字段Id
objDetailRegionFldsENT.OutFldId = objDetailRegionFldsENS.OutFldId; //OutFldId
objDetailRegionFldsENT.LabelCaption = objDetailRegionFldsENS.LabelCaption; //标签标题
objDetailRegionFldsENT.CtlTypeId = objDetailRegionFldsENS.CtlTypeId; //控件类型号
objDetailRegionFldsENT.ColSpan = objDetailRegionFldsENS.ColSpan; //跨列数
objDetailRegionFldsENT.ColIndex = objDetailRegionFldsENS.ColIndex; //列序号
objDetailRegionFldsENT.Width = objDetailRegionFldsENS.Width; //宽
objDetailRegionFldsENT.IsMultiRow = objDetailRegionFldsENS.IsMultiRow; //是否多行
objDetailRegionFldsENT.SeqNum = objDetailRegionFldsENS.SeqNum; //字段序号
objDetailRegionFldsENT.InOutTypeId = objDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objDetailRegionFldsENT.InUse = objDetailRegionFldsENS.InUse; //是否在用
objDetailRegionFldsENT.ChangeEvent = objDetailRegionFldsENS.ChangeEvent; //Change事件
objDetailRegionFldsENT.ClickEvent = objDetailRegionFldsENS.ClickEvent; //Click事件
objDetailRegionFldsENT.VarId = objDetailRegionFldsENS.VarId; //变量Id
objDetailRegionFldsENT.ErrMsg = objDetailRegionFldsENS.ErrMsg; //错误信息
objDetailRegionFldsENT.PrjId = objDetailRegionFldsENS.PrjId; //工程Id
objDetailRegionFldsENT.UpdUser = objDetailRegionFldsENS.UpdUser; //修改者
objDetailRegionFldsENT.UpdDate = objDetailRegionFldsENS.UpdDate; //修改日期
objDetailRegionFldsENT.Memo = objDetailRegionFldsENS.Memo; //说明
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
 /// <param name = "objDetailRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsDetailRegionFldsEN:objDetailRegionFldsENT</returns>
 public static clsDetailRegionFldsEN CopyTo(this clsDetailRegionFldsEN objDetailRegionFldsENS)
{
try
{
 clsDetailRegionFldsEN objDetailRegionFldsENT = new clsDetailRegionFldsEN()
{
mId = objDetailRegionFldsENS.mId, //mId
RegionId = objDetailRegionFldsENS.RegionId, //区域Id
FldId = objDetailRegionFldsENS.FldId, //字段Id
OutFldId = objDetailRegionFldsENS.OutFldId, //OutFldId
LabelCaption = objDetailRegionFldsENS.LabelCaption, //标签标题
CtlTypeId = objDetailRegionFldsENS.CtlTypeId, //控件类型号
ColSpan = objDetailRegionFldsENS.ColSpan, //跨列数
ColIndex = objDetailRegionFldsENS.ColIndex, //列序号
Width = objDetailRegionFldsENS.Width, //宽
IsMultiRow = objDetailRegionFldsENS.IsMultiRow, //是否多行
SeqNum = objDetailRegionFldsENS.SeqNum, //字段序号
InOutTypeId = objDetailRegionFldsENS.InOutTypeId, //INOUT类型ID
InUse = objDetailRegionFldsENS.InUse, //是否在用
ChangeEvent = objDetailRegionFldsENS.ChangeEvent, //Change事件
ClickEvent = objDetailRegionFldsENS.ClickEvent, //Click事件
VarId = objDetailRegionFldsENS.VarId, //变量Id
ErrMsg = objDetailRegionFldsENS.ErrMsg, //错误信息
PrjId = objDetailRegionFldsENS.PrjId, //工程Id
UpdUser = objDetailRegionFldsENS.UpdUser, //修改者
UpdDate = objDetailRegionFldsENS.UpdDate, //修改日期
Memo = objDetailRegionFldsENS.Memo, //说明
};
 return objDetailRegionFldsENT;
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
public static void CheckPropertyNew(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 clsDetailRegionFldsBL.DetailRegionFldsDA.CheckPropertyNew(objDetailRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 clsDetailRegionFldsBL.DetailRegionFldsDA.CheckProperty4Condition(objDetailRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDetailRegionFldsEN objDetailRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.mId) == true)
{
string strComparisonOpmId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.mId, objDetailRegionFldsCond.mId, strComparisonOpmId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.RegionId, objDetailRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.FldId, objDetailRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.OutFldId, objDetailRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.LabelCaption) == true)
{
string strComparisonOpLabelCaption = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.LabelCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.LabelCaption, objDetailRegionFldsCond.LabelCaption, strComparisonOpLabelCaption);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.CtlTypeId, objDetailRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ColSpan) == true)
{
string strComparisonOpColSpan = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ColSpan];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.ColSpan, objDetailRegionFldsCond.ColSpan, strComparisonOpColSpan);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ColIndex) == true)
{
string strComparisonOpColIndex = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ColIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.ColIndex, objDetailRegionFldsCond.ColIndex, strComparisonOpColIndex);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.Width) == true)
{
string strComparisonOpWidth = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.Width];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.Width, objDetailRegionFldsCond.Width, strComparisonOpWidth);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.IsMultiRow) == true)
{
if (objDetailRegionFldsCond.IsMultiRow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDetailRegionFlds.IsMultiRow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDetailRegionFlds.IsMultiRow);
}
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDetailRegionFlds.SeqNum, objDetailRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.InOutTypeId, objDetailRegionFldsCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.InUse) == true)
{
if (objDetailRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDetailRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDetailRegionFlds.InUse);
}
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ChangeEvent) == true)
{
string strComparisonOpChangeEvent = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ChangeEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ChangeEvent, objDetailRegionFldsCond.ChangeEvent, strComparisonOpChangeEvent);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ClickEvent) == true)
{
string strComparisonOpClickEvent = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ClickEvent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ClickEvent, objDetailRegionFldsCond.ClickEvent, strComparisonOpClickEvent);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.VarId) == true)
{
string strComparisonOpVarId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.VarId, objDetailRegionFldsCond.VarId, strComparisonOpVarId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.ErrMsg, objDetailRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.PrjId, objDetailRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.UpdUser, objDetailRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.UpdDate, objDetailRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objDetailRegionFldsCond.IsUpdated(conDetailRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objDetailRegionFldsCond.dicFldComparisonOp[conDetailRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDetailRegionFlds.Memo, objDetailRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DetailRegionFlds(详细区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDetailRegionFldsEN == null) return true;
if (objDetailRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 if (objDetailRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objDetailRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
}
 if (objDetailRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objDetailRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
}
if (clsDetailRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDetailRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
if (clsDetailRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DetailRegionFlds(详细区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDetailRegionFldsEN == null) return "";
if (objDetailRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 if (objDetailRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objDetailRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
}
 if (objDetailRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objDetailRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDetailRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDetailRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDetailRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDetailRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DetailRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objDetailRegionFlds = clsDetailRegionFldsBL.GetObjBymId(lngmId);
if (objDetailRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objDetailRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objDetailRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// 详细区域字段(DetailRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDetailRegionFldsBL
{
public static RelatedActions_DetailRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDetailRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDetailRegionFldsDA DetailRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDetailRegionFldsDA();
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
 public clsDetailRegionFldsBL()
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
if (string.IsNullOrEmpty(clsDetailRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDetailRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_DetailRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DetailRegionFldsDA.GetDataTable_DetailRegionFlds(strWhereCond);
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
objDT = DetailRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = DetailRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DetailRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DetailRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DetailRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = DetailRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DetailRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DetailRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsDetailRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
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
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDetailRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
arrDetailRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrDetailRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
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
public static List<clsDetailRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDetailRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDetailRegionFldsEN> GetSubObjLstCache(clsDetailRegionFldsEN objDetailRegionFldsCond)
{
 string strPrjId = objDetailRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDetailRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDetailRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDetailRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDetailRegionFlds._AttributeName)
{
if (objDetailRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objDetailRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDetailRegionFldsCond[strFldName].ToString());
}
else
{
if (objDetailRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDetailRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDetailRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDetailRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDetailRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDetailRegionFldsCond[strFldName]));
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
public static List<clsDetailRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
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
public static List<clsDetailRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
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
List<clsDetailRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDetailRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDetailRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDetailRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
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
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
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
public static List<clsDetailRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDetailRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
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
public static List<clsDetailRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDetailRegionFldsEN> arrObjLst = new List<clsDetailRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
try
{
objDetailRegionFldsEN.mId = Int32.Parse(objRow[conDetailRegionFlds.mId].ToString().Trim()); //mId
objDetailRegionFldsEN.RegionId = objRow[conDetailRegionFlds.RegionId].ToString().Trim(); //区域Id
objDetailRegionFldsEN.FldId = objRow[conDetailRegionFlds.FldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.FldId].ToString().Trim(); //字段Id
objDetailRegionFldsEN.OutFldId = objRow[conDetailRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDetailRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDetailRegionFldsEN.LabelCaption = objRow[conDetailRegionFlds.LabelCaption] == DBNull.Value ? null : objRow[conDetailRegionFlds.LabelCaption].ToString().Trim(); //标签标题
objDetailRegionFldsEN.CtlTypeId = objRow[conDetailRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDetailRegionFldsEN.ColSpan = objRow[conDetailRegionFlds.ColSpan] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColSpan].ToString().Trim()); //跨列数
objDetailRegionFldsEN.ColIndex = objRow[conDetailRegionFlds.ColIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.ColIndex].ToString().Trim()); //列序号
objDetailRegionFldsEN.Width = objRow[conDetailRegionFlds.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.Width].ToString().Trim()); //宽
objDetailRegionFldsEN.IsMultiRow = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.IsMultiRow].ToString().Trim()); //是否多行
objDetailRegionFldsEN.SeqNum = objRow[conDetailRegionFlds.SeqNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDetailRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDetailRegionFldsEN.InOutTypeId = objRow[conDetailRegionFlds.InOutTypeId] == DBNull.Value ? null : objRow[conDetailRegionFlds.InOutTypeId].ToString().Trim(); //INOUT类型ID
objDetailRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDetailRegionFlds.InUse].ToString().Trim()); //是否在用
objDetailRegionFldsEN.ChangeEvent = objRow[conDetailRegionFlds.ChangeEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ChangeEvent].ToString().Trim(); //Change事件
objDetailRegionFldsEN.ClickEvent = objRow[conDetailRegionFlds.ClickEvent] == DBNull.Value ? null : objRow[conDetailRegionFlds.ClickEvent].ToString().Trim(); //Click事件
objDetailRegionFldsEN.VarId = objRow[conDetailRegionFlds.VarId] == DBNull.Value ? null : objRow[conDetailRegionFlds.VarId].ToString().Trim(); //变量Id
objDetailRegionFldsEN.ErrMsg = objRow[conDetailRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDetailRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDetailRegionFldsEN.PrjId = objRow[conDetailRegionFlds.PrjId].ToString().Trim(); //工程Id
objDetailRegionFldsEN.UpdUser = objRow[conDetailRegionFlds.UpdUser].ToString().Trim(); //修改者
objDetailRegionFldsEN.UpdDate = objRow[conDetailRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDetailRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDetailRegionFldsEN.Memo = objRow[conDetailRegionFlds.Memo] == DBNull.Value ? null : objRow[conDetailRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDetailRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDetailRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDetailRegionFlds(ref clsDetailRegionFldsEN objDetailRegionFldsEN)
{
bool bolResult = DetailRegionFldsDA.GetDetailRegionFlds(ref objDetailRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDetailRegionFldsEN GetObjBymId(long lngmId)
{
clsDetailRegionFldsEN objDetailRegionFldsEN = DetailRegionFldsDA.GetObjBymId(lngmId);
return objDetailRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDetailRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDetailRegionFldsEN objDetailRegionFldsEN = DetailRegionFldsDA.GetFirstObj(strWhereCond);
 return objDetailRegionFldsEN;
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
public static clsDetailRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDetailRegionFldsEN objDetailRegionFldsEN = DetailRegionFldsDA.GetObjByDataRow(objRow);
 return objDetailRegionFldsEN;
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
public static clsDetailRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDetailRegionFldsEN objDetailRegionFldsEN = DetailRegionFldsDA.GetObjByDataRow(objRow);
 return objDetailRegionFldsEN;
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
 /// <param name = "lstDetailRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDetailRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsDetailRegionFldsEN> lstDetailRegionFldsObjLst)
{
foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in lstDetailRegionFldsObjLst)
{
if (objDetailRegionFldsEN.mId == lngmId)
{
return objDetailRegionFldsEN;
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
 lngmId = new clsDetailRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = DetailRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = DetailRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = DetailRegionFldsDA.IsExist(lngmId);
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
clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(lngmId);
objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDetailRegionFldsEN.UpdUser = strOpUser;
return clsDetailRegionFldsBL.UpdateBySql2(objDetailRegionFldsEN);
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
 bolIsExist = clsDetailRegionFldsDA.IsExistTable();
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
 bolIsExist = DetailRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDetailRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDetailRegionFldsBL.AddNewRecordBySql2)", objDetailRegionFldsEN.RegionId,objDetailRegionFldsEN.FldId,objDetailRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = DetailRegionFldsDA.AddNewRecordBySQL2(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDetailRegionFldsEN objDetailRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDetailRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDetailRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objDetailRegionFldsEN.RegionId,objDetailRegionFldsEN.FldId,objDetailRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = DetailRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
try
{
bool bolResult = DetailRegionFldsDA.Update(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 /// <param name = "objDetailRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 if (objDetailRegionFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DetailRegionFldsDA.UpdateBySql2(objDetailRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDetailRegionFldsBL.ReFreshCache(objDetailRegionFldsEN.PrjId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
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
 clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(lngmId);

if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(objDetailRegionFldsEN.mId, objDetailRegionFldsEN.UpdUser);
}
if (objDetailRegionFldsEN != null)
{
int intRecNum = DetailRegionFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDetailRegionFldsEN.PrjId);
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
objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[DetailRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDetailRegionFlds.mId,
//lngmId);
//        clsDetailRegionFldsBL.DelDetailRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDetailRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDetailRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsDetailRegionFldsBL.relatedActions != null)
{
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = DetailRegionFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelDetailRegionFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsDetailRegionFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsDetailRegionFldsEN objDetailRegionFldsEN = clsDetailRegionFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = DetailRegionFldsDA.DelDetailRegionFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDetailRegionFldsEN.PrjId);
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
public static int DelDetailRegionFldssByCond(string strWhereCond)
{
try
{
if (clsDetailRegionFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsDetailRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDetailRegionFlds.PrjId, strWhereCond);
int intRecNum = DetailRegionFldsDA.DelDetailRegionFlds(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DetailRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDetailRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[DetailRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDetailRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDetailRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objDetailRegionFldsENS">源对象</param>
 /// <param name = "objDetailRegionFldsENT">目标对象</param>
 public static void CopyTo(clsDetailRegionFldsEN objDetailRegionFldsENS, clsDetailRegionFldsEN objDetailRegionFldsENT)
{
try
{
objDetailRegionFldsENT.mId = objDetailRegionFldsENS.mId; //mId
objDetailRegionFldsENT.RegionId = objDetailRegionFldsENS.RegionId; //区域Id
objDetailRegionFldsENT.FldId = objDetailRegionFldsENS.FldId; //字段Id
objDetailRegionFldsENT.OutFldId = objDetailRegionFldsENS.OutFldId; //OutFldId
objDetailRegionFldsENT.LabelCaption = objDetailRegionFldsENS.LabelCaption; //标签标题
objDetailRegionFldsENT.CtlTypeId = objDetailRegionFldsENS.CtlTypeId; //控件类型号
objDetailRegionFldsENT.ColSpan = objDetailRegionFldsENS.ColSpan; //跨列数
objDetailRegionFldsENT.ColIndex = objDetailRegionFldsENS.ColIndex; //列序号
objDetailRegionFldsENT.Width = objDetailRegionFldsENS.Width; //宽
objDetailRegionFldsENT.IsMultiRow = objDetailRegionFldsENS.IsMultiRow; //是否多行
objDetailRegionFldsENT.SeqNum = objDetailRegionFldsENS.SeqNum; //字段序号
objDetailRegionFldsENT.InOutTypeId = objDetailRegionFldsENS.InOutTypeId; //INOUT类型ID
objDetailRegionFldsENT.InUse = objDetailRegionFldsENS.InUse; //是否在用
objDetailRegionFldsENT.ChangeEvent = objDetailRegionFldsENS.ChangeEvent; //Change事件
objDetailRegionFldsENT.ClickEvent = objDetailRegionFldsENS.ClickEvent; //Click事件
objDetailRegionFldsENT.VarId = objDetailRegionFldsENS.VarId; //变量Id
objDetailRegionFldsENT.ErrMsg = objDetailRegionFldsENS.ErrMsg; //错误信息
objDetailRegionFldsENT.PrjId = objDetailRegionFldsENS.PrjId; //工程Id
objDetailRegionFldsENT.UpdUser = objDetailRegionFldsENS.UpdUser; //修改者
objDetailRegionFldsENT.UpdDate = objDetailRegionFldsENS.UpdDate; //修改日期
objDetailRegionFldsENT.Memo = objDetailRegionFldsENS.Memo; //说明
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
 /// <param name = "objDetailRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
try
{
objDetailRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDetailRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDetailRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.mId = objDetailRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(conDetailRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.RegionId = objDetailRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conDetailRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.FldId = objDetailRegionFldsEN.FldId == "[null]" ? null :  objDetailRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conDetailRegionFlds.OutFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.OutFldId = objDetailRegionFldsEN.OutFldId == "[null]" ? null :  objDetailRegionFldsEN.OutFldId; //OutFldId
}
if (arrFldSet.Contains(conDetailRegionFlds.LabelCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.LabelCaption = objDetailRegionFldsEN.LabelCaption == "[null]" ? null :  objDetailRegionFldsEN.LabelCaption; //标签标题
}
if (arrFldSet.Contains(conDetailRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.CtlTypeId = objDetailRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conDetailRegionFlds.ColSpan, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.ColSpan = objDetailRegionFldsEN.ColSpan; //跨列数
}
if (arrFldSet.Contains(conDetailRegionFlds.ColIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.ColIndex = objDetailRegionFldsEN.ColIndex; //列序号
}
if (arrFldSet.Contains(conDetailRegionFlds.Width, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.Width = objDetailRegionFldsEN.Width; //宽
}
if (arrFldSet.Contains(conDetailRegionFlds.IsMultiRow, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.IsMultiRow = objDetailRegionFldsEN.IsMultiRow; //是否多行
}
if (arrFldSet.Contains(conDetailRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.SeqNum = objDetailRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conDetailRegionFlds.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.InOutTypeId = objDetailRegionFldsEN.InOutTypeId == "[null]" ? null :  objDetailRegionFldsEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(conDetailRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.InUse = objDetailRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conDetailRegionFlds.ChangeEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.ChangeEvent = objDetailRegionFldsEN.ChangeEvent == "[null]" ? null :  objDetailRegionFldsEN.ChangeEvent; //Change事件
}
if (arrFldSet.Contains(conDetailRegionFlds.ClickEvent, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.ClickEvent = objDetailRegionFldsEN.ClickEvent == "[null]" ? null :  objDetailRegionFldsEN.ClickEvent; //Click事件
}
if (arrFldSet.Contains(conDetailRegionFlds.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.VarId = objDetailRegionFldsEN.VarId == "[null]" ? null :  objDetailRegionFldsEN.VarId; //变量Id
}
if (arrFldSet.Contains(conDetailRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.ErrMsg = objDetailRegionFldsEN.ErrMsg == "[null]" ? null :  objDetailRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conDetailRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.PrjId = objDetailRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDetailRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.UpdUser = objDetailRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDetailRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.UpdDate = objDetailRegionFldsEN.UpdDate == "[null]" ? null :  objDetailRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDetailRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDetailRegionFldsEN.Memo = objDetailRegionFldsEN.Memo == "[null]" ? null :  objDetailRegionFldsEN.Memo; //说明
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
 /// <param name = "objDetailRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
try
{
if (objDetailRegionFldsEN.FldId == "[null]") objDetailRegionFldsEN.FldId = null; //字段Id
if (objDetailRegionFldsEN.OutFldId == "[null]") objDetailRegionFldsEN.OutFldId = null; //OutFldId
if (objDetailRegionFldsEN.LabelCaption == "[null]") objDetailRegionFldsEN.LabelCaption = null; //标签标题
if (objDetailRegionFldsEN.InOutTypeId == "[null]") objDetailRegionFldsEN.InOutTypeId = null; //INOUT类型ID
if (objDetailRegionFldsEN.ChangeEvent == "[null]") objDetailRegionFldsEN.ChangeEvent = null; //Change事件
if (objDetailRegionFldsEN.ClickEvent == "[null]") objDetailRegionFldsEN.ClickEvent = null; //Click事件
if (objDetailRegionFldsEN.VarId == "[null]") objDetailRegionFldsEN.VarId = null; //变量Id
if (objDetailRegionFldsEN.ErrMsg == "[null]") objDetailRegionFldsEN.ErrMsg = null; //错误信息
if (objDetailRegionFldsEN.UpdDate == "[null]") objDetailRegionFldsEN.UpdDate = null; //修改日期
if (objDetailRegionFldsEN.Memo == "[null]") objDetailRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 DetailRegionFldsDA.CheckPropertyNew(objDetailRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
 DetailRegionFldsDA.CheckProperty4Condition(objDetailRegionFldsEN);
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
if (clsDetailRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDetailRegionFldsBL没有刷新缓存机制(clsDetailRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDetailRegionFldsObjLstCache == null)
//{
//arrDetailRegionFldsObjLstCache = DetailRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDetailRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDetailRegionFldsEN> arrDetailRegionFldsObjLst_Sel =
arrDetailRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrDetailRegionFldsObjLst_Sel.Count() == 0)
{
   clsDetailRegionFldsEN obj = clsDetailRegionFldsBL.GetObjBymId(lngmId);
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
return arrDetailRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDetailRegionFldsEN> GetAllDetailRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrDetailRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDetailRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDetailRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDetailRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDetailRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsDetailRegionFldsEN._RefreshTimeLst[clsDetailRegionFldsEN._RefreshTimeLst.Count - 1];
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
if (clsDetailRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDetailRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDetailRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDetailRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DetailRegionFlds(详细区域字段)
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDetailRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDetailRegionFldsEN objDetailRegionFldsEN)
{
//检测记录是否存在
string strResult = DetailRegionFldsDA.GetUniCondStr(objDetailRegionFldsEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conDetailRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDetailRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDetailRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objDetailRegionFlds = clsDetailRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objDetailRegionFlds == null) return "";
return objDetailRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsDetailRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsDetailRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDetailRegionFldsDA.GetRecCount();
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
int intRecCount = clsDetailRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDetailRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDetailRegionFldsEN objDetailRegionFldsCond)
{
 string strPrjId = objDetailRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDetailRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDetailRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDetailRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDetailRegionFlds._AttributeName)
{
if (objDetailRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objDetailRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDetailRegionFldsCond[strFldName].ToString());
}
else
{
if (objDetailRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDetailRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDetailRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDetailRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDetailRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDetailRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDetailRegionFldsCond[strFldName]));
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
 List<string> arrList = clsDetailRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DetailRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DetailRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DetailRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDetailRegionFldsDA.SetFldValue(clsDetailRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DetailRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDetailRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDetailRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDetailRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DetailRegionFlds] "); 
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
 strCreateTabCode.Append(" CtlTypeId char(2) not Null, "); 
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
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**Change事件*/ 
 strCreateTabCode.Append(" ChangeEvent varchar(50) Null, "); 
 // /**Click事件*/ 
 strCreateTabCode.Append(" ClickEvent varchar(50) Null, "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) Null, "); 
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
 // /**INOUT类型名称*/ 
 strCreateTabCode.Append(" InOutTypeName varchar(30) Null, "); 
 // /**控件类型中文名*/ 
 strCreateTabCode.Append(" CtlCnName varchar(50) Null, "); 
 // /**界面Ids*/ 
 strCreateTabCode.Append(" ViewIds varchar(50) not Null, "); 
 // /**控件类型缩写*/ 
 strCreateTabCode.Append(" CtlTypeAbbr varchar(5) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNameV2 varchar(50) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**Out字段名*/ 
 strCreateTabCode.Append(" OutFldName varchar(50) Null, "); 
 // /**DN路径IdEx*/ 
 strCreateTabCode.Append(" DnPathIdEx char(8) Null, "); 
 // /**DN路径Id*/ 
 strCreateTabCode.Append(" DnPathId char(8) Null, "); 
 // /**使用函数映射*/ 
 strCreateTabCode.Append(" IsUseFunc bit Null, "); 
 // /**数据属性名*/ 
 strCreateTabCode.Append(" DataPropertyName varchar(50) Null, "); 
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
strCondition += string.Format(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjList = new clsDetailRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDetailRegionFldsEN objDetailRegionFlds in arrDetailRegionFldsObjList)
{
objDetailRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDetailRegionFlds);
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

clsDetailRegionFldsEN objDetailRegionFlds = clsDetailRegionFldsBL.GetObjBymId(lngmId);

intOrderNum = objDetailRegionFlds.SeqNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);
intTabRecNum = clsDetailRegionFldsBL.GetRecCountByCond(clsDetailRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conDetailRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsDetailRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conDetailRegionFlds.mId, lngmId));
clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conDetailRegionFlds.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conDetailRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);

lngNextmId = clsDetailRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conDetailRegionFlds.mId, lngmId));
clsDetailRegionFldsBL.SetFldValue(clsDetailRegionFldsEN._CurrTabName, conDetailRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conDetailRegionFlds.mId, lngNextmId));
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
string strCondition = string.Format("{0} in ({1})", conDetailRegionFlds.mId, strKeyList);
List<clsDetailRegionFldsEN> arrDetailRegionFldsLst = GetObjLst(strCondition);
foreach (clsDetailRegionFldsEN objDetailRegionFlds in arrDetailRegionFldsLst)
{
objDetailRegionFlds.SeqNum = objDetailRegionFlds.SeqNum + 10000;
UpdateBySql2(objDetailRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjList = new clsDetailRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDetailRegionFldsEN objDetailRegionFlds in arrDetailRegionFldsObjList)
{
objDetailRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDetailRegionFlds);
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
string strCondition = string.Format("{0} in ({1})", conDetailRegionFlds.mId, strKeyList);
List<clsDetailRegionFldsEN> arrDetailRegionFldsLst = GetObjLst(strCondition);
foreach (clsDetailRegionFldsEN objDetailRegionFlds in arrDetailRegionFldsLst)
{
objDetailRegionFlds.SeqNum = objDetailRegionFlds.SeqNum - 10000;
UpdateBySql2(objDetailRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDetailRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDetailRegionFldsEN> arrDetailRegionFldsObjList = new clsDetailRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDetailRegionFldsEN objDetailRegionFlds in arrDetailRegionFldsObjList)
{
objDetailRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDetailRegionFlds);
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
 /// 详细区域字段(DetailRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DetailRegionFlds : clsCommFun4BLV2
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
clsDetailRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}