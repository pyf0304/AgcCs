
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_TemplateStyleBLEx
 表名:vcss_TemplateStyle(00050472)
 生成代码版本:2019.07.15.2
 生成日期:2019/07/18 01:17:18
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsvcss_TemplateStyleBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <returns>目标对象=>clsvcss_TemplateStyleEN:objvcss_TemplateStyleENT</returns>
 public static clsvcss_TemplateStyleENEx CopyToEx(this clsvcss_TemplateStyleEN objvcss_TemplateStyleENS)
{
try
{
 clsvcss_TemplateStyleENEx objvcss_TemplateStyleENT = new clsvcss_TemplateStyleENEx();
clsvcss_TemplateStyleBL.CopyTo(objvcss_TemplateStyleENS, objvcss_TemplateStyleENT);
 return objvcss_TemplateStyleENT;
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
 /// <param name = "objvcss_TemplateStyleENS">源对象</param>
 /// <returns>目标对象=>clsvcss_TemplateStyleEN:objvcss_TemplateStyleENT</returns>
 public static clsvcss_TemplateStyleEN CopyTo(this clsvcss_TemplateStyleENEx objvcss_TemplateStyleENS)
{
try
{
 clsvcss_TemplateStyleEN objvcss_TemplateStyleENT = new clsvcss_TemplateStyleEN();
clsvcss_TemplateStyleBL.CopyTo(objvcss_TemplateStyleENS, objvcss_TemplateStyleENT);
 return objvcss_TemplateStyleENT;
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
 /// vcss_TemplateStyle(vcss_TemplateStyle)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvcss_TemplateStyleBLEx : clsvcss_TemplateStyleBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvcss_TemplateStyleDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvcss_TemplateStyleDAEx vcss_TemplateStyleDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvcss_TemplateStyleDAEx();
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
public static List<clsvcss_TemplateStyleENEx> GetObjExLst(string strCondition)
{
List <clsvcss_TemplateStyleEN> arrObjLst = clsvcss_TemplateStyleBL.GetObjLst(strCondition);
List <clsvcss_TemplateStyleENEx> arrObjExLst = new List<clsvcss_TemplateStyleENEx>();
foreach (clsvcss_TemplateStyleEN objInFor in arrObjLst)
{
clsvcss_TemplateStyleENEx objvcss_TemplateStyleENEx = new clsvcss_TemplateStyleENEx();
clsvcss_TemplateStyleBL.CopyTo(objInFor, objvcss_TemplateStyleENEx);
arrObjExLst.Add(objvcss_TemplateStyleENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvcss_TemplateStyleENEx GetObjExBymId(long lngmId)
{
clsvcss_TemplateStyleEN objvcss_TemplateStyleEN = clsvcss_TemplateStyleBL.GetObjBymId(lngmId);
clsvcss_TemplateStyleENEx objvcss_TemplateStyleENEx = new clsvcss_TemplateStyleENEx();
clsvcss_TemplateStyleBL.CopyTo(objvcss_TemplateStyleEN, objvcss_TemplateStyleENEx);
return objvcss_TemplateStyleENEx;
}
}
}