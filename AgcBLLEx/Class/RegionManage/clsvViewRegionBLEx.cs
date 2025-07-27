
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewRegionBLEx
表名:vViewRegion
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{

    public static class clsvViewRegionBLEx_Static
    {
        public static bool InUseInViewId(this clsvViewRegionEN objvViewRegion, string strViewId, string strCmPrjId)
        {
            var objvViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(strViewId, objvViewRegion.RegionId, strCmPrjId,"");
            if (objvViewRegionRela == null) return false;

            return objvViewRegionRela.InUse;
        }
        public static bool InUseInViewInfo(this clsvViewRegionEN objvViewRegion, clsViewInfoEN objViewInfo)
        {
            var objvViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(objViewInfo.ViewId, objvViewRegion.RegionId, objViewInfo.PrjId,"");
            if (objvViewRegionRela == null) return false;

            return objvViewRegionRela.InUse;
        }

        public static bool IsDispInViewId(this clsvViewRegionEN objvViewRegion, string strViewId, string strPrjId)
        {
            var objvViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionId(strViewId, objvViewRegion.RegionId);
            if (objvViewRegionRela == null) return false;

            return objvViewRegionRela.IsDisp;
        }
        public static bool IsDispInViewInfo(this clsvViewRegionEN objvViewRegion, clsViewInfoEN objViewInfo)
        {
            var objvViewRegionRela = clsViewRegionRelaBLEx.GetObjByViewIdAndRegionIdCache(objViewInfo.ViewId, objvViewRegion.RegionId, objViewInfo.PrjId, "");
            if (objvViewRegionRela == null) return false;

            return objvViewRegionRela.IsDisp;
        }

        public static bool IsJumpPage(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool IsRadio(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }
        public static bool IsCheck(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool IsHaveDelBtn(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool IsHaveUpdBtn(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool IsHaveDetailBtn(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool AllowSorting(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }
        public static bool AllowPaging(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return true;
            return false;
        }

        public static bool AutoGenerateColumns(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }

        public static string OUTTabName(this clsvViewRegionEN objvViewRegion)
        {
            if (string.IsNullOrEmpty(objvViewRegion.TabId) == true) return "";
            return clsPrjTabBL.GetNameByTabIdCache(objvViewRegion.TabId, objvViewRegion.PrjId);
        }



        public static bool IsInTab(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return false;
            return false;
        }


        public static int FieldNum(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.QueryRegion_0001) return 10;
            if (objvViewRegion.RegionTypeId == enumRegionType.EditRegion_0003) return 10;

            return 0;
        }
        public static int StyleZindex(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return 1000;
            return 0;
        }
        public static int PageSize(this clsvViewRegionEN objvViewRegion)
        {
            if (objvViewRegion.RegionTypeId == enumRegionType.ListRegion_0002) return 15;
            return 0;
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewRegionENS">源对象</param>
        /// <returns>目标对象=>clsvViewRegionEN:objvViewRegionENT</returns>
        public static clsvViewRegionENEx CopyToEx(this clsvViewRegionEN objvViewRegionENS)
        {
            try
            {
                clsvViewRegionENEx objvViewRegionENT = new clsvViewRegionENEx();
                clsvViewRegionBL.CopyTo(objvViewRegionENS, objvViewRegionENT);
                return objvViewRegionENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvViewRegionENS">源对象</param>
        /// <returns>目标对象=>clsvViewRegionEN:objvViewRegionENT</returns>
        public static clsvViewRegionEN CopyTo(this clsvViewRegionENEx objvViewRegionENS)
        {
            try
            {
                clsvViewRegionEN objvViewRegionENT = new clsvViewRegionEN();
                clsvViewRegionBL.CopyTo(objvViewRegionENS, objvViewRegionENT);
                return objvViewRegionENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }


    /// <summary>
    /// v界面区域(vViewRegion)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvViewRegionBLEx : clsvViewRegionBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewRegionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewRegionDAEx vViewRegionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewRegionDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表  
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewRegionENEx> GetObjExLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", clsvViewRegionEN.con_ViewId, strViewId);
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
            List<clsvViewRegionEN> arrObjLstCache = clsvViewRegionBL.GetObjLstCache(strPrjId);// strCondition);
            List<clsvViewRegionEN> arrObjLst = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId)).ToList();
            List<clsvViewRegionENEx> arrObjExLst = new List<clsvViewRegionENEx>();
            foreach (clsvViewRegionEN objInFor in arrObjLst)
            {
                clsvViewRegionENEx objvViewRegionENEx = new clsvViewRegionENEx();
                clsvViewRegionBL.CopyTo(objInFor, objvViewRegionENEx);
                arrObjExLst.Add(objvViewRegionENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewRegionENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewRegionEN> arrObjLst = clsvViewRegionBL.GetObjLst(strCondition);
            List<clsvViewRegionENEx> arrObjExLst = new List<clsvViewRegionENEx>();
            foreach (clsvViewRegionEN objInFor in arrObjLst)
            {
                clsvViewRegionENEx objvViewRegionENEx = new clsvViewRegionENEx();
                clsvViewRegionBL.CopyTo(objInFor, objvViewRegionENEx);
                arrObjExLst.Add(objvViewRegionENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strRegionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewRegionENEx GetObjExByRegionId(string strRegionId)
        {
            clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(strRegionId);
            clsvViewRegionENEx objvViewRegionENEx = new clsvViewRegionENEx();
            clsvViewRegionBL.CopyTo(objvViewRegionEN, objvViewRegionENEx);
            return objvViewRegionENEx;
        }
    }
}