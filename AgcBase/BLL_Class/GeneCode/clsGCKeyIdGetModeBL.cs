
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCKeyIdGetModeBL
 表名:GCKeyIdGetMode(00050562)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsGCKeyIdGetModeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCKeyIdGetModeEN GetObj(this K_KeyIdGetModeId_GCKeyIdGetMode myKey)
{
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.GetObjByKeyIdGetModeId(myKey.Value);
return objGCKeyIdGetModeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCKeyIdGetModeEN) == false)
{
var strMsg = string.Format("记录已经存在!GC关键字获取方式名 = [{0}]的数据已经存在!(in clsGCKeyIdGetModeBL.AddNewRecord)", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
bool bolResult = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.AddNewRecordBySQL2(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
public static bool AddRecordEx(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCKeyIdGetModeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCKeyIdGetModeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(GC关键字获取方式名(KeyIdGetModeName)=[{0}])已经存在,不能重复!", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCKeyIdGetModeEN.AddNewRecord();
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCKeyIdGetModeEN) == false)
{
var strMsg = string.Format("记录已经存在!GC关键字获取方式名 = [{0}]的数据已经存在!(in clsGCKeyIdGetModeBL.AddNewRecordWithMaxId)", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
string strKeyIdGetModeId = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.AddNewRecordBySQL2WithReturnKey(objGCKeyIdGetModeEN);
     objGCKeyIdGetModeEN.KeyIdGetModeId = strKeyIdGetModeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
}
return strKeyIdGetModeId;
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCKeyIdGetModeEN) == false)
{
var strMsg = string.Format("记录已经存在!GC关键字获取方式名 = [{0}]的数据已经存在!(in clsGCKeyIdGetModeBL.AddNewRecordWithReturnKey)", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
string strKey = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.AddNewRecordBySQL2WithReturnKey(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeId(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, conGCKeyIdGetMode.KeyIdGetModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, conGCKeyIdGetMode.KeyIdGetModeId);
}
objGCKeyIdGetModeEN.KeyIdGetModeId = strKeyIdGetModeId; //GC关键字获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeId) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeId, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeId] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeName(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyIdGetModeName, conGCKeyIdGetMode.KeyIdGetModeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdGetModeName, 50, conGCKeyIdGetMode.KeyIdGetModeName);
}
objGCKeyIdGetModeEN.KeyIdGetModeName = strKeyIdGetModeName; //GC关键字获取方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeName) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeName, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeName] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeENName(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyIdGetModeENName, conGCKeyIdGetMode.KeyIdGetModeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdGetModeENName, 50, conGCKeyIdGetMode.KeyIdGetModeENName);
}
objGCKeyIdGetModeEN.KeyIdGetModeENName = strKeyIdGetModeENName; //GC关键字获取方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeENName) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeENName, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeENName] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetUpdDate(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCKeyIdGetMode.UpdDate);
}
objGCKeyIdGetModeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.UpdDate) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.UpdDate, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.UpdDate] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetUpdUser(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCKeyIdGetMode.UpdUser);
}
objGCKeyIdGetModeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.UpdUser) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.UpdUser, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.UpdUser] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetMemo(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCKeyIdGetMode.Memo);
}
objGCKeyIdGetModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.Memo) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.Memo, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.Memo] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCKeyIdGetModeEN.CheckPropertyNew();
clsGCKeyIdGetModeEN objGCKeyIdGetModeCond = new clsGCKeyIdGetModeEN();
string strCondition = objGCKeyIdGetModeCond
.SetKeyIdGetModeId(objGCKeyIdGetModeEN.KeyIdGetModeId, "<>")
.SetKeyIdGetModeName(objGCKeyIdGetModeEN.KeyIdGetModeName, "=")
.GetCombineCondition();
objGCKeyIdGetModeEN._IsCheckProperty = true;
bool bolIsExist = clsGCKeyIdGetModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(KeyIdGetModeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCKeyIdGetModeEN.Update();
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
 /// <param name = "objGCKeyIdGetMode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCKeyIdGetModeEN objGCKeyIdGetMode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCKeyIdGetModeEN objGCKeyIdGetModeCond = new clsGCKeyIdGetModeEN();
string strCondition = objGCKeyIdGetModeCond
.SetKeyIdGetModeName(objGCKeyIdGetMode.KeyIdGetModeName, "=")
.GetCombineCondition();
objGCKeyIdGetMode._IsCheckProperty = true;
bool bolIsExist = clsGCKeyIdGetModeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCKeyIdGetMode.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetFirstID_S(strCondition);
objGCKeyIdGetMode.UpdateWithCondition(strCondition);
}
else
{
objGCKeyIdGetMode.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
objGCKeyIdGetMode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.UpdateBySql2(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.UpdateBySql2(objGCKeyIdGetModeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strWhereCond)
{
try
{
bool bolResult = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.UpdateBySqlWithCondition(objGCKeyIdGetModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.UpdateBySqlWithConditionTransaction(objGCKeyIdGetModeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "strKeyIdGetModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
int intRecNum = clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.DelRecord(objGCKeyIdGetModeEN.KeyIdGetModeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeENS">源对象</param>
 /// <param name = "objGCKeyIdGetModeENT">目标对象</param>
 public static void CopyTo(this clsGCKeyIdGetModeEN objGCKeyIdGetModeENS, clsGCKeyIdGetModeEN objGCKeyIdGetModeENT)
{
try
{
objGCKeyIdGetModeENT.KeyIdGetModeId = objGCKeyIdGetModeENS.KeyIdGetModeId; //GC关键字获取方式Id
objGCKeyIdGetModeENT.KeyIdGetModeName = objGCKeyIdGetModeENS.KeyIdGetModeName; //GC关键字获取方式名
objGCKeyIdGetModeENT.KeyIdGetModeENName = objGCKeyIdGetModeENS.KeyIdGetModeENName; //GC关键字获取方式英文名
objGCKeyIdGetModeENT.UpdDate = objGCKeyIdGetModeENS.UpdDate; //修改日期
objGCKeyIdGetModeENT.UpdUser = objGCKeyIdGetModeENS.UpdUser; //修改者
objGCKeyIdGetModeENT.Memo = objGCKeyIdGetModeENS.Memo; //说明
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
 /// <param name = "objGCKeyIdGetModeENS">源对象</param>
 /// <returns>目标对象=>clsGCKeyIdGetModeEN:objGCKeyIdGetModeENT</returns>
 public static clsGCKeyIdGetModeEN CopyTo(this clsGCKeyIdGetModeEN objGCKeyIdGetModeENS)
{
try
{
 clsGCKeyIdGetModeEN objGCKeyIdGetModeENT = new clsGCKeyIdGetModeEN()
{
KeyIdGetModeId = objGCKeyIdGetModeENS.KeyIdGetModeId, //GC关键字获取方式Id
KeyIdGetModeName = objGCKeyIdGetModeENS.KeyIdGetModeName, //GC关键字获取方式名
KeyIdGetModeENName = objGCKeyIdGetModeENS.KeyIdGetModeENName, //GC关键字获取方式英文名
UpdDate = objGCKeyIdGetModeENS.UpdDate, //修改日期
UpdUser = objGCKeyIdGetModeENS.UpdUser, //修改者
Memo = objGCKeyIdGetModeENS.Memo, //说明
};
 return objGCKeyIdGetModeENT;
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
public static void CheckPropertyNew(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.CheckPropertyNew(objGCKeyIdGetModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 clsGCKeyIdGetModeBL.GCKeyIdGetModeDA.CheckProperty4Condition(objGCKeyIdGetModeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeId) == true)
{
string strComparisonOpKeyIdGetModeId = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeId, objGCKeyIdGetModeCond.KeyIdGetModeId, strComparisonOpKeyIdGetModeId);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeName) == true)
{
string strComparisonOpKeyIdGetModeName = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeName, objGCKeyIdGetModeCond.KeyIdGetModeName, strComparisonOpKeyIdGetModeName);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeENName) == true)
{
string strComparisonOpKeyIdGetModeENName = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeENName, objGCKeyIdGetModeCond.KeyIdGetModeENName, strComparisonOpKeyIdGetModeENName);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.UpdDate, objGCKeyIdGetModeCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.UpdUser, objGCKeyIdGetModeCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.Memo) == true)
{
string strComparisonOpMemo = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.Memo, objGCKeyIdGetModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCKeyIdGetMode(GC关键字获取方式), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:KeyIdGetModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCKeyIdGetModeEN == null) return true;
if (objGCKeyIdGetModeEN.KeyIdGetModeId == null || objGCKeyIdGetModeEN.KeyIdGetModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
if (clsGCKeyIdGetModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("KeyIdGetModeId !=  '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeId);
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
if (clsGCKeyIdGetModeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCKeyIdGetMode(GC关键字获取方式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:KeyIdGetModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCKeyIdGetModeEN == null) return "";
if (objGCKeyIdGetModeEN.KeyIdGetModeId == null || objGCKeyIdGetModeEN.KeyIdGetModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KeyIdGetModeId !=  '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeId);
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCKeyIdGetMode
{
public virtual bool UpdRelaTabDate(string strKeyIdGetModeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumGCKeyIdGetMode
{
 /// <summary>
 /// 列表选择记录
 /// </summary>
public const string ListCheckedRecord_0001 = "0001";
 /// <summary>
 /// 界面静态变量
 /// </summary>
public const string ViewStaticVariable_0002 = "0002";
}
 /// <summary>
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCKeyIdGetModeBL
{
public static RelatedActions_GCKeyIdGetMode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCKeyIdGetModeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCKeyIdGetModeDA GCKeyIdGetModeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCKeyIdGetModeDA();
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
 public clsGCKeyIdGetModeBL()
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
if (string.IsNullOrEmpty(clsGCKeyIdGetModeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCKeyIdGetModeEN._ConnectString);
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
public static DataTable GetDataTable_GCKeyIdGetMode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCKeyIdGetModeDA.GetDataTable_GCKeyIdGetMode(strWhereCond);
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
objDT = GCKeyIdGetModeDA.GetDataTable(strWhereCond);
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
objDT = GCKeyIdGetModeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCKeyIdGetModeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCKeyIdGetModeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCKeyIdGetModeDA.GetDataTable_Top(objTopPara);
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
objDT = GCKeyIdGetModeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCKeyIdGetModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCKeyIdGetModeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKeyIdGetModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstByKeyIdGetModeIdLst(List<string> arrKeyIdGetModeIdLst)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKeyIdGetModeIdLst, true);
 string strWhereCond = string.Format("KeyIdGetModeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyIdGetModeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCKeyIdGetModeEN> GetObjLstByKeyIdGetModeIdLstCache(List<string> arrKeyIdGetModeIdLst)
{
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel =
arrGCKeyIdGetModeObjLstCache
.Where(x => arrKeyIdGetModeIdLst.Contains(x.KeyIdGetModeId));
return arrGCKeyIdGetModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLst(string strWhereCond)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
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
public static List<clsGCKeyIdGetModeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCKeyIdGetModeEN> GetSubObjLstCache(clsGCKeyIdGetModeEN objGCKeyIdGetModeCond)
{
List<clsGCKeyIdGetModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCKeyIdGetMode._AttributeName)
{
if (objGCKeyIdGetModeCond.IsUpdated(strFldName) == false) continue;
if (objGCKeyIdGetModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCKeyIdGetModeCond[strFldName].ToString());
}
else
{
if (objGCKeyIdGetModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCKeyIdGetModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCKeyIdGetModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCKeyIdGetModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCKeyIdGetModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCKeyIdGetModeCond[strFldName]));
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
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
List<clsGCKeyIdGetModeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCKeyIdGetModeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCKeyIdGetModeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
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
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
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
public static List<clsGCKeyIdGetModeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCKeyIdGetModeEN> arrObjLst = new List<clsGCKeyIdGetModeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN();
try
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objRow[conGCKeyIdGetMode.KeyIdGetModeId].ToString().Trim(); //GC关键字获取方式Id
objGCKeyIdGetModeEN.KeyIdGetModeName = objRow[conGCKeyIdGetMode.KeyIdGetModeName].ToString().Trim(); //GC关键字获取方式名
objGCKeyIdGetModeEN.KeyIdGetModeENName = objRow[conGCKeyIdGetMode.KeyIdGetModeENName].ToString().Trim(); //GC关键字获取方式英文名
objGCKeyIdGetModeEN.UpdDate = objRow[conGCKeyIdGetMode.UpdDate] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdDate].ToString().Trim(); //修改日期
objGCKeyIdGetModeEN.UpdUser = objRow[conGCKeyIdGetMode.UpdUser] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.UpdUser].ToString().Trim(); //修改者
objGCKeyIdGetModeEN.Memo = objRow[conGCKeyIdGetMode.Memo] == DBNull.Value ? null : objRow[conGCKeyIdGetMode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCKeyIdGetModeEN.KeyIdGetModeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCKeyIdGetModeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCKeyIdGetMode(ref clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
bool bolResult = GCKeyIdGetModeDA.GetGCKeyIdGetMode(ref objGCKeyIdGetModeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCKeyIdGetModeEN GetObjByKeyIdGetModeId(string strKeyIdGetModeId)
{
if (strKeyIdGetModeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKeyIdGetModeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKeyIdGetModeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = GCKeyIdGetModeDA.GetObjByKeyIdGetModeId(strKeyIdGetModeId);
return objGCKeyIdGetModeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCKeyIdGetModeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = GCKeyIdGetModeDA.GetFirstObj(strWhereCond);
 return objGCKeyIdGetModeEN;
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
public static clsGCKeyIdGetModeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = GCKeyIdGetModeDA.GetObjByDataRow(objRow);
 return objGCKeyIdGetModeEN;
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
public static clsGCKeyIdGetModeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = GCKeyIdGetModeDA.GetObjByDataRow(objRow);
 return objGCKeyIdGetModeEN;
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
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <param name = "lstGCKeyIdGetModeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCKeyIdGetModeEN GetObjByKeyIdGetModeIdFromList(string strKeyIdGetModeId, List<clsGCKeyIdGetModeEN> lstGCKeyIdGetModeObjLst)
{
foreach (clsGCKeyIdGetModeEN objGCKeyIdGetModeEN in lstGCKeyIdGetModeObjLst)
{
if (objGCKeyIdGetModeEN.KeyIdGetModeId == strKeyIdGetModeId)
{
return objGCKeyIdGetModeEN;
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
 string strMaxKeyIdGetModeId;
 try
 {
 strMaxKeyIdGetModeId = clsGCKeyIdGetModeDA.GetMaxStrId();
 return strMaxKeyIdGetModeId;
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
 string strKeyIdGetModeId;
 try
 {
 strKeyIdGetModeId = new clsGCKeyIdGetModeDA().GetFirstID(strWhereCond);
 return strKeyIdGetModeId;
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
 arrList = GCKeyIdGetModeDA.GetID(strWhereCond);
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
bool bolIsExist = GCKeyIdGetModeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKeyIdGetModeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCKeyIdGetModeDA.IsExist(strKeyIdGetModeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strKeyIdGetModeId">GC关键字获取方式Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strKeyIdGetModeId, string strOpUser)
{
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = clsGCKeyIdGetModeBL.GetObjByKeyIdGetModeId(strKeyIdGetModeId);
objGCKeyIdGetModeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCKeyIdGetModeEN.UpdUser = strOpUser;
return clsGCKeyIdGetModeBL.UpdateBySql2(objGCKeyIdGetModeEN);
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
 bolIsExist = clsGCKeyIdGetModeDA.IsExistTable();
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
 bolIsExist = GCKeyIdGetModeDA.IsExistTable(strTabName);
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCKeyIdGetModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!GC关键字获取方式名 = [{0}]的数据已经存在!(in clsGCKeyIdGetModeBL.AddNewRecordBySql2)", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
bool bolResult = GCKeyIdGetModeDA.AddNewRecordBySQL2(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCKeyIdGetModeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!GC关键字获取方式名 = [{0}]的数据已经存在!(in clsGCKeyIdGetModeBL.AddNewRecordBySql2WithReturnKey)", objGCKeyIdGetModeEN.KeyIdGetModeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeBL.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeBL.GetMaxStrId_S();
 }
string strKey = GCKeyIdGetModeDA.AddNewRecordBySQL2WithReturnKey(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
bool bolResult = GCKeyIdGetModeDA.Update(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCKeyIdGetModeDA.UpdateBySql2(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeBL.ReFreshCache();

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
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
 /// <param name = "strKeyIdGetModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strKeyIdGetModeId)
{
try
{
 clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = clsGCKeyIdGetModeBL.GetObjByKeyIdGetModeId(strKeyIdGetModeId);

if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(objGCKeyIdGetModeEN.KeyIdGetModeId, objGCKeyIdGetModeEN.UpdUser);
}
if (objGCKeyIdGetModeEN != null)
{
int intRecNum = GCKeyIdGetModeDA.DelRecord(strKeyIdGetModeId);
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
/// <param name="strKeyIdGetModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strKeyIdGetModeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCKeyIdGetModeDA.GetSpecSQLObj();
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
//删除与表:[GCKeyIdGetMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCKeyIdGetMode.KeyIdGetModeId,
//strKeyIdGetModeId);
//        clsGCKeyIdGetModeBL.DelGCKeyIdGetModesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCKeyIdGetModeBL.DelRecord(strKeyIdGetModeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCKeyIdGetModeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKeyIdGetModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strKeyIdGetModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strKeyIdGetModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCKeyIdGetModeBL.relatedActions != null)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(strKeyIdGetModeId, "UpdRelaTabDate");
}
bool bolResult = GCKeyIdGetModeDA.DelRecord(strKeyIdGetModeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrKeyIdGetModeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCKeyIdGetModes(List<string> arrKeyIdGetModeIdLst)
{
if (arrKeyIdGetModeIdLst.Count == 0) return 0;
try
{
if (clsGCKeyIdGetModeBL.relatedActions != null)
{
foreach (var strKeyIdGetModeId in arrKeyIdGetModeIdLst)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(strKeyIdGetModeId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCKeyIdGetModeDA.DelGCKeyIdGetMode(arrKeyIdGetModeIdLst);
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
public static int DelGCKeyIdGetModesByCond(string strWhereCond)
{
try
{
if (clsGCKeyIdGetModeBL.relatedActions != null)
{
List<string> arrKeyIdGetModeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strKeyIdGetModeId in arrKeyIdGetModeId)
{
clsGCKeyIdGetModeBL.relatedActions.UpdRelaTabDate(strKeyIdGetModeId, "UpdRelaTabDate");
}
}
int intRecNum = GCKeyIdGetModeDA.DelGCKeyIdGetMode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCKeyIdGetMode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strKeyIdGetModeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strKeyIdGetModeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCKeyIdGetModeDA.GetSpecSQLObj();
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
//删除与表:[GCKeyIdGetMode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCKeyIdGetModeBL.DelRecord(strKeyIdGetModeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCKeyIdGetModeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKeyIdGetModeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCKeyIdGetModeENS">源对象</param>
 /// <param name = "objGCKeyIdGetModeENT">目标对象</param>
 public static void CopyTo(clsGCKeyIdGetModeEN objGCKeyIdGetModeENS, clsGCKeyIdGetModeEN objGCKeyIdGetModeENT)
{
try
{
objGCKeyIdGetModeENT.KeyIdGetModeId = objGCKeyIdGetModeENS.KeyIdGetModeId; //GC关键字获取方式Id
objGCKeyIdGetModeENT.KeyIdGetModeName = objGCKeyIdGetModeENS.KeyIdGetModeName; //GC关键字获取方式名
objGCKeyIdGetModeENT.KeyIdGetModeENName = objGCKeyIdGetModeENS.KeyIdGetModeENName; //GC关键字获取方式英文名
objGCKeyIdGetModeENT.UpdDate = objGCKeyIdGetModeENS.UpdDate; //修改日期
objGCKeyIdGetModeENT.UpdUser = objGCKeyIdGetModeENS.UpdUser; //修改者
objGCKeyIdGetModeENT.Memo = objGCKeyIdGetModeENS.Memo; //说明
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
 /// <param name = "objGCKeyIdGetModeEN">源简化对象</param>
 public static void SetUpdFlag(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
objGCKeyIdGetModeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCKeyIdGetModeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCKeyIdGetMode.KeyIdGetModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.KeyIdGetModeId = objGCKeyIdGetModeEN.KeyIdGetModeId; //GC关键字获取方式Id
}
if (arrFldSet.Contains(conGCKeyIdGetMode.KeyIdGetModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.KeyIdGetModeName = objGCKeyIdGetModeEN.KeyIdGetModeName; //GC关键字获取方式名
}
if (arrFldSet.Contains(conGCKeyIdGetMode.KeyIdGetModeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.KeyIdGetModeENName = objGCKeyIdGetModeEN.KeyIdGetModeENName; //GC关键字获取方式英文名
}
if (arrFldSet.Contains(conGCKeyIdGetMode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.UpdDate = objGCKeyIdGetModeEN.UpdDate == "[null]" ? null :  objGCKeyIdGetModeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCKeyIdGetMode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.UpdUser = objGCKeyIdGetModeEN.UpdUser == "[null]" ? null :  objGCKeyIdGetModeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCKeyIdGetMode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCKeyIdGetModeEN.Memo = objGCKeyIdGetModeEN.Memo == "[null]" ? null :  objGCKeyIdGetModeEN.Memo; //说明
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
 /// <param name = "objGCKeyIdGetModeEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
if (objGCKeyIdGetModeEN.UpdDate == "[null]") objGCKeyIdGetModeEN.UpdDate = null; //修改日期
if (objGCKeyIdGetModeEN.UpdUser == "[null]") objGCKeyIdGetModeEN.UpdUser = null; //修改者
if (objGCKeyIdGetModeEN.Memo == "[null]") objGCKeyIdGetModeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 GCKeyIdGetModeDA.CheckPropertyNew(objGCKeyIdGetModeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 GCKeyIdGetModeDA.CheckProperty4Condition(objGCKeyIdGetModeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_KeyIdGetModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCKeyIdGetMode.KeyIdGetModeId); 
List<clsGCKeyIdGetModeEN> arrObjLst = clsGCKeyIdGetModeBL.GetObjLst(strCondition).OrderBy(x=>x.KeyIdGetModeName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN()
{
KeyIdGetModeId = "0",
KeyIdGetModeName = "选[GC关键字获取方式]..."
};
arrObjLst.Insert(0, objGCKeyIdGetModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCKeyIdGetMode.KeyIdGetModeId;
objComboBox.DisplayMember = conGCKeyIdGetMode.KeyIdGetModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_KeyIdGetModeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC关键字获取方式]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conGCKeyIdGetMode.KeyIdGetModeId); 
IEnumerable<clsGCKeyIdGetModeEN> arrObjLst = clsGCKeyIdGetModeBL.GetObjLst(strCondition).OrderBy(x=>x.KeyIdGetModeName);
objDDL.DataValueField = conGCKeyIdGetMode.KeyIdGetModeId;
objDDL.DataTextField = conGCKeyIdGetMode.KeyIdGetModeName;
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
public static void BindDdl_KeyIdGetModeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC关键字获取方式]...","0");
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst = GetAllGCKeyIdGetModeObjLstCache(); 
objDDL.DataValueField = conGCKeyIdGetMode.KeyIdGetModeId;
objDDL.DataTextField = conGCKeyIdGetMode.KeyIdGetModeName;
objDDL.DataSource = arrGCKeyIdGetModeObjLst;
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
if (clsGCKeyIdGetModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCKeyIdGetModeBL没有刷新缓存机制(clsGCKeyIdGetModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KeyIdGetModeId");
//if (arrGCKeyIdGetModeObjLstCache == null)
//{
//arrGCKeyIdGetModeObjLstCache = GCKeyIdGetModeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCKeyIdGetModeEN GetObjByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel =
arrGCKeyIdGetModeObjLstCache
.Where(x=> x.KeyIdGetModeId == strKeyIdGetModeId 
);
if (arrGCKeyIdGetModeObjLst_Sel.Count() == 0)
{
   clsGCKeyIdGetModeEN obj = clsGCKeyIdGetModeBL.GetObjByKeyIdGetModeId(strKeyIdGetModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCKeyIdGetModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKeyIdGetModeNameByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return "";
//获取缓存中的对象列表
clsGCKeyIdGetModeEN objGCKeyIdGetMode = GetObjByKeyIdGetModeIdCache(strKeyIdGetModeId);
if (objGCKeyIdGetMode == null) return "";
return objGCKeyIdGetMode.KeyIdGetModeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return "";
//获取缓存中的对象列表
clsGCKeyIdGetModeEN objGCKeyIdGetMode = GetObjByKeyIdGetModeIdCache(strKeyIdGetModeId);
if (objGCKeyIdGetMode == null) return "";
return objGCKeyIdGetMode.KeyIdGetModeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetAllGCKeyIdGetModeObjLstCache()
{
//获取缓存中的对象列表
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache(); 
return arrGCKeyIdGetModeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCKeyIdGetModeObjLstCache;
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
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCKeyIdGetModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCKeyIdGetModeEN._RefreshTimeLst.Count == 0) return "";
return clsGCKeyIdGetModeEN._RefreshTimeLst[clsGCKeyIdGetModeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsGCKeyIdGetModeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCKeyIdGetModeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCKeyIdGetModeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCKeyIdGetMode(GC关键字获取方式)
 /// 唯一性条件:KeyIdGetModeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
//检测记录是否存在
string strResult = GCKeyIdGetModeDA.GetUniCondStr(objGCKeyIdGetModeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strKeyIdGetModeId)
{
if (strInFldName != conGCKeyIdGetMode.KeyIdGetModeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCKeyIdGetMode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCKeyIdGetMode._AttributeName));
throw new Exception(strMsg);
}
var objGCKeyIdGetMode = clsGCKeyIdGetModeBL.GetObjByKeyIdGetModeIdCache(strKeyIdGetModeId);
if (objGCKeyIdGetMode == null) return "";
return objGCKeyIdGetMode[strOutFldName].ToString();
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
int intRecCount = clsGCKeyIdGetModeDA.GetRecCount(strTabName);
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
int intRecCount = clsGCKeyIdGetModeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCKeyIdGetModeDA.GetRecCount();
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
int intRecCount = clsGCKeyIdGetModeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCKeyIdGetModeEN objGCKeyIdGetModeCond)
{
List<clsGCKeyIdGetModeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCKeyIdGetMode._AttributeName)
{
if (objGCKeyIdGetModeCond.IsUpdated(strFldName) == false) continue;
if (objGCKeyIdGetModeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCKeyIdGetModeCond[strFldName].ToString());
}
else
{
if (objGCKeyIdGetModeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCKeyIdGetModeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCKeyIdGetModeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCKeyIdGetModeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCKeyIdGetModeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCKeyIdGetModeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCKeyIdGetModeCond[strFldName]));
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
 List<string> arrList = clsGCKeyIdGetModeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCKeyIdGetModeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCKeyIdGetModeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCKeyIdGetModeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCKeyIdGetModeDA.SetFldValue(clsGCKeyIdGetModeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCKeyIdGetModeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCKeyIdGetModeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCKeyIdGetModeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCKeyIdGetModeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCKeyIdGetMode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**GC关键字获取方式Id*/ 
 strCreateTabCode.Append(" KeyIdGetModeId char(4) primary key, "); 
 // /**GC关键字获取方式名*/ 
 strCreateTabCode.Append(" KeyIdGetModeName varchar(50) not Null, "); 
 // /**GC关键字获取方式英文名*/ 
 strCreateTabCode.Append(" KeyIdGetModeENName varchar(50) not Null, "); 
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
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCKeyIdGetMode : clsCommFun4BL
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
clsGCKeyIdGetModeBL.ReFreshThisCache();
}
}

}