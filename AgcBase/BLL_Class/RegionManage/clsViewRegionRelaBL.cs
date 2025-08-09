
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRegionRelaBL
 表名:ViewRegionRela(00050573)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:10
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
public static class  clsViewRegionRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionRelaEN GetObj(this K_mId_ViewRegionRela myKey)
{
clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBL.ViewRegionRelaDA.GetObjBymId(myKey.Value);
return objViewRegionRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRegionRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],区域Id = [{1}]的数据已经存在!(in clsViewRegionRelaBL.AddNewRecord)", objViewRegionRelaEN.ViewId,objViewRegionRelaEN.RegionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewRegionRelaBL.ViewRegionRelaDA.AddNewRecordBySQL2(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objViewRegionRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewRegionRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面Id(ViewId)=[{0}],区域Id(RegionId)=[{1}])已经存在,不能重复!", objViewRegionRelaEN.ViewId, objViewRegionRelaEN.RegionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewRegionRelaEN.AddNewRecord();
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRegionRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],区域Id = [{1}]的数据已经存在!(in clsViewRegionRelaBL.AddNewRecordWithReturnKey)", objViewRegionRelaEN.ViewId,objViewRegionRelaEN.RegionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewRegionRelaBL.ViewRegionRelaDA.AddNewRecordBySQL2WithReturnKey(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetmId(this clsViewRegionRelaEN objViewRegionRelaEN, long lngmId, string strComparisonOp="")
	{
objViewRegionRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.mId) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.mId, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.mId] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetRegionId(this clsViewRegionRelaEN objViewRegionRelaEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conViewRegionRela.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conViewRegionRela.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conViewRegionRela.RegionId);
}
objViewRegionRelaEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.RegionId) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.RegionId, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.RegionId] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetViewId(this clsViewRegionRelaEN objViewRegionRelaEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, conViewRegionRela.ViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewRegionRela.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewRegionRela.ViewId);
}
objViewRegionRelaEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.ViewId) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.ViewId, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.ViewId] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetInUse(this clsViewRegionRelaEN objViewRegionRelaEN, bool bolInUse, string strComparisonOp="")
	{
objViewRegionRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.InUse) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.InUse, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.InUse] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetIsDisp(this clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsDisp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDisp, conViewRegionRela.IsDisp);
objViewRegionRelaEN.IsDisp = bolIsDisp; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.IsDisp) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.IsDisp, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.IsDisp] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetPrjId(this clsViewRegionRelaEN objViewRegionRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewRegionRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewRegionRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewRegionRela.PrjId);
}
objViewRegionRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.PrjId) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.PrjId, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.PrjId] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetUpdUser(this clsViewRegionRelaEN objViewRegionRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewRegionRela.UpdUser);
}
objViewRegionRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.UpdUser) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.UpdUser, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.UpdUser] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetUpdDate(this clsViewRegionRelaEN objViewRegionRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewRegionRela.UpdDate);
}
objViewRegionRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.UpdDate) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.UpdDate, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.UpdDate] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRegionRelaEN SetMemo(this clsViewRegionRelaEN objViewRegionRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewRegionRela.Memo);
}
objViewRegionRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRegionRelaEN.dicFldComparisonOp.ContainsKey(conViewRegionRela.Memo) == false)
{
objViewRegionRelaEN.dicFldComparisonOp.Add(conViewRegionRela.Memo, strComparisonOp);
}
else
{
objViewRegionRelaEN.dicFldComparisonOp[conViewRegionRela.Memo] = strComparisonOp;
}
}
return objViewRegionRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewRegionRelaEN objViewRegionRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewRegionRelaEN.CheckPropertyNew();
clsViewRegionRelaEN objViewRegionRelaCond = new clsViewRegionRelaEN();
string strCondition = objViewRegionRelaCond
.SetmId(objViewRegionRelaEN.mId, "<>")
.SetViewId(objViewRegionRelaEN.ViewId, "=")
.SetRegionId(objViewRegionRelaEN.RegionId, "=")
.GetCombineCondition();
objViewRegionRelaEN._IsCheckProperty = true;
bool bolIsExist = clsViewRegionRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewId_RegionId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewRegionRelaEN.Update();
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
 /// <param name = "objViewRegionRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewRegionRelaEN objViewRegionRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewRegionRelaEN objViewRegionRelaCond = new clsViewRegionRelaEN();
