using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public static class clsQryRegionFldsBLEx_Static
    {
        //public static string PrjId(this clsQryRegionFldsEN objFeatureRegionFldsEN)
        //{
        //    var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objFeatureRegionFldsEN.CmPrjId);
        //    return objCmProject.PrjId;
        //}

        //public static clsFieldTabEN ObjFieldTab1(this clsQryRegionFldsENEx objQryRegionFldsEN)
        //{
        //    try
        //    {
        //        clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objQryRegionFldsEN.FldId, objQryRegionFldsEN.PrjId);
        //        return objFieldTab;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据查询区字段获取字段对象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objQryRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsQryRegionFldsENEx objQryRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objQryRegionFldsEN.ObjFieldTabENEx.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objQryRegionFldsEN.ObjFieldTabENEx.FldName);
            }
        }
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objQryRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName_FstLcase(this clsQryRegionFldsENEx objQryRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objQryRegionFldsEN.PropertyName;
            }
            else
            {
                return clsString.FstLcaseS(objQryRegionFldsEN.PropertyName);
            }
        }

        //public static string PrimaryTypeId(this clsQryRegionFldsENEx objEditRegionFldsEx)
        //{
        //    var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
        //    var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
        //    return objPrjTabFld.PrimaryTypeId;
        //}
        //public static clsPrjTabFldEN ObjPrjTabFld(this clsQryRegionFldsENEx objEditRegionFldsEx)
        //{
        //    var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.CmPrjId).TabId;
        //    var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
        //    return objPrjTabFld;
        //}
        public static string DataPropertyName_Property(this clsQryRegionFldsENEx objQryRegionFldsEx, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objQryRegionFldsEx.DataPropertyName() + "_q";
            }
            else
            {
                return clsString.FstLcaseS(objQryRegionFldsEx.DataPropertyName() + "_q");
            }
        }
        public static bool IsTabForeignKey(this clsQryRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.ObjFieldTabENEx.FldId, objEditRegionFldsEx.PrjId());
            return objPrjTabFld.IsTabForeignKey;
        }
        /// <summary>
        /// 是否是表字段
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static bool IsTabField(this clsQryRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            return true;
        }
    }
    public partial class clsQryRegionFldsBLEx : clsQryRegionFldsBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsQryRegionFldsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsQryRegionFldsBL没有刷新缓存机制(clsQryRegionFldsBL.objCommFun4BL == null), 请联系程序员！({1}->{0})",
        //            clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrQryRegionFldsObjLstCache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by mId");
        //    if (arrQryRegionFldsObjLstCache == null)
        //    {
        //        //string strWhereCond = string.Format("{0} = '{1}' order by SeqNum",
        //        //     clsPrjTabEN.con_PrjId, strPrjId);

        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by {4}",
        //          conQryRegionFlds.RegionId, clsvViewRegionEN._CurrTabName, 
        //          clsvViewRegionEN.con_PrjId, strPrjId,
        //          conQryRegionFlds.SeqNum);

        //        arrQryRegionFldsObjLstCache = new clsQryRegionFldsDA().GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({4}->{3}->{2})",
        //          strPrjId, strPrjIdCache_Init,
        //          clsStackTrace.GetCurrClassFunction(),
        //          clsStackTrace.GetCurrClassFunctionByLevel(2),
        //          clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}

        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsQryRegionFldsEN> arrObjLstCache = clsQryRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrQryRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsQryRegionFldsEN> arrObjLstCache = clsQryRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrQryRegionFldsObjLst_Sel.Count;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsQryRegionFldsEN> GetObjLstByRegionIdCache4InUseEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsQryRegionFldsEN> arrObjLstCache = clsQryRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrQryRegionFldsObjLst_Sel;
        }
        public static List<clsQryRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsQryRegionFldsEN> arrObjLstCache = clsQryRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel =
