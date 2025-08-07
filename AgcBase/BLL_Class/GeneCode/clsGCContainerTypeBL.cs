
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCContainerTypeBL
 表名:GCContainerType(00050563)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsGCContainerTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strContainerTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCContainerTypeEN GetObj(this K_ContainerTypeId_GCContainerType myKey)
{
clsGCContainerTypeEN objGCContainerTypeEN = clsGCContainerTypeBL.GCContainerTypeDA.GetObjByContainerTypeId(myKey.Value);
return objGCContainerTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCContainerTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!容器类型名 = [{0}]的数据已经存在!(in clsGCContainerTypeBL.AddNewRecord)", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsGCContainerTypeBL.GCContainerTypeDA.AddNewRecordBySQL2(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCContainerTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCContainerTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(容器类型名(ContainerTypeName)=[{0}])已经存在,不能重复!", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCContainerTypeEN.AddNewRecord();
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCContainerTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!容器类型名 = [{0}]的数据已经存在!(in clsGCContainerTypeBL.AddNewRecordWithMaxId)", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
string strContainerTypeId = clsGCContainerTypeBL.GCContainerTypeDA.AddNewRecordBySQL2WithReturnKey(objGCContainerTypeEN);
     objGCContainerTypeEN.ContainerTypeId = strContainerTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
}
return strContainerTypeId;
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCContainerTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!容器类型名 = [{0}]的数据已经存在!(in clsGCContainerTypeBL.AddNewRecordWithReturnKey)", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
string strKey = clsGCContainerTypeBL.GCContainerTypeDA.AddNewRecordBySQL2WithReturnKey(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeId(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, conGCContainerType.ContainerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, conGCContainerType.ContainerTypeId);
}
objGCContainerTypeEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeId) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeId, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeId] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeName(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContainerTypeName, conGCContainerType.ContainerTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, conGCContainerType.ContainerTypeName);
}
objGCContainerTypeEN.ContainerTypeName = strContainerTypeName; //容器类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeName) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeName, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeName] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeENName(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContainerTypeENName, conGCContainerType.ContainerTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContainerTypeENName, 50, conGCContainerType.ContainerTypeENName);
}
objGCContainerTypeEN.ContainerTypeENName = strContainerTypeENName; //容器类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeENName) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeENName, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeENName] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetUpdDate(this clsGCContainerTypeEN objGCContainerTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCContainerType.UpdDate);
}
objGCContainerTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.UpdDate) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.UpdDate, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.UpdDate] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetUpdUser(this clsGCContainerTypeEN objGCContainerTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCContainerType.UpdUser);
}
objGCContainerTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.UpdUser) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.UpdUser, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.UpdUser] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetMemo(this clsGCContainerTypeEN objGCContainerTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCContainerType.Memo);
}
objGCContainerTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.Memo) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.Memo, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.Memo] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCContainerTypeEN objGCContainerTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCContainerTypeEN.CheckPropertyNew();
clsGCContainerTypeEN objGCContainerTypeCond = new clsGCContainerTypeEN();
string strCondition = objGCContainerTypeCond
.SetContainerTypeId(objGCContainerTypeEN.ContainerTypeId, "<>")
.SetContainerTypeName(objGCContainerTypeEN.ContainerTypeName, "=")
.GetCombineCondition();
objGCContainerTypeEN._IsCheckProperty = true;
bool bolIsExist = clsGCContainerTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ContainerTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCContainerTypeEN.Update();
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
 /// <param name = "objGCContainerType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCContainerTypeEN objGCContainerType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCContainerTypeEN objGCContainerTypeCond = new clsGCContainerTypeEN();
