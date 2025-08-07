
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathBL
 表名:DnPath(00050591)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsDnPathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnPathEN GetObj(this K_DnPathId_DnPath myKey)
{
clsDnPathEN objDnPathEN = clsDnPathBL.DnPathDA.GetObjByDnPathId(myKey.Value);
return objDnPathEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnPathEN) == false)
{
var strMsg = string.Format("记录已经存在!DN路径名 = [{0}],路径结点列表 = [{1}]的数据已经存在!(in clsDnPathBL.AddNewRecord)", objDnPathEN.DnPathName,objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
bool bolResult = clsDnPathBL.DnPathDA.AddNewRecordBySQL2(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
public static bool AddRecordEx(this clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDnPathBL.IsExist(objDnPathEN.DnPathId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDnPathEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDnPathEN.CheckUniqueness() == false)
{
strMsg = string.Format("(DN路径名(DnPathName)=[{0}],路径结点列表(DnPathNodeLst)=[{1}])已经存在,不能重复!", objDnPathEN.DnPathName, objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDnPathEN.AddNewRecord();
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnPathEN) == false)
{
var strMsg = string.Format("记录已经存在!DN路径名 = [{0}],路径结点列表 = [{1}]的数据已经存在!(in clsDnPathBL.AddNewRecordWithMaxId)", objDnPathEN.DnPathName,objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
string strDnPathId = clsDnPathBL.DnPathDA.AddNewRecordBySQL2WithReturnKey(objDnPathEN);
     objDnPathEN.DnPathId = strDnPathId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
}
return strDnPathId;
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDnPathEN) == false)
{
var strMsg = string.Format("记录已经存在!DN路径名 = [{0}],路径结点列表 = [{1}]的数据已经存在!(in clsDnPathBL.AddNewRecordWithReturnKey)", objDnPathEN.DnPathName,objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
string strKey = clsDnPathBL.DnPathDA.AddNewRecordBySQL2WithReturnKey(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathId(this clsDnPathEN objDnPathEN, string strDnPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conDnPath.DnPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conDnPath.DnPathId);
}
objDnPathEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathName(this clsDnPathEN objDnPathEN, string strDnPathName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathName, conDnPath.DnPathName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathName, 100, conDnPath.DnPathName);
}
objDnPathEN.DnPathName = strDnPathName; //DN路径名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathName) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathName, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathName] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetInDataNodeId(this clsDnPathEN objDnPathEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, conDnPath.InDataNodeId);
objDnPathEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.InDataNodeId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.InDataNodeId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.InDataNodeId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetOutDataNodeId(this clsDnPathEN objDnPathEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, conDnPath.OutDataNodeId);
objDnPathEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.OutDataNodeId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.OutDataNodeId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.OutDataNodeId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathNodeLst(this clsDnPathEN objDnPathEN, string strDnPathNodeLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathNodeLst, conDnPath.DnPathNodeLst);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathNodeLst, 500, conDnPath.DnPathNodeLst);
}
objDnPathEN.DnPathNodeLst = strDnPathNodeLst; //路径结点列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathNodeLst) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathNodeLst, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathNodeLst] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathNodeLstV2(this clsDnPathEN objDnPathEN, string strDnPathNodeLstV2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnPathNodeLstV2, 500, conDnPath.DnPathNodeLstV2);
}
objDnPathEN.DnPathNodeLstV2 = strDnPathNodeLstV2; //路径结点列表V2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathNodeLstV2) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathNodeLstV2, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathNodeLstV2] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetAssociationMappingId(this clsDnPathEN objDnPathEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDnPath.AssociationMappingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDnPath.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDnPath.AssociationMappingId);
}
objDnPathEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.AssociationMappingId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.AssociationMappingId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.AssociationMappingId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetIsHasErr(this clsDnPathEN objDnPathEN, bool bolIsHasErr, string strComparisonOp="")
	{
objDnPathEN.IsHasErr = bolIsHasErr; //是否有错
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.IsHasErr) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.IsHasErr, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.IsHasErr] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetEdgeNum(this clsDnPathEN objDnPathEN, int? intEdgeNum, string strComparisonOp="")
	{
objDnPathEN.EdgeNum = intEdgeNum; //边数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.EdgeNum) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.EdgeNum, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.EdgeNum] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetErrMsg(this clsDnPathEN objDnPathEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDnPath.ErrMsg);
}
objDnPathEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.ErrMsg) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.ErrMsg, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.ErrMsg] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetInUse(this clsDnPathEN objDnPathEN, bool bolInUse, string strComparisonOp="")
	{
objDnPathEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.InUse) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.InUse, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.InUse] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetIsExistPath(this clsDnPathEN objDnPathEN, bool bolIsExistPath, string strComparisonOp="")
	{
objDnPathEN.IsExistPath = bolIsExistPath; //是否存在路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.IsExistPath) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.IsExistPath, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.IsExistPath] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetPrjId(this clsDnPathEN objDnPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnPath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnPath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnPath.PrjId);
}
objDnPathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.PrjId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.PrjId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.PrjId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetUpdDate(this clsDnPathEN objDnPathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnPath.UpdDate);
}
objDnPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.UpdDate) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.UpdDate, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.UpdDate] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetUpdUser(this clsDnPathEN objDnPathEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnPath.UpdUser);
}
objDnPathEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.UpdUser) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.UpdUser, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.UpdUser] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetMemo(this clsDnPathEN objDnPathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnPath.Memo);
}
objDnPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.Memo) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.Memo, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.Memo] = strComparisonOp;
}
}
return objDnPathEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDnPathEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDnPathEN objDnPathEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDnPathEN.CheckPropertyNew();
clsDnPathEN objDnPathCond = new clsDnPathEN();
string strCondition = objDnPathCond
.SetDnPathId(objDnPathEN.DnPathId, "<>")
.SetDnPathName(objDnPathEN.DnPathName, "=")
.SetDnPathNodeLst(objDnPathEN.DnPathNodeLst, "=")
.GetCombineCondition();
objDnPathEN._IsCheckProperty = true;
bool bolIsExist = clsDnPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DnPathName_DnPathNodeLst)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDnPathEN.Update();
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
 /// <param name = "objDnPath">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDnPathEN objDnPath)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDnPathEN objDnPathCond = new clsDnPathEN();
