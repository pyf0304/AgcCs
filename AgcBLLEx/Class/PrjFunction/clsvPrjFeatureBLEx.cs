
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjFeatureBLEx
表名:vPrjFeature
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
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
    /// <summary>
    /// vPrjFeature(vPrjFeature)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvPrjFeatureBLEx : clsvPrjFeatureBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPrjFeatureDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPrjFeatureDAEx vPrjFeatureDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPrjFeatureDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据界面Id获取功能对象列表
        /// </summary>
        /// <param name="strViewId">界面Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>功能对象列表</returns>
        public static List<clsvPrjFeatureEN> GetObjLstByViewId(string strViewId, string strPrjId)
        {
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);
                        
            string strCondtion = string.Format("{0} in (Select {0} From {1} Where {2} in ({3}))",
                convPrjFeature.FeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            List<clsvPrjFeatureEN> arrvPrjFeatureObjLst = clsvPrjFeatureBL.GetObjLst(strCondtion);
            return arrvPrjFeatureObjLst;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableByAppId(string strWhereCond, int intApplicationTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = vPrjFeatureDAEx.GetDataTableByAppId(strWhereCond, intApplicationTypeId);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {2})({0}->{1})\r\n{3}",
                clsStackTrace.GetCurrClassFunctionByLevel(2),
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件和应用类型Id获取对象列表,用对象列表表示
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回对象列表,用对象列表表示</returns>
        public static List<clsvPrjFeatureEN> GetObjLstByAppId(string strWhereCond, int intApplicationTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = vPrjFeatureDAEx.GetDataTableByAppId(strWhereCond, intApplicationTypeId);
                List<clsvPrjFeatureEN> arrObjLst = clsvPrjFeatureBL.GetObjLstFromDataTable(objDT);
                return arrObjLst;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取对象列表出错!(strWhereCond = {2}，intApplicationTypeId={4})({0}->{1})\r\n{3}",
                clsStackTrace.GetCurrClassFunctionByLevel(2),
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message, intApplicationTypeId);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFeatureId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvPrjFeatureEN GetObjByFeatureIdCacheEx(List<clsvPrjFeatureEN> arrvPrjFeatureObjLst, string strFeatureId)
        {
            if (string.IsNullOrEmpty(strFeatureId) == true) return null;
        
            IEnumerable<clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel1 =
            from objvPrjFeatureEN in arrvPrjFeatureObjLst
            where objvPrjFeatureEN.FeatureId == strFeatureId
            select objvPrjFeatureEN;
            List<clsvPrjFeatureEN> arrvPrjFeatureObjLst_Sel = new List<clsvPrjFeatureEN>();
            foreach (clsvPrjFeatureEN obj in arrvPrjFeatureObjLst_Sel1)
            {
                arrvPrjFeatureObjLst_Sel.Add(obj);
            }
            if (arrvPrjFeatureObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvPrjFeatureObjLst_Sel[0];
        }
    }
}