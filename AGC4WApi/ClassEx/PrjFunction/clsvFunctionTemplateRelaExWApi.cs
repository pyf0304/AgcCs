
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunctionTemplateRelaExWApi
表名:vFunctionTemplateRela(00050317)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:38
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
    /// v函数与模板关系(vFunctionTemplateRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvFunctionTemplateRelaExWApi
    {
        //private static readonly string mstrApiControllerName = "vFunctionTemplateRelaExApi";

        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvFunctionTemplateRelaExWApi()
        {
        }
        /// <summary>
        /// 获取表生成某代码类型的相关函数数
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <returns>函数数</returns>
        public static int GetFunctionCountByTabId(string strTabId, string strPrjId, string strCodeTypeId)
        {
            //string strPrjId = 
            clsvPrjTab_SimEN objPrjTab = clsvPrjTab_SimWApi.GetObjByTabIdCache(strTabId, strPrjId);
            List<string> arrSqlDsTypeId = new List<string>() { "00", objPrjTab.SqlDsTypeId };

            string strFunctionTemplateId = clsPrjFuncTemplateRelaExWApi.getFunctionTemplateIdByPrjId(objPrjTab.PrjId);
            //clsCodeTypeEN objCodeTypeEN = clsCodeTypeWApi.GetObjByCodeTypeIdCache(strCodeTypeId);
            //初始化列表缓存
            IEnumerable<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRelaObjLst_Cache =  clsvFunctionTemplateRela_SimWApi.GetObjLstCache(strFunctionTemplateId);
            IEnumerable<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRelaObjLst_Sel1 =
                arrvFunctionTemplateRelaObjLst_Cache
            .Where(x => x.CodeTypeId == strCodeTypeId
                && arrSqlDsTypeId.Contains(x.SqlDsTypeId)
                && x.FunctionTemplateId == strFunctionTemplateId);

            int intCount = arrvFunctionTemplateRelaObjLst_Sel1.Count();

            return intCount;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvFunctionTemplateRelaEN GetObjBymId_Cache11(long lngmId)
        {
            //初始化列表缓存
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst_Cache = clsvFunctionTemplateRelaWApi.GetObjLst("1=1");
            IEnumerable<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst_Sel1 =
            from objvFunctionTemplateRelaEN in arrvFunctionTemplateRelaObjLst_Cache
            where objvFunctionTemplateRelaEN.mId == lngmId
            select objvFunctionTemplateRelaEN;
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst_Sel = new List<clsvFunctionTemplateRelaEN>();
            foreach (clsvFunctionTemplateRelaEN obj in arrvFunctionTemplateRelaObjLst_Sel1)
            {
                arrvFunctionTemplateRelaObjLst_Sel.Add(obj);
            }
            if (arrvFunctionTemplateRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvFunctionTemplateRelaObjLst_Sel[0];
        }

    }
}