
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDict4GCBL
 表名:Dict4GC(00050351)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:22
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
public static class  clsDict4GCBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDict4GCEN GetObj(this K_DictId_Dict4GC myKey)
{
clsDict4GCEN objDict4GCEN = clsDict4GCBL.Dict4GCDA.GetObjByDictId(myKey.Value);
return objDict4GCEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDict4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典值 = [{0}],字典类型Id = [{1}]的数据已经存在!(in clsDict4GCBL.AddNewRecord)", objDict4GCEN.DictValue,objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
bool bolResult = clsDict4GCBL.Dict4GCDA.AddNewRecordBySQL2(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
public static bool AddRecordEx(this clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsDict4GCBL.IsExist(objDict4GCEN.DictId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objDict4GCEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objDict4GCEN.CheckUniqueness() == false)
{
strMsg = string.Format("(字典值(DictValue)=[{0}],字典类型Id(DictTypeId)=[{1}])已经存在,不能重复!", objDict4GCEN.DictValue, objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objDict4GCEN.AddNewRecord();
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDict4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典值 = [{0}],字典类型Id = [{1}]的数据已经存在!(in clsDict4GCBL.AddNewRecordWithMaxId)", objDict4GCEN.DictValue,objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
string strDictId = clsDict4GCBL.Dict4GCDA.AddNewRecordBySQL2WithReturnKey(objDict4GCEN);
     objDict4GCEN.DictId = strDictId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
}
return strDictId;
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objDict4GCEN) == false)
{
var strMsg = string.Format("记录已经存在!字典值 = [{0}],字典类型Id = [{1}]的数据已经存在!(in clsDict4GCBL.AddNewRecordWithReturnKey)", objDict4GCEN.DictValue,objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
string strKey = clsDict4GCBL.Dict4GCDA.AddNewRecordBySQL2WithReturnKey(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictId(this clsDict4GCEN objDict4GCEN, string strDictId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictId, 8, conDict4GC.DictId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDictId, 8, conDict4GC.DictId);
}
objDict4GCEN.DictId = strDictId; //字典Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictId) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictId, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictId] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictValue(this clsDict4GCEN objDict4GCEN, string strDictValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictValue, conDict4GC.DictValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictValue, 500, conDict4GC.DictValue);
}
objDict4GCEN.DictValue = strDictValue; //字典值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictValue) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictValue, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictValue] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictTypeId(this clsDict4GCEN objDict4GCEN, string strDictTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictTypeId, 4, conDict4GC.DictTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDictTypeId, 4, conDict4GC.DictTypeId);
}
objDict4GCEN.DictTypeId = strDictTypeId; //字典类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictTypeId) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictTypeId, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictTypeId] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictKey1(this clsDict4GCEN objDict4GCEN, string strDictKey1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey1, conDict4GC.DictKey1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictKey1, 50, conDict4GC.DictKey1);
}
objDict4GCEN.DictKey1 = strDictKey1; //字典关键字1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictKey1) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictKey1, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictKey1] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictKey2(this clsDict4GCEN objDict4GCEN, string strDictKey2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictKey2, 50, conDict4GC.DictKey2);
}
objDict4GCEN.DictKey2 = strDictKey2; //字典关键字2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictKey2) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictKey2, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictKey2] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetUpdDate(this clsDict4GCEN objDict4GCEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDict4GC.UpdDate);
}
objDict4GCEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.UpdDate) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.UpdDate, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.UpdDate] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetUpdUser(this clsDict4GCEN objDict4GCEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDict4GC.UpdUser);
}
objDict4GCEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.UpdUser) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.UpdUser, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.UpdUser] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetMemo(this clsDict4GCEN objDict4GCEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDict4GC.Memo);
}
objDict4GCEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.Memo) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.Memo, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.Memo] = strComparisonOp;
}
}
return objDict4GCEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDict4GCEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDict4GCEN objDict4GCEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDict4GCEN.CheckPropertyNew();
clsDict4GCEN objDict4GCCond = new clsDict4GCEN();
string strCondition = objDict4GCCond
.SetDictId(objDict4GCEN.DictId, "<>")
.SetDictValue(objDict4GCEN.DictValue, "=")
.SetDictTypeId(objDict4GCEN.DictTypeId, "=")
.GetCombineCondition();
objDict4GCEN._IsCheckProperty = true;
bool bolIsExist = clsDict4GCBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DictValue_DictTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDict4GCEN.Update();
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
 /// <param name = "objDict4GC">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDict4GCEN objDict4GC)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDict4GCEN objDict4GCCond = new clsDict4GCEN();
