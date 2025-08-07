
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMap_SimExWApi
 表名:vDnFuncMap_Sim(00050625)
 * 版本:2023.07.16.1(服务器:PYF-THINKPAD)
 日期:2023/07/18 17:14:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:WA_访问扩展层(CS)(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;

namespace AGC4WApi
{
 /// <summary>
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvDnFuncMap_SimExWApi
{
private static readonly string mstrApiControllerName = "vDnFuncMap_SimExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

}
}