using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using AGC.DAL;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsEditRegionBLEx 
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
        //    if (clsEditRegionBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsEditRegionBL没有刷新缓存机制(clsEditRegionBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjId_Cache_Init != strPrjId) arrEditRegionObjLst_Cache = null;
        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by RegionId");
        //    if (arrEditRegionObjLst_Cache == null)
        //    {
        //        string strWhereCond = string.Format("{0} in (select {0} From {1} where {2} = '{3}') order by RegionId",
        //              clsEditRegionEN.con_RegionId, clsvViewRegionEN._CurrTabName_S, clsvViewRegionEN.con_PrjId, strPrjId);

        //        arrEditRegionObjLst_Cache = new clsEditRegionDA().GetObjLst(strWhereCond);
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
        //public static clsEditRegionEN GetObjByRegionId_CacheEx(string lngRegionId, string strPrjId)
        //{
        //    //初始化列表缓存
        //    List<clsEditRegionEN> arrObjLst_Cache = clsEditRegionBL.GetObjLst_Cache(strPrjId);


        //    IEnumerable<clsEditRegionEN> arrEditRegionObjLst_Sel1 =
        //    from objEditRegionEN in arrObjLst_Cache
        //    where objEditRegionEN.RegionId == lngRegionId
        //    select objEditRegionEN;
        //    List<clsEditRegionEN> arrEditRegionObjLst_Sel = new List<clsEditRegionEN>();
        //    foreach (clsEditRegionEN obj in arrEditRegionObjLst_Sel1)
        //    {
        //        arrEditRegionObjLst_Sel.Add(obj);
        //    }
        //    if (arrEditRegionObjLst_Sel.Count == 0)
        //    {
        //        return null;
        //    }
        //    return arrEditRegionObjLst_Sel[0];
        //}

        //public static void GetEditRegionEx(ref clsEditRegionENEx objEditRegionENEx, string strPrjId)
        //{
        //    //clsEditRegionDAEx objEditRegionDA = new clsEditRegionDAEx();
        //    //bool bolResult = objEditRegionDA.GetEditRegionEx(ref objEditRegionEN);
        //    //return bolResult;

        //    clsEditRegionEN objEditRegionEN = GetObjByRegionId_CacheEx(objEditRegionENEx.RegionId, strPrjId);
        //     clsEditRegionBL.CopyTo(objEditRegionEN, objEditRegionENEx);
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

        //    List<clsEditRegionEN> arrEditRegionENObjLst = clsEditRegionBL.GetObjLst(strCondition);

        //    foreach (clsEditRegionEN objEditRegionEN4Web in arrEditRegionENObjLst)
        //    {

        //        objEditRegionEN4Web.IsSynchToServer = true;
        //        objEditRegionEN4Web.SynchToServerDate = strCurrDate14;
        //        objEditRegionEN4Web.SynchToServerUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        try
        //        {
        //            clsEditRegionEN objEditRegionEN4Web2 = new clsEditRegionEN();
        //            clsEditRegionBL.CopyTo(objEditRegionEN4Web, objEditRegionEN4Web2);
        //            objEditRegionEN4Web2.SynSource = "Client";
        //            clsEditRegionEN objEditRegion_Target = clsEditRegionBL.GetObjByRegionId(objEditRegionEN4Web.RegionId);

        //            if (objEditRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objEditRegion_Target.UpdDate.CompareTo(objEditRegionEN4Web.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsEditRegionBL.UpdateBySql2(objEditRegionEN4Web2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsEditRegionBL.AddNewRecordBySql2(objEditRegionEN4Web2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //            clsEditRegionBL.UpdateBySql2(objEditRegionEN4Web);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Main库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objEditRegionEN4Web.RegionId,
        //                        objEditRegionEN4Web.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
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

        //    List<clsEditRegionEN> arrEditRegionENObjLst = clsEditRegionBL.GetObjLst(strCondition);

        //    foreach (clsEditRegionEN objEditRegionEN4Main in arrEditRegionENObjLst)
        //    {

        //        objEditRegionEN4Main.IsSynchToClient = true;
        //        objEditRegionEN4Main.SynchToClientDate = strCurrDate14;
        //        objEditRegionEN4Main.SynchToClientUser = strUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringWeb";
        //        try
        //        {
        //            clsEditRegionEN objEditRegionEN4Main2 = new clsEditRegionEN();
        //            clsEditRegionBL.CopyTo(objEditRegionEN4Main, objEditRegionEN4Main2);
        //            objEditRegionEN4Main2.SynSource = "Server";
        //            clsEditRegionEN objEditRegion_Target = clsEditRegionBL.GetObjByRegionId(objEditRegionEN4Main.RegionId);

        //            if (objEditRegion_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objEditRegion_Target.UpdDate.CompareTo(objEditRegionEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    clsEditRegionBL.UpdateBySql2(objEditRegionEN4Main2);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                clsEditRegionBL.AddNewRecordBySql2(objEditRegionEN4Main2);
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            clsEditRegionBL.UpdateBySql2(objEditRegionEN4Main);
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Web库，工程表：{0}({1})时出错。({3}).[上级抛错:{2}]", objEditRegionEN4Main.RegionId,
        //                        objEditRegionEN4Main.RegionId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


      
    }
}