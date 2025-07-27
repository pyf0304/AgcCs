
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_FldDispUnitStyleBLEx
 表名:css_FldDispUnitStyle(00050615)
 * 版本:2023.02.04.1(服务器:WIN-SRV103-116)
 日期:2023/02/04 15:26:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
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
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_css_FldDispUnitStyleEx: RelatedActions_css_FldDispUnitStyle
{
public override bool UpdRelaTabDate(string strFldDispUnitStyleId, string strOpUser)
{
return true;
}
}
public static class clscss_FldDispUnitStyleBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <returns>目标对象=>clscss_FldDispUnitStyleEN:objcss_FldDispUnitStyleENT</returns>
 public static clscss_FldDispUnitStyleENEx CopyToEx(this clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS)
{
try
{
 clscss_FldDispUnitStyleENEx objcss_FldDispUnitStyleENT = new clscss_FldDispUnitStyleENEx();
clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.CopyTo(objcss_FldDispUnitStyleENS, objcss_FldDispUnitStyleENT);
 return objcss_FldDispUnitStyleENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <returns>目标对象=>clscss_FldDispUnitStyleEN:objcss_FldDispUnitStyleENT</returns>
 public static clscss_FldDispUnitStyleEN CopyTo(this clscss_FldDispUnitStyleENEx objcss_FldDispUnitStyleENS)
{
try
{
 clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENT = new clscss_FldDispUnitStyleEN();
clscss_FldDispUnitStyleBL.CopyTo(objcss_FldDispUnitStyleENS, objcss_FldDispUnitStyleENT);
 return objcss_FldDispUnitStyleENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// css_FldDispUnitStyle(css_FldDispUnitStyle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscss_FldDispUnitStyleBLEx : clscss_FldDispUnitStyleBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscss_FldDispUnitStyleDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscss_FldDispUnitStyleDAEx css_FldDispUnitStyleDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscss_FldDispUnitStyleDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objcss_FldDispUnitStyleENS">源对象</param>
 /// <returns>目标对象=>clscss_FldDispUnitStyleEN:objcss_FldDispUnitStyleENT</returns>
 public static clscss_FldDispUnitStyleENEx CopyToEx(clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleENS)
{
try
{
 clscss_FldDispUnitStyleENEx objcss_FldDispUnitStyleENT = new clscss_FldDispUnitStyleENEx();
clscss_FldDispUnitStyleBL.css_FldDispUnitStyleDA.CopyTo(objcss_FldDispUnitStyleENS, objcss_FldDispUnitStyleENT);
 return objcss_FldDispUnitStyleENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clscss_FldDispUnitStyleENEx> GetObjExLst(string strCondition)
{
List <clscss_FldDispUnitStyleEN> arrObjLst = clscss_FldDispUnitStyleBL.GetObjLst(strCondition);
List <clscss_FldDispUnitStyleENEx> arrObjExLst = new List<clscss_FldDispUnitStyleENEx>();
foreach (clscss_FldDispUnitStyleEN objInFor in arrObjLst)
{
clscss_FldDispUnitStyleENEx objcss_FldDispUnitStyleENEx = new clscss_FldDispUnitStyleENEx();
clscss_FldDispUnitStyleBL.CopyTo(objInFor, objcss_FldDispUnitStyleENEx);
arrObjExLst.Add(objcss_FldDispUnitStyleENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFldDispUnitStyleId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscss_FldDispUnitStyleENEx GetObjExByFldDispUnitStyleId(string strFldDispUnitStyleId)
{
clscss_FldDispUnitStyleEN objcss_FldDispUnitStyleEN = clscss_FldDispUnitStyleBL.GetObjByFldDispUnitStyleId(strFldDispUnitStyleId);
clscss_FldDispUnitStyleENEx objcss_FldDispUnitStyleENEx = new clscss_FldDispUnitStyleENEx();
clscss_FldDispUnitStyleBL.CopyTo(objcss_FldDispUnitStyleEN, objcss_FldDispUnitStyleENEx);
return objcss_FldDispUnitStyleENEx;
}
}
}