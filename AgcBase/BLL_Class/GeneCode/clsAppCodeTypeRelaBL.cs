
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppCodeTypeRelaBL
 表名:AppCodeTypeRela(00050418)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:25
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
public static class  clsAppCodeTypeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppCodeTypeRelaEN GetObj(this K_mId_AppCodeTypeRela myKey)
{
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.GetObjBymId(myKey.Value);
return objAppCodeTypeRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAppCodeTypeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],代码类型Id = [{1}]的数据已经存在!(in clsAppCodeTypeRelaBL.AddNewRecord)", objAppCodeTypeRelaEN.ApplicationTypeId,objAppCodeTypeRelaEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.AddNewRecordBySQL2(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objAppCodeTypeRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objAppCodeTypeRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(应用程序类型ID(ApplicationTypeId)=[{0}],代码类型Id(CodeTypeId)=[{1}])已经存在,不能重复!", objAppCodeTypeRelaEN.ApplicationTypeId, objAppCodeTypeRelaEN.CodeTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objAppCodeTypeRelaEN.AddNewRecord();
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAppCodeTypeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],代码类型Id = [{1}]的数据已经存在!(in clsAppCodeTypeRelaBL.AddNewRecordWithReturnKey)", objAppCodeTypeRelaEN.ApplicationTypeId,objAppCodeTypeRelaEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.AddNewRecordBySQL2WithReturnKey(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetmId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.mId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.mId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.mId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetApplicationTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conAppCodeTypeRela.ApplicationTypeId);
objAppCodeTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.ApplicationTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetCodeTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conAppCodeTypeRela.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
}
objAppCodeTypeRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.CodeTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.CodeTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.CodeTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetViewTypeCode(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int? intViewTypeCode, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.ViewTypeCode = intViewTypeCode; //界面类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.ViewTypeCode) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.ViewTypeCode, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.ViewTypeCode] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetTabMainTypeId(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
}
objAppCodeTypeRelaEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.TabMainTypeId) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.TabMainTypeId, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.TabMainTypeId] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetIsVisible(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.IsVisible) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.IsVisible, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.IsVisible] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetIsInGroupGeneCode(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsInGroupGeneCode, string strComparisonOp="")
	{
objAppCodeTypeRelaEN.IsInGroupGeneCode = bolIsInGroupGeneCode; //是否参与组生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.IsInGroupGeneCode) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.IsInGroupGeneCode, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.IsInGroupGeneCode] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetOrderNum(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conAppCodeTypeRela.OrderNum);
objAppCodeTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.OrderNum) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.OrderNum, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.OrderNum] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetUpdDate(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAppCodeTypeRela.UpdDate);
}
objAppCodeTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.UpdDate) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.UpdDate, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.UpdDate] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetUpdUser(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAppCodeTypeRela.UpdUser);
}
objAppCodeTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.UpdUser) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.UpdUser, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.UpdUser] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppCodeTypeRelaEN SetMemo(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppCodeTypeRela.Memo);
}
objAppCodeTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppCodeTypeRelaEN.dicFldComparisonOp.ContainsKey(conAppCodeTypeRela.Memo) == false)
{
objAppCodeTypeRelaEN.dicFldComparisonOp.Add(conAppCodeTypeRela.Memo, strComparisonOp);
}
else
{
objAppCodeTypeRelaEN.dicFldComparisonOp[conAppCodeTypeRela.Memo] = strComparisonOp;
}
}
return objAppCodeTypeRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAppCodeTypeRelaEN.CheckPropertyNew();
clsAppCodeTypeRelaEN objAppCodeTypeRelaCond = new clsAppCodeTypeRelaEN();
string strCondition = objAppCodeTypeRelaCond
.SetmId(objAppCodeTypeRelaEN.mId, "<>")
.SetApplicationTypeId(objAppCodeTypeRelaEN.ApplicationTypeId, "=")
.SetCodeTypeId(objAppCodeTypeRelaEN.CodeTypeId, "=")
.GetCombineCondition();
objAppCodeTypeRelaEN._IsCheckProperty = true;
bool bolIsExist = clsAppCodeTypeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ApplicationTypeId_CodeTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAppCodeTypeRelaEN.Update();
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
 /// <param name = "objAppCodeTypeRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsAppCodeTypeRelaEN objAppCodeTypeRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsAppCodeTypeRelaEN objAppCodeTypeRelaCond = new clsAppCodeTypeRelaEN();
