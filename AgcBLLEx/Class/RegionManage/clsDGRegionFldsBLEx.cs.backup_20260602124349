using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using com.taishsoft.commexception;
using AGC.BusinessLogic;
using AGC.DAL;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commdb;
using System.Collections;

namespace AGC.BusinessLogicEx
{

    public static class clsDGRegionFldsBLEx_Static
    {

        /// <summary>
        /// 是否是表字段
        /// </summary>
        /// <param name="objEditRegionFldsEx"></param>
        /// <returns></returns>
        public static bool IsTabField(this clsDGRegionFldsENEx objEditRegionFldsEx)
        {
            var strTabId = clsViewRegionBLEx.GetObjByRegionIdCache(objEditRegionFldsEx.RegionId, objEditRegionFldsEx.PrjId()).TabId;
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, objEditRegionFldsEx.FldId, objEditRegionFldsEx.PrjId());
            if (objPrjTabFld == null) return false;
            return true;
        }


        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objDGRegionFldsEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsDGRegionFldsENEx objDGRegionFldsEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objDGRegionFldsEN.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objDGRegionFldsEN.FldName);
            }
        }


        public static string SortExpression_FstLcase(this clsDGRegionFldsENEx objDGRegionFldsEN, bool bolIsFstLcase)
        {
            if (objDGRegionFldsEN.SortExpression == null) return "";
            if (bolIsFstLcase == false)
            {
                return objDGRegionFldsEN.SortExpression;
            }
            else
            {
                return clsString.FstLcaseS(objDGRegionFldsEN.SortExpression);
            }
        }



    }

    public partial class clsDGRegionFldsBLEx : clsDGRegionFldsBL
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
        //    if (clsDGRegionFldsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsDGRegionFldsBL没有刷新缓存机制(clsDGRegionFldsBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrDGRegionFldsObjLstCache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by mId");
        //    if (arrDGRegionFldsObjLstCache == null)
        //    {            
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by {4}",
        //             conDGRegionFlds.RegionId, clsvViewRegionEN._CurrTabName, clsvViewRegionEN.con_PrjId, strPrjId,
        //             conDGRegionFlds.SeqNum);

        //        arrDGRegionFldsObjLstCache = new clsDGRegionFldsDA().GetObjLst(strWhereCond);
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
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsDGRegionFldsEN> GetObjLstByRegionIdCache4InUseEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                .OrderBy(x => x.SeqNum)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }

        public static List<clsDGRegionFldsEN> GetObjLstByRegionIdCacheEx1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);

            IEnumerable<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel1 =
            from objDGRegionFldsEN in arrObjLstCache
            where objDGRegionFldsEN.RegionId == lngRegionId
            select objDGRegionFldsEN;
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = new List<clsDGRegionFldsEN>();
            foreach (clsDGRegionFldsEN obj in arrDGRegionFldsObjLst_Sel1)
            {
                arrDGRegionFldsObjLst_Sel.Add(obj);
            }
            return arrDGRegionFldsObjLst_Sel;
        }
        /// <summary>
        /// 根据区域Id获取相关列表字段对象列表.
        /// </summary>
        /// <param name = "lngRegionId">区域Id</param>
        /// <returns>根据区域Id获取的对象列表</returns>
        public static List<clsDGRegionFldsEN> GetObjLstByRegionIdEx(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1} order by {2}",
                conDGRegionFlds.RegionId, lngRegionId, conDGRegionFlds.SeqNum);
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = clsDGRegionFldsBL.GetObjLst(strCondition);
            return arrDGRegionFldsObjLst_Sel;
        }

        public static List<clsDGRegionFldsEN> GetObjLstByRegionId4InUseExBak(string lngRegionId)
        {
            //初始化列表缓存
            string strCondition = string.Format("{0}={1} And {2}='1' order by {3}",
                conDGRegionFlds.RegionId, lngRegionId, conDGRegionFlds.InUse, conDGRegionFlds.SeqNum);
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = clsDGRegionFldsBL.GetObjLst(strCondition);
            return arrDGRegionFldsObjLst_Sel;
        }
        public static List<clsDGRegionFldsEN> GetObjLstByRegionId4InUseExCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存   
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel = arrDGRegionFldsObjLstCache
                .Where(x => x.InUse == true && x.RegionId == lngRegionId)
                .ToList();
            return arrDGRegionFldsObjLst_Sel;
        }
        public static List<clsDGRegionFldsENEx> GetDGRegionFldsENExObjListBak(string strCondition)
        {

            List<clsDGRegionFldsENEx> arrObjENExList = new List<clsDGRegionFldsENEx>();
            List<clsDGRegionFldsEN> arrObjList = GetObjLst(strCondition);
            foreach (clsDGRegionFldsEN objDGRegionENExFldsEN in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionENExFldsENEx = new clsDGRegionFldsENEx();
                CopyTo(objDGRegionENExFldsEN, objDGRegionENExFldsENEx);
                arrObjENExList.Add(objDGRegionENExFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsDGRegionFldsENEx> GetObjExList(string lngRegionId, string strPrjId)
        {
            //string strCondition = string.Format("{0}={1} and {2}1='1' order by SeqNum", 
            //    conDGRegionFlds.RegionId, lngRegionId, conDGRegionFlds.InUse);
            List<clsDGRegionFldsENEx> arrObjENExList = new List<clsDGRegionFldsENEx>();
            List<clsDGRegionFldsEN> arrObjList = GetObjLstByRegionIdEx(lngRegionId);
            foreach (clsDGRegionFldsEN objDGRegionENExFldsEN in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionENExFldsENEx = new clsDGRegionFldsENEx();
                CopyTo(objDGRegionENExFldsEN, objDGRegionENExFldsENEx);
                arrObjENExList.Add(objDGRegionENExFldsENEx);
            }
            return arrObjENExList;
        }
        public static List<clsDGRegionFldsENEx> GetObjExList4InUse1(string lngRegionId, string strCmPrjId)
        {
            //string strCondition = string.Format("{0}={1} and {2}1='1' order by SeqNum", 
            //    conDGRegionFlds.RegionId, lngRegionId, conDGRegionFlds.InUse);
            List<clsDGRegionFldsENEx> arrObjENExList = new List<clsDGRegionFldsENEx>();
            List<clsDGRegionFldsEN> arrObjList = GetObjLstByRegionId4InUseExCache1(lngRegionId, strCmPrjId);
            foreach (clsDGRegionFldsEN objDGRegionENExFldsEN in arrObjList)
            {
                clsDGRegionFldsENEx objDGRegionENExFldsENEx = new clsDGRegionFldsENEx();
                CopyTo(objDGRegionENExFldsEN, objDGRegionENExFldsENEx);
                arrObjENExList.Add(objDGRegionENExFldsENEx);
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
                    clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(strMid);
                    objDGRegionFldsEN.InUse = true;
                    objDGRegionFldsEN.UpdUser = strUpdUser;
                    objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN);
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
                    clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsBL.GetObjBymId(strMid);
                    objDGRegionFldsEN.InUse = false;
                    objDGRegionFldsEN.UpdUser = strUpdUser;
                    objDGRegionFldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN);
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

        //    List<clsDGRegionFldsEN> arrDGRegionFldsENObjLst = clsDGRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsDGRegionFldsEN objDGRegionFldsEN4Web in arrDGRegionFldsENObjLst)
        //    {

        //        objDGRegionFldsEN4Web.IsSynchToServer = true;
        //        objDGRegionFldsEN4Web.SynchToServerDate = strCurrDate14;
        //        objDGRegionFldsEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsDGRegionFldsEN objDGRegionFldsEN4Web2 = new clsDGRegionFldsEN();
        //            clsDGRegionFldsBL.CopyTo(objDGRegionFldsEN4Web, objDGRegionFldsEN4Web2);
        //            objDGRegionFldsEN4Web2.SynSource = "Client";
        //            strCondition = objDGRegionFldsEN4Web.GetUniquenessConditionString();

        //            clsDGRegionFldsEN objDGRegionFlds_Target = clsDGRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objDGRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDGRegionFlds_Target.UpdDate.CompareTo(objDGRegionFldsEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objDGRegionFldsEN4Web2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFldsEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDGRegionFldsEN4Web.RegionId,
        //                        objDGRegionFldsEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
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

        //    List<clsDGRegionFldsEN> arrDGRegionFldsENObjLst = clsDGRegionFldsBL.GetObjLst(strCondition);

        //    foreach (clsDGRegionFldsEN objDGRegionFldsEN4Main in arrDGRegionFldsENObjLst)
        //    {

        //        objDGRegionFldsEN4Main.IsSynchToClient = true;
        //        objDGRegionFldsEN4Main.SynchToClientDate = strCurrDate14;
        //        objDGRegionFldsEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsDGRegionFldsEN objDGRegionFldsEN4Main2 = new clsDGRegionFldsEN();
        //            clsDGRegionFldsBL.CopyTo(objDGRegionFldsEN4Main, objDGRegionFldsEN4Main2);
        //            objDGRegionFldsEN4Main2.SynSource = "Server";
        //            strCondition = objDGRegionFldsEN4Main.GetUniquenessConditionString();

        //            clsDGRegionFldsEN objDGRegionFlds_Target = clsDGRegionFldsBL.GetFirstObj_S(strCondition);

        //            if (objDGRegionFlds_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDGRegionFlds_Target.UpdDate.CompareTo(objDGRegionFldsEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {
        //                    objDGRegionFldsEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFldsEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsDGRegionFldsBL.UpdateBySql2(objDGRegionFldsEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDGRegionFldsEN4Main.RegionId,
        //                        objDGRegionFldsEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {

            int intRecNum = 0;
            //1、获取当前区域ID的相关主表ID；
            if (lngRegionId == "0" || lngRegionId == "")
            {
                throw new Exception(string.Format("传入的区域Id为空！(in {0})", clsStackTrace.GetCurrClassFunction()));
            }
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //获取当前区域所在界面的界面类型码对象,以便决定DG区域的相关属性
            //string strViewId = clsViewRegionBL.GetObjByRegionId(lngRegionId).ViewId;
            //int strViewTypeCode = clsViewInfoBL.GetObjByViewId(strViewId).ViewTypeCode;
            //clsViewTypeCodeTabEN objViewTypeCode = clsViewTypeCodeTabBL.GetObjByViewTypeCode(strViewTypeCode);

            clsDGRegionFldsEN objDGRegionFlds = new clsDGRegionFldsEN();

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

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, strPrjId);
                string strFldName = objFieldTab.FldName;
                objDGRegionFlds.RegionId = lngRegionId;
                objDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
                objDGRegionFlds.UpdUser = strUserId;
                objDGRegionFlds.PrjId = strPrjId;

                if (objPrjTabFldEN.IsForExtendClass)
                {
                    //if (string.IsNullOrEmpty(objPrjTabFldEN.DnPathId) == true) continue;
                    //var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFldEN.DnPathId, strCmPrjId);                    
                    //if (objDnPath == null) continue;
                    //var objInDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDnPath.InDataNodeId, strCmPrjId);
                    //if (objInDataNode == null) continue;
                    objDGRegionFlds.FldId = objPrjTabFldEN.InFldId;
                    objDGRegionFlds.OutFldId = objPrjTabFldEN.FldId;
                    objDGRegionFlds.SortExpression = strFldName;
                    //objDGRegionFlds.IsUseFunc = true;
                    objDGRegionFlds.HeaderText = objFieldTab.Caption;
                    //objDGRegionFlds.DnPathId = objPrjTabFldEN.DnPathId;
                    //objDGRegionFlds.DataPropertyName = objFieldTab.FldName;
                    //objDGRegionFlds.OutDataNodeId = objDnPath.OutDataNodeId;

                }
                else
                {

                    objDGRegionFlds.FldId = objPrjTabFldEN.FldId;

                    objDGRegionFlds.HeaderText = objFieldTab.Caption;
                    objDGRegionFlds.SortExpression = strFldName;
                    objDGRegionFlds.IsVisible = true;
                    objDGRegionFlds.IsFuncFld = false;
                    objDGRegionFlds.IsNeedSort = true;
                    objDGRegionFlds.DgFuncTypeId = "0001";
                    switch (objFieldTab.DataTypeId)
                    {
                        case enumDataTypeAbbr.bit_03:
                            objDGRegionFlds.CtlTypeId = "02";
                            break;
                        default:
                            objDGRegionFlds.CtlTypeId = "16";
                            break;
                    }


                    if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                    {
                        objDGRegionFlds.InUse = true;
                    }
                    else
                    {
                        int intLen = strFldName.Length;
                        string strRight2Byte = strFldName.Substring(intLen - 2, 2);

                        if (strRight2Byte.Equals("Id", StringComparison.InvariantCultureIgnoreCase) == true)
                        {
                            objDGRegionFlds.InUse = false;
                        }
                        else
                        {
                            objDGRegionFlds.InUse = true;
                        }
                        if (strFldName.StartsWith("_"))
                        {
                            objDGRegionFlds.InUse = false;
                        }
                    }
                }
                //5、检查传进去的对象属性是否合法
                try
                {
                    clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFlds);
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                    //string strSS;
                }
                //6、把数据实体层的数据存贮到数据库中

                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDGRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);
                var strExistCond = objDGRegionFlds.GetUniCondStr();
                if (clsDGRegionFldsBL.IsExistRecord(strExistCond) == false)
                {
                    objDGRegionFlds.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFlds) == false)
                    {
                        var objDGRegionFldsEx = CopyToEx(objDGRegionFlds);
                        throw new clsDbObjException("添加DataGrid区域字段不成功!" + clsFieldTabBL.GetNameByFldIdCache(objDGRegionFlds.FldId, objDGRegionFldsEx.PrjId()));

                    }
                    else
                    {
                    }
                }
            }
            //为添加、修改添加到列表中
            {
                string strCondition = string.Format("{0}={1} and {2}='{3}'",
                    conDGRegionFlds.RegionId, lngRegionId,
                    conDGRegionFlds.HeaderText, "修改");
                if (clsDGRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    AddButtonInDgRegion(lngRegionId, "修改", strPrjId, strUserId);
                }
                strCondition = string.Format("{0}={1} and {2}='{3}'",
                    conDGRegionFlds.RegionId, lngRegionId,
                    conDGRegionFlds.HeaderText, "删除");
                if (clsDGRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    AddButtonInDgRegion(lngRegionId, "删除", strPrjId, strUserId);
                }
                strCondition = string.Format("{0}={1} and {2}='{3}'",
                    conDGRegionFlds.RegionId, lngRegionId,
                    conDGRegionFlds.HeaderText, "详细");
                if (clsDGRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    clsDGRegionFldsEN objDGRegionFlds_Detail = AddButtonInDgRegion(lngRegionId, "详细", strPrjId, strUserId);
                    objDGRegionFlds_Detail.InUse = false;
                    objDGRegionFlds_Detail.Update();
                }
            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);
            return true;

        }
        private static clsDGRegionFldsEN AddButtonInDgRegion(string lngRegionId, string strButtonName, string strPrjId, string strUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            clsDGRegionFldsEN objDGRegionFlds = new clsDGRegionFldsEN();

            //long lngTabFldId = objDGRegionFlds.FldId;

            objDGRegionFlds.RegionId = lngRegionId;
            objDGRegionFlds.HeaderText = strButtonName;
            objDGRegionFlds.IsVisible = true;
            objDGRegionFlds.IsFuncFld = false;
            objDGRegionFlds.IsNeedSort = true;
            objDGRegionFlds.DgFuncTypeId = "0001";

            objDGRegionFlds.CtlTypeId = enumCtlType.Button_01;
            objDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
            objDGRegionFlds.UpdUser = strUserId;
            objDGRegionFlds.PrjId = strPrjId;

            objDGRegionFlds.InUse = true;

            //5、检查传进去的对象属性是否合法

            clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFlds);

            //6、把数据实体层的数据存贮到数据库中

            int intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDGRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);

            objDGRegionFlds.SeqNum = intRecNum + 1;
            intRecNum++;
            string strKey = clsDGRegionFldsBL.AddNewRecordBySql2WithReturnKey(objDGRegionFlds);
            objDGRegionFlds.mId = long.Parse(strKey);

            return objDGRegionFlds;
        }

        public static bool ImportRelaFlds(string lngRegionId, ArrayList arrRelaTabFldObjList, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;

            clsDGRegionFldsEN objDGRegionFlds = new clsDGRegionFldsEN();

            //2、获取相关主表ID的字段的对象列表;
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                //long lngTabFldId = objDGRegionFlds.TabFldId;
                string strFldName = clsFieldTabBL.GetNameByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);

                objDGRegionFlds.FldId = objPrjTabFldEN.FldId;
                objDGRegionFlds.RegionId = lngRegionId;
                objDGRegionFlds.HeaderText = objPrjTabFldEN.Caption;
                objDGRegionFlds.SortExpression = strFldName;

                objDGRegionFlds.IsVisible = true;
                objDGRegionFlds.IsFuncFld = false;
                objDGRegionFlds.IsNeedSort = true;
                objDGRegionFlds.DgFuncTypeId = "0001";
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objDGRegionFlds.CtlTypeId = "02";
                        break;
                    default:
                        objDGRegionFlds.CtlTypeId = "16";
                        break;
                }
                objDGRegionFlds.UpdDate = clsDateTime.getTodayStr(0);
                objDGRegionFlds.UpdUser = strUserId;
                objDGRegionFlds.PrjId = strPrjId;

                int intLen = strFldName.Length;
                string strRight2Byte = strFldName.Substring(intLen - 2, 2);

                if (strRight2Byte.Equals("Id", StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    objDGRegionFlds.InUse = false;
                }
                else
                {
                    objDGRegionFlds.InUse = true;
                }
                //5、检查传进去的对象属性是否合法

                clsDGRegionFldsBL.CheckPropertyNew(objDGRegionFlds);

                //6、把数据实体层的数据存贮到数据库中
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDGRegionFldsEN._CurrTabName, "RegionId = " + lngRegionId);

                if (clsvDGRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objDGRegionFlds.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDGRegionFldsBL.AddNewRecordBySql2(objDGRegionFlds) == false)
                    {
                        var objDGRegionFldsEx = CopyToEx(objDGRegionFlds);
                        throw new clsDbObjException("添加DataGrid区域字段不成功!" + clsFieldTabBL.GetFldNameByFldIdCache(objDGRegionFlds.FldId, objDGRegionFldsEx.PrjId()));

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
            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst = clsDGRegionFldsBLEx.GetObjLstByRegionIdCacheEx1(lngRegionId_S, strCmPrjId);
            foreach (clsDGRegionFldsEN objInfor2 in arrDGRegionFldsObjLst)
            {
                clsDGRegionFldsEN objInfor2_T = new clsDGRegionFldsEN();
                clsDGRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
            }
            return true;
        }


        public static bool ImportExtendFld(long lngMid, string strPrjId, string strUserId)
        {
            //JumpOtherPages("CheckConsistency");
            var objDGRegionFlds = clsDGRegionFldsBLEx.GetObjExBymIdCache(lngMid, strPrjId);

            if (objDGRegionFlds.IsUseFunc() == false)
            {
                string strMsg = string.Format("当前区域字段:[{0}]没有使用扩展字段功能，不需要导入到表中！(in {1})", lngMid, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            };

            if (string.IsNullOrEmpty(objDGRegionFlds.DataPropertyName()) == true) return false;
            return true;
            //var objDataNode = clsDataNodeBL.GetObjByDataNodeIdCache(objDGRegionFlds.OutDataNodeId, strCmPrjId);
            //if (objDataNode == null) return false;
            //return clsPubRegionFldsBLEx.AddExtendClassToPrjTabFld(objDataNode, objViewRegion, objDGRegionFlds.DataPropertyName, objDGRegionFlds.HeaderText, objDGRegionFlds.DnPathId, strUserId);

        }
        public static int GetRecCount4InUseCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId && x.InUse == true)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrDGRegionFldsObjLst_Sel.Count;
        }


        public static int GetRecCountCache1(string lngRegionId, string strPrjId)
        {
            //初始化列表缓存
            List<clsDGRegionFldsEN> arrObjLstCache = clsDGRegionFldsBL.GetObjLstCache(strPrjId);

            List<clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
                    arrObjLstCache.Where(x => x.RegionId == lngRegionId)
                    .OrderBy(x => x.SeqNum).ToList();
            return arrDGRegionFldsObjLst_Sel.Count;
        }
        public static bool SetCmPrjId1(string strRegionId, string strPrjId, string strUserId)
        {

            try
            {
                List<clsDGRegionFldsEN> arrDGRegionFlds = clsDGRegionFldsBLEx.GetObjLstByRegionIdEx(strRegionId);

                foreach (var objInFor in arrDGRegionFlds)
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
        //    string strCondition = string.Format("{0}='{1}'", conDGRegionFlds.DnPathId, strDnPathId);
        //    var objPrjTabFld = GetFirstObj_S(strCondition);
        //    if (objPrjTabFld == null) return "";
        //    return objPrjTabFld.RegionId;
        //}

        //public static clsDGRegionFldsEN GetObjByDnPathId(string strDnPathId)
        //{
        //    string strCondition = string.Format("{0}='{1}'", conDGRegionFlds.DnPathId, strDnPathId);
        //    var objDGRegionFlds = GetFirstObj_S(strCondition);
        //    if (objDGRegionFlds == null) return null;
        //    return objDGRegionFlds;
        //}
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDGRegionFldsENS">源对象</param>
        /// <returns>目标对象=>clsDGRegionFldsEN:objDGRegionFldsENT</returns>
        public static clsDGRegionFldsENEx CopyToEx(clsDGRegionFldsEN objDGRegionFldsENS)
        {
            try
            {
                clsDGRegionFldsENEx objDGRegionFldsENT = new clsDGRegionFldsENEx();
                clsDGRegionFldsBL.DGRegionFldsDA.CopyTo(objDGRegionFldsENS, objDGRegionFldsENT);
                return objDGRegionFldsENT;
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
