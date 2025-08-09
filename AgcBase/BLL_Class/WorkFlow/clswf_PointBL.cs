
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_PointBL
 表名:wf_Point(00050485)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
public static class  clswf_PointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_PointEN GetObj(this K_PointId_wf_Point myKey)
{
clswf_PointEN objwf_PointEN = clswf_PointBL.wf_PointDA.GetObjByPointId(myKey.Value);
return objwf_PointEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objwf_PointEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],结点名称 = [{1}]的数据已经存在!(in clswf_PointBL.AddNewRecord)", objwf_PointEN.PrjId,objwf_PointEN.PointName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
bool bolResult = clswf_PointBL.wf_PointDA.AddNewRecordBySQL2(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
public static bool AddRecordEx(this clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clswf_PointBL.IsExist(objwf_PointEN.PointId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objwf_PointEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objwf_PointEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],结点名称(PointName)=[{1}])已经存在,不能重复!", objwf_PointEN.PrjId, objwf_PointEN.PointName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objwf_PointEN.AddNewRecord();
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objwf_PointEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],结点名称 = [{1}]的数据已经存在!(in clswf_PointBL.AddNewRecordWithMaxId)", objwf_PointEN.PrjId,objwf_PointEN.PointName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
string strPointId = clswf_PointBL.wf_PointDA.AddNewRecordBySQL2WithReturnKey(objwf_PointEN);
     objwf_PointEN.PointId = strPointId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
}
return strPointId;
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objwf_PointEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],结点名称 = [{1}]的数据已经存在!(in clswf_PointBL.AddNewRecordWithReturnKey)", objwf_PointEN.PrjId,objwf_PointEN.PointName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
string strKey = clswf_PointBL.wf_PointDA.AddNewRecordBySQL2WithReturnKey(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetPointId(this clswf_PointEN objwf_PointEN, string strPointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointId, 8, conwf_Point.PointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointId, 8, conwf_Point.PointId);
}
objwf_PointEN.PointId = strPointId; //结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.PointId) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.PointId, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.PointId] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetPointName(this clswf_PointEN objwf_PointEN, string strPointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointName, conwf_Point.PointName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointName, 100, conwf_Point.PointName);
}
objwf_PointEN.PointName = strPointName; //结点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.PointName) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.PointName, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.PointName] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetPrjId(this clswf_PointEN objwf_PointEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conwf_Point.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conwf_Point.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conwf_Point.PrjId);
}
objwf_PointEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.PrjId) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.PrjId, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.PrjId] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetTabName(this clswf_PointEN objwf_PointEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conwf_Point.TabName);
}
objwf_PointEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.TabName) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.TabName, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.TabName] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetTabKeyId(this clswf_PointEN objwf_PointEN, string strTabKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabKeyId, 50, conwf_Point.TabKeyId);
}
objwf_PointEN.TabKeyId = strTabKeyId; //表关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.TabKeyId) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.TabKeyId, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.TabKeyId] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetInUse(this clswf_PointEN objwf_PointEN, bool bolInUse, string strComparisonOp="")
	{
objwf_PointEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.InUse) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.InUse, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.InUse] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetUpdDate(this clswf_PointEN objwf_PointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_Point.UpdDate);
}
objwf_PointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.UpdDate) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.UpdDate, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.UpdDate] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetUpdUser(this clswf_PointEN objwf_PointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_Point.UpdUser);
}
objwf_PointEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.UpdUser) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.UpdUser, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.UpdUser] = strComparisonOp;
}
}
return objwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_PointEN SetMemo(this clswf_PointEN objwf_PointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_Point.Memo);
}
objwf_PointEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_PointEN.dicFldComparisonOp.ContainsKey(conwf_Point.Memo) == false)
{
objwf_PointEN.dicFldComparisonOp.Add(conwf_Point.Memo, strComparisonOp);
}
else
{
objwf_PointEN.dicFldComparisonOp[conwf_Point.Memo] = strComparisonOp;
}
}
return objwf_PointEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objwf_PointEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clswf_PointEN objwf_PointEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objwf_PointEN.CheckPropertyNew();
clswf_PointEN objwf_PointCond = new clswf_PointEN();
string strCondition = objwf_PointCond
.SetPointId(objwf_PointEN.PointId, "<>")
.SetPrjId(objwf_PointEN.PrjId, "=")
.SetPointName(objwf_PointEN.PointName, "=")
.GetCombineCondition();
objwf_PointEN._IsCheckProperty = true;
bool bolIsExist = clswf_PointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_PointName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objwf_PointEN.Update();
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
 /// <param name = "objwf_Point">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clswf_PointEN objwf_Point)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clswf_PointEN objwf_PointCond = new clswf_PointEN();
