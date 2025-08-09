
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssociationMappingBL
 表名:AssociationMapping(00050550)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsAssociationMappingBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strAssociationMappingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAssociationMappingEN GetObj(this K_AssociationMappingId_AssociationMapping myKey)
{
clsAssociationMappingEN objAssociationMappingEN = clsAssociationMappingBL.AssociationMappingDA.GetObjByAssociationMappingId(myKey.Value);
return objAssociationMappingEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAssociationMappingEN) == false)
{
var strMsg = string.Format("记录已经存在!关联关系映射名 = [{0}]的数据已经存在!(in clsAssociationMappingBL.AddNewRecord)", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
bool bolResult = clsAssociationMappingBL.AssociationMappingDA.AddNewRecordBySQL2(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
public static bool AddRecordEx(this clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objAssociationMappingEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objAssociationMappingEN.CheckUniqueness() == false)
{
strMsg = string.Format("(关联关系映射名(AssociationMappingName)=[{0}])已经存在,不能重复!", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objAssociationMappingEN.AddNewRecord();
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAssociationMappingEN) == false)
{
var strMsg = string.Format("记录已经存在!关联关系映射名 = [{0}]的数据已经存在!(in clsAssociationMappingBL.AddNewRecordWithMaxId)", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
string strAssociationMappingId = clsAssociationMappingBL.AssociationMappingDA.AddNewRecordBySQL2WithReturnKey(objAssociationMappingEN);
     objAssociationMappingEN.AssociationMappingId = strAssociationMappingId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
}
return strAssociationMappingId;
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAssociationMappingEN) == false)
{
var strMsg = string.Format("记录已经存在!关联关系映射名 = [{0}]的数据已经存在!(in clsAssociationMappingBL.AddNewRecordWithReturnKey)", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
string strKey = clsAssociationMappingBL.AssociationMappingDA.AddNewRecordBySQL2WithReturnKey(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetAssociationMappingId(this clsAssociationMappingEN objAssociationMappingEN, string strAssociationMappingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conAssociationMapping.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conAssociationMapping.AssociationMappingId);
}
objAssociationMappingEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.AssociationMappingId) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.AssociationMappingId, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.AssociationMappingId] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetAssociationMappingName(this clsAssociationMappingEN objAssociationMappingEN, string strAssociationMappingName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, conAssociationMapping.AssociationMappingName);
}
objAssociationMappingEN.AssociationMappingName = strAssociationMappingName; //关联关系映射名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.AssociationMappingName) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.AssociationMappingName, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.AssociationMappingName] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetAssociationMappingENName(this clsAssociationMappingEN objAssociationMappingEN, string strAssociationMappingENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingENName, 50, conAssociationMapping.AssociationMappingENName);
}
objAssociationMappingEN.AssociationMappingENName = strAssociationMappingENName; //关联关系映射英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.AssociationMappingENName) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.AssociationMappingENName, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.AssociationMappingENName] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetUpdDate(this clsAssociationMappingEN objAssociationMappingEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAssociationMapping.UpdDate);
}
objAssociationMappingEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.UpdDate) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.UpdDate, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.UpdDate] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetUpdUser(this clsAssociationMappingEN objAssociationMappingEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAssociationMapping.UpdUser);
}
objAssociationMappingEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.UpdUser) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.UpdUser, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.UpdUser] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAssociationMappingEN SetMemo(this clsAssociationMappingEN objAssociationMappingEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAssociationMapping.Memo);
}
objAssociationMappingEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAssociationMappingEN.dicFldComparisonOp.ContainsKey(conAssociationMapping.Memo) == false)
{
objAssociationMappingEN.dicFldComparisonOp.Add(conAssociationMapping.Memo, strComparisonOp);
}
else
{
objAssociationMappingEN.dicFldComparisonOp[conAssociationMapping.Memo] = strComparisonOp;
}
}
return objAssociationMappingEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAssociationMappingEN objAssociationMappingEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAssociationMappingEN.CheckPropertyNew();
clsAssociationMappingEN objAssociationMappingCond = new clsAssociationMappingEN();
string strCondition = objAssociationMappingCond
.SetAssociationMappingId(objAssociationMappingEN.AssociationMappingId, "<>")
.SetAssociationMappingName(objAssociationMappingEN.AssociationMappingName, "=")
.GetCombineCondition();
objAssociationMappingEN._IsCheckProperty = true;
bool bolIsExist = clsAssociationMappingBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AssociationMappingName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAssociationMappingEN.Update();
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
 /// <param name = "objAssociationMapping">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsAssociationMappingEN objAssociationMapping)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsAssociationMappingEN objAssociationMappingCond = new clsAssociationMappingEN();
