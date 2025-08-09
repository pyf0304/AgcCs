
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlSP_ParaBL
 表名:SqlSP_Para(00050183)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
public static class  clsSqlSP_ParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlSP_ParaEN GetObj(this K_mId_SqlSP_Para myKey)
{
clsSqlSP_ParaEN objSqlSP_ParaEN = clsSqlSP_ParaBL.SqlSP_ParaDA.GetObjBymId(myKey.Value);
return objSqlSP_ParaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlSP_ParaEN) == false)
{
var strMsg = string.Format("记录已经存在!存储过程流水号 = [{0}],参数名 = [{1}]的数据已经存在!(in clsSqlSP_ParaBL.AddNewRecord)", objSqlSP_ParaEN.IdStoreProcedure,objSqlSP_ParaEN.ParaName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSqlSP_ParaBL.SqlSP_ParaDA.AddNewRecordBySQL2(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNeedCheckUniqueness = true)
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
objSqlSP_ParaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSqlSP_ParaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(存储过程流水号(IdStoreProcedure)=[{0}],参数名(ParaName)=[{1}])已经存在,不能重复!", objSqlSP_ParaEN.IdStoreProcedure, objSqlSP_ParaEN.ParaName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSqlSP_ParaEN.AddNewRecord();
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlSP_ParaEN) == false)
{
var strMsg = string.Format("记录已经存在!存储过程流水号 = [{0}],参数名 = [{1}]的数据已经存在!(in clsSqlSP_ParaBL.AddNewRecordWithReturnKey)", objSqlSP_ParaEN.IdStoreProcedure,objSqlSP_ParaEN.ParaName);
throw new Exception(strMsg);
}
try
{
string strKey = clsSqlSP_ParaBL.SqlSP_ParaDA.AddNewRecordBySQL2WithReturnKey(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetmId(this clsSqlSP_ParaEN objSqlSP_ParaEN, long lngmId, string strComparisonOp="")
	{
objSqlSP_ParaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.mId) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.mId, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.mId] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetIdStoreProcedure(this clsSqlSP_ParaEN objSqlSP_ParaEN, long lngIdStoreProcedure, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngIdStoreProcedure, conSqlSP_Para.IdStoreProcedure);
objSqlSP_ParaEN.IdStoreProcedure = lngIdStoreProcedure; //存储过程流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.IdStoreProcedure) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.IdStoreProcedure, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.IdStoreProcedure] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetParaName(this clsSqlSP_ParaEN objSqlSP_ParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conSqlSP_Para.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, conSqlSP_Para.ParaName);
}
objSqlSP_ParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.ParaName) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.ParaName, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.ParaName] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetParaSize(this clsSqlSP_ParaEN objSqlSP_ParaEN, short shtParaSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtParaSize, conSqlSP_Para.ParaSize);
objSqlSP_ParaEN.ParaSize = shtParaSize; //参数长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.ParaSize) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.ParaSize, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.ParaSize] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetParaDataType(this clsSqlSP_ParaEN objSqlSP_ParaEN, string strParaDataType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaDataType, conSqlSP_Para.ParaDataType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaDataType, 20, conSqlSP_Para.ParaDataType);
}
objSqlSP_ParaEN.ParaDataType = strParaDataType; //参数数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.ParaDataType) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.ParaDataType, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.ParaDataType] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetParaDirection(this clsSqlSP_ParaEN objSqlSP_ParaEN, string strParaDirection, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaDirection, conSqlSP_Para.ParaDirection);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaDirection, 20, conSqlSP_Para.ParaDirection);
}
objSqlSP_ParaEN.ParaDirection = strParaDirection; //参数数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.ParaDirection) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.ParaDirection, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.ParaDirection] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetIsNullable(this clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNullable, conSqlSP_Para.IsNullable);
objSqlSP_ParaEN.IsNullable = bolIsNullable; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.IsNullable) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.IsNullable, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.IsNullable] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlSP_ParaEN SetSpId(this clsSqlSP_ParaEN objSqlSP_ParaEN, long lngSpId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSpId, conSqlSP_Para.SpId);
objSqlSP_ParaEN.SpId = lngSpId; //SP_ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlSP_ParaEN.dicFldComparisonOp.ContainsKey(conSqlSP_Para.SpId) == false)
{
objSqlSP_ParaEN.dicFldComparisonOp.Add(conSqlSP_Para.SpId, strComparisonOp);
}
else
{
objSqlSP_ParaEN.dicFldComparisonOp[conSqlSP_Para.SpId] = strComparisonOp;
}
}
return objSqlSP_ParaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSqlSP_ParaEN.CheckPropertyNew();
clsSqlSP_ParaEN objSqlSP_ParaCond = new clsSqlSP_ParaEN();
string strCondition = objSqlSP_ParaCond
.SetmId(objSqlSP_ParaEN.mId, "<>")
.SetIdStoreProcedure(objSqlSP_ParaEN.IdStoreProcedure, "=")
.SetParaName(objSqlSP_ParaEN.ParaName, "=")
.GetCombineCondition();
objSqlSP_ParaEN._IsCheckProperty = true;
bool bolIsExist = clsSqlSP_ParaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_StoreProcedure_ParaName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSqlSP_ParaEN.Update();
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
 /// <param name = "objSqlSP_Para">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSqlSP_ParaEN objSqlSP_Para)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSqlSP_ParaEN objSqlSP_ParaCond = new clsSqlSP_ParaEN();
