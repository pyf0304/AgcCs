
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureTypeBL
 表名:CMFeatureType(00050518)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsCMFeatureTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureTypeEN GetObj(this K_CmFeatureTypeId_CMFeatureType myKey)
{
clsCMFeatureTypeEN objCMFeatureTypeEN = clsCMFeatureTypeBL.CMFeatureTypeDA.GetObjByCmFeatureTypeId(myKey.Value);
return objCMFeatureTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!功能类型名称 = [{0}]的数据已经存在!(in clsCMFeatureTypeBL.AddNewRecord)", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsCMFeatureTypeBL.CMFeatureTypeDA.AddNewRecordBySQL2(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCMFeatureTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMFeatureTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能类型名称(FeatureTypeName)=[{0}])已经存在,不能重复!", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCMFeatureTypeEN.AddNewRecord();
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!功能类型名称 = [{0}]的数据已经存在!(in clsCMFeatureTypeBL.AddNewRecordWithMaxId)", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
string strCmFeatureTypeId = clsCMFeatureTypeBL.CMFeatureTypeDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureTypeEN);
     objCMFeatureTypeEN.CmFeatureTypeId = strCmFeatureTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
}
return strCmFeatureTypeId;
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFeatureTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!功能类型名称 = [{0}]的数据已经存在!(in clsCMFeatureTypeBL.AddNewRecordWithReturnKey)", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
string strKey = clsCMFeatureTypeBL.CMFeatureTypeDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetCmFeatureTypeId(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strCmFeatureTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFeatureTypeId, 2, conCMFeatureType.CmFeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFeatureTypeId, 2, conCMFeatureType.CmFeatureTypeId);
}
objCMFeatureTypeEN.CmFeatureTypeId = strCmFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.CmFeatureTypeId) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.CmFeatureTypeId, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.CmFeatureTypeId] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetFeatureTypeName(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, conCMFeatureType.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, conCMFeatureType.FeatureTypeName);
}
objCMFeatureTypeEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.FeatureTypeName) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.FeatureTypeName, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.FeatureTypeName] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetFeatureTypeENName(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strFeatureTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeENName, 30, conCMFeatureType.FeatureTypeENName);
}
objCMFeatureTypeEN.FeatureTypeENName = strFeatureTypeENName; //功能类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.FeatureTypeENName) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.FeatureTypeENName, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.FeatureTypeENName] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetOrderNum(this clsCMFeatureTypeEN objCMFeatureTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMFeatureType.OrderNum);
objCMFeatureTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.OrderNum) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.OrderNum, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.OrderNum] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetUpdDate(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFeatureType.UpdDate);
}
objCMFeatureTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.UpdDate) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.UpdDate, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.UpdDate] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetUpdUser(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFeatureType.UpdUser);
}
objCMFeatureTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.UpdUser) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.UpdUser, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.UpdUser] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureTypeEN SetMemo(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFeatureType.Memo);
}
objCMFeatureTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureTypeEN.dicFldComparisonOp.ContainsKey(conCMFeatureType.Memo) == false)
{
objCMFeatureTypeEN.dicFldComparisonOp.Add(conCMFeatureType.Memo, strComparisonOp);
}
else
{
objCMFeatureTypeEN.dicFldComparisonOp[conCMFeatureType.Memo] = strComparisonOp;
}
}
return objCMFeatureTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMFeatureTypeEN.CheckPropertyNew();
clsCMFeatureTypeEN objCMFeatureTypeCond = new clsCMFeatureTypeEN();
string strCondition = objCMFeatureTypeCond
.SetCmFeatureTypeId(objCMFeatureTypeEN.CmFeatureTypeId, "<>")
.SetFeatureTypeName(objCMFeatureTypeEN.FeatureTypeName, "=")
.GetCombineCondition();
objCMFeatureTypeEN._IsCheckProperty = true;
bool bolIsExist = clsCMFeatureTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FeatureTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMFeatureTypeEN.Update();
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
 /// <param name = "objCMFeatureType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMFeatureTypeEN objCMFeatureType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMFeatureTypeEN objCMFeatureTypeCond = new clsCMFeatureTypeEN();
