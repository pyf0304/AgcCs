
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewIdGCVariableRelaExWApi
 表名:ViewIdGCVariableRela(00050631)
 * 版本:2024.11.25.1(服务器:PYF-AI)
 日期:2024/11/27 03:21:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
 框架-层名:WA_访问扩展层(CS)(WA_AccessEx,0186)
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
 /// 界面变量关系(ViewIdGCVariableRela)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsViewIdGCVariableRelaExWApi
{
private static readonly string mstrApiControllerName = "ViewIdGCVariableRelaExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

}
}