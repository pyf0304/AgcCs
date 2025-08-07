
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjFuncTemplateRelaExWApi
表名:PrjFuncTemplateRela(00050314)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:36
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:函数管理
模块英文名:PrjFunction
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
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 工程与函数模板关系(PrjFuncTemplateRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjFuncTemplateRelaExWApi
    {
        //private static readonly string mstrApiControllerName = "PrjFuncTemplateRelaExApi";

        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjFuncTemplateRelaExWApi()
        {
        }
        /// <summary>
        /// 根据工程Id获取模板Id
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取的模板Id</returns>
        public static string getFunctionTemplateIdByPrjId(string strPrjId)
        {
            //            string strCondition = string.Format("{0}='{1}'", clsPrjFuncTemplateRelaEN.con_PrjId, strPrjId);
            List<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Sel = GetAllPrjFuncTemplateRelaObjLst_CacheEx(strPrjId);
            if (arrPrjFuncTemplateRelaObjLst_Sel.Count == 0)
            {
                string strMsg = string.Format("工程Id：【{0}】没有相应的模板，请联系管理员！", strPrjId);
                throw new Exception(strMsg);
            }
            clsPrjFuncTemplateRelaEN objPrjFuncTemplateRelaEN = arrPrjFuncTemplateRelaObjLst_Sel[0];// clsPrjFuncTemplateRelaWApi.GetFirstPrjFuncTemplateRela_S(strCondition);

            return objPrjFuncTemplateRelaEN.FunctionTemplateId;
        }


        /// <summary>
        /// 从缓存中获取所有正在使用的用户缺省值对象列表.
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsPrjFuncTemplateRelaEN> GetAllPrjFuncTemplateRelaObjLst_CacheEx(string strPrjId)
        {

            List<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Cache = clsPrjFuncTemplateRelaWApi.GetObjLstCache(strPrjId);
            List<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst = new List<clsPrjFuncTemplateRelaEN>();

            IEnumerable<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Sel1 =
                from objPrjFuncTemplateRelaEN in arrPrjFuncTemplateRelaObjLst_Cache
                where objPrjFuncTemplateRelaEN.PrjId == strPrjId
                select objPrjFuncTemplateRelaEN;


            List<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Sel = new List<clsPrjFuncTemplateRelaEN>();
            foreach (clsPrjFuncTemplateRelaEN obj in arrPrjFuncTemplateRelaObjLst_Sel1)
            {
                arrPrjFuncTemplateRelaObjLst_Sel.Add(obj);
            }

            return arrPrjFuncTemplateRelaObjLst_Sel;
        }


    }
}