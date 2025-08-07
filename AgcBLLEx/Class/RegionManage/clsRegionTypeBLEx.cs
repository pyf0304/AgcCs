using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public partial class clsRegionTypeBLEx : clsRegionTypeBL
    {
        public const string
            QUERYREGION = "0001",
            FUNCTIONREGION = "0008",
            DGREGION = "0002",
            EDITREGION = "0003",
            LISTVIEWREGION = "0004",
            TREEVIEWREGION = "0005",
            DETAILREGION = "0006",
            EXCELEXPORT_REGION = "0007";
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsRegionTypeEN> GetRegionTypeObjLstForBindDdl()
        {
            List<clsRegionTypeEN> arrObjLstCache = clsRegionTypeBL.GetObjLstCache();

            return arrObjLstCache;
        }
    }
}
