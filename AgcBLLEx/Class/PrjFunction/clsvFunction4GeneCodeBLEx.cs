
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunction4GeneCodeBLEx
表名:vFunction4GeneCode
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
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

using System.Data;
using System.Data.SqlClient;
using AGC.BusinessLogic;
using AGC.Entity;
using AGC.DAL;
using AgcCommBase;

namespace AGC.BusinessLogicEx
{
    class VFunction4GeneCodeComparer : IEqualityComparer<clsvFunction4GeneCodeEN>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(clsvFunction4GeneCodeEN x, clsvFunction4GeneCodeEN y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.FuncName == y.FuncName;
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(clsvFunction4GeneCodeEN product)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(product, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = product.FuncName == null ? 0 : product.FuncName.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = product.FuncId4GC.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }

    }

    /// <summary>
    /// vFunction4GeneCode(vFunction4GeneCode)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFunction4GeneCodeBLEx : clsvFunction4GeneCodeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFunction4GeneCodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFunction4GeneCodeDAEx vFunction4GeneCodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFunction4GeneCodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回数据表,用DataTable表示</returns>
        public static DataTable GetDataTableByAppId(string strWhereCond, int intApplicationTypeId)
        {
            DataTable objDT = null;
            try
            {
                objDT = vFunction4GeneCodeDAEx.GetDataTableByAppId(strWhereCond, intApplicationTypeId);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {2}, intApplicationTypeId=[{4}])({0}->{1})\r\n{3}",
            clsStackTrace.GetCurrClassFunctionByLevel(2),
            clsStackTrace.GetCurrClassFunction(),
            strWhereCond,
            objException.Message,
            intApplicationTypeId);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 根据函数名称获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncName4Code">所给的函数名称</param>
        /// <returns>根据函数名称获取的对象</returns>
        public static clsvFunction4GeneCodeEN GetObjByFuncName4CodeCache(string strFuncName4Code)
        {
            if (string.IsNullOrEmpty(strFuncName4Code) == true) return null;
            //初始化列表缓存
            List<clsvFunction4GeneCodeEN> arrObjLstCache = clsvFunction4GeneCodeBL.GetObjLstCache();

            IEnumerable<clsvFunction4GeneCodeEN> arrFunction4CodeObjLst_Sel1 =
            from objFunction4CodeEN in arrObjLstCache
            where objFunction4CodeEN.FuncName4Code == strFuncName4Code
            select objFunction4CodeEN;
            List<clsvFunction4GeneCodeEN> arrFunction4CodeObjLst_Sel = new List<clsvFunction4GeneCodeEN>();
            foreach (clsvFunction4GeneCodeEN obj in arrFunction4CodeObjLst_Sel1)
            {
                arrFunction4CodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4CodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFunction4CodeObjLst_Sel[0];
        }
        /// <summary>
        /// 判断在一个函数对象列表中，是否存在某一个函数名的对象
        /// </summary>
        /// <param name="arrvFunction4GeneCodeObjLst">函数对象列表</param>
        /// <param name="strFuncName4Code">所给的函数名</param>
        /// <returns></returns>
        public static bool IsExistFuncNameInObjLst(List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst, string strFuncName)
        {
            foreach (clsvFunction4GeneCodeEN objFunction4CodeEN in arrvFunction4GeneCodeObjLst)
            {
                if (objFunction4CodeEN.FuncName == strFuncName) return true;
            }
            return false;
        }

        public static clsvFunction4GeneCodeEN GetObjByFuncId4GCCacheEx(string strFuncId4GC)
        {

            string strWhereCond = string.Format("1 = 1 Order By {0}", convFunction4GeneCode.OrderNum);
            List<clsvFunction4GeneCodeEN> arrObjLstCache = clsvFunction4GeneCodeBL.GetObjLstCache();

            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = new List<clsvFunction4GeneCodeEN>();

            IEnumerable<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
                from objFunction4GeneCodeEN in arrObjLstCache
                where objFunction4GeneCodeEN.FuncId4GC == strFuncId4GC
                select objFunction4GeneCodeEN;


            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsvFunction4GeneCodeEN>();
            foreach (clsvFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
            {
                arrFunction4GeneCodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4GeneCodeObjLst_Sel.Count > 0) return arrFunction4GeneCodeObjLst_Sel[0];
            return null;
        }
        /// <summary>
        /// 获取表相关所有的生成代码函数对象列表
        /// </summary>
        /// <param name="objPrjTabENEx">表对象</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <returns>生成代码函数对象列表</returns>
        public static List<clsvFunction4GeneCodeEN> GetObjLstByPrjTabEx(clsPrjTabENEx objPrjTabENEx, int intApplicationTypeId, string strCmPrjId)
        {

            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(strCmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                            .OrderBy(x => x.OrderNum).ToList();
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = null;

            //添加与表-功能相关的函数
            List<string> arrFeatureId = objPrjTabENEx.arrTabFeatureSet().Select(x => x.FeatureId).ToList();
            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeatureCache
                 = clsvFunction4GeneCodeBLEx.GetObjLst4FeatureIdLst(arrFeatureId, intApplicationTypeId);
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = null;
            if (arrvFunction4GeneCodeObjLst4TabFeatureCache != null)
            {
                arrvFunction4GeneCodeObjLst4TabFeature = arrvFunction4GeneCodeObjLst4TabFeatureCache.
                    Where(x => x.FuncCodeTypeId == objPrjTabENEx.CodeTypeId);
            }

            if (arrvFunction4GeneCodeObjLst4TabFeature != null && arrvFunction4GeneCodeObjLst4TabFeature.Count() > 0)
            {
                arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLst4TabFeature, new VFunction4GeneCodeComparer());
            }
            else
            {
                arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst;
            }

            int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

            arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);
            return arrvFunction4GeneCodeObjLst_All.ToList();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFuncName"></param>
        /// <returns></returns>
        public static clsvFunction4GeneCodeEN GetObjByFuncNameCacheEx(string strFuncName)
        {

            List<clsvFunction4GeneCodeEN> arrObjLstCache = clsvFunction4GeneCodeBL.GetObjLstCache();


            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = new List<clsvFunction4GeneCodeEN>();

            IEnumerable<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
                from objFunction4GeneCodeEN in arrObjLstCache
                where objFunction4GeneCodeEN.FuncName == strFuncName
                select objFunction4GeneCodeEN;


            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsvFunction4GeneCodeEN>();
            foreach (clsvFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
            {
                arrFunction4GeneCodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4GeneCodeObjLst_Sel.Count > 0) return arrFunction4GeneCodeObjLst_Sel[0];

            return null;
        }
        /// <summary>
        /// 根据功能获取相关函数
        /// </summary>
        /// <param name="strFeatureId"></param>
        /// <returns></returns>
        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByFeatureIdBak(string strFeatureId)
        {
            string strWhereCond = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                convFunction4GeneCode.FuncId4GC,
                clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.FeatureId, strFeatureId);
            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = clsvFunction4GeneCodeBL.GetObjLst(strWhereCond);
            return arrFunction4GeneCodeObjLst;
        }

        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByFeatureIdCache(string strFeatureId)
        {
            //string strWhereCond = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
            //    convFunction4GeneCode.FuncId4GC,
            //    clsFeatureFuncRelaEN._CurrTabName,
            //    conFeatureFuncRela.FeatureId, strFeatureId);


            //List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = clsvFunction4GeneCodeBL.GetObjLst(strWhereCond);
            //return arrFunction4GeneCodeObjLst;


            List<clsFeatureFuncRelaEN> arrFeatureFuncRelaCache = clsFeatureFuncRelaBL.GetObjLstCache();
            List<clsFeatureFuncRelaEN> arrFeatureFuncRela = arrFeatureFuncRelaCache.Where(x => x.FeatureId == strFeatureId).ToList();

            List<string> arrFuncId4GC = arrFeatureFuncRela.Select(x => x.FuncId4GC)
                .ToList();
            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstCache = GetObjLstCache();
            //return arrFeatureFuncRelaObjLstCache;
            List<clsvFunction4GeneCodeEN> arrFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLstCache.Where(x => arrFuncId4GC.Contains(x.FuncId4GC)).ToList();
            return arrFunction4GeneCodeObjLst;
        }

        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLst4FeatureIdLst(IEnumerable<string> arrFeatureId)
        {
            if (arrFeatureId.Count() == 0) return null;
            IEnumerable<clsFeatureFuncRelaEN> arrFeatureFuncRelaCache = clsFeatureFuncRelaBL.GetObjLstCache();
            IEnumerable<clsFeatureFuncRelaEN> arrFeatureFuncRela = arrFeatureFuncRelaCache.Where(x => arrFeatureId.Contains(x.FeatureId));
            IEnumerable<string> arrFuncId = arrFeatureFuncRela.Select(x => x.FuncId4GC);

            //string strCondition = string.Format("{0} in (Select {0} From {1} Where {2} in ({3}))",
            //        convFunction4GeneCode.FuncId4GC,
            //        clsFeatureFuncRelaEN._CurrTabName,
            //        conFeatureFuncRela.FeatureId, clsArray.GetSqlInStrByArray(arrFeatureId.ToList(), true));
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = clsvFunction4GeneCodeBL.GetObjLstCache()
                .Where(x => arrFuncId.Contains(x.FuncId4GC));
            return arrvFunction4GeneCodeObjLst4TabFeature;
            //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = clsvFunction4GeneCodeBL.GetObjLst(strCondition).Where(x => x.CodeTypeId == objPrjTabENEx.CodeTypeId);

        }

        public static List<clsvFunction4GeneCodeEN> GetObjLst4FeatureIdLst(IEnumerable<string> arrFeatureId, int intApplicationTypeId)
        {
            if (arrFeatureId.Count() == 0) return null;
            IEnumerable<clsFeatureFuncRelaEN> arrFeatureFuncRelaCache = clsFeatureFuncRelaBL.GetObjLstCache();
            IEnumerable<clsFeatureFuncRelaEN> arrFeatureFuncRela = arrFeatureFuncRelaCache
                .Where(x => x.ApplicationTypeId == intApplicationTypeId && arrFeatureId.Contains(x.FeatureId));
            IEnumerable<string> arrFuncId = arrFeatureFuncRela.Select(x => x.FuncId4GC);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = clsvFunction4GeneCodeBL.GetObjLstCache()
                .Where(x => arrFuncId.Contains(x.FuncId4GC));
            return arrvFunction4GeneCodeObjLst4TabFeature.ToList();

        }
        /// <summary>
        /// 获取界面所有的生成代码函数对象列表
        /// </summary>
        /// <param name="objViewInfoENEx">界面对象</param>
        /// <returns>生成代码函数对象列表</returns>
        public static List<clsvFunction4GeneCodeEN> GetObjLstByViewInfoEx(clsViewInfoENEx objViewInfoENEx)
        {
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                     objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId)
                                   .OrderBy(x => x.OrderNum);

            //int intCount1 = arrvFunction4GeneCodeObjLst.Count();

            List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
            if (arrvFunction4GeneCodeObjLstByFeature == null)
            {
                string strMsg = string.Format("功能区为空，请检查！(In {0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
            arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FuncCodeTypeId == objViewInfoENEx.CodeTypeId).ToList();
            //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();
            //var aa = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FeatureId == enumPrjFeature.AddNewRecordWithMaxId_0183).ToList();
            //var aa2 = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FeatureId == enumPrjFeature.AddNewRecord_0136).ToList();
            //var aa3 = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FeatureId == enumPrjFeature.AddNewRecord_0197).ToList();

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature,
                new VFunction4GeneCodeComparer());
            //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

            arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);

            //int intCount5 = arrvFunction4GeneCodeObjLst_All.Count();
            return arrvFunction4GeneCodeObjLst_All.ToList();

        }

