using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using com.taishsoft.commexception;
using AGC.BusinessLogic;
using com.taishsoft.common;
using AGC.DAL;
using com.taishsoft.datetime;
using com.taishsoft.commdb;
using System.Collections;
using AGC.PureClassEx;
using System.Drawing;

namespace AGC.BusinessLogicEx
{


    public static class clsExcelExportRegionFldsBLEx_Static
    {

        /// <summary>
        /// 是否是表字段
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static bool IsTabField(this clsExcelExportRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            return true;
        }


        //public static string TabId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
        //{
        //    try
        //    {
        //        clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objExcelExportRegionFldsEN.RegionId, objExcelExportRegionFldsEN.CmPrjId);
        //        if (objViewRegion == null) return null;
        //        return objViewRegion.TabId;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        //public static string DnPathId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
        //{
        //    try
        //    {
        //        string strTabId = objExcelExportRegionFldsEN.TabId();
        //        if (strTabId == null) return null;
        //        string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(objExcelExportRegionFldsEN.CmPrjId);
        //        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objExcelExportRegionFldsEN.OutFldId, strPrjId);
        //        if (objPrjTabFld == null) return null;
        //        return objPrjTabFld.DnPathId;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        //public static bool IsUseFunc(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(objExcelExportRegionFldsEN.OutFldId)) return false;
        //        else return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
        //public static string DataPropertyName(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
        //{
        //    try
        //    {
        //        string strTabId = objExcelExportRegionFldsEN.TabId();
        //        if (strTabId == null) return null;
        //        string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(objExcelExportRegionFldsEN.CmPrjId);
        //        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objExcelExportRegionFldsEN.OutFldId, strPrjId);
        //        if (objPrjTabFld == null) return null;
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, strPrjId);
        //        if (objFieldTab == null) return null;
        //        return objFieldTab.FldName;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}


