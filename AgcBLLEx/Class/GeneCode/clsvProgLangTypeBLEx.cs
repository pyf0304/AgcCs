
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeBLEx
 表名:vProgLangType
 生成代码版本:2018.04.29.1
 生成日期:2018/04/29 11:42:53
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// vProgLangType(vProgLangType)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
 /// </summary>
public class clsvProgLangTypeBLEx : clsvProgLangTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvProgLangTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvProgLangTypeDAEx vProgLangTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvProgLangTypeDAEx();
}
return uniqueInstanceEx;
}
}
}
}