        /// <summary>
        /// 获取界面功能区所有的生成代码函数对象列表
        /// </summary>
        /// <param name="objViewInfoENEx">界面对象</param>
        /// <returns>生成代码函数对象列表</returns>
        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLst4FeatureRegionByViewInfoEx(clsViewInfoENEx objViewInfoENEx)
        {

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.FeatureRegion_0008)
                                   .OrderBy(x => x.OrderNum);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;

            arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FuncCodeTypeId == objViewInfoENEx.CodeTypeId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature,
                new VFunction4GeneCodeComparer());

            arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);
            return arrvFunction4GeneCodeObjLst_All;

        }



        /// <summary>
        /// 获取界面的生成代码函数对象列表,专门指JS函数
        /// </summary>
        /// <param name="objViewInfoENEx">界面对象</param>
        /// <returns>生成代码函数对象列表</returns>
        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByViewInfoEx_JS(clsViewInfoENEx objViewInfoENEx)
        {
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                    clsPubConst.LangType.JavaScript, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId).OrderBy(x => x.FuncName4Code);

            //int intCount1 = arrvFunction4GeneCodeObjLst.Count();
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
            //int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
            arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.FuncCodeTypeId == objViewInfoENEx.CodeTypeId && x.ProgLangTypeId == enumProgLangType.JavaScript_04);
            //int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS_All = arrvFunction4GeneCodeObjLst_JS.Union(arrvFunction4GeneCodeObjLstByFeature,
                new VFunction4GeneCodeComparer());

            //int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

            arrvFunction4GeneCodeObjLst_JS_All = arrvFunction4GeneCodeObjLst_JS_All.OrderBy(x => x.FuncName4Code);
            return arrvFunction4GeneCodeObjLst_JS_All;
        }
        /// <summary>
        /// 获取表相关所有的生成代码函数对象列表
        /// </summary>
        /// <param name="objPrjTabENEx">表对象</param>
        /// <returns>生成代码函数对象列表</returns>
        public static IEnumerable<clsvFunction4GeneCodeEN> GetObjLstByPrjTabEx(clsPrjTabENEx objPrjTabENEx, string strCmPrjId)
        {

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = null;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sub1 =
                            clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(strCmPrjId),
                            objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

            //添加与表-功能相关的函数
            IEnumerable<string> arrFeatureId = objPrjTabENEx.arrTabFeatureSet().Select(x => x.FeatureId);
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeatureCache
    = clsvFunction4GeneCodeBLEx.GetObjLst4FeatureIdLst(arrFeatureId);
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = null;
            if (arrvFunction4GeneCodeObjLst4TabFeatureCache != null)
            {
                arrvFunction4GeneCodeObjLst4TabFeature = arrvFunction4GeneCodeObjLst4TabFeatureCache.
                    Where(x => x.FuncCodeTypeId == objPrjTabENEx.CodeTypeId);
            }



            if (arrvFunction4GeneCodeObjLst4TabFeature != null && arrvFunction4GeneCodeObjLst4TabFeature.Count() > 0)
            {
                arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst_Sub1.Union(arrvFunction4GeneCodeObjLst4TabFeature,
                    new VFunction4GeneCodeComparer());
            }
            else
            {
                arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst_Sub1;
            }
            //int intCount4 = arrvFunction4GeneCodeObjLst.Count();

            arrvFunction4GeneCodeObjLst = arrvFunction4GeneCodeObjLst.OrderBy(x => x.OrderNum);
            return arrvFunction4GeneCodeObjLst;
        }
    }
}