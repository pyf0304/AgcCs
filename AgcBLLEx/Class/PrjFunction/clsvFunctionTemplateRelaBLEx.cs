
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunctionTemplateRelaBLEx
表名:vFunctionTemplateRela
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
using AgcCommBase;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// vFunctionTemplateRela(vFunctionTemplateRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvFunctionTemplateRelaBLEx : clsvFunctionTemplateRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFunctionTemplateRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFunctionTemplateRelaDAEx vFunctionTemplateRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFunctionTemplateRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strFunctionTemplateId">工程</param>  
        /// <param name = "ltLangType">语言类型</param>
        /// <param name = "strCodeTypeId">层类型Id</param>
        /// <param name = "strSqlDsTypeId">数据源类型</param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsvFunctionTemplateRelaEN> GetAllvFunctionTemplateRelaObjLstCacheEx(
            string strFunctionTemplateId,
            clsPubConst.LangType ltLangType,
            string strCodeTypeId, string strSqlDsTypeId, string strFuncTypeID)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            List<string> arrSqlDsTypeIdLst = new List<string>();
            arrSqlDsTypeIdLst.Add("00");
            arrSqlDsTypeIdLst.Add(strSqlDsTypeId);

            string strWhereCond = string.Format("1 = 1 Order By {0}", convFunctionTemplateRela.OrderNum);

            List<clsvFunctionTemplateRelaEN> arrObjLstCache = clsvFunctionTemplateRelaBL.GetObjLstCache();

           
          
            IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FunctionTemplateId == strFunctionTemplateId
                && objFunctionTemplateRelaEN.ProgLangTypeId == strProgLangTypeId
                && objFunctionTemplateRelaEN.CodeTypeId == strCodeTypeId
                && objFunctionTemplateRelaEN.FuncTypeId == strFuncTypeID
                && arrSqlDsTypeIdLst.Contains(objFunctionTemplateRelaEN.SqlDsTypeId) == true
                select objFunctionTemplateRelaEN;


            List<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel = new List<clsvFunctionTemplateRelaEN>();
            foreach (clsvFunctionTemplateRelaEN obj in arrFunctionTemplateRelaObjLst_Sel1)
            {
                arrFunctionTemplateRelaObjLst_Sel.Add(obj);
            }

            return arrFunctionTemplateRelaObjLst_Sel;
        }

        public static IEnumerable<clsvFunctionTemplateRelaEN> GetObjObjLstCacheEx(
            string strFunctionTemplateId,
            string strCodeTypeId,
            string strRegionTypeId)
        {
            List<clsvFunctionTemplateRelaEN> arrObjLstCache = clsvFunctionTemplateRelaBL.GetObjLstCache();
            IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FunctionTemplateId == strFunctionTemplateId

                && objFunctionTemplateRelaEN.RegionTypeId == strRegionTypeId
                select objFunctionTemplateRelaEN;
            if (string.IsNullOrEmpty(strCodeTypeId) == false)
            {
                arrFunctionTemplateRelaObjLst_Sel1 = arrFunctionTemplateRelaObjLst_Sel1.Where(x => x.CodeTypeId == strCodeTypeId && x.IsGeneCode == true);
            }

            return arrFunctionTemplateRelaObjLst_Sel1;
        }
               

        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strFunctionTemplateId">工程</param>  
        /// <param name = "ltLangType">语言类型</param>
        /// <param name = "strCodeTypeId">层类型Id</param>
        /// <param name = "strSqlDsTypeId">数据源类型</param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsvFunctionTemplateRelaEN> GetAllvFunctionTemplateRelaObjLstCacheEx(
            string strFunctionTemplateId,
            clsPubConst.LangType ltLangType,
            string strCodeTypeId, string strSqlDsTypeId)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            List<string> arrSqlDsTypeIdLst = new List<string>() { "00", strSqlDsTypeId };
                        
            List<clsvFunctionTemplateRelaEN> arrObjLstCache = clsvFunctionTemplateRelaBL.GetObjLstCache();
           
            IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FunctionTemplateId == strFunctionTemplateId
                && objFunctionTemplateRelaEN.ProgLangTypeId == strProgLangTypeId
                && objFunctionTemplateRelaEN.CodeTypeId == strCodeTypeId
                && objFunctionTemplateRelaEN.IsGeneCode == true

                && arrSqlDsTypeIdLst.Contains(objFunctionTemplateRelaEN.SqlDsTypeId) == true
                select objFunctionTemplateRelaEN;


            List<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel = new List<clsvFunctionTemplateRelaEN>();
            foreach (clsvFunctionTemplateRelaEN obj in arrFunctionTemplateRelaObjLst_Sel1)
            {
                arrFunctionTemplateRelaObjLst_Sel.Add(obj);
            }

            return arrFunctionTemplateRelaObjLst_Sel;
        }

        public static clsvFunctionTemplateRelaEN GetObjByFuncNameCacheEx(string strFuncName)
        {

            List<clsvFunctionTemplateRelaEN> arrObjLstCache = clsvFunctionTemplateRelaBL.GetObjLstCache();

            IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FuncName == strFuncName
                select objFunctionTemplateRelaEN;


            List<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel = new List<clsvFunctionTemplateRelaEN>();
            foreach (clsvFunctionTemplateRelaEN obj in arrFunctionTemplateRelaObjLst_Sel1)
            {
                arrFunctionTemplateRelaObjLst_Sel.Add(obj);
            }
            if (arrFunctionTemplateRelaObjLst_Sel.Count > 0)                return arrFunctionTemplateRelaObjLst_Sel[0];

            return null;
        }

        //public static clsvFunctionTemplateRelaEN GetObjByFuncId4GCCacheEx(string strFuncId4GC)
        //{

        //    string strWhereCond = string.Format("1 = 1 Order By {0}", convFunctionTemplateRela.OrderNum);
        //    if (clsvFunctionTemplateRelaBL.arrvFunctionTemplateRelaObjLstCache == null)
        //    {
        //        clsvFunctionTemplateRelaBL.arrvFunctionTemplateRelaObjLstCache = new clsvFunctionTemplateRelaDA().GetObjLst(strWhereCond);
        //    }

        //    List<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst = new List<clsvFunctionTemplateRelaEN>();

        //    IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
        //        from objFunctionTemplateRelaEN in clsvFunctionTemplateRelaBL.arrvFunctionTemplateRelaObjLstCache
        //        where objFunctionTemplateRelaEN.FuncId4GC == strFuncId4GC
        //        select objFunctionTemplateRelaEN;


        //    List<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel = new List<clsvFunctionTemplateRelaEN>();
        //    foreach (clsvFunctionTemplateRelaEN obj in arrFunctionTemplateRelaObjLst_Sel1)
        //    {
        //        arrFunctionTemplateRelaObjLst_Sel.Add(obj);
        //    }
        //    if (arrFunctionTemplateRelaObjLst_Sel.Count>0) return  arrFunctionTemplateRelaObjLst_Sel[0];
        //    return null;
        //}

        /// <summary>
        /// 根据模板Id、语言、层、数据源类型获取模板函数对象列表
        /// </summary>
        /// <param name="strFunctionTemplateId">模板Id</param>
        /// <param name="ltLangType">语言</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strSqlDsTypeId">数据源类型：表、视图</param>
        /// <returns></returns>
        public static List<clsvFunction4GeneCodeEN> getFunction4GeneCodeObjLstByTemplateId(string strFunctionTemplateId,
            clsPubConst.LangType ltLangType,
            string strCodeTypeId, string strSqlDsTypeId)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
        
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst = clsvFunctionTemplateRelaBLEx.GetAllvFunctionTemplateRelaObjLstCacheEx(strFunctionTemplateId, ltLangType, strCodeTypeId, strSqlDsTypeId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = arrvFunctionTemplateRelaObjLst.Select(GetFunction4GeneCodeObj).OrderBy(x=>x.OrderNum);
            return arrvFunction4GeneCodeObjLst.ToList();
        }

        public static IEnumerable<clsvFunction4GeneCodeEN> getFunction4GeneCodeObjLstByTemplateId(string strFunctionTemplateId, string strCodeTypeId, string strRegionTypeId)
        {

            IEnumerable<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst = clsvFunctionTemplateRelaBLEx.GetObjObjLstCacheEx(strFunctionTemplateId, strCodeTypeId,  strRegionTypeId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = arrvFunctionTemplateRelaObjLst.Select(GetFunction4GeneCodeObj).OrderBy(x => x.OrderNum);
            return arrvFunction4GeneCodeObjLst;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objvFunctionTemplateRelaENS"></param>
        /// <returns></returns>
        public static clsvFunction4GeneCodeEN GetFunction4GeneCodeObj(clsvFunctionTemplateRelaEN objvFunctionTemplateRelaENS)
        {
            clsvFunction4GeneCodeEN objvFunction4GeneCodeENT = clsvFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunctionTemplateRelaENS.FuncId4GC);
            
            return objvFunction4GeneCodeENT;
        }


        /// <summary>
        /// 根据模板Id获取用户自定义模板函数对象列表
        /// USF：用户自定义函数
        /// </summary>
        /// <param name="strFunctionTemplateId">模板Id</param>
        /// <returns></returns>
        public static IEnumerable<clsvFunction4GeneCodeEN> getUSFFunction4GeneCodeObjLstByTemplateId(string strFunctionTemplateId            )
        {
            List<clsvFunctionTemplateRelaEN> arrObjLstCache = clsvFunctionTemplateRelaBL.GetObjLstCache();
                       
            IEnumerable<clsvFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FunctionTemplateId == strFunctionTemplateId              
                && objFunctionTemplateRelaEN.FuncTypeId == "10"
                select objFunctionTemplateRelaEN;
         
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst = arrFunctionTemplateRelaObjLst_Sel1.Select(GetFunction4GeneCodeObj);
            return arrvFunction4GeneCodeObjLst;
            
        }


        public static List<clsvFunctionTemplateRelaEN> getFunction4GeneCodeObjLstByTemplateIdBak(string strFunctionTemplateId,
           clsPubConst.LangType ltLangType,
           string strCodeTypeId, string strSqlDsTypeId)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            string strCondition = string.Format("{0}='{1}' And {2}='{3}' And {4}='{5}' And {6} in ('00','{7}') order by {8}",
                convFunctionTemplateRela.FunctionTemplateId, strFunctionTemplateId,
                 convFunctionTemplateRela.ProgLangTypeId, strProgLangTypeId,
                 convFunctionTemplateRela.CodeTypeId, strCodeTypeId,
                convFunctionTemplateRela.SqlDsTypeId, strSqlDsTypeId,
                convFunctionTemplateRela.OrderNum);
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst = clsvFunctionTemplateRelaBL.GetObjLst(strCondition);
            return arrvFunctionTemplateRelaObjLst;
        }

        public static List<clsvFunctionTemplateRelaEN> GetObjLstByTemplateIdAndCodeTypeId(string strFunctionTemplateId,
              string strCodeTypeId)
        {
            string strCondition = string.Format("{0}='{1}' And {2}='{3}' order by {4}",
                convFunctionTemplateRela.FunctionTemplateId, strFunctionTemplateId,                 
                 convFunctionTemplateRela.CodeTypeId, strCodeTypeId,                
                convFunctionTemplateRela.OrderNum);
            List<clsvFunctionTemplateRelaEN> arrvFunctionTemplateRelaObjLst = clsvFunctionTemplateRelaBL.GetObjLst(strCondition);
            return arrvFunctionTemplateRelaObjLst;
        }

        /// <summary>
        /// 获取表生成某代码类型的相关函数数
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strPrjId">strPrjId</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <returns>函数数</returns>
        public static int GetFunctionCountByTabId(string strTabId, string strPrjId, string strCodeTypeId)
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objPrjTab.PrjId);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            string strCondition = string.Format("{6}='{7}' and {0}='{1}' and {2}='{3}' and {4} in ('00','{5}')",
                convFunctionTemplateRela.ProgLangTypeId, objCodeTypeEN.ProgLangTypeId,
                convFunctionTemplateRela.CodeTypeId, objCodeTypeEN.CodeTypeId,
                convFunctionTemplateRela.SqlDsTypeId, objPrjTab.SqlDsTypeId,
                convFunctionTemplateRela.FunctionTemplateId, strFunctionTemplateId            );
            int intCount = clsvFunctionTemplateRelaBL.GetRecCountByCond(strCondition);

            return intCount;
        }
    }
}