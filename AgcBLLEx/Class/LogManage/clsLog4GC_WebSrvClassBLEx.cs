
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GC_WebSrvClassBLEx
 表名:Log4GC_WebSrvClass
 生成代码版本:2018.01.16.1
 生成日期:2018/02/06 23:36:44
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC_CSV7
 工程ID:0005
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:业务逻辑扩展层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
 /// <summary>
 /// 生成WebSrvClass代码日志(Log4GC_WebSrvClass)
 /// 数据源类型:SQL表
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
 /// </summary>
public class clsLog4GC_WebSrvClassBLEx : clsLog4GC_WebSrvClassBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
/// </summary>
private static clsLog4GC_WebSrvClassDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsLog4GC_WebSrvClassDAEx Log4GC_WebSrvClassDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsLog4GC_WebSrvClassDAEx();
}
return uniqueInstanceEx;
}
}
}
}