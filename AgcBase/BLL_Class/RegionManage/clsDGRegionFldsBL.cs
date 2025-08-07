
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsBL
 表名:DGRegionFlds(00050113)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:58
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
public static class  clsDGRegionFldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDGRegionFldsEN GetObj(this K_mId_DGRegionFlds myKey)
{
clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.DGRegionFldsDA.GetObjBymId(myKey.Value);
return objDGRegionFldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDGRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDGRegionFldsBL.AddNewRecord)", objDGRegionFldsEN.RegionId,objDGRegionFldsEN.FldId,objDGRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDGRegionFldsBL.DGRegionFldsDA.AddNewRecordBySQL2(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
public static bool AddRecordEx(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
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
objDGRegionFldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDGRegionFldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(区域Id(RegionId)=[{0}],字段Id(FldId)=[{1}],OutFldId(OutFldId)=[{2}])已经存在,不能重复!", objDGRegionFldsEN.RegionId, objDGRegionFldsEN.FldId, objDGRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDGRegionFldsEN.AddNewRecord();
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDGRegionFldsEN) == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDGRegionFldsBL.AddNewRecordWithReturnKey)", objDGRegionFldsEN.RegionId,objDGRegionFldsEN.FldId,objDGRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsDGRegionFldsBL.DGRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetmId(this clsDGRegionFldsEN objDGRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objDGRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.mId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.mId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.mId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetRegionId(this clsDGRegionFldsEN objDGRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conDGRegionFlds.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conDGRegionFlds.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conDGRegionFlds.RegionId);
}
objDGRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.RegionId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.RegionId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.RegionId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetFldId(this clsDGRegionFldsEN objDGRegionFldsEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conDGRegionFlds.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDGRegionFlds.FldId);
}
objDGRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.FldId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.FldId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.FldId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetOutFldId(this clsDGRegionFldsEN objDGRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conDGRegionFlds.OutFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conDGRegionFlds.OutFldId);
}
objDGRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.OutFldId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.OutFldId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.OutFldId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetSortExpression(this clsDGRegionFldsEN objDGRegionFldsEN, string strSortExpression, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSortExpression, 50, conDGRegionFlds.SortExpression);
}
objDGRegionFldsEN.SortExpression = strSortExpression; //排序表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.SortExpression) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.SortExpression, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.SortExpression] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetSeqNum(this clsDGRegionFldsEN objDGRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, conDGRegionFlds.SeqNum);
objDGRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.SeqNum) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.SeqNum, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.SeqNum] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetHeaderText(this clsDGRegionFldsEN objDGRegionFldsEN, string strHeaderText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHeaderText, 100, conDGRegionFlds.HeaderText);
}
objDGRegionFldsEN.HeaderText = strHeaderText; //列头
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.HeaderText) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.HeaderText, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.HeaderText] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetToolTipText(this clsDGRegionFldsEN objDGRegionFldsEN, string strToolTipText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strToolTipText, 150, conDGRegionFlds.ToolTipText);
}
objDGRegionFldsEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.ToolTipText) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.ToolTipText, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.ToolTipText] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetCtlTypeId(this clsDGRegionFldsEN objDGRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conDGRegionFlds.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conDGRegionFlds.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conDGRegionFlds.CtlTypeId);
}
objDGRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.CtlTypeId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetDgFuncTypeId(this clsDGRegionFldsEN objDGRegionFldsEN, string strDgFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
}
objDGRegionFldsEN.DgFuncTypeId = strDgFuncTypeId; //Dg功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.DgFuncTypeId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.DgFuncTypeId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.DgFuncTypeId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsNeedSort(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conDGRegionFlds.IsNeedSort);
objDGRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsNeedSort) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsDefaultSort(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
objDGRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsDefaultSort) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsTransToChkBox(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsTransToChkBox, string strComparisonOp="")
	{
objDGRegionFldsEN.IsTransToChkBox = bolIsTransToChkBox; //是否转换成CheckBox
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsTransToChkBox) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsTransToChkBox, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsTransToChkBox] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsVisible(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsVisible, string strComparisonOp="")
	{
objDGRegionFldsEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsVisible) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsVisible, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsVisible] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsFuncFld(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsFuncFld, string strComparisonOp="")
	{
objDGRegionFldsEN.IsFuncFld = bolIsFuncFld; //是否功能字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsFuncFld) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsFuncFld, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsFuncFld] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetInUse(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objDGRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.InUse) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.InUse, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.InUse] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetErrMsg(this clsDGRegionFldsEN objDGRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDGRegionFlds.ErrMsg);
}
objDGRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.ErrMsg) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetPrjId(this clsDGRegionFldsEN objDGRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDGRegionFlds.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDGRegionFlds.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDGRegionFlds.PrjId);
}
objDGRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.PrjId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.PrjId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.PrjId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetUpdUser(this clsDGRegionFldsEN objDGRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDGRegionFlds.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDGRegionFlds.UpdUser);
}
objDGRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.UpdUser) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.UpdUser, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.UpdUser] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetUpdDate(this clsDGRegionFldsEN objDGRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDGRegionFlds.UpdDate);
}
objDGRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.UpdDate) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.UpdDate, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.UpdDate] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetMemo(this clsDGRegionFldsEN objDGRegionFldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDGRegionFlds.Memo);
}
objDGRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.Memo) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.Memo, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.Memo] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDGRegionFldsEN objDGRegionFldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDGRegionFldsEN.CheckPropertyNew();
clsDGRegionFldsEN objDGRegionFldsCond = new clsDGRegionFldsEN();
string strCondition = objDGRegionFldsCond
.SetmId(objDGRegionFldsEN.mId, "<>")
.SetRegionId(objDGRegionFldsEN.RegionId, "=")
.SetFldId(objDGRegionFldsEN.FldId, "=")
.SetOutFldId(objDGRegionFldsEN.OutFldId, "=")
.GetCombineCondition();
objDGRegionFldsEN._IsCheckProperty = true;
bool bolIsExist = clsDGRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RegionId_FldId_OutFldId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDGRegionFldsEN.Update();
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
 /// <param name = "objDGRegionFlds">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDGRegionFldsEN objDGRegionFlds)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDGRegionFldsEN objDGRegionFldsCond = new clsDGRegionFldsEN();
