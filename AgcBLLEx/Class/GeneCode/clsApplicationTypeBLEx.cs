using AGC.BusinessLogic;
using AGC.Entity;
using System.Collections.Generic;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public partial class clsApplicationTypeBLEx : clsApplicationTypeBL
    {
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsApplicationTypeEN> GetApplicationTypeObjLstForBindDdl()
        {
            List<clsApplicationTypeEN> arrApplicationTypeObjLstCache = clsApplicationTypeBL.GetObjLstCache()
                .Where(x => x.IsVisible == true)
                .OrderBy(x => x.OrderNum)
                .ToList();
            return arrApplicationTypeObjLstCache;
        }

        /// <summary>
        /// 获取所有可见的应用对象列表
        /// </summary>
        /// <returns></returns>
        public static List<clsApplicationTypeEN> GetObjLst4Visible()
        {
            List<clsApplicationTypeEN> arrObjLst = clsApplicationTypeBL.GetObjLstCache()
                .Where(x => x.IsVisible == true)
                .OrderBy(x => x.OrderNum)
                .ToList();
            return arrObjLst;
        }
    }
}
