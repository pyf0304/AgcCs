
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVueCtrlDesignSysBL
 表名:VueCtrlDesignSys(00050633)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsVueCtrlDesignSysBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strVueDesignSysId">表关键字</param>
 /// <returns>表对象</returns>
public static clsVueCtrlDesignSysEN GetObj(this K_VueDesignSysId_VueCtrlDesignSys myKey)
{
clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.GetObjByVueDesignSysId(myKey.Value);
return objVueCtrlDesignSysEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objVueCtrlDesignSysEN) == false)
{
var strMsg = string.Format("记录已经存在!Vue控件设计体系名称 = [{0}]的数据已经存在!(in clsVueCtrlDesignSysBL.AddNewRecord)", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
bool bolResult = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.AddNewRecordBySQL2(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
public static bool AddRecordEx(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objVueCtrlDesignSysEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objVueCtrlDesignSysEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Vue控件设计体系名称(VueDesignSysName)=[{0}])已经存在,不能重复!", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objVueCtrlDesignSysEN.AddNewRecord();
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objVueCtrlDesignSysEN) == false)
{
var strMsg = string.Format("记录已经存在!Vue控件设计体系名称 = [{0}]的数据已经存在!(in clsVueCtrlDesignSysBL.AddNewRecordWithMaxId)", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
string strVueDesignSysId = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.AddNewRecordBySQL2WithReturnKey(objVueCtrlDesignSysEN);
     objVueCtrlDesignSysEN.VueDesignSysId = strVueDesignSysId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
}
return strVueDesignSysId;
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objVueCtrlDesignSysEN) == false)
{
var strMsg = string.Format("记录已经存在!Vue控件设计体系名称 = [{0}]的数据已经存在!(in clsVueCtrlDesignSysBL.AddNewRecordWithReturnKey)", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
string strKey = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.AddNewRecordBySQL2WithReturnKey(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetVueDesignSysId(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strVueDesignSysId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVueDesignSysId, 2, conVueCtrlDesignSys.VueDesignSysId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVueDesignSysId, 2, conVueCtrlDesignSys.VueDesignSysId);
}
objVueCtrlDesignSysEN.VueDesignSysId = strVueDesignSysId; //Vue控件设计体系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.VueDesignSysId) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.VueDesignSysId, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysId] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetVueDesignSysName(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strVueDesignSysName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVueDesignSysName, conVueCtrlDesignSys.VueDesignSysName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVueDesignSysName, 50, conVueCtrlDesignSys.VueDesignSysName);
}
objVueCtrlDesignSysEN.VueDesignSysName = strVueDesignSysName; //Vue控件设计体系名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.VueDesignSysName) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.VueDesignSysName, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysName] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetVueDesignSysEnName(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strVueDesignSysEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVueDesignSysEnName, conVueCtrlDesignSys.VueDesignSysEnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVueDesignSysEnName, 50, conVueCtrlDesignSys.VueDesignSysEnName);
}
objVueCtrlDesignSysEN.VueDesignSysEnName = strVueDesignSysEnName; //Vue控件设计体系英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.VueDesignSysEnName) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.VueDesignSysEnName, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysEnName] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetUpdDate(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conVueCtrlDesignSys.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conVueCtrlDesignSys.UpdDate);
}
objVueCtrlDesignSysEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.UpdDate) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.UpdDate, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.UpdDate] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetUpdUser(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conVueCtrlDesignSys.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conVueCtrlDesignSys.UpdUser);
}
objVueCtrlDesignSysEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.UpdUser) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.UpdUser, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.UpdUser] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVueCtrlDesignSysEN SetMemo(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conVueCtrlDesignSys.Memo);
}
objVueCtrlDesignSysEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVueCtrlDesignSysEN.dicFldComparisonOp.ContainsKey(conVueCtrlDesignSys.Memo) == false)
{
objVueCtrlDesignSysEN.dicFldComparisonOp.Add(conVueCtrlDesignSys.Memo, strComparisonOp);
}
else
{
objVueCtrlDesignSysEN.dicFldComparisonOp[conVueCtrlDesignSys.Memo] = strComparisonOp;
}
}
return objVueCtrlDesignSysEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objVueCtrlDesignSysEN.CheckPropertyNew();
clsVueCtrlDesignSysEN objVueCtrlDesignSysCond = new clsVueCtrlDesignSysEN();
string strCondition = objVueCtrlDesignSysCond
.SetVueDesignSysId(objVueCtrlDesignSysEN.VueDesignSysId, "<>")
.SetVueDesignSysName(objVueCtrlDesignSysEN.VueDesignSysName, "=")
.GetCombineCondition();
objVueCtrlDesignSysEN._IsCheckProperty = true;
bool bolIsExist = clsVueCtrlDesignSysBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa1)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objVueCtrlDesignSysEN.Update();
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
 /// <param name = "objVueCtrlDesignSys">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsVueCtrlDesignSysEN objVueCtrlDesignSys)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsVueCtrlDesignSysEN objVueCtrlDesignSysCond = new clsVueCtrlDesignSysEN();
