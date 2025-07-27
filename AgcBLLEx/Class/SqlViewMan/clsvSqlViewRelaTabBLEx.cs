using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsvSqlViewRelaTabBLEx
    {

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strRelaTabId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvSqlViewRelaTabEN GetvSqlViewRelaTabObjByRelaTabIdCache(string strTabAliases, List<clsvSqlViewRelaTabEN> arrvSqlViewRelaTabObjLst)
        {

            foreach (clsvSqlViewRelaTabEN objvSqlViewRelaTabEN in arrvSqlViewRelaTabObjLst)
            {
                if (objvSqlViewRelaTabEN.TabAliases  ==  strTabAliases)
                {
                    return objvSqlViewRelaTabEN;
                }
            }
            return null;
        }
    }
}
