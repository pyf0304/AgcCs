
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionPurposeBLEx
 表名:FunctionPurpose(00050526)
 生成代码版本:2019.11.22.1
 生成日期:2019/11/28 02:28:00
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理
 模块英文名:PrjFunction
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;


namespace AGC.BusinessLogicEx
{
public static class clsFunctionPurposeBLEx_Static
{

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx2(this clsFunctionPurposeEN objFunctionPurposeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFunctionPurposeBL.IsExist(objFunctionPurposeEN.FuncPurposeId))	//判断是否有相同的关键字
{
strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFunctionPurposeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFunctionPurposeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunctionPurposeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx2(this clsFunctionPurposeEN objFunctionPurposeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunctionPurposeEN.CheckPropertyNew();
//4、把数据实体层的数据存贮到数据库中
objFunctionPurposeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
 /// </summary>
 /// <param name = "objFunctionPurpose">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx2(this clsFunctionPurposeEN objFunctionPurpose)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunctionPurposeEN objFunctionPurpose_Cond = new clsFunctionPurposeEN();
string strCondition = objFunctionPurpose_Cond
.SetFuncPurposeId(objFunctionPurpose.FuncPurposeId, "=")
.GetCombineCondition();
objFunctionPurpose._IsCheckProperty = true;
bool bolIsExist = clsFunctionPurposeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunctionPurpose.FuncPurposeId = clsFunctionPurposeBL.GetFirstID_S(strCondition);
objFunctionPurpose.UpdateWithCondition(strCondition);
}
else
{
objFunctionPurpose.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objFunctionPurposeENS">源对象</param>
 /// <returns>目标对象=>clsFunctionPurposeEN:objFunctionPurposeENT</returns>
 public static clsFunctionPurposeENEx CopyToEx(this clsFunctionPurposeEN objFunctionPurposeENS)
{
try
{
 clsFunctionPurposeENEx objFunctionPurposeENT = new clsFunctionPurposeENEx();
clsFunctionPurposeBL.CopyTo(objFunctionPurposeENS, objFunctionPurposeENT);
 return objFunctionPurposeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objFunctionPurposeENS">源对象</param>
 /// <returns>目标对象=>clsFunctionPurposeEN:objFunctionPurposeENT</returns>
 public static clsFunctionPurposeEN CopyTo(this clsFunctionPurposeENEx objFunctionPurposeENS)
{
try
{
 clsFunctionPurposeEN objFunctionPurposeENT = new clsFunctionPurposeEN();
clsFunctionPurposeBL.CopyTo(objFunctionPurposeENS, objFunctionPurposeENT);
 return objFunctionPurposeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 函数用途(FunctionPurpose)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsFunctionPurposeBLEx : clsFunctionPurposeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsFunctionPurposeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsFunctionPurposeDAEx FunctionPurposeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsFunctionPurposeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsFunctionPurposeENEx> GetObjExLst(string strCondition)
{
List <clsFunctionPurposeEN> arrObjLst = clsFunctionPurposeBL.GetObjLst(strCondition);
List <clsFunctionPurposeENEx> arrObjExLst = new List<clsFunctionPurposeENEx>();
foreach (clsFunctionPurposeEN objInFor in arrObjLst)
{
clsFunctionPurposeENEx objFunctionPurposeENEx = new clsFunctionPurposeENEx();
clsFunctionPurposeBL.CopyTo(objInFor, objFunctionPurposeENEx);
arrObjExLst.Add(objFunctionPurposeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFuncPurposeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsFunctionPurposeENEx GetObjExByFuncPurposeId(string strFuncPurposeId)
{
clsFunctionPurposeEN objFunctionPurposeEN = clsFunctionPurposeBL.GetObjByFuncPurposeId(strFuncPurposeId);
clsFunctionPurposeENEx objFunctionPurposeENEx = new clsFunctionPurposeENEx();
clsFunctionPurposeBL.CopyTo(objFunctionPurposeEN, objFunctionPurposeENEx);
return objFunctionPurposeENEx;
}
}
}