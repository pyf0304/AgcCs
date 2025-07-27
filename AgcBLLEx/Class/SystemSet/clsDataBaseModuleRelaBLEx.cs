using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.DAL;

namespace AGC.BusinessLogicEx
{
    public class clsDataBaseModuleRelaBLEx : clsDataBaseModuleRelaBL
    {
        public static bool SetVisibility(long lngMid, bool bolIsvisible, string strOptUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            clsDataBaseModuleRelaEN objDataBaseModuleRelaEN = clsDataBaseModuleRelaBL.GetObjBymId(lngMid);

         
            objDataBaseModuleRelaEN.IsVisible = bolIsvisible;
            objDataBaseModuleRelaEN.UpdUserId = strOptUserId;
            objDataBaseModuleRelaEN.UpdDate = strCurrDate;

            return clsDataBaseModuleRelaBL.UpdateBySql2(objDataBaseModuleRelaEN);
        }
        public static bool SetDefaDataBaseModuleRela(string strPrjId, string strPrjDataBaseId, string strOptUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strCondition = string.Format("PrjId='{0}'", strPrjId);
            IEnumerable<clsFuncModule_AgcEN> arrFuncModuleLst = clsFuncModule_AgcBL.GetObjLstCache(strPrjId)
                .Where(x=>x.PrjId == strPrjId);
            foreach (clsFuncModule_AgcEN objFuncModuleEN in arrFuncModuleLst)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("PrjId='{0}'", strPrjId);
                sbCondition.AppendFormat(" And PrjDataBaseId='{0}'", strPrjDataBaseId);
                sbCondition.AppendFormat(" And FuncModuleAgcId='{0}'", objFuncModuleEN.FuncModuleAgcId);
                List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel =  clsDataBaseModuleRelaBLEx.GetAllDataBaseModuleRelaObjLstByFuncModuleIdCacheEx(strPrjDataBaseId, strPrjId, objFuncModuleEN.FuncModuleAgcId);
                if (arrDataBaseModuleRelaObjLst_Sel.Count == 0)
                {
                    clsDataBaseModuleRelaEN objDataBaseModuleRelaEN = new clsDataBaseModuleRelaEN();
                    objDataBaseModuleRelaEN.PrjId = strPrjId;
                    objDataBaseModuleRelaEN.PrjDataBaseId = strPrjDataBaseId;
                    objDataBaseModuleRelaEN.FuncModuleAgcId = objFuncModuleEN.FuncModuleAgcId;
                    objDataBaseModuleRelaEN.IsVisible = true;
                    objDataBaseModuleRelaEN.UpdUserId = strOptUserId;
                    objDataBaseModuleRelaEN.UpdDate = strCurrDate;
                    objDataBaseModuleRelaEN.Memo = "通过默认设置";
                    clsDataBaseModuleRelaBL.AddNewRecordBySql2(objDataBaseModuleRelaEN);
                }
            }
            return true;
        }

