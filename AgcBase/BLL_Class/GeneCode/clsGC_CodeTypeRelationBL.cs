
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGC_CodeTypeRelationBL
 表名:GC_CodeTypeRelation(00050646)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/05 05:22:33
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
public static class  clsGC_CodeTypeRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGC_CodeTypeRelationEN GetObj(this K_RelationId_GC_CodeTypeRelation myKey)
{
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.GetObjByRelationId(myKey.Value);
return objGC_CodeTypeRelationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGC_CodeTypeRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!父代码类型Id = [{0}],子代码类型Id = [{1}]的数据已经存在!(in clsGC_CodeTypeRelationBL.AddNewRecord)", objGC_CodeTypeRelationEN.ParentCodeTypeId,objGC_CodeTypeRelationEN.ChildCodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.AddNewRecordBySQL2(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
public static bool AddRecordEx(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, bool bolIsNeedCheckUniqueness = true)
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
objGC_CodeTypeRelationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGC_CodeTypeRelationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(父代码类型Id(ParentCodeTypeId)=[{0}],子代码类型Id(ChildCodeTypeId)=[{1}])已经存在,不能重复!", objGC_CodeTypeRelationEN.ParentCodeTypeId, objGC_CodeTypeRelationEN.ChildCodeTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objGC_CodeTypeRelationEN.AddNewRecord();
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGC_CodeTypeRelationEN) == false)
{
var strMsg = string.Format("记录已经存在!父代码类型Id = [{0}],子代码类型Id = [{1}]的数据已经存在!(in clsGC_CodeTypeRelationBL.AddNewRecordWithReturnKey)", objGC_CodeTypeRelationEN.ParentCodeTypeId,objGC_CodeTypeRelationEN.ChildCodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.AddNewRecordBySQL2WithReturnKey(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetRelationId(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, long lngRelationId, string strComparisonOp="")
	{
objGC_CodeTypeRelationEN.RelationId = lngRelationId; //关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.RelationId) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.RelationId, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.RelationId] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetParentCodeTypeId(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strParentCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentCodeTypeId, 4, conGC_CodeTypeRelation.ParentCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentCodeTypeId, 4, conGC_CodeTypeRelation.ParentCodeTypeId);
}
objGC_CodeTypeRelationEN.ParentCodeTypeId = strParentCodeTypeId; //父代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.ParentCodeTypeId) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.ParentCodeTypeId, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.ParentCodeTypeId] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetChildCodeTypeId(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strChildCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChildCodeTypeId, 4, conGC_CodeTypeRelation.ChildCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChildCodeTypeId, 4, conGC_CodeTypeRelation.ChildCodeTypeId);
}
objGC_CodeTypeRelationEN.ChildCodeTypeId = strChildCodeTypeId; //子代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.ChildCodeTypeId) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.ChildCodeTypeId, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.ChildCodeTypeId] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetCtRelationTypeId(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strCtRelationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtRelationTypeId, 2, conGC_CodeTypeRelation.CtRelationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtRelationTypeId, 2, conGC_CodeTypeRelation.CtRelationTypeId);
}
objGC_CodeTypeRelationEN.CtRelationTypeId = strCtRelationTypeId; //Ct关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.CtRelationTypeId) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.CtRelationTypeId, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.CtRelationTypeId] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetDescription(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDescription, 300, conGC_CodeTypeRelation.Description);
}
objGC_CodeTypeRelationEN.Description = strDescription; //描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.Description) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.Description, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.Description] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetUpdDate(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGC_CodeTypeRelation.UpdDate);
}
objGC_CodeTypeRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.UpdDate) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.UpdDate, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.UpdDate] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGC_CodeTypeRelationEN SetUpdUser(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGC_CodeTypeRelation.UpdUser);
}
objGC_CodeTypeRelationEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGC_CodeTypeRelationEN.dicFldComparisonOp.ContainsKey(conGC_CodeTypeRelation.UpdUser) == false)
{
objGC_CodeTypeRelationEN.dicFldComparisonOp.Add(conGC_CodeTypeRelation.UpdUser, strComparisonOp);
}
else
{
objGC_CodeTypeRelationEN.dicFldComparisonOp[conGC_CodeTypeRelation.UpdUser] = strComparisonOp;
}
}
return objGC_CodeTypeRelationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGC_CodeTypeRelationEN.CheckPropertyNew();
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationCond = new clsGC_CodeTypeRelationEN();
string strCondition = objGC_CodeTypeRelationCond
.SetRelationId(objGC_CodeTypeRelationEN.RelationId, "<>")
.SetParentCodeTypeId(objGC_CodeTypeRelationEN.ParentCodeTypeId, "=")
.SetChildCodeTypeId(objGC_CodeTypeRelationEN.ChildCodeTypeId, "=")
.GetCombineCondition();
objGC_CodeTypeRelationEN._IsCheckProperty = true;
bool bolIsExist = clsGC_CodeTypeRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGC_CodeTypeRelationEN.Update();
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
 /// <param name = "objGC_CodeTypeRelation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationCond = new clsGC_CodeTypeRelationEN();
