
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableTypeBL
 表名:GCVariableType(00050560)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:16
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
public static class  clsGCVariableTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strVarTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVariableTypeEN GetObj(this K_VarTypeId_GCVariableType myKey)
{
clsGCVariableTypeEN objGCVariableTypeEN = clsGCVariableTypeBL.GCVariableTypeDA.GetObjByVarTypeId(myKey.Value);
return objGCVariableTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!变量类型名 = [{0}]的数据已经存在!(in clsGCVariableTypeBL.AddNewRecord)", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsGCVariableTypeBL.GCVariableTypeDA.AddNewRecordBySQL2(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCVariableTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCVariableTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(变量类型名(VarTypeName)=[{0}])已经存在,不能重复!", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCVariableTypeEN.AddNewRecord();
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!变量类型名 = [{0}]的数据已经存在!(in clsGCVariableTypeBL.AddNewRecordWithMaxId)", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
string strVarTypeId = clsGCVariableTypeBL.GCVariableTypeDA.AddNewRecordBySQL2WithReturnKey(objGCVariableTypeEN);
     objGCVariableTypeEN.VarTypeId = strVarTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
}
return strVarTypeId;
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!变量类型名 = [{0}]的数据已经存在!(in clsGCVariableTypeBL.AddNewRecordWithReturnKey)", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
string strKey = clsGCVariableTypeBL.GCVariableTypeDA.AddNewRecordBySQL2WithReturnKey(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetVarTypeId(this clsGCVariableTypeEN objGCVariableTypeEN, string strVarTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeId, 4, conGCVariableType.VarTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarTypeId, 4, conGCVariableType.VarTypeId);
}
objGCVariableTypeEN.VarTypeId = strVarTypeId; //变量类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.VarTypeId) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.VarTypeId, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.VarTypeId] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetVarTypeName(this clsGCVariableTypeEN objGCVariableTypeEN, string strVarTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarTypeName, conGCVariableType.VarTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeName, 50, conGCVariableType.VarTypeName);
}
objGCVariableTypeEN.VarTypeName = strVarTypeName; //变量类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.VarTypeName) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.VarTypeName, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.VarTypeName] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetVarTypeENName(this clsGCVariableTypeEN objGCVariableTypeEN, string strVarTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarTypeENName, conGCVariableType.VarTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeENName, 50, conGCVariableType.VarTypeENName);
}
objGCVariableTypeEN.VarTypeENName = strVarTypeENName; //变量类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.VarTypeENName) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.VarTypeENName, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.VarTypeENName] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetVarTypeSimName(this clsGCVariableTypeEN objGCVariableTypeEN, string strVarTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeSimName, 50, conGCVariableType.VarTypeSimName);
}
objGCVariableTypeEN.VarTypeSimName = strVarTypeSimName; //变量类型简名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.VarTypeSimName) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.VarTypeSimName, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.VarTypeSimName] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetUpdDate(this clsGCVariableTypeEN objGCVariableTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCVariableType.UpdDate);
}
objGCVariableTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.UpdDate) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.UpdDate, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.UpdDate] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetUpdUser(this clsGCVariableTypeEN objGCVariableTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCVariableType.UpdUser);
}
objGCVariableTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.UpdUser) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.UpdUser, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.UpdUser] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableTypeEN SetMemo(this clsGCVariableTypeEN objGCVariableTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCVariableType.Memo);
}
objGCVariableTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableTypeEN.dicFldComparisonOp.ContainsKey(conGCVariableType.Memo) == false)
{
objGCVariableTypeEN.dicFldComparisonOp.Add(conGCVariableType.Memo, strComparisonOp);
}
else
{
objGCVariableTypeEN.dicFldComparisonOp[conGCVariableType.Memo] = strComparisonOp;
}
}
return objGCVariableTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCVariableTypeEN objGCVariableTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCVariableTypeEN.CheckPropertyNew();
clsGCVariableTypeEN objGCVariableTypeCond = new clsGCVariableTypeEN();
string strCondition = objGCVariableTypeCond
.SetVarTypeId(objGCVariableTypeEN.VarTypeId, "<>")
.SetVarTypeName(objGCVariableTypeEN.VarTypeName, "=")
.GetCombineCondition();
objGCVariableTypeEN._IsCheckProperty = true;
bool bolIsExist = clsGCVariableTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(VarTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCVariableTypeEN.Update();
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
 /// <param name = "objGCVariableType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCVariableTypeEN objGCVariableType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCVariableTypeEN objGCVariableTypeCond = new clsGCVariableTypeEN();
string strCondition = objGCVariableTypeCond
.SetVarTypeName(objGCVariableType.VarTypeName, "=")
.GetCombineCondition();
objGCVariableType._IsCheckProperty = true;
bool bolIsExist = clsGCVariableTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCVariableType.VarTypeId = clsGCVariableTypeBL.GetFirstID_S(strCondition);
objGCVariableType.UpdateWithCondition(strCondition);
}
else
{
objGCVariableType.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
objGCVariableType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVariableTypeEN objGCVariableTypeEN)
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVariableTypeBL.GCVariableTypeDA.UpdateBySql2(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVariableTypeEN objGCVariableTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVariableTypeBL.GCVariableTypeDA.UpdateBySql2(objGCVariableTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVariableTypeEN objGCVariableTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsGCVariableTypeBL.GCVariableTypeDA.UpdateBySqlWithCondition(objGCVariableTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVariableTypeEN objGCVariableTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCVariableTypeBL.GCVariableTypeDA.UpdateBySqlWithConditionTransaction(objGCVariableTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "strVarTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCVariableTypeEN objGCVariableTypeEN)
{
try
{
int intRecNum = clsGCVariableTypeBL.GCVariableTypeDA.DelRecord(objGCVariableTypeEN.VarTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeENS">源对象</param>
 /// <param name = "objGCVariableTypeENT">目标对象</param>
 public static void CopyTo(this clsGCVariableTypeEN objGCVariableTypeENS, clsGCVariableTypeEN objGCVariableTypeENT)
{
try
{
objGCVariableTypeENT.VarTypeId = objGCVariableTypeENS.VarTypeId; //变量类型Id
objGCVariableTypeENT.VarTypeName = objGCVariableTypeENS.VarTypeName; //变量类型名
objGCVariableTypeENT.VarTypeENName = objGCVariableTypeENS.VarTypeENName; //变量类型英文名
objGCVariableTypeENT.VarTypeSimName = objGCVariableTypeENS.VarTypeSimName; //变量类型简名
objGCVariableTypeENT.UpdDate = objGCVariableTypeENS.UpdDate; //修改日期
objGCVariableTypeENT.UpdUser = objGCVariableTypeENS.UpdUser; //修改者
objGCVariableTypeENT.Memo = objGCVariableTypeENS.Memo; //说明
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
 /// <param name = "objGCVariableTypeENS">源对象</param>
 /// <returns>目标对象=>clsGCVariableTypeEN:objGCVariableTypeENT</returns>
 public static clsGCVariableTypeEN CopyTo(this clsGCVariableTypeEN objGCVariableTypeENS)
{
try
{
 clsGCVariableTypeEN objGCVariableTypeENT = new clsGCVariableTypeEN()
{
VarTypeId = objGCVariableTypeENS.VarTypeId, //变量类型Id
VarTypeName = objGCVariableTypeENS.VarTypeName, //变量类型名
VarTypeENName = objGCVariableTypeENS.VarTypeENName, //变量类型英文名
VarTypeSimName = objGCVariableTypeENS.VarTypeSimName, //变量类型简名
UpdDate = objGCVariableTypeENS.UpdDate, //修改日期
UpdUser = objGCVariableTypeENS.UpdUser, //修改者
Memo = objGCVariableTypeENS.Memo, //说明
};
 return objGCVariableTypeENT;
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
public static void CheckPropertyNew(this clsGCVariableTypeEN objGCVariableTypeEN)
{
 clsGCVariableTypeBL.GCVariableTypeDA.CheckPropertyNew(objGCVariableTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCVariableTypeEN objGCVariableTypeEN)
{
 clsGCVariableTypeBL.GCVariableTypeDA.CheckProperty4Condition(objGCVariableTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCVariableTypeEN objGCVariableTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.VarTypeId) == true)
{
string strComparisonOpVarTypeId = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.VarTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.VarTypeId, objGCVariableTypeCond.VarTypeId, strComparisonOpVarTypeId);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.VarTypeName) == true)
{
string strComparisonOpVarTypeName = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.VarTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.VarTypeName, objGCVariableTypeCond.VarTypeName, strComparisonOpVarTypeName);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.VarTypeENName) == true)
{
string strComparisonOpVarTypeENName = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.VarTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.VarTypeENName, objGCVariableTypeCond.VarTypeENName, strComparisonOpVarTypeENName);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.VarTypeSimName) == true)
{
string strComparisonOpVarTypeSimName = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.VarTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.VarTypeSimName, objGCVariableTypeCond.VarTypeSimName, strComparisonOpVarTypeSimName);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.UpdDate, objGCVariableTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.UpdUser, objGCVariableTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCVariableTypeCond.IsUpdated(conGCVariableType.Memo) == true)
{
string strComparisonOpMemo = objGCVariableTypeCond.dicFldComparisonOp[conGCVariableType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariableType.Memo, objGCVariableTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCVariableType(GC变量类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:VarTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCVariableTypeEN objGCVariableTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCVariableTypeEN == null) return true;
if (objGCVariableTypeEN.VarTypeId == null || objGCVariableTypeEN.VarTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarTypeName = '{0}'", objGCVariableTypeEN.VarTypeName);
if (clsGCVariableTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("VarTypeId !=  '{0}'", objGCVariableTypeEN.VarTypeId);
 sbCondition.AppendFormat(" and VarTypeName = '{0}'", objGCVariableTypeEN.VarTypeName);
if (clsGCVariableTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCVariableType(GC变量类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:VarTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCVariableTypeEN objGCVariableTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCVariableTypeEN == null) return "";
if (objGCVariableTypeEN.VarTypeId == null || objGCVariableTypeEN.VarTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarTypeName = '{0}'", objGCVariableTypeEN.VarTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("VarTypeId !=  '{0}'", objGCVariableTypeEN.VarTypeId);
 sbCondition.AppendFormat(" and VarTypeName = '{0}'", objGCVariableTypeEN.VarTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCVariableType
{
public virtual bool UpdRelaTabDate(string strVarTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumGCVariableType
{
 /// <summary>
 /// 给定值
 /// </summary>
public const string GivingValue_0001 = "0001";
 /// <summary>
 /// 缺省值
 /// </summary>
public const string DefaultValue_0002 = "0002";
 /// <summary>
 /// 本地存储
 /// </summary>
public const string localStorage_0003 = "0003";
 /// <summary>
 /// sessionStorage
 /// </summary>
public const string sessionStorage_0004 = "0004";
 /// <summary>
 /// 查询字符串
 /// </summary>
public const string QueryString_0005 = "0005";
 /// <summary>
 /// 静态变量
 /// </summary>
public const string StaticValuable_0006 = "0006";
 /// <summary>
 /// 缓存分类字段
 /// </summary>
public const string CacheClassifyField_0007 = "0007";
 /// <summary>
 /// 函数
 /// </summary>
public const string Function_0008 = "0008";
 /// <summary>
 /// storeStorage
 /// </summary>
public const string storeStorage_0009 = "0009";
 /// <summary>
 /// 对象
 /// </summary>
public const string Object_0010 = "0010";
}
 /// <summary>
 /// GC变量类型(GCVariableType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCVariableTypeBL
{
public static RelatedActions_GCVariableType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCVariableTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCVariableTypeDA GCVariableTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCVariableTypeDA();
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
 public clsGCVariableTypeBL()
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
if (string.IsNullOrEmpty(clsGCVariableTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVariableTypeEN._ConnectString);
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
public static DataTable GetDataTable_GCVariableType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCVariableTypeDA.GetDataTable_GCVariableType(strWhereCond);
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
objDT = GCVariableTypeDA.GetDataTable(strWhereCond);
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
objDT = GCVariableTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCVariableTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCVariableTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCVariableTypeDA.GetDataTable_Top(objTopPara);
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
objDT = GCVariableTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCVariableTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCVariableTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrVarTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCVariableTypeEN> GetObjLstByVarTypeIdLst(List<string> arrVarTypeIdLst)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVarTypeIdLst, true);
 string strWhereCond = string.Format("VarTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVarTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCVariableTypeEN> GetObjLstByVarTypeIdLstCache(List<string> arrVarTypeIdLst)
{
string strKey = string.Format("{0}", clsGCVariableTypeEN._CurrTabName);
List<clsGCVariableTypeEN> arrGCVariableTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableTypeEN> arrGCVariableTypeObjLst_Sel =
arrGCVariableTypeObjLstCache
.Where(x => arrVarTypeIdLst.Contains(x.VarTypeId));
return arrGCVariableTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableTypeEN> GetObjLst(string strWhereCond)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
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
public static List<clsGCVariableTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCVariableTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCVariableTypeEN> GetSubObjLstCache(clsGCVariableTypeEN objGCVariableTypeCond)
{
List<clsGCVariableTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVariableType._AttributeName)
{
if (objGCVariableTypeCond.IsUpdated(strFldName) == false) continue;
if (objGCVariableTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableTypeCond[strFldName].ToString());
}
else
{
if (objGCVariableTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVariableTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVariableTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVariableTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVariableTypeCond[strFldName]));
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
public static List<clsGCVariableTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
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
public static List<clsGCVariableTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
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
List<clsGCVariableTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCVariableTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCVariableTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
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
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
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
public static List<clsGCVariableTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCVariableTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCVariableTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
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
public static List<clsGCVariableTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCVariableTypeEN> arrObjLst = new List<clsGCVariableTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN();
try
{
objGCVariableTypeEN.VarTypeId = objRow[conGCVariableType.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableTypeEN.VarTypeName = objRow[conGCVariableType.VarTypeName].ToString().Trim(); //变量类型名
objGCVariableTypeEN.VarTypeENName = objRow[conGCVariableType.VarTypeENName].ToString().Trim(); //变量类型英文名
objGCVariableTypeEN.VarTypeSimName = objRow[conGCVariableType.VarTypeSimName] == DBNull.Value ? null : objRow[conGCVariableType.VarTypeSimName].ToString().Trim(); //变量类型简名
objGCVariableTypeEN.UpdDate = objRow[conGCVariableType.UpdDate] == DBNull.Value ? null : objRow[conGCVariableType.UpdDate].ToString().Trim(); //修改日期
objGCVariableTypeEN.UpdUser = objRow[conGCVariableType.UpdUser] == DBNull.Value ? null : objRow[conGCVariableType.UpdUser].ToString().Trim(); //修改者
objGCVariableTypeEN.Memo = objRow[conGCVariableType.Memo] == DBNull.Value ? null : objRow[conGCVariableType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableTypeEN.VarTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCVariableType(ref clsGCVariableTypeEN objGCVariableTypeEN)
{
bool bolResult = GCVariableTypeDA.GetGCVariableType(ref objGCVariableTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVarTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVariableTypeEN GetObjByVarTypeId(string strVarTypeId)
{
if (strVarTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strVarTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVarTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strVarTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCVariableTypeEN objGCVariableTypeEN = GCVariableTypeDA.GetObjByVarTypeId(strVarTypeId);
return objGCVariableTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCVariableTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCVariableTypeEN objGCVariableTypeEN = GCVariableTypeDA.GetFirstObj(strWhereCond);
 return objGCVariableTypeEN;
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
public static clsGCVariableTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCVariableTypeEN objGCVariableTypeEN = GCVariableTypeDA.GetObjByDataRow(objRow);
 return objGCVariableTypeEN;
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
public static clsGCVariableTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCVariableTypeEN objGCVariableTypeEN = GCVariableTypeDA.GetObjByDataRow(objRow);
 return objGCVariableTypeEN;
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
 /// <param name = "strVarTypeId">所给的关键字</param>
 /// <param name = "lstGCVariableTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVariableTypeEN GetObjByVarTypeIdFromList(string strVarTypeId, List<clsGCVariableTypeEN> lstGCVariableTypeObjLst)
{
foreach (clsGCVariableTypeEN objGCVariableTypeEN in lstGCVariableTypeObjLst)
{
if (objGCVariableTypeEN.VarTypeId == strVarTypeId)
{
return objGCVariableTypeEN;
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
 string strMaxVarTypeId;
 try
 {
 strMaxVarTypeId = clsGCVariableTypeDA.GetMaxStrId();
 return strMaxVarTypeId;
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
 string strVarTypeId;
 try
 {
 strVarTypeId = new clsGCVariableTypeDA().GetFirstID(strWhereCond);
 return strVarTypeId;
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
 arrList = GCVariableTypeDA.GetID(strWhereCond);
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
bool bolIsExist = GCVariableTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVarTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVarTypeId)
{
if (string.IsNullOrEmpty(strVarTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strVarTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCVariableTypeDA.IsExist(strVarTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strVarTypeId">变量类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strVarTypeId, string strOpUser)
{
clsGCVariableTypeEN objGCVariableTypeEN = clsGCVariableTypeBL.GetObjByVarTypeId(strVarTypeId);
objGCVariableTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCVariableTypeEN.UpdUser = strOpUser;
return clsGCVariableTypeBL.UpdateBySql2(objGCVariableTypeEN);
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
 bolIsExist = clsGCVariableTypeDA.IsExistTable();
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
 bolIsExist = GCVariableTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCVariableTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!变量类型名 = [{0}]的数据已经存在!(in clsGCVariableTypeBL.AddNewRecordBySql2)", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
bool bolResult = GCVariableTypeDA.AddNewRecordBySQL2(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCVariableTypeEN objGCVariableTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCVariableTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!变量类型名 = [{0}]的数据已经存在!(in clsGCVariableTypeBL.AddNewRecordBySql2WithReturnKey)", objGCVariableTypeEN.VarTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true || clsGCVariableTypeBL.IsExist(objGCVariableTypeEN.VarTypeId) == true)
 {
     objGCVariableTypeEN.VarTypeId = clsGCVariableTypeBL.GetMaxStrId_S();
 }
string strKey = GCVariableTypeDA.AddNewRecordBySQL2WithReturnKey(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCVariableTypeEN objGCVariableTypeEN)
{
try
{
bool bolResult = GCVariableTypeDA.Update(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "objGCVariableTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCVariableTypeEN objGCVariableTypeEN)
{
 if (string.IsNullOrEmpty(objGCVariableTypeEN.VarTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCVariableTypeDA.UpdateBySql2(objGCVariableTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableTypeBL.ReFreshCache();

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
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
 /// <param name = "strVarTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strVarTypeId)
{
try
{
 clsGCVariableTypeEN objGCVariableTypeEN = clsGCVariableTypeBL.GetObjByVarTypeId(strVarTypeId);

if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(objGCVariableTypeEN.VarTypeId, objGCVariableTypeEN.UpdUser);
}
if (objGCVariableTypeEN != null)
{
int intRecNum = GCVariableTypeDA.DelRecord(strVarTypeId);
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
/// <param name="strVarTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strVarTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVariableTypeDA.GetSpecSQLObj();
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
//删除与表:[GCVariableType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCVariableType.VarTypeId,
//strVarTypeId);
//        clsGCVariableTypeBL.DelGCVariableTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVariableTypeBL.DelRecord(strVarTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVariableTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strVarTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strVarTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCVariableTypeBL.relatedActions != null)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(strVarTypeId, "UpdRelaTabDate");
}
bool bolResult = GCVariableTypeDA.DelRecord(strVarTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrVarTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCVariableTypes(List<string> arrVarTypeIdLst)
{
if (arrVarTypeIdLst.Count == 0) return 0;
try
{
if (clsGCVariableTypeBL.relatedActions != null)
{
foreach (var strVarTypeId in arrVarTypeIdLst)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(strVarTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCVariableTypeDA.DelGCVariableType(arrVarTypeIdLst);
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
public static int DelGCVariableTypesByCond(string strWhereCond)
{
try
{
if (clsGCVariableTypeBL.relatedActions != null)
{
List<string> arrVarTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strVarTypeId in arrVarTypeId)
{
clsGCVariableTypeBL.relatedActions.UpdRelaTabDate(strVarTypeId, "UpdRelaTabDate");
}
}
int intRecNum = GCVariableTypeDA.DelGCVariableType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCVariableType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strVarTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strVarTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVariableTypeDA.GetSpecSQLObj();
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
//删除与表:[GCVariableType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVariableTypeBL.DelRecord(strVarTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVariableTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCVariableTypeENS">源对象</param>
 /// <param name = "objGCVariableTypeENT">目标对象</param>
 public static void CopyTo(clsGCVariableTypeEN objGCVariableTypeENS, clsGCVariableTypeEN objGCVariableTypeENT)
{
try
{
objGCVariableTypeENT.VarTypeId = objGCVariableTypeENS.VarTypeId; //变量类型Id
objGCVariableTypeENT.VarTypeName = objGCVariableTypeENS.VarTypeName; //变量类型名
objGCVariableTypeENT.VarTypeENName = objGCVariableTypeENS.VarTypeENName; //变量类型英文名
objGCVariableTypeENT.VarTypeSimName = objGCVariableTypeENS.VarTypeSimName; //变量类型简名
objGCVariableTypeENT.UpdDate = objGCVariableTypeENS.UpdDate; //修改日期
objGCVariableTypeENT.UpdUser = objGCVariableTypeENS.UpdUser; //修改者
objGCVariableTypeENT.Memo = objGCVariableTypeENS.Memo; //说明
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
 /// <param name = "objGCVariableTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsGCVariableTypeEN objGCVariableTypeEN)
{
try
{
objGCVariableTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCVariableTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCVariableType.VarTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.VarTypeId = objGCVariableTypeEN.VarTypeId; //变量类型Id
}
if (arrFldSet.Contains(conGCVariableType.VarTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.VarTypeName = objGCVariableTypeEN.VarTypeName; //变量类型名
}
if (arrFldSet.Contains(conGCVariableType.VarTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.VarTypeENName = objGCVariableTypeEN.VarTypeENName; //变量类型英文名
}
if (arrFldSet.Contains(conGCVariableType.VarTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.VarTypeSimName = objGCVariableTypeEN.VarTypeSimName == "[null]" ? null :  objGCVariableTypeEN.VarTypeSimName; //变量类型简名
}
if (arrFldSet.Contains(conGCVariableType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.UpdDate = objGCVariableTypeEN.UpdDate == "[null]" ? null :  objGCVariableTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCVariableType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.UpdUser = objGCVariableTypeEN.UpdUser == "[null]" ? null :  objGCVariableTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCVariableType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableTypeEN.Memo = objGCVariableTypeEN.Memo == "[null]" ? null :  objGCVariableTypeEN.Memo; //说明
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
 /// <param name = "objGCVariableTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCVariableTypeEN objGCVariableTypeEN)
{
try
{
if (objGCVariableTypeEN.VarTypeSimName == "[null]") objGCVariableTypeEN.VarTypeSimName = null; //变量类型简名
if (objGCVariableTypeEN.UpdDate == "[null]") objGCVariableTypeEN.UpdDate = null; //修改日期
if (objGCVariableTypeEN.UpdUser == "[null]") objGCVariableTypeEN.UpdUser = null; //修改者
if (objGCVariableTypeEN.Memo == "[null]") objGCVariableTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCVariableTypeEN objGCVariableTypeEN)
{
 GCVariableTypeDA.CheckPropertyNew(objGCVariableTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCVariableTypeEN objGCVariableTypeEN)
{
 GCVariableTypeDA.CheckProperty4Condition(objGCVariableTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_VarTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCVariableType.VarTypeId); 
List<clsGCVariableTypeEN> arrObjLst = clsGCVariableTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCVariableTypeEN objGCVariableTypeEN = new clsGCVariableTypeEN()
{
VarTypeId = "0",
VarTypeName = "选[GC变量类型]..."
};
arrObjLst.Insert(0, objGCVariableTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCVariableType.VarTypeId;
objComboBox.DisplayMember = conGCVariableType.VarTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_VarTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC变量类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conGCVariableType.VarTypeId); 
IEnumerable<clsGCVariableTypeEN> arrObjLst = clsGCVariableTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conGCVariableType.VarTypeId;
objDDL.DataTextField = conGCVariableType.VarTypeName;
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
public static void BindDdl_VarTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC变量类型]...","0");
List<clsGCVariableTypeEN> arrGCVariableTypeObjLst = GetAllGCVariableTypeObjLstCache(); 
objDDL.DataValueField = conGCVariableType.VarTypeId;
objDDL.DataTextField = conGCVariableType.VarTypeName;
objDDL.DataSource = arrGCVariableTypeObjLst;
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
if (clsGCVariableTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVariableTypeBL没有刷新缓存机制(clsGCVariableTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VarTypeId");
//if (arrGCVariableTypeObjLstCache == null)
//{
//arrGCVariableTypeObjLstCache = GCVariableTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVarTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVariableTypeEN GetObjByVarTypeIdCache(string strVarTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCVariableTypeEN._CurrTabName);
List<clsGCVariableTypeEN> arrGCVariableTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableTypeEN> arrGCVariableTypeObjLst_Sel =
arrGCVariableTypeObjLstCache
.Where(x=> x.VarTypeId == strVarTypeId 
);
if (arrGCVariableTypeObjLst_Sel.Count() == 0)
{
   clsGCVariableTypeEN obj = clsGCVariableTypeBL.GetObjByVarTypeId(strVarTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCVariableTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetVarTypeNameByVarTypeIdCache(string strVarTypeId)
{
if (string.IsNullOrEmpty(strVarTypeId) == true) return "";
//获取缓存中的对象列表
clsGCVariableTypeEN objGCVariableType = GetObjByVarTypeIdCache(strVarTypeId);
if (objGCVariableType == null) return "";
return objGCVariableType.VarTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByVarTypeIdCache(string strVarTypeId)
{
if (string.IsNullOrEmpty(strVarTypeId) == true) return "";
//获取缓存中的对象列表
clsGCVariableTypeEN objGCVariableType = GetObjByVarTypeIdCache(strVarTypeId);
if (objGCVariableType == null) return "";
return objGCVariableType.VarTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVariableTypeEN> GetAllGCVariableTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsGCVariableTypeEN> arrGCVariableTypeObjLstCache = GetObjLstCache(); 
return arrGCVariableTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVariableTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCVariableTypeEN._CurrTabName);
List<clsGCVariableTypeEN> arrGCVariableTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCVariableTypeObjLstCache;
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
string strKey = string.Format("{0}", clsGCVariableTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVariableTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCVariableTypeEN._RefreshTimeLst.Count == 0) return "";
return clsGCVariableTypeEN._RefreshTimeLst[clsGCVariableTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsGCVariableTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCVariableTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVariableTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCVariableTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCVariableType(GC变量类型)
 /// 唯一性条件:VarTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCVariableTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCVariableTypeEN objGCVariableTypeEN)
{
//检测记录是否存在
string strResult = GCVariableTypeDA.GetUniCondStr(objGCVariableTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strVarTypeId)
{
if (strInFldName != conGCVariableType.VarTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCVariableType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCVariableType._AttributeName));
throw new Exception(strMsg);
}
var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeIdCache(strVarTypeId);
if (objGCVariableType == null) return "";
return objGCVariableType[strOutFldName].ToString();
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
int intRecCount = clsGCVariableTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsGCVariableTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCVariableTypeDA.GetRecCount();
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
int intRecCount = clsGCVariableTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCVariableTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCVariableTypeEN objGCVariableTypeCond)
{
List<clsGCVariableTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVariableType._AttributeName)
{
if (objGCVariableTypeCond.IsUpdated(strFldName) == false) continue;
if (objGCVariableTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableTypeCond[strFldName].ToString());
}
else
{
if (objGCVariableTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVariableTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVariableTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVariableTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVariableTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVariableTypeCond[strFldName]));
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
 List<string> arrList = clsGCVariableTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCVariableTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCVariableTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCVariableTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVariableTypeDA.SetFldValue(clsGCVariableTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCVariableTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVariableTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVariableTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVariableTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCVariableType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**变量类型Id*/ 
 strCreateTabCode.Append(" VarTypeId char(4) primary key, "); 
 // /**变量类型名*/ 
 strCreateTabCode.Append(" VarTypeName varchar(50) not Null, "); 
 // /**变量类型英文名*/ 
 strCreateTabCode.Append(" VarTypeENName varchar(50) not Null, "); 
 // /**变量类型简名*/ 
 strCreateTabCode.Append(" VarTypeSimName varchar(50) Null, "); 
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
 /// GC变量类型(GCVariableType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCVariableType : clsCommFun4BL
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
clsGCVariableTypeBL.ReFreshThisCache();
}
}

}