        /// <summary>
        /// 设置默认的数据库模块关系
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strOptUserId">操作用户Id</param>
        /// <returns>是否成功？</returns>
        public static int SetDefaDataBaseModuleRela(string strPrjId, string strOptUserId)
        {
            int intRecCount = 0;
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strCondition = string.Format("PrjId='{0}'", strPrjId);
            List<clsFuncModule_AgcEN> arrFuncModuleLst = clsFuncModule_AgcBLEx.GetObjLst(strCondition);
            List<clsProjectDatabaseRelEN> arrProjectDatabaseRelObjLst = clsProjectDatabaseRelBL.GetObjLst(strCondition);
            foreach (clsProjectDatabaseRelEN objProjectDatabaseRelEN in arrProjectDatabaseRelObjLst)
            {
                foreach (clsFuncModule_AgcEN objFuncModuleEN in arrFuncModuleLst)
                {
                    StringBuilder sbCondition = new StringBuilder();
                    sbCondition.AppendFormat("PrjId='{0}'", strPrjId);
                    sbCondition.AppendFormat(" And PrjDataBaseId='{0}'", objProjectDatabaseRelEN.PrjDataBaseId);
                    sbCondition.AppendFormat(" And FuncModuleAgcId='{0}'", objFuncModuleEN.FuncModuleAgcId);
                    if (clsDataBaseModuleRelaBL.IsExistRecord(sbCondition.ToString()) == false)
                    {
                        clsDataBaseModuleRelaEN objDataBaseModuleRelaEN = new clsDataBaseModuleRelaEN();
                        objDataBaseModuleRelaEN.PrjId = strPrjId;
                        objDataBaseModuleRelaEN.PrjDataBaseId = objProjectDatabaseRelEN.PrjDataBaseId;
                        objDataBaseModuleRelaEN.FuncModuleAgcId = objFuncModuleEN.FuncModuleAgcId;
                        objDataBaseModuleRelaEN.IsVisible = true;
                        objDataBaseModuleRelaEN.UpdUserId = strOptUserId;
                        objDataBaseModuleRelaEN.UpdDate = strCurrDate;
                        objDataBaseModuleRelaEN.Memo = "通过默认设置";
                        clsDataBaseModuleRelaBL.AddNewRecordBySql2(objDataBaseModuleRelaEN);
                        intRecCount++;
                    }
                }
            }
            return intRecCount;
        }
        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>  
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>从缓存中获取满足条件所有【系统缺省值名称】对象列表</returns>
        public static List<clsDataBaseModuleRelaEN> GetAllDataBaseModuleRelaObjLstCacheEx(string strPrjDataBaseId, string strPrjId)
        {
            //InitListCache();

            //List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst = new List<clsDataBaseModuleRelaEN>();
            List<clsDataBaseModuleRelaEN> arrObjLstCache = clsDataBaseModuleRelaBL.GetObjLstCache();

            IEnumerable<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel1 =
                from objDataBaseModuleRelaEN in arrObjLstCache
                where objDataBaseModuleRelaEN.PrjDataBaseId == strPrjDataBaseId
                && objDataBaseModuleRelaEN.PrjId == strPrjId
                select objDataBaseModuleRelaEN;


            List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel = new List<clsDataBaseModuleRelaEN>();
            foreach (clsDataBaseModuleRelaEN obj in arrDataBaseModuleRelaObjLst_Sel1)
            {
                arrDataBaseModuleRelaObjLst_Sel.Add(obj);
            }

            return arrDataBaseModuleRelaObjLst_Sel;
        }

        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>  
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strFuncModuleAgcId">工程数据库Id</param>
        /// <returns>从缓存中获取满足条件所有【系统缺省值名称】对象列表</returns>
        public static List<clsDataBaseModuleRelaEN> GetAllDataBaseModuleRelaObjLstByFuncModuleIdCacheEx(string strPrjDataBaseId, 
            string strPrjId, string strFuncModuleAgcId)
        {
            //InitListCache();

            //List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst = new List<clsDataBaseModuleRelaEN>();
            List<clsDataBaseModuleRelaEN> arrObjLstCache = clsDataBaseModuleRelaBL.GetObjLstCache();

            IEnumerable<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel1 =
                from objDataBaseModuleRelaEN in arrObjLstCache
                where objDataBaseModuleRelaEN.PrjDataBaseId == strPrjDataBaseId
                && objDataBaseModuleRelaEN.PrjId == strPrjId
                && objDataBaseModuleRelaEN.FuncModuleAgcId == strFuncModuleAgcId

                select objDataBaseModuleRelaEN;


            List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel = new List<clsDataBaseModuleRelaEN>();
            foreach (clsDataBaseModuleRelaEN obj in arrDataBaseModuleRelaObjLst_Sel1)
            {
                arrDataBaseModuleRelaObjLst_Sel.Add(obj);
            }

            return arrDataBaseModuleRelaObjLst_Sel;
        }

       
        /// <summary>
        /// 从缓存中获取满足条件所有【模块Id(FuncModuleAgcId)】列表.
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>  
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>从缓存中获取满足条件所有【模块Id(FuncModuleAgcId)】列表</returns>
        public static List<string> GetAllFuncModuleAgcIdLstCacheEx(string strPrjDataBaseId, string strPrjId)
        {
            //InitListCache();
       
            //List<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst = new List<clsDataBaseModuleRelaEN>();
            List<clsDataBaseModuleRelaEN> arrObjLstCache = clsDataBaseModuleRelaBL.GetObjLstCache();

            IEnumerable<clsDataBaseModuleRelaEN> arrDataBaseModuleRelaObjLst_Sel1 =
                from objDataBaseModuleRelaEN in arrObjLstCache
                where objDataBaseModuleRelaEN.PrjDataBaseId == strPrjDataBaseId
                && objDataBaseModuleRelaEN.PrjId == strPrjId
                && objDataBaseModuleRelaEN.IsVisible == true
                select objDataBaseModuleRelaEN;


            List<string> arrFuncModuleAgcIdLst_Sel = new List<string>();
            foreach (clsDataBaseModuleRelaEN obj in arrDataBaseModuleRelaObjLst_Sel1)
            {
                arrFuncModuleAgcIdLst_Sel.Add(obj.FuncModuleAgcId);
            }

            return arrFuncModuleAgcIdLst_Sel;
        }

    }
}