string strCondition = objDnPathCond
.SetDnPathName(objDnPath.DnPathName, "=")
.SetDnPathNodeLst(objDnPath.DnPathNodeLst, "=")
.GetCombineCondition();
objDnPath._IsCheckProperty = true;
bool bolIsExist = clsDnPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDnPath.DnPathId = clsDnPathBL.GetFirstID_S(strCondition);
objDnPath.UpdateWithCondition(strCondition);
}
else
{
objDnPath.DnPathId = clsDnPathBL.GetMaxStrId_S();
objDnPath.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnPathEN objDnPathEN)
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnPathBL.DnPathDA.UpdateBySql2(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnPathEN objDnPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDnPathBL.DnPathDA.UpdateBySql2(objDnPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnPathEN objDnPathEN, string strWhereCond)
{
try
{
bool bolResult = clsDnPathBL.DnPathDA.UpdateBySqlWithCondition(objDnPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnPathEN objDnPathEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDnPathBL.DnPathDA.UpdateBySqlWithConditionTransaction(objDnPathEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDnPathEN objDnPathEN)
{
try
{
int intRecNum = clsDnPathBL.DnPathDA.DelRecord(objDnPathEN.DnPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathENS">源对象</param>
 /// <param name = "objDnPathENT">目标对象</param>
 public static void CopyTo(this clsDnPathEN objDnPathENS, clsDnPathEN objDnPathENT)
{
try
{
objDnPathENT.DnPathId = objDnPathENS.DnPathId; //DN路径Id
objDnPathENT.DnPathName = objDnPathENS.DnPathName; //DN路径名
objDnPathENT.InDataNodeId = objDnPathENS.InDataNodeId; //In数据结点Id
objDnPathENT.OutDataNodeId = objDnPathENS.OutDataNodeId; //Out数据结点Id
objDnPathENT.DnPathNodeLst = objDnPathENS.DnPathNodeLst; //路径结点列表
objDnPathENT.DnPathNodeLstV2 = objDnPathENS.DnPathNodeLstV2; //路径结点列表V2
objDnPathENT.AssociationMappingId = objDnPathENS.AssociationMappingId; //关联关系映射Id
objDnPathENT.IsHasErr = objDnPathENS.IsHasErr; //是否有错
objDnPathENT.EdgeNum = objDnPathENS.EdgeNum; //边数
objDnPathENT.ErrMsg = objDnPathENS.ErrMsg; //错误信息
objDnPathENT.InUse = objDnPathENS.InUse; //是否在用
objDnPathENT.IsExistPath = objDnPathENS.IsExistPath; //是否存在路径
objDnPathENT.PrjId = objDnPathENS.PrjId; //工程Id
objDnPathENT.UpdDate = objDnPathENS.UpdDate; //修改日期
objDnPathENT.UpdUser = objDnPathENS.UpdUser; //修改者
objDnPathENT.Memo = objDnPathENS.Memo; //说明
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
 /// <param name = "objDnPathENS">源对象</param>
 /// <returns>目标对象=>clsDnPathEN:objDnPathENT</returns>
 public static clsDnPathEN CopyTo(this clsDnPathEN objDnPathENS)
{
try
{
 clsDnPathEN objDnPathENT = new clsDnPathEN()
{
DnPathId = objDnPathENS.DnPathId, //DN路径Id
DnPathName = objDnPathENS.DnPathName, //DN路径名
InDataNodeId = objDnPathENS.InDataNodeId, //In数据结点Id
OutDataNodeId = objDnPathENS.OutDataNodeId, //Out数据结点Id
DnPathNodeLst = objDnPathENS.DnPathNodeLst, //路径结点列表
DnPathNodeLstV2 = objDnPathENS.DnPathNodeLstV2, //路径结点列表V2
AssociationMappingId = objDnPathENS.AssociationMappingId, //关联关系映射Id
IsHasErr = objDnPathENS.IsHasErr, //是否有错
EdgeNum = objDnPathENS.EdgeNum, //边数
ErrMsg = objDnPathENS.ErrMsg, //错误信息
InUse = objDnPathENS.InUse, //是否在用
IsExistPath = objDnPathENS.IsExistPath, //是否存在路径
PrjId = objDnPathENS.PrjId, //工程Id
UpdDate = objDnPathENS.UpdDate, //修改日期
UpdUser = objDnPathENS.UpdUser, //修改者
Memo = objDnPathENS.Memo, //说明
};
 return objDnPathENT;
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
public static void CheckPropertyNew(this clsDnPathEN objDnPathEN)
{
 clsDnPathBL.DnPathDA.CheckPropertyNew(objDnPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDnPathEN objDnPathEN)
{
 clsDnPathBL.DnPathDA.CheckProperty4Condition(objDnPathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnPathEN objDnPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnPathCond.IsUpdated(conDnPath.DnPathId) == true)
{
string strComparisonOpDnPathId = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathId, objDnPathCond.DnPathId, strComparisonOpDnPathId);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathName) == true)
{
string strComparisonOpDnPathName = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathName, objDnPathCond.DnPathName, strComparisonOpDnPathName);
}
if (objDnPathCond.IsUpdated(conDnPath.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objDnPathCond.dicFldComparisonOp[conDnPath.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.InDataNodeId, objDnPathCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objDnPathCond.IsUpdated(conDnPath.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objDnPathCond.dicFldComparisonOp[conDnPath.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.OutDataNodeId, objDnPathCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathNodeLst) == true)
{
string strComparisonOpDnPathNodeLst = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathNodeLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathNodeLst, objDnPathCond.DnPathNodeLst, strComparisonOpDnPathNodeLst);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathNodeLstV2) == true)
{
string strComparisonOpDnPathNodeLstV2 = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathNodeLstV2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathNodeLstV2, objDnPathCond.DnPathNodeLstV2, strComparisonOpDnPathNodeLstV2);
}
if (objDnPathCond.IsUpdated(conDnPath.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDnPathCond.dicFldComparisonOp[conDnPath.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.AssociationMappingId, objDnPathCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDnPathCond.IsUpdated(conDnPath.IsHasErr) == true)
{
if (objDnPathCond.IsHasErr == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.IsHasErr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.IsHasErr);
}
}
if (objDnPathCond.IsUpdated(conDnPath.EdgeNum) == true)
{
string strComparisonOpEdgeNum = objDnPathCond.dicFldComparisonOp[conDnPath.EdgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.EdgeNum, objDnPathCond.EdgeNum, strComparisonOpEdgeNum);
}
if (objDnPathCond.IsUpdated(conDnPath.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDnPathCond.dicFldComparisonOp[conDnPath.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.ErrMsg, objDnPathCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDnPathCond.IsUpdated(conDnPath.InUse) == true)
{
if (objDnPathCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.InUse);
}
}
if (objDnPathCond.IsUpdated(conDnPath.IsExistPath) == true)
{
if (objDnPathCond.IsExistPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.IsExistPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.IsExistPath);
}
}
if (objDnPathCond.IsUpdated(conDnPath.PrjId) == true)
{
string strComparisonOpPrjId = objDnPathCond.dicFldComparisonOp[conDnPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.PrjId, objDnPathCond.PrjId, strComparisonOpPrjId);
}
if (objDnPathCond.IsUpdated(conDnPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnPathCond.dicFldComparisonOp[conDnPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.UpdDate, objDnPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnPathCond.IsUpdated(conDnPath.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnPathCond.dicFldComparisonOp[conDnPath.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.UpdUser, objDnPathCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnPathCond.IsUpdated(conDnPath.Memo) == true)
{
string strComparisonOpMemo = objDnPathCond.dicFldComparisonOp[conDnPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.Memo, objDnPathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DnPath(数据结点路径), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DnPathName_DnPathNodeLst
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDnPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDnPathEN objDnPathEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDnPathEN == null) return true;
if (objDnPathEN.DnPathId == null || objDnPathEN.DnPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
if (clsDnPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DnPathId !=  '{0}'", objDnPathEN.DnPathId);
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
if (clsDnPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DnPath(数据结点路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DnPathName_DnPathNodeLst
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDnPathEN objDnPathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnPathEN == null) return "";
if (objDnPathEN.DnPathId == null || objDnPathEN.DnPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnPathId !=  '{0}'", objDnPathEN.DnPathId);
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DnPath
{
public virtual bool UpdRelaTabDate(string strDnPathId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据结点路径(DnPath)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDnPathBL
{
public static RelatedActions_DnPath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDnPathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDnPathDA DnPathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDnPathDA();
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
 public clsDnPathBL()
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
if (string.IsNullOrEmpty(clsDnPathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDnPathEN._ConnectString);
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
public static DataTable GetDataTable_DnPath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DnPathDA.GetDataTable_DnPath(strWhereCond);
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
objDT = DnPathDA.GetDataTable(strWhereCond);
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
objDT = DnPathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DnPathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DnPathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DnPathDA.GetDataTable_Top(objTopPara);
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
objDT = DnPathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DnPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DnPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDnPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDnPathEN> GetObjLstByDnPathIdLst(List<string> arrDnPathIdLst)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDnPathIdLst, true);
 string strWhereCond = string.Format("DnPathId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDnPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDnPathEN> GetObjLstByDnPathIdLstCache(List<string> arrDnPathIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel =
arrDnPathObjLstCache
.Where(x => arrDnPathIdLst.Contains(x.DnPathId));
return arrDnPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetObjLst(string strWhereCond)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
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
public static List<clsDnPathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDnPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDnPathEN> GetSubObjLstCache(clsDnPathEN objDnPathCond)
{
 string strPrjId = objDnPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDnPathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDnPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnPath._AttributeName)
{
if (objDnPathCond.IsUpdated(strFldName) == false) continue;
if (objDnPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnPathCond[strFldName].ToString());
}
else
{
if (objDnPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnPathCond[strFldName]));
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
public static List<clsDnPathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
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
public static List<clsDnPathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
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
List<clsDnPathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDnPathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDnPathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
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
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
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
public static List<clsDnPathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDnPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDnPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
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
public static List<clsDnPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDnPathEN> arrObjLst = new List<clsDnPathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDnPathEN objDnPathEN = new clsDnPathEN();
try
{
objDnPathEN.DnPathId = objRow[conDnPath.DnPathId].ToString().Trim(); //DN路径Id
objDnPathEN.DnPathName = objRow[conDnPath.DnPathName].ToString().Trim(); //DN路径名
objDnPathEN.InDataNodeId = Int32.Parse(objRow[conDnPath.InDataNodeId].ToString().Trim()); //In数据结点Id
objDnPathEN.OutDataNodeId = Int32.Parse(objRow[conDnPath.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDnPathEN.DnPathNodeLst = objRow[conDnPath.DnPathNodeLst].ToString().Trim(); //路径结点列表
objDnPathEN.DnPathNodeLstV2 = objRow[conDnPath.DnPathNodeLstV2] == DBNull.Value ? null : objRow[conDnPath.DnPathNodeLstV2].ToString().Trim(); //路径结点列表V2
objDnPathEN.AssociationMappingId = objRow[conDnPath.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDnPathEN.IsHasErr = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsHasErr].ToString().Trim()); //是否有错
objDnPathEN.EdgeNum = objRow[conDnPath.EdgeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDnPath.EdgeNum].ToString().Trim()); //边数
objDnPathEN.ErrMsg = objRow[conDnPath.ErrMsg] == DBNull.Value ? null : objRow[conDnPath.ErrMsg].ToString().Trim(); //错误信息
objDnPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.InUse].ToString().Trim()); //是否在用
objDnPathEN.IsExistPath = clsEntityBase2.TransNullToBool_S(objRow[conDnPath.IsExistPath].ToString().Trim()); //是否存在路径
objDnPathEN.PrjId = objRow[conDnPath.PrjId].ToString().Trim(); //工程Id
objDnPathEN.UpdDate = objRow[conDnPath.UpdDate] == DBNull.Value ? null : objRow[conDnPath.UpdDate].ToString().Trim(); //修改日期
objDnPathEN.UpdUser = objRow[conDnPath.UpdUser] == DBNull.Value ? null : objRow[conDnPath.UpdUser].ToString().Trim(); //修改者
objDnPathEN.Memo = objRow[conDnPath.Memo] == DBNull.Value ? null : objRow[conDnPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDnPathEN.DnPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDnPathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDnPathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDnPath(ref clsDnPathEN objDnPathEN)
{
bool bolResult = DnPathDA.GetDnPath(ref objDnPathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnPathEN GetObjByDnPathId(string strDnPathId)
{
if (strDnPathId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDnPathId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDnPathId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDnPathId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDnPathEN objDnPathEN = DnPathDA.GetObjByDnPathId(strDnPathId);
return objDnPathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDnPathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDnPathEN objDnPathEN = DnPathDA.GetFirstObj(strWhereCond);
 return objDnPathEN;
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
public static clsDnPathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDnPathEN objDnPathEN = DnPathDA.GetObjByDataRow(objRow);
 return objDnPathEN;
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
public static clsDnPathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDnPathEN objDnPathEN = DnPathDA.GetObjByDataRow(objRow);
 return objDnPathEN;
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
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <param name = "lstDnPathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnPathEN GetObjByDnPathIdFromList(string strDnPathId, List<clsDnPathEN> lstDnPathObjLst)
{
foreach (clsDnPathEN objDnPathEN in lstDnPathObjLst)
{
if (objDnPathEN.DnPathId == strDnPathId)
{
return objDnPathEN;
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
 string strMaxDnPathId;
 try
 {
 strMaxDnPathId = clsDnPathDA.GetMaxStrId();
 return strMaxDnPathId;
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
 string strDnPathId;
 try
 {
 strDnPathId = new clsDnPathDA().GetFirstID(strWhereCond);
 return strDnPathId;
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
 arrList = DnPathDA.GetID(strWhereCond);
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
bool bolIsExist = DnPathDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDnPathId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DnPathDA.IsExist(strDnPathId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDnPathId">DN路径Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDnPathId, string strOpUser)
{
clsDnPathEN objDnPathEN = clsDnPathBL.GetObjByDnPathId(strDnPathId);
objDnPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDnPathEN.UpdUser = strOpUser;
return clsDnPathBL.UpdateBySql2(objDnPathEN);
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
 bolIsExist = clsDnPathDA.IsExistTable();
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
 bolIsExist = DnPathDA.IsExistTable(strTabName);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!DN路径名 = [{0}],路径结点列表 = [{1}]的数据已经存在!(in clsDnPathBL.AddNewRecordBySql2)", objDnPathEN.DnPathName,objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
bool bolResult = DnPathDA.AddNewRecordBySQL2(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDnPathEN objDnPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDnPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!DN路径名 = [{0}],路径结点列表 = [{1}]的数据已经存在!(in clsDnPathBL.AddNewRecordBySql2WithReturnKey)", objDnPathEN.DnPathName,objDnPathEN.DnPathNodeLst);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathBL.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathBL.GetMaxStrId_S();
 }
string strKey = DnPathDA.AddNewRecordBySQL2WithReturnKey(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDnPathEN objDnPathEN)
{
try
{
bool bolResult = DnPathDA.Update(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDnPathEN objDnPathEN)
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DnPathDA.UpdateBySql2(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathBL.ReFreshCache(objDnPathEN.PrjId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
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
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDnPathId)
{
try
{
 clsDnPathEN objDnPathEN = clsDnPathBL.GetObjByDnPathId(strDnPathId);

if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(objDnPathEN.DnPathId, objDnPathEN.UpdUser);
}
if (objDnPathEN != null)
{
int intRecNum = DnPathDA.DelRecord(strDnPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDnPathEN.PrjId);
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
/// <param name="strDnPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strDnPathId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnPathDA.GetSpecSQLObj();
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
//删除与表:[DnPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDnPath.DnPathId,
//strDnPathId);
//        clsDnPathBL.DelDnPathsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnPathBL.DelRecord(strDnPathId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDnPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDnPathId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDnPathId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDnPathBL.relatedActions != null)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(strDnPathId, "UpdRelaTabDate");
}
bool bolResult = DnPathDA.DelRecord(strDnPathId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDnPathIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDnPaths(List<string> arrDnPathIdLst)
{
if (arrDnPathIdLst.Count == 0) return 0;
try
{
if (clsDnPathBL.relatedActions != null)
{
foreach (var strDnPathId in arrDnPathIdLst)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(strDnPathId, "UpdRelaTabDate");
}
}
 clsDnPathEN objDnPathEN = clsDnPathBL.GetObjByDnPathId(arrDnPathIdLst[0]);
int intDelRecNum = DnPathDA.DelDnPath(arrDnPathIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDnPathEN.PrjId);
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
public static int DelDnPathsByCond(string strWhereCond)
{
try
{
if (clsDnPathBL.relatedActions != null)
{
List<string> arrDnPathId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDnPathId in arrDnPathId)
{
clsDnPathBL.relatedActions.UpdRelaTabDate(strDnPathId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conDnPath.PrjId, strWhereCond);
int intRecNum = DnPathDA.DelDnPath(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DnPath]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDnPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDnPathId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDnPathDA.GetSpecSQLObj();
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
//删除与表:[DnPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDnPathBL.DelRecord(strDnPathId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDnPathBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDnPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDnPathENS">源对象</param>
 /// <param name = "objDnPathENT">目标对象</param>
 public static void CopyTo(clsDnPathEN objDnPathENS, clsDnPathEN objDnPathENT)
{
try
{
objDnPathENT.DnPathId = objDnPathENS.DnPathId; //DN路径Id
objDnPathENT.DnPathName = objDnPathENS.DnPathName; //DN路径名
objDnPathENT.InDataNodeId = objDnPathENS.InDataNodeId; //In数据结点Id
objDnPathENT.OutDataNodeId = objDnPathENS.OutDataNodeId; //Out数据结点Id
objDnPathENT.DnPathNodeLst = objDnPathENS.DnPathNodeLst; //路径结点列表
objDnPathENT.DnPathNodeLstV2 = objDnPathENS.DnPathNodeLstV2; //路径结点列表V2
objDnPathENT.AssociationMappingId = objDnPathENS.AssociationMappingId; //关联关系映射Id
objDnPathENT.IsHasErr = objDnPathENS.IsHasErr; //是否有错
objDnPathENT.EdgeNum = objDnPathENS.EdgeNum; //边数
objDnPathENT.ErrMsg = objDnPathENS.ErrMsg; //错误信息
objDnPathENT.InUse = objDnPathENS.InUse; //是否在用
objDnPathENT.IsExistPath = objDnPathENS.IsExistPath; //是否存在路径
objDnPathENT.PrjId = objDnPathENS.PrjId; //工程Id
objDnPathENT.UpdDate = objDnPathENS.UpdDate; //修改日期
objDnPathENT.UpdUser = objDnPathENS.UpdUser; //修改者
objDnPathENT.Memo = objDnPathENS.Memo; //说明
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
 /// <param name = "objDnPathEN">源简化对象</param>
 public static void SetUpdFlag(clsDnPathEN objDnPathEN)
{
try
{
objDnPathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDnPathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDnPath.DnPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.DnPathId = objDnPathEN.DnPathId; //DN路径Id
}
if (arrFldSet.Contains(conDnPath.DnPathName, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.DnPathName = objDnPathEN.DnPathName; //DN路径名
}
if (arrFldSet.Contains(conDnPath.InDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.InDataNodeId = objDnPathEN.InDataNodeId; //In数据结点Id
}
if (arrFldSet.Contains(conDnPath.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.OutDataNodeId = objDnPathEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(conDnPath.DnPathNodeLst, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.DnPathNodeLst = objDnPathEN.DnPathNodeLst; //路径结点列表
}
if (arrFldSet.Contains(conDnPath.DnPathNodeLstV2, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.DnPathNodeLstV2 = objDnPathEN.DnPathNodeLstV2 == "[null]" ? null :  objDnPathEN.DnPathNodeLstV2; //路径结点列表V2
}
if (arrFldSet.Contains(conDnPath.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.AssociationMappingId = objDnPathEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(conDnPath.IsHasErr, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.IsHasErr = objDnPathEN.IsHasErr; //是否有错
}
if (arrFldSet.Contains(conDnPath.EdgeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.EdgeNum = objDnPathEN.EdgeNum; //边数
}
if (arrFldSet.Contains(conDnPath.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.ErrMsg = objDnPathEN.ErrMsg == "[null]" ? null :  objDnPathEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conDnPath.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.InUse = objDnPathEN.InUse; //是否在用
}
if (arrFldSet.Contains(conDnPath.IsExistPath, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.IsExistPath = objDnPathEN.IsExistPath; //是否存在路径
}
if (arrFldSet.Contains(conDnPath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.PrjId = objDnPathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conDnPath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.UpdDate = objDnPathEN.UpdDate == "[null]" ? null :  objDnPathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDnPath.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.UpdUser = objDnPathEN.UpdUser == "[null]" ? null :  objDnPathEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDnPath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDnPathEN.Memo = objDnPathEN.Memo == "[null]" ? null :  objDnPathEN.Memo; //说明
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
 /// <param name = "objDnPathEN">源简化对象</param>
 public static void AccessFldValueNull(clsDnPathEN objDnPathEN)
{
try
{
if (objDnPathEN.DnPathNodeLstV2 == "[null]") objDnPathEN.DnPathNodeLstV2 = null; //路径结点列表V2
if (objDnPathEN.ErrMsg == "[null]") objDnPathEN.ErrMsg = null; //错误信息
if (objDnPathEN.UpdDate == "[null]") objDnPathEN.UpdDate = null; //修改日期
if (objDnPathEN.UpdUser == "[null]") objDnPathEN.UpdUser = null; //修改者
if (objDnPathEN.Memo == "[null]") objDnPathEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDnPathEN objDnPathEN)
{
 DnPathDA.CheckPropertyNew(objDnPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDnPathEN objDnPathEN)
{
 DnPathDA.CheckProperty4Condition(objDnPathEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DnPathIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点路径]...","0");
List<clsDnPathEN> arrDnPathObjLst = GetAllDnPathObjLstCache(strPrjId); 
objDDL.DataValueField = conDnPath.DnPathId;
objDDL.DataTextField = conDnPath.DnPathName;
objDDL.DataSource = arrDnPathObjLst;
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
if (clsDnPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnPathBL没有刷新缓存机制(clsDnPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DnPathId");
//if (arrDnPathObjLstCache == null)
//{
//arrDnPathObjLstCache = DnPathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnPathEN GetObjByDnPathIdCache(string strDnPathId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel =
arrDnPathObjLstCache
.Where(x=> x.DnPathId == strDnPathId 
);
if (arrDnPathObjLst_Sel.Count() == 0)
{
   clsDnPathEN obj = clsDnPathBL.GetObjByDnPathId(strDnPathId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strDnPathId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrDnPathObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDnPathNameByDnPathIdCache(string strDnPathId, string strPrjId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//获取缓存中的对象列表
clsDnPathEN objDnPath = GetObjByDnPathIdCache(strDnPathId, strPrjId);
if (objDnPath == null) return "";
return objDnPath.DnPathName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDnPathIdCache(string strDnPathId, string strPrjId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//获取缓存中的对象列表
clsDnPathEN objDnPath = GetObjByDnPathIdCache(strDnPathId, strPrjId);
if (objDnPath == null) return "";
return objDnPath.DnPathName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnPathEN> GetAllDnPathObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache(strPrjId); 
return arrDnPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnPathEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDnPathObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDnPathEN._RefreshTimeLst.Count == 0) return "";
return clsDnPathEN._RefreshTimeLst[clsDnPathEN._RefreshTimeLst.Count - 1];
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
if (clsDnPathBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDnPathBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DnPath(数据结点路径)
 /// 唯一性条件:DnPathName_DnPathNodeLst
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDnPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDnPathEN objDnPathEN)
{
//检测记录是否存在
string strResult = DnPathDA.GetUniCondStr(objDnPathEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDnPathId, string strPrjId)
{
if (strInFldName != conDnPath.DnPathId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDnPath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDnPath._AttributeName));
throw new Exception(strMsg);
}
var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(strDnPathId, strPrjId);
if (objDnPath == null) return "";
return objDnPath[strOutFldName].ToString();
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
int intRecCount = clsDnPathDA.GetRecCount(strTabName);
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
int intRecCount = clsDnPathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDnPathDA.GetRecCount();
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
int intRecCount = clsDnPathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDnPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDnPathEN objDnPathCond)
{
 string strPrjId = objDnPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDnPathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDnPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDnPath._AttributeName)
{
if (objDnPathCond.IsUpdated(strFldName) == false) continue;
if (objDnPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnPathCond[strFldName].ToString());
}
else
{
if (objDnPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDnPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDnPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDnPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDnPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDnPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDnPathCond[strFldName]));
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
 List<string> arrList = clsDnPathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DnPathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DnPathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DnPathDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnPathDA.SetFldValue(clsDnPathEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DnPathDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnPathDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDnPathDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDnPathDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DnPath] "); 
 strCreateTabCode.Append(" ( "); 
 // /**DN路径Id*/ 
 strCreateTabCode.Append(" DnPathId char(8) primary key, "); 
 // /**DN路径名*/ 
 strCreateTabCode.Append(" DnPathName varchar(100) not Null, "); 
 // /**In数据结点Id*/ 
 strCreateTabCode.Append(" InDataNodeId bigint not Null, "); 
 // /**Out数据结点Id*/ 
 strCreateTabCode.Append(" OutDataNodeId bigint not Null, "); 
 // /**路径结点列表*/ 
 strCreateTabCode.Append(" DnPathNodeLst varchar(500) not Null, "); 
 // /**路径结点列表V2*/ 
 strCreateTabCode.Append(" DnPathNodeLstV2 varchar(500) Null, "); 
 // /**关联关系映射Id*/ 
 strCreateTabCode.Append(" AssociationMappingId char(2) not Null, "); 
 // /**是否有错*/ 
 strCreateTabCode.Append(" IsHasErr bit Null, "); 
 // /**边数*/ 
 strCreateTabCode.Append(" EdgeNum int Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否存在路径*/ 
 strCreateTabCode.Append(" IsExistPath bit Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**In数据结点名*/ 
 strCreateTabCode.Append(" InDataNodeName varchar(100) Null, "); 
 // /**In字段名*/ 
 strCreateTabCode.Append(" InFldName varchar(50) Null, "); 
 // /**In字段Id*/ 
 strCreateTabCode.Append(" InFldId char(8) Null, "); 
 // /**Out数据结点名*/ 
 strCreateTabCode.Append(" OutDataNodeName varchar(100) Null, "); 
 // /**Out字段名*/ 
 strCreateTabCode.Append(" OutFldName varchar(50) Null, "); 
 // /**数据结点名*/ 
 strCreateTabCode.Append(" DataNodeName varchar(100) Null, "); 
 // /**关联关系映射名*/ 
 strCreateTabCode.Append(" AssociationMappingName varchar(50) Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**引用数*/ 
 strCreateTabCode.Append(" RefNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 数据结点路径(DnPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DnPath : clsCommFun4BLV2
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
clsDnPathBL.ReFreshThisCache(strPrjId);
}
}

}