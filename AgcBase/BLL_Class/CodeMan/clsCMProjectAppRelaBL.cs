
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectAppRelaBL
 表名:CMProjectAppRela(00050600)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMProjectAppRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectAppRelaEN GetObj(this K_CMProjectAppRelaId_CMProjectAppRela myKey)
{
clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaBL.CMProjectAppRelaDA.GetObjByCMProjectAppRelaId(myKey.Value);
return objCMProjectAppRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectAppRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsCMProjectAppRelaBL.AddNewRecord)", objCMProjectAppRelaEN.CmPrjId,objCMProjectAppRelaEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMProjectAppRelaBL.CMProjectAppRelaDA.AddNewRecordBySQL2(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objCMProjectAppRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMProjectAppRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Cm工程Id(CmPrjId)=[{0}],应用程序类型ID(ApplicationTypeId)=[{1}])已经存在,不能重复!", objCMProjectAppRelaEN.CmPrjId, objCMProjectAppRelaEN.ApplicationTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMProjectAppRelaEN.AddNewRecord();
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMProjectAppRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsCMProjectAppRelaBL.AddNewRecordWithReturnKey)", objCMProjectAppRelaEN.CmPrjId,objCMProjectAppRelaEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMProjectAppRelaBL.CMProjectAppRelaDA.AddNewRecordBySQL2WithReturnKey(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetCMProjectAppRelaId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
objCMProjectAppRelaEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.CMProjectAppRelaId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.CMProjectAppRelaId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.CMProjectAppRelaId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetCmPrjId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMProjectAppRela.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProjectAppRela.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProjectAppRela.CmPrjId);
}
objCMProjectAppRelaEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.CmPrjId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.CmPrjId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.CmPrjId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetApplicationTypeId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMProjectAppRela.ApplicationTypeId);
objCMProjectAppRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.ApplicationTypeId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.ApplicationTypeId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.ApplicationTypeId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetOrderNum(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMProjectAppRela.OrderNum);
objCMProjectAppRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.OrderNum) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.OrderNum, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.OrderNum] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetPrjId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMProjectAppRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMProjectAppRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMProjectAppRela.PrjId);
}
objCMProjectAppRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.PrjId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.PrjId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.PrjId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetUpdDate(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProjectAppRela.UpdDate);
}
objCMProjectAppRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.UpdDate) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.UpdDate, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.UpdDate] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetUpdUser(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMProjectAppRela.UpdUser);
}
objCMProjectAppRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.UpdUser) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.UpdUser, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.UpdUser] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetMemo(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProjectAppRela.Memo);
}
objCMProjectAppRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.Memo) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.Memo, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.Memo] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMProjectAppRelaEN.CheckPropertyNew();
clsCMProjectAppRelaEN objCMProjectAppRelaCond = new clsCMProjectAppRelaEN();
string strCondition = objCMProjectAppRelaCond
.SetCMProjectAppRelaId(objCMProjectAppRelaEN.CMProjectAppRelaId, "<>")
.SetCmPrjId(objCMProjectAppRelaEN.CmPrjId, "=")
.SetApplicationTypeId(objCMProjectAppRelaEN.ApplicationTypeId, "=")
.GetCombineCondition();
objCMProjectAppRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCMProjectAppRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CmPrjId_ApplicationTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMProjectAppRelaEN.Update();
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
 /// <param name = "objCMProjectAppRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMProjectAppRelaEN objCMProjectAppRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMProjectAppRelaEN objCMProjectAppRelaCond = new clsCMProjectAppRelaEN();