string strCondition = objDGRegionFldsCond
.SetRegionId(objDGRegionFlds.RegionId, "=")
.SetFldId(objDGRegionFlds.FldId, "=")
.SetOutFldId(objDGRegionFlds.OutFldId, "=")
.GetCombineCondition();
objDGRegionFlds._IsCheckProperty = true;
bool bolIsExist = clsDGRegionFldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDGRegionFlds.mId = clsDGRegionFldsBL.GetFirstID_S(strCondition);
objDGRegionFlds.UpdateWithCondition(strCondition);
}
else
{
objDGRegionFlds.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDGRegionFldsEN objDGRegionFldsEN)
{
 if (objDGRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDGRegionFldsBL.DGRegionFldsDA.UpdateBySql2(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDGRegionFldsEN objDGRegionFldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDGRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDGRegionFldsBL.DGRegionFldsDA.UpdateBySql2(objDGRegionFldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDGRegionFldsEN objDGRegionFldsEN, string strWhereCond)
{
try
{
bool bolResult = clsDGRegionFldsBL.DGRegionFldsDA.UpdateBySqlWithCondition(objDGRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDGRegionFldsEN objDGRegionFldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDGRegionFldsBL.DGRegionFldsDA.UpdateBySqlWithConditionTransaction(objDGRegionFldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
public static int Delete(this clsDGRegionFldsEN objDGRegionFldsEN)
{
try
{
int intRecNum = clsDGRegionFldsBL.DGRegionFldsDA.DelRecord(objDGRegionFldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
 public static void CopyTo(this clsDGRegionFldsEN objDGRegionFldsENS, clsDGRegionFldsEN objDGRegionFldsENT)
{
try
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.FldId = objDGRegionFldsENS.FldId; //字段Id
objDGRegionFldsENT.OutFldId = objDGRegionFldsENS.OutFldId; //OutFldId
objDGRegionFldsENT.SortExpression = objDGRegionFldsENS.SortExpression; //排序表达式
objDGRegionFldsENT.SeqNum = objDGRegionFldsENS.SeqNum; //字段序号
objDGRegionFldsENT.HeaderText = objDGRegionFldsENS.HeaderText; //列头
objDGRegionFldsENT.ToolTipText = objDGRegionFldsENS.ToolTipText; //提示文字
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsDefaultSort = objDGRegionFldsENS.IsDefaultSort; //是否默认排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.ErrMsg = objDGRegionFldsENS.ErrMsg; //错误信息
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程Id
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
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
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <returns>目标对象=>clsDGRegionFldsEN:objDGRegionFldsENT</returns>
 public static clsDGRegionFldsEN CopyTo(this clsDGRegionFldsEN objDGRegionFldsENS)
{
try
{
 clsDGRegionFldsEN objDGRegionFldsENT = new clsDGRegionFldsEN()
{
mId = objDGRegionFldsENS.mId, //mId
RegionId = objDGRegionFldsENS.RegionId, //区域Id
FldId = objDGRegionFldsENS.FldId, //字段Id
OutFldId = objDGRegionFldsENS.OutFldId, //OutFldId
SortExpression = objDGRegionFldsENS.SortExpression, //排序表达式
SeqNum = objDGRegionFldsENS.SeqNum, //字段序号
HeaderText = objDGRegionFldsENS.HeaderText, //列头
ToolTipText = objDGRegionFldsENS.ToolTipText, //提示文字
CtlTypeId = objDGRegionFldsENS.CtlTypeId, //控件类型号
DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId, //Dg功能类型Id
IsNeedSort = objDGRegionFldsENS.IsNeedSort, //是否需要排序
IsDefaultSort = objDGRegionFldsENS.IsDefaultSort, //是否默认排序
IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox, //是否转换成CheckBox
IsVisible = objDGRegionFldsENS.IsVisible, //是否显示
IsFuncFld = objDGRegionFldsENS.IsFuncFld, //是否功能字段
InUse = objDGRegionFldsENS.InUse, //是否在用
ErrMsg = objDGRegionFldsENS.ErrMsg, //错误信息
PrjId = objDGRegionFldsENS.PrjId, //工程Id
UpdUser = objDGRegionFldsENS.UpdUser, //修改者
UpdDate = objDGRegionFldsENS.UpdDate, //修改日期
Memo = objDGRegionFldsENS.Memo, //说明
};
 return objDGRegionFldsENT;
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
public static void CheckPropertyNew(this clsDGRegionFldsEN objDGRegionFldsEN)
{
 clsDGRegionFldsBL.DGRegionFldsDA.CheckPropertyNew(objDGRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDGRegionFldsEN objDGRegionFldsEN)
{
 clsDGRegionFldsBL.DGRegionFldsDA.CheckProperty4Condition(objDGRegionFldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDGRegionFldsEN objDGRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.mId) == true)
{
string strComparisonOpmId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDGRegionFlds.mId, objDGRegionFldsCond.mId, strComparisonOpmId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.RegionId, objDGRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.FldId, objDGRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.OutFldId, objDGRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.SortExpression) == true)
{
string strComparisonOpSortExpression = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.SortExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.SortExpression, objDGRegionFldsCond.SortExpression, strComparisonOpSortExpression);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDGRegionFlds.SeqNum, objDGRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.HeaderText) == true)
{
string strComparisonOpHeaderText = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.HeaderText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.HeaderText, objDGRegionFldsCond.HeaderText, strComparisonOpHeaderText);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.ToolTipText) == true)
{
string strComparisonOpToolTipText = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.ToolTipText, objDGRegionFldsCond.ToolTipText, strComparisonOpToolTipText);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.CtlTypeId, objDGRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.DgFuncTypeId) == true)
{
string strComparisonOpDgFuncTypeId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.DgFuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.DgFuncTypeId, objDGRegionFldsCond.DgFuncTypeId, strComparisonOpDgFuncTypeId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsNeedSort) == true)
{
if (objDGRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsNeedSort);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsDefaultSort) == true)
{
if (objDGRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsDefaultSort);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsTransToChkBox) == true)
{
if (objDGRegionFldsCond.IsTransToChkBox == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsTransToChkBox);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsTransToChkBox);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsVisible) == true)
{
if (objDGRegionFldsCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsVisible);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsFuncFld) == true)
{
if (objDGRegionFldsCond.IsFuncFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsFuncFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsFuncFld);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.InUse) == true)
{
if (objDGRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.InUse);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.ErrMsg, objDGRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.PrjId, objDGRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.UpdUser, objDGRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.UpdDate, objDGRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.Memo, objDGRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DGRegionFlds(DG区域字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDGRegionFldsEN objDGRegionFldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDGRegionFldsEN == null) return true;
if (objDGRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 if (objDGRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objDGRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
}
 if (objDGRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objDGRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
}
if (clsDGRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDGRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
if (clsDGRegionFldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DGRegionFlds(DG区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDGRegionFldsEN objDGRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDGRegionFldsEN == null) return "";
if (objDGRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 if (objDGRegionFldsEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objDGRegionFldsEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
}
 if (objDGRegionFldsEN.OutFldId == null)
{
 sbCondition.AppendFormat(" and OutFldId is null", objDGRegionFldsEN.OutFldId);
}
else
{
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDGRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DGRegionFlds
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
var objDGRegionFlds = clsDGRegionFldsBL.GetObjBymId(lngmId);
if (objDGRegionFlds == null) return false;
 var objViewRegion = clsViewRegionBL.GetObjByRegionId(objDGRegionFlds.RegionId);
if (objViewRegion == null) return false;
clsViewRegionBL.SetUpdDate(objDGRegionFlds.RegionId, strOpUser);
return true;
}
}
 /// <summary>
 /// DG区域字段(DGRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDGRegionFldsBL
{
public static RelatedActions_DGRegionFlds relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDGRegionFldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDGRegionFldsDA DGRegionFldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDGRegionFldsDA();
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
 public clsDGRegionFldsBL()
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
if (string.IsNullOrEmpty(clsDGRegionFldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDGRegionFldsEN._ConnectString);
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
public static DataTable GetDataTable_DGRegionFlds(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DGRegionFldsDA.GetDataTable_DGRegionFlds(strWhereCond);
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
objDT = DGRegionFldsDA.GetDataTable(strWhereCond);
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
objDT = DGRegionFldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DGRegionFldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DGRegionFldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DGRegionFldsDA.GetDataTable_Top(objTopPara);
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
objDT = DGRegionFldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DGRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DGRegionFldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsDGRegionFldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
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
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDGRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strPrjId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
arrDGRegionFldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrDGRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLst(string strWhereCond)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
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
public static List<clsDGRegionFldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDGRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDGRegionFldsEN> GetSubObjLstCache(clsDGRegionFldsEN objDGRegionFldsCond)
{
 string strPrjId = objDGRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDGRegionFldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDGRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDGRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDGRegionFlds._AttributeName)
{
if (objDGRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objDGRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDGRegionFldsCond[strFldName].ToString());
}
else
{
if (objDGRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDGRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDGRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDGRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDGRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDGRegionFldsCond[strFldName]));
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
public static List<clsDGRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
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
public static List<clsDGRegionFldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
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
List<clsDGRegionFldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDGRegionFldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDGRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
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
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
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
public static List<clsDGRegionFldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDGRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
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
public static List<clsDGRegionFldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDGRegionFldsEN> arrObjLst = new List<clsDGRegionFldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDGRegionFldsEN objDGRegionFldsEN = new clsDGRegionFldsEN();
try
{
objDGRegionFldsEN.mId = Int32.Parse(objRow[conDGRegionFlds.mId].ToString().Trim()); //mId
objDGRegionFldsEN.RegionId = objRow[conDGRegionFlds.RegionId].ToString().Trim(); //区域Id
objDGRegionFldsEN.FldId = objRow[conDGRegionFlds.FldId] == DBNull.Value ? null : objRow[conDGRegionFlds.FldId].ToString().Trim(); //字段Id
objDGRegionFldsEN.OutFldId = objRow[conDGRegionFlds.OutFldId] == DBNull.Value ? null : objRow[conDGRegionFlds.OutFldId].ToString().Trim(); //OutFldId
objDGRegionFldsEN.SortExpression = objRow[conDGRegionFlds.SortExpression] == DBNull.Value ? null : objRow[conDGRegionFlds.SortExpression].ToString().Trim(); //排序表达式
objDGRegionFldsEN.SeqNum = Int32.Parse(objRow[conDGRegionFlds.SeqNum].ToString().Trim()); //字段序号
objDGRegionFldsEN.HeaderText = objRow[conDGRegionFlds.HeaderText] == DBNull.Value ? null : objRow[conDGRegionFlds.HeaderText].ToString().Trim(); //列头
objDGRegionFldsEN.ToolTipText = objRow[conDGRegionFlds.ToolTipText] == DBNull.Value ? null : objRow[conDGRegionFlds.ToolTipText].ToString().Trim(); //提示文字
objDGRegionFldsEN.CtlTypeId = objRow[conDGRegionFlds.CtlTypeId].ToString().Trim(); //控件类型号
objDGRegionFldsEN.DgFuncTypeId = objRow[conDGRegionFlds.DgFuncTypeId] == DBNull.Value ? null : objRow[conDGRegionFlds.DgFuncTypeId].ToString().Trim(); //Dg功能类型Id
objDGRegionFldsEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsNeedSort].ToString().Trim()); //是否需要排序
objDGRegionFldsEN.IsDefaultSort = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsDefaultSort].ToString().Trim()); //是否默认排序
objDGRegionFldsEN.IsTransToChkBox = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsTransToChkBox].ToString().Trim()); //是否转换成CheckBox
objDGRegionFldsEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsVisible].ToString().Trim()); //是否显示
objDGRegionFldsEN.IsFuncFld = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.IsFuncFld].ToString().Trim()); //是否功能字段
objDGRegionFldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDGRegionFlds.InUse].ToString().Trim()); //是否在用
objDGRegionFldsEN.ErrMsg = objRow[conDGRegionFlds.ErrMsg] == DBNull.Value ? null : objRow[conDGRegionFlds.ErrMsg].ToString().Trim(); //错误信息
objDGRegionFldsEN.PrjId = objRow[conDGRegionFlds.PrjId].ToString().Trim(); //工程Id
objDGRegionFldsEN.UpdUser = objRow[conDGRegionFlds.UpdUser].ToString().Trim(); //修改者
objDGRegionFldsEN.UpdDate = objRow[conDGRegionFlds.UpdDate] == DBNull.Value ? null : objRow[conDGRegionFlds.UpdDate].ToString().Trim(); //修改日期
objDGRegionFldsEN.Memo = objRow[conDGRegionFlds.Memo] == DBNull.Value ? null : objRow[conDGRegionFlds.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDGRegionFldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDGRegionFldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDGRegionFlds(ref clsDGRegionFldsEN objDGRegionFldsEN)
{
bool bolResult = DGRegionFldsDA.GetDGRegionFlds(ref objDGRegionFldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDGRegionFldsEN GetObjBymId(long lngmId)
{
clsDGRegionFldsEN objDGRegionFldsEN = DGRegionFldsDA.GetObjBymId(lngmId);
return objDGRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDGRegionFldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDGRegionFldsEN objDGRegionFldsEN = DGRegionFldsDA.GetFirstObj(strWhereCond);
 return objDGRegionFldsEN;
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
public static clsDGRegionFldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDGRegionFldsEN objDGRegionFldsEN = DGRegionFldsDA.GetObjByDataRow(objRow);
 return objDGRegionFldsEN;
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
public static clsDGRegionFldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDGRegionFldsEN objDGRegionFldsEN = DGRegionFldsDA.GetObjByDataRow(objRow);
 return objDGRegionFldsEN;
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
 /// <param name = "lstDGRegionFldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDGRegionFldsEN GetObjBymIdFromList(long lngmId, List<clsDGRegionFldsEN> lstDGRegionFldsObjLst)
{
foreach (clsDGRegionFldsEN objDGRegionFldsEN in lstDGRegionFldsObjLst)
{
if (objDGRegionFldsEN.mId == lngmId)
{
return objDGRegionFldsEN;
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
 lngmId = new clsDGRegionFldsDA().GetFirstID(strWhereCond);
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
 arrList = DGRegionFldsDA.GetID(strWhereCond);
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
bool bolIsExist = DGRegionFldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = DGRegionFldsDA.IsExist(lngmId);
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
clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(lngmId);
objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDGRegionFldsEN.UpdUser = strOpUser;
return clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN);
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
 bolIsExist = clsDGRegionFldsDA.IsExistTable();
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
 bolIsExist = DGRegionFldsDA.IsExistTable(strTabName);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDGRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDGRegionFldsBL.AddNewRecordBySql2)", objDGRegionFldsEN.RegionId,objDGRegionFldsEN.FldId,objDGRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = DGRegionFldsDA.AddNewRecordBySQL2(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDGRegionFldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!区域Id = [{0}],字段Id = [{1}],OutFldId = [{2}]的数据已经存在!(in clsDGRegionFldsBL.AddNewRecordBySql2WithReturnKey)", objDGRegionFldsEN.RegionId,objDGRegionFldsEN.FldId,objDGRegionFldsEN.OutFldId);
throw new Exception(strMsg);
}
try
{
string strKey = DGRegionFldsDA.AddNewRecordBySQL2WithReturnKey(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDGRegionFldsEN objDGRegionFldsEN)
{
try
{
bool bolResult = DGRegionFldsDA.Update(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDGRegionFldsEN objDGRegionFldsEN)
{
 if (objDGRegionFldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DGRegionFldsDA.UpdateBySql2(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsBL.ReFreshCache(objDGRegionFldsEN.PrjId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
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
 clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(lngmId);

if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(objDGRegionFldsEN.mId, objDGRegionFldsEN.UpdUser);
}
if (objDGRegionFldsEN != null)
{
int intRecNum = DGRegionFldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDGRegionFldsEN.PrjId);
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
objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[DGRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDGRegionFlds.mId,
//lngmId);
//        clsDGRegionFldsBL.DelDGRegionFldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDGRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDGRegionFldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsDGRegionFldsBL.relatedActions != null)
{
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = DGRegionFldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelDGRegionFldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsDGRegionFldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = DGRegionFldsDA.DelDGRegionFlds(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDGRegionFldsEN.PrjId);
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
public static int DelDGRegionFldssByCond(string strWhereCond)
{
try
{
if (clsDGRegionFldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsDGRegionFldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDGRegionFlds.PrjId, strWhereCond);
int intRecNum = DGRegionFldsDA.DelDGRegionFlds(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DGRegionFlds]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDGRegionFldsDA.GetSpecSQLObj();
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
//删除与表:[DGRegionFlds]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDGRegionFldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDGRegionFldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
 public static void CopyTo(clsDGRegionFldsEN objDGRegionFldsENS, clsDGRegionFldsEN objDGRegionFldsENT)
{
try
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.FldId = objDGRegionFldsENS.FldId; //字段Id
objDGRegionFldsENT.OutFldId = objDGRegionFldsENS.OutFldId; //OutFldId
objDGRegionFldsENT.SortExpression = objDGRegionFldsENS.SortExpression; //排序表达式
objDGRegionFldsENT.SeqNum = objDGRegionFldsENS.SeqNum; //字段序号
objDGRegionFldsENT.HeaderText = objDGRegionFldsENS.HeaderText; //列头
objDGRegionFldsENT.ToolTipText = objDGRegionFldsENS.ToolTipText; //提示文字
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsDefaultSort = objDGRegionFldsENS.IsDefaultSort; //是否默认排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.ErrMsg = objDGRegionFldsENS.ErrMsg; //错误信息
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程Id
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
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
 /// <param name = "objDGRegionFldsEN">源简化对象</param>
 public static void SetUpdFlag(clsDGRegionFldsEN objDGRegionFldsEN)
{
try
{
objDGRegionFldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDGRegionFldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDGRegionFlds.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.mId = objDGRegionFldsEN.mId; //mId
}
if (arrFldSet.Contains(conDGRegionFlds.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.RegionId = objDGRegionFldsEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conDGRegionFlds.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.FldId = objDGRegionFldsEN.FldId == "[null]" ? null :  objDGRegionFldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conDGRegionFlds.OutFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.OutFldId = objDGRegionFldsEN.OutFldId == "[null]" ? null :  objDGRegionFldsEN.OutFldId; //OutFldId
}
if (arrFldSet.Contains(conDGRegionFlds.SortExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.SortExpression = objDGRegionFldsEN.SortExpression == "[null]" ? null :  objDGRegionFldsEN.SortExpression; //排序表达式
}
if (arrFldSet.Contains(conDGRegionFlds.SeqNum, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.SeqNum = objDGRegionFldsEN.SeqNum; //字段序号
}
if (arrFldSet.Contains(conDGRegionFlds.HeaderText, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.HeaderText = objDGRegionFldsEN.HeaderText == "[null]" ? null :  objDGRegionFldsEN.HeaderText; //列头
}
if (arrFldSet.Contains(conDGRegionFlds.ToolTipText, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.ToolTipText = objDGRegionFldsEN.ToolTipText == "[null]" ? null :  objDGRegionFldsEN.ToolTipText; //提示文字
}
if (arrFldSet.Contains(conDGRegionFlds.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.CtlTypeId = objDGRegionFldsEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(conDGRegionFlds.DgFuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.DgFuncTypeId = objDGRegionFldsEN.DgFuncTypeId == "[null]" ? null :  objDGRegionFldsEN.DgFuncTypeId; //Dg功能类型Id
}
if (arrFldSet.Contains(conDGRegionFlds.IsNeedSort, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.IsNeedSort = objDGRegionFldsEN.IsNeedSort; //是否需要排序
}
if (arrFldSet.Contains(conDGRegionFlds.IsDefaultSort, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.IsDefaultSort = objDGRegionFldsEN.IsDefaultSort; //是否默认排序
}
if (arrFldSet.Contains(conDGRegionFlds.IsTransToChkBox, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.IsTransToChkBox = objDGRegionFldsEN.IsTransToChkBox; //是否转换成CheckBox
}
if (arrFldSet.Contains(conDGRegionFlds.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.IsVisible = objDGRegionFldsEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conDGRegionFlds.IsFuncFld, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.IsFuncFld = objDGRegionFldsEN.IsFuncFld; //是否功能字段
}
if (arrFldSet.Contains(conDGRegionFlds.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.InUse = objDGRegionFldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conDGRegionFlds.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.ErrMsg = objDGRegionFldsEN.ErrMsg == "[null]" ? null :  objDGRegionFldsEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conDGRegionFlds.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.PrjId = objDGRegionFldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDGRegionFlds.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.UpdUser = objDGRegionFldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDGRegionFlds.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.UpdDate = objDGRegionFldsEN.UpdDate == "[null]" ? null :  objDGRegionFldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDGRegionFlds.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDGRegionFldsEN.Memo = objDGRegionFldsEN.Memo == "[null]" ? null :  objDGRegionFldsEN.Memo; //说明
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
 /// <param name = "objDGRegionFldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsDGRegionFldsEN objDGRegionFldsEN)
{
try
{
if (objDGRegionFldsEN.FldId == "[null]") objDGRegionFldsEN.FldId = null; //字段Id
if (objDGRegionFldsEN.OutFldId == "[null]") objDGRegionFldsEN.OutFldId = null; //OutFldId
if (objDGRegionFldsEN.SortExpression == "[null]") objDGRegionFldsEN.SortExpression = null; //排序表达式
if (objDGRegionFldsEN.HeaderText == "[null]") objDGRegionFldsEN.HeaderText = null; //列头
if (objDGRegionFldsEN.ToolTipText == "[null]") objDGRegionFldsEN.ToolTipText = null; //提示文字
if (objDGRegionFldsEN.DgFuncTypeId == "[null]") objDGRegionFldsEN.DgFuncTypeId = null; //Dg功能类型Id
if (objDGRegionFldsEN.ErrMsg == "[null]") objDGRegionFldsEN.ErrMsg = null; //错误信息
if (objDGRegionFldsEN.UpdDate == "[null]") objDGRegionFldsEN.UpdDate = null; //修改日期
if (objDGRegionFldsEN.Memo == "[null]") objDGRegionFldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDGRegionFldsEN objDGRegionFldsEN)
{
 DGRegionFldsDA.CheckPropertyNew(objDGRegionFldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDGRegionFldsEN objDGRegionFldsEN)
{
 DGRegionFldsDA.CheckProperty4Condition(objDGRegionFldsEN);
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
if (clsDGRegionFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDGRegionFldsBL没有刷新缓存机制(clsDGRegionFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDGRegionFldsObjLstCache == null)
//{
//arrDGRegionFldsObjLstCache = DGRegionFldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDGRegionFldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strPrjId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
arrDGRegionFldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrDGRegionFldsObjLst_Sel.Count() == 0)
{
   clsDGRegionFldsEN obj = clsDGRegionFldsBL.GetObjBymId(lngmId);
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
return arrDGRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDGRegionFldsEN> GetAllDGRegionFldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = GetObjLstCache(strPrjId); 
return arrDGRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDGRegionFldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDGRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDGRegionFldsEN._RefreshTimeLst.Count == 0) return "";
return clsDGRegionFldsEN._RefreshTimeLst[clsDGRegionFldsEN._RefreshTimeLst.Count - 1];
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
if (clsDGRegionFldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDGRegionFldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDGRegionFldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DGRegionFlds(DG区域字段)
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDGRegionFldsEN objDGRegionFldsEN)
{
//检测记录是否存在
string strResult = DGRegionFldsDA.GetUniCondStr(objDGRegionFldsEN);
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
if (strInFldName != conDGRegionFlds.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDGRegionFlds._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDGRegionFlds._AttributeName));
throw new Exception(strMsg);
}
var objDGRegionFlds = clsDGRegionFldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objDGRegionFlds == null) return "";
return objDGRegionFlds[strOutFldName].ToString();
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
int intRecCount = clsDGRegionFldsDA.GetRecCount(strTabName);
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
int intRecCount = clsDGRegionFldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDGRegionFldsDA.GetRecCount();
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
int intRecCount = clsDGRegionFldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDGRegionFldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDGRegionFldsEN objDGRegionFldsCond)
{
 string strPrjId = objDGRegionFldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDGRegionFldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDGRegionFldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDGRegionFldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDGRegionFlds._AttributeName)
{
if (objDGRegionFldsCond.IsUpdated(strFldName) == false) continue;
if (objDGRegionFldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDGRegionFldsCond[strFldName].ToString());
}
else
{
if (objDGRegionFldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDGRegionFldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDGRegionFldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDGRegionFldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDGRegionFldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDGRegionFldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDGRegionFldsCond[strFldName]));
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
 List<string> arrList = clsDGRegionFldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DGRegionFldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DGRegionFldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DGRegionFldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDGRegionFldsDA.SetFldValue(clsDGRegionFldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DGRegionFldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDGRegionFldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDGRegionFldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDGRegionFldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DGRegionFlds] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**OutFldId*/ 
 strCreateTabCode.Append(" OutFldId char(8) Null, "); 
 // /**排序表达式*/ 
 strCreateTabCode.Append(" SortExpression varchar(50) Null, "); 
 // /**字段序号*/ 
 strCreateTabCode.Append(" SeqNum int not Null, "); 
 // /**列头*/ 
 strCreateTabCode.Append(" HeaderText varchar(100) Null, "); 
 // /**提示文字*/ 
 strCreateTabCode.Append(" ToolTipText varchar(150) Null, "); 
 // /**控件类型号*/ 
 strCreateTabCode.Append(" CtlTypeId char(2) not Null, "); 
 // /**Dg功能类型Id*/ 
 strCreateTabCode.Append(" DgFuncTypeId char(4) Null, "); 
 // /**是否需要排序*/ 
 strCreateTabCode.Append(" IsNeedSort bit not Null, "); 
 // /**是否默认排序*/ 
 strCreateTabCode.Append(" IsDefaultSort bit Null, "); 
 // /**是否转换成CheckBox*/ 
 strCreateTabCode.Append(" IsTransToChkBox bit Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**是否功能字段*/ 
 strCreateTabCode.Append(" IsFuncFld bit Null, "); 
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
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**控件类型名*/ 
 strCreateTabCode.Append(" CtlTypeName varchar(30) Null, "); 
 // /**TdClass*/ 
 strCreateTabCode.Append(" TdClass varchar(50) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldNameV2 varchar(50) not Null, "); 
 // /**DN路径IdEx*/ 
 strCreateTabCode.Append(" DnPathIdEx char(8) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**Out字段名*/ 
 strCreateTabCode.Append(" OutFldName varchar(50) Null, "); 
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
strCondition += string.Format(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDGRegionFldsEN> arrDGRegionFldsObjList = new clsDGRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
{
objDGRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDGRegionFlds);
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

clsDGRegionFldsEN objDGRegionFlds = clsDGRegionFldsBL.GetObjBymId(lngmId);

intOrderNum = objDGRegionFlds.SeqNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);
intTabRecNum = clsDGRegionFldsBL.GetRecCountByCond(clsDGRegionFldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conDGRegionFlds.SeqNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsDGRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.SeqNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conDGRegionFlds.mId, lngmId));
clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.SeqNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conDGRegionFlds.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conDGRegionFlds.SeqNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);

lngNextmId = clsDGRegionFldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.SeqNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conDGRegionFlds.mId, lngmId));
clsDGRegionFldsBL.SetFldValue(clsDGRegionFldsEN._CurrTabName, conDGRegionFlds.SeqNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conDGRegionFlds.mId, lngNextmId));
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
string strCondition = string.Format("{0} in ({1})", conDGRegionFlds.mId, strKeyList);
List<clsDGRegionFldsEN> arrDGRegionFldsLst = GetObjLst(strCondition);
foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsLst)
{
objDGRegionFlds.SeqNum = objDGRegionFlds.SeqNum + 10000;
UpdateBySql2(objDGRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDGRegionFldsEN> arrDGRegionFldsObjList = new clsDGRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
{
objDGRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDGRegionFlds);
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
string strCondition = string.Format("{0} in ({1})", conDGRegionFlds.mId, strKeyList);
List<clsDGRegionFldsEN> arrDGRegionFldsLst = GetObjLst(strCondition);
foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsLst)
{
objDGRegionFlds.SeqNum = objDGRegionFlds.SeqNum - 10000;
UpdateBySql2(objDGRegionFlds);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conDGRegionFlds.RegionId, strRegionId);
 strCondition += string.Format(" order by SeqNum ");
List<clsDGRegionFldsEN> arrDGRegionFldsObjList = new clsDGRegionFldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsDGRegionFldsEN objDGRegionFlds in arrDGRegionFldsObjList)
{
objDGRegionFlds.SeqNum = intIndex;
UpdateBySql2(objDGRegionFlds);
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
 /// DG区域字段(DGRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DGRegionFlds : clsCommFun4BLV2
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
clsDGRegionFldsBL.ReFreshThisCache(strPrjId);
}
}

}