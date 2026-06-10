
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupBL
 表名:CTCodeTypeGroup(00050648)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/06 11:43:51
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
public static class  clsCTCodeTypeGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCTCodeTypeGroupEN GetObj(this K_CtGroupId_CTCodeTypeGroup myKey)
{
clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.GetObjByCtGroupId(myKey.Value);
return objCTCodeTypeGroupEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCTCodeTypeGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],组名 = [{1}]的数据已经存在!(in clsCTCodeTypeGroupBL.AddNewRecord)", objCTCodeTypeGroupEN.ApplicationTypeId,objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
bool bolResult = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.AddNewRecordBySQL2(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
public static bool AddRecordEx(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCTCodeTypeGroupEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCTCodeTypeGroupEN.CheckUniqueness() == false)
{
strMsg = string.Format("(应用程序类型ID(ApplicationTypeId)=[{0}],组名(GroupName)=[{1}])已经存在,不能重复!", objCTCodeTypeGroupEN.ApplicationTypeId, objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCTCodeTypeGroupEN.AddNewRecord();
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCTCodeTypeGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],组名 = [{1}]的数据已经存在!(in clsCTCodeTypeGroupBL.AddNewRecordWithMaxId)", objCTCodeTypeGroupEN.ApplicationTypeId,objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
string strCtGroupId = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.AddNewRecordBySQL2WithReturnKey(objCTCodeTypeGroupEN);
     objCTCodeTypeGroupEN.CtGroupId = strCtGroupId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
}
return strCtGroupId;
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCTCodeTypeGroupEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],组名 = [{1}]的数据已经存在!(in clsCTCodeTypeGroupBL.AddNewRecordWithReturnKey)", objCTCodeTypeGroupEN.ApplicationTypeId,objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
string strKey = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.AddNewRecordBySQL2WithReturnKey(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetCtGroupId(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strCtGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtGroupId, 4, conCTCodeTypeGroup.CtGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtGroupId, 4, conCTCodeTypeGroup.CtGroupId);
}
objCTCodeTypeGroupEN.CtGroupId = strCtGroupId; //Ct组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.CtGroupId) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.CtGroupId, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.CtGroupId] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetApplicationTypeId(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCTCodeTypeGroup.ApplicationTypeId);
objCTCodeTypeGroupEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.ApplicationTypeId) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.ApplicationTypeId, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.ApplicationTypeId] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetGroupName(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, conCTCodeTypeGroup.GroupName);
}
objCTCodeTypeGroupEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.GroupName) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.GroupName, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.GroupName] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetGroupENName(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strGroupENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupENName, 100, conCTCodeTypeGroup.GroupENName);
}
objCTCodeTypeGroupEN.GroupENName = strGroupENName; //组英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.GroupENName) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.GroupENName, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.GroupENName] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetDescription(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDescription, 300, conCTCodeTypeGroup.Description);
}
objCTCodeTypeGroupEN.Description = strDescription; //描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.Description) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.Description, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.Description] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetOrderNum(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, int? intOrderNum, string strComparisonOp="")
	{
objCTCodeTypeGroupEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.OrderNum) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.OrderNum, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.OrderNum] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetInUse(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolInUse, string strComparisonOp="")
	{
objCTCodeTypeGroupEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.InUse) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.InUse, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.InUse] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetUpdDate(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCTCodeTypeGroup.UpdDate);
}
objCTCodeTypeGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.UpdDate) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.UpdDate, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.UpdDate] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCTCodeTypeGroupEN SetUpdUser(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCTCodeTypeGroup.UpdUser);
}
objCTCodeTypeGroupEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCTCodeTypeGroupEN.dicFldComparisonOp.ContainsKey(conCTCodeTypeGroup.UpdUser) == false)
{
objCTCodeTypeGroupEN.dicFldComparisonOp.Add(conCTCodeTypeGroup.UpdUser, strComparisonOp);
}
else
{
objCTCodeTypeGroupEN.dicFldComparisonOp[conCTCodeTypeGroup.UpdUser] = strComparisonOp;
}
}
return objCTCodeTypeGroupEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCTCodeTypeGroupEN.CheckPropertyNew();
clsCTCodeTypeGroupEN objCTCodeTypeGroupCond = new clsCTCodeTypeGroupEN();
string strCondition = objCTCodeTypeGroupCond
.SetCtGroupId(objCTCodeTypeGroupEN.CtGroupId, "<>")
.SetApplicationTypeId(objCTCodeTypeGroupEN.ApplicationTypeId, "=")
.SetGroupName(objCTCodeTypeGroupEN.GroupName, "=")
.GetCombineCondition();
objCTCodeTypeGroupEN._IsCheckProperty = true;
bool bolIsExist = clsCTCodeTypeGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCTCodeTypeGroupEN.Update();
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
 /// <param name = "objCTCodeTypeGroup">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCTCodeTypeGroupEN objCTCodeTypeGroup)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCTCodeTypeGroupEN objCTCodeTypeGroupCond = new clsCTCodeTypeGroupEN();
