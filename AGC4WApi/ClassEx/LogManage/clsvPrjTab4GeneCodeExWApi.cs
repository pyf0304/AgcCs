
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTab4GeneCodeExWApi
表名:vPrjTab4GeneCode(00050284)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:22
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
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
    /// <summary>
    /// vPrjTab4GeneCode(vPrjTab4GeneCode)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvPrjTab4GeneCodeExWApi
    {
        //private static readonly string mstrApiControllerName = "vPrjTab4GeneCodeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvPrjTab4GeneCodeExWApi()
        {
        }
        ///// <summary>
        ///// 调用函数,根据用户和条件生成界面代码的日志视图对象列表
        ///// </summary>
        ///// <param name = "strUserId">用户Id</param>
        ///// <param name = "strCondition">条件</param>
        ///// <returns>界面代码的日志视图对象列表</returns>
        //public static List<clsvPrjTab4GeneCodeEN> GetvPrjTab4GeneCodeObjListByUserIdAndCondition(
        //    string strUserId, int intApplicationTypeId, string strCondition)
        //{

        //    //DataTable objDT = fn_getvPrjTab4GeneCodeByUserId(strUserId, intApplicationTypeId, strCondition);
        //    //StringBuilder sbCondition = new StringBuilder();
        //    //sbCondition.AppendFormat("SchoolYear = '{1}' And SchoolTerm = '{2}' And Id_PKaoEduClass<>'{0}' And Id_Stu in (Select Id_Stu From PKaoEduClsStu Where Id_PKaoEduClass = '{0}') And {3} = {4}  Order By Id_PKaoWeekTime, Id_PKaoEduClass",
        //    //    strId_EduClass, strSchoolYear, strSchoolTerm, clsvPrjTab4GeneCodeEN.con_WeekSeq, shtWeekSeq);

        //    List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst = fn_getObjLstByUserId(strUserId, intApplicationTypeId, strCondition);
        //    return arrvPrjTab4GeneCodeObjLst;
        //}



       
    }
}