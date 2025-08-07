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
    /// 系统缺省值名称业务逻辑层的扩展类
    /// </summary>
    public class clsSysDefaValNameBLEx: clsSysDefaValNameBL
    {
        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程</param>  
        /// <param name = "strDefaValName">缺省值名</param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsSysDefaValNameEN> GetAllSysDefaValNameObjLstCacheEx(string strDefaValName, string strPrjId)
        {
     
            List<clsSysDefaValNameEN> arrObjLstCache = clsSysDefaValNameBL.GetObjLstCache();
            
            List<clsSysDefaValNameEN> arrSysDefaValNameObjLst = new List<clsSysDefaValNameEN>();

            IEnumerable<clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel1 =
                from objSysDefaValNameEN in arrObjLstCache
                where objSysDefaValNameEN.DefaValName == strDefaValName
                && objSysDefaValNameEN.PrjId == strPrjId
                select objSysDefaValNameEN;


            List<clsSysDefaValNameEN> arrSysDefaValNameObjLst_Sel = new List<clsSysDefaValNameEN>();
            foreach (clsSysDefaValNameEN obj in arrSysDefaValNameObjLst_Sel1)
            {
                arrSysDefaValNameObjLst_Sel.Add(obj);
            }

            return arrSysDefaValNameObjLst_Sel;
        }

    }
}
