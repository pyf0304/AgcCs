using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
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
    public partial class clsDGRegionBLEx
    {
        public static string strPrjId_Cache_Init = "";

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsDGRegionBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsDGRegionBL没有刷新缓存机制(clsDGRegionBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjId_Cache_Init != strPrjId) arrDGRegionObjLst_Cache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by RegionId");
        //    if (arrDGRegionObjLst_Cache == null)
        //    {
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by RegionId",
        //               clsDGRegionEN.con_RegionId, clsvViewRegionEN._CurrTabName_S, clsvViewRegionEN.con_PrjId, strPrjId);
        //        arrDGRegionObjLst_Cache = new clsDGRegionDA().GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjId_Cache_Init={1}.({4}->{3}->{2})",
        //          strPrjId, strPrjId_Cache_Init,
        //          clsStackTrace.GetCurrClassFunction(),
        //          clsStackTrace.GetCurrClassFunctionByLevel(2),
        //          clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjId_Cache_Init = strPrjId;
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsDGRegionEN GetObjByRegionId_CacheEx(string lngRegionId, string strPrjId)
        //{
        //    //初始化列表缓存
        //    //InitListCache(strPrjId);
        //    List<clsDGRegionEN> arrObjLst_Cache = clsDGRegionBL.GetObjLst_Cache(strPrjId);

        //    IEnumerable<clsDGRegionEN> arrDGRegionObjLst_Sel1 =
        //    from objDGRegionEN in arrObjLst_Cache
        //    where objDGRegionEN.RegionId == lngRegionId
        //    select objDGRegionEN;
        //    List<clsDGRegionEN> arrDGRegionObjLst_Sel = new List<clsDGRegionEN>();
        //    foreach (clsDGRegionEN obj in arrDGRegionObjLst_Sel1)
        //    {
        //        arrDGRegionObjLst_Sel.Add(obj);
        //    }
        //    if (arrDGRegionObjLst_Sel.Count == 0)
        //    {
        //        return null;
        //    }
        //    return arrDGRegionObjLst_Sel[0];
        //}

    
        
        //public static void GetDGRegionEx(ref clsDGRegionENEx objDGRegionENExEN, string strPrjId)
        //{
        //    //clsDGRegionDAEx objDGRegionENExDA = new clsDGRegionDAEx();
        //    clsDGRegionEN objDGRegionEN = GetObjByRegionId_CacheEx(objDGRegionENExEN.RegionId, strPrjId);
        //     clsDGRegionBL.CopyTo(objDGRegionEN, objDGRegionENExEN);
        //    //bool bolResult = objDGRegionENExDA.GetDGRegionEx(ref objDGRegionENExEN);
        //    //return bolResult;
        //}


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

        //    List<clsDGRegionEN> arrDGRegionENObjLst = clsDGRegionBL.GetObjLst(strCondition);

        //    foreach (clsDGRegionEN objDGRegionEN4Web in arrDGRegionENObjLst)
        //    {

        //        objDGRegionEN4Web.IsSynchToServer = true;
        //        objDGRegionEN4Web.SynchToServerDate = strCurrDate14;
        //        objDGRegionEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsDGRegionEN objDGRegionEN4Web2 = new clsDGRegionEN();
        //            clsDGRegionBL.CopyTo(objDGRegionEN4Web, objDGRegionEN4Web2);
        //            objDGRegionEN4Web2.SynSource = "Client";
        //            clsDGRegionEN objDGRegion_Target = clsDGRegionBL.GetObjByRegionId(objDGRegionEN4Web.RegionId);

        //            if (objDGRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDGRegion_Target.UpdDate.CompareTo(objDGRegionEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsDGRegionBL.UpdateBySql2(objDGRegionEN4Web2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDGRegionBL.AddNewRecordBySql2(objDGRegionEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsDGRegionBL.UpdateBySql2(objDGRegionEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDGRegionEN4Web.RegionId,
        //                        objDGRegionEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
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

        //    List<clsDGRegionEN> arrDGRegionENObjLst = clsDGRegionBL.GetObjLst(strCondition);

        //    foreach (clsDGRegionEN objDGRegionEN4Main in arrDGRegionENObjLst)
        //    {

        //        objDGRegionEN4Main.IsSynchToClient = true;
        //        objDGRegionEN4Main.SynchToClientDate = strCurrDate14;
        //        objDGRegionEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsDGRegionEN objDGRegionEN4Main2 = new clsDGRegionEN();
        //            clsDGRegionBL.CopyTo(objDGRegionEN4Main, objDGRegionEN4Main2);
        //            objDGRegionEN4Main2.SynSource = "Server";
        //            clsDGRegionEN objDGRegion_Target = clsDGRegionBL.GetObjByRegionId(objDGRegionEN4Main.RegionId);

        //            if (objDGRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objDGRegion_Target.UpdDate.CompareTo(objDGRegionEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsDGRegionBL.UpdateBySql2(objDGRegionEN4Main2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsDGRegionBL.AddNewRecordBySql2(objDGRegionEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsDGRegionBL.UpdateBySql2(objDGRegionEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objDGRegionEN4Main.RegionId,
        //                        objDGRegionEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

     
    }
}