string strCondition = objCTCodeTypeGroupCond
.SetApplicationTypeId(objCTCodeTypeGroup.ApplicationTypeId, "=")
.SetGroupName(objCTCodeTypeGroup.GroupName, "=")
.GetCombineCondition();
objCTCodeTypeGroup._IsCheckProperty = true;
bool bolIsExist = clsCTCodeTypeGroupBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCTCodeTypeGroup.CtGroupId = clsCTCodeTypeGroupBL.GetFirstID_S(strCondition);
objCTCodeTypeGroup.UpdateWithCondition(strCondition);
}
else
{
objCTCodeTypeGroup.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
objCTCodeTypeGroup.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.UpdateBySql2(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.UpdateBySql2(objCTCodeTypeGroupEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strWhereCond)
{
try
{
bool bolResult = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.UpdateBySqlWithCondition(objCTCodeTypeGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.UpdateBySqlWithConditionTransaction(objCTCodeTypeGroupEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
try
{
int intRecNum = clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.DelRecord(objCTCodeTypeGroupEN.CtGroupId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupENT">目标对象</param>
 public static void CopyTo(this clsCTCodeTypeGroupEN objCTCodeTypeGroupENS, clsCTCodeTypeGroupEN objCTCodeTypeGroupENT)
{
try
{
objCTCodeTypeGroupENT.CtGroupId = objCTCodeTypeGroupENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupENT.ApplicationTypeId = objCTCodeTypeGroupENS.ApplicationTypeId; //应用程序类型ID
objCTCodeTypeGroupENT.GroupName = objCTCodeTypeGroupENS.GroupName; //组名
objCTCodeTypeGroupENT.GroupENName = objCTCodeTypeGroupENS.GroupENName; //组英文名
objCTCodeTypeGroupENT.Description = objCTCodeTypeGroupENS.Description; //描述
objCTCodeTypeGroupENT.OrderNum = objCTCodeTypeGroupENS.OrderNum; //序号
objCTCodeTypeGroupENT.InUse = objCTCodeTypeGroupENS.InUse; //是否在用
objCTCodeTypeGroupENT.UpdDate = objCTCodeTypeGroupENS.UpdDate; //修改日期
objCTCodeTypeGroupENT.UpdUser = objCTCodeTypeGroupENS.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupENS">源对象</param>
 /// <returns>目标对象=>clsCTCodeTypeGroupEN:objCTCodeTypeGroupENT</returns>
 public static clsCTCodeTypeGroupEN CopyTo(this clsCTCodeTypeGroupEN objCTCodeTypeGroupENS)
{
try
{
 clsCTCodeTypeGroupEN objCTCodeTypeGroupENT = new clsCTCodeTypeGroupEN()
{
CtGroupId = objCTCodeTypeGroupENS.CtGroupId, //Ct组Id
ApplicationTypeId = objCTCodeTypeGroupENS.ApplicationTypeId, //应用程序类型ID
GroupName = objCTCodeTypeGroupENS.GroupName, //组名
GroupENName = objCTCodeTypeGroupENS.GroupENName, //组英文名
Description = objCTCodeTypeGroupENS.Description, //描述
OrderNum = objCTCodeTypeGroupENS.OrderNum, //序号
InUse = objCTCodeTypeGroupENS.InUse, //是否在用
UpdDate = objCTCodeTypeGroupENS.UpdDate, //修改日期
UpdUser = objCTCodeTypeGroupENS.UpdUser, //修改者
};
 return objCTCodeTypeGroupENT;
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
public static void CheckPropertyNew(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.CheckPropertyNew(objCTCodeTypeGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 clsCTCodeTypeGroupBL.CTCodeTypeGroupDA.CheckProperty4Condition(objCTCodeTypeGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCTCodeTypeGroupEN objCTCodeTypeGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.CtGroupId) == true)
{
string strComparisonOpCtGroupId = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.CtGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.CtGroupId, objCTCodeTypeGroupCond.CtGroupId, strComparisonOpCtGroupId);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroup.ApplicationTypeId, objCTCodeTypeGroupCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.GroupName) == true)
{
string strComparisonOpGroupName = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.GroupName, objCTCodeTypeGroupCond.GroupName, strComparisonOpGroupName);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.GroupENName) == true)
{
string strComparisonOpGroupENName = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.GroupENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.GroupENName, objCTCodeTypeGroupCond.GroupENName, strComparisonOpGroupENName);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.Description) == true)
{
string strComparisonOpDescription = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.Description];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.Description, objCTCodeTypeGroupCond.Description, strComparisonOpDescription);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.OrderNum) == true)
{
string strComparisonOpOrderNum = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCTCodeTypeGroup.OrderNum, objCTCodeTypeGroupCond.OrderNum, strComparisonOpOrderNum);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.InUse) == true)
{
if (objCTCodeTypeGroupCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCTCodeTypeGroup.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCTCodeTypeGroup.InUse);
}
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.UpdDate, objCTCodeTypeGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objCTCodeTypeGroupCond.IsUpdated(conCTCodeTypeGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objCTCodeTypeGroupCond.dicFldComparisonOp[conCTCodeTypeGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCTCodeTypeGroup.UpdUser, objCTCodeTypeGroupCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CTCodeTypeGroup(CTCodeTypeGroup), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeId_GroupName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCTCodeTypeGroupEN == null) return true;
if (objCTCodeTypeGroupEN.CtGroupId == null || objCTCodeTypeGroupEN.CtGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCTCodeTypeGroupEN.ApplicationTypeId);
 if (objCTCodeTypeGroupEN.GroupName == null)
{
 sbCondition.AppendFormat(" and GroupName is null", objCTCodeTypeGroupEN.GroupName);
}
else
{
 sbCondition.AppendFormat(" and GroupName = '{0}'", objCTCodeTypeGroupEN.GroupName);
}
if (clsCTCodeTypeGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CtGroupId !=  '{0}'", objCTCodeTypeGroupEN.CtGroupId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCTCodeTypeGroupEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and GroupName = '{0}'", objCTCodeTypeGroupEN.GroupName);
if (clsCTCodeTypeGroupBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CTCodeTypeGroup(CTCodeTypeGroup), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_GroupName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCTCodeTypeGroupEN == null) return "";
if (objCTCodeTypeGroupEN.CtGroupId == null || objCTCodeTypeGroupEN.CtGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCTCodeTypeGroupEN.ApplicationTypeId);
 if (objCTCodeTypeGroupEN.GroupName == null)
{
 sbCondition.AppendFormat(" and GroupName is null", objCTCodeTypeGroupEN.GroupName);
}
else
{
 sbCondition.AppendFormat(" and GroupName = '{0}'", objCTCodeTypeGroupEN.GroupName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CtGroupId !=  '{0}'", objCTCodeTypeGroupEN.CtGroupId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCTCodeTypeGroupEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and GroupName = '{0}'", objCTCodeTypeGroupEN.GroupName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CTCodeTypeGroup
{
public virtual bool UpdRelaTabDate(string strCtGroupId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CTCodeTypeGroup(CTCodeTypeGroup)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCTCodeTypeGroupBL
{
public static RelatedActions_CTCodeTypeGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCTCodeTypeGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCTCodeTypeGroupDA CTCodeTypeGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCTCodeTypeGroupDA();
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
 public clsCTCodeTypeGroupBL()
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
if (string.IsNullOrEmpty(clsCTCodeTypeGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupEN._ConnectString);
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
public static DataTable GetDataTable_CTCodeTypeGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CTCodeTypeGroupDA.GetDataTable_CTCodeTypeGroup(strWhereCond);
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
objDT = CTCodeTypeGroupDA.GetDataTable(strWhereCond);
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
objDT = CTCodeTypeGroupDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CTCodeTypeGroupDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CTCodeTypeGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CTCodeTypeGroupDA.GetDataTable_Top(objTopPara);
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
objDT = CTCodeTypeGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CTCodeTypeGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CTCodeTypeGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCtGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetObjLstByCtGroupIdLst(List<string> arrCtGroupIdLst)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCtGroupIdLst, true);
 string strWhereCond = string.Format("CtGroupId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCtGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCTCodeTypeGroupEN> GetObjLstByCtGroupIdLstCache(List<string> arrCtGroupIdLst)
{
string strKey = string.Format("{0}", clsCTCodeTypeGroupEN._CurrTabName);
List<clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLst_Sel =
arrCTCodeTypeGroupObjLstCache
.Where(x => arrCtGroupIdLst.Contains(x.CtGroupId));
return arrCTCodeTypeGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetObjLst(string strWhereCond)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
public static List<clsCTCodeTypeGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCTCodeTypeGroupEN> GetSubObjLstCache(clsCTCodeTypeGroupEN objCTCodeTypeGroupCond)
{
List<clsCTCodeTypeGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTCodeTypeGroup._AttributeName)
{
if (objCTCodeTypeGroupCond.IsUpdated(strFldName) == false) continue;
if (objCTCodeTypeGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupCond[strFldName].ToString());
}
else
{
if (objCTCodeTypeGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTCodeTypeGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTCodeTypeGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupCond[strFldName]));
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
public static List<clsCTCodeTypeGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
public static List<clsCTCodeTypeGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
List<clsCTCodeTypeGroupEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCTCodeTypeGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCTCodeTypeGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
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
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
public static List<clsCTCodeTypeGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCTCodeTypeGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
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
public static List<clsCTCodeTypeGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCTCodeTypeGroupEN> arrObjLst = new List<clsCTCodeTypeGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = new clsCTCodeTypeGroupEN();
try
{
objCTCodeTypeGroupEN.CtGroupId = objRow[conCTCodeTypeGroup.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupEN.ApplicationTypeId = Int32.Parse(objRow[conCTCodeTypeGroup.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCTCodeTypeGroupEN.GroupName = objRow[conCTCodeTypeGroup.GroupName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupName].ToString().Trim(); //组名
objCTCodeTypeGroupEN.GroupENName = objRow[conCTCodeTypeGroup.GroupENName] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.GroupENName].ToString().Trim(); //组英文名
objCTCodeTypeGroupEN.Description = objRow[conCTCodeTypeGroup.Description] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.Description].ToString().Trim(); //描述
objCTCodeTypeGroupEN.OrderNum = objRow[conCTCodeTypeGroup.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroup.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroup.InUse].ToString().Trim()); //是否在用
objCTCodeTypeGroupEN.UpdDate = objRow[conCTCodeTypeGroup.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupEN.UpdUser = objRow[conCTCodeTypeGroup.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroup.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCTCodeTypeGroupEN.CtGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCTCodeTypeGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCTCodeTypeGroup(ref clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
bool bolResult = CTCodeTypeGroupDA.GetCTCodeTypeGroup(ref objCTCodeTypeGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCTCodeTypeGroupEN GetObjByCtGroupId(string strCtGroupId)
{
if (strCtGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCtGroupId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCtGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCtGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = CTCodeTypeGroupDA.GetObjByCtGroupId(strCtGroupId);
return objCTCodeTypeGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCTCodeTypeGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = CTCodeTypeGroupDA.GetFirstObj(strWhereCond);
 return objCTCodeTypeGroupEN;
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
public static clsCTCodeTypeGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = CTCodeTypeGroupDA.GetObjByDataRow(objRow);
 return objCTCodeTypeGroupEN;
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
public static clsCTCodeTypeGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = CTCodeTypeGroupDA.GetObjByDataRow(objRow);
 return objCTCodeTypeGroupEN;
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
 /// <param name = "strCtGroupId">所给的关键字</param>
 /// <param name = "lstCTCodeTypeGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTCodeTypeGroupEN GetObjByCtGroupIdFromList(string strCtGroupId, List<clsCTCodeTypeGroupEN> lstCTCodeTypeGroupObjLst)
{
foreach (clsCTCodeTypeGroupEN objCTCodeTypeGroupEN in lstCTCodeTypeGroupObjLst)
{
if (objCTCodeTypeGroupEN.CtGroupId == strCtGroupId)
{
return objCTCodeTypeGroupEN;
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
 string strMaxCtGroupId;
 try
 {
 strMaxCtGroupId = clsCTCodeTypeGroupDA.GetMaxStrId();
 return strMaxCtGroupId;
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
 string strCtGroupId;
 try
 {
 strCtGroupId = new clsCTCodeTypeGroupDA().GetFirstID(strWhereCond);
 return strCtGroupId;
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
 arrList = CTCodeTypeGroupDA.GetID(strWhereCond);
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
bool bolIsExist = CTCodeTypeGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCtGroupId)
{
if (string.IsNullOrEmpty(strCtGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCtGroupId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CTCodeTypeGroupDA.IsExist(strCtGroupId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCtGroupId">Ct组Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCtGroupId, string strOpUser)
{
clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = clsCTCodeTypeGroupBL.GetObjByCtGroupId(strCtGroupId);
objCTCodeTypeGroupEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCTCodeTypeGroupEN.UpdUser = strOpUser;
return clsCTCodeTypeGroupBL.UpdateBySql2(objCTCodeTypeGroupEN);
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
 bolIsExist = clsCTCodeTypeGroupDA.IsExistTable();
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
 bolIsExist = CTCodeTypeGroupDA.IsExistTable(strTabName);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCTCodeTypeGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],组名 = [{1}]的数据已经存在!(in clsCTCodeTypeGroupBL.AddNewRecordBySql2)", objCTCodeTypeGroupEN.ApplicationTypeId,objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
bool bolResult = CTCodeTypeGroupDA.AddNewRecordBySQL2(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCTCodeTypeGroupEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],组名 = [{1}]的数据已经存在!(in clsCTCodeTypeGroupBL.AddNewRecordBySql2WithReturnKey)", objCTCodeTypeGroupEN.ApplicationTypeId,objCTCodeTypeGroupEN.GroupName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true || clsCTCodeTypeGroupBL.IsExist(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
     objCTCodeTypeGroupEN.CtGroupId = clsCTCodeTypeGroupBL.GetMaxStrId_S();
 }
string strKey = CTCodeTypeGroupDA.AddNewRecordBySQL2WithReturnKey(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
try
{
bool bolResult = CTCodeTypeGroupDA.Update(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "objCTCodeTypeGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 if (string.IsNullOrEmpty(objCTCodeTypeGroupEN.CtGroupId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CTCodeTypeGroupDA.UpdateBySql2(objCTCodeTypeGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCTCodeTypeGroupBL.ReFreshCache();

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCtGroupId)
{
try
{
 clsCTCodeTypeGroupEN objCTCodeTypeGroupEN = clsCTCodeTypeGroupBL.GetObjByCtGroupId(strCtGroupId);

if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(objCTCodeTypeGroupEN.CtGroupId, objCTCodeTypeGroupEN.UpdUser);
}
if (objCTCodeTypeGroupEN != null)
{
int intRecNum = CTCodeTypeGroupDA.DelRecord(strCtGroupId);
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
/// <param name="strCtGroupId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCtGroupId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
//删除与表:[CTCodeTypeGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCTCodeTypeGroup.CtGroupId,
//strCtGroupId);
//        clsCTCodeTypeGroupBL.DelCTCodeTypeGroupsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTCodeTypeGroupBL.DelRecord(strCtGroupId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTCodeTypeGroupBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCtGroupId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCTCodeTypeGroupBL.relatedActions != null)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(strCtGroupId, "UpdRelaTabDate");
}
bool bolResult = CTCodeTypeGroupDA.DelRecord(strCtGroupId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCtGroupIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCTCodeTypeGroups(List<string> arrCtGroupIdLst)
{
if (arrCtGroupIdLst.Count == 0) return 0;
try
{
if (clsCTCodeTypeGroupBL.relatedActions != null)
{
foreach (var strCtGroupId in arrCtGroupIdLst)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(strCtGroupId, "UpdRelaTabDate");
}
}
int intDelRecNum = CTCodeTypeGroupDA.DelCTCodeTypeGroup(arrCtGroupIdLst);
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
public static int DelCTCodeTypeGroupsByCond(string strWhereCond)
{
try
{
if (clsCTCodeTypeGroupBL.relatedActions != null)
{
List<string> arrCtGroupId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCtGroupId in arrCtGroupId)
{
clsCTCodeTypeGroupBL.relatedActions.UpdRelaTabDate(strCtGroupId, "UpdRelaTabDate");
}
}
int intRecNum = CTCodeTypeGroupDA.DelCTCodeTypeGroup(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CTCodeTypeGroup]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCtGroupId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCtGroupId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCTCodeTypeGroupDA.GetSpecSQLObj();
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
//删除与表:[CTCodeTypeGroup]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCTCodeTypeGroupBL.DelRecord(strCtGroupId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCTCodeTypeGroupBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCtGroupId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCTCodeTypeGroupENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupENT">目标对象</param>
 public static void CopyTo(clsCTCodeTypeGroupEN objCTCodeTypeGroupENS, clsCTCodeTypeGroupEN objCTCodeTypeGroupENT)
{
try
{
objCTCodeTypeGroupENT.CtGroupId = objCTCodeTypeGroupENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupENT.ApplicationTypeId = objCTCodeTypeGroupENS.ApplicationTypeId; //应用程序类型ID
objCTCodeTypeGroupENT.GroupName = objCTCodeTypeGroupENS.GroupName; //组名
objCTCodeTypeGroupENT.GroupENName = objCTCodeTypeGroupENS.GroupENName; //组英文名
objCTCodeTypeGroupENT.Description = objCTCodeTypeGroupENS.Description; //描述
objCTCodeTypeGroupENT.OrderNum = objCTCodeTypeGroupENS.OrderNum; //序号
objCTCodeTypeGroupENT.InUse = objCTCodeTypeGroupENS.InUse; //是否在用
objCTCodeTypeGroupENT.UpdDate = objCTCodeTypeGroupENS.UpdDate; //修改日期
objCTCodeTypeGroupENT.UpdUser = objCTCodeTypeGroupENS.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
try
{
objCTCodeTypeGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCTCodeTypeGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCTCodeTypeGroup.CtGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.CtGroupId = objCTCodeTypeGroupEN.CtGroupId; //Ct组Id
}
if (arrFldSet.Contains(conCTCodeTypeGroup.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.ApplicationTypeId = objCTCodeTypeGroupEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conCTCodeTypeGroup.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.GroupName = objCTCodeTypeGroupEN.GroupName == "[null]" ? null :  objCTCodeTypeGroupEN.GroupName; //组名
}
if (arrFldSet.Contains(conCTCodeTypeGroup.GroupENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.GroupENName = objCTCodeTypeGroupEN.GroupENName == "[null]" ? null :  objCTCodeTypeGroupEN.GroupENName; //组英文名
}
if (arrFldSet.Contains(conCTCodeTypeGroup.Description, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.Description = objCTCodeTypeGroupEN.Description == "[null]" ? null :  objCTCodeTypeGroupEN.Description; //描述
}
if (arrFldSet.Contains(conCTCodeTypeGroup.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.OrderNum = objCTCodeTypeGroupEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCTCodeTypeGroup.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.InUse = objCTCodeTypeGroupEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCTCodeTypeGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.UpdDate = objCTCodeTypeGroupEN.UpdDate == "[null]" ? null :  objCTCodeTypeGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCTCodeTypeGroup.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCTCodeTypeGroupEN.UpdUser = objCTCodeTypeGroupEN.UpdUser == "[null]" ? null :  objCTCodeTypeGroupEN.UpdUser; //修改者
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
 /// <param name = "objCTCodeTypeGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
try
{
if (objCTCodeTypeGroupEN.GroupName == "[null]") objCTCodeTypeGroupEN.GroupName = null; //组名
if (objCTCodeTypeGroupEN.GroupENName == "[null]") objCTCodeTypeGroupEN.GroupENName = null; //组英文名
if (objCTCodeTypeGroupEN.Description == "[null]") objCTCodeTypeGroupEN.Description = null; //描述
if (objCTCodeTypeGroupEN.UpdDate == "[null]") objCTCodeTypeGroupEN.UpdDate = null; //修改日期
if (objCTCodeTypeGroupEN.UpdUser == "[null]") objCTCodeTypeGroupEN.UpdUser = null; //修改者
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
public static void CheckPropertyNew(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 CTCodeTypeGroupDA.CheckPropertyNew(objCTCodeTypeGroupEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
 CTCodeTypeGroupDA.CheckProperty4Condition(objCTCodeTypeGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CtGroupIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CTCodeTypeGroup]...","0");
List<clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLst = GetAllCTCodeTypeGroupObjLstCache(); 
arrCTCodeTypeGroupObjLst = arrCTCodeTypeGroupObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conCTCodeTypeGroup.CtGroupId;
objDDL.DataTextField = conCTCodeTypeGroup.GroupName;
objDDL.DataSource = arrCTCodeTypeGroupObjLst;
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
if (clsCTCodeTypeGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCTCodeTypeGroupBL没有刷新缓存机制(clsCTCodeTypeGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CtGroupId");
//if (arrCTCodeTypeGroupObjLstCache == null)
//{
//arrCTCodeTypeGroupObjLstCache = CTCodeTypeGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCtGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCTCodeTypeGroupEN GetObjByCtGroupIdCache(string strCtGroupId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCTCodeTypeGroupEN._CurrTabName);
List<clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLst_Sel =
arrCTCodeTypeGroupObjLstCache
.Where(x=> x.CtGroupId == strCtGroupId 
);
if (arrCTCodeTypeGroupObjLst_Sel.Count() == 0)
{
   clsCTCodeTypeGroupEN obj = clsCTCodeTypeGroupBL.GetObjByCtGroupId(strCtGroupId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCTCodeTypeGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGroupNameByCtGroupIdCache(string strCtGroupId)
{
if (string.IsNullOrEmpty(strCtGroupId) == true) return "";
//获取缓存中的对象列表
clsCTCodeTypeGroupEN objCTCodeTypeGroup = GetObjByCtGroupIdCache(strCtGroupId);
if (objCTCodeTypeGroup == null) return "";
return objCTCodeTypeGroup.GroupName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCtGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCtGroupIdCache(string strCtGroupId)
{
if (string.IsNullOrEmpty(strCtGroupId) == true) return "";
//获取缓存中的对象列表
clsCTCodeTypeGroupEN objCTCodeTypeGroup = GetObjByCtGroupIdCache(strCtGroupId);
if (objCTCodeTypeGroup == null) return "";
return objCTCodeTypeGroup.GroupName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetAllCTCodeTypeGroupObjLstCache()
{
//获取缓存中的对象列表
List<clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLstCache = GetObjLstCache(); 
return arrCTCodeTypeGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCTCodeTypeGroupEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCTCodeTypeGroupEN._CurrTabName);
List<clsCTCodeTypeGroupEN> arrCTCodeTypeGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCTCodeTypeGroupObjLstCache;
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
string strKey = string.Format("{0}", clsCTCodeTypeGroupEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTCodeTypeGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCTCodeTypeGroupEN._RefreshTimeLst.Count == 0) return "";
return clsCTCodeTypeGroupEN._RefreshTimeLst[clsCTCodeTypeGroupEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCTCodeTypeGroupBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCTCodeTypeGroupEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCTCodeTypeGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCTCodeTypeGroupBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CTCodeTypeGroup(CTCodeTypeGroup)
 /// 唯一性条件:ApplicationTypeId_GroupName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCTCodeTypeGroupEN objCTCodeTypeGroupEN)
{
//检测记录是否存在
string strResult = CTCodeTypeGroupDA.GetUniCondStr(objCTCodeTypeGroupEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-06-06
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCtGroupId)
{
if (strInFldName != conCTCodeTypeGroup.CtGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCTCodeTypeGroup._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCTCodeTypeGroup._AttributeName));
throw new Exception(strMsg);
}
var objCTCodeTypeGroup = clsCTCodeTypeGroupBL.GetObjByCtGroupIdCache(strCtGroupId);
if (objCTCodeTypeGroup == null) return "";
return objCTCodeTypeGroup[strOutFldName].ToString();
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
int intRecCount = clsCTCodeTypeGroupDA.GetRecCount(strTabName);
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
int intRecCount = clsCTCodeTypeGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCTCodeTypeGroupDA.GetRecCount();
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
int intRecCount = clsCTCodeTypeGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCTCodeTypeGroupEN objCTCodeTypeGroupCond)
{
List<clsCTCodeTypeGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCTCodeTypeGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCTCodeTypeGroup._AttributeName)
{
if (objCTCodeTypeGroupCond.IsUpdated(strFldName) == false) continue;
if (objCTCodeTypeGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupCond[strFldName].ToString());
}
else
{
if (objCTCodeTypeGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCTCodeTypeGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCTCodeTypeGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCTCodeTypeGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCTCodeTypeGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCTCodeTypeGroupCond[strFldName]));
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
 List<string> arrList = clsCTCodeTypeGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CTCodeTypeGroupDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CTCodeTypeGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CTCodeTypeGroupDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupDA.SetFldValue(clsCTCodeTypeGroupEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CTCodeTypeGroupDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCTCodeTypeGroupDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CTCodeTypeGroup] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Ct组Id*/ 
 strCreateTabCode.Append(" CtGroupId char(4) primary key, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**组英文名*/ 
 strCreateTabCode.Append(" GroupENName varchar(100) Null, "); 
 // /**描述*/ 
 strCreateTabCode.Append(" Description varchar(300) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CTCodeTypeGroup(CTCodeTypeGroup)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CTCodeTypeGroup : clsCommFun4BL
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
clsCTCodeTypeGroupBL.ReFreshThisCache();
}
}

}