        //public static clsViewRegionEN ObjViewRegion(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
        //{
        //    try
        //    {
        //        clsViewRegionEN objViewRegion = clsViewRegionBLEx.GetObjByRegionIdCache(objExcelExportRegionFldsEN.RegionId, objExcelExportRegionFldsEN.PrjId);
        //        return objViewRegion;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)根据列表字段获取区域象出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objExcelExportRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsExcelExportRegionFldsENEx objExcelExportRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objExcelExportRegionFldsEN.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objExcelExportRegionFldsEN.FldName);
            }
        }

        ///// <summary>
        ///// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        ///// </summary>
        ///// <param name="objExcelExportRegionFldsEN"></param>
        ///// <returns></returns>
        //public static string DataPropertyName_FstLcase(this clsExcelExportRegionFldsENEx objExcelExportRegionFldsEN)
        //{
        //    if (bolIsFstLcase == false)
        //    {
        //        return objExcelExportRegionFldsEN.DataPropertyName(bolIsFstLcase);
        //    }
        //    else
        //    {
        //        return clsString.FstLcaseS(objExcelExportRegionFldsEN.DataPropertyName(bolIsFstLcase));
        //    }
        //}

        //public static clsFieldTabEN ObjFieldTab1(this clsExcelExportRegionFldsENEx objExcelExportRegionFlds)
        //{
        //    var objPrjTabFld = clsFieldTabBL.GetObjByFldIdCache(objExcelExportRegionFlds.FldId, objExcelExportRegionFlds.PrjId);
        //    return objPrjTabFld;
        //}
       
    }

    public partial class clsExcelExportRegionFldsBLEx : clsExcelExportRegionFldsBL
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
        //    if (clsExcelExportRegionFldsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsExcelExportRegionFldsBL没有刷新缓存机制(clsExcelExportRegionFldsBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", 
        //            clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrExcelExportRegionFldsObjLstCache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by mId");
        //    if (arrExcelExportRegionFldsObjLstCache == null)
        //    {              
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by {4}",
        //               clsExcelExportRegionFldsEN.con_RegionId, clsvViewRegionEN._CurrTabName, clsvViewRegionEN.con_PrjId, strPrjId,
        //               clsExcelExportRegionFldsEN.con_SeqNum);

        //        arrExcelExportRegionFldsObjLstCache = new clsExcelExportRegionFldsDA().GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({4}->{3}->{2})",
        //          strPrjId, strPrjIdCache_Init,
        //          clsStackTrace.GetCurrClassFunction(),
        //          clsStackTrace.GetCurrClassFunctionByLevel(2),
        //          clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <param name = "strPrjId"></param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsExcelExportRegionFldsEN> GetObjLstByRegionIdCache4InUseEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsExcelExportRegionFldsEN> arrObjLstCache = clsExcelExportRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
     arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
     .OrderBy(x => x.SeqNum)
     .ToList();
            return arrExcelExportRegionFldsObjLst_Sel;
        }

        public static List<clsExcelExportRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsExcelExportRegionFldsEN> arrObjLstCache = clsExcelExportRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel1 =
            from objExcelExportRegionFldsEN in arrObjLstCache
            where objExcelExportRegionFldsEN.RegionId == lngRegionId
            orderby objExcelExportRegionFldsEN.SeqNum
            select objExcelExportRegionFldsEN;
            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel = new List<clsExcelExportRegionFldsEN>();
            foreach (clsExcelExportRegionFldsEN obj in arrExcelExportRegionFldsObjLst_Sel1)
            {
                arrExcelExportRegionFldsObjLst_Sel.Add(obj);
            }
            //if (arrExcelExportRegionFldsObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrExcelExportRegionFldsObjLst_Sel;
        }
        public static List<clsExcelExportRegionFldsENEx> GetObjExLstByRegionIdEx1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, clsExcelExportRegionFldsEN.con_InUse);

            List<clsExcelExportRegionFldsENEx> arrObjENExList = new List<clsExcelExportRegionFldsENEx>();
            List<clsExcelExportRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);

            foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrObjList)
            {
                clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
                CopyTo(objExcelExportRegionFldsEN, objExcelExportRegionFldsENEx);
                objExcelExportRegionFldsENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objExcelExportRegionFldsENEx.FldId, objExcelExportRegionFldsENEx.PrjId());
                

                //objExcelExportRegionFldsENEx.objCtlType = clsCtlTypeBLEx.GetObjByCtlTypeIdCache(objExcelExportRegionFldsENEx.CtlTypeId);
                arrObjENExList.Add(objExcelExportRegionFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsExcelExportRegionFldsENEx> GetExcelExportRegionFldsENExObjListBak(string strCondition)
        {

            List<clsExcelExportRegionFldsENEx> arrObjENExList = new List<clsExcelExportRegionFldsENEx>();
            List<clsExcelExportRegionFldsEN> arrObjList = clsExcelExportRegionFldsBL.GetObjLst(strCondition);
            foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrObjList)
            {
                clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
                clsExcelExportRegionFldsBL.CopyTo(objExcelExportRegionFldsEN, objExcelExportRegionFldsENEx);
                arrObjENExList.Add(objExcelExportRegionFldsENEx);
            }
            return arrObjENExList;
        }

        //public static List<clsExcelExportRegionFldsENEx> GetObjExLst(string lngRegionId, string strPrjId)
        //{
        //    //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, clsExcelExportRegionFldsEN.con_InUse);
        //    List<clsExcelExportRegionFldsENEx> arrObjENExList = new List<clsExcelExportRegionFldsENEx>();
        //    List<clsExcelExportRegionFldsEN> arrObjList = GetObjLstByRegionIdCacheEx(lngRegionId, strPrjId);
        //    foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrObjList)
        //    {
        //        clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
        //        clsExcelExportRegionFldsBL.CopyTo(objExcelExportRegionFldsEN, objExcelExportRegionFldsENEx);
        //        arrObjENExList.Add(objExcelExportRegionFldsENEx);
        //    }
        //    return arrObjENExList;
        //}

        public static List<clsExcelExportRegionFldsENEx> GetObjExLst4InUse1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, clsExcelExportRegionFldsEN.con_InUse);
            List<clsExcelExportRegionFldsENEx> arrObjENExList = new List<clsExcelExportRegionFldsENEx>();
            List<clsExcelExportRegionFldsEN> arrObjList = GetObjLstByRegionIdCache4InUseEx1(lngRegionId, strCmPrjId);
            foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN in arrObjList)
            {
                clsExcelExportRegionFldsENEx objExcelExportRegionFldsENEx = new clsExcelExportRegionFldsENEx();
                clsExcelExportRegionFldsBL.CopyTo(objExcelExportRegionFldsEN, objExcelExportRegionFldsENEx);
                arrObjENExList.Add(objExcelExportRegionFldsENEx);
            }
            return arrObjENExList;
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
                foreach (long strMid in arrmIdLst)
                {
                    clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(strMid);
                    objExcelExportRegionFldsEN.InUse = true;
                    objExcelExportRegionFldsEN.UpdUser = strUpdUser;
                    objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN);
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
        public static int SetNotInUse(List<long> arrmIdLst, string strUpdUser)
        {
            try
            {
                int intRecNum = 0;
                foreach (long strMid in arrmIdLst)
                {
                    clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsBL.GetObjBymId(strMid);
                    objExcelExportRegionFldsEN.InUse = false;
                    objExcelExportRegionFldsEN.UpdUser = strUpdUser;
                    objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN);
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

        //    List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsENObjLst = clsExcelExportRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN4Web in arrExcelExportRegionFldsENObjLst)
        //    {

        //        objExcelExportRegionFldsEN4Web.IsSynchToServer = true;
        //        objExcelExportRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objExcelExportRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN4Web2 = new clsExcelExportRegionFldsEN();
        //            clsExcelExportRegionFldsBL.CopyTo(objExcelExportRegionFldsEN4Web, objExcelExportRegionFldsEN4Web2);
        //            objExcelExportRegionFldsEN4Web2.SynSource = "Client";
        //            strCondition = objExcelExportRegionFldsEN4Web.GetUniquenessConditionString();

        //            clsExcelExportRegionFldsEN objExcelExportRegionFlds_Target = clsExcelExportRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objExcelExportRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objExcelExportRegionFlds_Target.UpdDate.CompareTo(objExcelExportRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objExcelExportRegionFldsEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsExcelExportRegionFldsBL.AddNewRecordBySql2(objExcelExportRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objExcelExportRegionFldsEN4Web.RegionId,
        //                        objExcelExportRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


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

        //    List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsENObjLst = clsExcelExportRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsExcelExportRegionFldsEN objExcelExportRegionFldsEN4Main in arrExcelExportRegionFldsENObjLst)
        //    {

        //        objExcelExportRegionFldsEN4Main.IsSynchToClient = true;
        //        objExcelExportRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objExcelExportRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN4Main2 = new clsExcelExportRegionFldsEN();
        //            clsExcelExportRegionFldsBL.CopyTo(objExcelExportRegionFldsEN4Main, objExcelExportRegionFldsEN4Main2);
        //            objExcelExportRegionFldsEN4Main2.SynSource = "Server";
        //            strCondition = objExcelExportRegionFldsEN4Main.GetUniquenessConditionString();

        //            clsExcelExportRegionFldsEN objExcelExportRegionFlds_Target = clsExcelExportRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objExcelExportRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objExcelExportRegionFlds_Target.UpdDate.CompareTo(objExcelExportRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objExcelExportRegionFldsEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsExcelExportRegionFldsBL.AddNewRecordBySql2(objExcelExportRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objExcelExportRegionFldsEN4Main.RegionId,
        //                        objExcelExportRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}
        /// <summary>
        /// 导入该区域相关字段的列表
        /// </summary>
        /// <param name = "lngRegionId"></param>
        /// <param name = "strPrjId"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {
            
            int intRecNum = 0;
            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsPrjTabFldEN> arrRelaTabFldObjList = clsPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                //enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08
            };

            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);

            foreach (clsPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, strPrjId);
                string strFldName = objFieldTab.FldName;
                objExcelExportRegionFldsEN.RegionId = lngRegionId;
                objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objExcelExportRegionFldsEN.UpdUser = strUserId;
                objExcelExportRegionFldsEN.PrjId = strPrjId;

                if (objPrjTabFldEN.IsForExtendClass)
                {
                    if (objPrjTabFldEN.InFldId == null) continue;
                    //if (string.IsNullOrEmpty(objPrjTabFldEN.DnPathId) == true) continue;
                    //var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFldEN.DnPathId, strCmPrjId);
                    //if (objDnPath == null) continue;
                    //var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, strCmPrjId);
                    //if (objInDataNode == null) continue;
                    objExcelExportRegionFldsEN.FldId = objPrjTabFldEN.InFldId;
                    objExcelExportRegionFldsEN.OutFldId = objPrjTabFldEN.FldId;

                    //objExcelExportRegionFldsEN.IsUseFunc = true;
                    objExcelExportRegionFldsEN.ColCaption = objFieldTab.Caption;
                    //objExcelExportRegionFldsEN.DnPathId = objPrjTabFldEN.DnPathId;
                    //objExcelExportRegionFldsEN.DataPropertyName = objFieldTab.FldName;                    
                    //objExcelExportRegionFldsEN.OutDataNodeId = objDnPath.OutDataNodeId;

                }
                else
                {
                    //long lngTabFldId = objExcelExportRegionFldsEN.TabFldId;
                    
                    objExcelExportRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                    
                    objExcelExportRegionFldsEN.ColCaption = objFieldTab.Caption;
                    
                    if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                    {
                        objExcelExportRegionFldsEN.InUse = true;
                    }
                    else
                    {
                        int intLen = strFldName.Length;
                        string strRight2Byte = strFldName.Substring(intLen - 2, 2);

                        if (strRight2Byte.Equals("Id", StringComparison.InvariantCultureIgnoreCase) == true)
                        {
                            objExcelExportRegionFldsEN.InUse = false;
                        }
                        else
                        {
                            objExcelExportRegionFldsEN.InUse = true;
                        }
                    }
          
                }
                //5、检查传进去的对象属性是否合法
                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFldsEN);
                //6、把数据实体层的数据存贮到数据库中
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsExcelExportRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                var strWhere = objExcelExportRegionFldsEN.GetUniCondStr();
                if (clsExcelExportRegionFldsBL.IsExistRecord(strWhere) == false)
                {
                    objExcelExportRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsExcelExportRegionFldsBL.AddNewRecordBySql2(objExcelExportRegionFldsEN) == false)
                    {
                        var objExcelExportRegionFldsENEx = CopyToEx(objExcelExportRegionFldsEN);
                        throw new clsDbObjException("添加DataGrid区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objExcelExportRegionFldsEN.FldId, objExcelExportRegionFldsENEx.PrjId()));

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

        /// <summary>
        /// 导入该区域相关字段的列表
        /// </summary>
        /// <param name = "lngRegionId"></param>
        /// <param name = "strPrjId"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static bool ImportRelaFlds(string lngRegionId, ArrayList arrRelaTabFldObjList, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = new clsExcelExportRegionFldsEN();

            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                objExcelExportRegionFldsEN.FldId = objPrjTabFldEN.FldId;
                objExcelExportRegionFldsEN.RegionId = lngRegionId;
                objExcelExportRegionFldsEN.ColCaption = objPrjTabFldEN.Caption;
                objExcelExportRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objExcelExportRegionFldsEN.UpdUser = strUserId;
                objExcelExportRegionFldsEN.PrjId = strPrjId;

                objExcelExportRegionFldsEN.InUse = true;
                //5、检查传进去的对象属性是否合法

                clsExcelExportRegionFldsBL.CheckPropertyNew(objExcelExportRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中

                string strFldName = clsFieldTabBL.GetObjByFldId(objExcelExportRegionFldsEN.FldId).FldName;

                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsExcelExportRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                if (clsvExcelExportRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objExcelExportRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsExcelExportRegionFldsBL.AddNewRecordBySql2(objExcelExportRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加DataGrid区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objExcelExportRegionFldsEN.FldId, strPrjId));

                    }
                    else
                    {
                    }
                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate4RegionId(lngRegionId);

            return true;

        }
        public static bool CopyTo1(string lngRegionId_S, string lngRegionId_T, string strCmPrjId, string strUpdUser)
        {


            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst = clsExcelExportRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsExcelExportRegionFldsEN objInfor2 in arrExcelExportRegionFldsObjLst)
            {
                clsExcelExportRegionFldsEN objInfor2_T = new clsExcelExportRegionFldsEN();
                clsExcelExportRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUpdUser);
                clsExcelExportRegionFldsBL.AddNewRecordBySql2(objInfor2_T);
            }
            return true;
        }
        public static bool CheckOutFldId(clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx, string strCmPrjId, string strOpUser)
        {
            string strMsg = "";
            string strOutFldId = objExcelExportRegionFldsEx.OutFldId;
            string strPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            
            try
            {
                var objFieldTab_Out = clsFieldTabBL.GetObjByFldIdCache(strOutFldId, strPrjId);

                if (objFieldTab_Out == null)
                {

                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);

                    strMsg = string.Format("检查Out字段时, 输出字段:[{0}]不存在。在 CmPrjId={1}({2})，请检查！(In {3})",
                         strOutFldId, strCmPrjId, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);


                }
                return true;
            }
            catch (Exception objException)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objExcelExportRegionFldsEx.FldId, objExcelExportRegionFldsEx.PrjId());
                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                strMsg = string.Format("检查OutFldId:[{0}({1})], 属性:[{2}])，出错:{3}。 CmPrjId={4}({5})，请检查！(In {6})",
                    strOutFldId, objFieldTab.FldName, objExcelExportRegionFldsEx.DataPropertyName(),
                    objException.Message,
                    strCmPrjId, objCMProject.CmPrjName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        //public static bool CheckOutDataNodeId(clsExcelExportRegionFldsEN objExcelExportRegionFldsEx, string strCmPrjId, string strOpUser)
        //{
        //    string strMsg = "";
        //    long strOutDataNodeId = objExcelExportRegionFldsEx.OutDataNodeId;            
        //    try
        //    {
        //        var objDataNode_Out = clsDataNodeBL.GetObjByDataNodeIdCache(strOutDataNodeId, strCmPrjId);

        //        if (objDataNode_Out == null)
        //        {
        //            var strDataNodeId_New = clsDataNodeBLEx.GetNewDataNodeIdByCmPrjId(strOutDataNodeId, strCmPrjId);
        //            if (string.IsNullOrEmpty(strDataNodeId_New) == true)
        //            {
        //                var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);

        //                var objDataNode = clsDataNodeBL.GetObjByDataNodeId(strOutDataNodeId);

        //                if (objDataNode == null)
        //                {
        //                    strMsg = string.Format("检查Out结点时, 输出结点:[{0}]不存在。在 CmPrjId={1}({2})，请检查！(In {3})",
        //                         strOutDataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                        clsStackTrace.GetCurrClassFunction());
        //                    throw new Exception(strMsg);
        //                }
        //                strMsg = string.Format("转换函数中，属性:[{0}], 输出结点:[{1}]({2}), 不存在。在 VersionNo=1, CmPrjId={3}，请检查！(In {4})",
        //                     objExcelExportRegionFldsEx.DataPropertyName,
        //                    objDataNode.DataNodeName, objDataNode.DataNodeId, strCmPrjId, objCMProject.CmPrjName,
        //                    clsStackTrace.GetCurrClassFunction());
        //                throw new Exception(strMsg);
        //            }
        //            else
        //            {
        //                strOutDataNodeId = strDataNodeId_New;
        //                objExcelExportRegionFldsEx.OutDataNodeId = strDataNodeId_New;
        //                if (objExcelExportRegionFldsEx.DnPathId == "") objExcelExportRegionFldsEx.DnPathId = null;
        //                objExcelExportRegionFldsEx.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //                objExcelExportRegionFldsEx.UpdUser = strOpUser;
        //                clsExcelExportRegionFldsBL.UpdateBySql2(objExcelExportRegionFldsEx);
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception objException)
        //    {
        //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objExcelExportRegionFldsEx.FldId, objExcelExportRegionFldsEx.PrjId());
        //        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
        //        strMsg = string.Format("检查OutDataNodeId:[{0}]时(字段:[{1}({2})], 属性:[{3}])，出错:{4}。 CmPrjId={5}({6})，请检查！(In {7})",
        //            strOutDataNodeId, objFieldTab.FldName,  objExcelExportRegionFldsEx.FldId, objExcelExportRegionFldsEx.DataPropertyName,
        //            objException.Message,
        //            strCmPrjId, objCMProject.CmPrjName,
        //            clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //}

        public static List<clsExcelExportRegionFldsEN> GetObjLstByPrjIdCache(string strPrjId)
        {
            //初始化列表缓存
            List<clsExcelExportRegionFldsEN> arrObjLstCache = clsExcelExportRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsViewRegionEN> arrViewRegion = clsViewRegionBLEx.GetObjLstByPrjIdCache(strPrjId);
            List<string> arrRegionId = arrViewRegion.Select(x => x.RegionId).ToList();
            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel = arrObjLstCache.Where(x => arrRegionId.Contains(x.RegionId) == true && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrExcelExportRegionFldsObjLst_Sel;
        }


        public static bool ImportExtendFld(long lngMid, string strPrjId, string strUserId)
        {
            //JumpOtherPages("CheckConsistency");
            var objExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjExBymIdCache(lngMid, strPrjId);

            if (objExcelExportRegionFlds.IsUseFunc() == false)
            {
                string strMsg = string.Format("当前区域字段:[{0}]没有使用扩展字段功能，不需要导入到表中！(in {1})", lngMid, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            };
                        
            if (string.IsNullOrEmpty(objExcelExportRegionFlds.DataPropertyName()) == true) return false;
            return true;
            //var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objExcelExportRegionFlds.OutDataNodeId, strCmPrjId);
            //if (objDataNode == null) return false;
            //return clsPubRegionFldsBLEx.AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objExcelExportRegionFlds.DataPropertyName, objExcelExportRegionFlds.ColCaption, objExcelExportRegionFlds.DnPathId, strUserId);

        }

        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsExcelExportRegionFldsEN> arrObjLstCache = clsExcelExportRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrExcelExportRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsExcelExportRegionFldsEN> arrObjLstCache = clsExcelExportRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrExcelExportRegionFldsObjLst_Sel.Count;
        }

        /// <summary>
        /// 根据区域Id获取相关列表字段对象列表.
        /// </summary>
        /// <param name = "lngRegionId">区域Id</param>
        /// <returns>根据区域Id获取的对象列表</returns>
        public static List<clsExcelExportRegionFldsEN> GetObjLstByRegionId(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1} ", conExcelExportRegionFlds.RegionId, lngRegionId);
            List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel = clsExcelExportRegionFldsBL.GetObjLst(strCondition);
            return arrExcelExportRegionFldsObjLst_Sel;
        }

        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {
            try
            {
                List<clsExcelExportRegionFldsEN> arrExcelExportRegionFlds = clsExcelExportRegionFldsBLEx.GetObjLstByRegionId(strRegionId);

                foreach (var objInFor in arrExcelExportRegionFlds)
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
        //public static string GetRegionIdByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conExcelExportRegionFlds.DnPathId, strDnPathId);
        //    var objPrjTabFld = GetFirstObj_S(strCondition);
        //    if (objPrjTabFld == null) return "";
        //    return objPrjTabFld.RegionId;
        //}
        //public static clsExcelExportRegionFldsEN GetObjByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conExcelExportRegionFlds.DnPathId, strDnPathId);
        //    var objDetailRegionFlds = GetFirstObj_S(strCondition);
        //    if (objDetailRegionFlds == null) return null;
        //    return objDetailRegionFlds;
        //}
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objExcelExportRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsExcelExportRegionFldsEN:objExcelExportRegionFldsENT</returns>
        public static clsExcelExportRegionFldsENEx CopyToEx(clsExcelExportRegionFldsEN objExcelExportRegionFldsENS)
        {
            try
            {
                clsExcelExportRegionFldsENEx objExcelExportRegionFldsENT = new clsExcelExportRegionFldsENEx();
                clsExcelExportRegionFldsBL.ExcelExportRegionFldsDA.CopyTo(objExcelExportRegionFldsENS, objExcelExportRegionFldsENT);
                return objExcelExportRegionFldsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}