string strCondition = objViewRegionRelaCond
.SetViewId(objViewRegionRela.ViewId, "=")
.SetRegionId(objViewRegionRela.RegionId, "=")
.GetCombineCondition();
objViewRegionRela._IsCheckProperty = true;
bool bolIsExist = clsViewRegionRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewRegionRela.mId = clsViewRegionRelaBL.GetFirstID_S(strCondition);
objViewRegionRela.UpdateWithCondition(strCondition);
}
else
{
objViewRegionRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionRelaEN objViewRegionRelaEN)
{
 if (objViewRegionRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionRelaBL.ViewRegionRelaDA.UpdateBySql2(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRegionRelaEN objViewRegionRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewRegionRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRegionRelaBL.ViewRegionRelaDA.UpdateBySql2(objViewRegionRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionRelaEN objViewRegionRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsViewRegionRelaBL.ViewRegionRelaDA.UpdateBySqlWithCondition(objViewRegionRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRegionRelaEN objViewRegionRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewRegionRelaBL.ViewRegionRelaDA.UpdateBySqlWithConditionTransaction(objViewRegionRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
public static int Delete(this clsViewRegionRelaEN objViewRegionRelaEN)
{
try
{
int intRecNum = clsViewRegionRelaBL.ViewRegionRelaDA.DelRecord(objViewRegionRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaENS">源对象</param>
 /// <param name = "objViewRegionRelaENT">目标对象</param>
 public static void CopyTo(this clsViewRegionRelaEN objViewRegionRelaENS, clsViewRegionRelaEN objViewRegionRelaENT)
{
try
{
objViewRegionRelaENT.mId = objViewRegionRelaENS.mId; //mId
objViewRegionRelaENT.RegionId = objViewRegionRelaENS.RegionId; //区域Id
objViewRegionRelaENT.ViewId = objViewRegionRelaENS.ViewId; //界面Id
objViewRegionRelaENT.InUse = objViewRegionRelaENS.InUse; //是否在用
objViewRegionRelaENT.IsDisp = objViewRegionRelaENS.IsDisp; //是否显示
objViewRegionRelaENT.PrjId = objViewRegionRelaENS.PrjId; //工程Id
objViewRegionRelaENT.UpdUser = objViewRegionRelaENS.UpdUser; //修改者
objViewRegionRelaENT.UpdDate = objViewRegionRelaENS.UpdDate; //修改日期
objViewRegionRelaENT.Memo = objViewRegionRelaENS.Memo; //说明
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
 /// <param name = "objViewRegionRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewRegionRelaEN:objViewRegionRelaENT</returns>
 public static clsViewRegionRelaEN CopyTo(this clsViewRegionRelaEN objViewRegionRelaENS)
{
try
{
 clsViewRegionRelaEN objViewRegionRelaENT = new clsViewRegionRelaEN()
{
mId = objViewRegionRelaENS.mId, //mId
RegionId = objViewRegionRelaENS.RegionId, //区域Id
ViewId = objViewRegionRelaENS.ViewId, //界面Id
InUse = objViewRegionRelaENS.InUse, //是否在用
IsDisp = objViewRegionRelaENS.IsDisp, //是否显示
PrjId = objViewRegionRelaENS.PrjId, //工程Id
UpdUser = objViewRegionRelaENS.UpdUser, //修改者
UpdDate = objViewRegionRelaENS.UpdDate, //修改日期
Memo = objViewRegionRelaENS.Memo, //说明
};
 return objViewRegionRelaENT;
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
public static void CheckPropertyNew(this clsViewRegionRelaEN objViewRegionRelaEN)
{
 clsViewRegionRelaBL.ViewRegionRelaDA.CheckPropertyNew(objViewRegionRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewRegionRelaEN objViewRegionRelaEN)
{
 clsViewRegionRelaBL.ViewRegionRelaDA.CheckProperty4Condition(objViewRegionRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewRegionRelaEN objViewRegionRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.mId) == true)
{
string strComparisonOpmId = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRegionRela.mId, objViewRegionRelaCond.mId, strComparisonOpmId);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.RegionId) == true)
{
string strComparisonOpRegionId = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.RegionId, objViewRegionRelaCond.RegionId, strComparisonOpRegionId);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.ViewId) == true)
{
string strComparisonOpViewId = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.ViewId, objViewRegionRelaCond.ViewId, strComparisonOpViewId);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.InUse) == true)
{
if (objViewRegionRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewRegionRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewRegionRela.InUse);
}
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.IsDisp) == true)
{
if (objViewRegionRelaCond.IsDisp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewRegionRela.IsDisp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewRegionRela.IsDisp);
}
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.PrjId) == true)
{
string strComparisonOpPrjId = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.PrjId, objViewRegionRelaCond.PrjId, strComparisonOpPrjId);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.UpdUser, objViewRegionRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.UpdDate, objViewRegionRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewRegionRelaCond.IsUpdated(conViewRegionRela.Memo) == true)
{
string strComparisonOpMemo = objViewRegionRelaCond.dicFldComparisonOp[conViewRegionRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRegionRela.Memo, objViewRegionRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewRegionRela(界面区域关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewId_RegionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewRegionRelaEN objViewRegionRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewRegionRelaEN == null) return true;
if (objViewRegionRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRegionRelaEN.ViewId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objViewRegionRelaEN.RegionId);
if (clsViewRegionRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewRegionRelaEN.mId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRegionRelaEN.ViewId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objViewRegionRelaEN.RegionId);
if (clsViewRegionRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewRegionRela(界面区域关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewId_RegionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewRegionRelaEN objViewRegionRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewRegionRelaEN == null) return "";
if (objViewRegionRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRegionRelaEN.ViewId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objViewRegionRelaEN.RegionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewRegionRelaEN.mId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRegionRelaEN.ViewId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objViewRegionRelaEN.RegionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewRegionRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面区域关系(ViewRegionRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewRegionRelaBL
{
public static RelatedActions_ViewRegionRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewRegionRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewRegionRelaDA ViewRegionRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewRegionRelaDA();
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
 public clsViewRegionRelaBL()
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
if (string.IsNullOrEmpty(clsViewRegionRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRegionRelaEN._ConnectString);
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
public static DataTable GetDataTable_ViewRegionRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewRegionRelaDA.GetDataTable_ViewRegionRela(strWhereCond);
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
objDT = ViewRegionRelaDA.GetDataTable(strWhereCond);
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
objDT = ViewRegionRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewRegionRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewRegionRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewRegionRelaDA.GetDataTable_Top(objTopPara);
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
objDT = ViewRegionRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewRegionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewRegionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsViewRegionRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
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
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewRegionRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewRegionRelaEN._CurrTabName, strPrjId);
List<clsViewRegionRelaEN> arrViewRegionRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionRelaEN> arrViewRegionRelaObjLst_Sel =
arrViewRegionRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrViewRegionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionRelaEN> GetObjLst(string strWhereCond)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
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
public static List<clsViewRegionRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewRegionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewRegionRelaEN> GetSubObjLstCache(clsViewRegionRelaEN objViewRegionRelaCond)
{
 string strPrjId = objViewRegionRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewRegionRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewRegionRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegionRela._AttributeName)
{
if (objViewRegionRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionRelaCond[strFldName].ToString());
}
else
{
if (objViewRegionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionRelaCond[strFldName]));
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
public static List<clsViewRegionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
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
public static List<clsViewRegionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
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
List<clsViewRegionRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewRegionRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewRegionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
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
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
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
public static List<clsViewRegionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewRegionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewRegionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
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
public static List<clsViewRegionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRegionRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewRegionRelaEN> arrObjLst = new List<clsViewRegionRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();
try
{
objViewRegionRelaEN.mId = Int32.Parse(objRow[conViewRegionRela.mId].ToString().Trim()); //mId
objViewRegionRelaEN.RegionId = objRow[conViewRegionRela.RegionId].ToString().Trim(); //区域Id
objViewRegionRelaEN.ViewId = objRow[conViewRegionRela.ViewId].ToString().Trim(); //界面Id
objViewRegionRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.InUse].ToString().Trim()); //是否在用
objViewRegionRelaEN.IsDisp = clsEntityBase2.TransNullToBool_S(objRow[conViewRegionRela.IsDisp].ToString().Trim()); //是否显示
objViewRegionRelaEN.PrjId = objRow[conViewRegionRela.PrjId].ToString().Trim(); //工程Id
objViewRegionRelaEN.UpdUser = objRow[conViewRegionRela.UpdUser] == DBNull.Value ? null : objRow[conViewRegionRela.UpdUser].ToString().Trim(); //修改者
objViewRegionRelaEN.UpdDate = objRow[conViewRegionRela.UpdDate] == DBNull.Value ? null : objRow[conViewRegionRela.UpdDate].ToString().Trim(); //修改日期
objViewRegionRelaEN.Memo = objRow[conViewRegionRela.Memo] == DBNull.Value ? null : objRow[conViewRegionRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRegionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRegionRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewRegionRela(ref clsViewRegionRelaEN objViewRegionRelaEN)
{
bool bolResult = ViewRegionRelaDA.GetViewRegionRela(ref objViewRegionRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRegionRelaEN GetObjBymId(long lngmId)
{
clsViewRegionRelaEN objViewRegionRelaEN = ViewRegionRelaDA.GetObjBymId(lngmId);
return objViewRegionRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewRegionRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewRegionRelaEN objViewRegionRelaEN = ViewRegionRelaDA.GetFirstObj(strWhereCond);
 return objViewRegionRelaEN;
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
public static clsViewRegionRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewRegionRelaEN objViewRegionRelaEN = ViewRegionRelaDA.GetObjByDataRow(objRow);
 return objViewRegionRelaEN;
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
public static clsViewRegionRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewRegionRelaEN objViewRegionRelaEN = ViewRegionRelaDA.GetObjByDataRow(objRow);
 return objViewRegionRelaEN;
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
 /// <param name = "lstViewRegionRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionRelaEN GetObjBymIdFromList(long lngmId, List<clsViewRegionRelaEN> lstViewRegionRelaObjLst)
{
foreach (clsViewRegionRelaEN objViewRegionRelaEN in lstViewRegionRelaObjLst)
{
if (objViewRegionRelaEN.mId == lngmId)
{
return objViewRegionRelaEN;
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
 lngmId = new clsViewRegionRelaDA().GetFirstID(strWhereCond);
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
 arrList = ViewRegionRelaDA.GetID(strWhereCond);
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
bool bolIsExist = ViewRegionRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ViewRegionRelaDA.IsExist(lngmId);
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
clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBL.GetObjBymId(lngmId);
objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewRegionRelaEN.UpdUser = strOpUser;
return clsViewRegionRelaBL.UpdateBySql2(objViewRegionRelaEN);
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
 bolIsExist = clsViewRegionRelaDA.IsExistTable();
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
 bolIsExist = ViewRegionRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRegionRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],区域Id = [{1}]的数据已经存在!(in clsViewRegionRelaBL.AddNewRecordBySql2)", objViewRegionRelaEN.ViewId,objViewRegionRelaEN.RegionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewRegionRelaDA.AddNewRecordBySQL2(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewRegionRelaEN objViewRegionRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRegionRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],区域Id = [{1}]的数据已经存在!(in clsViewRegionRelaBL.AddNewRecordBySql2WithReturnKey)", objViewRegionRelaEN.ViewId,objViewRegionRelaEN.RegionId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewRegionRelaDA.AddNewRecordBySQL2WithReturnKey(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewRegionRelaEN objViewRegionRelaEN)
{
try
{
bool bolResult = ViewRegionRelaDA.Update(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 /// <param name = "objViewRegionRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewRegionRelaEN objViewRegionRelaEN)
{
 if (objViewRegionRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewRegionRelaDA.UpdateBySql2(objViewRegionRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRegionRelaBL.ReFreshCache(objViewRegionRelaEN.PrjId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
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
 clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBL.GetObjBymId(lngmId);

if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(objViewRegionRelaEN.mId, objViewRegionRelaEN.UpdUser);
}
if (objViewRegionRelaEN != null)
{
int intRecNum = ViewRegionRelaDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRegionRelaEN.PrjId);
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
objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewRegionRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewRegionRela.mId,
//lngmId);
//        clsViewRegionRelaBL.DelViewRegionRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionRelaBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsViewRegionRelaBL.relatedActions != null)
{
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewRegionRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelViewRegionRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsViewRegionRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ViewRegionRelaDA.DelViewRegionRela(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRegionRelaEN.PrjId);
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
public static int DelViewRegionRelasByCond(string strWhereCond)
{
try
{
if (clsViewRegionRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewRegionRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewRegionRela.PrjId, strWhereCond);
int intRecNum = ViewRegionRelaDA.DelViewRegionRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewRegionRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRegionRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewRegionRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRegionRelaBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRegionRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objViewRegionRelaENS">源对象</param>
 /// <param name = "objViewRegionRelaENT">目标对象</param>
 public static void CopyTo(clsViewRegionRelaEN objViewRegionRelaENS, clsViewRegionRelaEN objViewRegionRelaENT)
{
try
{
objViewRegionRelaENT.mId = objViewRegionRelaENS.mId; //mId
objViewRegionRelaENT.RegionId = objViewRegionRelaENS.RegionId; //区域Id
objViewRegionRelaENT.ViewId = objViewRegionRelaENS.ViewId; //界面Id
objViewRegionRelaENT.InUse = objViewRegionRelaENS.InUse; //是否在用
objViewRegionRelaENT.IsDisp = objViewRegionRelaENS.IsDisp; //是否显示
objViewRegionRelaENT.PrjId = objViewRegionRelaENS.PrjId; //工程Id
objViewRegionRelaENT.UpdUser = objViewRegionRelaENS.UpdUser; //修改者
objViewRegionRelaENT.UpdDate = objViewRegionRelaENS.UpdDate; //修改日期
objViewRegionRelaENT.Memo = objViewRegionRelaENS.Memo; //说明
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
 /// <param name = "objViewRegionRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsViewRegionRelaEN objViewRegionRelaEN)
{
try
{
objViewRegionRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewRegionRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewRegionRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.mId = objViewRegionRelaEN.mId; //mId
}
if (arrFldSet.Contains(conViewRegionRela.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.RegionId = objViewRegionRelaEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conViewRegionRela.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.ViewId = objViewRegionRelaEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewRegionRela.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.InUse = objViewRegionRelaEN.InUse; //是否在用
}
if (arrFldSet.Contains(conViewRegionRela.IsDisp, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.IsDisp = objViewRegionRelaEN.IsDisp; //是否显示
}
if (arrFldSet.Contains(conViewRegionRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.PrjId = objViewRegionRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewRegionRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.UpdUser = objViewRegionRelaEN.UpdUser == "[null]" ? null :  objViewRegionRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewRegionRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.UpdDate = objViewRegionRelaEN.UpdDate == "[null]" ? null :  objViewRegionRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewRegionRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRegionRelaEN.Memo = objViewRegionRelaEN.Memo == "[null]" ? null :  objViewRegionRelaEN.Memo; //说明
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
 /// <param name = "objViewRegionRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewRegionRelaEN objViewRegionRelaEN)
{
try
{
if (objViewRegionRelaEN.UpdUser == "[null]") objViewRegionRelaEN.UpdUser = null; //修改者
if (objViewRegionRelaEN.UpdDate == "[null]") objViewRegionRelaEN.UpdDate = null; //修改日期
if (objViewRegionRelaEN.Memo == "[null]") objViewRegionRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewRegionRelaEN objViewRegionRelaEN)
{
 ViewRegionRelaDA.CheckPropertyNew(objViewRegionRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewRegionRelaEN objViewRegionRelaEN)
{
 ViewRegionRelaDA.CheckProperty4Condition(objViewRegionRelaEN);
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
if (clsViewRegionRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRegionRelaBL没有刷新缓存机制(clsViewRegionRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrViewRegionRelaObjLstCache == null)
//{
//arrViewRegionRelaObjLstCache = ViewRegionRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRegionRelaEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewRegionRelaEN._CurrTabName, strPrjId);
List<clsViewRegionRelaEN> arrViewRegionRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionRelaEN> arrViewRegionRelaObjLst_Sel =
arrViewRegionRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrViewRegionRelaObjLst_Sel.Count() == 0)
{
   clsViewRegionRelaEN obj = clsViewRegionRelaBL.GetObjBymId(lngmId);
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
return arrViewRegionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionRelaEN> GetAllViewRegionRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewRegionRelaEN> arrViewRegionRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrViewRegionRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRegionRelaEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsViewRegionRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewRegionRelaEN> arrViewRegionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewRegionRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsViewRegionRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRegionRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewRegionRelaEN._RefreshTimeLst.Count == 0) return "";
return clsViewRegionRelaEN._RefreshTimeLst[clsViewRegionRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewRegionRelaBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewRegionRelaBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsViewRegionRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewRegionRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRegionRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewRegionRelaBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewRegionRela(界面区域关系)
 /// 唯一性条件:ViewId_RegionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRegionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewRegionRelaEN objViewRegionRelaEN)
{
//检测记录是否存在
string strResult = ViewRegionRelaDA.GetUniCondStr(objViewRegionRelaEN);
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
if (strInFldName != conViewRegionRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewRegionRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewRegionRela._AttributeName));
throw new Exception(strMsg);
}
var objViewRegionRela = clsViewRegionRelaBL.GetObjBymIdCache(lngmId, strPrjId);
if (objViewRegionRela == null) return "";
return objViewRegionRela[strOutFldName].ToString();
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
int intRecCount = clsViewRegionRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsViewRegionRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewRegionRelaDA.GetRecCount();
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
int intRecCount = clsViewRegionRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewRegionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewRegionRelaEN objViewRegionRelaCond)
{
 string strPrjId = objViewRegionRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewRegionRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewRegionRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRegionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRegionRela._AttributeName)
{
if (objViewRegionRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewRegionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionRelaCond[strFldName].ToString());
}
else
{
if (objViewRegionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRegionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRegionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRegionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRegionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRegionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRegionRelaCond[strFldName]));
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
 List<string> arrList = clsViewRegionRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewRegionRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewRegionRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionRelaDA.SetFldValue(clsViewRegionRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewRegionRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRegionRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRegionRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewRegionRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisp bit not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**区域类型序号*/ 
 strCreateTabCode.Append(" RegionTypeOrderNum int Null, "); 
 // /**区域名称*/ 
 strCreateTabCode.Append(" RegionName varchar(50) Null, "); 
 // /**区域类型简名*/ 
 strCreateTabCode.Append(" RegionTypeSimName varchar(10) Null, "); 
 // /**容器类型名*/ 
 strCreateTabCode.Append(" ContainerTypeName varchar(50) Null, "); 
 // /**页面显示模式名称*/ 
 strCreateTabCode.Append(" PageDispModeName varchar(50) Null, "); 
 // /**字段数*/ 
 strCreateTabCode.Append(" FldNum int Null, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" RegionTabName varchar(100) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) not Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面区域关系(ViewRegionRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewRegionRela : clsCommFun4BLV2
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
clsViewRegionRelaBL.ReFreshThisCache(strPrjId);
}
}

}