
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExcelExportRegionFldsBL
 表名:ExcelExportRegionFlds(00050149)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:56
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
public static class  clsExcelExportRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExcelExportRegionFldsEN GetObj(this K_mId_ExcelExportRegionFlds myKey)
{
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.GetObjBymId(myKey.Value);
return objExcelExportRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExcelExportRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsExcelExportRegionFldsBL.AddNewRecord)", objExcelExportRegionFldsEN.RegionId,objExcelExportRegionFldsEN.FldId,objExcelExportRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.AddNewRecordBySQL2(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objExcelExportRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objExcelExportRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],字段Id(FldId)=[{1}],OutFldId(OutFldId)=[{2}])已经存在,不能重复!", objExcelExportRegionFldsEN.RegionId, objExcelExportRegionFldsEN.FldId, objExcelExportRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objExcelExportRegionFldsEN.AddNewRecord();
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objExcelExportRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsExcelExportRegionFldsBL.AddNewRecordWithReturnKey)", objExcelExportRegionFldsEN.RegionId,objExcelExportRegionFldsEN.FldId,objExcelExportRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetmId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objExcelExportRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.mId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.mId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.mId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetRegionId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conExcelExportRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conExcelExportRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conExcelExportRegionFlds.RegionId);
}
objExcelExportRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.RegionId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.RegionId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.RegionId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetFldId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conExcelExportRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conExcelExportRegionFlds.FldId);
}
objExcelExportRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.FldId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.FldId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.FldId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetOutFldId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conExcelExportRegionFlds.OutFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conExcelExportRegionFlds.OutFldId);
}
objExcelExportRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.OutFldId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.OutFldId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.OutFldId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetSeqNum(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, conExcelExportRegionFlds.SeqNum);
objExcelExportRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.SeqNum) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.SeqNum, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.SeqNum] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetColCaption(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strColCaption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColCaption, 100, conExcelExportRegionFlds.ColCaption);
}
objExcelExportRegionFldsEN.ColCaption = strColCaption; //列标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.ColCaption) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.ColCaption, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.ColCaption] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetInUse(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objExcelExportRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.InUse) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.InUse, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.InUse] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetErrMsg(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conExcelExportRegionFlds.ErrMsg);
}
objExcelExportRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.ErrMsg) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetPrjId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conExcelExportRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conExcelExportRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conExcelExportRegionFlds.PrjId);
}
objExcelExportRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.PrjId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.PrjId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.PrjId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetUpdDate(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conExcelExportRegionFlds.UpdDate);
}
objExcelExportRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.UpdDate) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.UpdDate, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.UpdDate] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetUpdUser(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conExcelExportRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conExcelExportRegionFlds.UpdUser);
}
objExcelExportRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.UpdUser) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.UpdUser, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.UpdUser] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetMemo(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExcelExportRegionFlds.Memo);
}
objExcelExportRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.Memo) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.Memo, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.Memo] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetIsDefaultSort(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultSort, conExcelExportRegionFlds.IsDefaultSort);
objExcelExportRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.IsDefaultSort) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetIsNeedSort(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conExcelExportRegionFlds.IsNeedSort);
objExcelExportRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.IsNeedSort) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objExcelExportRegionFldsEN.CheckPropertyNew();
clsExcelExportRegionFldsEN objExcelExportRegionFldsCond = new clsExcelExportRegionFldsEN();
string strCondition = objExcelExportRegionFldsCond
.SetmId(objExcelExportRegionFldsEN.mId, "<>")
.SetRegionId(objExcelExportRegionFldsEN.RegionId, "=")
.SetFldId(objExcelExportRegionFldsEN.FldId, "=")
.SetOutFldId(objExcelExportRegionFldsEN.OutFldId, "=")
.GetCombineCondition();
objExcelExportRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsExcelExportRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RegionId_FldId_OutFldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objExcelExportRegionFldsEN.Update();
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
 /// <param name = "objExcelExportRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsExcelExportRegionFldsEN objExcelExportRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsExcelExportRegionFldsEN objExcelExportRegionFldsCond = new clsExcelExportRegionFldsEN();
