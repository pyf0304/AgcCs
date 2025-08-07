
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabCheckResultExWApi
表名:TabCheckResult(00050188)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:00:32
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:日志管理
模块英文名:LogManage
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using com.taishsoft.datetime;

namespace AGC4WApi
{
    /// <summary>
    /// 表检查结果(TabCheckResult)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsTabCheckResultExWApi
    {
        //private static readonly string mstrApiControllerName = "TabCheckResultExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsTabCheckResultEN> arrTabCheckResultObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsTabCheckResultExWApi()
        {
        }
        public static bool AddErrorResult(string strPrjId, string strPrjDataBaseId,
         string strTabId, string strFldId, string strErrMsg, int strErrorLevelId, string strTabCheckErrorTypeId, string strUserId)
        {
            clsTabCheckResultEN objTabCheckResultEn = new clsTabCheckResultEN();
            objTabCheckResultEn.PrjId = strPrjId;
            objTabCheckResultEn.PrjDataBaseId = strPrjDataBaseId;

            objTabCheckResultEn.TabId = strTabId;
            objTabCheckResultEn.FldId = strFldId;

            objTabCheckResultEn.ErrorLevelId = strErrorLevelId;
            objTabCheckResultEn.ErrorMsg = strErrMsg;
            objTabCheckResultEn.CheckDate = clsDateTime.getTodayDateTimeStr(0);
            objTabCheckResultEn.CheckUser = strUserId;
            objTabCheckResultEn.TabCheckErrorTypeId = strTabCheckErrorTypeId;
            objTabCheckResultEn.AddNewRecord();
            return true;
        }
    }
}