string strCondition = objwf_PointCond
.SetPrjId(objwf_Point.PrjId, "=")
.SetPointName(objwf_Point.PointName, "=")
.GetCombineCondition();
objwf_Point._IsCheckProperty = true;
bool bolIsExist = clswf_PointBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objwf_Point.PointId = clswf_PointBL.GetFirstID_S(strCondition);
objwf_Point.UpdateWithCondition(strCondition);
}
else
{
objwf_Point.PointId = clswf_PointBL.GetMaxStrId_S();
objwf_Point.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_PointEN objwf_PointEN)
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_PointBL.wf_PointDA.UpdateBySql2(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_PointEN objwf_PointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_PointBL.wf_PointDA.UpdateBySql2(objwf_PointEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_PointEN objwf_PointEN, string strWhereCond)
{
try
{
bool bolResult = clswf_PointBL.wf_PointDA.UpdateBySqlWithCondition(objwf_PointEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_PointEN objwf_PointEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clswf_PointBL.wf_PointDA.UpdateBySqlWithConditionTransaction(objwf_PointEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "strPointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clswf_PointEN objwf_PointEN)
{
try
{
int intRecNum = clswf_PointBL.wf_PointDA.DelRecord(objwf_PointEN.PointId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointENS">源对象</param>
 /// <param name = "objwf_PointENT">目标对象</param>
 public static void CopyTo(this clswf_PointEN objwf_PointENS, clswf_PointEN objwf_PointENT)
{
try
{
objwf_PointENT.PointId = objwf_PointENS.PointId; //结点Id
objwf_PointENT.PointName = objwf_PointENS.PointName; //结点名称
objwf_PointENT.PrjId = objwf_PointENS.PrjId; //工程Id
objwf_PointENT.TabName = objwf_PointENS.TabName; //表名
objwf_PointENT.TabKeyId = objwf_PointENS.TabKeyId; //表关键字Id
objwf_PointENT.InUse = objwf_PointENS.InUse; //是否在用
objwf_PointENT.UpdDate = objwf_PointENS.UpdDate; //修改日期
objwf_PointENT.UpdUser = objwf_PointENS.UpdUser; //修改者
objwf_PointENT.Memo = objwf_PointENS.Memo; //说明
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
 /// <param name = "objwf_PointENS">源对象</param>
 /// <returns>目标对象=>clswf_PointEN:objwf_PointENT</returns>
 public static clswf_PointEN CopyTo(this clswf_PointEN objwf_PointENS)
{
try
{
 clswf_PointEN objwf_PointENT = new clswf_PointEN()
{
PointId = objwf_PointENS.PointId, //结点Id
PointName = objwf_PointENS.PointName, //结点名称
PrjId = objwf_PointENS.PrjId, //工程Id
TabName = objwf_PointENS.TabName, //表名
TabKeyId = objwf_PointENS.TabKeyId, //表关键字Id
InUse = objwf_PointENS.InUse, //是否在用
UpdDate = objwf_PointENS.UpdDate, //修改日期
UpdUser = objwf_PointENS.UpdUser, //修改者
Memo = objwf_PointENS.Memo, //说明
};
 return objwf_PointENT;
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
public static void CheckPropertyNew(this clswf_PointEN objwf_PointEN)
{
 clswf_PointBL.wf_PointDA.CheckPropertyNew(objwf_PointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clswf_PointEN objwf_PointEN)
{
 clswf_PointBL.wf_PointDA.CheckProperty4Condition(objwf_PointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_PointEN objwf_PointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_PointCond.IsUpdated(conwf_Point.PointId) == true)
{
string strComparisonOpPointId = objwf_PointCond.dicFldComparisonOp[conwf_Point.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.PointId, objwf_PointCond.PointId, strComparisonOpPointId);
}
if (objwf_PointCond.IsUpdated(conwf_Point.PointName) == true)
{
string strComparisonOpPointName = objwf_PointCond.dicFldComparisonOp[conwf_Point.PointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.PointName, objwf_PointCond.PointName, strComparisonOpPointName);
}
if (objwf_PointCond.IsUpdated(conwf_Point.PrjId) == true)
{
string strComparisonOpPrjId = objwf_PointCond.dicFldComparisonOp[conwf_Point.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.PrjId, objwf_PointCond.PrjId, strComparisonOpPrjId);
}
if (objwf_PointCond.IsUpdated(conwf_Point.TabName) == true)
{
string strComparisonOpTabName = objwf_PointCond.dicFldComparisonOp[conwf_Point.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.TabName, objwf_PointCond.TabName, strComparisonOpTabName);
}
if (objwf_PointCond.IsUpdated(conwf_Point.TabKeyId) == true)
{
string strComparisonOpTabKeyId = objwf_PointCond.dicFldComparisonOp[conwf_Point.TabKeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.TabKeyId, objwf_PointCond.TabKeyId, strComparisonOpTabKeyId);
}
if (objwf_PointCond.IsUpdated(conwf_Point.InUse) == true)
{
if (objwf_PointCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conwf_Point.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conwf_Point.InUse);
}
}
if (objwf_PointCond.IsUpdated(conwf_Point.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_PointCond.dicFldComparisonOp[conwf_Point.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.UpdDate, objwf_PointCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_PointCond.IsUpdated(conwf_Point.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_PointCond.dicFldComparisonOp[conwf_Point.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.UpdUser, objwf_PointCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_PointCond.IsUpdated(conwf_Point.Memo) == true)
{
string strComparisonOpMemo = objwf_PointCond.dicFldComparisonOp[conwf_Point.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Point.Memo, objwf_PointCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_Point(工作流结点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_PointName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objwf_PointEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clswf_PointEN objwf_PointEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objwf_PointEN == null) return true;
if (objwf_PointEN.PointId == null || objwf_PointEN.PointId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_PointEN.PrjId);
 sbCondition.AppendFormat(" and PointName = '{0}'", objwf_PointEN.PointName);
if (clswf_PointBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PointId !=  '{0}'", objwf_PointEN.PointId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_PointEN.PrjId);
 sbCondition.AppendFormat(" and PointName = '{0}'", objwf_PointEN.PointName);
if (clswf_PointBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--wf_Point(工作流结点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PointName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_PointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clswf_PointEN objwf_PointEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_PointEN == null) return "";
if (objwf_PointEN.PointId == null || objwf_PointEN.PointId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_PointEN.PrjId);
 sbCondition.AppendFormat(" and PointName = '{0}'", objwf_PointEN.PointName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PointId !=  '{0}'", objwf_PointEN.PointId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_PointEN.PrjId);
 sbCondition.AppendFormat(" and PointName = '{0}'", objwf_PointEN.PointName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_wf_Point
{
public virtual bool UpdRelaTabDate(string strPointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工作流结点(wf_Point)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clswf_PointBL
{
public static RelatedActions_wf_Point relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clswf_PointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clswf_PointDA wf_PointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clswf_PointDA();
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
 public clswf_PointBL()
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
if (string.IsNullOrEmpty(clswf_PointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_PointEN._ConnectString);
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
public static DataTable GetDataTable_wf_Point(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_PointDA.GetDataTable_wf_Point(strWhereCond);
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
objDT = wf_PointDA.GetDataTable(strWhereCond);
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
objDT = wf_PointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = wf_PointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = wf_PointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = wf_PointDA.GetDataTable_Top(objTopPara);
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
objDT = wf_PointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = wf_PointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = wf_PointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clswf_PointEN> GetObjLstByPointIdLst(List<string> arrPointIdLst)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPointIdLst, true);
 string strWhereCond = string.Format("PointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clswf_PointEN> GetObjLstByPointIdLstCache(List<string> arrPointIdLst)
{
string strKey = string.Format("{0}", clswf_PointEN._CurrTabName);
List<clswf_PointEN> arrwf_PointObjLstCache = GetObjLstCache();
IEnumerable <clswf_PointEN> arrwf_PointObjLst_Sel =
arrwf_PointObjLstCache
.Where(x => arrPointIdLst.Contains(x.PointId));
return arrwf_PointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_PointEN> GetObjLst(string strWhereCond)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
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
public static List<clswf_PointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objwf_PointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clswf_PointEN> GetSubObjLstCache(clswf_PointEN objwf_PointCond)
{
List<clswf_PointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_PointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_Point._AttributeName)
{
if (objwf_PointCond.IsUpdated(strFldName) == false) continue;
if (objwf_PointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_PointCond[strFldName].ToString());
}
else
{
if (objwf_PointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_PointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_PointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_PointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_PointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_PointCond[strFldName]));
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
public static List<clswf_PointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
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
public static List<clswf_PointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
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
List<clswf_PointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clswf_PointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_PointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clswf_PointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
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
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
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
public static List<clswf_PointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_PointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clswf_PointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
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
public static List<clswf_PointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_PointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clswf_PointEN> arrObjLst = new List<clswf_PointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_PointEN objwf_PointEN = new clswf_PointEN();
try
{
objwf_PointEN.PointId = objRow[conwf_Point.PointId].ToString().Trim(); //结点Id
objwf_PointEN.PointName = objRow[conwf_Point.PointName].ToString().Trim(); //结点名称
objwf_PointEN.PrjId = objRow[conwf_Point.PrjId].ToString().Trim(); //工程Id
objwf_PointEN.TabName = objRow[conwf_Point.TabName] == DBNull.Value ? null : objRow[conwf_Point.TabName].ToString().Trim(); //表名
objwf_PointEN.TabKeyId = objRow[conwf_Point.TabKeyId] == DBNull.Value ? null : objRow[conwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_Point.InUse].ToString().Trim()); //是否在用
objwf_PointEN.UpdDate = objRow[conwf_Point.UpdDate] == DBNull.Value ? null : objRow[conwf_Point.UpdDate].ToString().Trim(); //修改日期
objwf_PointEN.UpdUser = objRow[conwf_Point.UpdUser] == DBNull.Value ? null : objRow[conwf_Point.UpdUser].ToString().Trim(); //修改者
objwf_PointEN.Memo = objRow[conwf_Point.Memo] == DBNull.Value ? null : objRow[conwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_PointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objwf_PointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getwf_Point(ref clswf_PointEN objwf_PointEN)
{
bool bolResult = wf_PointDA.Getwf_Point(ref objwf_PointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_PointEN GetObjByPointId(string strPointId)
{
if (strPointId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPointId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clswf_PointEN objwf_PointEN = wf_PointDA.GetObjByPointId(strPointId);
return objwf_PointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clswf_PointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clswf_PointEN objwf_PointEN = wf_PointDA.GetFirstObj(strWhereCond);
 return objwf_PointEN;
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
public static clswf_PointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clswf_PointEN objwf_PointEN = wf_PointDA.GetObjByDataRow(objRow);
 return objwf_PointEN;
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
public static clswf_PointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clswf_PointEN objwf_PointEN = wf_PointDA.GetObjByDataRow(objRow);
 return objwf_PointEN;
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
 /// <param name = "strPointId">所给的关键字</param>
 /// <param name = "lstwf_PointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_PointEN GetObjByPointIdFromList(string strPointId, List<clswf_PointEN> lstwf_PointObjLst)
{
foreach (clswf_PointEN objwf_PointEN in lstwf_PointObjLst)
{
if (objwf_PointEN.PointId == strPointId)
{
return objwf_PointEN;
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
 string strMaxPointId;
 try
 {
 strMaxPointId = clswf_PointDA.GetMaxStrId();
 return strMaxPointId;
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
 string strPointId;
 try
 {
 strPointId = new clswf_PointDA().GetFirstID(strWhereCond);
 return strPointId;
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
 arrList = wf_PointDA.GetID(strWhereCond);
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
bool bolIsExist = wf_PointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPointId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = wf_PointDA.IsExist(strPointId);
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
 bolIsExist = clswf_PointDA.IsExistTable();
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
 bolIsExist = wf_PointDA.IsExistTable(strTabName);
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objwf_PointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],结点名称 = [{1}]的数据已经存在!(in clswf_PointBL.AddNewRecordBySql2)", objwf_PointEN.PrjId,objwf_PointEN.PointName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
bool bolResult = wf_PointDA.AddNewRecordBySQL2(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clswf_PointEN objwf_PointEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objwf_PointEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],结点名称 = [{1}]的数据已经存在!(in clswf_PointBL.AddNewRecordBySql2WithReturnKey)", objwf_PointEN.PrjId,objwf_PointEN.PointName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true || clswf_PointBL.IsExist(objwf_PointEN.PointId) == true)
 {
     objwf_PointEN.PointId = clswf_PointBL.GetMaxStrId_S();
 }
string strKey = wf_PointDA.AddNewRecordBySQL2WithReturnKey(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clswf_PointEN objwf_PointEN)
{
try
{
bool bolResult = wf_PointDA.Update(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "objwf_PointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clswf_PointEN objwf_PointEN)
{
 if (string.IsNullOrEmpty(objwf_PointEN.PointId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = wf_PointDA.UpdateBySql2(objwf_PointEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_PointBL.ReFreshCache();

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
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
 /// <param name = "strPointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPointId)
{
try
{
 clswf_PointEN objwf_PointEN = clswf_PointBL.GetObjByPointId(strPointId);

if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(objwf_PointEN.PointId, "SetUpdDate");
}
if (objwf_PointEN != null)
{
int intRecNum = wf_PointDA.DelRecord(strPointId);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strPointId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strPointId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_PointDA.GetSpecSQLObj();
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
//删除与表:[wf_Point]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conwf_Point.PointId,
//strPointId);
//        clswf_PointBL.Delwf_PointsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_PointBL.DelRecord(strPointId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_PointBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPointId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clswf_PointBL.relatedActions != null)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(strPointId, "UpdRelaTabDate");
}
bool bolResult = wf_PointDA.DelRecord(strPointId,objSqlConnection,objSqlTransaction);
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
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrPointIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delwf_Points(List<string> arrPointIdLst)
{
if (arrPointIdLst.Count == 0) return 0;
try
{
if (clswf_PointBL.relatedActions != null)
{
foreach (var strPointId in arrPointIdLst)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(strPointId, "UpdRelaTabDate");
}
}
int intDelRecNum = wf_PointDA.Delwf_Point(arrPointIdLst);
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
public static int Delwf_PointsByCond(string strWhereCond)
{
try
{
if (clswf_PointBL.relatedActions != null)
{
List<string> arrPointId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPointId in arrPointId)
{
clswf_PointBL.relatedActions.UpdRelaTabDate(strPointId, "UpdRelaTabDate");
}
}
int intRecNum = wf_PointDA.Delwf_Point(strWhereCond);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[wf_Point]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPointId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPointId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_PointDA.GetSpecSQLObj();
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
//删除与表:[wf_Point]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_PointBL.DelRecord(strPointId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_PointBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPointId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objwf_PointENS">源对象</param>
 /// <param name = "objwf_PointENT">目标对象</param>
 public static void CopyTo(clswf_PointEN objwf_PointENS, clswf_PointEN objwf_PointENT)
{
try
{
objwf_PointENT.PointId = objwf_PointENS.PointId; //结点Id
objwf_PointENT.PointName = objwf_PointENS.PointName; //结点名称
objwf_PointENT.PrjId = objwf_PointENS.PrjId; //工程Id
objwf_PointENT.TabName = objwf_PointENS.TabName; //表名
objwf_PointENT.TabKeyId = objwf_PointENS.TabKeyId; //表关键字Id
objwf_PointENT.InUse = objwf_PointENS.InUse; //是否在用
objwf_PointENT.UpdDate = objwf_PointENS.UpdDate; //修改日期
objwf_PointENT.UpdUser = objwf_PointENS.UpdUser; //修改者
objwf_PointENT.Memo = objwf_PointENS.Memo; //说明
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
 /// <param name = "objwf_PointEN">源简化对象</param>
 public static void SetUpdFlag(clswf_PointEN objwf_PointEN)
{
try
{
objwf_PointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objwf_PointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conwf_Point.PointId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.PointId = objwf_PointEN.PointId; //结点Id
}
if (arrFldSet.Contains(conwf_Point.PointName, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.PointName = objwf_PointEN.PointName; //结点名称
}
if (arrFldSet.Contains(conwf_Point.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.PrjId = objwf_PointEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conwf_Point.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.TabName = objwf_PointEN.TabName == "[null]" ? null :  objwf_PointEN.TabName; //表名
}
if (arrFldSet.Contains(conwf_Point.TabKeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.TabKeyId = objwf_PointEN.TabKeyId == "[null]" ? null :  objwf_PointEN.TabKeyId; //表关键字Id
}
if (arrFldSet.Contains(conwf_Point.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.InUse = objwf_PointEN.InUse; //是否在用
}
if (arrFldSet.Contains(conwf_Point.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.UpdDate = objwf_PointEN.UpdDate == "[null]" ? null :  objwf_PointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conwf_Point.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.UpdUser = objwf_PointEN.UpdUser == "[null]" ? null :  objwf_PointEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conwf_Point.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_PointEN.Memo = objwf_PointEN.Memo == "[null]" ? null :  objwf_PointEN.Memo; //说明
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
 /// <param name = "objwf_PointEN">源简化对象</param>
 public static void AccessFldValueNull(clswf_PointEN objwf_PointEN)
{
try
{
if (objwf_PointEN.TabName == "[null]") objwf_PointEN.TabName = null; //表名
if (objwf_PointEN.TabKeyId == "[null]") objwf_PointEN.TabKeyId = null; //表关键字Id
if (objwf_PointEN.UpdDate == "[null]") objwf_PointEN.UpdDate = null; //修改日期
if (objwf_PointEN.UpdUser == "[null]") objwf_PointEN.UpdUser = null; //修改者
if (objwf_PointEN.Memo == "[null]") objwf_PointEN.Memo = null; //说明
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
public static void CheckPropertyNew(clswf_PointEN objwf_PointEN)
{
 wf_PointDA.CheckPropertyNew(objwf_PointEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clswf_PointEN objwf_PointEN)
{
 wf_PointDA.CheckProperty4Condition(objwf_PointEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PointId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conwf_Point.PointId); 
List<clswf_PointEN> arrObjLst = clswf_PointBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clswf_PointEN objwf_PointEN = new clswf_PointEN()
{
PointId = "0",
PointName = "选[工作流结点]..."
};
arrObjLst.Insert(0, objwf_PointEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conwf_Point.PointId;
objComboBox.DisplayMember = conwf_Point.PointName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PointId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流结点]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conwf_Point.PointId); 
IEnumerable<clswf_PointEN> arrObjLst = clswf_PointBL.GetObjLst(strCondition);
objDDL.DataValueField = conwf_Point.PointId;
objDDL.DataTextField = conwf_Point.PointName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PointIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流结点]...","0");
List<clswf_PointEN> arrwf_PointObjLst = GetAllwf_PointObjLstCache(); 
objDDL.DataValueField = conwf_Point.PointId;
objDDL.DataTextField = conwf_Point.PointName;
objDDL.DataSource = arrwf_PointObjLst;
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
if (clswf_PointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_PointBL没有刷新缓存机制(clswf_PointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PointId");
//if (arrwf_PointObjLstCache == null)
//{
//arrwf_PointObjLstCache = wf_PointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_PointEN GetObjByPointIdCache(string strPointId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clswf_PointEN._CurrTabName);
List<clswf_PointEN> arrwf_PointObjLstCache = GetObjLstCache();
IEnumerable <clswf_PointEN> arrwf_PointObjLst_Sel =
arrwf_PointObjLstCache
.Where(x=> x.PointId == strPointId 
);
if (arrwf_PointObjLst_Sel.Count() == 0)
{
   clswf_PointEN obj = clswf_PointBL.GetObjByPointId(strPointId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrwf_PointObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPointNameByPointIdCache(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true) return "";
//获取缓存中的对象列表
clswf_PointEN objwf_Point = GetObjByPointIdCache(strPointId);
if (objwf_Point == null) return "";
return objwf_Point.PointName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPointIdCache(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true) return "";
//获取缓存中的对象列表
clswf_PointEN objwf_Point = GetObjByPointIdCache(strPointId);
if (objwf_Point == null) return "";
return objwf_Point.PointName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_PointEN> GetAllwf_PointObjLstCache()
{
//获取缓存中的对象列表
List<clswf_PointEN> arrwf_PointObjLstCache = GetObjLstCache(); 
return arrwf_PointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_PointEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clswf_PointEN._CurrTabName);
List<clswf_PointEN> arrwf_PointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrwf_PointObjLstCache;
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
string strKey = string.Format("{0}", clswf_PointEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_PointEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clswf_PointEN._RefreshTimeLst.Count == 0) return "";
return clswf_PointEN._RefreshTimeLst[clswf_PointEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clswf_PointBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_PointEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_PointEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clswf_PointBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--wf_Point(工作流结点)
 /// 唯一性条件:PrjId_PointName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_PointEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clswf_PointEN objwf_PointEN)
{
//检测记录是否存在
string strResult = wf_PointDA.GetUniCondStr(objwf_PointEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPointId)
{
if (strInFldName != conwf_Point.PointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conwf_Point._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conwf_Point._AttributeName));
throw new Exception(strMsg);
}
var objwf_Point = clswf_PointBL.GetObjByPointIdCache(strPointId);
if (objwf_Point == null) return "";
return objwf_Point[strOutFldName].ToString();
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
int intRecCount = clswf_PointDA.GetRecCount(strTabName);
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
int intRecCount = clswf_PointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clswf_PointDA.GetRecCount();
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
int intRecCount = clswf_PointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objwf_PointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clswf_PointEN objwf_PointCond)
{
List<clswf_PointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_PointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_Point._AttributeName)
{
if (objwf_PointCond.IsUpdated(strFldName) == false) continue;
if (objwf_PointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_PointCond[strFldName].ToString());
}
else
{
if (objwf_PointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_PointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_PointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_PointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_PointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_PointCond[strFldName]));
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
 List<string> arrList = clswf_PointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = wf_PointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = wf_PointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = wf_PointDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_PointDA.SetFldValue(clswf_PointEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = wf_PointDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_PointDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_PointDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_PointDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[wf_Point] "); 
 strCreateTabCode.Append(" ( "); 
 // /**结点Id*/ 
 strCreateTabCode.Append(" PointId char(8) primary key, "); 
 // /**结点名称*/ 
 strCreateTabCode.Append(" PointName varchar(100) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**表关键字Id*/ 
 strCreateTabCode.Append(" TabKeyId varchar(50) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工作流结点(wf_Point)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4wf_Point : clsCommFun4BL
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
clswf_PointBL.ReFreshThisCache();
}
}

}