string strCondition = objAssociationMappingCond
.SetAssociationMappingName(objAssociationMapping.AssociationMappingName, "=")
.GetCombineCondition();
objAssociationMapping._IsCheckProperty = true;
bool bolIsExist = clsAssociationMappingBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objAssociationMapping.AssociationMappingId = clsAssociationMappingBL.GetFirstID_S(strCondition);
objAssociationMapping.UpdateWithCondition(strCondition);
}
else
{
objAssociationMapping.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
objAssociationMapping.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAssociationMappingEN objAssociationMappingEN)
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAssociationMappingBL.AssociationMappingDA.UpdateBySql2(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAssociationMappingEN objAssociationMappingEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAssociationMappingBL.AssociationMappingDA.UpdateBySql2(objAssociationMappingEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAssociationMappingEN objAssociationMappingEN, string strWhereCond)
{
try
{
bool bolResult = clsAssociationMappingBL.AssociationMappingDA.UpdateBySqlWithCondition(objAssociationMappingEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAssociationMappingEN objAssociationMappingEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAssociationMappingBL.AssociationMappingDA.UpdateBySqlWithConditionTransaction(objAssociationMappingEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "strAssociationMappingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsAssociationMappingEN objAssociationMappingEN)
{
try
{
int intRecNum = clsAssociationMappingBL.AssociationMappingDA.DelRecord(objAssociationMappingEN.AssociationMappingId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingENS">源对象</param>
 /// <param name = "objAssociationMappingENT">目标对象</param>
 public static void CopyTo(this clsAssociationMappingEN objAssociationMappingENS, clsAssociationMappingEN objAssociationMappingENT)
{
try
{
objAssociationMappingENT.AssociationMappingId = objAssociationMappingENS.AssociationMappingId; //关联关系映射Id
objAssociationMappingENT.AssociationMappingName = objAssociationMappingENS.AssociationMappingName; //关联关系映射名
objAssociationMappingENT.AssociationMappingENName = objAssociationMappingENS.AssociationMappingENName; //关联关系映射英文名
objAssociationMappingENT.UpdDate = objAssociationMappingENS.UpdDate; //修改日期
objAssociationMappingENT.UpdUser = objAssociationMappingENS.UpdUser; //修改者
objAssociationMappingENT.Memo = objAssociationMappingENS.Memo; //说明
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
 /// <param name = "objAssociationMappingENS">源对象</param>
 /// <returns>目标对象=>clsAssociationMappingEN:objAssociationMappingENT</returns>
 public static clsAssociationMappingEN CopyTo(this clsAssociationMappingEN objAssociationMappingENS)
{
try
{
 clsAssociationMappingEN objAssociationMappingENT = new clsAssociationMappingEN()
{
AssociationMappingId = objAssociationMappingENS.AssociationMappingId, //关联关系映射Id
AssociationMappingName = objAssociationMappingENS.AssociationMappingName, //关联关系映射名
AssociationMappingENName = objAssociationMappingENS.AssociationMappingENName, //关联关系映射英文名
UpdDate = objAssociationMappingENS.UpdDate, //修改日期
UpdUser = objAssociationMappingENS.UpdUser, //修改者
Memo = objAssociationMappingENS.Memo, //说明
};
 return objAssociationMappingENT;
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
public static void CheckPropertyNew(this clsAssociationMappingEN objAssociationMappingEN)
{
 clsAssociationMappingBL.AssociationMappingDA.CheckPropertyNew(objAssociationMappingEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAssociationMappingEN objAssociationMappingEN)
{
 clsAssociationMappingBL.AssociationMappingDA.CheckProperty4Condition(objAssociationMappingEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAssociationMappingEN objAssociationMappingCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.AssociationMappingId, objAssociationMappingCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.AssociationMappingName) == true)
{
string strComparisonOpAssociationMappingName = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.AssociationMappingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.AssociationMappingName, objAssociationMappingCond.AssociationMappingName, strComparisonOpAssociationMappingName);
}
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.AssociationMappingENName) == true)
{
string strComparisonOpAssociationMappingENName = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.AssociationMappingENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.AssociationMappingENName, objAssociationMappingCond.AssociationMappingENName, strComparisonOpAssociationMappingENName);
}
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.UpdDate) == true)
{
string strComparisonOpUpdDate = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.UpdDate, objAssociationMappingCond.UpdDate, strComparisonOpUpdDate);
}
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.UpdUser) == true)
{
string strComparisonOpUpdUser = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.UpdUser, objAssociationMappingCond.UpdUser, strComparisonOpUpdUser);
}
if (objAssociationMappingCond.IsUpdated(conAssociationMapping.Memo) == true)
{
string strComparisonOpMemo = objAssociationMappingCond.dicFldComparisonOp[conAssociationMapping.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAssociationMapping.Memo, objAssociationMappingCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--AssociationMapping(关联关系映射), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AssociationMappingName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objAssociationMappingEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsAssociationMappingEN objAssociationMappingEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objAssociationMappingEN == null) return true;
if (objAssociationMappingEN.AssociationMappingId == null || objAssociationMappingEN.AssociationMappingId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objAssociationMappingEN.AssociationMappingName == null)
{
 sbCondition.AppendFormat(" and AssociationMappingName is null", objAssociationMappingEN.AssociationMappingName);
}
else
{
 sbCondition.AppendFormat(" and AssociationMappingName = '{0}'", objAssociationMappingEN.AssociationMappingName);
}
if (clsAssociationMappingBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AssociationMappingId !=  '{0}'", objAssociationMappingEN.AssociationMappingId);
 sbCondition.AppendFormat(" and AssociationMappingName = '{0}'", objAssociationMappingEN.AssociationMappingName);
if (clsAssociationMappingBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--AssociationMapping(关联关系映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AssociationMappingName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAssociationMappingEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsAssociationMappingEN objAssociationMappingEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAssociationMappingEN == null) return "";
if (objAssociationMappingEN.AssociationMappingId == null || objAssociationMappingEN.AssociationMappingId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objAssociationMappingEN.AssociationMappingName == null)
{
 sbCondition.AppendFormat(" and AssociationMappingName is null", objAssociationMappingEN.AssociationMappingName);
}
else
{
 sbCondition.AppendFormat(" and AssociationMappingName = '{0}'", objAssociationMappingEN.AssociationMappingName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AssociationMappingId !=  '{0}'", objAssociationMappingEN.AssociationMappingId);
 sbCondition.AppendFormat(" and AssociationMappingName = '{0}'", objAssociationMappingEN.AssociationMappingName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_AssociationMapping
{
public virtual bool UpdRelaTabDate(string strAssociationMappingId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumAssociationMapping
{
 /// <summary>
 /// 一对一
 /// </summary>
public const string OneToOne_01 = "01";
 /// <summary>
 /// 一对多
 /// </summary>
public const string OneToMany_02 = "02";
}
 /// <summary>
 /// 关联关系映射(AssociationMapping)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAssociationMappingBL
{
public static RelatedActions_AssociationMapping relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAssociationMappingDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAssociationMappingDA AssociationMappingDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAssociationMappingDA();
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
 public clsAssociationMappingBL()
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
if (string.IsNullOrEmpty(clsAssociationMappingEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAssociationMappingEN._ConnectString);
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
public static DataTable GetDataTable_AssociationMapping(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AssociationMappingDA.GetDataTable_AssociationMapping(strWhereCond);
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
objDT = AssociationMappingDA.GetDataTable(strWhereCond);
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
objDT = AssociationMappingDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AssociationMappingDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AssociationMappingDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AssociationMappingDA.GetDataTable_Top(objTopPara);
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
objDT = AssociationMappingDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AssociationMappingDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AssociationMappingDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAssociationMappingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsAssociationMappingEN> GetObjLstByAssociationMappingIdLst(List<string> arrAssociationMappingIdLst)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAssociationMappingIdLst, true);
 string strWhereCond = string.Format("AssociationMappingId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAssociationMappingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAssociationMappingEN> GetObjLstByAssociationMappingIdLstCache(List<string> arrAssociationMappingIdLst)
{
string strKey = string.Format("{0}", clsAssociationMappingEN._CurrTabName);
List<clsAssociationMappingEN> arrAssociationMappingObjLstCache = GetObjLstCache();
IEnumerable <clsAssociationMappingEN> arrAssociationMappingObjLst_Sel =
arrAssociationMappingObjLstCache
.Where(x => arrAssociationMappingIdLst.Contains(x.AssociationMappingId));
return arrAssociationMappingObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAssociationMappingEN> GetObjLst(string strWhereCond)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
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
public static List<clsAssociationMappingEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAssociationMappingCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAssociationMappingEN> GetSubObjLstCache(clsAssociationMappingEN objAssociationMappingCond)
{
List<clsAssociationMappingEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAssociationMappingEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAssociationMapping._AttributeName)
{
if (objAssociationMappingCond.IsUpdated(strFldName) == false) continue;
if (objAssociationMappingCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAssociationMappingCond[strFldName].ToString());
}
else
{
if (objAssociationMappingCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAssociationMappingCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAssociationMappingCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAssociationMappingCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAssociationMappingCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAssociationMappingCond[strFldName]));
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
public static List<clsAssociationMappingEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
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
public static List<clsAssociationMappingEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
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
List<clsAssociationMappingEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAssociationMappingEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAssociationMappingEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAssociationMappingEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
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
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
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
public static List<clsAssociationMappingEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAssociationMappingEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAssociationMappingEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
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
public static List<clsAssociationMappingEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAssociationMappingEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAssociationMappingEN> arrObjLst = new List<clsAssociationMappingEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN();
try
{
objAssociationMappingEN.AssociationMappingId = objRow[conAssociationMapping.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objAssociationMappingEN.AssociationMappingName = objRow[conAssociationMapping.AssociationMappingName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingName].ToString().Trim(); //关联关系映射名
objAssociationMappingEN.AssociationMappingENName = objRow[conAssociationMapping.AssociationMappingENName] == DBNull.Value ? null : objRow[conAssociationMapping.AssociationMappingENName].ToString().Trim(); //关联关系映射英文名
objAssociationMappingEN.UpdDate = objRow[conAssociationMapping.UpdDate] == DBNull.Value ? null : objRow[conAssociationMapping.UpdDate].ToString().Trim(); //修改日期
objAssociationMappingEN.UpdUser = objRow[conAssociationMapping.UpdUser] == DBNull.Value ? null : objRow[conAssociationMapping.UpdUser].ToString().Trim(); //修改者
objAssociationMappingEN.Memo = objRow[conAssociationMapping.Memo] == DBNull.Value ? null : objRow[conAssociationMapping.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAssociationMappingEN.AssociationMappingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAssociationMappingEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAssociationMappingEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAssociationMapping(ref clsAssociationMappingEN objAssociationMappingEN)
{
bool bolResult = AssociationMappingDA.GetAssociationMapping(ref objAssociationMappingEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strAssociationMappingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAssociationMappingEN GetObjByAssociationMappingId(string strAssociationMappingId)
{
if (strAssociationMappingId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strAssociationMappingId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strAssociationMappingId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strAssociationMappingId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsAssociationMappingEN objAssociationMappingEN = AssociationMappingDA.GetObjByAssociationMappingId(strAssociationMappingId);
return objAssociationMappingEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAssociationMappingEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAssociationMappingEN objAssociationMappingEN = AssociationMappingDA.GetFirstObj(strWhereCond);
 return objAssociationMappingEN;
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
public static clsAssociationMappingEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAssociationMappingEN objAssociationMappingEN = AssociationMappingDA.GetObjByDataRow(objRow);
 return objAssociationMappingEN;
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
public static clsAssociationMappingEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAssociationMappingEN objAssociationMappingEN = AssociationMappingDA.GetObjByDataRow(objRow);
 return objAssociationMappingEN;
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
 /// <param name = "strAssociationMappingId">所给的关键字</param>
 /// <param name = "lstAssociationMappingObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAssociationMappingEN GetObjByAssociationMappingIdFromList(string strAssociationMappingId, List<clsAssociationMappingEN> lstAssociationMappingObjLst)
{
foreach (clsAssociationMappingEN objAssociationMappingEN in lstAssociationMappingObjLst)
{
if (objAssociationMappingEN.AssociationMappingId == strAssociationMappingId)
{
return objAssociationMappingEN;
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
 string strMaxAssociationMappingId;
 try
 {
 strMaxAssociationMappingId = clsAssociationMappingDA.GetMaxStrId();
 return strMaxAssociationMappingId;
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
 string strAssociationMappingId;
 try
 {
 strAssociationMappingId = new clsAssociationMappingDA().GetFirstID(strWhereCond);
 return strAssociationMappingId;
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
 arrList = AssociationMappingDA.GetID(strWhereCond);
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
bool bolIsExist = AssociationMappingDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strAssociationMappingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strAssociationMappingId)
{
if (string.IsNullOrEmpty(strAssociationMappingId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strAssociationMappingId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = AssociationMappingDA.IsExist(strAssociationMappingId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strAssociationMappingId">关联关系映射Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strAssociationMappingId, string strOpUser)
{
clsAssociationMappingEN objAssociationMappingEN = clsAssociationMappingBL.GetObjByAssociationMappingId(strAssociationMappingId);
objAssociationMappingEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objAssociationMappingEN.UpdUser = strOpUser;
return clsAssociationMappingBL.UpdateBySql2(objAssociationMappingEN);
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
 bolIsExist = clsAssociationMappingDA.IsExistTable();
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
 bolIsExist = AssociationMappingDA.IsExistTable(strTabName);
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAssociationMappingEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!关联关系映射名 = [{0}]的数据已经存在!(in clsAssociationMappingBL.AddNewRecordBySql2)", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
bool bolResult = AssociationMappingDA.AddNewRecordBySQL2(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAssociationMappingEN objAssociationMappingEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAssociationMappingEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!关联关系映射名 = [{0}]的数据已经存在!(in clsAssociationMappingBL.AddNewRecordBySql2WithReturnKey)", objAssociationMappingEN.AssociationMappingName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true || clsAssociationMappingBL.IsExist(objAssociationMappingEN.AssociationMappingId) == true)
 {
     objAssociationMappingEN.AssociationMappingId = clsAssociationMappingBL.GetMaxStrId_S();
 }
string strKey = AssociationMappingDA.AddNewRecordBySQL2WithReturnKey(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAssociationMappingEN objAssociationMappingEN)
{
try
{
bool bolResult = AssociationMappingDA.Update(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "objAssociationMappingEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAssociationMappingEN objAssociationMappingEN)
{
 if (string.IsNullOrEmpty(objAssociationMappingEN.AssociationMappingId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AssociationMappingDA.UpdateBySql2(objAssociationMappingEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAssociationMappingBL.ReFreshCache();

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
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
 /// <param name = "strAssociationMappingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strAssociationMappingId)
{
try
{
 clsAssociationMappingEN objAssociationMappingEN = clsAssociationMappingBL.GetObjByAssociationMappingId(strAssociationMappingId);

if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(objAssociationMappingEN.AssociationMappingId, objAssociationMappingEN.UpdUser);
}
if (objAssociationMappingEN != null)
{
int intRecNum = AssociationMappingDA.DelRecord(strAssociationMappingId);
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
/// <param name="strAssociationMappingId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strAssociationMappingId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAssociationMappingDA.GetSpecSQLObj();
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
//删除与表:[AssociationMapping]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAssociationMapping.AssociationMappingId,
//strAssociationMappingId);
//        clsAssociationMappingBL.DelAssociationMappingsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAssociationMappingBL.DelRecord(strAssociationMappingId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAssociationMappingBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAssociationMappingId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strAssociationMappingId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strAssociationMappingId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsAssociationMappingBL.relatedActions != null)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(strAssociationMappingId, "UpdRelaTabDate");
}
bool bolResult = AssociationMappingDA.DelRecord(strAssociationMappingId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrAssociationMappingIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelAssociationMappings(List<string> arrAssociationMappingIdLst)
{
if (arrAssociationMappingIdLst.Count == 0) return 0;
try
{
if (clsAssociationMappingBL.relatedActions != null)
{
foreach (var strAssociationMappingId in arrAssociationMappingIdLst)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(strAssociationMappingId, "UpdRelaTabDate");
}
}
int intDelRecNum = AssociationMappingDA.DelAssociationMapping(arrAssociationMappingIdLst);
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
public static int DelAssociationMappingsByCond(string strWhereCond)
{
try
{
if (clsAssociationMappingBL.relatedActions != null)
{
List<string> arrAssociationMappingId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAssociationMappingId in arrAssociationMappingId)
{
clsAssociationMappingBL.relatedActions.UpdRelaTabDate(strAssociationMappingId, "UpdRelaTabDate");
}
}
int intRecNum = AssociationMappingDA.DelAssociationMapping(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[AssociationMapping]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strAssociationMappingId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strAssociationMappingId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAssociationMappingDA.GetSpecSQLObj();
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
//删除与表:[AssociationMapping]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAssociationMappingBL.DelRecord(strAssociationMappingId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAssociationMappingBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAssociationMappingId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objAssociationMappingENS">源对象</param>
 /// <param name = "objAssociationMappingENT">目标对象</param>
 public static void CopyTo(clsAssociationMappingEN objAssociationMappingENS, clsAssociationMappingEN objAssociationMappingENT)
{
try
{
objAssociationMappingENT.AssociationMappingId = objAssociationMappingENS.AssociationMappingId; //关联关系映射Id
objAssociationMappingENT.AssociationMappingName = objAssociationMappingENS.AssociationMappingName; //关联关系映射名
objAssociationMappingENT.AssociationMappingENName = objAssociationMappingENS.AssociationMappingENName; //关联关系映射英文名
objAssociationMappingENT.UpdDate = objAssociationMappingENS.UpdDate; //修改日期
objAssociationMappingENT.UpdUser = objAssociationMappingENS.UpdUser; //修改者
objAssociationMappingENT.Memo = objAssociationMappingENS.Memo; //说明
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
 /// <param name = "objAssociationMappingEN">源简化对象</param>
 public static void SetUpdFlag(clsAssociationMappingEN objAssociationMappingEN)
{
try
{
objAssociationMappingEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAssociationMappingEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAssociationMapping.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.AssociationMappingId = objAssociationMappingEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(conAssociationMapping.AssociationMappingName, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.AssociationMappingName = objAssociationMappingEN.AssociationMappingName == "[null]" ? null :  objAssociationMappingEN.AssociationMappingName; //关联关系映射名
}
if (arrFldSet.Contains(conAssociationMapping.AssociationMappingENName, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.AssociationMappingENName = objAssociationMappingEN.AssociationMappingENName == "[null]" ? null :  objAssociationMappingEN.AssociationMappingENName; //关联关系映射英文名
}
if (arrFldSet.Contains(conAssociationMapping.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.UpdDate = objAssociationMappingEN.UpdDate == "[null]" ? null :  objAssociationMappingEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conAssociationMapping.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.UpdUser = objAssociationMappingEN.UpdUser == "[null]" ? null :  objAssociationMappingEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conAssociationMapping.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAssociationMappingEN.Memo = objAssociationMappingEN.Memo == "[null]" ? null :  objAssociationMappingEN.Memo; //说明
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
 /// <param name = "objAssociationMappingEN">源简化对象</param>
 public static void AccessFldValueNull(clsAssociationMappingEN objAssociationMappingEN)
{
try
{
if (objAssociationMappingEN.AssociationMappingName == "[null]") objAssociationMappingEN.AssociationMappingName = null; //关联关系映射名
if (objAssociationMappingEN.AssociationMappingENName == "[null]") objAssociationMappingEN.AssociationMappingENName = null; //关联关系映射英文名
if (objAssociationMappingEN.UpdDate == "[null]") objAssociationMappingEN.UpdDate = null; //修改日期
if (objAssociationMappingEN.UpdUser == "[null]") objAssociationMappingEN.UpdUser = null; //修改者
if (objAssociationMappingEN.Memo == "[null]") objAssociationMappingEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsAssociationMappingEN objAssociationMappingEN)
{
 AssociationMappingDA.CheckPropertyNew(objAssociationMappingEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAssociationMappingEN objAssociationMappingEN)
{
 AssociationMappingDA.CheckProperty4Condition(objAssociationMappingEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_AssociationMappingId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conAssociationMapping.AssociationMappingId); 
List<clsAssociationMappingEN> arrObjLst = clsAssociationMappingBL.GetObjLst(strCondition).OrderBy(x=>x.AssociationMappingName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsAssociationMappingEN objAssociationMappingEN = new clsAssociationMappingEN()
{
AssociationMappingId = "0",
AssociationMappingName = "选[关联关系映射]..."
};
arrObjLst.Insert(0, objAssociationMappingEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conAssociationMapping.AssociationMappingId;
objComboBox.DisplayMember = conAssociationMapping.AssociationMappingName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_AssociationMappingId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[关联关系映射]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conAssociationMapping.AssociationMappingId); 
IEnumerable<clsAssociationMappingEN> arrObjLst = clsAssociationMappingBL.GetObjLst(strCondition).OrderBy(x=>x.AssociationMappingName);
objDDL.DataValueField = conAssociationMapping.AssociationMappingId;
objDDL.DataTextField = conAssociationMapping.AssociationMappingName;
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
public static void BindDdl_AssociationMappingIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[关联关系映射]...","0");
List<clsAssociationMappingEN> arrAssociationMappingObjLst = GetAllAssociationMappingObjLstCache(); 
objDDL.DataValueField = conAssociationMapping.AssociationMappingId;
objDDL.DataTextField = conAssociationMapping.AssociationMappingName;
objDDL.DataSource = arrAssociationMappingObjLst;
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
if (clsAssociationMappingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAssociationMappingBL没有刷新缓存机制(clsAssociationMappingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AssociationMappingId");
//if (arrAssociationMappingObjLstCache == null)
//{
//arrAssociationMappingObjLstCache = AssociationMappingDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strAssociationMappingId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAssociationMappingEN GetObjByAssociationMappingIdCache(string strAssociationMappingId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAssociationMappingEN._CurrTabName);
List<clsAssociationMappingEN> arrAssociationMappingObjLstCache = GetObjLstCache();
IEnumerable <clsAssociationMappingEN> arrAssociationMappingObjLst_Sel =
arrAssociationMappingObjLstCache
.Where(x=> x.AssociationMappingId == strAssociationMappingId 
);
if (arrAssociationMappingObjLst_Sel.Count() == 0)
{
   clsAssociationMappingEN obj = clsAssociationMappingBL.GetObjByAssociationMappingId(strAssociationMappingId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAssociationMappingObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strAssociationMappingId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAssociationMappingNameByAssociationMappingIdCache(string strAssociationMappingId)
{
if (string.IsNullOrEmpty(strAssociationMappingId) == true) return "";
//获取缓存中的对象列表
clsAssociationMappingEN objAssociationMapping = GetObjByAssociationMappingIdCache(strAssociationMappingId);
if (objAssociationMapping == null) return "";
return objAssociationMapping.AssociationMappingName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strAssociationMappingId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByAssociationMappingIdCache(string strAssociationMappingId)
{
if (string.IsNullOrEmpty(strAssociationMappingId) == true) return "";
//获取缓存中的对象列表
clsAssociationMappingEN objAssociationMapping = GetObjByAssociationMappingIdCache(strAssociationMappingId);
if (objAssociationMapping == null) return "";
return objAssociationMapping.AssociationMappingName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAssociationMappingEN> GetAllAssociationMappingObjLstCache()
{
//获取缓存中的对象列表
List<clsAssociationMappingEN> arrAssociationMappingObjLstCache = GetObjLstCache(); 
return arrAssociationMappingObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAssociationMappingEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAssociationMappingEN._CurrTabName);
List<clsAssociationMappingEN> arrAssociationMappingObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAssociationMappingObjLstCache;
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
string strKey = string.Format("{0}", clsAssociationMappingEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAssociationMappingEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAssociationMappingEN._RefreshTimeLst.Count == 0) return "";
return clsAssociationMappingEN._RefreshTimeLst[clsAssociationMappingEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsAssociationMappingBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAssociationMappingEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAssociationMappingEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAssociationMappingBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--AssociationMapping(关联关系映射)
 /// 唯一性条件:AssociationMappingName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAssociationMappingEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsAssociationMappingEN objAssociationMappingEN)
{
//检测记录是否存在
string strResult = AssociationMappingDA.GetUniCondStr(objAssociationMappingEN);
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
public static string Func(string strInFldName, string strOutFldName, string strAssociationMappingId)
{
if (strInFldName != conAssociationMapping.AssociationMappingId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAssociationMapping._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAssociationMapping._AttributeName));
throw new Exception(strMsg);
}
var objAssociationMapping = clsAssociationMappingBL.GetObjByAssociationMappingIdCache(strAssociationMappingId);
if (objAssociationMapping == null) return "";
return objAssociationMapping[strOutFldName].ToString();
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
int intRecCount = clsAssociationMappingDA.GetRecCount(strTabName);
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
int intRecCount = clsAssociationMappingDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAssociationMappingDA.GetRecCount();
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
int intRecCount = clsAssociationMappingDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAssociationMappingCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAssociationMappingEN objAssociationMappingCond)
{
List<clsAssociationMappingEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAssociationMappingEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAssociationMapping._AttributeName)
{
if (objAssociationMappingCond.IsUpdated(strFldName) == false) continue;
if (objAssociationMappingCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAssociationMappingCond[strFldName].ToString());
}
else
{
if (objAssociationMappingCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAssociationMappingCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAssociationMappingCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAssociationMappingCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAssociationMappingCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAssociationMappingCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAssociationMappingCond[strFldName]));
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
 List<string> arrList = clsAssociationMappingDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AssociationMappingDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AssociationMappingDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AssociationMappingDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAssociationMappingDA.SetFldValue(clsAssociationMappingEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = AssociationMappingDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAssociationMappingDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAssociationMappingDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAssociationMappingDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[AssociationMapping] "); 
 strCreateTabCode.Append(" ( "); 
 // /**关联关系映射Id*/ 
 strCreateTabCode.Append(" AssociationMappingId char(2) primary key, "); 
 // /**关联关系映射名*/ 
 strCreateTabCode.Append(" AssociationMappingName varchar(50) Null, "); 
 // /**关联关系映射英文名*/ 
 strCreateTabCode.Append(" AssociationMappingENName varchar(50) Null, "); 
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
 /// 关联关系映射(AssociationMapping)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4AssociationMapping : clsCommFun4BL
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
clsAssociationMappingBL.ReFreshThisCache();
}
}

}