string strCondition = objExcelExportRegionFldsCond
.SetRegionId(objExcelExportRegionFlds.RegionId, "=")
.SetFldId(objExcelExportRegionFlds.FldId, "=")
.SetOutFldId(objExcelExportRegionFlds.OutFldId, "=")
.GetCombineCondition();
objExcelExportRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsExcelExportRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objExcelExportRegionFlds.mId = clsExcelExportRegionFldsBL.GetFirstID_S(strCondition);
objExcelExportRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objExcelExportRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 if (objExcelExportRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.UpdateBySql2(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objExcelExportRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.UpdateBySql2(objExcelExportRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.UpdateBySqlWithCondition(objExcelExportRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.UpdateBySqlWithConditionTransaction(objExcelExportRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
public static int Delete(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
try
{
int intRecNum = clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.DelRecord(objExcelExportRegionFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objExcelExportRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsExcelExportRegionFldsEN objExcelExportRegionFldsENS, clsExcelExportRegionFldsEN objExcelExportRegionFldsENT)
{
try
{
objExcelExportRegionFldsENT.mId = objExcelExportRegionFldsENS.mId; //mId
objExcelExportRegionFldsENT.RegionId = objExcelExportRegionFldsENS.RegionId; //区域Id
objExcelExportRegionFldsENT.FldId = objExcelExportRegionFldsENS.FldId; //字段Id
objExcelExportRegionFldsENT.OutFldId = objExcelExportRegionFldsENS.OutFldId; //OutFldId
objExcelExportRegionFldsENT.SeqNum = objExcelExportRegionFldsENS.SeqNum; //字段序号
objExcelExportRegionFldsENT.ColCaption = objExcelExportRegionFldsENS.ColCaption; //列标题
objExcelExportRegionFldsENT.InUse = objExcelExportRegionFldsENS.InUse; //是否在用
objExcelExportRegionFldsENT.ErrMsg = objExcelExportRegionFldsENS.ErrMsg; //错误信息
objExcelExportRegionFldsENT.PrjId = objExcelExportRegionFldsENS.PrjId; //工程Id
objExcelExportRegionFldsENT.UpdDate = objExcelExportRegionFldsENS.UpdDate; //修改日期
objExcelExportRegionFldsENT.UpdUser = objExcelExportRegionFldsENS.UpdUser; //修改者
objExcelExportRegionFldsENT.Memo = objExcelExportRegionFldsENS.Memo; //说明
objExcelExportRegionFldsENT.IsDefaultSort = objExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objExcelExportRegionFldsENT.IsNeedSort = objExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
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
 /// <param name = "objExcelExportRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsExcelExportRegionFldsEN:objExcelExportRegionFldsENT</returns>
 public static clsExcelExportRegionFldsEN CopyTo(this clsExcelExportRegionFldsEN objExcelExportRegionFldsENS)
{
try
{
 clsExcelExportRegionFldsEN objExcelExportRegionFldsENT = new clsExcelExportRegionFldsEN()
{
mId = objExcelExportRegionFldsENS.mId, //mId
RegionId = objExcelExportRegionFldsENS.RegionId, //区域Id
FldId = objExcelExportRegionFldsENS.FldId, //字段Id
OutFldId = objExcelExportRegionFldsENS.OutFldId, //OutFldId
SeqNum = objExcelExportRegionFldsENS.SeqNum, //字段序号
ColCaption = objExcelExportRegionFldsENS.ColCaption, //列标题
InUse = objExcelExportRegionFldsENS.InUse, //是否在用
ErrMsg = objExcelExportRegionFldsENS.ErrMsg, //错误信息
PrjId = objExcelExportRegionFldsENS.PrjId, //工程Id
UpdDate = objExcelExportRegionFldsENS.UpdDate, //修改日期
UpdUser = objExcelExportRegionFldsENS.UpdUser, //修改者
Memo = objExcelExportRegionFldsENS.Memo, //说明
IsDefaultSort = objExcelExportRegionFldsENS.IsDefaultSort, //是否默认排序
IsNeedSort = objExcelExportRegionFldsENS.IsNeedSort, //是否需要排序
};
 return objExcelExportRegionFldsENT;
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
public static void CheckPropertyNew(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.CheckPropertyNew(objExcelExportRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.CheckProperty4Condition(objExcelExportRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.mId) == true)
{
string strComparisonOpmId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conExcelExportRegionFlds.mId, objExcelExportRegionFldsCond.mId, strComparisonOpmId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.RegionId, objExcelExportRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.FldId, objExcelExportRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.OutFldId, objExcelExportRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conExcelExportRegionFlds.SeqNum, objExcelExportRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.ColCaption) == true)
{
string strComparisonOpColCaption = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.ColCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.ColCaption, objExcelExportRegionFldsCond.ColCaption, strComparisonOpColCaption);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.InUse) == true)
{
if (objExcelExportRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.InUse);
}
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.ErrMsg, objExcelExportRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.PrjId, objExcelExportRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.UpdDate, objExcelExportRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.UpdUser, objExcelExportRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.Memo, objExcelExportRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.IsDefaultSort) == true)
{
if (objExcelExportRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.IsDefaultSort);
}
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.IsNeedSort) == true)
{
if (objExcelExportRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.IsNeedSort);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ExcelExportRegionFlds(Excel导出区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objExcelExportRegionFldsEN == null) return true;
if (objExcelExportRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 if (objExcelExportRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objExcelExportRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
}
 if (objExcelExportRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objExcelExportRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
}
if (clsExcelExportRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExcelExportRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
if (clsExcelExportRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ExcelExportRegionFlds(Excel导出区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExcelExportRegionFldsEN == null) return "";
if (objExcelExportRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 if (objExcelExportRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objExcelExportRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
}
 if (objExcelExportRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objExcelExportRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExcelExportRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ExcelExportRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objExcelExportRegionFlds = clsExcelExportRegionFldsBL.GetObjBymId(lngmId);
if (objExcelExportRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objExcelExportRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objExcelExportRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsExcelExportRegionFldsBL
{
public static RelatedActions_ExcelExportRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsExcelExportRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsExcelExportRegionFldsDA ExcelExportRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsExcelExportRegionFldsDA();
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
 public clsExcelExportRegionFldsBL()
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
if (string.IsNullOrEmpty(clsExcelExportRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExcelExportRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_ExcelExportRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ExcelExportRegionFldsDA.GetDataTable_ExcelExportRegionFlds(strWhereCond);
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
objDT = ExcelExportRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = ExcelExportRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ExcelExportRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ExcelExportRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ExcelExportRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = ExcelExportRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ExcelExportRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ExcelExportRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
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
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsExcelExportRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
arrExcelExportRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrExcelExportRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
public static List<clsExcelExportRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsExcelExportRegionFldsEN> GetSubObjLstCache(clsExcelExportRegionFldsEN objExcelExportRegionFldsCond)
{
 string strPrjId = objExcelExportRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsExcelExportRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsExcelExportRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsExcelExportRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExcelExportRegionFlds._AttributeName)
{
if (objExcelExportRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objExcelExportRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExcelExportRegionFldsCond[strFldName].ToString());
}
else
{
if (objExcelExportRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExcelExportRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExcelExportRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExcelExportRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExcelExportRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExcelExportRegionFldsCond[strFldName]));
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
List<clsExcelExportRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsExcelExportRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsExcelExportRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
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
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
public static List<clsExcelExportRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsExcelExportRegionFldsEN> arrObjLst = new List<clsExcelExportRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();
try
{
objExcelExportRegionFldsEN.mId = Int32.Parse(objRow[conExcelExportRegionFlds.mId].ToString().Trim()); //mId
objExcelExportRegionFldsEN.RegionId = objRow[conExcelExportRegionFlds.RegionId].ToString().Trim(); //区域Id
objExcelExportRegionFldsEN.FldId = objRow[conExcelExportRegionFlds.FldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.FldId].ToString().Trim(); //字段Id
objExcelExportRegionFldsEN.OutFldId = objRow[conExcelExportRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objExcelExportRegionFldsEN.SeqNum = Int32.Parse(objRow[conExcelExportRegionFlds.SeqNum].ToString().Trim()); //字段序号
objExcelExportRegionFldsEN.ColCaption = objRow[conExcelExportRegionFlds.ColCaption] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ColCaption].ToString().Trim(); //列标题
objExcelExportRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.InUse].ToString().Trim()); //是否在用
objExcelExportRegionFldsEN.ErrMsg = objRow[conExcelExportRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objExcelExportRegionFldsEN.PrjId = objRow[conExcelExportRegionFlds.PrjId].ToString().Trim(); //工程Id
objExcelExportRegionFldsEN.UpdDate = objRow[conExcelExportRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.UpdDate].ToString().Trim(); //修改日期
objExcelExportRegionFldsEN.UpdUser = objRow[conExcelExportRegionFlds.UpdUser].ToString().Trim(); //修改者
objExcelExportRegionFldsEN.Memo = objRow[conExcelExportRegionFlds.Memo] == DBNull.Value ? null : objRow[conExcelExportRegionFlds.Memo].ToString().Trim(); //说明
objExcelExportRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objExcelExportRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conExcelExportRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objExcelExportRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objExcelExportRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetExcelExportRegionFlds(ref clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
bool bolResult = ExcelExportRegionFldsDA.GetExcelExportRegionFlds(ref objExcelExportRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = ExcelExportRegionFldsDA.GetObjBymId(lngmId);
return objExcelExportRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsExcelExportRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = ExcelExportRegionFldsDA.GetFirstObj(strWhereCond);
 return objExcelExportRegionFldsEN;
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
public static clsExcelExportRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = ExcelExportRegionFldsDA.GetObjByDataRow(objRow);
 return objExcelExportRegionFldsEN;
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
public static clsExcelExportRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = ExcelExportRegionFldsDA.GetObjByDataRow(objRow);
 return objExcelExportRegionFldsEN;
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
 /// <param name = "lstExcelExportRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExcelExportRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsExcelExportRegionFldsEN> lstExcelExportRegionFldsObjLst)
{
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in lstExcelExportRegionFldsObjLst)
{
if (objExcelExportRegionFldsEN.mId == lngmId)
{
return objExcelExportRegionFldsEN;
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
 lngmId = new clsExcelExportRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = ExcelExportRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = ExcelExportRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ExcelExportRegionFldsDA.IsExist(lngmId);
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
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(lngmId);
objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objExcelExportRegionFldsEN.UpdUser = strOpUser;
return clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN);
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
 bolIsExist = clsExcelExportRegionFldsDA.IsExistTable();
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
 bolIsExist = ExcelExportRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExcelExportRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsExcelExportRegionFldsBL.AddNewRecordBySql2)", objExcelExportRegionFldsEN.RegionId,objExcelExportRegionFldsEN.FldId,objExcelExportRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ExcelExportRegionFldsDA.AddNewRecordBySQL2(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objExcelExportRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsExcelExportRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objExcelExportRegionFldsEN.RegionId,objExcelExportRegionFldsEN.FldId,objExcelExportRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = ExcelExportRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
try
{
bool bolResult = ExcelExportRegionFldsDA.Update(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 if (objExcelExportRegionFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ExcelExportRegionFldsDA.UpdateBySql2(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsBL.ReFreshCache(objExcelExportRegionFldsEN.PrjId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
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
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(lngmId);

if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(objExcelExportRegionFldsEN.mId, objExcelExportRegionFldsEN.UpdUser);
}
if (objExcelExportRegionFldsEN != null)
{
int intRecNum = ExcelExportRegionFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[ExcelExportRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conExcelExportRegionFlds.mId,
//lngmId);
//        clsExcelExportRegionFldsBL.DelExcelExportRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExcelExportRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExcelExportRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsExcelExportRegionFldsBL.relatedActions != null)
{
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ExcelExportRegionFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelExcelExportRegionFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsExcelExportRegionFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ExcelExportRegionFldsDA.DelExcelExportRegionFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
public static int DelExcelExportRegionFldssByCond(string strWhereCond)
{
try
{
if (clsExcelExportRegionFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsExcelExportRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conExcelExportRegionFlds.PrjId, strWhereCond);
int intRecNum = ExcelExportRegionFldsDA.DelExcelExportRegionFlds(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ExcelExportRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsExcelExportRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[ExcelExportRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsExcelExportRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsExcelExportRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objExcelExportRegionFldsENT">目标对象</param>
 public static void CopyTo(clsExcelExportRegionFldsEN objExcelExportRegionFldsENS, clsExcelExportRegionFldsEN objExcelExportRegionFldsENT)
{
try
{
objExcelExportRegionFldsENT.mId = objExcelExportRegionFldsENS.mId; //mId
objExcelExportRegionFldsENT.RegionId = objExcelExportRegionFldsENS.RegionId; //区域Id
objExcelExportRegionFldsENT.FldId = objExcelExportRegionFldsENS.FldId; //字段Id
objExcelExportRegionFldsENT.OutFldId = objExcelExportRegionFldsENS.OutFldId; //OutFldId
objExcelExportRegionFldsENT.SeqNum = objExcelExportRegionFldsENS.SeqNum; //字段序号
objExcelExportRegionFldsENT.ColCaption = objExcelExportRegionFldsENS.ColCaption; //列标题
objExcelExportRegionFldsENT.InUse = objExcelExportRegionFldsENS.InUse; //是否在用
objExcelExportRegionFldsENT.ErrMsg = objExcelExportRegionFldsENS.ErrMsg; //错误信息
objExcelExportRegionFldsENT.PrjId = objExcelExportRegionFldsENS.PrjId; //工程Id
objExcelExportRegionFldsENT.UpdDate = objExcelExportRegionFldsENS.UpdDate; //修改日期
objExcelExportRegionFldsENT.UpdUser = objExcelExportRegionFldsENS.UpdUser; //修改者
objExcelExportRegionFldsENT.Memo = objExcelExportRegionFldsENS.Memo; //说明
objExcelExportRegionFldsENT.IsDefaultSort = objExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objExcelExportRegionFldsENT.IsNeedSort = objExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
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
 /// <param name = "objExcelExportRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
try
{
objExcelExportRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objExcelExportRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conExcelExportRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.mId = objExcelExportRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(conExcelExportRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.RegionId = objExcelExportRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conExcelExportRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.FldId = objExcelExportRegionFldsEN.FldId == "[null]" ? null :  objExcelExportRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conExcelExportRegionFlds.OutFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.OutFldId = objExcelExportRegionFldsEN.OutFldId == "[null]" ? null :  objExcelExportRegionFldsEN.OutFldId; //OutFldId
}
if (arrFldSet.Contains(conExcelExportRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.SeqNum = objExcelExportRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conExcelExportRegionFlds.ColCaption, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.ColCaption = objExcelExportRegionFldsEN.ColCaption == "[null]" ? null :  objExcelExportRegionFldsEN.ColCaption; //列标题
}
if (arrFldSet.Contains(conExcelExportRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.InUse = objExcelExportRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conExcelExportRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.ErrMsg = objExcelExportRegionFldsEN.ErrMsg == "[null]" ? null :  objExcelExportRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conExcelExportRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.PrjId = objExcelExportRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conExcelExportRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.UpdDate = objExcelExportRegionFldsEN.UpdDate == "[null]" ? null :  objExcelExportRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conExcelExportRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.UpdUser = objExcelExportRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conExcelExportRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.Memo = objExcelExportRegionFldsEN.Memo == "[null]" ? null :  objExcelExportRegionFldsEN.Memo; //说明
}
if (arrFldSet.Contains(conExcelExportRegionFlds.IsDefaultSort, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.IsDefaultSort = objExcelExportRegionFldsEN.IsDefaultSort; //是否默认排序
}
if (arrFldSet.Contains(conExcelExportRegionFlds.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objExcelExportRegionFldsEN.IsNeedSort = objExcelExportRegionFldsEN.IsNeedSort; //是否需要排序
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
 /// <param name = "objExcelExportRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
try
{
if (objExcelExportRegionFldsEN.FldId == "[null]") objExcelExportRegionFldsEN.FldId = null; //字段Id
if (objExcelExportRegionFldsEN.OutFldId == "[null]") objExcelExportRegionFldsEN.OutFldId = null; //OutFldId
if (objExcelExportRegionFldsEN.ColCaption == "[null]") objExcelExportRegionFldsEN.ColCaption = null; //列标题
if (objExcelExportRegionFldsEN.ErrMsg == "[null]") objExcelExportRegionFldsEN.ErrMsg = null; //错误信息
if (objExcelExportRegionFldsEN.UpdDate == "[null]") objExcelExportRegionFldsEN.UpdDate = null; //修改日期
if (objExcelExportRegionFldsEN.Memo == "[null]") objExcelExportRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 ExcelExportRegionFldsDA.CheckPropertyNew(objExcelExportRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 ExcelExportRegionFldsDA.CheckProperty4Condition(objExcelExportRegionFldsEN);
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
if (clsExcelExportRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExcelExportRegionFldsBL没有刷新缓存机制(clsExcelExportRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrExcelExportRegionFldsObjLstCache == null)
//{
//arrExcelExportRegionFldsObjLstCache = ExcelExportRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExcelExportRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
arrExcelExportRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrExcelExportRegionFldsObjLst_Sel.Count() == 0)
{
   clsExcelExportRegionFldsEN obj = clsExcelExportRegionFldsBL.GetObjBymId(lngmId);
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
return arrExcelExportRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetAllExcelExportRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrExcelExportRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrExcelExportRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsExcelExportRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsExcelExportRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsExcelExportRegionFldsEN._RefreshTimeLst[clsExcelExportRegionFldsEN._RefreshTimeLst.Count - 1];
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
if (clsExcelExportRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsExcelExportRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsExcelExportRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ExcelExportRegionFlds(Excel导出区域字段)
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检测记录是否存在
string strResult = ExcelExportRegionFldsDA.GetUniCondStr(objExcelExportRegionFldsEN);
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
if (strInFldName != conExcelExportRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conExcelExportRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conExcelExportRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objExcelExportRegionFlds = clsExcelExportRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objExcelExportRegionFlds == null) return "";
return objExcelExportRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsExcelExportRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsExcelExportRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsExcelExportRegionFldsDA.GetRecCount();
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
int intRecCount = clsExcelExportRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsExcelExportRegionFldsEN objExcelExportRegionFldsCond)
{
 string strPrjId = objExcelExportRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsExcelExportRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsExcelExportRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsExcelExportRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conExcelExportRegionFlds._AttributeName)
{
if (objExcelExportRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objExcelExportRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExcelExportRegionFldsCond[strFldName].ToString());
}
else
{
if (objExcelExportRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objExcelExportRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objExcelExportRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objExcelExportRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objExcelExportRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objExcelExportRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objExcelExportRegionFldsCond[strFldName]));
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
 List<string> arrList = clsExcelExportRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ExcelExportRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ExcelExportRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ExcelExportRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsExcelExportRegionFldsDA.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ExcelExportRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsExcelExportRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsExcelExportRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsExcelExportRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ExcelExportRegionFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**OutFldId*/ 
 strCreateTabCode.Append(" OutFldId char(8) Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int not Null, "); 
 // /**列标题*/ 
 strCreateTabCode.Append(" ColCaption varchar(100) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否默认排序*/ 
 strCreateTabCode.Append(" IsDefaultSort bit not Null, "); 
 // /**是否需要排序*/ 
 strCreateTabCode.Append(" IsNeedSort bit not Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) not Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNameV2 varchar(50) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
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
strCondition += string.Format(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList = new clsExcelExportRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFlds in arrExcelExportRegionFldsObjList)
{
objExcelExportRegionFlds.SeqNum = intIndex;
UpdateBySql2(objExcelExportRegionFlds);
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

clsExcelExportRegionFldsEN objExcelExportRegionFlds = clsExcelExportRegionFldsBL.GetObjBymId(lngmId);

intOrderNum = objExcelExportRegionFlds.SeqNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);
intTabRecNum = clsExcelExportRegionFldsBL.GetRecCountByCond(clsExcelExportRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conExcelExportRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsExcelExportRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conExcelExportRegionFlds.mId, lngmId));
clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conExcelExportRegionFlds.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conExcelExportRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);

lngNextmId = clsExcelExportRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conExcelExportRegionFlds.mId, lngmId));
clsExcelExportRegionFldsBL.SetFldValue(clsExcelExportRegionFldsEN._CurrTabName, conExcelExportRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conExcelExportRegionFlds.mId, lngNextmId));
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
string strCondition = string.Format("{0} in ({1})", conExcelExportRegionFlds.mId, strKeyList);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsLst = GetObjLst(strCondition);
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFlds in arrExcelExportRegionFldsLst)
{
objExcelExportRegionFlds.SeqNum = objExcelExportRegionFlds.SeqNum + 10000;
UpdateBySql2(objExcelExportRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList = new clsExcelExportRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFlds in arrExcelExportRegionFldsObjList)
{
objExcelExportRegionFlds.SeqNum = intIndex;
UpdateBySql2(objExcelExportRegionFlds);
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
string strCondition = string.Format("{0} in ({1})", conExcelExportRegionFlds.mId, strKeyList);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsLst = GetObjLst(strCondition);
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFlds in arrExcelExportRegionFldsLst)
{
objExcelExportRegionFlds.SeqNum = objExcelExportRegionFlds.SeqNum - 10000;
UpdateBySql2(objExcelExportRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conExcelExportRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjList = new clsExcelExportRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsExcelExportRegionFldsEN objExcelExportRegionFlds in arrExcelExportRegionFldsObjList)
{
objExcelExportRegionFlds.SeqNum = intIndex;
UpdateBySql2(objExcelExportRegionFlds);
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
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ExcelExportRegionFlds : clsCommFun4BLV2
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
clsExcelExportRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}