string strCondition = objDict4GCCond
.SetDictValue(objDict4GC.DictValue, "=")
.SetDictTypeId(objDict4GC.DictTypeId, "=")
.GetCombineCondition();
objDict4GC._IsCheckProperty = true;
bool bolIsExist = clsDict4GCBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDict4GC.DictId = clsDict4GCBL.GetFirstID_S(strCondition);
objDict4GC.UpdateWithCondition(strCondition);
}
else
{
objDict4GC.DictId = clsDict4GCBL.GetMaxStrId_S();
objDict4GC.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDict4GCEN objDict4GCEN)
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDict4GCBL.Dict4GCDA.UpdateBySql2(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDict4GCEN objDict4GCEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDict4GCBL.Dict4GCDA.UpdateBySql2(objDict4GCEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDict4GCEN objDict4GCEN, string strWhereCond)
{
try
{
bool bolResult = clsDict4GCBL.Dict4GCDA.UpdateBySqlWithCondition(objDict4GCEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDict4GCEN objDict4GCEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDict4GCBL.Dict4GCDA.UpdateBySqlWithConditionTransaction(objDict4GCEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDict4GCEN objDict4GCEN)
{
try
{
int intRecNum = clsDict4GCBL.Dict4GCDA.DelRecord(objDict4GCEN.DictId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCENS">源对象</param>
 /// <param name = "objDict4GCENT">目标对象</param>
 public static void CopyTo(this clsDict4GCEN objDict4GCENS, clsDict4GCEN objDict4GCENT)
{
try
{
objDict4GCENT.DictId = objDict4GCENS.DictId; //字典Id
objDict4GCENT.DictValue = objDict4GCENS.DictValue; //字典值
objDict4GCENT.DictTypeId = objDict4GCENS.DictTypeId; //字典类型Id
objDict4GCENT.DictKey1 = objDict4GCENS.DictKey1; //字典关键字1
objDict4GCENT.DictKey2 = objDict4GCENS.DictKey2; //字典关键字2
objDict4GCENT.UpdDate = objDict4GCENS.UpdDate; //修改日期
objDict4GCENT.UpdUser = objDict4GCENS.UpdUser; //修改者
objDict4GCENT.Memo = objDict4GCENS.Memo; //说明
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
 /// <param name = "objDict4GCENS">源对象</param>
 /// <returns>目标对象=>clsDict4GCEN:objDict4GCENT</returns>
 public static clsDict4GCEN CopyTo(this clsDict4GCEN objDict4GCENS)
{
try
{
 clsDict4GCEN objDict4GCENT = new clsDict4GCEN()
{
DictId = objDict4GCENS.DictId, //字典Id
DictValue = objDict4GCENS.DictValue, //字典值
DictTypeId = objDict4GCENS.DictTypeId, //字典类型Id
DictKey1 = objDict4GCENS.DictKey1, //字典关键字1
DictKey2 = objDict4GCENS.DictKey2, //字典关键字2
UpdDate = objDict4GCENS.UpdDate, //修改日期
UpdUser = objDict4GCENS.UpdUser, //修改者
Memo = objDict4GCENS.Memo, //说明
};
 return objDict4GCENT;
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
public static void CheckPropertyNew(this clsDict4GCEN objDict4GCEN)
{
 clsDict4GCBL.Dict4GCDA.CheckPropertyNew(objDict4GCEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDict4GCEN objDict4GCEN)
{
 clsDict4GCBL.Dict4GCDA.CheckProperty4Condition(objDict4GCEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDict4GCEN objDict4GCCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDict4GCCond.IsUpdated(conDict4GC.DictId) == true)
{
string strComparisonOpDictId = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictId, objDict4GCCond.DictId, strComparisonOpDictId);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictValue) == true)
{
string strComparisonOpDictValue = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictValue, objDict4GCCond.DictValue, strComparisonOpDictValue);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictTypeId) == true)
{
string strComparisonOpDictTypeId = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictTypeId, objDict4GCCond.DictTypeId, strComparisonOpDictTypeId);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictKey1) == true)
{
string strComparisonOpDictKey1 = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictKey1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictKey1, objDict4GCCond.DictKey1, strComparisonOpDictKey1);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictKey2) == true)
{
string strComparisonOpDictKey2 = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictKey2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictKey2, objDict4GCCond.DictKey2, strComparisonOpDictKey2);
}
if (objDict4GCCond.IsUpdated(conDict4GC.UpdDate) == true)
{
string strComparisonOpUpdDate = objDict4GCCond.dicFldComparisonOp[conDict4GC.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.UpdDate, objDict4GCCond.UpdDate, strComparisonOpUpdDate);
}
if (objDict4GCCond.IsUpdated(conDict4GC.UpdUser) == true)
{
string strComparisonOpUpdUser = objDict4GCCond.dicFldComparisonOp[conDict4GC.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.UpdUser, objDict4GCCond.UpdUser, strComparisonOpUpdUser);
}
if (objDict4GCCond.IsUpdated(conDict4GC.Memo) == true)
{
string strComparisonOpMemo = objDict4GCCond.dicFldComparisonOp[conDict4GC.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.Memo, objDict4GCCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Dict4GC(生成代码字典), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DictValue_DictTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDict4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDict4GCEN objDict4GCEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDict4GCEN == null) return true;
if (objDict4GCEN.DictId == null || objDict4GCEN.DictId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 if (objDict4GCEN.DictTypeId == null)
{
 sbCondition.AppendFormat(" and DictTypeId is null", objDict4GCEN.DictTypeId);
}
else
{
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
}
if (clsDict4GCBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DictId !=  '{0}'", objDict4GCEN.DictId);
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
if (clsDict4GCBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Dict4GC(生成代码字典), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DictValue_DictTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDict4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDict4GCEN objDict4GCEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDict4GCEN == null) return "";
if (objDict4GCEN.DictId == null || objDict4GCEN.DictId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 if (objDict4GCEN.DictTypeId == null)
{
 sbCondition.AppendFormat(" and DictTypeId is null", objDict4GCEN.DictTypeId);
}
else
{
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DictId !=  '{0}'", objDict4GCEN.DictId);
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Dict4GC
{
public virtual bool UpdRelaTabDate(string strDictId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表字段内容设置enum列表-字段名：[DictKey1]
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList4Field)
 /// </summary>
public class enumDict4GC_DictKey1
{
 /// <summary>
 /// GetRecordJSONObjByKey
 /// </summary>
public const string conGetRecordJSONObjByKey = "GetRecordJSONObjByKey";
 /// <summary>
 /// GetRecordJSONObjLst
 /// </summary>
public const string conGetRecordJSONObjLst = "GetRecordJSONObjLst";
 /// <summary>
 /// GetTopRecordJSONObjLst
 /// </summary>
public const string conGetTopRecordJSONObjLst = "GetTopRecordJSONObjLst";
 /// <summary>
 /// AddNewRecordByJSON
 /// </summary>
public const string conAddNewRecordByJSON = "AddNewRecordByJSON";
 /// <summary>
 /// UpdateRecordByJSON
 /// </summary>
public const string conUpdateRecordByJSON = "UpdateRecordByJSON";
 /// <summary>
 /// DelRecord
 /// </summary>
public const string conDelRecord = "DelRecord";
 /// <summary>
 /// GetFirstJSONObj
 /// </summary>
public const string conGetFirstJSONObj = "GetFirstJSONObj";
 /// <summary>
 /// IsExistRecord
 /// </summary>
public const string conIsExistRecord = "IsExistRecord";
 /// <summary>
 /// GetMaxStrId
 /// </summary>
public const string conGetMaxStrId = "GetMaxStrId";
 /// <summary>
 /// GetMaxStrIdByPrefix
 /// </summary>
public const string conGetMaxStrIdByPrefix = "GetMaxStrIdByPrefix";
 /// <summary>
 /// SelfDefFunc
 /// </summary>
public const string conSelfDefFunc = "SelfDefFunc";
 /// <summary>
 /// GetRecordJSONObjLstByPager
 /// </summary>
public const string conGetRecordJSONObjLstByPager = "GetRecordJSONObjLstByPager";
 /// <summary>
 /// GetRecCountByCond
 /// </summary>
public const string conGetRecCountByCond = "GetRecCountByCond";
 /// <summary>
 /// DelRecordsByJSON
 /// </summary>
public const string conDelRecordsByJSON = "DelRecordsByJSON";
 /// <summary>
 /// GetRecordJSONObjLstByRange
 /// </summary>
public const string conGetRecordJSONObjLstByRange = "GetRecordJSONObjLstByRange";
 /// <summary>
 /// GetObjByKey
 /// </summary>
public const string conGetObjByKey = "GetObjByKey";
 /// <summary>
 /// AddNewRecord
 /// </summary>
public const string conAddNewRecord = "AddNewRecord";
 /// <summary>
 /// GetFirstObj
 /// </summary>
public const string conGetFirstObj = "GetFirstObj";
 /// <summary>
 /// GetObjLstByPager
 /// </summary>
public const string conGetObjLstByPager = "GetObjLstByPager";
 /// <summary>
 /// GetObjLstByRange
 /// </summary>
public const string conGetObjLstByRange = "GetObjLstByRange";
 /// <summary>
 /// GetObjLst
 /// </summary>
public const string conGetObjLst = "GetObjLst";
 /// <summary>
 /// GetTopObjLst
 /// </summary>
public const string conGetTopObjLst = "GetTopObjLst";
 /// <summary>
 /// UpdateRecord
 /// </summary>
public const string conUpdateRecord = "UpdateRecord";
}
 /// <summary>
 /// 根据表字段内容设置enum列表-字段名：[DictKey2]
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList4Field)
 /// </summary>
public class enumDict4GC_DictKey2
{
 /// <summary>
 /// Finished
 /// </summary>
public const string conFinished = "Finished";
 /// <summary>
 /// CorrectFinished
 /// </summary>
public const string conCorrectFinished = "CorrectFinished";
}
 /// <summary>
 /// 生成代码字典(Dict4GC)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDict4GCBL
{
public static RelatedActions_Dict4GC relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDict4GCDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDict4GCDA Dict4GCDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDict4GCDA();
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
 public clsDict4GCBL()
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
if (string.IsNullOrEmpty(clsDict4GCEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDict4GCEN._ConnectString);
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
public static DataTable GetDataTable_Dict4GC(string strWhereCond)
{
DataTable objDT;
try
{
objDT = Dict4GCDA.GetDataTable_Dict4GC(strWhereCond);
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
objDT = Dict4GCDA.GetDataTable(strWhereCond);
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
objDT = Dict4GCDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = Dict4GCDA.GetDataTable(strWhereCond, strTabName);
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
objDT = Dict4GCDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = Dict4GCDA.GetDataTable_Top(objTopPara);
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
objDT = Dict4GCDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = Dict4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = Dict4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDictIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDict4GCEN> GetObjLstByDictIdLst(List<string> arrDictIdLst)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDictIdLst, true);
 string strWhereCond = string.Format("DictId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDictIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDict4GCEN> GetObjLstByDictIdLstCache(List<string> arrDictIdLst)
{
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
List<clsDict4GCEN> arrDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrDict4GCObjLst_Sel =
arrDict4GCObjLstCache
.Where(x => arrDictIdLst.Contains(x.DictId));
return arrDict4GCObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetObjLst(string strWhereCond)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
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
public static List<clsDict4GCEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDict4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDict4GCEN> GetSubObjLstCache(clsDict4GCEN objDict4GCCond)
{
List<clsDict4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDict4GC._AttributeName)
{
if (objDict4GCCond.IsUpdated(strFldName) == false) continue;
if (objDict4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDict4GCCond[strFldName].ToString());
}
else
{
if (objDict4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDict4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDict4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDict4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDict4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDict4GCCond[strFldName]));
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
public static List<clsDict4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
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
public static List<clsDict4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
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
List<clsDict4GCEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDict4GCEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDict4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
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
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
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
public static List<clsDict4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDict4GCEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDict4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
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
public static List<clsDict4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDict4GCEN> arrObjLst = new List<clsDict4GCEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDict4GCEN objDict4GCEN = new clsDict4GCEN();
try
{
objDict4GCEN.DictId = objRow[conDict4GC.DictId].ToString().Trim(); //字典Id
objDict4GCEN.DictValue = objRow[conDict4GC.DictValue].ToString().Trim(); //字典值
objDict4GCEN.DictTypeId = objRow[conDict4GC.DictTypeId] == DBNull.Value ? null : objRow[conDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objDict4GCEN.DictKey1 = objRow[conDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objDict4GCEN.DictKey2 = objRow[conDict4GC.DictKey2] == DBNull.Value ? null : objRow[conDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objDict4GCEN.UpdDate = objRow[conDict4GC.UpdDate] == DBNull.Value ? null : objRow[conDict4GC.UpdDate].ToString().Trim(); //修改日期
objDict4GCEN.UpdUser = objRow[conDict4GC.UpdUser] == DBNull.Value ? null : objRow[conDict4GC.UpdUser].ToString().Trim(); //修改者
objDict4GCEN.Memo = objRow[conDict4GC.Memo] == DBNull.Value ? null : objRow[conDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDict4GCEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDict4GCEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDict4GC(ref clsDict4GCEN objDict4GCEN)
{
bool bolResult = Dict4GCDA.GetDict4GC(ref objDict4GCEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDict4GCEN GetObjByDictId(string strDictId)
{
if (strDictId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDictId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDictId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDictId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDict4GCEN objDict4GCEN = Dict4GCDA.GetObjByDictId(strDictId);
return objDict4GCEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDict4GCEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDict4GCEN objDict4GCEN = Dict4GCDA.GetFirstObj(strWhereCond);
 return objDict4GCEN;
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
public static clsDict4GCEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDict4GCEN objDict4GCEN = Dict4GCDA.GetObjByDataRow(objRow);
 return objDict4GCEN;
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
public static clsDict4GCEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDict4GCEN objDict4GCEN = Dict4GCDA.GetObjByDataRow(objRow);
 return objDict4GCEN;
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
 /// <param name = "strDictId">所给的关键字</param>
 /// <param name = "lstDict4GCObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDict4GCEN GetObjByDictIdFromList(string strDictId, List<clsDict4GCEN> lstDict4GCObjLst)
{
foreach (clsDict4GCEN objDict4GCEN in lstDict4GCObjLst)
{
if (objDict4GCEN.DictId == strDictId)
{
return objDict4GCEN;
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
 string strMaxDictId;
 try
 {
 strMaxDictId = clsDict4GCDA.GetMaxStrId();
 return strMaxDictId;
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
 string strDictId;
 try
 {
 strDictId = new clsDict4GCDA().GetFirstID(strWhereCond);
 return strDictId;
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
 arrList = Dict4GCDA.GetID(strWhereCond);
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
bool bolIsExist = Dict4GCDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDictId)
{
if (string.IsNullOrEmpty(strDictId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDictId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = Dict4GCDA.IsExist(strDictId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strDictId">字典Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strDictId, string strOpUser)
{
clsDict4GCEN objDict4GCEN = clsDict4GCBL.GetObjByDictId(strDictId);
objDict4GCEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDict4GCEN.UpdUser = strOpUser;
return clsDict4GCBL.UpdateBySql2(objDict4GCEN);
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
 bolIsExist = clsDict4GCDA.IsExistTable();
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
 bolIsExist = Dict4GCDA.IsExistTable(strTabName);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDict4GCEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字典值 = [{0}],字典类型Id = [{1}]的数据已经存在!(in clsDict4GCBL.AddNewRecordBySql2)", objDict4GCEN.DictValue,objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
bool bolResult = Dict4GCDA.AddNewRecordBySQL2(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDict4GCEN objDict4GCEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objDict4GCEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!字典值 = [{0}],字典类型Id = [{1}]的数据已经存在!(in clsDict4GCBL.AddNewRecordBySql2WithReturnKey)", objDict4GCEN.DictValue,objDict4GCEN.DictTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCBL.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCBL.GetMaxStrId_S();
 }
string strKey = Dict4GCDA.AddNewRecordBySQL2WithReturnKey(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDict4GCEN objDict4GCEN)
{
try
{
bool bolResult = Dict4GCDA.Update(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDict4GCEN objDict4GCEN)
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = Dict4GCDA.UpdateBySql2(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCBL.ReFreshCache();

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strDictId)
{
try
{
 clsDict4GCEN objDict4GCEN = clsDict4GCBL.GetObjByDictId(strDictId);

if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(objDict4GCEN.DictId, objDict4GCEN.UpdUser);
}
if (objDict4GCEN != null)
{
int intRecNum = Dict4GCDA.DelRecord(strDictId);
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
/// <param name="strDictId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strDictId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDict4GCDA.GetSpecSQLObj();
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
//删除与表:[Dict4GC]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDict4GC.DictId,
//strDictId);
//        clsDict4GCBL.DelDict4GCsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDict4GCBL.DelRecord(strDictId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDict4GCBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDictId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strDictId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strDictId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDict4GCBL.relatedActions != null)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(strDictId, "UpdRelaTabDate");
}
bool bolResult = Dict4GCDA.DelRecord(strDictId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDictIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDict4GCs(List<string> arrDictIdLst)
{
if (arrDictIdLst.Count == 0) return 0;
try
{
if (clsDict4GCBL.relatedActions != null)
{
foreach (var strDictId in arrDictIdLst)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(strDictId, "UpdRelaTabDate");
}
}
int intDelRecNum = Dict4GCDA.DelDict4GC(arrDictIdLst);
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
public static int DelDict4GCsByCond(string strWhereCond)
{
try
{
if (clsDict4GCBL.relatedActions != null)
{
List<string> arrDictId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDictId in arrDictId)
{
clsDict4GCBL.relatedActions.UpdRelaTabDate(strDictId, "UpdRelaTabDate");
}
}
int intRecNum = Dict4GCDA.DelDict4GC(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Dict4GC]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strDictId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strDictId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDict4GCDA.GetSpecSQLObj();
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
//删除与表:[Dict4GC]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDict4GCBL.DelRecord(strDictId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDict4GCBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strDictId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDict4GCENS">源对象</param>
 /// <param name = "objDict4GCENT">目标对象</param>
 public static void CopyTo(clsDict4GCEN objDict4GCENS, clsDict4GCEN objDict4GCENT)
{
try
{
objDict4GCENT.DictId = objDict4GCENS.DictId; //字典Id
objDict4GCENT.DictValue = objDict4GCENS.DictValue; //字典值
objDict4GCENT.DictTypeId = objDict4GCENS.DictTypeId; //字典类型Id
objDict4GCENT.DictKey1 = objDict4GCENS.DictKey1; //字典关键字1
objDict4GCENT.DictKey2 = objDict4GCENS.DictKey2; //字典关键字2
objDict4GCENT.UpdDate = objDict4GCENS.UpdDate; //修改日期
objDict4GCENT.UpdUser = objDict4GCENS.UpdUser; //修改者
objDict4GCENT.Memo = objDict4GCENS.Memo; //说明
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
 /// <param name = "objDict4GCEN">源简化对象</param>
 public static void SetUpdFlag(clsDict4GCEN objDict4GCEN)
{
try
{
objDict4GCEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDict4GCEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDict4GC.DictId, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.DictId = objDict4GCEN.DictId; //字典Id
}
if (arrFldSet.Contains(conDict4GC.DictValue, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.DictValue = objDict4GCEN.DictValue; //字典值
}
if (arrFldSet.Contains(conDict4GC.DictTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.DictTypeId = objDict4GCEN.DictTypeId == "[null]" ? null :  objDict4GCEN.DictTypeId; //字典类型Id
}
if (arrFldSet.Contains(conDict4GC.DictKey1, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.DictKey1 = objDict4GCEN.DictKey1; //字典关键字1
}
if (arrFldSet.Contains(conDict4GC.DictKey2, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.DictKey2 = objDict4GCEN.DictKey2 == "[null]" ? null :  objDict4GCEN.DictKey2; //字典关键字2
}
if (arrFldSet.Contains(conDict4GC.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.UpdDate = objDict4GCEN.UpdDate == "[null]" ? null :  objDict4GCEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDict4GC.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.UpdUser = objDict4GCEN.UpdUser == "[null]" ? null :  objDict4GCEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conDict4GC.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDict4GCEN.Memo = objDict4GCEN.Memo == "[null]" ? null :  objDict4GCEN.Memo; //说明
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
 /// <param name = "objDict4GCEN">源简化对象</param>
 public static void AccessFldValueNull(clsDict4GCEN objDict4GCEN)
{
try
{
if (objDict4GCEN.DictTypeId == "[null]") objDict4GCEN.DictTypeId = null; //字典类型Id
if (objDict4GCEN.DictKey2 == "[null]") objDict4GCEN.DictKey2 = null; //字典关键字2
if (objDict4GCEN.UpdDate == "[null]") objDict4GCEN.UpdDate = null; //修改日期
if (objDict4GCEN.UpdUser == "[null]") objDict4GCEN.UpdUser = null; //修改者
if (objDict4GCEN.Memo == "[null]") objDict4GCEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsDict4GCEN objDict4GCEN)
{
 Dict4GCDA.CheckPropertyNew(objDict4GCEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDict4GCEN objDict4GCEN)
{
 Dict4GCDA.CheckProperty4Condition(objDict4GCEN);
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
if (clsDict4GCBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDict4GCBL没有刷新缓存机制(clsDict4GCBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DictId");
//if (arrDict4GCObjLstCache == null)
//{
//arrDict4GCObjLstCache = Dict4GCDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDictId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDict4GCEN GetObjByDictIdCache(string strDictId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
List<clsDict4GCEN> arrDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrDict4GCObjLst_Sel =
arrDict4GCObjLstCache
.Where(x=> x.DictId == strDictId 
);
if (arrDict4GCObjLst_Sel.Count() == 0)
{
   clsDict4GCEN obj = clsDict4GCBL.GetObjByDictId(strDictId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDict4GCObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDict4GCEN> GetAllDict4GCObjLstCache()
{
//获取缓存中的对象列表
List<clsDict4GCEN> arrDict4GCObjLstCache = GetObjLstCache(); 
return arrDict4GCObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDict4GCEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
List<clsDict4GCEN> arrDict4GCObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDict4GCObjLstCache;
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
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDict4GCEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsDict4GCEN._RefreshTimeLst.Count == 0) return "";
return clsDict4GCEN._RefreshTimeLst[clsDict4GCEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsDict4GCBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDict4GCEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDict4GCBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Dict4GC(生成代码字典)
 /// 唯一性条件:DictValue_DictTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDict4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDict4GCEN objDict4GCEN)
{
//检测记录是否存在
string strResult = Dict4GCDA.GetUniCondStr(objDict4GCEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDictId)
{
if (strInFldName != conDict4GC.DictId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDict4GC._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDict4GC._AttributeName));
throw new Exception(strMsg);
}
var objDict4GC = clsDict4GCBL.GetObjByDictIdCache(strDictId);
if (objDict4GC == null) return "";
return objDict4GC[strOutFldName].ToString();
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
int intRecCount = clsDict4GCDA.GetRecCount(strTabName);
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
int intRecCount = clsDict4GCDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDict4GCDA.GetRecCount();
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
int intRecCount = clsDict4GCDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDict4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDict4GCEN objDict4GCCond)
{
List<clsDict4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDict4GC._AttributeName)
{
if (objDict4GCCond.IsUpdated(strFldName) == false) continue;
if (objDict4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDict4GCCond[strFldName].ToString());
}
else
{
if (objDict4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDict4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDict4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDict4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDict4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDict4GCCond[strFldName]));
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
 List<string> arrList = clsDict4GCDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = Dict4GCDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = Dict4GCDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = Dict4GCDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDict4GCDA.SetFldValue(clsDict4GCEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = Dict4GCDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDict4GCDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDict4GCDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDict4GCDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Dict4GC] "); 
 strCreateTabCode.Append(" ( "); 
 // /**字典Id*/ 
 strCreateTabCode.Append(" DictId char(8) primary key, "); 
 // /**字典值*/ 
 strCreateTabCode.Append(" DictValue varchar(500) not Null, "); 
 // /**字典类型Id*/ 
 strCreateTabCode.Append(" DictTypeId char(4) Null, "); 
 // /**字典关键字1*/ 
 strCreateTabCode.Append(" DictKey1 varchar(50) not Null, "); 
 // /**字典关键字2*/ 
 strCreateTabCode.Append(" DictKey2 varchar(50) Null, "); 
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
 /// 生成代码字典(Dict4GC)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Dict4GC : clsCommFun4BL
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
clsDict4GCBL.ReFreshThisCache();
}
}

}