string strCondition = objGCContainerTypeCond
.SetContainerTypeName(objGCContainerType.ContainerTypeName, "=")
.GetCombineCondition();
objGCContainerType._IsCheckProperty = true;
bool bolIsExist = clsGCContainerTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCContainerType.ContainerTypeId = clsGCContainerTypeBL.GetFirstID_S(strCondition);
objGCContainerType.UpdateWithCondition(strCondition);
}
else
{
objGCContainerType.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
objGCContainerType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCContainerTypeEN objGCContainerTypeEN)
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCContainerTypeBL.GCContainerTypeDA.UpdateBySql2(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCContainerTypeEN objGCContainerTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCContainerTypeBL.GCContainerTypeDA.UpdateBySql2(objGCContainerTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCContainerTypeEN objGCContainerTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsGCContainerTypeBL.GCContainerTypeDA.UpdateBySqlWithCondition(objGCContainerTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCContainerTypeEN objGCContainerTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCContainerTypeBL.GCContainerTypeDA.UpdateBySqlWithConditionTransaction(objGCContainerTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
int intRecNum = clsGCContainerTypeBL.GCContainerTypeDA.DelRecord(objGCContainerTypeEN.ContainerTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <param name = "objGCContainerTypeENT">目标对象</param>
 public static void CopyTo(this clsGCContainerTypeEN objGCContainerTypeENS, clsGCContainerTypeEN objGCContainerTypeENT)
{
try
{
objGCContainerTypeENT.ContainerTypeId = objGCContainerTypeENS.ContainerTypeId; //容器类型Id
objGCContainerTypeENT.ContainerTypeName = objGCContainerTypeENS.ContainerTypeName; //容器类型名
objGCContainerTypeENT.ContainerTypeENName = objGCContainerTypeENS.ContainerTypeENName; //容器类型英文名
objGCContainerTypeENT.UpdDate = objGCContainerTypeENS.UpdDate; //修改日期
objGCContainerTypeENT.UpdUser = objGCContainerTypeENS.UpdUser; //修改者
objGCContainerTypeENT.Memo = objGCContainerTypeENS.Memo; //说明
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <returns>目标对象=>clsGCContainerTypeEN:objGCContainerTypeENT</returns>
 public static clsGCContainerTypeEN CopyTo(this clsGCContainerTypeEN objGCContainerTypeENS)
{
try
{
 clsGCContainerTypeEN objGCContainerTypeENT = new clsGCContainerTypeEN()
{
ContainerTypeId = objGCContainerTypeENS.ContainerTypeId, //容器类型Id
ContainerTypeName = objGCContainerTypeENS.ContainerTypeName, //容器类型名
ContainerTypeENName = objGCContainerTypeENS.ContainerTypeENName, //容器类型英文名
UpdDate = objGCContainerTypeENS.UpdDate, //修改日期
UpdUser = objGCContainerTypeENS.UpdUser, //修改者
Memo = objGCContainerTypeENS.Memo, //说明
};
 return objGCContainerTypeENT;
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
public static void CheckPropertyNew(this clsGCContainerTypeEN objGCContainerTypeEN)
{
 clsGCContainerTypeBL.GCContainerTypeDA.CheckPropertyNew(objGCContainerTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCContainerTypeEN objGCContainerTypeEN)
{
 clsGCContainerTypeBL.GCContainerTypeDA.CheckProperty4Condition(objGCContainerTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCContainerTypeEN objGCContainerTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeId, objGCContainerTypeCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeName) == true)
{
string strComparisonOpContainerTypeName = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeName, objGCContainerTypeCond.ContainerTypeName, strComparisonOpContainerTypeName);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeENName) == true)
{
string strComparisonOpContainerTypeENName = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeENName, objGCContainerTypeCond.ContainerTypeENName, strComparisonOpContainerTypeENName);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.UpdDate, objGCContainerTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.UpdUser, objGCContainerTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.Memo) == true)
{
string strComparisonOpMemo = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.Memo, objGCContainerTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCContainerType(GC容器类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ContainerTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCContainerTypeEN objGCContainerTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCContainerTypeEN == null) return true;
if (objGCContainerTypeEN.ContainerTypeId == null || objGCContainerTypeEN.ContainerTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
if (clsGCContainerTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ContainerTypeId !=  '{0}'", objGCContainerTypeEN.ContainerTypeId);
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
if (clsGCContainerTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCContainerType(GC容器类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ContainerTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCContainerTypeEN objGCContainerTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCContainerTypeEN == null) return "";
if (objGCContainerTypeEN.ContainerTypeId == null || objGCContainerTypeEN.ContainerTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ContainerTypeId !=  '{0}'", objGCContainerTypeEN.ContainerTypeId);
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCContainerType
{
public virtual bool UpdRelaTabDate(string strContainerTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumGCContainerType
{
 /// <summary>
 /// 表格容器
 /// </summary>
public const string TableContainer_0001 = "0001";
 /// <summary>
 /// 表单控件
 /// </summary>
public const string FormControl_0002 = "0002";
 /// <summary>
 /// 行内布局
 /// </summary>
public const string FormInline_0003 = "0003";
 /// <summary>
 /// Div列表
 /// </summary>
public const string DivTable_0004 = "0004";
 /// <summary>
 /// 横向列表Li
 /// </summary>
public const string HorizontalListLi_0005 = "0005";
 /// <summary>
 /// 纵向列表Li
 /// </summary>
public const string VerticalListLi_0006 = "0006";
}
 /// <summary>
 /// GC容器类型(GCContainerType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCContainerTypeBL
{
public static RelatedActions_GCContainerType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCContainerTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCContainerTypeDA GCContainerTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCContainerTypeDA();
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
 public clsGCContainerTypeBL()
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
if (string.IsNullOrEmpty(clsGCContainerTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCContainerTypeEN._ConnectString);
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
public static DataTable GetDataTable_GCContainerType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCContainerTypeDA.GetDataTable_GCContainerType(strWhereCond);
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
objDT = GCContainerTypeDA.GetDataTable(strWhereCond);
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
objDT = GCContainerTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCContainerTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCContainerTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCContainerTypeDA.GetDataTable_Top(objTopPara);
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
objDT = GCContainerTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCContainerTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCContainerTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrContainerTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstByContainerTypeIdLst(List<string> arrContainerTypeIdLst)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrContainerTypeIdLst, true);
 string strWhereCond = string.Format("ContainerTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrContainerTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCContainerTypeEN> GetObjLstByContainerTypeIdLstCache(List<string> arrContainerTypeIdLst)
{
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel =
arrGCContainerTypeObjLstCache
.Where(x => arrContainerTypeIdLst.Contains(x.ContainerTypeId));
return arrGCContainerTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLst(string strWhereCond)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
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
public static List<clsGCContainerTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCContainerTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCContainerTypeEN> GetSubObjLstCache(clsGCContainerTypeEN objGCContainerTypeCond)
{
List<clsGCContainerTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCContainerType._AttributeName)
{
if (objGCContainerTypeCond.IsUpdated(strFldName) == false) continue;
if (objGCContainerTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCContainerTypeCond[strFldName].ToString());
}
else
{
if (objGCContainerTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCContainerTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCContainerTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCContainerTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCContainerTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCContainerTypeCond[strFldName]));
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
public static List<clsGCContainerTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
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
public static List<clsGCContainerTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
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
List<clsGCContainerTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCContainerTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCContainerTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
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
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
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
public static List<clsGCContainerTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCContainerTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
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
public static List<clsGCContainerTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCContainerTypeEN> arrObjLst = new List<clsGCContainerTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN();
try
{
objGCContainerTypeEN.ContainerTypeId = objRow[conGCContainerType.ContainerTypeId].ToString().Trim(); //容器类型Id
objGCContainerTypeEN.ContainerTypeName = objRow[conGCContainerType.ContainerTypeName].ToString().Trim(); //容器类型名
objGCContainerTypeEN.ContainerTypeENName = objRow[conGCContainerType.ContainerTypeENName].ToString().Trim(); //容器类型英文名
objGCContainerTypeEN.UpdDate = objRow[conGCContainerType.UpdDate] == DBNull.Value ? null : objRow[conGCContainerType.UpdDate].ToString().Trim(); //修改日期
objGCContainerTypeEN.UpdUser = objRow[conGCContainerType.UpdUser] == DBNull.Value ? null : objRow[conGCContainerType.UpdUser].ToString().Trim(); //修改者
objGCContainerTypeEN.Memo = objRow[conGCContainerType.Memo] == DBNull.Value ? null : objRow[conGCContainerType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCContainerTypeEN.ContainerTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCContainerTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCContainerType(ref clsGCContainerTypeEN objGCContainerTypeEN)
{
bool bolResult = GCContainerTypeDA.GetGCContainerType(ref objGCContainerTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strContainerTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCContainerTypeEN GetObjByContainerTypeId(string strContainerTypeId)
{
if (strContainerTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strContainerTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strContainerTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strContainerTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCContainerTypeEN objGCContainerTypeEN = GCContainerTypeDA.GetObjByContainerTypeId(strContainerTypeId);
return objGCContainerTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCContainerTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCContainerTypeEN objGCContainerTypeEN = GCContainerTypeDA.GetFirstObj(strWhereCond);
 return objGCContainerTypeEN;
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
public static clsGCContainerTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCContainerTypeEN objGCContainerTypeEN = GCContainerTypeDA.GetObjByDataRow(objRow);
 return objGCContainerTypeEN;
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
public static clsGCContainerTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCContainerTypeEN objGCContainerTypeEN = GCContainerTypeDA.GetObjByDataRow(objRow);
 return objGCContainerTypeEN;
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
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <param name = "lstGCContainerTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCContainerTypeEN GetObjByContainerTypeIdFromList(string strContainerTypeId, List<clsGCContainerTypeEN> lstGCContainerTypeObjLst)
{
foreach (clsGCContainerTypeEN objGCContainerTypeEN in lstGCContainerTypeObjLst)
{
if (objGCContainerTypeEN.ContainerTypeId == strContainerTypeId)
{
return objGCContainerTypeEN;
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
 string strMaxContainerTypeId;
 try
 {
 strMaxContainerTypeId = clsGCContainerTypeDA.GetMaxStrId();
 return strMaxContainerTypeId;
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
 string strContainerTypeId;
 try
 {
 strContainerTypeId = new clsGCContainerTypeDA().GetFirstID(strWhereCond);
 return strContainerTypeId;
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
 arrList = GCContainerTypeDA.GetID(strWhereCond);
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
bool bolIsExist = GCContainerTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strContainerTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCContainerTypeDA.IsExist(strContainerTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strContainerTypeId">容器类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strContainerTypeId, string strOpUser)
{
clsGCContainerTypeEN objGCContainerTypeEN = clsGCContainerTypeBL.GetObjByContainerTypeId(strContainerTypeId);
objGCContainerTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCContainerTypeEN.UpdUser = strOpUser;
return clsGCContainerTypeBL.UpdateBySql2(objGCContainerTypeEN);
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
 bolIsExist = clsGCContainerTypeDA.IsExistTable();
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
 bolIsExist = GCContainerTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCContainerTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!容器类型名 = [{0}]的数据已经存在!(in clsGCContainerTypeBL.AddNewRecordBySql2)", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
bool bolResult = GCContainerTypeDA.AddNewRecordBySQL2(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCContainerTypeEN objGCContainerTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCContainerTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!容器类型名 = [{0}]的数据已经存在!(in clsGCContainerTypeBL.AddNewRecordBySql2WithReturnKey)", objGCContainerTypeEN.ContainerTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeBL.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeBL.GetMaxStrId_S();
 }
string strKey = GCContainerTypeDA.AddNewRecordBySQL2WithReturnKey(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
bool bolResult = GCContainerTypeDA.Update(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCContainerTypeEN objGCContainerTypeEN)
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCContainerTypeDA.UpdateBySql2(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeBL.ReFreshCache();

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
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
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strContainerTypeId)
{
try
{
 clsGCContainerTypeEN objGCContainerTypeEN = clsGCContainerTypeBL.GetObjByContainerTypeId(strContainerTypeId);

if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(objGCContainerTypeEN.ContainerTypeId, objGCContainerTypeEN.UpdUser);
}
if (objGCContainerTypeEN != null)
{
int intRecNum = GCContainerTypeDA.DelRecord(strContainerTypeId);
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
/// <param name="strContainerTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strContainerTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
//删除与表:[GCContainerType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCContainerType.ContainerTypeId,
//strContainerTypeId);
//        clsGCContainerTypeBL.DelGCContainerTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCContainerTypeBL.DelRecord(strContainerTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCContainerTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strContainerTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strContainerTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strContainerTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCContainerTypeBL.relatedActions != null)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(strContainerTypeId, "UpdRelaTabDate");
}
bool bolResult = GCContainerTypeDA.DelRecord(strContainerTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrContainerTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCContainerTypes(List<string> arrContainerTypeIdLst)
{
if (arrContainerTypeIdLst.Count == 0) return 0;
try
{
if (clsGCContainerTypeBL.relatedActions != null)
{
foreach (var strContainerTypeId in arrContainerTypeIdLst)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(strContainerTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCContainerTypeDA.DelGCContainerType(arrContainerTypeIdLst);
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
public static int DelGCContainerTypesByCond(string strWhereCond)
{
try
{
if (clsGCContainerTypeBL.relatedActions != null)
{
List<string> arrContainerTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strContainerTypeId in arrContainerTypeId)
{
clsGCContainerTypeBL.relatedActions.UpdRelaTabDate(strContainerTypeId, "UpdRelaTabDate");
}
}
int intRecNum = GCContainerTypeDA.DelGCContainerType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCContainerType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strContainerTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strContainerTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCContainerTypeDA.GetSpecSQLObj();
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
//删除与表:[GCContainerType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCContainerTypeBL.DelRecord(strContainerTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCContainerTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strContainerTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <param name = "objGCContainerTypeENT">目标对象</param>
 public static void CopyTo(clsGCContainerTypeEN objGCContainerTypeENS, clsGCContainerTypeEN objGCContainerTypeENT)
{
try
{
objGCContainerTypeENT.ContainerTypeId = objGCContainerTypeENS.ContainerTypeId; //容器类型Id
objGCContainerTypeENT.ContainerTypeName = objGCContainerTypeENS.ContainerTypeName; //容器类型名
objGCContainerTypeENT.ContainerTypeENName = objGCContainerTypeENS.ContainerTypeENName; //容器类型英文名
objGCContainerTypeENT.UpdDate = objGCContainerTypeENS.UpdDate; //修改日期
objGCContainerTypeENT.UpdUser = objGCContainerTypeENS.UpdUser; //修改者
objGCContainerTypeENT.Memo = objGCContainerTypeENS.Memo; //说明
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
 /// <param name = "objGCContainerTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
objGCContainerTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCContainerTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCContainerType.ContainerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.ContainerTypeId = objGCContainerTypeEN.ContainerTypeId; //容器类型Id
}
if (arrFldSet.Contains(conGCContainerType.ContainerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.ContainerTypeName = objGCContainerTypeEN.ContainerTypeName; //容器类型名
}
if (arrFldSet.Contains(conGCContainerType.ContainerTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.ContainerTypeENName = objGCContainerTypeEN.ContainerTypeENName; //容器类型英文名
}
if (arrFldSet.Contains(conGCContainerType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.UpdDate = objGCContainerTypeEN.UpdDate == "[null]" ? null :  objGCContainerTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCContainerType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.UpdUser = objGCContainerTypeEN.UpdUser == "[null]" ? null :  objGCContainerTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCContainerType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCContainerTypeEN.Memo = objGCContainerTypeEN.Memo == "[null]" ? null :  objGCContainerTypeEN.Memo; //说明
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
 /// <param name = "objGCContainerTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
if (objGCContainerTypeEN.UpdDate == "[null]") objGCContainerTypeEN.UpdDate = null; //修改日期
if (objGCContainerTypeEN.UpdUser == "[null]") objGCContainerTypeEN.UpdUser = null; //修改者
if (objGCContainerTypeEN.Memo == "[null]") objGCContainerTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCContainerTypeEN objGCContainerTypeEN)
{
 GCContainerTypeDA.CheckPropertyNew(objGCContainerTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCContainerTypeEN objGCContainerTypeEN)
{
 GCContainerTypeDA.CheckProperty4Condition(objGCContainerTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ContainerTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCContainerType.ContainerTypeId); 
List<clsGCContainerTypeEN> arrObjLst = clsGCContainerTypeBL.GetObjLst(strCondition).OrderBy(x=>x.ContainerTypeName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN()
{
ContainerTypeId = "0",
ContainerTypeName = "选[GC容器类型]..."
};
arrObjLst.Insert(0, objGCContainerTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCContainerType.ContainerTypeId;
objComboBox.DisplayMember = conGCContainerType.ContainerTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ContainerTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC容器类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conGCContainerType.ContainerTypeId); 
IEnumerable<clsGCContainerTypeEN> arrObjLst = clsGCContainerTypeBL.GetObjLst(strCondition).OrderBy(x=>x.ContainerTypeName);
objDDL.DataValueField = conGCContainerType.ContainerTypeId;
objDDL.DataTextField = conGCContainerType.ContainerTypeName;
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
public static void BindDdl_ContainerTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC容器类型]...","0");
List<clsGCContainerTypeEN> arrGCContainerTypeObjLst = GetAllGCContainerTypeObjLstCache(); 
objDDL.DataValueField = conGCContainerType.ContainerTypeId;
objDDL.DataTextField = conGCContainerType.ContainerTypeName;
objDDL.DataSource = arrGCContainerTypeObjLst;
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
if (clsGCContainerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCContainerTypeBL没有刷新缓存机制(clsGCContainerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ContainerTypeId");
//if (arrGCContainerTypeObjLstCache == null)
//{
//arrGCContainerTypeObjLstCache = GCContainerTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCContainerTypeEN GetObjByContainerTypeIdCache(string strContainerTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel =
arrGCContainerTypeObjLstCache
.Where(x=> x.ContainerTypeId == strContainerTypeId 
);
if (arrGCContainerTypeObjLst_Sel.Count() == 0)
{
   clsGCContainerTypeEN obj = clsGCContainerTypeBL.GetObjByContainerTypeId(strContainerTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCContainerTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetContainerTypeNameByContainerTypeIdCache(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return "";
//获取缓存中的对象列表
clsGCContainerTypeEN objGCContainerType = GetObjByContainerTypeIdCache(strContainerTypeId);
if (objGCContainerType == null) return "";
return objGCContainerType.ContainerTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByContainerTypeIdCache(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return "";
//获取缓存中的对象列表
clsGCContainerTypeEN objGCContainerType = GetObjByContainerTypeIdCache(strContainerTypeId);
if (objGCContainerType == null) return "";
return objGCContainerType.ContainerTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCContainerTypeEN> GetAllGCContainerTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache(); 
return arrGCContainerTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCContainerTypeObjLstCache;
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
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCContainerTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCContainerTypeEN._RefreshTimeLst.Count == 0) return "";
return clsGCContainerTypeEN._RefreshTimeLst[clsGCContainerTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsGCContainerTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCContainerTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCContainerTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCContainerType(GC容器类型)
 /// 唯一性条件:ContainerTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCContainerTypeEN objGCContainerTypeEN)
{
//检测记录是否存在
string strResult = GCContainerTypeDA.GetUniCondStr(objGCContainerTypeEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strContainerTypeId)
{
if (strInFldName != conGCContainerType.ContainerTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCContainerType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCContainerType._AttributeName));
throw new Exception(strMsg);
}
var objGCContainerType = clsGCContainerTypeBL.GetObjByContainerTypeIdCache(strContainerTypeId);
if (objGCContainerType == null) return "";
return objGCContainerType[strOutFldName].ToString();
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
int intRecCount = clsGCContainerTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsGCContainerTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCContainerTypeDA.GetRecCount();
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
int intRecCount = clsGCContainerTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCContainerTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCContainerTypeEN objGCContainerTypeCond)
{
List<clsGCContainerTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCContainerType._AttributeName)
{
if (objGCContainerTypeCond.IsUpdated(strFldName) == false) continue;
if (objGCContainerTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCContainerTypeCond[strFldName].ToString());
}
else
{
if (objGCContainerTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCContainerTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCContainerTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCContainerTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCContainerTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCContainerTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCContainerTypeCond[strFldName]));
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
 List<string> arrList = clsGCContainerTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCContainerTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCContainerTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCContainerTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCContainerTypeDA.SetFldValue(clsGCContainerTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCContainerTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCContainerTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCContainerTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCContainerTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCContainerType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**容器类型Id*/ 
 strCreateTabCode.Append(" ContainerTypeId char(4) primary key, "); 
 // /**容器类型名*/ 
 strCreateTabCode.Append(" ContainerTypeName varchar(50) not Null, "); 
 // /**容器类型英文名*/ 
 strCreateTabCode.Append(" ContainerTypeENName varchar(50) not Null, "); 
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
 /// GC容器类型(GCContainerType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCContainerType : clsCommFun4BL
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
clsGCContainerTypeBL.ReFreshThisCache();
}
}

}