string strCondition = objCMProjectAppRelaCond
.SetCmPrjId(objCMProjectAppRela.CmPrjId, "=")
.SetApplicationTypeId(objCMProjectAppRela.ApplicationTypeId, "=")
.GetCombineCondition();
objCMProjectAppRela._IsCheckProperty = true;
bool bolIsExist = clsCMProjectAppRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMProjectAppRela.CMProjectAppRelaId = clsCMProjectAppRelaBL.GetFirstID_S(strCondition);
objCMProjectAppRela.UpdateWithCondition(strCondition);
}
else
{
objCMProjectAppRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectAppRelaBL.CMProjectAppRelaDA.UpdateBySql2(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMProjectAppRelaBL.CMProjectAppRelaDA.UpdateBySql2(objCMProjectAppRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCMProjectAppRelaBL.CMProjectAppRelaDA.UpdateBySqlWithCondition(objCMProjectAppRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMProjectAppRelaBL.CMProjectAppRelaDA.UpdateBySqlWithConditionTransaction(objCMProjectAppRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
try
{
int intRecNum = clsCMProjectAppRelaBL.CMProjectAppRelaDA.DelRecord(objCMProjectAppRelaEN.CMProjectAppRelaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaENS">源对象</param>
 /// <param name = "objCMProjectAppRelaENT">目标对象</param>
 public static void CopyTo(this clsCMProjectAppRelaEN objCMProjectAppRelaENS, clsCMProjectAppRelaEN objCMProjectAppRelaENT)
{
try
{
objCMProjectAppRelaENT.CMProjectAppRelaId = objCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objCMProjectAppRelaENT.CmPrjId = objCMProjectAppRelaENS.CmPrjId; //Cm工程Id
objCMProjectAppRelaENT.ApplicationTypeId = objCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objCMProjectAppRelaENT.OrderNum = objCMProjectAppRelaENS.OrderNum; //序号
objCMProjectAppRelaENT.PrjId = objCMProjectAppRelaENS.PrjId; //工程Id
objCMProjectAppRelaENT.UpdDate = objCMProjectAppRelaENS.UpdDate; //修改日期
objCMProjectAppRelaENT.UpdUser = objCMProjectAppRelaENS.UpdUser; //修改者
objCMProjectAppRelaENT.Memo = objCMProjectAppRelaENS.Memo; //说明
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
 /// <param name = "objCMProjectAppRelaENS">源对象</param>
 /// <returns>目标对象=>clsCMProjectAppRelaEN:objCMProjectAppRelaENT</returns>
 public static clsCMProjectAppRelaEN CopyTo(this clsCMProjectAppRelaEN objCMProjectAppRelaENS)
{
try
{
 clsCMProjectAppRelaEN objCMProjectAppRelaENT = new clsCMProjectAppRelaEN()
{
CMProjectAppRelaId = objCMProjectAppRelaENS.CMProjectAppRelaId, //Cm工程应用关系Id
CmPrjId = objCMProjectAppRelaENS.CmPrjId, //Cm工程Id
ApplicationTypeId = objCMProjectAppRelaENS.ApplicationTypeId, //应用程序类型ID
OrderNum = objCMProjectAppRelaENS.OrderNum, //序号
PrjId = objCMProjectAppRelaENS.PrjId, //工程Id
UpdDate = objCMProjectAppRelaENS.UpdDate, //修改日期
UpdUser = objCMProjectAppRelaENS.UpdUser, //修改者
Memo = objCMProjectAppRelaENS.Memo, //说明
};
 return objCMProjectAppRelaENT;
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
public static void CheckPropertyNew(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 clsCMProjectAppRelaBL.CMProjectAppRelaDA.CheckPropertyNew(objCMProjectAppRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 clsCMProjectAppRelaBL.CMProjectAppRelaDA.CheckProperty4Condition(objCMProjectAppRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectAppRelaEN objCMProjectAppRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.CMProjectAppRelaId, objCMProjectAppRelaCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.CmPrjId, objCMProjectAppRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.ApplicationTypeId, objCMProjectAppRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.OrderNum, objCMProjectAppRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.PrjId) == true)
{
string strComparisonOpPrjId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.PrjId, objCMProjectAppRelaCond.PrjId, strComparisonOpPrjId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.UpdDate, objCMProjectAppRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.UpdUser, objCMProjectAppRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.Memo) == true)
{
string strComparisonOpMemo = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.Memo, objCMProjectAppRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMProjectAppRela(CM项目应用关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CmPrjId_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectAppRelaEN == null) return true;
if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
if (clsCMProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objCMProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
if (clsCMProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMProjectAppRela(CM项目应用关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CmPrjId_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectAppRelaEN == null) return "";
if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objCMProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMProjectAppRela
{
public virtual bool UpdRelaTabDate(long lngCMProjectAppRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectAppRelaBL
{
public static RelatedActions_CMProjectAppRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMProjectAppRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMProjectAppRelaDA CMProjectAppRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMProjectAppRelaDA();
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
 public clsCMProjectAppRelaBL()
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
if (string.IsNullOrEmpty(clsCMProjectAppRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMProjectAppRelaEN._ConnectString);
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
public static DataTable GetDataTable_CMProjectAppRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMProjectAppRelaDA.GetDataTable_CMProjectAppRela(strWhereCond);
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
objDT = CMProjectAppRelaDA.GetDataTable(strWhereCond);
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
objDT = CMProjectAppRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMProjectAppRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMProjectAppRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMProjectAppRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CMProjectAppRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaIdLst)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCMProjectAppRelaIdLst);
 string strWhereCond = string.Format("CMProjectAppRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLst_Sel =
arrCMProjectAppRelaObjLstCache
.Where(x => arrCMProjectAppRelaIdLst.Contains(x.CMProjectAppRelaId));
return arrCMProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLst(string strWhereCond)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
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
public static List<clsCMProjectAppRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMProjectAppRelaEN> GetSubObjLstCache(clsCMProjectAppRelaEN objCMProjectAppRelaCond)
{
 string strPrjId = objCMProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCMProjectAppRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCMProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProjectAppRela._AttributeName)
{
if (objCMProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objCMProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectAppRelaCond[strFldName]));
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
public static List<clsCMProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
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
public static List<clsCMProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
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
List<clsCMProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
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
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
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
public static List<clsCMProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
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
public static List<clsCMProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMProjectAppRelaEN> arrObjLst = new List<clsCMProjectAppRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMProjectAppRelaEN objCMProjectAppRelaEN = new clsCMProjectAppRelaEN();
try
{
objCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[conCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objCMProjectAppRelaEN.CmPrjId = objRow[conCMProjectAppRela.CmPrjId].ToString().Trim(); //Cm工程Id
objCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[conCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[conCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objCMProjectAppRelaEN.PrjId = objRow[conCMProjectAppRela.PrjId].ToString().Trim(); //工程Id
objCMProjectAppRelaEN.UpdDate = objRow[conCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objCMProjectAppRelaEN.UpdUser = objRow[conCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[conCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objCMProjectAppRelaEN.Memo = objRow[conCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[conCMProjectAppRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMProjectAppRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMProjectAppRela(ref clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
bool bolResult = CMProjectAppRelaDA.GetCMProjectAppRela(ref objCMProjectAppRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
clsCMProjectAppRelaEN objCMProjectAppRelaEN = CMProjectAppRelaDA.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
return objCMProjectAppRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMProjectAppRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = CMProjectAppRelaDA.GetFirstObj(strWhereCond);
 return objCMProjectAppRelaEN;
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
public static clsCMProjectAppRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = CMProjectAppRelaDA.GetObjByDataRow(objRow);
 return objCMProjectAppRelaEN;
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
public static clsCMProjectAppRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = CMProjectAppRelaDA.GetObjByDataRow(objRow);
 return objCMProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "lstCMProjectAppRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectAppRelaEN GetObjByCMProjectAppRelaIdFromList(long lngCMProjectAppRelaId, List<clsCMProjectAppRelaEN> lstCMProjectAppRelaObjLst)
{
foreach (clsCMProjectAppRelaEN objCMProjectAppRelaEN in lstCMProjectAppRelaObjLst)
{
if (objCMProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId)
{
return objCMProjectAppRelaEN;
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
 long lngCMProjectAppRelaId;
 try
 {
 lngCMProjectAppRelaId = new clsCMProjectAppRelaDA().GetFirstID(strWhereCond);
 return lngCMProjectAppRelaId;
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
 arrList = CMProjectAppRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CMProjectAppRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
bool bolIsExist = CMProjectAppRelaDA.IsExist(lngCMProjectAppRelaId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngCMProjectAppRelaId, string strOpUser)
{
clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
objCMProjectAppRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMProjectAppRelaEN.UpdUser = strOpUser;
return clsCMProjectAppRelaBL.UpdateBySql2(objCMProjectAppRelaEN);
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
 bolIsExist = clsCMProjectAppRelaDA.IsExistTable();
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
 bolIsExist = CMProjectAppRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMProjectAppRelaEN objCMProjectAppRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectAppRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsCMProjectAppRelaBL.AddNewRecordBySql2)", objCMProjectAppRelaEN.CmPrjId,objCMProjectAppRelaEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMProjectAppRelaDA.AddNewRecordBySQL2(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMProjectAppRelaEN objCMProjectAppRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMProjectAppRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],应用程序类型ID = [{1}]的数据已经存在!(in clsCMProjectAppRelaBL.AddNewRecordBySql2WithReturnKey)", objCMProjectAppRelaEN.CmPrjId,objCMProjectAppRelaEN.ApplicationTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = CMProjectAppRelaDA.AddNewRecordBySQL2WithReturnKey(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
try
{
bool bolResult = CMProjectAppRelaDA.Update(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMProjectAppRelaDA.UpdateBySql2(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaBL.ReFreshCache(objCMProjectAppRelaEN.PrjId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngCMProjectAppRelaId)
{
try
{
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);

if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(objCMProjectAppRelaEN.CMProjectAppRelaId, objCMProjectAppRelaEN.UpdUser);
}
if (objCMProjectAppRelaEN != null)
{
int intRecNum = CMProjectAppRelaDA.DelRecord(lngCMProjectAppRelaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
/// <param name="lngCMProjectAppRelaId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngCMProjectAppRelaId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
//删除与表:[CMProjectAppRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMProjectAppRela.CMProjectAppRelaId,
//lngCMProjectAppRelaId);
//        clsCMProjectAppRelaBL.DelCMProjectAppRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectAppRelaBL.DelRecord(lngCMProjectAppRelaId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectAppRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngCMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngCMProjectAppRelaId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMProjectAppRelaBL.relatedActions != null)
{
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(lngCMProjectAppRelaId, "UpdRelaTabDate");
}
bool bolResult = CMProjectAppRelaDA.DelRecord(lngCMProjectAppRelaId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCMProjectAppRelaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMProjectAppRelas(List<string> arrCMProjectAppRelaIdLst)
{
if (arrCMProjectAppRelaIdLst.Count == 0) return 0;
try
{
if (clsCMProjectAppRelaBL.relatedActions != null)
{
foreach (var strCMProjectAppRelaId in arrCMProjectAppRelaIdLst)
{
long lngCMProjectAppRelaId = long.Parse(strCMProjectAppRelaId);
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(lngCMProjectAppRelaId, "UpdRelaTabDate");
}
}
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(long.Parse(arrCMProjectAppRelaIdLst[0]));
int intDelRecNum = CMProjectAppRelaDA.DelCMProjectAppRela(arrCMProjectAppRelaIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
public static int DelCMProjectAppRelasByCond(string strWhereCond)
{
try
{
if (clsCMProjectAppRelaBL.relatedActions != null)
{
List<string> arrCMProjectAppRelaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCMProjectAppRelaId in arrCMProjectAppRelaId)
{
long lngCMProjectAppRelaId = long.Parse(strCMProjectAppRelaId);
clsCMProjectAppRelaBL.relatedActions.UpdRelaTabDate(lngCMProjectAppRelaId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conCMProjectAppRela.PrjId, strWhereCond);
int intRecNum = CMProjectAppRelaDA.DelCMProjectAppRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMProjectAppRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngCMProjectAppRelaId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngCMProjectAppRelaId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMProjectAppRelaDA.GetSpecSQLObj();
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
//删除与表:[CMProjectAppRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMProjectAppRelaBL.DelRecord(lngCMProjectAppRelaId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMProjectAppRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngCMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMProjectAppRelaENS">源对象</param>
 /// <param name = "objCMProjectAppRelaENT">目标对象</param>
 public static void CopyTo(clsCMProjectAppRelaEN objCMProjectAppRelaENS, clsCMProjectAppRelaEN objCMProjectAppRelaENT)
{
try
{
objCMProjectAppRelaENT.CMProjectAppRelaId = objCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objCMProjectAppRelaENT.CmPrjId = objCMProjectAppRelaENS.CmPrjId; //Cm工程Id
objCMProjectAppRelaENT.ApplicationTypeId = objCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objCMProjectAppRelaENT.OrderNum = objCMProjectAppRelaENS.OrderNum; //序号
objCMProjectAppRelaENT.PrjId = objCMProjectAppRelaENS.PrjId; //工程Id
objCMProjectAppRelaENT.UpdDate = objCMProjectAppRelaENS.UpdDate; //修改日期
objCMProjectAppRelaENT.UpdUser = objCMProjectAppRelaENS.UpdUser; //修改者
objCMProjectAppRelaENT.Memo = objCMProjectAppRelaENS.Memo; //说明
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
 /// <param name = "objCMProjectAppRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
try
{
objCMProjectAppRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMProjectAppRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMProjectAppRela.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.CMProjectAppRelaId = objCMProjectAppRelaEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(conCMProjectAppRela.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.CmPrjId = objCMProjectAppRelaEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conCMProjectAppRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.ApplicationTypeId = objCMProjectAppRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conCMProjectAppRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.OrderNum = objCMProjectAppRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCMProjectAppRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.PrjId = objCMProjectAppRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMProjectAppRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.UpdDate = objCMProjectAppRelaEN.UpdDate == "[null]" ? null :  objCMProjectAppRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMProjectAppRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.UpdUser = objCMProjectAppRelaEN.UpdUser == "[null]" ? null :  objCMProjectAppRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMProjectAppRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMProjectAppRelaEN.Memo = objCMProjectAppRelaEN.Memo == "[null]" ? null :  objCMProjectAppRelaEN.Memo; //说明
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
 /// <param name = "objCMProjectAppRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
try
{
if (objCMProjectAppRelaEN.UpdDate == "[null]") objCMProjectAppRelaEN.UpdDate = null; //修改日期
if (objCMProjectAppRelaEN.UpdUser == "[null]") objCMProjectAppRelaEN.UpdUser = null; //修改者
if (objCMProjectAppRelaEN.Memo == "[null]") objCMProjectAppRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 CMProjectAppRelaDA.CheckPropertyNew(objCMProjectAppRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 CMProjectAppRelaDA.CheckProperty4Condition(objCMProjectAppRelaEN);
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
if (clsCMProjectAppRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectAppRelaBL没有刷新缓存机制(clsCMProjectAppRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CMProjectAppRelaId");
//if (arrCMProjectAppRelaObjLstCache == null)
//{
//arrCMProjectAppRelaObjLstCache = CMProjectAppRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLst_Sel =
arrCMProjectAppRelaObjLstCache
.Where(x=> x.CMProjectAppRelaId == lngCMProjectAppRelaId 
);
if (arrCMProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsCMProjectAppRelaEN obj = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngCMProjectAppRelaId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCMProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetAllCMProjectAppRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCMProjectAppRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMProjectAppRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMProjectAppRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCMProjectAppRelaEN._RefreshTimeLst[clsCMProjectAppRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMProjectAppRelaBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMProjectAppRelaBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsCMProjectAppRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMProjectAppRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMProjectAppRelaBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMProjectAppRela(CM项目应用关系)
 /// 唯一性条件:CmPrjId_ApplicationTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检测记录是否存在
string strResult = CMProjectAppRelaDA.GetUniCondStr(objCMProjectAppRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngCMProjectAppRelaId, string strPrjId)
{
if (strInFldName != conCMProjectAppRela.CMProjectAppRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMProjectAppRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMProjectAppRela._AttributeName));
throw new Exception(strMsg);
}
var objCMProjectAppRela = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, strPrjId);
if (objCMProjectAppRela == null) return "";
return objCMProjectAppRela[strOutFldName].ToString();
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
int intRecCount = clsCMProjectAppRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCMProjectAppRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMProjectAppRelaDA.GetRecCount();
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
int intRecCount = clsCMProjectAppRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMProjectAppRelaEN objCMProjectAppRelaCond)
{
 string strPrjId = objCMProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCMProjectAppRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCMProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMProjectAppRela._AttributeName)
{
if (objCMProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objCMProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objCMProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMProjectAppRelaCond[strFldName]));
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
 List<string> arrList = clsCMProjectAppRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMProjectAppRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMProjectAppRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMProjectAppRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectAppRelaDA.SetFldValue(clsCMProjectAppRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMProjectAppRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectAppRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMProjectAppRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMProjectAppRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMProjectAppRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**Cm工程应用关系Id*/ 
 strCreateTabCode.Append(" CMProjectAppRelaId bigint primary key identity, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**CM工程应用名*/ 
 strCreateTabCode.Append(" CmPrjAppName varchar(50) Null, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMProjectAppRela : clsCommFun4BLV2
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
clsCMProjectAppRelaBL.ReFreshThisCache(strPrjId);
}
}

}