string strCondition = objSqlSP_ParaCond
.SetIdStoreProcedure(objSqlSP_Para.IdStoreProcedure, "=")
.SetParaName(objSqlSP_Para.ParaName, "=")
.GetCombineCondition();
objSqlSP_Para._IsCheckProperty = true;
bool bolIsExist = clsSqlSP_ParaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSqlSP_Para.mId = clsSqlSP_ParaBL.GetFirstID_S(strCondition);
objSqlSP_Para.UpdateWithCondition(strCondition);
}
else
{
objSqlSP_Para.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlSP_ParaBL.SqlSP_ParaDA.UpdateBySql2(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlSP_ParaEN objSqlSP_ParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSqlSP_ParaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlSP_ParaBL.SqlSP_ParaDA.UpdateBySql2(objSqlSP_ParaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlSP_ParaEN objSqlSP_ParaEN, string strWhereCond)
{
try
{
bool bolResult = clsSqlSP_ParaBL.SqlSP_ParaDA.UpdateBySqlWithCondition(objSqlSP_ParaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlSP_ParaEN objSqlSP_ParaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSqlSP_ParaBL.SqlSP_ParaDA.UpdateBySqlWithConditionTransaction(objSqlSP_ParaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
public static int Delete(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
try
{
int intRecNum = clsSqlSP_ParaBL.SqlSP_ParaDA.DelRecord(objSqlSP_ParaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaENS">源对象</param>
 /// <param name = "objSqlSP_ParaENT">目标对象</param>
 public static void CopyTo(this clsSqlSP_ParaEN objSqlSP_ParaENS, clsSqlSP_ParaEN objSqlSP_ParaENT)
{
try
{
objSqlSP_ParaENT.mId = objSqlSP_ParaENS.mId; //mId
objSqlSP_ParaENT.IdStoreProcedure = objSqlSP_ParaENS.IdStoreProcedure; //存储过程流水号
objSqlSP_ParaENT.ParaName = objSqlSP_ParaENS.ParaName; //参数名
objSqlSP_ParaENT.ParaSize = objSqlSP_ParaENS.ParaSize; //参数长度
objSqlSP_ParaENT.ParaDataType = objSqlSP_ParaENS.ParaDataType; //参数数据类型
objSqlSP_ParaENT.ParaDirection = objSqlSP_ParaENS.ParaDirection; //参数数据类型
objSqlSP_ParaENT.IsNullable = objSqlSP_ParaENS.IsNullable; //是否可空
objSqlSP_ParaENT.SpId = objSqlSP_ParaENS.SpId; //SP_ID
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
 /// <param name = "objSqlSP_ParaENS">源对象</param>
 /// <returns>目标对象=>clsSqlSP_ParaEN:objSqlSP_ParaENT</returns>
 public static clsSqlSP_ParaEN CopyTo(this clsSqlSP_ParaEN objSqlSP_ParaENS)
{
try
{
 clsSqlSP_ParaEN objSqlSP_ParaENT = new clsSqlSP_ParaEN()
{
mId = objSqlSP_ParaENS.mId, //mId
IdStoreProcedure = objSqlSP_ParaENS.IdStoreProcedure, //存储过程流水号
ParaName = objSqlSP_ParaENS.ParaName, //参数名
ParaSize = objSqlSP_ParaENS.ParaSize, //参数长度
ParaDataType = objSqlSP_ParaENS.ParaDataType, //参数数据类型
ParaDirection = objSqlSP_ParaENS.ParaDirection, //参数数据类型
IsNullable = objSqlSP_ParaENS.IsNullable, //是否可空
SpId = objSqlSP_ParaENS.SpId, //SP_ID
};
 return objSqlSP_ParaENT;
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
public static void CheckPropertyNew(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 clsSqlSP_ParaBL.SqlSP_ParaDA.CheckPropertyNew(objSqlSP_ParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 clsSqlSP_ParaBL.SqlSP_ParaDA.CheckProperty4Condition(objSqlSP_ParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlSP_ParaEN objSqlSP_ParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.mId) == true)
{
string strComparisonOpmId = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlSP_Para.mId, objSqlSP_ParaCond.mId, strComparisonOpmId);
}
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.IdStoreProcedure) == true)
{
string strComparisonOpIdStoreProcedure = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.IdStoreProcedure];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlSP_Para.IdStoreProcedure, objSqlSP_ParaCond.IdStoreProcedure, strComparisonOpIdStoreProcedure);
}
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.ParaName) == true)
{
string strComparisonOpParaName = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlSP_Para.ParaName, objSqlSP_ParaCond.ParaName, strComparisonOpParaName);
}
//数据类型short(tinyint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.ParaDataType) == true)
{
string strComparisonOpParaDataType = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.ParaDataType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlSP_Para.ParaDataType, objSqlSP_ParaCond.ParaDataType, strComparisonOpParaDataType);
}
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.ParaDirection) == true)
{
string strComparisonOpParaDirection = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.ParaDirection];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlSP_Para.ParaDirection, objSqlSP_ParaCond.ParaDirection, strComparisonOpParaDirection);
}
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.IsNullable) == true)
{
if (objSqlSP_ParaCond.IsNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSqlSP_Para.IsNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSqlSP_Para.IsNullable);
}
}
if (objSqlSP_ParaCond.IsUpdated(conSqlSP_Para.SpId) == true)
{
string strComparisonOpSpId = objSqlSP_ParaCond.dicFldComparisonOp[conSqlSP_Para.SpId];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlSP_Para.SpId, objSqlSP_ParaCond.SpId, strComparisonOpSpId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SqlSP_Para(SQL存储过程参数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_StoreProcedure_ParaName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSqlSP_ParaEN == null) return true;
if (objSqlSP_ParaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStoreProcedure = '{0}'", objSqlSP_ParaEN.IdStoreProcedure);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objSqlSP_ParaEN.ParaName);
if (clsSqlSP_ParaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSqlSP_ParaEN.mId);
 sbCondition.AppendFormat(" and IdStoreProcedure = '{0}'", objSqlSP_ParaEN.IdStoreProcedure);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objSqlSP_ParaEN.ParaName);
if (clsSqlSP_ParaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SqlSP_Para(SQL存储过程参数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_StoreProcedure_ParaName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlSP_ParaEN == null) return "";
if (objSqlSP_ParaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStoreProcedure = '{0}'", objSqlSP_ParaEN.IdStoreProcedure);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objSqlSP_ParaEN.ParaName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSqlSP_ParaEN.mId);
 sbCondition.AppendFormat(" and IdStoreProcedure = '{0}'", objSqlSP_ParaEN.IdStoreProcedure);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objSqlSP_ParaEN.ParaName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SqlSP_Para
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// SQL存储过程参数(SqlSP_Para)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSqlSP_ParaBL
{
public static RelatedActions_SqlSP_Para relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSqlSP_ParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSqlSP_ParaDA SqlSP_ParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSqlSP_ParaDA();
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
 public clsSqlSP_ParaBL()
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
if (string.IsNullOrEmpty(clsSqlSP_ParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlSP_ParaEN._ConnectString);
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
public static DataTable GetDataTable_SqlSP_Para(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SqlSP_ParaDA.GetDataTable_SqlSP_Para(strWhereCond);
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
objDT = SqlSP_ParaDA.GetDataTable(strWhereCond);
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
objDT = SqlSP_ParaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SqlSP_ParaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SqlSP_ParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SqlSP_ParaDA.GetDataTable_Top(objTopPara);
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
objDT = SqlSP_ParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SqlSP_ParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SqlSP_ParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsSqlSP_ParaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
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
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSqlSP_ParaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsSqlSP_ParaEN._CurrTabName);
List<clsSqlSP_ParaEN> arrSqlSP_ParaObjLstCache = GetObjLstCache();
IEnumerable <clsSqlSP_ParaEN> arrSqlSP_ParaObjLst_Sel =
arrSqlSP_ParaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrSqlSP_ParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlSP_ParaEN> GetObjLst(string strWhereCond)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
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
public static List<clsSqlSP_ParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSqlSP_ParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSqlSP_ParaEN> GetSubObjLstCache(clsSqlSP_ParaEN objSqlSP_ParaCond)
{
List<clsSqlSP_ParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSqlSP_ParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlSP_Para._AttributeName)
{
if (objSqlSP_ParaCond.IsUpdated(strFldName) == false) continue;
if (objSqlSP_ParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlSP_ParaCond[strFldName].ToString());
}
else
{
if (objSqlSP_ParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlSP_ParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlSP_ParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlSP_ParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlSP_ParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlSP_ParaCond[strFldName]));
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
public static List<clsSqlSP_ParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
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
public static List<clsSqlSP_ParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
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
List<clsSqlSP_ParaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSqlSP_ParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlSP_ParaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSqlSP_ParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
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
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
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
public static List<clsSqlSP_ParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSqlSP_ParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSqlSP_ParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
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
public static List<clsSqlSP_ParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlSP_ParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlSP_ParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSqlSP_Para(ref clsSqlSP_ParaEN objSqlSP_ParaEN)
{
bool bolResult = SqlSP_ParaDA.GetSqlSP_Para(ref objSqlSP_ParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlSP_ParaEN GetObjBymId(long lngmId)
{
clsSqlSP_ParaEN objSqlSP_ParaEN = SqlSP_ParaDA.GetObjBymId(lngmId);
return objSqlSP_ParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSqlSP_ParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSqlSP_ParaEN objSqlSP_ParaEN = SqlSP_ParaDA.GetFirstObj(strWhereCond);
 return objSqlSP_ParaEN;
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
public static clsSqlSP_ParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSqlSP_ParaEN objSqlSP_ParaEN = SqlSP_ParaDA.GetObjByDataRow(objRow);
 return objSqlSP_ParaEN;
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
public static clsSqlSP_ParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSqlSP_ParaEN objSqlSP_ParaEN = SqlSP_ParaDA.GetObjByDataRow(objRow);
 return objSqlSP_ParaEN;
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
 /// <param name = "lstSqlSP_ParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlSP_ParaEN GetObjBymIdFromList(long lngmId, List<clsSqlSP_ParaEN> lstSqlSP_ParaObjLst)
{
foreach (clsSqlSP_ParaEN objSqlSP_ParaEN in lstSqlSP_ParaObjLst)
{
if (objSqlSP_ParaEN.mId == lngmId)
{
return objSqlSP_ParaEN;
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
 lngmId = new clsSqlSP_ParaDA().GetFirstID(strWhereCond);
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
 arrList = SqlSP_ParaDA.GetID(strWhereCond);
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
bool bolIsExist = SqlSP_ParaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = SqlSP_ParaDA.IsExist(lngmId);
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
 bolIsExist = clsSqlSP_ParaDA.IsExistTable();
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
 bolIsExist = SqlSP_ParaDA.IsExistTable(strTabName);
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlSP_ParaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!存储过程流水号 = [{0}],参数名 = [{1}]的数据已经存在!(in clsSqlSP_ParaBL.AddNewRecordBySql2)", objSqlSP_ParaEN.IdStoreProcedure,objSqlSP_ParaEN.ParaName);
throw new Exception(strMsg);
}
try
{
bool bolResult = SqlSP_ParaDA.AddNewRecordBySQL2(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSqlSP_ParaEN objSqlSP_ParaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlSP_ParaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!存储过程流水号 = [{0}],参数名 = [{1}]的数据已经存在!(in clsSqlSP_ParaBL.AddNewRecordBySql2WithReturnKey)", objSqlSP_ParaEN.IdStoreProcedure,objSqlSP_ParaEN.ParaName);
throw new Exception(strMsg);
}
try
{
string strKey = SqlSP_ParaDA.AddNewRecordBySQL2WithReturnKey(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
try
{
bool bolResult = SqlSP_ParaDA.Update(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SqlSP_ParaDA.UpdateBySql2(objSqlSP_ParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlSP_ParaBL.ReFreshCache();

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
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
 clsSqlSP_ParaEN objSqlSP_ParaEN = clsSqlSP_ParaBL.GetObjBymId(lngmId);

if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(objSqlSP_ParaEN.mId, "SetUpdDate");
}
if (objSqlSP_ParaEN != null)
{
int intRecNum = SqlSP_ParaDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
//删除与表:[SqlSP_Para]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSqlSP_Para.mId,
//lngmId);
//        clsSqlSP_ParaBL.DelSqlSP_ParasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlSP_ParaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlSP_ParaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSqlSP_ParaBL.relatedActions != null)
{
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = SqlSP_ParaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSqlSP_Paras(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsSqlSP_ParaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = SqlSP_ParaDA.DelSqlSP_Para(arrmIdLst);
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
public static int DelSqlSP_ParasByCond(string strWhereCond)
{
try
{
if (clsSqlSP_ParaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsSqlSP_ParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = SqlSP_ParaDA.DelSqlSP_Para(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SqlSP_Para]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
//删除与表:[SqlSP_Para]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlSP_ParaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlSP_ParaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objSqlSP_ParaENS">源对象</param>
 /// <param name = "objSqlSP_ParaENT">目标对象</param>
 public static void CopyTo(clsSqlSP_ParaEN objSqlSP_ParaENS, clsSqlSP_ParaEN objSqlSP_ParaENT)
{
try
{
objSqlSP_ParaENT.mId = objSqlSP_ParaENS.mId; //mId
objSqlSP_ParaENT.IdStoreProcedure = objSqlSP_ParaENS.IdStoreProcedure; //存储过程流水号
objSqlSP_ParaENT.ParaName = objSqlSP_ParaENS.ParaName; //参数名
objSqlSP_ParaENT.ParaSize = objSqlSP_ParaENS.ParaSize; //参数长度
objSqlSP_ParaENT.ParaDataType = objSqlSP_ParaENS.ParaDataType; //参数数据类型
objSqlSP_ParaENT.ParaDirection = objSqlSP_ParaENS.ParaDirection; //参数数据类型
objSqlSP_ParaENT.IsNullable = objSqlSP_ParaENS.IsNullable; //是否可空
objSqlSP_ParaENT.SpId = objSqlSP_ParaENS.SpId; //SP_ID
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
 /// <param name = "objSqlSP_ParaEN">源简化对象</param>
 public static void SetUpdFlag(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
try
{
objSqlSP_ParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSqlSP_ParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSqlSP_Para.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.mId = objSqlSP_ParaEN.mId; //mId
}
if (arrFldSet.Contains(conSqlSP_Para.IdStoreProcedure, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.IdStoreProcedure = objSqlSP_ParaEN.IdStoreProcedure; //存储过程流水号
}
if (arrFldSet.Contains(conSqlSP_Para.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.ParaName = objSqlSP_ParaEN.ParaName; //参数名
}
if (arrFldSet.Contains(conSqlSP_Para.ParaSize, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.ParaSize = objSqlSP_ParaEN.ParaSize; //参数长度
}
if (arrFldSet.Contains(conSqlSP_Para.ParaDataType, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.ParaDataType = objSqlSP_ParaEN.ParaDataType; //参数数据类型
}
if (arrFldSet.Contains(conSqlSP_Para.ParaDirection, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.ParaDirection = objSqlSP_ParaEN.ParaDirection; //参数数据类型
}
if (arrFldSet.Contains(conSqlSP_Para.IsNullable, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.IsNullable = objSqlSP_ParaEN.IsNullable; //是否可空
}
if (arrFldSet.Contains(conSqlSP_Para.SpId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlSP_ParaEN.SpId = objSqlSP_ParaEN.SpId; //SP_ID
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
 /// <param name = "objSqlSP_ParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
try
{
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
public static void CheckPropertyNew(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 SqlSP_ParaDA.CheckPropertyNew(objSqlSP_ParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 SqlSP_ParaDA.CheckProperty4Condition(objSqlSP_ParaEN);
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
if (clsSqlSP_ParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlSP_ParaBL没有刷新缓存机制(clsSqlSP_ParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSqlSP_ParaObjLstCache == null)
//{
//arrSqlSP_ParaObjLstCache = SqlSP_ParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlSP_ParaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSqlSP_ParaEN._CurrTabName);
List<clsSqlSP_ParaEN> arrSqlSP_ParaObjLstCache = GetObjLstCache();
IEnumerable <clsSqlSP_ParaEN> arrSqlSP_ParaObjLst_Sel =
arrSqlSP_ParaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrSqlSP_ParaObjLst_Sel.Count() == 0)
{
   clsSqlSP_ParaEN obj = clsSqlSP_ParaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSqlSP_ParaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlSP_ParaEN> GetAllSqlSP_ParaObjLstCache()
{
//获取缓存中的对象列表
List<clsSqlSP_ParaEN> arrSqlSP_ParaObjLstCache = GetObjLstCache(); 
return arrSqlSP_ParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlSP_ParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSqlSP_ParaEN._CurrTabName);
List<clsSqlSP_ParaEN> arrSqlSP_ParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSqlSP_ParaObjLstCache;
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
string strKey = string.Format("{0}", clsSqlSP_ParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSqlSP_ParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSqlSP_ParaEN._RefreshTimeLst.Count == 0) return "";
return clsSqlSP_ParaEN._RefreshTimeLst[clsSqlSP_ParaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsSqlSP_ParaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSqlSP_ParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSqlSP_ParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSqlSP_ParaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SqlSP_Para(SQL存储过程参数)
 /// 唯一性条件:id_StoreProcedure_ParaName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检测记录是否存在
string strResult = SqlSP_ParaDA.GetUniCondStr(objSqlSP_ParaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conSqlSP_Para.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSqlSP_Para._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSqlSP_Para._AttributeName));
throw new Exception(strMsg);
}
var objSqlSP_Para = clsSqlSP_ParaBL.GetObjBymIdCache(lngmId);
if (objSqlSP_Para == null) return "";
return objSqlSP_Para[strOutFldName].ToString();
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
int intRecCount = clsSqlSP_ParaDA.GetRecCount(strTabName);
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
int intRecCount = clsSqlSP_ParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSqlSP_ParaDA.GetRecCount();
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
int intRecCount = clsSqlSP_ParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSqlSP_ParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSqlSP_ParaEN objSqlSP_ParaCond)
{
List<clsSqlSP_ParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSqlSP_ParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlSP_Para._AttributeName)
{
if (objSqlSP_ParaCond.IsUpdated(strFldName) == false) continue;
if (objSqlSP_ParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlSP_ParaCond[strFldName].ToString());
}
else
{
if (objSqlSP_ParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlSP_ParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlSP_ParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlSP_ParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlSP_ParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlSP_ParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlSP_ParaCond[strFldName]));
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
 List<string> arrList = clsSqlSP_ParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SqlSP_ParaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SqlSP_ParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SqlSP_ParaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlSP_ParaDA.SetFldValue(clsSqlSP_ParaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SqlSP_ParaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlSP_ParaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlSP_ParaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlSP_ParaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SqlSP_Para] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**存储过程流水号*/ 
 strCreateTabCode.Append(" IdStoreProcedure bigint not Null, "); 
 // /**参数名*/ 
 strCreateTabCode.Append(" ParaName varchar(50) not Null, "); 
 // /**参数长度*/ 
 strCreateTabCode.Append(" ParaSize tinyint not Null, "); 
 // /**参数数据类型*/ 
 strCreateTabCode.Append(" ParaDataType varchar(20) not Null, "); 
 // /**参数数据类型*/ 
 strCreateTabCode.Append(" ParaDirection varchar(20) not Null, "); 
 // /**是否可空*/ 
 strCreateTabCode.Append(" IsNullable bit not Null, "); 
 // /**SP_ID*/ 
 strCreateTabCode.Append(" SpId bigint not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// SQL存储过程参数(SqlSP_Para)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SqlSP_Para : clsCommFun4BL
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
clsSqlSP_ParaBL.ReFreshThisCache();
}
}

}