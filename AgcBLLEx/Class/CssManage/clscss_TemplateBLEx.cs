
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscss_TemplateBLEx
 表名:css_Template(00050469)
 生成代码版本:2019.07.15.2
 生成日期:2019/07/18 01:45:20
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理
 模块英文名:CssManage
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
public static class clscss_TemplateBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <returns>目标对象=>clscss_TemplateEN:objcss_TemplateENT</returns>
 public static clscss_TemplateENEx CopyToEx(this clscss_TemplateEN objcss_TemplateENS)
{
try
{
 clscss_TemplateENEx objcss_TemplateENT = new clscss_TemplateENEx();
clscss_TemplateBL.CopyTo(objcss_TemplateENS, objcss_TemplateENT);
 return objcss_TemplateENT;
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
 /// <param name = "objcss_TemplateENS">源对象</param>
 /// <returns>目标对象=>clscss_TemplateEN:objcss_TemplateENT</returns>
 public static clscss_TemplateEN CopyTo(this clscss_TemplateENEx objcss_TemplateENS)
{
try
{
 clscss_TemplateEN objcss_TemplateENT = new clscss_TemplateEN();
clscss_TemplateBL.CopyTo(objcss_TemplateENS, objcss_TemplateENT);
 return objcss_TemplateENT;
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
 /// css_Template(css_Template)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clscss_TemplateBLEx : clscss_TemplateBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clscss_TemplateDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clscss_TemplateDAEx css_TemplateDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clscss_TemplateDAEx();
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
public static List<clscss_TemplateENEx> GetObjExLst(string strCondition)
{
List <clscss_TemplateEN> arrObjLst = clscss_TemplateBL.GetObjLst(strCondition);
List <clscss_TemplateENEx> arrObjExLst = new List<clscss_TemplateENEx>();
foreach (clscss_TemplateEN objInFor in arrObjLst)
{
clscss_TemplateENEx objcss_TemplateENEx = new clscss_TemplateENEx();
clscss_TemplateBL.CopyTo(objInFor, objcss_TemplateENEx);
arrObjExLst.Add(objcss_TemplateENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTemplateId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clscss_TemplateENEx GetObjExByTemplateId(string strTemplateId)
{
clscss_TemplateEN objcss_TemplateEN = clscss_TemplateBL.GetObjByTemplateId(strTemplateId);
clscss_TemplateENEx objcss_TemplateENEx = new clscss_TemplateENEx();
clscss_TemplateBL.CopyTo(objcss_TemplateEN, objcss_TemplateENEx);
return objcss_TemplateENEx;
}
}
}