arrObjLstCache.Where(x => x.RegionId == lngRegionId)
.OrderBy(x => x.SeqNum).ToList();
            return arrQryRegionFldsObjLst_Sel;
        }






        public static List<clsQryRegionFldsENEx> GetQryRegionFldsENExObjList1(string strCondition)
        {

            List<clsQryRegionFldsENEx> arrObjENExList = new List<clsQryRegionFldsENEx>();
            List<clsQryRegionFldsEN> arrObjList = GetObjLst(strCondition);
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrObjList)
            {
                clsQryRegionFldsENEx objQryRegionFldsEx = new clsQryRegionFldsENEx();
                CopyTo(objQryRegionFldsEN, objQryRegionFldsEx);
                arrObjENExList.Add(objQryRegionFldsEx);
            }
            return arrObjENExList;
        }
        /// <summary>
        /// 根据区域Id获取相关
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsQryRegionFldsENEx> GetObjExLstByRegionIdCache4InUse2(string lngRegionId, bool bolIsFstLcase, string strPrjId, string strViewId)
        {
            //string strCondition = string.Format("RegionId = {0} order by SeqNum", lngRegionId);
            List<clsQryRegionFldsENEx> arrObjENExList = new List<clsQryRegionFldsENEx>();
            List<clsQryRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strPrjId);
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrObjList)
            {
                clsQryRegionFldsENEx objQryRegionFldsEx = new clsQryRegionFldsENEx();
                CopyTo(objQryRegionFldsEN, objQryRegionFldsEx);
                if (string.IsNullOrEmpty(objQryRegionFldsEN.TabFeatureId4Ddl) == false)
                {

                    clsTabFeatureENEx4Ddl objTabFeatureENEx4Ddl = clsTabFeatureBLEx.GetObjEx4DdlByTabFeatureId4View(objQryRegionFldsEN.TabFeatureId4Ddl, strPrjId, bolIsFstLcase, strViewId);
                    if (objTabFeatureENEx4Ddl != null)
                    {
                        objQryRegionFldsEx.ValueFieldName = objTabFeatureENEx4Ddl.ValueFieldName;
                        objQryRegionFldsEx.TextFieldName = objTabFeatureENEx4Ddl.TextFieldName;

                    }
                }
                arrObjENExList.Add(objQryRegionFldsEx);
            }
            return arrObjENExList;
        }
        public static List<clsGCVariableEN> GetGcVarLst4Cond1(string lngRegionId, string strCmPrjId)
        {

            List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };

            var arrQryRegionFlds = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrQryRegionFldsEx = arrQryRegionFlds.Select(CopyToEx);
            var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrQryRegionFldsEx)
            {
                var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                if (objVar != null)
                {
                    objVar.DataTypeId = objInFor.ObjFieldTab().DataTypeId;
                    objVar.Memo = "查询区条件变量";
                    arrGCVariable.Add(objVar);
                }
            }

            return arrGCVariable;
        }

        public static List<clsGCVariableEN> GetGcVarLst4DdlCond(string lngRegionId, string strCmPrjId)
        {
            List<string> arrCtlType = new List<string>() { enumCtlType.DropDownList_06 };
            var arrQryRegionFlds = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId)
                .Where(x => arrCtlType.Contains(x.CtlTypeId));
            var arrQryRegionFldsEx = arrQryRegionFlds.Select(CopyToEx);
            var arrGCVariable = new List<clsGCVariableEN>();

            foreach (var objInFor in arrQryRegionFldsEx)
            {
                {
                    var objVar_Cond1 =
                        string.IsNullOrEmpty(objInFor.VarIdCond1) ? null :
                        clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond1);
                    if (objVar_Cond1 != null)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond1, objInFor.PrjId());
                        objVar_Cond1.DataTypeId = objField.DataTypeId;
                        objVar_Cond1.Memo = "查询区下拉框条件变量1";
                        arrGCVariable.Add(objVar_Cond1);
                    }
                }
                {
                    var objVar_Cond2 =
                        string.IsNullOrEmpty(objInFor.VarIdCond2) ? null :
                        clsGCVariableBL.GetObjByVarIdCache(objInFor.VarIdCond2);
                    if (objVar_Cond2 != null && string.IsNullOrEmpty(objInFor.FldIdCond2) == false)
                    {
                        var objField = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldIdCond2, objInFor.PrjId());
                        objVar_Cond2.DataTypeId = objField.DataTypeId;
                        objVar_Cond2.Memo = "查询区下拉框条件变量2";
                        arrGCVariable.Add(objVar_Cond2);
                    }
                }
            }

            return arrGCVariable;
        }
        /// <summary>
        /// 根据区域Id获取相关
        /// </summary>
        /// <param name="lngRegionId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsQryRegionFldsENEx> GetObjExLstByRegionIdCacheEx(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} order by SeqNum", lngRegionId);
            List<clsQryRegionFldsENEx> arrObjENExList = new List<clsQryRegionFldsENEx>();
            List<clsQryRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsQryRegionFldsEN objQryRegionFldsEN in arrObjList)
            {
                clsQryRegionFldsENEx objQryRegionFldsEx = new clsQryRegionFldsENEx();
                CopyTo(objQryRegionFldsEN, objQryRegionFldsEx);
                objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, objQryRegionFldsEx.PrjId());

                objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
                arrObjENExList.Add(objQryRegionFldsEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<string> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(long.Parse(strMid));
                    objQryRegionFldsEN.InUse = true;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 功能:设置字段可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置可用的记录数</returns>
        public static int SetInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long lngMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(lngMid);
                    objQryRegionFldsEN.InUse = true;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<string> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (string strMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(long.Parse(strMid));
                    objQryRegionFldsEN.InUse = false;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "arrmIdLst">给定的关键字值列表</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long lngMid in arrmIdLst)
                {
                    clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(lngMid);
                    objQryRegionFldsEN.InUse = false;
                    objQryRegionFldsEN.UpdUser = strUpdUser;
                    objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                    intRecNum++;
                }
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 功能:设置字段不可用，同时设置多条记录。
        /// </summary>
        /// <param name = "lngmId">给定的关键字值</param>
        /// <param name = "strUpdUser">给定的关键字值列表</param>
        /// <returns>返回设置不可用的记录数</returns>
        public static int SetNotInUse(long lngmId, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;

                clsQryRegionFldsEN objQryRegionFldsEN = clsQryRegionFldsBL.GetObjBymId(lngmId);
                objQryRegionFldsEN.InUse = false;
                objQryRegionFldsEN.UpdUser = strUpdUser;
                objQryRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN);
                intRecNum++;
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("设置字段不可用出错,{1}.({0})",
                 clsStackTrace.GetCurrClassFunction(),
                 objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 获取扩展对象列表，同时获取相关表对象属性
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<clsQryRegionFldsENEx> GetObjExLstEx(string strViewId, string strPrjId)
        {
            //获取区域ID
            string lngRegionId = clsViewRegionBLEx.GetRegionIdByTypeCache2(strViewId,
                    enumRegionType.QueryRegion_0001, strPrjId);
            if (string.IsNullOrEmpty(lngRegionId) == true)
            {
                return new List<clsQryRegionFldsENEx>();
            }

            List<clsQryRegionFldsENEx> arrQryRegionFldSet = clsQryRegionFldsBLEx.GetObjExList(lngRegionId, strPrjId);

            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in arrQryRegionFldSet)
            {
                if (string.IsNullOrEmpty(objQryRegionFldsEx.FldId)) continue;
                try
                {
                    objQryRegionFldsEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objQryRegionFldsEx.FldId, strPrjId);
                    if (objQryRegionFldsEx.FldId.Length > 0 && objQryRegionFldsEx.ObjFieldTabENEx == null)
                    {
                        continue;
                    }

                    objQryRegionFldsEx.objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objQryRegionFldsEx.CtlTypeId);
                }
                catch (Exception objEx1)
                {
                    if (objEx1.Message.IndexOf("没有字段Id") > -1) continue;
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("界面Id:{0},获取查询字段扩展信息出错，错误:{1}.(in {2})",
                        strViewId, objEx1.Message,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(sbMsg.ToString());
                }
            }
            return arrQryRegionFldSet;
        }

        public static clsQryRegionFldsENEx GetObjEx(clsQryRegionFldsEN objQryRegionFlds)
        {
            clsQryRegionFldsENEx objQryRegionFldsENEx = new clsQryRegionFldsENEx();
            CopyTo(objQryRegionFlds, objQryRegionFldsENEx);
            return objQryRegionFldsENEx;
        }


        public static List<clsQryRegionFldsENEx> GetObjExList(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("{0}={1} and {2}1='1' order by SeqNum", 
            //    conQryRegionFlds.RegionId, lngRegionId, conQryRegionFlds.InUse);
            List<clsQryRegionFldsENEx> arrObjENExList = new List<clsQryRegionFldsENEx>();
            List<clsQryRegionFldsEN> arrObjList = GetObjLstByRegionIdEx(lngRegionId);
            foreach (clsQryRegionFldsEN objQryRegionENExFldsEN in arrObjList)
            {
                clsQryRegionFldsENEx objQryRegionENExFldsENEx = new clsQryRegionFldsENEx();
                CopyTo(objQryRegionENExFldsEN, objQryRegionENExFldsENEx);
                arrObjENExList.Add(objQryRegionENExFldsENEx);
            }
            return arrObjENExList;
        }

        /// <summary>
        /// 根据区域Id获取相关列表字段对象列表.
        /// </summary>
        /// <param name = "lngRegionId">区域Id</param>
        /// <returns>根据区域Id获取的对象列表</returns>
        public static List<clsQryRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1}", conQryRegionFlds.RegionId, lngRegionId);
            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst_Sel = clsQryRegionFldsBL.GetObjLst(strCondition);
            return arrQryRegionFldsObjLst_Sel;
        }
        /// <summary>
        /// 同步满足条件的DG信息到Server
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strUserId)
        //{
        //    //string strCondition = string.Format("id_CurrEduClass='{0}'", strId_TransferCourses);
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionStringWeb";

        //    List<clsQryRegionFldsEN> arrQryRegionFldsENObjLst = clsQryRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsQryRegionFldsEN objQryRegionFldsEN4Web in arrQryRegionFldsENObjLst)
        //    {

        //        objQryRegionFldsEN4Web.IsSynchToServer = true;
        //        objQryRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objQryRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsQryRegionFldsEN objQryRegionFldsEN4Web2 = new clsQryRegionFldsEN();
        //            clsQryRegionFldsBL.CopyTo(objQryRegionFldsEN4Web, objQryRegionFldsEN4Web2);
        //            objQryRegionFldsEN4Web2.SynSource = "Client";
        //            strCondition = objQryRegionFldsEN4Web.GetUniquenessConditionString();
        //            clsQryRegionFldsEN objQryRegionFlds_Target = clsQryRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objQryRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objQryRegionFlds_Target.UpdDate.CompareTo(objQryRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objQryRegionFldsEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objQryRegionFldsEN4Web.RegionId,
        //                        objQryRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        public static bool CheckRegionFldsUp(string strRegionId, string strViewId, string strCmPrjId, string strOpUserId)
        {
            var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckRegionFlds(strRegionId, strCmPrjId, strOpUserId, strViewId);
            var arrViewId = clsViewRegionRelaBLEx.GetViewIdLstByRegionIdCache(strRegionId, strPrjId_p);
            var arrViewInfo = clsViewInfoBL.GetObjLstByViewIdLstCache(arrViewId, strPrjId_p);
            if (objErrMsg_New.ErrNum == 0)
            {
                foreach (var objInFor in arrViewInfo)
                {
                    if (objInFor.ErrMsg == null) continue;
                    if (objInFor.ErrMsg.Length == 0) continue;
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    if (arrErrMsg == null) continue;
                    if (arrErrMsg.Count == 0) continue;
                    var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType != objErrMsg_New.ErrType).ToList();
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg_Del);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            else
            {

                foreach (var objInFor in arrViewInfo)
                {
                    var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                    clsErrMsgBLEx.AddObj(arrErrMsg, objErrMsg_New);
                    string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                    objInFor.ErrMsg = strErrMsg_New;
                    objInFor.Update();
                }
            }
            return true;
        }
        public static clsErrMsgENEx CheckRegionFlds(string strRegionId, string strCmPrjId, string strOpUserId, string strViewId)
        {
            string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            string strMsg = "";
            int intErrCount = 0;
            var arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);
            var arrQryRegionFldsEx = arrQryRegionFlds.Select(clsQryRegionFldsBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrQryRegionFldsEx)
            {
                if (objInFor.InUse == false) continue;
                try
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true)
                    {
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段Id(FldId)为空！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    if (objInFor.IsTabField() == false)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objInFor.FldId, objInFor.PrjId);
                        strMsg = $"控件:[{objInFor.LabelCaption}]的字段:[{objFieldTab.FldName}({objInFor.FldId})]，不在查询区的相关表中，请检查！({clsStackTrace.GetCurrClassFunctionByLevel(2)})";
                        throw new Exception(strMsg);
                    }
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlType.DropDownList_06:
                            clsPubFun4BLEx.CheckComboBox(objInFor, strViewId, strCmPrjId);
                            if (objInFor.DnPathId() != null)
                            {
                                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
                                clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
                                if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                                {
                                    strMsg = string.Format("控件:[{0}]中，路径出错:[{1}].({2})",
                  objInFor.LabelCaption, objDnPath.ErrMsg,
                clsStackTrace.GetCurrClassFunctionByLevel(2));
                                    throw new Exception(strMsg);
                                }
                                //clsPubFun4BLEx.CheckDnPath_In(objInFor);
                            }


                            break;
                        case enumCtlType.DropDownList_Bool_18:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        case enumCtlType.TextBox_16:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            if (objInFor.DnPathId() != null)
                            {
                                var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objInFor.DnPathId(), objInFor.PrjId);
                                clsDnPathBLEx.CheckDnPath(objDnPath, strOpUserId);
                                if (objDnPath.ErrMsg != null && objDnPath.ErrMsg.Length > 0)
                                {
                                    strMsg = string.Format("控件:[{0}]中，路径出错:[{1}].({2})",
                  objInFor.LabelCaption, objDnPath.ErrMsg,
                clsStackTrace.GetCurrClassFunctionByLevel(2));
                                    throw new Exception(strMsg);
                                }
                                //clsPubFun4BLEx.CheckDnPath_In(objInFor);
                            }


                            break;
                        case enumCtlType.CheckBox_02:
                            //clsPubFun4BLEx.CheckComboBox(objInFor);
                            break;
                        //case enumCtlType.DefaultValue_36:
                        //    clsPubFun4BLEx.CheckSessionStorageVar(objInFor);
                        //    break;

                        case enumCtlType.ViewVariable_38:

                            clsPubFun4BLEx.CheckSessionStorageVar(objInFor);
                            break;

                        default:
                            var objCtlType = clsCtlTypeBL.GetObjByCtlTypeIdCache(objInFor.CtlTypeId);
                            strMsg = string.Format("控件类型:[{0}]({1})没有被处理！(in {2})",
                                      objCtlType.CtlTypeName, objCtlType.CtlTypeId,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                }
                catch (Exception ex)
                {
                    objInFor.ErrMsg = ex.Message;
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length > 0)
                {
                    objInFor.ErrMsg = "";
                    //if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    continue;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    sbErrMsg.AppendLine(ex.Message);
            //}
            //2、获取相关主表ID的字段的对象列表;
            var objErrMsg = new clsErrMsgENEx(conErrType.QryRegion, intErrCount);
            var objViewRegion = clsViewRegionBL.GetObjByRegionId(strRegionId);
            if (objViewRegion != null)
            {
                if (intErrCount > 0)
                {
                    objViewRegion.ErrMsg = objErrMsg.ToString();
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
                else
                {
                    objViewRegion.ErrMsg = "";
                    objViewRegion.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objViewRegion.Update();
                }
            }
            return objErrMsg;

        }

        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            int intRecNum = 0;
            clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            string strTabName = objvViewRegionEN.TabName;
            string strRelaTabId = objvViewRegionEN.TabId;
            //2、获取相关主表ID的字段的对象列表;
            List<clsvPrjTabFldEN> arrRelaTabFldObjList = clsvPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");
            IEnumerable<clsvPrjTabFldENEx> arrObjExLst = clsvPrjTabFldBLEx.GetObjExLstByObjLst(arrRelaTabFldObjList);

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08
            };

            arrObjExLst = arrObjExLst.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);
            int intKeyNum = arrObjExLst.Count(x => x.FieldTypeId == enumFieldType.KeyField_02);
            foreach (clsvPrjTabFldENEx objPrjTabFldEN in arrObjExLst)
            {
                //6、把数据实体层的数据存贮到数据库中
                long lngTabFldId = objPrjTabFldEN.mId;
                //clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjByFldIDCacheEx(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                //clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objPrjTabFldEN.DataTypeId);

                string strFldName = objPrjTabFldEN.FldName;
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsQryRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                if (clsvQryRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == true)
                {
                    continue;
                }

                objQryRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                objQryRegionFldsEN.RegionId = lngRegionId;
                objQryRegionFldsEN.Width = 120;
                objQryRegionFldsEN.ColSpan = 1;
                objQryRegionFldsEN.LabelCaption = objPrjTabFldEN.Caption;
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objQryRegionFldsEN.CtlTypeId = enumCtlType.CheckBox_02;
                        break;
                    default:
                        objQryRegionFldsEN.CtlTypeId = enumCtlType.TextBox_16;
                        break;
                }
                var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();
                //判断该字段是否为相关表中的关键字
                if ((intKeyNum > 1 || objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02)
                    && objvFieldTab4CodeConv != null
                    && objvFieldTab4CodeConv.CodeTab != ""
                    && objvFieldTab4CodeConv.CodeTabCode != ""
                    && objvFieldTab4CodeConv.CodeTabName != "")
                {
                    objQryRegionFldsEN.CtlTypeId = enumCtlType.DropDownList_06;		//下拉框
                    objQryRegionFldsEN.DdlItemsOptionId = enumDDLItemsOption.DataSourceTable_02;	//数据源表
                    string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + strPrjId + "' and TabName = '"
                        + objvFieldTab4CodeConv.CodeTab + "'");
                    if (strDsTabId != "")
                    {
                        objQryRegionFldsEN.DsTabId = strDsTabId;
                        objQryRegionFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objQryRegionFldsEN.DsTabId, strPrjId);

                    }
                    objQryRegionFldsEN.QueryOptionId = enumQueryOption.EqualQuery_01;	//相等查询
                }
                else
                {
                    objQryRegionFldsEN.DdlItemsOptionId = enumDDLItemsOption.Unknown_00;
                    objQryRegionFldsEN.DsTabId = "";
                    objQryRegionFldsEN.TabFeatureId4Ddl = "";

                    if (objDataTypeAbbrEN.CsType == "string")
                    {
                        objQryRegionFldsEN.QueryOptionId = enumQueryOption.FuzzyQuery_02;   //模糊查询
                    }
                    else
                    {
                        objQryRegionFldsEN.QueryOptionId = enumQueryOption.EqualQuery_01;
                    }
                }
                objQryRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objQryRegionFldsEN.UpdUser = strUserId;
                objQryRegionFldsEN.PrjId = strPrjId;

                if (objDataTypeAbbrEN.CsType == "long"
                    || objDataTypeAbbrEN.CsType == "int"
                    || objDataTypeAbbrEN.CsType == "short"
                    )
                {
                    objQryRegionFldsEN.InUse = false;
                }
                else if (objPrjTabFldEN.FldName == "UpdUser")
                {
                    objQryRegionFldsEN.InUse = false;
                }
                else if (objPrjTabFldEN.FldName == "UpdDate")
                {
                    objQryRegionFldsEN.InUse = false;
                }
                else if (objPrjTabFldEN.FldName == "Memo")
                {
                    objQryRegionFldsEN.InUse = false;
                }
                else
                {
                    clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = clsvFieldTab4RootFldBLEx.GetObjByTabNameAndFldNameCache(strPrjId,
                        objPrjTabFldEN.SourceTabName, objPrjTabFldEN.FldName);
                    if (objvFieldTab4RootFldEN == null)
                    {
                        //string strMsg = string.Format("表:{1},字段:{3}的根字段不存在，请生成相关根字段！", 
                        //    clsvFieldTab4RootFldEN.con_TabName, objPrjTabFldEN.TabName,
                        //    clsvFieldTab4RootFldEN.con_FldName, objPrjTabFldEN.FldName);
                        //throw new Exception(strMsg);
                        objQryRegionFldsEN.InUse = true;
                    }
                    else if (objvFieldTab4RootFldEN.TabName == strTabName)
                    {
                        objQryRegionFldsEN.InUse = true;
                    }
                    else if (objvFieldTab4RootFldEN.IsRootFld == true)
                    {
                        objQryRegionFldsEN.InUse = true;
                    }
                    else
                    {
                        objvFieldTab4RootFldEN = clsvFieldTab4RootFldBLEx.GetObjByTabNameAndFldNameCache(strPrjId,
                               objvFieldTab4RootFldEN.RootTabName, objvFieldTab4RootFldEN.FldName);
                        if (objvFieldTab4RootFldEN == null) objQryRegionFldsEN.InUse = true;
                        bool bolIsExist = clsvPrjTabFldBLEx.IsExistFldInObjLst(objvFieldTab4RootFldEN.RootFldName, arrRelaTabFldObjList);
                        if (bolIsExist == true) objQryRegionFldsEN.InUse = false;
                        else objQryRegionFldsEN.InUse = true;
                    }
                    if (objPrjTabFldEN.FldName.StartsWith("_"))
                    {
                        objQryRegionFldsEN.InUse = false;
                    }

                }

                //5、检查传进去的对象属性是否合法

                clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                objQryRegionFldsEN.SeqNum = intRecNum + 1;
                intRecNum++;
                if (clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN) == false)
                {
                    var objQryRegionFldsENEx = CopyToEx(objQryRegionFldsEN);
                    throw new clsDbObjException("添加查询区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objQryRegionFldsEN.FldId, objQryRegionFldsENEx.PrjId()));
                }
                else
                {
                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate4RegionId(lngRegionId);

            return true;

        }

        public static bool ImportRelaFlds(string lngRegionId, ArrayList arrRelaTabFldObjList, string strCmPrjId, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            clsQryRegionFldsEN objQryRegionFldsEN = new clsQryRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                objQryRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                objQryRegionFldsEN.RegionId = lngRegionId;
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objQryRegionFldsEN.CtlTypeId = "02";
                        break;
                    default:
                        objQryRegionFldsEN.CtlTypeId = "16";
                        break;
                }
                var objvFieldTab4CodeConv = objPrjTabFldEN.ObjvFieldTab4CodeConv();

                //判断该字段是否为相关表中的关键字
                if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                    && objvFieldTab4CodeConv != null
                    && objvFieldTab4CodeConv.CodeTab != ""
                    && objvFieldTab4CodeConv.CodeTabCode != ""
                    && objvFieldTab4CodeConv.CodeTabName != "")
                {
                    objQryRegionFldsEN.CtlTypeId = "06";		//下拉框
                    objQryRegionFldsEN.DdlItemsOptionId = "02";	//数据源表
                    string strDsTabId = clsPrjTabBL.GetFirstID_S("PrjId = '" + strPrjId + "' and TabName = '" + objvFieldTab4CodeConv.CodeTab + "'");
                    if (strDsTabId != "")
                    {
                        objQryRegionFldsEN.DsTabId = strDsTabId;
                        objQryRegionFldsEN.TabFeatureId4Ddl = clsTabFeatureBLEx.GetFstFeatureIdByTabId(objQryRegionFldsEN.DsTabId, strPrjId);

                    }
                    objQryRegionFldsEN.QueryOptionId = "01";	//相等查询
                }
                else
                {
                    objQryRegionFldsEN.DdlItemsOptionId = "00";
                    objQryRegionFldsEN.DsTabId = "";
                    objQryRegionFldsEN.TabFeatureId4Ddl = "";

                    objQryRegionFldsEN.QueryOptionId = "02";	//模糊查询
                }
                objQryRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objQryRegionFldsEN.UpdUser = strUserId;
                objQryRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsQryRegionFldsBL.CheckPropertyNew(objQryRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                string strFldName = clsFieldTabBL.GetObjByFldId(objQryRegionFldsEN.FldId).FldName;

                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsQryRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                if (clsvQryRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objQryRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加查询区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objQryRegionFldsEN.FldId, strPrjId));
                    }
                    else
                    {
                    }
                }
            }

            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);

            return true;

        }

        public static bool CopyTo1(string lngRegionId_S, string lngRegionId_T, string strCmPrjId, string strUpdUser)
        {


            List<clsQryRegionFldsEN> arrQryRegionFldsObjLst = clsQryRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsQryRegionFldsEN objInfor2 in arrQryRegionFldsObjLst)
            {
                clsQryRegionFldsEN objInfor2_T = new clsQryRegionFldsEN();
                clsQryRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
            }
            return true;
        }

        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {

            try
            {
                List<clsQryRegionFldsEN> arrQryRegionFlds = clsQryRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);

                foreach (var objInFor in arrQryRegionFlds)
                {
                    try
                    {
                        objInFor
                            .SetPrjId(strPrjId)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .SetUpdUser(strUserId)
                            .Update();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                return true;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        /// <summary>
        /// 同步满足条件的信息到Client
        /// </summary>
        /// <param name="strCondition"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strUserId)
        //{
        //    if (string.IsNullOrEmpty(strUserId) == true)
        //    {
        //        throw new Exception("上传到WEB库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();

        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsQryRegionFldsEN> arrQryRegionFldsENObjLst = clsQryRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsQryRegionFldsEN objQryRegionFldsEN4Main in arrQryRegionFldsENObjLst)
        //    {

        //        objQryRegionFldsEN4Main.IsSynchToClient = true;
        //        objQryRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objQryRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsQryRegionFldsEN objQryRegionFldsEN4Main2 = new clsQryRegionFldsEN();
        //            clsQryRegionFldsBL.CopyTo(objQryRegionFldsEN4Main, objQryRegionFldsEN4Main2);
        //            objQryRegionFldsEN4Main2.SynSource = "Server";
        //            strCondition = objQryRegionFldsEN4Main.GetUniquenessConditionString();

        //            clsQryRegionFldsEN objQryRegionFlds_Target = clsQryRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objQryRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objQryRegionFlds_Target.UpdDate.CompareTo(objQryRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objQryRegionFldsEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsQryRegionFldsBL.AddNewRecordBySql2(objQryRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsQryRegionFldsBL.UpdateBySql2(objQryRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objQryRegionFldsEN4Main.RegionId,
        //                        objQryRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}
        //public static string GetRegionIdByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conQryRegionFlds.DnPathId, strDnPathId);
        //    var objPrjTabFld = GetFirstObj_S(strCondition);
        //    if (objPrjTabFld == null) return "";
        //    return objPrjTabFld.RegionId;
        //}
        //public static clsQryRegionFldsEN GetObjByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conQryRegionFlds.DnPathId, strDnPathId);
        //    var objDetailRegionFlds = GetFirstObj_S(strCondition);
        //    if (objDetailRegionFlds == null) return null;
        //    return objDetailRegionFlds;
        //}
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQryRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsQryRegionFldsEN:objQryRegionFldsENT</returns>
        public static clsQryRegionFldsENEx CopyToEx(clsQryRegionFldsEN objQryRegionFldsENS)
        {
            try
            {
                clsQryRegionFldsENEx objQryRegionFldsENT = new clsQryRegionFldsENEx();
                clsQryRegionFldsBL.QryRegionFldsDA.CopyTo(objQryRegionFldsENS, objQryRegionFldsENT);
                return objQryRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static bool ReplaceField(string strPrjId, string strSourceFldId, string strTargetFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            strSQL = string.Format($"Update QryRegionFlds Set FldId = '{strTargetFldId}' where PrjId = '{strPrjId}' And {conQryRegionFlds.FldId} = '{strSourceFldId}'");
            return objSQL.ExecSql(strSQL);
        }
        public static List<DdlOptionsInfo> GetDdlOptionInfoLstByViewId(string strViewId, string strPrjId)
        {
            var arrQryRegionFldsENEx = GetObjExLstEx(strViewId, strPrjId);
            List<DdlOptionsInfo> arrDdlOptionsInfo = GetDdlOptionInfoLst(arrQryRegionFldsENEx, strViewId);
            return arrDdlOptionsInfo;
        }


        /// <summary>
        /// 根据查询区域字段列表获取下拉框选项信息列表
        /// </summary>
        /// <param name="arrQryRegionFldsENEx">查询区域字段扩展对象列表</param>
        /// <returns>下拉框选项信息列表</returns>
        public static List<DdlOptionsInfo> GetDdlOptionInfoLst(List<clsQryRegionFldsENEx> arrQryRegionFldsENEx, string strViewId)
        {
            List<DdlOptionsInfo> arrDdlOptionsInfo = new List<DdlOptionsInfo>();

            try
            {
                // 1. 筛选出下拉框类型且非布尔类型的字段
                var arrDropDownFields = arrQryRegionFldsENEx
                    .Where(x => x.CtlTypeId == enumCtlType.DropDownList_06
                             && x.InUse == true
                             && x.DdlItemsOptionId != enumDDLItemsOption.TrueAndFalseList_04)
                    .ToList();

                // 2. 对每个下拉框字段生成选项信息
                foreach (var fld in arrDropDownFields)
                {
                    try
                    {
                        var optionInfo = GetOptionsInfoFromDataSource(fld, strViewId);
                        if (optionInfo != null)
                        {
                            arrDdlOptionsInfo.Add(optionInfo);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"处理下拉框字段 {fld.FldId} 时出错: {ex.Message}");
                    }
                }

                // 3. 去重：按 Key 分组，每个 Key 只保留一个
                var uniqueOptions = arrDdlOptionsInfo
                    .GroupBy(x => x.Key)
                    .Select(g => g.First())
                    .ToList();

                return uniqueOptions;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取下拉框选项信息列表出错,{1}.({0})",
                    clsStackTrace.GetCurrClassFunction(),
                    objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 从数据源表和表功能获取选项信息（包含参数信息）
        /// </summary>
        private static DdlOptionsInfo GetOptionsInfoFromDataSource(clsQryRegionFldsENEx objQryRegionFldsENEx, string strViewId)
        {
            try
            {
                string optionKey = "";
                List<DdlOptionParam> parameters = new List<DdlOptionParam>();

                // 5. 获取字段名
                string fldName = objQryRegionFldsENEx.ObjFieldTabENEx?.FldName;
                if (string.IsNullOrEmpty(fldName))
                {
                    return null;
                }
                if (objQryRegionFldsENEx.CtlTypeId == enumCtlType.DropDownList_Bool_18)
                {
                    optionKey = ToCamelCase(fldName) + "_f";

                    var optionInfo0 = new DdlOptionsInfo
                    {
                        Key = optionKey,
                        ControlType = "select4Bool",
                        OptionsKey = optionKey,
                        Parameters = parameters
                    };

                    return optionInfo0;
                }
                // 1. 检查是否有数据源表ID
                string dsTabId = objQryRegionFldsENEx.DsTabId;
                if (string.IsNullOrEmpty(dsTabId))
                {
                    return null;
                }

                // 2. 获取数据源表对象
                var objDsTab = clsPrjTabBL.GetObjByTabIdCache(dsTabId, objQryRegionFldsENEx.PrjId);
                if (objDsTab == null)
                {
                    Console.WriteLine($"找不到数据源表: {dsTabId}");
                    return null;
                }

                // 3. 获取表的功能模块
                var objFuncModule = objDsTab.ObjFuncModule();
                string moduleName = objFuncModule?.FuncModuleEnName ?? "SysPara";

                // 4. WApi 类名 = 数据源表名
                string wApiClass = objDsTab.TabName;

                if (string.IsNullOrEmpty(fldName))
                {
                    return null;
                }
                // 🔥 关键修复：调用 GetDsFieldNames 获取值字段和文本字段
                var (valueFieldName, textFieldName) = GetDsFieldNames(objQryRegionFldsENEx);

                // 6. 默认函数名
                string getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}";
                string strArrayVariableName = "arr" + wApiClass;
                bool isExtendedClass = false;
                
                // 7. 如果有表功能ID
                string tabFeatureId = objQryRegionFldsENEx.TabFeatureId4Ddl;
                if (!string.IsNullOrEmpty(tabFeatureId))
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(tabFeatureId, objQryRegionFldsENEx.PrjId);
                    if (objTabFeature != null && objTabFeature.IsForTypeScript)
                    {
                        isExtendedClass = objTabFeature.IsExtendedClass;
                       
                        // 获取函数名
                        if (string.IsNullOrEmpty(objTabFeature.GetDdlDataFuncName4Ex))
                        {
                            var strConditionFieldName = clsTabFeatureBLEx.GetConditionFieldNameByTabFeatureId(tabFeatureId, objQryRegionFldsENEx.PrjId);

                            if (string.IsNullOrEmpty(strConditionFieldName))
                            {
                                getDdlDataFuncName = $"{wApiClass}_{objTabFeature.GetDdlDataFuncName4Ex}";
                            }
                            else
                            {
                                getDdlDataFuncName = $"{wApiClass}_GetArr{wApiClass}By{strConditionFieldName}";
                            }
                            objTabFeature.GetDdlDataFuncName4Ex = getDdlDataFuncName;
                            objTabFeature.Update();
                        }
                        else
                        {
                            getDdlDataFuncName = objTabFeature.GetDdlDataFuncName4Ex;
                        }
                        // 获取参数（从查询字段的 VarIdCond1, VarIdCond2）
                        parameters = GetFunctionParameters(objQryRegionFldsENEx, objTabFeature, strViewId, objQryRegionFldsENEx.PrjId);
                    }
                }

                // 8. 生成选项键（转为驼峰命名）
                optionKey = ToCamelCase(fldName) + "_q";

                // 9. 构建 DdlOptionsInfo 对象
                var optionInfo = new DdlOptionsInfo
                {
                    FldId = objQryRegionFldsENEx.FldId,
                    Key = optionKey,
                    IsNumberType = objQryRegionFldsENEx.IsNumberType(),
                    ControlType = "select",
                    OptionsKey = optionKey,
                    ValueFieldName = valueFieldName,
                    TextFieldName = textFieldName,
                    WApiClass = wApiClass,
                    ArrayVariableName = strArrayVariableName,
                    ModuleName = moduleName,
                    GetDdlDataFuncName = getDdlDataFuncName,
                    IsExtendedClass = isExtendedClass,
                    WApiPath = isExtendedClass ? "L3ForWApiEx" : "L3ForWApi",
                    WApiFileName = isExtendedClass
                        ? $"cls{wApiClass}ExWApi"
                        : $"cls{wApiClass}WApi",
                    Parameters = parameters
                };

                return optionInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取选项信息失败: {ex.Message}\n{ex.StackTrace}");
                return null;
            }
        }

        /// <summary>
        /// 从查询字段的条件变量获取参数信息
        /// </summary>
        private static List<DdlOptionParam> GetFunctionParameters(clsQryRegionFldsENEx fld, clsTabFeatureEN objTabFeature, string strViewId, string strPrjId)
        {
            var parameters = new List<DdlOptionParam>();

            try
            {
                List<clsViewVariable> arrViewVariable = clsViewIdGCVariableRelaBLEx.GetAllViewVariableObjs(strViewId, strPrjId);

                // 从查询字段的条件变量字段获取参数
                var conditionVarIds = new List<(string VarId, int Order, string FldId)>();

                // 检查 VarIdCond1
                if (!string.IsNullOrEmpty(fld.VarIdCond1))
                {
                    conditionVarIds.Add((fld.VarIdCond1, 1, fld.FldIdCond1));
                }

                // 检查 VarIdCond2
                if (!string.IsNullOrEmpty(fld.VarIdCond2))
                {
                    conditionVarIds.Add((fld.VarIdCond2, 2, fld.FldIdCond2));
                }

                if (conditionVarIds.Count == 0)
                {
                    return parameters;
                }

                // 按顺序处理每个条件变量
                foreach (var (varId, order, fldId) in conditionVarIds.OrderBy(x => x.Order))
                {
                    try
                    {
                        // 从 GCVariable 获取变量对象
                        var objVariable = clsGCVariableBLEx.GetObjByVarIdCache(varId);
                        if (objVariable != null)
                        {
                            // 构建共享变量名：去掉 "str" 前缀，加上 "_Static" 后缀
                            string sharedVarName = arrViewVariable.Find(x=>x.VarId == varId)?.VariableName;
                                                       
                            // 获取字段名（用于生成参数名）
                            string paramName = null;
                            if (!string.IsNullOrEmpty(fldId))
                            {
                                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(fldId, strPrjId);
                                if (objFieldTab != null)
                                {
                                    paramName = ToCamelCase(objFieldTab.FldName);
                                }
                            }

                            // 构建参数信息
                            var param = new DdlOptionParam
                            {
                                ParamName = paramName ?? ToCamelCase(objVariable.VarName),
                                SharedVarName = sharedVarName,
                                FldId = fldId,
                                VarId = varId
                            };

                            parameters.Add(param);

                            //判断当前下拉框数据源表是否为缓存的表，如果是的话，参数中需要再添加一个变量
                            if (string.IsNullOrEmpty(fld.DsTabId)==false)
                            {
                                var objDsTab = clsPrjTabBL.GetObjByTabIdCache(fld.DsTabId, fld.PrjId);
                                if (objDsTab != null && objDsTab.IsHasCacheClassifyFldTS())
                                {
                                    List<CacheClassify4Tab> arrCacheClassify4Tab = clsPrjTabBLEx.GetArrCacheClassify4Tab_TSByTabId(fld.DsTabId, fld.PrjId); 
                                    foreach (var cacheClassify in arrCacheClassify4Tab)
                                    {
                                        string strSharedVarName = arrViewVariable.Find(x => x.VarId == cacheClassify.ParaVarId_TS)?.VariableName;
                                        var cacheParam = new DdlOptionParam
                                        {
                                            ParamName = ToCamelCase(cacheClassify.FldName),
                                            SharedVarName = strSharedVarName,
                                            FldId = cacheClassify.FldId,
                                            VarId = cacheClassify.ParaVarId_TS
                                        };
                                        parameters.Add(cacheParam);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"处理条件变量失败: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取函数参数失败: {ex.Message}\n{ex.StackTrace}");
            }

            return parameters;
        }
        /// <summary>
        /// 🔥 修正：获取数据源的值字段名和文本字段名
        /// 从 QryRegionFlds.TabFeatureId4Ddl → TabFeature → TabFeatureFlds 中获取
        /// </summary>
        private static (string ValueFieldName, string TextFieldName) GetDsFieldNames(clsQryRegionFldsENEx field)
        {
            try
            {
                // 如果是布尔类型的下拉框，返回固定值
                if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                {
                    return ("value", "text");
                }

                if (!IsSelectControl(field))
                {
                    return (null, null);
                }

                // 🔥 核心逻辑：通过 TabFeatureId4Ddl 直接找到 TabFeature
                if (string.IsNullOrEmpty(field.TabFeatureId4Ddl))
                {
                    Console.WriteLine($"  ⚠️ 字段 {field.FldName()} 未配置 TabFeatureId4Ddl");
                    return GetDefaultFieldNames(field);
                }

                // 1. 获取 TabFeature 对象（不需要通过名称查找，直接通过ID获取）
                var tabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(field.TabFeatureId4Ddl, field.PrjId);
                if (tabFeature == null)
                {
                    Console.WriteLine($"  ⚠️ 未找到 TabFeatureId: {field.TabFeatureId4Ddl}");
                    return GetDefaultFieldNames(field);
                }

                // 2. 获取该 TabFeature 的字段配置
                var arrTabFeatureFlds = clsTabFeatureFldsBL.GetObjLstCache(field.PrjId)
                    .Where(x => x.TabFeatureId == field.TabFeatureId4Ddl)
                    .ToList();

                if (arrTabFeatureFlds == null || arrTabFeatureFlds.Count == 0)
                {
                    Console.WriteLine($"  ⚠️ TabFeature {tabFeature.TabFeatureName} 未配置字段");
                    return GetDefaultFieldNames(field);
                }

                // 3. 查找值字段（KeyField_01）和文本字段（TextField_02）
                var valueFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.KeyField_02);
                var textFieldConfig = arrTabFeatureFlds.FirstOrDefault(x => x.FieldTypeId == enumFieldType.NameField_03);

                if (valueFieldConfig == null || textFieldConfig == null)
                {
                    Console.WriteLine($"  ⚠️ TabFeatureFlds 中未找到值字段或文本字段配置");
                    Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName}");
                    Console.WriteLine($"     TabFeatureFlds 数量: {arrTabFeatureFlds.Count}");
                    Console.WriteLine($"     valueFieldConfig: {valueFieldConfig != null}");
                    Console.WriteLine($"     textFieldConfig: {textFieldConfig != null}");
                    return GetDefaultFieldNames(field);
                }

                // 4. 获取字段对象
                var valueFieldObj = clsFieldTabBL.GetObjByFldIdCache(valueFieldConfig.FldId, field.PrjId);
                var textFieldObj = clsFieldTabBL.GetObjByFldIdCache(textFieldConfig.FldId, field.PrjId);

                if (valueFieldObj == null || textFieldObj == null)
                {
                    Console.WriteLine($"  ⚠️ 字段对象获取失败");
                    Console.WriteLine($"     valueFieldObj: {valueFieldObj != null} (FldId: {valueFieldConfig.FldId})");
                    Console.WriteLine($"     textFieldObj: {textFieldObj != null} (FldId: {textFieldConfig.FldId})");
                    return GetDefaultFieldNames(field);
                }

                // 5. 转换为 camelCase
                string valueFieldName = ToCamelCase(valueFieldObj.FldName);
                string textFieldName = ToCamelCase(textFieldObj.FldName);

                Console.WriteLine($"  ✅ 下拉框字段: {field.FldName()}");
                Console.WriteLine($"     TabFeature: {tabFeature.TabFeatureName} (ID: {field.TabFeatureId4Ddl})");
                Console.WriteLine($"     数据源表: {field.DsTabId}");
                Console.WriteLine($"     值字段: {valueFieldName} (来源: {valueFieldObj.FldName})");
                Console.WriteLine($"     文本字段: {textFieldName} (来源: {textFieldObj.FldName})");

                return (valueFieldName, textFieldName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  ❌ 获取数据源字段名失败: {ex.Message}");
                Console.WriteLine($"  堆栈跟踪: {ex.StackTrace}");
                return GetDefaultFieldNames(field);
            }
        }
        /// <summary>
        /// 🔥 新增：获取默认字段名（回退方案）
        /// 例如：FunctionTemplate → functionTemplateId / functionTemplateName
        /// </summary>
        private static (string ValueFieldName, string TextFieldName) GetDefaultFieldNames(clsQryRegionFldsENEx field)
        {
            var wApiClass = GetOptionsWApiClass(field);
            if (!string.IsNullOrEmpty(wApiClass))
            {
                string defaultValueField = ToCamelCase(wApiClass) + "Id";
                string defaultTextField = ToCamelCase(wApiClass) + "Name";

                Console.WriteLine($"  ⚠️ 使用默认命名: {field.FldName()} → {defaultValueField} / {defaultTextField}");

                return (defaultValueField, defaultTextField);
            }

            return (null, null);
        }

        /// <summary>
        /// 🔥 修改：获取选项数据源的 WApi 类名
        /// 需要与 Ai3Query 中的逻辑一致，基于数据源表名
        /// </summary>
        private static  string GetOptionsWApiClass(clsQryRegionFldsENEx field)
        {
            if (!IsSelectControl(field)) return null;
            if (field.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) return null;
            try
            {
                // 🔥 如果有数据源表ID，使用表名作为 WApi 类名
                if (!string.IsNullOrEmpty(field.DsTabId))
                {
                    var objDsTab = clsPrjTabBL.GetObjByTabIdCache(field.DsTabId, field.PrjId);
                    if (objDsTab != null)
                    {
                        return objDsTab.TabName;  // 返回表名，如 FunctionTemplate, RegionType
                    }
                }

                // 🔥 回退逻辑：从字段名推断
                string fieldName = field.FldName();
                if (fieldName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
                {
                    fieldName = fieldName.Substring(0, fieldName.Length - 2);
                }
                return char.ToUpper(fieldName[0]) + fieldName.Substring(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取 WApi 类名失败: {ex.Message}");
                return null;
            }
        }
        /// <summary>
        /// 判断查询字段是否为下拉框控件
        /// </summary>
        private static bool IsSelectControl(clsQryRegionFldsENEx field)
        {
            if (field == null) return false;

            string ctlTypeName = field.CtlTypeENName?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(ctlTypeName)) return false;

            ctlTypeName = ctlTypeName.ToLowerInvariant();

            return ctlTypeName == "select"
                || ctlTypeName == "ddl"
                || ctlTypeName == "dropdownlist"
                || ctlTypeName == "combobox"
                || ctlTypeName == "combo";
        }
        /// <summary>
        /// 将字符串转换为驼峰命名（首字母小写）
        /// </summary>
        private static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            // 首字母转小写
            return char.ToLower(str[0]) + str.Substring(1);
        }
    }
}
