
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewFeatureFldsBLEx
表名:vViewFeatureFlds(00050454)
生成代码版本:2019.04.19.1
生成日期:2019/04/21 07:26:07
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
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
    public static class clsvViewFeatureFldsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsvViewFeatureFldsEN:objvViewFeatureFldsENT</returns>
        public static clsvViewFeatureFldsENEx CopyToEx(this clsvViewFeatureFldsEN objvViewFeatureFldsENS)
        {
            try
            {
                clsvViewFeatureFldsENEx objvViewFeatureFldsENT = new clsvViewFeatureFldsENEx();
                clsvViewFeatureFldsBL.CopyTo(objvViewFeatureFldsENS, objvViewFeatureFldsENT);
                return objvViewFeatureFldsENT;
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
        /// <param name = "objvViewFeatureFldsENS">源对象</param>
        /// <returns>目标对象=>clsvViewFeatureFldsEN:objvViewFeatureFldsENT</returns>
        public static clsvViewFeatureFldsEN CopyTo(this clsvViewFeatureFldsENEx objvViewFeatureFldsENS)
        {
            try
            {
                clsvViewFeatureFldsEN objvViewFeatureFldsENT = new clsvViewFeatureFldsEN();
                clsvViewFeatureFldsBL.CopyTo(objvViewFeatureFldsENS, objvViewFeatureFldsENT);
                return objvViewFeatureFldsENT;
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
    /// v界面功能字段(vViewFeatureFlds)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvViewFeatureFldsBLEx : clsvViewFeatureFldsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewFeatureFldsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewFeatureFldsDAEx vViewFeatureFldsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewFeatureFldsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewFeatureFldsENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewFeatureFldsEN> arrObjLst = clsvViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsvViewFeatureFldsENEx> arrObjExLst = new List<clsvViewFeatureFldsENEx>();
            foreach (clsvViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsvViewFeatureFldsENEx objvViewFeatureFldsENEx = new clsvViewFeatureFldsENEx();
                clsvViewFeatureFldsBL.CopyTo(objInFor, objvViewFeatureFldsENEx);
                arrObjExLst.Add(objvViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewFeatureFldsENEx GetObjExBymId(long lngmId)
        {
            clsvViewFeatureFldsEN objvViewFeatureFldsEN = clsvViewFeatureFldsBL.GetObjBymId(lngmId);
            clsvViewFeatureFldsENEx objvViewFeatureFldsENEx = new clsvViewFeatureFldsENEx();
            clsvViewFeatureFldsBL.CopyTo(objvViewFeatureFldsEN, objvViewFeatureFldsENEx);
            return objvViewFeatureFldsENEx;
        }

        public static List<clsvViewFeatureFldsENEx> GetObjExLstByRegionId(string lngRegionId, string strPrjId)
        {

            string strCondition = string.Format("{0} in (Select {0} From {1} where {2}={3})",
                convViewFeatureFlds.ViewFeatureId,
                clsFeatureRegionFldsEN._CurrTabName,
                conFeatureRegionFlds.RegionId, lngRegionId);

            List<clsvViewFeatureFldsEN> arrObjLst = clsvViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsvViewFeatureFldsENEx> arrObjExLst = new List<clsvViewFeatureFldsENEx>();
            foreach (clsvViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsvViewFeatureFldsENEx objvViewFeatureFldsENEx = new clsvViewFeatureFldsENEx();
                clsvViewFeatureFldsBL.CopyTo(objInFor, objvViewFeatureFldsENEx);
                objvViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objvViewFeatureFldsENEx.ReleFldId, strPrjId);
                if (string.IsNullOrEmpty(objvViewFeatureFldsENEx.CtlTypeId))
                {
                    string strMsg = string.Format("界面功能字段的控件类型为空！功能：{0},字段：{1}. (In {2})", 
                        objvViewFeatureFldsENEx.FeatureName, objvViewFeatureFldsENEx.FldName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                objvViewFeatureFldsENEx.ObjCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objvViewFeatureFldsENEx.CtlTypeId);
             
                arrObjExLst.Add(objvViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }

        public static List<clsvViewFeatureFldsENEx> GetObjExLstByViewIdBak(string strViewId, string strPrjId)
        {

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} in ({3}))",
                convViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
            convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));

            List<clsvViewFeatureFldsEN> arrObjLst = clsvViewFeatureFldsBL.GetObjLst(strCondition);
            List<clsvViewFeatureFldsENEx> arrObjExLst = new List<clsvViewFeatureFldsENEx>();
            foreach (clsvViewFeatureFldsEN objInFor in arrObjLst)
            {
                clsvViewFeatureFldsENEx objvViewFeatureFldsENEx = new clsvViewFeatureFldsENEx();
                clsvViewFeatureFldsBL.CopyTo(objInFor, objvViewFeatureFldsENEx);

                objvViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objvViewFeatureFldsENEx.ReleFldId, strPrjId);
                objvViewFeatureFldsENEx.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvViewFeatureFldsENEx.ObjFieldTabENEx.DataTypeId).CopyToEx();

                arrObjExLst.Add(objvViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }
        public static List<clsvViewFeatureFldsENEx> GetObjExLstByViewIdCache(string strViewId, string strPrjId)
        {

            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);


            //string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} in ({3}))",
            //    convViewFeatureFlds.ViewFeatureId,
            //    clsvFeatureRegionFldsEN._CurrTabName,
            //convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));

            List<clsvFeatureRegionFldsEN> arrarrObjLstCacheObjLstCache = clsvFeatureRegionFldsBL.GetObjLstCache(strPrjId);
            
            IEnumerable<clsvFeatureRegionFldsEN> arrvFeatureRegionFldsObjLst = arrarrObjLstCacheObjLstCache.Where(x => arrRegionId.Contains( x.RegionId));
            IEnumerable<string> arrViewFeatureId = arrvFeatureRegionFldsObjLst.Select(x => x.ViewFeatureId);

            List<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLstCache = clsvViewFeatureFldsBL.GetObjLstCache(strPrjId);
            
            IEnumerable<clsvViewFeatureFldsEN> arrvViewFeatureFldsObjLst = arrvViewFeatureFldsObjLstCache.Where(x=> arrViewFeatureId.Contains(x.ViewFeatureId));

            List<clsvViewFeatureFldsENEx> arrObjExLst = new List<clsvViewFeatureFldsENEx>();
            foreach (clsvViewFeatureFldsEN objInFor in arrvViewFeatureFldsObjLst)
            {
                clsvViewFeatureFldsENEx objvViewFeatureFldsENEx = new clsvViewFeatureFldsENEx();
                clsvViewFeatureFldsBL.CopyTo(objInFor, objvViewFeatureFldsENEx);

                objvViewFeatureFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objvViewFeatureFldsENEx.ReleFldId, strPrjId);
                objvViewFeatureFldsENEx.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvViewFeatureFldsENEx.ObjFieldTabENEx.DataTypeId).CopyToEx();

                arrObjExLst.Add(objvViewFeatureFldsENEx);
            }
            return arrObjExLst;
        }
        public static IEnumerable<clsvViewFeatureFldsEN> GetObjLstByViewFeatureIdCache0(string strViewFeatureId, string strCmPrjId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conViewFeatureFlds.ViewFeatureId,
                clsvFeatureRegionFldsEN._CurrTabName,
                convFeatureRegionFlds.ViewFeatureId, strViewFeatureId);

            List<clsvViewFeatureFldsEN> arrObjLstCache = clsvViewFeatureFldsBL.GetObjLstCache(strCmPrjId);
            
            IEnumerable<clsvViewFeatureFldsEN> arrObjLst_Sel = arrObjLstCache.Where(x => x.ViewFeatureId == strViewFeatureId);
            return arrObjLst_Sel;
        }
    }
}