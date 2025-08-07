
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeParaBL
 表名:CodePara(00050437)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:05
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
public static class  clsCodeParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeParaEN GetObj(this K_CodeParaId_CodePara myKey)
{
clsCodeParaEN objCodeParaEN = clsCodeParaBL.CodeParaDA.GetObjByCodeParaId(myKey.Value);
return objCodeParaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeParaEN objCodeParaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeParaBL.IsExist(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeParaEN.CodeParaId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCodeParaBL.CodeParaDA.AddNewRecordBySQL2(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
public static bool AddRecordEx(this clsCodeParaEN objCodeParaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCodeParaBL.IsExist(objCodeParaEN.CodeParaId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCodeParaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCodeParaEN.AddNewRecord();
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCodeParaEN objCodeParaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeParaBL.IsExist(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeParaEN.CodeParaId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCodeParaBL.CodeParaDA.AddNewRecordBySQL2WithReturnKey(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetCodeParaId(this clsCodeParaEN objCodeParaEN, string strCodeParaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeParaId, 8, conCodePara.CodeParaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeParaId, 8, conCodePara.CodeParaId);
}
objCodeParaEN.CodeParaId = strCodeParaId; //代码参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.CodeParaId) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.CodeParaId, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.CodeParaId] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetCodeParaName(this clsCodeParaEN objCodeParaEN, string strCodeParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeParaName, conCodePara.CodeParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeParaName, 50, conCodePara.CodeParaName);
}
objCodeParaEN.CodeParaName = strCodeParaName; //代码参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.CodeParaName) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.CodeParaName, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.CodeParaName] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetDataTypeId(this clsCodeParaEN objCodeParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conCodePara.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conCodePara.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conCodePara.DataTypeId);
}
objCodeParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.DataTypeId) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.DataTypeId, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.DataTypeId] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetTabId(this clsCodeParaEN objCodeParaEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conCodePara.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conCodePara.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conCodePara.TabId);
}
objCodeParaEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.TabId) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.TabId, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.TabId] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetFldId(this clsCodeParaEN objCodeParaEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conCodePara.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conCodePara.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conCodePara.FldId);
}
objCodeParaEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.FldId) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.FldId, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.FldId] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetPrjId(this clsCodeParaEN objCodeParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCodePara.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCodePara.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCodePara.PrjId);
}
objCodeParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.PrjId) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.PrjId, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.PrjId] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetCodeParaContent(this clsCodeParaEN objCodeParaEN, string strCodeParaContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeParaContent, 100, conCodePara.CodeParaContent);
}
objCodeParaEN.CodeParaContent = strCodeParaContent; //代码参数内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.CodeParaContent) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.CodeParaContent, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.CodeParaContent] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetUpdDate(this clsCodeParaEN objCodeParaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodePara.UpdDate);
}
objCodeParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.UpdDate) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.UpdDate, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.UpdDate] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetUpdUser(this clsCodeParaEN objCodeParaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodePara.UpdUser);
}
objCodeParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.UpdUser) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.UpdUser, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.UpdUser] = strComparisonOp;
}
}
return objCodeParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeParaEN SetMemo(this clsCodeParaEN objCodeParaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodePara.Memo);
}
objCodeParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeParaEN.dicFldComparisonOp.ContainsKey(conCodePara.Memo) == false)
{
objCodeParaEN.dicFldComparisonOp.Add(conCodePara.Memo, strComparisonOp);
}
else
{
objCodeParaEN.dicFldComparisonOp[conCodePara.Memo] = strComparisonOp;
}
}
return objCodeParaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCodeParaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCodeParaEN objCodeParaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeParaEN.CheckPropertyNew();
clsCodeParaEN objCodeParaCond = new clsCodeParaEN();
string strCondition = objCodeParaCond
.SetCodeParaId(objCodeParaEN.CodeParaId, "=")
.GetCombineCondition();
objCodeParaEN._IsCheckProperty = true;
bool bolIsExist = clsCodeParaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCodeParaEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeParaEN objCodeParaEN)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeParaBL.CodeParaDA.UpdateBySql2(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeParaEN objCodeParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeParaBL.CodeParaDA.UpdateBySql2(objCodeParaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeParaEN objCodeParaEN, string strWhereCond)
{
try
{
bool bolResult = clsCodeParaBL.CodeParaDA.UpdateBySqlWithCondition(objCodeParaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeParaEN objCodeParaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCodeParaBL.CodeParaDA.UpdateBySqlWithConditionTransaction(objCodeParaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCodeParaEN objCodeParaEN)
{
try
{
int intRecNum = clsCodeParaBL.CodeParaDA.DelRecord(objCodeParaEN.CodeParaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaENS">源对象</param>
 /// <param name = "objCodeParaENT">目标对象</param>
 public static void CopyTo(this clsCodeParaEN objCodeParaENS, clsCodeParaEN objCodeParaENT)
{
try
{
objCodeParaENT.CodeParaId = objCodeParaENS.CodeParaId; //代码参数Id
objCodeParaENT.CodeParaName = objCodeParaENS.CodeParaName; //代码参数名
objCodeParaENT.DataTypeId = objCodeParaENS.DataTypeId; //数据类型Id
objCodeParaENT.TabId = objCodeParaENS.TabId; //表ID
objCodeParaENT.FldId = objCodeParaENS.FldId; //字段Id
objCodeParaENT.PrjId = objCodeParaENS.PrjId; //工程Id
objCodeParaENT.CodeParaContent = objCodeParaENS.CodeParaContent; //代码参数内容
objCodeParaENT.UpdDate = objCodeParaENS.UpdDate; //修改日期
objCodeParaENT.UpdUser = objCodeParaENS.UpdUser; //修改者
objCodeParaENT.Memo = objCodeParaENS.Memo; //说明
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
 /// <param name = "objCodeParaENS">源对象</param>
 /// <returns>目标对象=>clsCodeParaEN:objCodeParaENT</returns>
 public static clsCodeParaEN CopyTo(this clsCodeParaEN objCodeParaENS)
{
try
{
 clsCodeParaEN objCodeParaENT = new clsCodeParaEN()
{
CodeParaId = objCodeParaENS.CodeParaId, //代码参数Id
CodeParaName = objCodeParaENS.CodeParaName, //代码参数名
DataTypeId = objCodeParaENS.DataTypeId, //数据类型Id
TabId = objCodeParaENS.TabId, //表ID
FldId = objCodeParaENS.FldId, //字段Id
PrjId = objCodeParaENS.PrjId, //工程Id
CodeParaContent = objCodeParaENS.CodeParaContent, //代码参数内容
UpdDate = objCodeParaENS.UpdDate, //修改日期
UpdUser = objCodeParaENS.UpdUser, //修改者
Memo = objCodeParaENS.Memo, //说明
};
 return objCodeParaENT;
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
public static void CheckPropertyNew(this clsCodeParaEN objCodeParaEN)
{
 clsCodeParaBL.CodeParaDA.CheckPropertyNew(objCodeParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCodeParaEN objCodeParaEN)
{
 clsCodeParaBL.CodeParaDA.CheckProperty4Condition(objCodeParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeParaEN objCodeParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeParaCond.IsUpdated(conCodePara.CodeParaId) == true)
{
string strComparisonOpCodeParaId = objCodeParaCond.dicFldComparisonOp[conCodePara.CodeParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.CodeParaId, objCodeParaCond.CodeParaId, strComparisonOpCodeParaId);
}
if (objCodeParaCond.IsUpdated(conCodePara.CodeParaName) == true)
{
string strComparisonOpCodeParaName = objCodeParaCond.dicFldComparisonOp[conCodePara.CodeParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.CodeParaName, objCodeParaCond.CodeParaName, strComparisonOpCodeParaName);
}
if (objCodeParaCond.IsUpdated(conCodePara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objCodeParaCond.dicFldComparisonOp[conCodePara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.DataTypeId, objCodeParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objCodeParaCond.IsUpdated(conCodePara.TabId) == true)
{
string strComparisonOpTabId = objCodeParaCond.dicFldComparisonOp[conCodePara.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.TabId, objCodeParaCond.TabId, strComparisonOpTabId);
}
if (objCodeParaCond.IsUpdated(conCodePara.FldId) == true)
{
string strComparisonOpFldId = objCodeParaCond.dicFldComparisonOp[conCodePara.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.FldId, objCodeParaCond.FldId, strComparisonOpFldId);
}
if (objCodeParaCond.IsUpdated(conCodePara.PrjId) == true)
{
string strComparisonOpPrjId = objCodeParaCond.dicFldComparisonOp[conCodePara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.PrjId, objCodeParaCond.PrjId, strComparisonOpPrjId);
}
if (objCodeParaCond.IsUpdated(conCodePara.CodeParaContent) == true)
{
string strComparisonOpCodeParaContent = objCodeParaCond.dicFldComparisonOp[conCodePara.CodeParaContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.CodeParaContent, objCodeParaCond.CodeParaContent, strComparisonOpCodeParaContent);
}
if (objCodeParaCond.IsUpdated(conCodePara.UpdDate) == true)
{
string strComparisonOpUpdDate = objCodeParaCond.dicFldComparisonOp[conCodePara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.UpdDate, objCodeParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCodeParaCond.IsUpdated(conCodePara.UpdUser) == true)
{
string strComparisonOpUpdUser = objCodeParaCond.dicFldComparisonOp[conCodePara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.UpdUser, objCodeParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCodeParaCond.IsUpdated(conCodePara.Memo) == true)
{
string strComparisonOpMemo = objCodeParaCond.dicFldComparisonOp[conCodePara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodePara.Memo, objCodeParaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CodePara
{
public virtual bool UpdRelaTabDate(string strCodeParaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 代码参数(CodePara)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCodeParaBL
{
public static RelatedActions_CodePara relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCodeParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCodeParaDA CodeParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCodeParaDA();
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
 public clsCodeParaBL()
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
if (string.IsNullOrEmpty(clsCodeParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeParaEN._ConnectString);
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
public static DataTable GetDataTable_CodePara(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CodeParaDA.GetDataTable_CodePara(strWhereCond);
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
objDT = CodeParaDA.GetDataTable(strWhereCond);
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
objDT = CodeParaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CodeParaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CodeParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CodeParaDA.GetDataTable_Top(objTopPara);
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
objDT = CodeParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CodeParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CodeParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCodeParaEN> GetObjLstByCodeParaIdLst(List<string> arrCodeParaIdLst)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeParaIdLst, true);
 string strWhereCond = string.Format("CodeParaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCodeParaEN> GetObjLstByCodeParaIdLstCache(List<string> arrCodeParaIdLst)
{
string strKey = string.Format("{0}", clsCodeParaEN._CurrTabName);
List<clsCodeParaEN> arrCodeParaObjLstCache = GetObjLstCache();
IEnumerable <clsCodeParaEN> arrCodeParaObjLst_Sel =
arrCodeParaObjLstCache
.Where(x => arrCodeParaIdLst.Contains(x.CodeParaId));
return arrCodeParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeParaEN> GetObjLst(string strWhereCond)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
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
public static List<clsCodeParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCodeParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCodeParaEN> GetSubObjLstCache(clsCodeParaEN objCodeParaCond)
{
List<clsCodeParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCodeParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodePara._AttributeName)
{
if (objCodeParaCond.IsUpdated(strFldName) == false) continue;
if (objCodeParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeParaCond[strFldName].ToString());
}
else
{
if (objCodeParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeParaCond[strFldName]));
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
public static List<clsCodeParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
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
public static List<clsCodeParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
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
List<clsCodeParaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCodeParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeParaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCodeParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
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
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
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
public static List<clsCodeParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCodeParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCodeParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
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
public static List<clsCodeParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCodeParaEN> arrObjLst = new List<clsCodeParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeParaEN objCodeParaEN = new clsCodeParaEN();
try
{
objCodeParaEN.CodeParaId = objRow[conCodePara.CodeParaId].ToString().Trim(); //代码参数Id
objCodeParaEN.CodeParaName = objRow[conCodePara.CodeParaName].ToString().Trim(); //代码参数名
objCodeParaEN.DataTypeId = objRow[conCodePara.DataTypeId].ToString().Trim(); //数据类型Id
objCodeParaEN.TabId = objRow[conCodePara.TabId].ToString().Trim(); //表ID
objCodeParaEN.FldId = objRow[conCodePara.FldId].ToString().Trim(); //字段Id
objCodeParaEN.PrjId = objRow[conCodePara.PrjId].ToString().Trim(); //工程Id
objCodeParaEN.CodeParaContent = objRow[conCodePara.CodeParaContent] == DBNull.Value ? null : objRow[conCodePara.CodeParaContent].ToString().Trim(); //代码参数内容
objCodeParaEN.UpdDate = objRow[conCodePara.UpdDate] == DBNull.Value ? null : objRow[conCodePara.UpdDate].ToString().Trim(); //修改日期
objCodeParaEN.UpdUser = objRow[conCodePara.UpdUser] == DBNull.Value ? null : objRow[conCodePara.UpdUser].ToString().Trim(); //修改者
objCodeParaEN.Memo = objRow[conCodePara.Memo] == DBNull.Value ? null : objRow[conCodePara.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeParaEN.CodeParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCodeParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCodePara(ref clsCodeParaEN objCodeParaEN)
{
bool bolResult = CodeParaDA.GetCodePara(ref objCodeParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeParaEN GetObjByCodeParaId(string strCodeParaId)
{
if (strCodeParaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeParaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeParaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeParaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCodeParaEN objCodeParaEN = CodeParaDA.GetObjByCodeParaId(strCodeParaId);
return objCodeParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCodeParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCodeParaEN objCodeParaEN = CodeParaDA.GetFirstObj(strWhereCond);
 return objCodeParaEN;
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
public static clsCodeParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCodeParaEN objCodeParaEN = CodeParaDA.GetObjByDataRow(objRow);
 return objCodeParaEN;
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
public static clsCodeParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCodeParaEN objCodeParaEN = CodeParaDA.GetObjByDataRow(objRow);
 return objCodeParaEN;
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
 /// <param name = "strCodeParaId">所给的关键字</param>
 /// <param name = "lstCodeParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeParaEN GetObjByCodeParaIdFromList(string strCodeParaId, List<clsCodeParaEN> lstCodeParaObjLst)
{
foreach (clsCodeParaEN objCodeParaEN in lstCodeParaObjLst)
{
if (objCodeParaEN.CodeParaId == strCodeParaId)
{
return objCodeParaEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strCodeParaId;
 try
 {
 strCodeParaId = new clsCodeParaDA().GetFirstID(strWhereCond);
 return strCodeParaId;
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
 arrList = CodeParaDA.GetID(strWhereCond);
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
bool bolIsExist = CodeParaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeParaId)
{
if (string.IsNullOrEmpty(strCodeParaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeParaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CodeParaDA.IsExist(strCodeParaId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCodeParaId">代码参数Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCodeParaId, string strOpUser)
{
clsCodeParaEN objCodeParaEN = clsCodeParaBL.GetObjByCodeParaId(strCodeParaId);
objCodeParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCodeParaEN.UpdUser = strOpUser;
return clsCodeParaBL.UpdateBySql2(objCodeParaEN);
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
 bolIsExist = clsCodeParaDA.IsExistTable();
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
 bolIsExist = CodeParaDA.IsExistTable(strTabName);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCodeParaEN objCodeParaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeParaBL.IsExist(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeParaEN.CodeParaId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CodeParaDA.AddNewRecordBySQL2(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCodeParaEN objCodeParaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeParaBL.IsExist(objCodeParaEN.CodeParaId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeParaEN.CodeParaId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CodeParaDA.AddNewRecordBySQL2WithReturnKey(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCodeParaEN objCodeParaEN)
{
try
{
bool bolResult = CodeParaDA.Update(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "objCodeParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCodeParaEN objCodeParaEN)
{
 if (string.IsNullOrEmpty(objCodeParaEN.CodeParaId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CodeParaDA.UpdateBySql2(objCodeParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeParaBL.ReFreshCache();

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
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
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCodeParaId)
{
try
{
 clsCodeParaEN objCodeParaEN = clsCodeParaBL.GetObjByCodeParaId(strCodeParaId);

if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(objCodeParaEN.CodeParaId, objCodeParaEN.UpdUser);
}
if (objCodeParaEN != null)
{
int intRecNum = CodeParaDA.DelRecord(strCodeParaId);
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
/// <param name="strCodeParaId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCodeParaId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeParaDA.GetSpecSQLObj();
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
//删除与表:[CodePara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodePara.CodeParaId,
//strCodeParaId);
//        clsCodeParaBL.DelCodeParasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeParaBL.DelRecord(strCodeParaId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeParaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeParaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCodeParaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCodeParaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCodeParaBL.relatedActions != null)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(strCodeParaId, "UpdRelaTabDate");
}
bool bolResult = CodeParaDA.DelRecord(strCodeParaId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCodeParaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCodeParas(List<string> arrCodeParaIdLst)
{
if (arrCodeParaIdLst.Count == 0) return 0;
try
{
if (clsCodeParaBL.relatedActions != null)
{
foreach (var strCodeParaId in arrCodeParaIdLst)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(strCodeParaId, "UpdRelaTabDate");
}
}
int intDelRecNum = CodeParaDA.DelCodePara(arrCodeParaIdLst);
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
public static int DelCodeParasByCond(string strWhereCond)
{
try
{
if (clsCodeParaBL.relatedActions != null)
{
List<string> arrCodeParaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCodeParaId in arrCodeParaId)
{
clsCodeParaBL.relatedActions.UpdRelaTabDate(strCodeParaId, "UpdRelaTabDate");
}
}
int intRecNum = CodeParaDA.DelCodePara(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CodePara]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCodeParaId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCodeParaId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeParaDA.GetSpecSQLObj();
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
//删除与表:[CodePara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeParaBL.DelRecord(strCodeParaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeParaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCodeParaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCodeParaENS">源对象</param>
 /// <param name = "objCodeParaENT">目标对象</param>
 public static void CopyTo(clsCodeParaEN objCodeParaENS, clsCodeParaEN objCodeParaENT)
{
try
{
objCodeParaENT.CodeParaId = objCodeParaENS.CodeParaId; //代码参数Id
objCodeParaENT.CodeParaName = objCodeParaENS.CodeParaName; //代码参数名
objCodeParaENT.DataTypeId = objCodeParaENS.DataTypeId; //数据类型Id
objCodeParaENT.TabId = objCodeParaENS.TabId; //表ID
objCodeParaENT.FldId = objCodeParaENS.FldId; //字段Id
objCodeParaENT.PrjId = objCodeParaENS.PrjId; //工程Id
objCodeParaENT.CodeParaContent = objCodeParaENS.CodeParaContent; //代码参数内容
objCodeParaENT.UpdDate = objCodeParaENS.UpdDate; //修改日期
objCodeParaENT.UpdUser = objCodeParaENS.UpdUser; //修改者
objCodeParaENT.Memo = objCodeParaENS.Memo; //说明
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
 /// <param name = "objCodeParaEN">源简化对象</param>
 public static void SetUpdFlag(clsCodeParaEN objCodeParaEN)
{
try
{
objCodeParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCodeParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCodePara.CodeParaId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.CodeParaId = objCodeParaEN.CodeParaId; //代码参数Id
}
if (arrFldSet.Contains(conCodePara.CodeParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.CodeParaName = objCodeParaEN.CodeParaName; //代码参数名
}
if (arrFldSet.Contains(conCodePara.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.DataTypeId = objCodeParaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conCodePara.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.TabId = objCodeParaEN.TabId; //表ID
}
if (arrFldSet.Contains(conCodePara.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.FldId = objCodeParaEN.FldId; //字段Id
}
if (arrFldSet.Contains(conCodePara.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.PrjId = objCodeParaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCodePara.CodeParaContent, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.CodeParaContent = objCodeParaEN.CodeParaContent == "[null]" ? null :  objCodeParaEN.CodeParaContent; //代码参数内容
}
if (arrFldSet.Contains(conCodePara.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.UpdDate = objCodeParaEN.UpdDate == "[null]" ? null :  objCodeParaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCodePara.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.UpdUser = objCodeParaEN.UpdUser == "[null]" ? null :  objCodeParaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCodePara.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeParaEN.Memo = objCodeParaEN.Memo == "[null]" ? null :  objCodeParaEN.Memo; //说明
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
 /// <param name = "objCodeParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCodeParaEN objCodeParaEN)
{
try
{
if (objCodeParaEN.CodeParaContent == "[null]") objCodeParaEN.CodeParaContent = null; //代码参数内容
if (objCodeParaEN.UpdDate == "[null]") objCodeParaEN.UpdDate = null; //修改日期
if (objCodeParaEN.UpdUser == "[null]") objCodeParaEN.UpdUser = null; //修改者
if (objCodeParaEN.Memo == "[null]") objCodeParaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCodeParaEN objCodeParaEN)
{
 CodeParaDA.CheckPropertyNew(objCodeParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCodeParaEN objCodeParaEN)
{
 CodeParaDA.CheckProperty4Condition(objCodeParaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CodeParaId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCodePara.CodeParaId); 
List<clsCodeParaEN> arrObjLst = clsCodeParaBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCodeParaEN objCodeParaEN = new clsCodeParaEN()
{
CodeParaId = "0",
CodeParaName = "选[代码参数]..."
};
arrObjLst.Insert(0, objCodeParaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCodePara.CodeParaId;
objComboBox.DisplayMember = conCodePara.CodeParaName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CodeParaId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码参数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCodePara.CodeParaId); 
IEnumerable<clsCodeParaEN> arrObjLst = clsCodeParaBL.GetObjLst(strCondition);
objDDL.DataValueField = conCodePara.CodeParaId;
objDDL.DataTextField = conCodePara.CodeParaName;
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
public static void BindDdl_CodeParaIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码参数]...","0");
List<clsCodeParaEN> arrCodeParaObjLst = GetAllCodeParaObjLstCache(); 
objDDL.DataValueField = conCodePara.CodeParaId;
objDDL.DataTextField = conCodePara.CodeParaName;
objDDL.DataSource = arrCodeParaObjLst;
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
if (clsCodeParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeParaBL没有刷新缓存机制(clsCodeParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeParaId");
//if (arrCodeParaObjLstCache == null)
//{
//arrCodeParaObjLstCache = CodeParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeParaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeParaEN GetObjByCodeParaIdCache(string strCodeParaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCodeParaEN._CurrTabName);
List<clsCodeParaEN> arrCodeParaObjLstCache = GetObjLstCache();
IEnumerable <clsCodeParaEN> arrCodeParaObjLst_Sel =
arrCodeParaObjLstCache
.Where(x=> x.CodeParaId == strCodeParaId 
);
if (arrCodeParaObjLst_Sel.Count() == 0)
{
   clsCodeParaEN obj = clsCodeParaBL.GetObjByCodeParaId(strCodeParaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCodeParaObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeParaId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeParaNameByCodeParaIdCache(string strCodeParaId)
{
if (string.IsNullOrEmpty(strCodeParaId) == true) return "";
//获取缓存中的对象列表
clsCodeParaEN objCodePara = GetObjByCodeParaIdCache(strCodeParaId);
if (objCodePara == null) return "";
return objCodePara.CodeParaName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeParaId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeParaIdCache(string strCodeParaId)
{
if (string.IsNullOrEmpty(strCodeParaId) == true) return "";
//获取缓存中的对象列表
clsCodeParaEN objCodePara = GetObjByCodeParaIdCache(strCodeParaId);
if (objCodePara == null) return "";
return objCodePara.CodeParaName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeParaEN> GetAllCodeParaObjLstCache()
{
//获取缓存中的对象列表
List<clsCodeParaEN> arrCodeParaObjLstCache = GetObjLstCache(); 
return arrCodeParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCodeParaEN._CurrTabName);
List<clsCodeParaEN> arrCodeParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCodeParaObjLstCache;
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
string strKey = string.Format("{0}", clsCodeParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCodeParaEN._RefreshTimeLst.Count == 0) return "";
return clsCodeParaEN._RefreshTimeLst[clsCodeParaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCodeParaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCodeParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCodeParaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strCodeParaId)
{
if (strInFldName != conCodePara.CodeParaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCodePara._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCodePara._AttributeName));
throw new Exception(strMsg);
}
var objCodePara = clsCodeParaBL.GetObjByCodeParaIdCache(strCodeParaId);
if (objCodePara == null) return "";
return objCodePara[strOutFldName].ToString();
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
int intRecCount = clsCodeParaDA.GetRecCount(strTabName);
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
int intRecCount = clsCodeParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCodeParaDA.GetRecCount();
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
int intRecCount = clsCodeParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCodeParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCodeParaEN objCodeParaCond)
{
List<clsCodeParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCodeParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCodePara._AttributeName)
{
if (objCodeParaCond.IsUpdated(strFldName) == false) continue;
if (objCodeParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeParaCond[strFldName].ToString());
}
else
{
if (objCodeParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCodeParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeParaCond[strFldName]));
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
 List<string> arrList = clsCodeParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CodeParaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CodeParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CodeParaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeParaDA.SetFldValue(clsCodeParaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CodeParaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeParaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeParaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeParaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CodePara] "); 
 strCreateTabCode.Append(" ( "); 
 // /**代码参数Id*/ 
 strCreateTabCode.Append(" CodeParaId char(8) primary key, "); 
 // /**代码参数名*/ 
 strCreateTabCode.Append(" CodeParaName varchar(50) not Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**代码参数内容*/ 
 strCreateTabCode.Append(" CodeParaContent varchar(100) Null, "); 
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
 /// 代码参数(CodePara)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CodePara : clsCommFun4BL
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
clsCodeParaBL.ReFreshThisCache();
}
}

}