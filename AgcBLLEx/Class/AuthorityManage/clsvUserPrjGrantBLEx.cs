
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantBLEx
 表名:vUserPrjGrant
 生成代码版本:2017.05.06.1
 生成日期:2017/05/07
 生成者:
 工程名称:AGC_CSV7
 工程ID:0005
 模块中文名:权限管理
 模块英文名:AuthorityManage
 框架-层名:业务逻辑扩展层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
 /// vUserPrjGrant(vUserPrjGrant)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
 /// </summary>
public class clsvUserPrjGrantBLEx : clsvUserPrjGrantBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvUserPrjGrantDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvUserPrjGrantDAEx vUserPrjGrantDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvUserPrjGrantDAEx();
}
return uniqueInstanceEx;
}
}
}
}