string strCondition = objVueCtrlDesignSysCond
.SetVueDesignSysName(objVueCtrlDesignSys.VueDesignSysName, "=")
.GetCombineCondition();
objVueCtrlDesignSys._IsCheckProperty = true;
bool bolIsExist = clsVueCtrlDesignSysBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objVueCtrlDesignSys.VueDesignSysId = clsVueCtrlDesignSysBL.GetFirstID_S(strCondition);
objVueCtrlDesignSys.UpdateWithCondition(strCondition);
}
else
{
objVueCtrlDesignSys.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
objVueCtrlDesignSys.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.UpdateBySql2(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.UpdateBySql2(objVueCtrlDesignSysEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strWhereCond)
{
try
{
bool bolResult = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.UpdateBySqlWithCondition(objVueCtrlDesignSysEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.UpdateBySqlWithConditionTransaction(objVueCtrlDesignSysEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "strVueDesignSysId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
try
{
int intRecNum = clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.DelRecord(objVueCtrlDesignSysEN.VueDesignSysId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysENS">源对象</param>
 /// <param name = "objVueCtrlDesignSysENT">目标对象</param>
 public static void CopyTo(this clsVueCtrlDesignSysEN objVueCtrlDesignSysENS, clsVueCtrlDesignSysEN objVueCtrlDesignSysENT)
{
try
{
objVueCtrlDesignSysENT.VueDesignSysId = objVueCtrlDesignSysENS.VueDesignSysId; //Vue控件设计体系Id
objVueCtrlDesignSysENT.VueDesignSysName = objVueCtrlDesignSysENS.VueDesignSysName; //Vue控件设计体系名称
objVueCtrlDesignSysENT.VueDesignSysEnName = objVueCtrlDesignSysENS.VueDesignSysEnName; //Vue控件设计体系英文名
objVueCtrlDesignSysENT.UpdDate = objVueCtrlDesignSysENS.UpdDate; //修改日期
objVueCtrlDesignSysENT.UpdUser = objVueCtrlDesignSysENS.UpdUser; //修改者
objVueCtrlDesignSysENT.Memo = objVueCtrlDesignSysENS.Memo; //说明
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
 /// <param name = "objVueCtrlDesignSysENS">源对象</param>
 /// <returns>目标对象=>clsVueCtrlDesignSysEN:objVueCtrlDesignSysENT</returns>
 public static clsVueCtrlDesignSysEN CopyTo(this clsVueCtrlDesignSysEN objVueCtrlDesignSysENS)
{
try
{
 clsVueCtrlDesignSysEN objVueCtrlDesignSysENT = new clsVueCtrlDesignSysEN()
{
VueDesignSysId = objVueCtrlDesignSysENS.VueDesignSysId, //Vue控件设计体系Id
VueDesignSysName = objVueCtrlDesignSysENS.VueDesignSysName, //Vue控件设计体系名称
VueDesignSysEnName = objVueCtrlDesignSysENS.VueDesignSysEnName, //Vue控件设计体系英文名
UpdDate = objVueCtrlDesignSysENS.UpdDate, //修改日期
UpdUser = objVueCtrlDesignSysENS.UpdUser, //修改者
Memo = objVueCtrlDesignSysENS.Memo, //说明
};
 return objVueCtrlDesignSysENT;
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
public static void CheckPropertyNew(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.CheckPropertyNew(objVueCtrlDesignSysEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 clsVueCtrlDesignSysBL.VueCtrlDesignSysDA.CheckProperty4Condition(objVueCtrlDesignSysEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsVueCtrlDesignSysEN objVueCtrlDesignSysCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.VueDesignSysId) == true)
{
string strComparisonOpVueDesignSysId = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.VueDesignSysId, objVueCtrlDesignSysCond.VueDesignSysId, strComparisonOpVueDesignSysId);
}
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.VueDesignSysName) == true)
{
string strComparisonOpVueDesignSysName = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.VueDesignSysName, objVueCtrlDesignSysCond.VueDesignSysName, strComparisonOpVueDesignSysName);
}
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.VueDesignSysEnName) == true)
{
string strComparisonOpVueDesignSysEnName = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.VueDesignSysEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.VueDesignSysEnName, objVueCtrlDesignSysCond.VueDesignSysEnName, strComparisonOpVueDesignSysEnName);
}
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.UpdDate) == true)
{
string strComparisonOpUpdDate = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.UpdDate, objVueCtrlDesignSysCond.UpdDate, strComparisonOpUpdDate);
}
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.UpdUser) == true)
{
string strComparisonOpUpdUser = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.UpdUser, objVueCtrlDesignSysCond.UpdUser, strComparisonOpUpdUser);
}
if (objVueCtrlDesignSysCond.IsUpdated(conVueCtrlDesignSys.Memo) == true)
{
string strComparisonOpMemo = objVueCtrlDesignSysCond.dicFldComparisonOp[conVueCtrlDesignSys.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVueCtrlDesignSys.Memo, objVueCtrlDesignSysCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--VueCtrlDesignSys(Vue控件设计体系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:VueDesignSysName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objVueCtrlDesignSysEN == null) return true;
if (objVueCtrlDesignSysEN.VueDesignSysId == null || objVueCtrlDesignSysEN.VueDesignSysId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VueDesignSysName = '{0}'", objVueCtrlDesignSysEN.VueDesignSysName);
if (clsVueCtrlDesignSysBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("VueDesignSysId !=  '{0}'", objVueCtrlDesignSysEN.VueDesignSysId);
 sbCondition.AppendFormat(" and VueDesignSysName = '{0}'", objVueCtrlDesignSysEN.VueDesignSysName);
if (clsVueCtrlDesignSysBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--VueCtrlDesignSys(Vue控件设计体系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:VueDesignSysName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objVueCtrlDesignSysEN == null) return "";
if (objVueCtrlDesignSysEN.VueDesignSysId == null || objVueCtrlDesignSysEN.VueDesignSysId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VueDesignSysName = '{0}'", objVueCtrlDesignSysEN.VueDesignSysName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("VueDesignSysId !=  '{0}'", objVueCtrlDesignSysEN.VueDesignSysId);
 sbCondition.AppendFormat(" and VueDesignSysName = '{0}'", objVueCtrlDesignSysEN.VueDesignSysName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_VueCtrlDesignSys
{
public virtual bool UpdRelaTabDate(string strVueDesignSysId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumVueCtrlDesignSys
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 基于 Ant Design 设计体系
 /// </summary>
public const string AntDesignVue_01 = "01";
 /// <summary>
 /// 基于 Element UI 设计体系
 /// </summary>
public const string ElementPlus_02 = "02";
}
 /// <summary>
 /// Vue控件设计体系(VueCtrlDesignSys)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsVueCtrlDesignSysBL
{
public static RelatedActions_VueCtrlDesignSys relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsVueCtrlDesignSysDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsVueCtrlDesignSysDA VueCtrlDesignSysDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsVueCtrlDesignSysDA();
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
 public clsVueCtrlDesignSysBL()
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
if (string.IsNullOrEmpty(clsVueCtrlDesignSysEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVueCtrlDesignSysEN._ConnectString);
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
public static DataTable GetDataTable_VueCtrlDesignSys(string strWhereCond)
{
DataTable objDT;
try
{
objDT = VueCtrlDesignSysDA.GetDataTable_VueCtrlDesignSys(strWhereCond);
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
objDT = VueCtrlDesignSysDA.GetDataTable(strWhereCond);
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
objDT = VueCtrlDesignSysDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = VueCtrlDesignSysDA.GetDataTable(strWhereCond, strTabName);
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
objDT = VueCtrlDesignSysDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = VueCtrlDesignSysDA.GetDataTable_Top(objTopPara);
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
objDT = VueCtrlDesignSysDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = VueCtrlDesignSysDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = VueCtrlDesignSysDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrVueDesignSysIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetObjLstByVueDesignSysIdLst(List<string> arrVueDesignSysIdLst)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVueDesignSysIdLst, true);
 string strWhereCond = string.Format("VueDesignSysId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVueDesignSysIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsVueCtrlDesignSysEN> GetObjLstByVueDesignSysIdLstCache(List<string> arrVueDesignSysIdLst)
{
string strKey = string.Format("{0}", clsVueCtrlDesignSysEN._CurrTabName);
List<clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLstCache = GetObjLstCache();
IEnumerable <clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLst_Sel =
arrVueCtrlDesignSysObjLstCache
.Where(x => arrVueDesignSysIdLst.Contains(x.VueDesignSysId));
return arrVueCtrlDesignSysObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetObjLst(string strWhereCond)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
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
public static List<clsVueCtrlDesignSysEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsVueCtrlDesignSysEN> GetSubObjLstCache(clsVueCtrlDesignSysEN objVueCtrlDesignSysCond)
{
List<clsVueCtrlDesignSysEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVueCtrlDesignSysEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVueCtrlDesignSys._AttributeName)
{
if (objVueCtrlDesignSysCond.IsUpdated(strFldName) == false) continue;
if (objVueCtrlDesignSysCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVueCtrlDesignSysCond[strFldName].ToString());
}
else
{
if (objVueCtrlDesignSysCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVueCtrlDesignSysCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVueCtrlDesignSysCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVueCtrlDesignSysCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVueCtrlDesignSysCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVueCtrlDesignSysCond[strFldName]));
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
public static List<clsVueCtrlDesignSysEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
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
public static List<clsVueCtrlDesignSysEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
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
List<clsVueCtrlDesignSysEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsVueCtrlDesignSysEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsVueCtrlDesignSysEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
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
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
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
public static List<clsVueCtrlDesignSysEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsVueCtrlDesignSysEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
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
public static List<clsVueCtrlDesignSysEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsVueCtrlDesignSysEN> arrObjLst = new List<clsVueCtrlDesignSysEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = new clsVueCtrlDesignSysEN();
try
{
objVueCtrlDesignSysEN.VueDesignSysId = objRow[conVueCtrlDesignSys.VueDesignSysId].ToString().Trim(); //Vue控件设计体系Id
objVueCtrlDesignSysEN.VueDesignSysName = objRow[conVueCtrlDesignSys.VueDesignSysName].ToString().Trim(); //Vue控件设计体系名称
objVueCtrlDesignSysEN.VueDesignSysEnName = objRow[conVueCtrlDesignSys.VueDesignSysEnName].ToString().Trim(); //Vue控件设计体系英文名
objVueCtrlDesignSysEN.UpdDate = objRow[conVueCtrlDesignSys.UpdDate].ToString().Trim(); //修改日期
objVueCtrlDesignSysEN.UpdUser = objRow[conVueCtrlDesignSys.UpdUser].ToString().Trim(); //修改者
objVueCtrlDesignSysEN.Memo = objRow[conVueCtrlDesignSys.Memo] == DBNull.Value ? null : objRow[conVueCtrlDesignSys.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVueCtrlDesignSysEN.VueDesignSysId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVueCtrlDesignSysEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetVueCtrlDesignSys(ref clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
bool bolResult = VueCtrlDesignSysDA.GetVueCtrlDesignSys(ref objVueCtrlDesignSysEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVueDesignSysId">表关键字</param>
 /// <returns>表对象</returns>
public static clsVueCtrlDesignSysEN GetObjByVueDesignSysId(string strVueDesignSysId)
{
if (strVueDesignSysId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strVueDesignSysId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVueDesignSysId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strVueDesignSysId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = VueCtrlDesignSysDA.GetObjByVueDesignSysId(strVueDesignSysId);
return objVueCtrlDesignSysEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsVueCtrlDesignSysEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = VueCtrlDesignSysDA.GetFirstObj(strWhereCond);
 return objVueCtrlDesignSysEN;
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
public static clsVueCtrlDesignSysEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = VueCtrlDesignSysDA.GetObjByDataRow(objRow);
 return objVueCtrlDesignSysEN;
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
public static clsVueCtrlDesignSysEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = VueCtrlDesignSysDA.GetObjByDataRow(objRow);
 return objVueCtrlDesignSysEN;
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
 /// <param name = "strVueDesignSysId">所给的关键字</param>
 /// <param name = "lstVueCtrlDesignSysObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVueCtrlDesignSysEN GetObjByVueDesignSysIdFromList(string strVueDesignSysId, List<clsVueCtrlDesignSysEN> lstVueCtrlDesignSysObjLst)
{
foreach (clsVueCtrlDesignSysEN objVueCtrlDesignSysEN in lstVueCtrlDesignSysObjLst)
{
if (objVueCtrlDesignSysEN.VueDesignSysId == strVueDesignSysId)
{
return objVueCtrlDesignSysEN;
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
 string strMaxVueDesignSysId;
 try
 {
 strMaxVueDesignSysId = clsVueCtrlDesignSysDA.GetMaxStrId();
 return strMaxVueDesignSysId;
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
 string strVueDesignSysId;
 try
 {
 strVueDesignSysId = new clsVueCtrlDesignSysDA().GetFirstID(strWhereCond);
 return strVueDesignSysId;
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
 arrList = VueCtrlDesignSysDA.GetID(strWhereCond);
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
bool bolIsExist = VueCtrlDesignSysDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVueDesignSysId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVueDesignSysId)
{
if (string.IsNullOrEmpty(strVueDesignSysId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strVueDesignSysId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = VueCtrlDesignSysDA.IsExist(strVueDesignSysId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strVueDesignSysId">Vue控件设计体系Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strVueDesignSysId, string strOpUser)
{
clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = clsVueCtrlDesignSysBL.GetObjByVueDesignSysId(strVueDesignSysId);
objVueCtrlDesignSysEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objVueCtrlDesignSysEN.UpdUser = strOpUser;
return clsVueCtrlDesignSysBL.UpdateBySql2(objVueCtrlDesignSysEN);
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
 bolIsExist = clsVueCtrlDesignSysDA.IsExistTable();
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
 bolIsExist = VueCtrlDesignSysDA.IsExistTable(strTabName);
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objVueCtrlDesignSysEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Vue控件设计体系名称 = [{0}]的数据已经存在!(in clsVueCtrlDesignSysBL.AddNewRecordBySql2)", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
bool bolResult = VueCtrlDesignSysDA.AddNewRecordBySQL2(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objVueCtrlDesignSysEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Vue控件设计体系名称 = [{0}]的数据已经存在!(in clsVueCtrlDesignSysBL.AddNewRecordBySql2WithReturnKey)", objVueCtrlDesignSysEN.VueDesignSysName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true || clsVueCtrlDesignSysBL.IsExist(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
     objVueCtrlDesignSysEN.VueDesignSysId = clsVueCtrlDesignSysBL.GetMaxStrId_S();
 }
string strKey = VueCtrlDesignSysDA.AddNewRecordBySQL2WithReturnKey(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
try
{
bool bolResult = VueCtrlDesignSysDA.Update(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "objVueCtrlDesignSysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 if (string.IsNullOrEmpty(objVueCtrlDesignSysEN.VueDesignSysId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = VueCtrlDesignSysDA.UpdateBySql2(objVueCtrlDesignSysEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVueCtrlDesignSysBL.ReFreshCache();

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
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
 /// <param name = "strVueDesignSysId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strVueDesignSysId)
{
try
{
 clsVueCtrlDesignSysEN objVueCtrlDesignSysEN = clsVueCtrlDesignSysBL.GetObjByVueDesignSysId(strVueDesignSysId);

if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(objVueCtrlDesignSysEN.VueDesignSysId, objVueCtrlDesignSysEN.UpdUser);
}
if (objVueCtrlDesignSysEN != null)
{
int intRecNum = VueCtrlDesignSysDA.DelRecord(strVueDesignSysId);
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
/// <param name="strVueDesignSysId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strVueDesignSysId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVueCtrlDesignSysDA.GetSpecSQLObj();
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
//删除与表:[VueCtrlDesignSys]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conVueCtrlDesignSys.VueDesignSysId,
//strVueDesignSysId);
//        clsVueCtrlDesignSysBL.DelVueCtrlDesignSyssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVueCtrlDesignSysBL.DelRecord(strVueDesignSysId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVueCtrlDesignSysBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVueDesignSysId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strVueDesignSysId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strVueDesignSysId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsVueCtrlDesignSysBL.relatedActions != null)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(strVueDesignSysId, "UpdRelaTabDate");
}
bool bolResult = VueCtrlDesignSysDA.DelRecord(strVueDesignSysId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrVueDesignSysIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelVueCtrlDesignSyss(List<string> arrVueDesignSysIdLst)
{
if (arrVueDesignSysIdLst.Count == 0) return 0;
try
{
if (clsVueCtrlDesignSysBL.relatedActions != null)
{
foreach (var strVueDesignSysId in arrVueDesignSysIdLst)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(strVueDesignSysId, "UpdRelaTabDate");
}
}
int intDelRecNum = VueCtrlDesignSysDA.DelVueCtrlDesignSys(arrVueDesignSysIdLst);
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
public static int DelVueCtrlDesignSyssByCond(string strWhereCond)
{
try
{
if (clsVueCtrlDesignSysBL.relatedActions != null)
{
List<string> arrVueDesignSysId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strVueDesignSysId in arrVueDesignSysId)
{
clsVueCtrlDesignSysBL.relatedActions.UpdRelaTabDate(strVueDesignSysId, "UpdRelaTabDate");
}
}
int intRecNum = VueCtrlDesignSysDA.DelVueCtrlDesignSys(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[VueCtrlDesignSys]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strVueDesignSysId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strVueDesignSysId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVueCtrlDesignSysDA.GetSpecSQLObj();
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
//删除与表:[VueCtrlDesignSys]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVueCtrlDesignSysBL.DelRecord(strVueDesignSysId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVueCtrlDesignSysBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVueDesignSysId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objVueCtrlDesignSysENS">源对象</param>
 /// <param name = "objVueCtrlDesignSysENT">目标对象</param>
 public static void CopyTo(clsVueCtrlDesignSysEN objVueCtrlDesignSysENS, clsVueCtrlDesignSysEN objVueCtrlDesignSysENT)
{
try
{
objVueCtrlDesignSysENT.VueDesignSysId = objVueCtrlDesignSysENS.VueDesignSysId; //Vue控件设计体系Id
objVueCtrlDesignSysENT.VueDesignSysName = objVueCtrlDesignSysENS.VueDesignSysName; //Vue控件设计体系名称
objVueCtrlDesignSysENT.VueDesignSysEnName = objVueCtrlDesignSysENS.VueDesignSysEnName; //Vue控件设计体系英文名
objVueCtrlDesignSysENT.UpdDate = objVueCtrlDesignSysENS.UpdDate; //修改日期
objVueCtrlDesignSysENT.UpdUser = objVueCtrlDesignSysENS.UpdUser; //修改者
objVueCtrlDesignSysENT.Memo = objVueCtrlDesignSysENS.Memo; //说明
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
 /// <param name = "objVueCtrlDesignSysEN">源简化对象</param>
 public static void SetUpdFlag(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
try
{
objVueCtrlDesignSysEN.ClearUpdateState();
   string strsfUpdFldSetStr = objVueCtrlDesignSysEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conVueCtrlDesignSys.VueDesignSysId, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.VueDesignSysId = objVueCtrlDesignSysEN.VueDesignSysId; //Vue控件设计体系Id
}
if (arrFldSet.Contains(conVueCtrlDesignSys.VueDesignSysName, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.VueDesignSysName = objVueCtrlDesignSysEN.VueDesignSysName; //Vue控件设计体系名称
}
if (arrFldSet.Contains(conVueCtrlDesignSys.VueDesignSysEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.VueDesignSysEnName = objVueCtrlDesignSysEN.VueDesignSysEnName; //Vue控件设计体系英文名
}
if (arrFldSet.Contains(conVueCtrlDesignSys.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.UpdDate = objVueCtrlDesignSysEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conVueCtrlDesignSys.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.UpdUser = objVueCtrlDesignSysEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conVueCtrlDesignSys.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objVueCtrlDesignSysEN.Memo = objVueCtrlDesignSysEN.Memo == "[null]" ? null :  objVueCtrlDesignSysEN.Memo; //说明
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
 /// <param name = "objVueCtrlDesignSysEN">源简化对象</param>
 public static void AccessFldValueNull(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
try
{
if (objVueCtrlDesignSysEN.Memo == "[null]") objVueCtrlDesignSysEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 VueCtrlDesignSysDA.CheckPropertyNew(objVueCtrlDesignSysEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
 VueCtrlDesignSysDA.CheckProperty4Condition(objVueCtrlDesignSysEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_VueDesignSysIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[Vue控件设计体系]...","0");
List<clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLst = GetAllVueCtrlDesignSysObjLstCache(); 
objDDL.DataValueField = conVueCtrlDesignSys.VueDesignSysId;
objDDL.DataTextField = conVueCtrlDesignSys.VueDesignSysName;
objDDL.DataSource = arrVueCtrlDesignSysObjLst;
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
if (clsVueCtrlDesignSysBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVueCtrlDesignSysBL没有刷新缓存机制(clsVueCtrlDesignSysBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VueDesignSysId");
//if (arrVueCtrlDesignSysObjLstCache == null)
//{
//arrVueCtrlDesignSysObjLstCache = VueCtrlDesignSysDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVueDesignSysId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVueCtrlDesignSysEN GetObjByVueDesignSysIdCache(string strVueDesignSysId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsVueCtrlDesignSysEN._CurrTabName);
List<clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLstCache = GetObjLstCache();
IEnumerable <clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLst_Sel =
arrVueCtrlDesignSysObjLstCache
.Where(x=> x.VueDesignSysId == strVueDesignSysId 
);
if (arrVueCtrlDesignSysObjLst_Sel.Count() == 0)
{
   clsVueCtrlDesignSysEN obj = clsVueCtrlDesignSysBL.GetObjByVueDesignSysId(strVueDesignSysId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrVueCtrlDesignSysObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVueDesignSysId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetVueDesignSysNameByVueDesignSysIdCache(string strVueDesignSysId)
{
if (string.IsNullOrEmpty(strVueDesignSysId) == true) return "";
//获取缓存中的对象列表
clsVueCtrlDesignSysEN objVueCtrlDesignSys = GetObjByVueDesignSysIdCache(strVueDesignSysId);
if (objVueCtrlDesignSys == null) return "";
return objVueCtrlDesignSys.VueDesignSysName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVueDesignSysId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByVueDesignSysIdCache(string strVueDesignSysId)
{
if (string.IsNullOrEmpty(strVueDesignSysId) == true) return "";
//获取缓存中的对象列表
clsVueCtrlDesignSysEN objVueCtrlDesignSys = GetObjByVueDesignSysIdCache(strVueDesignSysId);
if (objVueCtrlDesignSys == null) return "";
return objVueCtrlDesignSys.VueDesignSysName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetAllVueCtrlDesignSysObjLstCache()
{
//获取缓存中的对象列表
List<clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLstCache = GetObjLstCache(); 
return arrVueCtrlDesignSysObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVueCtrlDesignSysEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsVueCtrlDesignSysEN._CurrTabName);
List<clsVueCtrlDesignSysEN> arrVueCtrlDesignSysObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrVueCtrlDesignSysObjLstCache;
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
string strKey = string.Format("{0}", clsVueCtrlDesignSysEN._CurrTabName);
CacheHelper.Remove(strKey);
clsVueCtrlDesignSysEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsVueCtrlDesignSysEN._RefreshTimeLst.Count == 0) return "";
return clsVueCtrlDesignSysEN._RefreshTimeLst[clsVueCtrlDesignSysEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsVueCtrlDesignSysBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsVueCtrlDesignSysEN._CurrTabName);
CacheHelper.Remove(strKey);
clsVueCtrlDesignSysEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsVueCtrlDesignSysBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--VueCtrlDesignSys(Vue控件设计体系)
 /// 唯一性条件:VueDesignSysName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsVueCtrlDesignSysEN objVueCtrlDesignSysEN)
{
//检测记录是否存在
string strResult = VueCtrlDesignSysDA.GetUniCondStr(objVueCtrlDesignSysEN);
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
public static string Func(string strInFldName, string strOutFldName, string strVueDesignSysId)
{
if (strInFldName != conVueCtrlDesignSys.VueDesignSysId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conVueCtrlDesignSys._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conVueCtrlDesignSys._AttributeName));
throw new Exception(strMsg);
}
var objVueCtrlDesignSys = clsVueCtrlDesignSysBL.GetObjByVueDesignSysIdCache(strVueDesignSysId);
if (objVueCtrlDesignSys == null) return "";
return objVueCtrlDesignSys[strOutFldName].ToString();
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
int intRecCount = clsVueCtrlDesignSysDA.GetRecCount(strTabName);
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
int intRecCount = clsVueCtrlDesignSysDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsVueCtrlDesignSysDA.GetRecCount();
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
int intRecCount = clsVueCtrlDesignSysDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objVueCtrlDesignSysCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsVueCtrlDesignSysEN objVueCtrlDesignSysCond)
{
List<clsVueCtrlDesignSysEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVueCtrlDesignSysEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVueCtrlDesignSys._AttributeName)
{
if (objVueCtrlDesignSysCond.IsUpdated(strFldName) == false) continue;
if (objVueCtrlDesignSysCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVueCtrlDesignSysCond[strFldName].ToString());
}
else
{
if (objVueCtrlDesignSysCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVueCtrlDesignSysCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVueCtrlDesignSysCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVueCtrlDesignSysCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVueCtrlDesignSysCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVueCtrlDesignSysCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVueCtrlDesignSysCond[strFldName]));
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
 List<string> arrList = clsVueCtrlDesignSysDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = VueCtrlDesignSysDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = VueCtrlDesignSysDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = VueCtrlDesignSysDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsVueCtrlDesignSysDA.SetFldValue(clsVueCtrlDesignSysEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = VueCtrlDesignSysDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsVueCtrlDesignSysDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsVueCtrlDesignSysDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsVueCtrlDesignSysDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[VueCtrlDesignSys] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Vue控件设计体系Id*/ 
 strCreateTabCode.Append(" VueDesignSysId char(2) primary key, "); 
 // /**Vue控件设计体系名称*/ 
 strCreateTabCode.Append(" VueDesignSysName varchar(50) not Null, "); 
 // /**Vue控件设计体系英文名*/ 
 strCreateTabCode.Append(" VueDesignSysEnName varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// Vue控件设计体系(VueCtrlDesignSys)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4VueCtrlDesignSys : clsCommFun4BL
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
clsVueCtrlDesignSysBL.ReFreshThisCache();
}
}

}