string strCondition = objCMFeatureTypeCond
.SetFeatureTypeName(objCMFeatureType.FeatureTypeName, "=")
.GetCombineCondition();
objCMFeatureType._IsCheckProperty = true;
bool bolIsExist = clsCMFeatureTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMFeatureType.CmFeatureTypeId = clsCMFeatureTypeBL.GetFirstID_S(strCondition);
objCMFeatureType.UpdateWithCondition(strCondition);
}
else
{
objCMFeatureType.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
objCMFeatureType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFeatureTypeBL.CMFeatureTypeDA.UpdateBySql2(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureTypeEN objCMFeatureTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFeatureTypeBL.CMFeatureTypeDA.UpdateBySql2(objCMFeatureTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsCMFeatureTypeBL.CMFeatureTypeDA.UpdateBySqlWithCondition(objCMFeatureTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureTypeEN objCMFeatureTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMFeatureTypeBL.CMFeatureTypeDA.UpdateBySqlWithConditionTransaction(objCMFeatureTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "strCmFeatureTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
try
{
int intRecNum = clsCMFeatureTypeBL.CMFeatureTypeDA.DelRecord(objCMFeatureTypeEN.CmFeatureTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeENS">源对象</param>
 /// <param name = "objCMFeatureTypeENT">目标对象</param>
 public static void CopyTo(this clsCMFeatureTypeEN objCMFeatureTypeENS, clsCMFeatureTypeEN objCMFeatureTypeENT)
{
try
{
objCMFeatureTypeENT.CmFeatureTypeId = objCMFeatureTypeENS.CmFeatureTypeId; //功能类型Id
objCMFeatureTypeENT.FeatureTypeName = objCMFeatureTypeENS.FeatureTypeName; //功能类型名称
objCMFeatureTypeENT.FeatureTypeENName = objCMFeatureTypeENS.FeatureTypeENName; //功能类型英文名
objCMFeatureTypeENT.OrderNum = objCMFeatureTypeENS.OrderNum; //序号
objCMFeatureTypeENT.UpdDate = objCMFeatureTypeENS.UpdDate; //修改日期
objCMFeatureTypeENT.UpdUser = objCMFeatureTypeENS.UpdUser; //修改者
objCMFeatureTypeENT.Memo = objCMFeatureTypeENS.Memo; //说明
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
 /// <param name = "objCMFeatureTypeENS">源对象</param>
 /// <returns>目标对象=>clsCMFeatureTypeEN:objCMFeatureTypeENT</returns>
 public static clsCMFeatureTypeEN CopyTo(this clsCMFeatureTypeEN objCMFeatureTypeENS)
{
try
{
 clsCMFeatureTypeEN objCMFeatureTypeENT = new clsCMFeatureTypeEN()
{
CmFeatureTypeId = objCMFeatureTypeENS.CmFeatureTypeId, //功能类型Id
FeatureTypeName = objCMFeatureTypeENS.FeatureTypeName, //功能类型名称
FeatureTypeENName = objCMFeatureTypeENS.FeatureTypeENName, //功能类型英文名
OrderNum = objCMFeatureTypeENS.OrderNum, //序号
UpdDate = objCMFeatureTypeENS.UpdDate, //修改日期
UpdUser = objCMFeatureTypeENS.UpdUser, //修改者
Memo = objCMFeatureTypeENS.Memo, //说明
};
 return objCMFeatureTypeENT;
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
public static void CheckPropertyNew(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 clsCMFeatureTypeBL.CMFeatureTypeDA.CheckPropertyNew(objCMFeatureTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 clsCMFeatureTypeBL.CMFeatureTypeDA.CheckProperty4Condition(objCMFeatureTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFeatureTypeEN objCMFeatureTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.CmFeatureTypeId) == true)
{
string strComparisonOpCmFeatureTypeId = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.CmFeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.CmFeatureTypeId, objCMFeatureTypeCond.CmFeatureTypeId, strComparisonOpCmFeatureTypeId);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.FeatureTypeName, objCMFeatureTypeCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.FeatureTypeENName) == true)
{
string strComparisonOpFeatureTypeENName = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.FeatureTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.FeatureTypeENName, objCMFeatureTypeCond.FeatureTypeENName, strComparisonOpFeatureTypeENName);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFeatureType.OrderNum, objCMFeatureTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.UpdDate, objCMFeatureTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.UpdUser, objCMFeatureTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFeatureTypeCond.IsUpdated(conCMFeatureType.Memo) == true)
{
string strComparisonOpMemo = objCMFeatureTypeCond.dicFldComparisonOp[conCMFeatureType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureType.Memo, objCMFeatureTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMFeatureType(CM功能类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FeatureTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureTypeEN == null) return true;
if (objCMFeatureTypeEN.CmFeatureTypeId == null || objCMFeatureTypeEN.CmFeatureTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objCMFeatureTypeEN.FeatureTypeName);
if (clsCMFeatureTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmFeatureTypeId !=  '{0}'", objCMFeatureTypeEN.CmFeatureTypeId);
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objCMFeatureTypeEN.FeatureTypeName);
if (clsCMFeatureTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMFeatureType(CM功能类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMFeatureTypeEN objCMFeatureTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureTypeEN == null) return "";
if (objCMFeatureTypeEN.CmFeatureTypeId == null || objCMFeatureTypeEN.CmFeatureTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objCMFeatureTypeEN.FeatureTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFeatureTypeId !=  '{0}'", objCMFeatureTypeEN.CmFeatureTypeId);
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objCMFeatureTypeEN.FeatureTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMFeatureType
{
public virtual bool UpdRelaTabDate(string strCmFeatureTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCMFeatureType
{
 /// <summary>
 /// 基本功能
 /// </summary>
public const string BaseFeature_01 = "01";
 /// <summary>
 /// 高级功能
 /// </summary>
public const string AdvancedFeature_02 = "02";
 /// <summary>
 /// 远期功能
 /// </summary>
public const string ForwardFeature_03 = "03";
}
 /// <summary>
 /// CM功能类型(CMFeatureType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMFeatureTypeBL
{
public static RelatedActions_CMFeatureType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMFeatureTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMFeatureTypeDA CMFeatureTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMFeatureTypeDA();
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
 public clsCMFeatureTypeBL()
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
if (string.IsNullOrEmpty(clsCMFeatureTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFeatureTypeEN._ConnectString);
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
public static DataTable GetDataTable_CMFeatureType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMFeatureTypeDA.GetDataTable_CMFeatureType(strWhereCond);
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
objDT = CMFeatureTypeDA.GetDataTable(strWhereCond);
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
objDT = CMFeatureTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMFeatureTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMFeatureTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMFeatureTypeDA.GetDataTable_Top(objTopPara);
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
objDT = CMFeatureTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMFeatureTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMFeatureTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFeatureTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMFeatureTypeEN> GetObjLstByCmFeatureTypeIdLst(List<string> arrCmFeatureTypeIdLst)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFeatureTypeIdLst, true);
 string strWhereCond = string.Format("CmFeatureTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFeatureTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMFeatureTypeEN> GetObjLstByCmFeatureTypeIdLstCache(List<string> arrCmFeatureTypeIdLst)
{
string strKey = string.Format("{0}", clsCMFeatureTypeEN._CurrTabName);
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCMFeatureTypeEN> arrCMFeatureTypeObjLst_Sel =
arrCMFeatureTypeObjLstCache
.Where(x => arrCmFeatureTypeIdLst.Contains(x.CmFeatureTypeId));
return arrCMFeatureTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureTypeEN> GetObjLst(string strWhereCond)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
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
public static List<clsCMFeatureTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMFeatureTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMFeatureTypeEN> GetSubObjLstCache(clsCMFeatureTypeEN objCMFeatureTypeCond)
{
List<clsCMFeatureTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFeatureTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFeatureType._AttributeName)
{
if (objCMFeatureTypeCond.IsUpdated(strFldName) == false) continue;
if (objCMFeatureTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureTypeCond[strFldName].ToString());
}
else
{
if (objCMFeatureTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFeatureTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFeatureTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFeatureTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFeatureTypeCond[strFldName]));
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
public static List<clsCMFeatureTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
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
public static List<clsCMFeatureTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
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
List<clsCMFeatureTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMFeatureTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMFeatureTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
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
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
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
public static List<clsCMFeatureTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMFeatureTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMFeatureTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
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
public static List<clsCMFeatureTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMFeatureTypeEN> arrObjLst = new List<clsCMFeatureTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN();
try
{
objCMFeatureTypeEN.CmFeatureTypeId = objRow[conCMFeatureType.CmFeatureTypeId].ToString().Trim(); //功能类型Id
objCMFeatureTypeEN.FeatureTypeName = objRow[conCMFeatureType.FeatureTypeName].ToString().Trim(); //功能类型名称
objCMFeatureTypeEN.FeatureTypeENName = objRow[conCMFeatureType.FeatureTypeENName] == DBNull.Value ? null : objRow[conCMFeatureType.FeatureTypeENName].ToString().Trim(); //功能类型英文名
objCMFeatureTypeEN.OrderNum = Int32.Parse(objRow[conCMFeatureType.OrderNum].ToString().Trim()); //序号
objCMFeatureTypeEN.UpdDate = objRow[conCMFeatureType.UpdDate] == DBNull.Value ? null : objRow[conCMFeatureType.UpdDate].ToString().Trim(); //修改日期
objCMFeatureTypeEN.UpdUser = objRow[conCMFeatureType.UpdUser] == DBNull.Value ? null : objRow[conCMFeatureType.UpdUser].ToString().Trim(); //修改者
objCMFeatureTypeEN.Memo = objRow[conCMFeatureType.Memo] == DBNull.Value ? null : objRow[conCMFeatureType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFeatureTypeEN.CmFeatureTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFeatureTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMFeatureType(ref clsCMFeatureTypeEN objCMFeatureTypeEN)
{
bool bolResult = CMFeatureTypeDA.GetCMFeatureType(ref objCMFeatureTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureTypeEN GetObjByCmFeatureTypeId(string strCmFeatureTypeId)
{
if (strCmFeatureTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFeatureTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFeatureTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFeatureTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMFeatureTypeEN objCMFeatureTypeEN = CMFeatureTypeDA.GetObjByCmFeatureTypeId(strCmFeatureTypeId);
return objCMFeatureTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMFeatureTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMFeatureTypeEN objCMFeatureTypeEN = CMFeatureTypeDA.GetFirstObj(strWhereCond);
 return objCMFeatureTypeEN;
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
public static clsCMFeatureTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMFeatureTypeEN objCMFeatureTypeEN = CMFeatureTypeDA.GetObjByDataRow(objRow);
 return objCMFeatureTypeEN;
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
public static clsCMFeatureTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMFeatureTypeEN objCMFeatureTypeEN = CMFeatureTypeDA.GetObjByDataRow(objRow);
 return objCMFeatureTypeEN;
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
 /// <param name = "strCmFeatureTypeId">所给的关键字</param>
 /// <param name = "lstCMFeatureTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFeatureTypeEN GetObjByCmFeatureTypeIdFromList(string strCmFeatureTypeId, List<clsCMFeatureTypeEN> lstCMFeatureTypeObjLst)
{
foreach (clsCMFeatureTypeEN objCMFeatureTypeEN in lstCMFeatureTypeObjLst)
{
if (objCMFeatureTypeEN.CmFeatureTypeId == strCmFeatureTypeId)
{
return objCMFeatureTypeEN;
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
 string strMaxCmFeatureTypeId;
 try
 {
 strMaxCmFeatureTypeId = clsCMFeatureTypeDA.GetMaxStrId();
 return strMaxCmFeatureTypeId;
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
 string strCmFeatureTypeId;
 try
 {
 strCmFeatureTypeId = new clsCMFeatureTypeDA().GetFirstID(strWhereCond);
 return strCmFeatureTypeId;
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
 arrList = CMFeatureTypeDA.GetID(strWhereCond);
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
bool bolIsExist = CMFeatureTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFeatureTypeId)
{
if (string.IsNullOrEmpty(strCmFeatureTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFeatureTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMFeatureTypeDA.IsExist(strCmFeatureTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmFeatureTypeId">功能类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmFeatureTypeId, string strOpUser)
{
clsCMFeatureTypeEN objCMFeatureTypeEN = clsCMFeatureTypeBL.GetObjByCmFeatureTypeId(strCmFeatureTypeId);
objCMFeatureTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMFeatureTypeEN.UpdUser = strOpUser;
return clsCMFeatureTypeBL.UpdateBySql2(objCMFeatureTypeEN);
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
 bolIsExist = clsCMFeatureTypeDA.IsExistTable();
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
 bolIsExist = CMFeatureTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFeatureTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能类型名称 = [{0}]的数据已经存在!(in clsCMFeatureTypeBL.AddNewRecordBySql2)", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
bool bolResult = CMFeatureTypeDA.AddNewRecordBySQL2(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMFeatureTypeEN objCMFeatureTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFeatureTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能类型名称 = [{0}]的数据已经存在!(in clsCMFeatureTypeBL.AddNewRecordBySql2WithReturnKey)", objCMFeatureTypeEN.FeatureTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true || clsCMFeatureTypeBL.IsExist(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
     objCMFeatureTypeEN.CmFeatureTypeId = clsCMFeatureTypeBL.GetMaxStrId_S();
 }
string strKey = CMFeatureTypeDA.AddNewRecordBySQL2WithReturnKey(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
try
{
bool bolResult = CMFeatureTypeDA.Update(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "objCMFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 if (string.IsNullOrEmpty(objCMFeatureTypeEN.CmFeatureTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMFeatureTypeDA.UpdateBySql2(objCMFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureTypeBL.ReFreshCache();

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
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
 /// <param name = "strCmFeatureTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmFeatureTypeId)
{
try
{
 clsCMFeatureTypeEN objCMFeatureTypeEN = clsCMFeatureTypeBL.GetObjByCmFeatureTypeId(strCmFeatureTypeId);

if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureTypeEN.CmFeatureTypeId, objCMFeatureTypeEN.UpdUser);
}
if (objCMFeatureTypeEN != null)
{
int intRecNum = CMFeatureTypeDA.DelRecord(strCmFeatureTypeId);
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
/// <param name="strCmFeatureTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmFeatureTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFeatureTypeDA.GetSpecSQLObj();
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
//删除与表:[CMFeatureType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMFeatureType.CmFeatureTypeId,
//strCmFeatureTypeId);
//        clsCMFeatureTypeBL.DelCMFeatureTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFeatureTypeBL.DelRecord(strCmFeatureTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFeatureTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFeatureTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmFeatureTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmFeatureTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(strCmFeatureTypeId, "UpdRelaTabDate");
}
bool bolResult = CMFeatureTypeDA.DelRecord(strCmFeatureTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmFeatureTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMFeatureTypes(List<string> arrCmFeatureTypeIdLst)
{
if (arrCmFeatureTypeIdLst.Count == 0) return 0;
try
{
if (clsCMFeatureTypeBL.relatedActions != null)
{
foreach (var strCmFeatureTypeId in arrCmFeatureTypeIdLst)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(strCmFeatureTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMFeatureTypeDA.DelCMFeatureType(arrCmFeatureTypeIdLst);
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
public static int DelCMFeatureTypesByCond(string strWhereCond)
{
try
{
if (clsCMFeatureTypeBL.relatedActions != null)
{
List<string> arrCmFeatureTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmFeatureTypeId in arrCmFeatureTypeId)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(strCmFeatureTypeId, "UpdRelaTabDate");
}
}
int intRecNum = CMFeatureTypeDA.DelCMFeatureType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMFeatureType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmFeatureTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmFeatureTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFeatureTypeDA.GetSpecSQLObj();
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
//删除与表:[CMFeatureType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFeatureTypeBL.DelRecord(strCmFeatureTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFeatureTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFeatureTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMFeatureTypeENS">源对象</param>
 /// <param name = "objCMFeatureTypeENT">目标对象</param>
 public static void CopyTo(clsCMFeatureTypeEN objCMFeatureTypeENS, clsCMFeatureTypeEN objCMFeatureTypeENT)
{
try
{
objCMFeatureTypeENT.CmFeatureTypeId = objCMFeatureTypeENS.CmFeatureTypeId; //功能类型Id
objCMFeatureTypeENT.FeatureTypeName = objCMFeatureTypeENS.FeatureTypeName; //功能类型名称
objCMFeatureTypeENT.FeatureTypeENName = objCMFeatureTypeENS.FeatureTypeENName; //功能类型英文名
objCMFeatureTypeENT.OrderNum = objCMFeatureTypeENS.OrderNum; //序号
objCMFeatureTypeENT.UpdDate = objCMFeatureTypeENS.UpdDate; //修改日期
objCMFeatureTypeENT.UpdUser = objCMFeatureTypeENS.UpdUser; //修改者
objCMFeatureTypeENT.Memo = objCMFeatureTypeENS.Memo; //说明
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
 /// <param name = "objCMFeatureTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
try
{
objCMFeatureTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMFeatureTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMFeatureType.CmFeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.CmFeatureTypeId = objCMFeatureTypeEN.CmFeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(conCMFeatureType.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.FeatureTypeName = objCMFeatureTypeEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(conCMFeatureType.FeatureTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.FeatureTypeENName = objCMFeatureTypeEN.FeatureTypeENName == "[null]" ? null :  objCMFeatureTypeEN.FeatureTypeENName; //功能类型英文名
}
if (arrFldSet.Contains(conCMFeatureType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.OrderNum = objCMFeatureTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCMFeatureType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.UpdDate = objCMFeatureTypeEN.UpdDate == "[null]" ? null :  objCMFeatureTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMFeatureType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.UpdUser = objCMFeatureTypeEN.UpdUser == "[null]" ? null :  objCMFeatureTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMFeatureType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFeatureTypeEN.Memo = objCMFeatureTypeEN.Memo == "[null]" ? null :  objCMFeatureTypeEN.Memo; //说明
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
 /// <param name = "objCMFeatureTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
try
{
if (objCMFeatureTypeEN.FeatureTypeENName == "[null]") objCMFeatureTypeEN.FeatureTypeENName = null; //功能类型英文名
if (objCMFeatureTypeEN.UpdDate == "[null]") objCMFeatureTypeEN.UpdDate = null; //修改日期
if (objCMFeatureTypeEN.UpdUser == "[null]") objCMFeatureTypeEN.UpdUser = null; //修改者
if (objCMFeatureTypeEN.Memo == "[null]") objCMFeatureTypeEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 CMFeatureTypeDA.CheckPropertyNew(objCMFeatureTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
 CMFeatureTypeDA.CheckProperty4Condition(objCMFeatureTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CmFeatureTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMFeatureType.CmFeatureTypeId); 
List<clsCMFeatureTypeEN> arrObjLst = clsCMFeatureTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMFeatureTypeEN objCMFeatureTypeEN = new clsCMFeatureTypeEN()
{
CmFeatureTypeId = "0",
FeatureTypeName = "选[CM功能类型]..."
};
arrObjLst.Insert(0, objCMFeatureTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMFeatureType.CmFeatureTypeId;
objComboBox.DisplayMember = conCMFeatureType.FeatureTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CmFeatureTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM功能类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMFeatureType.CmFeatureTypeId); 
IEnumerable<clsCMFeatureTypeEN> arrObjLst = clsCMFeatureTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conCMFeatureType.CmFeatureTypeId;
objDDL.DataTextField = conCMFeatureType.FeatureTypeName;
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
public static void BindDdl_CmFeatureTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM功能类型]...","0");
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjLst = GetAllCMFeatureTypeObjLstCache(); 
arrCMFeatureTypeObjLst = arrCMFeatureTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conCMFeatureType.CmFeatureTypeId;
objDDL.DataTextField = conCMFeatureType.FeatureTypeName;
objDDL.DataSource = arrCMFeatureTypeObjLst;
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
if (clsCMFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFeatureTypeBL没有刷新缓存机制(clsCMFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFeatureTypeId");
//if (arrCMFeatureTypeObjLstCache == null)
//{
//arrCMFeatureTypeObjLstCache = CMFeatureTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFeatureTypeEN GetObjByCmFeatureTypeIdCache(string strCmFeatureTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMFeatureTypeEN._CurrTabName);
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsCMFeatureTypeEN> arrCMFeatureTypeObjLst_Sel =
arrCMFeatureTypeObjLstCache
.Where(x=> x.CmFeatureTypeId == strCmFeatureTypeId 
);
if (arrCMFeatureTypeObjLst_Sel.Count() == 0)
{
   clsCMFeatureTypeEN obj = clsCMFeatureTypeBL.GetObjByCmFeatureTypeId(strCmFeatureTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMFeatureTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureTypeNameByCmFeatureTypeIdCache(string strCmFeatureTypeId)
{
if (string.IsNullOrEmpty(strCmFeatureTypeId) == true) return "";
//获取缓存中的对象列表
clsCMFeatureTypeEN objCMFeatureType = GetObjByCmFeatureTypeIdCache(strCmFeatureTypeId);
if (objCMFeatureType == null) return "";
return objCMFeatureType.FeatureTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFeatureTypeIdCache(string strCmFeatureTypeId)
{
if (string.IsNullOrEmpty(strCmFeatureTypeId) == true) return "";
//获取缓存中的对象列表
clsCMFeatureTypeEN objCMFeatureType = GetObjByCmFeatureTypeIdCache(strCmFeatureTypeId);
if (objCMFeatureType == null) return "";
return objCMFeatureType.FeatureTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureTypeEN> GetAllCMFeatureTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjLstCache = GetObjLstCache(); 
return arrCMFeatureTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFeatureTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMFeatureTypeEN._CurrTabName);
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMFeatureTypeObjLstCache;
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
string strKey = string.Format("{0}", clsCMFeatureTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFeatureTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMFeatureTypeEN._RefreshTimeLst.Count == 0) return "";
return clsCMFeatureTypeEN._RefreshTimeLst[clsCMFeatureTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCMFeatureTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFeatureTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFeatureTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMFeatureTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMFeatureType(CM功能类型)
 /// 唯一性条件:FeatureTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFeatureTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMFeatureTypeEN objCMFeatureTypeEN)
{
//检测记录是否存在
string strResult = CMFeatureTypeDA.GetUniCondStr(objCMFeatureTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCmFeatureTypeId)
{
if (strInFldName != conCMFeatureType.CmFeatureTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMFeatureType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMFeatureType._AttributeName));
throw new Exception(strMsg);
}
var objCMFeatureType = clsCMFeatureTypeBL.GetObjByCmFeatureTypeIdCache(strCmFeatureTypeId);
if (objCMFeatureType == null) return "";
return objCMFeatureType[strOutFldName].ToString();
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
int intRecCount = clsCMFeatureTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsCMFeatureTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMFeatureTypeDA.GetRecCount();
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
int intRecCount = clsCMFeatureTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMFeatureTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMFeatureTypeEN objCMFeatureTypeCond)
{
List<clsCMFeatureTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFeatureTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFeatureType._AttributeName)
{
if (objCMFeatureTypeCond.IsUpdated(strFldName) == false) continue;
if (objCMFeatureTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureTypeCond[strFldName].ToString());
}
else
{
if (objCMFeatureTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFeatureTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFeatureTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFeatureTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFeatureTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFeatureTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFeatureTypeCond[strFldName]));
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
 List<string> arrList = clsCMFeatureTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMFeatureTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMFeatureTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMFeatureTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFeatureTypeDA.SetFldValue(clsCMFeatureTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMFeatureTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFeatureTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFeatureTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFeatureTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMFeatureType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能类型Id*/ 
 strCreateTabCode.Append(" CmFeatureTypeId char(2) primary key, "); 
 // /**功能类型名称*/ 
 strCreateTabCode.Append(" FeatureTypeName varchar(30) not Null, "); 
 // /**功能类型英文名*/ 
 strCreateTabCode.Append(" FeatureTypeENName varchar(30) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
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


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conCMFeatureType.OrderNum); 
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjList = new clsCMFeatureTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureTypeEN objCMFeatureType in arrCMFeatureTypeObjList)
{
objCMFeatureType.OrderNum = intIndex;
UpdateBySql2(objCMFeatureType);
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
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCmFeatureTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strCmFeatureTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CmFeatureTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CmFeatureTypeId
//5、把当前关键字CmFeatureTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CmFeatureTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCmFeatureTypeId = "";    //上一条序号的关键字CmFeatureTypeId
string strNextCmFeatureTypeId = "";    //下一条序号的关键字CmFeatureTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[CmFeatureTypeId],获取相应的序号[OrderNum]。

clsCMFeatureTypeEN objCMFeatureType = clsCMFeatureTypeBL.GetObjByCmFeatureTypeId(strCmFeatureTypeId);

intOrderNum = objCMFeatureType.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsCMFeatureTypeBL.GetRecCountByCond(clsCMFeatureTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conCMFeatureType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字CmFeatureTypeId
strPrevCmFeatureTypeId = clsCMFeatureTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevCmFeatureTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CmFeatureTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字CmFeatureTypeId所对应的记录序号加1
clsCMFeatureTypeBL.SetFldValue(clsCMFeatureTypeEN._CurrTabName, conCMFeatureType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conCMFeatureType.CmFeatureTypeId, strCmFeatureTypeId));
clsCMFeatureTypeBL.SetFldValue(clsCMFeatureTypeEN._CurrTabName, conCMFeatureType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conCMFeatureType.CmFeatureTypeId, strPrevCmFeatureTypeId));
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

//4、获取下一个序号字段的关键字CmFeatureTypeId
strCondition.AppendFormat(" {0} = {1}", conCMFeatureType.OrderNum, intOrderNum + 1);

strNextCmFeatureTypeId = clsCMFeatureTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextCmFeatureTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CmFeatureTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字CmFeatureTypeId所对应的记录序号减1
clsCMFeatureTypeBL.SetFldValue(clsCMFeatureTypeEN._CurrTabName, conCMFeatureType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conCMFeatureType.CmFeatureTypeId, strCmFeatureTypeId));
clsCMFeatureTypeBL.SetFldValue(clsCMFeatureTypeEN._CurrTabName, conCMFeatureType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCMFeatureType.CmFeatureTypeId, strNextCmFeatureTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsCMFeatureTypeBL.ReFreshCache();
if (clsCMFeatureTypeBL.relatedActions != null)
{
clsCMFeatureTypeBL.relatedActions.UpdRelaTabDate(objCMFeatureType.CmFeatureTypeId, "UpdRelaTabDate");
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
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCMFeatureType.CmFeatureTypeId, strKeyList);
List<clsCMFeatureTypeEN> arrCMFeatureTypeLst = GetObjLst(strCondition);
foreach (clsCMFeatureTypeEN objCMFeatureType in arrCMFeatureTypeLst)
{
objCMFeatureType.OrderNum = objCMFeatureType.OrderNum + 10000;
UpdateBySql2(objCMFeatureType);
}
strCondition = string.Format("1 = 1 order by {0} ", conCMFeatureType.OrderNum); 
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjList = new clsCMFeatureTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureTypeEN objCMFeatureType in arrCMFeatureTypeObjList)
{
objCMFeatureType.OrderNum = intIndex;
UpdateBySql2(objCMFeatureType);
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
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conCMFeatureType.CmFeatureTypeId, strKeyList);
List<clsCMFeatureTypeEN> arrCMFeatureTypeLst = GetObjLst(strCondition);
foreach (clsCMFeatureTypeEN objCMFeatureType in arrCMFeatureTypeLst)
{
objCMFeatureType.OrderNum = objCMFeatureType.OrderNum - 10000;
UpdateBySql2(objCMFeatureType);
}
strCondition = string.Format("1 = 1 order by {0} ", conCMFeatureType.OrderNum); 
List<clsCMFeatureTypeEN> arrCMFeatureTypeObjList = new clsCMFeatureTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMFeatureTypeEN objCMFeatureType in arrCMFeatureTypeObjList)
{
objCMFeatureType.OrderNum = intIndex;
UpdateBySql2(objCMFeatureType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// CM功能类型(CMFeatureType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMFeatureType : clsCommFun4BL
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
clsCMFeatureTypeBL.ReFreshThisCache();
}
}

}