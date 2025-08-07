using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsViewStyleBLEx : clsViewStyleBL
    {
        // 用于记录缓存的记录数
        public static int intFldNumCache = 0;
        ///// <summary>
        ///// 从缓存中查找失败的次数
        ///// </summary>
        //protected static int intFindFailCount = 0;
        


            /// <summary>
            /// 根据ViewId获取相关的界面样式
            /// </summary>
            /// <param name="strViewId"></param>
            /// <returns></returns>
        public static List<clsViewStyleEN> GetObjLstByViewIdEx(string strViewId)
        {
            string strCondition = string.Format("{0} = '{1}' ", conViewStyle.ViewId, strViewId);
            List<clsViewStyleEN> arrObjLst = clsViewStyleBL.GetObjLst(strCondition);
            return arrObjLst;
        }

            /// <summary>
            /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
            /// </summary>
            /// <param name = "strViewId">所给的关键字</param>
            /// <returns>根据关键字获取的对象</returns>
            public static clsViewStyleEN GetObjByViewIdCacheEx(string strViewId)
        {
           
            List<clsViewStyleEN> arrObjLstCache = clsViewStyleBL.GetObjLstCache();
            var objViewStyle = arrObjLstCache.Find(x=>x.ViewId == strViewId);

            return objViewStyle;
        }
    }
}