string strCondition = objAppCodeTypeRelaCond
.SetApplicationTypeId(objAppCodeTypeRela.ApplicationTypeId, "=")
.SetCodeTypeId(objAppCodeTypeRela.CodeTypeId, "=")
.GetCombineCondition();
objAppCodeTypeRela._IsCheckProperty = true;
bool bolIsExist = clsAppCodeTypeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objAppCodeTypeRela.mId = clsAppCodeTypeRelaBL.GetFirstID_S(strCondition);
objAppCodeTypeRela.UpdateWithCondition(strCondition);
}
else
{
objAppCodeTypeRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 if (objAppCodeTypeRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.UpdateBySql2(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAppCodeTypeRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.UpdateBySql2(objAppCodeTypeRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.UpdateBySqlWithCondition(objAppCodeTypeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.UpdateBySqlWithConditionTransaction(objAppCodeTypeRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
public static int Delete(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
try
{
int intRecNum = clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.DelRecord(objAppCodeTypeRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objAppCodeTypeRelaENT">目标对象</param>
 public static void CopyTo(this clsAppCodeTypeRelaEN objAppCodeTypeRelaENS, clsAppCodeTypeRelaEN objAppCodeTypeRelaENT)
{
try
{
objAppCodeTypeRelaENT.mId = objAppCodeTypeRelaENS.mId; //mId
objAppCodeTypeRelaENT.ApplicationTypeId = objAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objAppCodeTypeRelaENT.CodeTypeId = objAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objAppCodeTypeRelaENT.ViewTypeCode = objAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objAppCodeTypeRelaENT.TabMainTypeId = objAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objAppCodeTypeRelaENT.IsVisible = objAppCodeTypeRelaENS.IsVisible; //是否显示
objAppCodeTypeRelaENT.IsInGroupGeneCode = objAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objAppCodeTypeRelaENT.OrderNum = objAppCodeTypeRelaENS.OrderNum; //序号
objAppCodeTypeRelaENT.UpdDate = objAppCodeTypeRelaENS.UpdDate; //修改日期
objAppCodeTypeRelaENT.UpdUser = objAppCodeTypeRelaENS.UpdUser; //修改者
objAppCodeTypeRelaENT.Memo = objAppCodeTypeRelaENS.Memo; //说明
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
 /// <param name = "objAppCodeTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsAppCodeTypeRelaEN:objAppCodeTypeRelaENT</returns>
 public static clsAppCodeTypeRelaEN CopyTo(this clsAppCodeTypeRelaEN objAppCodeTypeRelaENS)
{
try
{
 clsAppCodeTypeRelaEN objAppCodeTypeRelaENT = new clsAppCodeTypeRelaEN()
{
mId = objAppCodeTypeRelaENS.mId, //mId
ApplicationTypeId = objAppCodeTypeRelaENS.ApplicationTypeId, //应用程序类型ID
CodeTypeId = objAppCodeTypeRelaENS.CodeTypeId, //代码类型Id
ViewTypeCode = objAppCodeTypeRelaENS.ViewTypeCode, //界面类型码
TabMainTypeId = objAppCodeTypeRelaENS.TabMainTypeId, //表主类型Id
IsVisible = objAppCodeTypeRelaENS.IsVisible, //是否显示
IsInGroupGeneCode = objAppCodeTypeRelaENS.IsInGroupGeneCode, //是否参与组生成代码
OrderNum = objAppCodeTypeRelaENS.OrderNum, //序号
UpdDate = objAppCodeTypeRelaENS.UpdDate, //修改日期
UpdUser = objAppCodeTypeRelaENS.UpdUser, //修改者
Memo = objAppCodeTypeRelaENS.Memo, //说明
};
 return objAppCodeTypeRelaENT;
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
public static void CheckPropertyNew(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.CheckPropertyNew(objAppCodeTypeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 clsAppCodeTypeRelaBL.AppCodeTypeRelaDA.CheckProperty4Condition(objAppCodeTypeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppCodeTypeRelaEN objAppCodeTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.mId) == true)
{
string strComparisonOpmId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.mId, objAppCodeTypeRelaCond.mId, strComparisonOpmId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.ApplicationTypeId, objAppCodeTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.CodeTypeId, objAppCodeTypeRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.ViewTypeCode) == true)
{
string strComparisonOpViewTypeCode = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.ViewTypeCode];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.ViewTypeCode, objAppCodeTypeRelaCond.ViewTypeCode, strComparisonOpViewTypeCode);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.TabMainTypeId, objAppCodeTypeRelaCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.IsVisible) == true)
{
if (objAppCodeTypeRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppCodeTypeRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppCodeTypeRela.IsVisible);
}
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode) == true)
{
if (objAppCodeTypeRelaCond.IsInGroupGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAppCodeTypeRela.IsInGroupGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAppCodeTypeRela.IsInGroupGeneCode);
}
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conAppCodeTypeRela.OrderNum, objAppCodeTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.UpdDate, objAppCodeTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.UpdUser, objAppCodeTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objAppCodeTypeRelaCond.IsUpdated(conAppCodeTypeRela.Memo) == true)
{
string strComparisonOpMemo = objAppCodeTypeRelaCond.dicFldComparisonOp[conAppCodeTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppCodeTypeRela.Memo, objAppCodeTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--AppCodeTypeRela(应用程序代码类型关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objAppCodeTypeRelaEN == null) return true;
if (objAppCodeTypeRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
if (clsAppCodeTypeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppCodeTypeRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
if (clsAppCodeTypeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--AppCodeTypeRela(应用程序代码类型关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAppCodeTypeRelaEN == null) return "";
if (objAppCodeTypeRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAppCodeTypeRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_AppCodeTypeRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAppCodeTypeRelaBL
{
public static RelatedActions_AppCodeTypeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAppCodeTypeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAppCodeTypeRelaDA AppCodeTypeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAppCodeTypeRelaDA();
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
 public clsAppCodeTypeRelaBL()
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
if (string.IsNullOrEmpty(clsAppCodeTypeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppCodeTypeRelaEN._ConnectString);
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
public static DataTable GetDataTable_AppCodeTypeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AppCodeTypeRelaDA.GetDataTable_AppCodeTypeRela(strWhereCond);
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
objDT = AppCodeTypeRelaDA.GetDataTable(strWhereCond);
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
objDT = AppCodeTypeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AppCodeTypeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AppCodeTypeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AppCodeTypeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = AppCodeTypeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AppCodeTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AppCodeTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
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
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAppCodeTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel =
arrAppCodeTypeRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrAppCodeTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLst(string strWhereCond)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
public static List<clsAppCodeTypeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAppCodeTypeRelaEN> GetSubObjLstCache(clsAppCodeTypeRelaEN objAppCodeTypeRelaCond)
{
List<clsAppCodeTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppCodeTypeRela._AttributeName)
{
if (objAppCodeTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objAppCodeTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppCodeTypeRelaCond[strFldName].ToString());
}
else
{
if (objAppCodeTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppCodeTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppCodeTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppCodeTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppCodeTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppCodeTypeRelaCond[strFldName]));
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
List<clsAppCodeTypeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAppCodeTypeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAppCodeTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
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
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
public static List<clsAppCodeTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
public static List<clsAppCodeTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppCodeTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAppCodeTypeRela(ref clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
bool bolResult = AppCodeTypeRelaDA.GetAppCodeTypeRela(ref objAppCodeTypeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = AppCodeTypeRelaDA.GetObjBymId(lngmId);
return objAppCodeTypeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAppCodeTypeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = AppCodeTypeRelaDA.GetFirstObj(strWhereCond);
 return objAppCodeTypeRelaEN;
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
public static clsAppCodeTypeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = AppCodeTypeRelaDA.GetObjByDataRow(objRow);
 return objAppCodeTypeRelaEN;
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
public static clsAppCodeTypeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = AppCodeTypeRelaDA.GetObjByDataRow(objRow);
 return objAppCodeTypeRelaEN;
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
 /// <param name = "lstAppCodeTypeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppCodeTypeRelaEN GetObjBymIdFromList(long lngmId, List<clsAppCodeTypeRelaEN> lstAppCodeTypeRelaObjLst)
{
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRelaEN in lstAppCodeTypeRelaObjLst)
{
if (objAppCodeTypeRelaEN.mId == lngmId)
{
return objAppCodeTypeRelaEN;
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
 lngmId = new clsAppCodeTypeRelaDA().GetFirstID(strWhereCond);
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
 arrList = AppCodeTypeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = AppCodeTypeRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = AppCodeTypeRelaDA.IsExist(lngmId);
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
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaBL.GetObjBymId(lngmId);
objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objAppCodeTypeRelaEN.UpdUser = strOpUser;
return clsAppCodeTypeRelaBL.UpdateBySql2(objAppCodeTypeRelaEN);
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
 bolIsExist = clsAppCodeTypeRelaDA.IsExistTable();
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
 bolIsExist = AppCodeTypeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAppCodeTypeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],代码类型Id = [{1}]的数据已经存在!(in clsAppCodeTypeRelaBL.AddNewRecordBySql2)", objAppCodeTypeRelaEN.ApplicationTypeId,objAppCodeTypeRelaEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = AppCodeTypeRelaDA.AddNewRecordBySQL2(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAppCodeTypeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!应用程序类型ID = [{0}],代码类型Id = [{1}]的数据已经存在!(in clsAppCodeTypeRelaBL.AddNewRecordBySql2WithReturnKey)", objAppCodeTypeRelaEN.ApplicationTypeId,objAppCodeTypeRelaEN.CodeTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = AppCodeTypeRelaDA.AddNewRecordBySQL2WithReturnKey(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
try
{
bool bolResult = AppCodeTypeRelaDA.Update(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 if (objAppCodeTypeRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AppCodeTypeRelaDA.UpdateBySql2(objAppCodeTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppCodeTypeRelaBL.ReFreshCache();

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
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
 clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaBL.GetObjBymId(lngmId);

if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(objAppCodeTypeRelaEN.mId, objAppCodeTypeRelaEN.UpdUser);
}
if (objAppCodeTypeRelaEN != null)
{
int intRecNum = AppCodeTypeRelaDA.DelRecord(lngmId);
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
objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
//删除与表:[AppCodeTypeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAppCodeTypeRela.mId,
//lngmId);
//        clsAppCodeTypeRelaBL.DelAppCodeTypeRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppCodeTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppCodeTypeRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsAppCodeTypeRelaBL.relatedActions != null)
{
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = AppCodeTypeRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelAppCodeTypeRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsAppCodeTypeRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = AppCodeTypeRelaDA.DelAppCodeTypeRela(arrmIdLst);
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
public static int DelAppCodeTypeRelasByCond(string strWhereCond)
{
try
{
if (clsAppCodeTypeRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsAppCodeTypeRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = AppCodeTypeRelaDA.DelAppCodeTypeRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[AppCodeTypeRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
//删除与表:[AppCodeTypeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppCodeTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppCodeTypeRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objAppCodeTypeRelaENT">目标对象</param>
 public static void CopyTo(clsAppCodeTypeRelaEN objAppCodeTypeRelaENS, clsAppCodeTypeRelaEN objAppCodeTypeRelaENT)
{
try
{
objAppCodeTypeRelaENT.mId = objAppCodeTypeRelaENS.mId; //mId
objAppCodeTypeRelaENT.ApplicationTypeId = objAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objAppCodeTypeRelaENT.CodeTypeId = objAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objAppCodeTypeRelaENT.ViewTypeCode = objAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objAppCodeTypeRelaENT.TabMainTypeId = objAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objAppCodeTypeRelaENT.IsVisible = objAppCodeTypeRelaENS.IsVisible; //是否显示
objAppCodeTypeRelaENT.IsInGroupGeneCode = objAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objAppCodeTypeRelaENT.OrderNum = objAppCodeTypeRelaENS.OrderNum; //序号
objAppCodeTypeRelaENT.UpdDate = objAppCodeTypeRelaENS.UpdDate; //修改日期
objAppCodeTypeRelaENT.UpdUser = objAppCodeTypeRelaENS.UpdUser; //修改者
objAppCodeTypeRelaENT.Memo = objAppCodeTypeRelaENS.Memo; //说明
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
 /// <param name = "objAppCodeTypeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
try
{
objAppCodeTypeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAppCodeTypeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAppCodeTypeRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.mId = objAppCodeTypeRelaEN.mId; //mId
}
if (arrFldSet.Contains(conAppCodeTypeRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.ApplicationTypeId = objAppCodeTypeRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(conAppCodeTypeRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.CodeTypeId = objAppCodeTypeRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conAppCodeTypeRela.ViewTypeCode, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.ViewTypeCode = objAppCodeTypeRelaEN.ViewTypeCode; //界面类型码
}
if (arrFldSet.Contains(conAppCodeTypeRela.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.TabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId == "[null]" ? null :  objAppCodeTypeRelaEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(conAppCodeTypeRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.IsVisible = objAppCodeTypeRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conAppCodeTypeRela.IsInGroupGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.IsInGroupGeneCode = objAppCodeTypeRelaEN.IsInGroupGeneCode; //是否参与组生成代码
}
if (arrFldSet.Contains(conAppCodeTypeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.OrderNum = objAppCodeTypeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conAppCodeTypeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.UpdDate = objAppCodeTypeRelaEN.UpdDate == "[null]" ? null :  objAppCodeTypeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conAppCodeTypeRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.UpdUser = objAppCodeTypeRelaEN.UpdUser == "[null]" ? null :  objAppCodeTypeRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conAppCodeTypeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAppCodeTypeRelaEN.Memo = objAppCodeTypeRelaEN.Memo == "[null]" ? null :  objAppCodeTypeRelaEN.Memo; //说明
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
 /// <param name = "objAppCodeTypeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
try
{
if (objAppCodeTypeRelaEN.TabMainTypeId == "[null]") objAppCodeTypeRelaEN.TabMainTypeId = null; //表主类型Id
if (objAppCodeTypeRelaEN.UpdDate == "[null]") objAppCodeTypeRelaEN.UpdDate = null; //修改日期
if (objAppCodeTypeRelaEN.UpdUser == "[null]") objAppCodeTypeRelaEN.UpdUser = null; //修改者
if (objAppCodeTypeRelaEN.Memo == "[null]") objAppCodeTypeRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 AppCodeTypeRelaDA.CheckPropertyNew(objAppCodeTypeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 AppCodeTypeRelaDA.CheckProperty4Condition(objAppCodeTypeRelaEN);
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
if (clsAppCodeTypeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppCodeTypeRelaBL没有刷新缓存机制(clsAppCodeTypeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrAppCodeTypeRelaObjLstCache == null)
//{
//arrAppCodeTypeRelaObjLstCache = AppCodeTypeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppCodeTypeRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel =
arrAppCodeTypeRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrAppCodeTypeRelaObjLst_Sel.Count() == 0)
{
   clsAppCodeTypeRelaEN obj = clsAppCodeTypeRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAppCodeTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetAllAppCodeTypeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = GetObjLstCache(); 
return arrAppCodeTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppCodeTypeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAppCodeTypeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppCodeTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAppCodeTypeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsAppCodeTypeRelaEN._RefreshTimeLst[clsAppCodeTypeRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsAppCodeTypeRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppCodeTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppCodeTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAppCodeTypeRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--AppCodeTypeRela(应用程序代码类型关系)
 /// 唯一性条件:ApplicationTypeId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检测记录是否存在
string strResult = AppCodeTypeRelaDA.GetUniCondStr(objAppCodeTypeRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conAppCodeTypeRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAppCodeTypeRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAppCodeTypeRela._AttributeName));
throw new Exception(strMsg);
}
var objAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjBymIdCache(lngmId);
if (objAppCodeTypeRela == null) return "";
return objAppCodeTypeRela[strOutFldName].ToString();
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
int intRecCount = clsAppCodeTypeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsAppCodeTypeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAppCodeTypeRelaDA.GetRecCount();
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
int intRecCount = clsAppCodeTypeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAppCodeTypeRelaEN objAppCodeTypeRelaCond)
{
List<clsAppCodeTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppCodeTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppCodeTypeRela._AttributeName)
{
if (objAppCodeTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objAppCodeTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppCodeTypeRelaCond[strFldName].ToString());
}
else
{
if (objAppCodeTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppCodeTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppCodeTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppCodeTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppCodeTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppCodeTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppCodeTypeRelaCond[strFldName]));
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
 List<string> arrList = clsAppCodeTypeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AppCodeTypeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AppCodeTypeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AppCodeTypeRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppCodeTypeRelaDA.SetFldValue(clsAppCodeTypeRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = AppCodeTypeRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppCodeTypeRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppCodeTypeRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppCodeTypeRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[AppCodeTypeRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**应用程序类型ID*/ 
 strCreateTabCode.Append(" ApplicationTypeId int not Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) not Null, "); 
 // /**界面类型码*/ 
 strCreateTabCode.Append(" ViewTypeCode int Null, "); 
 // /**表主类型Id*/ 
 strCreateTabCode.Append(" TabMainTypeId char(4) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**是否参与组生成代码*/ 
 strCreateTabCode.Append(" IsInGroupGeneCode bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) Null, "); 
 // /**简称*/ 
 strCreateTabCode.Append(" CodeTypeSimName varchar(50) Null, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) Null, "); 
 // /**依赖于*/ 
 strCreateTabCode.Append(" DependsOn varchar(50) Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**编程语言类型简称*/ 
 strCreateTabCode.Append(" ProgLangTypeSimName varchar(30) Null, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(int intApplicationTypeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = new clsAppCodeTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRelaObjList)
{
objAppCodeTypeRela.OrderNum = intIndex;
UpdateBySql2(objAppCodeTypeRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,int intApplicationTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsAppCodeTypeRelaEN objAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjBymId(lngmId);

intOrderNum = objAppCodeTypeRela.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
intTabRecNum = clsAppCodeTypeRelaBL.GetRecCountByCond(clsAppCodeTypeRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conAppCodeTypeRela.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsAppCodeTypeRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsAppCodeTypeRelaBL.SetFldValue(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conAppCodeTypeRela.mId, lngmId));
clsAppCodeTypeRelaBL.SetFldValue(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conAppCodeTypeRela.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conAppCodeTypeRela.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);

lngNextmId = clsAppCodeTypeRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsAppCodeTypeRelaBL.SetFldValue(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conAppCodeTypeRela.mId, lngmId));
clsAppCodeTypeRelaBL.SetFldValue(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conAppCodeTypeRela.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,int intApplicationTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conAppCodeTypeRela.mId, strKeyList);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaLst = GetObjLst(strCondition);
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRelaLst)
{
objAppCodeTypeRela.OrderNum = objAppCodeTypeRela.OrderNum + 10000;
UpdateBySql2(objAppCodeTypeRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = new clsAppCodeTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRelaObjList)
{
objAppCodeTypeRela.OrderNum = intIndex;
UpdateBySql2(objAppCodeTypeRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：ApplicationTypeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="intApplicationTypeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,int intApplicationTypeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conAppCodeTypeRela.mId, strKeyList);
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaLst = GetObjLst(strCondition);
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRelaLst)
{
objAppCodeTypeRela.OrderNum = objAppCodeTypeRela.OrderNum - 10000;
UpdateBySql2(objAppCodeTypeRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjList = new clsAppCodeTypeRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRelaObjList)
{
objAppCodeTypeRela.OrderNum = intIndex;
UpdateBySql2(objAppCodeTypeRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4AppCodeTypeRela : clsCommFun4BL
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
clsAppCodeTypeRelaBL.ReFreshThisCache();
}
}

}