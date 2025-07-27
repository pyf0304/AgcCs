using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// clsPrjFuncTemplateRelaBL的扩展类
    /// </summary>
    public class clsPrjFuncTemplateRelaBLEx: clsPrjFuncTemplateRelaBL
    {
        /// <summary>
        /// 根据工程Id获取模板Id
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取的模板Id</returns>
        public static string getFunctionTemplateIdByPrjId(string strPrjId)
        {
//            string strCondition = string.Format("{0}='{1}'", clsPrjFuncTemplateRelaEN.con_PrjId, strPrjId);
            List<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Sel = GetAllPrjFuncTemplateRelaObjLstCacheEx(strPrjId);
            if (arrPrjFuncTemplateRelaObjLst_Sel.Count == 0)
            {
                string strMsg = string.Format("工程Id：【{0}】没有相应的模板，请联系管理员！", strPrjId);
                throw new Exception(strMsg);
            }
            clsPrjFuncTemplateRelaEN objPrjFuncTemplateRelaEN = arrPrjFuncTemplateRelaObjLst_Sel[0];// clsPrjFuncTemplateRelaBL.GetFirstPrjFuncTemplateRela_S(strCondition);
           
            return objPrjFuncTemplateRelaEN.FunctionTemplateId;
        }

       


        /// <summary>
        /// 从缓存中获取所有正在使用的用户缺省值对象列表.
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsPrjFuncTemplateRelaEN> GetAllPrjFuncTemplateRelaObjLstCacheEx(string strPrjId)
        {
            List<clsPrjFuncTemplateRelaEN> arrObjLstCache = clsPrjFuncTemplateRelaBL.GetObjLstCache();
            
            IEnumerable<clsPrjFuncTemplateRelaEN> arrPrjFuncTemplateRelaObjLst_Sel1 =
                from objPrjFuncTemplateRelaEN in arrObjLstCache
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
