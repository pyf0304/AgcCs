using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public partial class clsInOutTypeBLEx : clsInOutTypeBL
    {
        public const string
            OUTIN_Type = "01",
            IN_Type = "02",
            OUT_Type = "03",
            NotOUTIN_Type = "04";
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsInOutTypeEN> GetInOutTypeObjLstForBindDdl()
        {
            List<clsInOutTypeEN> arrObjLstCache = clsInOutTypeBL.GetObjLstCache();

            return arrObjLstCache;
        }
    }
}