string strCondition = objGC_CodeTypeRelationCond
.SetParentCodeTypeId(objGC_CodeTypeRelation.ParentCodeTypeId, "=")
.SetChildCodeTypeId(objGC_CodeTypeRelation.ChildCodeTypeId, "=")
.GetCombineCondition();
objGC_CodeTypeRelation._IsCheckProperty = true;
bool bolIsExist = clsGC_CodeTypeRelationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGC_CodeTypeRelation.RelationId = clsGC_CodeTypeRelationBL.GetFirstID_S(strCondition);
objGC_CodeTypeRelation.UpdateWithCondition(strCondition);
}
else
{
objGC_CodeTypeRelation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 if (objGC_CodeTypeRelationEN.RelationId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.UpdateBySql2(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGC_CodeTypeRelationEN.RelationId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.UpdateBySql2(objGC_CodeTypeRelationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strWhereCond)
{
try
{
bool bolResult = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.UpdateBySqlWithCondition(objGC_CodeTypeRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.UpdateBySqlWithConditionTransaction(objGC_CodeTypeRelationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "lngRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
try
{
int intRecNum = clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.DelRecord(objGC_CodeTypeRelationEN.RelationId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <param name = "objGC_CodeTypeRelationENT">目标对象</param>
 public static void CopyTo(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENS, clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENT)
{
try
{
objGC_CodeTypeRelationENT.RelationId = objGC_CodeTypeRelationENS.RelationId; //关系Id
objGC_CodeTypeRelationENT.ParentCodeTypeId = objGC_CodeTypeRelationENS.ParentCodeTypeId; //父代码类型Id
objGC_CodeTypeRelationENT.ChildCodeTypeId = objGC_CodeTypeRelationENS.ChildCodeTypeId; //子代码类型Id
objGC_CodeTypeRelationENT.CtRelationTypeId = objGC_CodeTypeRelationENS.CtRelationTypeId; //Ct关系类型Id
objGC_CodeTypeRelationENT.Description = objGC_CodeTypeRelationENS.Description; //描述
objGC_CodeTypeRelationENT.UpdDate = objGC_CodeTypeRelationENS.UpdDate; //修改日期
objGC_CodeTypeRelationENT.UpdUser = objGC_CodeTypeRelationENS.UpdUser; //修改者
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
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <returns>目标对象=>clsGC_CodeTypeRelationEN:objGC_CodeTypeRelationENT</returns>
 public static clsGC_CodeTypeRelationEN CopyTo(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENS)
{
try
{
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENT = new clsGC_CodeTypeRelationEN()
{
RelationId = objGC_CodeTypeRelationENS.RelationId, //关系Id
ParentCodeTypeId = objGC_CodeTypeRelationENS.ParentCodeTypeId, //父代码类型Id
ChildCodeTypeId = objGC_CodeTypeRelationENS.ChildCodeTypeId, //子代码类型Id
CtRelationTypeId = objGC_CodeTypeRelationENS.CtRelationTypeId, //Ct关系类型Id
Description = objGC_CodeTypeRelationENS.Description, //描述
UpdDate = objGC_CodeTypeRelationENS.UpdDate, //修改日期
UpdUser = objGC_CodeTypeRelationENS.UpdUser, //修改者
};
 return objGC_CodeTypeRelationENT;
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
public static void CheckPropertyNew(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.CheckPropertyNew(objGC_CodeTypeRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 clsGC_CodeTypeRelationBL.GC_CodeTypeRelationDA.CheckProperty4Condition(objGC_CodeTypeRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.RelationId) == true)
{
string strComparisonOpRelationId = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.RelationId];
strWhereCond += string.Format(" And {0} {2} {1}", conGC_CodeTypeRelation.RelationId, objGC_CodeTypeRelationCond.RelationId, strComparisonOpRelationId);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.ParentCodeTypeId) == true)
{
string strComparisonOpParentCodeTypeId = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.ParentCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.ParentCodeTypeId, objGC_CodeTypeRelationCond.ParentCodeTypeId, strComparisonOpParentCodeTypeId);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.ChildCodeTypeId) == true)
{
string strComparisonOpChildCodeTypeId = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.ChildCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.ChildCodeTypeId, objGC_CodeTypeRelationCond.ChildCodeTypeId, strComparisonOpChildCodeTypeId);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.CtRelationTypeId) == true)
{
string strComparisonOpCtRelationTypeId = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.CtRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.CtRelationTypeId, objGC_CodeTypeRelationCond.CtRelationTypeId, strComparisonOpCtRelationTypeId);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.Description) == true)
{
string strComparisonOpDescription = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.Description];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.Description, objGC_CodeTypeRelationCond.Description, strComparisonOpDescription);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.UpdDate, objGC_CodeTypeRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objGC_CodeTypeRelationCond.IsUpdated(conGC_CodeTypeRelation.UpdUser) == true)
{
string strComparisonOpUpdUser = objGC_CodeTypeRelationCond.dicFldComparisonOp[conGC_CodeTypeRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGC_CodeTypeRelation.UpdUser, objGC_CodeTypeRelationCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GC_CodeTypeRelation(GC_代码类型关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ChildCodeTypeId_ParentCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGC_CodeTypeRelationEN == null) return true;
if (objGC_CodeTypeRelationEN.RelationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objGC_CodeTypeRelationEN.ParentCodeTypeId == null)
{
 sbCondition.AppendFormat(" and ParentCodeTypeId is null", objGC_CodeTypeRelationEN.ParentCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and ParentCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ParentCodeTypeId);
}
 if (objGC_CodeTypeRelationEN.ChildCodeTypeId == null)
{
 sbCondition.AppendFormat(" and ChildCodeTypeId is null", objGC_CodeTypeRelationEN.ChildCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and ChildCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ChildCodeTypeId);
}
if (clsGC_CodeTypeRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RelationId !=  {0}", objGC_CodeTypeRelationEN.RelationId);
 sbCondition.AppendFormat(" and ParentCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ParentCodeTypeId);
 sbCondition.AppendFormat(" and ChildCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ChildCodeTypeId);
if (clsGC_CodeTypeRelationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GC_CodeTypeRelation(GC_代码类型关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ChildCodeTypeId_ParentCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGC_CodeTypeRelationEN == null) return "";
if (objGC_CodeTypeRelationEN.RelationId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objGC_CodeTypeRelationEN.ParentCodeTypeId == null)
{
 sbCondition.AppendFormat(" and ParentCodeTypeId is null", objGC_CodeTypeRelationEN.ParentCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and ParentCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ParentCodeTypeId);
}
 if (objGC_CodeTypeRelationEN.ChildCodeTypeId == null)
{
 sbCondition.AppendFormat(" and ChildCodeTypeId is null", objGC_CodeTypeRelationEN.ChildCodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and ChildCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ChildCodeTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelationId !=  {0}", objGC_CodeTypeRelationEN.RelationId);
 sbCondition.AppendFormat(" and ParentCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ParentCodeTypeId);
 sbCondition.AppendFormat(" and ChildCodeTypeId = '{0}'", objGC_CodeTypeRelationEN.ChildCodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GC_CodeTypeRelation
{
public virtual bool UpdRelaTabDate(long lngRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// GC_代码类型关系(GC_CodeTypeRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGC_CodeTypeRelationBL
{
public static RelatedActions_GC_CodeTypeRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGC_CodeTypeRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGC_CodeTypeRelationDA GC_CodeTypeRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGC_CodeTypeRelationDA();
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
 public clsGC_CodeTypeRelationBL()
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
if (string.IsNullOrEmpty(clsGC_CodeTypeRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGC_CodeTypeRelationEN._ConnectString);
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
public static DataTable GetDataTable_GC_CodeTypeRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GC_CodeTypeRelationDA.GetDataTable_GC_CodeTypeRelation(strWhereCond);
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
objDT = GC_CodeTypeRelationDA.GetDataTable(strWhereCond);
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
objDT = GC_CodeTypeRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GC_CodeTypeRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GC_CodeTypeRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GC_CodeTypeRelationDA.GetDataTable_Top(objTopPara);
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
objDT = GC_CodeTypeRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GC_CodeTypeRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GC_CodeTypeRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetObjLstByRelationIdLst(List<long> arrRelationIdLst)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelationIdLst);
 string strWhereCond = string.Format("RelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGC_CodeTypeRelationEN> GetObjLstByRelationIdLstCache(List<long> arrRelationIdLst)
{
string strKey = string.Format("{0}", clsGC_CodeTypeRelationEN._CurrTabName);
List<clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLstCache = GetObjLstCache();
IEnumerable <clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLst_Sel =
arrGC_CodeTypeRelationObjLstCache
.Where(x => arrRelationIdLst.Contains(x.RelationId));
return arrGC_CodeTypeRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetObjLst(string strWhereCond)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
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
public static List<clsGC_CodeTypeRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGC_CodeTypeRelationEN> GetSubObjLstCache(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationCond)
{
List<clsGC_CodeTypeRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGC_CodeTypeRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGC_CodeTypeRelation._AttributeName)
{
if (objGC_CodeTypeRelationCond.IsUpdated(strFldName) == false) continue;
if (objGC_CodeTypeRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGC_CodeTypeRelationCond[strFldName].ToString());
}
else
{
if (objGC_CodeTypeRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGC_CodeTypeRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGC_CodeTypeRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGC_CodeTypeRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGC_CodeTypeRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGC_CodeTypeRelationCond[strFldName]));
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
public static List<clsGC_CodeTypeRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
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
public static List<clsGC_CodeTypeRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
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
List<clsGC_CodeTypeRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGC_CodeTypeRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGC_CodeTypeRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
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
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
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
public static List<clsGC_CodeTypeRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGC_CodeTypeRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
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
public static List<clsGC_CodeTypeRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGC_CodeTypeRelationEN> arrObjLst = new List<clsGC_CodeTypeRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = new clsGC_CodeTypeRelationEN();
try
{
objGC_CodeTypeRelationEN.RelationId = Int32.Parse(objRow[conGC_CodeTypeRelation.RelationId].ToString().Trim()); //关系Id
objGC_CodeTypeRelationEN.ParentCodeTypeId = objRow[conGC_CodeTypeRelation.ParentCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ParentCodeTypeId].ToString().Trim(); //父代码类型Id
objGC_CodeTypeRelationEN.ChildCodeTypeId = objRow[conGC_CodeTypeRelation.ChildCodeTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.ChildCodeTypeId].ToString().Trim(); //子代码类型Id
objGC_CodeTypeRelationEN.CtRelationTypeId = objRow[conGC_CodeTypeRelation.CtRelationTypeId] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.CtRelationTypeId].ToString().Trim(); //Ct关系类型Id
objGC_CodeTypeRelationEN.Description = objRow[conGC_CodeTypeRelation.Description] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.Description].ToString().Trim(); //描述
objGC_CodeTypeRelationEN.UpdDate = objRow[conGC_CodeTypeRelation.UpdDate] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdDate].ToString().Trim(); //修改日期
objGC_CodeTypeRelationEN.UpdUser = objRow[conGC_CodeTypeRelation.UpdUser] == DBNull.Value ? null : objRow[conGC_CodeTypeRelation.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGC_CodeTypeRelationEN.RelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGC_CodeTypeRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGC_CodeTypeRelation(ref clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
bool bolResult = GC_CodeTypeRelationDA.GetGC_CodeTypeRelation(ref objGC_CodeTypeRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGC_CodeTypeRelationEN GetObjByRelationId(long lngRelationId)
{
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = GC_CodeTypeRelationDA.GetObjByRelationId(lngRelationId);
return objGC_CodeTypeRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGC_CodeTypeRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = GC_CodeTypeRelationDA.GetFirstObj(strWhereCond);
 return objGC_CodeTypeRelationEN;
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
public static clsGC_CodeTypeRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = GC_CodeTypeRelationDA.GetObjByDataRow(objRow);
 return objGC_CodeTypeRelationEN;
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
public static clsGC_CodeTypeRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = GC_CodeTypeRelationDA.GetObjByDataRow(objRow);
 return objGC_CodeTypeRelationEN;
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
 /// <param name = "lngRelationId">所给的关键字</param>
 /// <param name = "lstGC_CodeTypeRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGC_CodeTypeRelationEN GetObjByRelationIdFromList(long lngRelationId, List<clsGC_CodeTypeRelationEN> lstGC_CodeTypeRelationObjLst)
{
foreach (clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN in lstGC_CodeTypeRelationObjLst)
{
if (objGC_CodeTypeRelationEN.RelationId == lngRelationId)
{
return objGC_CodeTypeRelationEN;
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
 long lngRelationId;
 try
 {
 lngRelationId = new clsGC_CodeTypeRelationDA().GetFirstID(strWhereCond);
 return lngRelationId;
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
 arrList = GC_CodeTypeRelationDA.GetID(strWhereCond);
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
bool bolIsExist = GC_CodeTypeRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngRelationId)
{
//检测记录是否存在
bool bolIsExist = GC_CodeTypeRelationDA.IsExist(lngRelationId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngRelationId">关系Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngRelationId, string strOpUser)
{
clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = clsGC_CodeTypeRelationBL.GetObjByRelationId(lngRelationId);
objGC_CodeTypeRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGC_CodeTypeRelationEN.UpdUser = strOpUser;
return clsGC_CodeTypeRelationBL.UpdateBySql2(objGC_CodeTypeRelationEN);
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
 bolIsExist = clsGC_CodeTypeRelationDA.IsExistTable();
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
 bolIsExist = GC_CodeTypeRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGC_CodeTypeRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!父代码类型Id = [{0}],子代码类型Id = [{1}]的数据已经存在!(in clsGC_CodeTypeRelationBL.AddNewRecordBySql2)", objGC_CodeTypeRelationEN.ParentCodeTypeId,objGC_CodeTypeRelationEN.ChildCodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = GC_CodeTypeRelationDA.AddNewRecordBySQL2(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGC_CodeTypeRelationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!父代码类型Id = [{0}],子代码类型Id = [{1}]的数据已经存在!(in clsGC_CodeTypeRelationBL.AddNewRecordBySql2WithReturnKey)", objGC_CodeTypeRelationEN.ParentCodeTypeId,objGC_CodeTypeRelationEN.ChildCodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = GC_CodeTypeRelationDA.AddNewRecordBySQL2WithReturnKey(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
try
{
bool bolResult = GC_CodeTypeRelationDA.Update(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "objGC_CodeTypeRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 if (objGC_CodeTypeRelationEN.RelationId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GC_CodeTypeRelationDA.UpdateBySql2(objGC_CodeTypeRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGC_CodeTypeRelationBL.ReFreshCache();

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
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
 /// <param name = "lngRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngRelationId)
{
try
{
 clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN = clsGC_CodeTypeRelationBL.GetObjByRelationId(lngRelationId);

if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(objGC_CodeTypeRelationEN.RelationId, objGC_CodeTypeRelationEN.UpdUser);
}
if (objGC_CodeTypeRelationEN != null)
{
int intRecNum = GC_CodeTypeRelationDA.DelRecord(lngRelationId);
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
/// <param name="lngRelationId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngRelationId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGC_CodeTypeRelationDA.GetSpecSQLObj();
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
//删除与表:[GC_CodeTypeRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGC_CodeTypeRelation.RelationId,
//lngRelationId);
//        clsGC_CodeTypeRelationBL.DelGC_CodeTypeRelationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGC_CodeTypeRelationBL.DelRecord(lngRelationId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGC_CodeTypeRelationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngRelationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(lngRelationId, "UpdRelaTabDate");
}
bool bolResult = GC_CodeTypeRelationDA.DelRecord(lngRelationId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRelationIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGC_CodeTypeRelations(List<string> arrRelationIdLst)
{
if (arrRelationIdLst.Count == 0) return 0;
try
{
if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
foreach (var strRelationId in arrRelationIdLst)
{
long lngRelationId = long.Parse(strRelationId);
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(lngRelationId, "UpdRelaTabDate");
}
}
int intDelRecNum = GC_CodeTypeRelationDA.DelGC_CodeTypeRelation(arrRelationIdLst);
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
public static int DelGC_CodeTypeRelationsByCond(string strWhereCond)
{
try
{
if (clsGC_CodeTypeRelationBL.relatedActions != null)
{
List<string> arrRelationId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRelationId in arrRelationId)
{
long lngRelationId = long.Parse(strRelationId);
clsGC_CodeTypeRelationBL.relatedActions.UpdRelaTabDate(lngRelationId, "UpdRelaTabDate");
}
}
int intRecNum = GC_CodeTypeRelationDA.DelGC_CodeTypeRelation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GC_CodeTypeRelation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngRelationId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngRelationId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGC_CodeTypeRelationDA.GetSpecSQLObj();
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
//删除与表:[GC_CodeTypeRelation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGC_CodeTypeRelationBL.DelRecord(lngRelationId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGC_CodeTypeRelationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRelationId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGC_CodeTypeRelationENS">源对象</param>
 /// <param name = "objGC_CodeTypeRelationENT">目标对象</param>
 public static void CopyTo(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENS, clsGC_CodeTypeRelationEN objGC_CodeTypeRelationENT)
{
try
{
objGC_CodeTypeRelationENT.RelationId = objGC_CodeTypeRelationENS.RelationId; //关系Id
objGC_CodeTypeRelationENT.ParentCodeTypeId = objGC_CodeTypeRelationENS.ParentCodeTypeId; //父代码类型Id
objGC_CodeTypeRelationENT.ChildCodeTypeId = objGC_CodeTypeRelationENS.ChildCodeTypeId; //子代码类型Id
objGC_CodeTypeRelationENT.CtRelationTypeId = objGC_CodeTypeRelationENS.CtRelationTypeId; //Ct关系类型Id
objGC_CodeTypeRelationENT.Description = objGC_CodeTypeRelationENS.Description; //描述
objGC_CodeTypeRelationENT.UpdDate = objGC_CodeTypeRelationENS.UpdDate; //修改日期
objGC_CodeTypeRelationENT.UpdUser = objGC_CodeTypeRelationENS.UpdUser; //修改者
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
 /// <param name = "objGC_CodeTypeRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
try
{
objGC_CodeTypeRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGC_CodeTypeRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGC_CodeTypeRelation.RelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.RelationId = objGC_CodeTypeRelationEN.RelationId; //关系Id
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.ParentCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.ParentCodeTypeId = objGC_CodeTypeRelationEN.ParentCodeTypeId == "[null]" ? null :  objGC_CodeTypeRelationEN.ParentCodeTypeId; //父代码类型Id
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.ChildCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.ChildCodeTypeId = objGC_CodeTypeRelationEN.ChildCodeTypeId == "[null]" ? null :  objGC_CodeTypeRelationEN.ChildCodeTypeId; //子代码类型Id
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.CtRelationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.CtRelationTypeId = objGC_CodeTypeRelationEN.CtRelationTypeId == "[null]" ? null :  objGC_CodeTypeRelationEN.CtRelationTypeId; //Ct关系类型Id
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.Description, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.Description = objGC_CodeTypeRelationEN.Description == "[null]" ? null :  objGC_CodeTypeRelationEN.Description; //描述
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.UpdDate = objGC_CodeTypeRelationEN.UpdDate == "[null]" ? null :  objGC_CodeTypeRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGC_CodeTypeRelation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGC_CodeTypeRelationEN.UpdUser = objGC_CodeTypeRelationEN.UpdUser == "[null]" ? null :  objGC_CodeTypeRelationEN.UpdUser; //修改者
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
 /// <param name = "objGC_CodeTypeRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
try
{
if (objGC_CodeTypeRelationEN.ParentCodeTypeId == "[null]") objGC_CodeTypeRelationEN.ParentCodeTypeId = null; //父代码类型Id
if (objGC_CodeTypeRelationEN.ChildCodeTypeId == "[null]") objGC_CodeTypeRelationEN.ChildCodeTypeId = null; //子代码类型Id
if (objGC_CodeTypeRelationEN.CtRelationTypeId == "[null]") objGC_CodeTypeRelationEN.CtRelationTypeId = null; //Ct关系类型Id
if (objGC_CodeTypeRelationEN.Description == "[null]") objGC_CodeTypeRelationEN.Description = null; //描述
if (objGC_CodeTypeRelationEN.UpdDate == "[null]") objGC_CodeTypeRelationEN.UpdDate = null; //修改日期
if (objGC_CodeTypeRelationEN.UpdUser == "[null]") objGC_CodeTypeRelationEN.UpdUser = null; //修改者
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
public static void CheckPropertyNew(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 GC_CodeTypeRelationDA.CheckPropertyNew(objGC_CodeTypeRelationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
 GC_CodeTypeRelationDA.CheckProperty4Condition(objGC_CodeTypeRelationEN);
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
if (clsGC_CodeTypeRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGC_CodeTypeRelationBL没有刷新缓存机制(clsGC_CodeTypeRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationId");
//if (arrGC_CodeTypeRelationObjLstCache == null)
//{
//arrGC_CodeTypeRelationObjLstCache = GC_CodeTypeRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGC_CodeTypeRelationEN GetObjByRelationIdCache(long lngRelationId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGC_CodeTypeRelationEN._CurrTabName);
List<clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLstCache = GetObjLstCache();
IEnumerable <clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLst_Sel =
arrGC_CodeTypeRelationObjLstCache
.Where(x=> x.RelationId == lngRelationId 
);
if (arrGC_CodeTypeRelationObjLst_Sel.Count() == 0)
{
   clsGC_CodeTypeRelationEN obj = clsGC_CodeTypeRelationBL.GetObjByRelationId(lngRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGC_CodeTypeRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetAllGC_CodeTypeRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLstCache = GetObjLstCache(); 
return arrGC_CodeTypeRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGC_CodeTypeRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGC_CodeTypeRelationEN._CurrTabName);
List<clsGC_CodeTypeRelationEN> arrGC_CodeTypeRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGC_CodeTypeRelationObjLstCache;
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
string strKey = string.Format("{0}", clsGC_CodeTypeRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGC_CodeTypeRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGC_CodeTypeRelationEN._RefreshTimeLst.Count == 0) return "";
return clsGC_CodeTypeRelationEN._RefreshTimeLst[clsGC_CodeTypeRelationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsGC_CodeTypeRelationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGC_CodeTypeRelationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGC_CodeTypeRelationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGC_CodeTypeRelationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GC_CodeTypeRelation(GC_代码类型关系)
 /// 唯一性条件:ChildCodeTypeId_ParentCodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationEN)
{
//检测记录是否存在
string strResult = GC_CodeTypeRelationDA.GetUniCondStr(objGC_CodeTypeRelationEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-06-05
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngRelationId)
{
if (strInFldName != conGC_CodeTypeRelation.RelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGC_CodeTypeRelation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGC_CodeTypeRelation._AttributeName));
throw new Exception(strMsg);
}
var objGC_CodeTypeRelation = clsGC_CodeTypeRelationBL.GetObjByRelationIdCache(lngRelationId);
if (objGC_CodeTypeRelation == null) return "";
return objGC_CodeTypeRelation[strOutFldName].ToString();
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
int intRecCount = clsGC_CodeTypeRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsGC_CodeTypeRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGC_CodeTypeRelationDA.GetRecCount();
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
int intRecCount = clsGC_CodeTypeRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGC_CodeTypeRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGC_CodeTypeRelationEN objGC_CodeTypeRelationCond)
{
List<clsGC_CodeTypeRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGC_CodeTypeRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGC_CodeTypeRelation._AttributeName)
{
if (objGC_CodeTypeRelationCond.IsUpdated(strFldName) == false) continue;
if (objGC_CodeTypeRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGC_CodeTypeRelationCond[strFldName].ToString());
}
else
{
if (objGC_CodeTypeRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGC_CodeTypeRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGC_CodeTypeRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGC_CodeTypeRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGC_CodeTypeRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGC_CodeTypeRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGC_CodeTypeRelationCond[strFldName]));
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
 List<string> arrList = clsGC_CodeTypeRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GC_CodeTypeRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GC_CodeTypeRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GC_CodeTypeRelationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGC_CodeTypeRelationDA.SetFldValue(clsGC_CodeTypeRelationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GC_CodeTypeRelationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGC_CodeTypeRelationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGC_CodeTypeRelationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGC_CodeTypeRelationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GC_CodeTypeRelation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**关系Id*/ 
 strCreateTabCode.Append(" RelationId bigint primary key identity, "); 
 // /**父代码类型Id*/ 
 strCreateTabCode.Append(" ParentCodeTypeId char(4) Null, "); 
 // /**子代码类型Id*/ 
 strCreateTabCode.Append(" ChildCodeTypeId char(4) Null, "); 
 // /**Ct关系类型Id*/ 
 strCreateTabCode.Append(" CtRelationTypeId char(2) Null, "); 
 // /**描述*/ 
 strCreateTabCode.Append(" Description varchar(300) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**子代码类型名*/ 
 strCreateTabCode.Append(" ChildCodeTypeName varchar(50) Null, "); 
 // /**箭头类型*/ 
 strCreateTabCode.Append(" ArrowType varchar(20) Null, "); 
 // /**关系类型名*/ 
 strCreateTabCode.Append(" RelationTypeName varchar(50) Null, "); 
 // /**父代码类型名*/ 
 strCreateTabCode.Append(" ParentCodeTypeName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// GC_代码类型关系(GC_CodeTypeRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GC_CodeTypeRelation : clsCommFun4BL
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
clsGC_CodeTypeRelationBL.ReFreshThisCache();
}
}

}