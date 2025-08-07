using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System.Collections.Generic;

namespace AGC.BusinessLogicEx
{
    public class clsPrimaryTypeBLEx : clsPrimaryTypeBL
    {
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsPrimaryTypeEN> GetPrimaryTypeObjLstForBindDdl()
        {
            List<clsPrimaryTypeEN> arrObjLstCache = clsPrimaryTypeBL.GetObjLstCache();

            return arrObjLstCache;
        }
    }
}
